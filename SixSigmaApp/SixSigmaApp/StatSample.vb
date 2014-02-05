Public Class StatSample
    ' This object aims to represent the relevant
    ' quantities in a statistical sample without bogging
    ' them down with a list of entries.
    Private _sampleSize As Long
    Private _stringMean As String
    Private _sumOfSquares As Double
    Private _mean As Double
    Private _meanOfSquares As Double
    Private _sixSigma As Double
    Private _stringSixSigma As String
    Private _sampleValues As List(Of Double) = New List(Of Double)

    ''' <summary>
    ''' Returns the number of elements in the current sample.
    ''' </summary>
    ''' <value>This is the number of elements that have been added to the statistical sample in a string that's safe to display in a text box.</value>
    ''' <returns>Number of elements in the current sample.</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SampleSize

        Get
            SampleSize = CStr(_sampleSize)
        End Get

    End Property

    ''' <summary>
    ''' Returns the current six sigma span (twelve standard deviations) if applicable.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SixSigma
        Get

            If (_sampleSize > 2) Then
                SixSigma = _sixSigma
            Else
                SixSigma = 0.0
            End If

        End Get
    End Property

    ''' <summary>
    ''' Returns the six sigma range (12 standard deviations,) across n-1, in a string that may be displayed in a text box.
    ''' </summary>
    ''' <value>This returns the six sigma range (12 standard deviations,) across n-1, in a string that may be displayed in a text box.</value>
    ''' <returns>Six sigma range, or "N/A" if no such range exists.</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property StringSixSigma

        Get
            StringSixSigma = _stringSixSigma
        End Get

    End Property

    ''' <summary>
    ''' Returns the mean of the sample as a double (returns 0 if the sample is empty.)
    ''' </summary>
    ''' <value>Average of the sample if applicable.</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Mean
        Get
            If _sampleSize > 0 Then
                Mean = _mean
            Else
                Mean = 0.0
            End If
        End Get
    End Property

    ''' <summary>
    ''' Returns the sample mean as a string that may be displayed in a text box
    ''' </summary>
    ''' <value>Returns the sample mean as a string that may be displayed in a text box.</value>
    ''' <returns>The sample mean, or N/A if no mean has been defined.</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property StringMean

        Get
            StringMean = _stringMean
        End Get

    End Property

    ''' <summary>
    ''' Updates the statistical sample with the given data point.
    ''' </summary>
    ''' <param name="DataPoint">Value added to the statistical sample.</param>
    ''' <remarks>Consuming code is responsible for error handling and validation.</remarks>
    Public Sub AddValue(ByVal DataPoint As Double)

        Dim sum As Double
        Dim dSampleSize As Double

        _sampleValues.Add(DataPoint)
        dSampleSize = CDbl(_sampleSize)

        sum = (_mean * dSampleSize) + DataPoint
        _sumOfSquares += (DataPoint * DataPoint)
        _sampleSize += 1
        dSampleSize = CDbl(_sampleSize)
        _mean = sum / dSampleSize
        _stringMean = smartFormat(_mean)

        Call updateSampleSpecificFields()

    End Sub
    ''' <summary>
    ''' Converts numeric entry into usable string, formatted for significant figures.
    ''' </summary>
    ''' <param name="numericValue">Number to format.</param>
    ''' <returns>Number converted to string and formatted.</returns>
    ''' <remarks></remarks>
    Private Function smartFormat(ByVal numericValue As Double) As String
        If numericValue < 10000.0 Then
            smartFormat = Format$(numericValue, "0.###")
        ElseIf numericValue < 100000.0 Then
            smartFormat = Format$(numericValue, "0.##")
        ElseIf numericValue < 1000000.0 Then
            smartFormat = Format$(numericValue, "0.#")
        Else
            smartFormat = CStr(numericValue)
        End If
    End Function
    ''' <summary>
    ''' Constructor.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        Call Clear()

    End Sub

    ''' <summary>
    ''' Empties StatSample- sets sample size, mean, and six sigma to null default values.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Clear()

        _sampleValues.Clear()
        _mean = 0.0F
        _stringMean = "N/A"
        _sampleSize = 0
        _sixSigma = 0.0F
        _sumOfSquares = 0.0F
        _stringSixSigma = "N/A"

    End Sub

    ''' <summary>
    ''' Removes a value from the statistical sample.
    ''' </summary>
    ''' <param name="DataPoint">Value to remove.</param>
    ''' <remarks></remarks>
    Public Sub RemoveValue(ByVal DataPoint As Double)

        If Not _sampleValues.Contains(DataPoint) Then
            Return
        End If

        Dim sum As Double
        Dim dSampleSize As Double

        dSampleSize = CDbl(_sampleSize)

        sum = (_mean * dSampleSize) - DataPoint
        _sumOfSquares -= (DataPoint * DataPoint)
        _sampleSize -= 1
        dSampleSize = CDbl(_sampleSize)
        _mean = sum / dSampleSize
        _stringMean = smartFormat(_mean)

        Call updateSampleSpecificFields()

    End Sub
    ''' <summary>
    ''' Sets members in the object when the sample has been updated.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub updateSampleSpecificFields()

        Dim dSampleSize As Double
        dSampleSize = CDbl(_sampleSize)

        If _sampleSize > 1 Then
            _sixSigma = 12 * System.Math.Sqrt(_sumOfSquares / (dSampleSize - 1.0) - (_mean ^ 2) * dSampleSize / (dSampleSize - 1))
            _stringSixSigma = smartFormat(_sixSigma)
        Else
            _stringSixSigma = "N/A"
        End If
    End Sub


End Class

Public Class SixSCalculator

    Private _sample As StatSample
    Private _targetMean As Double
    Private _lastValidTarget As String
    Private _processTolerance As Double
    Private _lastValidTolerance As String

    ''' <summary>
    ''' Instantiates the form as well as the statistical sample.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SixSCalculator_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If _sample Is Nothing Then
            _sample = New StatSample()
        End If

        _lastValidTarget = ""
        _lastValidTolerance = ""

    End Sub

    ''' <summary>
    ''' Clears relevant objects from memory.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SixSCalculator_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        _sample.Clear()
        _sample = Nothing

    End Sub

    ''' <summary>
    ''' Empties the statistical sample.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClearValues_Click(sender As Object, e As EventArgs) Handles btnClearValues.Click

        If MsgBox("Are you sure you want to clear your entries?", vbYesNo, "Reset Data") <> vbYes Then
            Return
        End If

        _sample.Clear()
        cboEnteredList.Items.Clear()
        ' Resets the length of the list
        cboEnteredList.Items.Add("foo")
        cboEnteredList.Items.Remove("foo")
        _lastValidTarget = ""
        _lastValidTolerance = ""
        txtProcessTarget.Text = ""
        txtProcessTolerance.Text = ""

        Call refreshControls()

        txtValueToAdd.Select()

    End Sub

    ''' <summary>
    ''' Updates fields with the appropriate values, selects the entry textbox.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub refreshControls()

        txtValueToAdd.Text = ""
        lblCurrMeanDisplay.Text = _sample.StringMean
        lblCurrSixSDisplay.Text = _sample.StringSixSigma
        lblCurrSampleSizeDisplay.Text = _sample.SampleSize
        lblProcessCapabilityField.Text = ""

        If (_sample.SampleSize < 2) Then
            Return
        End If

        ' Cache the mean and six-sigma in local variables
        Dim tempMean As Double = _sample.Mean
        Dim tempSixSigma As Double = _sample.SixSigma / 2.0

        If (_lastValidTarget.Length <> 0 And _lastValidTolerance.Length <> 0) Then

            If ((_targetMean + _processTolerance) <= (tempMean + tempSixSigma)) Then
                lblProcessCapabilityField.Text = "No"
                lblProcessCapabilityField.ForeColor = Color.Red
                Return
            ElseIf ((_targetMean - _processTolerance) >= (tempMean - tempSixSigma)) Then
                lblProcessCapabilityField.Text = "No"
                lblProcessCapabilityField.ForeColor = Color.Red
                Return
            End If

            lblProcessCapabilityField.Text = "Yes"
            lblProcessCapabilityField.ForeColor = lblCurrMeanDisplay.ForeColor
        End If
        Return

    End Sub

    ''' <summary>
    ''' Validation code for the user's entry.
    ''' </summary>
    ''' <param name="userEntry">Value entered by the user for addition to the statistical sample.</param>
    ''' <remarks></remarks>
    Private Sub tryValueAdd(ByVal userEntry As String)

        If Not IsNumeric(userEntry) Then
            Call MsgBox("The value you add must be numeric.", vbOKOnly, "Unable to Add Value")
        Else
            _sample.AddValue(userEntry)
            cboEnteredList.Items.Add(userEntry)
        End If

        Call refreshControls()

        txtValueToAdd.Select()

    End Sub

    ''' <summary>
    ''' Given the user's entry for the process target or process tolerance, validates the entry.
    ''' </summary>
    ''' <param name="valueField">Text box that contians the value.</param>
    ''' <param name="defaultVal">Default string representation of the value.</param>
    ''' <returns>The contents of the textbox if the user's entry is valid, the default value if not.</returns>
    ''' <remarks></remarks>
    Private Function validateMeanOrSigma(ByVal valueField As TextBox, ByVal defaultVal As String) As String

        Dim userEntry As String
        userEntry = valueField.Text

        If (userEntry.Length <> 0) AndAlso Not IsNumeric(userEntry) Then
            Call MsgBox("This value must be numeric.", vbOKOnly, "Unable to Update Value")
            Return defaultVal
        Else
            Return userEntry
        End If

    End Function

    ''' <summary>
    ''' Attempts to add the value in the entry field to the statistical sample.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnUpdateValues_Click(sender As Object, e As EventArgs) Handles btnUpdateValues.Click

        If Len(txtValueToAdd.Text) <> 0 Then
            tryValueAdd(txtValueToAdd.Text)
        End If

    End Sub

    ''' <summary>
    ''' Handles the enter key; allows the user to pass values to the statistical sample by pressing enter.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtValueToAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValueToAdd.KeyDown

        If e.KeyCode = Keys.Enter Then
            tryValueAdd(sender.Text)
        End If

    End Sub

    ''' <summary>
    ''' If a value has been selected from the drop down list, the selected value is removed from the statistical sample.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRemoveOneValue_Click(sender As Object, e As EventArgs) Handles btnRemoveOneValue.Click

        Dim selectedVal As String
        selectedVal = cboEnteredList.Text
        If Len(selectedVal) = 0 Then
            Return
        End If

        Dim killVal As Double
        killVal = CDbl(selectedVal)
        _sample.RemoveValue(killVal)
        cboEnteredList.Items.Remove(selectedVal)

        Call refreshControls()

        txtValueToAdd.Select()

    End Sub

    Private Sub txtProcessTarget_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProcessTarget.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            Call validateTargetMean()
        End If

    End Sub

    ''' <summary>
    ''' Performs validation on the Target Mean field.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtProcessTarget_LostFocus(sender As Object, e As EventArgs) Handles txtProcessTarget.LostFocus
        
        Call validateTargetMean()

    End Sub

    ''' <summary>
    ''' Performs validation on the Tolerance field.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtProcessTolerance_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProcessTolerance.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Call validateProcessTolerance()
        End If
    End Sub

    ''' <summary>
    ''' Performs validation on the Tolerance field.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtProcessTolerance_LostFocus(sender As Object, e As EventArgs) Handles txtProcessTolerance.LostFocus

        Call validateProcessTolerance()

    End Sub

    ''' <summary>
    ''' Performs validation on the Target Mean field.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub validateTargetMean()

        If (txtProcessTarget.Text = _lastValidTarget) Then
            Return
        End If
        _lastValidTarget = validateMeanOrSigma(txtProcessTarget, _lastValidTarget)
        txtProcessTarget.Text = _lastValidTarget
        If (_lastValidTarget.Length <> 0) Then
            _targetMean = CDbl(_lastValidTarget)
        End If

        Call refreshControls()

    End Sub

    ''' <summary>
    ''' Performs validation on the Tolerance field.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub validateProcessTolerance()

        If (txtProcessTolerance.Text = _lastValidTolerance) Then
            Return
        End If
        _lastValidTolerance = validateMeanOrSigma(txtProcessTolerance, _lastValidTolerance)
        txtProcessTolerance.Text = _lastValidTolerance
        If (_lastValidTolerance.Length <> 0) Then
            _processTolerance = CDbl(_lastValidTolerance)
        End If

        Call refreshControls()

    End Sub

End Class

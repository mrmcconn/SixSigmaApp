<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SixSCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtValueToAdd = New System.Windows.Forms.TextBox()
        Me.lblValuePrompt = New System.Windows.Forms.Label()
        Me.lblCurrSixSPrompt = New System.Windows.Forms.Label()
        Me.lblCurrSixSDisplay = New System.Windows.Forms.Label()
        Me.lblCurrMeanPrompt = New System.Windows.Forms.Label()
        Me.lblCurrMeanDisplay = New System.Windows.Forms.Label()
        Me.btnUpdateValues = New System.Windows.Forms.Button()
        Me.btnClearValues = New System.Windows.Forms.Button()
        Me.lblCurrSampleSizeDisplay = New System.Windows.Forms.Label()
        Me.lblSampleSizePrompt = New System.Windows.Forms.Label()
        Me.cboEnteredList = New System.Windows.Forms.ComboBox()
        Me.btnRemoveOneValue = New System.Windows.Forms.Button()
        Me.lblRemoveValue = New System.Windows.Forms.Label()
        Me.lblProcessTargetData = New System.Windows.Forms.Label()
        Me.txtProcessTarget = New System.Windows.Forms.TextBox()
        Me.lblSeparatorLine = New System.Windows.Forms.Label()
        Me.lblTargetMean = New System.Windows.Forms.Label()
        Me.txtProcessTolerance = New System.Windows.Forms.TextBox()
        Me.lblTargetTolerance = New System.Windows.Forms.Label()
        Me.lblProcessCapabilityLabel = New System.Windows.Forms.Label()
        Me.lblProcessCapabilityField = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtValueToAdd
        '
        Me.txtValueToAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValueToAdd.Location = New System.Drawing.Point(324, 17)
        Me.txtValueToAdd.Name = "txtValueToAdd"
        Me.txtValueToAdd.Size = New System.Drawing.Size(150, 44)
        Me.txtValueToAdd.TabIndex = 0
        '
        'lblValuePrompt
        '
        Me.lblValuePrompt.AutoSize = True
        Me.lblValuePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValuePrompt.Location = New System.Drawing.Point(136, 20)
        Me.lblValuePrompt.Name = "lblValuePrompt"
        Me.lblValuePrompt.Size = New System.Drawing.Size(182, 37)
        Me.lblValuePrompt.TabIndex = 1
        Me.lblValuePrompt.Text = "Next Value:"
        '
        'lblCurrSixSPrompt
        '
        Me.lblCurrSixSPrompt.AutoSize = True
        Me.lblCurrSixSPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrSixSPrompt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCurrSixSPrompt.Location = New System.Drawing.Point(33, 334)
        Me.lblCurrSixSPrompt.Name = "lblCurrSixSPrompt"
        Me.lblCurrSixSPrompt.Size = New System.Drawing.Size(285, 37)
        Me.lblCurrSixSPrompt.TabIndex = 2
        Me.lblCurrSixSPrompt.Text = "Current Six Sigma:"
        '
        'lblCurrSixSDisplay
        '
        Me.lblCurrSixSDisplay.AutoSize = True
        Me.lblCurrSixSDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrSixSDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCurrSixSDisplay.Location = New System.Drawing.Point(315, 334)
        Me.lblCurrSixSDisplay.Name = "lblCurrSixSDisplay"
        Me.lblCurrSixSDisplay.Size = New System.Drawing.Size(72, 37)
        Me.lblCurrSixSDisplay.TabIndex = 3
        Me.lblCurrSixSDisplay.Text = "N/A"
        '
        'lblCurrMeanPrompt
        '
        Me.lblCurrMeanPrompt.AutoSize = True
        Me.lblCurrMeanPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrMeanPrompt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCurrMeanPrompt.Location = New System.Drawing.Point(97, 260)
        Me.lblCurrMeanPrompt.Name = "lblCurrMeanPrompt"
        Me.lblCurrMeanPrompt.Size = New System.Drawing.Size(221, 37)
        Me.lblCurrMeanPrompt.TabIndex = 4
        Me.lblCurrMeanPrompt.Text = "Current Mean:"
        '
        'lblCurrMeanDisplay
        '
        Me.lblCurrMeanDisplay.AutoSize = True
        Me.lblCurrMeanDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrMeanDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCurrMeanDisplay.Location = New System.Drawing.Point(315, 260)
        Me.lblCurrMeanDisplay.Name = "lblCurrMeanDisplay"
        Me.lblCurrMeanDisplay.Size = New System.Drawing.Size(72, 37)
        Me.lblCurrMeanDisplay.TabIndex = 5
        Me.lblCurrMeanDisplay.Text = "N/A"
        '
        'btnUpdateValues
        '
        Me.btnUpdateValues.BackColor = System.Drawing.Color.Green
        Me.btnUpdateValues.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateValues.ForeColor = System.Drawing.Color.White
        Me.btnUpdateValues.Location = New System.Drawing.Point(480, 12)
        Me.btnUpdateValues.Name = "btnUpdateValues"
        Me.btnUpdateValues.Size = New System.Drawing.Size(150, 53)
        Me.btnUpdateValues.TabIndex = 1
        Me.btnUpdateValues.Text = "Update"
        Me.btnUpdateValues.UseVisualStyleBackColor = False
        '
        'btnClearValues
        '
        Me.btnClearValues.BackColor = System.Drawing.Color.DimGray
        Me.btnClearValues.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearValues.ForeColor = System.Drawing.Color.White
        Me.btnClearValues.Location = New System.Drawing.Point(480, 260)
        Me.btnClearValues.Name = "btnClearValues"
        Me.btnClearValues.Size = New System.Drawing.Size(150, 148)
        Me.btnClearValues.TabIndex = 7
        Me.btnClearValues.TabStop = False
        Me.btnClearValues.Text = "Reset Data"
        Me.btnClearValues.UseVisualStyleBackColor = False
        '
        'lblCurrSampleSizeDisplay
        '
        Me.lblCurrSampleSizeDisplay.AutoSize = True
        Me.lblCurrSampleSizeDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrSampleSizeDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCurrSampleSizeDisplay.Location = New System.Drawing.Point(315, 297)
        Me.lblCurrSampleSizeDisplay.Name = "lblCurrSampleSizeDisplay"
        Me.lblCurrSampleSizeDisplay.Size = New System.Drawing.Size(35, 37)
        Me.lblCurrSampleSizeDisplay.TabIndex = 9
        Me.lblCurrSampleSizeDisplay.Text = "0"
        '
        'lblSampleSizePrompt
        '
        Me.lblSampleSizePrompt.AutoSize = True
        Me.lblSampleSizePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSampleSizePrompt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSampleSizePrompt.Location = New System.Drawing.Point(114, 297)
        Me.lblSampleSizePrompt.Name = "lblSampleSizePrompt"
        Me.lblSampleSizePrompt.Size = New System.Drawing.Size(204, 37)
        Me.lblSampleSizePrompt.TabIndex = 8
        Me.lblSampleSizePrompt.Text = "Sample Size:"
        '
        'cboEnteredList
        '
        Me.cboEnteredList.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnteredList.FormattingEnabled = True
        Me.cboEnteredList.Location = New System.Drawing.Point(324, 73)
        Me.cboEnteredList.Name = "cboEnteredList"
        Me.cboEnteredList.Size = New System.Drawing.Size(150, 45)
        Me.cboEnteredList.TabIndex = 2
        '
        'btnRemoveOneValue
        '
        Me.btnRemoveOneValue.BackColor = System.Drawing.Color.Maroon
        Me.btnRemoveOneValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveOneValue.ForeColor = System.Drawing.Color.White
        Me.btnRemoveOneValue.Location = New System.Drawing.Point(480, 68)
        Me.btnRemoveOneValue.Name = "btnRemoveOneValue"
        Me.btnRemoveOneValue.Size = New System.Drawing.Size(150, 53)
        Me.btnRemoveOneValue.TabIndex = 3
        Me.btnRemoveOneValue.Text = "Remove"
        Me.btnRemoveOneValue.UseVisualStyleBackColor = False
        '
        'lblRemoveValue
        '
        Me.lblRemoveValue.AutoSize = True
        Me.lblRemoveValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemoveValue.Location = New System.Drawing.Point(55, 76)
        Me.lblRemoveValue.Name = "lblRemoveValue"
        Me.lblRemoveValue.Size = New System.Drawing.Size(263, 37)
        Me.lblRemoveValue.TabIndex = 12
        Me.lblRemoveValue.Text = "Values Thus Far:"
        '
        'lblProcessTargetData
        '
        Me.lblProcessTargetData.AutoSize = True
        Me.lblProcessTargetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessTargetData.Location = New System.Drawing.Point(25, 200)
        Me.lblProcessTargetData.Name = "lblProcessTargetData"
        Me.lblProcessTargetData.Size = New System.Drawing.Size(293, 37)
        Me.lblProcessTargetData.TabIndex = 13
        Me.lblProcessTargetData.Text = "Target Parameters:"
        '
        'txtProcessTarget
        '
        Me.txtProcessTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessTarget.Location = New System.Drawing.Point(324, 197)
        Me.txtProcessTarget.Name = "txtProcessTarget"
        Me.txtProcessTarget.Size = New System.Drawing.Size(150, 44)
        Me.txtProcessTarget.TabIndex = 4
        '
        'lblSeparatorLine
        '
        Me.lblSeparatorLine.AutoSize = True
        Me.lblSeparatorLine.BackColor = System.Drawing.SystemColors.Control
        Me.lblSeparatorLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblSeparatorLine.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSeparatorLine.Location = New System.Drawing.Point(12, 121)
        Me.lblSeparatorLine.Name = "lblSeparatorLine"
        Me.lblSeparatorLine.Size = New System.Drawing.Size(636, 26)
        Me.lblSeparatorLine.TabIndex = 15
        Me.lblSeparatorLine.Text = "____________________________________________________"
        '
        'lblTargetMean
        '
        Me.lblTargetMean.AutoSize = True
        Me.lblTargetMean.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetMean.Location = New System.Drawing.Point(327, 168)
        Me.lblTargetMean.Name = "lblTargetMean"
        Me.lblTargetMean.Size = New System.Drawing.Size(147, 26)
        Me.lblTargetMean.TabIndex = 16
        Me.lblTargetMean.Text = "Target (Mean)"
        '
        'txtProcessTolerance
        '
        Me.txtProcessTolerance.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessTolerance.Location = New System.Drawing.Point(480, 197)
        Me.txtProcessTolerance.Name = "txtProcessTolerance"
        Me.txtProcessTolerance.Size = New System.Drawing.Size(150, 44)
        Me.txtProcessTolerance.TabIndex = 5
        '
        'lblTargetTolerance
        '
        Me.lblTargetTolerance.AutoSize = True
        Me.lblTargetTolerance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetTolerance.Location = New System.Drawing.Point(477, 168)
        Me.lblTargetTolerance.Name = "lblTargetTolerance"
        Me.lblTargetTolerance.Size = New System.Drawing.Size(153, 26)
        Me.lblTargetTolerance.TabIndex = 18
        Me.lblTargetTolerance.Text = "Tolerance (+/-)"
        '
        'lblProcessCapabilityLabel
        '
        Me.lblProcessCapabilityLabel.AutoSize = True
        Me.lblProcessCapabilityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessCapabilityLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProcessCapabilityLabel.Location = New System.Drawing.Point(9, 371)
        Me.lblProcessCapabilityLabel.Name = "lblProcessCapabilityLabel"
        Me.lblProcessCapabilityLabel.Size = New System.Drawing.Size(309, 37)
        Me.lblProcessCapabilityLabel.TabIndex = 19
        Me.lblProcessCapabilityLabel.Text = "Process is Capable?"
        '
        'lblProcessCapabilityField
        '
        Me.lblProcessCapabilityField.AutoSize = True
        Me.lblProcessCapabilityField.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessCapabilityField.Location = New System.Drawing.Point(315, 371)
        Me.lblProcessCapabilityField.Name = "lblProcessCapabilityField"
        Me.lblProcessCapabilityField.Size = New System.Drawing.Size(0, 37)
        Me.lblProcessCapabilityField.TabIndex = 20
        '
        'SixSCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 433)
        Me.Controls.Add(Me.lblProcessCapabilityField)
        Me.Controls.Add(Me.lblProcessCapabilityLabel)
        Me.Controls.Add(Me.lblTargetTolerance)
        Me.Controls.Add(Me.txtProcessTolerance)
        Me.Controls.Add(Me.lblTargetMean)
        Me.Controls.Add(Me.lblSeparatorLine)
        Me.Controls.Add(Me.txtProcessTarget)
        Me.Controls.Add(Me.lblProcessTargetData)
        Me.Controls.Add(Me.lblRemoveValue)
        Me.Controls.Add(Me.btnRemoveOneValue)
        Me.Controls.Add(Me.cboEnteredList)
        Me.Controls.Add(Me.lblCurrSampleSizeDisplay)
        Me.Controls.Add(Me.lblSampleSizePrompt)
        Me.Controls.Add(Me.btnClearValues)
        Me.Controls.Add(Me.btnUpdateValues)
        Me.Controls.Add(Me.lblCurrMeanDisplay)
        Me.Controls.Add(Me.lblCurrMeanPrompt)
        Me.Controls.Add(Me.lblCurrSixSDisplay)
        Me.Controls.Add(Me.lblCurrSixSPrompt)
        Me.Controls.Add(Me.lblValuePrompt)
        Me.Controls.Add(Me.txtValueToAdd)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SixSCalculator"
        Me.Text = "Continuous Six Sigma Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtValueToAdd As System.Windows.Forms.TextBox
    Friend WithEvents lblValuePrompt As System.Windows.Forms.Label
    Friend WithEvents lblCurrSixSPrompt As System.Windows.Forms.Label
    Friend WithEvents lblCurrSixSDisplay As System.Windows.Forms.Label
    Friend WithEvents lblCurrMeanPrompt As System.Windows.Forms.Label
    Friend WithEvents lblCurrMeanDisplay As System.Windows.Forms.Label
    Friend WithEvents btnUpdateValues As System.Windows.Forms.Button
    Friend WithEvents btnClearValues As System.Windows.Forms.Button
    Friend WithEvents lblCurrSampleSizeDisplay As System.Windows.Forms.Label
    Friend WithEvents lblSampleSizePrompt As System.Windows.Forms.Label
    Friend WithEvents cboEnteredList As System.Windows.Forms.ComboBox
    Friend WithEvents btnRemoveOneValue As System.Windows.Forms.Button
    Friend WithEvents lblRemoveValue As System.Windows.Forms.Label
    Friend WithEvents lblProcessTargetData As System.Windows.Forms.Label
    Friend WithEvents txtProcessTarget As System.Windows.Forms.TextBox
    Friend WithEvents lblSeparatorLine As System.Windows.Forms.Label
    Friend WithEvents lblTargetMean As System.Windows.Forms.Label
    Friend WithEvents txtProcessTolerance As System.Windows.Forms.TextBox
    Friend WithEvents lblTargetTolerance As System.Windows.Forms.Label
    Friend WithEvents lblProcessCapabilityLabel As System.Windows.Forms.Label
    Friend WithEvents lblProcessCapabilityField As System.Windows.Forms.Label

End Class

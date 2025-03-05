<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinFormExampleForm
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.FirstLabel = New System.Windows.Forms.Label()
        Me.FirstTextBox = New System.Windows.Forms.TextBox()
        Me.LastTextBox = New System.Windows.Forms.TextBox()
        Me.LastLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.UpperRadioButton = New System.Windows.Forms.RadioButton()
        Me.LowerRadioButton = New System.Windows.Forms.RadioButton()
        Me.LastFirstRadioButton = New System.Windows.Forms.RadioButton()
        Me.FirstLastRadioButton = New System.Windows.Forms.RadioButton()
        Me.CaseGroupBox = New System.Windows.Forms.GroupBox()
        Me.NameFormatGroupBox = New System.Windows.Forms.GroupBox()
        Me.ReverseCheckBox = New System.Windows.Forms.CheckBox()
        Me.WhiteSpaceCheckBox = New System.Windows.Forms.CheckBox()
        Me.RandomCheckBox = New System.Windows.Forms.CheckBox()
        Me.NameFormatGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(395, 224)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(115, 98)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&XIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(274, 224)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(115, 98)
        Me.UpdateButton.TabIndex = 3
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'FirstLabel
        '
        Me.FirstLabel.AutoSize = True
        Me.FirstLabel.Location = New System.Drawing.Point(7, 19)
        Me.FirstLabel.Name = "FirstLabel"
        Me.FirstLabel.Size = New System.Drawing.Size(57, 13)
        Me.FirstLabel.TabIndex = 2
        Me.FirstLabel.Text = "First Name"
        '
        'FirstTextBox
        '
        Me.FirstTextBox.Location = New System.Drawing.Point(70, 12)
        Me.FirstTextBox.Name = "FirstTextBox"
        Me.FirstTextBox.Size = New System.Drawing.Size(149, 20)
        Me.FirstTextBox.TabIndex = 0
        '
        'LastTextBox
        '
        Me.LastTextBox.Location = New System.Drawing.Point(70, 38)
        Me.LastTextBox.Name = "LastTextBox"
        Me.LastTextBox.Size = New System.Drawing.Size(149, 20)
        Me.LastTextBox.TabIndex = 1
        '
        'LastLabel
        '
        Me.LastLabel.AutoSize = True
        Me.LastLabel.Location = New System.Drawing.Point(7, 45)
        Me.LastLabel.Name = "LastLabel"
        Me.LastLabel.Size = New System.Drawing.Size(58, 13)
        Me.LastLabel.TabIndex = 4
        Me.LastLabel.Text = "Last Name"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(70, 64)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(58, 20)
        Me.AgeTextBox.TabIndex = 2
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(38, 71)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(26, 13)
        Me.AgeLabel.TabIndex = 6
        Me.AgeLabel.Text = "Age"
        '
        'UpperRadioButton
        '
        Me.UpperRadioButton.AutoSize = True
        Me.UpperRadioButton.Location = New System.Drawing.Point(70, 108)
        Me.UpperRadioButton.Name = "UpperRadioButton"
        Me.UpperRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.UpperRadioButton.TabIndex = 7
        Me.UpperRadioButton.TabStop = True
        Me.UpperRadioButton.Text = "Upper"
        Me.UpperRadioButton.UseVisualStyleBackColor = True
        '
        'LowerRadioButton
        '
        Me.LowerRadioButton.AutoSize = True
        Me.LowerRadioButton.Location = New System.Drawing.Point(70, 132)
        Me.LowerRadioButton.Name = "LowerRadioButton"
        Me.LowerRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.LowerRadioButton.TabIndex = 8
        Me.LowerRadioButton.TabStop = True
        Me.LowerRadioButton.Text = "Lower"
        Me.LowerRadioButton.UseVisualStyleBackColor = True
        '
        'LastFirstRadioButton
        '
        Me.LastFirstRadioButton.AutoSize = True
        Me.LastFirstRadioButton.Location = New System.Drawing.Point(23, 38)
        Me.LastFirstRadioButton.Name = "LastFirstRadioButton"
        Me.LastFirstRadioButton.Size = New System.Drawing.Size(132, 17)
        Me.LastFirstRadioButton.TabIndex = 10
        Me.LastFirstRadioButton.TabStop = True
        Me.LastFirstRadioButton.Text = "Last Name, First Name"
        Me.LastFirstRadioButton.UseVisualStyleBackColor = True
        '
        'FirstLastRadioButton
        '
        Me.FirstLastRadioButton.AutoSize = True
        Me.FirstLastRadioButton.Location = New System.Drawing.Point(23, 14)
        Me.FirstLastRadioButton.Name = "FirstLastRadioButton"
        Me.FirstLastRadioButton.Size = New System.Drawing.Size(132, 17)
        Me.FirstLastRadioButton.TabIndex = 9
        Me.FirstLastRadioButton.TabStop = True
        Me.FirstLastRadioButton.Text = "First Name, Last Name"
        Me.FirstLastRadioButton.UseVisualStyleBackColor = True
        '
        'CaseGroupBox
        '
        Me.CaseGroupBox.Location = New System.Drawing.Point(41, 94)
        Me.CaseGroupBox.Name = "CaseGroupBox"
        Me.CaseGroupBox.Size = New System.Drawing.Size(87, 70)
        Me.CaseGroupBox.TabIndex = 11
        Me.CaseGroupBox.TabStop = False
        Me.CaseGroupBox.Text = "Case"
        '
        'NameFormatGroupBox
        '
        Me.NameFormatGroupBox.Controls.Add(Me.LastFirstRadioButton)
        Me.NameFormatGroupBox.Controls.Add(Me.FirstLastRadioButton)
        Me.NameFormatGroupBox.Location = New System.Drawing.Point(134, 94)
        Me.NameFormatGroupBox.Name = "NameFormatGroupBox"
        Me.NameFormatGroupBox.Size = New System.Drawing.Size(166, 70)
        Me.NameFormatGroupBox.TabIndex = 0
        Me.NameFormatGroupBox.TabStop = False
        Me.NameFormatGroupBox.Text = "Name Format"
        '
        'ReverseCheckBox
        '
        Me.ReverseCheckBox.AutoSize = True
        Me.ReverseCheckBox.Location = New System.Drawing.Point(70, 181)
        Me.ReverseCheckBox.Name = "ReverseCheckBox"
        Me.ReverseCheckBox.Size = New System.Drawing.Size(66, 17)
        Me.ReverseCheckBox.TabIndex = 12
        Me.ReverseCheckBox.Text = "Reverse"
        Me.ReverseCheckBox.UseVisualStyleBackColor = True
        '
        'WhiteSpaceCheckBox
        '
        Me.WhiteSpaceCheckBox.AutoSize = True
        Me.WhiteSpaceCheckBox.Location = New System.Drawing.Point(70, 204)
        Me.WhiteSpaceCheckBox.Name = "WhiteSpaceCheckBox"
        Me.WhiteSpaceCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.WhiteSpaceCheckBox.TabIndex = 13
        Me.WhiteSpaceCheckBox.Text = "White Space"
        Me.WhiteSpaceCheckBox.UseVisualStyleBackColor = True
        '
        'RandomCheckBox
        '
        Me.RandomCheckBox.AutoSize = True
        Me.RandomCheckBox.Location = New System.Drawing.Point(70, 227)
        Me.RandomCheckBox.Name = "RandomCheckBox"
        Me.RandomCheckBox.Size = New System.Drawing.Size(66, 17)
        Me.RandomCheckBox.TabIndex = 14
        Me.RandomCheckBox.Text = "Random"
        Me.RandomCheckBox.UseVisualStyleBackColor = True
        '
        'WinFormExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 334)
        Me.Controls.Add(Me.RandomCheckBox)
        Me.Controls.Add(Me.WhiteSpaceCheckBox)
        Me.Controls.Add(Me.ReverseCheckBox)
        Me.Controls.Add(Me.LowerRadioButton)
        Me.Controls.Add(Me.UpperRadioButton)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.LastTextBox)
        Me.Controls.Add(Me.LastLabel)
        Me.Controls.Add(Me.FirstTextBox)
        Me.Controls.Add(Me.FirstLabel)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.NameFormatGroupBox)
        Me.Controls.Add(Me.CaseGroupBox)
        Me.Name = "WinFormExampleForm"
        Me.Text = "Windows Form Example"
        Me.NameFormatGroupBox.ResumeLayout(False)
        Me.NameFormatGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents FirstLabel As Label
    Friend WithEvents FirstTextBox As TextBox
    Friend WithEvents LastTextBox As TextBox
    Friend WithEvents LastLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents UpperRadioButton As RadioButton
    Friend WithEvents LowerRadioButton As RadioButton
    Friend WithEvents LastFirstRadioButton As RadioButton
    Friend WithEvents FirstLastRadioButton As RadioButton
    Friend WithEvents CaseGroupBox As GroupBox
    Friend WithEvents NameFormatGroupBox As GroupBox
    Friend WithEvents ReverseCheckBox As CheckBox
    Friend WithEvents WhiteSpaceCheckBox As CheckBox
    Friend WithEvents RandomCheckBox As CheckBox
End Class

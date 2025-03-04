'Alexis Villagran

Option Strict On
Option Explicit On
Option Compare Binary

Public Class WinFormExampleForm
    Sub SetDefault()
        FirstTextBox.Text = " "
        LastTextBox.Text = " "
        AgeTextBox.Text = " "
        UpperRadioButton.Checked = True
        FirstLastRadioButton.Checked = True
    End Sub

    Sub SetCase()
        If UpperRadioButton.Checked = True Then
            Me.Text = UCase(FirstTextBox.Text & " " & LastTextBox.Text)


        ElseIf LowerRadioButton.Checked = True Then
            Me.Text = LCase(FirstTextBox.Text & " " & LastTextBox.Text)

        Else
            MsgBox($"YOU DIDN'T SELECT A CASE!")

        End If
    End Sub

    Sub SetFormat()
        If FirstLastRadioButton.Checked = True Then
            Me.Text = FirstTextBox.Text & " " & LastTextBox.Text

        ElseIf LastFirstRadioButton.Checked = True Then
            Me.Text = $"{LastTextBox.Text}, {FirstTextBox.Text}"

        Else
            MsgBox($"YOU DIDN'T SELECT A FORMAT!")

        End If
    End Sub

    'Event Handlers**************************************************************************88
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'Me.Text = "hello world"
        'Me.Text = StrReverse(Me.Text)

        SetCase()
        SetFormat()
        SetDefault()

    End Sub
    Private Sub WinFormExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefault()
    End Sub
End Class

'Alexis Villagran

Option Strict On
Option Explicit On
Option Compare Binary

Public Class WinFormExampleForm
    Sub clear()
        FirstTextBox.Text = " "
        LastTextBox.Text = " "
        AgeTextBox.Text = " "
    End Sub

    'Event Handlers**************************************************************************88
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'Me.Text = "hello world"
        'Me.Text = StrReverse(Me.Text)

        Me.Text = FirstTextBox.Text & " " & LastTextBox.Text
        clear()
    End Sub

End Class

'Alexis Villagran

Option Strict On
Option Explicit On
Option Compare Binary

Public Class WinFormExampleForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Me.Text = "hello world"
        'Me.Text = StrReverse(Me.Text)
    End Sub
End Class

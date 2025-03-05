Option Strict On
Option Explicit On
Option Compare Binary
'Alexis Villagran

Imports Microsoft.Win32.SafeHandles

Public Class WinFormExampleForm
    Sub SetDefault()
        FirstTextBox.Text = ""
        LastTextBox.Text = ""
        AgeTextBox.Text = ""
        UpperRadioButton.Checked = True
        FirstLastRadioButton.Checked = True
        ReverseCheckBox.Checked = False
        WhiteSpaceCheckBox.Checked = False
        RandomCheckBox.Checked = False
        FirstTextBox.Focus()
    End Sub

    Sub SetCase()
        If UpperRadioButton.Checked = True Then
            FirstTextBox.Text = UCase(FirstTextBox.Text)
            LastTextBox.Text = UCase(LastTextBox.Text)


        ElseIf LowerRadioButton.Checked = True Then
            FirstTextBox.Text = LCase(FirstTextBox.Text)
            LastTextBox.Text = LCase(LastTextBox.Text)

        Else
            MsgBox($"YOU DIDN'T SELECT A CASE!")

        End If
    End Sub

    Sub SetFormat()
        If FirstLastRadioButton.Checked = True Then
            Me.Text = FirstTextBox.Text & " ," & LastTextBox.Text

        ElseIf LastFirstRadioButton.Checked = True Then
            Me.Text = $"{LastTextBox.Text}, {FirstTextBox.Text}"

        Else
            MsgBox($"YOU DIDN'T SELECT A FORMAT!")

        End If
    End Sub

    Sub ReverseString()
        If ReverseCheckBox.Checked Then
            Me.Text = StrReverse(Me.Text)
        End If
    End Sub

    Sub WhiteSpace()
        If WhiteSpaceCheckBox.Checked Then
            Me.Text = Replace(Me.Text, " ", " ")
        End If
    End Sub

    Function UserInputValid() As Boolean
        Dim valid As Boolean = True
        Dim message As String

        If IsNumeric(AgeTextBox.Text) = False Then
            valid = False
            AgeTextBox.Focus()
            message &= "Please enter a valid age." & vbNewLine
        End If

        If LastTextBox.Text = "" Then
            valid = False
            LastTextBox.Focus()
            message &= "Last name is required." & vbNewLine
        End If

        If FirstTextBox.Text = "" Then
            valid = False
            FirstTextBox.Focus()
            message &= "First name is required." & vbNewLine
        End If

        If Not valid Then
            MsgBox(message, MsgBoxStyle.Critical, "User Input Fail!")
        End If

        Return valid
    End Function

    'Event Handlers**************************************************************************88
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'Me.Text = "hello world"

        If UserInputValid() Then

            SetCase()
            SetFormat()
            ReverseString()
            WhiteSpace()
            SetDefault()

        End If
    End Sub
    Private Sub WinFormExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefault()
    End Sub
End Class

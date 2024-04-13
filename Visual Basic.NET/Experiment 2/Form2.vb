Imports System.Drawing.Imaging

Public Class Form2
    ' Program 2: Determine whether an inputted integer number is prime or not

    Private Sub button_exit_Click(sender As Object, e As EventArgs) Handles button_exit.Click
        Application.Exit()
    End Sub

    Private Sub button_back_Click(sender As Object, e As EventArgs) Handles button_back.Click
        Form1.Show()
        Hide()
    End Sub

    Private Sub button_prime_Click(sender As Object, e As EventArgs) Handles button_prime.Click
        Dim a As Integer = Convert.ToInt32(textbox_num.Text)
        If a = 1 Then
            MessageBox.Show(a.ToString() + " is not a prime number nor a composite number")
            Return
        End If
        Dim i As Integer = 2
        Dim prime As Boolean = True
        While i <= (a - 1)
            If (a Mod i = 0) Then
                prime = False
            End If
            i += 1
        End While
        If prime = False Then
            MessageBox.Show("Number is not prime")
        Else
            MessageBox.Show("Number is prime")
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New ToolTip()
        t.SetToolTip(button_back, "Click here to go back")
        t.SetToolTip(button_prime, "Click here to check whether number is prime or not")
        t.SetToolTip(button_exit, "Click here to exit")
    End Sub
End Class
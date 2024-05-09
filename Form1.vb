Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New ToolTip()
        t.SetToolTip(button_showprime, "Click here to add prime numbers between 1 and 100")
        t.SetToolTip(button_exit, "Click here to exit the application")
        t.SetToolTip(button_continue, "Click here to move ahead....")
        t.SetToolTip(button_reset, "Click here to reset the listbox")
    End Sub

    Private Sub button_exit_Click(sender As Object, e As EventArgs) Handles button_exit.Click
        Application.Exit()
    End Sub

    Private Sub button_showprime_Click(sender As Object, e As EventArgs) Handles button_showprime.Click
        For i = 1 To 100 Step 1
            If i = 2 Or i = 3 Then
                Listbox_primenum.Items.Add(i)
                Continue For
            ElseIf i = 1 Then
                Continue For
            End If
            Dim j As Integer = 2
            While j <= Math.Floor(Math.Sqrt(i))
                If i Mod j = 0 Then
                    Continue For
                End If
                j += 1
            End While
            Listbox_primenum.Items.Add(i)
        Next
    End Sub

    Private Sub button_continue_Click(sender As Object, e As EventArgs) Handles button_continue.Click
        Dim f As New Form2()
        Hide()
        f.Show()
    End Sub

    Private Sub button_reset_Click(sender As Object, e As EventArgs) Handles button_reset.Click
        Listbox_primenum.Items.Clear()
        Listbox_primenum.Focus()
        Listbox_primenum.Items.Add("The prime numbers between 1 and 100 are shown as:-")
    End Sub
End Class

Public Class Form1
    Private Sub button_hello_Click(sender As Object, e As EventArgs) Handles button_hello.Click
        textbox_hello.Text = "Hello World!"
    End Sub

    Private Sub button_next_Click(sender As Object, e As EventArgs) Handles button_next.Click
        Dim f As New Form2()
        Hide()
        f.Show()
    End Sub
End Class

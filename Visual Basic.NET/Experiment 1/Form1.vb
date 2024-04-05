Public Class Form1
    Dim name_p As String = "Pranav"
    Dim num As Integer = 516403221

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textbox_input.TextChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles multiline_input.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label_name.Text = "Label Name:-"
        MessageBox.Show("Hello! " + name_p + " Your Enrollment number is " + num.ToString())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If textbox_input.Text = "1" Then
            Label_name.Text = "Message created!"
        End If
        If textbox_input.Text = "2" Then
            Label_name.Text = "Message again created!"
        End If
    End Sub
End Class

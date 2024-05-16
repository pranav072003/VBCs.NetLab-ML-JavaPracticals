Public Class Form3
    Private Sub button_zerodiv_Click(sender As Object, e As EventArgs) Handles button_zerodiv.Click
        Dim b As Integer = 0
        Try
            Dim a As Integer = Convert.ToInt32(textbox_num.Text)
            Dim c As Integer = a / b
            MessageBox.Show(c)
        Catch ex As FormatException
            MessageBox.Show("Format Exception raised!")
        Catch ex As OverflowException
            MessageBox.Show("Zero Division error!")
        Catch ex As ArithmeticException
            MessageBox.Show("Arithmetic exception raised!")
        Finally
            MessageBox.Show("Code ended!")
        End Try
    End Sub

    Private Sub button_next_Click(sender As Object, e As EventArgs) Handles button_next.Click
        Dim f As New Form4()
        Hide()
        f.Show()
    End Sub
End Class
Public Class Form1
    Private Sub button_reset_Click(sender As Object, e As EventArgs) Handles button_reset.Click
        listbox_result.Items.Clear()
        textbox_num.Clear()
        textbox_num.Focus()
        textbox_num.ForeColor = Color.Black
    End Sub

    Private Sub button_exit_Click(sender As Object, e As EventArgs) Handles button_exit.Click
        Environment.Exit(0)
    End Sub

    Private Sub button_fact_Click(sender As Object, e As EventArgs) Handles button_fact.Click
        listbox_result.Items.Clear()
        textbox_num.ForeColor = Color.Black
        Try
            Dim a As Double = Convert.ToDouble(textbox_num.Text)
            Dim factorial As Long = 1
            Dim i As Double = 1
            While i <= a
                factorial *= i
                i += 1
            End While
            listbox_result.Items.Add("Your factorial result is:- " + factorial.ToString())
        Catch ex As FormatException
            textbox_num.Text = "Invalid Input! Please try again"
            textbox_num.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub button_continue_Click(sender As Object, e As EventArgs) Handles button_continue.Click
        Dim f As Form2 = New Form2()
        f.Show()
        Hide()
    End Sub
End Class

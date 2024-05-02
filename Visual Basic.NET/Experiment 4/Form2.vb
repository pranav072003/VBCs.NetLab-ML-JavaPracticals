Public Class Form2
    Private Sub button_reset_Click(sender As Object, e As EventArgs) Handles button_reset.Click
        listbox_result.Items.Clear()
        textbox_radius.Clear()
        textbox_radius.Focus()
        textbox_height.Clear()
        textbox_height.Focus()
    End Sub

    Private Sub button_back_Click(sender As Object, e As EventArgs) Handles button_back.Click
        Dim f As New Form1()
        f.Show()
        Hide()
    End Sub

    Private Sub button_exit_Click(sender As Object, e As EventArgs) Handles button_exit.Click
        Application.Exit()
    End Sub

    Private Sub button_area_Click(sender As Object, e As EventArgs) Handles button_area.Click
        listbox_result.Items.Clear()
        Try
            If RadioButton_circle.Checked Then
                Dim r As Double = Convert.ToDouble(textbox_radius.Text)
                Dim ar As Double = Math.PI * Math.Pow(r, 2)
                listbox_result.Items.Add("Area of circle is:- " + ar.ToString() + " sq units")
            ElseIf RadioButton_cylinder.Checked Then
                Dim r As Double = Convert.ToDouble(textbox_radius.Text)
                Dim h As Double = Convert.ToDouble(textbox_height.Text)
                Dim ar As Double = 2 * Math.PI * r * h
                listbox_result.Items.Add("Area of cylinder is:- " + ar.ToString() + " sq units")
            Else
                Throw New Exception()
            End If
        Catch ex As Exception
            listbox_result.Items.Add("Invalid inputs or parse error!")
        End Try
    End Sub
End Class
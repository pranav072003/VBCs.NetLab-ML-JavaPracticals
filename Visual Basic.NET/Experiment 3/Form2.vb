Public Class Form2
    Private Sub button_back_Click(sender As Object, e As EventArgs) Handles button_back.Click
        Dim f As New Form1
        Hide()
        f.Show()
    End Sub

    Private Sub button_calculatesi_Click(sender As Object, e As EventArgs) Handles button_calculatesi.Click
        If textbox_principal.Text.Length = 0 Or textbox_rate.Text.Length = 0 Or textbox_timeperiod.Text.Length = 0 Then
            ' return with error
            MessageBox.Show("Missing inputs....")
            Return
        End If
        Dim principal As Double = Convert.ToDouble(textbox_principal.Text)
        Dim rate As Double = Convert.ToDouble(textbox_rate.Text)
        Dim time As Double = Convert.ToDouble(textbox_timeperiod.Text)

        Try
            Dim si As Double = (principal * rate * time) / 100
            textbox_si.Text = "Rs " + si.ToString()
        Catch ex As OverflowException
            MessageBox.Show("Overflow Exception")
        End Try
    End Sub
End Class
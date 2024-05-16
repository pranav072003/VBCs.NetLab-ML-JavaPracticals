Public Class Form2
    Dim arr As Integer() = {3, 7, 2, 9, 11}

    Private Sub button_largest_Click(sender As Object, e As EventArgs) Handles button_largest.Click
        Dim a As Integer
        a = arr(0)
        For i = 1 To (arr.Length - 1)
            If arr(i) > a Then
                a = arr(i)
            End If
        Next
        MessageBox.Show("Largest number of array is:- " + a.ToString())
    End Sub

    Private Sub button_next_Click(sender As Object, e As EventArgs) Handles button_next.Click
        Dim f As New Form3()
        Hide()
        f.Show()
    End Sub
End Class
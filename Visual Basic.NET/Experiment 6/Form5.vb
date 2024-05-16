Imports System.IO

Public Class Form5
    Private Sub button_read_from_file_Click(sender As Object, e As EventArgs) Handles button_read_from_file.Click
        Dim path As String = "C:\Users\Pranav Jain\Desktop\Gate paper 2024\6th Semester\Visual Basic.NET\demo-file.txt"
        If Not File.Exists(path) Then
            ' file does not exist, error to be raised
            MessageBox.Show("File does not exist!")
        Else
            ' write to file
            Using sr As New StreamReader(path)
                richtextbox_fileread.Text = sr.ReadToEnd()
            End Using
        End If
        MessageBox.Show("Operations applied successfully!")
    End Sub

    Private Sub button_next_Click(sender As Object, e As EventArgs) Handles button_next.Click
        Dim f As New Form6()
        Hide()
        f.Show()
    End Sub
End Class
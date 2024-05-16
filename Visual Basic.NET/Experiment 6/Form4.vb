Imports System.IO

Public Class Form4
    Private Sub button_write_to_file_Click(sender As Object, e As EventArgs) Handles button_write_to_file.Click
        Dim path As String = "C:\Users\Pranav Jain\Desktop\Gate paper 2024\6th Semester\Visual Basic.NET\demo-file.txt"
        If Not File.Exists(path) Then
            ' file does not exist, file has to be created
            File.Create(path).Close()
        Else
            ' write to file
            Using sw As New StreamWriter(path)
                sw.Write(richtextbox_filewrite.Text)
            End Using
        End If
        MessageBox.Show("Operations applied successfully!")
    End Sub

    Private Sub button_next_Click(sender As Object, e As EventArgs) Handles button_next.Click
        Dim f As New Form5()
        Hide()
        f.Show()
    End Sub
End Class
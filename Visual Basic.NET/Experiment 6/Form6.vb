Imports System.IO

Public Class Form6
    Private Sub button_append_to_file_Click(sender As Object, e As EventArgs) Handles button_append_to_file.Click
        Dim path As String = "C:\Users\Pranav Jain\Desktop\Gate paper 2024\6th Semester\Visual Basic.NET\demo-file.txt"
        If Not File.Exists(path) Then
            ' file does not exist, error to be raised
            MessageBox.Show("File does not exist!")
        Else
            ' write to file
            Dim lines As String() = File.ReadAllLines(path)
            ReDim Preserve lines(lines.Length)
            lines(lines.Length - 1) = richtextbox_fileappend.Text
            File.WriteAllLines(path, lines)
        End If
        MessageBox.Show("Operations applied successfully!")
    End Sub

    Private Sub button_next_Click(sender As Object, e As EventArgs) Handles button_next.Click
        Dim f As New Form7()
        Hide()
        f.Show()
    End Sub
End Class
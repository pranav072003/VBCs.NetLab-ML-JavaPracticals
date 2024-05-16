Imports System.Data.SqlClient

Public Class Form7
    Private Sub button_exit_Click(sender As Object, e As EventArgs) Handles button_exit.Click
        Application.Exit()
    End Sub

    Private Sub button_loaddata_Click(sender As Object, e As EventArgs) Handles button_loaddata.Click
        Try
            Dim Connectionstring As String = "Data Source=LAPTOP-NFJ7VAOT\SQLEXPRESS;Initial Catalog=Pranav;Integrated Security=True;Connect Timeout=30;Encrypt=False;" 'Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
            Using connection As New SqlConnection(Connectionstring)
                connection.Open()
                Dim query As String = "SELECT * FROM MyFirstTable"
                Using adap As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adap.Fill(table)
                    datagridview_database.DataSource = table
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub button_insert_Click(sender As Object, e As EventArgs) Handles button_insert.Click
        Try
            Dim Connectionstring As String = "Data Source=LAPTOP-NFJ7VAOT\SQLEXPRESS;Initial Catalog=Pranav;Integrated Security=True;Connect Timeout=30;Encrypt=False;" 'Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
            Using connection As New SqlConnection(Connectionstring)
                connection.Open()
                Dim name, enrollment_num, dept, course As String
                name = textbox_name.Text
                enrollment_num = textbox_enroll.Text
                dept = textbox_dept.Text
                course = textbox_course.Text
                Dim query As String = "INSERT INTO MyFirstTable(NAME,ENROLLMENT_NUM,DEPARTMENT,COURSE) VALUES('" + name + "', '" + enrollment_num + "', '" + dept + "', '" + course + "')"
                Dim cmd As New SqlCommand(query, connection)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Insertion successfull!")
        Catch ex As Exception
            MessageBox.Show("Insertion unsuccessfull!")
        End Try
    End Sub

    Private Sub button_update_Click(sender As Object, e As EventArgs) Handles button_update.Click
        Try
            Dim Connectionstring As String = "Data Source=LAPTOP-NFJ7VAOT\SQLEXPRESS;Initial Catalog=Pranav;Integrated Security=True;Connect Timeout=30;Encrypt=False;" 'Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
            Using connection As New SqlConnection(Connectionstring)
                connection.Open()
                Dim name, enrollment_num, dept, course As String
                name = textbox_name.Text
                enrollment_num = textbox_enroll.Text
                dept = textbox_dept.Text
                course = textbox_course.Text
                Dim query As String = "UPDATE MyFirstTable SET NAME='" + name + "', DEPARTMENT='" + dept + "', COURSE='" + course + "' WHERE ENROLLMENT_NUM='" + enrollment_num + "'"
                Dim cmd As New SqlCommand(query, connection)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Updation successfull!")
        Catch ex As Exception
            MessageBox.Show("Updation unsuccessfull!")
        End Try
    End Sub

    Private Sub button_delete_Click(sender As Object, e As EventArgs) Handles button_delete.Click
        Try
            Dim Connectionstring As String = "Data Source=LAPTOP-NFJ7VAOT\SQLEXPRESS;Initial Catalog=Pranav;Integrated Security=True;Connect Timeout=30;Encrypt=False;" 'Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
            Using connection As New SqlConnection(Connectionstring)
                connection.Open()
                Dim name, enrollment_num, dept, course As String
                name = textbox_name.Text
                enrollment_num = textbox_enroll.Text
                dept = textbox_dept.Text
                course = textbox_course.Text
                Dim query As String = "DELETE from MyFirstTable WHERE ENROLLMENT_NUM='" + enrollment_num + "'"
                Dim cmd As New SqlCommand(query, connection)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Deletion successfull!")
        Catch ex As Exception
            MessageBox.Show("Deletion unsuccessfull!")
        End Try
    End Sub
End Class
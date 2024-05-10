Imports System.Runtime.Intrinsics.X86

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New ToolTip()
        t.SetToolTip(button_sequence, "Click here to print sequence")
        t.SetToolTip(button_exit, "Click here to exit the application")
        t.SetToolTip(button_back, "Click here to go back....")
        t.SetToolTip(button_reset, "Click here to reset the listbox")
    End Sub

    Private Sub button_back_Click(sender As Object, e As EventArgs) Handles button_back.Click
        Dim f As New Form1()
        Hide()
        f.Show()
    End Sub

    Private Sub button_exit_Click(sender As Object, e As EventArgs) Handles button_exit.Click
        Application.Exit()
    End Sub

    Private Sub button_sequence_Click(sender As Object, e As EventArgs) Handles button_sequence.Click
        listbox_sequence.Items.Clear()
        listbox_sequence.Focus()
        Dim a As Integer
        Try
            a = Convert.ToInt32(textbox_num.Text)
        Catch ex As Exception
            textbox_num.Text = "Error! Please try again"
        End Try
        ' proceed with building the series
        Dim levels As Integer = a
        ' check or levels condition
        If levels = 0 Then
            MessageBox.Show("Invalid input! Try again!")
            Return
        End If
        Dim k As Integer = 1
        Dim space As Integer = levels
        For i = 1 To levels Step 1
            Dim s As String = Strings.StrDup(2 * levels - 2, " ")
            ' DONE: add logic for adding numbers in a row to form star like pattern
            Dim idx As Integer = space - 1
            For j = k To (k + i - 1)
                s = s.Insert(idx, j.ToString())
                idx += 2
            Next
            k += i
            space -= 1
            listbox_sequence.Items.Add(s)
        Next
    End Sub

    Private Sub button_reset_Click(sender As Object, e As EventArgs) Handles button_reset.Click
        listbox_sequence.Items.Clear()
        listbox_sequence.Focus()
        textbox_num.Clear()
        textbox_num.Focus()
    End Sub
End Class
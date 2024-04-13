Option Explicit On

Public Class Form1
    ' Program 1: To apply +,-,*,/ on numbers inputted by user
    Public a, b As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As ToolTip = New ToolTip()
        t.SetToolTip(button_close, "Click here to close the application")
        t.SetToolTip(button_continue, "Click here to proceed ahead....")
        t.SetToolTip(button_restart, "Click here to restart the application")
    End Sub

    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        MessageBox.Show("Exiting the application....")
        Environment.Exit(0)
    End Sub

    Private Sub button_restart_Click(sender As Object, e As EventArgs) Handles button_restart.Click
        MessageBox.Show("Restarting the application...")
        Application.Restart()
    End Sub

    Private Sub button_add_Click(sender As Object, e As EventArgs) Handles button_add.Click
        Dim num1 As Double = Convert.ToDouble(textbox_num1.Text)
        Dim num2 As Double = Convert.ToDouble(textbox_num2.Text)
        add(num1, num2)
    End Sub

    Public Sub add(a, b)
        Dim c As Double = a + b
        MessageBox.Show("Addition Result: " + c.ToString())
    End Sub

    Public Sub subtract(a, b)
        Dim c As Double = a - b
        MessageBox.Show("Subtraction Result: " + c.ToString())
    End Sub

    Public Sub multiply(a, b)
        Dim c As Double = a * b
        MessageBox.Show("Multiplication Result: " + c.ToString())
    End Sub

    Public Sub divide(a, b)
        Try
            Dim c As Double = a / b
            If b = 0 Then
                Throw New System.OverflowException()
            End If
            MessageBox.Show("Division Result: " + c.ToString())
        Catch ex As System.OverflowException
            MessageBox.Show("Arithmetic Exception occuring!")
        End Try
    End Sub

    Private Sub button_sub_Click(sender As Object, e As EventArgs) Handles button_sub.Click
        Dim num1 As Double = Convert.ToDouble(textbox_num1.Text)
        Dim num2 As Double = Convert.ToDouble(textbox_num2.Text)
        subtract(num1, num2)
    End Sub

    Private Sub button_mul_Click(sender As Object, e As EventArgs) Handles button_mul.Click
        Dim num1 As Double = Convert.ToDouble(textbox_num1.Text)
        Dim num2 As Double = Convert.ToDouble(textbox_num2.Text)
        multiply(num1, num2)
    End Sub

    Private Sub button_div_Click(sender As Object, e As EventArgs) Handles button_div.Click
        Dim num1 As Double = Convert.ToDouble(textbox_num1.Text)
        Dim num2 As Double = Convert.ToDouble(textbox_num2.Text)
        divide(num1, num2)
    End Sub

    Private Sub button_continue_Click(sender As Object, e As EventArgs) Handles button_continue.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class

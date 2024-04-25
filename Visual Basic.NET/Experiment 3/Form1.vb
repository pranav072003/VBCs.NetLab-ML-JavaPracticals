Imports System.Numerics
Imports System.Runtime.CompilerServices

Public Class Form1
    Public calc_num1 As String = ""
    Public calc_op As String = ""
    Public calc_num2 As String = ""

    Private Sub button_exit_Click(sender As Object, e As EventArgs) Handles button_exit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New ToolTip()
        t.SetToolTip(button_exit, "Click here to exit the calculator")
        t.SetToolTip(button_restart, "Click here to restart the calculator")
        textbox_calc.Text = "0"
    End Sub

    Private Sub button_restart_Click(sender As Object, e As EventArgs) Handles button_restart.Click
        Application.Restart()
    End Sub

    Public Sub Modify_Textbox(str As String)
        If str = "+" Or str = "-" Or str = "*" Or str = "/" Or str = "^" Then
            ' complete the logic
            Return
        Else
            If textbox_calc.Text = "0" Then
                textbox_calc.Clear()
                textbox_calc.Focus()
                textbox_calc.Text = str
            ElseIf textbox_calc.Text.Chars(0) = "0" Then
                textbox_calc.Text.Remove(0)
                textbox_calc.Text += str
            ElseIf textbox_calc.Text = "+" Or textbox_calc.Text = "-" Or textbox_calc.Text = "*" Or textbox_calc.Text = "/" Or textbox_calc.Text = "^" Then
                calc_op = textbox_calc.Text
                textbox_calc.Clear()
                textbox_calc.Focus()
                textbox_calc.Text = str
            Else
                textbox_calc.Text += str
            End If
        End If
    End Sub

    Public Sub Click_operation(str As String)
        If calc_num1.Length > 0 And textbox_calc.Text.Length > 0 And calc_op.Length > 0 Then
            ' don't take in more operations
            MessageBox.Show("More operations cannot be performed")
        Else
            calc_num1 = textbox_calc.Text
            textbox_calc.Clear()
            textbox_calc.Focus()
            textbox_calc.Text = str
            calc_op = str
        End If
    End Sub

    Private Sub button_nine_Click(sender As Object, e As EventArgs) Handles button_nine.Click
        Modify_Textbox("9")
    End Sub

    Private Sub button_eight_Click(sender As Object, e As EventArgs) Handles button_eight.Click
        Modify_Textbox("8")
    End Sub

    Private Sub button_seven_Click(sender As Object, e As EventArgs) Handles button_seven.Click
        Modify_Textbox("7")
    End Sub

    Private Sub button_four_Click(sender As Object, e As EventArgs) Handles button_four.Click
        Modify_Textbox("4")
    End Sub

    Private Sub button_five_Click(sender As Object, e As EventArgs) Handles button_five.Click
        Modify_Textbox("5")
    End Sub

    Private Sub button_six_Click(sender As Object, e As EventArgs) Handles button_six.Click
        Modify_Textbox("6")
    End Sub

    Private Sub button_one_Click(sender As Object, e As EventArgs) Handles button_one.Click
        Modify_Textbox("1")
    End Sub

    Private Sub button_two_Click(sender As Object, e As EventArgs) Handles button_two.Click
        Modify_Textbox("2")
    End Sub

    Private Sub button_three_Click(sender As Object, e As EventArgs) Handles button_three.Click
        Modify_Textbox("3")
    End Sub

    Private Sub button_zero_Click(sender As Object, e As EventArgs) Handles button_zero.Click
        Modify_Textbox("0")
    End Sub

    Private Sub button_divide_Click(sender As Object, e As EventArgs)
        Click_operation("/")
    End Sub

    Private Sub button_clear_Click(sender As Object, e As EventArgs) Handles button_clear.Click
        textbox_calc.Clear()
        textbox_calc.Focus()
        textbox_calc.Text = "0"
        ' clear the numbers and operators
        calc_num1 = ""
        calc_num2 = ""
        calc_op = ""
    End Sub

    Private Sub button_add_Click(sender As Object, e As EventArgs) Handles button_add.Click
        Click_operation("+")
    End Sub

    Private Sub button_sub_Click(sender As Object, e As EventArgs) Handles button_sub.Click
        Click_operation("-")
    End Sub

    Private Sub button_mul_Click(sender As Object, e As EventArgs) Handles button_mul.Click
        Click_operation("*")
    End Sub

    Private Sub button_eq_Click(sender As Object, e As EventArgs) Handles button_eq.Click
        If calc_num1.Length = 0 Or textbox_calc.Text = "+" Or textbox_calc.Text = "-" Or textbox_calc.Text = "*" Or textbox_calc.Text = "/" Then
            ' return error
            MessageBox.Show("Missing one input....")
        Else
            calc_num2 = textbox_calc.Text
            textbox_calc.Clear()
            textbox_calc.Focus()
            Dim a As Double = Convert.ToDouble(calc_num1)
            Dim b As Double = Convert.ToDouble(calc_num2)
            Dim op As String = calc_op
            Dim result As Double
            If op = "+" Then
                result = a + b
                calc_num1 = result.ToString()
                calc_num2 = ""
                textbox_calc.Text = calc_num1
                calc_op = ""
            ElseIf op = "-" Then
                result = a - b
                calc_num1 = result.ToString()
                calc_num2 = ""
                textbox_calc.Text = calc_num1
                calc_op = ""
            ElseIf op = "*" Then
                result = a * b
                calc_num1 = result.ToString()
                calc_num2 = ""
                textbox_calc.Text = calc_num1
                calc_op = ""
            ElseIf op = "^" Then
                result = a ^ b
                calc_num1 = result.ToString()
                calc_num2 = ""
                textbox_calc.Text = calc_num1
                calc_op = ""
            ElseIf op = "/" Then
                If b = 0 Then
                    ' return error
                    textbox_calc.Text = "Math Domain Error! Cannot divide by zero"
                    Return
                End If
                result = a / b
                calc_num1 = result.ToString()
                calc_num2 = ""
                textbox_calc.Text = calc_num1
                calc_op = ""
            End If
        End If
    End Sub

    Private Sub button_divide_Click_1(sender As Object, e As EventArgs) Handles button_divide.Click
        Click_operation("/")
    End Sub

    Private Sub button_changesign_Click(sender As Object, e As EventArgs) Handles button_changesign.Click
        calc_num1 = textbox_calc.Text

        If calc_op.Length <> 0 Or calc_num1 = "" Then
            ' arithmetic operation exists on screen or second number present on screen or number not present
            MessageBox.Show("Operation cannot be performed!")
            Return
        End If
        Dim num As Double = Convert.ToDouble(textbox_calc.Text)
        If num <= 0 Then
            ' change the sign
            num *= (-1)
            textbox_calc.Text = num.ToString()
            Return
        Else
            ' change the sign
            num *= (-1)
            textbox_calc.Text = num.ToString()
            Return
        End If
    End Sub

    Private Sub button_sqrt_Click(sender As Object, e As EventArgs) Handles button_sqrt.Click
        calc_num1 = textbox_calc.Text

        If calc_op.Length <> 0 Or calc_num1 = "" Then
            ' arithmetic operation exists on screen or second number present on screen or number not present
            MessageBox.Show("Operation cannot be performed!")
            Return
        End If
        Dim num As Double = Convert.ToDouble(textbox_calc.Text)
        If num < 0 Then
            ' return a error with complex number shown on it
            num *= (-1)
            Dim img As Double = Math.Sqrt(num)
            Dim c As New Complex(0.0, img)
            textbox_calc.Text = "Square Root on negative numbers undefined. Giving complex result-> " + c.Imaginary.ToString() + "j"
            Return
        Else
            ' compute sqrt
            textbox_calc.Text = Math.Sqrt(num).ToString()
            Return
        End If
    End Sub

    Private Sub button_abs_Click(sender As Object, e As EventArgs) Handles button_abs.Click
        calc_num1 = textbox_calc.Text

        If calc_op.Length <> 0 Or calc_num1 = "" Then
            ' arithmetic operation exists on screen or second number present on screen or number not present
            MessageBox.Show("Operation cannot be performed!")
            Return
        End If
        Dim num As Double = Convert.ToDouble(textbox_calc.Text)
        If num >= 0 Then
            ' dont change the sign and leave as it is
            Return
        Else
            ' change the sign
            num *= (-1)
            textbox_calc.Text = num.ToString()
            Return
        End If
    End Sub

    Private Sub button_exponentiation_Click(sender As Object, e As EventArgs) Handles button_exponentiation.Click
        Click_operation("^")
    End Sub

    Private Sub button_continue_Click(sender As Object, e As EventArgs) Handles button_continue.Click
        Dim f As New Form2
        Hide()
        f.Show()
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        textbox_calc = New TextBox()
        Label1 = New Label()
        button_exit = New Button()
        button_restart = New Button()
        button_seven = New Button()
        button_eight = New Button()
        button_nine = New Button()
        button_divide = New Button()
        button_four = New Button()
        button_five = New Button()
        button_six = New Button()
        button_mul = New Button()
        button_one = New Button()
        button_two = New Button()
        button_three = New Button()
        button_sub = New Button()
        button_clear = New Button()
        button_eq = New Button()
        button_zero = New Button()
        button_add = New Button()
        button_changesign = New Button()
        button_sqrt = New Button()
        button_abs = New Button()
        button_exponentiation = New Button()
        button_continue = New Button()
        SuspendLayout()
        ' 
        ' textbox_calc
        ' 
        textbox_calc.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        textbox_calc.Location = New Point(85, 77)
        textbox_calc.Name = "textbox_calc"
        textbox_calc.Size = New Size(614, 27)
        textbox_calc.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(188, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(404, 25)
        Label1.TabIndex = 1
        Label1.Text = "Please feel free to experiment with the calculator"
        ' 
        ' button_exit
        ' 
        button_exit.Anchor = AnchorStyles.Top
        button_exit.Location = New Point(662, 32)
        button_exit.Name = "button_exit"
        button_exit.Size = New Size(94, 29)
        button_exit.TabIndex = 2
        button_exit.Text = "Exit"
        button_exit.UseVisualStyleBackColor = True
        ' 
        ' button_restart
        ' 
        button_restart.Anchor = AnchorStyles.Top
        button_restart.Location = New Point(21, 32)
        button_restart.Name = "button_restart"
        button_restart.Size = New Size(94, 29)
        button_restart.TabIndex = 3
        button_restart.Text = "Restart"
        button_restart.UseVisualStyleBackColor = True
        ' 
        ' button_seven
        ' 
        button_seven.Anchor = AnchorStyles.Top
        button_seven.Location = New Point(105, 129)
        button_seven.Name = "button_seven"
        button_seven.Size = New Size(94, 81)
        button_seven.TabIndex = 12
        button_seven.Text = "7"
        button_seven.UseVisualStyleBackColor = True
        ' 
        ' button_eight
        ' 
        button_eight.Anchor = AnchorStyles.Top
        button_eight.Location = New Point(273, 129)
        button_eight.Name = "button_eight"
        button_eight.Size = New Size(94, 81)
        button_eight.TabIndex = 13
        button_eight.Text = "8"
        button_eight.UseVisualStyleBackColor = True
        ' 
        ' button_nine
        ' 
        button_nine.Anchor = AnchorStyles.Top
        button_nine.Location = New Point(432, 129)
        button_nine.Name = "button_nine"
        button_nine.Size = New Size(94, 81)
        button_nine.TabIndex = 14
        button_nine.Text = "9"
        button_nine.UseVisualStyleBackColor = True
        ' 
        ' button_divide
        ' 
        button_divide.Anchor = AnchorStyles.Top
        button_divide.Location = New Point(581, 129)
        button_divide.Name = "button_divide"
        button_divide.Size = New Size(94, 81)
        button_divide.TabIndex = 15
        button_divide.Text = "/"
        button_divide.UseVisualStyleBackColor = True
        ' 
        ' button_four
        ' 
        button_four.Anchor = AnchorStyles.Top
        button_four.Location = New Point(105, 216)
        button_four.Name = "button_four"
        button_four.Size = New Size(94, 81)
        button_four.TabIndex = 16
        button_four.Text = "4"
        button_four.UseVisualStyleBackColor = True
        ' 
        ' button_five
        ' 
        button_five.Anchor = AnchorStyles.Top
        button_five.Location = New Point(273, 216)
        button_five.Name = "button_five"
        button_five.Size = New Size(94, 81)
        button_five.TabIndex = 17
        button_five.Text = "5"
        button_five.UseVisualStyleBackColor = True
        ' 
        ' button_six
        ' 
        button_six.Anchor = AnchorStyles.Top
        button_six.Location = New Point(432, 216)
        button_six.Name = "button_six"
        button_six.Size = New Size(94, 81)
        button_six.TabIndex = 18
        button_six.Text = "6"
        button_six.UseVisualStyleBackColor = True
        ' 
        ' button_mul
        ' 
        button_mul.Anchor = AnchorStyles.Top
        button_mul.Location = New Point(581, 216)
        button_mul.Name = "button_mul"
        button_mul.Size = New Size(94, 81)
        button_mul.TabIndex = 19
        button_mul.Text = "*"
        button_mul.UseVisualStyleBackColor = True
        ' 
        ' button_one
        ' 
        button_one.Anchor = AnchorStyles.Top
        button_one.Location = New Point(105, 303)
        button_one.Name = "button_one"
        button_one.Size = New Size(94, 81)
        button_one.TabIndex = 20
        button_one.Text = "1"
        button_one.UseVisualStyleBackColor = True
        ' 
        ' button_two
        ' 
        button_two.Anchor = AnchorStyles.Top
        button_two.Location = New Point(273, 303)
        button_two.Name = "button_two"
        button_two.Size = New Size(94, 81)
        button_two.TabIndex = 21
        button_two.Text = "2"
        button_two.UseVisualStyleBackColor = True
        ' 
        ' button_three
        ' 
        button_three.Anchor = AnchorStyles.Top
        button_three.Location = New Point(432, 303)
        button_three.Name = "button_three"
        button_three.Size = New Size(94, 81)
        button_three.TabIndex = 22
        button_three.Text = "3"
        button_three.UseVisualStyleBackColor = True
        ' 
        ' button_sub
        ' 
        button_sub.Anchor = AnchorStyles.Top
        button_sub.Location = New Point(581, 303)
        button_sub.Name = "button_sub"
        button_sub.Size = New Size(94, 81)
        button_sub.TabIndex = 23
        button_sub.Text = "-"
        button_sub.UseVisualStyleBackColor = True
        ' 
        ' button_clear
        ' 
        button_clear.Anchor = AnchorStyles.Top
        button_clear.Location = New Point(105, 390)
        button_clear.Name = "button_clear"
        button_clear.Size = New Size(94, 81)
        button_clear.TabIndex = 24
        button_clear.Text = "C"
        button_clear.UseVisualStyleBackColor = True
        ' 
        ' button_eq
        ' 
        button_eq.Anchor = AnchorStyles.Top
        button_eq.Location = New Point(432, 390)
        button_eq.Name = "button_eq"
        button_eq.Size = New Size(94, 81)
        button_eq.TabIndex = 25
        button_eq.Text = "="
        button_eq.UseVisualStyleBackColor = True
        ' 
        ' button_zero
        ' 
        button_zero.Anchor = AnchorStyles.Top
        button_zero.Location = New Point(273, 390)
        button_zero.Name = "button_zero"
        button_zero.Size = New Size(94, 81)
        button_zero.TabIndex = 26
        button_zero.Text = "0"
        button_zero.UseVisualStyleBackColor = True
        ' 
        ' button_add
        ' 
        button_add.Anchor = AnchorStyles.Top
        button_add.Location = New Point(581, 390)
        button_add.Name = "button_add"
        button_add.Size = New Size(94, 81)
        button_add.TabIndex = 27
        button_add.Text = "+"
        button_add.UseVisualStyleBackColor = True
        ' 
        ' button_changesign
        ' 
        button_changesign.Anchor = AnchorStyles.Top
        button_changesign.Location = New Point(105, 477)
        button_changesign.Name = "button_changesign"
        button_changesign.Size = New Size(94, 81)
        button_changesign.TabIndex = 28
        button_changesign.Text = "+/-"
        button_changesign.UseVisualStyleBackColor = True
        ' 
        ' button_sqrt
        ' 
        button_sqrt.Anchor = AnchorStyles.Top
        button_sqrt.Location = New Point(273, 477)
        button_sqrt.Name = "button_sqrt"
        button_sqrt.Size = New Size(94, 81)
        button_sqrt.TabIndex = 29
        button_sqrt.Text = "SQRT"
        button_sqrt.UseVisualStyleBackColor = True
        ' 
        ' button_abs
        ' 
        button_abs.Anchor = AnchorStyles.Top
        button_abs.Location = New Point(432, 477)
        button_abs.Name = "button_abs"
        button_abs.Size = New Size(94, 81)
        button_abs.TabIndex = 30
        button_abs.Text = "|x|"
        button_abs.UseVisualStyleBackColor = True
        ' 
        ' button_exponentiation
        ' 
        button_exponentiation.Anchor = AnchorStyles.Top
        button_exponentiation.Location = New Point(581, 477)
        button_exponentiation.Name = "button_exponentiation"
        button_exponentiation.Size = New Size(94, 81)
        button_exponentiation.TabIndex = 31
        button_exponentiation.Text = "^"
        button_exponentiation.UseVisualStyleBackColor = True
        ' 
        ' button_continue
        ' 
        button_continue.Anchor = AnchorStyles.Top
        button_continue.Location = New Point(355, 564)
        button_continue.Name = "button_continue"
        button_continue.Size = New Size(94, 29)
        button_continue.TabIndex = 32
        button_continue.Text = "Continue"
        button_continue.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(804, 596)
        Controls.Add(button_continue)
        Controls.Add(button_exponentiation)
        Controls.Add(button_abs)
        Controls.Add(button_sqrt)
        Controls.Add(button_changesign)
        Controls.Add(button_add)
        Controls.Add(button_zero)
        Controls.Add(button_eq)
        Controls.Add(button_clear)
        Controls.Add(button_sub)
        Controls.Add(button_three)
        Controls.Add(button_two)
        Controls.Add(button_one)
        Controls.Add(button_mul)
        Controls.Add(button_six)
        Controls.Add(button_five)
        Controls.Add(button_four)
        Controls.Add(button_divide)
        Controls.Add(button_nine)
        Controls.Add(button_eight)
        Controls.Add(button_seven)
        Controls.Add(button_restart)
        Controls.Add(button_exit)
        Controls.Add(Label1)
        Controls.Add(textbox_calc)
        Name = "Form1"
        Text = "Simple Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textbox_calc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents button_exit As Button
    Friend WithEvents button_restart As Button
    Friend WithEvents button_seven As Button
    Friend WithEvents button_eight As Button
    Friend WithEvents button_nine As Button
    Friend WithEvents button_divide As Button
    Friend WithEvents button_four As Button
    Friend WithEvents button_five As Button
    Friend WithEvents button_six As Button
    Friend WithEvents button_mul As Button
    Friend WithEvents button_one As Button
    Friend WithEvents button_two As Button
    Friend WithEvents button_three As Button
    Friend WithEvents button_sub As Button
    Friend WithEvents button_clear As Button
    Friend WithEvents button_eq As Button
    Friend WithEvents button_zero As Button
    Friend WithEvents button_add As Button
    Friend WithEvents button_changesign As Button
    Friend WithEvents button_sqrt As Button
    Friend WithEvents button_abs As Button
    Friend WithEvents button_exponentiation As Button
    Friend WithEvents button_continue As Button

End Class

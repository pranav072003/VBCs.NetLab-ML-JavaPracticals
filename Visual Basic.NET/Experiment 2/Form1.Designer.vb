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
        label_num1 = New Label()
        textbox_num1 = New TextBox()
        label_num2 = New Label()
        textbox_num2 = New TextBox()
        button_close = New Button()
        button_restart = New Button()
        button_add = New Button()
        button_mul = New Button()
        button_sub = New Button()
        button_div = New Button()
        button_continue = New Button()
        SuspendLayout()
        ' 
        ' label_num1
        ' 
        label_num1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        label_num1.AutoSize = True
        label_num1.Location = New Point(205, 107)
        label_num1.Name = "label_num1"
        label_num1.Size = New Size(88, 20)
        label_num1.TabIndex = 0
        label_num1.Text = "Number 1:- "
        ' 
        ' textbox_num1
        ' 
        textbox_num1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        textbox_num1.Location = New Point(356, 104)
        textbox_num1.Name = "textbox_num1"
        textbox_num1.Size = New Size(125, 27)
        textbox_num1.TabIndex = 1
        ' 
        ' label_num2
        ' 
        label_num2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        label_num2.AutoSize = True
        label_num2.Location = New Point(205, 167)
        label_num2.Name = "label_num2"
        label_num2.Size = New Size(88, 20)
        label_num2.TabIndex = 2
        label_num2.Text = "Number 2:- "
        ' 
        ' textbox_num2
        ' 
        textbox_num2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        textbox_num2.Location = New Point(356, 164)
        textbox_num2.Name = "textbox_num2"
        textbox_num2.Size = New Size(125, 27)
        textbox_num2.TabIndex = 3
        ' 
        ' button_close
        ' 
        button_close.Location = New Point(238, 240)
        button_close.Name = "button_close"
        button_close.Size = New Size(94, 29)
        button_close.TabIndex = 4
        button_close.Text = "Close"
        button_close.UseVisualStyleBackColor = True
        ' 
        ' button_restart
        ' 
        button_restart.Location = New Point(356, 240)
        button_restart.Name = "button_restart"
        button_restart.Size = New Size(94, 29)
        button_restart.TabIndex = 5
        button_restart.Text = "Restart"
        button_restart.UseVisualStyleBackColor = True
        ' 
        ' button_add
        ' 
        button_add.Location = New Point(238, 290)
        button_add.Name = "button_add"
        button_add.Size = New Size(38, 29)
        button_add.TabIndex = 6
        button_add.Text = "+"
        button_add.UseVisualStyleBackColor = True
        ' 
        ' button_mul
        ' 
        button_mul.Location = New Point(356, 290)
        button_mul.Name = "button_mul"
        button_mul.Size = New Size(38, 29)
        button_mul.TabIndex = 7
        button_mul.Text = "*"
        button_mul.UseVisualStyleBackColor = True
        ' 
        ' button_sub
        ' 
        button_sub.Location = New Point(294, 290)
        button_sub.Name = "button_sub"
        button_sub.Size = New Size(38, 29)
        button_sub.TabIndex = 8
        button_sub.Text = "-"
        button_sub.UseVisualStyleBackColor = True
        ' 
        ' button_div
        ' 
        button_div.Location = New Point(412, 290)
        button_div.Name = "button_div"
        button_div.Size = New Size(38, 29)
        button_div.TabIndex = 9
        button_div.Text = "/"
        button_div.UseVisualStyleBackColor = True
        ' 
        ' button_continue
        ' 
        button_continue.Location = New Point(294, 339)
        button_continue.Name = "button_continue"
        button_continue.Size = New Size(94, 29)
        button_continue.TabIndex = 10
        button_continue.Text = "Continue"
        button_continue.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(button_continue)
        Controls.Add(button_div)
        Controls.Add(button_sub)
        Controls.Add(button_mul)
        Controls.Add(button_add)
        Controls.Add(button_restart)
        Controls.Add(button_close)
        Controls.Add(textbox_num2)
        Controls.Add(label_num2)
        Controls.Add(textbox_num1)
        Controls.Add(label_num1)
        Name = "Form1"
        Text = "Number Calculator Arithmetic Operations"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label_num1 As Label
    Friend WithEvents textbox_num1 As TextBox
    Friend WithEvents label_num2 As Label
    Friend WithEvents textbox_num2 As TextBox
    Friend WithEvents button_close As Button
    Friend WithEvents button_restart As Button
    Friend WithEvents button_add As Button
    Friend WithEvents button_mul As Button
    Friend WithEvents button_sub As Button
    Friend WithEvents button_div As Button
    Friend WithEvents button_continue As Button

End Class

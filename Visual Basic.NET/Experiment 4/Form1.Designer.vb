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
        label_num = New Label()
        textbox_num = New TextBox()
        button_fact = New Button()
        listbox_result = New ListBox()
        button_exit = New Button()
        button_continue = New Button()
        button_reset = New Button()
        SuspendLayout()
        ' 
        ' label_num
        ' 
        label_num.AutoSize = True
        label_num.Location = New Point(204, 79)
        label_num.Name = "label_num"
        label_num.Size = New Size(87, 15)
        label_num.TabIndex = 0
        label_num.Text = "Enter number:-"
        ' 
        ' textbox_num
        ' 
        textbox_num.Location = New Point(310, 76)
        textbox_num.Name = "textbox_num"
        textbox_num.Size = New Size(187, 23)
        textbox_num.TabIndex = 1
        ' 
        ' button_fact
        ' 
        button_fact.Location = New Point(256, 141)
        button_fact.Name = "button_fact"
        button_fact.Size = New Size(129, 23)
        button_fact.TabIndex = 2
        button_fact.Text = "Calculate factorial"
        button_fact.UseVisualStyleBackColor = True
        ' 
        ' listbox_result
        ' 
        listbox_result.FormattingEnabled = True
        listbox_result.ItemHeight = 15
        listbox_result.Location = New Point(204, 214)
        listbox_result.Name = "listbox_result"
        listbox_result.Size = New Size(293, 19)
        listbox_result.TabIndex = 3
        ' 
        ' button_exit
        ' 
        button_exit.Location = New Point(406, 141)
        button_exit.Name = "button_exit"
        button_exit.Size = New Size(75, 23)
        button_exit.TabIndex = 4
        button_exit.Text = "Exit"
        button_exit.UseVisualStyleBackColor = True
        ' 
        ' button_continue
        ' 
        button_continue.Location = New Point(353, 170)
        button_continue.Name = "button_continue"
        button_continue.Size = New Size(75, 23)
        button_continue.TabIndex = 5
        button_continue.Text = "Continue"
        button_continue.UseVisualStyleBackColor = True
        ' 
        ' button_reset
        ' 
        button_reset.Location = New Point(272, 170)
        button_reset.Name = "button_reset"
        button_reset.Size = New Size(75, 23)
        button_reset.TabIndex = 6
        button_reset.Text = "Reset"
        button_reset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(button_reset)
        Controls.Add(button_continue)
        Controls.Add(button_exit)
        Controls.Add(listbox_result)
        Controls.Add(button_fact)
        Controls.Add(textbox_num)
        Controls.Add(label_num)
        Name = "Form1"
        Text = "Factorial of number"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label_num As Label
    Friend WithEvents textbox_num As TextBox
    Friend WithEvents button_fact As Button
    Friend WithEvents listbox_result As ListBox
    Friend WithEvents button_exit As Button
    Friend WithEvents button_continue As Button
    Friend WithEvents button_reset As Button

End Class

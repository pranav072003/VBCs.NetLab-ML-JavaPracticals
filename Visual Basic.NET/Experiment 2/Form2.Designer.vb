<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        button_back = New Button()
        button_exit = New Button()
        button_prime = New Button()
        label_num = New Label()
        textbox_num = New TextBox()
        SuspendLayout()
        ' 
        ' button_back
        ' 
        button_back.Location = New Point(187, 287)
        button_back.Name = "button_back"
        button_back.Size = New Size(94, 29)
        button_back.TabIndex = 0
        button_back.Text = "Back"
        button_back.UseVisualStyleBackColor = True
        ' 
        ' button_exit
        ' 
        button_exit.Location = New Point(324, 287)
        button_exit.Name = "button_exit"
        button_exit.Size = New Size(94, 29)
        button_exit.TabIndex = 1
        button_exit.Text = "Exit"
        button_exit.UseVisualStyleBackColor = True
        ' 
        ' button_prime
        ' 
        button_prime.Location = New Point(458, 287)
        button_prime.Name = "button_prime"
        button_prime.Size = New Size(162, 29)
        button_prime.TabIndex = 2
        button_prime.Text = "Check Prime"
        button_prime.UseVisualStyleBackColor = True
        ' 
        ' label_num
        ' 
        label_num.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        label_num.AutoSize = True
        label_num.Location = New Point(228, 123)
        label_num.Name = "label_num"
        label_num.Size = New Size(72, 20)
        label_num.TabIndex = 3
        label_num.Text = "Number:-"
        ' 
        ' textbox_num
        ' 
        textbox_num.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        textbox_num.Location = New Point(353, 120)
        textbox_num.Name = "textbox_num"
        textbox_num.Size = New Size(125, 27)
        textbox_num.TabIndex = 4
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(textbox_num)
        Controls.Add(label_num)
        Controls.Add(button_prime)
        Controls.Add(button_exit)
        Controls.Add(button_back)
        Name = "Form2"
        Text = "Prime number verifier"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents button_back As Button
    Friend WithEvents button_exit As Button
    Friend WithEvents button_prime As Button
    Friend WithEvents label_num As Label
    Friend WithEvents textbox_num As TextBox
End Class

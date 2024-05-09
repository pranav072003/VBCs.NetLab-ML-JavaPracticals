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
        Label1 = New Label()
        textbox_num = New TextBox()
        button_sequence = New Button()
        button_exit = New Button()
        button_back = New Button()
        listbox_sequence = New ListBox()
        button_reset = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(259, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter maximum limit:- "
        ' 
        ' textbox_num
        ' 
        textbox_num.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        textbox_num.Location = New Point(446, 123)
        textbox_num.Margin = New Padding(3, 4, 3, 4)
        textbox_num.Name = "textbox_num"
        textbox_num.Size = New Size(217, 27)
        textbox_num.TabIndex = 1
        ' 
        ' button_sequence
        ' 
        button_sequence.Anchor = AnchorStyles.Bottom
        button_sequence.Location = New Point(275, 467)
        button_sequence.Margin = New Padding(3, 4, 3, 4)
        button_sequence.Name = "button_sequence"
        button_sequence.Size = New Size(115, 31)
        button_sequence.TabIndex = 2
        button_sequence.Text = "Print Sequence"
        button_sequence.UseVisualStyleBackColor = True
        ' 
        ' button_exit
        ' 
        button_exit.Anchor = AnchorStyles.Bottom
        button_exit.Location = New Point(410, 457)
        button_exit.Margin = New Padding(3, 4, 3, 4)
        button_exit.Name = "button_exit"
        button_exit.Size = New Size(86, 31)
        button_exit.TabIndex = 3
        button_exit.Text = "Exit"
        button_exit.UseVisualStyleBackColor = True
        ' 
        ' button_back
        ' 
        button_back.Anchor = AnchorStyles.Bottom
        button_back.Location = New Point(519, 467)
        button_back.Margin = New Padding(3, 4, 3, 4)
        button_back.Name = "button_back"
        button_back.Size = New Size(86, 31)
        button_back.TabIndex = 4
        button_back.Text = "Back"
        button_back.UseVisualStyleBackColor = True
        ' 
        ' listbox_sequence
        ' 
        listbox_sequence.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        listbox_sequence.FormattingEnabled = True
        listbox_sequence.Location = New Point(275, 203)
        listbox_sequence.Margin = New Padding(3, 4, 3, 4)
        listbox_sequence.Name = "listbox_sequence"
        listbox_sequence.Size = New Size(329, 224)
        listbox_sequence.TabIndex = 5
        ' 
        ' button_reset
        ' 
        button_reset.Anchor = AnchorStyles.Bottom
        button_reset.Location = New Point(396, 496)
        button_reset.Margin = New Padding(3, 4, 3, 4)
        button_reset.Name = "button_reset"
        button_reset.Size = New Size(111, 32)
        button_reset.TabIndex = 6
        button_reset.Text = "Reset"
        button_reset.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(button_reset)
        Controls.Add(listbox_sequence)
        Controls.Add(button_back)
        Controls.Add(button_exit)
        Controls.Add(button_sequence)
        Controls.Add(textbox_num)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "Print star pattern of numbers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textbox_num As TextBox
    Friend WithEvents button_sequence As Button
    Friend WithEvents button_exit As Button
    Friend WithEvents button_back As Button
    Friend WithEvents listbox_sequence As ListBox
    Friend WithEvents button_reset As Button
End Class

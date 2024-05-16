<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        textbox_num = New TextBox()
        Label1 = New Label()
        button_next = New Button()
        button_zerodiv = New Button()
        SuspendLayout()
        ' 
        ' textbox_num
        ' 
        textbox_num.Location = New Point(323, 111)
        textbox_num.Name = "textbox_num"
        textbox_num.Size = New Size(255, 27)
        textbox_num.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(157, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 20)
        Label1.TabIndex = 1
        Label1.Text = "Enter the number:-"
        ' 
        ' button_next
        ' 
        button_next.Location = New Point(385, 186)
        button_next.Name = "button_next"
        button_next.Size = New Size(94, 29)
        button_next.TabIndex = 6
        button_next.Text = "Next"
        button_next.UseVisualStyleBackColor = True
        ' 
        ' button_zerodiv
        ' 
        button_zerodiv.Location = New Point(227, 186)
        button_zerodiv.Name = "button_zerodiv"
        button_zerodiv.Size = New Size(94, 29)
        button_zerodiv.TabIndex = 5
        button_zerodiv.Text = "Click me!"
        button_zerodiv.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(button_next)
        Controls.Add(button_zerodiv)
        Controls.Add(Label1)
        Controls.Add(textbox_num)
        Name = "Form3"
        Text = "DivideByZeroException"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textbox_num As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents button_next As Button
    Friend WithEvents button_zerodiv As Button
End Class

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
        textbox_input = New TextBox()
        multiline_input = New RichTextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label_name = New Label()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' textbox_input
        ' 
        textbox_input.Location = New Point(191, 111)
        textbox_input.Multiline = True
        textbox_input.Name = "textbox_input"
        textbox_input.ScrollBars = ScrollBars.Vertical
        textbox_input.Size = New Size(430, 34)
        textbox_input.TabIndex = 0
        ' 
        ' multiline_input
        ' 
        multiline_input.Location = New Point(191, 173)
        multiline_input.Name = "multiline_input"
        multiline_input.Size = New Size(430, 137)
        multiline_input.TabIndex = 1
        multiline_input.Text = ""
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(245, 357)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(440, 357)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 3
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label_name
        ' 
        Label_name.AutoSize = True
        Label_name.Location = New Point(27, 114)
        Label_name.Name = "Label_name"
        Label_name.Size = New Size(98, 20)
        Label_name.TabIndex = 4
        Label_name.Text = "Label Name:-"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(343, 397)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 5
        Button3.Text = "Click me!"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Label_name)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(multiline_input)
        Controls.Add(textbox_input)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textbox_input As TextBox
    Friend WithEvents multiline_input As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label_name As Label
    Friend WithEvents Button3 As Button

End Class

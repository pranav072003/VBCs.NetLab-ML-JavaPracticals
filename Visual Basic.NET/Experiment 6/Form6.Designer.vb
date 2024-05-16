<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        button_next = New Button()
        button_append_to_file = New Button()
        Label1 = New Label()
        richtextbox_fileappend = New RichTextBox()
        SuspendLayout()
        ' 
        ' button_next
        ' 
        button_next.Location = New Point(395, 266)
        button_next.Name = "button_next"
        button_next.Size = New Size(94, 29)
        button_next.TabIndex = 16
        button_next.Text = "Next"
        button_next.UseVisualStyleBackColor = True
        ' 
        ' button_append_to_file
        ' 
        button_append_to_file.Location = New Point(237, 266)
        button_append_to_file.Name = "button_append_to_file"
        button_append_to_file.Size = New Size(127, 29)
        button_append_to_file.TabIndex = 15
        button_append_to_file.Text = "Append to file"
        button_append_to_file.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(328, 20)
        Label1.TabIndex = 14
        Label1.Text = "File content to be appended to be written here:-"
        ' 
        ' richtextbox_fileappend
        ' 
        richtextbox_fileappend.Location = New Point(412, 94)
        richtextbox_fileappend.Name = "richtextbox_fileappend"
        richtextbox_fileappend.Size = New Size(359, 120)
        richtextbox_fileappend.TabIndex = 13
        richtextbox_fileappend.Text = ""
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(button_next)
        Controls.Add(button_append_to_file)
        Controls.Add(Label1)
        Controls.Add(richtextbox_fileappend)
        Name = "Form6"
        Text = "Append data to file"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents button_next As Button
    Friend WithEvents button_append_to_file As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents richtextbox_fileappend As RichTextBox
End Class

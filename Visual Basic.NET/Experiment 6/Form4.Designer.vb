<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        richtextbox_filewrite = New RichTextBox()
        Label1 = New Label()
        button_next = New Button()
        button_write_to_file = New Button()
        SuspendLayout()
        ' 
        ' richtextbox_filewrite
        ' 
        richtextbox_filewrite.Location = New Point(353, 89)
        richtextbox_filewrite.Name = "richtextbox_filewrite"
        richtextbox_filewrite.Size = New Size(359, 120)
        richtextbox_filewrite.TabIndex = 0
        richtextbox_filewrite.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(74, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(245, 20)
        Label1.TabIndex = 1
        Label1.Text = "Enter the file content to be written:-"
        ' 
        ' button_next
        ' 
        button_next.Location = New Point(383, 263)
        button_next.Name = "button_next"
        button_next.Size = New Size(94, 29)
        button_next.TabIndex = 8
        button_next.Text = "Next"
        button_next.UseVisualStyleBackColor = True
        ' 
        ' button_write_to_file
        ' 
        button_write_to_file.Location = New Point(225, 263)
        button_write_to_file.Name = "button_write_to_file"
        button_write_to_file.Size = New Size(127, 29)
        button_write_to_file.TabIndex = 7
        button_write_to_file.Text = "Write to file"
        button_write_to_file.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(button_next)
        Controls.Add(button_write_to_file)
        Controls.Add(Label1)
        Controls.Add(richtextbox_filewrite)
        Name = "Form4"
        Text = "Write data to text file"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents richtextbox_filewrite As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents button_next As Button
    Friend WithEvents button_write_to_file As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        button_read_from_file = New Button()
        Label1 = New Label()
        richtextbox_fileread = New RichTextBox()
        SuspendLayout()
        ' 
        ' button_next
        ' 
        button_next.Location = New Point(381, 282)
        button_next.Name = "button_next"
        button_next.Size = New Size(94, 29)
        button_next.TabIndex = 12
        button_next.Text = "Next"
        button_next.UseVisualStyleBackColor = True
        ' 
        ' button_read_from_file
        ' 
        button_read_from_file.Location = New Point(223, 282)
        button_read_from_file.Name = "button_read_from_file"
        button_read_from_file.Size = New Size(127, 29)
        button_read_from_file.TabIndex = 11
        button_read_from_file.Text = "Read from file"
        button_read_from_file.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(72, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 20)
        Label1.TabIndex = 10
        Label1.Text = "File content to be read here:-"
        ' 
        ' richtextbox_fileread
        ' 
        richtextbox_fileread.Location = New Point(308, 111)
        richtextbox_fileread.Name = "richtextbox_fileread"
        richtextbox_fileread.Size = New Size(359, 120)
        richtextbox_fileread.TabIndex = 9
        richtextbox_fileread.Text = ""
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(button_next)
        Controls.Add(button_read_from_file)
        Controls.Add(Label1)
        Controls.Add(richtextbox_fileread)
        Name = "Form5"
        Text = "Read data from file"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents button_next As Button
    Friend WithEvents button_read_from_file As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents richtextbox_fileread As RichTextBox
End Class

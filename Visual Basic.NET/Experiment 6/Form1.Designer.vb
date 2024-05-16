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
        textbox_hello = New TextBox()
        button_hello = New Button()
        button_next = New Button()
        SuspendLayout()
        ' 
        ' textbox_hello
        ' 
        textbox_hello.Location = New Point(216, 119)
        textbox_hello.Name = "textbox_hello"
        textbox_hello.Size = New Size(381, 27)
        textbox_hello.TabIndex = 0
        ' 
        ' button_hello
        ' 
        button_hello.Location = New Point(267, 201)
        button_hello.Name = "button_hello"
        button_hello.Size = New Size(94, 29)
        button_hello.TabIndex = 1
        button_hello.Text = "Click me!"
        button_hello.UseVisualStyleBackColor = True
        ' 
        ' button_next
        ' 
        button_next.Location = New Point(425, 201)
        button_next.Name = "button_next"
        button_next.Size = New Size(94, 29)
        button_next.TabIndex = 2
        button_next.Text = "Next"
        button_next.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(button_next)
        Controls.Add(button_hello)
        Controls.Add(textbox_hello)
        Name = "Form1"
        Text = "Hello World Program"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textbox_hello As TextBox
    Friend WithEvents button_hello As Button
    Friend WithEvents button_next As Button

End Class

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
        button_next = New Button()
        button_largest = New Button()
        SuspendLayout()
        ' 
        ' button_next
        ' 
        button_next.Location = New Point(416, 114)
        button_next.Name = "button_next"
        button_next.Size = New Size(94, 29)
        button_next.TabIndex = 4
        button_next.Text = "Next"
        button_next.UseVisualStyleBackColor = True
        ' 
        ' button_largest
        ' 
        button_largest.Location = New Point(258, 114)
        button_largest.Name = "button_largest"
        button_largest.Size = New Size(94, 29)
        button_largest.TabIndex = 3
        button_largest.Text = "Click me!"
        button_largest.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(button_next)
        Controls.Add(button_largest)
        Name = "Form2"
        Text = "Largest number of array"
        ResumeLayout(False)
    End Sub

    Friend WithEvents button_next As Button
    Friend WithEvents button_largest As Button
End Class

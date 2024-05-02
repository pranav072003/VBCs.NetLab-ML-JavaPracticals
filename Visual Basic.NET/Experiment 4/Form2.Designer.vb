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
        textbox_radius = New TextBox()
        label_radius = New Label()
        textbox_height = New TextBox()
        label_height = New Label()
        GroupBox1 = New GroupBox()
        RadioButton_circle = New RadioButton()
        RadioButton_cylinder = New RadioButton()
        button_area = New Button()
        button_exit = New Button()
        button_back = New Button()
        button_reset = New Button()
        listbox_result = New ListBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' textbox_radius
        ' 
        textbox_radius.Location = New Point(335, 94)
        textbox_radius.Name = "textbox_radius"
        textbox_radius.Size = New Size(187, 23)
        textbox_radius.TabIndex = 3
        ' 
        ' label_radius
        ' 
        label_radius.AutoSize = True
        label_radius.Location = New Point(229, 97)
        label_radius.Name = "label_radius"
        label_radius.Size = New Size(77, 15)
        label_radius.TabIndex = 2
        label_radius.Text = "Enter radius:-"
        ' 
        ' textbox_height
        ' 
        textbox_height.Location = New Point(335, 138)
        textbox_height.Name = "textbox_height"
        textbox_height.Size = New Size(187, 23)
        textbox_height.TabIndex = 5
        ' 
        ' label_height
        ' 
        label_height.AutoSize = True
        label_height.Location = New Point(229, 141)
        label_height.Name = "label_height"
        label_height.Size = New Size(79, 15)
        label_height.TabIndex = 4
        label_height.Text = "Enter height:-"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton_circle)
        GroupBox1.Controls.Add(RadioButton_cylinder)
        GroupBox1.Location = New Point(229, 190)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(293, 50)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "groupbox_buttons"
        ' 
        ' RadioButton_circle
        ' 
        RadioButton_circle.AutoSize = True
        RadioButton_circle.Location = New Point(145, 21)
        RadioButton_circle.Name = "RadioButton_circle"
        RadioButton_circle.Size = New Size(55, 19)
        RadioButton_circle.TabIndex = 1
        RadioButton_circle.TabStop = True
        RadioButton_circle.Text = "Circle"
        RadioButton_circle.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_cylinder
        ' 
        RadioButton_cylinder.AutoSize = True
        RadioButton_cylinder.Location = New Point(42, 21)
        RadioButton_cylinder.Name = "RadioButton_cylinder"
        RadioButton_cylinder.Size = New Size(69, 19)
        RadioButton_cylinder.TabIndex = 0
        RadioButton_cylinder.TabStop = True
        RadioButton_cylinder.Text = "Cylinder"
        RadioButton_cylinder.UseVisualStyleBackColor = True
        ' 
        ' button_area
        ' 
        button_area.Location = New Point(179, 270)
        button_area.Name = "button_area"
        button_area.Size = New Size(104, 23)
        button_area.TabIndex = 7
        button_area.Text = "Compute Area"
        button_area.UseVisualStyleBackColor = True
        ' 
        ' button_exit
        ' 
        button_exit.Location = New Point(289, 270)
        button_exit.Name = "button_exit"
        button_exit.Size = New Size(75, 23)
        button_exit.TabIndex = 8
        button_exit.Text = "Exit"
        button_exit.UseVisualStyleBackColor = True
        ' 
        ' button_back
        ' 
        button_back.Location = New Point(383, 270)
        button_back.Name = "button_back"
        button_back.Size = New Size(75, 23)
        button_back.TabIndex = 9
        button_back.Text = "Back"
        button_back.UseVisualStyleBackColor = True
        ' 
        ' button_reset
        ' 
        button_reset.Location = New Point(464, 270)
        button_reset.Name = "button_reset"
        button_reset.Size = New Size(75, 23)
        button_reset.TabIndex = 10
        button_reset.Text = "Reset"
        button_reset.UseVisualStyleBackColor = True
        ' 
        ' listbox_result
        ' 
        listbox_result.FormattingEnabled = True
        listbox_result.ItemHeight = 15
        listbox_result.Location = New Point(229, 318)
        listbox_result.Name = "listbox_result"
        listbox_result.Size = New Size(293, 19)
        listbox_result.TabIndex = 11
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(listbox_result)
        Controls.Add(button_reset)
        Controls.Add(button_back)
        Controls.Add(button_exit)
        Controls.Add(button_area)
        Controls.Add(GroupBox1)
        Controls.Add(textbox_height)
        Controls.Add(label_height)
        Controls.Add(textbox_radius)
        Controls.Add(label_radius)
        Name = "Form2"
        Text = "Area of Shapes"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textbox_radius As TextBox
    Friend WithEvents label_radius As Label
    Friend WithEvents textbox_height As TextBox
    Friend WithEvents label_height As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_circle As RadioButton
    Friend WithEvents RadioButton_cylinder As RadioButton
    Friend WithEvents button_area As Button
    Friend WithEvents button_exit As Button
    Friend WithEvents button_back As Button
    Friend WithEvents button_reset As Button
    Friend WithEvents listbox_result As ListBox
End Class

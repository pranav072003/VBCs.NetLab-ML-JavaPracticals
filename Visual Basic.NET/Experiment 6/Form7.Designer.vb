<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        button_exit = New Button()
        Label1 = New Label()
        textbox_name = New TextBox()
        textbox_enroll = New TextBox()
        Label2 = New Label()
        textbox_dept = New TextBox()
        Label3 = New Label()
        textbox_course = New TextBox()
        Label4 = New Label()
        datagridview_database = New DataGridView()
        button_loaddata = New Button()
        button_insert = New Button()
        button_update = New Button()
        button_delete = New Button()
        Label5 = New Label()
        CType(datagridview_database, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' button_exit
        ' 
        button_exit.Location = New Point(626, 318)
        button_exit.Name = "button_exit"
        button_exit.Size = New Size(94, 29)
        button_exit.TabIndex = 0
        button_exit.Text = "Exit"
        button_exit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(98, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 20)
        Label1.TabIndex = 1
        Label1.Text = "Enter name:-"
        ' 
        ' textbox_name
        ' 
        textbox_name.Location = New Point(234, 84)
        textbox_name.Name = "textbox_name"
        textbox_name.Size = New Size(330, 27)
        textbox_name.TabIndex = 2
        ' 
        ' textbox_enroll
        ' 
        textbox_enroll.Location = New Point(234, 137)
        textbox_enroll.Name = "textbox_enroll"
        textbox_enroll.Size = New Size(330, 27)
        textbox_enroll.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 20)
        Label2.TabIndex = 3
        Label2.Text = "Enter enrollment number:-"
        ' 
        ' textbox_dept
        ' 
        textbox_dept.Location = New Point(234, 194)
        textbox_dept.Name = "textbox_dept"
        textbox_dept.Size = New Size(330, 27)
        textbox_dept.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(71, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 20)
        Label3.TabIndex = 5
        Label3.Text = "Enter department:-"
        ' 
        ' textbox_course
        ' 
        textbox_course.Location = New Point(234, 249)
        textbox_course.Name = "textbox_course"
        textbox_course.Size = New Size(330, 27)
        textbox_course.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(98, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 20)
        Label4.TabIndex = 7
        Label4.Text = "Enter course:-"
        ' 
        ' datagridview_database
        ' 
        datagridview_database.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        datagridview_database.Location = New Point(45, 303)
        datagridview_database.Name = "datagridview_database"
        datagridview_database.RowHeadersWidth = 51
        datagridview_database.Size = New Size(519, 135)
        datagridview_database.TabIndex = 9
        ' 
        ' button_loaddata
        ' 
        button_loaddata.Location = New Point(613, 78)
        button_loaddata.Name = "button_loaddata"
        button_loaddata.Size = New Size(133, 29)
        button_loaddata.TabIndex = 10
        button_loaddata.Text = "Load database"
        button_loaddata.UseVisualStyleBackColor = True
        ' 
        ' button_insert
        ' 
        button_insert.Location = New Point(613, 136)
        button_insert.Name = "button_insert"
        button_insert.Size = New Size(133, 29)
        button_insert.TabIndex = 11
        button_insert.Text = "Insert into table"
        button_insert.UseVisualStyleBackColor = True
        ' 
        ' button_update
        ' 
        button_update.Location = New Point(595, 194)
        button_update.Name = "button_update"
        button_update.Size = New Size(161, 29)
        button_update.TabIndex = 12
        button_update.Text = "Update table data"
        button_update.UseVisualStyleBackColor = True
        ' 
        ' button_delete
        ' 
        button_delete.Location = New Point(595, 252)
        button_delete.Name = "button_delete"
        button_delete.Size = New Size(161, 27)
        button_delete.TabIndex = 13
        button_delete.Text = "Delete from table"
        button_delete.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(298, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(182, 20)
        Label5.TabIndex = 14
        Label5.Text = "Student Registration Form"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(button_delete)
        Controls.Add(button_update)
        Controls.Add(button_insert)
        Controls.Add(button_loaddata)
        Controls.Add(datagridview_database)
        Controls.Add(textbox_course)
        Controls.Add(Label4)
        Controls.Add(textbox_dept)
        Controls.Add(Label3)
        Controls.Add(textbox_enroll)
        Controls.Add(Label2)
        Controls.Add(textbox_name)
        Controls.Add(Label1)
        Controls.Add(button_exit)
        Name = "Form7"
        Text = "Database Connectivity"
        CType(datagridview_database, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents button_exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents textbox_name As TextBox
    Friend WithEvents textbox_enroll As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textbox_dept As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textbox_course As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents datagridview_database As DataGridView
    Friend WithEvents button_loaddata As Button
    Friend WithEvents button_insert As Button
    Friend WithEvents button_update As Button
    Friend WithEvents button_delete As Button
    Friend WithEvents Label5 As Label
End Class

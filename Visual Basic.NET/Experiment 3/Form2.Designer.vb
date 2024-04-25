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
        textbox_principal = New TextBox()
        textbox_timeperiod = New TextBox()
        Label2 = New Label()
        textbox_rate = New TextBox()
        Label3 = New Label()
        textbox_si = New TextBox()
        Label4 = New Label()
        button_calculatesi = New Button()
        button_back = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Location = New Point(188, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter principal:-"
        ' 
        ' textbox_principal
        ' 
        textbox_principal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        textbox_principal.Location = New Point(348, 94)
        textbox_principal.Name = "textbox_principal"
        textbox_principal.Size = New Size(262, 27)
        textbox_principal.TabIndex = 1
        ' 
        ' textbox_timeperiod
        ' 
        textbox_timeperiod.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        textbox_timeperiod.Location = New Point(348, 194)
        textbox_timeperiod.Name = "textbox_timeperiod"
        textbox_timeperiod.Size = New Size(262, 27)
        textbox_timeperiod.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Location = New Point(188, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 20)
        Label2.TabIndex = 2
        Label2.Text = "Enter time period:-"
        ' 
        ' textbox_rate
        ' 
        textbox_rate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        textbox_rate.Location = New Point(348, 143)
        textbox_rate.Name = "textbox_rate"
        textbox_rate.Size = New Size(262, 27)
        textbox_rate.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Location = New Point(189, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(153, 20)
        Label3.TabIndex = 4
        Label3.Text = "Enter rate of interest:-"
        ' 
        ' textbox_si
        ' 
        textbox_si.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        textbox_si.Location = New Point(348, 244)
        textbox_si.Name = "textbox_si"
        textbox_si.Size = New Size(262, 27)
        textbox_si.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label4.AutoSize = True
        Label4.Location = New Point(188, 244)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 20)
        Label4.TabIndex = 6
        Label4.Text = "Simple Interest:-"
        ' 
        ' button_calculatesi
        ' 
        button_calculatesi.Anchor = AnchorStyles.Top
        button_calculatesi.Location = New Point(318, 306)
        button_calculatesi.Name = "button_calculatesi"
        button_calculatesi.Size = New Size(244, 29)
        button_calculatesi.TabIndex = 8
        button_calculatesi.Text = "Calculate Simple Interest"
        button_calculatesi.UseVisualStyleBackColor = True
        ' 
        ' button_back
        ' 
        button_back.Anchor = AnchorStyles.Top
        button_back.Location = New Point(318, 356)
        button_back.Name = "button_back"
        button_back.Size = New Size(244, 27)
        button_back.TabIndex = 9
        button_back.Text = "Back"
        button_back.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(button_back)
        Controls.Add(button_calculatesi)
        Controls.Add(textbox_si)
        Controls.Add(Label4)
        Controls.Add(textbox_rate)
        Controls.Add(Label3)
        Controls.Add(textbox_timeperiod)
        Controls.Add(Label2)
        Controls.Add(textbox_principal)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Simple Interest Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textbox_principal As TextBox
    Friend WithEvents textbox_timeperiod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textbox_rate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textbox_si As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents button_calculatesi As Button
    Friend WithEvents button_back As Button
End Class

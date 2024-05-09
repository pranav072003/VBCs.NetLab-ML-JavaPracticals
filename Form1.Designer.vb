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
        Listbox_primenum = New ListBox()
        button_showprime = New Button()
        button_exit = New Button()
        button_continue = New Button()
        button_reset = New Button()
        SuspendLayout()
        ' 
        ' Listbox_primenum
        ' 
        Listbox_primenum.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Listbox_primenum.FormattingEnabled = True
        Listbox_primenum.Items.AddRange(New Object() {"The prime numbers between 1 and 100 are shown as:-"})
        Listbox_primenum.Location = New Point(242, 135)
        Listbox_primenum.Margin = New Padding(3, 4, 3, 4)
        Listbox_primenum.Name = "Listbox_primenum"
        Listbox_primenum.Size = New Size(412, 184)
        Listbox_primenum.TabIndex = 0
        ' 
        ' button_showprime
        ' 
        button_showprime.Anchor = AnchorStyles.Bottom
        button_showprime.Location = New Point(242, 377)
        button_showprime.Margin = New Padding(3, 4, 3, 4)
        button_showprime.Name = "button_showprime"
        button_showprime.Size = New Size(111, 72)
        button_showprime.TabIndex = 1
        button_showprime.Text = "Show Prime numbers"
        button_showprime.UseVisualStyleBackColor = True
        ' 
        ' button_exit
        ' 
        button_exit.Anchor = AnchorStyles.Bottom
        button_exit.Location = New Point(398, 377)
        button_exit.Margin = New Padding(3, 4, 3, 4)
        button_exit.Name = "button_exit"
        button_exit.Size = New Size(111, 72)
        button_exit.TabIndex = 2
        button_exit.Text = "Exit"
        button_exit.UseVisualStyleBackColor = True
        ' 
        ' button_continue
        ' 
        button_continue.Anchor = AnchorStyles.Bottom
        button_continue.Location = New Point(544, 377)
        button_continue.Margin = New Padding(3, 4, 3, 4)
        button_continue.Name = "button_continue"
        button_continue.Size = New Size(111, 72)
        button_continue.TabIndex = 3
        button_continue.Text = "Continue"
        button_continue.UseVisualStyleBackColor = True
        ' 
        ' button_reset
        ' 
        button_reset.Anchor = AnchorStyles.Bottom
        button_reset.Location = New Point(398, 457)
        button_reset.Margin = New Padding(3, 4, 3, 4)
        button_reset.Name = "button_reset"
        button_reset.Size = New Size(111, 72)
        button_reset.TabIndex = 4
        button_reset.Text = "Reset"
        button_reset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(button_reset)
        Controls.Add(button_continue)
        Controls.Add(button_exit)
        Controls.Add(button_showprime)
        Controls.Add(Listbox_primenum)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Print Prime Numbers between 1 and 100"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Listbox_primenum As ListBox
    Friend WithEvents button_showprime As Button
    Friend WithEvents button_exit As Button
    Friend WithEvents button_continue As Button
    Friend WithEvents button_reset As Button

End Class

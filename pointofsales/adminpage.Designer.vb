<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminpage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.addcashier_btn = New System.Windows.Forms.Button()
        Me.attendance_btn = New System.Windows.Forms.Button()
        Me.editcashier_btn = New System.Windows.Forms.Button()
        Me.deletecashier_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.accountadmin_btn = New System.Windows.Forms.Button()
        Me.report_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Page"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(221, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 257)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Location = New System.Drawing.Point(51, 170)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(383, 51)
        Me.Panel3.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(260, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Summary of Items"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(98, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "EDIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(179, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Items"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.addcashier_btn)
        Me.Panel2.Controls.Add(Me.attendance_btn)
        Me.Panel2.Controls.Add(Me.editcashier_btn)
        Me.Panel2.Controls.Add(Me.deletecashier_btn)
        Me.Panel2.Location = New System.Drawing.Point(51, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(383, 51)
        Me.Panel2.TabIndex = 2
        '
        'addcashier_btn
        '
        Me.addcashier_btn.Location = New System.Drawing.Point(17, 14)
        Me.addcashier_btn.Name = "addcashier_btn"
        Me.addcashier_btn.Size = New System.Drawing.Size(75, 23)
        Me.addcashier_btn.TabIndex = 1
        Me.addcashier_btn.Text = "ADD"
        Me.addcashier_btn.UseVisualStyleBackColor = True
        '
        'attendance_btn
        '
        Me.attendance_btn.Location = New System.Drawing.Point(260, 14)
        Me.attendance_btn.Name = "attendance_btn"
        Me.attendance_btn.Size = New System.Drawing.Size(110, 23)
        Me.attendance_btn.TabIndex = 1
        Me.attendance_btn.Text = "ATTENDANCE"
        Me.attendance_btn.UseVisualStyleBackColor = True
        '
        'editcashier_btn
        '
        Me.editcashier_btn.Location = New System.Drawing.Point(98, 14)
        Me.editcashier_btn.Name = "editcashier_btn"
        Me.editcashier_btn.Size = New System.Drawing.Size(75, 23)
        Me.editcashier_btn.TabIndex = 1
        Me.editcashier_btn.Text = "EDIT"
        Me.editcashier_btn.UseVisualStyleBackColor = True
        '
        'deletecashier_btn
        '
        Me.deletecashier_btn.Location = New System.Drawing.Point(179, 14)
        Me.deletecashier_btn.Name = "deletecashier_btn"
        Me.deletecashier_btn.Size = New System.Drawing.Size(75, 23)
        Me.deletecashier_btn.TabIndex = 1
        Me.deletecashier_btn.Text = "DELETE"
        Me.deletecashier_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cashier's Info"
        '
        'accountadmin_btn
        '
        Me.accountadmin_btn.Location = New System.Drawing.Point(61, 81)
        Me.accountadmin_btn.Name = "accountadmin_btn"
        Me.accountadmin_btn.Size = New System.Drawing.Size(86, 23)
        Me.accountadmin_btn.TabIndex = 2
        Me.accountadmin_btn.Text = "My Account"
        Me.accountadmin_btn.UseVisualStyleBackColor = True
        '
        'report_btn
        '
        Me.report_btn.Location = New System.Drawing.Point(61, 136)
        Me.report_btn.Name = "report_btn"
        Me.report_btn.Size = New System.Drawing.Size(86, 23)
        Me.report_btn.TabIndex = 3
        Me.report_btn.Text = "Sales Report"
        Me.report_btn.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(65, 197)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.exit_btn.TabIndex = 4
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'adminpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pointofsales.My.Resources.Resources.download
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(686, 281)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.report_btn)
        Me.Controls.Add(Me.accountadmin_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminpage"
        Me.Text = "adminpage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents addcashier_btn As System.Windows.Forms.Button
    Friend WithEvents attendance_btn As System.Windows.Forms.Button
    Friend WithEvents editcashier_btn As System.Windows.Forms.Button
    Friend WithEvents deletecashier_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents accountadmin_btn As System.Windows.Forms.Button
    Friend WithEvents report_btn As System.Windows.Forms.Button
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

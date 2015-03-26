<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editpassadm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.conpas_txt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cashier_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.npass_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cupass_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pass_btn = New System.Windows.Forms.Button()
        Me.posi_btn = New System.Windows.Forms.Button()
        Me.cashadd_btn = New System.Windows.Forms.Button()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.savepass_btn = New System.Windows.Forms.Button()
        Me.list = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.backbtn)
        Me.Panel1.Controls.Add(Me.savepass_btn)
        Me.Panel1.Location = New System.Drawing.Point(21, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 267)
        Me.Panel1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.conpas_txt)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.cashier_id)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.npass_txt)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.cupass_txt)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(150, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 206)
        Me.Panel3.TabIndex = 7
        '
        'conpas_txt
        '
        Me.conpas_txt.Location = New System.Drawing.Point(128, 162)
        Me.conpas_txt.Name = "conpas_txt"
        Me.conpas_txt.Size = New System.Drawing.Size(145, 20)
        Me.conpas_txt.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(35, 165)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Confirm Password"
        '
        'cashier_id
        '
        Me.cashier_id.Location = New System.Drawing.Point(128, 73)
        Me.cashier_id.Name = "cashier_id"
        Me.cashier_id.Size = New System.Drawing.Size(145, 20)
        Me.cashier_id.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Select  Cashier ID"
        '
        'npass_txt
        '
        Me.npass_txt.Location = New System.Drawing.Point(128, 129)
        Me.npass_txt.Name = "npass_txt"
        Me.npass_txt.Size = New System.Drawing.Size(145, 20)
        Me.npass_txt.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "New Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Password"
        '
        'cupass_txt
        '
        Me.cupass_txt.Location = New System.Drawing.Point(128, 99)
        Me.cupass_txt.Name = "cupass_txt"
        Me.cupass_txt.Size = New System.Drawing.Size(145, 20)
        Me.cupass_txt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Current Password"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.pass_btn)
        Me.Panel2.Controls.Add(Me.posi_btn)
        Me.Panel2.Controls.Add(Me.cashadd_btn)
        Me.Panel2.Location = New System.Drawing.Point(13, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(122, 244)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "What do like to edit ?"
        '
        'pass_btn
        '
        Me.pass_btn.Location = New System.Drawing.Point(22, 171)
        Me.pass_btn.Name = "pass_btn"
        Me.pass_btn.Size = New System.Drawing.Size(75, 23)
        Me.pass_btn.TabIndex = 2
        Me.pass_btn.Text = "Password"
        Me.pass_btn.UseVisualStyleBackColor = True
        '
        'posi_btn
        '
        Me.posi_btn.Location = New System.Drawing.Point(22, 131)
        Me.posi_btn.Name = "posi_btn"
        Me.posi_btn.Size = New System.Drawing.Size(75, 23)
        Me.posi_btn.TabIndex = 1
        Me.posi_btn.Text = "Position"
        Me.posi_btn.UseVisualStyleBackColor = True
        '
        'cashadd_btn
        '
        Me.cashadd_btn.Location = New System.Drawing.Point(22, 91)
        Me.cashadd_btn.Name = "cashadd_btn"
        Me.cashadd_btn.Size = New System.Drawing.Size(75, 23)
        Me.cashadd_btn.TabIndex = 0
        Me.cashadd_btn.Text = "Address"
        Me.cashadd_btn.UseVisualStyleBackColor = True
        '
        'backbtn
        '
        Me.backbtn.Location = New System.Drawing.Point(372, 232)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(75, 23)
        Me.backbtn.TabIndex = 5
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'savepass_btn
        '
        Me.savepass_btn.Location = New System.Drawing.Point(291, 232)
        Me.savepass_btn.Name = "savepass_btn"
        Me.savepass_btn.Size = New System.Drawing.Size(75, 23)
        Me.savepass_btn.TabIndex = 4
        Me.savepass_btn.Text = "Save"
        Me.savepass_btn.UseVisualStyleBackColor = True
        '
        'list
        '
        Me.list.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3})
        Me.list.Location = New System.Drawing.Point(489, 42)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(289, 211)
        Me.list.TabIndex = 9
        Me.list.UseCompatibleStateImageBehavior = False
        Me.list.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID"
        Me.ColumnHeader2.Width = 157
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Password"
        Me.ColumnHeader3.Width = 100
        '
        'editpassadm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pointofsales.My.Resources.Resources.download
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(790, 340)
        Me.Controls.Add(Me.list)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "editpassadm"
        Me.Text = "editpassadm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents npass_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cupass_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pass_btn As System.Windows.Forms.Button
    Friend WithEvents posi_btn As System.Windows.Forms.Button
    Friend WithEvents cashadd_btn As System.Windows.Forms.Button
    Friend WithEvents backbtn As System.Windows.Forms.Button
    Friend WithEvents savepass_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cashier_id As System.Windows.Forms.TextBox
    Friend WithEvents list As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents conpas_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editcashier
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.refbtn = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cashier_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.city_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.st_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.barrang_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pass_btn = New System.Windows.Forms.Button()
        Me.posi_btn = New System.Windows.Forms.Button()
        Me.cashadd_btn = New System.Windows.Forms.Button()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.saveadd_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.refbtn)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.backbtn)
        Me.Panel1.Controls.Add(Me.saveadd_btn)
        Me.Panel1.Location = New System.Drawing.Point(19, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 267)
        Me.Panel1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(456, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Click to Edit"
        '
        'refbtn
        '
        Me.refbtn.Location = New System.Drawing.Point(210, 232)
        Me.refbtn.Name = "refbtn"
        Me.refbtn.Size = New System.Drawing.Size(75, 23)
        Me.refbtn.TabIndex = 9
        Me.refbtn.Text = "Refresh"
        Me.refbtn.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Location = New System.Drawing.Point(456, 54)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(298, 169)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Baranggay"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Street"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "City"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cashier_id)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.city_txt)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.st_txt)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.barrang_txt)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(150, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 206)
        Me.Panel3.TabIndex = 7
        '
        'cashier_id
        '
        Me.cashier_id.Location = New System.Drawing.Point(126, 59)
        Me.cashier_id.Name = "cashier_id"
        Me.cashier_id.Size = New System.Drawing.Size(145, 20)
        Me.cashier_id.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Select  Cashier ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Address Info"
        '
        'city_txt
        '
        Me.city_txt.Location = New System.Drawing.Point(126, 149)
        Me.city_txt.Name = "city_txt"
        Me.city_txt.Size = New System.Drawing.Size(145, 20)
        Me.city_txt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "City"
        '
        'st_txt
        '
        Me.st_txt.Location = New System.Drawing.Point(126, 119)
        Me.st_txt.Name = "st_txt"
        Me.st_txt.Size = New System.Drawing.Size(145, 20)
        Me.st_txt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Street"
        '
        'barrang_txt
        '
        Me.barrang_txt.Location = New System.Drawing.Point(126, 87)
        Me.barrang_txt.Name = "barrang_txt"
        Me.barrang_txt.Size = New System.Drawing.Size(145, 20)
        Me.barrang_txt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Barranggay"
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
        'saveadd_btn
        '
        Me.saveadd_btn.Location = New System.Drawing.Point(291, 232)
        Me.saveadd_btn.Name = "saveadd_btn"
        Me.saveadd_btn.Size = New System.Drawing.Size(75, 23)
        Me.saveadd_btn.TabIndex = 4
        Me.saveadd_btn.Text = "Save"
        Me.saveadd_btn.UseVisualStyleBackColor = True
        '
        'editcashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pointofsales.My.Resources.Resources.download
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(801, 291)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editcashier"
        Me.Text = "editcashier"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents backbtn As System.Windows.Forms.Button
    Friend WithEvents saveadd_btn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents city_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents st_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents barrang_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pass_btn As System.Windows.Forms.Button
    Friend WithEvents posi_btn As System.Windows.Forms.Button
    Friend WithEvents cashadd_btn As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cashier_id As System.Windows.Forms.TextBox
    Friend WithEvents refbtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class

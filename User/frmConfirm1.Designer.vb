<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfirm1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblUSer1 = New System.Windows.Forms.Label()
        Me.cmbyr = New System.Windows.Forms.ComboBox()
        Me.TxtConfirm = New System.Windows.Forms.TextBox()
        Me.LblConfirm = New System.Windows.Forms.Label()
        Me.TxtNewPass = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.TxtStudID = New System.Windows.Forms.TextBox()
        Me.CNCL_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtsection = New System.Windows.Forms.TextBox()
        Me.Txtmname = New System.Windows.Forms.TextBox()
        Me.Txtfname = New System.Windows.Forms.TextBox()
        Me.Txtlname = New System.Windows.Forms.TextBox()
        Me.LblID = New System.Windows.Forms.Label()
        Me.Txtid = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LblUSer1)
        Me.Panel1.Controls.Add(Me.cmbyr)
        Me.Panel1.Controls.Add(Me.TxtConfirm)
        Me.Panel1.Controls.Add(Me.LblConfirm)
        Me.Panel1.Controls.Add(Me.TxtNewPass)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.TxtStudID)
        Me.Panel1.Controls.Add(Me.CNCL_Button)
        Me.Panel1.Controls.Add(Me.OK_Button)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Txtsection)
        Me.Panel1.Controls.Add(Me.Txtmname)
        Me.Panel1.Controls.Add(Me.Txtfname)
        Me.Panel1.Controls.Add(Me.Txtlname)
        Me.Panel1.Controls.Add(Me.LblID)
        Me.Panel1.Controls.Add(Me.Txtid)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 454)
        Me.Panel1.TabIndex = 0
        '
        'LblUSer1
        '
        Me.LblUSer1.AutoSize = True
        Me.LblUSer1.Location = New System.Drawing.Point(334, 368)
        Me.LblUSer1.Name = "LblUSer1"
        Me.LblUSer1.Size = New System.Drawing.Size(0, 13)
        Me.LblUSer1.TabIndex = 82
        Me.LblUSer1.Visible = False
        '
        'cmbyr
        '
        Me.cmbyr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbyr.FormattingEnabled = True
        Me.cmbyr.Items.AddRange(New Object() {"1st yr", "2nd yr", "3rd yr", "4th yr"})
        Me.cmbyr.Location = New System.Drawing.Point(136, 293)
        Me.cmbyr.Name = "cmbyr"
        Me.cmbyr.Size = New System.Drawing.Size(241, 21)
        Me.cmbyr.TabIndex = 8
        '
        'TxtConfirm
        '
        Me.TxtConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConfirm.Location = New System.Drawing.Point(163, 251)
        Me.TxtConfirm.Name = "TxtConfirm"
        Me.TxtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfirm.Size = New System.Drawing.Size(214, 26)
        Me.TxtConfirm.TabIndex = 7
        '
        'LblConfirm
        '
        Me.LblConfirm.AutoSize = True
        Me.LblConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConfirm.ForeColor = System.Drawing.Color.White
        Me.LblConfirm.Location = New System.Drawing.Point(25, 251)
        Me.LblConfirm.Name = "LblConfirm"
        Me.LblConfirm.Size = New System.Drawing.Size(137, 20)
        Me.LblConfirm.TabIndex = 81
        Me.LblConfirm.Text = "Confirm Password"
        '
        'TxtNewPass
        '
        Me.TxtNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNewPass.Location = New System.Drawing.Point(144, 209)
        Me.TxtNewPass.Name = "TxtNewPass"
        Me.TxtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtNewPass.Size = New System.Drawing.Size(232, 26)
        Me.TxtNewPass.TabIndex = 6
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(25, 212)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(113, 20)
        Me.lblPassword.TabIndex = 79
        Me.lblPassword.Text = "New Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(25, 169)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(87, 20)
        Me.lblUsername.TabIndex = 76
        Me.lblUsername.Text = "Student ID"
        '
        'TxtStudID
        '
        Me.TxtStudID.Location = New System.Drawing.Point(141, 169)
        Me.TxtStudID.MaxLength = 13
        Me.TxtStudID.Name = "TxtStudID"
        Me.TxtStudID.Size = New System.Drawing.Size(235, 20)
        Me.TxtStudID.TabIndex = 5
        '
        'CNCL_Button
        '
        Me.CNCL_Button.Location = New System.Drawing.Point(290, 394)
        Me.CNCL_Button.Name = "CNCL_Button"
        Me.CNCL_Button.Size = New System.Drawing.Size(97, 34)
        Me.CNCL_Button.TabIndex = 74
        Me.CNCL_Button.Text = "Cancel"
        Me.CNCL_Button.UseVisualStyleBackColor = True
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(173, 394)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(97, 34)
        Me.OK_Button.TabIndex = 73
        Me.OK_Button.Text = "Ok"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(26, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Section"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(26, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(26, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(26, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(26, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Last Name"
        '
        'Txtsection
        '
        Me.Txtsection.Location = New System.Drawing.Point(142, 332)
        Me.Txtsection.Name = "Txtsection"
        Me.Txtsection.Size = New System.Drawing.Size(235, 20)
        Me.Txtsection.TabIndex = 9
        '
        'Txtmname
        '
        Me.Txtmname.Location = New System.Drawing.Point(141, 130)
        Me.Txtmname.Name = "Txtmname"
        Me.Txtmname.Size = New System.Drawing.Size(235, 20)
        Me.Txtmname.TabIndex = 4
        '
        'Txtfname
        '
        Me.Txtfname.Location = New System.Drawing.Point(141, 94)
        Me.Txtfname.Name = "Txtfname"
        Me.Txtfname.Size = New System.Drawing.Size(235, 20)
        Me.Txtfname.TabIndex = 3
        '
        'Txtlname
        '
        Me.Txtlname.Location = New System.Drawing.Point(141, 56)
        Me.Txtlname.Name = "Txtlname"
        Me.Txtlname.Size = New System.Drawing.Size(235, 20)
        Me.Txtlname.TabIndex = 2
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.ForeColor = System.Drawing.SystemColors.Control
        Me.LblID.Location = New System.Drawing.Point(26, 19)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(24, 18)
        Me.LblID.TabIndex = 62
        Me.LblID.Text = "ID"
        '
        'Txtid
        '
        Me.Txtid.Enabled = False
        Me.Txtid.Location = New System.Drawing.Point(141, 19)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.Size = New System.Drawing.Size(235, 20)
        Me.Txtid.TabIndex = 1
        '
        'frmConfirm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(441, 481)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfirm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Confirm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Txtid As System.Windows.Forms.TextBox
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtsection As System.Windows.Forms.TextBox
    Friend WithEvents Txtmname As System.Windows.Forms.TextBox
    Friend WithEvents Txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Txtlname As System.Windows.Forms.TextBox
    Friend WithEvents CNCL_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents TxtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents LblConfirm As System.Windows.Forms.Label
    Friend WithEvents TxtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents TxtStudID As System.Windows.Forms.TextBox
    Friend WithEvents cmbyr As System.Windows.Forms.ComboBox
    Friend WithEvents LblUSer1 As System.Windows.Forms.Label
End Class

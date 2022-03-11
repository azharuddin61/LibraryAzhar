<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSending
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSending))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnBck1 = New System.Windows.Forms.Button()
        Me.cmdsend = New System.Windows.Forms.Button()
        Me.Txtmessage = New System.Windows.Forms.TextBox()
        Me.Txtnumber = New System.Windows.Forms.TextBox()
        Me.cmbConnect = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnBck1)
        Me.Panel1.Controls.Add(Me.cmdsend)
        Me.Panel1.Controls.Add(Me.Txtmessage)
        Me.Panel1.Controls.Add(Me.Txtnumber)
        Me.Panel1.Controls.Add(Me.cmbConnect)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 321)
        Me.Panel1.TabIndex = 0
        '
        'BtnBck1
        '
        Me.BtnBck1.Location = New System.Drawing.Point(254, 269)
        Me.BtnBck1.Name = "BtnBck1"
        Me.BtnBck1.Size = New System.Drawing.Size(71, 23)
        Me.BtnBck1.TabIndex = 8
        Me.BtnBck1.Text = "Back"
        Me.BtnBck1.UseVisualStyleBackColor = True
        '
        'cmdsend
        '
        Me.cmdsend.Location = New System.Drawing.Point(167, 269)
        Me.cmdsend.Name = "cmdsend"
        Me.cmdsend.Size = New System.Drawing.Size(75, 23)
        Me.cmdsend.TabIndex = 7
        Me.cmdsend.Text = "Send"
        Me.cmdsend.UseVisualStyleBackColor = True
        '
        'Txtmessage
        '
        Me.Txtmessage.Location = New System.Drawing.Point(30, 165)
        Me.Txtmessage.Multiline = True
        Me.Txtmessage.Name = "Txtmessage"
        Me.Txtmessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtmessage.Size = New System.Drawing.Size(294, 98)
        Me.Txtmessage.TabIndex = 6
        '
        'Txtnumber
        '
        Me.Txtnumber.Location = New System.Drawing.Point(32, 129)
        Me.Txtnumber.Name = "Txtnumber"
        Me.Txtnumber.Size = New System.Drawing.Size(294, 20)
        Me.Txtnumber.TabIndex = 5
        '
        'cmbConnect
        '
        Me.cmbConnect.Location = New System.Drawing.Point(27, 85)
        Me.cmbConnect.Name = "cmbConnect"
        Me.cmbConnect.Size = New System.Drawing.Size(76, 26)
        Me.cmbConnect.TabIndex = 4
        Me.cmbConnect.Text = "Connect"
        Me.cmbConnect.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(106, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(27, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Status"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(27, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(300, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'frmSending
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(401, 346)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSending"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSending"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbConnect As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents cmdsend As System.Windows.Forms.Button
    Friend WithEvents Txtmessage As System.Windows.Forms.TextBox
    Friend WithEvents BtnBck1 As System.Windows.Forms.Button
    Public WithEvents Txtnumber As System.Windows.Forms.TextBox
End Class

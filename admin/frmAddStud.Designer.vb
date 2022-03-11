<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStud
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
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.lblUSer1 = New System.Windows.Forms.Label()
        Me.cmbyr = New System.Windows.Forms.ComboBox()
        Me.TxtSection = New System.Windows.Forms.TextBox()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtStuden = New System.Windows.Forms.TextBox()
        Me.TxtMname = New System.Windows.Forms.TextBox()
        Me.TxtFname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblLastname = New System.Windows.Forms.Label()
        Me.TxtLname = New System.Windows.Forms.TextBox()
        Me.LblID = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Controls.Add(Me.lblUSer1)
        Me.Panel1.Controls.Add(Me.cmbyr)
        Me.Panel1.Controls.Add(Me.TxtSection)
        Me.Panel1.Controls.Add(Me.Txtpass)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtStuden)
        Me.Panel1.Controls.Add(Me.TxtMname)
        Me.Panel1.Controls.Add(Me.TxtFname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblLastname)
        Me.Panel1.Controls.Add(Me.TxtLname)
        Me.Panel1.Controls.Add(Me.LblID)
        Me.Panel1.Controls.Add(Me.TxtID)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 225)
        Me.Panel1.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(636, 174)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(78, 32)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(540, 173)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(78, 34)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'lblUSer1
        '
        Me.lblUSer1.AutoSize = True
        Me.lblUSer1.Location = New System.Drawing.Point(506, 13)
        Me.lblUSer1.Name = "lblUSer1"
        Me.lblUSer1.Size = New System.Drawing.Size(0, 13)
        Me.lblUSer1.TabIndex = 39
        Me.lblUSer1.Visible = False
        '
        'cmbyr
        '
        Me.cmbyr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbyr.FormattingEnabled = True
        Me.cmbyr.Items.AddRange(New Object() {"1st yr", "2nd yr", "3rd yr", "4th yr"})
        Me.cmbyr.Location = New System.Drawing.Point(473, 91)
        Me.cmbyr.Name = "cmbyr"
        Me.cmbyr.Size = New System.Drawing.Size(241, 21)
        Me.cmbyr.TabIndex = 7
        '
        'TxtSection
        '
        Me.TxtSection.Location = New System.Drawing.Point(473, 126)
        Me.TxtSection.Name = "TxtSection"
        Me.TxtSection.Size = New System.Drawing.Size(241, 20)
        Me.TxtSection.TabIndex = 8
        '
        'Txtpass
        '
        Me.Txtpass.Location = New System.Drawing.Point(473, 59)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.Size = New System.Drawing.Size(241, 20)
        Me.Txtpass.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(352, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Section"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(352, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(352, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(352, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Student Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(24, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Middle Name"
        '
        'TxtStuden
        '
        Me.TxtStuden.Location = New System.Drawing.Point(473, 26)
        Me.TxtStuden.Name = "TxtStuden"
        Me.TxtStuden.Size = New System.Drawing.Size(241, 20)
        Me.TxtStuden.TabIndex = 5
        '
        'TxtMname
        '
        Me.TxtMname.Location = New System.Drawing.Point(127, 130)
        Me.TxtMname.Name = "TxtMname"
        Me.TxtMname.Size = New System.Drawing.Size(186, 20)
        Me.TxtMname.TabIndex = 4
        '
        'TxtFname
        '
        Me.TxtFname.Location = New System.Drawing.Point(128, 96)
        Me.TxtFname.Name = "TxtFname"
        Me.TxtFname.Size = New System.Drawing.Size(185, 20)
        Me.TxtFname.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(24, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "First Name"
        '
        'LblLastname
        '
        Me.LblLastname.AutoSize = True
        Me.LblLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLastname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblLastname.Location = New System.Drawing.Point(24, 63)
        Me.LblLastname.Name = "LblLastname"
        Me.LblLastname.Size = New System.Drawing.Size(82, 16)
        Me.LblLastname.TabIndex = 32
        Me.LblLastname.Text = "Last Name"
        '
        'TxtLname
        '
        Me.TxtLname.Location = New System.Drawing.Point(127, 63)
        Me.TxtLname.Name = "TxtLname"
        Me.TxtLname.Size = New System.Drawing.Size(186, 20)
        Me.TxtLname.TabIndex = 2
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblID.Location = New System.Drawing.Point(24, 26)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(27, 16)
        Me.LblID.TabIndex = 29
        Me.LblID.Text = "ID "
        '
        'TxtID
        '
        Me.TxtID.Enabled = False
        Me.TxtID.Location = New System.Drawing.Point(127, 27)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(186, 20)
        Me.TxtID.TabIndex = 1
        '
        'frmAddStud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(777, 253)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAddStud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Student"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents lblUSer1 As System.Windows.Forms.Label
    Friend WithEvents cmbyr As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSection As System.Windows.Forms.TextBox
    Friend WithEvents Txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtStuden As System.Windows.Forms.TextBox
    Friend WithEvents TxtMname As System.Windows.Forms.TextBox
    Friend WithEvents TxtFname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblLastname As System.Windows.Forms.Label
    Friend WithEvents TxtLname As System.Windows.Forms.TextBox
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
End Class

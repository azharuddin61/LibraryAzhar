<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoveborrow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMoveborrow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblBookid = New System.Windows.Forms.Label()
        Me.TxtCopies = New System.Windows.Forms.TextBox()
        Me.TxtAuthorname = New System.Windows.Forms.TextBox()
        Me.TxtReserveName = New System.Windows.Forms.TextBox()
        Me.TxtBookTle = New System.Windows.Forms.TextBox()
        Me.TxtContact = New System.Windows.Forms.TextBox()
        Me.TxtBookid = New System.Windows.Forms.TextBox()
        Me.TxtRiD = New System.Windows.Forms.TextBox()
        Me.Bck = New System.Windows.Forms.Button()
        Me.MTB = New System.Windows.Forms.Button()
        Me.datereturn = New System.Windows.Forms.Label()
        Me.LblPickup = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.datereturn)
        Me.Panel1.Controls.Add(Me.LblPickup)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblBookid)
        Me.Panel1.Controls.Add(Me.TxtCopies)
        Me.Panel1.Controls.Add(Me.TxtAuthorname)
        Me.Panel1.Controls.Add(Me.TxtReserveName)
        Me.Panel1.Controls.Add(Me.TxtBookTle)
        Me.Panel1.Controls.Add(Me.TxtContact)
        Me.Panel1.Controls.Add(Me.TxtBookid)
        Me.Panel1.Controls.Add(Me.TxtRiD)
        Me.Panel1.Controls.Add(Me.Bck)
        Me.Panel1.Controls.Add(Me.MTB)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(583, 338)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(20, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Number Copies"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(287, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Author Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(307, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Book Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(307, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Book ID "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(20, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Reserve Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(20, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Contact No"
        '
        'LblBookid
        '
        Me.LblBookid.AutoSize = True
        Me.LblBookid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBookid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblBookid.Location = New System.Drawing.Point(20, 25)
        Me.LblBookid.Name = "LblBookid"
        Me.LblBookid.Size = New System.Drawing.Size(90, 16)
        Me.LblBookid.TabIndex = 25
        Me.LblBookid.Text = "Reserve ID "
        '
        'TxtCopies
        '
        Me.TxtCopies.Location = New System.Drawing.Point(158, 200)
        Me.TxtCopies.Name = "TxtCopies"
        Me.TxtCopies.Size = New System.Drawing.Size(173, 20)
        Me.TxtCopies.TabIndex = 24
        '
        'TxtAuthorname
        '
        Me.TxtAuthorname.Enabled = False
        Me.TxtAuthorname.Location = New System.Drawing.Point(390, 143)
        Me.TxtAuthorname.Name = "TxtAuthorname"
        Me.TxtAuthorname.Size = New System.Drawing.Size(173, 20)
        Me.TxtAuthorname.TabIndex = 22
        '
        'TxtReserveName
        '
        Me.TxtReserveName.Location = New System.Drawing.Point(138, 143)
        Me.TxtReserveName.Name = "TxtReserveName"
        Me.TxtReserveName.Size = New System.Drawing.Size(144, 20)
        Me.TxtReserveName.TabIndex = 21
        '
        'TxtBookTle
        '
        Me.TxtBookTle.Enabled = False
        Me.TxtBookTle.Location = New System.Drawing.Point(390, 84)
        Me.TxtBookTle.Name = "TxtBookTle"
        Me.TxtBookTle.Size = New System.Drawing.Size(173, 20)
        Me.TxtBookTle.TabIndex = 20
        '
        'TxtContact
        '
        Me.TxtContact.Location = New System.Drawing.Point(109, 84)
        Me.TxtContact.MaxLength = 13
        Me.TxtContact.Name = "TxtContact"
        Me.TxtContact.Size = New System.Drawing.Size(173, 20)
        Me.TxtContact.TabIndex = 19
        '
        'TxtBookid
        '
        Me.TxtBookid.Enabled = False
        Me.TxtBookid.Location = New System.Drawing.Point(390, 25)
        Me.TxtBookid.Name = "TxtBookid"
        Me.TxtBookid.Size = New System.Drawing.Size(173, 20)
        Me.TxtBookid.TabIndex = 18
        '
        'TxtRiD
        '
        Me.TxtRiD.Enabled = False
        Me.TxtRiD.Location = New System.Drawing.Point(109, 25)
        Me.TxtRiD.Name = "TxtRiD"
        Me.TxtRiD.Size = New System.Drawing.Size(173, 20)
        Me.TxtRiD.TabIndex = 17
        '
        'Bck
        '
        Me.Bck.Location = New System.Drawing.Point(453, 273)
        Me.Bck.Name = "Bck"
        Me.Bck.Size = New System.Drawing.Size(75, 40)
        Me.Bck.TabIndex = 16
        Me.Bck.Text = "Back"
        Me.Bck.UseVisualStyleBackColor = True
        '
        'MTB
        '
        Me.MTB.Location = New System.Drawing.Point(348, 273)
        Me.MTB.Name = "MTB"
        Me.MTB.Size = New System.Drawing.Size(75, 40)
        Me.MTB.TabIndex = 15
        Me.MTB.Text = "Move to Borrow"
        Me.MTB.UseVisualStyleBackColor = True
        '
        'datereturn
        '
        Me.datereturn.AutoSize = True
        Me.datereturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datereturn.ForeColor = System.Drawing.SystemColors.Control
        Me.datereturn.Location = New System.Drawing.Point(20, 295)
        Me.datereturn.Name = "datereturn"
        Me.datereturn.Size = New System.Drawing.Size(125, 18)
        Me.datereturn.TabIndex = 79
        Me.datereturn.Text = "DATE RETURN"
        '
        'LblPickup
        '
        Me.LblPickup.AutoSize = True
        Me.LblPickup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPickup.ForeColor = System.Drawing.SystemColors.Control
        Me.LblPickup.Location = New System.Drawing.Point(20, 245)
        Me.LblPickup.Name = "LblPickup"
        Me.LblPickup.Size = New System.Drawing.Size(59, 18)
        Me.LblPickup.TabIndex = 78
        Me.LblPickup.Text = "Pickup"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(158, 242)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 80
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(158, 293)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 81
        '
        'frmMoveborrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(608, 363)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMoveborrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMoveborrow"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblBookid As System.Windows.Forms.Label
    Friend WithEvents TxtCopies As System.Windows.Forms.TextBox
    Friend WithEvents TxtAuthorname As System.Windows.Forms.TextBox
    Friend WithEvents TxtReserveName As System.Windows.Forms.TextBox
    Friend WithEvents TxtBookTle As System.Windows.Forms.TextBox
    Friend WithEvents TxtContact As System.Windows.Forms.TextBox
    Friend WithEvents TxtBookid As System.Windows.Forms.TextBox
    Friend WithEvents TxtRiD As System.Windows.Forms.TextBox
    Friend WithEvents Bck As System.Windows.Forms.Button
    Friend WithEvents MTB As System.Windows.Forms.Button
    Friend WithEvents datereturn As System.Windows.Forms.Label
    Friend WithEvents LblPickup As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class

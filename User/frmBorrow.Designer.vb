<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtAuthor = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.btnbck = New System.Windows.Forms.Button()
        Me.BtnBorrow = New System.Windows.Forms.Button()
        Me.TxtNumberCopies = New System.Windows.Forms.TextBox()
        Me.TxtBookname = New System.Windows.Forms.TextBox()
        Me.TxtBookid = New System.Windows.Forms.TextBox()
        Me.TxtBorrowname = New System.Windows.Forms.TextBox()
        Me.TxtContact = New System.Windows.Forms.TextBox()
        Me.TxtBorrowId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datereturn = New System.Windows.Forms.Label()
        Me.DateTimePicker_pickup = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DateTimePicker_pickup)
        Me.Panel1.Controls.Add(Me.datereturn)
        Me.Panel1.Controls.Add(Me.TxtAuthor)
        Me.Panel1.Controls.Add(Me.lblQty)
        Me.Panel1.Controls.Add(Me.btnbck)
        Me.Panel1.Controls.Add(Me.BtnBorrow)
        Me.Panel1.Controls.Add(Me.TxtNumberCopies)
        Me.Panel1.Controls.Add(Me.TxtBookname)
        Me.Panel1.Controls.Add(Me.TxtBookid)
        Me.Panel1.Controls.Add(Me.TxtBorrowname)
        Me.Panel1.Controls.Add(Me.TxtContact)
        Me.Panel1.Controls.Add(Me.TxtBorrowId)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.LblAuthor)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 371)
        Me.Panel1.TabIndex = 0
        '
        'TxtAuthor
        '
        Me.TxtAuthor.Enabled = False
        Me.TxtAuthor.Location = New System.Drawing.Point(208, 203)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.Size = New System.Drawing.Size(306, 20)
        Me.TxtAuthor.TabIndex = 72
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.ForeColor = System.Drawing.SystemColors.Control
        Me.lblQty.Location = New System.Drawing.Point(36, 302)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(0, 13)
        Me.lblQty.TabIndex = 71
        Me.lblQty.Visible = False
        '
        'btnbck
        '
        Me.btnbck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbck.Location = New System.Drawing.Point(436, 302)
        Me.btnbck.Name = "btnbck"
        Me.btnbck.Size = New System.Drawing.Size(77, 37)
        Me.btnbck.TabIndex = 70
        Me.btnbck.Text = "Back"
        Me.btnbck.UseVisualStyleBackColor = True
        '
        'BtnBorrow
        '
        Me.BtnBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrow.Location = New System.Drawing.Point(338, 302)
        Me.BtnBorrow.Name = "BtnBorrow"
        Me.BtnBorrow.Size = New System.Drawing.Size(77, 37)
        Me.BtnBorrow.TabIndex = 69
        Me.BtnBorrow.Text = "Borrow"
        Me.BtnBorrow.UseVisualStyleBackColor = True
        '
        'TxtNumberCopies
        '
        Me.TxtNumberCopies.Location = New System.Drawing.Point(205, 238)
        Me.TxtNumberCopies.Name = "TxtNumberCopies"
        Me.TxtNumberCopies.Size = New System.Drawing.Size(306, 20)
        Me.TxtNumberCopies.TabIndex = 60
        '
        'TxtBookname
        '
        Me.TxtBookname.Enabled = False
        Me.TxtBookname.Location = New System.Drawing.Point(208, 165)
        Me.TxtBookname.Name = "TxtBookname"
        Me.TxtBookname.Size = New System.Drawing.Size(306, 20)
        Me.TxtBookname.TabIndex = 57
        '
        'TxtBookid
        '
        Me.TxtBookid.Enabled = False
        Me.TxtBookid.Location = New System.Drawing.Point(208, 129)
        Me.TxtBookid.Name = "TxtBookid"
        Me.TxtBookid.Size = New System.Drawing.Size(306, 20)
        Me.TxtBookid.TabIndex = 56
        '
        'TxtBorrowname
        '
        Me.TxtBorrowname.Enabled = False
        Me.TxtBorrowname.Location = New System.Drawing.Point(208, 96)
        Me.TxtBorrowname.Name = "TxtBorrowname"
        Me.TxtBorrowname.Size = New System.Drawing.Size(306, 20)
        Me.TxtBorrowname.TabIndex = 55
        '
        'TxtContact
        '
        Me.TxtContact.Location = New System.Drawing.Point(208, 63)
        Me.TxtContact.MaxLength = 13
        Me.TxtContact.Name = "TxtContact"
        Me.TxtContact.Size = New System.Drawing.Size(306, 20)
        Me.TxtContact.TabIndex = 54
        '
        'TxtBorrowId
        '
        Me.TxtBorrowId.Enabled = False
        Me.TxtBorrowId.Location = New System.Drawing.Point(208, 27)
        Me.TxtBorrowId.Name = "TxtBorrowId"
        Me.TxtBorrowId.Size = New System.Drawing.Size(306, 20)
        Me.TxtBorrowId.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(36, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 18)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Number of Copies"
        '
        'LblAuthor
        '
        Me.LblAuthor.AutoSize = True
        Me.LblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAuthor.ForeColor = System.Drawing.SystemColors.Control
        Me.LblAuthor.Location = New System.Drawing.Point(36, 202)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(106, 18)
        Me.LblAuthor.TabIndex = 66
        Me.LblAuthor.Text = "Author Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(36, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 18)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Book Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(36, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Book ID "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(36, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Borrow Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(36, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Contact No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(36, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Borrow ID"
        '
        'datereturn
        '
        Me.datereturn.AutoSize = True
        Me.datereturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datereturn.ForeColor = System.Drawing.SystemColors.Control
        Me.datereturn.Location = New System.Drawing.Point(36, 270)
        Me.datereturn.Name = "datereturn"
        Me.datereturn.Size = New System.Drawing.Size(125, 18)
        Me.datereturn.TabIndex = 73
        Me.datereturn.Text = "DATE RETURN"
        '
        'DateTimePicker_pickup
        '
        Me.DateTimePicker_pickup.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_pickup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_pickup.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_pickup.Location = New System.Drawing.Point(381, 270)
        Me.DateTimePicker_pickup.Name = "DateTimePicker_pickup"
        Me.DateTimePicker_pickup.Size = New System.Drawing.Size(130, 26)
        Me.DateTimePicker_pickup.TabIndex = 74
        '
        'frmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(576, 399)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBorrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBorrow"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents btnbck As System.Windows.Forms.Button
    Friend WithEvents BtnBorrow As System.Windows.Forms.Button
    Friend WithEvents TxtNumberCopies As System.Windows.Forms.TextBox
    Friend WithEvents TxtBookname As System.Windows.Forms.TextBox
    Friend WithEvents TxtBookid As System.Windows.Forms.TextBox
    Friend WithEvents TxtBorrowname As System.Windows.Forms.TextBox
    Friend WithEvents TxtContact As System.Windows.Forms.TextBox
    Friend WithEvents TxtBorrowId As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblAuthor As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents datereturn As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_pickup As System.Windows.Forms.DateTimePicker
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReserve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReserve))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtAuthor = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.btnbck = New System.Windows.Forms.Button()
        Me.BtnReserve = New System.Windows.Forms.Button()
        Me.DateTimePicker_pickup = New System.Windows.Forms.DateTimePicker()
        Me.TxtNumberCopies = New System.Windows.Forms.TextBox()
        Me.TxtBookname = New System.Windows.Forms.TextBox()
        Me.TxtBookid = New System.Windows.Forms.TextBox()
        Me.TxtReserveName = New System.Windows.Forms.TextBox()
        Me.TxtContact = New System.Windows.Forms.TextBox()
        Me.TxtReserveId = New System.Windows.Forms.TextBox()
        Me.LblNumber = New System.Windows.Forms.Label()
        Me.LblPickup = New System.Windows.Forms.Label()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.LblBname = New System.Windows.Forms.Label()
        Me.LblBID = New System.Windows.Forms.Label()
        Me.LblRname = New System.Windows.Forms.Label()
        Me.LblContact = New System.Windows.Forms.Label()
        Me.LblRID = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.datereturn = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.datereturn)
        Me.Panel1.Controls.Add(Me.TxtAuthor)
        Me.Panel1.Controls.Add(Me.lblQty)
        Me.Panel1.Controls.Add(Me.btnbck)
        Me.Panel1.Controls.Add(Me.BtnReserve)
        Me.Panel1.Controls.Add(Me.DateTimePicker_pickup)
        Me.Panel1.Controls.Add(Me.TxtNumberCopies)
        Me.Panel1.Controls.Add(Me.TxtBookname)
        Me.Panel1.Controls.Add(Me.TxtBookid)
        Me.Panel1.Controls.Add(Me.TxtReserveName)
        Me.Panel1.Controls.Add(Me.TxtContact)
        Me.Panel1.Controls.Add(Me.TxtReserveId)
        Me.Panel1.Controls.Add(Me.LblNumber)
        Me.Panel1.Controls.Add(Me.LblPickup)
        Me.Panel1.Controls.Add(Me.LblAuthor)
        Me.Panel1.Controls.Add(Me.LblBname)
        Me.Panel1.Controls.Add(Me.LblBID)
        Me.Panel1.Controls.Add(Me.LblRname)
        Me.Panel1.Controls.Add(Me.LblContact)
        Me.Panel1.Controls.Add(Me.LblRID)
        Me.Panel1.Location = New System.Drawing.Point(13, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 391)
        Me.Panel1.TabIndex = 1
        '
        'TxtAuthor
        '
        Me.TxtAuthor.Enabled = False
        Me.TxtAuthor.Location = New System.Drawing.Point(208, 200)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.Size = New System.Drawing.Size(306, 20)
        Me.TxtAuthor.TabIndex = 72
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.ForeColor = System.Drawing.SystemColors.Control
        Me.lblQty.Location = New System.Drawing.Point(36, 340)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(0, 13)
        Me.lblQty.TabIndex = 71
        Me.lblQty.Visible = False
        '
        'btnbck
        '
        Me.btnbck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbck.Location = New System.Drawing.Point(437, 328)
        Me.btnbck.Name = "btnbck"
        Me.btnbck.Size = New System.Drawing.Size(77, 37)
        Me.btnbck.TabIndex = 70
        Me.btnbck.Text = "Back"
        Me.btnbck.UseVisualStyleBackColor = True
        '
        'BtnReserve
        '
        Me.BtnReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReserve.Location = New System.Drawing.Point(342, 328)
        Me.BtnReserve.Name = "BtnReserve"
        Me.BtnReserve.Size = New System.Drawing.Size(77, 37)
        Me.BtnReserve.TabIndex = 69
        Me.BtnReserve.Text = "Reserve"
        Me.BtnReserve.UseVisualStyleBackColor = True
        '
        'DateTimePicker_pickup
        '
        Me.DateTimePicker_pickup.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_pickup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_pickup.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_pickup.Location = New System.Drawing.Point(384, 226)
        Me.DateTimePicker_pickup.Name = "DateTimePicker_pickup"
        Me.DateTimePicker_pickup.Size = New System.Drawing.Size(130, 26)
        Me.DateTimePicker_pickup.TabIndex = 59
        '
        'TxtNumberCopies
        '
        Me.TxtNumberCopies.Location = New System.Drawing.Point(208, 261)
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
        'TxtReserveName
        '
        Me.TxtReserveName.Enabled = False
        Me.TxtReserveName.Location = New System.Drawing.Point(208, 96)
        Me.TxtReserveName.Name = "TxtReserveName"
        Me.TxtReserveName.Size = New System.Drawing.Size(306, 20)
        Me.TxtReserveName.TabIndex = 55
        '
        'TxtContact
        '
        Me.TxtContact.Location = New System.Drawing.Point(208, 63)
        Me.TxtContact.MaxLength = 13
        Me.TxtContact.Name = "TxtContact"
        Me.TxtContact.Size = New System.Drawing.Size(306, 20)
        Me.TxtContact.TabIndex = 54
        '
        'TxtReserveId
        '
        Me.TxtReserveId.Enabled = False
        Me.TxtReserveId.Location = New System.Drawing.Point(208, 27)
        Me.TxtReserveId.Name = "TxtReserveId"
        Me.TxtReserveId.Size = New System.Drawing.Size(306, 20)
        Me.TxtReserveId.TabIndex = 53
        '
        'LblNumber
        '
        Me.LblNumber.AutoSize = True
        Me.LblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumber.ForeColor = System.Drawing.SystemColors.Control
        Me.LblNumber.Location = New System.Drawing.Point(36, 263)
        Me.LblNumber.Name = "LblNumber"
        Me.LblNumber.Size = New System.Drawing.Size(145, 18)
        Me.LblNumber.TabIndex = 68
        Me.LblNumber.Text = "Number of Copies"
        '
        'LblPickup
        '
        Me.LblPickup.AutoSize = True
        Me.LblPickup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPickup.ForeColor = System.Drawing.SystemColors.Control
        Me.LblPickup.Location = New System.Drawing.Point(36, 233)
        Me.LblPickup.Name = "LblPickup"
        Me.LblPickup.Size = New System.Drawing.Size(59, 18)
        Me.LblPickup.TabIndex = 67
        Me.LblPickup.Text = "Pickup"
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
        'LblBname
        '
        Me.LblBname.AutoSize = True
        Me.LblBname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBname.ForeColor = System.Drawing.SystemColors.Control
        Me.LblBname.Location = New System.Drawing.Point(36, 167)
        Me.LblBname.Name = "LblBname"
        Me.LblBname.Size = New System.Drawing.Size(97, 18)
        Me.LblBname.TabIndex = 65
        Me.LblBname.Text = "Book Name"
        '
        'LblBID
        '
        Me.LblBID.AutoSize = True
        Me.LblBID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBID.ForeColor = System.Drawing.SystemColors.Control
        Me.LblBID.Location = New System.Drawing.Point(36, 131)
        Me.LblBID.Name = "LblBID"
        Me.LblBID.Size = New System.Drawing.Size(74, 18)
        Me.LblBID.TabIndex = 64
        Me.LblBID.Text = "Book ID "
        '
        'LblRname
        '
        Me.LblRname.AutoSize = True
        Me.LblRname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRname.ForeColor = System.Drawing.SystemColors.Control
        Me.LblRname.Location = New System.Drawing.Point(36, 98)
        Me.LblRname.Name = "LblRname"
        Me.LblRname.Size = New System.Drawing.Size(119, 18)
        Me.LblRname.TabIndex = 63
        Me.LblRname.Text = "Reserve Name"
        '
        'LblContact
        '
        Me.LblContact.AutoSize = True
        Me.LblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContact.ForeColor = System.Drawing.SystemColors.Control
        Me.LblContact.Location = New System.Drawing.Point(36, 65)
        Me.LblContact.Name = "LblContact"
        Me.LblContact.Size = New System.Drawing.Size(99, 18)
        Me.LblContact.TabIndex = 62
        Me.LblContact.Text = "Contact No."
        '
        'LblRID
        '
        Me.LblRID.AutoSize = True
        Me.LblRID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRID.ForeColor = System.Drawing.SystemColors.Control
        Me.LblRID.Location = New System.Drawing.Point(36, 29)
        Me.LblRID.Name = "LblRID"
        Me.LblRID.Size = New System.Drawing.Size(91, 18)
        Me.LblRID.TabIndex = 61
        Me.LblRID.Text = "Reserve ID"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(384, 291)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(130, 26)
        Me.DateTimePicker1.TabIndex = 76
        '
        'datereturn
        '
        Me.datereturn.AutoSize = True
        Me.datereturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datereturn.ForeColor = System.Drawing.SystemColors.Control
        Me.datereturn.Location = New System.Drawing.Point(36, 291)
        Me.datereturn.Name = "datereturn"
        Me.datereturn.Size = New System.Drawing.Size(125, 18)
        Me.datereturn.TabIndex = 75
        Me.datereturn.Text = "DATE RETURN"
        '
        'frmReserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(576, 421)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReserve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReserve"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents btnbck As System.Windows.Forms.Button
    Friend WithEvents BtnReserve As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker_pickup As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtNumberCopies As System.Windows.Forms.TextBox
    Friend WithEvents TxtBookname As System.Windows.Forms.TextBox
    Friend WithEvents TxtBookid As System.Windows.Forms.TextBox
    Friend WithEvents TxtReserveName As System.Windows.Forms.TextBox
    Friend WithEvents TxtContact As System.Windows.Forms.TextBox
    Friend WithEvents TxtReserveId As System.Windows.Forms.TextBox
    Friend WithEvents LblNumber As System.Windows.Forms.Label
    Friend WithEvents LblPickup As System.Windows.Forms.Label
    Friend WithEvents LblAuthor As System.Windows.Forms.Label
    Friend WithEvents LblBname As System.Windows.Forms.Label
    Friend WithEvents LblBID As System.Windows.Forms.Label
    Friend WithEvents LblRname As System.Windows.Forms.Label
    Friend WithEvents LblContact As System.Windows.Forms.Label
    Friend WithEvents LblRID As System.Windows.Forms.Label
    Friend WithEvents TxtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents datereturn As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdd))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblQty = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.TxtAuthor = New System.Windows.Forms.TextBox()
        Me.BtnBck = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.LblBookName = New System.Windows.Forms.Label()
        Me.LblBookid = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.TxtBookname = New System.Windows.Forms.TextBox()
        Me.TxtBookid = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LblQty)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.LblAuthor)
        Me.Panel1.Controls.Add(Me.TxtAuthor)
        Me.Panel1.Controls.Add(Me.BtnBck)
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Controls.Add(Me.LblQuantity)
        Me.Panel1.Controls.Add(Me.LblCategory)
        Me.Panel1.Controls.Add(Me.LblBookName)
        Me.Panel1.Controls.Add(Me.LblBookid)
        Me.Panel1.Controls.Add(Me.TxtQuantity)
        Me.Panel1.Controls.Add(Me.TxtBookname)
        Me.Panel1.Controls.Add(Me.TxtBookid)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 196)
        Me.Panel1.TabIndex = 0
        '
        'LblQty
        '
        Me.LblQty.AutoSize = True
        Me.LblQty.Location = New System.Drawing.Point(524, 116)
        Me.LblQty.Name = "LblQty"
        Me.LblQty.Size = New System.Drawing.Size(25, 13)
        Me.LblQty.TabIndex = 23
        Me.LblQty.Text = "250"
        Me.LblQty.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(450, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(213, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'LblAuthor
        '
        Me.LblAuthor.AutoSize = True
        Me.LblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAuthor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblAuthor.Location = New System.Drawing.Point(347, 21)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(97, 16)
        Me.LblAuthor.TabIndex = 21
        Me.LblAuthor.Text = "Author Name"
        '
        'TxtAuthor
        '
        Me.TxtAuthor.Location = New System.Drawing.Point(450, 20)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.Size = New System.Drawing.Size(215, 20)
        Me.TxtAuthor.TabIndex = 3
        '
        'BtnBck
        '
        Me.BtnBck.Location = New System.Drawing.Point(588, 146)
        Me.BtnBck.Name = "BtnBck"
        Me.BtnBck.Size = New System.Drawing.Size(75, 33)
        Me.BtnBck.TabIndex = 19
        Me.BtnBck.Text = "Back"
        Me.BtnBck.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(497, 146)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 33)
        Me.BtnAdd.TabIndex = 18
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuantity.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblQuantity.Location = New System.Drawing.Point(173, 117)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(104, 16)
        Me.LblQuantity.TabIndex = 17
        Me.LblQuantity.Text = "Book Quantity"
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblCategory.Location = New System.Drawing.Point(333, 69)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(111, 16)
        Me.LblCategory.TabIndex = 16
        Me.LblCategory.Text = "Book Category"
        '
        'LblBookName
        '
        Me.LblBookName.AutoSize = True
        Me.LblBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBookName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblBookName.Location = New System.Drawing.Point(16, 68)
        Me.LblBookName.Name = "LblBookName"
        Me.LblBookName.Size = New System.Drawing.Size(89, 16)
        Me.LblBookName.TabIndex = 15
        Me.LblBookName.Text = "Book Name"
        '
        'LblBookid
        '
        Me.LblBookid.AutoSize = True
        Me.LblBookid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBookid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblBookid.Location = New System.Drawing.Point(16, 21)
        Me.LblBookid.Name = "LblBookid"
        Me.LblBookid.Size = New System.Drawing.Size(67, 16)
        Me.LblBookid.TabIndex = 14
        Me.LblBookid.Text = "Book ID "
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Location = New System.Drawing.Point(290, 116)
        Me.TxtQuantity.MaxLength = 3
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(215, 20)
        Me.TxtQuantity.TabIndex = 5
        '
        'TxtBookname
        '
        Me.TxtBookname.Location = New System.Drawing.Point(112, 68)
        Me.TxtBookname.Name = "TxtBookname"
        Me.TxtBookname.Size = New System.Drawing.Size(215, 20)
        Me.TxtBookname.TabIndex = 2
        '
        'TxtBookid
        '
        Me.TxtBookid.Location = New System.Drawing.Point(112, 21)
        Me.TxtBookid.Name = "TxtBookid"
        Me.TxtBookid.Size = New System.Drawing.Size(215, 20)
        Me.TxtBookid.TabIndex = 1
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(696, 222)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnBck As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LblQuantity As System.Windows.Forms.Label
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Friend WithEvents LblBookName As System.Windows.Forms.Label
    Friend WithEvents LblBookid As System.Windows.Forms.Label
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents TxtBookname As System.Windows.Forms.TextBox
    Friend WithEvents TxtBookid As System.Windows.Forms.TextBox
    Friend WithEvents LblAuthor As System.Windows.Forms.Label
    Friend WithEvents TxtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LblQty As System.Windows.Forms.Label
End Class

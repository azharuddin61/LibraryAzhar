<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListBook))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lsv1 = New System.Windows.Forms.ListView()
        Me.bk_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bk_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.author_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bk_ctry = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bk_qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnReserve = New System.Windows.Forms.Button()
        Me.BtnBorrow = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Lsv1)
        Me.Panel1.Controls.Add(Me.BtnBack)
        Me.Panel1.Controls.Add(Me.BtnReserve)
        Me.Panel1.Controls.Add(Me.BtnBorrow)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 458)
        Me.Panel1.TabIndex = 0
        '
        'Lsv1
        '
        Me.Lsv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.bk_id, Me.bk_name, Me.author_name, Me.bk_ctry, Me.bk_qty})
        Me.Lsv1.FullRowSelect = True
        Me.Lsv1.GridLines = True
        Me.Lsv1.Location = New System.Drawing.Point(27, 109)
        Me.Lsv1.Name = "Lsv1"
        Me.Lsv1.Size = New System.Drawing.Size(711, 325)
        Me.Lsv1.TabIndex = 24
        Me.Lsv1.UseCompatibleStateImageBehavior = False
        Me.Lsv1.View = System.Windows.Forms.View.Details
        '
        'bk_id
        '
        Me.bk_id.Text = "Book ID "
        Me.bk_id.Width = 65
        '
        'bk_name
        '
        Me.bk_name.Text = "Book Name"
        Me.bk_name.Width = 176
        '
        'author_name
        '
        Me.author_name.Text = "Author Name"
        Me.author_name.Width = 189
        '
        'bk_ctry
        '
        Me.bk_ctry.Text = "Book Category"
        Me.bk_ctry.Width = 151
        '
        'bk_qty
        '
        Me.bk_qty.Text = "Book Quantity"
        Me.bk_qty.Width = 126
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(778, 296)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 58)
        Me.BtnBack.TabIndex = 23
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnReserve
        '
        Me.BtnReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReserve.Location = New System.Drawing.Point(778, 212)
        Me.BtnReserve.Name = "BtnReserve"
        Me.BtnReserve.Size = New System.Drawing.Size(75, 58)
        Me.BtnReserve.TabIndex = 22
        Me.BtnReserve.Text = "Reserve"
        Me.BtnReserve.UseVisualStyleBackColor = True
        '
        'BtnBorrow
        '
        Me.BtnBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrow.Location = New System.Drawing.Point(778, 127)
        Me.BtnBorrow.Name = "BtnBorrow"
        Me.BtnBorrow.Size = New System.Drawing.Size(75, 58)
        Me.BtnBorrow.TabIndex = 21
        Me.BtnBorrow.Text = "Borrow"
        Me.BtnBorrow.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(250, 64)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(294, 20)
        Me.TxtSearch.TabIndex = 20
        '
        'BtnSearch
        '
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(565, 64)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 19
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'frmListBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(902, 487)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListBook"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents BtnReserve As System.Windows.Forms.Button
    Friend WithEvents BtnBorrow As System.Windows.Forms.Button
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents Lsv1 As System.Windows.Forms.ListView
    Friend WithEvents bk_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents bk_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents author_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents bk_ctry As System.Windows.Forms.ColumnHeader
    Friend WithEvents bk_qty As System.Windows.Forms.ColumnHeader
End Class

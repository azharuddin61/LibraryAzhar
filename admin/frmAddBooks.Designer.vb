<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddBooks))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lsv2 = New System.Windows.Forms.ListView()
        Me.book_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bk_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.author_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bk_ctry = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bk_qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnBck = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAddbooks = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Controls.Add(Me.Lsv2)
        Me.Panel1.Controls.Add(Me.BtnBck)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Controls.Add(Me.BtnAddbooks)
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 423)
        Me.Panel1.TabIndex = 1
        '
        'Lsv2
        '
        Me.Lsv2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.book_id, Me.bk_name, Me.author_name, Me.bk_ctry, Me.bk_qty})
        Me.Lsv2.FullRowSelect = True
        Me.Lsv2.GridLines = True
        Me.Lsv2.Location = New System.Drawing.Point(19, 99)
        Me.Lsv2.Name = "Lsv2"
        Me.Lsv2.Size = New System.Drawing.Size(741, 305)
        Me.Lsv2.TabIndex = 9
        Me.Lsv2.UseCompatibleStateImageBehavior = False
        Me.Lsv2.View = System.Windows.Forms.View.Details
        '
        'book_id
        '
        Me.book_id.Text = "Book ID "
        Me.book_id.Width = 62
        '
        'bk_name
        '
        Me.bk_name.Text = "Book Name"
        Me.bk_name.Width = 246
        '
        'author_name
        '
        Me.author_name.Text = "Author Name"
        Me.author_name.Width = 183
        '
        'bk_ctry
        '
        Me.bk_ctry.Text = "Book Category"
        Me.bk_ctry.Width = 150
        '
        'bk_qty
        '
        Me.bk_qty.Text = "Book Quantity"
        Me.bk_qty.Width = 95
        '
        'BtnBck
        '
        Me.BtnBck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBck.Location = New System.Drawing.Point(664, 30)
        Me.BtnBck.Name = "BtnBck"
        Me.BtnBck.Size = New System.Drawing.Size(96, 30)
        Me.BtnBck.TabIndex = 8
        Me.BtnBck.Text = "Back"
        Me.BtnBck.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(562, 30)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(96, 30)
        Me.BtnDelete.TabIndex = 7
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(460, 30)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(96, 30)
        Me.BtnEdit.TabIndex = 6
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnAddbooks
        '
        Me.BtnAddbooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddbooks.Location = New System.Drawing.Point(358, 30)
        Me.BtnAddbooks.Name = "BtnAddbooks"
        Me.BtnAddbooks.Size = New System.Drawing.Size(96, 30)
        Me.BtnAddbooks.TabIndex = 5
        Me.BtnAddbooks.Text = "Add Books"
        Me.BtnAddbooks.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(19, 37)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(215, 20)
        Me.TxtSearch.TabIndex = 10
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(240, 33)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(96, 27)
        Me.BtnSearch.TabIndex = 11
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'frmAddBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(803, 448)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddBooks"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Books"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnBck As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnAddbooks As System.Windows.Forms.Button
    Friend WithEvents Lsv2 As System.Windows.Forms.ListView
    Friend WithEvents book_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents bk_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents author_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents bk_ctry As System.Windows.Forms.ColumnHeader
    Friend WithEvents bk_qty As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
End Class

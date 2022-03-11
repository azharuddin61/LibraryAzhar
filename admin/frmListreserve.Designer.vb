<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListreserve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListreserve))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnData = New System.Windows.Forms.Button()
        Me.Lsv4 = New System.Windows.Forms.ListView()
        Me.reserve_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.contact_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.reserve_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bookid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.booktle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.author_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pickup = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.no_copies = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Btnsearch = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnBack)
        Me.Panel1.Controls.Add(Me.BtnData)
        Me.Panel1.Controls.Add(Me.Lsv4)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Controls.Add(Me.Btnsearch)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(893, 491)
        Me.Panel1.TabIndex = 0
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(801, 193)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 55)
        Me.BtnBack.TabIndex = 5
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnData
        '
        Me.BtnData.Location = New System.Drawing.Point(801, 110)
        Me.BtnData.Name = "BtnData"
        Me.BtnData.Size = New System.Drawing.Size(75, 55)
        Me.BtnData.TabIndex = 4
        Me.BtnData.Text = "Move to Borrow"
        Me.BtnData.UseVisualStyleBackColor = True
        '
        'Lsv4
        '
        Me.Lsv4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.reserve_id, Me.contact_no, Me.reserve_name, Me.bookid, Me.booktle, Me.author_name, Me.pickup, Me.no_copies})
        Me.Lsv4.FullRowSelect = True
        Me.Lsv4.GridLines = True
        Me.Lsv4.Location = New System.Drawing.Point(14, 91)
        Me.Lsv4.Name = "Lsv4"
        Me.Lsv4.Size = New System.Drawing.Size(769, 378)
        Me.Lsv4.TabIndex = 2
        Me.Lsv4.UseCompatibleStateImageBehavior = False
        Me.Lsv4.View = System.Windows.Forms.View.Details
        '
        'reserve_id
        '
        Me.reserve_id.Text = "Reserve ID "
        Me.reserve_id.Width = 73
        '
        'contact_no
        '
        Me.contact_no.Text = "Contact Number"
        Me.contact_no.Width = 100
        '
        'reserve_name
        '
        Me.reserve_name.Text = "Reserve Name"
        Me.reserve_name.Width = 111
        '
        'bookid
        '
        Me.bookid.Text = "Book ID"
        Me.bookid.Width = 58
        '
        'booktle
        '
        Me.booktle.Text = "Book Title"
        Me.booktle.Width = 119
        '
        'author_name
        '
        Me.author_name.Text = "Author Name"
        Me.author_name.Width = 88
        '
        'pickup
        '
        Me.pickup.Text = "Pick Up"
        Me.pickup.Width = 94
        '
        'no_copies
        '
        Me.no_copies.Text = "Number Copies"
        Me.no_copies.Width = 133
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(288, 49)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(249, 20)
        Me.TxtSearch.TabIndex = 1
        '
        'Btnsearch
        '
        Me.Btnsearch.Location = New System.Drawing.Point(557, 49)
        Me.Btnsearch.Name = "Btnsearch"
        Me.Btnsearch.Size = New System.Drawing.Size(70, 22)
        Me.Btnsearch.TabIndex = 0
        Me.Btnsearch.Text = "Search"
        Me.Btnsearch.UseVisualStyleBackColor = True
        '
        'frmListreserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(918, 516)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListreserve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListreserve"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lsv4 As System.Windows.Forms.ListView
    Friend WithEvents reserve_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents contact_no As System.Windows.Forms.ColumnHeader
    Friend WithEvents reserve_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents bookid As System.Windows.Forms.ColumnHeader
    Friend WithEvents booktle As System.Windows.Forms.ColumnHeader
    Friend WithEvents author_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents pickup As System.Windows.Forms.ColumnHeader
    Friend WithEvents no_copies As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Btnsearch As System.Windows.Forms.Button
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents BtnData As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListborrow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListborrow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnBck = New System.Windows.Forms.Button()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.BtnData = New System.Windows.Forms.Button()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.brw_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.contact_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brw_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bookid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.booktle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.author_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.no_copies = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateissue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.datereturn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Txtsearch = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BtnBck)
        Me.Panel1.Controls.Add(Me.BtnReturn)
        Me.Panel1.Controls.Add(Me.BtnData)
        Me.Panel1.Controls.Add(Me.ListView)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.Txtsearch)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1012, 491)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(31, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Today Return Date"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(739, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Send Alert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnBck
        '
        Me.BtnBck.Location = New System.Drawing.Point(916, 295)
        Me.BtnBck.Name = "BtnBck"
        Me.BtnBck.Size = New System.Drawing.Size(75, 55)
        Me.BtnBck.TabIndex = 5
        Me.BtnBck.Text = "Back"
        Me.BtnBck.UseVisualStyleBackColor = True
        '
        'BtnReturn
        '
        Me.BtnReturn.Location = New System.Drawing.Point(916, 212)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(75, 55)
        Me.BtnReturn.TabIndex = 4
        Me.BtnReturn.Text = "Return"
        Me.BtnReturn.UseVisualStyleBackColor = True
        '
        'BtnData
        '
        Me.BtnData.Location = New System.Drawing.Point(916, 130)
        Me.BtnData.Name = "BtnData"
        Me.BtnData.Size = New System.Drawing.Size(75, 55)
        Me.BtnData.TabIndex = 3
        Me.BtnData.Text = "Sending"
        Me.BtnData.UseVisualStyleBackColor = True
        '
        'ListView
        '
        Me.ListView.CheckBoxes = True
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.brw_id, Me.contact_no, Me.brw_name, Me.bookid, Me.booktle, Me.author_name, Me.no_copies, Me.dateissue, Me.datereturn})
        Me.ListView.FullRowSelect = True
        Me.ListView.GridLines = True
        Me.ListView.Location = New System.Drawing.Point(20, 104)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(877, 365)
        Me.ListView.TabIndex = 2
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'brw_id
        '
        Me.brw_id.Text = "Borrow ID "
        Me.brw_id.Width = 73
        '
        'contact_no
        '
        Me.contact_no.Text = "Contact Number"
        Me.contact_no.Width = 97
        '
        'brw_name
        '
        Me.brw_name.Text = "Borrow Name"
        Me.brw_name.Width = 83
        '
        'bookid
        '
        Me.bookid.Text = "Book ID "
        '
        'booktle
        '
        Me.booktle.Text = "Book Title"
        Me.booktle.Width = 133
        '
        'author_name
        '
        Me.author_name.Text = "Author Name"
        Me.author_name.Width = 141
        '
        'no_copies
        '
        Me.no_copies.Text = "Number Copy"
        Me.no_copies.Width = 120
        '
        'dateissue
        '
        Me.dateissue.Text = "DateIssue"
        Me.dateissue.Width = 74
        '
        'datereturn
        '
        Me.datereturn.Text = "DateReturn"
        Me.datereturn.Width = 106
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(609, 39)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Txtsearch
        '
        Me.Txtsearch.Location = New System.Drawing.Point(286, 39)
        Me.Txtsearch.Name = "Txtsearch"
        Me.Txtsearch.Size = New System.Drawing.Size(302, 20)
        Me.Txtsearch.TabIndex = 0
        '
        'frmListborrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1037, 516)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListborrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListborrow"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents brw_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents contact_no As System.Windows.Forms.ColumnHeader
    Friend WithEvents brw_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents bookid As System.Windows.Forms.ColumnHeader
    Friend WithEvents booktle As System.Windows.Forms.ColumnHeader
    Friend WithEvents author_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents no_copies As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnBck As System.Windows.Forms.Button
    Friend WithEvents BtnReturn As System.Windows.Forms.Button
    Friend WithEvents BtnData As System.Windows.Forms.Button
    Friend WithEvents dateissue As System.Windows.Forms.ColumnHeader
    Friend WithEvents datereturn As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

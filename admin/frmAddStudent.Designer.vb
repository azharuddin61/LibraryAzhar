<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddStudent))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnBck = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAddstudent = New System.Windows.Forms.Button()
        Me.Lsv3 = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.uname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pass = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.yr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.section = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LblSearch)
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Controls.Add(Me.BtnBck)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Controls.Add(Me.BtnAddstudent)
        Me.Panel1.Controls.Add(Me.Lsv3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 459)
        Me.Panel1.TabIndex = 1
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(262, 25)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(96, 27)
        Me.BtnSearch.TabIndex = 23
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(41, 29)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(215, 20)
        Me.TxtSearch.TabIndex = 22
        '
        'BtnBck
        '
        Me.BtnBck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBck.Location = New System.Drawing.Point(722, 22)
        Me.BtnBck.Name = "BtnBck"
        Me.BtnBck.Size = New System.Drawing.Size(96, 30)
        Me.BtnBck.TabIndex = 21
        Me.BtnBck.Text = "Back"
        Me.BtnBck.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(620, 22)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(96, 30)
        Me.BtnDelete.TabIndex = 20
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(518, 22)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(96, 30)
        Me.BtnEdit.TabIndex = 19
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnAddstudent
        '
        Me.BtnAddstudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddstudent.Location = New System.Drawing.Point(416, 22)
        Me.BtnAddstudent.Name = "BtnAddstudent"
        Me.BtnAddstudent.Size = New System.Drawing.Size(96, 30)
        Me.BtnAddstudent.TabIndex = 18
        Me.BtnAddstudent.Text = "Add Student"
        Me.BtnAddstudent.UseVisualStyleBackColor = True
        '
        'Lsv3
        '
        Me.Lsv3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.lname, Me.fname, Me.mname, Me.uname, Me.pass, Me.yr, Me.section})
        Me.Lsv3.FullRowSelect = True
        Me.Lsv3.GridLines = True
        Me.Lsv3.Location = New System.Drawing.Point(18, 92)
        Me.Lsv3.Name = "Lsv3"
        Me.Lsv3.Size = New System.Drawing.Size(792, 349)
        Me.Lsv3.TabIndex = 17
        Me.Lsv3.UseCompatibleStateImageBehavior = False
        Me.Lsv3.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        '
        'lname
        '
        Me.lname.Text = "Last Name"
        Me.lname.Width = 118
        '
        'fname
        '
        Me.fname.Text = "First Name"
        Me.fname.Width = 108
        '
        'mname
        '
        Me.mname.Text = "Middle Name"
        Me.mname.Width = 105
        '
        'uname
        '
        Me.uname.Text = "Student Number"
        Me.uname.Width = 110
        '
        'pass
        '
        Me.pass.Text = "Password"
        Me.pass.Width = 104
        '
        'yr
        '
        Me.yr.Text = "Year"
        Me.yr.Width = 87
        '
        'section
        '
        Me.section.Text = "Section"
        Me.section.Width = 116
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Location = New System.Drawing.Point(67, 73)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(0, 13)
        Me.LblSearch.TabIndex = 24
        Me.LblSearch.Visible = False
        '
        'frmAddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(849, 483)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddStudent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnBck As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnAddstudent As System.Windows.Forms.Button
    Friend WithEvents Lsv3 As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents lname As System.Windows.Forms.ColumnHeader
    Friend WithEvents fname As System.Windows.Forms.ColumnHeader
    Friend WithEvents mname As System.Windows.Forms.ColumnHeader
    Friend WithEvents uname As System.Windows.Forms.ColumnHeader
    Friend WithEvents pass As System.Windows.Forms.ColumnHeader
    Friend WithEvents yr As System.Windows.Forms.ColumnHeader
    Friend WithEvents section As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents LblSearch As System.Windows.Forms.Label
End Class

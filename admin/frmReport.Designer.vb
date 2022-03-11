<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.LsvUser = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.stud_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.action = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.log = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(41, 33)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(52, 29)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(99, 38)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(163, 20)
        Me.TxtSearch.TabIndex = 2
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(358, 33)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(77, 28)
        Me.BtnPrint.TabIndex = 3
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'LsvUser
        '
        Me.LsvUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.stud_no, Me.password, Me.action, Me.log})
        Me.LsvUser.Location = New System.Drawing.Point(-1, 81)
        Me.LsvUser.Name = "LsvUser"
        Me.LsvUser.Size = New System.Drawing.Size(514, 255)
        Me.LsvUser.TabIndex = 4
        Me.LsvUser.UseCompatibleStateImageBehavior = False
        Me.LsvUser.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        '
        'stud_no
        '
        Me.stud_no.Text = "Student Number"
        Me.stud_no.Width = 134
        '
        'password
        '
        Me.password.Text = "Password"
        Me.password.Width = 88
        '
        'action
        '
        Me.action.Text = "Action"
        Me.action.Width = 123
        '
        'log
        '
        Me.log.Text = "Log"
        Me.log.Width = 140
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 336)
        Me.Controls.Add(Me.LsvUser)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.BtnSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents LsvUser As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents stud_no As System.Windows.Forms.ColumnHeader
    Friend WithEvents password As System.Windows.Forms.ColumnHeader
    Friend WithEvents action As System.Windows.Forms.ColumnHeader
    Friend WithEvents log As System.Windows.Forms.ColumnHeader
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainAdmin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfBorrowBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfReserveBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBooksToolStripMenuItem, Me.AddStudentToolStripMenuItem, Me.ListOfBorrowBookToolStripMenuItem, Me.ListOfReserveBookToolStripMenuItem, Me.ReportToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1378, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddBooksToolStripMenuItem
        '
        Me.AddBooksToolStripMenuItem.Name = "AddBooksToolStripMenuItem"
        Me.AddBooksToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.AddBooksToolStripMenuItem.Text = "&Add Books"
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.AddStudentToolStripMenuItem.Text = "&Add Student"
        '
        'ListOfBorrowBookToolStripMenuItem
        '
        Me.ListOfBorrowBookToolStripMenuItem.Name = "ListOfBorrowBookToolStripMenuItem"
        Me.ListOfBorrowBookToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.ListOfBorrowBookToolStripMenuItem.Text = "&List of Borrow Book"
        '
        'ListOfReserveBookToolStripMenuItem
        '
        Me.ListOfReserveBookToolStripMenuItem.Name = "ListOfReserveBookToolStripMenuItem"
        Me.ListOfReserveBookToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.ListOfReserveBookToolStripMenuItem.Text = "&List of Reserve Book"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentLoginToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "&Report"
        '
        'StudentLoginToolStripMenuItem
        '
        Me.StudentLoginToolStripMenuItem.Name = "StudentLoginToolStripMenuItem"
        Me.StudentLoginToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.StudentLoginToolStripMenuItem.Text = "&Student Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1386, 763)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmMainAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMainAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainAdmin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfBorrowBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfReserveBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentLoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

Public Class frmMainAdmin

    Private Sub AddBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBooksToolStripMenuItem.Click
        frmAddBooks.Show()
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentToolStripMenuItem.Click
        frmAddStudent.show()
    End Sub

    Private Sub ListOfBorrowBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfBorrowBookToolStripMenuItem.Click
        frmListborrow.Show()
    End Sub

    Private Sub StudentLoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentLoginToolStripMenuItem.Click
        frmReport.Show()
    End Sub

    Private Sub ListOfReserveBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfReserveBookToolStripMenuItem.Click
        frmListreserve.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("Thankyou Administration", vbInformation + vbOKOnly)
        frmIndex.Show()
        Me.Hide()
    End Sub
End Class
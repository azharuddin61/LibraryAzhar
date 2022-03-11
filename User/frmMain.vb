Imports system.data.sqlclient
Imports LibrarySystem.connection

Public Class frmMain
    Dim mycnt As SqlConnection = New SqlConnection(con)
    Private Sub BooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksToolStripMenuItem.Click
        frmListBook.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem2.Click
        MsgBox("Thank You Student")
        Me.Close()
        ' konekmo()
        'mycnt.ConnectionString = con
        mycnt.Open()
        Dim qry = "insert into users values('','" & frmUserLogin.user & "','" & frmUserLogin.pass & "','Logout','" & Date.Now.ToString("hh:mm:dd") & "')"
        cmd = New SqlCommand(qry, mycnt)
        da = cmd.ExecuteScalar
        mycnt.Close()

        frmUserLogin.txtUsername.Text = ""
        frmUserLogin.txtPassword.Text = ""

    End Sub
End Class
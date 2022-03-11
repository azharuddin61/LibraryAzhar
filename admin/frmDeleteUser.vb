Imports system.data.sqlclient
Imports LibrarySystem.connection

Public Class frmDeleteUser
    Dim mycnt As sqlConnection
    Dim sql As sqlCommand

    Private Sub frmDeleteUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mycnt = New sqlConnection
        mycnt.ConnectionString = con
        Try
            mycnt.Open()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect" + ex.Message)
        Finally
            mycnt.Dispose()
        End Try
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        mycnt = New sqlConnection
        mycnt.ConnectionString = con
        Dim dr As sqlDataReader

        Try
            mycnt.Open()
            Dim Query As String
            Query = "Delete from userinfo where id='" & TxtID.Text & "'"
            sql = New sqlCommand(Query, mycnt)
            dr = sql.ExecuteReader


            MessageBox.Show("Successfully Deleted")
            frmAddStudent.student()
            TxtID.Text = ""
            TxtLname.Text = ""
            TxtFname.Text = ""
            TxtMname.Text = ""
            TxtStuden.Text = ""
            Txtpass.Text = ""
            cmbyr.Text = ""
            TxtSection.Text = ""
            Me.Hide()
            mycnt.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycnt.Dispose()
        End Try
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        frmAddStudent.Show()
        Me.Hide()
    End Sub
End Class
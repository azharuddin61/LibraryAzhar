Imports System.Data.SqlClient
Imports LibrarySystem.connection

Public Class frmMoveborrow
    Dim mycnt As sqlConnection
    Dim sql As sqlCommand

    Private Sub MTB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTB.Click
        mycnt = New sqlConnection
        mycnt.ConnectionString = con
        Dim dr As sqlDataReader
        Dim sqlAdapter As New sqlDataAdapter
        Dim sqlCommand As New sqlCommand
        Dim lv As New DataTable

        Try
            mycnt.Open()
            Dim qry = "insert into brwbooks(brw_id,contact_no,brw_name,bookid,booktle,author_name,dateissue,datereturn,no_copies)values('" & TxtRiD.Text & "','" & TxtContact.Text & "','" & TxtReserveName.Text & "','" & TxtBookid.Text & "','" & TxtBookTle.Text & "','" & TxtAuthorname.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TxtCopies.Text & "')"
            cmd = New sqlCommand(qry, mycnt)
            da = cmd.ExecuteScalar
            mycnt.Close()

            mycnt.Open()
            Dim Query As String
            Query = "Delete from reserve where reserve_id='" & TxtRiD.Text & "'and bookid='" & TxtBookid.Text & "'"
            sql = New sqlCommand(Query, mycnt)
            dr = sql.ExecuteReader
            MessageBox.Show("Successfully Return Book!")
            frmListreserve.listreserve()
            TxtRiD.Text = ""
            TxtContact.Text = ""
            TxtReserveName.Text = ""
            TxtBookid.Text = ""
            TxtBookTle.Text = ""
            TxtAuthorname.Text = ""
            TxtCopies.Text = ""
            TextBox1.Text = " "
            TextBox2.Text = " "
            mycnt.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycnt.Dispose()
        End Try
    End Sub

    Private Sub frmMoveborrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bck.Click
        frmListreserve.Show()
        Me.Hide()
    End Sub

    Private Sub TxtContact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtContact.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtContact.Clear()
        End If
    End Sub

    Private Sub TxtReserveName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReserveName.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtReserveName.Clear()
        End If
    End Sub

    Private Sub TxtReserveName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReserveName.KeyPress
        Dim allowedchars As String = "abcdefghijklnopqrstuvwxyz"
        If allowedchars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCopies_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCopies.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtCopies.Clear()
        End If
    End Sub

    Private Sub TxtCopies_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCopies.KeyPress
        Dim allowedchars As String = "1234567890"
        If allowedchars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker_pickup_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblPickup_Click(sender As Object, e As EventArgs) Handles LblPickup.Click

    End Sub

    Private Sub datereturn_Click(sender As Object, e As EventArgs) Handles datereturn.Click

    End Sub
End Class
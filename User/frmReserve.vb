Imports System.Data.SqlClient
Imports LibrarySystem.connection

Public Class frmReserve
    Dim mycnt As SqlConnection = New SqlConnection(con)
    Dim sql As sqlCommand

    Private Sub frmReserve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'mycnt = New sqlConnection
        'mycnt.ConnectionString = con
        Try
            mycnt.Open()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect" + ex.Message)
        Finally
            '' mycnt.Dispose()
        End Try
        asd()
        namoo()
    End Sub

    Dim Query As String
    Dim Reader As sqlDataReader

    Public Sub Squery()
        Dim Query As String
        'mycnt = New sqlConnection
        'mycnt.ConnectionString = con
        Try
            mycnt.Open()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect" + ex.Message)
        Finally
            mycnt.Dispose()
        End Try

        Query = "select bk_qty from tblbooks"
    End Sub

    Private Sub BtnReserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReserve.Click
        'mycnt = New sqlConnection
        'mycnt.ConnectionString = con
        Dim dr As sqlDataReader

        Try
            'konekmo()
            ' mycnt.Open()
            Dim qry = "update tblbooks set bk_qty=bk_qty-" & TxtNumberCopies.Text & " where book_id='" & TxtBookid.Text & "'"
            cmd = New SqlCommand(qry, mycnt)
            da = cmd.ExecuteScalar
            mycnt.Close()

            mycnt.Open()
            Dim Query As String
            Query = "insert into reserve(reserve_id,contact_no,reserve_name,bookid,booktle,author_name,pickup,no_copies,returndate)values ('" & TxtReserveId.Text & "','" & TxtContact.Text & "','" & TxtReserveName.Text & "','" & TxtBookid.Text & "','" & TxtBookname.Text & "','" & TxtAuthor.Text & "','" & DateTimePicker_pickup.Text & "','" & TxtNumberCopies.Text & "','" & DateTimePicker1.Text & "')"
            sql = New sqlCommand(Query, mycnt)
            dr = sql.ExecuteReader

            MessageBox.Show("Successful Reserve Information")
            frmListBook.listbook()
            Me.Hide()
            mycnt.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycnt.Dispose()
        End Try
    End Sub

    Private Sub TxtNumberCopies_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumberCopies.TextChanged
        If Val(TxtNumberCopies.Text) > Val(lblQty.Text) Then
            MsgBox("Number of copies is too much", MsgBoxStyle.Exclamation, "Number of Copies")
            TxtNumberCopies.Clear()
        End If
    End Sub

    Private Sub TxtContact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtContact.Click
        TxtContact.Text = "+63"
        TxtContact.Select(4, 0)
    End Sub
    Sub asd()
        TxtReserveName.Text = frmUserLogin.firstname
    End Sub
    Sub namoo()
        TxtReserveId.Text = frmUserLogin.user
    End Sub

    Private Sub datereturn_Click(sender As Object, e As EventArgs) Handles datereturn.Click

    End Sub

    Private Sub DateTimePicker_pickup_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_pickup.ValueChanged

    End Sub

    Private Sub LblPickup_Click(sender As Object, e As EventArgs) Handles LblPickup.Click

    End Sub
End Class
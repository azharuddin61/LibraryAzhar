Imports System.Data.SqlClient
Imports LibrarySystem.connection

Public Class frmBorrow
    Dim mycnt As SqlConnection = New SqlConnection(con)
    Dim sql As SqlCommand

    Private Sub frmBorrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'mycnt = New SqlConnection
        'mycnt.ConnectionString = con
        Try
            mycnt.Open()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect" + ex.Message)
        Finally
            '' mycnt.Dispose()
        End Try
        asd()
        studentno()
    End Sub

    Dim Query As String
    Dim Reader As SqlDataReader

    Public Sub Squery()
        Dim Query As String
        'mycnt = New SqlConnection
        'mycnt.ConnectionString = con
        '"server=localhost;userid=AZHAAR;database=library;Convert Zero Datetime=True"
        Try
            mycnt.Open()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect" + ex.Message)
        Finally
            mycnt.Dispose()
        End Try

        Query = "select bk_qty from tblbooks"
    End Sub

    Private Sub BtnBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrow.Click
        If TxtBorrowId.Text = "" Or TxtContact.Text = "" Or TxtBorrowname.Text = "" Or TxtBookid.Text = "" Or TxtBookname.Text = "" Or TxtAuthor.Text = "" Or TxtNumberCopies.Text = "" Then
            MessageBox.Show("Please fill all the information.")
        Else
            Try
                Dim result2 As DialogResult = MessageBox.Show("Do you want to add the following data?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result2 = vbYes Then
                    Borrow()
                    Me.Close()
                    frmListBook.listbook()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Sub Borrow()
        'konekmo()
        'mycnt.ConnectionString = con
        '  mycnt.Open()
        Dim qry = "update tblbooks set bk_qty=bk_qty-" & TxtNumberCopies.Text & " where book_id='" & TxtBookid.Text & "'"
        cmd = New SqlCommand(qry, mycnt)
        da = cmd.ExecuteScalar
        mycnt.Close()
        Dim sqlQuery As String = "insert into brwbooks (brw_id,contact_no,brw_name,bookid,booktle,author_name,dateissue,datereturn,no_copies) values ('" & TxtBorrowId.Text & "','" & TxtContact.Text & "','" & TxtBorrowname.Text & "','" & TxtBookid.Text & "','" & TxtBookname.Text & "','" & TxtAuthor.Text & "','" & Date.Now.ToString() & "','" & DateTimePicker_pickup.Text & "','" & TxtNumberCopies.Text & "');"
        Dim sqlAdapter As New SqlDataAdapter
        Dim sqlCommand As New SqlCommand
        Dim lv As New DataTable
        Dim i As Integer

        With sqlCommand
            .CommandText = sqlQuery
            .Connection = mycnt
        End With
        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(lv)
        End With
        For i = 0 To lv.Rows.Count - 1
        Next
        MessageBox.Show("Succesfully Borrow Books.")
    End Sub

    Private Sub btnbck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbck.Click
        frmListbook.Show()
        Me.Hide()
    End Sub
    Sub asd()
        TxtBorrowname.Text = frmUserLogin.firstname
    End Sub
    Sub studentno()
        TxtBorrowId.Text = frmUserLogin.user
    End Sub

    Private Sub TxtContact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtContact.Click
        TxtContact.Text = "+91"
        ''TxtContact.Select(4, 0)
    End Sub

    Private Sub TxtContact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtContact.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtContact.Clear()
        End If
    End Sub

    Private Sub TxtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtContact.KeyPress
        Dim allowedChars As String = "1234567890"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNumberCopies_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumberCopies.TextChanged
        If Val(TxtNumberCopies.Text) > Val(lblQty.Text) Then
            MsgBox("Number of copies is too much", MsgBoxStyle.Exclamation, "Number of Copies")
            TxtNumberCopies.Clear()
        End If
    End Sub
End Class
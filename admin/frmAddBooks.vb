Imports System.Data.SqlClient
Imports LibrarySystem.connection

Public Class frmAddBooks

    Dim mycnt As New sqlConnection
    Dim sql As New sqlCommand
    Dim qry As String

    Private Sub frmAddBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mycnt = New SqlConnection
        mycnt.ConnectionString = con
        Try
            mycnt.Open()
            listbook1()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect" + ex.Message)
        Finally
            ''  mycnt.Dispose()
        End Try
    End Sub
    Sub listbook1()
        Lsv2.Items.Clear()
        Dim sqlQuery As String = "select * from tblbooks; "

        Dim sqlAdapter As New sqlDataAdapter
        Dim sqlCommand As New sqlCommand
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
            With Lsv2
                .Items.Add(lv.Rows(i)("book_id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(lv.Rows(i)("bk_name"))
                    .Add(lv.Rows(i)("author_name"))
                    .Add(lv.Rows(i)("bk_ctry"))
                    .Add(lv.Rows(i)("bk_qty"))
                End With
            End With
        Next
    End Sub

    Private Sub BtnAddbooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddbooks.Click
        frmAdd.Show()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        frmEdit.Show()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        frmDelete.Show()
    End Sub

    Private Sub TxtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim allowedChars As String = "1234567890"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub BtnBck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBck.Click
        frmMainadmin.Show()
        Me.Hide()
    End Sub

    Private Sub Lsv2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv2.SelectedIndexChanged
        frmEdit.TxtBookid.Text = Lsv2.Items(Lsv2.FocusedItem.Index).SubItems(0).Text
        frmEdit.TxtBookname.Text = Lsv2.Items(Lsv2.FocusedItem.Index).SubItems(1).Text
        frmEdit.TxtAuthor.Text = Lsv2.Items(Lsv2.FocusedItem.Index).SubItems(2).Text
        frmEdit.cmbCategory.Text = Lsv2.Items(Lsv2.FocusedItem.Index).SubItems(3).Text
        frmEdit.TxtQuantity.Text = Lsv2.Items(Lsv2.FocusedItem.Index).SubItems(4).Text
        frmDelete.TxtBookid.Text = Lsv2.Items(Lsv2.FocusedItem.Index).SubItems(0).Text
        frmDelete.TxtBookname.Text = Lsv2.Items(Lsv2.FocusedItem.Index).SubItems(1).Text
        frmDelete.TxtAuthor.Text = Lsv2.Items(Lsv2.FocusedItem.Index).SubItems(2).Text
        frmDelete.cmbCategory.Text = Lsv2.Items(Lsv2.FocusedItem.Index).SubItems(3).Text
        frmDelete.TxtQuantity.Text = Lsv2.Items(Lsv2.FocusedItem.Index).SubItems(4).Text
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        qry = "select book_id, bk_name, author_name, bk_ctry,bk_qty from tblbooks where book_id like '%" & TxtSearch.Text & "%' or bk_name like '%" & TxtSearch.Text & "%'"
        search()
    End Sub

    Sub search()
        Lsv2.Items.Clear()
        Dim sqlAdapter As New sqlDataAdapter
        Dim sqlCommand As New sqlCommand
        Dim lv As New DataTable
        Dim i As Integer

        With sqlCommand
            .CommandText = qry
            .Connection = mycnt
        End With

        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(lv)
        End With

        For i = 0 To lv.Rows.Count - 1
            With Lsv2
                .Items.Add(lv.Rows(i)("book_id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(lv.Rows(i)("bk_name"))
                    .Add(lv.Rows(i)("author_name"))
                    .Add(lv.Rows(i)("bk_ctry"))
                    .Add(lv.Rows(i)("bk_qty"))
                End With

            End With
        Next
    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtSearch.Clear()
        End If
    End Sub
End Class
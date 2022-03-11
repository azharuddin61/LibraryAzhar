Imports System.Data.SqlClient
Imports LibrarySystem.connection

Public Class frmListBook
    Dim mycnt As sqlConnection
    Dim sql As sqlCommand
    Dim qry As String

    Private Sub frmListBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mycnt = New sqlConnection
        mycnt.ConnectionString = con
        Try
            mycnt.Open()
            listbook()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect" + ex.Message)
        Finally
            ' mycnt.Dispose()
        End Try
    End Sub
    Sub listbook()
        Lsv1.Items.Clear()
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
            With Lsv1
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

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        qry = "select book_id, bk_name, author_name, bk_ctry,bk_qty from tblbooks where book_id like '%" & TxtSearch.Text & "%' or bk_name like '%" & TxtSearch.Text & "%'"
        search()
    End Sub
    Sub search()
        Lsv1.Items.Clear()
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
            With Lsv1
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

    Public bookid As String = ""

    Private Sub BtnBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrow.Click
        frmBorrow.Show()
    End Sub

    Private Sub BtnReserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReserve.Click
        frmReserve.Show()
    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub Lsv1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv1.SelectedIndexChanged
        frmBorrow.TxtBookid.Text = Lsv1.Items(Lsv1.FocusedItem.Index).SubItems(0).Text
        frmBorrow.TxtBookname.Text = Lsv1.Items(Lsv1.FocusedItem.Index).SubItems(1).Text
        frmBorrow.TxtAuthor.Text = Lsv1.Items(Lsv1.FocusedItem.Index).SubItems(2).Text
        bookid = Lsv1.Items(Lsv1.FocusedItem.Index).SubItems(0).Text
        frmBorrow.lblQty.Text = Lsv1.Items(Lsv1.FocusedItem.Index).SubItems(4).Text
        frmReserve.TxtBookid.Text = Lsv1.Items(Lsv1.FocusedItem.Index).SubItems(0).Text
        frmReserve.TxtBookname.Text = Lsv1.Items(Lsv1.FocusedItem.Index).SubItems(1).Text
        frmReserve.TxtAuthor.Text = Lsv1.Items(Lsv1.FocusedItem.Index).SubItems(2).Text
        bookid = Lsv1.Items(Lsv1.FocusedItem.Index).SubItems(0).Text
        frmReserve.lblQty.Text = Lsv1.Items(Lsv1.FocusedItem.Index).SubItems(4).Text
    End Sub
End Class
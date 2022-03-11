Imports System.Data.SqlClient
Imports LibrarySystem.connection

Public Class frmListreserve
    Dim mycnt As sqlConnection
    Dim sql As sqlCommand
    Dim qry As String

    Private Sub frmListreserve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mycnt = New sqlConnection
        mycnt.ConnectionString = con
        Try
            mycnt.Open()
            listreserve()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect" + ex.Message)
        Finally
            '' mycnt.Dispose()
        End Try
    End Sub

    Sub listreserve()
        Lsv4.Items.Clear()
        Dim sqlQuery As String = "select * from reserve; "

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
            With Lsv4
                .Items.Add(lv.Rows(i)("reserve_id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(lv.Rows(i)("contact_no"))
                    .Add(lv.Rows(i)("reserve_name"))
                    .Add(lv.Rows(i)("bookid"))
                    .Add(lv.Rows(i)("booktle"))
                    .Add(lv.Rows(i)("author_name"))
                    .Add(lv.Rows(i)("pickup"))
                    .Add(lv.Rows(i)("no_copies"))
                    .Add(lv.Rows(i)("returndate"))
                End With
            End With
        Next
    End Sub

    Private Sub BtnData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnData.Click
        frmMoveborrow.Show()
    End Sub

    Private Sub Lsv4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv4.SelectedIndexChanged
        frmMoveborrow.TxtRiD.Text = Lsv4.Items(Lsv4.FocusedItem.Index).SubItems(0).Text
        frmMoveborrow.TxtContact.Text = Lsv4.Items(Lsv4.FocusedItem.Index).SubItems(1).Text
        frmMoveborrow.TxtReserveName.Text = Lsv4.Items(Lsv4.FocusedItem.Index).SubItems(2).Text
        frmMoveborrow.TxtBookid.Text = Lsv4.Items(Lsv4.FocusedItem.Index).SubItems(3).Text
        frmMoveborrow.TxtBookTle.Text = Lsv4.Items(Lsv4.FocusedItem.Index).SubItems(4).Text
        frmMoveborrow.TxtAuthorname.Text = Lsv4.Items(Lsv4.FocusedItem.Index).SubItems(5).Text
        frmMoveborrow.TxtCopies.Text = Lsv4.Items(Lsv4.FocusedItem.Index).SubItems(7).Text
        frmMoveborrow.TextBox1.Text = Lsv4.Items(Lsv4.FocusedItem.Index).SubItems(6).Text
        frmMoveborrow.TextBox2.Text = Lsv4.Items(Lsv4.FocusedItem.Index).SubItems(8).Text

    End Sub

    Sub search()
        Lsv4.Items.Clear()
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
            With Lsv4
                .Items.Add(lv.Rows(i)("reserve_id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(lv.Rows(i)("contact_no"))
                    .Add(lv.Rows(i)("reserve_name"))
                    .Add(lv.Rows(i)("bookid"))
                    .Add(lv.Rows(i)("booktle"))
                    .Add(lv.Rows(i)("author_name"))
                    .Add(lv.Rows(i)("pickup"))
                    .Add(lv.Rows(i)("no_copies"))
                    .Add(lv.Rows(i)("returndate"))
                End With
            End With
        Next
    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        frmMainAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsearch.Click
        qry = "select reserve_id, contact_no, reserve_name, bookid, booktle, author_name, pickup, no_copies,returndate from reserve where reserve_id like '%" & TxtSearch.Text & "%' or reserve_name like '%" & TxtSearch.Text & "%'"
        search()
    End Sub
End Class
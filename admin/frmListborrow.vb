Imports system.data.sqlclient
Imports LibrarySystem.connection

Public Class frmListborrow
    Dim mycnt As sqlConnection
    Dim sql As sqlCommand
    Dim aqry As String

    Private Sub frmListborrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mycnt = New sqlConnection
        mycnt.ConnectionString = con
        Try
            mycnt.Open()
            listborrow()
            ''checkreturn()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect" + ex.Message)
        Finally
            ''           mycnt.Dispose()
        End Try
    End Sub

    Sub checkreturn()
        ListView.Items.Clear()
        Dim sqlAdapter As New SqlDataAdapter
        Dim sqlCommand As New SqlCommand
        Dim lv As New DataTable
        Dim i As Integer

        With sqlCommand
            .CommandText = aqry
            .Connection = mycnt
        End With
        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(lv)
        End With
        For i = 0 To lv.Rows.Count - 1
            With ListView
                .Items.Add(lv.Rows(i)("brw_id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(lv.Rows(i)("contact_no"))
                    .Add(lv.Rows(i)("brw_name"))
                    .Add(lv.Rows(i)("bookid"))
                    .Add(lv.Rows(i)("booktle"))
                    .Add(lv.Rows(i)("author_name"))
                    .Add(lv.Rows(i)("no_copies"))
                    .Add(lv.Rows(i)("dateissue"))
                    .Add(lv.Rows(i)("datereturn"))
                End With
            End With
        Next

    End Sub
    Sub listborrow()
        ListView.Items.Clear()
        Dim sqlQuery As String = "select * from brwbooks; "

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
            With ListView
                .Items.Add(lv.Rows(i)("brw_id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(lv.Rows(i)("contact_no"))
                    .Add(lv.Rows(i)("brw_name"))
                    .Add(lv.Rows(i)("bookid"))
                    .Add(lv.Rows(i)("booktle"))
                    .Add(lv.Rows(i)("author_name"))
                    .Add(lv.Rows(i)("no_copies"))
                    .Add(lv.Rows(i)("dateissue"))
                    .Add(lv.Rows(i)("datereturn"))
                End With
            End With
        Next
    End Sub

    Sub search()
        ListView.Items.Clear()
        Dim sqlAdapter As New sqlDataAdapter
        Dim sqlCommand As New sqlCommand
        Dim lv As New DataTable
        Dim i As Integer

        With sqlCommand
            .CommandText = aqry
            .Connection = mycnt
        End With
        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(lv)
        End With
        For i = 0 To lv.Rows.Count - 1
            With ListView
                .Items.Add(lv.Rows(i)("brw_id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(lv.Rows(i)("contact_no"))
                    .Add(lv.Rows(i)("brw_name"))
                    .Add(lv.Rows(i)("bookid"))
                    .Add(lv.Rows(i)("booktle"))
                    .Add(lv.Rows(i)("author_name"))
                    .Add(lv.Rows(i)("no_copies"))
                    .Add(lv.Rows(i)("dateissue"))
                    .Add(lv.Rows(i)("datereturn"))
                End With
            End With
        Next
    End Sub

    Private Sub BtnData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnData.Click

        With frmSending
            For i As Integer = 0 To ListView.Items.Count - 1
                If ListView.Items(i).Checked Then
                    Dim str As String = ","
                    Dim lstnumber As String = ListView.Items(i).SubItems(1).Text
                    If .Txtnumber.Text = "" Then
                        .Txtnumber.Text = ListView.Items(i).SubItems(1).Text
                    Else
                        .Txtnumber.Text = .Txtnumber.Text + str + ListView.Items(i).SubItems(1).Text
                    End If

                End If
            Next
            .Show()
        End With

    End Sub
    

    Private Sub Lsv3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView.SelectedIndexChanged
        'If ListView.CheckBoxes = True Then
        '    For i = 0 To ListView.FocusedItem.Index
        '        frmSending.Txtnumber.Text = ListView.Items(ListView.FocusedItem.Index).SubItems(i).Text
        '    Next
        'End If
        frmSending.Txtnumber.Text = ListView.Items(ListView.FocusedItem.Index).SubItems(1).Text
        frmReturing.TxtRiD.Text = ListView.Items(ListView.FocusedItem.Index).SubItems(0).Text
        frmReturing.TxtContact.Text = ListView.Items(ListView.FocusedItem.Index).SubItems(1).Text
        frmReturing.TxtReserveName.Text = ListView.Items(ListView.FocusedItem.Index).SubItems(2).Text
        frmReturing.TxtBookid.Text = ListView.Items(ListView.FocusedItem.Index).SubItems(3).Text
        frmReturing.TxtBookTle.Text = ListView.Items(ListView.FocusedItem.Index).SubItems(4).Text
        frmReturing.TxtAuthorname.Text = ListView.Items(ListView.FocusedItem.Index).SubItems(5).Text
        frmReturing.TxtCopies.Text = ListView.Items(ListView.FocusedItem.Index).SubItems(6).Text
    End Sub

    Private Sub BtnBck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBck.Click
        frmMainAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub BtnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReturn.Click
        frmReturing.Show()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        aqry = "select brw_id, contact_no, brw_name, bookid, booktle, author_name, no_copies,dateissue,datereturn from brwbooks where brw_name like '%" & Txtsearch.Text & "%' or brw_id like '%" & Txtsearch.Text & "%'"
        search()
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        aqry = "SELECT * from brwbooks where datereturn = dateadd(day,datediff(DAY ,-1,GETDATE()),0)"
        checkreturn()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        aqry = "select * from brwbooks where datereturn = '" & Date.Now.ToString("yyy-MM-dd") & "'"
        expirydate()
    End Sub
    Sub expirydate()
        ListView.Items.Clear()
        Dim sqlAdapter As New SqlDataAdapter
        Dim sqlCommand As New SqlCommand
        Dim lv As New DataTable
        Dim i As Integer

        With sqlCommand
            .CommandText = aqry
            .Connection = mycnt
        End With
        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(lv)
        End With
        For i = 0 To lv.Rows.Count - 1
            With ListView
                .Items.Add(lv.Rows(i)("brw_id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(lv.Rows(i)("contact_no"))
                    .Add(lv.Rows(i)("brw_name"))
                    .Add(lv.Rows(i)("bookid"))
                    .Add(lv.Rows(i)("booktle"))
                    .Add(lv.Rows(i)("author_name"))
                    .Add(lv.Rows(i)("no_copies"))
                    .Add(lv.Rows(i)("dateissue"))
                    .Add(lv.Rows(i)("datereturn"))
                End With
            End With
        Next
    End Sub
End Class
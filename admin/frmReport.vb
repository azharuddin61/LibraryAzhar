Imports system.data.sqlclient
Imports LibrarySystem.connection

Public Class frmReport
    Dim mycnt As sqlConnection
    Dim sql As sqlCommand
    Dim qry As String

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mycnt = New sqlConnection
        mycnt.ConnectionString = con
        Try
            mycnt.Open()
            Print()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect" + ex.Message)
        Finally
            ''mycnt.Dispose()
        End Try
    End Sub

    Sub Print()
        LsvUser.Items.Clear()
        Dim sqlQuery As String = "select * from users; "

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
            With LsvUser
                .Items.Add(lv.Rows(i)("id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(lv.Rows(i)("stud_no"))
                    .Add(lv.Rows(i)("password"))
                    .Add(lv.Rows(i)("action"))
                    .Add(lv.Rows(i)("log"))
                End With
            End With
        Next
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        PrintForm1.Print()
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        qry = "select id, stud_no, password, action, log from users where id like '%" & TxtSearch.Text & "%' or stud_no like '%" & TxtSearch.Text & "%'"
        search()
    End Sub

    Sub search()
        LsvUser.Items.Clear()
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
            With LsvUser
                .Items.Add(lv.Rows(i)("id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(lv.Rows(i)("stud_no"))
                    .Add(lv.Rows(i)("password"))
                    .Add(lv.Rows(i)("action"))
                    .Add(lv.Rows(i)("log"))
                End With
            End With
        Next
    End Sub
End Class
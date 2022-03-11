Imports system.data.sqlclient
Imports LibrarySystem.connection

Public Class frmAddStudent
    Dim mycnt As sqlConnection
    Dim dr As sqlDataReader
    Dim sql As sqlCommand
    Dim sqry As String

    Private Sub frmAddStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mycnt = New SqlConnection
        mycnt.ConnectionString = con
        Try
            mycnt.Open()
            student()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect" + ex.Message)
        Finally
            ''mycnt.Dispose()
        End Try
    End Sub

    Sub student()
        Lsv3.Items.Clear()
        Dim sqlQuery As String = "select * from userinfo; "

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
            With Lsv3
                .Items.Add(lv.Rows(i)("id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(lv.Rows(i)("lname"))
                    .Add(lv.Rows(i)("fname"))
                    .Add(lv.Rows(i)("mname"))
                    .Add(lv.Rows(i)("uname"))
                    .Add(lv.Rows(i)("pass"))
                    .Add(lv.Rows(i)("yr"))
                    .Add(lv.Rows(i)("section"))
                End With
            End With
        Next
        Lsv3.Refresh()
    End Sub

    Private Sub Lsv3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv3.SelectedIndexChanged
        frmDeleteUser.TxtID.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(0).Text
        frmDeleteUser.TxtLname.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(1).Text
        frmDeleteUser.TxtFname.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(2).Text
        frmDeleteUser.TxtMname.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(3).Text
        frmDeleteUser.TxtStuden.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(4).Text
        frmDeleteUser.Txtpass.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(5).Text
        frmDeleteUser.cmbyr.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(6).Text
        frmDeleteUser.TxtSection.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(7).Text

        frmEditStudent.TxtID.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(0).Text
        frmEditStudent.TxtLname.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(1).Text
        frmEditStudent.TxtFname.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(2).Text
        frmEditStudent.TxtMname.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(3).Text
        frmEditStudent.TxtStuden.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(4).Text
        frmEditStudent.Txtpass.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(5).Text
        frmEditStudent.cmbyr.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(6).Text
        frmEditStudent.TxtSection.Text = Lsv3.Items(Lsv3.FocusedItem.Index).SubItems(7).Text
    End Sub

    Private Sub BtnAddstudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddstudent.Click
        frmAddStud.Show()
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        frmEditStudent.Show()
    End Sub

    Private Sub BtnBck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBck.Click
        frmMainAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        frmDeleteUser.Show()
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        sqry = "select id, lname, fname, mname, uname, pass, yr, section from userinfo where id like '%" & TxtSearch.Text & "%' or uname like '%" & TxtSearch.Text & "%'"
        search()
    End Sub

    Sub search()
        Lsv3.Items.Clear()
        Dim sqlAdapter As New sqlDataAdapter
        Dim sqlCommand As New sqlCommand
        Dim lv As New DataTable
        Dim i As Integer

        With sqlCommand
            .CommandText = sqry
            .Connection = mycnt
        End With

        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(lv)
        End With

        For i = 0 To lv.Rows.Count - 1
            With Lsv3
                .Items.Add(lv.Rows(i)("id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(lv.Rows(i)("lname"))
                    .Add(lv.Rows(i)("fname"))
                    .Add(lv.Rows(i)("mname"))
                    .Add(lv.Rows(i)("uname"))
                    .Add(lv.Rows(i)("pass"))
                    .Add(lv.Rows(i)("yr"))
                    .Add(lv.Rows(i)("section"))
                End With
            End With
        Next
    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        lblSearch.Text = TxtSearch.Text
        If TxtSearch.TextLength = 4 Then
            TxtSearch.Text += "-"
            TxtSearch.Select(5, 5)
        End If
        If TxtSearch.TextLength = 7 Then
            TxtSearch.Text += "-"
            TxtSearch.Select(8, 8)
        End If
    End Sub
End Class
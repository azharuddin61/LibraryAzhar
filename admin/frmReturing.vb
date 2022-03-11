Imports System.Data.SqlClient
Imports LibrarySystem.connection

Public Class frmReturing
    Dim mycnt As sqlConnection
    Dim sql As sqlCommand

    Private Sub frmReturing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub BtnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReturn.Click
        mycnt = New sqlConnection
        mycnt.ConnectionString = con
        Dim dr As sqlDataReader
        Dim sqlAdapter As New sqlDataAdapter
        Dim sqlCommand As New sqlCommand
        Dim lv As New DataTable

        Try
            mycnt.Open()
            Dim qry = "update tblbooks set bk_qty=bk_qty+" & TxtCopies.Text & " where book_id='" & TxtBookid.Text & "'"
            cmd = New sqlCommand(qry, mycnt)
            da = cmd.ExecuteScalar
            mycnt.Close()

            mycnt.Open()
            Dim Query As String
            Query = "Delete from brwbooks where brw_id='" & TxtRiD.Text & "'and bookid='" & TxtBookid.Text & "'"
            sql = New sqlCommand(Query, mycnt)
            dr = sql.ExecuteReader
            MessageBox.Show("Successfully Return Book!")
            frmListborrow.listborrow()
            TxtRiD.Text = ""
            TxtContact.Text = ""
            TxtReserveName.Text = ""
            TxtBookid.Text = ""
            TxtBookTle.Text = ""
            TxtAuthorname.Text = ""
            TxtCopies.Text = ""
            mycnt.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycnt.Dispose()
        End Try
    End Sub

    Private Sub TxtRiD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtRiD.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtRiD.Clear()
        End If
    End Sub

    Private Sub TxtRiD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRiD.KeyPress
        Dim allowedchars As String = "1234567890"
        If allowedchars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Me.Hide()
    End Sub

    Private Sub TxtContact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtContact.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtContact.Clear()
        End If
    End Sub

    Private Sub TxtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtContact.KeyPress
        Dim AllowedCharacter As String = "1234567890"
        If AllowedCharacter.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtReserveName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReserveName.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtReserveName.Clear()
        End If
    End Sub

    Private Sub TxtReserveName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReserveName.KeyPress
        Dim AllowedCharacter As String = "abcdefghijklnmopqrstuvwxyz"
        If AllowedCharacter.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCopies_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCopies.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtCopies.Clear()
        End If
    End Sub

    Private Sub TxtCopies_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCopies.KeyPress
        Dim AllowedCharacter As String = "1234567890"
        If AllowedCharacter.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCopies_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCopies.TextChanged
        If Val(TxtCopies.Text) > Val(LblCopies.Text) Then
            MsgBox("Number of copies is too much", MsgBoxStyle.Exclamation, "Number of Copies")
            TxtCopies.Clear()
        End If
    End Sub
End Class
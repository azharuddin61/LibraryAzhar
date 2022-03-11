﻿Imports System.Data.SqlClient
Imports LibrarySystem.connection

Public Class frmDelete
    Dim mycnt As New sqlConnection
    Dim sql As New sqlCommand

    Private Sub frmDelete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mycnt = New sqlConnection
        mycnt.ConnectionString = con
        Dim dr As sqlDataReader

        Try
            mycnt.Open()
            Dim Query As String
            Query = "select * from category"
            sql = New sqlCommand(Query, mycnt)
            dr = sql.ExecuteReader
            While dr.Read
                Dim sCategory = dr.GetString("category")
                cmbCategory.Items.Add(sCategory)
            End While

            mycnt.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycnt.Dispose()
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        mycnt = New sqlConnection
        mycnt.ConnectionString = con
        Dim dr As sqlDataReader

        Try
            mycnt.Open()
            Dim Query As String
            Query = "Delete from tblbooks where book_id='" & TxtBookid.Text & "'"
            sql = New sqlCommand(Query, mycnt)
            dr = sql.ExecuteReader

            MessageBox.Show("Successfully Deleted")
            frmAddBooks.listbook1()
            TxtBookid.Text = ""
            TxtBookname.Text = ""
            TxtAuthor.Text = ""
            cmbCategory.Text = ""
            TxtQuantity.Text = ""
            Me.Hide()
            mycnt.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycnt.Dispose()
        End Try
    End Sub

    Private Sub TxtBookid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBookid.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtBookid.Clear()
        End If
    End Sub

    Private Sub TxtBookid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBookid.KeyPress
        Dim AllowedChars As String = "1234567890"
        If AllowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtBookname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBookname.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtBookname.Clear()
        End If
    End Sub

    Private Sub TxtBookname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBookname.KeyPress
        Dim AllowedChars As String = "abcdefghijklnmopqrstuvwxyz"
        If AllowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAuthor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAuthor.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtAuthor.Clear()
        End If
    End Sub

    Private Sub TxtAuthor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAuthor.KeyPress
        Dim AllowedChars As String = "abcdefghijklnmopqrstuvwxyz"
        If AllowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuantity.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtQuantity.Clear()
        End If
    End Sub

    Private Sub TxtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQuantity.KeyPress
        Dim AllowedChars As String = "1234567890"
        If AllowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnBck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBck.Click
        frmAddBooks.Show()
        Me.Hide()
    End Sub
End Class
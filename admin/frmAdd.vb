Imports System.Data.SqlClient
Imports LibrarySystem.connection

Public Class frmAdd
    Dim mycnt As sqlConnection
    Dim sql As sqlCommand

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If TxtBookid.Text = "" Or TxtBookname.Text = "" Or TxtAuthor.Text = "" Or TxtBookid.Text = "" Or ComboBox1.Text = "" Or TxtQuantity.Text = "" Then
            MessageBox.Show("Please fill all the information.")
        Else
            Try
                Dim result2 As DialogResult = MessageBox.Show("Do you want to add the following data?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result2 = vbYes Then
                    Add()
                    Me.Close()
                    frmAddBooks.listbook1()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Sub Add()
        Dim sqlQuery As String = "insert into tblbooks (book_id,bk_name,author_name,bk_ctry,bk_qty) values ('" & TxtBookid.Text & "','" & TxtBookname.Text & "','" & TxtAuthor.Text & "','" & ComboBox1.Text & "','" & TxtQuantity.Text & "');"
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
        Next
        MessageBox.Show("Succesfully Add Books.")
    End Sub

    Private Sub frmAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                Dim sCategory = dr("category").ToString()
                ComboBox1.Items.Add(sCategory)
            End While

            mycnt.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ''mycnt.Dispose()
        End Try
    End Sub

    Private Sub TxtBookid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBookid.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtBookid.Clear()
        End If
    End Sub

    Private Sub TxtBookid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBookid.KeyPress
        Dim AllowedChar As String = "1234567890"
        If AllowedChar.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtBookname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBookname.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtBookname.Clear()
        End If
    End Sub

    Private Sub TxtBookname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBookname.KeyPress
        Dim AllowedChar As String = "abcdefghijklnopqrstuvwxyzABCDEFGHIJKLNOPQRSTUVWXYZ"
        If AllowedChar.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAuthor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAuthor.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtAuthor.Clear()
        End If
    End Sub

    Private Sub TxtAuthor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAuthor.KeyPress
        Dim AllowedChar As String = "abcdefghijklnopqrstuvwxyzABCDEFGHIJKLNOPQRSTUVWXYZ"
        If AllowedChar.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuantity.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtQuantity.Clear()
        End If
    End Sub

    Private Sub TxtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQuantity.KeyPress
        Dim AllowedChar As String = "1234567890"
        If AllowedChar.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnBck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBck.Click
        frmAddBooks.Show()
        Me.Hide()
    End Sub

    Private Sub cmbCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim xCurrentTextValue As String
        xCurrentTextValue = ComboBox1.Text

        If e.KeyCode <> Keys.Enter Then
            Me.ComboBox1.Text = xCurrentTextValue
        End If
    End Sub

    Private Sub cmbCategory_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cmbCategory_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If (ComboBox1.SelectedIndex = -1) Then
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub TxtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQuantity.TextChanged
        If Val(TxtQuantity.Text) > Val(LblQty.Text) Then
            MsgBox("Number of copies is too much", MsgBoxStyle.Exclamation, "Number of Copies")
            TxtQuantity.Clear()
        End If
    End Sub
End Class
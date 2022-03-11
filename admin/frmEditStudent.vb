Imports system.data.sqlclient
Imports LibrarySystem.connection

Public Class frmEditStudent
    Dim mycnt As New sqlConnection
    Dim sql As New sqlCommand

    Private Sub frmEditStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mycnt = New sqlConnection
        mycnt.ConnectionString = con
        Try
            mycnt.Open()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect" + ex.Message)
        Finally
            mycnt.Dispose()
        End Try
        autogenerate_id()
    End Sub

    Public Sub autogenerate_id()
        Dim cn As New sqlConnection
        Dim cmd As New sqlCommand
        cn.ConnectionString = con
        cmd.Connection = cn
        cn.Open()

        Dim number As Integer
        cmd.CommandText = "SELECT Max(ID) from userinfo"

        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1
            TxtID.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            TxtID.Text = number
        End If
        cmd.Dispose()
        cn.Close()
        cn.Dispose()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        mycnt = New sqlConnection
        mycnt.ConnectionString = con
        Dim dr As sqlDataReader

        Try
            mycnt.Open()
            Dim Query As String
            Query = "update userinfo set id='" & TxtID.Text & "',lname='" & TxtLname.Text & "',fname='" & TxtFname.Text & "',mname='" & TxtMname.Text & "',uname='" & TxtStuden.Text & "',pass='" & Txtpass.Text & "',yr='" & cmbyr.Text & "',section='" & TxtSection.Text & "' where uname='" & TxtStuden.Text & "'"
            sql = New sqlCommand(Query, mycnt)
            dr = sql.ExecuteReader

            MessageBox.Show("Successful Update Information")
            frmAddStudent.student()
            TxtID.Text = ""
            TxtLname.Text = ""
            TxtFname.Text = ""
            TxtMname.Text = ""
            TxtStuden.Text = ""
            Txtpass.Text = ""
            cmbyr.Text = ""
            TxtSection.Text = ""
            Me.Hide()
            mycnt.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycnt.Dispose()
        End Try
    End Sub

    Private Sub TxtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtID.KeyPress
        Dim allowedChars As String = "1234567890"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtLname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLname.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtLname.Clear()
        End If
    End Sub

    Private Sub TxtLname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLname.KeyPress
        Dim allowedChars As String = "abcdefghijklnmopqrstuvwxyxABCDEFGHIJKLNMOPQRSTUVWXYZ"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtFname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFname.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtFname.Clear()
        End If
    End Sub

    Private Sub TxtFname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFname.KeyPress
        Dim allowedChars As String = "abcdefghijklnmopqrstuvwxyxABCDEFGHIJKLNMOPQRSTUVWXYZ"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtMname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMname.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtMname.Clear()
        End If
    End Sub

    Private Sub TxtMname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMname.KeyPress
        Dim allowedChars As String = "abcdefghijklnmopqrstuvwxyxABCDEFGHIJKLNMOPQRSTUVWXYZ"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtStuden_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStuden.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtStuden.Clear()
        End If
    End Sub

    Private Sub TxtStuden_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStuden.KeyPress
        Dim allowedChars As String = "1234567890"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtStuden_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtStuden.TextChanged
        lblUSer1.Text = TxtStuden.Text
        If TxtStuden.TextLength = 4 Then
            TxtStuden.Text += "-"
            TxtStuden.Select(5, 5)
        End If
        If TxtStuden.TextLength = 7 Then
            TxtStuden.Text += "-"
            TxtStuden.Select(8, 8)
        End If
    End Sub

    Private Sub TxtSection_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSection.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtSection.Clear()
        End If
    End Sub

    Private Sub TxtSection_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSection.KeyPress
        Dim allowedChars As String = "abcdefghijklnmopqrstuvwxyxABCDEFGHIJKLNMOPQRSTUVWXYZ"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        frmAddStudent.Show()
        Me.Hide()
    End Sub
End Class
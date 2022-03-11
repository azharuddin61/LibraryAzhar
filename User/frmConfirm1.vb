Imports system.data.sqlclient
Imports LibrarySystem.connection

Public Class frmConfirm1

    Dim mycnt As SqlConnection = New SqlConnection(con)
    Dim sql As sqlCommand

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'mycnt = New sqlConnection
        'mycnt.ConnectionString = con
        Dim dr As sqlDataReader

        Try
            mycnt.Open()
            Dim Query As String
            Query = "insert into userinfo (id,lname,fname,mname,uname,pass,yr,section) values('" & Txtid.Text & "','" & Txtlname.Text & "','" & Txtfname.Text & "','" & Txtmname.Text & "','" & TxtStudID.Text & "','" & TxtNewPass.Text & "','" & cmbyr.Text & "','" & Txtsection.Text & "')"
            sql = New sqlCommand(Query, mycnt)
            dr = sql.ExecuteReader

            MessageBox.Show("Confirm Your Account!")
            Refresh()
            mycnt.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycnt.Dispose()
        End Try
        autogenerate_id()
    End Sub

    Private Sub autogenerate_id()
        Dim cn As SqlConnection = New SqlConnection(con)
        Dim cmd As New sqlCommand
        'cn.ConnectionString = con
        cmd.Connection = cn
        cn.Open()

        Dim number As Integer
        cmd.CommandText = "SELECT Max(ID) from userinfo"

        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1
            Txtid.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            Txtid.Text = number
        End If
        cmd.Dispose()
        cn.Close()
        cn.Dispose()
    End Sub

    Private Sub frmConfirm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        autogenerate_id()
    End Sub

    Private Sub Txtlname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtlname.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            Txtlname.Clear()
        End If
    End Sub

    Private Sub Txtlname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtlname.KeyPress
        Dim AllowedChars As String = "abcdefghijklnopqrstuvwxyz"
        If AllowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txtfname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtfname.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            Txtfname.Clear()
        End If
    End Sub

    Private Sub Txtfname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtfname.KeyPress
        Dim AllowedChars As String = "abcdefghijklnopqrstuvwxyz"
        If AllowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txtmname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtmname.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            Txtmname.Clear()
        End If
    End Sub

    Private Sub Txtmname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtmname.KeyPress
        Dim AllowedChars As String = "abcdefghijklnopqrstuvwxyz"
        If AllowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtStudID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStudID.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtStudID.Clear()
        End If
    End Sub

    Private Sub TxtStudID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStudID.KeyPress
        Dim AllowedChars As String = "1234567890"
        If AllowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtStudID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtStudID.TextChanged
        LblUSer1.Text = TxtStudID.Text
        If TxtStudID.TextLength = 4 Then
            TxtStudID.Text += "-"
            TxtStudID.Select(5, 5)
        End If
        If TxtStudID.TextLength = 7 Then
            TxtStudID.Text += "-"
            TxtStudID.Select(8, 8)
        End If
    End Sub

    Private Sub TxtNewPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNewPass.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtNewPass.Clear()
        End If
    End Sub

    Private Sub TxtNewPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNewPass.KeyPress
        Dim AllowedChars As String = "abcdefghijklnopqrstuvwxyz1234567890"
        If AllowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtConfirm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtConfirm.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtConfirm.Clear()
        End If
    End Sub

    Private Sub TxtConfirm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtConfirm.KeyPress
        Dim AllowedChars As String = "abcdefghijklnopqrstuvwxyz1234567890"
        If AllowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CNCL_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CNCL_Button.Click
        frmUserLogin.Show()
        Me.Hide()
    End Sub
End Class
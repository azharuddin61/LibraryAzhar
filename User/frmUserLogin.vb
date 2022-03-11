Imports System.Data.SqlClient
Imports LibrarySystem.connection

Public Class frmUserLogin
    Dim MyConn As SqlConnection
    Dim sql As SqlCommand
    Dim query As String
    Dim Attempt As Integer = 0
    Public user, pass, firstname As String

    Sub Login()
        MyConn = New SqlConnection(con)
        ' MyConn.ConnectionString = con
        'MyConn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbfileName = " & Application.StartupPath & "\library.mdf ;Integrated Security=True"
        MyConn.Open()
        Dim Query As String
        Query = "select * from userinfo where uname ='" & txtUsername.Text & "' and pass ='" & txtPassword.Text & "';"
        sql = New SqlCommand(Query, MyConn)
        dr = sql.ExecuteReader
        Dim login_count As Integer
        login_count = 0

        While dr.Read
            login_count = login_count + 1
            user = dr("uname")
            pass = dr("pass")
            firstname = dr("fname")
        End While
        MyConn.Close()
        If login_count = 1 Then
            MsgBox("Welcome")
            frmMain.Show()
            txtUsername.Text = user
            txtPassword.Text = pass
            Label1.Hide()
            Me.Hide()

            'konekmo()
            MyConn.Open()
            Dim qry = "insert into users values('','" & txtUsername.Text & "','" & txtPassword.Text & "','Login','" & Date.Now.ToString("hh:mm:dd") & "')"
            cmd = New SqlCommand(qry, MyConn)
            da = cmd.ExecuteScalar
            MyConn.Close()

        Else
            MsgBox("username and Password incorrect")
            Attempt = Attempt + 1
            txtPassword.Clear()
            txtUsername.SelectAll()

        End If

        MyConn.Close()

        If Attempt = 3 Then

            'konekmo()
            MyConn.Open()
            Query = "delete from userinfo where uname ='" & txtUsername.Text & "'"
            cmd = New SqlCommand(Query, MyConn)
            da = cmd.ExecuteScalar
            MsgBox("Your account " & txtPassword.Text & " has been deleted", MsgBoxStyle.Critical, "Account deleted")
            MyConn.Close()

            Label1.Show()

            txtUsername.Text = ""
            txtPassword.Text = ""

        End If
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            txtUsername.Clear()
        End If
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        Dim allowedChars As String = "1234567890"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        LblUSer1.Text = txtUsername.Text
        If txtUsername.TextLength = 4 Then
            txtUsername.Text += "-"
            txtUsername.Select(5, 5)
        End If
        If txtUsername.TextLength = 7 Then
            txtUsername.Text += "-"
            txtUsername.Select(8, 8)
        End If
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        frmConfirm1.Show()
    End Sub

    Private Sub Showing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Showing.CheckedChanged
        If Showing.CheckState = CheckState.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub frmUserLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub
End Class

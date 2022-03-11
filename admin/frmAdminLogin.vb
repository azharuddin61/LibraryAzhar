Imports System.Data.SqlClient
Imports System.IO
Imports LibrarySystem.connection

Public Class frmAdminLogin
    Dim mycnt As SqlConnection
    Dim sql As SqlCommand

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'If Not CheckDatabaseExist() Then
        '    GenerateDatabase()
        'End If

        login()
    End Sub

    'Private Function CheckDatabaseExist()

    '    mycnt = New SqlConnection
    '    '  mycnt.ConnectionString = "Data Source=AZHAR\SQLEXPRESS;Initial Catalog=library;Integrated Security=True"
    '    '  mycnt.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=testing ;Integrated Security=True"
    '    Try
    '        mycnt.ConnectionString = "Data Source=.;Initial Catalog=master ;Integrated Security=True"
    '        mycnt.Open()
    '        mycnt.Close()
    '    Catch
    '        mycnt.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=master ;Integrated Security=True"
    '        mycnt.Open()
    '        mycnt.Close()
    '    End Try
    '    con = mycnt.ConnectionString.Replace("master", "testing")


    '    Try
    '        mycnt.ConnectionString = con
    '        mycnt.Open()
    '        mycnt.Close()
    '        Return True
    '    Catch
    '        Return False
    '    End Try

    'End Function

    'Private Sub GenerateDatabase()
    '    Dim tr As TextReader
    '    Dim cmds As List(Of String) = New List(Of String)
    '    If File.Exists(Application.StartupPath + "\library.sql") Then
    '        tr = New StreamReader(Application.StartupPath + "\library.sql")
    '        Dim line As String = ""
    '        Dim cmd As String = ""
    '        'line = tr.ReadToEnd()
    '        Do While tr.Peek() >= 0
    '            line = tr.ReadLine()
    '            If (line.Trim().ToUpper() = "GO") Then
    '                cmds.Add(cmd)
    '                cmd = ""
    '            Else
    '                cmd += line + vbNewLine
    '            End If
    '        Loop
    '        'While ((line = tr.ReadLine()) <> vbNull)
    '        '    If (line.Trim().ToUpper() = "GO") Then
    '        '        cmds.Add(cmd)
    '        '        cmd = ""
    '        '    Else
    '        '        cmd += line + vbNewLine
    '        '    End If
    '        'End While
    '        ' cmd = line
    '        If (cmd.Length > 0) Then

    '            cmds.Add(cmd)
    '            cmd = ""

    '            tr.Close()
    '        End If
    '    End If
    '    If (cmds.Count > 0) Then

    '        Dim Command As SqlCommand = New SqlCommand()

    '        '  Command.Connection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=MASTER ;Integrated Security=True")
    '        ' Command.Connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=MASTER ;Integrated Security=True")
    '        Command.Connection = New SqlConnection(con)
    '        Command.CommandType = System.Data.CommandType.Text
    '        Command.Connection.Open()
    '        Dim i As Integer
    '        For i = 0 To cmds.Count - 1
    '            Command.CommandText = cmds(i)
    '            Command.ExecuteNonQuery()
    '        Next

    '    End If



    'End Sub

    Private Sub btnOk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnOk.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            txtUsername.Clear()
        End If
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Sub login()

        mycnt = New SqlConnection(con)
        '  mycnt.ConnectionString = "Data Source=AZHAR\SQLEXPRESS;Initial Catalog=library;Integrated Security=True"
        'mycnt.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=testing ;Integrated Security=True"
        ' mycnt.ConnectionString = con
        Dim Reader As SqlDataReader
        Try
            mycnt.Open()
            Dim Query As String
            Query = "select * from adminpass where username ='" & txtUsername.Text & "' and password ='" & txtPassword.Text & "';"
            sql = New SqlCommand(Query, mycnt)
            Reader = sql.ExecuteReader()
            Dim login_count As Integer
            login_count = 0

            While Reader.Read
                login_count = login_count + 1
            End While

            If login_count = 1 Then
                MsgBox("Thank you for Logging In, Lets Proceed", vbOKOnly)
                frmMainAdmin.Show()
                Me.Hide()

                txtUsername.Text = ""
                txtPassword.Text = ""
            ElseIf login_count > 1 Then
                MessageBox.Show("Duplicated data.")
            Else
                MessageBox.Show("Login failed, wrong password or lastname.")
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            txtUsername.Clear()
        End If
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmIndex.Show()
        Me.Hide()
    End Sub
End Class
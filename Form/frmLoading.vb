Imports System.Data.SqlClient
Imports System.IO
Imports LibrarySystem.connection

Public Class frmLoading
    Dim mycnt As SqlConnection
    Dim sql As SqlCommand

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Value = ProgressBar1.Value + 2
        If (ProgressBar1.Value = 10) Then
            Label1.Text = "Reading modules.."
        ElseIf (ProgressBar1.Value = 20) Then
            Label1.Text = "Turning on modules."
        ElseIf (ProgressBar1.Value = 40) Then
            Label1.Text = "Starting modules.."
        ElseIf (ProgressBar1.Value = 60) Then
            Label1.Text = "Loading modules.."
        ElseIf (ProgressBar1.Value = 80) Then
            Label1.Text = "Done Loading modules.."
        ElseIf (ProgressBar1.Value = 100) Then
            Timer1.Enabled = False
            frmIndex.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub frmLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not CheckDatabaseExist() Then
            GenerateDatabase()
        End If
        Timer1.Start()
    End Sub
    Private Function CheckDatabaseExist()

        mycnt = New SqlConnection
        '  mycnt.ConnectionString = "Data Source=AZHAR\SQLEXPRESS;Initial Catalog=library;Integrated Security=True"
        '  mycnt.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=testing ;Integrated Security=True"
        Try
            mycnt.ConnectionString = "Data Source=.;Initial Catalog=master ;Integrated Security=True"
            mycnt.Open()
            mycnt.Close()
        Catch
            mycnt.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=master ;Integrated Security=True"
            mycnt.Open()
            mycnt.Close()
        End Try
        con = mycnt.ConnectionString.Replace("master", "testing")


        Try
            mycnt.ConnectionString = con
            mycnt.Open()
            mycnt.Close()
            Return True
        Catch
            Return False
        End Try

    End Function

    Private Sub GenerateDatabase()
        Dim tr As TextReader
        Dim cmds As List(Of String) = New List(Of String)
        If File.Exists(Application.StartupPath + "\library.sql") Then
            tr = New StreamReader(Application.StartupPath + "\library.sql")
            Dim line As String = ""
            Dim cmd As String = ""
            'line = tr.ReadToEnd()
            Do While tr.Peek() >= 0
                line = tr.ReadLine()
                If (line.Trim().ToUpper() = "GO") Then
                    cmds.Add(cmd)
                    cmd = ""
                Else
                    cmd += line + vbNewLine
                End If
            Loop
            'While ((line = tr.ReadLine()) <> vbNull)
            '    If (line.Trim().ToUpper() = "GO") Then
            '        cmds.Add(cmd)
            '        cmd = ""
            '    Else
            '        cmd += line + vbNewLine
            '    End If
            'End While
            ' cmd = line
            If (cmd.Length > 0) Then

                cmds.Add(cmd)
                cmd = ""

                tr.Close()
            End If
        End If
        If (cmds.Count > 0) Then

            Dim Command As SqlCommand = New SqlCommand()

            '  Command.Connection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=MASTER ;Integrated Security=True")
            ' Command.Connection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=MASTER ;Integrated Security=True")
            Command.Connection = New SqlConnection(con)
            Command.CommandType = System.Data.CommandType.Text
            Command.Connection.Open()
            Dim i As Integer
            For i = 0 To cmds.Count - 1
                Command.CommandText = cmds(i)
                Command.ExecuteNonQuery()
            Next

        End If



    End Sub

End Class
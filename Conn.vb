Imports System.Data.SqlClient
Imports LibrarySystem.connection

Module Conn
    Public cmd As New sqlCommand
    Public connect As New sqlConnection
    Public dr As sqlDataReader
    Public da As New sqlDataAdapter
    Public Dataset As New DataSet
    'Public conn As String = "Data Source=.\SQLEXPRESS;Initial Catalog=library;Integrated Security=True"
    '  Public conn As String = "Data Source=.\SQLEXPRESS;AttachDbfileName = " & Application.StartupPath & "\library.mdf ;Integrated Security=True"
    Public Sub konekmo()
        'Dim strConn As String

        'strConn = "Data Source=.\SQLEXPRESS;Initial Catalog=library;Integrated Security=True"
        ''     strConn = "Data Source=.\SQLEXPRESS;AttachDbfileName = " & Application.StartupPath & "\library.mdf ;Integrated Security=True"
        connect = New SqlConnection(con)

        connect.Open()
    End Sub
End Module

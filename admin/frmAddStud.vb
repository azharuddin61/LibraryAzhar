Imports system.data.sqlclient
Imports LibrarySystem.connection

Public Class frmAddStud
    Dim mycnt As sqlConnection
    Dim sql As sqlCommand

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If TxtID.Text = "" Or TxtLname.Text = "" Or TxtFname.Text = "" Or TxtMname.Text = "" Or TxtStuden.Text = "" Or Txtpass.Text = "" Or cmbyr.Text = "" Or TxtSection.Text = "" Then
            MessageBox.Show("Please Fill Up The Following")
        Else
            Try
                Dim result2 As DialogResult = MessageBox.Show("Do you want to add the following data?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result2 = vbYes Then
                    AddStudent()
                    Me.Close()
                    frmAddStudent.student()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Sub AddStudent()
        
        Dim sqlQuery As String = "insert into userinfo (id,lname,fname,mname,uname,pass,yr,section) values ('" & TxtID.Text & "','" & TxtLname.Text & "','" & TxtFname.Text & "','" & TxtMname.Text & "','" & TxtStuden.Text & "','" & Txtpass.Text & "','" & cmbyr.Text & "','" & TxtSection.Text & "');"
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
        MessageBox.Show("Succesfully Add Student.")

    End Sub

    Private Sub frmAddStud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mycnt = New sqlConnection
        mycnt.ConnectionString = con
        Try
            mycnt.Open()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect" + ex.Message)
        Finally
            ''  mycnt.Dispose()
        End Try
        autogenerate_id()
    End Sub

    Private Sub autogenerate_id()
        Dim cn As New sqlConnection
        Dim cmd As New sqlCommand
        cn.ConnectionString = con
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

    Private Sub TxtID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtID.KeyDown
        If e.KeyCode.Equals(Keys.Back) Then
            TxtID.Clear()
        End If
    End Sub

    Private Sub TxtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtID.KeyPress
        Dim allowedChars As String = "1234567890"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
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
            ' Invalid Character
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
            ' Invalid Character
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
            ' Invalid Character
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
            ' Invalid Character
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
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        frmAddStudent.Show()
        Me.Hide()
    End Sub
End Class
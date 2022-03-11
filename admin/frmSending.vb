'Imports System.Management
'Imports System.Threading

'Public Class frmSending
'    Dim rcvdata As String = ""

'    Private Sub frmSending_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        Dim ports() As String
'        ports = Split(ModemsConnected(), "***")
'        For i As Integer = 0 To ports.Length - 2
'            ComboBox1.Items.Add(ports(i))
'        Next
'        Refresh()
'    End Sub

'    Public Function ModemsConnected() As String
'        Dim modems As String = ""
'        Try
'            Dim searcher As New ManagementObjectSearcher( _
'                "root\CIMV2", _
'                "SELECT * FROM Win32_NetworkAdapterConfiguration")
'            ''SELECT * FROM Win32_POTSModem
'            For Each queryObj As ManagementObject In searcher.Get()
'                If queryObj("Status") = "OK" Then
'                    modems = modems & (queryObj("AttachedTo") & " - " & queryObj("Description") & "***")
'                End If
'            Next
'        Catch err As ManagementException
'            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
'            Return ""
'        End Try
'        Return modems
'    End Function
'    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
'        Label1.Text = Trim(Mid(ComboBox1.Text, 1, 5))
'    End Sub

'    Public Sub serialport1_datareceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
'        Dim datain As String = ""
'        Dim numbytes As Integer = SerialPort1.BytesToRead
'        For i As Integer = 1 To numbytes
'            datain &= Chr(SerialPort1.ReadChar)
'        Next
'        test(datain)
'    End Sub
'    Private Sub test(ByVal indata As String)
'        rcvdata &= indata
'    End Sub

'    Private Sub cmbConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConnect.Click
'        Try
'            With SerialPort1
'                .PortName = Label1.Text
'                .BaudRate = 9600
'                .Parity = IO.Ports.Parity.None
'                .DataBits = 8
'                .StopBits = IO.Ports.StopBits.One
'                .Handshake = IO.Ports.Handshake.None
'                .RtsEnable = True
'                .ReceivedBytesThreshold = 1
'                .NewLine = vbCr
'                .ReadTimeout = 1000
'                .Open()

'                If SerialPort1.IsOpen Then
'                    Label3.Text = "Connected"
'                Else
'                    Label3.Text = "Not Connected"
'                End If
'            End With
'        Catch ex As Exception
'            MsgBox(ex.Message)
'        End Try

'        Refresh()

'    End Sub

'    Private Sub cmdsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsend.Click
'        Try
'            With SerialPort1
'                .Write("AT" & vbCrLf)
'                Threading.Thread.Sleep(1000)
'                .Write("AT + CMGF=1" & vbCrLf)
'                Threading.Thread.Sleep(1000)
'                .Write("AT + CMGS=" & Chr(34) & Txtnumber.Text & Chr(34) & vbCrLf)
'                .Write(Txtmessage.Text & Chr(26))
'                Threading.Thread.Sleep(1000)
'            End With
'            If rcvdata.ToString.Contains(">") Then
'                MsgBox("Message Sent")
'                Txtmessage.Text = ""
'            Else
'                MsgBox("Got Some Error")
'            End If
'        Catch ex As Exception
'        End Try
'    End Sub

'    Private Sub BtnBck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        frmListborrow.Show()
'    End Sub

'    Private Sub BtnBck1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBck1.Click
'        frmListborrow.Show()
'        Me.Hide()
'    End Sub
'End Class

'' send sms throgh online by azhar account

Imports System.Web
Imports System.Net
Imports LibrarySystem.connection

Public Class frmSending
    Dim rcvdata As String = ""

    Private Sub frmSending_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cmdsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsend.Click
        Send_SMS_Example()
    End Sub
    Sub Send_SMS_Example()

        'Create ViaNettSMS object with username and password
        Dim s As New ViaNettSMS(username:="mohammedazharuddin70@gmail.com", password:="cbrxm")
        'Declare Result object returned by the SendSMS function
        Dim result As ViaNettSMS.Result
        Try
            'Send SMS through HTTP API

            Dim parts As String() = Txtnumber.Text.Split(New Char() {","c})
            Dim part As String
            For Each part In parts
                result = s.SendSMS(msgsender:="Azhar", destinationaddr:=part.ToString(), message:=Txtmessage.Text.ToString())
                If result.Success Then
                    MessageBox.Show("Message successfully sent")
                Else
                    MessageBox.Show("Received error: " & result.ErrorCode & " " & result.ErrorMessage)
                End If
            Next

            'Show Send SMS response
           

        Catch ex As System.Net.WebException
            'Catch error occurred while connecting to server.
            Debug.WriteLine(ex.Message)
        End Try

    End Sub
End Class




''send sms through mobiloe 


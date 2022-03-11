'-------------------------------------------------------------------------------------------
' Updated: 29.10.2009
' This source code can only be used and altered together with ViaNett's SMS system.
'
' Requirements:
' You need to have a ViaNett SMS account.
' Register at: http://sms.vianett.com/cat/485.aspx
' You need to add System.Web as a reference.
' 
' Support: smssupport@vianett.no.
'-------------------------------------------------------------------------------------------

Option Strict On
Imports System.Web
Imports System.Net

''' <summary>
''' ViaNett SMS class provides an easy way of sending SMS messages through the HTTP API.
''' </summary>
Public Class ViaNettSMS
    Dim username As String
    Dim password As String

    ''' <summary>
    ''' Constructor with username and password to ViaNett gateway. 
    ''' </summary>
    Public Sub New(ByVal username As String, ByVal password As String)
        Me.username = username
        Me.password = password
    End Sub

    ''' <summary>
    ''' Send SMS message through the ViaNett HTTP API.
    ''' </summary>
    ''' <returns>Returns an object with the following parameters: Success, ErrorCode, ErrorMessage</returns>
    ''' <param name="msgsender">Message sender address. Mobile number or small text, e.g. company name</param>
    ''' <param name="destinationaddr">Message destination address. Mobile number.</param>
    ''' <param name="message">Text message</param>
    Public Function SendSMS(ByVal msgsender As String, _
                            ByVal destinationaddr As String, _
                            ByVal message As String) As Result

        'Declarations
        Dim url, serverResult As String, l As Long, result As Result

        'Build the URL request for sending SMS.
        url = "http://smsc.vianett.no/ActiveServer/MT/?" & _
        "username=" & HttpUtility.UrlEncode(username) & _
        "&password=" & HttpUtility.UrlEncode(password) & _
        "&destinationaddr=" & HttpUtility.UrlEncode(destinationaddr) & _
        "&message=" & HttpUtility.UrlEncode(message) & _
        "&refno=1" ' refno is required

        'Check if the message sender is numeric or alphanumeric.
        If Long.TryParse(msgsender, l) Then
            url = url & "&sourceAddr=" & msgsender
        Else
            url = url & "&fromAlpha=" & msgsender
        End If

        'Send the SMS by submitting the URL request to the server. The response is saved as an XML string.
        serverResult = DownloadString(url)
        'Converts the XML response from the server into a more structured Result object.
        result = ParseServerResult(serverResult)
        'Return the Result object.
        Return result
    End Function

    ''' <summary>
    ''' Downloads the URL from the server, and returns the response as string.
    ''' </summary>
    ''' <param name="URL"></param>
    ''' <returns>Returns the http/xml response as string</returns>
    ''' <exception cref="WebException">WebException is thrown if there is a connection problem.</exception>
    Private Function DownloadString(ByVal URL As String) As String
        'Create WebClient instanse.
        Using wlc As New System.Net.WebClient
            Try
                'Download and return the xml response
                Return wlc.DownloadString(URL)
            Catch ex As WebException
                'Failed to connect to server. Throw an exception with a customized text.
                Throw New WebException("Error occurred while connecting to server. " & ex.Message, ex)
            End Try
        End Using
    End Function

    ''' <summary>
    ''' Parses the XML code and returns a Result object.
    ''' </summary>
    ''' <param name="ServerResult">XML data from a request through HTTP API.</param>
    ''' <returns>Returns a Result object with the parsed data.</returns>
    Private Function ParseServerResult(ByVal ServerResult As String) As Result
        Dim xDoc As New System.Xml.XmlDocument()
        Dim ack As System.Xml.XmlNode
        Dim result As New Result

        xDoc.LoadXml(ServerResult)
        ack = xDoc.GetElementsByTagName("ack").Item(0)

        result.ErrorCode = CInt(ack.Attributes("errorcode").Value)
        result.ErrorMessage = ack.InnerText
        result.Success = (result.ErrorCode = 0)
        Return result
    End Function

    ''' <summary>
    ''' The Result object from the SendSMS function, which returns Success(Boolean), ErrorCode(Integer), ErrorMessage(String).
    ''' </summary>
    Public Class Result
        Public Success As Boolean
        Public ErrorCode As Integer
        Public ErrorMessage As String
    End Class

End Class


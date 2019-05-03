Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class TCPControl
    Public Event MessageReceived(sender As TCPControl, Data As String)


    ' SERVER CONFIG
    Public ServerIp As IPAddress = IPAddress.Parse("10.10.1.101")
    Public ServerPort As Integer = 64555
    Public Server As TcpListener

    Private commThread As Thread
    Public IsLitening As Boolean = True

    ' CLIENTS 
    Private Client As TcpClient
    Private ClientData As StreamReader
    Public Sub New()
        Server = New TcpListener(ServerIp, ServerPort)
        Server.Start()

        commThread = New Thread(New ThreadStart(AddressOf Listening))
        commThread.Start()
    End Sub


    Private Sub Listening()
        ' CREATES LISTENING LOOP
        Do Until IsLitening = False
            ' ACCEPT INCOMING CONNECTIONS
            If Server.Pending = True Then
                Client = Server.AcceptTcpClient
                ClientData = New StreamReader(Client.GetStream)
            End If

            'RAISE EVENT FOR INCOMING MESSAGES 
            Try
                RaiseEvent MessageReceived(Me, ClientData.ReadLine)
            Catch ex As Exception

            End Try

            ' CPU USAGE
            Thread.Sleep(100)

        Loop
    End Sub
End Class

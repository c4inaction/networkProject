﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Client As TCPControl

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        Client = New TCPControl("10.10.1.101", 64555)
        If Client.Client.Connected Then cmdConnect.Text = "connected"

    End Sub

    Private Sub cmdSend_Click(sender As Object, e As EventArgs) Handles cmdSend.Click
        SendMessage()
        txtMessage.Clear()
        txtMessage.Focus()
    End Sub

    Private Sub SendMessage()
        If Client.Client.Connected = True Then Client.Send(txtMessage.Text)
    End Sub

    Private Sub txtMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMessage.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendMessage()
            txtMessage.Clear()
            txtMessage.Focus()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Client.Client.Connected = True Then
            Client.DataStream.Close()
            Client.Client.Close()
        End If
    End Sub

End Class

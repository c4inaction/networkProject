Public Class Form1
    Private Server As TCPControl


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Server = New TCPControl
        txtChat.Text = "::: SERVER STARTED :::" & vbCrLf

        AddHandler Server.MessageReceived, AddressOf onlineRecieved
    End Sub

    Private Delegate Sub updateTextDelagete(TB As TextBox, txt As String)
    'UPDATE TEXTBOX 
    Private Sub updateText(TB As TextBox, txt As String)
        If TB.InvokeRequired Then
            TB.Invoke(New updateTextDelagete(AddressOf updateText), New Object() {TB, txt})
        Else
            If txt IsNot Nothing Then TB.AppendText(txt & vbCrLf)
        End If

    End Sub
    Private Sub onlineRecieved(sender As TCPControl, Data As String)
        updateText(txtChat, Data)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Server.IsLitening = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles descriptionMessage.TextChanged

    End Sub
End Class

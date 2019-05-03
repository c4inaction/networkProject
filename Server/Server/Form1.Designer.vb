<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.descriptionMessage = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PortVar = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtChat
        '
        Me.txtChat.Location = New System.Drawing.Point(12, 65)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.Size = New System.Drawing.Size(344, 174)
        Me.txtChat.TabIndex = 0
        '
        'descriptionMessage
        '
        Me.descriptionMessage.Location = New System.Drawing.Point(12, 3)
        Me.descriptionMessage.Name = "descriptionMessage"
        Me.descriptionMessage.Size = New System.Drawing.Size(234, 20)
        Me.descriptionMessage.TabIndex = 1
        Me.descriptionMessage.Text = "computer must be under same network as client"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(70, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'PortVar
        '
        Me.PortVar.Location = New System.Drawing.Point(221, 29)
        Me.PortVar.Name = "PortVar"
        Me.PortVar.Size = New System.Drawing.Size(100, 20)
        Me.PortVar.TabIndex = 3
        Me.PortVar.Tag = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(52, 20)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "Server IP"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(179, 29)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(36, 20)
        Me.TextBox4.TabIndex = 5
        Me.TextBox4.Text = "Port #"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 280)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.PortVar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.descriptionMessage)
        Me.Controls.Add(Me.txtChat)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtChat As TextBox
    Friend WithEvents descriptionMessage As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PortVar As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class

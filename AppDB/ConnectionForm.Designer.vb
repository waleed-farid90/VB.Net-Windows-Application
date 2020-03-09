<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConnectionForm
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
        Me.ServerText = New System.Windows.Forms.TextBox()
        Me.Server = New System.Windows.Forms.Label()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.DBNameText = New System.Windows.Forms.TextBox()
        Me.UserNameText = New System.Windows.Forms.TextBox()
        Me.UserName = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.DBName = New System.Windows.Forms.Label()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.ConnectRecent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ServerText
        '
        Me.ServerText.Location = New System.Drawing.Point(159, 30)
        Me.ServerText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ServerText.Name = "ServerText"
        Me.ServerText.Size = New System.Drawing.Size(217, 22)
        Me.ServerText.TabIndex = 0
        '
        'Server
        '
        Me.Server.AutoSize = True
        Me.Server.Location = New System.Drawing.Point(21, 38)
        Me.Server.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Server.Name = "Server"
        Me.Server.Size = New System.Drawing.Size(50, 17)
        Me.Server.TabIndex = 1
        Me.Server.Text = "Server"
        '
        'PasswordText
        '
        Me.PasswordText.Location = New System.Drawing.Point(159, 140)
        Me.PasswordText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordText.Size = New System.Drawing.Size(217, 22)
        Me.PasswordText.TabIndex = 2
        '
        'DBNameText
        '
        Me.DBNameText.Location = New System.Drawing.Point(159, 196)
        Me.DBNameText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DBNameText.Name = "DBNameText"
        Me.DBNameText.Size = New System.Drawing.Size(217, 22)
        Me.DBNameText.TabIndex = 3
        '
        'UserNameText
        '
        Me.UserNameText.Location = New System.Drawing.Point(159, 86)
        Me.UserNameText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserNameText.Name = "UserNameText"
        Me.UserNameText.Size = New System.Drawing.Size(217, 22)
        Me.UserNameText.TabIndex = 4
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.Location = New System.Drawing.Point(21, 95)
        Me.UserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(79, 17)
        Me.UserName.TabIndex = 5
        Me.UserName.Text = "User Name"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(21, 149)
        Me.Password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(69, 17)
        Me.Password.TabIndex = 6
        Me.Password.Text = "Password"
        '
        'DBName
        '
        Me.DBName.AutoSize = True
        Me.DBName.Location = New System.Drawing.Point(16, 204)
        Me.DBName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DBName.Name = "DBName"
        Me.DBName.Size = New System.Drawing.Size(110, 17)
        Me.DBName.TabIndex = 7
        Me.DBName.Text = "Database Name"
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(276, 266)
        Me.ConnectButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(100, 28)
        Me.ConnectButton.TabIndex = 8
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'ConnectRecent
        '
        Me.ConnectRecent.Location = New System.Drawing.Point(113, 266)
        Me.ConnectRecent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ConnectRecent.Name = "ConnectRecent"
        Me.ConnectRecent.Size = New System.Drawing.Size(143, 28)
        Me.ConnectRecent.TabIndex = 9
        Me.ConnectRecent.Text = "Connect Recent"
        Me.ConnectRecent.UseVisualStyleBackColor = True
        '
        'ConnectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 309)
        Me.Controls.Add(Me.ConnectRecent)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.DBName)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.UserNameText)
        Me.Controls.Add(Me.DBNameText)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.Server)
        Me.Controls.Add(Me.ServerText)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ConnectionForm"
        Me.Text = "ConnectionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ServerText As TextBox
    Friend WithEvents Server As Label
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents DBNameText As TextBox
    Friend WithEvents UserNameText As TextBox
    Friend WithEvents UserName As Label
    Friend WithEvents Password As Label
    Friend WithEvents DBName As Label
    Friend WithEvents ConnectButton As Button
    Friend WithEvents ConnectRecent As Button
End Class

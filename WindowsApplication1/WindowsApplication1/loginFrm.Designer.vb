<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginFrm
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
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.usernameTextbox = New System.Windows.Forms.TextBox()
        Me.passwordTextbox = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.usernameLabel.Location = New System.Drawing.Point(12, 9)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(102, 24)
        Me.usernameLabel.TabIndex = 0
        Me.usernameLabel.Text = "Username:"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.passwordLabel.Location = New System.Drawing.Point(12, 60)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(97, 24)
        Me.passwordLabel.TabIndex = 1
        Me.passwordLabel.Text = "Password:"
        '
        'usernameTextbox
        '
        Me.usernameTextbox.Location = New System.Drawing.Point(13, 37)
        Me.usernameTextbox.Name = "usernameTextbox"
        Me.usernameTextbox.Size = New System.Drawing.Size(208, 20)
        Me.usernameTextbox.TabIndex = 2
        '
        'passwordTextbox
        '
        Me.passwordTextbox.Location = New System.Drawing.Point(13, 88)
        Me.passwordTextbox.Name = "passwordTextbox"
        Me.passwordTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextbox.Size = New System.Drawing.Size(208, 20)
        Me.passwordTextbox.TabIndex = 3
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(16, 114)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(104, 26)
        Me.loginBtn.TabIndex = 4
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(126, 114)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(95, 26)
        Me.exitBtn.TabIndex = 5
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'loginFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 149)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.passwordTextbox)
        Me.Controls.Add(Me.usernameTextbox)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.usernameLabel)
        Me.Name = "loginFrm"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usernameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents usernameTextbox As TextBox
    Friend WithEvents passwordTextbox As TextBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents exitBtn As Button
End Class

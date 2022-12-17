<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.showpassCB = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(312, 210)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(135, 20)
        Me.txtpassword.TabIndex = 1
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(308, 187)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(135, 20)
        Me.txtusername.TabIndex = 0
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(329, 259)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 23)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(361, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(253, 187)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(58, 13)
        Me.Username.TabIndex = 4
        Me.Username.Text = "Username:"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(253, 217)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(53, 13)
        Me.Password.TabIndex = 5
        Me.Password.Text = "Password"
        '
        'showpassCB
        '
        Me.showpassCB.AutoSize = True
        Me.showpassCB.Location = New System.Drawing.Point(317, 236)
        Me.showpassCB.Name = "showpassCB"
        Me.showpassCB.Size = New System.Drawing.Size(102, 17)
        Me.showpassCB.TabIndex = 3
        Me.showpassCB.Text = "Show Password"
        Me.showpassCB.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(674, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 50)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.showpassCB)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtpassword)
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Username As Label
    Friend WithEvents Password As Label
    Friend WithEvents showpassCB As CheckBox
    Friend WithEvents btnExit As Button
End Class

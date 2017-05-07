<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseConfig
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PasswordLbl = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtServerHost = New System.Windows.Forms.TextBox()
        Me.DataBaseLbl = New System.Windows.Forms.Label()
        Me.UsernameLbl = New System.Windows.Forms.Label()
        Me.ServerHostLbl = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PageLbl = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PasswordLbl)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtDatabase)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.txtServerHost)
        Me.GroupBox1.Controls.Add(Me.DataBaseLbl)
        Me.GroupBox1.Controls.Add(Me.UsernameLbl)
        Me.GroupBox1.Controls.Add(Me.ServerHostLbl)
        Me.GroupBox1.Controls.Add(Me.cmdClose)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.cmdTest)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 299)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connect to MySQL Server"
        '
        'PasswordLbl
        '
        Me.PasswordLbl.AutoSize = True
        Me.PasswordLbl.Location = New System.Drawing.Point(30, 107)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(73, 17)
        Me.PasswordLbl.TabIndex = 9
        Me.PasswordLbl.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Info
        Me.txtPassword.Location = New System.Drawing.Point(137, 104)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(231, 23)
        Me.txtPassword.TabIndex = 5
        '
        'txtDatabase
        '
        Me.txtDatabase.BackColor = System.Drawing.SystemColors.Info
        Me.txtDatabase.Location = New System.Drawing.Point(137, 137)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(231, 23)
        Me.txtDatabase.TabIndex = 6
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.SystemColors.Info
        Me.txtUserName.Location = New System.Drawing.Point(137, 72)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(231, 23)
        Me.txtUserName.TabIndex = 4
        '
        'txtServerHost
        '
        Me.txtServerHost.BackColor = System.Drawing.SystemColors.Info
        Me.txtServerHost.Location = New System.Drawing.Point(137, 38)
        Me.txtServerHost.Name = "txtServerHost"
        Me.txtServerHost.Size = New System.Drawing.Size(231, 23)
        Me.txtServerHost.TabIndex = 3
        '
        'DataBaseLbl
        '
        Me.DataBaseLbl.AutoSize = True
        Me.DataBaseLbl.Location = New System.Drawing.Point(30, 140)
        Me.DataBaseLbl.Name = "DataBaseLbl"
        Me.DataBaseLbl.Size = New System.Drawing.Size(73, 17)
        Me.DataBaseLbl.TabIndex = 10
        Me.DataBaseLbl.Text = "Database:"
        '
        'UsernameLbl
        '
        Me.UsernameLbl.AutoSize = True
        Me.UsernameLbl.Location = New System.Drawing.Point(29, 75)
        Me.UsernameLbl.Name = "UsernameLbl"
        Me.UsernameLbl.Size = New System.Drawing.Size(77, 17)
        Me.UsernameLbl.TabIndex = 8
        Me.UsernameLbl.Text = "Username:"
        '
        'ServerHostLbl
        '
        Me.ServerHostLbl.AutoSize = True
        Me.ServerHostLbl.Location = New System.Drawing.Point(29, 41)
        Me.ServerHostLbl.Name = "ServerHostLbl"
        Me.ServerHostLbl.Size = New System.Drawing.Size(87, 17)
        Me.ServerHostLbl.TabIndex = 7
        Me.ServerHostLbl.Text = "Server Host:"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmdClose.Location = New System.Drawing.Point(260, 212)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(108, 40)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmdSave.Location = New System.Drawing.Point(146, 212)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(108, 40)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdTest
        '
        Me.cmdTest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmdTest.Location = New System.Drawing.Point(32, 212)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(108, 40)
        Me.cmdTest.TabIndex = 0
        Me.cmdTest.Text = "&Test "
        Me.cmdTest.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PageLbl)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 86)
        Me.Panel1.TabIndex = 1
        '
        'PageLbl
        '
        Me.PageLbl.AutoSize = True
        Me.PageLbl.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PageLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageLbl.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.PageLbl.Location = New System.Drawing.Point(37, 28)
        Me.PageLbl.Name = "PageLbl"
        Me.PageLbl.Size = New System.Drawing.Size(322, 31)
        Me.PageLbl.TabIndex = 0
        Me.PageLbl.Text = "Database Configuration"
        '
        'DatabaseConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 419)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DatabaseConfig"
        Me.Text = "Database"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataBaseLbl As System.Windows.Forms.Label
    Friend WithEvents UsernameLbl As System.Windows.Forms.Label
    Friend WithEvents ServerHostLbl As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdTest As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PageLbl As System.Windows.Forms.Label
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtServerHost As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLbl As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
End Class

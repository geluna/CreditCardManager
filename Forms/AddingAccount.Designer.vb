<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddingAccount
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CreditorTxtFld = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.URLTxtFld = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UsernameTxtFld = New System.Windows.Forms.TextBox()
        Me.PassTxtFld = New System.Windows.Forms.TextBox()
        Me.APRTxtFld = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.DueDateTxtFld = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of Creditor:"
        '
        'CreditorTxtFld
        '
        Me.CreditorTxtFld.Location = New System.Drawing.Point(306, 109)
        Me.CreditorTxtFld.Name = "CreditorTxtFld"
        Me.CreditorTxtFld.Size = New System.Drawing.Size(253, 22)
        Me.CreditorTxtFld.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "URL of website login page:"
        '
        'URLTxtFld
        '
        Me.URLTxtFld.Location = New System.Drawing.Point(306, 155)
        Me.URLTxtFld.Name = "URLTxtFld"
        Me.URLTxtFld.Size = New System.Drawing.Size(253, 22)
        Me.URLTxtFld.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Annual APR:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Payment monthly due date:"
        '
        'UsernameTxtFld
        '
        Me.UsernameTxtFld.Location = New System.Drawing.Point(306, 201)
        Me.UsernameTxtFld.Name = "UsernameTxtFld"
        Me.UsernameTxtFld.Size = New System.Drawing.Size(253, 22)
        Me.UsernameTxtFld.TabIndex = 8
        '
        'PassTxtFld
        '
        Me.PassTxtFld.Location = New System.Drawing.Point(306, 240)
        Me.PassTxtFld.Name = "PassTxtFld"
        Me.PassTxtFld.Size = New System.Drawing.Size(253, 22)
        Me.PassTxtFld.TabIndex = 9
        '
        'APRTxtFld
        '
        Me.APRTxtFld.Location = New System.Drawing.Point(306, 283)
        Me.APRTxtFld.Name = "APRTxtFld"
        Me.APRTxtFld.Size = New System.Drawing.Size(253, 22)
        Me.APRTxtFld.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(180, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 29)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "New Creditor Form"
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(322, 379)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(108, 57)
        Me.SaveBtn.TabIndex = 13
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(451, 379)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(108, 57)
        Me.CloseBtn.TabIndex = 14
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'DueDateTxtFld
        '
        Me.DueDateTxtFld.Location = New System.Drawing.Point(306, 322)
        Me.DueDateTxtFld.Name = "DueDateTxtFld"
        Me.DueDateTxtFld.Size = New System.Drawing.Size(253, 22)
        Me.DueDateTxtFld.TabIndex = 15
        '
        'AddingAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 460)
        Me.Controls.Add(Me.DueDateTxtFld)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.APRTxtFld)
        Me.Controls.Add(Me.PassTxtFld)
        Me.Controls.Add(Me.UsernameTxtFld)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.URLTxtFld)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CreditorTxtFld)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddingAccount"
        Me.Text = "AddingAccount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CreditorTxtFld As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents URLTxtFld As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UsernameTxtFld As System.Windows.Forms.TextBox
    Friend WithEvents PassTxtFld As System.Windows.Forms.TextBox
    Friend WithEvents APRTxtFld As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents DueDateTxtFld As System.Windows.Forms.DateTimePicker
End Class

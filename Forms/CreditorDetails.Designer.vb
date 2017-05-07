<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditorDetails
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
        Me.StoreNameLbl = New System.Windows.Forms.Label()
        Me.BankLbl = New System.Windows.Forms.Label()
        Me.APRLbl = New System.Windows.Forms.Label()
        Me.BalanceLbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StoreNameLbl
        '
        Me.StoreNameLbl.AutoSize = True
        Me.StoreNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StoreNameLbl.Location = New System.Drawing.Point(174, 24)
        Me.StoreNameLbl.Name = "StoreNameLbl"
        Me.StoreNameLbl.Size = New System.Drawing.Size(48, 20)
        Me.StoreNameLbl.TabIndex = 0
        Me.StoreNameLbl.Text = "Store"
        '
        'BankLbl
        '
        Me.BankLbl.AutoSize = True
        Me.BankLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankLbl.Location = New System.Drawing.Point(31, 69)
        Me.BankLbl.Name = "BankLbl"
        Me.BankLbl.Size = New System.Drawing.Size(40, 17)
        Me.BankLbl.TabIndex = 1
        Me.BankLbl.Text = "Bank"
        '
        'APRLbl
        '
        Me.APRLbl.AutoSize = True
        Me.APRLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APRLbl.Location = New System.Drawing.Point(31, 108)
        Me.APRLbl.Name = "APRLbl"
        Me.APRLbl.Size = New System.Drawing.Size(36, 17)
        Me.APRLbl.TabIndex = 2
        Me.APRLbl.Text = "APR"
        '
        'BalanceLbl
        '
        Me.BalanceLbl.AutoSize = True
        Me.BalanceLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceLbl.Location = New System.Drawing.Point(283, 73)
        Me.BalanceLbl.Name = "BalanceLbl"
        Me.BalanceLbl.Size = New System.Drawing.Size(34, 17)
        Me.BalanceLbl.TabIndex = 3
        Me.BalanceLbl.Text = "BAL"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 433)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CreditorDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 479)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BalanceLbl)
        Me.Controls.Add(Me.APRLbl)
        Me.Controls.Add(Me.BankLbl)
        Me.Controls.Add(Me.StoreNameLbl)
        Me.Name = "CreditorDetails"
        Me.Text = "CreditorDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StoreNameLbl As System.Windows.Forms.Label
    Friend WithEvents BankLbl As System.Windows.Forms.Label
    Friend WithEvents APRLbl As System.Windows.Forms.Label
    Friend WithEvents BalanceLbl As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

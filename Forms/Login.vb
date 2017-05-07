Imports System.Data.SqlClient

Public Class Login

    Private Sub Login()
        Try
            Dim sql As String
            Dim ds As New DataSet
            Dim sConnectionString = "Server = '" & ServerSQL & "';  " _
                                       & "Database = '" & DBNameSQL & "'; " _
                                       & "user id = '" & UserNameSQL & "'; " _
                                        & "password = '" & PwdSQL & "'"
            sql = "SELECT * FROM Users WHERE Email = '" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "'"

            Dim con As New SqlConnection(sConnectionString)
            Dim cmd As New SqlCommand(sql, con)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "dbCreditCardManager")

            If ds.Tables(0).Rows(0)(0) <> 0 Then
                Dashboard.ShowDialog()
                Me.Hide()
            Else
                MsgBox("Incorrect username or password.", MsgBoxStyle.Critical, "Login")
                txtUsername.SelectAll()
                txtPassword.SelectAll()
            End If
        Catch ex As Exception

 
        End Try
        ' cmd.Dispose()
        ' conn.Close()
        Me.Close()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Login()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        If MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo, "Close Window") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If

        If e.KeyCode = Keys.F12 Then
            DatabaseConfig.ShowDialog()
        End If
        If e.KeyCode = Keys.Enter Then
            Login()
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        getData()
    End Sub


    '  Private Sub PasswordPicBox_Click_1(sender As Object, e As EventArgs) Handles PasswordPicBox.Click

    '     PasswordPicBox.Image = Image.FromFile("C:\Users\GEL8953\Desktop\PasswordOFF.PNG") Then
    '  End Sub

    Private Sub PasswordPicBox_MouseDown(sender As Object, e As MouseEventArgs) Handles PasswordPicBox.MouseDown
        PasswordPicBox.Image = Image.FromFile("C:\Users\GEL8953\Desktop\PasswordOFF.PNG")
        txtPassword.PasswordChar = ""
    End Sub

    Private Sub PasswordPicBox_MouseUp(sender As Object, e As MouseEventArgs) Handles PasswordPicBox.MouseUp
        PasswordPicBox.Image = Image.FromFile("C:\Users\GEL8953\Desktop\PasswordON.PNG")
        txtPassword.PasswordChar = "*"
    End Sub
End Class
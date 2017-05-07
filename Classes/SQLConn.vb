Imports System.Data.SqlClient

Module SQLConn
    Public ServerSQL As String
    Public UserNameSQL As String
    Public PwdSQL As String
    Public DBNameSQL As String
    Public sqL As String
    Public ds As New DataSet()
    'Public cmd As MySqlCommand
    'Public dr As MySqlDataReader
    'Public da As New MySqlDataAdapter
    'Public conn As New MySqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public da As New SqlDataAdapter
    Public conn As New SqlConnection
    'Public conn = "Server=my_server;Database=name_of_db;User Id=user_name;Password=my_password"
    Sub getData()
        Dim AppName As String = Application.ProductName

        Try
            DBNameSQL = "dbCreditCardManager"
            'GetSetting(AppName, "DBSection", "DB_Name", "temp")
            ServerSQL = "192.168.1.65\ITSOL"
            'GetSetting(AppName, "DBSection", "DB_IP", "temp")
            UserNameSQL = "generic"
            'GetSetting(AppName, "DBSection", "DB_User", "temp")
            PwdSQL = "generic"
            'GetSetting(AppName, "DBSection", "DB_Password", "temp")
        Catch ex As Exception
            MsgBox("System registry was not established, you can set/save " & _
            "these settings by pressing F1", MsgBoxStyle.Information)
        End Try

    End Sub

    Public Sub ConnDB()
        conn.Close()
        Try
            conn.ConnectionString = "Server = '" & ServerSQL & "';  " _
                                         & "Database = '" & DBNameSQL & "'; " _
                                         & "user id = '" & UserNameSQL & "'; " _
                                         & "password = '" & PwdSQL & "'"

            conn.Open()
        Catch ex As Exception
            MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings")
        End Try

    End Sub

    Public Sub DisconnMy()

        conn.Close()
        conn.Dispose()

    End Sub

    Sub SaveData()
        Dim AppName As String = Application.ProductName

        SaveSetting(AppName, "DBSection", "DB_Name", DBNameSQL)
        SaveSetting(AppName, "DBSection", "DB_IP", ServerSQL)
        SaveSetting(AppName, "DBSection", "DB_User", UserNameSQL)
        SaveSetting(AppName, "DBSection", "DB_Password", PwdSQL)

        MsgBox("Database connection settings are saved.", MsgBoxStyle.Information)
    End Sub

End Module

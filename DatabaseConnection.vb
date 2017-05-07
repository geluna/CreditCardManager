Public Class DatabaseConnection

    'Sub getData()
    '    Dim AppName As String = Application.ProductName

    '    Try
    '        DBNameSQL = "dbCreditCardManager"
    '        'GetSetting(AppName, "DBSection", "DB_Name", "temp")
    '        ServerSQL = "localhost"
    '        'GetSetting(AppName, "DBSection", "DB_IP", "temp")
    '        UserNameSQL = "root"
    '        'GetSetting(AppName, "DBSection", "DB_User", "temp")
    '        PwdSQL = "root"
    '        'GetSetting(AppName, "DBSection", "DB_Password", "temp")
    '    Catch ex As Exception
    '        MsgBox("System registry was not established, you can set/save " & _
    '        "these settings by pressing F1", MsgBoxStyle.Information)
    '    End Try

    'End Sub

    'Public Sub ConnDB()
    '    conn.Close()
    '    Try
    '        conn.ConnectionString = "Server = '" & ServerSQL & "';  " _
    '                                   & "Database = '" & DBNameSQL & "'; " _
    '                                     & "user id = '" & UserNameSQL & "'; " _
    '                                     & "password = '" & PwdSQL & "'"

    '        conn.Open()
    '    Catch ex As Exception
    '        MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings")
    '    End Try
    'End Sub

    'Public Sub DisconnMy()
    '    conn.Close()
    '    conn.Dispose()
    'End Sub

    'Sub SaveData()
    '    Dim AppName As String = Application.ProductName

    '    SaveSetting(AppName, "DBSection", "DB_Name", DBNameSQL)
    '    SaveSetting(AppName, "DBSection", "DB_IP", ServerSQL)
    '    SaveSetting(AppName, "DBSection", "DB_User", UserNameSQL)
    '    SaveSetting(AppName, "DBSection", "DB_Password", PwdSQL)

    '    MsgBox("Database connection settings are saved.", MsgBoxStyle.Information)
    'End Sub
    ''Access Database Connection String to local access database
    ''Public Function GetCCInformationData() As DataSet
    ''    Dim Con As New OleDb.OleDbConnection
    ''    Dim dbProvider As String
    ''    Dim dbSource As String
    ''    Dim ds As New DataSet
    ''    Dim da As New OleDb.OleDbDataAdapter
    ''    Dim sql As String
    ''    dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
    ''    dbSource = "Data Source = " + Application.StartupPath + "\CreditCardInformation.accdb"
    ''    Con.ConnectionString = dbProvider & dbSource
    ''    Con.Open()
    ''    sql = "Select * From CCInformation"
    ''    da = New OleDb.OleDbDataAdapter(sql, Con)
    ''    da.Fill(ds, "CCInformation")
    ''    Return ds
    ''End Function

    ''Sql Connnection String to Local Database MDF file
 

End Class

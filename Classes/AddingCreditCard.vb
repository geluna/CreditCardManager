Imports System.Data.OleDb

Public Class AddingCreditCard


    Public Sub AddAccount(Creditor As String, URL As String, Username As String, Pass As String, APR As String, Due As DateTime)
        'Adding an account to the CCInformation table
        Dim Con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter
        Dim sql As String
        dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " + Application.StartupPath + "\CreditCardInformation.accdb"
        Con.ConnectionString = dbProvider & dbSource
        Try
            Con.Open()
            sql += "INSERT INTO CreditCardInformation"
            sql += "([CCCompany] "
            sql += ",[Website] "
            sql += ",[Username]"
            sql += ",[Password]"
            sql += ",[InterestRate]"
            sql += ",[PaymentDueDate])"
            sql += "VALUES"
            sql += "(@Creditor,"
            sql += "@URL,"
            sql += "@Username,"
            sql += "@Pass,"
            sql += "@APR,"
            sql += "@Due)"
            Dim Command As New OleDbCommand(sql, Con)
            Command.Parameters.Add("@Creditor", SqlDbType.VarChar)
            Command.Parameters("@Creditor").Value = Creditor
            Command.Parameters.Add("@URL", SqlDbType.VarChar)
            Command.Parameters("@URL").Value = URL
            Command.Parameters.Add("@Username", SqlDbType.VarChar)
            Command.Parameters("@Username").Value = Username
            Command.Parameters.Add("@Pass", SqlDbType.VarChar)
            Command.Parameters("@Pass").Value = Pass
            Command.Parameters.Add("@APR", SqlDbType.VarChar)
            Command.Parameters("@APR").Value = APR
            Command.Parameters.Add("@Due", SqlDbType.DateTime)
            Command.Parameters("@Due").Value = Due

            Command.ExecuteNonQuery()
            Con.Close()

        Catch ex As Exception

        End Try


    End Sub

End Class

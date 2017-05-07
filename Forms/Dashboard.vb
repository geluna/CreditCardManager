

Public Class Dashboard

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
        'or you can use 
        'Me.CenterToParent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Today's Date is " + Date.Now.ToString("d")
        '   NextBillDue()
        '   FillDataGrid()
    End Sub

    'Public Sub NextBillDue()
    '    Dim dbConn As New DatabaseConnection
    '    Dim ds As DataSet
    '    Dim dt As DataTable
    '    Dim dr As DataRow
    '    Dim CurrentDate = Date.Now.ToString("d")
    '    Dim CompareDate As Date
    '    Dim Count As Int16

    '    ds = dbConn.GetCCInformationData()
    '    dt = ds.Tables(0)

    '    For Each dr In dt.Rows
    '        CompareDate = DateTime.Parse(dr("PaymentDueDate"))
    '        If CompareDate < DateTime.Parse(CurrentDate) Then
    '            Count += 1
    '        End If
    '    Next
    '    If Count > 1 Then
    '        '     OverDueLbl.Text = "You have " + Count.ToString + " overdue accounts!"
    '    ElseIf Count = 1 Then
    '        '   OverDueLbl.Text = "You have " + Count.ToString + " overdue account!"
    '    Else
    '        '   OverDueLbl.Text = ""
    '    End If

    'End Sub

    'Private Sub CreditorWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'TODO: This line of code loads data into the 'UserCellPhoneHistory._UserCellPhoneHistory' table. You can move, or remove it, as needed.
    '    '    Me.UserCellPhoneHistoryTableAdapter.Fill(Me.UserCellPhoneHistory._UserCellPhoneHistory)
    '    '   FillDataGrid()
    '    Me.DataGridView1.ColumnHeadersDefaultCellStyle.Format = "MM-dd-yyyy"
    '    Me.DataGridView1.Sort(DataGridView1.Columns("CCCompany"), System.ComponentModel.ListSortDirection.Ascending)

    '    'Fills DataGridView and resizes columns to fit the newly loaded data.
    '    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '    DataGridView1.AutoResizeColumns()
    '    Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    '    DataGridView1.Columns("Username").Visible = False
    '    DataGridView1.Columns("Password").Visible = False
    '    DataGridView1.Columns("InterestRate").Visible = False
    '    DataGridView1.RowHeadersVisible = False

    'End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

    End Sub


    'Public Sub FillDataGrid()
    '    Dim dbConn As New DatabaseConnection
    '    Dim ds = dbConn.GetCCInformationData()
    '    DataGridView1.DataSource = ds.Tables(0)
    'End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
            If Me.DataGridView1.Rows(i).Cells("PaymentDueDate").Value < Now() Then
                Me.DataGridView1.Rows(i).Cells("PaymentDueDate").Style.BackColor = Color.Red
            End If
        Next


    End Sub
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim Add As AddingAccount
        AddingAccount.Show()
    End Sub


    Private Sub SQLDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SQLDatabaseToolStripMenuItem.Click
        DatabaseConfig.ShowDialog()
    End Sub
End Class


Public Class AddingAccount

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
        'or you can use 
        'Me.CenterToParent()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim Creditor As String
        Dim URL As String
        Dim Username As String
        Dim Pass As String
        Dim APR As String
        Dim DueDate As DateTime
        Dim Add As New AddingCreditCard
        Creditor = CreditorTxtFld.Text
        URL = URLTxtFld.Text
        Username = UsernameTxtFld.Text
        Pass = PassTxtFld.Text
        APR = APRTxtFld.Text
        DueDate = DueDateTxtFld.Text
        If Creditor = "" Or URL = "" Or Username = "" Or Pass = "" Or APR = "" Or DueDate = "" Then
            MessageBox.Show("Please fill all fields!")
        Else
            If MessageBox.Show("Are You Sure all information is correct?", "Verification", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Add.AddAccount(Creditor, URL, Username, Pass, APR, DueDate)
            Else

            End If
        End If
    End Sub



End Class
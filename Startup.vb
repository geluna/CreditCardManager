Module Startup

    Sub Main()
        'If System.IO.File.Exists("C:\Users\GEL8953\Documents\Visual Studio 2013\Projects\CreditCardManager\CreditCardManager\bin\Debug\config.ini") Then
        '    PCA.Core.Globals.BootStrap("C:\Users\GEL8953\Documents\Visual Studio 2013\Projects\CreditCardManager\CreditCardManager\bin\Debug\config.ini", True)
        'End If
        Dim f As New Login

        f.ShowDialog()
    End Sub


End Module

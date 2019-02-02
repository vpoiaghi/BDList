Imports System.Net
Imports System.Text

Public NotInheritable Class PurchasesReadersFactory

    Public Shared Function GetPurchaseReader(url As String) As IPurchaseReader

        Dim purchaseReader As IPurchaseReader = Nothing
        Dim source As String = GetSource(url)

        If Not String.IsNullOrEmpty(source) Then
            purchaseReader = SelectPurchaseReader(url)
            purchaseReader.ReadSource(source)
        End If

        Return purchaseReader

    End Function

    Private Shared Function GetSource(url As String) As String

        Dim webClient As New WebClient
        Dim source As String = Nothing

        Try
            webClient.Encoding = Encoding.UTF8
            source = webClient.DownloadString(url)
        Catch e As ArgumentNullException
        Catch e As WebException
        Catch e As NotSupportedException
        End Try

        Return source

    End Function

    Private Shared Function SelectPurchaseReader(url As String) As IPurchaseReader

        Dim result As IPurchaseReader = Nothing

        If url.StartsWith("") Then
            result = New PurchaseReaderEBay()
        End If

        Return result

    End Function

End Class

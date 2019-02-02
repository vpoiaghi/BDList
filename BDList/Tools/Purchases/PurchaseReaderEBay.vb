Imports System.Globalization
Imports FrameworkPN

Public Class PurchaseReaderEBay
    Inherits PurchaseReader

    ' Pour utiliser l'API ebay, ajouter cette référence Web au projet: http://developer.ebay.com/webservices/latest/ebaySvc.wsdl

    ' Page de test de l'api : https://developer.ebay.com/DevZone/build-test/test-tool/default.aspx?index=0&env=production&api=offer&call=bidding-item_id_place_proxy_bid__POST&variation=json



    ' Clés d'identification pour accès à l'API ebay sur une version bac-à-sable d'eBay.
    ' Associé au compte ebpoy (mp : edpPoy!!00) pour l'application BDList
    ' https://developer.ebay.com/
    Private Const KEY_APP_ID As String = "PoiaghiV-BDList-SBX-5c230b90b-fa5b2c77"       ' Client ID (User Tokens|Notifications|API Reports)
    Private Const KEY_DEV_ID As String = "42701dcf-a7bf-4af5-a456-82d1022d85ab"
    Private Const KEY_CERT_ID As String = "SBX-c230b90b129c-a6db-4b25-af62-ec9c"        ' Client secret (Rotate (Reset) Cert ID)

    ' Clés d'identification pour accès à l'API ebay en production (vrai site ebay).
    ' Associé au compte ebpoy (mp : edpPoy!!00) pour l'application BDList
    ' https://developer.ebay.com/
    Private Const KEY_PROD_APP_ID As String = "PoiaghiV-BDList-PRD-bc22b8256-664ca9d8"       ' Client ID (User Tokens|Notifications|API Reports)
    Private Const KEY_PROD_DEV_ID As String = "42701dcf-a7bf-4af5-a456-82d1022d85ab"
    Private Const KEY_PROD_CERT_ID As String = "PRD-c22b8256e8a4-b8d0-4259-87e7-351d"        ' Client secret (Rotate (Reset) Cert ID)



    Public Overrides Function GetBaseUrl() As String
        Return "https://www.ebay.fr"
    End Function

    Public Overrides Function GetSiteName() As String
        Return "eBay"
    End Function

    Protected Overrides Function ExtractTitle(ByVal source As HtmlDocument) As String

        Dim e As HtmlElement = source.GetElementById("itemTitle")
        Dim eText As String = e.InnerHtml
        Dim spanPart As String = e.FirstChild.OuterHtml

        Return eText.Substring(spanPart.Length)

    End Function

    Protected Overrides Function ExtractImages(ByVal source As HtmlDocument) As List(Of Image)

        Dim images As New List(Of Image)

        Dim urlImage As String = source.GetElementById("icImg").GetAttribute("src")
        urlImage = urlImage.Substring(0, urlImage.LastIndexOf("/")) & "/s-l1600.jpg"

        Dim img As Image = ImageUtils.LoadWebImage(urlImage)

        If img IsNot Nothing Then
            images.Add(img)
        End If

        Return images

    End Function

    Protected Overrides Function ExtractEndOfValidity(ByVal source As HtmlDocument) As DateTime?

        Dim result As DateTime? = Nothing
        Dim element As HtmlElement = source.GetElementById("bb_tlft")

        If element IsNot Nothing Then

            Dim txt As String = element.InnerText
            txt = txt.Replace(".", "").Replace("Paris", "").Trim().ToLower()

            Dim parts() As String = txt.Split(" ")

            Select Case parts(1)
                Case "jan" : parts(1) = "01"
                Case "fév" : parts(1) = "02"
                Case "mar" : parts(1) = "03"
                Case "avr" : parts(1) = "04"
                Case "mai" : parts(1) = "05"
                Case "jui" : parts(1) = "06"
                Case "jui" : parts(1) = "07"
                Case "aou" : parts(1) = "08"
                Case "sep" : parts(1) = "09"
                Case "oct" : parts(1) = "10"
                Case "nov" : parts(1) = "11"
                Case "déc" : parts(1) = "12"
            End Select

            txt = parts(0) & "/" & parts(1) & "/" & parts(2) & " " & parts(3)
            result = DateTime.ParseExact(txt, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)

        End If

        Return result

    End Function

    Protected Overrides Function ExtractCurrentCost(ByVal source As HtmlDocument) As Single?

        Dim element As HtmlElement = source.GetElementById("prcIsum_bidPrice")
        Return CSng(element.GetAttribute("content").Replace(".", ","))

    End Function

    Protected Overrides Function ExtractComments(ByVal source As HtmlDocument) As String

        Dim comments As String = ""

        Try
            Dim element As HtmlElement = source.GetElementById("ds_div")
            comments = element.InnerText
        Catch e As exception
        End Try

        Return comments

    End Function



End Class

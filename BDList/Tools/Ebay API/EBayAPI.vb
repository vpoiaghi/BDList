Imports System.Net
Imports System.Web.Script.Serialization
'Imports BDList.com.ebay.developer

Namespace BDList_API.EBay

    ' Pour référencer l'API ebay, suivre le guide suivant :
    ' https://developer.ebay.com/devzone/xml/docs/HowTo/FirstCall/MakingCallCSharp.html
    ' en utilisant à la place de l'url avec "latest" cette url :
    ' http://developer.ebay.com/webservices/989/ebaySvc.wsdl

    Public Class EBayAPI

        ' Clés d'identification pour accès à l'API ebay sur une version bac-à-sable d'eBay.
        ' Associé au compte ebpoy (mp : edpPoy!!00) pour l'application BDList
        ' https://developer.ebay.com/
        Private Const KEY_SANDBOX_APP_ID As String = "PoiaghiV-BDList-SBX-5c230b90b-fa5b2c77"       ' Client ID (User Tokens|Notifications|API Reports)
        Private Const KEY_SANDBOX_DEV_ID As String = "42701dcf-a7bf-4af5-a456-82d1022d85ab"
        Private Const KEY_SANDBOX_CERT_ID As String = "SBX-c230b90b129c-a6db-4b25-af62-ec9c"        ' Client secret (Rotate (Reset) Cert ID)

        ' Clés d'identification pour accès à l'API ebay en production (vrai site ebay).
        ' Associé au compte ebpoy (mp : edpPoy!!00) pour l'application BDList
        ' https://developer.ebay.com/
        Private Const KEY_PROD_APP_ID As String = "PoiaghiV-BDList-PRD-bc22b8256-664ca9d8"       ' Client ID (User Tokens|Notifications|API Reports)
        Private Const KEY_PROD_DEV_ID As String = "42701dcf-a7bf-4af5-a456-82d1022d85ab"
        Private Const KEY_PROD_CERT_ID As String = "PRD-c22b8256e8a4-b8d0-4259-87e7-351d"        ' Client secret (Rotate (Reset) Cert ID)

        Public Sub FirstTestWithReferencedAPI()

            'Dim EndPoint As String = "https://api.sandbox.ebay.com/wsapi"
            'Dim callName As String = "GeteBayOfficialTime"
            'Dim siteId As String = "0"
            'Dim appId As String = KEY_SANDBOX_APP_ID
            'Dim devId As String = KEY_SANDBOX_DEV_ID
            'Dim certId As String = KEY_SANDBOX_CERT_ID
            'Dim Version As String = "405"

            ''Build the request URL
            'Dim requestURL As String _
            '    = EndPoint _
            '    & "?callname=" + callName _
            '    & "&siteid=" + siteId _
            '    & "&appid=" + appId _
            '    & "&version=" + Version _
            '    & "&routing=default"

            '' Create the service
            'Dim service As New eBayAPIInterfaceService()
            'service.Url = requestURL

            '' Set credentials
            'service.RequesterCredentials = New CustomSecurityHeaderType()
            'service.RequesterCredentials.eBayAuthToken = "yourToken"
            'service.RequesterCredentials.Credentials = New UserIdPasswordType()
            'service.RequesterCredentials.Credentials.AppId = appId
            'service.RequesterCredentials.Credentials.DevId = devId
            'service.RequesterCredentials.Credentials.AuthCert = certId

            '' Make the call to GeteBayOfficialTime
            'Dim request As New GeteBayOfficialTimeRequestType()
            'request.Version = "405"
            'Dim response As GeteBayOfficialTimeResponseType = service.GeteBayOfficialTime(request)
            'Console.WriteLine("The time at eBay headquarters in San Jose, California, USA, is:")
            'Console.WriteLine(response.Timestamp)

        End Sub



        Public Function SearchByKeywords(keywords As String)

            Dim json As String
            Dim results As EBayResult
            Dim result As EBayItem = Nothing

            keywords = keywords.Replace(" ", "%20")

            Dim url As String = "http://svcs.ebay.com/services/search/FindingService/v1" _
                & "?OPERATION-NAME=findItemsByKeywords" _
                & "&SERVICE-VERSION=1.0.0" _
                & "&SECURITY-APPNAME=PoiaghiV-BDList-PRD-bc22b8256-664ca9d8" _
                & "&RESPONSE-DATA-FORMAT=JSON" _
                & "&REST-PAYLOAD" _
                & "&keywords=" & keywords

            Using client As New WebClient()
                json = client.DownloadString(url)
                results = (New JavaScriptSerializer()).Deserialize(Of EBayResult)(json)
            End Using

            'If results IsNot Nothing _
            '    AndAlso results.FindItemsByKeywordsResponse IsNot Nothing _
            '    AndAlso results.FindItemsByKeywordsResponse.Count > 0 _
            '    AndAlso results.FindItemsByKeywordsResponse(0).SearchResult IsNot Nothing Then

            '    If results.FindItemsByKeywordsResponse.SearchResult.Count > 0 Then
            '        result = results.FindItemsByKeywordsResponse.SearchResult(0).Item(0)
            '    End If

            'End If


            Return result

        End Function

        Public Function GetItemById(id As String)

            Dim json As String
            Dim results As EBayResult
            Dim result As EBayItem = Nothing

            Dim url As String = "http://svcs.ebay.com/services/search/FindingService/v1" _
                & "?OPERATION-NAME=findItemsIneBayStores" _
                & "&SERVICE-VERSION=1.0.0" _
                & "&SECURITY-APPNAME=PoiaghiV-BDList-PRD-bc22b8256-664ca9d8" _
                & "&RESPONSE-DATA-FORMAT=JSON" _
                & "&REST-PAYLOAD" _
                & "&itemID=183514724171"




            Using client As New WebClient()
                json = client.DownloadString(url)
                results = (New JavaScriptSerializer()).Deserialize(Of EBayResult)(json)
            End Using

            'If results IsNot Nothing _
            '    AndAlso results.FindItemsByKeywordsResponse IsNot Nothing _
            '    AndAlso results.FindItemsByKeywordsResponse.Count > 0 _
            '    AndAlso results.FindItemsByKeywordsResponse(0).SearchResult IsNot Nothing Then

            '    If results.FindItemsByKeywordsResponse.SearchResult.Count > 0 Then
            '        result = results.FindItemsByKeywordsResponse.SearchResult(0).Item(0)
            '    End If

            'End If


            Return result

        End Function

    End Class

End Namespace
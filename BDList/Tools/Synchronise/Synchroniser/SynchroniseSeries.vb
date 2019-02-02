Imports BDList_DAO_BO.BO
Imports BDList_SERVICE


Public Class SynchroniseSeries
    Inherits SynchroniseIdBobject

    Private svcKind As New ServiceKind
    Private svcOrigin As New ServiceOrigin
    Private svcSerie As New ServiceSerie

    Protected Overrides Function GetItemsName() As String
        Return "série"
    End Function

    Protected Overrides Function AllowSynchronisePictures() As Boolean
        Return False
    End Function

    Protected Overrides Function GetLocalService() As IService
        Return svcSerie
    End Function

    Protected Overrides Function GetPhoneService() As IService
        Return New ServicePhoneSerie
    End Function

    Protected Overrides Function GetLocalPhoneParentDirPath() As String
        Return Nothing
    End Function

    Protected Overrides Function GetPhoneParentDirPath() As String
        Return Nothing
    End Function

    Public Overrides Sub LocalItemToPhoneItem(localItem As IdBObject, phoneItem As IdBObject)

        Dim localSerie As Serie = CType(localItem, Serie)
        Dim phoneSerie As PhoneSerie = CType(phoneItem, PhoneSerie)


        Dim kind As String = Nothing
        If localSerie.GetKind IsNot Nothing Then
            kind = localSerie.GetKind.GetName
        End If

        Dim origin As String = Nothing
        If localSerie.GetOrigin IsNot Nothing Then
            origin = localSerie.GetOrigin.GetName
        End If

        Dim searchName As String = ToSearchString(localSerie.GetSortName)

        phoneSerie.SetKind(kind)
        phoneSerie.SetOrigin(origin)
        phoneSerie.SetName(localSerie.GetSortName)
        phoneSerie.SetSearchName(searchName)
        phoneSerie.SetEnded(localSerie.IsEnded <> BoSerie.STATE_ONGOING)

        Dim story As String = localSerie.GetStory
        If Not String.IsNullOrEmpty(story) Then
            story = story.Replace("""", "''")
        End If

        phoneSerie.SetStory(story)

    End Sub

    Protected Overrides Sub PhoneItemToLocalItem(phoneItem As IdBObject, localItem As IdBObject)

        'Dim phoneSerie As PhoneSerie = CType(phoneItem, PhoneSerie)
        'Dim localSerie As Serie = CType(localItem, Serie)

        'Dim kindName As String = phoneSerie.GetKind
        'Dim kind As Kind = Nothing
        'If kindName IsNot Nothing Then
        '    Kind = svcKind.getByName(kindName)
        'End If

        'Dim originName As String = Nothing
        'Dim origin As Origin = Nothing
        'If originName IsNot Nothing Then
        '    origin = svcOrigin.getByName(originName)
        'End If

        'Dim sortName As String = phoneSerie.GetName
        'Dim name As String = svcSerie.ConvertSortNameToName(sortName)

        'localSerie.SetKind(kind)
        'localSerie.SetOrigin(Origin)
        'localSerie.SetName(name)
        'localSerie.SetSortName(sortName)
        'localSerie.SetEnded(phoneSerie.IsEnded)
        'localSerie.SetStory(phoneSerie.GetStory)

    End Sub

End Class


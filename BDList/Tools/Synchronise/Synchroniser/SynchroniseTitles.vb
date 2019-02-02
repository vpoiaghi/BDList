Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS


Public Class SynchroniseTitles
    Inherits SynchroniseIdBobject

    Private svcEdition As New ServiceEdition
    Private svcSerie As New ServiceSerie

    Protected Overrides Function GetItemsName() As String
        Return "titre"
    End Function

    Protected Overrides Function AllowSynchronisePictures() As Boolean
        Return False
    End Function

    Protected Overrides Function GetLocalService() As IService
        Return New ServiceTitle
    End Function

    Protected Overrides Function GetPhoneService() As IService
        Return New ServicePhoneTitle
    End Function

    Protected Overrides Function GetLocalPhoneParentDirPath() As String
        Return Nothing
    End Function

    Protected Overrides Function GetPhoneParentDirPath() As String
        Return Nothing
    End Function

    Public Overrides Sub LocalItemToPhoneItem(localItem As IdBObject, phoneItem As IdBObject)

        Dim localTitle As Title = CType(localItem, Title)
        Dim phoneTitle As PhoneTitle = CType(phoneItem, PhoneTitle)

        phoneTitle.SetIdSerie(localTitle.GetSerie.GetId)
        phoneTitle.SetName(localTitle.GetName.Replace("""", "''"))
        phoneTitle.SetOrderNumber(localTitle.GetOrderNumber)
        phoneTitle.SetOutSerie(localTitle.IsOutSerie)

        Dim story As String = localTitle.GetStory
        If String.IsNullOrEmpty(story) Then
            phoneTitle.SetStory(Nothing)
        Else
            phoneTitle.SetStory(story.Replace("""", "'"))
        End If

        Dim editionsList As List(Of IdBObject) = svcEdition.GetAllBySerie(localTitle.GetSerie)

        Dim isInPossession As Boolean = False

        For Each edition As Edition In editionsList
            If edition.GetPossessionState.GetId = PossessionStates.InPossession Then

                For Each titleOfEdition As Title In edition.GetTitles()
                    If titleOfEdition.GetId = localTitle.GetId Then
                        isInPossession = True
                        Exit For
                    End If
                Next

                If isInPossession Then Exit For

            End If
        Next

        phoneTitle.SetInPossession(isInPossession)

    End Sub

    Protected Overrides Sub PhoneItemToLocalItem(phoneItem As IdBObject, localItem As IdBObject)

        'Dim phoneTitle As PhoneTitle = CType(phoneItem, PhoneTitle)
        'Dim localTitle As Title = CType(localItem, Title)

        'Dim serie As Serie = svcSerie.GetById((phoneTitle.GetIdSerie))

        'localTitle.SetSerie(serie)
        'localTitle.SetName(phoneTitle.GetName)
        'localTitle.SetOrderNumber(phoneTitle.GetOrderNumber)
        'localTitle.SetStory(phoneTitle.GetStory)
        'localTitle.SetOutSerie(phoneTitle.IsOutSerie)

    End Sub

End Class


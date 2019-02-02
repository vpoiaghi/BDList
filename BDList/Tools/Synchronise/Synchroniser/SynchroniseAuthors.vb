Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class SynchroniseAuthors
    Inherits SynchroniseIdBobject

    Protected Overrides Function GetItemsName() As String
        Return "auteurs"
    End Function

    Protected Overrides Function AllowSynchronisePictures() As Boolean
        Return False
    End Function

    Protected Overrides Function GetLocalService() As IService
        Return New ServiceAuthor
    End Function

    Protected Overrides Function GetPhoneService() As IService
        Return New ServicePhoneAuthor
    End Function

    Protected Overrides Function GetLocalPhoneParentDirPath() As String
        Return LOCAL_PHONE_AUTHORS_FOLDER
    End Function

    Protected Overrides Function GetPhoneParentDirPath() As String
        Return PHONE_AUTHORS_FOLDER
    End Function

    Public Overrides Sub LocalItemToPhoneItem(localItem As IdBObject, phoneItem As IdBObject)

        Dim localAuthor As Author = CType(localItem, Author)
        Dim phoneAuthor As PhoneAuthor = CType(phoneItem, PhoneAuthor)

        Dim name As String = localAuthor.ToString
        Dim searchName As String = ToSearchString(name)

        phoneAuthor.SetName(name)
        phoneAuthor.SetSearchName(searchName)

    End Sub

    Protected Overrides Sub PhoneItemToLocalItem(phoneItem As IdBObject, localItem As IdBObject)

        'Dim phoneAuthor As PhoneAuthor = CType(phoneItem, PhoneAuthor)
        'Dim localAuthor As Author = CType(localItem, Author)

        'localAuthor.SetName(PhoneAuthor.GetName)

    End Sub

End Class


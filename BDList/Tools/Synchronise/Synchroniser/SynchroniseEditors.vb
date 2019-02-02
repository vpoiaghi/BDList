Imports BDList_DAO_BO.BO
Imports BDList_SERVICE


Public Class SynchroniseEditors
    Inherits SynchroniseIdBobject

    Protected Overrides Function GetItemsName() As String
        Return "éditeur"
    End Function

    Protected Overrides Function AllowSynchronisePictures() As Boolean
        Return False
    End Function

    Protected Overrides Function GetLocalService() As IService
        Return New ServiceEditor
    End Function

    Protected Overrides Function GetPhoneService() As IService
        Return New ServicePhoneEditor
    End Function

    Protected Overrides Function GetLocalPhoneParentDirPath() As String
        Return Nothing
    End Function

    Protected Overrides Function GetPhoneParentDirPath() As String
        Return Nothing
    End Function

    Public Overrides Sub LocalItemToPhoneItem(localItem As IdBObject, phoneItem As IdBObject)

        Dim localEditor As Editor = CType(localItem, Editor)
        Dim phoneEditor As PhoneEditor = CType(phoneItem, PhoneEditor)

        phoneEditor.SetName(localEditor.GetName)

    End Sub

    Protected Overrides Sub PhoneItemToLocalItem(phoneItem As IdBObject, localItem As IdBObject)

        'Dim phoneEditor As PhoneEditor = CType(phoneItem, PhoneEditor)
        'Dim localEditor As Editor = CType(localItem, Editor)

        'localEditor.SetName(phoneEditor.GetName)

    End Sub

End Class


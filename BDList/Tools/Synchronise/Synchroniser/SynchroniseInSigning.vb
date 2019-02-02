Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.Types.Sql

Public Class SynchroniseInSigning
    Inherits SynchroniseIdBobject

    Protected Overrides Function GetItemsName() As String
        Return "dédicace"
    End Function

    Protected Overrides Function AllowSynchronisePictures() As Boolean
        Return False
    End Function

    Protected Overrides Function GetLocalService() As IService
        Return New ServiceInSigning
    End Function

    Protected Overrides Function GetPhoneService() As IService
        Return New ServicePhoneInSigning
    End Function

    Protected Overrides Function GetLocalPhoneParentDirPath() As String
        Return Nothing
    End Function

    Protected Overrides Function GetPhoneParentDirPath() As String
        Return Nothing
    End Function

    Public Overrides Sub LocalItemToPhoneItem(localItem As IdBObject, phoneItem As IdBObject)

        Dim localInSigning As InSigning = CType(localItem, InSigning)
        Dim phoneInSigning As PhoneInSigning = CType(phoneItem, PhoneInSigning)

        phoneInSigning.SetIdFestival(localInSigning.GetFestival().GetId())
        phoneInSigning.SetIdAuthor(localInSigning.GetAuthor().GetId())

        Dim editor As Editor = localInSigning.GetEditor()
        If editor Is Nothing Then
            phoneInSigning.SetIdEditor(Nothing)
        Else
            phoneInSigning.SetIdEditor(editor.GetId())
        End If

        If localInSigning.GetStartTime Is Nothing Then
            phoneInSigning.SetStartHour(Nothing)
        Else
            phoneInSigning.SetStartHour(New SqlDate(localInSigning.GetStartTime))
        End If

        If localInSigning.GetEndTime Is Nothing Then
            phoneInSigning.SetEndHour(Nothing)
        Else
            phoneInSigning.SetEndHour(New SqlDate(localInSigning.GetEndTime))
        End If

        phoneInSigning.SetComments(localInSigning.GetComments)

    End Sub

    Protected Overrides Sub PhoneItemToLocalItem(phoneItem As IdBObject, localItem As IdBObject)

        Dim localInSigning As InSigning = CType(localItem, InSigning)
        Dim phoneInSigning As PhoneInSigning = CType(phoneItem, PhoneInSigning)

    End Sub

End Class


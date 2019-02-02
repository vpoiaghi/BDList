Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.Types.Sql

Public Class SynchroniseFestivals
    Inherits SynchroniseIdBobject

    Protected Overrides Function GetItemsName() As String
        Return "festival"
    End Function

    Protected Overrides Function AllowSynchronisePictures() As Boolean
        Return False
    End Function

    Protected Overrides Function GetLocalService() As IService
        Return New ServiceFestival
    End Function

    Protected Overrides Function GetPhoneService() As IService
        Return New ServicePhoneFestival
    End Function

    Protected Overrides Function GetLocalPhoneParentDirPath() As String
        Return Nothing
    End Function

    Protected Overrides Function GetPhoneParentDirPath() As String
        Return Nothing
    End Function

    Public Overrides Sub LocalItemToPhoneItem(localItem As IdBObject, phoneItem As IdBObject)

        Dim localFestival As Festival = CType(localItem, Festival)
        Dim phoneFestival As PhoneFestival = CType(phoneItem, PhoneFestival)

        phoneFestival.SetName(localFestival.GetName)

        If localFestival.GetBeginDate Is Nothing Then
            phoneFestival.SetBeginDate(Nothing)
        Else
            phoneFestival.SetBeginDate(New SqlDate(localFestival.GetBeginDate))
        End If

        If localFestival.GetEndDate Is Nothing Then
            phoneFestival.SetEndDate(Nothing)
        Else
            phoneFestival.SetEndDate(New SqlDate(localFestival.GetEndDate))
        End If

    End Sub

    Protected Overrides Sub PhoneItemToLocalItem(phoneItem As IdBObject, localItem As IdBObject)

        Dim localFestival As Festival = CType(localItem, Festival)
        Dim phoneFestival As PhoneFestival = CType(phoneItem, PhoneFestival)

        localFestival.SetName(phoneFestival.GetName)
        localFestival.SetBeginDate(phoneFestival.GetBeginDate.GetDate)
        localFestival.SetEndDate(phoneFestival.GetEndDate.GetDate)

    End Sub

End Class


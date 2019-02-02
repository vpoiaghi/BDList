Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.Types.Sql

Public Class SynchroniseFestivalReminders
    Inherits SynchroniseIdBobject

    Protected Overrides Function GetItemsName() As String
        Return "pense-bête festival"
    End Function

    Protected Overrides Function AllowSynchronisePictures() As Boolean
        Return False
    End Function

    Protected Overrides Function GetLocalService() As IService
        Return New ServiceFestivalReminder
    End Function

    Protected Overrides Function GetPhoneService() As IService
        Return New ServicePhoneFestivalReminder
    End Function

    Protected Overrides Function GetLocalPhoneParentDirPath() As String
        Return Nothing
    End Function

    Protected Overrides Function GetPhoneParentDirPath() As String
        Return Nothing
    End Function

    Public Overrides Sub LocalItemToPhoneItem(localItem As IdBObject, phoneItem As IdBObject)

        Dim localFestivalReminder As FestivalReminder = CType(localItem, FestivalReminder)
        Dim phoneFestivalReminder As PhoneFestivalReminder = CType(phoneItem, PhoneFestivalReminder)

        Dim editor As Editor = localFestivalReminder.GetEditor
        Dim idEditor As Long? = Nothing
        If editor IsNot Nothing Then
            idEditor = editor.GetId
        End If

        phoneFestivalReminder.SetIdFestival(localFestivalReminder.GetFestival.GetId)
        phoneFestivalReminder.SetIdEditor(idEditor)
        phoneFestivalReminder.SetName(localFestivalReminder.GetName)
        phoneFestivalReminder.SetKind(localFestivalReminder.GetKind)
        phoneFestivalReminder.SetComments(localFestivalReminder.GetComments)

    End Sub

    Protected Overrides Sub PhoneItemToLocalItem(phoneItem As IdBObject, localItem As IdBObject)

        Dim localFestivalReminder As FestivalReminder = CType(localItem, FestivalReminder)
        Dim phoneFestivalReminder As PhoneFestivalReminder = CType(phoneItem, PhoneFestivalReminder)


        Dim editor As Editor = Nothing
        Dim idEditor As Long? = phoneFestivalReminder.GetIdEditor
        If idEditor IsNot Nothing Then
            Dim svcEditor As ServiceEditor = New ServiceEditor
            editor = svcEditor.GetById(idEditor)
        End If

        Dim svcFestival As ServiceFestival = New ServiceFestival
        Dim festival As Festival = svcFestival.GetById(phoneFestivalReminder.GetIdFestival)

        localFestivalReminder.SetFestival(festival)
        localFestivalReminder.SetEditor(editor)
        localFestivalReminder.SetName(phoneFestivalReminder.GetName)
        localFestivalReminder.SetKind(phoneFestivalReminder.GetKind)
        localFestivalReminder.SetComments(phoneFestivalReminder.GetComments)


    End Sub

End Class


Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.Types.Sql

Public Class SynchroniseEvents
    Inherits SynchroniseIdBobject

    Protected Overrides Function GetItemsName() As String
        Return "évènement"
    End Function

    Protected Overrides Function AllowSynchronisePictures() As Boolean
        Return True
    End Function

    Protected Overrides Function GetLocalService() As IService
        Return New ServiceRecallEvent
    End Function

    Protected Overrides Function GetPhoneService() As IService
        Return New ServicePhoneEvent
    End Function

    Protected Overrides Function GetLocalPhoneParentDirPath() As String
        Return LOCAL_PHONE_EVENTS_FOLDER
    End Function

    Protected Overrides Function GetPhoneParentDirPath() As String
        Return PHONE_EVENTS_FOLDER
    End Function

    Public Overrides Sub LocalItemToPhoneItem(localItem As IdBObject, phoneItem As IdBObject)

        Dim localEvent As RecallEvent = CType(localItem, RecallEvent)
        Dim phoneEvent As PhoneEvent = CType(phoneItem, PhoneEvent)

        If localEvent.GetStartDate Is Nothing Then
            phoneEvent.SetStartDate(Nothing)
        Else
            phoneEvent.SetStartDate(New SqlDate(localEvent.GetStartDate))
        End If

        If localEvent.GetEndDate Is Nothing Then
            phoneEvent.SetEndDate(Nothing)
        Else
            phoneEvent.SetEndDate(New SqlDate(localEvent.GetEndDate))
        End If

        phoneEvent.SetName(localEvent.GetName)
        phoneEvent.SetPlace(localEvent.GetPlace)
        phoneEvent.SetComments(localEvent.GetComments)
        phoneEvent.SetState(localEvent.GetState)
        phoneEvent.SetReminderDays(localEvent.GetReminderDays)
        phoneEvent.SetPersistenceDays(localEvent.GetPersistenceDays)

    End Sub

    Protected Overrides Sub PhoneItemToLocalItem(phoneItem As IdBObject, localItem As IdBObject)

        Dim phoneEvent As PhoneEvent = CType(phoneItem, PhoneEvent)
        Dim localEvent As RecallEvent = CType(localItem, RecallEvent)

        localEvent.SetStartDate(phoneEvent.GetStartDate.GetDate)
        localEvent.SetEndDate(phoneEvent.GetEndDate.GetDate)
        localEvent.SetName(phoneEvent.GetName)
        localEvent.SetPlace(phoneEvent.GetPlace)
        localEvent.SetComments(phoneEvent.GetComments)
        localEvent.SetState(phoneEvent.GetState)
        localEvent.SetReminderDays(phoneEvent.GetReminderDays)
        localEvent.SetPersistenceDays(phoneEvent.GetPersistenceDays)

    End Sub

End Class


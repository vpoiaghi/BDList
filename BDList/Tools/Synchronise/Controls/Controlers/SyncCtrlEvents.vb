Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class SyncCtrlEvents
    Inherits SyncCtrl
    Implements ISyncCtrl

    Public Function GetLocalService() As IService Implements ISyncCtrl.GetLocalService
        Return New ServiceRecallEvent
    End Function

    Public Function GetPhoneService() As IService Implements ISyncCtrl.GetPhoneService
        Return New ServicePhoneEvent
    End Function

    Public Function GetSynchroniser() As SynchroniseIdBobject Implements ISyncCtrl.GetSynchroniser
        Return New SynchroniseEvents
    End Function

    Public Function GetCtrlResult() As SyncCtrlResult Implements ISyncCtrl.GetCtrlResult
        Return New SyncCtrlResult("Evènements")
    End Function

    Public Function Control(item As SyncCtrlItem) As Boolean Implements ISyncCtrl.Control

        ' Cast des Items
        Dim lcItem As PhoneEvent = CType(item.localPhoneItem, PhoneEvent)
        Dim phItem As PhoneEvent = CType(item.phoneItem, PhoneEvent)
        Dim result As Boolean = True

        ' Compare l'item du téléphone avec l'item local converti
        result = result And CompareDates(item, lcItem.GetStartDate(), phItem.GetStartDate(), "Date de début")
        result = result And CompareDates(item, lcItem.GetEndDate(), phItem.GetEndDate(), "Date de fin")
        result = result And CompareStrings(item, lcItem.GetName(), phItem.GetName(), "Nom")
        result = result And CompareStrings(item, lcItem.GetPlace(), phItem.GetPlace(), "Lieu")
        result = result And CompareStrings(item, lcItem.GetComments(), phItem.GetComments(), "Commentaires")
        result = result And CompareIntegers(item, lcItem.GetState(), phItem.GetState(), "Etat")
        result = result And CompareIntegers(item, lcItem.GetReminderDays(), phItem.GetReminderDays(), "Nb jours de notification avant début")
        result = result And CompareIntegers(item, lcItem.GetPersistenceDays(), phItem.GetPersistenceDays(), "Nb jours de relance")


        Return result

    End Function

End Class

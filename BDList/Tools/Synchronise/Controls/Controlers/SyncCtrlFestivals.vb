Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class SyncCtrlFestivals
    Inherits SyncCtrl
    Implements ISyncCtrl

    Public Function GetLocalService() As IService Implements ISyncCtrl.GetLocalService
        Return New ServiceFestival
    End Function

    Public Function GetPhoneService() As IService Implements ISyncCtrl.GetPhoneService
        Return New ServicePhoneFestival
    End Function

    Public Function GetSynchroniser() As SynchroniseIdBobject Implements ISyncCtrl.GetSynchroniser
        Return New SynchroniseFestivals
    End Function

    Public Function GetCtrlResult() As SyncCtrlResult Implements ISyncCtrl.GetCtrlResult
        Return New SyncCtrlResult("Festivals")
    End Function

    Public Function Control(item As SyncCtrlItem) As Boolean Implements ISyncCtrl.Control

        ' Cast des Items
        Dim lcItem As PhoneFestival = CType(item.localPhoneItem, PhoneFestival)
        Dim phItem As PhoneFestival = CType(item.phoneItem, PhoneFestival)
        Dim result As Boolean = True

        ' Compare l'item du téléphone avec l'item local converti
        result = result And CompareStrings(item, lcItem.GetName(), phItem.GetName(), "Nom")
        result = result And CompareDates(item, lcItem.GetBeginDate(), phItem.GetBeginDate(), "Date de début")
        result = result And CompareDates(item, lcItem.GetEndDate(), phItem.GetEndDate(), "Date de Fin")

        Return result

    End Function

End Class

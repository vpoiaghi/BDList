Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class SyncCtrlTitles
    Inherits SyncCtrl
    Implements ISyncCtrl

    Public Function GetLocalService() As IService Implements ISyncCtrl.GetLocalService
        Return New ServiceTitle
    End Function

    Public Function GetPhoneService() As IService Implements ISyncCtrl.GetPhoneService
        Return New ServicePhoneTitle
    End Function

    Public Function GetSynchroniser() As SynchroniseIdBobject Implements ISyncCtrl.GetSynchroniser
        Return New SynchroniseTitles
    End Function

    Public Function GetCtrlResult() As SyncCtrlResult Implements ISyncCtrl.GetCtrlResult
        Return New SyncCtrlResult("Titres")
    End Function

    Public Function Control(item As SyncCtrlItem) As Boolean Implements ISyncCtrl.Control

        ' Cast des Items
        Dim lcItem As PhoneTitle = CType(item.localPhoneItem, PhoneTitle)
        Dim phItem As PhoneTitle = CType(item.phoneItem, PhoneTitle)
        Dim result As Boolean = True

        ' Compare l'item du téléphone avec l'item local converti
        result = result And CompareIntegers(item, lcItem.GetIdSerie(), phItem.GetIdSerie(), "Id. série")
        result = result And CompareStrings(item, lcItem.GetName(), phItem.GetName(), "Nom")
        result = result And CompareIntegers(item, lcItem.GetOrderNumber(), phItem.GetOrderNumber(), "Numéro d'ordre")
        result = result And CompareStrings(item, lcItem.GetStory(), phItem.GetStory(), "résumé")
        result = result And CompareBooleans(item, lcItem.IsOutSerie(), phItem.IsOutSerie(), "Hors-série")
        result = result And CompareBooleans(item, lcItem.IsInPossession(), phItem.IsInPossession(), "En possession")

        Return result

    End Function

End Class

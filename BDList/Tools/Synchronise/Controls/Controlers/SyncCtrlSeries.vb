Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class SyncCtrlSeries
    Inherits SyncCtrl
    Implements ISyncCtrl

    Public Function GetLocalService() As IService Implements ISyncCtrl.GetLocalService
        Return New ServiceSerie
    End Function

    Public Function GetPhoneService() As IService Implements ISyncCtrl.GetPhoneService
        Return New ServicePhoneSerie
    End Function

    Public Function GetSynchroniser() As SynchroniseIdBobject Implements ISyncCtrl.GetSynchroniser
        Return New SynchroniseSeries
    End Function

    Public Function GetCtrlResult() As SyncCtrlResult Implements ISyncCtrl.GetCtrlResult
        Return New SyncCtrlResult("Séries")
    End Function

    Public Function Control(item As SyncCtrlItem) As Boolean Implements ISyncCtrl.Control

        ' Cast des Items
        Dim lcItem As PhoneSerie = CType(item.localPhoneItem, PhoneSerie)
        Dim phItem As PhoneSerie = CType(item.phoneItem, PhoneSerie)
        Dim result As Boolean = True

        ' Compare l'item du téléphone avec l'item local converti
        result = result And CompareStrings(item, lcItem.GetKind(), phItem.GetKind(), "Genre")
        result = result And CompareStrings(item, lcItem.GetOrigin(), phItem.GetOrigin(), "Origine")
        result = result And CompareStrings(item, lcItem.GetName(), phItem.GetName(), "Nom")
        result = result And CompareStrings(item, lcItem.GetSearchName(), phItem.GetSearchName(), "Nom (recherche)")
        result = result And CompareBooleans(item, lcItem.IsEnded(), phItem.IsEnded(), "Terminée")
        result = result And CompareStrings(item, lcItem.GetStory(), phItem.GetStory(), "Résumé")


        Return result

    End Function

End Class

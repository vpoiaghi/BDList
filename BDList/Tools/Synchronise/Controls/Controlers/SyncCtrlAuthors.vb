Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class SyncCtrlAuthors
    Inherits SyncCtrl
    Implements ISyncCtrl

    Public Function GetLocalService() As IService Implements ISyncCtrl.GetLocalService
        Return New ServiceAuthor
    End Function

    Public Function GetPhoneService() As IService Implements ISyncCtrl.GetPhoneService
        Return New ServicePhoneAuthor
    End Function

    Public Function GetSynchroniser() As SynchroniseIdBobject Implements ISyncCtrl.GetSynchroniser
        Return New SynchroniseAuthors
    End Function

    Public Function GetCtrlResult() As SyncCtrlResult Implements ISyncCtrl.GetCtrlResult
        Return New SyncCtrlResult("Auteurs")
    End Function

    Public Function Control(item As SyncCtrlItem) As Boolean Implements ISyncCtrl.Control

        ' Cast des Items
        Dim lcItem As PhoneAuthor = CType(item.localPhoneItem, PhoneAuthor)
        Dim phItem As PhoneAuthor = CType(item.phoneItem, PhoneAuthor)
        Dim result As Boolean = True

        ' Compare l'item du téléphone avec l'item local converti
        result = result And CompareStrings(item, lcItem.GetName(), phItem.GetName(), "Nom")
        result = result And CompareStrings(item, lcItem.GetSearchName(), phItem.GetSearchName(), "Nom (recherche)")


        Return result

    End Function

End Class

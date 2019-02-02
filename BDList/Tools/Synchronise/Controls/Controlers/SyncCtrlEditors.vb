Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class SyncCtrlEditors
    Inherits SyncCtrl
    Implements ISyncCtrl

    Public Function GetLocalService() As IService Implements ISyncCtrl.GetLocalService
        Return New ServiceEditor
    End Function

    Public Function GetPhoneService() As IService Implements ISyncCtrl.GetPhoneService
        Return New ServicePhoneEditor
    End Function

    Public Function GetSynchroniser() As SynchroniseIdBobject Implements ISyncCtrl.GetSynchroniser
        Return New SynchroniseEditors
    End Function

    Public Function GetCtrlResult() As SyncCtrlResult Implements ISyncCtrl.GetCtrlResult
        Return New SyncCtrlResult("Editeurs")
    End Function

    Public Function Control(item As SyncCtrlItem) As Boolean Implements ISyncCtrl.Control

        ' Cast des Items
        Dim lcItem As PhoneEditor = CType(item.localPhoneItem, PhoneEditor)
        Dim phItem As PhoneEditor = CType(item.phoneItem, PhoneEditor)
        Dim result As Boolean = True

        ' Compare l'item du téléphone avec l'item local converti
        result = result And CompareStrings(item, lcItem.GetName(), phItem.GetName(), "Nom")

        Return result

    End Function

End Class

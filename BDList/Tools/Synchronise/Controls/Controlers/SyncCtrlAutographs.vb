Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class SyncCtrlAutographs
    Inherits SyncCtrl
    Implements ISyncCtrl

    Public Function GetLocalService() As IService Implements ISyncCtrl.GetLocalService
        Return New ServiceAutograph
    End Function

    Public Function GetPhoneService() As IService Implements ISyncCtrl.GetPhoneService
        Return New ServicePhoneAutograph
    End Function

    Public Function GetSynchroniser() As SynchroniseIdBobject Implements ISyncCtrl.GetSynchroniser
        Return New SynchroniseAutographs
    End Function

    Public Function GetCtrlResult() As SyncCtrlResult Implements ISyncCtrl.GetCtrlResult
        Return New SyncCtrlResult("Dédicaces")
    End Function

    Public Function Control(item As SyncCtrlItem) As Boolean Implements ISyncCtrl.Control

        ' Cast des Items
        Dim lcItem As PhoneAutograph = CType(item.localPhoneItem, PhoneAutograph)
        Dim phItem As PhoneAutograph = CType(item.phoneItem, PhoneAutograph)
        Dim result As Boolean = True

        ' Compare l'item du téléphone avec l'item local converti
        result = result And CompareIntegers(item, lcItem.GetIdEdition(), phItem.GetIdEdition(), "Id. édition")
        result = result And CompareIntegers(item, lcItem.GetIdGoody(), phItem.GetIdGoody(), "Id. para-bd")
        result = result And CompareIntegers(item, lcItem.GetIdAuthor(), phItem.GetIdAuthor(), "Id. auteur")
        result = result And CompareStrings(item, lcItem.GetIdAuthors(), phItem.GetIdAuthors(), "Id. auteur(s)")
        result = result And CompareDates(item, lcItem.GetDate(), phItem.GetDate(), "Date de la dédicace")
        result = result And CompareStrings(item, lcItem.GetPlace(), phItem.GetPlace(), "Lieu de la dédicace")
        result = result And CompareStrings(item, lcItem.GetEvent(), phItem.GetEvent(), "Evènement")
        result = result And CompareStrings(item, lcItem.GetComments(), phItem.GetComments(), "Commentaires")

        Return result

    End Function

End Class

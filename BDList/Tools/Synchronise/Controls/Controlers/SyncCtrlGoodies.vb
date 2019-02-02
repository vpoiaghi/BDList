Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class SyncCtrlGoodies
    Inherits SyncCtrl
    Implements ISyncCtrl

    Public Function GetLocalService() As IService Implements ISyncCtrl.GetLocalService
        Return New ServiceGoody
    End Function

    Public Function GetPhoneService() As IService Implements ISyncCtrl.GetPhoneService
        Return New ServicePhoneGoody
    End Function

    Public Function GetSynchroniser() As SynchroniseIdBobject Implements ISyncCtrl.GetSynchroniser
        Return New SynchroniseGoodies
    End Function

    Public Function GetCtrlResult() As SyncCtrlResult Implements ISyncCtrl.GetCtrlResult
        Return New SyncCtrlResult("Para-bds")
    End Function

    Public Function Control(item As SyncCtrlItem) As Boolean Implements ISyncCtrl.Control

        ' Cast des Items
        Dim lcItem As PhoneGoody = CType(item.localPhoneItem, PhoneGoody)
        Dim phItem As PhoneGoody = CType(item.phoneItem, PhoneGoody)
        Dim result As Boolean = True

        item.Attributes.Clear()

        ' Compare l'item du téléphone avec l'item local converti
        result = result And CompareIntegers(item, lcItem.GetIdEditor(), phItem.GetIdEditor(), "Id. éditeur")
        result = result And CompareIntegers(item, lcItem.GetIdSerie(), phItem.GetIdSerie(), "Id. série")
        result = result And CompareStrings(item, lcItem.GetIdSeries(), phItem.GetIdSeries(), "Id. séries")
        result = result And CompareIntegers(item, lcItem.GetIdAuthor(), phItem.GetIdAuthor(), "Id. auteur")
        result = result And CompareStrings(item, lcItem.GetIdAuthors(), phItem.GetIdAuthors(), "Id. auteurs")
        result = result And CompareStrings(item, lcItem.GetName(), phItem.GetName(), "Nom")
        result = result And CompareStrings(item, lcItem.GetSearchName(), phItem.GetSearchName(), "Nom (recherche)")
        result = result And CompareStrings(item, lcItem.GetSerieName(), phItem.GetSerieName(), "Série")
        result = result And CompareStrings(item, lcItem.GetSerieSearchName(), phItem.GetSerieSearchName(), "Série (recherche)")
        result = result And CompareIntegers(item, lcItem.GetPossessionState(), phItem.GetPossessionState(), "Possession")
        result = result And CompareDates(item, lcItem.GetParutionDate(), phItem.GetParutionDate(), "Date de parution")
        result = result And CompareBooleans(item, lcItem.IsWithAutograph(), phItem.IsWithAutograph(), "Dédicacé")
        result = result And CompareStrings(item, lcItem.GetEditorName(), phItem.GetEditorName(), "Editeur")
        result = result And CompareStrings(item, lcItem.GetKindName(), phItem.GetKindName(), "Genre de para-bd")
        result = result And CompareIntegers(item, lcItem.GetSizeX(), phItem.GetSizeX(), "Taille (X)")
        result = result And CompareIntegers(item, lcItem.GetSizeY(), phItem.GetSizeY(), "Taille (Y)")
        result = result And CompareIntegers(item, lcItem.GetSizeZ(), phItem.GetSizeZ(), "Taille (Z)")
        result = result And CompareIntegers(item, lcItem.GetOrderNumber(), phItem.GetOrderNumber(), "Numéro d'ordre")
        result = result And CompareStrings(item, lcItem.GetCopyNumber(), phItem.GetCopyNumber(), "Numéro de l'exemplaire")
        result = result And CompareIntegers(item, lcItem.GetCopyCount(), phItem.GetCopyCount(), "Nombre d'exemplaires")
        result = result And CompareIntegers(item, lcItem.GetState(), phItem.GetState(), "Etat")

        Return result

    End Function

End Class

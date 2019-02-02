Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class SyncCtrlEditions
    Inherits SyncCtrl
    Implements ISyncCtrl

    Public Function GetLocalService() As IService Implements ISyncCtrl.GetLocalService
        Return New ServiceEdition
    End Function

    Public Function GetPhoneService() As IService Implements ISyncCtrl.GetPhoneService
        Return New ServicePhoneEdition
    End Function

    Public Function GetSynchroniser() As SynchroniseIdBobject Implements ISyncCtrl.GetSynchroniser
        Return New SynchroniseEditions
    End Function

    Public Function GetCtrlResult() As SyncCtrlResult Implements ISyncCtrl.GetCtrlResult
        Return New SyncCtrlResult("Editions")
    End Function

    Public Function Control(item As SyncCtrlItem) As Boolean Implements ISyncCtrl.Control

        ' Cast des Items
        Dim lcItem As PhoneEdition = CType(item.localPhoneItem, PhoneEdition)
        Dim phItem As PhoneEdition = CType(item.phoneItem, PhoneEdition)
        Dim result As Boolean = True

        ' Compare l'item du téléphone avec l'item local converti
        result = result And CompareIntegers(item, lcItem.GetId(), phItem.GetId(), "Id.")
        result = result And CompareIntegers(item, lcItem.GetIdEditor(), phItem.GetIdEditor(), "Id. éditeur")
        result = result And CompareIntegers(item, lcItem.GetIdSerie(), phItem.GetIdSerie(), "Id. série")
        result = result And CompareStrings(item, lcItem.GetIdSeries(), phItem.GetIdSeries(), "Id. séries")
        result = result And CompareIntegers(item, lcItem.GetIdTitle(), phItem.GetIdTitle(), "Id. titre")
        result = result And CompareStrings(item, lcItem.GetIdTitles(), phItem.GetIdTitles(), "Id. titres")
        result = result And CompareStrings(item, lcItem.GetSerieName(), phItem.GetSerieName(), "Série")
        result = result And CompareStrings(item, lcItem.GetSerieSearchName(), phItem.GetSerieSearchName(), "Série (recherche)")
        result = result And CompareIntegers(item, lcItem.GetOrderNumber(), phItem.GetOrderNumber(), "Numéro d'ordre")
        result = result And CompareStrings(item, lcItem.GetCollection(), phItem.GetCollection(), "Collection")
        result = result And CompareIntegers(item, lcItem.GetState(), phItem.GetState(), "Etat")
        result = result And CompareIntegers(item, lcItem.GetPossessionState(), phItem.GetPossessionState(), "Possession")
        result = result And CompareStrings(item, lcItem.GetEditionNumber(), phItem.GetEditionNumber(), "Numéro inscrit sur l'édition")
        result = result And CompareStrings(item, lcItem.GetIsbn(), phItem.GetIsbn(), "ISBN")
        result = result And CompareBooleans(item, lcItem.IsIntegral(), phItem.IsIntegral(), "Intégrale")
        result = result And CompareBooleans(item, lcItem.IsMiscellany(), phItem.IsMiscellany(), "Recueil")
        result = result And CompareStrings(item, lcItem.GetName(), phItem.GetName(), "Nom")
        result = result And CompareStrings(item, lcItem.GetSearchName(), phItem.GetSearchName(), "Nom (recherche)")
        result = result And CompareDates(item, lcItem.GetParutionDate(), phItem.GetParutionDate(), "Date de parution")
        result = result And CompareIntegers(item, lcItem.GetVersionNumber(), phItem.GetVersionNumber(), "Numéro de version")
        result = result And CompareStrings(item, lcItem.GetSpecialEdition(), phItem.GetSpecialEdition(), "Edition spéciale")
        result = result And CompareIntegers(item, lcItem.GetBoardsCount(), phItem.GetBoardsCount(), "Nombre de planches")
        result = result And CompareIntegers(item, lcItem.GetPrintingMax(), phItem.GetPrintingMax(), "Nb exemplaires parus")
        result = result And CompareStrings(item, lcItem.GetBoardsColor(), phItem.GetBoardsColor(), "Couleurs des pages")
        result = result And CompareStrings(item, lcItem.GetTextAuthorName(), phItem.GetTextAuthorName(), "Scénariste(s)")
        result = result And CompareStrings(item, lcItem.GetDrawAuthorName(), phItem.GetDrawAuthorName(), "Dessinateur(s)")
        result = result And CompareStrings(item, lcItem.GetColorAuthorName(), phItem.GetColorAuthorName(), "Coloriste(s)")
        result = result And CompareBooleans(item, lcItem.IsWithAutograph(), phItem.IsWithAutograph(), "Dédicacé")
        result = result And CompareBooleans(item, lcItem.GetHasAnotherEditions(), phItem.GetHasAnotherEditions(), "Autre édition")
        result = result And CompareStrings(item, lcItem.GetEditorName(), phItem.GetEditorName(), "Editeur")

        Return result

    End Function

End Class

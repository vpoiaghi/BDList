Imports System.Drawing.Drawing2D
Imports System.Text
Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN


Public MustInherit Class SynchroniseIdBobject

    Private Shared MAJ_CHARS As String() = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", " ", "!", """", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ":", ";", "<", "=", ">", "?", "@", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "[", "\", "]", "^", "_", "`", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "{", "|", "}", "~", "", "€", "", "‚", "ƒ", "„", "…", "†", "‡", "ˆ", "‰", "S", "‹", "OE", "", "Z", "", "", "‘", "’", """", """", "•", "–", "—", "˜", "™", "š", "›", "OE", "", "Z", "Y", " ", "¡", "C", "£", "¤", "Y", "¦", "§", "¨", "©", "A", "«", "¬", "­", "®", "¯", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "»", "¼", "½", "¾", "¿", "A", "A", "A", "A", "A", "A", "AE", "C", "E", "E", "E", "E", "I", "I", "I", "I", "D", "N", "O", "O", "O", "O", "O", "×", "O", "U", "U", "U", "U", "Y", "Þ", "ß", "A", "A", "A", "A", "A", "A", "AE", "C", "E", "E", "E", "E", "I", "I", "I", "I", "O", "N", "O", "O", "O", "O", "O", "÷", "ø", "U", "U", "U", "U", "Y", "þ", "Y"}

    Protected MustOverride Function GetItemsName() As String
    Protected MustOverride Function AllowSynchronisePictures() As Boolean
    Protected MustOverride Function GetLocalService() As IService
    Protected MustOverride Function GetPhoneService() As IService
    Protected MustOverride Function GetLocalPhoneParentDirPath() As String
    Protected MustOverride Function GetPhoneParentDirPath() As String
    Public MustOverride Sub LocalItemToPhoneItem(localItem As IdBObject, phoneItem As IdBObject)
    Protected MustOverride Sub PhoneItemToLocalItem(phoneItem As IdBObject, localItem As IdBObject)

    Private m_lastSyncDate As DateTime

    Public Sub New()
    End Sub

    Public Sub DeleteAll(phoneExplorer As PhoneExplorer)
        GetPhoneService.DeleteAll()
    End Sub

    Public Overridable Function Synchronise(phoneExplorer As PhoneExplorer, forceCleanPhone As Boolean) As SynchroniseResults

        Dim localService As IService = GetLocalService()
        Dim phoneService As IService = GetPhoneService()

        m_lastSyncDate = GetLastSyncDate()

        phoneService.CleanCash()

        Dim localItemsList As List(Of IdBObject)
        Dim phoneItemsList As List(Of IdBObject)

        If forceCleanPhone Then
            localItemsList = localService.GetAllSortedById()
            phoneItemsList = New List(Of IdBObject)
        Else
            localItemsList = localService.GetChanged(m_lastSyncDate)
            phoneItemsList = phoneService.GetChanged(m_lastSyncDate)
        End If

        Return Synchronise(localItemsList, phoneItemsList, phoneExplorer)

    End Function

    Public Function Synchronise(localItemsList As List(Of IdBObject), phoneItemsList As List(Of IdBObject), phoneExplorer As PhoneExplorer) As SyncIdBoResults

        Dim syncResults As New SyncIdBoResults

        Dim localService As IService = GetLocalService()
        Dim phoneService As IService = GetPhoneService()

        CompareChangedLists(localItemsList, phoneItemsList)

        syncResults.AddResults(SynchroniseData(localItemsList, phoneItemsList))
        syncResults.AddResults(SynchronisePictures(localItemsList, phoneItemsList, phoneExplorer))
        syncResults.AddResults(SynchroniseDeletedItems(localService, phoneService))

        Return syncResults

    End Function

    Protected Function GetLastSyncDate() As Date

        Dim svcPhoneParameters As New ServicePhoneParameters
        Dim phoneParameters As PhoneParameters = svcPhoneParameters.GetParameters
        Return phoneParameters.GetDataUpdateDate.GetDate

    End Function

    ' Parcours les deux listes à la recherche d'id communs. Si il en existe seule la liste contenant l'idbobject pour cet id avec
    ' le plus grand tsp gardera son idbobject.
    Private Sub CompareChangedLists(ByRef itemsList1 As List(Of IdBObject), ByRef itemsList2 As List(Of IdBObject))

        Dim id1 As Long?
        Dim id2 As Long?

        Dim tsp1 As Date
        Dim tsp2 As Date

        Dim index1 As Integer = 0
        Dim index2 As Integer = 0


        While (index1 < itemsList1.Count) AndAlso (index2 < itemsList2.Count)

            id1 = itemsList1(index1).GetId
            id2 = itemsList2(index2).GetId

            If id1 = id2 Then

                tsp1 = itemsList1(index1).GetModifiedDateTime
                tsp2 = itemsList2(index2).GetModifiedDateTime

                If tsp1 > tsp2 Then
                    itemsList2.RemoveAt(index2)
                    index1 += 1
                Else
                    itemsList1.RemoveAt(index1)
                    index2 += 1
                End If

            ElseIf id1 > id2 Then
                index2 += 1

            Else
                index1 += 1

            End If

        End While

    End Sub

    Private Function SynchroniseData(ByRef changedLocalItemsList As List(Of IdBObject), ByRef changedPhoneItemsList As List(Of IdBObject)) As SynchroniseResults

        Dim syncResults As New SyncIdBoResults

        ' Données locales
        Dim localItemsList As New List(Of IdBObject)
        Dim localItem As IdBObject

        ' Données du téléphone
        Dim phoneItemsList As New List(Of IdBObject)
        Dim phoneItem As IdBObject

        For Each localItem In changedLocalItemsList
            phoneItem = DoLocalItemToPhoneItem(localItem)
            If phoneItem IsNot Nothing Then
                phoneItemsList.Add(phoneItem)
                syncResults.AddPhoneUpdatedItem(phoneItem.GetType, phoneItem)
            End If
        Next

        For Each phoneItem In changedPhoneItemsList
            localItem = DoPhoneItemToLocalItem(phoneItem)
            If localItem IsNot Nothing Then
                localItemsList.Add(localItem)
                syncResults.AddLocalUpdatedItem(localItem.GetType, localItem)
            End If
        Next

        If localItemsList.Count > 0 Then
            GetLocalService().InsertOrUpdateRange(localItemsList)
        End If

        If phoneItemsList.Count > 0 Then
            GetPhoneService.InsertOrUpdateRange(phoneItemsList)
        End If

        Return syncResults

    End Function

    Private Function SynchronisePictures(ByRef changedLocalItemsList As List(Of IdBObject), ByRef changedPhoneItemsList As List(Of IdBObject), phoneExplorer As PhoneExplorer) As SynchroniseResults

        Dim syncResults As New SyncIdBoResults

        If AllowSynchronisePictures() AndAlso changedLocalItemsList.Count > 0 Then

            ' Données locales
            Dim localPhoneParentDirPath As String = GetLocalPhoneParentDirPath()
            Dim localPhoneParentDirectory As IDirectory = GetEmptyLocalPhoneParentFolder(localPhoneParentDirPath)
            Dim localFile As IFile

            ' Données du téléphone
            Dim phoneParentFolder As IDirectory = Factory.GetDirectory(GetPhoneParentDirPath())
            Dim phoneFilesList As List(Of IFile) = phoneParentFolder.GetFiles
            Dim phoneFile As IFile

            Dim isThereFilesToCopyToPhone As Boolean = False

            phoneExplorer.BeginTransaction()

            For Each localItem As IdBObject In changedLocalItemsList

                localFile = GetLocalService.GetFile(localItem)
                phoneFile = GetPhoneService.GetFile(localItem)

                If Not localFile.IsExists Then
                    If phoneFilesList.Exists(Function(p) p.GetFullName = phoneFile.GetFullName) Then
                        ' Le fichier n'existe en local, mais existe sur le téléphone.
                        ' ==> Suppression du fichier du téléphone.
                        syncResults.AddAction(New SynchroniseAction(SynchroniseAction.ActionTypes.RemoveFile, phoneFile.GetFullName))
                        phoneFile.Remove()
                    End If

                ElseIf localFile.GetLastWriteTime > m_lastSyncDate Then
                    ' Le fichier existe en local et a été modifié après la dernière synchro.
                    ' ==> Suprresiion du fichier sur le téléphone si il existe.
                    ' ==> Copie du fichier local vers le téléphone.
                    syncResults.AddAction(New SynchroniseAction(SynchroniseAction.ActionTypes.CreateOrUpdateFile, phoneFile.GetFullName))
                    If phoneFile.IsExists Then
                        phoneFile.Remove()
                    End If
                    BuildResizedLocalFile(localFile.GetFullName, Path.Combine(localPhoneParentDirPath, phoneFile.GetName))
                    isThereFilesToCopyToPhone = True

                ElseIf Not phoneFilesList.Exists(Function(p) p.GetFullName = phoneFile.GetFullName) Then
                    ' Le fichier existe en local et n'existe pas sur le téléphone.
                    ' ==> Copie du fichier local vers le téléphone.
                    syncResults.AddAction(New SynchroniseAction(SynchroniseAction.ActionTypes.CreateOrUpdateFile, phoneFile.GetFullName))
                    BuildResizedLocalFile(localFile.GetFullName, Path.Combine(localPhoneParentDirPath, phoneFile.GetName))
                    isThereFilesToCopyToPhone = True

                End If

            Next

            If isThereFilesToCopyToPhone Then
                ' Copie des images depuis le répertoire local temporaire vers le téléphone
                phoneExplorer.SendDirectory(localPhoneParentDirectory, phoneParentFolder)
            End If

            phoneExplorer.PlayTransaction()

        End If

        Return syncResults

    End Function

    ' Si le dossier existe, il est vidé avant d'être retourné.
    Private Function GetEmptyLocalPhoneParentFolder(path As String) As IDirectory

        Dim localPhoneEventsFolder As IDirectory = Factory.GetDirectory(path)

        If localPhoneEventsFolder.IsExists Then
            localPhoneEventsFolder.Remove()
        End If

        localPhoneEventsFolder.Create()

        Return localPhoneEventsFolder

    End Function

    Private Function GetPhoneFilesList(parentFolder As IDirectory, phoneExplorer As PhoneExplorer) As List(Of IFile)

        Dim phoneFilesList As List(Of IFile)

        If Not parentFolder.IsExists() Then
            parentFolder.Create()
            phoneFilesList = New List(Of IFile)
        Else
            phoneFilesList = parentFolder.GetFiles()
        End If

        Return phoneFilesList

    End Function


    Private Sub BuildResizedLocalFile(localFilePath As String, newLocalFilePath As String)

        Dim img As Image = ImageUtils.LoadImage(localFilePath)

        Dim newWidth As Integer = 360 '720
        Dim newHeight As Integer = 640 '1280

        Dim originalWidth As Integer = img.Width
        Dim originalHeight As Integer = img.Height

        Dim percentWidth As Single = CSng(newWidth) / CSng(originalWidth)
        Dim percentHeight As Single = CSng(newHeight) / CSng(originalHeight)

        Dim percent As Single = If(percentHeight < percentWidth, percentHeight, percentWidth)

        newWidth = CInt(originalWidth * percent)
        newHeight = CInt(originalHeight * percent)

        Dim newImg As Image = New Bitmap(newWidth, newHeight)

        Using gph As Graphics = Graphics.FromImage(newImg)
            gph.InterpolationMode = InterpolationMode.HighQualityBicubic
            gph.DrawImage(img, 0, 0, newWidth, newHeight)
            gph.Dispose()
        End Using

        newImg.Save(newLocalFilePath)

        img.Dispose()
        img = Nothing

        newImg.Dispose()
        img = Nothing

    End Sub

    Protected Function DoLocalItemToPhoneItem(localItem As IdBObject) As IdBObject

        Dim phoneItem As IdBObject = Nothing
        Dim id As Long? = localItem.GetId

        phoneItem = GetPhoneService.GetById(id)

        If phoneItem Is Nothing Then
            phoneItem = GetPhoneService.GetNew(id)
        End If

        LocalItemToPhoneItem(localItem, phoneItem)

        Return phoneItem

    End Function

    Protected Function DoPhoneItemToLocalItem(phoneItem As IdBObject) As IdBObject

        Dim localItem As IdBObject = Nothing
        Dim id As Long? = phoneItem.GetId

        localItem = GetLocalService.GetById(id)

        ' ACTUELLEMENT IL N'EST PAS PREVU DE CREE DES ITEMS DEPUIS LE TELEPHONE
        ' SEULEMENT DE LES MODIFIER.
        ' AUSSI, UN ITEM MODIFIER PAR LE TELEPHONE EXISTE FORCEMENT EN LOCAL
        ' SAUF SI IL A ETE SUPPRIME ENTRE TEMPS.
        ' C'EST POURQUOI LA SYNCHRO TELEPHONE VERS LOCAL N'EST AUTORISEE QUE
        ' SI L'ITEM LOCAL EXISTE (POUR LE MOMENT).

        'If localItem Is Nothing Then
        '    localItem = GetLocalService.GetNew(id)
        'End If

        'PhoneItemToLocalItem(phoneItem, localItem)

        'Return localItem


        If localItem IsNot Nothing Then
            PhoneItemToLocalItem(phoneItem, localItem)
        End If

        Return localItem

    End Function

    Private Function SynchroniseDeletedItems(localService As IService, phoneService As IService) As SynchroniseResults

        Dim syncResults As New SyncIdBoResults

        Dim localCount As Integer = localService.GetCount
        Dim phoneCount As Integer = phoneService.GetCount

        If localCount <> phoneCount Then

            Dim phoneItemsToDeleteList As New List(Of IdBObject)

            Dim localItems As List(Of IdBObject) = localService.GetAll()
            Dim phoneItems As List(Of IdBObject) = phoneService.GetAll()

            Dim localItemIndex As Integer = 0

            Dim phoneItem As IdBObject
            Dim phoneItemIndex As Integer = 0
            Dim phoneItemId As Long?

            Dim found As Boolean

            While phoneItemIndex < phoneCount

                found = False
                localItemIndex = 0
                phoneItem = phoneItems(phoneItemIndex)
                phoneItemId = phoneItem.GetId

                While (localItemIndex < localCount) AndAlso (Not found)

                    If localItems(localItemIndex).GetId = phoneItemId Then
                        found = True
                    End If

                    localItemIndex += 1
                End While

                If Not found Then
                    phoneItemsToDeleteList.Add(phoneItem)
                    syncResults.AddPhoneRemovedItem(phoneItem.GetType, phoneItem)
                End If

                phoneItemIndex += 1

            End While

            phoneService.Delete(phoneItemsToDeleteList)

        End If

        Return syncResults

    End Function

    Protected Function ToSearchString(value As String) As String

        Dim result As String = Nothing

        If value IsNot Nothing Then
            Dim sb As New StringBuilder

            For Each c As Char In value.ToCharArray
                sb.Append(MAJ_CHARS(Asc(c)))
            Next

            result = sb.ToString
        End If

        Return result

    End Function
End Class


Imports System.Text
Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO

Public Class SyncControler

    Public Event CtrlProgressEvent(stepIndex As Integer, stepsCount As Integer, text As String)
    Public Event CtrlEndedEvent(syncDuration As TimeSpan)

    Private ctrlDate As Date? = Nothing

    Public Sub New()

    End Sub

    Public Function StartControl() As List(Of SyncCtrlResult)

        Dim ctrlResults As New List(Of SyncCtrlResult)

        Dim phoneExplorer As PhoneExplorer
        Dim dbFile As IFile = Factory.GetFile(Constantes.SQLITE_DATABASE_LOCAL_FILE_PATH)
        Dim dbPhoneFile As IFile = Factory.GetFile(SQLITE_DATABASE_PHONE_FILE_PATH)
        Dim dbLocalFile As IFile = Factory.GetFile(SQLITE_DATABASE_LOCAL_FILE_PATH)

        'Try
        ctrlDate = Now

        phoneExplorer = PhoneExplorer.GetInstance

        If phoneExplorer.Connect Then

            ' Copie la base de données du téléphone en local
            phoneExplorer.PullFile(dbPhoneFile, dbLocalFile)


            Dim controlersList As New List(Of SyncCtrl)
            controlersList.Add(New SyncCtrlEvents)
            controlersList.Add(New SyncCtrlEditors)
            controlersList.Add(New SyncCtrlSeries)
            controlersList.Add(New SyncCtrlTitles)
            controlersList.Add(New SyncCtrlEditions)
            controlersList.Add(New SyncCtrlGoodies)
            controlersList.Add(New SyncCtrlAuthors)
            controlersList.Add(New SyncCtrlAutographs)
            controlersList.Add(New SyncCtrlFestivals)

            Dim stepIndex As Integer = 0
            Dim stepCount As Integer = controlersList.Count - 1

            For Each c As SyncCtrl In controlersList

                ctrlResults.Add(StartControl(c))

                RaiseEvent CtrlProgressEvent(stepIndex, stepCount, c.GetType.Name)
                stepIndex += 1

            Next

        End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

        Dim endCtrlDate As Date = Now
        Dim ctrlDuration As TimeSpan = (endCtrlDate - ctrlDate)

        RaiseEvent CtrlEndedEvent(ctrlDuration)

        Return ctrlResults

    End Function

    Private Function StartControl(SyncCtrl As ISyncCtrl) As SyncCtrlResult

        Dim synchroniser As SynchroniseIdBobject = SyncCtrl.GetSynchroniser
        Dim ctrlResult As SyncCtrlResult = SyncCtrl.GetCtrlResult()

        Dim phoneService As IService = SyncCtrl.GetPhoneService()
        Dim phoneItemsList As List(Of IdBObject) = phoneService.GetAllSortedById
        Dim phoneItemsIndex As Integer = 0
        Dim phoneItem As IdBObject = GetItem(phoneItemsList, phoneItemsIndex)

        Dim localService As IService = SyncCtrl.GetLocalService()
        Dim localItemsList As List(Of IdBObject) = localService.GetAllSortedById
        Dim localItemsIndex As Integer = 0
        Dim localItem As IdBObject = GetItem(localItemsList, localItemsIndex)
        Dim localPhoneItem As IdBObject = LocalItemToPhoneItemFormat(localItem, phoneService, synchroniser)

        Dim item As SyncCtrlItem

        While (phoneItem IsNot Nothing) AndAlso (localPhoneItem IsNot Nothing)

            If phoneItem.GetId = localPhoneItem.GetId Then

                item = New SyncCtrlItem(phoneItem, localPhoneItem, localItem)

                If SyncCtrl.Control(item) Then
                    ctrlResult.AddSame(item)
                Else
                    ctrlResult.AddDifferent(item)
                End If

                phoneItemsIndex += 1
                phoneItem = GetItem(phoneItemsList, phoneItemsIndex)

                localItemsIndex += 1
                localItem = GetItem(localItemsList, localItemsIndex)
                localPhoneItem = LocalItemToPhoneItemFormat(localItem, phoneService, synchroniser)

            ElseIf phoneItem.GetId < localPhoneItem.GetId Then
                item = New SyncCtrlItem(phoneItem, Nothing, Nothing)
                ctrlResult.AddMissingOnLocal(item)

                phoneItemsIndex += 1
                phoneItem = GetItem(phoneItemsList, phoneItemsIndex)

            Else 'phoneItem.GetId > localItem.GetId
                item = New SyncCtrlItem(Nothing, localPhoneItem, localItem)
                ctrlResult.AddMissingOnPhone(item)

                localItemsIndex += 1
                localItem = GetItem(localItemsList, localItemsIndex)
                localPhoneItem = LocalItemToPhoneItemFormat(localItem, phoneService, synchroniser)

            End If

        End While

        While (localPhoneItem IsNot Nothing)
            item = New SyncCtrlItem(Nothing, localPhoneItem, localItem)
            ctrlResult.AddMissingOnPhone(item)
            localItemsIndex += 1
            localItem = GetItem(localItemsList, localItemsIndex)
            localPhoneItem = LocalItemToPhoneItemFormat(localItem, phoneService, synchroniser)
        End While

        While (phoneItem IsNot Nothing)
            item = New SyncCtrlItem(phoneItem, Nothing, Nothing)
            ctrlResult.AddMissingOnLocal(item)
            phoneItemsIndex += 1
            phoneItem = GetItem(phoneItemsList, phoneItemsIndex)
        End While

        Return ctrlResult

    End Function

    ' Converti un item au format "local" en item au format "téléphone"
    Private Function LocalItemToPhoneItemFormat(ByRef localItem As IdBObject, ByRef phoneService As IService, ByRef synchroniser As SynchroniseIdBobject) As IdBObject

        Dim localPhoneFormattedItem As IdBObject = Nothing

        If localItem IsNot Nothing Then

            localPhoneFormattedItem = phoneService.GetNew(localItem.GetId)
            synchroniser.LocalItemToPhoneItem(localItem, localPhoneFormattedItem)
            End If

            Return localPhoneFormattedItem

    End Function

    Private Function GetItem(itemsList As List(Of IdBObject), itemIndex As Integer) As IdBObject

        Dim result As IdBObject = Nothing

        If (itemIndex >= 0 AndAlso itemIndex < itemsList.Count) Then
            result = itemsList(itemIndex)
        End If

        Return result

    End Function

End Class

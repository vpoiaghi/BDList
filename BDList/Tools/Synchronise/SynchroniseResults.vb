Imports BDList_TOOLS

Public MustInherit Class SynchroniseResults

    Private m_phoneUpdatedItems As Hashtable(Of Type, ICollection(Of Object))
    Private m_localUpdatedItems As Hashtable(Of Type, ICollection(Of Object))
    Private m_phoneRemovedItems As Hashtable(Of Type, ICollection(Of Object))
    Private m_actions As List(Of SynchroniseAction)

    Public Sub New()

        m_phoneUpdatedItems = New Hashtable(Of Type, ICollection(Of Object))
        m_localUpdatedItems = New Hashtable(Of Type, ICollection(Of Object))
        m_phoneRemovedItems = New Hashtable(Of Type, ICollection(Of Object))

        m_actions = New List(Of SynchroniseAction)

    End Sub

    Public MustOverride Function ItemToString(item As Object) As String

    Public Sub AddAction(action As SynchroniseAction)
        m_actions.Add(action)
    End Sub

    Public Function GetActions() As List(Of SynchroniseAction)
        Return m_actions
    End Function

    Public Sub AddLocalUpdatedItem(itemType As Type, item As Object)

        Dim items As New List(Of Object)
        items.Add(item)

        AddUpdatedItems(m_localUpdatedItems, itemType, items)

    End Sub

    Public Sub AddPhoneUpdatedItem(itemType As Type, item As Object)

        Dim items As New List(Of Object)
        items.Add(item)

        AddUpdatedItems(m_phoneUpdatedItems, itemType, items)

    End Sub

    Public Sub AddPhoneRemovedItem(itemType As Type, item As Object)

        Dim items As New List(Of Object)
        items.Add(item)

        AddUpdatedItems(m_phoneRemovedItems, itemType, items)

    End Sub

    Public Sub AddLocalUpdatedItems(itemType As Type, items As ICollection(Of Object))
        AddUpdatedItems(m_localUpdatedItems, itemType, items)
    End Sub

    Public Sub AddPhoneUpdatedItem(itemType As Type, items As ICollection(Of Object))
        AddUpdatedItems(m_phoneUpdatedItems, itemType, items)
    End Sub

    Public Sub AddPhoneRemovedItem(itemType As Type, items As ICollection(Of Object))
        AddUpdatedItems(m_phoneRemovedItems, itemType, items)
    End Sub

    Private Sub AddUpdatedItems(itemsMap As Hashtable(Of Type, ICollection(Of Object)), itemType As Type, items As ICollection(Of Object))

        Dim lst As List(Of Object) = itemsMap.Item(itemType)

        If lst Is Nothing Then
            lst = items
            itemsMap.Add(itemType, items)
        Else
            lst.AddRange(items)
        End If

    End Sub

    Public Function GetLocalInfos() As List(Of String)
        Return GetInfos(m_localUpdatedItems, "mis à jour", "en local")
    End Function

    Public Function GetPhoneInfos() As List(Of String)

        Dim infosList As New List(Of String)
        infosList.AddRange(GetInfos(m_phoneUpdatedItems, "mis à jour", "sur le téléphone"))
        infosList.AddRange(GetInfos(m_phoneRemovedItems, "supprimé", "sur le téléphone"))

        Return infosList

    End Function

    Private Function GetInfos(itemsMap As Hashtable(Of Type, ICollection(Of Object)), updateAction As String, updatedEnv As String) As List(Of String)

        Dim infosList As New List(Of String)
        Dim items As ICollection(Of Object)

        For Each itemType As Type In itemsMap.Keys

            items = itemsMap.Item(itemType)

            infosList.Add(items.Count & " " & itemType.Name & " " & updateAction & " " & updatedEnv)

            For Each item As Object In items
                infosList.Add(vbTab & ItemToString(item))
            Next

            infosList.Add("")

        Next

        Return infosList

    End Function

    Public Sub AddResults(synchroniseResults As SynchroniseResults)

        m_actions.AddRange(synchroniseResults.GetActions)
        AddUpdatedItems(synchroniseResults.GetLocalUpdatedItems, m_localUpdatedItems)
        AddUpdatedItems(synchroniseResults.GetPhoneUpdatedItems, m_phoneUpdatedItems)
        AddUpdatedItems(synchroniseResults.GetPhoneRemovedItems, m_phoneRemovedItems)

    End Sub

    Private Sub AddUpdatedItems(otherItemsMap As Hashtable(Of Type, ICollection(Of Object)), myItemsMap As Hashtable(Of Type, ICollection(Of Object)))

        Dim myItemsList As ICollection(Of Object)
        Dim otherItemsList As ICollection(Of Object)

        For Each itemType As Type In otherItemsMap.Keys

            myItemsList = myItemsMap.Item(itemType)
            otherItemsList = otherItemsMap.Item(itemType)

            If myItemsList Is Nothing Then
                myItemsList = New List(Of Object)
                myItemsMap.Add(itemType, myItemsList)
            End If

            For Each item As Object In otherItemsList
                myItemsList.Add(item)
            Next

        Next

    End Sub

    Protected Function GetLocalUpdatedItems() As Hashtable(Of Type, ICollection(Of Object))
        Return m_localUpdatedItems
    End Function

    Public Function GetPhoneUpdatedItems() As Hashtable(Of Type, ICollection(Of Object))
        Return m_phoneUpdatedItems
    End Function

    Public Function GetPhoneRemovedItems() As Hashtable(Of Type, ICollection(Of Object))
        Return m_phoneRemovedItems
    End Function

    Public Function GetLocalDataUpdatesCount() As Integer
        Return GetItemsUpdatedCount(m_localUpdatedItems)
    End Function

    Public Function GetPhoneDataUpdatesCount() As Integer
        Return GetItemsUpdatedCount(m_phoneUpdatedItems)
    End Function

    Public Function GetPhoneDataRemovedCount() As Integer
        Return GetItemsUpdatedCount(m_phoneRemovedItems)
    End Function

    Private Function GetItemsUpdatedCount(itemsMap As Hashtable(Of Type, ICollection(Of Object))) As Integer

        Dim c As Integer = 0
        Dim lst As ICollection(Of Object)

        For Each itemType As Type In itemsMap.Keys

            lst = itemsMap.Item(itemType)

            If lst IsNot Nothing Then
                c += lst.Count
            End If

        Next

        Return c

    End Function

End Class

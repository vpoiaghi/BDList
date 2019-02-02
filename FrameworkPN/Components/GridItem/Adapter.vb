Public MustInherit Class Adapter(Of ItemType As Class)
    Implements IAdapter

    Private m_items As List(Of ItemType)
    Private m_selectedItem As ItemType = Nothing

    Protected MustOverride Function InitItem(item As ItemType) As GridItem

    Public Sub New(items As List(Of ItemType))
        m_items = Filter(items)
    End Sub

    Protected Overridable Function InitItem(item As ItemType, gridItem As GridItem) As GridItem

        gridItem.SetValue(item)
        gridItem.SetSelected(item Is m_selectedItem)

        Return gridItem

    End Function

    Protected Overridable Function Filter(idBObjects As List(Of ItemType)) As List(Of ItemType)
        Return idBObjects
    End Function

    Friend Function BuildNewListViewItem(position As Integer) As GridItem Implements IAdapter.BuildNewListViewItem

        Return InitItem(m_items(position))

    End Function

    Friend Function InitListViewItem(gridItem As GridItem, position As Integer) As GridItem Implements IAdapter.InitListViewItem

        Return InitItem(m_items(position), gridItem)

    End Function

    Public Function GetItemsCount() As Integer Implements IAdapter.GetItemsCount
        Return m_items.Count
    End Function

    Protected Sub Sort()

        If (m_items IsNot Nothing) AndAlso (m_items.Count > 0) Then

            Dim itemsArray() As ItemType = m_items.ToArray

            QuickSort(itemsArray, 0, UBound(itemsArray))

            m_items.Clear()
            m_items.AddRange(itemsArray)

        End If

    End Sub

    Private Sub QuickSort(ByRef itemsArray() As ItemType, ByVal left As Integer, ByVal right As Integer)

        Dim index As Integer = partitionner(itemsArray, left, right)

        If left < index - 1 Then
            QuickSort(itemsArray, left, index - 1)
        End If

        If (index < right) Then
            QuickSort(itemsArray, index, right)
        End If

    End Sub

    Private Function partitionner(ByRef itemsArray() As ItemType, ByVal left As Integer, ByVal right As Integer) As Integer

        Dim i As Integer = left
        Dim j As Integer = right
        Dim pivot As ItemType = itemsArray((left + right) \ 2)

        While i <= j

            While Compare(itemsArray(i), pivot) = -1
                i += 1
            End While

            While Compare(itemsArray(j), pivot) = 1
                j -= 1
            End While

            If i <= j Then
                SwitchArrayItems(itemsArray, i, j)
                i += 1
                j -= 1
            End If

        End While

        Return i

    End Function

    Private Sub SwitchArrayItems(ByRef itemsArray() As ItemType, ByVal index1 As Integer, ByVal index2 As Integer)

        If (index1 <> index2) Then

            Dim tmp As ItemType = itemsArray(index1)
            itemsArray(index1) = itemsArray(index2)
            itemsArray(index2) = tmp

        End If

    End Sub

    Protected Overridable Function Compare(obj1 As ItemType, obj2 As ItemType) As Integer
        Throw New NotImplementedException("La méthode Compare de la classe Adapter doit être redéfinie.")
    End Function

End Class

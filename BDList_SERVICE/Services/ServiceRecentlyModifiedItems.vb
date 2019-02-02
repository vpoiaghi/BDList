Imports BDList_DAO_BO.BO

Public Class ServiceRecentlyModifiedItems

    Public Function GetLast(count As Integer) As List(Of IdBObject)

        Dim svcEditions As New ServiceEdition
        Dim svcGoodies As New ServiceGoody

        Dim items As List(Of IdBObject) = svcEditions.GetLastModified()
        items.AddRange(svcGoodies.GetLastModified())
        items = Sort(items)
        items.RemoveRange(count, items.Count - count)

        Return items

    End Function


    Private Function Sort(items As List(Of IdBObject)) As List(Of IdBObject)

        If (items IsNot Nothing) AndAlso (items.Count > 0) Then

            Dim itemsArray() As IdBObject = items.ToArray

            QuickSort(itemsArray, 0, UBound(itemsArray))

            items.Clear()
            items.AddRange(itemsArray)

        Else
            items = New List(Of IdBObject)

        End If

        Return items

    End Function

    Private Sub QuickSort(ByRef itemsArray() As IdBObject, ByVal left As Integer, ByVal right As Integer)

        Dim index As Integer = partitionner(itemsArray, left, right)

        If left < index - 1 Then
            QuickSort(itemsArray, left, index - 1)
        End If

        If (index < right) Then
            QuickSort(itemsArray, index, right)
        End If

    End Sub

    Private Function partitionner(ByRef itemsArray() As IdBObject, ByVal left As Integer, ByVal right As Integer) As Integer

        Dim i As Integer = left
        Dim j As Integer = right
        Dim pivot As IdBObject = itemsArray((left + right) \ 2)

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

    Private Sub SwitchArrayItems(ByRef itemsArray() As IdBObject, ByVal index1 As Integer, ByVal index2 As Integer)

        If (index1 <> index2) Then

            Dim tmp As IdBObject = itemsArray(index1)
            itemsArray(index1) = itemsArray(index2)
            itemsArray(index2) = tmp

        End If

    End Sub

    Protected Overridable Function Compare(obj1 As IdBObject, obj2 As IdBObject) As Integer
        Return -(obj1.GetModifiedDateTime.CompareTo(obj2.GetModifiedDateTime()))
    End Function

End Class

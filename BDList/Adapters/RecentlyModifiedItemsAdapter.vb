Imports BDList_DAO_BO.BO
Imports FrameworkPN

Public Class RecentlyModifiedItemsAdapter
    Inherits IdBObjectsAdapter

    Public Sub New(idBObjects As List(Of IdBObject))
        MyBase.New(idBObjects)
    End Sub

    Protected Overrides Function InitItem(item As IdBObject, gridItem As GridItem) As GridItem

        Dim result As GridItem_RecentyModified = Nothing

        If (item IsNot Nothing) Then

            If gridItem Is Nothing Then
                result = New GridItem_RecentyModified
            ElseIf Not TypeOf gridItem Is GridItem_RecentyModified Then
                result = New GridItem_RecentyModified
            Else
                result = gridItem
                result.SetSelected(False)
            End If

            result.SetValue(item)

        End If

        Return result

    End Function

    Protected Overrides Function Compare(obj1 As IdBObject, obj2 As IdBObject) As Integer
        Return -(obj1.GetModifiedDateTime.CompareTo(obj2.GetModifiedDateTime()))
    End Function

End Class

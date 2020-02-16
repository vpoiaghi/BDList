Imports BDList_DAO_BO.BO
Imports FrameworkPN

Public Class PressAdapter
    Inherits ChronologicParutionSortAdapter

    Public Sub New(idBObjects As List(Of IdBObject))
        MyBase.New(idBObjects)
    End Sub

    Protected Overrides Function Filter(idBObjects As List(Of IdBObject)) As List(Of IdBObject)

        Dim PressEditorsId() As Long = {15, 57}

        Dim filteredList As New List(Of IdBObject)
        Dim editors As List(Of IdBObject)

        For Each item As IdBObject In idBObjects

            editors = Nothing

            If TypeOf item Is Edition Then
                editors = New List(Of IdBObject)
                editors.Add(CType(item, Edition).GetEditor)
            ElseIf TypeOf item Is Goody Then
                editors = CType(item, Goody).GetEditors
            End If

            If (editors IsNot Nothing) AndAlso (editors.Count = 1) AndAlso (PressEditorsId.Contains(editors(0).GetId.Value)) Then
                filteredList.Add(item)
            End If

        Next

        Return filteredList

    End Function

End Class

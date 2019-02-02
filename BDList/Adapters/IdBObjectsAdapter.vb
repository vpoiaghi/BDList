Imports BDList_DAO_BO.BO
Imports FrameworkPN

Public Class IdBObjectsAdapter
    Inherits Adapter(Of IdBObject)

    Public Sub New(idBObjects As List(Of IdBObject))
        MyBase.New(idBObjects)
        Sort()
    End Sub

    Protected Overrides Function InitItem(item As IdBObject) As GridItem
        Return InitItem(item, Nothing)
    End Function

    Protected Overrides Function InitItem(item As IdBObject, gridItem As GridItem) As GridItem

        Dim result As GridItem = Nothing

        If result Is Nothing Then result = GetGridItem(Of Edition, GridItem_Edition)(item, gridItem)
        If result Is Nothing Then result = GetGridItem(Of Goody, GridItem_Goody)(item, gridItem)
        If result Is Nothing Then result = GetGridItem(Of Serie, GridItem_Serie)(item, gridItem)

        If TypeOf item Is AdArticle Then
            If result Is Nothing Then result = GetGridItem(Of Edition, GridItem_Edition)(CType(item, AdArticle).GetEdition, gridItem)
            If result Is Nothing Then result = GetGridItem(Of Goody, GridItem_Goody)(CType(item, AdArticle).GetGoody, gridItem)
        End If

        Return result

    End Function

    Private Function GetGridItem(Of ItemType As IdBObject, GridItemType As {GridItem, New})(item As IdBObject, gridItem As GridItem) As GridItem

        Dim result As GridItem = Nothing

        If (item IsNot Nothing) AndAlso (TypeOf item Is ItemType) Then

            If gridItem Is Nothing Then
                result = New GridItemType
            ElseIf Not TypeOf gridItem Is GridItemType Then
                result = New GridItemType
            Else
                result = gridItem
                result.SetSelected(False)
            End If

            result.SetValue(item)

        End If

        Return result

    End Function

    Protected Overrides Function Compare(obj1 As IdBObject, obj2 As IdBObject) As Integer

        Dim cobj1 As IdBObject
        Dim cobj2 As IdBObject

        Dim d1? As Date
        Dim d2? As Date
        Dim s1 As String = Nothing
        Dim s2 As String = Nothing

        If TypeOf obj1 Is AdArticle Then
            With CType(obj1, AdArticle)
                cobj1 = .GetEdition()
                If cobj1 Is Nothing Then
                    cobj1 = .GetGoody()
                End If
            End With
        Else
            cobj1 = obj1
        End If

        If TypeOf obj2 Is AdArticle Then
            With CType(obj2, AdArticle)
                cobj2 = .GetEdition()
                If cobj2 Is Nothing Then
                    cobj2 = .GetGoody()
                End If
            End With
        Else
            cobj2 = obj2
        End If

        If TypeOf cobj1 Is Edition Then
            With CType(cobj1, Edition)
                d1 = .GetParutionDate
                s1 = CType(.GetSeries(0), Serie).GetSortName
            End With
        ElseIf TypeOf cobj1 Is Goody Then
            With CType(cobj1, Goody)
                d1 = .GetParutionDate
                s1 = CType(.GetSeries(0), Serie).GetSortName
            End With
        End If

        If TypeOf cobj2 Is Edition Then
            With CType(cobj2, Edition)
                d2 = .GetParutionDate
                s2 = CType(.GetSeries(0), Serie).GetSortName
            End With
        ElseIf TypeOf cobj2 Is Goody Then
            With CType(cobj2, Goody)
                d2 = .GetParutionDate
                s2 = CType(.GetSeries(0), Serie).GetSortName
            End With
        End If


        Dim result As Integer = 0

        If d1 Is Nothing AndAlso d2 IsNot Nothing Then
            result = 1
        ElseIf d2 Is Nothing AndAlso d1 IsNot Nothing Then
            result = -1
        ElseIf d1 Is Nothing AndAlso d2 Is Nothing Then
            result = 0
        Else
            result = d1.Value.CompareTo(d2.Value)
        End If

        If result = 0 Then
            result = s1.CompareTo(s2)
        End If

        Return result

    End Function

End Class

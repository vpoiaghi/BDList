Imports BDList_DAO_BO.BO
Imports FrameworkPN

Public Class SeriesAdapter
    Inherits Adapter(Of IdBObject)

    Public Sub New(series As List(Of IdBObject))
        MyBase.New(series)
    End Sub

    Protected Overrides Function InitItem(item As IdBObject) As GridItem

        Dim gridItemSerie As New GridItem_Serie()
        gridItemSerie.SetValue(item)

        Return gridItemSerie

    End Function

End Class

Imports BDList_DAO_BO.BO
Imports FrameworkPN

Public Class GoodiesAdapter
    Inherits Adapter(Of IdBObject)

    Public Sub New(goodies As List(Of IdBObject))
        MyBase.New(goodies)
    End Sub

    Protected Overrides Function InitItem(item As IdBObject) As GridItem

        Dim gridItemGoody As New GridItem_Goody()
        gridItemGoody.SetValue(item)

        Return gridItemGoody

    End Function

End Class

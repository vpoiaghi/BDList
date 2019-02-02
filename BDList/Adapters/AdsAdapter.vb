Imports BDList_DAO_BO.BO
Imports FrameworkPN

Public Class AdsAdapter
    Inherits Adapter(Of IdBObject)

    Public Sub New(ads As List(Of IdBObject))
        MyBase.New(ads)
    End Sub

    Protected Overrides Function InitItem(item As IdBObject) As GridItem

        Dim gridItem As New GridItem_Ad()
        gridItem.SetValue(item)

        Return gridItem

    End Function

End Class

Imports BDList_DAO_BO.BO
Imports FrameworkPN

Public Class EditionsAdapter
    Inherits Adapter(Of IdBObject)

    Public Sub New(editions As List(Of IdBObject))
        MyBase.New(editions)
    End Sub

    Protected Overrides Function InitItem(item As IdBObject) As GridItem

        Dim gridItemEdition As New GridItem_Edition()
        gridItemEdition.SetValue(item)

        Return gridItemEdition

    End Function


End Class

Imports BDList_DAO_BO.BO
Imports FrameworkPN

Public Class AuthorsAdapter
    Inherits Adapter(Of IdBObject)

    Public Sub New(authors As List(Of IdBObject))
        MyBase.New(authors)
    End Sub

    Protected Overrides Function InitItem(item As IdBObject) As GridItem

        Dim gridItemAuthor As New GridItem_Author()
        gridItemAuthor.SetValue(item)

        Return gridItemAuthor

    End Function

End Class

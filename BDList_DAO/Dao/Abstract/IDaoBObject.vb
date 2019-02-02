Imports BDList_DAO_BO.BO
Imports BDList_TOOLS

Namespace DAO

    Public Interface IDaoBObject
        Inherits IDao

        Function GetNew() As IdBObject
        Function GetNew(id As Long) As IdBObject

        Function GetById(id As Long?) As IdBObject
        Function GetAll() As List(Of IdBObject)
        Function GetAllSortedById() As List(Of IdBObject)
        Function GetCount() As Integer

        Function GetChanged(fromDate As DateTime) As List(Of IdBObject)

    End Interface

End Namespace
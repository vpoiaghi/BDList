Imports BDList_DAO_BO.BO

Public Class ModifiedItem

    Private m_item As IdBObject
    Private m_fieldChangedList As List(Of String)

    Public Sub New(item As IdBObject)
        m_fieldChangedList = New List(Of String)
        m_item = item
    End Sub

    Public Function GetItem() As IdBObject
        Return m_item
    End Function

    Public Function GetFieldsChangedCount() As Integer
        Return m_fieldChangedList.Count
    End Function

    Public Function GetFieldsChanged(index As Integer) As String
        Return m_fieldChangedList(index)
    End Function

    Public Sub AddChangedFieldName(fieldName As String)
        m_fieldChangedList.Add(fieldName)
    End Sub

    Public Function GetModifiedLevel() As ModifiedLevels
        Return ModifiedLevels.NotChanged
    End Function

End Class

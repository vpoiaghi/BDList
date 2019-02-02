Imports BDList_TOOLS

Public Class GridItemActionEventArgs
    Inherits EventArgs

    Public Enum listItemActions
        Show
        Modify
        Delete
    End Enum

    Private m_action As listItemActions
    Private m_parameters As New Hashtable(Of String, Object)

    Public Sub New(action As listItemActions)
        m_action = action
    End Sub

    Public Sub AddParameter(key As String, value As Object)
        m_parameters.Add(key, value)
    End Sub

    Public Function GetAction() As listItemActions
        Return m_action
    End Function

    Public Function GetParameter(key As String) As Object
        Return m_parameters.Item(key)
    End Function

End Class

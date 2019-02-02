Imports BDList_TOOLS

Public Class GridItemSelectedEventArgs
    Inherits EventArgs

    Private m_value As Object

    Public Sub New(value As Object)
        m_value = value
    End Sub

    Public Function GetValue() As Object
        Return m_value
    End Function

End Class

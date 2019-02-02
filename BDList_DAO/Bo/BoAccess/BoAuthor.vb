Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoAuthor
        Inherits IdBObject

        Dim m_Alias As String

        Public Function GetAlias() As String
            Return m_Alias
        End Function
        Public Sub SetAlias(p_Alias As String)
            m_Alias = p_Alias
        End Sub

    End Class

End Namespace
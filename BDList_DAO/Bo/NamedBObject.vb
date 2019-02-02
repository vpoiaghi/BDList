Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class NamedBObject
        Inherits IdBObject

        Protected m_name As String

        Public Overridable Function GetName() As String
            Return m_name
        End Function

        Public Overridable Sub SetName(p_name As String)
            m_name = p_name
        End Sub

        Public Overrides Function ToString() As String
            Return GetName()
        End Function

    End Class

End Namespace
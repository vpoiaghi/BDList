Namespace BO

    Public MustInherit Class BoWebSite
        Inherits NamedBObject

        Dim m_url As String

        Public Function GetUrl() As String
            Return m_url
        End Function

        Public Sub SetUrl(p_url As String)
            m_url = p_url
        End Sub
    End Class

End Namespace

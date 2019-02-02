Option Explicit On

Namespace BO

	Public MustInherit Class BoSociety
        Inherits NamedBObject

        Dim m_WebSite As String

        Public Function GetWebSite() As String
            Return m_WebSite
        End Function
        Public Sub SetWebSite(p_WebSite As String)
            m_WebSite = p_WebSite
        End Sub

    End Class
End Namespace
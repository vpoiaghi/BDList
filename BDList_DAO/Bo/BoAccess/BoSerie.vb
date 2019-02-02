Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoSerie
        Inherits NamedBObject

        Public Const STATE_ONGOING As Integer = 0
        Public Const STATE_FINISHED As Integer = 1
        Public Const STATE_ABORTED As Integer = 2

        Dim m_Kind As BoKind
        Dim m_Origin As BoOrigin
        Dim m_manager As BoAuthor
        Dim m_SortName As String
        Dim m_Ended As Integer
        Dim m_WebSite As String
        Dim m_Story As String

        Public Function GetKind() As BoKind
            Return m_Kind
        End Function
        Public Sub SetKind(p_Kind As BoKind)
            m_Kind = p_Kind
        End Sub

        Public Function GetOrigin() As BoOrigin
            Return m_Origin
        End Function
        Public Sub SetOrigin(p_Origin As BoOrigin)
            m_Origin = p_Origin
        End Sub

        Public Function GetManager() As BoAuthor
            Return m_manager
        End Function
        Public Sub SetManager(p_manager As BoAuthor)
            m_manager = p_manager
        End Sub

        Public Function GetSortName() As String
            Return m_SortName
        End Function
        Friend Sub SetSortName(p_SortName As String)
            m_SortName = p_SortName
        End Sub

        Public Function IsEnded() As Integer
            Return m_Ended
        End Function
        Public Sub SetEnded(p_Ended As Integer)
            m_Ended = p_Ended
        End Sub

        Public Function GetWebSite() As String
            Return m_WebSite
        End Function
        Public Sub SetWebSite(p_WebSite As String)
            m_WebSite = p_WebSite
        End Sub

        Public Function GetStory() As String
            Return m_Story
        End Function
        Public Sub SetStory(p_Story As String)
            m_Story = p_Story
        End Sub

    End Class
End Namespace
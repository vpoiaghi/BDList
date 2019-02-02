Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoAutograph
        Inherits IdBObject

        Dim m_Author As BoAuthor

        Dim m_AutographDate As Nullable(Of DateTime)
        Dim m_Place As String
        Dim m_Event As String
        Dim m_Comments As String

        Public Function GetAuthor() As BoAuthor
            Return m_Author
        End Function
        Public Sub SetAuthor(p_Author As BoAuthor)
            m_Author = p_Author
        End Sub

        Public Function GetAutographDate() As Nullable(Of DateTime)
            Return m_AutographDate
        End Function
        Public Sub SetAutographDate(p_AutographDate As Nullable(Of DateTime))
            m_AutographDate = p_AutographDate
        End Sub

        Public Function GetPlace() As String
            Return m_Place
        End Function
        Public Sub SetPlace(p_Place As String)
            m_Place = p_Place
        End Sub

        Public Function GetEvent() As String
            Return m_Event
        End Function
        Public Sub SetEvent(p_Event As String)
            m_Event = p_Event
        End Sub

        Public Function GetComments() As String
            Return m_Comments
        End Function
        Public Sub SetComments(p_Comments As String)
            m_Comments = p_Comments
        End Sub

    End Class
End Namespace
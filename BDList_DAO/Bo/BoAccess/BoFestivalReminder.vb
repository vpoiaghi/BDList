Option Explicit On

Namespace BO

    Public MustInherit Class BoFestivalReminder
        Inherits NamedBObject

        Dim m_festival As BoFestival
        Dim m_editor As BoEditor
        Dim m_kind As Nullable(Of Int32)
        Dim m_comments As String

        Public Function GetFestival() As BoFestival
            Return m_festival
        End Function

        Public Sub SetFestival(value As BoFestival)
            m_festival = value
        End Sub

        Public Function GetEditor() As BoEditor
            Return m_editor
        End Function

        Public Sub SetEditor(value As BoEditor)
            m_editor = value
        End Sub

        Public Function GetKind() As Nullable(Of Int32)
            Return m_kind
        End Function

        Public Sub SetKind(value As Nullable(Of Int32))
            m_kind = value
        End Sub

        Public Function GetComments() As String
            Return m_comments
        End Function

        Public Sub SetComments(value As String)
            m_comments = value
        End Sub

    End Class
End Namespace
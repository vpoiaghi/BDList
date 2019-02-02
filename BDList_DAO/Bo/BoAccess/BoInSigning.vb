Option Explicit On

Namespace BO

    Public MustInherit Class BoInSigning
        Inherits IdBObject

        Dim m_festival As BoFestival
        Dim m_editor As BoEditor
        Dim m_author As BoAuthor
        Dim m_day As Nullable(Of Date)
        Dim m_startTime As Nullable(Of Date)
        Dim m_endTime As Nullable(Of Date)
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

        Public Function GetAuthor() As BoAuthor
            Return m_author
        End Function

        Public Sub SetAuthor(value As BoAuthor)
            m_author = value
        End Sub

        Public Function GetDay() As Nullable(Of Date)
            Return m_day
        End Function

        Public Sub SetDay(value As Nullable(Of Date))
            m_Day = value
        End Sub

        Public Function GetStartTime() As Nullable(Of Date)
            Return m_startTime
        End Function

        Public Sub SetStartTime(value As Nullable(Of Date))
            m_startTime = value
        End Sub

        Public Function GetEndTime() As Nullable(Of Date)
            Return m_endTime
        End Function

        Public Sub SetEndTime(value As Nullable(Of Date))
            m_endTime = value
        End Sub

        Public Function GetComments() As String
            Return m_comments
        End Function

        Public Sub SetComments(value As String)
            m_comments = value
        End Sub

    End Class
End Namespace
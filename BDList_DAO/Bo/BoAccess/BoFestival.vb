Option Explicit On

Namespace BO

    Public MustInherit Class BoFestival
        Inherits NamedBObject

        Dim m_beginDate As Nullable(Of Date)
        Dim m_endDate As Nullable(Of Date)

        Public Function GetBeginDate() As Nullable(Of Date)
            Return m_BeginDate
        End Function

        Public Sub SetBeginDate(value As Nullable(Of Date))
            m_BeginDate = value
        End Sub

        Public Function GetEndDate() As Nullable(Of Date)
            Return m_EndDate
        End Function

        Public Sub SetEndDate(value As Nullable(Of Date))
            m_EndDate = value
        End Sub

    End Class
End Namespace
Namespace BO

    Public Class CountByYear

        Private m_year As Integer
        Private m_date As Date
        Private m_count As Integer

        Public Function GetDate() As Date
            Return m_date
        End Function

        Public Sub SetYear(year As Integer)
            m_year = year
            InitDate()
        End Sub

        Public Function GetCount() As Integer
            Return m_count
        End Function

        Public Sub SetCount(count As Integer)
            m_count = count
        End Sub

        Private Sub InitDate()

            If m_year > 0 Then
                m_date = New Date(m_year, 12, 31)
            End If

        End Sub

    End Class
End Namespace

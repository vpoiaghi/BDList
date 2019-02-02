Namespace BO

    Public Class CountByMonth

        Private m_month As Integer
        Private m_year As Integer
        Private m_date As Date
        Private m_count As Integer

        Public Sub New(d As Date, c As Integer)
            SetMonth(d.Month)
            SetYear(d.Year)
            SetCount(c)
        End Sub

        Public Sub New(month As Integer, year As Integer, c As Integer)
            SetMonth(month)
            SetYear(year)
            SetCount(c)
        End Sub

        Public Function GetDate() As Date
            Return m_date
        End Function

        Public Sub SetMonth(month As Integer)
            m_month = month
            InitDate()
        End Sub

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

            If (m_month > 0) AndAlso (m_year > 0) Then
                m_date = New Date(m_year, m_month, 1)
                m_date.AddMonths(1)
                m_date.AddDays(-1)
            End If

        End Sub

    End Class
End Namespace

Imports BDList_TOOLS

Namespace BO

    Public Class Goody
        Inherits BoGoody

        Private m_series As New IdList(Of Serie)
        Private m_editions As New IdList(Of Edition)

        Public Function GetSeries() As IdList(Of Serie)
            Return m_series
        End Function

        Public Sub SetSeries(series As IdList(Of Serie))

            If series Is Nothing Then
                m_series.Clear()
            Else
                m_series = series
            End If

        End Sub

        Public Function GetEditions() As IdList(Of Edition)
            Return m_editions
        End Function

        Public Sub SetEditions(editions As IdList(Of Edition))

            If editions Is Nothing Then
                m_editions.Clear()
            Else
                m_editions = editions
            End If

        End Sub

        Public Overrides Function ToString() As String

            Dim s As String = GetKindOfGoody().ToString
            Dim d As String = GetDescription()

            If s.ToLower = "coffret" Or s.ToLower = "fourreau" Then

                s &= " : "

                For Each e As Edition In GetEditions()
                    s &= e.GetEditionNumber & ", "
                Next

                s = s.Substring(0, s.Length - 2)

            Else
                If Not String.IsNullOrEmpty(d) Then
                    s &= " - " & d
                End If

            End If

            Return s

        End Function

    End Class

End Namespace
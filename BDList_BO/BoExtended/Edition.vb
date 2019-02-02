Imports BDList_TOOLS

Namespace BO

    Public Class Edition
        Inherits BoEdition

        Private m_titles As New IdList(Of Title)
        Private m_series As New IdList(Of Serie)
        Private m_formats As New IdList(Of EditionFormat)
        Private m_colors As New IdList(Of EditionColor)
        Private m_personRoles As New IdList(Of PersonRole)
        Private m_societyRoles As New IdList(Of SocietyRole)

        Public Function GetTitles() As IdList(Of Title)
            Return m_titles
        End Function

        Public Sub SetTitles(titles As IdList(Of Title))
            m_titles = titles
        End Sub

        Public Function GetSeries() As IdList(Of Serie)

            If m_series Is Nothing Then
                dao_ser()
            End If

            Return m_series

        End Function

        Public Sub SetSeries(series As IdList(Of Serie))
            m_series = series
        End Sub

        Public Function GetFormats() As IdList(Of EditionFormat)
            Return m_formats
        End Function

        Public Sub SetFormats(formats As IdList(Of EditionFormat))
            m_formats = formats
        End Sub

        Public Function GetColors() As IdList(Of EditionColor)
            Return m_colors
        End Function

        Public Sub SetColors(colors As IdList(Of EditionColor))
            m_colors = colors
        End Sub

        Public Function GetPersonRoles() As IdList(Of PersonRole)
            Return m_personRoles
        End Function

        Public Sub SetPersonRoles(personRoles As IdList(Of PersonRole))
            m_personRoles = personRoles
        End Sub

        Public Function GetSocietyRoles() As IdList(Of SocietyRole)
            Return m_societyRoles
        End Function

        Public Sub SetSocietyRoles(societyRoles As IdList(Of SocietyRole))
            m_societyRoles = societyRoles
        End Sub

        Public Overrides Function ToString() As String

            Dim result As String
            Dim es As String = ""

            If GetSpecialEdition() IsNot Nothing Then
                es = " (" & GetSpecialEdition() & ")"
            End If


            If IsIntegral() Then

                result = ("[INT] " & GetEditionNumber()).Trim & es & " - " _
                       & "Tomes " & GetTitles(0).GetOrderNumber & " à " & GetTitles.Last.GetOrderNumber

                Dim n As String = GetName()
                If Not String.IsNullOrEmpty(n) Then
                    result &= vbCrLf & n
                End If

            ElseIf IsMiscellany() Then
                result = ("[REC] " & GetEditionNumber()).Trim & es & " - " & GetName()
            Else

                With m_titles(0)

                    If .IsOutSerie Then
                        result = ("[HS] " & .GetOrderNumber).Trim & es & " - " & .ToString
                    Else
                        If String.IsNullOrEmpty(GetEditionNumber()) Then
                            result = IIf(String.IsNullOrEmpty(es), "", es.Trim & " ") & .ToString
                        Else
                            result = GetEditionNumber() & es & " - " & .ToString
                        End If

                    End If

                End With

            End If

            Return result

        End Function

    End Class

End Namespace
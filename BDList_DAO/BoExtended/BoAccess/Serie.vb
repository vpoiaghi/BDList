Option Explicit On

Namespace BO

    Public Class Serie
        Inherits BoSerie

        Private m_toStringValue As String = Nothing

        Public Overrides Function ToString() As String

            If String.IsNullOrEmpty(m_toStringValue) Then
                m_toStringValue = GetToStringValue(GetName())
            End If

            Return m_toStringValue

        End Function

        Public Overrides Sub SetName(p_Name As String)
            MyBase.SetName(p_Name)
            SetSortName(ConvertNameToSortName(p_Name))
        End Sub

        Private Function ConvertNameToSortName(ByVal name As String) As String

            Dim sortName As String = Nothing
            Dim lowerName As String = Nothing
            Dim s As Integer = 0

            If name Is Nothing Then
                sortName = Nothing
            Else

                name = name.Trim
                lowerName = name.ToLower

                If name = "" Then
                    sortName = ""
                Else
                    If lowerName.StartsWith("l'") Then
                        s = 2
                    ElseIf lowerName.StartsWith("le ") Then
                        s = 3
                    ElseIf lowerName.StartsWith("la ") Then
                        s = 3
                    ElseIf lowerName.StartsWith("les ") Then
                        s = 4
                    End If

                    If s > 0 Then

                        ' Recherche des caractères " - ", car si ils sont présent, l'article sera déplacé avant et non à la fin du nom
                        Dim p As Integer = lowerName.IndexOf(" - ") - s
                        Dim a As String = "(" & name.Substring(0, 1).ToUpper & name.Substring(1, (s - 1)).Trim & ")"

                        ' Suppression de l'article de début et mise en majuscule de la première lettre
                        sortName = name.Substring(s, 1).ToUpper & name.Substring(s + 1)

                        If p > 0 Then
                            ' si " - " a été trouvé, insertion de l'article avant
                            sortName = sortName.Substring(0, p) & " " & a & sortName.Substring(p)
                        Else
                            ' sinon ajout de l'article à la fin
                            sortName &= " " & a
                        End If


                    Else
                        sortName = name
                    End If

                End If

                sortName = Replace(sortName, ".", "")

            End If

            Return sortName

        End Function

        Private Function GetToStringValue(ByVal name As String) As String

            Dim sortName As String = Nothing
            Dim lowerName As String = Nothing
            Dim s As Integer = 0

            If name Is Nothing Then
                sortName = Nothing
            Else

                name = name.Trim
                lowerName = name.ToLower

                If name = "" Then
                    sortName = ""
                Else
                    If lowerName.StartsWith("l'") Then
                        s = 2
                    ElseIf lowerName.StartsWith("le ") Then
                        s = 3
                    ElseIf lowerName.StartsWith("la ") Then
                        s = 3
                    ElseIf lowerName.StartsWith("les ") Then
                        s = 4
                    End If

                    If s > 0 Then

                        ' Recherche des caractères " - ", car si ils sont présent, l'article sera déplacé avant et non à la fin du nom
                        Dim p As Integer = lowerName.IndexOf(" - ") - s
                        Dim a As String = "(" & name.Substring(0, 1).ToUpper & name.Substring(1, (s - 1)).Trim & ")"

                        ' Suppression de l'article de début et mise en majuscule de la première lettre
                        sortName = name.Substring(s, 1).ToUpper & name.Substring(s + 1)

                        If p > 0 Then
                            ' si " - " a été trouvé, insertion de l'article avant
                            sortName = sortName.Substring(0, p) & " " & a & sortName.Substring(p)
                        Else
                            ' sinon ajout de l'article à la fin
                            sortName &= " " & a
                        End If


                    Else
                        sortName = name
                    End If

                End If
            End If

            Return sortName

        End Function

    End Class

End Namespace

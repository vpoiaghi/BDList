Namespace BO

    Public Class Festival
        Inherits BoFestival

        Public Function GetDatesString()

            Dim result As String = Nothing

            If (GetBeginDate() IsNot Nothing) AndAlso (GetEndDate() IsNot Nothing) Then

                Dim date1 As Date = GetBeginDate().Value
                Dim date2 As Date = GetEndDate().Value

                Dim d1 As Integer = date1.Day
                Dim m1 As Integer = date1.Month
                Dim y1 As Integer = date1.Year

                Dim d2 As Integer = date2.Day
                Dim m2 As Integer = date2.Month
                Dim y2 As Integer = date2.Year

                If date1.CompareTo(date2) = 0 Then
                    ' le festival dure 1 seule journée
                    result = "Le " & Format(date1, "dd MMMM yyyy")
                ElseIf (y1 = y2) Then
                    If (m1 = m2) Then
                        ' les jours du festivals sont dans un même mois
                        result = "Du " & d1 & " au " & d2 & " " & Format(date1, "MMMM yyyy")
                    Else
                        ' le festival est à cheval sur plusieurs mois
                        result = "Du " & Format(date1, "dd MMMM") & " au " & Format(date2, "dd MMMM yyyy")
                    End If
                Else
                    ' le festival est à cheval sur plusieurs années
                    result = "Du " & Format(date1, "dd MMMM yyyy") & " au " & Format(date2, "dd MMMM yyyy")
                End If

            End If

            Return result

        End Function

    End Class

End Namespace
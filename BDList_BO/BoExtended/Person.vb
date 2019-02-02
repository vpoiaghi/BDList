Namespace BO

    Public Class Person
        Inherits BoPerson

        Public Overrides Function ToString() As String

            Dim result As String = GetAlias()

            If String.IsNullOrEmpty(result) Then

                Dim firstName As String = GetFirstname()
                Dim lastName As String = GetLastname()

                If String.IsNullOrEmpty(firstName) Then
                    result = lastName
                ElseIf String.IsNullOrEmpty(lastName) Then
                    result = firstName
                Else
                    result = lastName & ", " & firstName
                End If

            End If

            Return result

        End Function

    End Class

End Namespace
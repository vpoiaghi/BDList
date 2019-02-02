Namespace BO

    Public Class Person
        Inherits BoPerson

        Private Const UNKNOWN_PERSON_DEFAULT_TO_STRING As String = "Inconnu"

        Public Overrides Function ToString() As String

            Dim result As String = ""

            Dim firstName As String = GetFirstname()
            Dim lastName As String = GetLastname()

            If String.IsNullOrEmpty(firstName) AndAlso String.IsNullOrEmpty(lastName) Then
                result = UNKNOWN_PERSON_DEFAULT_TO_STRING
            ElseIf String.IsNullOrEmpty(firstName) Then
                result = lastName
            ElseIf String.IsNullOrEmpty(lastName) Then
                result = firstName
            Else
                result = lastName & ", " & firstName
            End If

            Return result

        End Function

        Public Function IsUnknown() As Boolean
            Return String.IsNullOrEmpty(GetFirstname) AndAlso String.IsNullOrEmpty(GetLastname)
        End Function

    End Class

End Namespace
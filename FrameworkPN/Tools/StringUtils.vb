Public Module StringUtils

    Public Function ToMoneyString(value As Single?) As String

        Dim result As String = ""

        If value IsNot Nothing Then
            result = Format(value, "##0.00") & " €"
        End If

        Return result

    End Function

End Module

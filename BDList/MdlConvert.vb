Module MdlConvert

    Public Function ToNullableString(strValue As String) As String

        Dim result As String = Nothing

        If Not String.IsNullOrEmpty(strValue) Then
            result = strValue
        End If

        Return result

    End Function

    Public Function ToNullableDate(strValue As String) As Nullable(Of Date)

        Dim result As Nullable(Of Date) = Nothing

        If Not String.IsNullOrEmpty(strValue) Then
            If IsDate(strValue) Then
                result = CDate(strValue)
            End If
        End If

        Return result

    End Function

    Public Function ToNullableInteger(strValue As String) As Nullable(Of Integer)

        Dim result As Nullable(Of Integer) = Nothing

        If Not String.IsNullOrEmpty(strValue) Then
            Try
                result = Integer.Parse(strValue)
            Catch ex As FormatException
            End Try
        End If

        Return result

    End Function

End Module

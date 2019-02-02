Namespace IO

    Public NotInheritable Class Factory

        Private Sub New()
        End Sub

        Public Shared Function GetFile(ByVal path As String) As IFile

            path = path.Trim

            If path.StartsWith("/") Then
                Return New PhoneFile(path)
            Else
                Return New LocalFile(path)
            End If

        End Function

        Public Shared Function GetDirectory(ByVal path As String) As IDirectory

            path = path.Trim

            If path.StartsWith("/") Then
                Return New PhoneDirectory(path)
            Else
                Return New LocalDirectory(path)
            End If

        End Function


    End Class

End Namespace

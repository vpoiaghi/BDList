Namespace IO

    Public Interface IFile

        Function IsExists() As Boolean
        Function GetFullName() As String
        Function GetName() As String
        Function GetLastWriteTime() As DateTime
        Function GetDirectory() As IDirectory
        Function GetExtension() As String
        Sub Remove()
        Function Create() As Boolean

    End Interface

End Namespace
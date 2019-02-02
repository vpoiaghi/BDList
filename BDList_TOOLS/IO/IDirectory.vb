Namespace IO

    Public Interface IDirectory

        Function IsExists() As Boolean
        Function GetName() As String
        Function GetFullName() As String

        Function GetDirectories() As List(Of IDirectory)
        Function GetFiles() As List(Of IFile)
        Function GetFiles(searchPattern As String) As List(Of IFile)

        Sub Remove()
        Function Create() As Boolean
        Function CreateSubDirectory(subDirectoryName As String) As IDirectory

        Sub MoveTo(destDirName As String)

    End Interface

End Namespace
Imports System.IO

Namespace IO

    Friend Class LocalDirectory
        Implements IDirectory


        Private m_directory As DirectoryInfo

        Public Sub New(directoryPath As String)
            Me.New(New DirectoryInfo(directoryPath))
        End Sub

        Public Sub New(directory As DirectoryInfo)
            m_directory = directory
        End Sub

        Public Function GetName() As String Implements IDirectory.GetName
            Return m_directory.Name
        End Function

        Public Function GetFullName() As String Implements IDirectory.GetFullName
            Return m_directory.FullName
        End Function

        Public Function IsExists() As Boolean Implements IDirectory.IsExists
            Return m_directory.Exists
        End Function

        Public Function GetDirectories() As List(Of IDirectory) Implements IDirectory.GetDirectories

            Dim result As New List(Of IDirectory)

            For Each d As DirectoryInfo In m_directory.GetDirectories()
                result.Add(New LocalDirectory(d))
            Next

            Return result

        End Function

        Public Function GetFiles() As List(Of IFile) Implements IDirectory.GetFiles

            Dim result As New List(Of IFile)

            For Each f As FileInfo In m_directory.GetFiles()
                result.Add(New LocalFile(f))
            Next

            Return result

        End Function

        Public Function GetFiles(searchPattern As String) As List(Of IFile) Implements IDirectory.GetFiles

            Dim result As New List(Of IFile)

            If m_directory.Exists Then

                For Each f As FileInfo In m_directory.GetFiles(searchPattern)
                    result.Add(New LocalFile(f))
                Next

            End If

            Return result

        End Function

        Public Sub Remove() Implements IDirectory.Remove
            m_directory.Delete(True)
        End Sub

        Public Function Create() As Boolean Implements IDirectory.Create

            Dim result As Boolean = False

            Try
                m_directory.Create()
                result = True
            Catch ex As Exception
            End Try

            Return result

        End Function

        Public Function CreateSubDirectory(subDirectoryName As String) As IDirectory Implements IDirectory.CreateSubDirectory

            Dim result As IDirectory = Nothing

            Try
                Dim subDirectory As IDirectory = New LocalDirectory(Path.Combine(GetFullName, subDirectoryName))
                If subDirectory.Create() Then
                    result = subDirectory
                End If
            Catch ex As Exception
            End Try

            Return result


        End Function

        Public Sub MoveTo(destDirName As String) Implements IDirectory.MoveTo

            m_directory.MoveTo(destDirName)

        End Sub

    End Class

End Namespace
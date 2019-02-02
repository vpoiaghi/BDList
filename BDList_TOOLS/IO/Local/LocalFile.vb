Imports System.IO

Namespace IO

    Friend Class LocalFile
        Implements IFile

        Private m_file As FileInfo

        Public Sub New(filePath As String)
            Me.New(New FileInfo(filePath))
        End Sub

        Public Sub New(file As FileInfo)
            m_file = file
        End Sub

        Public Function GetFullName() As String Implements IFile.GetFullName
            Return m_file.FullName()
        End Function

        Public Function GetLastWriteTime() As Date Implements IFile.GetLastWriteTime
            Return m_file.LastWriteTime
        End Function

        Public Function GetName() As String Implements IFile.GetName
            Return m_file.Name
        End Function

        Public Function IsExists() As Boolean Implements IFile.IsExists
            Return m_file.Exists
        End Function

        Public Function GetDirectory() As IDirectory Implements IFile.GetDirectory
            Return New LocalDirectory(m_file.Directory)
        End Function

        Public Sub Remove() Implements IFile.Remove
            m_file.Delete()
        End Sub

        Public Function Create() As Boolean Implements IFile.Create

            Dim result As Boolean = False

            Try
                m_file.Create().Close()
                result = True
            Catch ex As Exception
            End Try

            Return result

        End Function

        Public Function GetExtension() As String Implements IFile.GetExtension
            Return m_file.Extension
        End Function
    End Class

End Namespace
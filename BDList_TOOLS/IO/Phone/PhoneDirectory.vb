Namespace IO

    Friend Class PhoneDirectory
        Inherits PhoneElement
        Implements IDirectory

        Private m_subDirectories As List(Of IDirectory)
        Private m_subFiles As List(Of IFile)

        Public Sub New(path As String)
            MyBase.New(path)
        End Sub

        Public Overrides Function GetName() As String Implements IDirectory.GetName
            Return MyBase.GetName
        End Function

        Public Overrides Function GetFullName() As String Implements IDirectory.GetFullName
            Return MyBase.GetFullname
        End Function

        Public Overrides Function IsExists() As Boolean Implements IDirectory.IsExists
            Return MyBase.IsExists
        End Function

        Public Function RefreshDirectories() As List(Of IDirectory)
            m_subDirectories = m_phoneExplorer.GetDirectoriesChilds(Me)
            Return GetDirectories()
        End Function

        Public Function GetDirectories() As List(Of IDirectory) Implements IDirectory.GetDirectories

            If m_subDirectories Is Nothing Then
                m_subDirectories = New List(Of IDirectory)
            End If

            Return m_subDirectories

        End Function

        Public Function RefreshFiles() As List(Of IFile)
            m_subFiles = m_phoneExplorer.GetFilesChilds(Me)
            Return GetFiles()
        End Function

        Public Function GetFiles() As List(Of IFile) Implements IDirectory.GetFiles

            If m_subFiles Is Nothing Then
                m_subFiles = m_phoneExplorer.GetFilesChilds(Me)
            End If

            Return m_subFiles

        End Function

        Public Function GetFiles(searchPattern As String) As List(Of IFile) Implements IDirectory.GetFiles

            Dim result As New List(Of IFile)

            If m_subFiles Is Nothing Then
                m_subFiles = m_phoneExplorer.GetFilesChilds(Me)
            End If

            If m_subFiles IsNot Nothing Then

                For Each f As IFile In m_subFiles
                    If f.GetName Like searchPattern Then
                        result.Add(f)
                    End If
                Next

            End If

            Return result

        End Function

        ' Créé le dossier si il n'existe pas.
        Private Function Create() As Boolean Implements IDirectory.Create
            Return (m_phoneExplorer.CreateDirectory(Me) IsNot Nothing)
        End Function

        Private Function CreateSubDirectory(name As String) As IDirectory Implements IDirectory.CreateSubDirectory

            Dim d As IDirectory = New PhoneDirectory(Me.GetFullName & "/" & name)

            Return m_phoneExplorer.CreateDirectory(d)

        End Function

        Public Overrides Sub Remove() Implements IDirectory.Remove
            MyBase.Remove()
            m_phoneExplorer.RemoveDirectory(Me)
        End Sub

        Public Sub AddDirectory(subDirectory As IDirectory)

            If m_subDirectories Is Nothing Then
                m_subDirectories = New List(Of IDirectory)
            End If

            m_subDirectories.Add(subDirectory)

        End Sub

        Public Sub AddFile(subFile As IFile)

            If m_subFiles Is Nothing Then
                m_subFiles = New List(Of IFile)
            End If

            m_subFiles.Add(subFile)

        End Sub

        Public Sub MoveTo(destDirName As String) Implements IDirectory.MoveTo
            Throw New NotImplementedException("La fonction MoveTo n'est pas implémentée par la classe PhoneDirectory.")
        End Sub

    End Class

End Namespace
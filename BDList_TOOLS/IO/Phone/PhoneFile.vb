Namespace IO

    Friend Class PhoneFile
        Inherits PhoneElement
        Implements IFile

        Public Sub New(path As String)
            MyBase.New(path)
        End Sub

        Public Overrides Sub Remove() Implements IFile.Remove
            MyBase.Remove()
            m_phoneExplorer.RemoveFile(Me)
        End Sub

        Public Function Create() As Boolean Implements IFile.Create
            Throw New NotImplementedException("La function Create de PhoneFile n'est pas implémentée.")
        End Function

        Public Overrides Function GetFullName() As String Implements IFile.GetFullName
            Return MyBase.GetFullname
        End Function

        Public Function GetLastWriteTime() As Date Implements IFile.GetLastWriteTime
            Return MyBase.GetCreationDate
        End Function

        Public Overrides Function GetName() As String Implements IFile.GetName
            Return MyBase.GetName
        End Function

        Public Overrides Function IsExists() As Boolean Implements IFile.IsExists
            Return MyBase.IsExists
        End Function

        Public Function GetDirectory() As IDirectory Implements IFile.GetDirectory
            Return GetParent()
        End Function

        Public Function GetExtension() As String Implements IFile.GetExtension

            Dim n As String = GetName()
            Dim p As Integer = n.LastIndexOf(".")

            Return n.Substring(p)

        End Function
    End Class

End Namespace
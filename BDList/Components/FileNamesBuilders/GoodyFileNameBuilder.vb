Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class GoodyFileNameBuilder
    Inherits PictureFileNameBuilder

    Private m_goody As Goody

    Public Sub New(goody As Goody)
        MyBase.New()

        m_goody = goody

    End Sub

    Public Overrides Function GetFile() As iFile

        Dim file As IFile = Nothing

        Dim result As String = InputBox("Indiquez le numéro de l'image :", "Nouvelle image...")

        If Not String.IsNullOrEmpty(result) Then
            file = GetFile(Integer.Parse(result))
        End If

        Return file

    End Function

    Public Overloads Function GetFile(index As Integer) As IFile

        Dim serviceGoody As New ServiceGoody
        Dim filename As String = serviceGoody.GetFileName(m_goody, index)
        Dim dirPath As IDirectory = DirNameGenerator.GetGoodiesDir(m_goody)

        Return Factory.GetFile(Path.Combine(dirPath.GetFullName, filename))

    End Function

End Class

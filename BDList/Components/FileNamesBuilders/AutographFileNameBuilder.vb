Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class AutographFileNameBuilder
    Inherits PictureFileNameBuilder

    Private m_autograph As Autograph

    Public Sub New(autograph As Autograph)
        MyBase.New()

        m_autograph = autograph

    End Sub

    Public Overrides Function GetFile() As IFile

        Dim file As IFile = Nothing

        Dim result As String = InputBox("Indiquez le numéro de l'image :", "Nouvelle image...")

        If Not String.IsNullOrEmpty(result) Then

            Dim pictureNumber As Integer = Integer.Parse(result)

            Dim serviceAutograph As New ServiceAutograph
            Dim filename As String = serviceAutograph.GetFileName(m_autograph, pictureNumber)
            Dim dirPath As IDirectory = DirNameGenerator.GetAutographDir(CType(m_autograph, Autograph))

            file = Factory.GetFile(Path.Combine(dirPath.GetFullName, filename))

        End If

        Return file

    End Function

End Class

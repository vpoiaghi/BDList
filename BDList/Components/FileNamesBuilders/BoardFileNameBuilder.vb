Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class BoardFileNameBuilder
    Inherits PictureFileNameBuilder

    Private m_edition As Edition

    Public Sub New(edition As Edition)
        MyBase.New()

        m_edition = edition

    End Sub

    Public Overrides Function GetFile() As IFile

        Dim file As IFile = Nothing

        Dim result As String = InputBox("Indiquez le numéro de la planche :", "Nouvelle planche...")

        If Not String.IsNullOrEmpty(result) Then
            file = GetFile(Integer.Parse(result))
        End If

        Return file

    End Function

    Public Overloads Function GetFile(index As Integer?) As IFile

        Dim serviceEdition As New ServiceEdition
        Return serviceEdition.GetBoardFile(m_edition, index, False)

    End Function

End Class

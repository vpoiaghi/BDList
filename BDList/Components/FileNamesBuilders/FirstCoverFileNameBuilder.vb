Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class FirstCoverFileNameBuilder
    Inherits PictureFileNameBuilder

    Private m_edition As Edition

    Public Sub New(edition As Edition)
        MyBase.New()

        m_edition = edition

    End Sub

    Public Overrides Function GetFile() As IFile

        Dim serviceEdition As New ServiceEdition
        Return serviceEdition.GetFirstCoverFile(m_edition, False)

    End Function

End Class

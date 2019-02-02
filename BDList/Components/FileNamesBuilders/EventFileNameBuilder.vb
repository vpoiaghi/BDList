Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class EventFileNameBuilder
    Inherits PictureFileNameBuilder

    Private m_recallEvent As RecallEvent

    Public Sub New(recallEvent As RecallEvent)
        MyBase.New()

        m_recallEvent = recallEvent

    End Sub

    Public Overrides Function GetFile() As IFile

        Dim serviceEvent As New ServiceRecallEvent
        Dim filename As String = serviceEvent.GetFileName(m_recallEvent)
        Dim dirPath As IDirectory = DirNameGenerator.GetEventsDir(m_recallEvent)

        Return Factory.GetFile(Path.Combine(dirPath.GetFullName, filename))

    End Function

End Class

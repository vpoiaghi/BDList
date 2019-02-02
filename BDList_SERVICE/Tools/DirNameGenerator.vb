Imports BDList_DAO_BO.BO
Imports BDList_TOOLS.IO

Public Class DirNameGenerator

    Public Shared Function GetMainSerieDir(p_serie As Serie) As iDirectory
        Return Factory.GetDirectory(GetMainSerieDirPath(p_serie))
    End Function

    Public Shared Function GetFirstCoverDir(p_edition As Edition) As IDirectory
        Return GetDir(p_edition, FIRSTCOVERS_FOLDER_NAME)
    End Function

    Public Shared Function GetFourthCoverDir(p_edition As Edition) As IDirectory
        Return GetDir(p_edition, FOURTHCOVERS_FOLDER_NAME)
    End Function

    Public Shared Function GetBoardDir(p_edition As Edition) As IDirectory
        Return GetDir(p_edition, BOARDS_FOLDER_NAME)
    End Function

    Public Shared Function GetGoodiesDir(p_goody As Goody) As IDirectory

        Dim result As IDirectory

        If p_goody.GetSeries.Count > 1 Then
            result = Factory.GetDirectory(Path.Combine(SET_FOLDER_PATH, GOODIES_FOLDER_NAME))
        ElseIf p_goody.GetSeries.Count = 0 Then
            result = Factory.GetDirectory(Path.Combine(OUT_SERIE_PATH, GOODIES_FOLDER_NAME))
        Else
            Dim s As Serie = p_goody.GetSeries(0)
            result = Factory.GetDirectory(Path.Combine(GetMainSerieDirPath(s), GOODIES_FOLDER_NAME))
        End If

        Return result

    End Function

    Public Shared Function GetAutographDir(p_autograph As Autograph) As IDirectory

        Dim serviceAuthor As New ServiceAuthor
        Dim dInfo As IDirectory = serviceAuthor.GetDirectory(p_autograph.GetAuthor)

        Return Factory.GetDirectory(Path.Combine(dInfo.GetFullName, AUTOGRAPH_FOLDER_NAME))

    End Function

    Public Shared Function GetBandeauDir(p_serie As Serie) As IFile

        Dim f As IFile = Nothing
        Dim d As IDirectory = Factory.GetDirectory(Path.Combine(GetMainSerieDirPath(p_serie), "Bandeau"))

        If d.IsExists Then

            Dim files As List(Of IFile) = d.GetFiles("bandeau.*")

            If files.Count > 0 Then
                f = files(0)
            End If

        End If

        Return f

    End Function

    Public Shared Function GetPersonsDir(p_name As String) As IDirectory

        Dim d As IDirectory = Nothing

        If Not String.IsNullOrEmpty(p_name) Then
            d = Factory.GetDirectory(Path.Combine(PERSONS_FOLDER_PATH, p_name))
        End If

        Return d

    End Function

    Public Shared Function GetEventsDir(p_recallEvent As RecallEvent) As IDirectory
        Return Factory.GetDirectory(EVENTS_FOLDER_PATH)
    End Function

    Private Shared Function GetDir(p_edition As Edition, targetDirName As String) As IDirectory

        If p_edition.IsMiscellany Then
            Return Factory.GetDirectory(Path.Combine(SET_FOLDER_PATH, targetDirName))
        Else
            Return Factory.GetDirectory(Path.Combine(GetMainSerieDirPath(p_edition.GetSeries(0)), targetDirName))
        End If

    End Function

    Private Shared Function GetMainSerieDirPath(p_serie As Serie) As String
        Return Path.Combine(BOOKS_FOLDER_PATH, p_serie.GetSortName)
    End Function

End Class

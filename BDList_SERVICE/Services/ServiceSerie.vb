Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS.IO

Public Class ServiceSerie
    Inherits Service(Of DaoSerie)

    Public Function GetSeriesByFirstLetters(ParamArray firstLetters() As String) As List(Of IdBObject)

        Dim series As New List(Of IdBobject)
        Dim searchByNumber As Boolean = False
        Dim letters As String = ""
        Dim s As New List(Of IdBobject)

        For Each letter As String In firstLetters
            If IsNumeric(letter) Then
                searchByNumber = True
            Else
                letters &= letter & ","
            End If
        Next

        If searchByNumber Then
            s = GetDao().GetSeriesStartByNumber()
            series.AddRange(s)
        End If

        If Not String.IsNullOrEmpty(letters) Then
            letters = letters.Substring(0, letters.Length - 1)
            s = GetDao().GetByFirstLetters(letters.Split(","))
            series.AddRange(s)
        End If

        Return series

    End Function

    Public Function Search(searchCriteria As SearchCriteria) As List(Of IdBObject)
        Return GetDao().Search(searchCriteria)
    End Function

    Public Function GetSeriesByFirstLetter(firstLetter As String) As List(Of IdBObject)

        Dim result As New List(Of IdBObject)

        If IsNumeric(firstLetter) Then
            result = GetDao().GetSeriesStartByNumber()
        Else
            result = GetSeriesByFirstLetters(firstLetter)
        End If

        Return result

    End Function

    Public Function GetSeriesByName(name As String) As List(Of IdBObject)

        Return GetDao().GetByName(name)

    End Function

    Public Function GetSeriesBySortName(sortName As String) As List(Of IdBObject)
        Return GetDao().GetByName(sortName)
    End Function

    Public Function GetSeriesByAuthorName(author As Author) As List(Of IdBObject)
        Return GetDao().GetSeriesByAuthorName(author)
    End Function

    Public Function GetAllWithEditionsCount() As Integer
        Return GetDao().GetAllWithEditionsCount()
    End Function

    Public Function GetAllWithEditionsFullCount() As Integer
        Return GetDao().GetAllWithEditionsFullCount()
    End Function

    Public Function GetAllWithEditionsNotFullCount() As Integer
        Return GetDao().GetAllWithEditionsNotFullCount()
    End Function

    Protected Overrides Sub BoAdded(serie As IdBObject)
        AddFolder(serie)
    End Sub

    Protected Overrides Sub BoUpdated(oldSerie As IdBObject, newSerie As IdBObject)
        RenameFolder(oldSerie, newSerie)
    End Sub

    Public Sub AddFolder(serie As Serie)

        Dim d As IDirectory = Factory.GetDirectory(BOOKS_FOLDER_PATH)
        If Not d.IsExists Then
            d.Create()
        End If

        Dim dInfos As IDirectory

        d = DirNameGenerator.GetMainSerieDir(serie)

        If Not d.IsExists Then
            d.Create()
            d.CreateSubDirectory(FIRSTCOVERS_FOLDER_NAME)
            d.CreateSubDirectory(FOURTHCOVERS_FOLDER_NAME)
            d.CreateSubDirectory(GOODIES_FOLDER_NAME)
            d.CreateSubDirectory(BOARDS_FOLDER_NAME)
            d.CreateSubDirectory(MOVIES_FOLDER_NAME)

            dInfos = d.CreateSubDirectory(INFOS_FOLDER_NAME)
            Dim fInfos As IFile = Factory.GetFile(Path.Combine(dInfos.GetFullName, "s" & Format(serie.GetId(), "0000") & ".txt"))
            fInfos.Create()

        Else
            Dim subDir As IDirectory

            subDir = Factory.GetDirectory(Path.Combine(d.GetFullName, FIRSTCOVERS_FOLDER_NAME))
            If Not subDir.IsExists Then subDir.Create()

            subDir = Factory.GetDirectory(Path.Combine(d.GetFullName, FOURTHCOVERS_FOLDER_NAME))
            If Not subDir.IsExists Then subDir.Create()

            subDir = Factory.GetDirectory(Path.Combine(d.GetFullName, GOODIES_FOLDER_NAME))
            If Not subDir.IsExists Then subDir.Create()

            subDir = Factory.GetDirectory(Path.Combine(d.GetFullName, BOARDS_FOLDER_NAME))
            If Not subDir.IsExists Then subDir.Create()

            subDir = Factory.GetDirectory(Path.Combine(d.GetFullName, MOVIES_FOLDER_NAME))
            If Not subDir.IsExists Then subDir.Create()

            subDir = Factory.GetDirectory(Path.Combine(d.GetFullName, INFOS_FOLDER_NAME))
            Dim fInfos As IFile = Factory.GetFile(Path.Combine(subDir.GetFullName, "s" & Format(serie.GetId().ToString, "0000") & ".txt"))

            If Not subDir.IsExists Then
                subDir.Create()
                fInfos.Create()
            ElseIf Not fInfos.IsExists Then
                fInfos.Create()
            End If

        End If

    End Sub

    Private Sub RenameFolder(oldSerie As Serie, newSerie As Serie)

        Dim d As IDirectory = Factory.GetDirectory(BOOKS_FOLDER_PATH)
        If Not d.IsExists Then
            d.Create()
        End If

        If (oldSerie IsNot Nothing) Then
            If (oldSerie.GetSortName <> newSerie.GetSortName) Then

                d = Factory.GetDirectory(BOOKS_FOLDER_PATH & oldSerie.GetSortName())

                If d.IsExists Then

                    If oldSerie.GetSortName.ToLower = newSerie.GetSortName.ToLower Then
                        d.MoveTo(BOOKS_FOLDER_PATH & oldSerie.GetSortName() & "_tmp")
                        d = Factory.GetDirectory(BOOKS_FOLDER_PATH & oldSerie.GetSortName() & "_tmp")
                    End If

                    d.MoveTo(BOOKS_FOLDER_PATH & newSerie.GetSortName())

                End If
            End If
        Else
            AddFolder(newSerie)

        End If

    End Sub

End Class

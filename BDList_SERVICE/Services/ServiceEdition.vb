Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class ServiceEdition
    Inherits Service(Of DaoEdition)

    Private Shared m_svcTitle As New ServiceTitle
    Private Shared m_svcAutograph As New ServiceAutograph


    Public Sub ConvertFilesNames()

        Dim editions As List(Of IdBObject) = GetAll()
        Dim boardsFiles As List(Of IFile)
        Dim firstCoverFile As IFile
        Dim fourthCoverFile As IFile

        Dim oldname As String
        Dim oldfile As IO.FileInfo
        Dim newName As String
        Dim index As String

        For Each edition As BoEdition In editions

            If edition.GetId.Value = 288 Then
                Dim t As Integer = 0
            End If

            firstCoverFile = GetFirstCoverFile(edition, True)
            If firstCoverFile IsNot Nothing Then
                oldname = firstCoverFile.GetFullName
                oldfile = New IO.FileInfo(oldname)
                newName = Format(edition.GetId.Value, "000000") & oldfile.Extension
                oldfile.MoveTo(IO.Path.Combine(oldfile.Directory.FullName, newName))
            End If

            fourthCoverFile = GetFourthCoverFile(edition, True)
            If fourthCoverFile IsNot Nothing Then
                oldname = fourthCoverFile.GetFullName
                oldfile = New IO.FileInfo(oldname)
                newName = Format(edition.GetId.Value, "000000") & oldfile.Extension
                oldfile.MoveTo(IO.Path.Combine(oldfile.Directory.FullName, newName))
            End If


            boardsFiles = GetBoardsFiles(edition)
            For Each boardFile As IFile In boardsFiles

                oldname = boardFile.GetFullName
                oldfile = New IO.FileInfo(oldname)
                With oldfile.Name.Substring(0, oldfile.Name.Length - oldfile.Extension.Length)
                    index = .Substring(.Length - 3)
                    newName = Format(edition.GetId.Value, "000000") & "-" & index & oldfile.Extension
                    oldfile.MoveTo(IO.Path.Combine(oldfile.Directory.FullName, newName))
                End With

            Next

        Next

        MsgBox("Convertion terminée")

    End Sub

    Public Function GetAllBySerie(serie As Serie) As List(Of IdBObject)

        Dim result As List(Of IdBObject) = Nothing

        Try

            If serie Is Nothing Then
                result = New List(Of IdBObject)
            Else
                result = GetAllBySerie(serie.GetId)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetLastModified() As List(Of IdBObject)
        Return GetDao().GetLastModified()
    End Function

    Public Function GetByAutograph(autograph As BoAutograph) As Edition
        Return GetDao().GetByAutograph(autograph)
    End Function

    Public Function GetExisting() As List(Of IdBObject)

        Dim result As New List(Of IdBObject)

        Try
            result = GetDao().GetExisting()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetExistingBySerie(serie As Serie) As List(Of IdBObject)

        Dim result As List(Of IdBObject) = Nothing

        Try

            If serie Is Nothing Then
                result = New List(Of IdBObject)
            Else
                result = GetExistingBySerie(serie.GetId)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function Search(searchCriteria As SearchCriteria) As List(Of IdBObject)
        Return GetDao().Search(searchCriteria)
    End Function

    Public Function SearchCount(searchCriteria As SearchCriteria) As Integer
        Return GetDao().SearchCount(searchCriteria)
    End Function

    Public Function GetEditionByPeriod(firstDate As Date, lastDate As Date) As List(Of IdBObject)

        Dim result As New List(Of IdBObject)

        Try
            result = GetDao().GetEditionByPeriod(firstDate, lastDate)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetBoughtByPeriod(firstDate As Date, lastDate As Date) As List(Of IdBObject)

        Dim result As New List(Of IdBObject)

        Try
            result = GetDao().GetBoughtByPeriod(firstDate, lastDate)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetEditionByPeriodAndEditor(firstDate As Date, lastDate As Date, editor As Editor) As List(Of IdBObject)

        Dim result As New List(Of IdBObject)

        Try
            result = GetDao().GetEditionByPeriodAndEditor(firstDate, lastDate, editor.GetId)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetBoughtByPeriodAndEditor(firstDate As Date, lastDate As Date, editor As Editor) As List(Of IdBObject)

        Dim result As New List(Of IdBObject)

        Try
            result = GetDao().GetBoughtByPeriodAndEditor(firstDate, lastDate, editor.GetId)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetComing() As List(Of IdBObject)

        Dim result As New List(Of IdBObject)

        Try
            result = GetDao().GetComing(Today)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetComing(firstDate As Date) As List(Of IdBObject)

        Dim result As New List(Of IdBObject)

        Try
            result = GetDao().GetComing(firstDate)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetComingBySerie(serie As Serie) As List(Of IdBObject)

        Dim result As List(Of IdBObject) = Nothing

        Try

            If serie Is Nothing Then
                result = New List(Of IdBObject)
            Else
                result = GetComingBySerie(serie.GetId)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetComingByEditor(editor As Editor) As List(Of IdBObject)

        Dim result As List(Of IdBObject) = Nothing

        Try

            If editor Is Nothing Then
                result = New List(Of IdBObject)
            Else
                result = GetComingByEditor(editor.GetId)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetPurchased() As List(Of IdBObject)

        Dim result As New List(Of IdBObject)

        Try
            result = GetDao().GetPurchased()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetPurchasedByEditor(editor As Editor) As List(Of IdBObject)

        Dim result As List(Of IdBObject) = Nothing

        Try

            If editor Is Nothing Then
                result = New List(Of IdBObject)
            Else
                result = GetDao().GetPurchasedByEditor(editor)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetAllBySerie(idSerie As Long?) As List(Of IdBObject)

        Return GetDao().GetAllBySerie(idSerie)

    End Function

    Public Function GetExistingBySerie(idSerie As Long?) As List(Of IdBObject)

        Return GetDao().GetExistingBySerie(idSerie)

    End Function

    Public Function GetComingBySerie(idSerie As Long?) As List(Of IdBObject)

        Return GetDao().GetComingBySerie(idSerie)

    End Function

    Public Function GetComingByEditor(idEditor As Long?) As List(Of IdBObject)

        Return GetDao().GetComingByEditor(idEditor)

    End Function

    Public Function GetInPossessionCount() As Integer
        Return GetDao.GetInPossessionCount()
    End Function

    Public Function GetIntegralsInPossessionCount() As Integer
        Return GetDao.GetIntegralsInPossessionCount()
    End Function

    Public Function GetMiscellaniesInPossessionCount() As Integer
        Return GetDao.GetMiscellaniesInPossessionCount()
    End Function

    Public Function GetInPossessionByEditorCount(editor As Editor) As Integer
        Return GetDao.GetInPossessionByEditorCount(editor)
    End Function

    Public Function GetInPossessionByMonths() As List(Of CountByMonth)

        Dim result As List(Of CountByMonth) = GetDao.GetInPossessionByMonths()
        Dim fullResult As New List(Of CountByMonth)

        Dim tmpDate As Date = result(0).GetDate
        Dim tmpCount As Integer = result(0).GetCount

        For Each cbm As CountByMonth In result

            While tmpDate < cbm.GetDate
                fullResult.Add(New CountByMonth(tmpDate, tmpCount))
                tmpDate = tmpDate.AddMonths(1)
            End While

            fullResult.Add(cbm)
            tmpDate = cbm.GetDate.AddMonths(1)
            tmpCount = cbm.GetCount

        Next


        Return fullResult

    End Function

    Public Function GetInPossessionByYears() As List(Of CountByYear)
        Return GetDao.GetInPossessionByYears()
    End Function

    Public Function GetCountBySerie(idSerie As Long?) As Integer
        Return GetDao().GetCountBySerie(idSerie)
    End Function

    Public Function GetCountInPossessionBySerie(idSerie As Long?) As Integer
        Return GetDao().GetCountInPossessionBySerie(idSerie)
    End Function

    Public Function GetComingCountBySerie(idSerie As Long?) As Integer
        Return GetDao().GetComingCountBySerie(idSerie)
    End Function

    Public Overrides Function GetFile(bo As IdBObject, Optional fileIndex As Integer? = 1) As IFile
        Return GetFirstCoverFile(CType(bo, Edition), False)
    End Function

    Public Function GetFirstCoverFile(edition As Edition, onlyIfExists As Boolean) As IFile

        Dim filePath As String = Path.Combine(DirNameGenerator.GetFirstCoverDir(edition).GetFullName, GetGenericFileName(edition))
        Dim file As IFile = Factory.GetFile(filePath)

        If (Not onlyIfExists) OrElse (file.IsExists) Then
            Return file
        Else
            Return Nothing
        End If

    End Function

    Public Function GetBoardFile(edition As Edition, boardIndex As Integer, onlyIfExists As Boolean) As IFile

        Dim filePath As String = Path.Combine(DirNameGenerator.GetBoardDir(edition).GetFullName, GetGenericFileName(edition, boardIndex))
        Dim file As IFile = Factory.GetFile(filePath)

        If (Not onlyIfExists) OrElse (file.IsExists) Then
            Return file
        Else
            Return Nothing
        End If

    End Function

    Public Function GetFourthCoverFile(edition As Edition, onlyIfExists As Boolean) As IFile

        Dim filePath As String = Path.Combine(DirNameGenerator.GetFourthCoverDir(edition).GetFullName, GetGenericFileName(edition))
        Dim file As IFile = Factory.GetFile(filePath)

        If (Not onlyIfExists) OrElse (file.IsExists) Then
            Return file
        Else
            Return Nothing
        End If

    End Function

    Public Function GetBoardsFiles(edition As Edition) As List(Of IFile)

        Dim files As New List(Of IFile)

        Dim boardDir As IDirectory = DirNameGenerator.GetBoardDir(edition)
        Dim boardFilePattern As String = GetBoardFilePattern(edition)

        files.AddRange(boardDir.GetFiles(boardFilePattern))

        Return files

    End Function

    Private Function GetBoardFilePattern(edition As Edition) As String
        Return GetGenericFileName(edition, "*")
    End Function

    Private Function GetGenericFileName(edition As Edition, Optional boardNumber As String = Nothing) As String

        Dim fileName As String = Format(edition.GetId, "000000")

        If Not String.IsNullOrEmpty(boardNumber) Then

            Dim n As Integer

            If Integer.TryParse(boardNumber, n) Then
                fileName &= "-" & Format(n, "000")
            Else
                fileName &= "-" & boardNumber
            End If

        End If

        Return fileName & ".jpg"

    End Function

    Public Overrides Sub InsertOrUpdate(edition As IdBObject)


        For Each title As Title In CType(edition, Edition).GetTitles
            m_svcTitle.InsertOrUpdate(title)
        Next

        For Each autograph As Autograph In CType(edition, Edition).GetAutographs
            m_svcAutograph.InsertOrUpdate(autograph)
        Next

        MyBase.InsertOrUpdate(edition)

    End Sub

    Public Function HasAnotherEditions(edition As Edition) As Integer
        Return GetDao().HasAnotherEditions(edition)
    End Function

    Public Function GetWithAutograph() As List(Of IdBObject)
        Return GetDao().GetWithAutograph
    End Function

    Public Overrides Sub Delete(edition As IdBObject)

        MyBase.Delete(edition)
        DeleteEditionImages(edition)

    End Sub

    Public Overrides Sub Delete(editionsList As List(Of IdBObject))

        MyBase.Delete(editionsList)

        For Each edition As IdBObject In editionsList
            DeleteEditionImages(edition)
        Next

    End Sub

    Private Sub DeleteEditionImages(edition As IdBObject)

        Dim e As Edition = CType(edition, Edition)

        ImageUtils.DeleteImage(GetFirstCoverFile(e, True))
        ImageUtils.DeleteImage(GetFourthCoverFile(e, True))

        For Each imgFile As IFile In GetBoardsFiles(e)
            ImageUtils.DeleteImage(imgFile)
        Next

        For Each autograph As Autograph In e.GetAutographs
            m_svcAutograph.DeleteAutographImages(autograph)
        Next

    End Sub

End Class

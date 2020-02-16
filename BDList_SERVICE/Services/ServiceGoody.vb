Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class ServiceGoody
    Inherits Service(Of DaoGoody)

    Public Function Search(searchCriteria As SearchCriteria) As List(Of IdBObject)
        Return GetDao().Search(searchCriteria)
    End Function

    Public Function SearchCount(searchCriteria As SearchCriteria) As Integer
        Return GetDao().SearchCount(searchCriteria)
    End Function

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

    Public Function GetAllBySerie(idSerie As Long?) As List(Of IdBObject)
        Return GetDao().GetAllBySerie(idSerie)
    End Function

    Public Function GetAllByAuthor(author As BoAuthor) As List(Of IdBObject)
        Return GetAllByAuthor(author.GetId)
    End Function

    Public Function GetAllByAuthor(idAuthor As Long?) As List(Of IdBObject)
        Return GetDao().GetAllByAuthor(idAuthor)
    End Function

    Public Function GetByAutograph(autograph As BoAutograph) As Goody
        Return GetDao().GetByAutograph(autograph)
    End Function

    Public Function GetLastModified() As List(Of IdBObject)
        Return GetDao().GetLastModified()
    End Function

    Public Function GetComing() As List(Of IdBObject)
        Return GetComing(Today)
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

    Public Function GetComingByEditor(editor As Editor) As List(Of IdBObject)
        Return GetComingByEditor(Today, editor)
    End Function

    Public Function GetComingByEditor(firstDate As Date, editor As Editor) As List(Of IdBObject)

        Dim result As New List(Of IdBObject)

        Try
            result = GetDao().GetComingByEditor(firstDate, editor.GetId)
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

    Public Function GetExLibrisLike() As List(Of IdBObject)

        Dim result As New List(Of IdBObject)

        Try
            result = GetDao().GetExLibrisLike()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetByPeriod(firstDate As Date, lastDate As Date) As List(Of IdBObject)

        Dim result As New List(Of IdBObject)

        Try
            result = GetDao().GetByPeriod(firstDate, lastDate)
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

    Public Function GetByPeriodAndEditor(firstDate As Date, lastDate As Date, editor As Editor) As List(Of IdBObject)

        Dim result As New List(Of IdBObject)

        Try
            result = GetDao().GetByPeriodAndEditor(firstDate, lastDate, editor.GetId)
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

    Public Function GetCountBySerie(idSerie As Long?) As Integer
        Return GetDao().GetCountBySerie(idSerie)
    End Function

    Public Function GetCountInPossessionBySerie(idSerie As Long?) As Integer
        Return GetDao().GetCountInPossessionBySerie(idSerie)
    End Function

    Public Function GetBoxesInPossessionCount() As Integer
        Return GetDao().GetBoxesInPossessionCount()
    End Function

    Public Function GetSheathsInPossessionCount() As Integer
        Return GetDao().GetSheathsInPossessionCount()
    End Function

    Public Overrides Function GetFile(bo As IdBObject, Optional fileIndex As Integer? = 1) As IFile

        Dim fileName As String = GetFilePattern(CType(bo, Goody), fileIndex)
        Dim dirPath As String = DirNameGenerator.GetGoodiesDir(CType(bo, Goody)).GetFullName
        Dim filePath As String = Path.Combine(dirPath, fileName)

        Return Factory.GetFile(filePath)

    End Function

    Public Function GetFiles(goody As Goody) As List(Of IFile)

        Dim result As List(Of IFile) = Nothing

        Dim parentDir As IDirectory = DirNameGenerator.GetGoodiesDir(goody)
        Dim filePattern As String = GetFilePattern(goody)

        If parentDir.IsExists Then
            result = parentDir.GetFiles(filePattern).ToList
        Else
            result = New List(Of IFile)
        End If

        Return result

    End Function

    Private Function GetFilePattern(goody As Goody, Optional fileIndex As Nullable(Of Integer) = Nothing) As String

        Dim filePattern As String = Format(goody.GetId, "000000") & "-"

        If fileIndex Is Nothing Then
            filePattern &= "*"
        Else
            filePattern &= Format(fileIndex.Value, "00")
        End If

        Return filePattern & ".jpg"

    End Function

    Public Function GetWithAutograph() As List(Of IdBObject)
        Return GetDao().GetWithAutograph
    End Function

    Public Function GetNumberTypes() As List(Of String)
        Return GetDao().GetNumberTypes()
    End Function

    Public Overrides Sub InsertOrUpdate(goody As IdBObject)

        Dim serviceEditor As New ServiceEditor
        For Each editor As Editor In CType(goody, Goody).GetEditors
            serviceEditor.InsertOrUpdate(editor)
        Next

        MyBase.InsertOrUpdate(goody)

    End Sub

    Public Overrides Sub Delete(goody As IdBObject)

        MyBase.Delete(goody)
        DeleteGoodyImages(goody)

    End Sub

    Public Overrides Sub Delete(goodiesList As List(Of IdBObject))

        MyBase.Delete(goodiesList)

        For Each goody As IdBObject In goodiesList
            DeleteGoodyImages(goody)
        Next

    End Sub

    Private Sub DeleteGoodyImages(goody As IdBObject)

        For Each imgFile As IFile In GetFiles(goody)
            ImageUtils.DeleteImage(imgFile)
        Next

    End Sub

End Class

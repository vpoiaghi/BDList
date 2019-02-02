Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports BDList_TOOLS.Types.Sql

Imports FrameworkPN

Imports System.Drawing.Drawing2D


Public Class SynchroniseAutographs
    Inherits SynchroniseIdBobject

    'Private m_linkedEdition As Edition
    'Private m_linkedGoody As Goody

    Dim serviceEdition As New ServiceEdition
    Dim serviceGoody As New ServiceGoody

    'Public Overrides Function Synchronise(phoneExplorer As BDList_TOOLS.IO.PhoneExplorer, forceCleanPhone As Boolean) As SynchroniseResults

    '    Dim result As New SyncIdBoResults

    '    Dim lastSyncDate As DateTime = GetLastSyncDate()

    '    Dim editionsList As List(Of IdBObject) = serviceEdition.GetWithAutograph
    '    Dim goodiesList As List(Of IdBObject) = serviceGoody.GetWithAutograph

    '    Dim serviceAutograph As ServiceAutograph = GetLocalService()

    '    Dim servicePhoneAutograph As ServicePhoneAutograph = GetPhoneService()
    '    Dim phoneAutographsList As New List(Of IdBObject)
    '    Dim phoneAutograph As PhoneAutograph

    '    Dim localFile As IFile

    '    Dim phoneAutographsFolder As IDirectory = Factory.GetDirectory(PHONE_AUTOGRAPHS_FOLDER)

    '    Dim phoneFile As IFile
    '    Dim phoneFilesList As List(Of IFile)

    '    If Not phoneAutographsFolder.IsExists() Then
    '        phoneAutographsFolder.Create()
    '        phoneFilesList = New List(Of IFile)
    '    Else
    '        phoneFilesList = phoneAutographsFolder.GetFiles
    '    End If

    '    Dim localPhoneAutographsFolder As IDirectory = Factory.GetDirectory(LOCAL_PHONE_AUTOGRAPHS_FOLDER)
    '    If localPhoneAutographsFolder.IsExists Then
    '        localPhoneAutographsFolder.Remove()
    '    End If
    '    localPhoneAutographsFolder.Create()

    '    phoneExplorer.BeginTransaction()

    '    'm_linkedEdition = Nothing
    '    'm_linkedGoody = Nothing

    '    For Each edition As Edition In editionsList

    '        'm_linkedEdition = edition

    '        For Each autograph As Autograph In edition.GetAutographs

    '            phoneAutograph = servicePhoneAutograph.GetNew(autograph.GetId)
    '            LocalItemToPhoneItem(autograph, phoneAutograph)
    '            phoneAutographsList.Add(phoneAutograph)
    '            result.AddPhoneUpdatedItem(phoneAutograph.GetType, phoneAutograph)

    '            With serviceAutograph.GetFiles(autograph)
    '                If .Count > 0 Then

    '                    localFile = .Item(0)
    '                    phoneFile = Factory.GetFile(PHONE_AUTOGRAPHS_FOLDER & Format(autograph.GetId, "000000") & ".jpg")

    '                    If Not localFile.IsExists Then
    '                        If phoneFilesList.Exists(Function(p) p.GetFullName = phoneFile.GetFullName) Then
    '                            result.AddAction(New SynchroniseAction(SynchroniseAction.ActionTypes.RemoveFile, phoneFile.GetFullName))
    '                            phoneFile.Remove()
    '                        End If

    '                    ElseIf localFile.GetLastWriteTime > lastSyncDate Then
    '                        result.AddAction(New SynchroniseAction(SynchroniseAction.ActionTypes.CreateOrUpdateFile, phoneFile.GetFullName))
    '                        phoneFile.Remove()
    '                        GetResizedLocalFile(localFile.GetFullName, Path.Combine(LOCAL_PHONE_AUTOGRAPHS_FOLDER, phoneFile.GetName))

    '                    ElseIf Not phoneFilesList.Exists(Function(p) p.GetFullName = phoneFile.GetFullName) Then
    '                        result.AddAction(New SynchroniseAction(SynchroniseAction.ActionTypes.CreateOrUpdateFile, phoneFile.GetFullName))
    '                        GetResizedLocalFile(localFile.GetFullName, Path.Combine(LOCAL_PHONE_AUTOGRAPHS_FOLDER, phoneFile.GetName))

    '                    End If

    '                End If
    '            End With
    '        Next
    '    Next

    '    'm_linkedEdition = Nothing
    '    'm_linkedGoody = Nothing

    '    For Each goody As Goody In goodiesList

    '        'm_linkedGoody = goody

    '        For Each autograph As Autograph In goody.GetAutographs

    '            phoneAutograph = servicePhoneAutograph.GetNew(autograph.GetId)
    '            LocalItemToPhoneItem(autograph, phoneAutograph)
    '            phoneAutographsList.Add(phoneAutograph)
    '            result.AddPhoneUpdatedItem(phoneAutograph.GetType, phoneAutograph)

    '            With serviceAutograph.GetFiles(autograph)
    '                If .Count > 0 Then

    '                    localFile = .Item(0)
    '                    phoneFile = Factory.GetFile(PHONE_AUTOGRAPHS_FOLDER & Format(autograph.GetId, "000000") & ".jpg")

    '                    If Not localFile.IsExists Then
    '                        If phoneFilesList.Exists(Function(p) p.GetFullName = phoneFile.GetFullName) Then
    '                            result.AddAction(New SynchroniseAction(SynchroniseAction.ActionTypes.RemoveFile, phoneFile.GetFullName))
    '                            phoneFile.Remove()
    '                        End If

    '                    ElseIf localFile.GetLastWriteTime > lastSyncDate Then
    '                        result.AddAction(New SynchroniseAction(SynchroniseAction.ActionTypes.CreateOrUpdateFile, phoneFile.GetFullName))
    '                        phoneFile.Remove()
    '                        GetResizedLocalFile(localFile.GetFullName, Path.Combine(LOCAL_PHONE_AUTOGRAPHS_FOLDER, phoneFile.GetName))

    '                    ElseIf Not phoneFilesList.Exists(Function(p) p.GetFullName = phoneFile.GetFullName) Then
    '                        result.AddAction(New SynchroniseAction(SynchroniseAction.ActionTypes.CreateOrUpdateFile, phoneFile.GetFullName))
    '                        GetResizedLocalFile(localFile.GetFullName, Path.Combine(LOCAL_PHONE_AUTOGRAPHS_FOLDER, phoneFile.GetName))

    '                    End If

    '                End If
    '            End With
    '        Next
    '    Next

    '    phoneExplorer.SendDirectory(localPhoneAutographsFolder, phoneAutographsFolder)
    '    phoneExplorer.PlayTransaction()

    '    servicePhoneAutograph.DeleteAll()
    '    servicePhoneAutograph.InsertOrUpdateRange(phoneAutographsList)

    '    Return result

    'End Function

    Protected Overrides Function AllowSynchronisePictures() As Boolean
        Return True
    End Function

    Protected Overrides Function GetItemsName() As String
        Return "autographes"
    End Function

    Protected Overrides Function GetLocalPhoneParentDirPath() As String
        Return LOCAL_PHONE_AUTOGRAPHS_FOLDER
    End Function

    Protected Overrides Function GetLocalService() As BDList_SERVICE.IService
        Return New ServiceAutograph
    End Function

    Protected Overrides Function GetPhoneParentDirPath() As String
        Return PHONE_AUTOGRAPHS_FOLDER
    End Function

    Protected Overrides Function GetPhoneService() As BDList_SERVICE.IService
        Return New ServicePhoneAutograph
    End Function

    Public Overrides Sub LocalItemToPhoneItem(localItem As BDList_DAO_BO.BO.IdBObject, phoneItem As BDList_DAO_BO.BO.IdBObject)

        Dim localAutograph As Autograph = CType(localItem, Autograph)
        Dim phoneAutograph As PhoneAutograph = CType(phoneItem, PhoneAutograph)

        'phoneAutograph.SetDate(New SqlDate(localAutograph.GetAutographDate))

        If localAutograph.GetAutographDate Is Nothing Then
            phoneAutograph.SetDate(Nothing)
        Else
            phoneAutograph.SetDate(New SqlDate(localAutograph.GetAutographDate))
        End If


        phoneAutograph.SetPlace(localAutograph.GetPlace)
        phoneAutograph.SetEvent(localAutograph.GetEvent)
        phoneAutograph.SetComments(localAutograph.GetComments)

        Dim linkedEdition As Edition = serviceEdition.GetByAutograph(localAutograph)
        Dim linkedGoody As Goody = serviceGoody.GetByAutograph(localAutograph)

        If linkedEdition IsNot Nothing Then
            phoneAutograph.SetIdEdition(linkedEdition.GetId)
        End If

        If linkedGoody IsNot Nothing Then
            phoneAutograph.SetIdGoody(linkedGoody.GetId)
        End If

        Dim idAuthor As Integer? = localAutograph.GetAuthor.GetId
        If idAuthor IsNot Nothing Then
            phoneAutograph.SetIdAuthor(idAuthor)
            phoneAutograph.SetIdAuthors(";" & idAuthor & ";")
        End If

    End Sub

    Protected Overrides Sub PhoneItemToLocalItem(phoneItem As BDList_DAO_BO.BO.IdBObject, localItem As BDList_DAO_BO.BO.IdBObject)

    End Sub

    Private Function GetResizedLocalFile(localFilePath As String, newLocalFilePath As String) As IFile

        Dim img As Image = ImageUtils.LoadImage(localFilePath)

        Dim newWidth As Integer = 360 '720
        Dim newHeight As Integer = 640 '1280

        Dim originalWidth As Integer = img.Width
        Dim originalHeight As Integer = img.Height

        Dim percentWidth As Single = CSng(newWidth) / CSng(originalWidth)
        Dim percentHeight As Single = CSng(newHeight) / CSng(originalHeight)

        Dim percent As Single = If(percentHeight < percentWidth, percentHeight, percentWidth)

        newWidth = CInt(originalWidth * percent)
        newHeight = CInt(originalHeight * percent)

        Dim newImg As Image = New Bitmap(newWidth, newHeight)

        Using gph As Graphics = Graphics.FromImage(newImg)
            gph.InterpolationMode = InterpolationMode.HighQualityBicubic
            gph.DrawImage(img, 0, 0, newWidth, newHeight)
            gph.Dispose()
        End Using

        newImg.Save(newLocalFilePath)

        img.Dispose()
        img = Nothing

        newImg.Dispose()
        img = Nothing

        Dim localFile As IFile = Factory.GetFile(newLocalFilePath)

        Return localFile

    End Function

End Class

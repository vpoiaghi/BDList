Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS.IO

Public Class ServiceAd
    Inherits Service(Of DaoAd)

    Public Function GetByPurchase(purchase As Purchase) As List(Of IdBObject)
        Return GetDao.GetByPurchase(purchase)
    End Function

    Public Overrides Function GetFile(bo As IdBObject, Optional fileIndex As Integer? = 1) As IFile

        Dim fInfo As IFile = Nothing

        If bo IsNot Nothing Then

            Dim ad As Ad = CType(bo, Ad)
            Dim dInfo As IDirectory = Factory.GetDirectory(PURCHASES_FOLDER_PATH)
            Dim fileName As String = Format(ad.GetId, "000000") & "_" & Format(fileIndex, "00") & ".jpg"

            With dInfo.GetFiles(fileName)
                If .Count > 0 Then
                    fInfo = Factory.GetFile(.ElementAt(0).GetFullName)
                Else
                    fInfo = Factory.GetFile(dInfo.GetFullName & "\" & fileName)
                End If
            End With

        End If

        Return fInfo

    End Function

    Public Overrides Sub InsertOrUpdate(ad As IdBObject)

        Dim serviceAdArticle As New ServiceAdArticle
        For Each adArticle As AdArticle In CType(ad, Ad).GetAdArticles
            serviceAdArticle.InsertOrUpdate(adArticle)
        Next

        MyBase.InsertOrUpdate(ad)

    End Sub

End Class

Imports BDList_TOOLS.IO
Imports System.IO
Imports System.Drawing.Imaging

Public Class ImageUtils

    Public Shared Function LoadImage(p_imageFilePath As String) As Image

        If p_imageFilePath Is Nothing Then
            Return Nothing
        Else
            Return LoadImage(Factory.GetFile(p_imageFilePath))
        End If

    End Function

    Public Shared Function LoadImage(p_imageFile As IFile) As Image

        Dim img As Image = Nothing

        If (p_imageFile IsNot Nothing) AndAlso (p_imageFile.IsExists) Then
            Dim fs As New FileStream(p_imageFile.GetFullName, FileMode.Open, FileAccess.Read)
            img = System.Drawing.Image.FromStream(fs)

            fs.Close()
            fs.Dispose()
        End If

        Return img

    End Function

    Public Shared Function SaveImage(p_image As Image, p_imageFile As IFile) As Boolean

        Dim savedWithSuccess As Boolean = False

        Try

            Dim fileImage As New FileInfo(p_imageFile.GetFullName)
            Dim parentDir As DirectoryInfo = fileImage.Directory

            If Not parentDir.Exists Then
                parentDir.Create()
            End If

            Dim imgFormat As ImageFormat
            Select Case p_imageFile.GetExtension().ToLower
                Case ".png" : imgFormat = ImageFormat.Png
                Case ".jpg" : imgFormat = ImageFormat.Jpeg
                Case ".jpeg" : imgFormat = ImageFormat.Jpeg
                Case Else : imgFormat = ImageFormat.Jpeg
            End Select

            Dim b As New Bitmap(p_image)
            b.Save(p_imageFile.GetFullName, imgFormat)

            savedWithSuccess = True

        Catch ex As Exception
            Throw New Exception("Une erreur s'est prosuite lors de l'enregistrement de l'image " & vbCrLf & p_imageFile.GetFullName, ex)
        End Try

        Return savedWithSuccess

    End Function

    Public Shared Function LoadWebImage(ByVal p_imageUrl As String) As Image

        Dim WebClient As New System.Net.WebClient
        Dim imageToAdd As Image = Nothing

        Try
            Dim WebResponse As System.IO.Stream
            Dim FichierDistant As String = p_imageUrl.Replace("&amp;", "&")
            WebResponse = WebClient.OpenRead(FichierDistant)
            imageToAdd = Image.FromStream(WebResponse)

            WebClient.Dispose()
            WebClient = Nothing

            WebResponse.Close()
            WebResponse = Nothing

        Catch ex As Exception
            WebClient.Dispose()
            WebClient = Nothing
        End Try

        Return imageToAdd

    End Function

    Public Shared Function DeleteImage(p_imageFile As IFile) As Boolean

        Dim deletedWithSuccess As Boolean = False

        Try

            If (p_imageFile IsNot Nothing) AndAlso (p_imageFile.IsExists) Then
                File.Delete(p_imageFile.GetFullName)
            End If

            deletedWithSuccess = True

        Catch ex As Exception
            Throw New Exception("Une erreur s'est prosuite lors de la suppression de l'image " & vbCrLf & p_imageFile.GetFullName, ex)
        End Try

        Return deletedWithSuccess


    End Function

End Class

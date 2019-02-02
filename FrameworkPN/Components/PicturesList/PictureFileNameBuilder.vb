Imports BDList_TOOLS.IO

Public Class PictureFileNameBuilder

    Protected Sub New()
    End Sub

    Friend Shared Function GetInstance() As PictureFileNameBuilder
        Return New PictureFileNameBuilder
    End Function

    Public Overridable Function GetFile() As IFile

        Dim result As IFile = Nothing

        Dim fileDialog As New SaveFileDialog
        fileDialog.InitialDirectory = Application.ExecutablePath
        fileDialog.Filter = "Fichier JPEG (*.jpg)|*.jpg"

        If fileDialog.ShowDialog = DialogResult.OK Then
            result = Factory.GetFile(fileDialog.FileName)
        End If

        Return result

    End Function

End Class

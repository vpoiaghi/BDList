Imports BDList_TOOLS.IO

Friend Class PctItem

    Private m_file As iFile
    Private m_image As Image
    Private m_saved As Boolean

    Public Sub New(p_file As IFile)

        m_file = p_file
        m_saved = False

        If (m_file IsNot Nothing) AndAlso (m_file.IsExists) Then

            Try
                m_image = ImageUtils.LoadImage(m_file)
                m_saved = True
            Catch ex As Exception
                m_image = Nothing
            End Try

        Else
            m_image = Nothing
        End If

    End Sub

    Public Sub New(p_file As IFile, p_image As Image)

        m_file = p_file
        m_image = p_image
        m_saved = False

    End Sub

    Public Function GetFile() As IFile
        Return m_file
    End Function

    Public Function GetImage() As Image
        Return m_image
    End Function

    Public Sub SetImage(image As Image)
        m_image = image
        m_saved = False
    End Sub

    Public Function IsSaved() As Boolean
        Return m_saved
    End Function

    Public Sub Save()

        If (Not IsSaved()) _
        AndAlso (m_file IsNot Nothing) _
        AndAlso (m_image IsNot Nothing) _
        Then

            Try
                ImageUtils.SaveImage(m_image, m_file)
            Catch ex As Exception
                MsgBox("Une erreur est survenue lors de la tentative d'enregistrement de l'image." _
                       & vbCrLf & ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Enregistreement...")
            End Try

        End If

    End Sub

End Class

Imports FrameworkPN
Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO

Public Class GridItem_Author

    Private m_authors As List(Of Author) = Nothing
    Private m_firstImage As Image
    Private m_author As Author

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Overrides Sub Redraw()

        Dim svcAuthor As New ServiceAuthor
        m_author = CType(m_value, Author)

        With m_author
            lbl_authorName.Text = .ToString
            lbl_id.Text = "(" & .GetId.Value & ")"
            ToolTip1.SetToolTip(lbl_authorName, .ToString)
        End With

        RedrawPictures(svcAuthor.GetFile(m_author))

    End Sub

    Private Sub RedrawPictures(file As IFile)

        m_firstImage = ImageUtils.LoadImage(file)

        If m_firstImage Is Nothing Then
            pct_firstImage.Image = My.Resources.nobody
        Else
            pct_firstImage.Image = m_firstImage
        End If

    End Sub

    Public Overrides Sub ModifyItem()

        Dim author As Author = CType(m_value, Author)

        Dim modifiedAuthor As ModifiedItem = FrmWriteAuthor.CreateOrEdit(Me.ParentForm, author)

        If modifiedAuthor IsNot Nothing Then

            m_value = modifiedAuthor.GetItem
            Redraw()

            Dim eventArgs As New GridItemActionEventArgs(GridItemActionEventArgs.listItemActions.Modify)
            eventArgs.AddParameter(NavParameters.PRM_AUTHOR_ID, CType(m_value, Author).GetId)

            SendActionEvent(eventArgs)

        End If

    End Sub

    Public Overrides Sub ShowItem()

        Dim author As Author = CType(m_value, Author)

        FrmPagesManager.SetParameter(NavParameters.PRM_AUTHOR_ID, m_author.GetId)
        FrmPagesManager.ShowPage(GetType(UC_Author).FullName)

    End Sub

    Private Sub pct_firstImage_MouseDown(sender As Object, e As MouseEventArgs) Handles pct_firstImage.MouseDown
        If e.Button = MouseButtons.Right Then
            FrmShowImage.ShowImage(CType(sender, PictureBox).Image)
        End If
    End Sub

End Class

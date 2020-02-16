Imports FrameworkPN
Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO

Public Class GridItem_Edition

    Private Shared m_svcEdition As New ServiceEdition

    Private m_series As List(Of Serie) = Nothing
    Private m_coverImage As Image

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Overrides Sub Redraw()

        Dim edition As Edition = CType(m_value, Edition)

        If edition IsNot Nothing Then
            With edition

                Dim maxLblSize As New Size(Panel2.Width, 0)
                lbl_serieName.MaximumSize = maxLblSize
                lbl_editionName.MaximumSize = maxLblSize
                lbl_comments.MaximumSize = maxLblSize

                lbl_serieName.Text = GetSeriesNames(edition)
                lbl_editionName.Text = .ToString
                RefreshLabel(lbl_editionNumber, .GetEditionNumber & " " & .GetSpecialEdition & " (" & .GetId.ToString & ")", "Ed. n° ")
                RefreshLabel(lbl_cycle, Nothing, "Cycle : ")
                RefreshLabel(lbl_comments, .GetComments)
                RefreshLabel(lbl_editor, .GetEditor, "Editeur")
                RefreshLabel(lbl_collection, .GetCollection, "Collection")


                Dim versionNumber As Integer? = .GetVersionNumber
                If versionNumber Is Nothing Then
                    pct_firstEdition.Visible = False
                Else
                    pct_firstEdition.Visible = (versionNumber = 1)
                End If

                pct_withAutograph.Visible = (.GetAutographs.Count > 0)
                pct_withAutograph.BringToFront()

                RefreshParutionDate(edition)
                RefreshPurchaseDate(edition)

                pct_inPossession.Image = PossessionStatesUtils.GetImage(.GetPossessionState().GetId)

                Dim firstCoverFile As IFile = m_svcEdition.GetFirstCoverFile(edition, True)
                If firstCoverFile Is Nothing Then
                    pct_cover.Image = Nothing
                Else
                    m_coverImage = ImageUtils.LoadImage(firstCoverFile)
                    pct_cover.Image = m_coverImage
                End If

                Dim fourthCoverFile As IFile = m_svcEdition.GetFourthCoverFile(edition, True)
                If fourthCoverFile Is Nothing Then
                    pct_minFourthCover.Image = Nothing
                    pct_minFourthCover.Visible = False
                Else
                    pct_minFourthCover.Image = ImageUtils.LoadImage(fourthCoverFile.GetFullName)
                    pct_minFourthCover.Visible = True
                End If

                Dim boardsFiles As List(Of IFile) = m_svcEdition.GetBoardsFiles(edition)
                If boardsFiles.Count = 0 Then
                    pct_minBoard.Image = Nothing
                    pct_minBoard.Visible = False

                Else
                    pct_minBoard.Image = ImageUtils.LoadImage(boardsFiles(0).GetFullName)
                    pct_minBoard.Visible = True
                End If

            End With
        End If

    End Sub

    Private Sub RefreshParutionDate(edition As Edition)

        Dim parutionDate As Date? = edition.GetParutionDate
        If parutionDate Is Nothing Then
            lbl_parutionDate.Text = ""
            lbl_parutionDate.BackColor = Color.Transparent
        Else
            lbl_parutionDate.Text = "Parution : " & Format(parutionDate, "dd/MM/yyyy")

            If parutionDate >= Today Then
                lbl_parutionDate.BackColor = Color.Yellow
            Else
                lbl_parutionDate.BackColor = Color.Transparent
            End If

        End If

    End Sub

    Private Sub RefreshPurchaseDate(edition As Edition)

        Dim purchaseDate As Date? = edition.GetBoughtDate
        If purchaseDate Is Nothing Then
            lbl_purchaseDate.Text = ""
        Else
            lbl_purchaseDate.Text = "Achat : " & Format(purchaseDate, "dd/MM/yyyy")
        End If

    End Sub

    Private Sub RefreshLabel(lbl As Label, value As Object)
        RefreshLabel(lbl, value, "")
    End Sub

    Private Sub RefreshLabel(lbl As Label, value As String)
        RefreshLabel(lbl, value, "")
    End Sub

    Private Function GetSeriesNames(edition As Edition) As String

        Dim series As List(Of IdBObject) = edition.GetSeries
        Dim seriesNames As String = ""

        m_series = New List(Of Serie)

        For Each s As Serie In series
            seriesNames &= " / " & s.ToString
            m_series.Add(s)
        Next

        If series.Count > 0 Then
            seriesNames = seriesNames.Substring(3)
        End If

        Return seriesNames

    End Function

    Private Sub RefreshLabel(lbl As Label, value As Object, prefix As String)

        Dim strValue As String = ""

        If value IsNot Nothing Then
            strValue = value.ToString
        End If

        RefreshLabel(lbl, strValue, prefix)

    End Sub

    Private Sub RefreshLabel(lbl As Label, value As String, prefix As String)

        If String.IsNullOrEmpty(value) Then
            lbl.Visible = False

        Else
            If Not String.IsNullOrEmpty(prefix) Then
                prefix &= " : "
            End If

            lbl.Text = prefix & value
            lbl.Visible = True
        End If

    End Sub

    Private Sub pct_minBack_MouseEnter(sender As Object, e As EventArgs) Handles pct_minFourthCover.MouseEnter
        If pct_minFourthCover.Image IsNot Nothing Then
            pct_cover.Image = pct_minFourthCover.Image
        End If
    End Sub

    Private Sub pct_minBack_MouseLeave(sender As Object, e As EventArgs) Handles pct_minFourthCover.MouseLeave
        If pct_minFourthCover.Image IsNot Nothing Then
            pct_cover.Image = m_coverImage
        End If
    End Sub

    Private Sub pct_minBoard_MouseEnter(sender As Object, e As EventArgs) Handles pct_minBoard.MouseEnter
        If pct_minBoard.Image IsNot Nothing Then
            pct_cover.Image = pct_minBoard.Image
        End If
    End Sub

    Private Sub pct_minBoard_MouseLeave(sender As Object, e As EventArgs) Handles pct_minBoard.MouseLeave
        If pct_minBoard.Image IsNot Nothing Then
            pct_cover.Image = m_coverImage
        End If
    End Sub

    Private Sub UC_ListItem_Edition_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Redraw()
    End Sub

    Public Overrides Sub ModifyItem()

        Dim edition As Edition = CType(m_value, Edition)
        Dim serie As Serie = CType(edition.GetSeries(0), Serie)

        Dim modifiedEdition As ModifiedItem = FrmWriteEdition.CreateOrEdit(Me.ParentForm, edition, serie)

        If modifiedEdition IsNot Nothing Then

            m_value = modifiedEdition.GetItem
            Redraw()

            Dim eventArgs As New GridItemActionEventArgs(GridItemActionEventArgs.listItemActions.Modify)
            eventArgs.AddParameter(NavParameters.PRM_EDITION_ID, CType(m_value, Edition).GetId)

            SendActionEvent(eventArgs)

        End If

    End Sub

    Public Overrides Sub DeleteItem()

        Dim edition As Edition = CType(m_value, Edition)
        Dim editionId As Long? = CType(m_value, Edition).GetId

        m_svcedition.Delete(edition)

        Dim eventArgs As New GridItemActionEventArgs(GridItemActionEventArgs.listItemActions.Delete)
        eventArgs.AddParameter(NavParameters.PRM_EDITION_ID, editionId)

        SendActionEvent(eventArgs)

    End Sub

    Public Overrides Sub ShowItem()

        Dim eventArgs As New GridItemActionEventArgs(GridItemActionEventArgs.listItemActions.Show)
        eventArgs.AddParameter(NavParameters.PRM_EDITION_ID, CType(m_value, Edition).GetId)

        SendActionEvent(eventArgs)

    End Sub


    Private Sub pct_minFourthCover_MouseDown(sender As Object, e As MouseEventArgs) Handles pct_minFourthCover.MouseDown
        If e.Button = MouseButtons.Right Then
            FrmShowImage.ShowImage(CType(sender, PictureBox).Image)
        End If
    End Sub

    Private Sub pct_minBoard_MouseDown(sender As Object, e As MouseEventArgs) Handles pct_minBoard.MouseDown
        If e.Button = MouseButtons.Right Then
            FrmShowImage.ShowImage(CType(sender, PictureBox).Image)
        End If
    End Sub

    Private Sub pct_cover_MouseDown(sender As Object, e As MouseEventArgs) Handles pct_cover.MouseDown
        If e.Button = MouseButtons.Right Then
            FrmShowImage.ShowImage(CType(sender, PictureBox).Image)
        End If
    End Sub

    Private Sub lbl_serieName_MouseUp(sender As Object, e As MouseEventArgs) Handles lbl_serieName.MouseUp

        If (Me.IsSelected) AndAlso (e.Button = MouseButtons.Left) Then

            Dim serie As Serie = Nothing

            If m_series.Count = 1 Then
                serie = m_series(0)
            Else
                Dim str As String = ""
                Dim g As Graphics = lbl_serieName.CreateGraphics
                Dim measure As SizeF

                For Each s As Serie In m_series

                    str &= s.ToString
                    measure = g.MeasureString(str, lbl_serieName.Font)

                    If (e.X <= measure.Width) Then
                        serie = s
                        Exit For
                    Else
                        str &= " / "
                    End If
                Next
            End If

            FrmPagesManager.SetParameter(NavParameters.PRM_SERIE_ID, serie.GetId)
            FrmPagesManager.ShowPage(GetType(UC_Serie).FullName)

        End If

    End Sub

End Class

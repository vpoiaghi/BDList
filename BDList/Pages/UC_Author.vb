Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class UC_Author

    Private svcAuthors As New ServiceAuthor
    Private svcSeries As New ServiceSerie
    Private svcEditions As New ServiceEdition
    Private svcGoodies As New ServiceGoody

    Private m_seriesList As List(Of IdBObject)
    Private m_editionsList As List(Of IdBObject)
    Private m_goodiesList As List(Of IdBObject)

    Private m_author As Author

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()

        grd_seriesList.Dock = DockStyle.Fill
        grd_editionsList.Dock = DockStyle.Fill
        grd_goodiesList.Dock = DockStyle.Fill
        pnl_authorInfos.Dock = DockStyle.Fill

    End Sub

    Protected Overrides Sub Activate()
        m_author = GetAuthor()
        RefreshAuthor()
        SetListsAndButtonsState(btn_author)
    End Sub

    Private Function GetAuthor() As Author

        Dim author As Author = Nothing
        Dim authorId As Long? = GetParameter(NavParameters.PRM_AUTHOR_ID)

        If authorId IsNot Nothing Then
            author = svcAuthors.GetById(authorId)
        End If

        Return author

    End Function

    Private Sub RefreshAuthor()
        RefreshAuthorinfos()
        RefreshSeriesList()
    End Sub

    Private Sub RefreshAuthorinfos()

        DrawHeader()
        DrawPicture()

        lbl_realName.Text = BuildRealName()

    End Sub


    Private Sub DrawPicture()
        Dim file As IFile = svcAuthors.GetFile(m_author)
        pct_author.BackColor = Color.Black
        pct_author.Image = ImageUtils.LoadImage(file)
    End Sub

    Public Sub DrawHeader()

        Dim f As New Font("Microsoft Sans Serif", 13)
        Dim x As Integer = 3
        Dim y As Integer = 10
        Dim authorName As String = m_author.ToString

        Dim img As Image = Nothing
        Dim g As Graphics

        Dim b As New Bitmap(pnl_authorHeader.Width, pnl_authorHeader.Height)
        b.SetResolution(300, 300)
        img = b
        b = Nothing
        g = Graphics.FromImage(img)
        g.Clear(pnl_authorHeader.BackColor)


        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit

        'g.DrawImage(img, 0, 0, 1700, 310)
        g.DrawString(authorName, f, New SolidBrush(Color.FromArgb(255, 60, 60, 60)), x - 1, y - 1)
        g.DrawString(authorName, f, New SolidBrush(Color.FromArgb(255, 255, 255, 255)), x + 1, y + 1)
        g.DrawString(authorName, f, New SolidBrush(Color.FromArgb(255, 30, 30, 30)), x, y)

        pnl_authorHeader.BackgroundImage = img

        img = Nothing

        g.Dispose()
        g = Nothing

    End Sub

    Private Sub RefreshSeriesList()

        Dim searchCriteria As New SearchCriteria()
        searchCriteria.authorId = m_author.GetId

        If searchCriteria IsNot Nothing Then

            m_seriesList = svcSeries.GetSeriesByAuthorName(m_author)

            Dim adapter As IAdapter = New SeriesAdapter(m_seriesList)
            grd_seriesList.SetAdapter(adapter)

            Dim itemSelected As Boolean = (grd_seriesList.SelectedItem IsNot Nothing)
        End If

    End Sub

    Private Sub RefreshEditionsList()

        Dim searchCriteria As New SearchCriteria()
        searchCriteria.authorId = m_author.GetId

        If searchCriteria IsNot Nothing Then

            m_editionsList = svcEditions.Search(searchCriteria)

            Dim adapter As IAdapter = New EditionsAdapter(m_editionsList)
            grd_editionsList.SetAdapter(adapter)

            Dim itemSelected As Boolean = (grd_editionsList.SelectedItem IsNot Nothing)
        End If

    End Sub

    Private Sub RefreshGoodiesList()

        Dim searchCriteria As New SearchCriteria()
        searchCriteria.authorId = m_author.GetId

        If searchCriteria IsNot Nothing Then

            m_goodiesList = svcGoodies.Search(searchCriteria)

            Dim adapter As IAdapter = New GoodiesAdapter(m_goodiesList)
            grd_goodiesList.SetAdapter(adapter)

            Dim itemSelected As Boolean = (grd_goodiesList.SelectedItem IsNot Nothing)
        End If

    End Sub

    Private Sub btn_author_Click(sender As Object, e As EventArgs) Handles btn_author.Click
        SetListsAndButtonsState(sender)
    End Sub

    Private Sub btn_series_Click(sender As Object, e As EventArgs) Handles btn_series.Click
        RefreshSeriesList()
        SetListsAndButtonsState(sender)
    End Sub

    Private Sub btn_editions_Click(sender As Object, e As EventArgs) Handles btn_editions.Click
        RefreshEditionsList()
        SetListsAndButtonsState(sender)
    End Sub

    Private Sub btn_goodies_Click(sender As Object, e As EventArgs) Handles btn_goodies.Click
        RefreshGoodiesList()
        SetListsAndButtonsState(sender)
    End Sub

    Private Sub SetListsAndButtonsState(sender As Object)

        Dim showAuthor As Boolean = (btn_author Is sender)
        Dim showSeries As Boolean = (btn_series Is sender)
        Dim showEditions As Boolean = (btn_editions Is sender)
        Dim showGoodies As Boolean = (btn_goodies Is sender)

        btn_author.Enabled = Not showAuthor
        pnl_authorInfos.Visible = showAuthor

        btn_series.Enabled = Not showSeries
        grd_seriesList.Visible = showSeries

        btn_editions.Enabled = Not showEditions
        grd_editionsList.Visible = showEditions

        btn_goodies.Enabled = Not showGoodies
        grd_goodiesList.Visible = showGoodies

        btn_edit.Visible = Not showSeries
        btn_edit.Enabled = showAuthor OrElse (showEditions AndAlso grd_editionsList.SelectedItem IsNot Nothing) OrElse (showGoodies AndAlso grd_goodiesList.SelectedItem IsNot Nothing)

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If pnl_authorInfos.Visible Then
            FrmWriteAuthor.CreateOrEdit(Me.ParentForm, m_author)
            RefreshAuthorinfos()
        ElseIf grd_editionsList.Visible Then
            grd_editionsList.SelectedItem.ModifyItem()
        ElseIf grd_goodiesList.Visible Then
            grd_goodiesList.SelectedItem.ModifyItem()
        End If

    End Sub

    Private Function BuildRealName() As String

        Dim result As String = ""
        Dim realNames As New List(Of String)

        For Each p As Person In m_author.GetPersons
            realNames.Add((p.GetFirstname() & " " & p.GetLastname()).Trim())
        Next

        If realNames.Count > 0 Then
            result = realNames(0)
        End If

        If realNames.Count > 1 Then

            For i = 1 To realNames.Count - 2
                result &= ", " & realNames(i)
            Next

            result &= " et " & realNames(realNames.Count - 1)

        End If

        Return result

    End Function

    Private Sub grd_seriesList_ItemSelectionChanged(Sender As Object, e As GridItemSelectedEventArgs) Handles grd_seriesList.ItemSelectionChanged

        Dim serie As Serie = CType(e.GetValue, Serie)

        If serie IsNot Nothing Then
            SetParameter(NavParameters.PRM_SERIE_ID, serie.GetId)
            ShowPage(GetType(UC_Serie).FullName)
        End If

    End Sub

    Private Sub grd_editionsList_ItemSelectionChanged(Sender As Object, e As GridItemSelectedEventArgs) Handles grd_editionsList.ItemSelectionChanged
        If (grd_editionsList.Visible) Then
            btn_edit.Enabled = (grd_editionsList.SelectedItem IsNot Nothing)
        End If
    End Sub

    Private Sub grd_goodiesList_ItemSelectionChanged(Sender As Object, e As GridItemSelectedEventArgs) Handles grd_goodiesList.ItemSelectionChanged
        If (grd_goodiesList.Visible) Then
            btn_edit.Enabled = (grd_goodiesList.SelectedItem IsNot Nothing)
        End If
    End Sub

End Class

Imports FrameworkPN
Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO

Public Class UC_Serie

    Private Enum Screens
        Serie
        Editions
        Goodies
    End Enum

    Private svcEditions As New ServiceEdition
    Private svcTitles As New ServiceTitle
    Private svcGoodies As New ServiceGoody

    Private m_editionsList As List(Of IdBObject)
    Private m_goodiesList As List(Of IdBObject)

    Private m_kindOfGoodyFlterList As List(Of KindOfGoody)

    Private m_serie As Serie
    Private m_currentScreen As Screens = Screens.Serie

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()

        m_kindOfGoodyFlterList = New List(Of KindOfGoody)

    End Sub

    Protected Overrides Sub Activate()

        m_serie = GetSerie()

        pnl_serieInfos.Dock = DockStyle.Fill
        lst_editions.Dock = DockStyle.Fill
        lst_goodies.Dock = DockStyle.Fill

        RefreshSerie()

        ShowSerieInfos()

        Dim editionId As Long? = GetParameter(NavParameters.PRM_EDITION_ID)
        GetParameter(NavParameters.PRM_EDITION_ID)
        If editionId IsNot Nothing Then
            ShowEditions()
        End If

        Dim goodyId As Long? = GetParameter(NavParameters.PRM_GOODY_ID)
        If goodyId IsNot Nothing Then
            showGoodies()
        End If

    End Sub

    Private Sub RefreshSerie()

        If m_serie IsNot Nothing Then

            With m_serie

                Dim idSerie As Long? = .GetId

                Dim kind As Kind = .GetKind
                If kind Is Nothing Then
                    lbl_kind.Text = "Genre :"
                Else
                    lbl_kind.Text = "Genre : " & kind.ToString
                End If

                Dim origin As Origin = .GetOrigin
                If origin Is Nothing Then
                    lbl_origin.Text = "Origine :"
                Else
                    lbl_origin.Text = "Origine : " & origin.ToString
                End If

                Select Case .IsEnded
                    Case BoSerie.STATE_FINISHED : lbl_ended.Text = "Statut : Terminée"
                    Case BoSerie.STATE_ABORTED : lbl_ended.Text = "Statut : Abandonnée"
                    Case BoSerie.STATE_ONGOING : lbl_ended.Text = "Statut : En cours"
                End Select

                lbl_story.Text = .GetStory

                RefreshEditions()
                RefreshGoodies()
                UpdateSerieStats()

                DrawHeader()

            End With

        End If

    End Sub

    Private Sub RefreshEditions()

        m_editionsList = svcEditions.GetAllBySerie(m_serie)
        Dim adapterEditions As IAdapter = New EditionsAdapter(m_editionsList)
        lst_editions.SetAdapter(adapterEditions)

    End Sub

    Private Sub RefreshGoodies()

        m_goodiesList = svcGoodies.GetAllBySerie(m_serie)
        Dim adapterGoodies As IAdapter = New GoodiesAdapter(m_goodiesList)
        lst_goodies.SetAdapter(adapterGoodies)

    End Sub

    Public Sub DrawHeader()

        Dim f As New Font("Microsoft Sans Serif", 13)
        Dim x As Integer = 3
        Dim y As Integer = 10
        Dim serieName As String = m_serie.GetName

        Dim img As Image = Nothing
        Dim g As Graphics

        Dim bandeauFile As IFile = DirNameGenerator.GetBandeauDir(m_serie)

        If bandeauFile IsNot Nothing Then
            img = ImageUtils.LoadImage(bandeauFile.GetFullName())
            g = Graphics.FromImage(img)
        Else
            Dim b As New Bitmap(pnl_serieHeader.Width, pnl_serieHeader.Height)
            b.SetResolution(300, 300)
            img = b
            b = Nothing
            g = Graphics.FromImage(img)
            g.Clear(pnl_serieHeader.BackColor)
        End If

        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit

        'g.DrawImage(img, 0, 0, 1700, 310)
        g.DrawString(serieName, f, New SolidBrush(Color.FromArgb(255, 60, 60, 60)), x - 1, y - 1)
        g.DrawString(serieName, f, New SolidBrush(Color.FromArgb(255, 255, 255, 255)), x + 1, y + 1)
        g.DrawString(serieName, f, New SolidBrush(Color.FromArgb(255, 30, 30, 30)), x, y)

        pnl_serieHeader.BackgroundImage = img

        img = Nothing

        g.Dispose()
        g = Nothing

    End Sub

    Private Sub UpdateSerieStats()

        Dim idSerie As Long? = m_serie.GetId

        btn_editions.Text = m_editionsList.Count & " éditions"
        btn_goodies.Text = m_goodiesList.Count & " para-bds"

        With svcEditions
            lbl_editions.Text = "Editions : " & .GetCountInPossessionBySerie(idSerie) & " / " & .GetCountBySerie(idSerie)
        End With

        With svcTitles
            lbl_titles.Text = "Titres : " & .GetCountInPosssessionBySerie(idSerie) & " / " & .GetCountBySerie(idSerie)
        End With

        With svcGoodies
            lbl_goodies.Text = "Para-bds : " & .GetCountInPossessionBySerie(idSerie) & " / " & .GetCountBySerie(idSerie)
        End With

    End Sub

    Private Function GetSerie() As Serie

        Dim serie As Serie = Nothing
        Dim serieId As Long? = GetParameter(NavParameters.PRM_SERIE_ID)

        If serieId IsNot Nothing Then

            Dim svcSerie As New ServiceSerie
            serie = svcSerie.GetById(serieId)

        End If

        Return serie

    End Function

    Private Sub ModifySerie()

        Dim modifiedSerie As Serie = FrmWriteSerie.CreateOrEdit(Me.ParentForm, m_serie)

        If modifiedSerie IsNot Nothing Then
            m_serie = modifiedSerie
            RefreshSerie()
        End If

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim gridItem As GridItem = Nothing

        Select Case m_currentScreen
            Case Screens.Editions : AddEdition()
            Case Screens.Goodies : AddGoody()
        End Select

        If gridItem IsNot Nothing Then
            gridItem.ModifyItem()
        End If

    End Sub

    Private Sub AddEdition()

        Dim newEdition As ModifiedItem = FrmWriteEdition.CreateOrEdit(Me.ParentForm, Nothing, m_serie)

        If newEdition IsNot Nothing Then

            Dim edition As Edition = newEdition.GetItem
            Dim editonIsInCurrentSerie As Boolean = False

            For Each s As Serie In edition.GetSeries
                If s.GetId = m_serie.GetId Then
                    editonIsInCurrentSerie = True
                End If
            Next

            If editonIsInCurrentSerie Then
                RefreshSerie()

            Else
                Dim msg As String = "La nouvelle édition à été enregistré dans une autre série." & vbCrLf & "Voulez-vous basculer sur cette série ?"

                If MsgBox(msg, vbYesNo + vbQuestion, "Edition d'une autre série...") = vbYes Then
                    SetParameter(NavParameters.PRM_SERIE_ID, edition.GetSeries(0).GetId)
                    ShowPage(GetType(UC_Serie).FullName)
                Else
                    RefreshSerie()
                End If

            End If

        End If

    End Sub

    Private Sub AddGoody()

        Dim newGoody As ModifiedItem = FrmWriteGoody.CreateOrEdit(Me.ParentForm, Nothing, m_serie)

        If newGoody IsNot Nothing Then

            Dim goody As Goody = newGoody.GetItem
            Dim goodyIsInCurrentSerie As Boolean = False

            For Each s As Serie In goody.GetSeries
                If s.GetId = m_serie.GetId Then
                    goodyIsInCurrentSerie = True
                End If
            Next

            If goodyIsInCurrentSerie Then
                RefreshSerie()

            Else
                Dim msg As String = "Le nouveau para-bd à été enregistré dans une autre série." & vbCrLf & "Voulez-vous basculer sur cette série ?"

                If MsgBox(msg, vbYesNo + vbQuestion, "Para-bd d'une autre série...") = vbYes Then
                    SetParameter(NavParameters.PRM_SERIE_ID, goody.GetSeries(0).GetId)
                    ShowPage(GetType(UC_Serie).FullName)
                Else
                    RefreshSerie()
                End If

            End If

        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim gridItem As GridItem = Nothing

        Select Case m_currentScreen
            Case Screens.Editions : DeleteEdition()
            Case Screens.Goodies : DeleteGoody()
        End Select

        If gridItem IsNot Nothing Then
            gridItem.ModifyItem()
        End If

    End Sub

    Private Sub DeleteEdition()

        If MsgBox("Voulez-vous supprimer cette édition ?", vbYesNo Or vbQuestion, "Suppression...") = MsgBoxResult.Yes Then

            Dim gridItem As GridItem = lst_editions.SelectedItem

            If gridItem IsNot Nothing Then
                gridItem.DeleteItem()
            End If

        End If

    End Sub

    Private Sub DeleteGoody()

        If MsgBox("Voulez-vous supprimer ce para-bd ?", vbYesNo Or vbQuestion, "Suppression...") = MsgBoxResult.Yes Then

            Dim gridItem As GridItem = lst_goodies.SelectedItem

            If gridItem IsNot Nothing Then
                gridItem.DeleteItem()
            End If

        End If

    End Sub

    Private Sub btn_serie_Click(sender As Object, e As EventArgs) Handles btn_serie.Click
        ShowSerieInfos()
    End Sub

    Private Sub btn_editions_Click(sender As Object, e As EventArgs) Handles btn_editions.Click
        ShowEditions()
    End Sub

    Private Sub btn_goodies_Click(sender As Object, e As EventArgs) Handles btn_goodies.Click
        showGoodies()
    End Sub

    Private Sub lst_editions_ListItemAction(Sender As Object, e As GridItemActionEventArgs) Handles lst_editions.ListItemAction

        Select Case e.GetAction
            Case GridItemActionEventArgs.listItemActions.Modify
            Case GridItemActionEventArgs.listItemActions.Delete : RefreshEditions()
        End Select

        UpdateSerieStats()

    End Sub

    Private Sub lst_goodies_ListItemAction(Sender As Object, e As GridItemActionEventArgs) Handles lst_goodies.ListItemAction

        Select Case e.GetAction
            Case GridItemActionEventArgs.listItemActions.Modify
            Case GridItemActionEventArgs.listItemActions.Delete : RefreshGoodies()
        End Select

        UpdateSerieStats()

    End Sub

    Private Sub ShowSerieInfos()

        m_currentScreen = Screens.Serie

        ' boutons "onglets"
        btn_serie.Enabled = False
        btn_goodies.Enabled = True
        btn_editions.Enabled = True

        ' zones
        pnl_serieInfos.Visible = True
        pnl_serieInfos.Focus()
        lst_editions.Visible = False
        lst_goodies.Visible = False

        ' visualisation des boutons d'action
        btn_add.Visible = False
        btn_show.Visible = False
        btn_copy.Visible = False
        btn_edit.Visible = True
        btn_delete.Visible = False

        ' activation des boutons d'action visibles
        btn_edit.Enabled = True

    End Sub

    Private Sub ShowEditions()

        m_currentScreen = Screens.Editions
        Dim itemSelected As Boolean = (lst_editions.SelectedItem IsNot Nothing)

        ' boutons "onglets"
        btn_serie.Enabled = True
        btn_editions.Enabled = False
        btn_goodies.Enabled = True

        ' zones
        lst_editions.Visible = True
        lst_editions.Focus()
        pnl_serieInfos.Visible = False
        lst_goodies.Visible = False

        ' visualisation des boutons d'action
        btn_add.Visible = True
        btn_show.Visible = True
        btn_copy.Visible = True
        btn_edit.Visible = True
        btn_delete.Visible = True

        ' activation des boutons d'action visibles
        btn_add.Enabled = True
        btn_show.Enabled = itemSelected
        btn_copy.Enabled = itemSelected
        btn_edit.Enabled = itemSelected
        btn_delete.Enabled = itemSelected

    End Sub

    Private Sub showGoodies()

        m_currentScreen = Screens.Goodies
        Dim itemSelected As Boolean = (lst_goodies.SelectedItem IsNot Nothing)

        ' boutons "onglets"
        btn_serie.Enabled = True
        btn_editions.Enabled = True
        btn_goodies.Enabled = False

        ' zones
        lst_goodies.Visible = True
        lst_goodies.Focus()
        pnl_serieInfos.Visible = False
        lst_editions.Visible = False

        ' visualisation des boutons d'action
        btn_add.Visible = True
        btn_show.Visible = True
        btn_copy.Visible = True
        btn_edit.Visible = True
        btn_delete.Visible = True

        ' activation des boutons d'action visibles
        btn_add.Enabled = True
        btn_show.Enabled = itemSelected
        btn_copy.Enabled = itemSelected
        btn_edit.Enabled = itemSelected
        btn_delete.Enabled = itemSelected

    End Sub

    Private Sub lbl_serieName_Paint(sender As Object, e As PaintEventArgs)

        With CType(sender, Label)

            Dim b As Brush = New SolidBrush(.ForeColor)

            e.Graphics.Clear(.Parent.BackColor)
            e.Graphics.DrawString(.Text, .Font, Brushes.White, 3, 3)
            e.Graphics.DrawString(.Text, .Font, b, 0, 0)
        End With



    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If m_currentScreen = Screens.Serie Then
            ModifySerie()
        Else

            Dim gridItem As GridItem = Nothing

            Select Case m_currentScreen
                Case Screens.Editions : gridItem = lst_editions.SelectedItem
                Case Screens.Goodies : gridItem = lst_goodies.SelectedItem
            End Select

            If gridItem IsNot Nothing Then
                gridItem.ModifyItem()
            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_show.Click

        If m_currentScreen = Screens.Serie Then
            ' Nothing to do
        Else

            Dim gridItem As GridItem = Nothing

            Select Case m_currentScreen
                Case Screens.Editions : gridItem = lst_editions.SelectedItem
                Case Screens.Goodies : gridItem = lst_goodies.SelectedItem
            End Select

            If gridItem IsNot Nothing Then
                gridItem.ShowItem()
            End If

        End If

    End Sub

    Private Sub btn_copy_Click(sender As Object, e As EventArgs) Handles btn_copy.Click

        Select Case m_currentScreen
            Case Screens.Editions : copyEdition()
            Case Screens.Goodies : CopyGoody()
        End Select


    End Sub

    Private Sub copyEdition()

        Dim gridItem As GridItem = lst_editions.SelectedItem

        If gridItem IsNot Nothing Then
            Dim edition As Edition = gridItem.GetValue

            Dim newEdition As ModifiedItem = FrmWriteEdition.Copy(Me.ParentForm, edition)

            If newEdition IsNot Nothing Then

                Dim editionIsInCurrentSerie As Boolean = False

                For Each s As Serie In edition.GetSeries
                    If s.GetId = m_serie.GetId Then
                        editionIsInCurrentSerie = True
                    End If
                Next

                If editionIsInCurrentSerie Then
                    RefreshSerie()

                Else
                    Dim msg As String = "La nouvelle édition a été enregistrée dans une autre série." & vbCrLf & "Voulez-vous basculer sur cette série ?"

                    If MsgBox(msg, vbYesNo + vbQuestion, "Edition d'une autre série...") = vbYes Then
                        SetParameter(NavParameters.PRM_SERIE_ID, edition.GetSeries(0).GetId)
                        ShowPage(GetType(UC_Serie).FullName)
                    Else
                        RefreshSerie()
                    End If

                End If

            End If
        End If

    End Sub

    Private Sub CopyGoody()

        Dim gridItem As GridItem = lst_goodies.SelectedItem

        If gridItem IsNot Nothing Then
            Dim goody As Goody = gridItem.GetValue

            Dim newGoody As ModifiedItem = FrmWriteGoody.Copy(Me.ParentForm, goody, m_serie)

            If newGoody IsNot Nothing Then

                Dim goodyIsInCurrentSerie As Boolean = False

                For Each s As Serie In goody.GetSeries
                    If s.GetId = m_serie.GetId Then
                        goodyIsInCurrentSerie = True
                    End If
                Next

                If goodyIsInCurrentSerie Then
                    RefreshSerie()

                Else
                    Dim msg As String = "Le nouveau para-bd a été enregistré dans une autre série." & vbCrLf & "Voulez-vous basculer sur cette série ?"

                    If MsgBox(msg, vbYesNo + vbQuestion, "Para-bd d'une autre série...") = vbYes Then
                        SetParameter(NavParameters.PRM_SERIE_ID, goody.GetSeries(0).GetId)
                        ShowPage(GetType(UC_Serie).FullName)
                    Else
                        RefreshSerie()
                    End If

                End If

            End If
        End If

    End Sub

    Private Sub lst_goodies_ItemSelectionChanged(Sender As Object, e As GridItemSelectedEventArgs) Handles lst_goodies.ItemSelectionChanged

        Dim itemSelected As Boolean = (e.GetValue IsNot Nothing)

        btn_edit.Enabled = itemSelected
        btn_show.Enabled = itemSelected
        btn_copy.Enabled = itemSelected
        btn_delete.Enabled = itemSelected

    End Sub

    Private Sub lst_editions_ItemSelectionChanged(Sender As Object, e As GridItemSelectedEventArgs) Handles lst_editions.ItemSelectionChanged

        Dim itemSelected As Boolean = (e.GetValue IsNot Nothing)

        btn_edit.Enabled = itemSelected
        btn_show.Enabled = itemSelected
        btn_copy.Enabled = itemSelected
        btn_delete.Enabled = itemSelected

    End Sub

    Private Sub lst_goodies_ShowFilterClick(sender As Object, e As MouseEventArgs) Handles lst_goodies.ShowFilterClick

        If e.Button = Windows.Forms.MouseButtons.Left Then

            Dim goodyKinds As New List(Of KindOfGoody)

            For Each goody As Goody In m_goodiesList
                If Not goodyKinds.Contains(goody.GetKindOfGoody) Then
                    goodyKinds.Add(goody.GetKindOfGoody)
                End If
            Next

            goodyKinds.Sort()
            m_kindOfGoodyFlterList.Sort()

            Dim result As FrmSelectItems.FrmSelectItemsResult = FrmSelectItems.GetSelectedItems(goodyKinds, m_kindOfGoodyFlterList, Me)

            If result.DlgResult = DialogResult.OK Then

                m_kindOfGoodyFlterList.Clear()

                If result.SelectedItems Is Nothing OrElse result.SelectedItems.Count = 0 Then
                    Dim adapterGoodies As IAdapter = New GoodiesAdapter(m_goodiesList)
                    lst_goodies.SetAdapter(adapterGoodies)

                Else
                    For Each selecteditem As KindOfGoody In result.SelectedItems
                        m_kindOfGoodyFlterList.Add(selecteditem)
                    Next

                    Dim filteredGoodiesList As New List(Of IdBObject)

                    For Each goody As Goody In m_goodiesList
                        If result.SelectedItems.Contains(goody.GetKindOfGoody) Then
                            filteredGoodiesList.Add(goody)
                        End If
                    Next

                    Dim adapterGoodies As IAdapter = New GoodiesAdapter(filteredGoodiesList)
                    lst_goodies.SetAdapter(adapterGoodies)
                End If
            End If

        End If

    End Sub

End Class

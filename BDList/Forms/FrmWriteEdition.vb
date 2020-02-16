Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports FrameworkPN
Imports System.Reflection
Imports BDList_TOOLS.IO
Imports BDList_TOOLS.Constantes

Public Class FrmWriteEdition

    Private Shared m_serviceEdition As New ServiceEdition
    Private Shared m_serviceAutograph As New ServiceAutograph
    Private Shared m_serviceAuthor As New ServiceAuthor

    Private m_edition As Edition
    Private m_selectedEditor As Editor
    Private m_modifiedItem As ModifiedItem

    ' Utilisé comme modèle dans les cas de duplication d'edition
    Private m_initEdition As Edition = Nothing


    Private m_seriesList As List(Of Serie)
    Private m_actorsList As List(Of ListViewItem)
    Private m_rolesList As List(Of ListViewItem)

    Private m_lstEditors As List(Of IdBObject)
    Private m_lstSizeCategories As List(Of IdBObject)
    Private m_lstCollections As List(Of IdBObject)
    Private m_lstStates As List(Of IdBObject)
    Private m_lstPossessionStates As List(Of IdBObject)
    Private m_lstColors As List(Of IdBObject)
    Private m_lstFormats As List(Of IdBObject)

    Private m_timing1 As Integer
    Private m_timing2 As Integer


    Private Sub New()
        MyBase.New()

        InitializeComponent()

        m_edition = Nothing
        m_selectedEditor = Nothing

        m_timing1 = 0
        m_timing2 = 0

        Panel6.Enabled = False
        PLstAutograph.Enabled = False
        BtnRemoveAutograph.Enabled = False

    End Sub

    Private Sub New(ByRef editionToEdit As ModifiedItem)
        Me.New()

        If (editionToEdit Is Nothing) OrElse (editionToEdit.GetItem Is Nothing) Then
            Throw New ArgumentNullException()
        End If

        m_initEdition = Nothing
        m_edition = editionToEdit.GetItem
        m_modifiedItem = editionToEdit

    End Sub

    Private Sub New(initEdition As Edition, ByRef editionToEdit As ModifiedItem)
        Me.New()

        If (editionToEdit Is Nothing) OrElse (editionToEdit.GetItem Is Nothing) Then
            Throw New ArgumentNullException()
        End If

        m_initEdition = initEdition
        m_edition = editionToEdit.GetItem
        m_modifiedItem = editionToEdit

    End Sub

    Public Shared Function CreateOrEdit(owner As Form) As ModifiedItem
        Return CreateOrEdit(owner, Nothing, Nothing)
    End Function

    Public Shared Function CreateOrEdit(owner As Form, edition As Edition, serie As Serie) As ModifiedItem

        Dim isNewEdition As Boolean = False
        Dim modifiedEdition As ModifiedItem = Nothing

        If (edition Is Nothing) AndAlso (serie Is Nothing) Then
            serie = GetSerie()
        End If

        If Not serie Is Nothing Then

            If edition Is Nothing Then
                edition = m_serviceEdition.GetNew
                edition.GetSeries.Add(serie)
                isNewEdition = True
            End If

            If edition Is Nothing Then
                Throw New NullReferenceException()

            Else
                modifiedEdition = New ModifiedItem(edition)

                Dim frm As New FrmWriteEdition(modifiedEdition)
                frm.ShowDialog(owner)

                If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                    m_serviceEdition.InsertOrUpdate(edition)
                Else
                    If isNewEdition Then
                        m_serviceEdition.Delete(edition)
                    End If
                    modifiedEdition = Nothing
                End If

                frm.Close()
                frm.Dispose()

            End If
        End If

        Return modifiedEdition

    End Function

    Private Shared Function GetSerie() As Serie

        Dim svcSerie As New ServiceSerie
        Return CType(FrmSelectValue.SelectValue(svcSerie.GetAll(), "Sélectionnez une série :", AddressOf GetNewSerie), Serie)

    End Function

    Public Shared Function GetNewSerie() As Object
        Return FrmWriteSerie.CreateOrEdit(Nothing, Nothing)
    End Function

    Public Shared Function Copy(owner As Form, initEdition As Edition) As ModifiedItem

        Dim modifiedEdition As ModifiedItem = Nothing

        If initEdition IsNot Nothing Then

            Dim newEdition As Edition = m_serviceEdition.GetNew
            modifiedEdition = New ModifiedItem(newEdition)

            Dim frm As New FrmWriteEdition(initEdition, modifiedEdition)
            frm.ShowDialog(owner)

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                m_serviceEdition.InsertOrUpdate(modifiedEdition.GetItem)
            Else
                m_serviceEdition.Delete(newEdition)
            End If

            frm.Dispose()

        End If

        Return modifiedEdition

    End Function

    Private Sub FrmWriteEdition_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If m_initEdition Is Nothing Then
            initForm(m_edition, m_edition)
        Else
            initForm(m_initEdition, m_edition)
        End If

    End Sub

    Private Sub initForm(oldEdition As Edition, newEdition As Edition)

        InitialiseEditorList()
        InitialiseStateList()
        InitialiseColorList()
        InitialiseFormatList()
        InitialiseSizeCategoryList()
        InitialiseSeriesList()
        InitialiseActorsList()
        InitialiseRolesList()
        InitialiseAutographAuthors()

        rbtSimpleBook.Checked = True
        rbtNotRead.Checked = True

        If oldEdition IsNot Nothing Then

            If oldEdition Is newEdition Then
                InitImages(oldEdition, newEdition)
            End If

            If m_initEdition IsNot Nothing Then
                Me.Text = "Edition ref. n°" & oldEdition.GetId & " (copie)"
            ElseIf oldEdition.GetId IsNot Nothing Then
                Me.Text = "Edition ref. n°" & oldEdition.GetId
            Else
                Me.Text = "Nouvelle édition"
            End If

            If oldEdition.IsIntegral Then
                rbtIntegral.Checked = True
            ElseIf oldEdition.IsMiscellany Then
                rbtSet.Checked = True
            Else
                rbtSimpleBook.Checked = True
            End If

            If oldEdition.IsRead Then
                rbtRead.Checked = True
            Else
                rbtNotRead.Checked = True
            End If

            txtName.Text = oldEdition.GetName
            txtNumber.Text = oldEdition.GetEditionNumber
            txtSpecialEdition.Text = oldEdition.GetSpecialEdition
            txtEditionNumber.Text = IIf(oldEdition.GetVersionNumber Is Nothing, "", oldEdition.GetVersionNumber)
            txtEditionInformations.Text = oldEdition.GetEditionInformations
            txtIsbn.Text = oldEdition.GetISBN
            txtEanIsbn.Text = oldEdition.GetEAN_ISBN
            txtIssn.Text = oldEdition.GetISSN
            txtDdl.Text = oldEdition.GetDDL
            txtReedition.Text = oldEdition.GetReedition
            txtBoardsCount.Text = IIf(oldEdition.GetBoardCount Is Nothing, "", oldEdition.GetBoardCount)
            txtAddinPagesCount.Text = IIf(oldEdition.GetGraphicPagesCount Is Nothing, "", oldEdition.GetGraphicPagesCount)
            txtPrintingNumber.Text = IIf(oldEdition.GetPrintingNumber Is Nothing, "", oldEdition.GetPrintingNumber)
            txtPrintingMaxNumber.Text = IIf(oldEdition.GetPrintingMaxNumber Is Nothing, "", oldEdition.GetPrintingMaxNumber)
            txtEditionComments.Text = oldEdition.GetComments

            Dim editor As Editor = oldEdition.GetEditor
            If editor IsNot Nothing Then
                cmbEditor.SelectedItem = editor
            End If

            Dim collection As Collection = oldEdition.GetCollection
            If collection IsNot Nothing Then
                cmbCollection.SelectedItem = collection
            End If

            Dim state As State = oldEdition.GetState
            If state IsNot Nothing Then
                cmbState.SelectedItem = state
            End If

            If oldEdition.GetPossessionState IsNot Nothing Then
                btn_possessionState.Tag = oldEdition.GetPossessionState.GetId
                btn_possessionState.Image = PossessionStatesUtils.GetImage(btn_possessionState.Tag)
            Else
                btn_possessionState.Tag = Nothing
                btn_possessionState.Image = Nothing
            End If

            Dim sizeCategory As SizeCategory = oldEdition.GetSizeCategory
            If sizeCategory IsNot Nothing Then
                cmbSize.SelectedItem = sizeCategory
            End If

            Dim items() As ListViewItem
            For Each c As EditionColor In oldEdition.GetColors
                items = LvwColor.Items.Find(c.GetName, False)
                items(0).Checked = True
            Next

            For Each f As EditionFormat In oldEdition.GetFormats
                items = LvwFormat.Items.Find(f.GetName, False)
                items(0).Checked = True
            Next

            txtBoughtDate.SetDate(oldEdition.GetBoughtDate)
            txtParutionDate.SetDate(oldEdition.GetParutionDate)
            txtPrintDate.SetDate(oldEdition.GetPrintDate)
            txtLegalDepositDate.SetDate(oldEdition.GetLegalDepositDate)

            InitialiseLinkedSeriesList(oldEdition)
            InitialiseTitlesListView(oldEdition)
            InitialiseSerieTitlesListView()
            InitialiseAuthorsListView(oldEdition)
            InitialiseAutographsListView(oldEdition)

            btnAddTitle.Enabled = Not ((lvwLinkedTitles.Items.Count > 0) AndAlso (rbtSimpleBook.Checked))

            If (oldEdition.GetTitles Is Nothing) OrElse (oldEdition.GetTitles.Count = 0) Then
                HidePictureTabPages()
            End If

        End If

    End Sub

    Private Sub HidePictureTabPages()

        For position As Integer = 5 To 8
            TabControl1.HideTabPage(position)
        Next

    End Sub

    Private Sub InitImages(oldEdition As Edition, newEdition As Edition)


        Dim firstCoverFile As IFile = m_serviceEdition.GetFirstCoverFile(oldEdition, True)
        Dim fourthCoverFile As IFile = m_serviceEdition.GetFourthCoverFile(oldEdition, True)
        Dim boardsFiles As List(Of IFile) = m_serviceEdition.GetBoardsFiles(oldEdition)

        PLstFirstCover.Clear()
        PLstFirstCover.Enabled = True

        PLstFourthCover.Clear()
        PLstFourthCover.Enabled = True

        PLstBoards.Clear()
        PLstBoards.Enabled = True


        Dim firstCoverFileNameBuilder As New FirstCoverFileNameBuilder(newEdition)
        PLstFirstCover.SetFileNameBuilder(firstCoverFileNameBuilder)

        Dim fourthCoverFileNameBuilder As New FourthCoverFileNameBuilder(oldEdition)
        PLstFourthCover.SetFileNameBuilder(fourthCoverFileNameBuilder)

        Dim boardFileNameBuilder As New BoardFileNameBuilder(oldEdition)
        PLstBoards.SetFileNameBuilder(boardFileNameBuilder)


        If oldEdition Is newEdition Then
            PLstFirstCover.Add(firstCoverFile)
            PLstFourthCover.Add(fourthCoverFile)
            PLstBoards.AddRange(boardsFiles)
        Else

            Dim p As Image
            Dim f As IFile

            If firstCoverFile IsNot Nothing Then
                p = ImageUtils.LoadImage(firstCoverFile)
                PLstFirstCover.Add(firstCoverFileNameBuilder.GetFile(), p)
            End If

            If fourthCoverFile IsNot Nothing > 0 Then
                p = ImageUtils.LoadImage(fourthCoverFile)
                PLstFourthCover.Add(fourthCoverFileNameBuilder.GetFile(), p)
            End If

            Dim i As Integer = 1
            For Each f In boardsFiles
                p = ImageUtils.LoadImage(f)
                PLstBoards.Add(boardFileNameBuilder.GetFile(i), p)
            Next

        End If

    End Sub

    Private Sub InitialiseEditorList()

        Dim svcEditor As New ServiceEditor
        m_lstEditors = svcEditor.GetAll()

        For Each e As Editor In m_lstEditors
            cmbEditor.Items.Add(e)
        Next

    End Sub

    Private Sub InitialiseSizeCategoryList()

        Dim svcSizeCategory As New ServiceSizeCategory
        m_lstSizeCategories = svcSizeCategory.GetAll()

        For Each sc As SizeCategory In m_lstSizeCategories
            cmbSize.Items.Add(sc)
        Next

    End Sub

    Private Sub InitialiseCollectionList(editor As Editor)

        Dim svcCollection As New ServiceCollection
        m_lstCollections = svcCollection.GetByEditor(editor)

        cmbCollection.SelectedItem = Nothing
        cmbCollection.Items.Clear()

        For Each c As Collection In m_lstCollections
            cmbCollection.Items.Add(c)
        Next

    End Sub

    Private Sub InitialiseStateList()

        Dim svcState As New ServiceState
        m_lstStates = svcState.GetAll()

        For Each s As State In m_lstStates
            cmbState.Items.Add(s)
        Next

    End Sub

    Private Sub InitialiseColorList()

        Dim svcColor As New ServiceColor
        m_lstColors = svcColor.GetAll()

        For Each c As EditionColor In m_lstColors
            With LvwColor.Items.Add(c.GetName)
                .Name = c.GetName
                .Tag = c
            End With
        Next

    End Sub

    Private Sub InitialiseFormatList()

        Dim svcFormat As New ServiceFormat
        m_lstFormats = svcFormat.GetAll()

        For Each f As EditionFormat In m_lstFormats
            With LvwFormat.Items.Add(f.GetName)
                .Name = f.GetName
                .Tag = f
            End With
        Next

    End Sub

    Private Sub InitialiseSeriesList()

        Dim svcSerie As New ServiceSerie
        Dim series As List(Of IdBObject) = svcSerie.GetAll()

        m_seriesList = New List(Of Serie)

        For Each s As Serie In series
            LstSeries.Items.Add(s)
            m_seriesList.Add(s)
        Next

    End Sub

    Private Sub InitialiseActorsList()

        Dim svcAuthor As New ServiceAuthor
        Dim authors As List(Of IdBObject) = svcAuthor.GetAll()

        Dim svcSociety As New ServiceSociety
        Dim societies As List(Of IdBObject) = svcSociety.GetAll()

        m_actorsList = New List(Of ListViewItem)

        Dim itemIndex As Integer = 0
        Dim item As ListViewItem
        Dim items(authors.Count + societies.Count - 1) As ListViewItem

        For Each a As Author In authors
            item = New ListViewItem(a.ToString)
            item.SubItems.Add("Personne")
            item.Tag = a
            items(itemIndex) = item
            itemIndex += 1

            m_actorsList.Add(item)
        Next

        For Each s As Society In societies
            item = New ListViewItem(s.ToString)
            item.SubItems.Add("Société")
            item.Tag = s
            items(itemIndex) = item
            itemIndex += 1

            m_actorsList.Add(item)
        Next

        lvwActors.Items.AddRange(items)

    End Sub

    Private Sub InitialiseRolesList()

        Dim svcRole As New ServiceRole
        Dim roles As List(Of IdBObject) = svcRole.GetAll()

        m_rolesList = New List(Of ListViewItem)

        Dim itemIndex As Integer = 0
        Dim item As ListViewItem
        Dim items(roles.Count - 1) As ListViewItem

        For Each r As Role In roles
            item = New ListViewItem(r.ToString)
            item.Tag = r
            items(itemIndex) = item
            itemIndex += 1

            m_rolesList.Add(item)
        Next


        lvwRoles.Items.AddRange(items)

    End Sub


    Private Sub InitialiseTitlesListView(edition As Edition)

        lvwLinkedTitles.Items.Clear()
        For Each t As Title In edition.GetTitles
            With lvwLinkedTitles.Items.Add(t.GetSerie.ToString)
                .SubItems.Add(t.GetOrderNumber)
                .SubItems.Add(IIf(t.IsOutSerie, "Oui", "Non"))
                .SubItems.Add(t.GetName)
                .SubItems.Add(t.GetStory)
                .Tag = t
            End With
        Next

    End Sub

    Private Sub InitialiseSerieTitlesListView()

        Dim serviceTitle As New ServiceTitle

        lvwSerieTitles.Items.Clear()

        For Each serie As Serie In LstLinkedSeries.Items

            For Each title As Title In serviceTitle.GetBySerie(serie)
                With lvwSerieTitles.Items.Add(title.GetSerie.ToString)
                    .SubItems.Add(title.GetOrderNumber)
                    .SubItems.Add(IIf(title.IsOutSerie, "Oui", "Non"))
                    .SubItems.Add(title.GetName)
                    .SubItems.Add(title.GetStory)
                    .Tag = title
                End With
            Next

        Next

    End Sub

    Private Sub InitialiseAuthorsListView(edition As Edition)

        lvwLinkedActorsRoles.Items.Clear()

        For Each pr As AuthorRole In edition.GetAuthorRoles
            With lvwLinkedActorsRoles.Items.Add(pr.GetRole.ToString)
                .SubItems.Add(pr.GetAuthor.ToString)
                .SubItems.Add("Personne")
                .Tag = pr
            End With
        Next

        For Each sr As SocietyRole In edition.GetSocietyRoles
            With lvwLinkedActorsRoles.Items.Add(sr.GetRole.ToString)
                .SubItems.Add(sr.GetSociety.ToString)
                .SubItems.Add("Société")
                .Tag = sr
            End With
        Next

    End Sub

    Private Sub InitialiseAutographsListView(edition As Edition)

        LvwAutographs.Items.Clear()

        For Each autograph As Autograph In edition.GetAutographs

            With LvwAutographs.Items.Add(autograph.GetAuthor.ToString)

                If autograph.GetAutographDate Is Nothing Then
                    .SubItems.Add("")
                Else
                    .SubItems.Add(autograph.GetAutographDate)
                End If

                .SubItems.Add(autograph.GetPlace)
                .SubItems.Add(autograph.GetEvent)
                .SubItems.Add(autograph.GetComments)
                .Tag = autograph

            End With
        Next

        If LvwAutographs.Items.Count > 0 Then
            LvwAutographs.Items(0).Selected = True
        End If

    End Sub

    Private Sub InitialiseLinkedSeriesList(edition As Edition)

        LstLinkedSeries.Items.Clear()

        For Each serie As Serie In edition.GetSeries
            AddSerieToEdition(serie)
        Next

    End Sub

    Private Sub cmbEditor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEditor.SelectedIndexChanged

        Dim editorChanged As Boolean = False

        If (m_selectedEditor Is Nothing) AndAlso (cmbEditor.SelectedItem Is Nothing) Then
            editorChanged = False
        ElseIf m_selectedEditor Is Nothing Then
            editorChanged = True
        ElseIf Not m_selectedEditor.Equals(cmbEditor.SelectedItem) Then
            editorChanged = True
        End If

        If editorChanged Then

            Dim index As Integer = cmbEditor.SelectedIndex
            m_selectedEditor = m_lstEditors(index)

            If m_selectedEditor IsNot Nothing Then
                InitialiseCollectionList(m_selectedEditor)
            Else
                cmbCollection.Items.Clear()
            End If
        End If

    End Sub

    Private Sub rbtBookType_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSimpleBook.CheckedChanged, rbtIntegral.CheckedChanged, rbtSet.CheckedChanged

        If sender Is rbtSimpleBook Then

            If lvwLinkedTitles.Items.Count > 1 Then

                Dim msg As String = "Plusieurs titres sont enregistrés pour cet edition." _
                                    & vbCrLf & "Veuillez modifier la liste des titres de sorte de n'en définir qu'un ou zéro avant de passer l'édition en ""album simple""."
                MsgBox(msg, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Nombre de titres trop important...")

                If m_edition.IsIntegral Then
                    rbtIntegral.Checked = True
                ElseIf m_edition.IsMiscellany Then
                    rbtSet.Checked = True
                End If

            Else

                txtName.Enabled = False
                btnAddTitle.Enabled = (lvwLinkedTitles.Items.Count = 0)
            End If

        ElseIf sender Is rbtIntegral Then
            txtName.Enabled = True
            btnAddTitle.Enabled = True

        ElseIf sender Is rbtSet Then
            txtName.Enabled = True
            btnAddTitle.Enabled = True

        End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Save()
    End Sub

    Private Sub Save()

        Dim allowSave As Boolean = ValidateBeforeSave()

        If allowSave Then

            Try
                Dim newEditor As Editor = GetSelectedBo(Of Editor)(cmbEditor, m_lstEditors, New ServiceEditor, "Éditeur")
                Dim newState As State = GetSelectedBo(Of State)(cmbState, m_lstStates, New ServiceState, "État")
                Dim newPossessionState As PossessionState = GetPossessionState()
                Dim newCollection As Collection = GetCollection(newEditor)
                Dim newSizeCategory As SizeCategory = GetSelectedBo(Of SizeCategory)(cmbSize, m_lstSizeCategories, New ServiceSizeCategory, "Taille")

                If (m_edition.GetEditor Is Nothing) OrElse (Not m_edition.GetEditor.Equals(newEditor)) Then
                    m_edition.SetEditor(newEditor)
                    m_modifiedItem.AddChangedFieldName("Editor")
                End If

                If (m_edition.GetState Is Nothing) OrElse (Not m_edition.GetState.Equals(newState)) Then
                    m_edition.SetState(newState)
                    m_modifiedItem.AddChangedFieldName("State")
                End If

                If (m_edition.GetPossessionState Is Nothing) OrElse (Not m_edition.GetPossessionState.Equals(newPossessionState)) Then
                    m_edition.SetPossessionState(newPossessionState)
                    m_modifiedItem.AddChangedFieldName("PossessionState")
                End If

                If (m_edition.GetCollection Is Nothing) OrElse (Not m_edition.GetCollection Is newCollection) Then
                    m_edition.SetCollection(newCollection)
                    m_modifiedItem.AddChangedFieldName("Collection")
                End If

                If (m_edition.GetSizeCategory Is Nothing) OrElse (Not m_edition.GetSizeCategory.Equals(newSizeCategory)) Then
                    m_edition.SetSizeCategory(newSizeCategory)
                    m_modifiedItem.AddChangedFieldName("SizeCategory")
                End If

            Catch ex As Exception
                allowSave = False
            End Try

        End If

        If allowSave Then

            RefreshTitlesOnCurentEdition()
            RefreshFormatsOnCurentEdition()
            RefreshAutographsOnCurentEdition()

            With m_edition.GetColors
                .Clear()
                For Each item As ListViewItem In LvwColor.Items
                    If item.Checked Then
                        .Add(item.Tag)
                    End If
                Next
            End With

            With m_edition.GetSeries
                .Clear()
                For Each serie As Serie In LstLinkedSeries.Items

                    For Each title As Title In m_edition.GetTitles
                        If title.GetSerie.Equals(serie) Then
                            .Add(serie)
                            Exit For
                        End If
                    Next
                Next
            End With

            m_edition.SetEditionNumber(ToNullableString(txtNumber.Text.Trim))
            m_edition.SetSpecialEdition(ToNullableString(txtSpecialEdition.Text.Trim))
            m_edition.SetRead(rbtRead.Checked)
            m_edition.SetISBN(ToNullableString(txtIsbn.Text.Trim))
            m_edition.SetEAN_ISBN(ToNullableString(txtEanIsbn.Text.Trim))
            m_edition.SetISSN(txtIssn.Text.Trim)
            m_edition.SetDDL(ToNullableString(txtDdl.Text.Trim))
            m_edition.SetReedition(ToNullableString(txtReedition.Text.Trim))
            m_edition.SetIntegral(rbtIntegral.Checked)
            m_edition.SetMiscellany(rbtSet.Checked)

            If rbtSimpleBook.Checked Then
                m_edition.SetName(Nothing)
            Else
                m_edition.SetName(ToNullableString(txtName.Text.Trim))
            End If

            m_edition.SetPageCount(Nothing)
            m_edition.SetBoardCount(ToNullableInteger(txtBoardsCount.Text.Trim))
            m_edition.SetGraphicPagesCount(ToNullableInteger(txtAddinPagesCount.Text.Trim))
            m_edition.SetBoughtPrice(Nothing)
            m_edition.SetLegalDepositDate(txtLegalDepositDate.GetDate)
            m_edition.SetParutionDate(txtParutionDate.GetDate)
            m_edition.SetBoughtDate(txtBoughtDate.GetDate)
            m_edition.SetPrintDate(txtPrintDate.GetDate)
            m_edition.SetVersionNumber(ToNullableInteger(txtEditionNumber.Text.Trim))
            m_edition.SetEditionInformations(ToNullableString(txtEditionInformations.Text.Trim))
            m_edition.SetSpecialEdition(ToNullableString(txtSpecialEdition.Text.Trim))
            m_edition.SetWidth(Nothing)
            m_edition.SetHeight(Nothing)
            m_edition.SetPrintingNumber(ToNullableInteger(txtPrintingNumber.Text.Trim))
            m_edition.SetPrintingMaxNumber(ToNullableInteger(txtPrintingMaxNumber.Text.Trim))
            m_edition.SetComments(ToNullableString(txtEditionComments.Text.Trim))

            PLstFirstCover.SavePictures()
            PLstBoards.SavePictures()
            PLstFourthCover.SavePictures()

            InitRolesActorsBeforeSave()

            Me.Hide()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub InitRolesActorsBeforeSave()

        Dim serviceAuthorRole As New ServiceAuthorRole
        Dim serviceSocietyRole As New ServiceSocietyRole

        Dim actorRoleList As List(Of IdBObject)
        Dim societyRoleList As List(Of IdBObject)

        Dim authorRole As AuthorRole
        Dim societyRole As SocietyRole

        m_edition.GetAuthorRoles.Clear()
        m_edition.GetSocietyRoles.Clear()

        For Each item As ListViewItem In lvwLinkedActorsRoles.Items

            If TypeOf item.Tag Is AuthorRole Then
                With CType(item.Tag, AuthorRole)
                    actorRoleList = serviceAuthorRole.GetByAuthorAndRole(.GetAuthor.GetId, .GetRole.GetId)

                    If actorRoleList.Count = 1 Then
                        authorRole = actorRoleList(0)
                    Else
                        authorRole = serviceAuthorRole.GetNew()
                        authorRole.SetAuthor(.GetAuthor)
                        authorRole.SetRole(.GetRole)
                        serviceAuthorRole.InsertOrUpdate(authorRole)
                    End If

                End With

                m_edition.GetAuthorRoles.Add(authorRole)

            Else
                With CType(item.Tag, SocietyRole)
                    societyRoleList = serviceSocietyRole.GetBySocietyAndRole(.GetSociety.GetId, .GetRole.GetId)

                    If societyRoleList.Count = 1 Then
                        societyRole = societyRoleList(0)
                    Else
                        societyRole = serviceSocietyRole.GetNew()
                        societyRole.SetSociety(.GetSociety)
                        societyRole.SetRole(.GetRole)
                        serviceSocietyRole.InsertOrUpdate(societyRole)
                    End If

                End With

                m_edition.GetSocietyRoles.Add(societyRole)
            End If

        Next

    End Sub

    Private Sub RefreshTitlesOnCurentEdition()

        Dim t As Title
        Dim st As New ServiceTitle
        Dim serieName As String

        Dim oldTitles As New List(Of Title)
        For Each t In m_edition.GetTitles
            oldTitles.Add(t)
        Next

        m_edition.GetTitles.Clear()

        For Each titleItem As ListViewItem In lvwLinkedTitles.Items

            t = titleItem.Tag

            If t Is Nothing Then
                t = st.GetNew()
            End If

            With titleItem

                serieName = .SubItems(0).Text

                For Each serie As Serie In LstLinkedSeries.Items
                    If serie.GetName = serieName Then
                        t.SetSerie(serie)
                        Exit For
                    End If
                Next

                If t.GetSerie() Is Nothing Then
                    For Each serie As Serie In m_seriesList
                        If serie.GetName = serieName Then
                            t.SetSerie(serie)
                            Exit For
                        End If
                    Next
                End If

                t.SetOrderNumber(Integer.Parse(.SubItems(1).Text))
                t.SetOutSerie(.SubItems(2).Text = "Oui")
                t.SetName(.SubItems(3).Text)
                t.SetStory(.SubItems(4).Text)
            End With

            m_edition.GetTitles.Add(t)
        Next

        If m_edition.GetTitles.Count <> oldTitles.Count Then
            m_modifiedItem.AddChangedFieldName("Titles")
        Else
            Dim index As Integer

            For Each t In m_edition.GetTitles

                index = oldTitles.IndexOf(t)

                If index = -1 Then
                    m_modifiedItem.AddChangedFieldName("Titles")
                    Exit For
                ElseIf t.CompareWith(oldTitles(index)) <> 0 Then
                    m_modifiedItem.AddChangedFieldName("Titles")
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub RefreshFormatsOnCurentEdition()

        Dim oldFormats As New List(Of EditionFormat)
        For Each f As EditionFormat In m_edition.GetFormats
            oldFormats.Add(f)
        Next

        With m_edition.GetFormats

            .Clear()

            For Each item As ListViewItem In LvwFormat.Items
                If item.Checked Then
                    .Add(item.Tag)
                End If
            Next

        End With

        If oldFormats.Count <> m_edition.GetFormats.Count Then
            m_modifiedItem.AddChangedFieldName("Formats")
        Else

            Dim index As Integer

            For Each f As EditionFormat In m_edition.GetFormats

                index = oldFormats.IndexOf(f)

                If index = -1 Then
                    m_modifiedItem.AddChangedFieldName("Formats")
                    Exit For
                ElseIf f.CompareWith(oldFormats(index)) <> 0 Then
                    m_modifiedItem.AddChangedFieldName("Formats")
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub RefreshAutographsOnCurentEdition()

        Dim lineOk As Boolean
        Dim autographs As New List(Of IdBObject)

        For Each item In LvwAutographs.Items

            lineOk = False

            With item

                For i As Integer = 0 To .SubItems.Count - 1
                    .SubItems(i).Text = .SubItems(i).Text.Trim
                    lineOk = lineOk OrElse Not String.IsNullOrEmpty(.SubItems(i).Text)
                Next

                If lineOk Then
                    autographs.Add(item.tag)
                End If

            End With

        Next

        PLstAutograph.SavePictures()

        m_edition.SetAutographs(autographs)

    End Sub

    Private Function ValidateBeforeSave() As Boolean

        Dim allowSave As Boolean = False
        Dim errMsg As String = Nothing

        If (cmbEditor.SelectedItem Is Nothing) AndAlso (String.IsNullOrEmpty(cmbEditor.Text.Trim)) Then
            errMsg = "Indiquez un éditeur pour l'édition."
        End If

        Dim d As String = txtParutionDate.Text.Trim
        If (String.IsNullOrEmpty(d)) Then
            errMsg = "Indiquez la date de parution de l'édition."
        ElseIf (Not String.IsNullOrEmpty(d)) AndAlso (Not IsDate(d)) Then
            errMsg = "Le format de la date de parution n'est pas valide."
        End If

        d = txtLegalDepositDate.Text.Trim
        If (Not String.IsNullOrEmpty(d)) AndAlso (Not IsDate(d)) Then
            errMsg = "Le format de la date de dépôt légal n'est pas valide."
        End If

        Dim possessionState As PossessionStates = btn_possessionState.Tag
        d = txtBoughtDate.Text.Trim
        If (Not String.IsNullOrEmpty(d)) AndAlso (Not IsDate(d)) Then
            errMsg = "Le format de la date d'obtention n'est pas valide."
        End If
        If ((possessionState <> PossessionStates.InPossession) AndAlso (Not String.IsNullOrEmpty(d))) Then
            errMsg = "La date d'obtention est renseignée, cependant l'édition n'est pas notée ""En possession""."
        End If
        If ((possessionState = PossessionStates.InPossession) AndAlso (String.IsNullOrEmpty(d))) Then
            Dim msg = "L'édition est notée ""En possession"", cependant la date d'obtention n'est pas renseignée."
            If MsgBox(msg & vbCrLf & "Voulez-vous tout de même enregistrer l'édition ?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Erreur...") = MsgBoxResult.No Then
                errMsg = msg
            End If
        End If

        d = txtPrintDate.Text.Trim
        If (Not String.IsNullOrEmpty(d)) AndAlso (Not IsDate(d)) Then
            errMsg = "Le format de la date d'impression n'est pas valide."
        End If

        Dim n As String = txtPrintingNumber.Text.Trim
        If (Not String.IsNullOrEmpty(n)) AndAlso (Not Integer.TryParse(n, 0)) Then
            errMsg = "Le format du numéro de tirage n'est pas valide."
        End If

        n = txtPrintingMaxNumber.Text.Trim
        If (Not String.IsNullOrEmpty(n)) AndAlso (Not Integer.TryParse(n, 0)) Then
            errMsg = "Le format du nombre de tirage n'est pas valide."
        End If

        n = txtBoardsCount.Text.Trim
        If (Not String.IsNullOrEmpty(n)) AndAlso (Not Integer.TryParse(n, 0)) Then
            errMsg = "Le format du nombre de planches n'est pas valide."
        End If

        n = txtAddinPagesCount.Text.Trim
        If (Not String.IsNullOrEmpty(n)) AndAlso (Not Integer.TryParse(n, 0)) Then
            errMsg = "Le format du nombre de pages de complément n'est pas valide."
        End If

        If lvwLinkedTitles.Items.Count = 0 Then
            errMsg = "Vous devez saisir au moins un titre pour cette édition."
        End If

        If (rbtSimpleBook.Checked) AndAlso (lvwLinkedTitles.Items.Count > 1) Then
            errMsg = "Une édition simple ne peut contenir plus d'un titre."
        End If

        For Each item In LvwAutographs.Items
            If item.text.trim = "" Then
                errMsg = "Une dédicace doit avoir au moins un auteur."
            End If
        Next


        If errMsg IsNot Nothing Then
            Call MsgBox(errMsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Informations incomplètes ou erronées...")
        Else
            'If m_edition Is Nothing Then
            ' m_edition = m_serviceEdition.GetNew
            ' End If
            allowSave = True
        End If

        Return allowSave

    End Function

    Private Function GetSelectedBo(Of boType As NamedBObject)(cmb As ComboBox, itemsList As List(Of IdBObject), service As IService, boCaption As String, Optional fields As Hashtable = Nothing) As boType

        Dim item As NamedBObject = Nothing
        Dim name As String = cmb.Text.Trim

        If Not String.IsNullOrEmpty(name) Then

            Dim index As Integer = cmb.FindStringExact(name)

            If index = -1 Then

                name = name.Substring(0, 1).ToUpper & name.Substring(1)
                index = cmb.FindStringExact(name)

                If index = -1 Then

                    If MsgBox(boCaption & " """ & name & """ inconnu(e). Voulez-vous l'ajouter ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, boCaption & " inconnu(e)...") = MsgBoxResult.Yes Then

                        item = service.GetNew
                        item.SetName(name)

                        If fields IsNot Nothing Then

                            Dim m As MethodInfo
                            Dim prms() As Object

                            For Each fieldName As String In fields.Keys
                                m = GetType(boType).GetMethod("Set" & fieldName)
                                prms = {fields.Item(fieldName)}
                                m.Invoke(item, prms)
                            Next
                        End If

                        service.InsertOrUpdate(item)

                    Else
                        Throw New Exception("Donnée invalide")
                    End If

                End If
            End If

            If index > -1 Then
                item = itemsList(index)
            End If

        End If

        Return item

    End Function


    Private Function GetCollection(editor As Editor) As Collection

        Dim collection As Collection = Nothing

        If editor IsNot Nothing Then

            Dim fields As New Hashtable
            fields.Add("Editor", editor)

            collection = GetSelectedBo(Of Collection)(cmbCollection, m_lstCollections, New ServiceCollection, "Collection", fields)
        End If

        Return collection

    End Function

    Private Sub lvwTitles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwLinkedTitles.SelectedIndexChanged

        If lvwLinkedTitles.SelectedItems.Count > 0 Then
            btnRemoveTitle.Enabled = True

            If Not IsSelectedTitleRowEmpty() Then

                With lvwLinkedTitles.SelectedItems(0)
                    txtTitleNumber.Text = .SubItems(1).Text

                    If .SubItems(2).Text = "Oui" Then
                        rbtOutSerie.Checked = True
                    Else
                        rbtNotOutSerie.Checked = True
                    End If

                    txtTitleName.Text = .SubItems(3).Text
                    txtTitleStory.Text = .SubItems(4).Text


                End With

                btnAddTitle.Enabled = (rbtSimpleBook.Checked And lvwLinkedTitles.Items.Count = 0) Or (Not rbtSimpleBook.Checked)
            End If
        Else
            btnRemoveTitle.Enabled = False
            btnAddTitle.Enabled = False
            cleanTxtBoxTitleInfos()
        End If

    End Sub

    Private Sub btnAddTitle_Click(sender As Object, e As EventArgs) Handles btnAddTitle.Click

        Dim serie As Serie = getSerieForTitle()

        If serie IsNot Nothing Then
            ChangeTitleElement(serie.GetName, 0)
            btnAddTitle.Enabled = (rbtSimpleBook.Checked And lvwLinkedTitles.Items.Count = 0) Or (Not rbtSimpleBook.Checked)
            txtTitleNumber.Focus()
        End If

    End Sub

    Private Sub txtTitleNumber_TextChanged(sender As Object, e As EventArgs) Handles txtTitleNumber.TextChanged
        ChangeTitleElement(txtTitleNumber.Text, 1)
    End Sub

    Private Sub txtTitleName_TextChanged(sender As Object, e As EventArgs) Handles txtTitleName.TextChanged
        ChangeTitleElement(txtTitleName.Text, 3)
    End Sub

    Private Sub rbtOutSerie_CheckedChanged(sender As Object, e As EventArgs) Handles rbtOutSerie.CheckedChanged
        ChangeTitleElement(IIf(rbtOutSerie.Checked, "Oui", ""), 2)
    End Sub

    Private Sub rbtNotOutSerie_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNotOutSerie.CheckedChanged
        ChangeTitleElement(IIf(rbtNotOutSerie.Checked, "Non", ""), 2)
    End Sub

    Private Sub txtTitleStory_TextChanged(sender As Object, e As EventArgs) Handles txtTitleStory.TextChanged
        ChangeTitleElement(txtTitleStory.Text, 4)
    End Sub

    Private Function AddTitleRow() As ListViewItem

        Dim lvi As ListViewItem = lvwLinkedTitles.Items.Add("")

        With lvi
            For c As Integer = 2 To lvwLinkedTitles.Columns.Count
                .SubItems.Add("")
            Next
        End With

        Return lvi

    End Function

    Private Function IsSelectedTitleRowEmpty()

        Dim result As Boolean = False

        With lvwLinkedTitles.SelectedItems(0)

            result = True

            Dim c As Integer = 1

            While (c < lvwLinkedTitles.Columns.Count) And (result)

                If (c <> 2) AndAlso (Not String.IsNullOrEmpty(.SubItems(c).Text.Trim)) Then
                    result = False
                End If

                c += 1
            End While

        End With

        Return result

    End Function

    Private Sub ChangeTitleElement(value As String, columnIndex As Integer)

        Dim serieName As String = Nothing
        Dim selectedItem As ListViewItem = Nothing

        If lvwLinkedTitles.SelectedItems.Count = 0 Then
            selectedItem = AddTitleRow()
            selectedItem.Selected = True
        Else
            selectedItem = lvwLinkedTitles.SelectedItems(0)
            serieName = lvwLinkedTitles.SelectedItems(0).SubItems(0).Text
        End If

        selectedItem.SubItems(columnIndex).Text = value.Trim

        If IsSelectedTitleRowEmpty() Then
            selectedItem.Remove()

        ElseIf selectedItem.SubItems(0).Text = "" Then

            Dim serie As Serie = getSerieForTitle()

            If serie IsNot Nothing Then
                serieName = serie.GetName
                selectedItem.SubItems(0).Text = serieName
            Else
                selectedItem.Remove()
            End If
        End If

    End Sub

    Private Function getSerieForTitle() As Serie

        Dim serie As Serie

        If LstLinkedSeries.Items.Count > 1 Then

            Dim series As New List(Of Object)
            For Each s As Serie In LstLinkedSeries.Items
                series.Add(s)
            Next

            serie = FrmSelectValue.SelectValue(series, "Sélectionnez la série associées au titre.")

        ElseIf LstLinkedSeries.Items.Count = 1 Then
            serie = LstLinkedSeries.Items(0)

        Else
            serie = Nothing
        End If

        Return serie

    End Function

    Private Sub btnRemoveTitle_Click(sender As Object, e As EventArgs) Handles btnRemoveTitle.Click

        If lvwLinkedTitles.SelectedItems.Count > 0 Then
            lvwLinkedTitles.SelectedItems(0).Remove()
            cleanTxtBoxTitleInfos()
            txtTitleNumber.Focus()
        End If

        btnAddTitle.Enabled = (rbtSimpleBook.Checked And lvwLinkedTitles.Items.Count = 0) Or (Not rbtSimpleBook.Checked)

    End Sub

    Private Sub cleanTxtBoxTitleInfos()

        txtTitleNumber.Text = ""
        txtTitleName.Text = ""
        txtTitleStory.Text = ""

        rbtOutSerie.Checked = False
        rbtNotOutSerie.Checked = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCopyToTitlesList.Click
        lvwLinkedTitles.Items.Add(lvwSerieTitles.SelectedItems(0).Clone)
    End Sub

    Private Sub lvwSerieTitles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwSerieTitles.SelectedIndexChanged
        btnCopyToTitlesList.Enabled = (lvwSerieTitles.SelectedItems.Count > 0)
    End Sub

    Private Sub TxtSeriesFilter_TextChanged(sender As Object, e As EventArgs) Handles TxtSeriesFilter.TextChanged

        LstSeries.Items.Clear()

        Dim filter As String = "*" & TxtSeriesFilter.Text.Trim.ToLower & "*"

        For Each s As Serie In m_seriesList
            If s.GetSortName.ToLower Like filter Then
                LstSeries.Items.Add(s)
            End If
        Next

    End Sub

    Private Sub LstSeries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstSeries.SelectedIndexChanged
        BtnAddSerie.Enabled = (LstSeries.SelectedItems.Count > 0)
    End Sub

    Private Sub LstLinkedSeries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstLinkedSeries.SelectedIndexChanged
        BtnRemoveSerie.Enabled = (LstLinkedSeries.SelectedItems.Count > 0)
    End Sub

    Private Sub BtnAddSerie_Click(sender As Object, e As EventArgs) Handles BtnAddSerie.Click
        AddSerieToEdition(LstSeries.SelectedItems(0))
    End Sub

    Private Sub AddSerieToEdition(serie As Serie)

        LstLinkedSeries.Items.Add(serie)
        m_seriesList.Remove(serie)
        LstSeries.Items.Remove(serie)
        InitialiseSerieTitlesListView()

    End Sub

    Private Sub BtnRemoveSerie_Click(sender As Object, e As EventArgs) Handles BtnRemoveSerie.Click

        Dim serie As Serie = LstLinkedSeries.SelectedItems(0)
        Dim continueRemove = True

        For Each item As ListViewItem In lvwLinkedTitles.Items
            If item.SubItems(0).Text = serie.ToString Then
                continueRemove = (MsgBox("Il existe des titres de la série " & serie.ToString & " attachés à l'édition. Si la série est retirée, les titres seront également retirés." & vbCrLf & "Retirer la série ?", vbExclamation + vbYesNo, "Titres de la série liés...") = vbYes)
                Exit For
            End If
        Next

        If continueRemove Then
            LstSeries.Items.Add(serie)
            m_seriesList.Add(serie)
            LstLinkedSeries.Items.Remove(serie)
            'm_seriesList.Sort()
            InitialiseSerieTitlesListView()

            For Each item As ListViewItem In lvwLinkedTitles.Items
                If item.SubItems(0).Text = serie.ToString Then
                    lvwLinkedTitles.Items.Remove(item)
                    Exit For
                End If
            Next

        End If

    End Sub

    Private Sub lvwActors_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lvwActors.ItemSelectionChanged
        btnAddActorRole.Enabled = (lvwActors.SelectedItems.Count > 0) AndAlso (lvwRoles.SelectedItems.Count > 0)
    End Sub

    Private Sub lvwActors_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvwActors.MouseDoubleClick

        Dim actor As Object = lvwActors.SelectedItems(0).Tag
        Dim modifiedItem As ModifiedItem

        If TypeOf actor Is Author Then

            modifiedItem = FrmWriteAuthor.CreateOrEdit(Me, actor)

            If modifiedItem IsNot Nothing Then
                Dim author As Author = modifiedItem.GetItem

                If author IsNot Nothing Then
                    lvwActors.SelectedItems(0).Text = author.ToString
                    lvwActors.SelectedItems(0).Tag = author
                End If

            End If

        Else
            Dim society As Society = FrmWriteSociety.CreateOrEdit(Me, actor)

            If society IsNot Nothing Then
                lvwActors.SelectedItems(0).Text = society.ToString
                lvwActors.SelectedItems(0).Tag = society
            End If

        End If

    End Sub

    Private Sub lvw_MouseEnter(sender As Object, e As EventArgs) Handles lvwActors.MouseEnter, lvwRoles.MouseEnter

        If Not (txtActorsFilter.Focused Or txtRolesFilter.Focused) Then
            sender.focus()
        End If

    End Sub

    Private Sub lvwActors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwActors.SelectedIndexChanged
        btnAddActorRole.Enabled = (lvwActors.SelectedItems.Count > 0) AndAlso (lvwRoles.SelectedItems.Count > 0)
    End Sub

    Private Sub lvwRoles_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lvwRoles.ItemSelectionChanged
        btnAddActorRole.Enabled = (lvwActors.SelectedItems.Count > 0) AndAlso (lvwRoles.SelectedItems.Count > 0)
    End Sub

    Private Sub lvwRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwRoles.SelectedIndexChanged
        btnAddActorRole.Enabled = (lvwActors.SelectedItems.Count > 0) AndAlso (lvwRoles.SelectedItems.Count > 0)
    End Sub

    Private Sub lvwLinkedActorsRoles_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvwLinkedActorsRoles.MouseDoubleClick

        Dim actorRole As Object = lvwLinkedActorsRoles.SelectedItems(0).Tag
        Dim modifiedItem As ModifiedItem = Nothing

        If TypeOf actorRole Is AuthorRole Then

            Dim authorRole As AuthorRole = CType(actorRole, AuthorRole)
            modifiedItem = FrmWriteAuthor.CreateOrEdit(Me, authorRole.GetAuthor)

            If modifiedItem IsNot Nothing Then
                Dim author As Author = modifiedItem.GetItem

                If author IsNot Nothing Then
                    lvwLinkedActorsRoles.SelectedItems(0).SubItems(1).Text = author.ToString
                    authorRole.SetAuthor(author)
                End If
            End If

        Else
            Dim societyRole As SocietyRole = CType(actorRole, SocietyRole)
            Dim society As Society = FrmWriteSociety.CreateOrEdit(Me, societyRole.GetSociety)

            If society IsNot Nothing Then
                lvwLinkedActorsRoles.SelectedItems(0).SubItems(1).Text = society.ToString
                societyRole.SetSociety(society)
            End If

        End If

    End Sub

    Private Sub lvwLinkedAuthors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwLinkedActorsRoles.SelectedIndexChanged
        btnRemoveActorRole.Enabled = (lvwLinkedActorsRoles.SelectedItems.Count > 0)
    End Sub

    Private Sub btnAddActorRole_Click(sender As Object, e As EventArgs) Handles btnAddActorRole.Click

        If (lvwActors.SelectedItems.Count > 0) AndAlso (lvwRoles.SelectedItems.Count > 0) Then

            Dim actor As Object = lvwActors.SelectedItems(0).Tag
            Dim role As Role = lvwRoles.SelectedItems(0).Tag

            If TypeOf actor Is Author Then

                Dim actorRole As New AuthorRole()
                actorRole.SetAuthor(actor)
                actorRole.SetRole(role)

                With lvwLinkedActorsRoles.Items.Add(actorRole.GetRole.ToString)
                    .SubItems.Add(actorRole.GetAuthor.ToString)
                    .SubItems.Add("Personne")
                    .Tag = actorRole
                End With

            Else

                Dim actorRole As New SocietyRole()
                actorRole.SetSociety(actor)
                actorRole.SetRole(role)

                With lvwLinkedActorsRoles.Items.Add(actorRole.GetRole.ToString)
                    .SubItems.Add(actorRole.GetSociety.ToString)
                    .SubItems.Add("Société")
                    .Tag = actorRole
                End With

            End If

        End If


    End Sub

    Private Sub btnRemoveActorRole_Click(sender As Object, e As EventArgs) Handles btnRemoveActorRole.Click
        lvwLinkedActorsRoles.Items.Remove(lvwLinkedActorsRoles.SelectedItems(0))
    End Sub

    Private Sub btnNewAuthor_Click_1(sender As Object, e As EventArgs) Handles btnNewAuthor.Click

        Dim modifiedItem As ModifiedItem = FrmWriteAuthor.CreateOrEdit(Me, Nothing)

        If modifiedItem IsNot Nothing Then
            Dim actor As Author = modifiedItem.GetItem

            If actor IsNot Nothing Then
                Dim lvi As ListViewItem = lvwActors.Items.Add(actor.ToString)
                With lvi
                    .SubItems.Add("Personne")
                    .Tag = actor
                    .Selected = True
                End With
                lvwActors.TopItem = lvi
                m_actorsList.Add(lvi)
            End If
        End If

    End Sub

    Private Sub btnNewSociety_Click(sender As Object, e As EventArgs) Handles btnNewSociety.Click

        Dim society As Society = FrmWriteSociety.CreateOrEdit(Me, Nothing)

        If society IsNot Nothing Then
            Dim lvi As ListViewItem = lvwActors.Items.Add(society.ToString)
            With lvi
                .SubItems.Add("Société")
                .Tag = society
                .Selected = True
            End With
            lvwActors.TopItem = lvi
            m_actorsList.Add(lvi)
        End If

    End Sub

    Private Sub btnNewRole_Click(sender As Object, e As EventArgs) Handles btnNewRole.Click

        Dim role As Role = FrmWriteRole.CreateOrEdit(Me, Nothing)

        If role IsNot Nothing Then
            Dim lvi As ListViewItem = lvwRoles.Items.Add(role.ToString)
            With lvi
                .Tag = role
                .Selected = True
            End With
            lvwRoles.TopItem = lvi
            m_rolesList.Add(lvi)
        End If

    End Sub

    Private Sub txtActorsFilter_TextChanged(sender As Object, e As EventArgs) Handles txtActorsFilter.TextChanged
        Timer1.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub txtRolesFilter_TextChanged(sender As Object, e As EventArgs) Handles txtRolesFilter.TextChanged
        Timer2.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        m_timing1 += 1

        If m_timing1 = 5 Then

            Timer1.Enabled = False
            m_timing1 = 0

            lvwActors.Items.Clear()

            Dim filter As String = txtActorsFilter.Text.Trim

            Dim itemIndex As Integer = 0
            Dim items(m_actorsList.Count - 1) As ListViewItem

            If Not String.IsNullOrEmpty(filter) Then

                filter = "*" & filter.ToLower & "*"

                For Each lvi As ListViewItem In m_actorsList
                    If lvi.Text.ToLower Like filter Then
                        items(itemIndex) = lvi
                        itemIndex += 1
                    End If
                Next

            Else

                For Each lvi As ListViewItem In m_actorsList
                    items(itemIndex) = lvi
                    itemIndex += 1
                Next

            End If

            ReDim Preserve items(itemIndex - 1)
            lvwActors.Items.AddRange(items)

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        m_timing1 += 1

        If m_timing1 = 5 Then

            Timer1.Enabled = False
            m_timing1 = 0

            lvwRoles.Items.Clear()

            Dim filter As String = "*" & txtRolesFilter.Text.Trim & "*"

            If Not String.IsNullOrEmpty(filter) Then

                filter = "*" & filter.ToLower & "*"

                Dim itemIndex As Integer = 0
                Dim items(m_rolesList.Count - 1) As ListViewItem

                For Each lvi As ListViewItem In m_rolesList
                    If lvi.Text.ToLower Like filter Then
                        items(itemIndex) = lvi
                        itemIndex += 1
                    End If
                Next

                ReDim Preserve items(itemIndex - 1)
                lvwRoles.Items.AddRange(items)

            End If
        End If

    End Sub

    Private Sub LvwAutographs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvwAutographs.SelectedIndexChanged

        If LvwAutographs.SelectedItems.Count = 1 Then

            Panel6.Enabled = True
            PLstAutograph.Enabled = True
            BtnRemoveAutograph.Enabled = True

            Dim a As Autograph = LvwAutographs.SelectedItems(0).Tag
            Dim author As Author = a.GetAuthor

            PLstAutograph.Clear()
            slst_authors.Clear()

            If author IsNot Nothing Then
                slst_authors.AddItem(author)
                PLstAutograph.SetFileNameBuilder(New AutographFileNameBuilder(a))
                PLstAutograph.AddRange(m_serviceAutograph.GetFiles(a))
            End If

            TxtAutographDate.SetDate(a.GetAutographDate)
            TxtAutographPlace.Text = a.GetPlace
            TxtAutographEvent.Text = a.GetEvent
            txtAutographComments.Text = a.GetComments

        Else
            Panel6.Enabled = False
            PLstAutograph.Enabled = False
            BtnRemoveAutograph.Enabled = False

            TxtAutographDate.SetDate(Nothing)
            TxtAutographPlace.Text = ""
            TxtAutographEvent.Text = ""
            txtAutographComments.Text = ""
            PLstAutograph.Clear()
            slst_authors.Clear()

        End If

    End Sub

    Private Sub InitialiseAutographAuthors()

        Dim serviceAuthor As New ServiceAuthor

        slst_authors.Enabled = True
        slst_authors.SetValues(serviceAuthor.GetAll().ToArray)

    End Sub

    Private Sub slst_authors_ItemsListChanged(sender As SelectList) Handles slst_authors.ItemsListChanged

        If LvwAutographs.SelectedItems.Count = 1 Then

            Dim item As ListViewItem = LvwAutographs.SelectedItems(0)
            Dim a As Autograph = item.Tag

            Dim author As Author = Nothing

            With CType(sender, SelectList).Items
                If .Count = 1 Then
                    author = CType(.ElementAt(0), Author)
                End If
            End With

            If author Is Nothing Then
                item.Text = ""
                a.SetAuthor(Nothing)
            Else
                item.Text = author.ToString
                a.SetAuthor(author)
            End If

        End If

    End Sub

    Private Sub TxtAutographDate_TextChanged(sender As Object, e As EventArgs) Handles TxtAutographDate.DateChanged

        If LvwAutographs.SelectedItems.Count = 1 Then

            Dim item As ListViewItem = LvwAutographs.SelectedItems(0)
            Dim a As Autograph = item.Tag
            Dim dte As Date? = CType(sender, DateTextBox).GetDate

            item.SubItems(1).Text = ""

            If dte Is Nothing Then
                item.SubItems(1).Text = ""
                a.SetAutographDate(Nothing)
            Else
                item.SubItems(1).Text = dte.Value
                a.SetAutographDate(dte)
            End If

        End If

    End Sub

    Private Sub TxtAutographPlace_TextChanged(sender As Object, e As EventArgs) Handles TxtAutographPlace.TextChanged

        If LvwAutographs.SelectedItems.Count = 1 Then

            Dim item As ListViewItem = LvwAutographs.SelectedItems(0)
            Dim a As Autograph = item.Tag
            Dim place As String = CType(sender, TextBox).Text.Trim

            If String.IsNullOrEmpty(place) Then
                item.SubItems(2).Text = ""
                a.SetPlace(Nothing)
            Else
                item.SubItems(2).Text = place
                a.SetPlace(place)
            End If

        End If

    End Sub

    Private Sub TxtAutographEvent_TextChanged(sender As Object, e As EventArgs) Handles TxtAutographEvent.TextChanged

        If LvwAutographs.SelectedItems.Count = 1 Then

            Dim item As ListViewItem = LvwAutographs.SelectedItems(0)
            Dim a As Autograph = item.Tag
            Dim evt As String = CType(sender, TextBox).Text.Trim

            If String.IsNullOrEmpty(evt) Then
                item.SubItems(3).Text = ""
                a.SetEvent(Nothing)
            Else
                item.SubItems(3).Text = evt
                a.SetEvent(evt)
            End If

        End If

    End Sub

    Private Sub txtAutographComments_TextChanged(sender As Object, e As EventArgs) Handles txtAutographComments.TextChanged

        If LvwAutographs.SelectedItems.Count = 1 Then

            Dim item As ListViewItem = LvwAutographs.SelectedItems(0)
            Dim a As Autograph = item.Tag
            Dim comments As String = CType(sender, TextBox).Text.Trim

            If String.IsNullOrEmpty(comments) Then
                item.SubItems(4).Text = ""
                a.SetComments(Nothing)
            Else
                item.SubItems(4).Text = comments
                a.SetComments(comments)
            End If

        End If

    End Sub

    Private Sub TabPage_DragOver(sender As Object, e As DragEventArgs) Handles TabControl1.DragOver

        Dim i As Integer = -1
        Dim pt As Point = TabControl1.PointToClient(New Point(e.X, e.Y))

        For index As Integer = 0 To TabControl1.TabCount - 1
            If TabControl1.GetTabRect(index).Contains(pt) Then i = index
        Next

        If i >= 5 And i <= 7 Then
            TabControl1.SelectedIndex = i
        End If

    End Sub

    Private Sub BtnAddAutograph_Click(sender As Object, e As EventArgs) Handles BtnAddAutograph.Click

        Dim lastLineOk As Boolean = True

        If LvwAutographs.Items.Count > 0 Then

            lastLineOk = False

            With LvwAutographs.Items(LvwAutographs.Items.Count - 1)

                For i As Integer = 0 To .SubItems.Count - 1
                    .SubItems(i).Text = .SubItems(i).Text.Trim
                    lastLineOk = lastLineOk OrElse Not String.IsNullOrEmpty(.SubItems(i).Text)
                Next

            End With
        End If

        If lastLineOk Then
            With LvwAutographs.Items.Add("")
                .SubItems.Add("")
                .SubItems.Add("")
                .SubItems.Add("")
                .SubItems.Add("")
                .Tag = m_serviceAutograph.GetNew()
                .Selected = True
            End With
        Else
            LvwAutographs.Items(LvwAutographs.Items.Count - 1).Selected = True
        End If

    End Sub

    Private Sub BtnRemoveAutograph_Click(sender As Object, e As EventArgs) Handles BtnRemoveAutograph.Click

        If MsgBox("Voulez-vous supprimer l'autographe ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Suppression d'autographe...") = MsgBoxResult.Yes Then
            LvwAutographs.SelectedItems.Item(0).Remove()
        End If

    End Sub

    Private Sub Btn_CreateAuthor_Click(sender As Object, e As EventArgs) Handles Btn_CreateAuthor.Click

        Dim modifiedItem As ModifiedItem = FrmWriteAuthor.CreateOrEdit(Me.ParentForm, Nothing)

        If modifiedItem IsNot Nothing Then
            Dim newAuthor As Author = modifiedItem.GetItem

            If newAuthor IsNot Nothing Then
                slst_authors.AddItem(newAuthor)
            End If
        End If

    End Sub

    Private Function GetPossessionState() As PossessionState

        Dim svcPossessionState As New ServicePossessionState
        Dim idPossessionState As Long? = CType(btn_possessionState.Tag, Long)

        Return CType(svcPossessionState.GetById(idPossessionState), BoPossessionState)

    End Function

    Private Sub btn_possessionState_Click(sender As Object, e As EventArgs) Handles btn_possessionState.Click
        btn_possessionState.Tag = FrmPossessionState.GetPossessionState(CType(btn_possessionState.Tag, PossessionStates), Me)
        btn_possessionState.Image = PossessionStatesUtils.GetImage(btn_possessionState.Tag)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

    End Sub

End Class
Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.Constantes
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class FrmWriteGoody

    Private Shared m_serviceGoody As New ServiceGoody()

    Private m_lstPossessionStates As List(Of IdBObject)

    Private m_goody As Goody = Nothing
    Private m_modifiedGoody As ModifiedItem = Nothing

    ' Utilisé comme modèle dans les cas de duplication de goody
    Private m_initGoody As Goody = Nothing

    Private m_defaultSerie As Serie

    Private Sub New()
        MyBase.New()
        InitializeComponent()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub New(ByRef goodyToEdit As ModifiedItem, defaultSerie As Serie)
        Me.New()

        If (goodyToEdit Is Nothing) OrElse (goodyToEdit.GetItem Is Nothing) Then
            Throw New ArgumentNullException()
        End If

        m_initGoody = Nothing
        m_goody = goodyToEdit.GetItem
        m_defaultSerie = defaultSerie
        m_modifiedGoody = goodyToEdit

    End Sub

    Private Sub New(initGoody As Goody, ByRef goodyToEdit As ModifiedItem, defaultSerie As Serie)
        Me.New()

        If (goodyToEdit Is Nothing) OrElse (goodyToEdit.GetItem Is Nothing) Then
            Throw New ArgumentNullException()
        End If

        m_initGoody = initGoody
        m_goody = goodyToEdit.GetItem
        m_defaultSerie = defaultSerie
        m_modifiedGoody = goodyToEdit

    End Sub

    Public Shared Function CreateOrEdit(owner As Form) As ModifiedItem
        Return CreateOrEdit(owner, Nothing, Nothing)
    End Function

    Public Shared Function CreateOrEdit(owner As Form, goody As Goody, serie As Serie) As ModifiedItem

        Dim isNewGoody As Boolean = False
        Dim modifiedGoody As ModifiedItem = Nothing

        If (goody Is Nothing) AndAlso (serie Is Nothing) Then
            serie = GetSerie()
        End If

        If Not serie Is Nothing Then

            If goody Is Nothing Then
                goody = m_serviceGoody.GetNew
                goody.GetSeries.Add(serie)
                isNewGoody = True
            End If

            If goody Is Nothing Then
                Throw New NullReferenceException()

            Else
                modifiedGoody = New ModifiedItem(goody)

                Dim frm As New FrmWriteGoody(modifiedGoody, serie)
                frm.ShowDialog(owner)

                If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                    m_serviceGoody.InsertOrUpdate(modifiedGoody.GetItem)
                Else
                    If isNewGoody Then
                        m_serviceGoody.Delete(goody)
                    End If
                    modifiedGoody = Nothing
                End If

                frm.Close()
                frm.Dispose()

            End If

        End If

        Return modifiedGoody

    End Function

    Private Shared Function GetSerie() As Serie

        Dim svcSerie As New ServiceSerie
        Return CType(FrmSelectValue.SelectValue(svcSerie.GetAll(), "Sélectionnez une série :", AddressOf GetNewSerie), Serie)

    End Function

    Public Shared Function GetNewSerie() As Object
        Return FrmWriteSerie.CreateOrEdit(Nothing, Nothing)
    End Function

    Public Shared Function Copy(owner As Form, initGoody As Goody, serie As Serie) As ModifiedItem

        Dim modifiedGoody As ModifiedItem = Nothing

        If initGoody IsNot Nothing Then

            Dim newGoody As Goody = m_serviceGoody.GetNew
            modifiedGoody = New ModifiedItem(newGoody)

            If serie IsNot Nothing Then
                newGoody.GetSeries.Add(serie)
            End If

            Dim frm As New FrmWriteGoody(initGoody, modifiedGoody, serie)
            frm.ShowDialog(owner)

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                m_serviceGoody.InsertOrUpdate(modifiedGoody.GetItem)
            Else
                m_serviceGoody.Delete(newGoody)
            End If

            frm.Dispose()

        End If

        Return modifiedGoody

    End Function

    Private Sub FrmWriteGoody_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If m_initGoody Is Nothing Then
            InitForm(m_goody, m_goody)
        Else
            InitForm(m_initGoody, m_goody)
        End If

    End Sub

    Private Sub InitForm(oldGoody As Goody, newGoody As Goody)

        If m_initGoody IsNot Nothing Then
            Me.Text = "Para-bd ref. n°" & newGoody.getId & " (copie)"
        ElseIf newGoody.GetId IsNot Nothing Then
            Me.Text = "Para-bd ref. n°" & newGoody.getId
        Else
            Me.Text = "Nouveau para-bd"
        End If

        InitImages(oldGoody, newGoody)

        Dim serviceSerie As New ServiceSerie
        slst_series.AddRange(oldGoody.GetSeries.ToArray)
        slst_series.SetValues(serviceSerie.GetAll.ToArray)
        slst_series.SetValues(serviceSerie.GetAll)

        Dim serviceEditor As New ServiceEditor
        If oldGoody.GetEditors IsNot Nothing Then
            For Each edt As Editor In oldGoody.GetEditors
                slst_editors.AddItem(edt)
            Next
        End If
        slst_editors.SetValues(serviceEditor.GetAll.ToArray)

        InitAuthors(oldGoody)

        cmbKindOfGoody.Items.Clear()
        Dim serviceKindOfGoody As New ServiceKindOfGoody
        Dim kindsOfGoodyList As List(Of IdBObject) = serviceKindOfGoody.GetAll
        For Each KindOfGoody As KindOfGoody In kindsOfGoodyList
            cmbKindOfGoody.Items.Add(KindOfGoody)
        Next
        cmbKindOfGoody.SelectedItem = oldGoody.GetKindOfGoody

        If oldGoody.GetPossessionState IsNot Nothing Then
            btn_possessionState.Tag = oldGoody.GetPossessionState.GetId
            btn_possessionState.Image = PossessionStatesUtils.GetImage(btn_possessionState.Tag)
        Else
            btn_possessionState.Tag = Nothing
            btn_possessionState.Image = Nothing
        End If

        cmbCollection.Items.Clear()
        Dim serviceCollection As New ServiceCollection
        Dim collectionList As List(Of IdBObject) = serviceCollection.GetAll
        For Each collection As Collection In collectionList
            cmbCollection.Items.Add(collection)
        Next
        If oldGoody.GetCollection IsNot Nothing Then
            cmbCollection.SelectedItem = oldGoody.GetCollection
        End If

        rtbDescription.Text = oldGoody.GetDescription
        txtNumber.Text = oldGoody.GetNumber

        cmbNumberType.Items.Clear()
        Dim serviceGoody As New ServiceGoody
        Dim numberTypesList As List(Of String) = serviceGoody.GetNumberTypes
        For Each numberType As String In numberTypesList
            If numberType Is Nothing Then
                cmbNumberType.Items.Add("")
            Else
                cmbNumberType.Items.Add(numberType)
            End If
        Next
        cmbNumberType.Text = oldGoody.GetNumberType

        If oldGoody.GetNumberMax IsNot Nothing Then
            txtNumberMax.Text = oldGoody.GetNumberMax
        End If

        rtbAutograph.Text = oldGoody.GetAutograph
        dtxtParutionDate.SetDate(oldGoody.GetParutionDate)
        dtxtBoughtDate.SetDate(oldGoody.GetBoughtDate)

        If oldGoody.GetWidth IsNot Nothing Then
            txtWidth.Text = oldGoody.GetWidth
        End If

        If oldGoody.GetHeight IsNot Nothing Then
            txtHeight.Text = oldGoody.GetHeight
        End If

        rtbFormat.Text = oldGoody.GetFormat
        rtbComments.Text = oldGoody.GetComments

        chkScanned.Checked = oldGoody.IsScanned

        If oldGoody.GetNumberInCollection IsNot Nothing Then
            txtNumberInCollection.Text = oldGoody.GetNumberInCollection
        End If

    End Sub

    Private Sub InitImages(oldGoody As Goody, newGoody As Goody)

        Dim files As List(Of IFile) = m_serviceGoody.GetFiles(oldGoody)

        plstPictures.Clear()
        plstPictures.Enabled = True

        Dim fileNameBuilder As New GoodyFileNameBuilder(newGoody)
        plstPictures.SetFileNameBuilder(fileNameBuilder)

        If oldGoody Is newGoody Then
            plstPictures.AddRange(files)
        Else

            Dim p As Image
            Dim i As Integer = 1

            For Each f As IFile In files
                p = ImageUtils.LoadImage(f)
                plstPictures.Add(fileNameBuilder.GetFile(i), p)
                i += 1
            Next

        End If

    End Sub

    Private Sub InitEditions(goody As Goody)

        Dim kindOfGoodyName As String = CType(cmbKindOfGoody.SelectedItem, KindOfGoody).GetName
        If IsLinkedWithEditions(kindOfGoodyName) Then

            slst_editions.Enabled = True
            slst_editions.AddRange(goody.GetEditions.ToArray)

            Dim serviceEdition As New ServiceEdition
            slst_editions.ClearValues()
            For Each s As Serie In slst_series.Items
                slst_editions.AddValues(serviceEdition.GetAllBySerie(s).ToArray)
            Next

        Else
            slst_editions.ClearValues()
            slst_editions.Enabled = False

        End If

    End Sub

    Private Sub InitAuthors(goody As Goody)

        Dim serviceAuthor As New ServiceAuthor

        slst_authors.Enabled = True
        slst_authors.Clear()
        slst_authors.AddRange(goody.GetAuthors.ToArray)
        slst_authors.SetValues(serviceAuthor.GetAll().ToArray)

    End Sub

    Private Sub cmbKindOfGoody_TextChanged(sender As Object, e As EventArgs) Handles cmbKindOfGoody.TextChanged

        Dim found As Boolean = False
        Dim txt As String = cmbKindOfGoody.Text.ToLower

        For Each item As KindOfGoody In cmbKindOfGoody.Items
            If item.ToString.ToLower = txt Then
                cmbKindOfGoody.SelectedItem = item

                If m_initGoody Is Nothing Then
                    InitEditions(m_goody)
                Else
                    InitEditions(m_initGoody)
                End If

                found = True
                Exit For
            End If
        Next

        If Not found Then
            slst_editions.Clear()
            slst_editions.ClearValues()
            slst_editions.Enabled = False
        End If

    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        If ValidateBeforeSave() Then

            With m_goody

                .SetSeries(GetSeries())
                .SetEditors(GetEditors)
                .SetKindOfGoody(GetKindOfGoody)
                .SetEditions(GetEditions)
                .SetAuthors(GetAuthors)
                .SetCollection(GetCollection)
                .SetPossessionState(GetPossessionState)

                .SetDescription(GetStringValue(rtbDescription))
                .SetParutionDate(dtxtParutionDate.GetDate)
                .SetBoughtDate(dtxtBoughtDate.GetDate)
                .SetWidth(GetIntegerValue(txtWidth))
                .SetHeight(GetIntegerValue(txtHeight))
                .SetFormat(GetStringValue(rtbFormat))
                .SetNumber(GetStringValue(txtNumber))
                .SetNumberType(GetStringValue(cmbNumberType))
                .SetNumberMax(GetIntegerValue(txtNumberMax))
                .SetAutograph(GetStringValue(rtbAutograph))
                .SetComments(GetStringValue(rtbComments))
                .SetNumberInCollection(GetIntegerValue(txtNumberInCollection))
                .SetScanned(chkScanned.Checked)

                plstPictures.SavePictures()

            End With

            m_modifiedGoody.AddChangedFieldName("bidon")

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End If

    End Sub

    Private Function ValidateBeforeSave() As Boolean

        Dim allowSave As Boolean = False
        Dim errMsg As String = Nothing

        Dim series As List(Of IdBObject) = GetSeries()
        If (series Is Nothing) OrElse (series.Count = 0) Then
            errMsg = "Indiquez au moins une série."
        End If

        Dim kindOfGoodyName As String = cmbKindOfGoody.Text.Trim.ToLower
        If (cmbKindOfGoody.SelectedItem Is Nothing) AndAlso (String.IsNullOrEmpty(kindOfGoodyName)) Then
            errMsg = "Indiquez un type d'objet."
        Else
            If (slst_editions.Count = 0) AndAlso IsLinkedWithEditions(kindOfGoodyName) Then
                errMsg = "Pour un para-bd de type " & kindOfGoodyName & ", une ou plusieurs éditions doivent être saisies."
            End If
        End If

        Dim value As String = dtxtParutionDate.Text.Trim
        If (Not String.IsNullOrEmpty(value)) AndAlso (Not IsDate(value)) Then
            errMsg = "Le format de la date de parution n'est pas valide."
        End If

        Dim possessionState As PossessionStates = btn_possessionState.Tag
        value = dtxtBoughtDate.Text.Trim
        If (Not String.IsNullOrEmpty(value)) AndAlso (Not IsDate(value)) Then
            errMsg = "Le format de la date d'obtention n'est pas valide."
        End If
        If ((possessionState <> PossessionStates.InPossession) AndAlso (Not String.IsNullOrEmpty(value))) Then
            errMsg = "La date d'obtention est renseignée, cependant l'édition n'est pas notée ""En possession""."
        End If
        If ((possessionState = PossessionStates.InPossession) AndAlso (String.IsNullOrEmpty(value))) Then
            Dim msg = "Le para-bd est noté ""En possession"", cependant la date d'obtention n'est pas renseignée."
            If MsgBox(msg & vbCrLf & "Voulez-vous tout de même enregistrer le para-bd ?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Erreur...") = MsgBoxResult.No Then
                errMsg = msg
            End If
        End If

        value = txtWidth.Text.Trim
        If (Not String.IsNullOrEmpty(value)) AndAlso ((Not IsNumeric(value)) OrElse (Integer.Parse(value).ToString <> value)) Then
            errMsg = "Le format de la largeur n'est pas valide. La largeur doit être un nombre entier exprimé en millimètres."
        End If

        value = txtHeight.Text.Trim
        If (Not String.IsNullOrEmpty(value)) AndAlso ((Not IsNumeric(value)) OrElse (Integer.Parse(value).ToString <> value)) Then
            errMsg = "Le format de la hauteur n'est pas valide. La hauteur doit être un nombre entier exprimé en millimètres."
        End If

        value = txtNumberMax.Text.Trim
        If (Not String.IsNullOrEmpty(value)) AndAlso ((Not IsNumeric(value)) OrElse (Integer.Parse(value).ToString <> value)) Then
            errMsg = "Le format de la numérotation max n'est pas valide. La valeur doit être un nombre entier."
        End If

        If errMsg IsNot Nothing Then
            Call MsgBox(errMsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Informations incomplètes ou erronées...")
        Else

            If m_goody Is Nothing Then
                Dim serviceGoody As New ServiceGoody
                m_goody = serviceGoody.GetNew
            End If
            allowSave = True
        End If

        Return allowSave

    End Function

    Private Function GetStringValue(ctrl As Control) As String

        Dim value As String = ctrl.Text.Trim

        If String.IsNullOrEmpty(value) Then
            value = Nothing
        End If

        Return value

    End Function

    Private Function GetIntegerValue(ctrl As Control) As Nullable(Of Integer)

        Dim value As String = ctrl.Text.Trim
        Dim result As Nullable(Of Integer) = Nothing

        If Not String.IsNullOrEmpty(value) Then
            result = Integer.Parse(value)
        End If

        Return result

    End Function

    Private Function GetEditors() As List(Of IdBObject)

        Dim editors As List(Of IdBObject)

        If slst_editors Is Nothing Then
            editors = Nothing
        Else
            editors = New List(Of IdBObject)

            For Each edt As Editor In slst_editors.Items
                editors.Add(edt)
            Next
        End If

        Return editors

    End Function

    Private Function GetSeries() As List(Of IdBObject)

        Dim result As List(Of IdBObject) = Nothing
        Dim c As Integer = slst_series.Count

        If c > 0 Then

            result = New List(Of IdBObject)(c)

            For Each serie As Serie In slst_series.Items
                result.Add(serie)
            Next

        End If

        Return result

    End Function

    Private Function GetEditions() As List(Of IdBObject)

        Dim result As List(Of IdBObject) = Nothing

        Dim c As Integer = slst_editions.Count
        Dim kindOfGoodyName As String = cmbKindOfGoody.Text

        If (c > 0) AndAlso IsLinkedWithEditions(kindOfGoodyName) Then

            result = New List(Of IdBObject)

            For Each edition As Edition In slst_editions.Items
                result.Add(edition)
            Next

        End If

        Return result

    End Function

    Private Function GetAuthors() As List(Of IdBObject)

        Dim result As List(Of IdBObject) = Nothing

        Dim c As Integer = slst_authors.Count

        If c > 0 Then

            result = New List(Of IdBObject)

            For Each author As Author In slst_authors.Items()
                result.Add(author)
            Next

        End If

        Return result

    End Function

    Private Function GetKindOfGoody() As KindOfGoody

        Dim kindOfGoody As KindOfGoody = cmbKindOfGoody.SelectedItem
        Dim kindOfGoodyName As String = cmbKindOfGoody.Text.Trim

        If kindOfGoody Is Nothing AndAlso kindOfGoodyName <> "" Then

            If MsgBox("Le type de para-bd saisi """ & kindOfGoodyName & """ n'existe pas. Voulez-vous le créer ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Type de para-bd inconnu...") = MsgBoxResult.Yes Then

                Dim serviceKindOfGoody As New ServiceKindOfGoody

                kindOfGoody = serviceKindOfGoody.GetNew
                kindOfGoody.SetName(kindOfGoodyName.Substring(0, 1).ToUpper & kindOfGoodyName.Substring(1))

                serviceKindOfGoody.InsertOrUpdate(kindOfGoody)

            Else
                Throw New Exception("Donnée invalide")
            End If

        End If

        Return kindOfGoody

    End Function

    Private Function GetCollection() As Collection

        Dim collection As Collection = cmbCollection.SelectedItem
        Dim collectionName As String = cmbCollection.Text.Trim

        If collection Is Nothing AndAlso collectionName <> "" Then

            If MsgBox("La collection saisie """ & collectionName & """ n'existe pas. Voulez-vous la créer ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Collection inconnue...") = MsgBoxResult.Yes Then

                Dim servicecollection As New ServiceCollection

                collection = servicecollection.GetNew
                collection.SetName(collectionName.Substring(0, 1).ToUpper & collectionName.Substring(1))

                servicecollection.InsertOrUpdate(collection)

            Else
                Throw New Exception("Donnée invalide")
            End If

        End If

        Return collection

    End Function

    Private Function GetPossessionState() As PossessionState

        Dim svcPossessionState As New ServicePossessionState
        Dim idPossessionState As Long? = CType(btn_possessionState.Tag, Long)

        Return CType(svcPossessionState.GetById(idPossessionState), BoPossessionState)

    End Function

    Private Function IsLinkedWithEditions(p_kindOfGoody As String) As Boolean

        Dim kog As String = p_kindOfGoody.Trim.ToLower
        Dim isLinked As Boolean = False

        If Not String.IsNullOrEmpty(kog) _
        And ((kog = "coffret") _
             OrElse (kog = "fourreau") _
             OrElse (kog = "jaquette")) _
        Then
            isLinked = True
        End If

        Return isLinked

    End Function

    Private Sub btn_possessionState_Click(sender As Object, e As EventArgs) Handles btn_possessionState.Click
        btn_possessionState.Tag = FrmPossessionState.GetPossessionState(CType(btn_possessionState.Tag, PossessionStates), Me)
        btn_possessionState.Image = PossessionStatesUtils.GetImage(btn_possessionState.Tag)
    End Sub


    Private Sub slst_authors_AddItemClick(sender As SelectList) Handles slst_authors.AddItemClick

        Dim modifiedItem As ModifiedItem = FrmWriteAuthor.CreateOrEdit(Me.ParentForm, Nothing)

        If modifiedItem IsNot Nothing Then

            Dim newAuthor As Author = modifiedItem.GetItem

            If newAuthor IsNot Nothing Then
                slst_authors.AddItem(newAuthor)
            End If

        End If

    End Sub

    Private Sub slst_editors_AddItemClick(sender As SelectList) Handles slst_editors.AddItemClick

        Dim modifiedItem As ModifiedItem = FrmWriteEditor.CreateOrEdit(Me.ParentForm, Nothing)

        If modifiedItem IsNot Nothing Then

            Dim newEditor As Editor = modifiedItem.GetItem

            If newEditor IsNot Nothing Then
                slst_editors.AddItem(newEditor)
            End If

        End If

    End Sub

End Class
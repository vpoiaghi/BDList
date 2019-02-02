Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class FrmWriteAuthor

    Private Shared m_serviceAuthor As New ServiceAuthor()
    Private Shared m_servicePerson As New ServicePerson()

    Private m_author As Author
    Private m_person As Person
    Private m_authorResult As Author

    Private m_withPicture As Boolean
    Private m_personChanged As Boolean

    Private Sub New()
        MyBase.New()

        InitializeComponent()

        m_author = Nothing
        m_person = Nothing
        m_authorResult = Nothing
        m_withPicture = False

        pctPicture.AllowDrop = True

        m_personChanged = False

    End Sub

    Private Sub New(ByRef author As Author)
        Me.New()
        m_author = author
    End Sub

    Public Shared Function CreateOrEdit(owner As Form, author As Author) As ModifiedItem

        Dim isNewAuthor As Boolean = False
        Dim modifiedEdition As ModifiedItem = Nothing

        If author Is Nothing Then
            author = m_serviceAuthor.GetNew()
            author.GetPersons.Add(m_servicePerson.GetNew())
            isNewAuthor = True
        End If

        If author Is Nothing Then
            Throw New NullReferenceException()

        Else
            modifiedEdition = New ModifiedItem(author)

            Dim frm As New FrmWriteAuthor(author)
            frm.ShowDialog(owner)

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                m_serviceAuthor.InsertOrUpdate(author)
            Else
                If isNewAuthor Then
                    m_serviceAuthor.Delete(author)
                End If
                modifiedEdition = Nothing
            End If

            frm.Close()
            frm.Dispose()

        End If

        Return modifiedEdition

    End Function

    Public Function GetAuthor() As Author
        Return m_authorResult
    End Function

    Private Sub FrmWritePerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If m_author IsNot Nothing Then

            LblAuthorId.Text = m_author.GetId
            TxtAlias.Text = m_author.GetAlias

            Dim persons As List(Of IdBObject) = m_author.GetPersons

            If persons.Count > 0 Then

                For Each p As Person In m_author.GetPersons
                    LvwPersons.Items.Add(p.ToString).Tag = p
                Next

                LvwPersons.Items(0).Selected = True

            End If

        End If

    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        If ValidateBeforeSave() Then
            Save()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Function ValidateBeforeSave() As Boolean

        Dim serviceAuthor As New ServiceAuthor
        Dim servicePerson As New ServicePerson

        Dim allowSave As Boolean = False
        Dim errMsg As String = Nothing

        If String.IsNullOrEmpty(TxtFirstname.Text) _
        And String.IsNullOrEmpty(TxtLastname.Text) _
        And String.IsNullOrEmpty(TxtAlias.Text) _
        Then
            errMsg = "Indiquez au moins un nom, un prénom ou un pseudonyme."
        End If

        Dim firstname As String = TxtFirstname.Text
        firstname = firstname.Trim
        If Not String.IsNullOrEmpty(firstname) Then
            TxtFirstname.Text = firstname.Substring(0, 1).ToUpper & firstname.Substring(1)
        Else
            TxtFirstname.Text = ""
        End If

        Dim lastname As String = TxtLastname.Text
        lastname = lastname.Trim
        If Not String.IsNullOrEmpty(lastname) Then
            TxtLastname.Text = lastname.Substring(0, 1).ToUpper & lastname.Substring(1)
        Else
            TxtLastname.Text = ""
        End If

        Dim allias As String = TxtAlias.Text
        allias = allias.Trim
        If Not String.IsNullOrEmpty(allias) Then
            TxtAlias.Text = allias.Substring(0, 1).ToUpper & allias.Substring(1)
        Else
            TxtAlias.Text = ""
        End If

        If errMsg IsNot Nothing Then
            Call MsgBox(errMsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Informations incomplètes...")
            allowSave = False
        Else
            allowSave = True

            If (lastname & "," & firstname).ToLower <> (m_person.GetLastname & "," & m_person.GetFirstname).ToLower Then

                ' Vérifier que la nouvelle personne ne correspond pas à une personne existante.
                Dim lstPersons As List(Of IdBObject) = servicePerson.GetByNames(lastname, firstname)

                If (lstPersons.Count > 0) Then
                    ' Si une personne portant ce nom/prénom existe déjà.

                    ' Demander confirmation pour modifier la personne existante.
                    ' Si non, l'enregistrement est annulé.
                    Dim msg As String = "Une personne du même nom et/ou pseudo existe déjà. Voulez-vous modifier la peronne existant ?" & vbCrLf _
                                      & "Note : La personne initialement sélectionnée pour être modifiée (" & m_person.ToString & ") ne sera pas modifiée."

                    If MsgBox(msg, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Personne existante...") = MsgBoxResult.Yes Then
                        m_person = lstPersons(0)
                    Else
                        allowSave = False
                    End If
                End If

            End If


            If (m_author IsNot Nothing) AndAlso (allias.ToLower <> ("" & m_author.GetAlias).ToLower) Then

                ' Vérifier que le nouvel auteur ne correspond pas à un auteur existant.
                Dim lstAuthors As List(Of IdBObject) = serviceAuthor.GetByAlias(allias)

                If (lstAuthors.Count > 0) Then
                    ' Si un auteur portant ce pseudo existe déjà.

                    ' Demander confirmation pour modifier l'auteur existant.
                    ' Si non, l'enregistrement est annulé.
                    Dim msg As String = "Un auteur du même pseudo existe déjà. Voulez-vous modifier l'auteur existant ?" & vbCrLf _
                                      & "Note : L'auteur initialement sélectionné pour être modifié (" & m_author.ToString & ") ne sera pas modifié."

                    If MsgBox(msg, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Personne existante...") = MsgBoxResult.Yes Then
                        m_author = lstAuthors(0)
                    Else
                        allowSave = False
                    End If
                End If

            End If

        End If

        Return allowSave

    End Function

    Private Sub Save()

        SavePerson()

        Dim serviceAuthor As New ServiceAuthor

        If m_author Is Nothing Then
            m_author = serviceAuthor.GetNew

            If m_person IsNot Nothing Then
                m_author.GetPersons.Add(m_person)
            End If

        End If


        m_author = SaveAuthor(m_author, m_person)

        m_authorResult = m_author

        SavePicture(m_author)


    End Sub

    Private Sub SavePerson()

        If m_person Is Nothing Then
            m_person = (New ServicePerson).GetNew
        End If

        m_person.SetFirstname(TxtFirstname.Text)
        m_person.SetLastname(TxtLastname.Text)
        m_person.SetWebSite(TxtWebSite.Text.Trim)
        m_person.SetBiography(RtbBiography.Text.Trim)
        m_person.SetBirthDay(DtbBirthday.GetDate)
        m_person.SetBirthPlace(TxtBirthPlace.Text.Trim)
        m_person.SetBirthCountry(TxtBirthCountry.Text.Trim)
        m_person.SetDeathDay(DtbDeathday.GetDate)

        m_personChanged = False

    End Sub

    Private Function SaveAuthor(p_author As Author, p_person As Person) As Author

        p_author.SetAlias(TxtAlias.Text)

        Return p_author

    End Function

    Private Sub LoadPicture(p_author As Author)
        LoadPicture((New ServiceAuthor).GetFilePath(p_author))
    End Sub

    Private Sub LoadPicture(p_person As Person)
        LoadPicture((New ServicePerson).GetFilePath(p_person))
    End Sub

    Private Sub LoadPicture(p_filePath As String)

        Dim img As Image = ImageUtils.LoadImage(p_filePath)

        If img Is Nothing Then
            pctPicture.Image = My.Resources.nobody
            m_withPicture = False
        Else
            pctPicture.Image = img
            m_withPicture = True
        End If

    End Sub

    Private Sub SavePicture(p_author As Author)
        If m_withPicture = True Then
            SavePicture((New ServiceAuthor).GetFile(p_author))
        End If
    End Sub

    Private Sub SavePicture(p_person As Person)
        If m_withPicture = True Then
            SavePicture((New ServicePerson).GetFile(p_person))
        End If
    End Sub

    Private Sub SavePicture(p_file As IFile)
        ImageUtils.SaveImage(pctPicture.Image, p_file)
    End Sub

    Private Sub pctPicture_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pctPicture.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub pctPicture_DragDrop(sender As Object, e As DragEventArgs) Handles pctPicture.DragDrop

        Try
            ' recupere la donnée
            'Variable qui contiendra un tableau contenant les fichiers
            Dim strFiles As Object

            'on recupere le drop dans le tableau
            strFiles = e.Data.GetData(DataFormats.FileDrop)
            strFiles = e.Data.GetData(DataFormats.Html)

            ' on recupere le début de l'adresse de l'image
            Dim addressStart() As String = Split(strFiles.ToString, "src=")

            ' ensuite on ne prend que la source
            ' prend le guillemet 
            Dim guillemet = Chr(34)
            Dim adresse = Split(addressStart(1), guillemet)

            ' extraction de l'image
            Dim newPicture As Image = RecupFichierImageInternet(adresse(1))

            ' enregistrement de l'image
            If newPicture IsNot Nothing Then
                pctPicture.Image = newPicture
                m_withPicture = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function RecupFichierImageInternet(ByVal UrlFichier As String) As Image

        Dim WebClient As New System.Net.WebClient
        Dim imageToAdd As Image = Nothing

        Try
            Dim WebResponse As System.IO.Stream
            Dim FichierDistant As String = UrlFichier.Replace("&amp;", "&")
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

    Private Sub LvwPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvwPersons.SelectedIndexChanged

        If LvwPersons.SelectedItems.Count > 0 Then

            Dim newSelectedPerson As Person = CType(LvwPersons.SelectedItems(0).Tag, Person)

            If m_personChanged AndAlso (Not m_person.Equals(newSelectedPerson)) Then

                If MsgBox("Des modification ont été apportées à la personne en cours. Voulez-vous enregistrer ces modification ?", _
                          MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Personne modifiée...") = MsgBoxResult.Yes Then

                    SavePerson()

                End If
            End If

            m_person = newSelectedPerson
            LoadPersonInfos()

        End If

    End Sub

    Private Sub LoadPersonInfos()

        With m_person

            TxtLastname.Text = .GetLastname
            TxtFirstname.Text = .GetFirstname
            TxtWebSite.Text = .GetWebSite
            DtbBirthday.SetDate(.GetBirthDay)
            TxtBirthPlace.Text = .GetBirthPlace
            TxtBirthCountry.Text = .GetBirthCountry
            DtbDeathday.SetDate(.GetDeathDay)
            RtbBiography.Text = .GetBiography

        End With

        LoadPicture(m_author)

        InitAliasesList(m_person)

        m_personChanged = False

    End Sub

    Private Sub InitAliasesList(p_person As Person)

        LvwAliases.Clear()

        Dim authors As List(Of IdBObject) = (New ServiceAuthor).GetByPerson(p_person)

        For Each a As Author In authors

            If a.IsAlias() Then

                With LvwAliases.Items.Add(a.ToString)
                    .Tag = a
                End With
            End If

        Next

    End Sub

    Private Sub BtnAddPerson_Click(sender As Object, e As EventArgs) Handles BtnAddPerson.Click

        Dim p As Person = FrmSelectPerson.SelectPerson(Me)

        If p IsNot Nothing Then

            Dim itemFound As Boolean = False

            For Each item As ListViewItem In LvwPersons.Items

                If item.Tag.Equals(p) Then
                    item.Selected = True
                    itemFound = True
                End If
            Next

            If Not itemFound Then
                With LvwPersons.Items.Add(p.ToString)
                    .Tag = p
                    .Selected = True
                End With
            End If

        End If

    End Sub

    Private Sub BtnDeletePerson_Click(sender As Object, e As EventArgs) Handles BtnDeletePerson.Click

        If LvwPersons.SelectedItems.Count > 0 Then

            If MsgBox("Voulez-vous supprimer cette personne pour ce pseudo ?", _
                      MsgBoxStyle.Question + MsgBoxStyle.YesNo, _
                      "Suppression de personne derrière un pseudo...") = MsgBoxResult.Yes Then

                m_person = Nothing
                CleanPerson()
                LvwPersons.Items.RemoveAt(LvwPersons.SelectedIndices(0))

                If LvwPersons.Items.Count > 0 Then
                    LvwPersons.Items(0).Selected = True
                End If

            End If

        End If

    End Sub

    Private Sub CleanPerson()

        m_person = Nothing

        TxtLastname.Text = ""
        TxtFirstname.Text = ""
        TxtWebSite.Text = ""
        DtbBirthday.SetDate(Nothing)
        TxtBirthPlace.Text = ""
        DtbDeathday.SetDate(Nothing)
        RtbBiography.Text = ""

        pctPicture.Image = My.Resources.nobody

        m_personChanged = False

    End Sub

    Private Sub TxtLastname_TextChanged(sender As Object, e As EventArgs) Handles TxtLastname.TextChanged
        m_personChanged = True
    End Sub

    Private Sub TxtFirstname_TextChanged(sender As Object, e As EventArgs) Handles TxtFirstname.TextChanged
        m_personChanged = True
    End Sub

    Private Sub TxtWebSite_TextChanged(sender As Object, e As EventArgs) Handles TxtWebSite.TextChanged
        m_personChanged = True
    End Sub

    Private Sub DtbBirthday_TextChanged(sender As Object, e As EventArgs) Handles DtbBirthday.TextChanged
        m_personChanged = True
    End Sub

    Private Sub TxtBirthPlace_TextChanged(sender As Object, e As EventArgs) Handles TxtBirthPlace.TextChanged
        m_personChanged = True
    End Sub

    Private Sub DtbDeathday_TextChanged(sender As Object, e As EventArgs) Handles DtbDeathday.TextChanged
        m_personChanged = True
    End Sub

    Private Sub RtbBiography_TextChanged(sender As Object, e As EventArgs) Handles RtbBiography.TextChanged
        m_personChanged = True
    End Sub

    Private Sub BtnAddAlias_Click(sender As Object, e As EventArgs) Handles BtnAddAlias.Click

        Dim author As Author = FrmWriteAuthorAlias.Create(Me, m_person)

        If author IsNot Nothing Then
            LvwAliases.Items.Add(author.ToString).Tag = author
        End If

    End Sub

    Private Sub BtnShowAlias_Click(sender As Object, e As EventArgs) Handles BtnShowAlias.Click

    End Sub
End Class
Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class FrmWriteEditor

    Private Shared m_svcEditor As New ServiceEditor

    Private m_editor As Editor
    Private m_modifiedEditor As ModifiedItem
    Private m_withPicture As Boolean

    Private Sub New()
        MyBase.New()

        InitializeComponent()
        pct_Editor.AllowDrop = True

    End Sub

    Private Sub New(ByRef EditorToEdit As ModifiedItem)
        Me.New()

        If (EditorToEdit Is Nothing) OrElse (EditorToEdit.GetItem Is Nothing) Then
            Throw New ArgumentNullException()
        End If

        m_editor = EditorToEdit.GetItem
        m_modifiedEditor = EditorToEdit
        m_withPicture = False

    End Sub

    Private Function GetModifiedEditor() As ModifiedItem
        Return m_modifiedEditor
    End Function

    Public Shared Function CreateOrEdit(owner As Form, editor As Editor) As ModifiedItem

        If editor Is Nothing Then
            editor = CType(m_svcEditor.GetNew, Editor)
        End If

        Dim frm As New FrmWriteEditor(New ModifiedItem(editor))
        frm.ShowDialog(owner)
        frm.Dispose()

        Dim modifiedEditor As ModifiedItem = frm.GetModifiedEditor()

        If (modifiedEditor IsNot Nothing) Then
            m_svcEditor.InsertOrUpdate(modifiedEditor.GetItem)
        End If

        Return modifiedEditor

    End Function

    Private Sub FrmWriteEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If m_editor.GetId IsNot Nothing Then
            Me.Text = "Editeur ref. n°" & m_editor.GetId
        Else
            Me.Text = "Nouvel éditeur"
        End If

        pct_Editor.Image = GetImage(m_editor)

        txt_name.Text = m_editor.GetName

        If Not String.IsNullOrEmpty(m_editor.GetNationality) Then
            txt_nationality.Text = m_editor.GetNationality
        End If
        If m_editor.GetFoundationYear IsNot Nothing Then
            txt_foundationYear.Text = m_editor.GetFoundationYear
        End If
        If m_editor.GetCessationYear IsNot Nothing Then
            txt_cessationYear.Text = m_editor.GetCessationYear
        End If
        If Not String.IsNullOrEmpty(m_editor.GetCessationCause) Then
            txt_cessationCause.Text = m_editor.GetCessationCause
        End If
        If Not String.IsNullOrEmpty(m_editor.GetLegalForm) Then
            txt_legalForm.Text = m_editor.GetLegalForm
        End If
        If Not String.IsNullOrEmpty(m_editor.GetStatus) Then
            txt_status.Text = m_editor.GetStatus
        End If
        If Not String.IsNullOrEmpty(m_editor.GetHeadOffice) Then
            txt_headOffice.Text = m_editor.GetHeadOffice
        End If
        If Not String.IsNullOrEmpty(m_editor.GetHeadQuarters) Then
            txt_headQuarters.Text = m_editor.GetHeadQuarters
        End If
        If Not String.IsNullOrEmpty(m_editor.GetNationality) Then
            txt_broadcasting.Text = m_editor.GetBroadcasting
        End If
        If Not String.IsNullOrEmpty(m_editor.GetNationality) Then
            txt_webSite.Text = m_editor.GetWebSite
        End If
        If Not String.IsNullOrEmpty(m_editor.GetNationality) Then
            txt_comingWebSite.Text = m_editor.GetComingWebSite
        End If

        Dim servicePerson As New ServicePerson
        With slst_managers
            .Enabled = True
            .Clear()
            If m_editor.GetManager IsNot Nothing Then
                .AddItem(m_editor.GetManager)
            End If
            .SetValues(servicePerson.GetAll().ToArray)
        End With

    End Sub

    Private Function GetImage(editor As Editor) As Image

        Dim img As Image = Nothing
        Dim file As IFile = m_svcEditor.GetFile(editor)

        If file IsNot Nothing Then
            img = ImageUtils.LoadImage(file.GetFullName)
        End If

        If img Is Nothing Then
            img = My.Resources.editor_no_picture
            m_withPicture = False
        Else
            m_withPicture = True
        End If

        Dim g As Graphics = Graphics.FromImage(img)
        g.DrawRectangle(Pens.Black, 0, 0, img.Width - 1, img.Height - 1)
        g.Dispose()

        Return img

    End Function
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If ValidateBeforeSave() Then

            With m_editor

                .SetManager(GetManager)

                m_editor.SetName(GetStringValue(txt_name))
                m_editor.SetNationality(GetStringValue(txt_nationality))
                m_editor.SetFoundationYear(GetIntegerValue(txt_foundationYear))
                m_editor.SetCessationYear(GetIntegerValue(txt_cessationYear))
                m_editor.SetCessationCause(GetStringValue(txt_cessationCause))
                m_editor.SetLegalForm(GetStringValue(txt_legalForm))
                m_editor.SetStatus(GetStringValue(txt_status))
                m_editor.SetHeadOffice(GetStringValue(txt_headOffice))
                m_editor.SetHeadQuarters(GetStringValue(txt_headQuarters))
                m_editor.SetBroadcasting(GetStringValue(txt_broadcasting))
                m_editor.SetWebSite(GetStringValue(txt_webSite))
                m_editor.SetComingWebSite(GetStringValue(txt_comingWebSite))

                If m_withPicture Then
                    ImageUtils.SaveImage(pct_Editor.Image, m_svcEditor.GetFile(m_editor))
                End If


            End With

            m_modifiedEditor.AddChangedFieldName("bidon")

            Me.Close()

        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

        m_modifiedEditor = Nothing
        Me.Close()

    End Sub

    Private Function GetManager() As BoPerson

        Dim result As List(Of IdBObject) = Nothing

        Dim c As Integer = slst_managers.Count

        If c > 0 Then

            result = New List(Of IdBObject)

            For Each manager As Person In slst_managers.Items()
                result.Add(manager)
            Next

        End If

        If (result IsNot Nothing) AndAlso (result.Count > 0) Then
            Return result(0)
        Else
            Return Nothing
        End If

    End Function

    Private Function ValidateBeforeSave() As Boolean

        Dim allowSave As Boolean = False
        Dim errMsg As String = Nothing

        Dim foundationYear As String = txt_foundationYear.Text.Trim
        Dim cessationYear As String = txt_cessationYear.Text.Trim
        Dim name As String = txt_name.Text.Trim


        If (Not String.IsNullOrEmpty(foundationYear)) AndAlso (Not IsNumeric(foundationYear)) Then
            errMsg = "Le format de la date de fondation est invalide."
        End If

        If (Not String.IsNullOrEmpty(cessationYear)) AndAlso (Not IsNumeric(cessationYear)) Then
            errMsg = "Le format de la date de cessation est invalide."
        End If

        If (String.IsNullOrEmpty(name)) Then
            errMsg = "Le nom doit être renseigné."
        End If

        If errMsg IsNot Nothing Then
            Call MsgBox(errMsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Informations incomplètes ou erronées...")
        Else
            If m_editor Is Nothing Then
                m_editor = m_svcEditor.GetNew
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

    Private Sub pct_Editor_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pct_Editor.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub pctPicture_DragDrop(sender As Object, e As DragEventArgs) Handles pct_Editor.DragDrop

        ' Image récupérée
        Dim newPicture As Image = Nothing

        Try
            ' recupere la donnée
            'Variable qui contiendra un tableau contenant les fichiers
            Dim strData As Object

            'on recupere le drop dans le tableau
            strData = e.Data.GetData(DataFormats.FileDrop)

            If strData IsNot Nothing Then

                Try
                    If IO.File.Exists(strData(0)) Then
                        newPicture = ImageUtils.LoadImage(strData(0))
                    End If
                Catch ex As Exception
                End Try

            End If

            If newPicture Is Nothing Then

                strData = e.Data.GetData(DataFormats.Html)

                If strData IsNot Nothing Then
                    ' on recupere le début de l'adresse de l'image
                    Dim addressStart() As String = Split(strData.ToString, "src=")

                    ' ensuite on ne prend que la source
                    ' prend le guillemet 
                    Dim guillemet = Chr(34)
                    Dim adresse = Split(addressStart(1), guillemet)

                    ' extraction de l'image
                    newPicture = RecupFichierImageInternet(adresse(1))

                End If
            End If

            ' enregistrement de l'image
            If newPicture IsNot Nothing Then
                pct_Editor.Image = newPicture
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

End Class
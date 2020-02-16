Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class UC_Festivals

    Private m_svcInSigning As New ServiceInSigning
    Private m_svcAuthors As New ServiceAuthor()
    Private m_svcFestivals As New ServiceFestival()
    Private m_festival As Festival

    Private m_withPicture As Boolean

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()

        Pct_Festival.AllowDrop = True

    End Sub

    Protected Overrides Sub Activate()
        RefreshData()
    End Sub

    Private Sub RefreshData(Optional festival As Festival = Nothing)

        m_festival = festival

        Lst_festivals.Items.Clear()
        For Each f As Festival In m_svcFestivals.GetAll()
            Lst_festivals.Items.Add(f)
        Next

        If Lst_festivals.Items.Count > 0 Then
            If (m_festival Is Nothing) Then
                Lst_festivals.SelectedIndex = 0
            Else
                Lst_festivals.SelectedItem = festival
            End If
        End If

    End Sub

    Private Sub RefreshFestival(festival As Festival)

        Btn_editFestival.Enabled = True
        Lbl_festivalDates.Text = festival.GetDatesString()
        InitAuthorsList(festival)

    End Sub

    Private Sub CleanFestival()

        Btn_editFestival.Enabled = False

        Lbl_festivalDates.Text = ""
        LVw_InSigning.Clear()

    End Sub


    Private Sub btn_addFestival_Click(sender As Object, e As EventArgs) Handles Btn_addFestival.Click

        Dim newFestival As ModifiedItem = FrmWriteFestival.CreateOrEdit(Me.ParentForm, Nothing)

        If newFestival IsNot Nothing Then
            RefreshData(newFestival.GetItem)
        End If

    End Sub

    Private Sub btn_editFestival_Click(sender As Object, e As EventArgs) Handles Btn_editFestival.Click

        Dim modifiedFestival As ModifiedItem = FrmWriteFestival.CreateOrEdit(Me.ParentForm, m_festival)

        If modifiedFestival IsNot Nothing Then
            RefreshData(modifiedFestival.GetItem)
        End If


    End Sub

    Private Sub lst_festivals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_festivals.SelectedIndexChanged

        m_festival = CType(sender, ListBox).SelectedItem

        If m_festival Is Nothing Then
            CleanFestival()
        Else
            RefreshFestival(m_festival)
        End If

    End Sub

    Private Sub Btn_AddInSigning_Click(sender As Object, e As EventArgs) Handles Btn_AddInSigning.Click

        Dim result As FrmSelectItems.FrmSelectItemsResult = FrmSelectItems.GetSelectedItems(m_svcAuthors.GetAll, Nothing, Me.ParentForm)

        If (result.DlgResult = DialogResult.OK) AndAlso (result.SelectedItems IsNot Nothing) Then
            For Each author As Author In result.SelectedItems

                Dim inSingning As New InSigning
                inSingning.SetAuthor(author)
                inSingning.SetFestival(m_festival)

                AddAuthorInSigningToList(inSingning)

            Next
        End If

    End Sub

    Private Sub InitAuthorsList(festival As Festival)

        LVw_InSigning.Items.Clear()

        For Each i As InSigning In m_svcInSigning.GetByFestival(festival)
            AddAuthorInSigningToList(i)
        Next

    End Sub

    Private Sub AddAuthorInSigningToList(authorInSigning As InSigning)

        With LVw_InSigning.Items.Add(authorInSigning.GetAuthor().ToString)

            If authorInSigning.GetEditor Is Nothing Then
                .SubItems.Add("")
            Else
                .SubItems.Add(authorInSigning.GetEditor.ToString)
            End If

            .SubItems.Add(Format(authorInSigning.GetDay, "dd/MM/yyyy"))
            .SubItems.Add(Format(authorInSigning.GetStartTime, "hh:mm"))
            .SubItems.Add(Format(authorInSigning.GetEndTime, "hh:mm"))
            .Tag = authorInSigning

        End With

    End Sub

    Private Sub LVw_InSigning_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVw_InSigning.SelectedIndexChanged

        Btn_SetDefaultTime.Enabled = (LVw_InSigning.SelectedItems.Count = 1)

    End Sub

    Private Sub Btn_SetDefaultTime_Click(sender As Object, e As EventArgs) Handles Btn_SetDefaultTime.Click

        Dim author As Author

        If LVw_InSigning.SelectedItems.Count = 1 Then

            author = CType(LVw_InSigning.SelectedItems.Item(0).Tag, InSigning).GetAuthor

            Dim dte1 As Date? = m_festival.GetBeginDate()
            Dim dte2 As Date? = m_festival.GetEndDate()

            If (dte1 IsNot Nothing) AndAlso (dte2 IsNot Nothing) Then

                Dim i As Integer = 0
                While i < LVw_InSigning.Items.Count

                    If CType(LVw_InSigning.Items(i).Tag, InSigning).GetAuthor.GetId = author.GetId Then
                        LVw_InSigning.Items.RemoveAt(i)
                    Else
                        i += 1
                    End If

                End While

                While dte1 <= dte2

                    Dim inSingning As New InSigning
                    inSingning.SetAuthor(author)
                    inSingning.SetDay(dte1)
                    inSingning.SetFestival(m_festival)

                    AddAuthorInSigningToList(inSingning)

                    dte1 = dte1.Value.AddDays(1)

                End While

            End If

        End If

    End Sub

    Private Sub LoadPicture(p_filePath As String)

        Dim img As Image = ImageUtils.LoadImage(p_filePath)

        If img Is Nothing Then
            Pct_Festival.Image = My.Resources.nobody
            m_withPicture = False
        Else
            Pct_Festival.Image = img
            m_withPicture = True
        End If

    End Sub

    Private Sub SavePicture(p_festival As Festival)
        If m_withPicture = True Then
            SavePicture((New ServiceFestival).GetFile(p_festival))
        End If
    End Sub

    Private Sub SavePicture(p_file As IFile)
        ImageUtils.SaveImage(Pct_Festival.Image, p_file)
    End Sub

    Private Sub Pct_Festival_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Pct_Festival.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub Pct_Festival_DragDrop(sender As Object, e As DragEventArgs) Handles Pct_Festival.DragDrop

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
                Pct_Festival.Image = newPicture
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

    Private Sub Pct_Festival_MouseDown(sender As Object, e As MouseEventArgs) Handles Pct_Festival.MouseDown

        If e.Button = MouseButtons.Right Then
            FrmShowImage.ShowImage(CType(sender, PictureBox).Image)
        End If

    End Sub
End Class

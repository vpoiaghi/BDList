Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class FrmWriteAd

    Private Shared m_serviceAd As New ServiceAd

    Private m_ad As Ad
    Private m_adResult As Ad
    Private m_withPicture As Boolean = False

    Private Sub New(ByRef ad As Ad)

        InitializeComponent()

        Pct_Picture.AllowDrop = True
        InitStatesList()

        m_ad = ad

        LoadAd()

    End Sub

    Public Shared Function CreateOrEdit(owner As Form, ad As Ad, purchase As Purchase) As ModifiedItem

        Dim isNewAd As Boolean = False
        Dim modifiedAd As ModifiedItem = Nothing

        If ad Is Nothing Then
            ad = m_serviceAd.GetNew()
            isNewAd = True
        End If

        If ad Is Nothing Then
            Throw New NullReferenceException()

        Else
            modifiedAd = New ModifiedItem(ad)

            Dim frm As New FrmWriteAd(ad)
            frm.ShowDialog(owner)

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                m_serviceAd.InsertOrUpdate(ad)
            Else
                If isNewAd Then
                    m_serviceAd.Delete(ad)
                End If
                modifiedAd = Nothing
            End If

            frm.Close()
            frm.Dispose()

        End If

        Return modifiedAd

    End Function

    Public Function GetAd() As Ad
        Return m_adResult
    End Function

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        If ValidateBeforeSave() Then
            Save()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function ValidateBeforeSave() As Boolean

        Dim allowSave As Boolean = True
        Dim errMsg As String = Nothing

        If String.IsNullOrEmpty(Txt_Title.Text.Trim) Then
            errMsg = "Indiquez le libellé de la vente."
        End If

        If String.IsNullOrEmpty(Txt_Url.Text.Trim) Then
            errMsg = "Indiquez l'url de l'annonce."
        End If

        If String.IsNullOrEmpty(Dtb_EndOfValidity.Text) Then
            errMsg = "Indiquez la date de fin de validité."
        End If

        If String.IsNullOrEmpty(Cmb_State.Text) Then
            errMsg = "Indiquez l'état."
        End If

        If String.IsNullOrEmpty(Txt_CurrentCost.Text) Then
            errMsg = "Indiquez le prix en cours."
        End If

        If errMsg IsNot Nothing Then
            Call MsgBox(errMsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Informations incomplètes...")
            allowSave = False
        End If

        Return allowSave

    End Function

    Private Sub Save()

        If m_ad Is Nothing Then
            m_ad = m_serviceAd.GetNew
        End If

        m_ad.SetTitle(Txt_Title.Text.Trim)
        m_ad.SetUrl(Txt_Url.Text.Trim)
        m_ad.SetState(Cmb_State.SelectedItem)
        m_ad.SetEndOfValidity(Dtb_EndOfValidity.GetDateTime)
        m_ad.SetSellerComments(Rtb_SellerComments.Text.Trim)
        m_ad.SetComments(Rtb_Comments.Text.Trim)

        If (Trim(Txt_articlesCount.Text)).Length > 0 Then
            m_ad.SetArticlesCount(Val(Trim(Txt_articlesCount.Text)))
        End If

        Dim curCost As String = Txt_CurrentCost.Text.Trim
        If Not String.IsNullOrEmpty(curCost) Then
            m_ad.SetCurrentCost(CSng(curCost))
        Else
            m_ad.SetCurrentCost(Nothing)
        End If

        Dim bestPrice As String = Txt_BestPrice.Text.Trim
        If Not String.IsNullOrEmpty(bestPrice) Then
            m_ad.SetBestPrice(CSng(bestPrice))
        Else
            m_ad.SetBestPrice(Nothing)
        End If

        SavePicture(m_ad)

        m_adResult = m_ad

    End Sub

    Private Sub LoadPicture(p_ad As Ad)
        Pct_Picture.Image = Nothing
        LoadPicture((New ServiceAd).GetFilePath(p_ad))
    End Sub

    Private Sub LoadPicture(p_filePath As String)
        LoadPicture(ImageUtils.LoadImage(p_filePath))
    End Sub

    Private Sub LoadPicture(p_img As Image)

        If p_img Is Nothing Then
            Pct_Picture.Image = My.Resources.unknown
            m_withPicture = False
        Else
            Pct_Picture.Image = p_img
            m_withPicture = True
        End If

    End Sub

    Private Sub SavePicture(p_ad As Ad)
        If m_withPicture = True Then
            SavePicture((New ServiceAd).GetFile(p_ad))
        End If
    End Sub

    Private Sub SavePicture(p_file As IFile)
        ImageUtils.SaveImage(Pct_Picture.Image, p_file)
    End Sub

    Private Sub Pct_Picture_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Pct_Picture.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub Pct_Picture_DragDrop(sender As Object, e As DragEventArgs) Handles Pct_Picture.DragDrop

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
                Pct_Picture.Image = newPicture
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

    Private Sub InitStatesList()

        Dim svcAdState As New ServiceAdState

        Cmb_State.Items.Clear()

        For Each state As AdState In svcAdState.GetAll()
            Cmb_State.Items.Add(state)
        Next

    End Sub

    Private Sub LoadAd()

        With m_ad

            Txt_Title.Text = m_ad.GetTitle()
            Txt_Url.Text = m_ad.GetUrl()
            Cmb_State.SelectedItem = m_ad.GetState()
            Dtb_EndOfValidity.SetDateTime(m_ad.GetEndOfValidity())
            Rtb_SellerComments.Text = m_ad.GetSellerComments()
            Rtb_Comments.Text = m_ad.GetComments()

            Txt_articlesCount.Text = m_ad.GetArticlesCount()
            Txt_articlesCount.Enabled = (m_ad.GetAdArticles.Count = 0)

            If m_ad.GetCurrentCost() IsNot Nothing Then
                Txt_CurrentCost.Text = m_ad.GetCurrentCost()
            Else
                Txt_CurrentCost.Text = ""
            End If

            If m_ad.GetBestPrice() IsNot Nothing Then
                Txt_BestPrice.Text = m_ad.GetBestPrice()
            Else
                Txt_BestPrice.Text = ""
            End If

        End With

        LoadPicture(m_ad)
        loadArticles(m_ad)

    End Sub

    Private Sub LoadArticles(ad As Ad)

        Dim adapter As IAdapter = New ChronologicParutionSortAdapter(ad.GetAdArticles())
        GVw_articles.SetAdapter(adapter)

    End Sub

    Private Sub Label9_DragEnter(sender As Object, e As DragEventArgs)
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub Label9_DragDrop(sender As Object, e As DragEventArgs)

        Dim url As String = e.Data.GetData(DataFormats.Text).ToString().Trim()

        If url <> "" Then

            Dim reader As IPurchaseReader = PurchasesReadersFactory.GetPurchaseReader(url)

            LoadPicture(reader.GetImages(0))
            Txt_Title.Text = reader.GetTitle
            Txt_Url.Text = url
            Dtb_EndOfValidity.SetDateTime(reader.GetEndOfValidity)
            Txt_CurrentCost.Text = reader.GetCurrentCost
            Rtb_SellerComments.Text = reader.GetComments

        End If

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim itemType As FrmEditionOrGoody.ItemType = FrmEditionOrGoody.GetEditionOrGoody(Me.Owner)

        Select Case itemType
            Case FrmEditionOrGoody.ItemType.NewEdition : AddNewEdition()
            Case FrmEditionOrGoody.ItemType.KnownEdition : AddKnownEdition()
            Case FrmEditionOrGoody.ItemType.NewGoody : AddNewGoody()
            Case FrmEditionOrGoody.ItemType.KnownGoody : AddKnownGoody()
        End Select

    End Sub

    Private Sub AddNewEdition()

        Dim newEdition As ModifiedItem = FrmWriteEdition.CreateOrEdit(Me.ParentForm)

        If newEdition IsNot Nothing Then
            AddEdition(newEdition.GetItem)
        End If

    End Sub

    Private Sub AddKnownEdition()

        Dim itemId As String = InputBox("Id de l'édition :", "Edition existante...", "").Trim

        If Not String.IsNullOrEmpty(itemId) Then
            If (itemId.Contains(".")) OrElse (itemId.Contains(",")) OrElse (Not IsNumeric(itemId)) Then
                MsgBox("L'identifiant saisi est invalide.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Erreur de saisi...")
            Else
                Dim svcEdition As New ServiceEdition
                AddEdition(svcEdition.GetById(CSng(itemId)))
            End If
        End If

    End Sub

    Private Sub AddEdition(edition As Edition)

        If edition IsNot Nothing Then

            Dim svcAdArticle As New ServiceAdArticle
            Dim newAdArticle As AdArticle = svcAdArticle.GetNew()
            newAdArticle.SetEdition(edition)

            m_ad.GetAdArticles.Add(newAdArticle)
            LoadArticles(m_ad)

        End If

    End Sub

    Private Sub AddNewGoody()

        Dim newGoody As ModifiedItem = FrmWriteGoody.CreateOrEdit(Me.ParentForm)

        If newGoody IsNot Nothing Then
            AddGoody(newGoody.GetItem)
        End If

    End Sub

    Private Sub AddKnownGoody()

        Dim itemId As String = InputBox("Id du para-bd :", "Para-bd existant...", "").Trim

        If Not String.IsNullOrEmpty(itemId) Then
            If (itemId.Contains(".")) OrElse (itemId.Contains(",")) OrElse (Not IsNumeric(itemId)) Then
                MsgBox("L'identifiant saisi est invalide.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Erreur de saisi...")
            Else
                Dim svcGoody As New ServiceGoody
                AddGoody(svcGoody.GetById(CSng(itemId)))
            End If
        End If

    End Sub

    Private Sub AddGoody(goody As Goody)

        If goody IsNot Nothing Then

            Dim svcAdArticle As New ServiceAdArticle
            Dim newAdArticle As AdArticle = svcAdArticle.GetNew()
            newAdArticle.SetGoody(goody)

            m_ad.GetAdArticles.Add(newAdArticle)
            LoadArticles(m_ad)
        End If

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        Dim gridItem As GridItem = GVw_articles.SelectedItem

        If gridItem IsNot Nothing Then
            gridItem.ModifyItem()
        End If

    End Sub

    Private Sub Btn_PasteImage_Click(sender As Object, e As EventArgs) Handles Btn_PasteImage.Click

        If Clipboard.ContainsImage Then

            Dim newPicture As Image = Clipboard.GetImage()

            If newPicture IsNot Nothing Then
                Pct_Picture.Image = newPicture
                m_withPicture = True
            End If

        Else
            MsgBox("Aucune image à coller.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Collage impossible...")
        End If
    End Sub

End Class
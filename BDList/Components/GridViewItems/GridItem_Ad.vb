Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class GridItem_Ad

    Private Shared ReadOnly COLOR_RED As Color = Color.FromArgb(255, 255, 72, 72)
    Private Shared ReadOnly COLOR_GREEN As Color = Color.FromArgb(255, 146, 208, 80)
    Private Shared ReadOnly COLOR_GREY As Color = Color.FromArgb(255, 120, 120, 120)
    Private Shared ReadOnly COLOR_YELLOW As Color = Color.FromArgb(255, 249, 236, 0)


    Private m_pnlInfosWidth As Integer = 0
    Private m_pnlPriceWidth As Integer = 0
    Private m_pctImageWidth As Integer = 0

    Private m_svcAd As New ServiceAd
    Private m_svcPurchase As New ServicePurchase

    Private m_ad As Ad

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Overrides Sub Redraw()

        m_ad = CType(m_value, Ad)

        With m_ad
            Lbl_Title.Text = .ToString
            Lbl_EndOfValidity.Text = BuildEndOfValidity(.GetEndOfValidity)
            Lbl_State.Text = .GetState().ToString
            Lbl_Comments.Text = .GetSellerComments & vbCrLf & .GetComments
            Lbl_ArticlesCount.Text = .GetAdArticles.Count
        End With

        RedrawPrice()
        RedrawPicture()
        RedrawWithAutograph()
        RedrawWithNumber()

    End Sub

    Private Sub RedrawPicture()

        Dim file As IFile = m_svcAd.GetFile(m_ad)
        Dim img As Image = ImageUtils.LoadImage(file)

        If img Is Nothing Then
            Pct_Image.Image = My.Resources.unknown
        Else
            Pct_Image.Image = img
        End If

    End Sub

    Private Sub RedrawPrice()

        With m_ad
            Lbl_CurrentCost.Text = StringUtils.ToMoneyString(.GetCurrentCost())
            Lbl_BestPrice.Text = StringUtils.ToMoneyString(.GetBestPrice())

            Dim c As Color
            If .GetCurrentCost <= .GetBestPrice Then
                c = COLOR_GREEN
            Else
                c = COLOR_RED
            End If

            Pnl_Price.BackColor = c
            pnl_colorLeft.BackColor = c

        End With

    End Sub

    Private Sub RedrawWithAutograph()

        Dim iwa As Integer
        Dim allSame As Boolean = True
        Dim articles As List(Of IdBObject) = m_ad.GetAdArticles

        If articles.Count = 0 Then
            iwa = AdArticle.AutographStates.Unknown

        ElseIf articles.Count = 1 Then
            iwa = CType(articles(0), AdArticle).IsWithAutograph()

        Else
            iwa = CType(articles(0), AdArticle).IsWithAutograph

            For i As Integer = 1 To articles.Count - 1
                allSame = allSame AndAlso (iwa = CType(articles(i), AdArticle).IsWithAutograph)
            Next

        End If

        If allSame Then
            If iwa = AdArticle.AutographStates.Unknown Then
                Lbl_WithAutograph.Visible = False
            Else
                Lbl_WithAutograph.Visible = True
                Lbl_WithAutograph.BackColor = IIf(iwa = AdArticle.AutographStates.WithAutograph, COLOR_GREEN, COLOR_RED)
            End If
        Else
            Lbl_WithAutograph.Visible = True
            Lbl_WithAutograph.BackColor = COLOR_GREY
        End If

    End Sub

    Private Sub RedrawWithNumber()

        Dim iwn As Integer
        Dim allSame As Boolean = True
        Dim articles As List(Of IdBObject) = m_ad.GetAdArticles

        If articles.Count = 0 Then
            iwn = AdArticle.NumberStates.Unknown

        ElseIf articles.Count = 1 Then

            With CType(articles(0), AdArticle)
                iwn = .IsWithNumber()
                allSame = True
            End With

        Else
            iwn = CType(articles(0), AdArticle).IsWithNumber

            For i As Integer = 1 To articles.Count - 1
                allSame = allSame AndAlso (iwn = CType(articles(i), AdArticle).IsWithNumber)
            Next

        End If

        If allSame Then
            If iwn = AdArticle.NumberStates.Unknown Then
                Lbl_WithNumber.Visible = False
            Else
                Lbl_WithNumber.Visible = True

                Select Case iwn
                    Case AdArticle.NumberStates.WithNumber : Lbl_WithNumber.BackColor = COLOR_GREEN
                    Case AdArticle.NumberStates.WithNumberOne : Lbl_WithNumber.BackColor = COLOR_YELLOW
                    Case Else : Lbl_WithNumber.BackColor = COLOR_RED
                End Select

            End If
        Else
            Lbl_WithNumber.Visible = True
            Lbl_WithNumber.BackColor = COLOR_GREY
        End If

    End Sub

    Private Function BuildEndOfValidity(endOfValidity As Date?) As String

        Dim eov As String = ""

        If (endOfValidity IsNot Nothing) AndAlso (endOfValidity.HasValue) Then
            eov = Format(endOfValidity.Value, "ddd dd/MM/yyyy HH:mm:ss")
        End If

        Return eov

    End Function

    Private Sub Pct_Image_MouseDown(sender As Object, e As MouseEventArgs) Handles Pct_Image.MouseDown
        If e.Button = MouseButtons.Right Then
            FrmShowImage.ShowImage(CType(sender, PictureBox).Image)
        End If
    End Sub

    Private Sub Pnl_Price_Paint(sender As Object, e As PaintEventArgs) Handles Pnl_Price.Paint

        If (m_pnlPriceWidth <> Pnl_Price.Width) Then

            m_pnlPriceWidth = Pnl_Price.Width

            Dim w As Single = (Pnl_Price.Width - Lbl_CostSeparation.Width - Lbl_ArticlesCount.Width) / 2
            Lbl_CostSeparation.Left = w
            Lbl_CurrentCost.Width = w
            Lbl_BestPrice.Width = w

        End If

    End Sub

    Private Sub Pnl_BackPaint(sender As Object, e As PaintEventArgs) Handles Pnl_Back.Paint

        If (m_pnlInfosWidth <> Pnl_Back.Width) Then

            m_pnlInfosWidth = Pnl_Back.Width

            Lbl_Title.MaximumSize = New Size(Pnl_Back.Width, 0)
            Lbl_Title.MinimumSize = New Size(Pnl_Back.Width, 0)

        End If

    End Sub

    Private Sub Pct_Image_Paint(sender As Object, e As PaintEventArgs) Handles Pct_Image.Paint

        If (m_pctImageWidth <> Pct_Image.Width) Then

            m_pctImageWidth = Pct_Image.Width

            Lbl_WithAutograph.Left = m_pctImageWidth - Lbl_WithAutograph.Width
            Lbl_WithNumber.Left = m_pctImageWidth - Lbl_WithNumber.Width

        End If

        If m_ad IsNot Nothing Then
            If m_ad.GetState.IsWin Then
                Dim w As Integer = Pct_Image.Width * 20 / 100
                Dim t As Integer = Pct_Image.Height - w - 5
                e.Graphics.DrawImage(My.Resources.winner, New Rectangle(5, t, w, w))
            ElseIf m_ad.GetState.IsLost Then
                Dim w As Integer = Pct_Image.Width * 90 / 100
                e.Graphics.DrawImage(My.Resources.failed, New Rectangle(5, 5, w, w))
            End If
        End If

    End Sub

    Private Sub Lbl_Title_MouseDown(sender As Object, e As MouseEventArgs) Handles Lbl_Title.MouseDown

        If (e.Button = MouseButtons.Right) AndAlso (Not String.IsNullOrEmpty(m_ad.GetUrl)) Then
            Process.Start(m_ad.GetUrl)
            Me.SetSelected(True)
        End If

    End Sub

    Public Overrides Sub ModifyItem()

        Dim ad As Ad = CType(m_value, Ad)
        Dim purchases As List(Of IdBObject) = m_svcPurchase.GetByAd(ad.GetId())

        Dim modifiedAd As ModifiedItem = FrmWriteAd.CreateOrEdit(Me.ParentForm, ad, purchases(0))

        If modifiedAd IsNot Nothing Then

            m_value = modifiedAd.GetItem
            Redraw()

            Dim eventArgs As New GridItemActionEventArgs(GridItemActionEventArgs.listItemActions.Modify)
            eventArgs.AddParameter(NavParameters.PRM_AD_ID, CType(m_value, Ad).GetId)

            SendActionEvent(eventArgs)

        End If

    End Sub

End Class

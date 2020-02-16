<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWriteAd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWriteAd))
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Btn_PasteImage = New System.Windows.Forms.Button()
        Me.Pnl_ImportFromBDFugue = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Pnl_ImportFromEbay = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Rtb_Comments = New System.Windows.Forms.RichTextBox()
        Me.Rtb_SellerComments = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_BestPrice = New FrameworkPN.MoneyTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_CurrentCost = New FrameworkPN.MoneyTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cmb_State = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dtb_EndOfValidity = New FrameworkPN.DateTimeTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Url = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pct_Picture = New System.Windows.Forms.PictureBox()
        Me.Txt_Title = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GVw_articles = New FrameworkPN.GridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt_articlesCount = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Pnl_ImportFromBDFugue.SuspendLayout()
        Me.Pnl_ImportFromEbay.SuspendLayout()
        CType(Me.Pct_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(609, 470)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(100, 22)
        Me.BtnOK.TabIndex = 35
        Me.BtnOK.Text = "Enregistrer"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(710, 470)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 22)
        Me.BtnCancel.TabIndex = 36
        Me.BtnCancel.Text = "Annuler"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(822, 464)
        Me.TabControl1.TabIndex = 51
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Txt_articlesCount)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Btn_PasteImage)
        Me.TabPage1.Controls.Add(Me.Pnl_ImportFromBDFugue)
        Me.TabPage1.Controls.Add(Me.Pnl_ImportFromEbay)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Rtb_Comments)
        Me.TabPage1.Controls.Add(Me.Rtb_SellerComments)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Txt_BestPrice)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Txt_CurrentCost)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Cmb_State)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Dtb_EndOfValidity)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Txt_Url)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Pct_Picture)
        Me.TabPage1.Controls.Add(Me.Txt_Title)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(814, 438)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Détail de l'annonce"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Btn_PasteImage
        '
        Me.Btn_PasteImage.Location = New System.Drawing.Point(338, 359)
        Me.Btn_PasteImage.Name = "Btn_PasteImage"
        Me.Btn_PasteImage.Size = New System.Drawing.Size(53, 20)
        Me.Btn_PasteImage.TabIndex = 70
        Me.Btn_PasteImage.Text = "Coller"
        Me.Btn_PasteImage.UseVisualStyleBackColor = True
        '
        'Pnl_ImportFromBDFugue
        '
        Me.Pnl_ImportFromBDFugue.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Pnl_ImportFromBDFugue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnl_ImportFromBDFugue.Controls.Add(Me.Label10)
        Me.Pnl_ImportFromBDFugue.Location = New System.Drawing.Point(734, 367)
        Me.Pnl_ImportFromBDFugue.Name = "Pnl_ImportFromBDFugue"
        Me.Pnl_ImportFromBDFugue.Size = New System.Drawing.Size(65, 65)
        Me.Pnl_ImportFromBDFugue.TabIndex = 69
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 61)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Importer BD Fugue"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pnl_ImportFromEbay
        '
        Me.Pnl_ImportFromEbay.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Pnl_ImportFromEbay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnl_ImportFromEbay.Controls.Add(Me.Label9)
        Me.Pnl_ImportFromEbay.Location = New System.Drawing.Point(663, 367)
        Me.Pnl_ImportFromEbay.Name = "Pnl_ImportFromEbay"
        Me.Pnl_ImportFromEbay.Size = New System.Drawing.Size(65, 65)
        Me.Pnl_ImportFromEbay.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 61)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Importer ebay"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Commentaire :"
        '
        'Rtb_Comments
        '
        Me.Rtb_Comments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Rtb_Comments.Location = New System.Drawing.Point(16, 342)
        Me.Rtb_Comments.Name = "Rtb_Comments"
        Me.Rtb_Comments.Size = New System.Drawing.Size(302, 92)
        Me.Rtb_Comments.TabIndex = 66
        Me.Rtb_Comments.Text = ""
        '
        'Rtb_SellerComments
        '
        Me.Rtb_SellerComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Rtb_SellerComments.Location = New System.Drawing.Point(16, 228)
        Me.Rtb_SellerComments.Name = "Rtb_SellerComments"
        Me.Rtb_SellerComments.Size = New System.Drawing.Size(302, 92)
        Me.Rtb_SellerComments.TabIndex = 64
        Me.Rtb_SellerComments.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Commentaire vendeur :"
        '
        'Txt_BestPrice
        '
        Me.Txt_BestPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_BestPrice.Location = New System.Drawing.Point(106, 178)
        Me.Txt_BestPrice.Name = "Txt_BestPrice"
        Me.Txt_BestPrice.Size = New System.Drawing.Size(87, 20)
        Me.Txt_BestPrice.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Mon meilleur prix :"
        '
        'Txt_CurrentCost
        '
        Me.Txt_CurrentCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_CurrentCost.Location = New System.Drawing.Point(106, 146)
        Me.Txt_CurrentCost.Name = "Txt_CurrentCost"
        Me.Txt_CurrentCost.Size = New System.Drawing.Size(87, 20)
        Me.Txt_CurrentCost.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Prix en cours :"
        '
        'Cmb_State
        '
        Me.Cmb_State.FormattingEnabled = True
        Me.Cmb_State.Location = New System.Drawing.Point(106, 114)
        Me.Cmb_State.Name = "Cmb_State"
        Me.Cmb_State.Size = New System.Drawing.Size(212, 21)
        Me.Cmb_State.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Etat :"
        '
        'Dtb_EndOfValidity
        '
        Me.Dtb_EndOfValidity.DateFormat = "dd/MM/yyyy"
        Me.Dtb_EndOfValidity.Location = New System.Drawing.Point(106, 79)
        Me.Dtb_EndOfValidity.Name = "Dtb_EndOfValidity"
        Me.Dtb_EndOfValidity.Size = New System.Drawing.Size(154, 20)
        Me.Dtb_EndOfValidity.TabIndex = 56
        Me.Dtb_EndOfValidity.Text = "             "
        Me.Dtb_EndOfValidity.TimeFormat = "HH:mm:ss"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Fin de validité :"
        '
        'Txt_Url
        '
        Me.Txt_Url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Url.Location = New System.Drawing.Point(106, 50)
        Me.Txt_Url.Name = "Txt_Url"
        Me.Txt_Url.Size = New System.Drawing.Size(693, 20)
        Me.Txt_Url.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Url :"
        '
        'Pct_Picture
        '
        Me.Pct_Picture.BackColor = System.Drawing.Color.Black
        Me.Pct_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pct_Picture.Image = Global.BDList.My.Resources.Resources.unknown
        Me.Pct_Picture.Location = New System.Drawing.Point(338, 77)
        Me.Pct_Picture.Name = "Pct_Picture"
        Me.Pct_Picture.Size = New System.Drawing.Size(463, 282)
        Me.Pct_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pct_Picture.TabIndex = 53
        Me.Pct_Picture.TabStop = False
        '
        'Txt_Title
        '
        Me.Txt_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Title.Location = New System.Drawing.Point(106, 18)
        Me.Txt_Title.Name = "Txt_Title"
        Me.Txt_Title.Size = New System.Drawing.Size(695, 20)
        Me.Txt_Title.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Libellé :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GVw_articles)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(814, 438)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Articles"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GVw_articles
        '
        Me.GVw_articles.BackColor = System.Drawing.Color.White
        Me.GVw_articles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GVw_articles.ColumnsCount = 2
        Me.GVw_articles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GVw_articles.ItemsMargin = 3
        Me.GVw_articles.Location = New System.Drawing.Point(3, 53)
        Me.GVw_articles.Name = "GVw_articles"
        Me.GVw_articles.RowsCount = 2
        Me.GVw_articles.ShowFilter = False
        Me.GVw_articles.Size = New System.Drawing.Size(808, 382)
        Me.GVw_articles.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btn_edit)
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 50)
        Me.Panel1.TabIndex = 0
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.Control
        Me.btn_edit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_edit.Image = Global.BDList.My.Resources.Resources.edit
        Me.btn_edit.Location = New System.Drawing.Point(708, 0)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(50, 50)
        Me.btn_edit.TabIndex = 5
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.Control
        Me.btn_add.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Location = New System.Drawing.Point(758, 0)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(50, 50)
        Me.btn_add.TabIndex = 6
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(384, 403)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Nombre d'articles :"
        '
        'Txt_articlesCount
        '
        Me.Txt_articlesCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_articlesCount.Location = New System.Drawing.Point(484, 401)
        Me.Txt_articlesCount.Name = "Txt_articlesCount"
        Me.Txt_articlesCount.Size = New System.Drawing.Size(79, 20)
        Me.Txt_articlesCount.TabIndex = 72
        '
        'FrmWriteAd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 502)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnCancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWriteAd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajouter ou modifier une annonce"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Pnl_ImportFromBDFugue.ResumeLayout(False)
        Me.Pnl_ImportFromEbay.ResumeLayout(False)
        CType(Me.Pct_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnOK As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Pnl_ImportFromBDFugue As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Pnl_ImportFromEbay As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Rtb_Comments As RichTextBox
    Friend WithEvents Rtb_SellerComments As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_BestPrice As FrameworkPN.MoneyTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_CurrentCost As FrameworkPN.MoneyTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Cmb_State As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Dtb_EndOfValidity As FrameworkPN.DateTimeTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Url As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Pct_Picture As PictureBox
    Friend WithEvents Txt_Title As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GVw_articles As FrameworkPN.GridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents Btn_PasteImage As Button
    Friend WithEvents Txt_articlesCount As TextBox
    Friend WithEvents Label11 As Label
End Class

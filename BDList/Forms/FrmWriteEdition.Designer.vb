<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWriteEdition
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New FrameworkPN.AutoIndexedTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_possessionState = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtEditionComments = New System.Windows.Forms.TextBox()
        Me.txtPrintingMaxNumber = New System.Windows.Forms.TextBox()
        Me.txtPrintingNumber = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtIntegral = New System.Windows.Forms.RadioButton()
        Me.rbtSet = New System.Windows.Forms.RadioButton()
        Me.rbtSimpleBook = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbtRead = New System.Windows.Forms.RadioButton()
        Me.rbtNotRead = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEditionInformations = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtEditionNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmbEditor = New System.Windows.Forms.ComboBox()
        Me.cmbCollection = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSpecialEdition = New System.Windows.Forms.TextBox()
        Me.txtReedition = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDdl = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIssn = New System.Windows.Forms.TextBox()
        Me.txtBoughtDate = New FrameworkPN.DateTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEanIsbn = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtIsbn = New System.Windows.Forms.TextBox()
        Me.txtParutionDate = New FrameworkPN.DateTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLegalDepositDate = New FrameworkPN.DateTextBox()
        Me.txtPrintDate = New FrameworkPN.DateTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.LvwFormat = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.LvwColor = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtAddinPagesCount = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtBoardsCount = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.LstLinkedSeries = New System.Windows.Forms.ListBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.BtnRemoveSerie = New System.Windows.Forms.Button()
        Me.BtnAddSerie = New System.Windows.Forms.Button()
        Me.LstSeries = New System.Windows.Forms.ListBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TxtSeriesFilter = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.rbtNotOutSerie = New System.Windows.Forms.RadioButton()
        Me.rbtOutSerie = New System.Windows.Forms.RadioButton()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lvwLinkedTitles = New System.Windows.Forms.ListView()
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnCopyToTitlesList = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvwSerieTitles = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtTitleName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtTitleNumber = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtTitleStory = New System.Windows.Forms.TextBox()
        Me.btnRemoveTitle = New System.Windows.Forms.Button()
        Me.btnAddTitle = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnRemoveActorRole = New System.Windows.Forms.Button()
        Me.btnAddActorRole = New System.Windows.Forms.Button()
        Me.lvwLinkedActorsRoles = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lvwRoles = New System.Windows.Forms.ListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnNewRole = New System.Windows.Forms.Button()
        Me.txtRolesFilter = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnNewSociety = New System.Windows.Forms.Button()
        Me.btnNewAuthor = New System.Windows.Forms.Button()
        Me.txtActorsFilter = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lvwActors = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PLstFirstCover = New FrameworkPN.PicturesList()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.PLstBoards = New FrameworkPN.PicturesList()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.PLstFourthCover = New FrameworkPN.PicturesList()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.LvwAutographs = New System.Windows.Forms.ListView()
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnRemoveAutograph = New System.Windows.Forms.Button()
        Me.BtnAddAutograph = New System.Windows.Forms.Button()
        Me.PLstAutograph = New FrameworkPN.PicturesList()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Btn_CreateAuthor = New System.Windows.Forms.Button()
        Me.slst_authors = New FrameworkPN.SelectList()
        Me.LblAutographDate = New System.Windows.Forms.Label()
        Me.TxtAutographDate = New FrameworkPN.DateTextBox()
        Me.LblAutographPlace = New System.Windows.Forms.Label()
        Me.TxtAutographPlace = New System.Windows.Forms.TextBox()
        Me.TxtAutographEvent = New System.Windows.Forms.TextBox()
        Me.LblAutographEvent = New System.Windows.Forms.Label()
        Me.lblAutographComments = New System.Windows.Forms.Label()
        Me.txtAutographComments = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(433, 607)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 22)
        Me.BtnSave.TabIndex = 33
        Me.BtnSave.Text = "Enregistrer"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(534, 607)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 22)
        Me.BtnCancel.TabIndex = 32
        Me.BtnCancel.Text = "Annuler"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.AllowDrop = True
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(656, 601)
        Me.TabControl1.TabIndex = 90
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_possessionState)
        Me.TabPage1.Controls.Add(Me.Label35)
        Me.TabPage1.Controls.Add(Me.txtEditionComments)
        Me.TabPage1.Controls.Add(Me.txtPrintingMaxNumber)
        Me.TabPage1.Controls.Add(Me.txtPrintingNumber)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.txtEditionInformations)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.txtEditionNumber)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.cmbEditor)
        Me.TabPage1.Controls.Add(Me.cmbCollection)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtNumber)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtSpecialEdition)
        Me.TabPage1.Controls.Add(Me.txtReedition)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.txtDdl)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtIssn)
        Me.TabPage1.Controls.Add(Me.txtBoughtDate)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.txtEanIsbn)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txtIsbn)
        Me.TabPage1.Controls.Add(Me.txtParutionDate)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtLegalDepositDate)
        Me.TabPage1.Controls.Add(Me.txtPrintDate)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(648, 575)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Infos d'édition"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_possessionState
        '
        Me.btn_possessionState.Location = New System.Drawing.Point(580, 48)
        Me.btn_possessionState.Name = "btn_possessionState"
        Me.btn_possessionState.Size = New System.Drawing.Size(50, 50)
        Me.btn_possessionState.TabIndex = 6
        Me.btn_possessionState.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(419, 116)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(79, 13)
        Me.Label35.TabIndex = 87
        Me.Label35.Text = "Commentaires :"
        '
        'txtEditionComments
        '
        Me.txtEditionComments.Location = New System.Drawing.Point(429, 139)
        Me.txtEditionComments.Multiline = True
        Me.txtEditionComments.Name = "txtEditionComments"
        Me.txtEditionComments.Size = New System.Drawing.Size(201, 74)
        Me.txtEditionComments.TabIndex = 11
        '
        'txtPrintingMaxNumber
        '
        Me.txtPrintingMaxNumber.Location = New System.Drawing.Point(239, 427)
        Me.txtPrintingMaxNumber.Name = "txtPrintingMaxNumber"
        Me.txtPrintingMaxNumber.Size = New System.Drawing.Size(89, 20)
        Me.txtPrintingMaxNumber.TabIndex = 20
        '
        'txtPrintingNumber
        '
        Me.txtPrintingNumber.Location = New System.Drawing.Point(126, 427)
        Me.txtPrintingNumber.Name = "txtPrintingNumber"
        Me.txtPrintingNumber.Size = New System.Drawing.Size(89, 20)
        Me.txtPrintingNumber.TabIndex = 19
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(221, 430)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(12, 13)
        Me.Label34.TabIndex = 85
        Me.Label34.Text = "/"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(16, 430)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(43, 13)
        Me.Label33.TabIndex = 83
        Me.Label33.Text = "Tirage :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Type de livre :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtIntegral)
        Me.Panel1.Controls.Add(Me.rbtSet)
        Me.Panel1.Controls.Add(Me.rbtSimpleBook)
        Me.Panel1.Location = New System.Drawing.Point(93, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(258, 30)
        Me.Panel1.TabIndex = 37
        '
        'rbtIntegral
        '
        Me.rbtIntegral.AutoSize = True
        Me.rbtIntegral.Location = New System.Drawing.Point(109, 6)
        Me.rbtIntegral.Name = "rbtIntegral"
        Me.rbtIntegral.Size = New System.Drawing.Size(60, 17)
        Me.rbtIntegral.TabIndex = 2
        Me.rbtIntegral.TabStop = True
        Me.rbtIntegral.Text = "Intégral"
        Me.rbtIntegral.UseVisualStyleBackColor = True
        '
        'rbtSet
        '
        Me.rbtSet.AutoSize = True
        Me.rbtSet.Location = New System.Drawing.Point(186, 6)
        Me.rbtSet.Name = "rbtSet"
        Me.rbtSet.Size = New System.Drawing.Size(61, 17)
        Me.rbtSet.TabIndex = 3
        Me.rbtSet.TabStop = True
        Me.rbtSet.Text = "Recueil"
        Me.rbtSet.UseVisualStyleBackColor = True
        '
        'rbtSimpleBook
        '
        Me.rbtSimpleBook.AutoSize = True
        Me.rbtSimpleBook.Location = New System.Drawing.Point(3, 6)
        Me.rbtSimpleBook.Name = "rbtSimpleBook"
        Me.rbtSimpleBook.Size = New System.Drawing.Size(86, 17)
        Me.rbtSimpleBook.TabIndex = 1
        Me.rbtSimpleBook.TabStop = True
        Me.rbtSimpleBook.Text = "Album simple"
        Me.rbtSimpleBook.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(473, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Lu :"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbtRead)
        Me.Panel4.Controls.Add(Me.rbtNotRead)
        Me.Panel4.Location = New System.Drawing.Point(504, 17)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(126, 25)
        Me.Panel4.TabIndex = 53
        '
        'rbtRead
        '
        Me.rbtRead.AutoSize = True
        Me.rbtRead.Location = New System.Drawing.Point(3, 3)
        Me.rbtRead.Name = "rbtRead"
        Me.rbtRead.Size = New System.Drawing.Size(41, 17)
        Me.rbtRead.TabIndex = 4
        Me.rbtRead.TabStop = True
        Me.rbtRead.Text = "Oui"
        Me.rbtRead.UseVisualStyleBackColor = True
        '
        'rbtNotRead
        '
        Me.rbtNotRead.AutoSize = True
        Me.rbtNotRead.Location = New System.Drawing.Point(60, 3)
        Me.rbtNotRead.Name = "rbtNotRead"
        Me.rbtNotRead.Size = New System.Drawing.Size(45, 17)
        Me.rbtNotRead.TabIndex = 5
        Me.rbtNotRead.TabStop = True
        Me.rbtNotRead.Text = "Non"
        Me.rbtNotRead.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(126, 61)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(225, 20)
        Me.txtName.TabIndex = 7
        '
        'txtEditionInformations
        '
        Me.txtEditionInformations.Location = New System.Drawing.Point(126, 219)
        Me.txtEditionInformations.Multiline = True
        Me.txtEditionInformations.Name = "txtEditionInformations"
        Me.txtEditionInformations.Size = New System.Drawing.Size(504, 118)
        Me.txtEditionInformations.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Éditeur :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(16, 222)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(112, 13)
        Me.Label25.TabIndex = 82
        Me.Label25.Text = "Informations d'édition :"
        '
        'txtEditionNumber
        '
        Me.txtEditionNumber.Location = New System.Drawing.Point(126, 193)
        Me.txtEditionNumber.Name = "txtEditionNumber"
        Me.txtEditionNumber.Size = New System.Drawing.Size(182, 20)
        Me.txtEditionNumber.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Collection :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(16, 196)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(92, 13)
        Me.Label24.TabIndex = 80
        Me.Label24.Text = "Numéro d'édition :"
        '
        'cmbEditor
        '
        Me.cmbEditor.FormattingEnabled = True
        Me.cmbEditor.Location = New System.Drawing.Point(126, 139)
        Me.cmbEditor.Name = "cmbEditor"
        Me.cmbEditor.Size = New System.Drawing.Size(225, 21)
        Me.cmbEditor.TabIndex = 10
        '
        'cmbCollection
        '
        Me.cmbCollection.FormattingEnabled = True
        Me.cmbCollection.Location = New System.Drawing.Point(126, 166)
        Me.cmbCollection.Name = "cmbCollection"
        Me.cmbCollection.Size = New System.Drawing.Size(225, 21)
        Me.cmbCollection.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Nom :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Numéro :"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(126, 87)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(89, 20)
        Me.txtNumber.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Ré-édition :"
        '
        'txtSpecialEdition
        '
        Me.txtSpecialEdition.Location = New System.Drawing.Point(126, 113)
        Me.txtSpecialEdition.Name = "txtSpecialEdition"
        Me.txtSpecialEdition.Size = New System.Drawing.Size(89, 20)
        Me.txtSpecialEdition.TabIndex = 9
        '
        'txtReedition
        '
        Me.txtReedition.Location = New System.Drawing.Point(126, 524)
        Me.txtReedition.Name = "txtReedition"
        Me.txtReedition.Size = New System.Drawing.Size(124, 20)
        Me.txtReedition.TabIndex = 25
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(18, 527)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 13)
        Me.Label21.TabIndex = 72
        Me.Label21.Text = "Ré-édition (R/...) :"
        '
        'txtDdl
        '
        Me.txtDdl.Location = New System.Drawing.Point(506, 498)
        Me.txtDdl.Name = "txtDdl"
        Me.txtDdl.Size = New System.Drawing.Size(124, 20)
        Me.txtDdl.TabIndex = 24
        Me.txtDdl.Text = "D/2007/0089/119"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(340, 501)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 13)
        Me.Label20.TabIndex = 70
        Me.Label20.Text = "Dépôt légal (D/...) :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(342, 383)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Date d'obtention :"
        '
        'txtIssn
        '
        Me.txtIssn.Location = New System.Drawing.Point(126, 498)
        Me.txtIssn.Name = "txtIssn"
        Me.txtIssn.Size = New System.Drawing.Size(124, 20)
        Me.txtIssn.TabIndex = 23
        '
        'txtBoughtDate
        '
        Me.txtBoughtDate.DateFormat = "dd/MM/yyyy"
        Me.txtBoughtDate.Location = New System.Drawing.Point(506, 380)
        Me.txtBoughtDate.Name = "txtBoughtDate"
        Me.txtBoughtDate.Size = New System.Drawing.Size(124, 20)
        Me.txtBoughtDate.TabIndex = 18
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(18, 501)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 13)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "ISSN :"
        '
        'txtEanIsbn
        '
        Me.txtEanIsbn.Location = New System.Drawing.Point(504, 472)
        Me.txtEanIsbn.Name = "txtEanIsbn"
        Me.txtEanIsbn.Size = New System.Drawing.Size(124, 20)
        Me.txtEanIsbn.TabIndex = 22
        Me.txtEanIsbn.Text = "978-2-7316-1735-1"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(340, 475)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 13)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "EAN-ISBN :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 383)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Date de parution :"
        '
        'txtIsbn
        '
        Me.txtIsbn.Location = New System.Drawing.Point(126, 472)
        Me.txtIsbn.Name = "txtIsbn"
        Me.txtIsbn.Size = New System.Drawing.Size(124, 20)
        Me.txtIsbn.TabIndex = 21
        Me.txtIsbn.Text = "2-7316-1735-7"
        '
        'txtParutionDate
        '
        Me.txtParutionDate.DateFormat = "dd/MM/yyyy"
        Me.txtParutionDate.Location = New System.Drawing.Point(126, 380)
        Me.txtParutionDate.Name = "txtParutionDate"
        Me.txtParutionDate.Size = New System.Drawing.Size(124, 20)
        Me.txtParutionDate.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 475)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "ISBN :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 357)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 13)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Date d'impression :"
        '
        'txtLegalDepositDate
        '
        Me.txtLegalDepositDate.DateFormat = "MMMM yyyy"
        Me.txtLegalDepositDate.Location = New System.Drawing.Point(506, 354)
        Me.txtLegalDepositDate.Name = "txtLegalDepositDate"
        Me.txtLegalDepositDate.Size = New System.Drawing.Size(124, 20)
        Me.txtLegalDepositDate.TabIndex = 16
        '
        'txtPrintDate
        '
        Me.txtPrintDate.DateFormat = "MMMM yyyy"
        Me.txtPrintDate.Location = New System.Drawing.Point(126, 354)
        Me.txtPrintDate.Name = "txtPrintDate"
        Me.txtPrintDate.Size = New System.Drawing.Size(124, 20)
        Me.txtPrintDate.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(342, 357)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "Date de dépôt légal :"
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.LvwFormat)
        Me.TabPage9.Controls.Add(Me.cmbSize)
        Me.TabPage9.Controls.Add(Me.Label31)
        Me.TabPage9.Controls.Add(Me.LvwColor)
        Me.TabPage9.Controls.Add(Me.txtAddinPagesCount)
        Me.TabPage9.Controls.Add(Me.Label23)
        Me.TabPage9.Controls.Add(Me.txtBoardsCount)
        Me.TabPage9.Controls.Add(Me.Label22)
        Me.TabPage9.Controls.Add(Me.Label13)
        Me.TabPage9.Controls.Add(Me.cmbState)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(648, 575)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Aspect"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'LvwFormat
        '
        Me.LvwFormat.CheckBoxes = True
        Me.LvwFormat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10})
        Me.LvwFormat.FullRowSelect = True
        Me.LvwFormat.Location = New System.Drawing.Point(8, 248)
        Me.LvwFormat.MultiSelect = False
        Me.LvwFormat.Name = "LvwFormat"
        Me.LvwFormat.Size = New System.Drawing.Size(625, 315)
        Me.LvwFormat.TabIndex = 100
        Me.LvwFormat.UseCompatibleStateImageBehavior = False
        Me.LvwFormat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Formats"
        Me.ColumnHeader10.Width = 621
        '
        'cmbSize
        '
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Location = New System.Drawing.Point(46, 66)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(165, 21)
        Me.cmbSize.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(8, 68)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(38, 13)
        Me.Label31.TabIndex = 98
        Me.Label31.Text = "Taille :"
        '
        'LvwColor
        '
        Me.LvwColor.CheckBoxes = True
        Me.LvwColor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9})
        Me.LvwColor.FullRowSelect = True
        Me.LvwColor.Location = New System.Drawing.Point(8, 121)
        Me.LvwColor.MultiSelect = False
        Me.LvwColor.Name = "LvwColor"
        Me.LvwColor.Size = New System.Drawing.Size(625, 121)
        Me.LvwColor.TabIndex = 97
        Me.LvwColor.UseCompatibleStateImageBehavior = False
        Me.LvwColor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Couleurs"
        Me.ColumnHeader9.Width = 621
        '
        'txtAddinPagesCount
        '
        Me.txtAddinPagesCount.Location = New System.Drawing.Point(468, 65)
        Me.txtAddinPagesCount.Name = "txtAddinPagesCount"
        Me.txtAddinPagesCount.Size = New System.Drawing.Size(165, 20)
        Me.txtAddinPagesCount.TabIndex = 3
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(296, 68)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(167, 13)
        Me.Label23.TabIndex = 95
        Me.Label23.Text = "Nombre de page de complément :"
        '
        'txtBoardsCount
        '
        Me.txtBoardsCount.Location = New System.Drawing.Point(468, 39)
        Me.txtBoardsCount.Name = "txtBoardsCount"
        Me.txtBoardsCount.Size = New System.Drawing.Size(165, 20)
        Me.txtBoardsCount.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(296, 42)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(111, 13)
        Me.Label22.TabIndex = 94
        Me.Label22.Text = "Nombre de planches :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Etat :"
        '
        'cmbState
        '
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(46, 39)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(165, 21)
        Me.cmbState.TabIndex = 1
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.LstLinkedSeries)
        Me.TabPage8.Controls.Add(Me.Panel8)
        Me.TabPage8.Controls.Add(Me.LstSeries)
        Me.TabPage8.Controls.Add(Me.Panel7)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(648, 575)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Séries"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'LstLinkedSeries
        '
        Me.LstLinkedSeries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstLinkedSeries.FormattingEnabled = True
        Me.LstLinkedSeries.Location = New System.Drawing.Point(3, 365)
        Me.LstLinkedSeries.Name = "LstLinkedSeries"
        Me.LstLinkedSeries.Size = New System.Drawing.Size(642, 207)
        Me.LstLinkedSeries.Sorted = True
        Me.LstLinkedSeries.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.BtnRemoveSerie)
        Me.Panel8.Controls.Add(Me.BtnAddSerie)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(3, 316)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(642, 49)
        Me.Panel8.TabIndex = 2
        '
        'BtnRemoveSerie
        '
        Me.BtnRemoveSerie.Enabled = False
        Me.BtnRemoveSerie.Image = Global.BDList.My.Resources.Resources.arrow_up
        Me.BtnRemoveSerie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRemoveSerie.Location = New System.Drawing.Point(324, 11)
        Me.BtnRemoveSerie.Name = "BtnRemoveSerie"
        Me.BtnRemoveSerie.Size = New System.Drawing.Size(115, 27)
        Me.BtnRemoveSerie.TabIndex = 3
        Me.BtnRemoveSerie.Text = "Retirer la série"
        Me.BtnRemoveSerie.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRemoveSerie.UseVisualStyleBackColor = True
        '
        'BtnAddSerie
        '
        Me.BtnAddSerie.Enabled = False
        Me.BtnAddSerie.Image = Global.BDList.My.Resources.Resources.arrow_down
        Me.BtnAddSerie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddSerie.Location = New System.Drawing.Point(203, 11)
        Me.BtnAddSerie.Name = "BtnAddSerie"
        Me.BtnAddSerie.Size = New System.Drawing.Size(115, 27)
        Me.BtnAddSerie.TabIndex = 2
        Me.BtnAddSerie.Text = "Ajouter la série"
        Me.BtnAddSerie.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddSerie.UseVisualStyleBackColor = True
        '
        'LstSeries
        '
        Me.LstSeries.Dock = System.Windows.Forms.DockStyle.Top
        Me.LstSeries.FormattingEnabled = True
        Me.LstSeries.Location = New System.Drawing.Point(3, 39)
        Me.LstSeries.Name = "LstSeries"
        Me.LstSeries.Size = New System.Drawing.Size(642, 277)
        Me.LstSeries.Sorted = True
        Me.LstSeries.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TxtSeriesFilter)
        Me.Panel7.Controls.Add(Me.Label30)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(642, 36)
        Me.Panel7.TabIndex = 0
        '
        'TxtSeriesFilter
        '
        Me.TxtSeriesFilter.Location = New System.Drawing.Point(46, 7)
        Me.TxtSeriesFilter.Name = "TxtSeriesFilter"
        Me.TxtSeriesFilter.Size = New System.Drawing.Size(587, 20)
        Me.TxtSeriesFilter.TabIndex = 1
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(5, 10)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(35, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Filtre :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel12)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.txtTitleName)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.txtTitleNumber)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.txtTitleStory)
        Me.TabPage2.Controls.Add(Me.btnRemoveTitle)
        Me.TabPage2.Controls.Add(Me.btnAddTitle)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(648, 575)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Titres"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.rbtNotOutSerie)
        Me.Panel12.Controls.Add(Me.rbtOutSerie)
        Me.Panel12.Controls.Add(Me.Label32)
        Me.Panel12.Location = New System.Drawing.Point(243, 407)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(217, 32)
        Me.Panel12.TabIndex = 57
        '
        'rbtNotOutSerie
        '
        Me.rbtNotOutSerie.AutoSize = True
        Me.rbtNotOutSerie.Location = New System.Drawing.Point(135, 7)
        Me.rbtNotOutSerie.Name = "rbtNotOutSerie"
        Me.rbtNotOutSerie.Size = New System.Drawing.Size(45, 17)
        Me.rbtNotOutSerie.TabIndex = 4
        Me.rbtNotOutSerie.TabStop = True
        Me.rbtNotOutSerie.Text = "Non"
        Me.rbtNotOutSerie.UseVisualStyleBackColor = True
        '
        'rbtOutSerie
        '
        Me.rbtOutSerie.AutoSize = True
        Me.rbtOutSerie.Location = New System.Drawing.Point(88, 7)
        Me.rbtOutSerie.Name = "rbtOutSerie"
        Me.rbtOutSerie.Size = New System.Drawing.Size(41, 17)
        Me.rbtOutSerie.TabIndex = 3
        Me.rbtOutSerie.TabStop = True
        Me.rbtOutSerie.Text = "Oui"
        Me.rbtOutSerie.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(14, 9)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(60, 13)
        Me.Label32.TabIndex = 52
        Me.Label32.Text = "Hors-série :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvwLinkedTitles)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 202)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 199)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Titres de l'édition "
        '
        'lvwLinkedTitles
        '
        Me.lvwLinkedTitles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader18, Me.ColumnHeader1, Me.ColumnHeader16, Me.ColumnHeader2, Me.ColumnHeader17})
        Me.lvwLinkedTitles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwLinkedTitles.FullRowSelect = True
        Me.lvwLinkedTitles.GridLines = True
        Me.lvwLinkedTitles.HideSelection = False
        Me.lvwLinkedTitles.LabelEdit = True
        Me.lvwLinkedTitles.Location = New System.Drawing.Point(3, 16)
        Me.lvwLinkedTitles.MultiSelect = False
        Me.lvwLinkedTitles.Name = "lvwLinkedTitles"
        Me.lvwLinkedTitles.Size = New System.Drawing.Size(636, 180)
        Me.lvwLinkedTitles.TabIndex = 38
        Me.lvwLinkedTitles.UseCompatibleStateImageBehavior = False
        Me.lvwLinkedTitles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Série"
        Me.ColumnHeader18.Width = 90
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Numéro"
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Hors-série"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nom"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Résumé"
        Me.ColumnHeader17.Width = 217
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnCopyToTitlesList)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 178)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(642, 24)
        Me.Panel5.TabIndex = 55
        '
        'btnCopyToTitlesList
        '
        Me.btnCopyToTitlesList.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCopyToTitlesList.Enabled = False
        Me.btnCopyToTitlesList.Image = Global.BDList.My.Resources.Resources.arrow_down
        Me.btnCopyToTitlesList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopyToTitlesList.Location = New System.Drawing.Point(496, 0)
        Me.btnCopyToTitlesList.Name = "btnCopyToTitlesList"
        Me.btnCopyToTitlesList.Size = New System.Drawing.Size(146, 24)
        Me.btnCopyToTitlesList.TabIndex = 1
        Me.btnCopyToTitlesList.Text = "Ajouter le titre à l'édition"
        Me.btnCopyToTitlesList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopyToTitlesList.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvwSerieTitles)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 175)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Titres connus de la série "
        '
        'lvwSerieTitles
        '
        Me.lvwSerieTitles.AllowColumnReorder = True
        Me.lvwSerieTitles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader15, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvwSerieTitles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwSerieTitles.FullRowSelect = True
        Me.lvwSerieTitles.GridLines = True
        Me.lvwSerieTitles.HideSelection = False
        Me.lvwSerieTitles.LabelEdit = True
        Me.lvwSerieTitles.Location = New System.Drawing.Point(3, 16)
        Me.lvwSerieTitles.MultiSelect = False
        Me.lvwSerieTitles.Name = "lvwSerieTitles"
        Me.lvwSerieTitles.Size = New System.Drawing.Size(636, 156)
        Me.lvwSerieTitles.TabIndex = 39
        Me.lvwSerieTitles.UseCompatibleStateImageBehavior = False
        Me.lvwSerieTitles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Série"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Numéro"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Hors-série"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nom"
        Me.ColumnHeader7.Width = 180
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Résumé"
        Me.ColumnHeader8.Width = 217
        '
        'txtTitleName
        '
        Me.txtTitleName.Location = New System.Drawing.Point(99, 439)
        Me.txtTitleName.Name = "txtTitleName"
        Me.txtTitleName.Size = New System.Drawing.Size(430, 20)
        Me.txtTitleName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 442)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Nom :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(8, 416)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(50, 13)
        Me.Label27.TabIndex = 51
        Me.Label27.Text = "Numéro :"
        '
        'txtTitleNumber
        '
        Me.txtTitleNumber.Location = New System.Drawing.Point(99, 413)
        Me.txtTitleNumber.Name = "txtTitleNumber"
        Me.txtTitleNumber.Size = New System.Drawing.Size(89, 20)
        Me.txtTitleNumber.TabIndex = 2
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(8, 468)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(52, 13)
        Me.Label29.TabIndex = 53
        Me.Label29.Text = "Résumé :"
        '
        'txtTitleStory
        '
        Me.txtTitleStory.Location = New System.Drawing.Point(99, 465)
        Me.txtTitleStory.Multiline = True
        Me.txtTitleStory.Name = "txtTitleStory"
        Me.txtTitleStory.Size = New System.Drawing.Size(537, 65)
        Me.txtTitleStory.TabIndex = 6
        '
        'btnRemoveTitle
        '
        Me.btnRemoveTitle.Enabled = False
        Me.btnRemoveTitle.Location = New System.Drawing.Point(331, 536)
        Me.btnRemoveTitle.Name = "btnRemoveTitle"
        Me.btnRemoveTitle.Size = New System.Drawing.Size(78, 33)
        Me.btnRemoveTitle.TabIndex = 8
        Me.btnRemoveTitle.Text = "Supprimer"
        Me.btnRemoveTitle.UseVisualStyleBackColor = True
        '
        'btnAddTitle
        '
        Me.btnAddTitle.Enabled = False
        Me.btnAddTitle.Location = New System.Drawing.Point(209, 536)
        Me.btnAddTitle.Name = "btnAddTitle"
        Me.btnAddTitle.Size = New System.Drawing.Size(78, 33)
        Me.btnAddTitle.TabIndex = 7
        Me.btnAddTitle.Text = "Ajouter"
        Me.btnAddTitle.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel10)
        Me.TabPage3.Controls.Add(Me.lvwLinkedActorsRoles)
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(648, 575)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Auteurs"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btnRemoveActorRole)
        Me.Panel10.Controls.Add(Me.btnAddActorRole)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(3, 275)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(642, 37)
        Me.Panel10.TabIndex = 90
        '
        'btnRemoveActorRole
        '
        Me.btnRemoveActorRole.Enabled = False
        Me.btnRemoveActorRole.Image = Global.BDList.My.Resources.Resources.arrow_up
        Me.btnRemoveActorRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveActorRole.Location = New System.Drawing.Point(324, 5)
        Me.btnRemoveActorRole.Name = "btnRemoveActorRole"
        Me.btnRemoveActorRole.Size = New System.Drawing.Size(115, 27)
        Me.btnRemoveActorRole.TabIndex = 7
        Me.btnRemoveActorRole.Text = "Retirer"
        Me.btnRemoveActorRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemoveActorRole.UseVisualStyleBackColor = True
        '
        'btnAddActorRole
        '
        Me.btnAddActorRole.Enabled = False
        Me.btnAddActorRole.Image = Global.BDList.My.Resources.Resources.arrow_down
        Me.btnAddActorRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddActorRole.Location = New System.Drawing.Point(203, 5)
        Me.btnAddActorRole.Name = "btnAddActorRole"
        Me.btnAddActorRole.Size = New System.Drawing.Size(115, 27)
        Me.btnAddActorRole.TabIndex = 6
        Me.btnAddActorRole.Text = "Ajouter"
        Me.btnAddActorRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddActorRole.UseVisualStyleBackColor = True
        '
        'lvwLinkedActorsRoles
        '
        Me.lvwLinkedActorsRoles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader14})
        Me.lvwLinkedActorsRoles.FullRowSelect = True
        Me.lvwLinkedActorsRoles.Location = New System.Drawing.Point(0, 335)
        Me.lvwLinkedActorsRoles.Name = "lvwLinkedActorsRoles"
        Me.lvwLinkedActorsRoles.Size = New System.Drawing.Size(652, 204)
        Me.lvwLinkedActorsRoles.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwLinkedActorsRoles.TabIndex = 87
        Me.lvwLinkedActorsRoles.UseCompatibleStateImageBehavior = False
        Me.lvwLinkedActorsRoles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Rôle"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Intervenant"
        Me.ColumnHeader5.Width = 300
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Personne/Société"
        Me.ColumnHeader14.Width = 110
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.09969!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.90031!))
        Me.TableLayoutPanel1.Controls.Add(Me.lvwRoles, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel11, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel9, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lvwActors, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(642, 272)
        Me.TableLayoutPanel1.TabIndex = 92
        '
        'lvwRoles
        '
        Me.lvwRoles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13})
        Me.lvwRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwRoles.FullRowSelect = True
        Me.lvwRoles.HideSelection = False
        Me.lvwRoles.Location = New System.Drawing.Point(376, 55)
        Me.lvwRoles.MultiSelect = False
        Me.lvwRoles.Name = "lvwRoles"
        Me.lvwRoles.Size = New System.Drawing.Size(263, 214)
        Me.lvwRoles.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwRoles.TabIndex = 96
        Me.lvwRoles.UseCompatibleStateImageBehavior = False
        Me.lvwRoles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Rôle"
        Me.ColumnHeader13.Width = 232
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.btnNewRole)
        Me.Panel11.Controls.Add(Me.txtRolesFilter)
        Me.Panel11.Controls.Add(Me.Label28)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(376, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(263, 46)
        Me.Panel11.TabIndex = 95
        '
        'btnNewRole
        '
        Me.btnNewRole.Location = New System.Drawing.Point(190, 3)
        Me.btnNewRole.Name = "btnNewRole"
        Me.btnNewRole.Size = New System.Drawing.Size(67, 40)
        Me.btnNewRole.TabIndex = 3
        Me.btnNewRole.Text = "Nouveau rôle"
        Me.btnNewRole.UseVisualStyleBackColor = True
        '
        'txtRolesFilter
        '
        Me.txtRolesFilter.Location = New System.Drawing.Point(75, 14)
        Me.txtRolesFilter.Name = "txtRolesFilter"
        Me.txtRolesFilter.Size = New System.Drawing.Size(106, 20)
        Me.txtRolesFilter.TabIndex = 5
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(3, 17)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(66, 13)
        Me.Label28.TabIndex = 92
        Me.Label28.Text = "Recherche :"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnNewSociety)
        Me.Panel9.Controls.Add(Me.btnNewAuthor)
        Me.Panel9.Controls.Add(Me.txtActorsFilter)
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(367, 46)
        Me.Panel9.TabIndex = 94
        '
        'btnNewSociety
        '
        Me.btnNewSociety.Location = New System.Drawing.Point(297, 3)
        Me.btnNewSociety.Name = "btnNewSociety"
        Me.btnNewSociety.Size = New System.Drawing.Size(67, 40)
        Me.btnNewSociety.TabIndex = 2
        Me.btnNewSociety.Text = "Nouvelle société"
        Me.btnNewSociety.UseVisualStyleBackColor = True
        '
        'btnNewAuthor
        '
        Me.btnNewAuthor.Location = New System.Drawing.Point(225, 3)
        Me.btnNewAuthor.Name = "btnNewAuthor"
        Me.btnNewAuthor.Size = New System.Drawing.Size(67, 40)
        Me.btnNewAuthor.TabIndex = 1
        Me.btnNewAuthor.Text = "Nouvel auteur"
        Me.btnNewAuthor.UseVisualStyleBackColor = True
        '
        'txtActorsFilter
        '
        Me.txtActorsFilter.Location = New System.Drawing.Point(75, 14)
        Me.txtActorsFilter.Name = "txtActorsFilter"
        Me.txtActorsFilter.Size = New System.Drawing.Size(144, 20)
        Me.txtActorsFilter.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Recherche :"
        '
        'lvwActors
        '
        Me.lvwActors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader11})
        Me.lvwActors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwActors.FullRowSelect = True
        Me.lvwActors.HideSelection = False
        Me.lvwActors.Location = New System.Drawing.Point(3, 55)
        Me.lvwActors.MultiSelect = False
        Me.lvwActors.Name = "lvwActors"
        Me.lvwActors.Size = New System.Drawing.Size(367, 214)
        Me.lvwActors.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwActors.TabIndex = 88
        Me.lvwActors.UseCompatibleStateImageBehavior = False
        Me.lvwActors.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Intervenant"
        Me.ColumnHeader12.Width = 224
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Personne/Société"
        Me.ColumnHeader11.Width = 110
        '
        'TabPage4
        '
        Me.TabPage4.AllowDrop = True
        Me.TabPage4.Controls.Add(Me.PLstFirstCover)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(648, 575)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "1ère de couverture"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'PLstFirstCover
        '
        Me.PLstFirstCover.BackColor = System.Drawing.Color.DarkGray
        Me.PLstFirstCover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PLstFirstCover.Location = New System.Drawing.Point(0, 0)
        Me.PLstFirstCover.Name = "PLstFirstCover"
        Me.PLstFirstCover.Size = New System.Drawing.Size(648, 575)
        Me.PLstFirstCover.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.AllowDrop = True
        Me.TabPage5.Controls.Add(Me.PLstBoards)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(648, 575)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Planches"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'PLstBoards
        '
        Me.PLstBoards.BackColor = System.Drawing.Color.DarkGray
        Me.PLstBoards.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PLstBoards.Location = New System.Drawing.Point(0, 0)
        Me.PLstBoards.Name = "PLstBoards"
        Me.PLstBoards.Size = New System.Drawing.Size(648, 575)
        Me.PLstBoards.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.AllowDrop = True
        Me.TabPage6.Controls.Add(Me.PLstFourthCover)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(648, 575)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "4ème de couverture"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'PLstFourthCover
        '
        Me.PLstFourthCover.BackColor = System.Drawing.Color.DarkGray
        Me.PLstFourthCover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PLstFourthCover.Location = New System.Drawing.Point(0, 0)
        Me.PLstFourthCover.Name = "PLstFourthCover"
        Me.PLstFourthCover.Size = New System.Drawing.Size(648, 575)
        Me.PLstFourthCover.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Panel13)
        Me.TabPage7.Controls.Add(Me.PLstAutograph)
        Me.TabPage7.Controls.Add(Me.Panel6)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(648, 575)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Dédicace"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.LvwAutographs)
        Me.Panel13.Controls.Add(Me.BtnRemoveAutograph)
        Me.Panel13.Controls.Add(Me.BtnAddAutograph)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(648, 153)
        Me.Panel13.TabIndex = 92
        '
        'LvwAutographs
        '
        Me.LvwAutographs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23})
        Me.LvwAutographs.Dock = System.Windows.Forms.DockStyle.Top
        Me.LvwAutographs.FullRowSelect = True
        Me.LvwAutographs.GridLines = True
        Me.LvwAutographs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvwAutographs.HideSelection = False
        Me.LvwAutographs.Location = New System.Drawing.Point(0, 0)
        Me.LvwAutographs.MultiSelect = False
        Me.LvwAutographs.Name = "LvwAutographs"
        Me.LvwAutographs.Size = New System.Drawing.Size(648, 120)
        Me.LvwAutographs.TabIndex = 2
        Me.LvwAutographs.UseCompatibleStateImageBehavior = False
        Me.LvwAutographs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Auteur"
        Me.ColumnHeader19.Width = 150
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Date"
        Me.ColumnHeader20.Width = 80
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Lieu"
        Me.ColumnHeader21.Width = 100
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Evènement"
        Me.ColumnHeader22.Width = 150
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Commentaires"
        Me.ColumnHeader23.Width = 162
        '
        'BtnRemoveAutograph
        '
        Me.BtnRemoveAutograph.Enabled = False
        Me.BtnRemoveAutograph.Location = New System.Drawing.Point(110, 126)
        Me.BtnRemoveAutograph.Name = "BtnRemoveAutograph"
        Me.BtnRemoveAutograph.Size = New System.Drawing.Size(93, 21)
        Me.BtnRemoveAutograph.TabIndex = 2
        Me.BtnRemoveAutograph.Text = "Supprimer"
        Me.BtnRemoveAutograph.UseVisualStyleBackColor = True
        '
        'BtnAddAutograph
        '
        Me.BtnAddAutograph.Location = New System.Drawing.Point(11, 126)
        Me.BtnAddAutograph.Name = "BtnAddAutograph"
        Me.BtnAddAutograph.Size = New System.Drawing.Size(93, 21)
        Me.BtnAddAutograph.TabIndex = 1
        Me.BtnAddAutograph.Text = "Ajouter"
        Me.BtnAddAutograph.UseVisualStyleBackColor = True
        '
        'PLstAutograph
        '
        Me.PLstAutograph.BackColor = System.Drawing.Color.DarkGray
        Me.PLstAutograph.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PLstAutograph.Location = New System.Drawing.Point(0, 153)
        Me.PLstAutograph.Name = "PLstAutograph"
        Me.PLstAutograph.Size = New System.Drawing.Size(648, 245)
        Me.PLstAutograph.TabIndex = 91
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Btn_CreateAuthor)
        Me.Panel6.Controls.Add(Me.slst_authors)
        Me.Panel6.Controls.Add(Me.LblAutographDate)
        Me.Panel6.Controls.Add(Me.TxtAutographDate)
        Me.Panel6.Controls.Add(Me.LblAutographPlace)
        Me.Panel6.Controls.Add(Me.TxtAutographPlace)
        Me.Panel6.Controls.Add(Me.TxtAutographEvent)
        Me.Panel6.Controls.Add(Me.LblAutographEvent)
        Me.Panel6.Controls.Add(Me.lblAutographComments)
        Me.Panel6.Controls.Add(Me.txtAutographComments)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 398)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(648, 177)
        Me.Panel6.TabIndex = 90
        '
        'Btn_CreateAuthor
        '
        Me.Btn_CreateAuthor.Location = New System.Drawing.Point(266, 47)
        Me.Btn_CreateAuthor.Name = "Btn_CreateAuthor"
        Me.Btn_CreateAuthor.Size = New System.Drawing.Size(21, 21)
        Me.Btn_CreateAuthor.TabIndex = 8
        Me.Btn_CreateAuthor.Text = "+"
        Me.Btn_CreateAuthor.UseVisualStyleBackColor = True
        '
        'slst_authors
        '
        Me.slst_authors.Location = New System.Drawing.Point(11, 6)
        Me.slst_authors.Name = "slst_authors"
        Me.slst_authors.Size = New System.Drawing.Size(276, 42)
        Me.slst_authors.TabIndex = 97
        Me.slst_authors.Title = "Auteur :"
        '
        'LblAutographDate
        '
        Me.LblAutographDate.AutoSize = True
        Me.LblAutographDate.Location = New System.Drawing.Point(316, 9)
        Me.LblAutographDate.Name = "LblAutographDate"
        Me.LblAutographDate.Size = New System.Drawing.Size(36, 13)
        Me.LblAutographDate.TabIndex = 95
        Me.LblAutographDate.Text = "Date :"
        '
        'TxtAutographDate
        '
        Me.TxtAutographDate.DateFormat = "dd/MM/yyyy"
        Me.TxtAutographDate.Location = New System.Drawing.Point(355, 6)
        Me.TxtAutographDate.Name = "TxtAutographDate"
        Me.TxtAutographDate.Size = New System.Drawing.Size(281, 20)
        Me.TxtAutographDate.TabIndex = 6
        '
        'LblAutographPlace
        '
        Me.LblAutographPlace.AutoSize = True
        Me.LblAutographPlace.Location = New System.Drawing.Point(316, 35)
        Me.LblAutographPlace.Name = "LblAutographPlace"
        Me.LblAutographPlace.Size = New System.Drawing.Size(33, 13)
        Me.LblAutographPlace.TabIndex = 93
        Me.LblAutographPlace.Text = "Lieu :"
        '
        'TxtAutographPlace
        '
        Me.TxtAutographPlace.Location = New System.Drawing.Point(355, 32)
        Me.TxtAutographPlace.Multiline = True
        Me.TxtAutographPlace.Name = "TxtAutographPlace"
        Me.TxtAutographPlace.Size = New System.Drawing.Size(281, 46)
        Me.TxtAutographPlace.TabIndex = 7
        '
        'TxtAutographEvent
        '
        Me.TxtAutographEvent.Location = New System.Drawing.Point(93, 84)
        Me.TxtAutographEvent.Name = "TxtAutographEvent"
        Me.TxtAutographEvent.Size = New System.Drawing.Size(543, 20)
        Me.TxtAutographEvent.TabIndex = 9
        '
        'LblAutographEvent
        '
        Me.LblAutographEvent.AutoSize = True
        Me.LblAutographEvent.Location = New System.Drawing.Point(8, 87)
        Me.LblAutographEvent.Name = "LblAutographEvent"
        Me.LblAutographEvent.Size = New System.Drawing.Size(67, 13)
        Me.LblAutographEvent.TabIndex = 90
        Me.LblAutographEvent.Text = "Evènement :"
        '
        'lblAutographComments
        '
        Me.lblAutographComments.AutoSize = True
        Me.lblAutographComments.Location = New System.Drawing.Point(8, 113)
        Me.lblAutographComments.Name = "lblAutographComments"
        Me.lblAutographComments.Size = New System.Drawing.Size(79, 13)
        Me.lblAutographComments.TabIndex = 89
        Me.lblAutographComments.Text = "Commentaires :"
        '
        'txtAutographComments
        '
        Me.txtAutographComments.Location = New System.Drawing.Point(93, 110)
        Me.txtAutographComments.Multiline = True
        Me.txtAutographComments.Name = "txtAutographComments"
        Me.txtAutographComments.Size = New System.Drawing.Size(543, 62)
        Me.txtAutographComments.TabIndex = 10
        '
        'FrmWriteEdition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 638)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWriteEdition"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmWriteEdition"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents cmbEditor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbtSimpleBook As System.Windows.Forms.RadioButton
    Friend WithEvents rbtIntegral As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSet As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lvwLinkedTitles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAddTitle As System.Windows.Forms.Button
    Friend WithEvents btnRemoveTitle As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSpecialEdition As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rbtRead As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNotRead As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBoughtDate As FrameworkPN.DateTextBox
    Friend WithEvents cmbCollection As System.Windows.Forms.ComboBox
    Friend WithEvents txtParutionDate As FrameworkPN.DateTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPrintDate As FrameworkPN.DateTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtLegalDepositDate As FrameworkPN.DateTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtIsbn As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtEanIsbn As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtIssn As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtDdl As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtReedition As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtEditionNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtEditionInformations As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lvwLinkedActorsRoles As System.Windows.Forms.ListView
    Friend WithEvents TabControl1 As FrameworkPN.AutoIndexedTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtTitleName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtTitleNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtTitleStory As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvwSerieTitles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCopyToTitlesList As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents txtAutographComments As System.Windows.Forms.TextBox
    Friend WithEvents lblAutographComments As System.Windows.Forms.Label
    Friend WithEvents PLstFirstCover As FrameworkPN.PicturesList
    Friend WithEvents PLstFourthCover As FrameworkPN.PicturesList
    Friend WithEvents PLstBoards As FrameworkPN.PicturesList
    Friend WithEvents PLstAutograph As FrameworkPN.PicturesList
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents LstLinkedSeries As System.Windows.Forms.ListBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents LstSeries As System.Windows.Forms.ListBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents TxtSeriesFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents BtnAddSerie As System.Windows.Forms.Button
    Friend WithEvents BtnRemoveSerie As System.Windows.Forms.Button
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents LvwColor As System.Windows.Forms.ListView
    Friend WithEvents txtAddinPagesCount As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtBoardsCount As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbState As System.Windows.Forms.ComboBox
    Friend WithEvents LvwFormat As System.Windows.Forms.ListView
    Friend WithEvents cmbSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents lvwActors As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvwRoles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents txtRolesFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents txtActorsFilter As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRemoveActorRole As System.Windows.Forms.Button
    Friend WithEvents btnAddActorRole As System.Windows.Forms.Button
    Friend WithEvents btnNewRole As System.Windows.Forms.Button
    Friend WithEvents btnNewAuthor As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnNewSociety As System.Windows.Forms.Button
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents rbtNotOutSerie As System.Windows.Forms.RadioButton
    Friend WithEvents rbtOutSerie As System.Windows.Forms.RadioButton
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPrintingMaxNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPrintingNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtEditionComments As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents LblAutographDate As System.Windows.Forms.Label
    Friend WithEvents TxtAutographDate As FrameworkPN.DateTextBox
    Friend WithEvents LblAutographPlace As System.Windows.Forms.Label
    Friend WithEvents TxtAutographPlace As System.Windows.Forms.TextBox
    Friend WithEvents TxtAutographEvent As System.Windows.Forms.TextBox
    Friend WithEvents LblAutographEvent As System.Windows.Forms.Label
    Friend WithEvents BtnRemoveAutograph As System.Windows.Forms.Button
    Friend WithEvents BtnAddAutograph As System.Windows.Forms.Button
    Friend WithEvents LvwAutographs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents slst_authors As FrameworkPN.SelectList
    Friend WithEvents Btn_CreateAuthor As Button
    Friend WithEvents btn_possessionState As Button
End Class

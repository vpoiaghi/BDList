<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWriteGoody
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
        Me.cmbKindOfGoody = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rtbDescription = New System.Windows.Forms.RichTextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumberMax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtbAutograph = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rtbFormat = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rtbComments = New System.Windows.Forms.RichTextBox()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.lblCollection = New System.Windows.Forms.Label()
        Me.txtNumberInCollection = New System.Windows.Forms.TextBox()
        Me.lblNumberInCollection = New System.Windows.Forms.Label()
        Me.cmbCollection = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkScanned = New System.Windows.Forms.CheckBox()
        Me.cmbNumberType = New System.Windows.Forms.ComboBox()
        Me.btn_possessionState = New System.Windows.Forms.Button()
        Me.plstPictures = New FrameworkPN.PicturesList()
        Me.slst_editions = New FrameworkPN.SelectList()
        Me.dtxtBoughtDate = New FrameworkPN.DateTextBox()
        Me.dtxtParutionDate = New FrameworkPN.DateTextBox()
        Me.slst_editors = New FrameworkPN.SelectList()
        Me.slst_series = New FrameworkPN.SelectList()
        Me.slst_authors = New FrameworkPN.SelectList()
        Me.SuspendLayout()
        '
        'cmbKindOfGoody
        '
        Me.cmbKindOfGoody.FormattingEnabled = True
        Me.cmbKindOfGoody.Location = New System.Drawing.Point(121, 162)
        Me.cmbKindOfGoody.Name = "cmbKindOfGoody"
        Me.cmbKindOfGoody.Size = New System.Drawing.Size(413, 21)
        Me.cmbKindOfGoody.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Type d'objet :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Description :"
        '
        'rtbDescription
        '
        Me.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbDescription.Location = New System.Drawing.Point(112, 273)
        Me.rtbDescription.Name = "rtbDescription"
        Me.rtbDescription.Size = New System.Drawing.Size(422, 48)
        Me.rtbDescription.TabIndex = 4
        Me.rtbDescription.Text = ""
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(112, 441)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(49, 20)
        Me.txtNumber.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 444)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Numéroté :"
        '
        'txtNumberMax
        '
        Me.txtNumberMax.Location = New System.Drawing.Point(185, 441)
        Me.txtNumberMax.Name = "txtNumberMax"
        Me.txtNumberMax.Size = New System.Drawing.Size(49, 20)
        Me.txtNumberMax.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "/"
        '
        'rtbAutograph
        '
        Me.rtbAutograph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbAutograph.Location = New System.Drawing.Point(112, 467)
        Me.rtbAutograph.Name = "rtbAutograph"
        Me.rtbAutograph.Size = New System.Drawing.Size(422, 48)
        Me.rtbAutograph.TabIndex = 15
        Me.rtbAutograph.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Dédicace :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Date de parution :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(236, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Date d'obtention :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 359)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Largeur (mm) :"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(112, 356)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(89, 20)
        Me.txtWidth.TabIndex = 8
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(333, 356)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(89, 20)
        Me.txtHeight.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(236, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Hauteur (mm) :"
        '
        'rtbFormat
        '
        Me.rtbFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbFormat.Location = New System.Drawing.Point(112, 387)
        Me.rtbFormat.Name = "rtbFormat"
        Me.rtbFormat.Size = New System.Drawing.Size(422, 48)
        Me.rtbFormat.TabIndex = 10
        Me.rtbFormat.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 387)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Format :"
        '
        'rtbComments
        '
        Me.rtbComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbComments.Location = New System.Drawing.Point(112, 521)
        Me.rtbComments.Name = "rtbComments"
        Me.rtbComments.Size = New System.Drawing.Size(422, 48)
        Me.rtbComments.TabIndex = 16
        Me.rtbComments.Text = ""
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(14, 521)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(79, 13)
        Me.lblComments.TabIndex = 29
        Me.lblComments.Text = "Commentaires :"
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(787, 694)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(100, 22)
        Me.BtnOK.TabIndex = 22
        Me.BtnOK.Text = "Enregistrer"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(888, 694)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 22)
        Me.BtnCancel.TabIndex = 23
        Me.BtnCancel.Text = "Annuler"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'lblCollection
        '
        Me.lblCollection.AutoSize = True
        Me.lblCollection.Location = New System.Drawing.Point(14, 578)
        Me.lblCollection.Name = "lblCollection"
        Me.lblCollection.Size = New System.Drawing.Size(59, 13)
        Me.lblCollection.TabIndex = 33
        Me.lblCollection.Text = "Collection :"
        '
        'txtNumberInCollection
        '
        Me.txtNumberInCollection.Location = New System.Drawing.Point(472, 575)
        Me.txtNumberInCollection.Name = "txtNumberInCollection"
        Me.txtNumberInCollection.Size = New System.Drawing.Size(62, 20)
        Me.txtNumberInCollection.TabIndex = 18
        '
        'lblNumberInCollection
        '
        Me.lblNumberInCollection.AutoSize = True
        Me.lblNumberInCollection.Location = New System.Drawing.Point(331, 578)
        Me.lblNumberInCollection.Name = "lblNumberInCollection"
        Me.lblNumberInCollection.Size = New System.Drawing.Size(135, 13)
        Me.lblNumberInCollection.TabIndex = 32
        Me.lblNumberInCollection.Text = "Numéro dans la collection :"
        '
        'cmbCollection
        '
        Me.cmbCollection.FormattingEnabled = True
        Me.cmbCollection.Location = New System.Drawing.Point(112, 575)
        Me.cmbCollection.Name = "cmbCollection"
        Me.cmbCollection.Size = New System.Drawing.Size(213, 21)
        Me.cmbCollection.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(417, 444)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Images scannées :"
        '
        'chkScanned
        '
        Me.chkScanned.AutoSize = True
        Me.chkScanned.Location = New System.Drawing.Point(519, 444)
        Me.chkScanned.Name = "chkScanned"
        Me.chkScanned.Size = New System.Drawing.Size(15, 14)
        Me.chkScanned.TabIndex = 14
        Me.chkScanned.UseVisualStyleBackColor = True
        '
        'cmbNumberType
        '
        Me.cmbNumberType.FormattingEnabled = True
        Me.cmbNumberType.Location = New System.Drawing.Point(240, 441)
        Me.cmbNumberType.Name = "cmbNumberType"
        Me.cmbNumberType.Size = New System.Drawing.Size(76, 21)
        Me.cmbNumberType.TabIndex = 13
        '
        'btn_possessionState
        '
        Me.btn_possessionState.Location = New System.Drawing.Point(484, 327)
        Me.btn_possessionState.Name = "btn_possessionState"
        Me.btn_possessionState.Size = New System.Drawing.Size(50, 50)
        Me.btn_possessionState.TabIndex = 7
        Me.btn_possessionState.UseVisualStyleBackColor = True
        '
        'plstPictures
        '
        Me.plstPictures.BackColor = System.Drawing.Color.DarkGray
        Me.plstPictures.Location = New System.Drawing.Point(540, 12)
        Me.plstPictures.Name = "plstPictures"
        Me.plstPictures.Size = New System.Drawing.Size(448, 676)
        Me.plstPictures.TabIndex = 21
        '
        'slst_editions
        '
        Me.slst_editions.AllowAdd = False
        Me.slst_editions.Enabled = False
        Me.slst_editions.Location = New System.Drawing.Point(14, 189)
        Me.slst_editions.Name = "slst_editions"
        Me.slst_editions.Size = New System.Drawing.Size(520, 78)
        Me.slst_editions.TabIndex = 3
        Me.slst_editions.Title = "Éditions :"
        '
        'dtxtBoughtDate
        '
        Me.dtxtBoughtDate.DateFormat = "dd/MM/yyyy"
        Me.dtxtBoughtDate.Location = New System.Drawing.Point(333, 327)
        Me.dtxtBoughtDate.Name = "dtxtBoughtDate"
        Me.dtxtBoughtDate.Size = New System.Drawing.Size(89, 20)
        Me.dtxtBoughtDate.TabIndex = 6
        '
        'dtxtParutionDate
        '
        Me.dtxtParutionDate.DateFormat = "dd/MM/yyyy"
        Me.dtxtParutionDate.Location = New System.Drawing.Point(112, 327)
        Me.dtxtParutionDate.Name = "dtxtParutionDate"
        Me.dtxtParutionDate.Size = New System.Drawing.Size(89, 20)
        Me.dtxtParutionDate.TabIndex = 5
        '
        'slst_editors
        '
        Me.slst_editors.AllowAdd = True
        Me.slst_editors.Location = New System.Drawing.Point(12, 96)
        Me.slst_editors.Name = "slst_editors"
        Me.slst_editors.Size = New System.Drawing.Size(522, 60)
        Me.slst_editors.TabIndex = 1
        Me.slst_editors.Title = "Éditeurs :"
        '
        'slst_series
        '
        Me.slst_series.AllowAdd = False
        Me.slst_series.Location = New System.Drawing.Point(12, 12)
        Me.slst_series.Name = "slst_series"
        Me.slst_series.Size = New System.Drawing.Size(522, 78)
        Me.slst_series.TabIndex = 0
        Me.slst_series.Title = "Séries :"
        '
        'slst_authors
        '
        Me.slst_authors.AllowAdd = True
        Me.slst_authors.Location = New System.Drawing.Point(12, 617)
        Me.slst_authors.Name = "slst_authors"
        Me.slst_authors.Size = New System.Drawing.Size(522, 78)
        Me.slst_authors.TabIndex = 19
        Me.slst_authors.Title = "Auteurs :"
        '
        'FrmWriteGoody
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 728)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_possessionState)
        Me.Controls.Add(Me.cmbNumberType)
        Me.Controls.Add(Me.chkScanned)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbCollection)
        Me.Controls.Add(Me.lblCollection)
        Me.Controls.Add(Me.txtNumberInCollection)
        Me.Controls.Add(Me.lblNumberInCollection)
        Me.Controls.Add(Me.plstPictures)
        Me.Controls.Add(Me.slst_editions)
        Me.Controls.Add(Me.dtxtBoughtDate)
        Me.Controls.Add(Me.dtxtParutionDate)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.rtbComments)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.rtbFormat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rtbAutograph)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumberMax)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtbDescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbKindOfGoody)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.slst_editors)
        Me.Controls.Add(Me.slst_series)
        Me.Controls.Add(Me.slst_authors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWriteGoody"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Para-bd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents slst_series As FrameworkPN.SelectList
    Friend WithEvents slst_editors As FrameworkPN.SelectList
    Friend WithEvents cmbKindOfGoody As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rtbDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumberMax As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rtbAutograph As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rtbFormat As System.Windows.Forms.RichTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rtbComments As System.Windows.Forms.RichTextBox
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents dtxtParutionDate As FrameworkPN.DateTextBox
    Friend WithEvents dtxtBoughtDate As FrameworkPN.DateTextBox
    Friend WithEvents slst_editions As FrameworkPN.SelectList
    Friend WithEvents plstPictures As FrameworkPN.PicturesList
    Friend WithEvents slst_authors As FrameworkPN.SelectList
    Friend WithEvents lblCollection As System.Windows.Forms.Label
    Friend WithEvents txtNumberInCollection As System.Windows.Forms.TextBox
    Friend WithEvents lblNumberInCollection As System.Windows.Forms.Label
    Friend WithEvents cmbCollection As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkScanned As CheckBox
    Friend WithEvents cmbNumberType As ComboBox
    Friend WithEvents btn_possessionState As Button
End Class

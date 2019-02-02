<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWriteAuthor
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWriteAuthor))
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.RtbBiography = New System.Windows.Forms.RichTextBox()
        Me.TxtWebSite = New System.Windows.Forms.TextBox()
        Me.TxtLastname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFirstname = New System.Windows.Forms.TextBox()
        Me.TxtAlias = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pctPicture = New System.Windows.Forms.PictureBox()
        Me.TxtBirthPlace = New System.Windows.Forms.TextBox()
        Me.LvwPersons = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LvwAliases = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnAddAlias = New System.Windows.Forms.Button()
        Me.BtnDeleteAlias = New System.Windows.Forms.Button()
        Me.BtnShowAlias = New System.Windows.Forms.Button()
        Me.BtnDeletePerson = New System.Windows.Forms.Button()
        Me.BtnAddPerson = New System.Windows.Forms.Button()
        Me.TxtBirthCountry = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DtbDeathday = New FrameworkPN.DateTextBox()
        Me.DtbBirthday = New FrameworkPN.DateTextBox()
        Me.LblAuthorId = New System.Windows.Forms.Label()
        CType(Me.pctPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(601, 407)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(100, 22)
        Me.BtnOK.TabIndex = 10
        Me.BtnOK.Text = "Enregistrer"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(702, 407)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 22)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "Annuler"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'RtbBiography
        '
        Me.RtbBiography.Location = New System.Drawing.Point(345, 240)
        Me.RtbBiography.Name = "RtbBiography"
        Me.RtbBiography.Size = New System.Drawing.Size(457, 156)
        Me.RtbBiography.TabIndex = 9
        Me.RtbBiography.Text = ""
        '
        'TxtWebSite
        '
        Me.TxtWebSite.Location = New System.Drawing.Point(345, 131)
        Me.TxtWebSite.Name = "TxtWebSite"
        Me.TxtWebSite.Size = New System.Drawing.Size(296, 20)
        Me.TxtWebSite.TabIndex = 4
        '
        'TxtLastname
        '
        Me.TxtLastname.Location = New System.Drawing.Point(345, 69)
        Me.TxtLastname.Name = "TxtLastname"
        Me.TxtLastname.Size = New System.Drawing.Size(225, 20)
        Me.TxtLastname.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(254, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Site web :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Pseudo :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Prénom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(254, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nom :"
        '
        'TxtFirstname
        '
        Me.TxtFirstname.Location = New System.Drawing.Point(345, 100)
        Me.TxtFirstname.Name = "TxtFirstname"
        Me.TxtFirstname.Size = New System.Drawing.Size(225, 20)
        Me.TxtFirstname.TabIndex = 3
        '
        'TxtAlias
        '
        Me.TxtAlias.Location = New System.Drawing.Point(124, 12)
        Me.TxtAlias.Name = "TxtAlias"
        Me.TxtAlias.Size = New System.Drawing.Size(577, 20)
        Me.TxtAlias.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(254, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Biographie :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Date naissance :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Date décès :"
        '
        'pctPicture
        '
        Me.pctPicture.BackColor = System.Drawing.Color.Black
        Me.pctPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctPicture.Image = CType(resources.GetObject("pctPicture.Image"), System.Drawing.Image)
        Me.pctPicture.Location = New System.Drawing.Point(659, 44)
        Me.pctPicture.Name = "pctPicture"
        Me.pctPicture.Size = New System.Drawing.Size(143, 174)
        Me.pctPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctPicture.TabIndex = 29
        Me.pctPicture.TabStop = False
        '
        'TxtBirthPlace
        '
        Me.TxtBirthPlace.Location = New System.Drawing.Point(345, 188)
        Me.TxtBirthPlace.Name = "TxtBirthPlace"
        Me.TxtBirthPlace.Size = New System.Drawing.Size(165, 20)
        Me.TxtBirthPlace.TabIndex = 6
        '
        'LvwPersons
        '
        Me.LvwPersons.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.LvwPersons.FullRowSelect = True
        Me.LvwPersons.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LvwPersons.HideSelection = False
        Me.LvwPersons.Location = New System.Drawing.Point(17, 69)
        Me.LvwPersons.Name = "LvwPersons"
        Me.LvwPersons.Size = New System.Drawing.Size(216, 110)
        Me.LvwPersons.TabIndex = 33
        Me.LvwPersons.TabStop = False
        Me.LvwPersons.UseCompatibleStateImageBehavior = False
        Me.LvwPersons.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 210
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Personnes :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Autres pseudos :"
        '
        'LvwAliases
        '
        Me.LvwAliases.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.LvwAliases.FullRowSelect = True
        Me.LvwAliases.GridLines = True
        Me.LvwAliases.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LvwAliases.HideSelection = False
        Me.LvwAliases.Location = New System.Drawing.Point(17, 257)
        Me.LvwAliases.MultiSelect = False
        Me.LvwAliases.Name = "LvwAliases"
        Me.LvwAliases.Size = New System.Drawing.Size(216, 110)
        Me.LvwAliases.TabIndex = 35
        Me.LvwAliases.TabStop = False
        Me.LvwAliases.UseCompatibleStateImageBehavior = False
        Me.LvwAliases.View = System.Windows.Forms.View.List
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 210
        '
        'BtnAddAlias
        '
        Me.BtnAddAlias.Location = New System.Drawing.Point(17, 373)
        Me.BtnAddAlias.Name = "BtnAddAlias"
        Me.BtnAddAlias.Size = New System.Drawing.Size(68, 22)
        Me.BtnAddAlias.TabIndex = 14
        Me.BtnAddAlias.Text = "Ajouter"
        Me.BtnAddAlias.UseVisualStyleBackColor = True
        '
        'BtnDeleteAlias
        '
        Me.BtnDeleteAlias.Location = New System.Drawing.Point(91, 373)
        Me.BtnDeleteAlias.Name = "BtnDeleteAlias"
        Me.BtnDeleteAlias.Size = New System.Drawing.Size(68, 22)
        Me.BtnDeleteAlias.TabIndex = 15
        Me.BtnDeleteAlias.Text = "Supprimer"
        Me.BtnDeleteAlias.UseVisualStyleBackColor = True
        '
        'BtnShowAlias
        '
        Me.BtnShowAlias.Location = New System.Drawing.Point(165, 373)
        Me.BtnShowAlias.Name = "BtnShowAlias"
        Me.BtnShowAlias.Size = New System.Drawing.Size(68, 22)
        Me.BtnShowAlias.TabIndex = 16
        Me.BtnShowAlias.Text = "Voir"
        Me.BtnShowAlias.UseVisualStyleBackColor = True
        '
        'BtnDeletePerson
        '
        Me.BtnDeletePerson.Location = New System.Drawing.Point(91, 185)
        Me.BtnDeletePerson.Name = "BtnDeletePerson"
        Me.BtnDeletePerson.Size = New System.Drawing.Size(68, 22)
        Me.BtnDeletePerson.TabIndex = 13
        Me.BtnDeletePerson.Text = "Supprimer"
        Me.BtnDeletePerson.UseVisualStyleBackColor = True
        '
        'BtnAddPerson
        '
        Me.BtnAddPerson.Location = New System.Drawing.Point(17, 185)
        Me.BtnAddPerson.Name = "BtnAddPerson"
        Me.BtnAddPerson.Size = New System.Drawing.Size(68, 22)
        Me.BtnAddPerson.TabIndex = 12
        Me.BtnAddPerson.Text = "Ajouter"
        Me.BtnAddPerson.UseVisualStyleBackColor = True
        '
        'TxtBirthCountry
        '
        Me.TxtBirthCountry.Location = New System.Drawing.Point(516, 188)
        Me.TxtBirthCountry.Name = "TxtBirthCountry"
        Me.TxtBirthCountry.Size = New System.Drawing.Size(125, 20)
        Me.TxtBirthCountry.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(254, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Lieu naissance :"
        '
        'DtbDeathday
        '
        Me.DtbDeathday.DateFormat = "dd/MM/yyyy"
        Me.DtbDeathday.Location = New System.Drawing.Point(345, 214)
        Me.DtbDeathday.Name = "DtbDeathday"
        Me.DtbDeathday.Size = New System.Drawing.Size(100, 20)
        Me.DtbDeathday.TabIndex = 8
        '
        'DtbBirthday
        '
        Me.DtbBirthday.DateFormat = "dd/MM/yyyy"
        Me.DtbBirthday.Location = New System.Drawing.Point(345, 162)
        Me.DtbBirthday.Name = "DtbBirthday"
        Me.DtbBirthday.Size = New System.Drawing.Size(100, 20)
        Me.DtbBirthday.TabIndex = 5
        '
        'LblAuthorId
        '
        Me.LblAuthorId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAuthorId.Location = New System.Drawing.Point(707, 15)
        Me.LblAuthorId.Name = "LblAuthorId"
        Me.LblAuthorId.Size = New System.Drawing.Size(95, 13)
        Me.LblAuthorId.TabIndex = 44
        Me.LblAuthorId.Text = "Id"
        Me.LblAuthorId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmWriteAuthor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 439)
        Me.Controls.Add(Me.LblAuthorId)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtBirthCountry)
        Me.Controls.Add(Me.BtnDeletePerson)
        Me.Controls.Add(Me.BtnAddPerson)
        Me.Controls.Add(Me.BtnShowAlias)
        Me.Controls.Add(Me.BtnDeleteAlias)
        Me.Controls.Add(Me.BtnAddAlias)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LvwAliases)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LvwPersons)
        Me.Controls.Add(Me.TxtBirthPlace)
        Me.Controls.Add(Me.DtbDeathday)
        Me.Controls.Add(Me.pctPicture)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtbBirthday)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtAlias)
        Me.Controls.Add(Me.TxtFirstname)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.RtbBiography)
        Me.Controls.Add(Me.TxtWebSite)
        Me.Controls.Add(Me.TxtLastname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWriteAuthor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajouter ou modifier un auteur"
        CType(Me.pctPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents RtbBiography As System.Windows.Forms.RichTextBox
    Friend WithEvents TxtWebSite As System.Windows.Forms.TextBox
    Friend WithEvents TxtLastname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlias As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DtbBirthday As FrameworkPN.DateTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pctPicture As System.Windows.Forms.PictureBox
    Friend WithEvents DtbDeathday As FrameworkPN.DateTextBox
    Friend WithEvents TxtBirthPlace As System.Windows.Forms.TextBox
    Friend WithEvents LvwPersons As System.Windows.Forms.ListView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LvwAliases As System.Windows.Forms.ListView
    Friend WithEvents BtnAddAlias As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteAlias As System.Windows.Forms.Button
    Friend WithEvents BtnShowAlias As System.Windows.Forms.Button
    Friend WithEvents BtnDeletePerson As System.Windows.Forms.Button
    Friend WithEvents BtnAddPerson As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtBirthCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblAuthorId As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWriteEditor
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_webSite = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nationality = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cessationCause = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_legalForm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_headOffice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_headQuarters = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_broadcasting = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_comingWebSite = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Btn_CreateAuthor = New System.Windows.Forms.Button()
        Me.pct_Editor = New System.Windows.Forms.PictureBox()
        Me.slst_managers = New FrameworkPN.SelectList()
        Me.txt_cessationYear = New System.Windows.Forms.TextBox()
        Me.txt_foundationYear = New System.Windows.Forms.TextBox()
        CType(Me.pct_Editor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Année de fondation :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Année de Cessation :"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(634, 438)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 22)
        Me.btn_save.TabIndex = 13
        Me.btn_save.Text = "Enregistrer"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.Location = New System.Drawing.Point(735, 438)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(100, 22)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "Annuler"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(133, 12)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(324, 20)
        Me.txt_name.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Nom :"
        '
        'txt_webSite
        '
        Me.txt_webSite.Location = New System.Drawing.Point(133, 362)
        Me.txt_webSite.Name = "txt_webSite"
        Me.txt_webSite.Size = New System.Drawing.Size(702, 20)
        Me.txt_webSite.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 365)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Site web :"
        '
        'txt_nationality
        '
        Me.txt_nationality.Location = New System.Drawing.Point(133, 38)
        Me.txt_nationality.MaxLength = 100
        Me.txt_nationality.Name = "txt_nationality"
        Me.txt_nationality.Size = New System.Drawing.Size(214, 20)
        Me.txt_nationality.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Nationalité :"
        '
        'txt_cessationCause
        '
        Me.txt_cessationCause.Location = New System.Drawing.Point(133, 136)
        Me.txt_cessationCause.MaxLength = 100
        Me.txt_cessationCause.Multiline = True
        Me.txt_cessationCause.Name = "txt_cessationCause"
        Me.txt_cessationCause.Size = New System.Drawing.Size(324, 68)
        Me.txt_cessationCause.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Cause de cessation :"
        '
        'txt_legalForm
        '
        Me.txt_legalForm.Location = New System.Drawing.Point(133, 210)
        Me.txt_legalForm.MaxLength = 100
        Me.txt_legalForm.Name = "txt_legalForm"
        Me.txt_legalForm.Size = New System.Drawing.Size(324, 20)
        Me.txt_legalForm.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Forme légale :"
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(133, 236)
        Me.txt_status.MaxLength = 100
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(324, 20)
        Me.txt_status.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Statut :"
        '
        'txt_headOffice
        '
        Me.txt_headOffice.Location = New System.Drawing.Point(133, 262)
        Me.txt_headOffice.MaxLength = 100
        Me.txt_headOffice.Name = "txt_headOffice"
        Me.txt_headOffice.Size = New System.Drawing.Size(324, 20)
        Me.txt_headOffice.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Maison mère :"
        '
        'txt_headQuarters
        '
        Me.txt_headQuarters.Location = New System.Drawing.Point(133, 288)
        Me.txt_headQuarters.MaxLength = 100
        Me.txt_headQuarters.Name = "txt_headQuarters"
        Me.txt_headQuarters.Size = New System.Drawing.Size(324, 20)
        Me.txt_headQuarters.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Centre :"
        '
        'txt_broadcasting
        '
        Me.txt_broadcasting.Location = New System.Drawing.Point(133, 314)
        Me.txt_broadcasting.MaxLength = 100
        Me.txt_broadcasting.Name = "txt_broadcasting"
        Me.txt_broadcasting.Size = New System.Drawing.Size(324, 20)
        Me.txt_broadcasting.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 317)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Distributeur :"
        '
        'txt_comingWebSite
        '
        Me.txt_comingWebSite.Location = New System.Drawing.Point(133, 388)
        Me.txt_comingWebSite.Name = "txt_comingWebSite"
        Me.txt_comingWebSite.Size = New System.Drawing.Size(702, 20)
        Me.txt_comingWebSite.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 391)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 13)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Page des ""à paraître"" :"
        '
        'Btn_CreateAuthor
        '
        Me.Btn_CreateAuthor.Location = New System.Drawing.Point(814, 265)
        Me.Btn_CreateAuthor.Name = "Btn_CreateAuthor"
        Me.Btn_CreateAuthor.Size = New System.Drawing.Size(21, 21)
        Me.Btn_CreateAuthor.TabIndex = 12
        Me.Btn_CreateAuthor.Text = "+"
        Me.Btn_CreateAuthor.UseVisualStyleBackColor = True
        '
        'pct_Editor
        '
        Me.pct_Editor.BackColor = System.Drawing.Color.Black
        Me.pct_Editor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_Editor.Image = Global.BDList.My.Resources.Resources.editor_no_picture
        Me.pct_Editor.Location = New System.Drawing.Point(463, 4)
        Me.pct_Editor.Name = "pct_Editor"
        Me.pct_Editor.Size = New System.Drawing.Size(372, 174)
        Me.pct_Editor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Editor.TabIndex = 70
        Me.pct_Editor.TabStop = False
        '
        'slst_managers
        '
        Me.slst_managers.Location = New System.Drawing.Point(463, 188)
        Me.slst_managers.Name = "slst_managers"
        Me.slst_managers.Size = New System.Drawing.Size(372, 78)
        Me.slst_managers.TabIndex = 69
        Me.slst_managers.Title = "Manager :"
        '
        'txt_cessationYear
        '
        Me.txt_cessationYear.Location = New System.Drawing.Point(133, 110)
        Me.txt_cessationYear.Name = "txt_cessationYear"
        Me.txt_cessationYear.Size = New System.Drawing.Size(89, 20)
        Me.txt_cessationYear.TabIndex = 3
        '
        'txt_foundationYear
        '
        Me.txt_foundationYear.Location = New System.Drawing.Point(133, 84)
        Me.txt_foundationYear.Name = "txt_foundationYear"
        Me.txt_foundationYear.Size = New System.Drawing.Size(89, 20)
        Me.txt_foundationYear.TabIndex = 2
        '
        'FrmWriteEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 467)
        Me.Controls.Add(Me.pct_Editor)
        Me.Controls.Add(Me.Btn_CreateAuthor)
        Me.Controls.Add(Me.slst_managers)
        Me.Controls.Add(Me.txt_comingWebSite)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_broadcasting)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_headQuarters)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_headOffice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_legalForm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cessationCause)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_nationality)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_webSite)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.txt_cessationYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_foundationYear)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWriteEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editeur"
        CType(Me.pct_Editor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_foundationYear As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_cessationYear As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_webSite As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_nationality As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_cessationCause As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_legalForm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_status As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_headOffice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_headQuarters As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_broadcasting As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_comingWebSite As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Btn_CreateAuthor As Button
    Friend WithEvents slst_managers As FrameworkPN.SelectList
    Friend WithEvents pct_Editor As PictureBox
End Class

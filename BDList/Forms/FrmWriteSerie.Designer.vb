<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWriteSerie
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.radOngoing = New System.Windows.Forms.RadioButton()
        Me.radFinished = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmbKind = New System.Windows.Forms.ComboBox()
        Me.cmbOrigin = New System.Windows.Forms.ComboBox()
        Me.txtWebSite = New System.Windows.Forms.TextBox()
        Me.rtbStory = New System.Windows.Forms.RichTextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.TxtManager = New System.Windows.Forms.TextBox()
        Me.BtnSelectManager = New System.Windows.Forms.Button()
        Me.radAborted = New System.Windows.Forms.RadioButton()
        Me.BtnHeader = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Genre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Origine :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Série dirigée par :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Site web :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Résumé :"
        '
        'radOngoing
        '
        Me.radOngoing.AutoSize = True
        Me.radOngoing.Location = New System.Drawing.Point(425, 19)
        Me.radOngoing.Name = "radOngoing"
        Me.radOngoing.Size = New System.Drawing.Size(67, 17)
        Me.radOngoing.TabIndex = 4
        Me.radOngoing.TabStop = True
        Me.radOngoing.Text = "En cours"
        Me.radOngoing.UseVisualStyleBackColor = True
        '
        'radFinished
        '
        Me.radFinished.AutoSize = True
        Me.radFinished.Location = New System.Drawing.Point(425, 42)
        Me.radFinished.Name = "radFinished"
        Me.radFinished.Size = New System.Drawing.Size(69, 17)
        Me.radFinished.TabIndex = 5
        Me.radFinished.TabStop = True
        Me.radFinished.Text = "Terminée"
        Me.radFinished.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(122, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(225, 20)
        Me.txtName.TabIndex = 1
        '
        'cmbKind
        '
        Me.cmbKind.FormattingEnabled = True
        Me.cmbKind.Location = New System.Drawing.Point(122, 49)
        Me.cmbKind.Name = "cmbKind"
        Me.cmbKind.Size = New System.Drawing.Size(225, 21)
        Me.cmbKind.TabIndex = 2
        '
        'cmbOrigin
        '
        Me.cmbOrigin.FormattingEnabled = True
        Me.cmbOrigin.Location = New System.Drawing.Point(122, 80)
        Me.cmbOrigin.Name = "cmbOrigin"
        Me.cmbOrigin.Size = New System.Drawing.Size(225, 21)
        Me.cmbOrigin.TabIndex = 3
        '
        'txtWebSite
        '
        Me.txtWebSite.Location = New System.Drawing.Point(122, 173)
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.Size = New System.Drawing.Size(504, 20)
        Me.txtWebSite.TabIndex = 7
        '
        'rtbStory
        '
        Me.rtbStory.Location = New System.Drawing.Point(122, 204)
        Me.rtbStory.Name = "rtbStory"
        Me.rtbStory.Size = New System.Drawing.Size(504, 143)
        Me.rtbStory.TabIndex = 8
        Me.rtbStory.Text = ""
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(526, 359)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 22)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Annuler"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(425, 359)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(100, 22)
        Me.BtnOK.TabIndex = 9
        Me.BtnOK.Text = "Enregistrer"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'TxtManager
        '
        Me.TxtManager.Enabled = False
        Me.TxtManager.Location = New System.Drawing.Point(122, 142)
        Me.TxtManager.Name = "TxtManager"
        Me.TxtManager.Size = New System.Drawing.Size(225, 20)
        Me.TxtManager.TabIndex = 11
        '
        'BtnSelectManager
        '
        Me.BtnSelectManager.Location = New System.Drawing.Point(344, 142)
        Me.BtnSelectManager.Name = "BtnSelectManager"
        Me.BtnSelectManager.Size = New System.Drawing.Size(32, 20)
        Me.BtnSelectManager.TabIndex = 12
        Me.BtnSelectManager.Text = "..."
        Me.BtnSelectManager.UseVisualStyleBackColor = True
        '
        'radAborted
        '
        Me.radAborted.AutoSize = True
        Me.radAborted.Location = New System.Drawing.Point(425, 65)
        Me.radAborted.Name = "radAborted"
        Me.radAborted.Size = New System.Drawing.Size(86, 17)
        Me.radAborted.TabIndex = 13
        Me.radAborted.TabStop = True
        Me.radAborted.Text = "Abandonnée"
        Me.radAborted.UseVisualStyleBackColor = True
        '
        'BtnHeader
        '
        Me.BtnHeader.Location = New System.Drawing.Point(15, 359)
        Me.BtnHeader.Name = "BtnHeader"
        Me.BtnHeader.Size = New System.Drawing.Size(100, 22)
        Me.BtnHeader.TabIndex = 14
        Me.BtnHeader.Text = "Bandeau"
        Me.BtnHeader.UseVisualStyleBackColor = True
        '
        'FrmWriteSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(638, 393)
        Me.Controls.Add(Me.BtnHeader)
        Me.Controls.Add(Me.radAborted)
        Me.Controls.Add(Me.BtnSelectManager)
        Me.Controls.Add(Me.TxtManager)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.rtbStory)
        Me.Controls.Add(Me.txtWebSite)
        Me.Controls.Add(Me.cmbOrigin)
        Me.Controls.Add(Me.cmbKind)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.radFinished)
        Me.Controls.Add(Me.radOngoing)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmWriteSerie"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajouter ou modifier une série"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents radOngoing As System.Windows.Forms.RadioButton
    Friend WithEvents radFinished As System.Windows.Forms.RadioButton
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cmbKind As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOrigin As System.Windows.Forms.ComboBox
    Friend WithEvents txtWebSite As System.Windows.Forms.TextBox
    Friend WithEvents rtbStory As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents TxtManager As System.Windows.Forms.TextBox
    Friend WithEvents BtnSelectManager As System.Windows.Forms.Button
    Friend WithEvents radAborted As System.Windows.Forms.RadioButton
    Friend WithEvents BtnHeader As System.Windows.Forms.Button
End Class

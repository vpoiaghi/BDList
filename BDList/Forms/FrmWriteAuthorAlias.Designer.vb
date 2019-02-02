<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWriteAuthorAlias
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
        Me.RadNewAlias = New System.Windows.Forms.RadioButton()
        Me.TxtNewAlias = New System.Windows.Forms.TextBox()
        Me.RadAddAliasFromPerson = New System.Windows.Forms.RadioButton()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RadNewAlias
        '
        Me.RadNewAlias.AutoSize = True
        Me.RadNewAlias.Location = New System.Drawing.Point(11, 8)
        Me.RadNewAlias.Name = "RadNewAlias"
        Me.RadNewAlias.Size = New System.Drawing.Size(124, 17)
        Me.RadNewAlias.TabIndex = 0
        Me.RadNewAlias.TabStop = True
        Me.RadNewAlias.Text = "Créer u nouvel alias :"
        Me.RadNewAlias.UseVisualStyleBackColor = True
        '
        'TxtNewAlias
        '
        Me.TxtNewAlias.Location = New System.Drawing.Point(39, 31)
        Me.TxtNewAlias.Name = "TxtNewAlias"
        Me.TxtNewAlias.Size = New System.Drawing.Size(319, 20)
        Me.TxtNewAlias.TabIndex = 1
        '
        'RadAddAliasFromPerson
        '
        Me.RadAddAliasFromPerson.AutoSize = True
        Me.RadAddAliasFromPerson.Location = New System.Drawing.Point(11, 73)
        Me.RadAddAliasFromPerson.Name = "RadAddAliasFromPerson"
        Me.RadAddAliasFromPerson.Size = New System.Drawing.Size(178, 17)
        Me.RadAddAliasFromPerson.TabIndex = 2
        Me.RadAddAliasFromPerson.TabStop = True
        Me.RadAddAliasFromPerson.Text = "Ajouter <person> comme auteur."
        Me.RadAddAliasFromPerson.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(105, 118)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(96, 24)
        Me.BtnOK.TabIndex = 3
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(207, 118)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(96, 24)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Annuler"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FrmWriteAuthorAlias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 154)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.RadAddAliasFromPerson)
        Me.Controls.Add(Me.TxtNewAlias)
        Me.Controls.Add(Me.RadNewAlias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWriteAuthorAlias"
        Me.Text = "Ajouter un alias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadNewAlias As System.Windows.Forms.RadioButton
    Friend WithEvents TxtNewAlias As System.Windows.Forms.TextBox
    Friend WithEvents RadAddAliasFromPerson As System.Windows.Forms.RadioButton
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class

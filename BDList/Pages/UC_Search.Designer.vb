Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Search
    Inherits UC_Page

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.lbl_keyword = New System.Windows.Forms.Label()
        Me.txt_keyword = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_inPossession = New System.Windows.Forms.Button()
        Me.btn_wanted = New System.Windows.Forms.Button()
        Me.btn_missing = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_editor = New System.Windows.Forms.TextBox()
        Me.lbl_editor = New System.Windows.Forms.Label()
        Me.lbl_kindOfGoodies = New System.Windows.Forms.Label()
        Me.cmb_kindOfGoodies = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_reinitialize = New System.Windows.Forms.Button()
        Me.cmb_collection = New System.Windows.Forms.ComboBox()
        Me.lbl_collection = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_toReserveAtBDfugue = New System.Windows.Forms.Button()
        Me.btn_reserved = New System.Windows.Forms.Button()
        Me.btn_inDelivery = New System.Windows.Forms.Button()
        Me.btn_toReserveAtCultura = New System.Windows.Forms.Button()
        Me.btn_present = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_keyword
        '
        Me.lbl_keyword.AutoSize = True
        Me.lbl_keyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_keyword.Location = New System.Drawing.Point(23, 87)
        Me.lbl_keyword.Name = "lbl_keyword"
        Me.lbl_keyword.Size = New System.Drawing.Size(113, 20)
        Me.lbl_keyword.TabIndex = 1
        Me.lbl_keyword.Text = "Mot clé / Nom :"
        '
        'txt_keyword
        '
        Me.txt_keyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_keyword.Location = New System.Drawing.Point(182, 84)
        Me.txt_keyword.Name = "txt_keyword"
        Me.txt_keyword.Size = New System.Drawing.Size(464, 26)
        Me.txt_keyword.TabIndex = 0
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.SystemColors.Control
        Me.btn_search.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(10, 10)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(10)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(161, 50)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Chercher"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'btn_inPossession
        '
        Me.btn_inPossession.BackColor = System.Drawing.Color.Lime
        Me.btn_inPossession.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inPossession.Image = Global.BDList.My.Resources.Resources.check
        Me.btn_inPossession.Location = New System.Drawing.Point(702, 84)
        Me.btn_inPossession.Name = "btn_inPossession"
        Me.btn_inPossession.Size = New System.Drawing.Size(60, 55)
        Me.btn_inPossession.TabIndex = 5
        Me.btn_inPossession.UseVisualStyleBackColor = False
        '
        'btn_wanted
        '
        Me.btn_wanted.BackColor = System.Drawing.Color.Lime
        Me.btn_wanted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_wanted.Image = Global.BDList.My.Resources.Resources.uncheck_but_wanted
        Me.btn_wanted.Location = New System.Drawing.Point(768, 84)
        Me.btn_wanted.Name = "btn_wanted"
        Me.btn_wanted.Size = New System.Drawing.Size(60, 55)
        Me.btn_wanted.TabIndex = 6
        Me.btn_wanted.UseVisualStyleBackColor = False
        '
        'btn_missing
        '
        Me.btn_missing.BackColor = System.Drawing.Color.Lime
        Me.btn_missing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_missing.Image = Global.BDList.My.Resources.Resources.uncheck
        Me.btn_missing.Location = New System.Drawing.Point(834, 84)
        Me.btn_missing.Name = "btn_missing"
        Me.btn_missing.Size = New System.Drawing.Size(60, 55)
        Me.btn_missing.TabIndex = 7
        Me.btn_missing.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 110)
        Me.Button1.Margin = New System.Windows.Forms.Padding(10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 50)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Ajouter une série"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_editor
        '
        Me.txt_editor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_editor.Location = New System.Drawing.Point(182, 177)
        Me.txt_editor.Name = "txt_editor"
        Me.txt_editor.Size = New System.Drawing.Size(464, 26)
        Me.txt_editor.TabIndex = 2
        '
        'lbl_editor
        '
        Me.lbl_editor.AutoSize = True
        Me.lbl_editor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editor.Location = New System.Drawing.Point(23, 180)
        Me.lbl_editor.Name = "lbl_editor"
        Me.lbl_editor.Size = New System.Drawing.Size(68, 20)
        Me.lbl_editor.TabIndex = 14
        Me.lbl_editor.Text = "Editeur :"
        '
        'lbl_kindOfGoodies
        '
        Me.lbl_kindOfGoodies.AutoSize = True
        Me.lbl_kindOfGoodies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kindOfGoodies.Location = New System.Drawing.Point(23, 305)
        Me.lbl_kindOfGoodies.Name = "lbl_kindOfGoodies"
        Me.lbl_kindOfGoodies.Size = New System.Drawing.Size(143, 20)
        Me.lbl_kindOfGoodies.TabIndex = 16
        Me.lbl_kindOfGoodies.Text = "Genre de para-bd :"
        '
        'cmb_kindOfGoodies
        '
        Me.cmb_kindOfGoodies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_kindOfGoodies.FormattingEnabled = True
        Me.cmb_kindOfGoodies.Location = New System.Drawing.Point(182, 302)
        Me.cmb_kindOfGoodies.Name = "cmb_kindOfGoodies"
        Me.cmb_kindOfGoodies.Size = New System.Drawing.Size(464, 28)
        Me.cmb_kindOfGoodies.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_reinitialize)
        Me.Panel1.Controls.Add(Me.btn_search)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1050, 62)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(181, 714)
        Me.Panel1.TabIndex = 18
        '
        'btn_reinitialize
        '
        Me.btn_reinitialize.BackColor = System.Drawing.SystemColors.Control
        Me.btn_reinitialize.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_reinitialize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reinitialize.Location = New System.Drawing.Point(10, 60)
        Me.btn_reinitialize.Margin = New System.Windows.Forms.Padding(10)
        Me.btn_reinitialize.Name = "btn_reinitialize"
        Me.btn_reinitialize.Size = New System.Drawing.Size(161, 50)
        Me.btn_reinitialize.TabIndex = 10
        Me.btn_reinitialize.Text = "Remise à zéro"
        Me.btn_reinitialize.UseVisualStyleBackColor = False
        '
        'cmb_collection
        '
        Me.cmb_collection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_collection.FormattingEnabled = True
        Me.cmb_collection.Location = New System.Drawing.Point(182, 336)
        Me.cmb_collection.Name = "cmb_collection"
        Me.cmb_collection.Size = New System.Drawing.Size(464, 28)
        Me.cmb_collection.TabIndex = 4
        '
        'lbl_collection
        '
        Me.lbl_collection.AutoSize = True
        Me.lbl_collection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_collection.Location = New System.Drawing.Point(23, 339)
        Me.lbl_collection.Name = "lbl_collection"
        Me.lbl_collection.Size = New System.Drawing.Size(86, 20)
        Me.lbl_collection.TabIndex = 20
        Me.lbl_collection.Text = "Collection :"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(182, 116)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(464, 26)
        Me.txt_id.TabIndex = 1
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(23, 119)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(88, 20)
        Me.lbl_id.TabIndex = 22
        Me.lbl_id.Text = "Identifiant :"
        '
        'btn_toReserveAtBDfugue
        '
        Me.btn_toReserveAtBDfugue.BackColor = System.Drawing.Color.Lime
        Me.btn_toReserveAtBDfugue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_toReserveAtBDfugue.Image = Global.BDList.My.Resources.Resources.to_order_at_bdfugue
        Me.btn_toReserveAtBDfugue.Location = New System.Drawing.Point(834, 145)
        Me.btn_toReserveAtBDfugue.Name = "btn_toReserveAtBDfugue"
        Me.btn_toReserveAtBDfugue.Size = New System.Drawing.Size(60, 55)
        Me.btn_toReserveAtBDfugue.TabIndex = 25
        Me.btn_toReserveAtBDfugue.UseVisualStyleBackColor = False
        '
        'btn_reserved
        '
        Me.btn_reserved.BackColor = System.Drawing.Color.Lime
        Me.btn_reserved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reserved.Image = Global.BDList.My.Resources.Resources.uncheck_reserved
        Me.btn_reserved.Location = New System.Drawing.Point(768, 145)
        Me.btn_reserved.Name = "btn_reserved"
        Me.btn_reserved.Size = New System.Drawing.Size(60, 55)
        Me.btn_reserved.TabIndex = 24
        Me.btn_reserved.UseVisualStyleBackColor = False
        '
        'btn_inDelivery
        '
        Me.btn_inDelivery.BackColor = System.Drawing.Color.Lime
        Me.btn_inDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inDelivery.Image = Global.BDList.My.Resources.Resources.uncheck_delivery
        Me.btn_inDelivery.Location = New System.Drawing.Point(702, 145)
        Me.btn_inDelivery.Name = "btn_inDelivery"
        Me.btn_inDelivery.Size = New System.Drawing.Size(60, 55)
        Me.btn_inDelivery.TabIndex = 23
        Me.btn_inDelivery.UseVisualStyleBackColor = False
        '
        'btn_toReserveAtCultura
        '
        Me.btn_toReserveAtCultura.BackColor = System.Drawing.Color.Lime
        Me.btn_toReserveAtCultura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_toReserveAtCultura.Image = Global.BDList.My.Resources.Resources.to_reserve_at_cultura
        Me.btn_toReserveAtCultura.Location = New System.Drawing.Point(702, 206)
        Me.btn_toReserveAtCultura.Name = "btn_toReserveAtCultura"
        Me.btn_toReserveAtCultura.Size = New System.Drawing.Size(60, 55)
        Me.btn_toReserveAtCultura.TabIndex = 26
        Me.btn_toReserveAtCultura.UseVisualStyleBackColor = False
        '
        'btn_present
        '
        Me.btn_present.BackColor = System.Drawing.Color.Lime
        Me.btn_present.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_present.Image = Global.BDList.My.Resources.Resources.present
        Me.btn_present.Location = New System.Drawing.Point(768, 206)
        Me.btn_present.Name = "btn_present"
        Me.btn_present.Size = New System.Drawing.Size(60, 55)
        Me.btn_present.TabIndex = 27
        Me.btn_present.UseVisualStyleBackColor = False
        '
        'UC_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.btn_present)
        Me.Controls.Add(Me.btn_toReserveAtCultura)
        Me.Controls.Add(Me.btn_toReserveAtBDfugue)
        Me.Controls.Add(Me.btn_reserved)
        Me.Controls.Add(Me.btn_inDelivery)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.cmb_collection)
        Me.Controls.Add(Me.lbl_collection)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmb_kindOfGoodies)
        Me.Controls.Add(Me.lbl_kindOfGoodies)
        Me.Controls.Add(Me.txt_editor)
        Me.Controls.Add(Me.lbl_editor)
        Me.Controls.Add(Me.btn_missing)
        Me.Controls.Add(Me.btn_wanted)
        Me.Controls.Add(Me.btn_inPossession)
        Me.Controls.Add(Me.txt_keyword)
        Me.Controls.Add(Me.lbl_keyword)
        Me.Name = "UC_Search"
        Me.Size = New System.Drawing.Size(1231, 776)
        Me.Title = "Recherche"
        Me.Controls.SetChildIndex(Me.lbl_keyword, 0)
        Me.Controls.SetChildIndex(Me.txt_keyword, 0)
        Me.Controls.SetChildIndex(Me.btn_inPossession, 0)
        Me.Controls.SetChildIndex(Me.btn_wanted, 0)
        Me.Controls.SetChildIndex(Me.btn_missing, 0)
        Me.Controls.SetChildIndex(Me.lbl_editor, 0)
        Me.Controls.SetChildIndex(Me.txt_editor, 0)
        Me.Controls.SetChildIndex(Me.lbl_kindOfGoodies, 0)
        Me.Controls.SetChildIndex(Me.cmb_kindOfGoodies, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.lbl_collection, 0)
        Me.Controls.SetChildIndex(Me.cmb_collection, 0)
        Me.Controls.SetChildIndex(Me.lbl_id, 0)
        Me.Controls.SetChildIndex(Me.txt_id, 0)
        Me.Controls.SetChildIndex(Me.btn_inDelivery, 0)
        Me.Controls.SetChildIndex(Me.btn_reserved, 0)
        Me.Controls.SetChildIndex(Me.btn_toReserveAtBDfugue, 0)
        Me.Controls.SetChildIndex(Me.btn_toReserveAtCultura, 0)
        Me.Controls.SetChildIndex(Me.btn_present, 0)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_keyword As System.Windows.Forms.Label
    Friend WithEvents txt_keyword As System.Windows.Forms.TextBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents btn_inPossession As System.Windows.Forms.Button
    Friend WithEvents btn_wanted As System.Windows.Forms.Button
    Friend WithEvents btn_missing As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_editor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_editor As System.Windows.Forms.Label
    Friend WithEvents lbl_kindOfGoodies As System.Windows.Forms.Label
    Friend WithEvents cmb_kindOfGoodies As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmb_collection As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_collection As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents btn_toReserveAtBDfugue As Button
    Friend WithEvents btn_reserved As Button
    Friend WithEvents btn_inDelivery As Button
    Friend WithEvents btn_toReserveAtCultura As Button
    Friend WithEvents btn_reinitialize As Button
    Friend WithEvents btn_present As Button
End Class

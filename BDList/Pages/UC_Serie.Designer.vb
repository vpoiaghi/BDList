Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Serie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Serie))
        Me.pnl_editionsList = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnl_serieInfos = New System.Windows.Forms.Panel()
        Me.lbl_story = New System.Windows.Forms.Label()
        Me.lbl_goodies = New System.Windows.Forms.Label()
        Me.lbl_editions = New System.Windows.Forms.Label()
        Me.lbl_titles = New System.Windows.Forms.Label()
        Me.lbl_ended = New System.Windows.Forms.Label()
        Me.lbl_origin = New System.Windows.Forms.Label()
        Me.lbl_kind = New System.Windows.Forms.Label()
        Me.lst_editions = New FrameworkPN.GridView()
        Me.lst_goodies = New FrameworkPN.GridView()
        Me.pnl_serieHeader = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_copy = New System.Windows.Forms.Button()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_addEdition = New System.Windows.Forms.Button()
        Me.btn_addGoody = New System.Windows.Forms.Button()
        Me.btn_goodies = New System.Windows.Forms.Button()
        Me.btn_editions = New System.Windows.Forms.Button()
        Me.btn_serie = New System.Windows.Forms.Button()
        Me.pnl_editionsList.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnl_serieInfos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_editionsList
        '
        Me.pnl_editionsList.Controls.Add(Me.Panel2)
        Me.pnl_editionsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_editionsList.Location = New System.Drawing.Point(0, 206)
        Me.pnl_editionsList.Name = "pnl_editionsList"
        Me.pnl_editionsList.Size = New System.Drawing.Size(1257, 500)
        Me.pnl_editionsList.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pnl_serieInfos)
        Me.Panel2.Controls.Add(Me.lst_editions)
        Me.Panel2.Controls.Add(Me.lst_goodies)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1257, 500)
        Me.Panel2.TabIndex = 4
        '
        'pnl_serieInfos
        '
        Me.pnl_serieInfos.BackColor = System.Drawing.Color.Bisque
        Me.pnl_serieInfos.Controls.Add(Me.lbl_story)
        Me.pnl_serieInfos.Controls.Add(Me.lbl_goodies)
        Me.pnl_serieInfos.Controls.Add(Me.lbl_editions)
        Me.pnl_serieInfos.Controls.Add(Me.lbl_titles)
        Me.pnl_serieInfos.Controls.Add(Me.lbl_ended)
        Me.pnl_serieInfos.Controls.Add(Me.lbl_origin)
        Me.pnl_serieInfos.Controls.Add(Me.lbl_kind)
        Me.pnl_serieInfos.Location = New System.Drawing.Point(33, 44)
        Me.pnl_serieInfos.Name = "pnl_serieInfos"
        Me.pnl_serieInfos.Size = New System.Drawing.Size(862, 230)
        Me.pnl_serieInfos.TabIndex = 3
        '
        'lbl_story
        '
        Me.lbl_story.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_story.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_story.Location = New System.Drawing.Point(19, 96)
        Me.lbl_story.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_story.Name = "lbl_story"
        Me.lbl_story.Size = New System.Drawing.Size(781, 97)
        Me.lbl_story.TabIndex = 7
        Me.lbl_story.Text = "Résumé"
        '
        'lbl_goodies
        '
        Me.lbl_goodies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_goodies.Location = New System.Drawing.Point(305, 66)
        Me.lbl_goodies.Name = "lbl_goodies"
        Me.lbl_goodies.Size = New System.Drawing.Size(184, 20)
        Me.lbl_goodies.TabIndex = 16
        Me.lbl_goodies.Text = "Para-bds :"
        '
        'lbl_editions
        '
        Me.lbl_editions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editions.Location = New System.Drawing.Point(305, 41)
        Me.lbl_editions.Name = "lbl_editions"
        Me.lbl_editions.Size = New System.Drawing.Size(184, 20)
        Me.lbl_editions.TabIndex = 15
        Me.lbl_editions.Text = "Editions : "
        '
        'lbl_titles
        '
        Me.lbl_titles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titles.Location = New System.Drawing.Point(305, 16)
        Me.lbl_titles.Name = "lbl_titles"
        Me.lbl_titles.Size = New System.Drawing.Size(184, 20)
        Me.lbl_titles.TabIndex = 14
        Me.lbl_titles.Text = "Titres : "
        '
        'lbl_ended
        '
        Me.lbl_ended.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ended.Location = New System.Drawing.Point(15, 66)
        Me.lbl_ended.Name = "lbl_ended"
        Me.lbl_ended.Size = New System.Drawing.Size(284, 20)
        Me.lbl_ended.TabIndex = 13
        Me.lbl_ended.Text = "Terminée"
        '
        'lbl_origin
        '
        Me.lbl_origin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_origin.Location = New System.Drawing.Point(15, 41)
        Me.lbl_origin.Name = "lbl_origin"
        Me.lbl_origin.Size = New System.Drawing.Size(284, 20)
        Me.lbl_origin.TabIndex = 12
        Me.lbl_origin.Text = "Origine"
        '
        'lbl_kind
        '
        Me.lbl_kind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kind.Location = New System.Drawing.Point(15, 16)
        Me.lbl_kind.Name = "lbl_kind"
        Me.lbl_kind.Size = New System.Drawing.Size(284, 20)
        Me.lbl_kind.TabIndex = 11
        Me.lbl_kind.Text = "Genre"
        '
        'lst_editions
        '
        Me.lst_editions.BackColor = System.Drawing.Color.Bisque
        Me.lst_editions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_editions.ColumnsCount = 4
        Me.lst_editions.ItemsMargin = 3
        Me.lst_editions.Location = New System.Drawing.Point(980, 202)
        Me.lst_editions.Name = "lst_editions"
        Me.lst_editions.RowsCount = 4
        Me.lst_editions.Size = New System.Drawing.Size(233, 134)
        Me.lst_editions.TabIndex = 1
        '
        'lst_goodies
        '
        Me.lst_goodies.BackColor = System.Drawing.Color.Bisque
        Me.lst_goodies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_goodies.ColumnsCount = 4
        Me.lst_goodies.ItemsMargin = 3
        Me.lst_goodies.Location = New System.Drawing.Point(980, 29)
        Me.lst_goodies.Name = "lst_goodies"
        Me.lst_goodies.RowsCount = 4
        Me.lst_goodies.Size = New System.Drawing.Size(233, 134)
        Me.lst_goodies.TabIndex = 2
        '
        'pnl_serieHeader
        '
        Me.pnl_serieHeader.BackColor = System.Drawing.Color.Black
        Me.pnl_serieHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_serieHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnl_serieHeader.Name = "pnl_serieHeader"
        Me.pnl_serieHeader.Size = New System.Drawing.Size(1257, 150)
        Me.pnl_serieHeader.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btn_copy)
        Me.Panel1.Controls.Add(Me.btn_show)
        Me.Panel1.Controls.Add(Me.btn_edit)
        Me.Panel1.Controls.Add(Me.btn_addEdition)
        Me.Panel1.Controls.Add(Me.btn_addGoody)
        Me.Panel1.Controls.Add(Me.btn_goodies)
        Me.Panel1.Controls.Add(Me.btn_editions)
        Me.Panel1.Controls.Add(Me.btn_serie)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(1257, 56)
        Me.Panel1.TabIndex = 5
        '
        'btn_copy
        '
        Me.btn_copy.BackColor = System.Drawing.SystemColors.Control
        Me.btn_copy.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_copy.Image = Global.BDList.My.Resources.Resources.duplicate
        Me.btn_copy.Location = New System.Drawing.Point(1004, 3)
        Me.btn_copy.Name = "btn_copy"
        Me.btn_copy.Size = New System.Drawing.Size(50, 50)
        Me.btn_copy.TabIndex = 6
        Me.btn_copy.UseVisualStyleBackColor = False
        '
        'btn_show
        '
        Me.btn_show.BackColor = System.Drawing.SystemColors.Control
        Me.btn_show.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_show.Image = Global.BDList.My.Resources.Resources.loupe
        Me.btn_show.Location = New System.Drawing.Point(1054, 3)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(50, 50)
        Me.btn_show.TabIndex = 5
        Me.btn_show.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.Control
        Me.btn_edit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_edit.Image = Global.BDList.My.Resources.Resources.edit
        Me.btn_edit.Location = New System.Drawing.Point(1104, 3)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(50, 50)
        Me.btn_edit.TabIndex = 4
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_addEdition
        '
        Me.btn_addEdition.BackColor = System.Drawing.SystemColors.Control
        Me.btn_addEdition.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_addEdition.Image = CType(resources.GetObject("btn_addEdition.Image"), System.Drawing.Image)
        Me.btn_addEdition.Location = New System.Drawing.Point(1154, 3)
        Me.btn_addEdition.Name = "btn_addEdition"
        Me.btn_addEdition.Size = New System.Drawing.Size(50, 50)
        Me.btn_addEdition.TabIndex = 0
        Me.btn_addEdition.UseVisualStyleBackColor = False
        '
        'btn_addGoody
        '
        Me.btn_addGoody.BackColor = System.Drawing.SystemColors.Control
        Me.btn_addGoody.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_addGoody.Image = CType(resources.GetObject("btn_addGoody.Image"), System.Drawing.Image)
        Me.btn_addGoody.Location = New System.Drawing.Point(1204, 3)
        Me.btn_addGoody.Name = "btn_addGoody"
        Me.btn_addGoody.Size = New System.Drawing.Size(50, 50)
        Me.btn_addGoody.TabIndex = 1
        Me.btn_addGoody.UseVisualStyleBackColor = False
        '
        'btn_goodies
        '
        Me.btn_goodies.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_goodies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_goodies.ForeColor = System.Drawing.Color.White
        Me.btn_goodies.Location = New System.Drawing.Point(293, 3)
        Me.btn_goodies.Name = "btn_goodies"
        Me.btn_goodies.Size = New System.Drawing.Size(145, 50)
        Me.btn_goodies.TabIndex = 1
        Me.btn_goodies.TabStop = False
        Me.btn_goodies.Text = "Para-bds"
        Me.btn_goodies.UseVisualStyleBackColor = True
        '
        'btn_editions
        '
        Me.btn_editions.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_editions.Enabled = False
        Me.btn_editions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editions.ForeColor = System.Drawing.Color.White
        Me.btn_editions.Location = New System.Drawing.Point(148, 3)
        Me.btn_editions.Name = "btn_editions"
        Me.btn_editions.Size = New System.Drawing.Size(145, 50)
        Me.btn_editions.TabIndex = 0
        Me.btn_editions.TabStop = False
        Me.btn_editions.Text = "Editions"
        Me.btn_editions.UseVisualStyleBackColor = True
        '
        'btn_serie
        '
        Me.btn_serie.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_serie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_serie.ForeColor = System.Drawing.Color.White
        Me.btn_serie.Location = New System.Drawing.Point(3, 3)
        Me.btn_serie.Name = "btn_serie"
        Me.btn_serie.Size = New System.Drawing.Size(145, 50)
        Me.btn_serie.TabIndex = 3
        Me.btn_serie.TabStop = False
        Me.btn_serie.Text = "Série"
        Me.btn_serie.UseVisualStyleBackColor = True
        '
        'UC_Serie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_editionsList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_serieHeader)
        Me.Name = "UC_Serie"
        Me.ShowHeader = False
        Me.Size = New System.Drawing.Size(1257, 706)
        Me.Title = "Série"
        Me.Controls.SetChildIndex(Me.pnl_serieHeader, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.pnl_editionsList, 0)
        Me.pnl_editionsList.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnl_serieInfos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_editionsList As System.Windows.Forms.Panel
    Friend WithEvents pnl_serieHeader As System.Windows.Forms.Panel
    Friend WithEvents lbl_story As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_goodies As System.Windows.Forms.Button
    Friend WithEvents btn_editions As System.Windows.Forms.Button
    Friend WithEvents lst_editions As FrameworkPN.GridView
    Friend WithEvents btn_addEdition As System.Windows.Forms.Button
    Friend WithEvents lst_goodies As FrameworkPN.GridView
    Friend WithEvents btn_addGoody As System.Windows.Forms.Button
    Friend WithEvents pnl_serieInfos As System.Windows.Forms.Panel
    Friend WithEvents lbl_goodies As System.Windows.Forms.Label
    Friend WithEvents lbl_editions As System.Windows.Forms.Label
    Friend WithEvents lbl_titles As System.Windows.Forms.Label
    Friend WithEvents lbl_ended As System.Windows.Forms.Label
    Friend WithEvents lbl_origin As System.Windows.Forms.Label
    Friend WithEvents lbl_kind As System.Windows.Forms.Label
    Friend WithEvents btn_serie As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_show As Button
    Friend WithEvents btn_copy As Button
End Class

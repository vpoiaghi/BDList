Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridItem_Edition
    Inherits GridItem

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
        Me.lbl_serieName = New System.Windows.Forms.Label()
        Me.lbl_editionName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pct_withAutograph = New System.Windows.Forms.PictureBox()
        Me.pct_firstEdition = New System.Windows.Forms.PictureBox()
        Me.pct_inPossession = New System.Windows.Forms.PictureBox()
        Me.lbl_editor = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_comments = New System.Windows.Forms.Label()
        Me.lbl_collection = New System.Windows.Forms.Label()
        Me.lbl_cycle = New System.Windows.Forms.Label()
        Me.lbl_editionNumber = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pct_minBoard = New System.Windows.Forms.PictureBox()
        Me.pct_minFourthCover = New System.Windows.Forms.PictureBox()
        Me.pct_cover = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_parutionDate = New System.Windows.Forms.Label()
        Me.lbl_purchaseDate = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pct_withAutograph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_firstEdition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_inPossession, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pct_minBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_minFourthCover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_cover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_serieName
        '
        Me.lbl_serieName.AutoSize = True
        Me.lbl_serieName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_serieName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_serieName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_serieName.Location = New System.Drawing.Point(0, 0)
        Me.lbl_serieName.Name = "lbl_serieName"
        Me.lbl_serieName.Size = New System.Drawing.Size(46, 20)
        Me.lbl_serieName.TabIndex = 0
        Me.lbl_serieName.Text = "Série"
        Me.lbl_serieName.UseMnemonic = False
        '
        'lbl_editionName
        '
        Me.lbl_editionName.AutoSize = True
        Me.lbl_editionName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_editionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editionName.Location = New System.Drawing.Point(0, 20)
        Me.lbl_editionName.Name = "lbl_editionName"
        Me.lbl_editionName.Size = New System.Drawing.Size(109, 17)
        Me.lbl_editionName.TabIndex = 2
        Me.lbl_editionName.Text = "Nom de l'édition"
        Me.lbl_editionName.UseMnemonic = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pct_withAutograph)
        Me.Panel1.Controls.Add(Me.pct_firstEdition)
        Me.Panel1.Controls.Add(Me.pct_inPossession)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(542, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(40, 148)
        Me.Panel1.TabIndex = 5
        '
        'pct_withAutograph
        '
        Me.pct_withAutograph.BackColor = System.Drawing.Color.Transparent
        Me.pct_withAutograph.Dock = System.Windows.Forms.DockStyle.Top
        Me.pct_withAutograph.Image = Global.BDList.My.Resources.Resources.btn_signature
        Me.pct_withAutograph.Location = New System.Drawing.Point(0, 80)
        Me.pct_withAutograph.Name = "pct_withAutograph"
        Me.pct_withAutograph.Size = New System.Drawing.Size(40, 40)
        Me.pct_withAutograph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pct_withAutograph.TabIndex = 10
        Me.pct_withAutograph.TabStop = False
        '
        'pct_firstEdition
        '
        Me.pct_firstEdition.BackColor = System.Drawing.Color.Transparent
        Me.pct_firstEdition.Dock = System.Windows.Forms.DockStyle.Top
        Me.pct_firstEdition.Image = Global.BDList.My.Resources.Resources.first_edition
        Me.pct_firstEdition.Location = New System.Drawing.Point(0, 40)
        Me.pct_firstEdition.Name = "pct_firstEdition"
        Me.pct_firstEdition.Size = New System.Drawing.Size(40, 40)
        Me.pct_firstEdition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pct_firstEdition.TabIndex = 9
        Me.pct_firstEdition.TabStop = False
        '
        'pct_inPossession
        '
        Me.pct_inPossession.BackColor = System.Drawing.Color.Transparent
        Me.pct_inPossession.Dock = System.Windows.Forms.DockStyle.Top
        Me.pct_inPossession.Location = New System.Drawing.Point(0, 0)
        Me.pct_inPossession.Name = "pct_inPossession"
        Me.pct_inPossession.Size = New System.Drawing.Size(40, 40)
        Me.pct_inPossession.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pct_inPossession.TabIndex = 8
        Me.pct_inPossession.TabStop = False
        '
        'lbl_editor
        '
        Me.lbl_editor.AutoSize = True
        Me.lbl_editor.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_editor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editor.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_editor.Location = New System.Drawing.Point(0, 37)
        Me.lbl_editor.Name = "lbl_editor"
        Me.lbl_editor.Size = New System.Drawing.Size(40, 13)
        Me.lbl_editor.TabIndex = 6
        Me.lbl_editor.Text = "Editeur"
        Me.lbl_editor.UseMnemonic = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_comments)
        Me.Panel2.Controls.Add(Me.lbl_collection)
        Me.Panel2.Controls.Add(Me.lbl_cycle)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.lbl_editionNumber)
        Me.Panel2.Controls.Add(Me.lbl_editor)
        Me.Panel2.Controls.Add(Me.lbl_editionName)
        Me.Panel2.Controls.Add(Me.lbl_serieName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(161, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(381, 148)
        Me.Panel2.TabIndex = 8
        '
        'lbl_comments
        '
        Me.lbl_comments.AutoSize = True
        Me.lbl_comments.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_comments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_comments.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_comments.Location = New System.Drawing.Point(0, 102)
        Me.lbl_comments.Name = "lbl_comments"
        Me.lbl_comments.Size = New System.Drawing.Size(68, 13)
        Me.lbl_comments.TabIndex = 12
        Me.lbl_comments.Text = "Commentaire"
        Me.lbl_comments.UseMnemonic = False
        '
        'lbl_collection
        '
        Me.lbl_collection.AutoSize = True
        Me.lbl_collection.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_collection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_collection.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_collection.Location = New System.Drawing.Point(0, 89)
        Me.lbl_collection.Name = "lbl_collection"
        Me.lbl_collection.Size = New System.Drawing.Size(53, 13)
        Me.lbl_collection.TabIndex = 11
        Me.lbl_collection.Text = "Collection"
        Me.lbl_collection.UseMnemonic = False
        '
        'lbl_cycle
        '
        Me.lbl_cycle.AutoSize = True
        Me.lbl_cycle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_cycle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cycle.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_cycle.Location = New System.Drawing.Point(0, 76)
        Me.lbl_cycle.Name = "lbl_cycle"
        Me.lbl_cycle.Size = New System.Drawing.Size(33, 13)
        Me.lbl_cycle.TabIndex = 10
        Me.lbl_cycle.Text = "Cycle"
        Me.lbl_cycle.UseMnemonic = False
        '
        'lbl_editionNumber
        '
        Me.lbl_editionNumber.AutoSize = True
        Me.lbl_editionNumber.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_editionNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editionNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_editionNumber.Location = New System.Drawing.Point(0, 50)
        Me.lbl_editionNumber.Name = "lbl_editionNumber"
        Me.lbl_editionNumber.Size = New System.Drawing.Size(63, 13)
        Me.lbl_editionNumber.TabIndex = 8
        Me.lbl_editionNumber.Text = "Num édition"
        Me.lbl_editionNumber.UseMnemonic = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.pct_minBoard)
        Me.Panel3.Controls.Add(Me.pct_minFourthCover)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(107, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Panel3.Size = New System.Drawing.Size(54, 148)
        Me.Panel3.TabIndex = 9
        '
        'pct_minBoard
        '
        Me.pct_minBoard.BackColor = System.Drawing.Color.Black
        Me.pct_minBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_minBoard.Dock = System.Windows.Forms.DockStyle.Top
        Me.pct_minBoard.Location = New System.Drawing.Point(5, 64)
        Me.pct_minBoard.Name = "pct_minBoard"
        Me.pct_minBoard.Size = New System.Drawing.Size(44, 64)
        Me.pct_minBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_minBoard.TabIndex = 7
        Me.pct_minBoard.TabStop = False
        '
        'pct_minFourthCover
        '
        Me.pct_minFourthCover.BackColor = System.Drawing.Color.Black
        Me.pct_minFourthCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_minFourthCover.Dock = System.Windows.Forms.DockStyle.Top
        Me.pct_minFourthCover.Location = New System.Drawing.Point(5, 0)
        Me.pct_minFourthCover.Name = "pct_minFourthCover"
        Me.pct_minFourthCover.Size = New System.Drawing.Size(44, 64)
        Me.pct_minFourthCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_minFourthCover.TabIndex = 6
        Me.pct_minFourthCover.TabStop = False
        '
        'pct_cover
        '
        Me.pct_cover.BackColor = System.Drawing.Color.Black
        Me.pct_cover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_cover.Dock = System.Windows.Forms.DockStyle.Left
        Me.pct_cover.Location = New System.Drawing.Point(3, 3)
        Me.pct_cover.Name = "pct_cover"
        Me.pct_cover.Size = New System.Drawing.Size(104, 148)
        Me.pct_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_cover.TabIndex = 4
        Me.pct_cover.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbl_purchaseDate)
        Me.Panel4.Controls.Add(Me.lbl_parutionDate)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 63)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(381, 13)
        Me.Panel4.TabIndex = 13
        '
        'lbl_parutionDate
        '
        Me.lbl_parutionDate.AutoSize = True
        Me.lbl_parutionDate.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_parutionDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_parutionDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_parutionDate.Location = New System.Drawing.Point(0, 0)
        Me.lbl_parutionDate.Name = "lbl_parutionDate"
        Me.lbl_parutionDate.Size = New System.Drawing.Size(86, 13)
        Me.lbl_parutionDate.TabIndex = 8
        Me.lbl_parutionDate.Text = "Date de parution"
        Me.lbl_parutionDate.UseMnemonic = False
        '
        'lbl_purchaseDate
        '
        Me.lbl_purchaseDate.AutoSize = True
        Me.lbl_purchaseDate.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_purchaseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_purchaseDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_purchaseDate.Location = New System.Drawing.Point(86, 0)
        Me.lbl_purchaseDate.Name = "lbl_purchaseDate"
        Me.lbl_purchaseDate.Size = New System.Drawing.Size(68, 13)
        Me.lbl_purchaseDate.TabIndex = 9
        Me.lbl_purchaseDate.Text = "Date d'achat"
        Me.lbl_purchaseDate.UseMnemonic = False
        '
        'GridItem_Edition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pct_cover)
        Me.Name = "GridItem_Edition"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(585, 154)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pct_withAutograph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_firstEdition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_inPossession, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.pct_minBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_minFourthCover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_cover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_serieName As System.Windows.Forms.Label
    Friend WithEvents lbl_editionName As System.Windows.Forms.Label
    Friend WithEvents pct_cover As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_editor As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pct_minBoard As System.Windows.Forms.PictureBox
    Friend WithEvents pct_minFourthCover As System.Windows.Forms.PictureBox
    Friend WithEvents pct_inPossession As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_editionNumber As System.Windows.Forms.Label
    Friend WithEvents lbl_cycle As System.Windows.Forms.Label
    Friend WithEvents pct_firstEdition As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_comments As System.Windows.Forms.Label
    Friend WithEvents lbl_collection As System.Windows.Forms.Label
    Friend WithEvents pct_withAutograph As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_purchaseDate As Label
    Friend WithEvents lbl_parutionDate As Label
End Class

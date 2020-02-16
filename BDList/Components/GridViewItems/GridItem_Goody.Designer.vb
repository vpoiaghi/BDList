Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GridItem_Goody
    Inherits GridItem

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.lbl_serieName = New System.Windows.Forms.Label()
        Me.lbl_goodyName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_comments = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_collection = New System.Windows.Forms.Label()
        Me.lbl_scanned = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_editor = New System.Windows.Forms.Label()
        Me.lbl_purchaseDate = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_authors = New System.Windows.Forms.Label()
        Me.lbl_parutionDate = New System.Windows.Forms.Label()
        Me.Nb_Number = New FrameworkPN.Number()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pct_minFourthImage = New System.Windows.Forms.PictureBox()
        Me.pct_minThirdImage = New System.Windows.Forms.PictureBox()
        Me.pct_minSecondImage = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Lbl_Count = New System.Windows.Forms.Label()
        Me.pct_withAutograph = New System.Windows.Forms.PictureBox()
        Me.pct_inPossession = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pct_firstImage = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pct_minFourthImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_minThirdImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_minSecondImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.pct_withAutograph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_inPossession, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_firstImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_serieName
        '
        Me.lbl_serieName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_serieName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_serieName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_serieName.Location = New System.Drawing.Point(10, 0)
        Me.lbl_serieName.Name = "lbl_serieName"
        Me.lbl_serieName.Size = New System.Drawing.Size(563, 20)
        Me.lbl_serieName.TabIndex = 0
        Me.lbl_serieName.Text = "Série"
        Me.lbl_serieName.UseMnemonic = False
        '
        'lbl_goodyName
        '
        Me.lbl_goodyName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_goodyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_goodyName.Location = New System.Drawing.Point(10, 20)
        Me.lbl_goodyName.Name = "lbl_goodyName"
        Me.lbl_goodyName.Size = New System.Drawing.Size(563, 36)
        Me.lbl_goodyName.TabIndex = 2
        Me.lbl_goodyName.Text = "Nom du para-bd"
        Me.lbl_goodyName.UseMnemonic = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_comments)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.lbl_goodyName)
        Me.Panel2.Controls.Add(Me.lbl_serieName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(161, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(573, 347)
        Me.Panel2.TabIndex = 8
        '
        'lbl_comments
        '
        Me.lbl_comments.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_comments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_comments.Location = New System.Drawing.Point(10, 113)
        Me.lbl_comments.Name = "lbl_comments"
        Me.lbl_comments.Size = New System.Drawing.Size(563, 42)
        Me.lbl_comments.TabIndex = 8
        Me.lbl_comments.Text = "Commentaires"
        Me.lbl_comments.UseMnemonic = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_collection)
        Me.Panel1.Controls.Add(Me.lbl_scanned)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(563, 19)
        Me.Panel1.TabIndex = 12
        '
        'lbl_collection
        '
        Me.lbl_collection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_collection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_collection.Location = New System.Drawing.Point(0, 0)
        Me.lbl_collection.Name = "lbl_collection"
        Me.lbl_collection.Size = New System.Drawing.Size(498, 19)
        Me.lbl_collection.TabIndex = 12
        Me.lbl_collection.Text = "Collection"
        Me.lbl_collection.UseMnemonic = False
        '
        'lbl_scanned
        '
        Me.lbl_scanned.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_scanned.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_scanned.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbl_scanned.Location = New System.Drawing.Point(498, 0)
        Me.lbl_scanned.Name = "lbl_scanned"
        Me.lbl_scanned.Size = New System.Drawing.Size(65, 19)
        Me.lbl_scanned.TabIndex = 13
        Me.lbl_scanned.Text = "Scanné"
        Me.lbl_scanned.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lbl_editor)
        Me.Panel6.Controls.Add(Me.lbl_purchaseDate)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(10, 75)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(563, 19)
        Me.Panel6.TabIndex = 10
        '
        'lbl_editor
        '
        Me.lbl_editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_editor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editor.Location = New System.Drawing.Point(0, 0)
        Me.lbl_editor.Name = "lbl_editor"
        Me.lbl_editor.Size = New System.Drawing.Size(495, 19)
        Me.lbl_editor.TabIndex = 7
        Me.lbl_editor.Text = "Editeur"
        Me.lbl_editor.UseMnemonic = False
        '
        'lbl_purchaseDate
        '
        Me.lbl_purchaseDate.AutoSize = True
        Me.lbl_purchaseDate.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_purchaseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_purchaseDate.Location = New System.Drawing.Point(495, 0)
        Me.lbl_purchaseDate.Name = "lbl_purchaseDate"
        Me.lbl_purchaseDate.Size = New System.Drawing.Size(68, 13)
        Me.lbl_purchaseDate.TabIndex = 8
        Me.lbl_purchaseDate.Text = "Date d'achat"
        Me.lbl_purchaseDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_purchaseDate.UseMnemonic = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbl_authors)
        Me.Panel4.Controls.Add(Me.lbl_parutionDate)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(10, 56)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(563, 19)
        Me.Panel4.TabIndex = 13
        '
        'lbl_authors
        '
        Me.lbl_authors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_authors.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_authors.Location = New System.Drawing.Point(0, 0)
        Me.lbl_authors.Name = "lbl_authors"
        Me.lbl_authors.Size = New System.Drawing.Size(477, 19)
        Me.lbl_authors.TabIndex = 10
        Me.lbl_authors.Text = "Auteurs"
        Me.lbl_authors.UseMnemonic = False
        '
        'lbl_parutionDate
        '
        Me.lbl_parutionDate.AutoSize = True
        Me.lbl_parutionDate.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_parutionDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_parutionDate.Location = New System.Drawing.Point(477, 0)
        Me.lbl_parutionDate.Name = "lbl_parutionDate"
        Me.lbl_parutionDate.Size = New System.Drawing.Size(86, 13)
        Me.lbl_parutionDate.TabIndex = 11
        Me.lbl_parutionDate.Text = "Date de parution"
        Me.lbl_parutionDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_parutionDate.UseMnemonic = False
        '
        'Nb_Number
        '
        Me.Nb_Number.Dock = System.Windows.Forms.DockStyle.Top
        Me.Nb_Number.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Nb_Number.Location = New System.Drawing.Point(0, 80)
        Me.Nb_Number.MaxNumber = Nothing
        Me.Nb_Number.Name = "Nb_Number"
        Me.Nb_Number.Number = Nothing
        Me.Nb_Number.NumberType = Nothing
        Me.Nb_Number.Size = New System.Drawing.Size(40, 40)
        Me.Nb_Number.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.pct_minFourthImage)
        Me.Panel3.Controls.Add(Me.pct_minThirdImage)
        Me.Panel3.Controls.Add(Me.pct_minSecondImage)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(107, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Panel3.Size = New System.Drawing.Size(54, 347)
        Me.Panel3.TabIndex = 9
        '
        'pct_minFourthImage
        '
        Me.pct_minFourthImage.BackColor = System.Drawing.Color.Black
        Me.pct_minFourthImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_minFourthImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.pct_minFourthImage.Location = New System.Drawing.Point(5, 128)
        Me.pct_minFourthImage.Name = "pct_minFourthImage"
        Me.pct_minFourthImage.Size = New System.Drawing.Size(44, 64)
        Me.pct_minFourthImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_minFourthImage.TabIndex = 7
        Me.pct_minFourthImage.TabStop = False
        '
        'pct_minThirdImage
        '
        Me.pct_minThirdImage.BackColor = System.Drawing.Color.Black
        Me.pct_minThirdImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_minThirdImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.pct_minThirdImage.Location = New System.Drawing.Point(5, 64)
        Me.pct_minThirdImage.Name = "pct_minThirdImage"
        Me.pct_minThirdImage.Size = New System.Drawing.Size(44, 64)
        Me.pct_minThirdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_minThirdImage.TabIndex = 6
        Me.pct_minThirdImage.TabStop = False
        '
        'pct_minSecondImage
        '
        Me.pct_minSecondImage.BackColor = System.Drawing.Color.Black
        Me.pct_minSecondImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_minSecondImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.pct_minSecondImage.Location = New System.Drawing.Point(5, 0)
        Me.pct_minSecondImage.Name = "pct_minSecondImage"
        Me.pct_minSecondImage.Size = New System.Drawing.Size(44, 64)
        Me.pct_minSecondImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_minSecondImage.TabIndex = 5
        Me.pct_minSecondImage.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Lbl_Count)
        Me.Panel5.Controls.Add(Me.Nb_Number)
        Me.Panel5.Controls.Add(Me.pct_withAutograph)
        Me.Panel5.Controls.Add(Me.pct_inPossession)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(734, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(40, 347)
        Me.Panel5.TabIndex = 11
        '
        'Lbl_Count
        '
        Me.Lbl_Count.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_Count.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Count.ForeColor = System.Drawing.Color.SteelBlue
        Me.Lbl_Count.Location = New System.Drawing.Point(0, 120)
        Me.Lbl_Count.Name = "Lbl_Count"
        Me.Lbl_Count.Size = New System.Drawing.Size(40, 40)
        Me.Lbl_Count.TabIndex = 14
        Me.Lbl_Count.Text = "x 2"
        Me.Lbl_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lbl_Count.Visible = False
        '
        'pct_withAutograph
        '
        Me.pct_withAutograph.BackColor = System.Drawing.Color.Transparent
        Me.pct_withAutograph.Dock = System.Windows.Forms.DockStyle.Top
        Me.pct_withAutograph.Image = Global.BDList.My.Resources.Resources.btn_signature
        Me.pct_withAutograph.Location = New System.Drawing.Point(0, 40)
        Me.pct_withAutograph.Name = "pct_withAutograph"
        Me.pct_withAutograph.Size = New System.Drawing.Size(40, 40)
        Me.pct_withAutograph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pct_withAutograph.TabIndex = 9
        Me.pct_withAutograph.TabStop = False
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
        'pct_firstImage
        '
        Me.pct_firstImage.BackColor = System.Drawing.Color.Black
        Me.pct_firstImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_firstImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.pct_firstImage.Location = New System.Drawing.Point(3, 3)
        Me.pct_firstImage.Name = "pct_firstImage"
        Me.pct_firstImage.Size = New System.Drawing.Size(104, 347)
        Me.pct_firstImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_firstImage.TabIndex = 4
        Me.pct_firstImage.TabStop = False
        '
        'GridItem_Goody
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pct_firstImage)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "GridItem_Goody"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(777, 353)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.pct_minFourthImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_minThirdImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_minSecondImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.pct_withAutograph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_inPossession, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_firstImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_serieName As System.Windows.Forms.Label
    Friend WithEvents lbl_goodyName As System.Windows.Forms.Label
    Friend WithEvents pct_firstImage As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pct_minFourthImage As System.Windows.Forms.PictureBox
    Friend WithEvents pct_minThirdImage As System.Windows.Forms.PictureBox
    Friend WithEvents pct_minSecondImage As System.Windows.Forms.PictureBox
    Friend WithEvents pct_inPossession As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_comments As System.Windows.Forms.Label
    Friend WithEvents pct_withAutograph As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lbl_editor As System.Windows.Forms.Label
    Friend WithEvents lbl_purchaseDate As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_collection As Label
    Friend WithEvents lbl_scanned As Label
    Friend WithEvents Nb_Number As Number
    Friend WithEvents Lbl_Count As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_authors As Label
    Friend WithEvents lbl_parutionDate As Label
End Class

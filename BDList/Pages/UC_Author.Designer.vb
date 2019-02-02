Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Author
    Inherits UC_Page

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnl_authorHeader = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_goodies = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_editions = New System.Windows.Forms.Button()
        Me.btn_series = New System.Windows.Forms.Button()
        Me.btn_author = New System.Windows.Forms.Button()
        Me.grd_seriesList = New FrameworkPN.GridView()
        Me.grd_goodiesList = New FrameworkPN.GridView()
        Me.grd_editionsList = New FrameworkPN.GridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_realName = New System.Windows.Forms.Label()
        Me.pnl_authorPicture = New System.Windows.Forms.Panel()
        Me.pct_author = New System.Windows.Forms.PictureBox()
        Me.pnl_authorInfos = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnl_authorPicture.SuspendLayout()
        CType(Me.pct_author, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_authorHeader
        '
        Me.pnl_authorHeader.BackColor = System.Drawing.Color.Black
        Me.pnl_authorHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_authorHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnl_authorHeader.Name = "pnl_authorHeader"
        Me.pnl_authorHeader.Size = New System.Drawing.Size(1024, 150)
        Me.pnl_authorHeader.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btn_goodies)
        Me.Panel1.Controls.Add(Me.btn_edit)
        Me.Panel1.Controls.Add(Me.btn_editions)
        Me.Panel1.Controls.Add(Me.btn_series)
        Me.Panel1.Controls.Add(Me.btn_author)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(1024, 56)
        Me.Panel1.TabIndex = 6
        '
        'btn_goodies
        '
        Me.btn_goodies.BackColor = System.Drawing.SystemColors.Control
        Me.btn_goodies.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_goodies.Enabled = False
        Me.btn_goodies.Location = New System.Drawing.Point(228, 3)
        Me.btn_goodies.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.btn_goodies.Name = "btn_goodies"
        Me.btn_goodies.Size = New System.Drawing.Size(75, 50)
        Me.btn_goodies.TabIndex = 2
        Me.btn_goodies.Text = "Para-bds"
        Me.btn_goodies.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.Control
        Me.btn_edit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_edit.Image = Global.BDList.My.Resources.Resources.edit
        Me.btn_edit.Location = New System.Drawing.Point(971, 3)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(50, 50)
        Me.btn_edit.TabIndex = 4
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_editions
        '
        Me.btn_editions.BackColor = System.Drawing.SystemColors.Control
        Me.btn_editions.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_editions.Enabled = False
        Me.btn_editions.Location = New System.Drawing.Point(153, 3)
        Me.btn_editions.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.btn_editions.Name = "btn_editions"
        Me.btn_editions.Size = New System.Drawing.Size(75, 50)
        Me.btn_editions.TabIndex = 1
        Me.btn_editions.Text = "Editions"
        Me.btn_editions.UseVisualStyleBackColor = False
        '
        'btn_series
        '
        Me.btn_series.BackColor = System.Drawing.SystemColors.Control
        Me.btn_series.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_series.Enabled = False
        Me.btn_series.Location = New System.Drawing.Point(78, 3)
        Me.btn_series.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.btn_series.Name = "btn_series"
        Me.btn_series.Size = New System.Drawing.Size(75, 50)
        Me.btn_series.TabIndex = 0
        Me.btn_series.Text = "Séries"
        Me.btn_series.UseVisualStyleBackColor = False
        '
        'btn_author
        '
        Me.btn_author.BackColor = System.Drawing.SystemColors.Control
        Me.btn_author.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_author.Enabled = False
        Me.btn_author.Location = New System.Drawing.Point(3, 3)
        Me.btn_author.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.btn_author.Name = "btn_author"
        Me.btn_author.Size = New System.Drawing.Size(75, 50)
        Me.btn_author.TabIndex = 5
        Me.btn_author.Text = "L'auteur"
        Me.btn_author.UseVisualStyleBackColor = False
        '
        'grd_seriesList
        '
        Me.grd_seriesList.BackColor = System.Drawing.Color.White
        Me.grd_seriesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grd_seriesList.ColumnsCount = 1
        Me.grd_seriesList.ItemsMargin = 3
        Me.grd_seriesList.Location = New System.Drawing.Point(224, 227)
        Me.grd_seriesList.Name = "grd_seriesList"
        Me.grd_seriesList.RowsCount = 10
        Me.grd_seriesList.Size = New System.Drawing.Size(241, 115)
        Me.grd_seriesList.TabIndex = 3
        Me.grd_seriesList.Visible = False
        '
        'grd_goodiesList
        '
        Me.grd_goodiesList.BackColor = System.Drawing.Color.White
        Me.grd_goodiesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grd_goodiesList.ColumnsCount = 4
        Me.grd_goodiesList.ItemsMargin = 3
        Me.grd_goodiesList.Location = New System.Drawing.Point(718, 227)
        Me.grd_goodiesList.Name = "grd_goodiesList"
        Me.grd_goodiesList.RowsCount = 5
        Me.grd_goodiesList.Size = New System.Drawing.Size(241, 115)
        Me.grd_goodiesList.TabIndex = 1
        Me.grd_goodiesList.Visible = False
        '
        'grd_editionsList
        '
        Me.grd_editionsList.BackColor = System.Drawing.Color.White
        Me.grd_editionsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grd_editionsList.ColumnsCount = 4
        Me.grd_editionsList.ItemsMargin = 3
        Me.grd_editionsList.Location = New System.Drawing.Point(471, 227)
        Me.grd_editionsList.Name = "grd_editionsList"
        Me.grd_editionsList.RowsCount = 5
        Me.grd_editionsList.Size = New System.Drawing.Size(241, 115)
        Me.grd_editionsList.TabIndex = 0
        Me.grd_editionsList.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Bisque
        Me.Panel2.Controls.Add(Me.lbl_realName)
        Me.Panel2.Controls.Add(Me.pnl_authorPicture)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 206)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(195, 442)
        Me.Panel2.TabIndex = 2
        '
        'lbl_realName
        '
        Me.lbl_realName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_realName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_realName.Location = New System.Drawing.Point(0, 234)
        Me.lbl_realName.Name = "lbl_realName"
        Me.lbl_realName.Size = New System.Drawing.Size(195, 41)
        Me.lbl_realName.TabIndex = 12
        Me.lbl_realName.Text = "Vrai nom"
        '
        'pnl_authorPicture
        '
        Me.pnl_authorPicture.BackColor = System.Drawing.Color.Black
        Me.pnl_authorPicture.Controls.Add(Me.pct_author)
        Me.pnl_authorPicture.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_authorPicture.Location = New System.Drawing.Point(0, 0)
        Me.pnl_authorPicture.Name = "pnl_authorPicture"
        Me.pnl_authorPicture.Padding = New System.Windows.Forms.Padding(5)
        Me.pnl_authorPicture.Size = New System.Drawing.Size(195, 234)
        Me.pnl_authorPicture.TabIndex = 1
        '
        'pct_author
        '
        Me.pct_author.BackColor = System.Drawing.Color.White
        Me.pct_author.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pct_author.Location = New System.Drawing.Point(5, 5)
        Me.pct_author.Name = "pct_author"
        Me.pct_author.Size = New System.Drawing.Size(185, 224)
        Me.pct_author.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_author.TabIndex = 0
        Me.pct_author.TabStop = False
        '
        'pnl_authorInfos
        '
        Me.pnl_authorInfos.BackColor = System.Drawing.Color.Bisque
        Me.pnl_authorInfos.Location = New System.Drawing.Point(322, 410)
        Me.pnl_authorInfos.Name = "pnl_authorInfos"
        Me.pnl_authorInfos.Size = New System.Drawing.Size(176, 133)
        Me.pnl_authorInfos.TabIndex = 7
        '
        'UC_Author
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_authorInfos)
        Me.Controls.Add(Me.grd_goodiesList)
        Me.Controls.Add(Me.grd_seriesList)
        Me.Controls.Add(Me.grd_editionsList)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_authorHeader)
        Me.Name = "UC_Author"
        Me.ShowHeader = False
        Me.Size = New System.Drawing.Size(1024, 648)
        Me.Controls.SetChildIndex(Me.pnl_authorHeader, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.grd_editionsList, 0)
        Me.Controls.SetChildIndex(Me.grd_seriesList, 0)
        Me.Controls.SetChildIndex(Me.grd_goodiesList, 0)
        Me.Controls.SetChildIndex(Me.pnl_authorInfos, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnl_authorPicture.ResumeLayout(False)
        CType(Me.pct_author, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_authorHeader As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_edit As Button
    Friend WithEvents pct_author As PictureBox
    Friend WithEvents pnl_authorPicture As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grd_editionsList As GridView
    Friend WithEvents grd_goodiesList As GridView
    Friend WithEvents btn_goodies As Button
    Friend WithEvents btn_editions As Button
    Friend WithEvents btn_series As Button
    Friend WithEvents grd_seriesList As GridView
    Friend WithEvents lbl_realName As Label
    Friend WithEvents btn_author As Button
    Friend WithEvents pnl_authorInfos As Panel
End Class

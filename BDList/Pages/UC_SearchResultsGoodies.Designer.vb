Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_SearchResultsGoodies
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
        Me.btn_series = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_goodies = New System.Windows.Forms.Button()
        Me.btn_editions = New System.Windows.Forms.Button()
        Me.lst_goodiesList = New FrameworkPN.GridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_authors = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_series
        '
        Me.btn_series.BackColor = System.Drawing.SystemColors.Control
        Me.btn_series.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_series.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_series.Location = New System.Drawing.Point(10, 0)
        Me.btn_series.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.btn_series.Name = "btn_series"
        Me.btn_series.Size = New System.Drawing.Size(185, 38)
        Me.btn_series.TabIndex = 0
        Me.btn_series.Text = "Séries"
        Me.btn_series.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btn_authors)
        Me.Panel1.Controls.Add(Me.btn_goodies)
        Me.Panel1.Controls.Add(Me.btn_editions)
        Me.Panel1.Controls.Add(Me.btn_series)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.Panel1.Size = New System.Drawing.Size(205, 658)
        Me.Panel1.TabIndex = 1
        '
        'btn_goodies
        '
        Me.btn_goodies.BackColor = System.Drawing.SystemColors.Control
        Me.btn_goodies.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_goodies.Enabled = False
        Me.btn_goodies.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_goodies.Location = New System.Drawing.Point(10, 76)
        Me.btn_goodies.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_goodies.Name = "btn_goodies"
        Me.btn_goodies.Size = New System.Drawing.Size(185, 38)
        Me.btn_goodies.TabIndex = 2
        Me.btn_goodies.Text = "Para-bds"
        Me.btn_goodies.UseVisualStyleBackColor = False
        '
        'btn_editions
        '
        Me.btn_editions.BackColor = System.Drawing.SystemColors.Control
        Me.btn_editions.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_editions.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_editions.Location = New System.Drawing.Point(10, 38)
        Me.btn_editions.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.btn_editions.Name = "btn_editions"
        Me.btn_editions.Size = New System.Drawing.Size(185, 38)
        Me.btn_editions.TabIndex = 1
        Me.btn_editions.Text = "Editions"
        Me.btn_editions.UseVisualStyleBackColor = False
        '
        'lst_goodiesList
        '
        Me.lst_goodiesList.BackColor = System.Drawing.Color.White
        Me.lst_goodiesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_goodiesList.ColumnsCount = 4
        Me.lst_goodiesList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_goodiesList.ItemsMargin = 3
        Me.lst_goodiesList.Location = New System.Drawing.Point(205, 118)
        Me.lst_goodiesList.Name = "lst_goodiesList"
        Me.lst_goodiesList.RowsCount = 5
        Me.lst_goodiesList.Size = New System.Drawing.Size(1026, 658)
        Me.lst_goodiesList.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.btn_show)
        Me.Panel2.Controls.Add(Me.btn_edit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel2.Size = New System.Drawing.Size(1231, 56)
        Me.Panel2.TabIndex = 15
        '
        'btn_show
        '
        Me.btn_show.BackColor = System.Drawing.SystemColors.Control
        Me.btn_show.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_show.Image = Global.BDList.My.Resources.Resources.loupe
        Me.btn_show.Location = New System.Drawing.Point(1128, 3)
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
        Me.btn_edit.Location = New System.Drawing.Point(1178, 3)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(50, 50)
        Me.btn_edit.TabIndex = 4
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_authors
        '
        Me.btn_authors.BackColor = System.Drawing.SystemColors.Control
        Me.btn_authors.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_authors.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_authors.Location = New System.Drawing.Point(10, 114)
        Me.btn_authors.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.btn_authors.Name = "btn_authors"
        Me.btn_authors.Size = New System.Drawing.Size(185, 38)
        Me.btn_authors.TabIndex = 4
        Me.btn_authors.Text = "Auteurs"
        Me.btn_authors.UseVisualStyleBackColor = False
        '
        'UC_SearchResultsGoodies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lst_goodiesList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "UC_SearchResultsGoodies"
        Me.Size = New System.Drawing.Size(1231, 776)
        Me.Title = "Para-bd"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.lst_goodiesList, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_series As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_goodies As System.Windows.Forms.Button
    Friend WithEvents btn_editions As System.Windows.Forms.Button
    Friend WithEvents lst_goodiesList As FrameworkPN.GridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_show As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_authors As Button
End Class

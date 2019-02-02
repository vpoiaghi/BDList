Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits FrmPagesManager

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_addEdition = New System.Windows.Forms.Button()
        Me.btn_addSerie = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_synchronize = New System.Windows.Forms.Button()
        Me.btn_stats = New System.Windows.Forms.Button()
        Me.btn_events = New System.Windows.Forms.Button()
        Me.btn_editors = New System.Windows.Forms.Button()
        Me.btn_authors = New System.Windows.Forms.Button()
        Me.btn_coming = New System.Windows.Forms.Button()
        Me.btn_news = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Pnl_Main = New System.Windows.Forms.Panel()
        Me.Pnl_Menu = New System.Windows.Forms.Panel()
        Me.Menu_App = New FrameworkPN.Menu()
        Me.Pnl_Home = New System.Windows.Forms.Panel()
        Me.Pct_BtnPrevPage = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pct_BtnHome = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Pnl_Menu.SuspendLayout()
        Me.Pnl_Home.SuspendLayout()
        CType(Me.Pct_BtnPrevPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pct_BtnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btn_addEdition)
        Me.Panel1.Controls.Add(Me.btn_addSerie)
        Me.Panel1.Controls.Add(Me.btn_print)
        Me.Panel1.Controls.Add(Me.btn_synchronize)
        Me.Panel1.Controls.Add(Me.btn_stats)
        Me.Panel1.Controls.Add(Me.btn_events)
        Me.Panel1.Controls.Add(Me.btn_editors)
        Me.Panel1.Controls.Add(Me.btn_authors)
        Me.Panel1.Controls.Add(Me.btn_coming)
        Me.Panel1.Controls.Add(Me.btn_news)
        Me.Panel1.Controls.Add(Me.btn_search)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1168, 111)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Visible = False
        '
        'btn_addEdition
        '
        Me.btn_addEdition.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_addEdition.FlatAppearance.BorderSize = 0
        Me.btn_addEdition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addEdition.ForeColor = System.Drawing.Color.White
        Me.btn_addEdition.Image = Global.BDList.My.Resources.Resources.add_book
        Me.btn_addEdition.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_addEdition.Location = New System.Drawing.Point(1000, 0)
        Me.btn_addEdition.Name = "btn_addEdition"
        Me.btn_addEdition.Size = New System.Drawing.Size(100, 111)
        Me.btn_addEdition.TabIndex = 14
        Me.btn_addEdition.Text = "+ EDITION"
        Me.btn_addEdition.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_addEdition.UseVisualStyleBackColor = True
        '
        'btn_addSerie
        '
        Me.btn_addSerie.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_addSerie.FlatAppearance.BorderSize = 0
        Me.btn_addSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addSerie.ForeColor = System.Drawing.Color.White
        Me.btn_addSerie.Image = Global.BDList.My.Resources.Resources.add_serie
        Me.btn_addSerie.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_addSerie.Location = New System.Drawing.Point(900, 0)
        Me.btn_addSerie.Name = "btn_addSerie"
        Me.btn_addSerie.Size = New System.Drawing.Size(100, 111)
        Me.btn_addSerie.TabIndex = 13
        Me.btn_addSerie.Text = "+ SERIE"
        Me.btn_addSerie.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_addSerie.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_print.FlatAppearance.BorderSize = 0
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.ForeColor = System.Drawing.Color.White
        Me.btn_print.Image = Global.BDList.My.Resources.Resources.printer
        Me.btn_print.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_print.Location = New System.Drawing.Point(800, 0)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(100, 111)
        Me.btn_print.TabIndex = 9
        Me.btn_print.Text = "IMPRIMER"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_synchronize
        '
        Me.btn_synchronize.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_synchronize.FlatAppearance.BorderSize = 0
        Me.btn_synchronize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_synchronize.ForeColor = System.Drawing.Color.White
        Me.btn_synchronize.Image = Global.BDList.My.Resources.Resources.synchronize
        Me.btn_synchronize.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_synchronize.Location = New System.Drawing.Point(700, 0)
        Me.btn_synchronize.Name = "btn_synchronize"
        Me.btn_synchronize.Size = New System.Drawing.Size(100, 111)
        Me.btn_synchronize.TabIndex = 8
        Me.btn_synchronize.Text = "SYNCHRO."
        Me.btn_synchronize.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_synchronize.UseVisualStyleBackColor = True
        '
        'btn_stats
        '
        Me.btn_stats.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_stats.FlatAppearance.BorderSize = 0
        Me.btn_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stats.ForeColor = System.Drawing.Color.White
        Me.btn_stats.Image = Global.BDList.My.Resources.Resources.chart
        Me.btn_stats.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_stats.Location = New System.Drawing.Point(600, 0)
        Me.btn_stats.Name = "btn_stats"
        Me.btn_stats.Size = New System.Drawing.Size(100, 111)
        Me.btn_stats.TabIndex = 7
        Me.btn_stats.Text = "STATISTIQUES"
        Me.btn_stats.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_stats.UseVisualStyleBackColor = True
        '
        'btn_events
        '
        Me.btn_events.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_events.FlatAppearance.BorderSize = 0
        Me.btn_events.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_events.ForeColor = System.Drawing.Color.White
        Me.btn_events.Image = Global.BDList.My.Resources.Resources.events
        Me.btn_events.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_events.Location = New System.Drawing.Point(500, 0)
        Me.btn_events.Name = "btn_events"
        Me.btn_events.Size = New System.Drawing.Size(100, 111)
        Me.btn_events.TabIndex = 15
        Me.btn_events.Text = "EVENEMENTS"
        Me.btn_events.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_events.UseVisualStyleBackColor = True
        '
        'btn_editors
        '
        Me.btn_editors.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_editors.FlatAppearance.BorderSize = 0
        Me.btn_editors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editors.ForeColor = System.Drawing.Color.White
        Me.btn_editors.Image = Global.BDList.My.Resources.Resources.editor
        Me.btn_editors.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editors.Location = New System.Drawing.Point(400, 0)
        Me.btn_editors.Name = "btn_editors"
        Me.btn_editors.Size = New System.Drawing.Size(100, 111)
        Me.btn_editors.TabIndex = 10
        Me.btn_editors.Text = "EDITEURS"
        Me.btn_editors.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editors.UseVisualStyleBackColor = True
        '
        'btn_authors
        '
        Me.btn_authors.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_authors.FlatAppearance.BorderSize = 0
        Me.btn_authors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_authors.ForeColor = System.Drawing.Color.White
        Me.btn_authors.Image = Global.BDList.My.Resources.Resources.author
        Me.btn_authors.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_authors.Location = New System.Drawing.Point(300, 0)
        Me.btn_authors.Name = "btn_authors"
        Me.btn_authors.Size = New System.Drawing.Size(100, 111)
        Me.btn_authors.TabIndex = 5
        Me.btn_authors.Text = "AUTEURS"
        Me.btn_authors.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_authors.UseVisualStyleBackColor = True
        '
        'btn_coming
        '
        Me.btn_coming.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_coming.FlatAppearance.BorderSize = 0
        Me.btn_coming.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_coming.ForeColor = System.Drawing.Color.White
        Me.btn_coming.Image = Global.BDList.My.Resources.Resources.calendar
        Me.btn_coming.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_coming.Location = New System.Drawing.Point(200, 0)
        Me.btn_coming.Name = "btn_coming"
        Me.btn_coming.Size = New System.Drawing.Size(100, 111)
        Me.btn_coming.TabIndex = 6
        Me.btn_coming.Text = "A PARAÎTRE"
        Me.btn_coming.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_coming.UseVisualStyleBackColor = True
        '
        'btn_news
        '
        Me.btn_news.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_news.FlatAppearance.BorderSize = 0
        Me.btn_news.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_news.ForeColor = System.Drawing.Color.White
        Me.btn_news.Image = Global.BDList.My.Resources.Resources.news
        Me.btn_news.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_news.Location = New System.Drawing.Point(100, 0)
        Me.btn_news.Name = "btn_news"
        Me.btn_news.Size = New System.Drawing.Size(100, 111)
        Me.btn_news.TabIndex = 12
        Me.btn_news.Text = "NOUVEAUTÉS"
        Me.btn_news.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_news.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Image = Global.BDList.My.Resources.Resources.search
        Me.btn_search.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_search.Location = New System.Drawing.Point(0, 0)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(100, 111)
        Me.btn_search.TabIndex = 11
        Me.btn_search.Text = "RECHERCHER"
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Pnl_Main
        '
        Me.Pnl_Main.BackColor = System.Drawing.Color.White
        Me.Pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Main.Location = New System.Drawing.Point(223, 111)
        Me.Pnl_Main.Name = "Pnl_Main"
        Me.Pnl_Main.Size = New System.Drawing.Size(945, 378)
        Me.Pnl_Main.TabIndex = 1
        '
        'Pnl_Menu
        '
        Me.Pnl_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Pnl_Menu.Controls.Add(Me.Menu_App)
        Me.Pnl_Menu.Controls.Add(Me.Pnl_Home)
        Me.Pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pnl_Menu.Location = New System.Drawing.Point(0, 111)
        Me.Pnl_Menu.Name = "Pnl_Menu"
        Me.Pnl_Menu.Size = New System.Drawing.Size(223, 378)
        Me.Pnl_Menu.TabIndex = 2
        '
        'Menu_App
        '
        Me.Menu_App.AutoScroll = True
        Me.Menu_App.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Menu_App.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Menu_App.Location = New System.Drawing.Point(0, 54)
        Me.Menu_App.Name = "Menu_App"
        Me.Menu_App.Padding = New System.Windows.Forms.Padding(0, 25, 0, 0)
        Me.Menu_App.Size = New System.Drawing.Size(223, 324)
        Me.Menu_App.TabIndex = 2
        '
        'Pnl_Home
        '
        Me.Pnl_Home.Controls.Add(Me.Pct_BtnPrevPage)
        Me.Pnl_Home.Controls.Add(Me.PictureBox1)
        Me.Pnl_Home.Controls.Add(Me.Pct_BtnHome)
        Me.Pnl_Home.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Home.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Home.Name = "Pnl_Home"
        Me.Pnl_Home.Size = New System.Drawing.Size(223, 54)
        Me.Pnl_Home.TabIndex = 0
        '
        'Pct_BtnPrevPage
        '
        Me.Pct_BtnPrevPage.Image = Global.BDList.My.Resources.Resources.btn_prev_page
        Me.Pct_BtnPrevPage.Location = New System.Drawing.Point(147, 6)
        Me.Pct_BtnPrevPage.Name = "Pct_BtnPrevPage"
        Me.Pct_BtnPrevPage.Size = New System.Drawing.Size(32, 32)
        Me.Pct_BtnPrevPage.TabIndex = 3
        Me.Pct_BtnPrevPage.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BDList.My.Resources.Resources.app_logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 54)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Pct_BtnHome
        '
        Me.Pct_BtnHome.Image = Global.BDList.My.Resources.Resources.btn_home
        Me.Pct_BtnHome.Location = New System.Drawing.Point(185, 6)
        Me.Pct_BtnHome.Name = "Pct_BtnHome"
        Me.Pct_BtnHome.Size = New System.Drawing.Size(32, 32)
        Me.Pct_BtnHome.TabIndex = 0
        Me.Pct_BtnHome.TabStop = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 489)
        Me.Controls.Add(Me.Pnl_Main)
        Me.Controls.Add(Me.Pnl_Menu)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMain"
        Me.Text = "BDList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Pnl_Menu.ResumeLayout(False)
        Me.Pnl_Home.ResumeLayout(False)
        CType(Me.Pct_BtnPrevPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pct_BtnHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Pnl_Main As System.Windows.Forms.Panel
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents btn_synchronize As System.Windows.Forms.Button
    Friend WithEvents btn_stats As System.Windows.Forms.Button
    Friend WithEvents btn_authors As System.Windows.Forms.Button
    Friend WithEvents btn_coming As System.Windows.Forms.Button
    Friend WithEvents btn_news As System.Windows.Forms.Button
    Friend WithEvents btn_editors As System.Windows.Forms.Button
    Friend WithEvents btn_addEdition As System.Windows.Forms.Button
    Friend WithEvents btn_addSerie As System.Windows.Forms.Button
    Friend WithEvents btn_events As System.Windows.Forms.Button
    Friend WithEvents Pnl_Menu As System.Windows.Forms.Panel
    Friend WithEvents Pnl_Home As System.Windows.Forms.Panel
    Friend WithEvents Pct_BtnHome As System.Windows.Forms.PictureBox
    Friend WithEvents Menu_App As FrameworkPN.Menu
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Pct_BtnPrevPage As PictureBox
End Class

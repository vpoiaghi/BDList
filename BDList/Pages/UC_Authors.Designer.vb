Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Authors
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LVwAuthors = New System.Windows.Forms.ListView()
        Me.ColName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtFilter = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_addEvent = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PctGoody = New System.Windows.Forms.PictureBox()
        Me.LVwGoodies = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColSerie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PctGoody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LVwAuthors)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(467, 524)
        Me.Panel1.TabIndex = 12
        '
        'LVwAuthors
        '
        Me.LVwAuthors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColName})
        Me.LVwAuthors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LVwAuthors.FullRowSelect = True
        Me.LVwAuthors.GridLines = True
        Me.LVwAuthors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LVwAuthors.HideSelection = False
        Me.LVwAuthors.Location = New System.Drawing.Point(0, 42)
        Me.LVwAuthors.MultiSelect = False
        Me.LVwAuthors.Name = "LVwAuthors"
        Me.LVwAuthors.Size = New System.Drawing.Size(467, 482)
        Me.LVwAuthors.TabIndex = 1
        Me.LVwAuthors.UseCompatibleStateImageBehavior = False
        Me.LVwAuthors.View = System.Windows.Forms.View.Details
        '
        'ColName
        '
        Me.ColName.Text = "Nom"
        Me.ColName.Width = 200
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(467, 34)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.TxtFilter)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(32, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(2, 10, 2, 0)
        Me.Panel4.Size = New System.Drawing.Size(433, 32)
        Me.Panel4.TabIndex = 1
        '
        'TxtFilter
        '
        Me.TxtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtFilter.Location = New System.Drawing.Point(2, 10)
        Me.TxtFilter.Name = "TxtFilter"
        Me.TxtFilter.Size = New System.Drawing.Size(429, 13)
        Me.TxtFilter.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.BDList.My.Resources.Resources.search_2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_addEvent
        '
        Me.btn_addEvent.BackColor = System.Drawing.SystemColors.Control
        Me.btn_addEvent.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_addEvent.Image = Global.BDList.My.Resources.Resources.add
        Me.btn_addEvent.Location = New System.Drawing.Point(583, 6)
        Me.btn_addEvent.Name = "btn_addEvent"
        Me.btn_addEvent.Size = New System.Drawing.Size(50, 48)
        Me.btn_addEvent.TabIndex = 3
        Me.btn_addEvent.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PctGoody)
        Me.GroupBox1.Controls.Add(Me.LVwGoodies)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(467, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 148)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Para-bd "
        '
        'PctGoody
        '
        Me.PctGoody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PctGoody.Dock = System.Windows.Forms.DockStyle.Right
        Me.PctGoody.Location = New System.Drawing.Point(530, 16)
        Me.PctGoody.Name = "PctGoody"
        Me.PctGoody.Size = New System.Drawing.Size(100, 129)
        Me.PctGoody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PctGoody.TabIndex = 3
        Me.PctGoody.TabStop = False
        '
        'LVwGoodies
        '
        Me.LVwGoodies.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColSerie})
        Me.LVwGoodies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LVwGoodies.FullRowSelect = True
        Me.LVwGoodies.GridLines = True
        Me.LVwGoodies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVwGoodies.HideSelection = False
        Me.LVwGoodies.Location = New System.Drawing.Point(3, 16)
        Me.LVwGoodies.MultiSelect = False
        Me.LVwGoodies.Name = "LVwGoodies"
        Me.LVwGoodies.Size = New System.Drawing.Size(627, 129)
        Me.LVwGoodies.TabIndex = 2
        Me.LVwGoodies.UseCompatibleStateImageBehavior = False
        Me.LVwGoodies.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom"
        Me.ColumnHeader1.Width = 200
        '
        'ColSerie
        '
        Me.ColSerie.Text = "Serie"
        Me.ColSerie.Width = 194
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_addEvent)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(467, 62)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.Panel5.Size = New System.Drawing.Size(633, 60)
        Me.Panel5.TabIndex = 14
        '
        'UC_Authors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_Authors"
        Me.Size = New System.Drawing.Size(1100, 586)
        Me.Title = "Auteurs"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel5, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PctGoody, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_addEvent As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TxtFilter As System.Windows.Forms.TextBox
    Friend WithEvents LVwAuthors As System.Windows.Forms.ListView
    Friend WithEvents ColName As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LVwGoodies As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColSerie As System.Windows.Forms.ColumnHeader
    Friend WithEvents PctGoody As System.Windows.Forms.PictureBox

End Class

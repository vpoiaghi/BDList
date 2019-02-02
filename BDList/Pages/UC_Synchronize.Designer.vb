Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Synchronize
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lbl_messages = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_synchronize = New System.Windows.Forms.Button()
        Me.btn_synchronizeAll = New System.Windows.Forms.Button()
        Me.lbl_lastSync = New System.Windows.Forms.Label()
        Me.btn_control = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_syncToLocal = New System.Windows.Forms.Button()
        Me.btn_syncToPhone = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 154)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(411, 428)
        Me.ListBox1.TabIndex = 1
        '
        'lbl_messages
        '
        Me.lbl_messages.AutoSize = True
        Me.lbl_messages.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_messages.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lbl_messages.Location = New System.Drawing.Point(10, 41)
        Me.lbl_messages.Name = "lbl_messages"
        Me.lbl_messages.Size = New System.Drawing.Size(105, 18)
        Me.lbl_messages.TabIndex = 6
        Me.lbl_messages.Text = "lbl_messages"
        Me.lbl_messages.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_synchronize)
        Me.Panel1.Controls.Add(Me.btn_synchronizeAll)
        Me.Panel1.Controls.Add(Me.lbl_lastSync)
        Me.Panel1.Controls.Add(Me.lbl_messages)
        Me.Panel1.Controls.Add(Me.btn_control)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(1200, 62)
        Me.Panel1.TabIndex = 9
        '
        'btn_synchronize
        '
        Me.btn_synchronize.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_synchronize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_synchronize.FlatAppearance.BorderSize = 0
        Me.btn_synchronize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_synchronize.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_synchronize.ForeColor = System.Drawing.Color.White
        Me.btn_synchronize.Image = Global.BDList.My.Resources.Resources.menu_synchronize
        Me.btn_synchronize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_synchronize.Location = New System.Drawing.Point(665, 10)
        Me.btn_synchronize.Name = "btn_synchronize"
        Me.btn_synchronize.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_synchronize.Size = New System.Drawing.Size(175, 42)
        Me.btn_synchronize.TabIndex = 7
        Me.btn_synchronize.Text = " Synchroniser"
        Me.btn_synchronize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_synchronize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_synchronize.UseVisualStyleBackColor = False
        '
        'btn_synchronizeAll
        '
        Me.btn_synchronizeAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_synchronizeAll.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_synchronizeAll.FlatAppearance.BorderSize = 0
        Me.btn_synchronizeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_synchronizeAll.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_synchronizeAll.ForeColor = System.Drawing.Color.White
        Me.btn_synchronizeAll.Image = Global.BDList.My.Resources.Resources.menu_synchronize
        Me.btn_synchronizeAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_synchronizeAll.Location = New System.Drawing.Point(840, 10)
        Me.btn_synchronizeAll.Name = "btn_synchronizeAll"
        Me.btn_synchronizeAll.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_synchronizeAll.Size = New System.Drawing.Size(175, 42)
        Me.btn_synchronizeAll.TabIndex = 14
        Me.btn_synchronizeAll.Text = " Synchroniser tout"
        Me.btn_synchronizeAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_synchronizeAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_synchronizeAll.UseVisualStyleBackColor = False
        '
        'lbl_lastSync
        '
        Me.lbl_lastSync.AutoSize = True
        Me.lbl_lastSync.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_lastSync.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lastSync.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lbl_lastSync.Location = New System.Drawing.Point(10, 10)
        Me.lbl_lastSync.Name = "lbl_lastSync"
        Me.lbl_lastSync.Size = New System.Drawing.Size(134, 18)
        Me.lbl_lastSync.TabIndex = 11
        Me.lbl_lastSync.Text = "Dernière synchro :"
        Me.lbl_lastSync.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_control
        '
        Me.btn_control.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_control.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_control.FlatAppearance.BorderSize = 0
        Me.btn_control.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_control.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_control.ForeColor = System.Drawing.Color.White
        Me.btn_control.Image = Global.BDList.My.Resources.Resources.menu_control
        Me.btn_control.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_control.Location = New System.Drawing.Point(1015, 10)
        Me.btn_control.Name = "btn_control"
        Me.btn_control.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_control.Size = New System.Drawing.Size(175, 42)
        Me.btn_control.TabIndex = 13
        Me.btn_control.Text = " Contrôler"
        Me.btn_control.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_control.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_control.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 124)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Panel3.Size = New System.Drawing.Size(1200, 30)
        Me.Panel3.TabIndex = 12
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1180, 24)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(643, 287)
        Me.DataGridView1.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Identiques"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Différents"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Absents en local"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Absents sur le téléphone"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.ListBox2)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(411, 154)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 287)
        Me.Panel2.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_syncToLocal)
        Me.Panel4.Controls.Add(Me.btn_syncToPhone)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(712, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(77, 287)
        Me.Panel4.TabIndex = 15
        '
        'btn_syncToLocal
        '
        Me.btn_syncToLocal.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_syncToLocal.Location = New System.Drawing.Point(0, 67)
        Me.btn_syncToLocal.Name = "btn_syncToLocal"
        Me.btn_syncToLocal.Size = New System.Drawing.Size(77, 67)
        Me.btn_syncToLocal.TabIndex = 1
        Me.btn_syncToLocal.Text = "Synchroniser vers le local"
        Me.btn_syncToLocal.UseVisualStyleBackColor = True
        '
        'btn_syncToPhone
        '
        Me.btn_syncToPhone.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_syncToPhone.Location = New System.Drawing.Point(0, 0)
        Me.btn_syncToPhone.Name = "btn_syncToPhone"
        Me.btn_syncToPhone.Size = New System.Drawing.Size(77, 67)
        Me.btn_syncToPhone.TabIndex = 0
        Me.btn_syncToPhone.Text = "Synchroniser vers le téléphone"
        Me.btn_syncToPhone.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(643, 0)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(146, 287)
        Me.ListBox2.TabIndex = 14
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(411, 441)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(789, 141)
        Me.DataGridView2.TabIndex = 0
        '
        'Column6
        '
        Me.Column6.HeaderText = "Clé"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 250
        '
        'Column7
        '
        Me.Column7.HeaderText = "Valeur sur le téléphone"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 250
        '
        'Column8
        '
        Me.Column8.HeaderText = "Valeur en local"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 250
        '
        'UC_Synchronize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_Synchronize"
        Me.Size = New System.Drawing.Size(1200, 582)
        Me.Title = "Synchronisation"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.ListBox1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DataGridView2, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lbl_messages As System.Windows.Forms.Label
    Friend WithEvents btn_synchronize As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_lastSync As System.Windows.Forms.Label
    Friend WithEvents btn_control As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_syncToLocal As Button
    Friend WithEvents btn_syncToPhone As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btn_synchronizeAll As Button
End Class

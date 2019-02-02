Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_NewEditions
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
        Me.lst_newItemsList = New FrameworkPN.GridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lst_editors = New System.Windows.Forms.ListView()
        Me.col_editorName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_newItemsList
        '
        Me.lst_newItemsList.BackColor = System.Drawing.Color.White
        Me.lst_newItemsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_newItemsList.ColumnsCount = 3
        Me.lst_newItemsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_newItemsList.ItemsMargin = 3
        Me.lst_newItemsList.Location = New System.Drawing.Point(278, 118)
        Me.lst_newItemsList.Name = "lst_newItemsList"
        Me.lst_newItemsList.RowsCount = 4
        Me.lst_newItemsList.Size = New System.Drawing.Size(953, 658)
        Me.lst_newItemsList.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lst_editors)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 118)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Panel3.Size = New System.Drawing.Size(278, 658)
        Me.Panel3.TabIndex = 12
        '
        'lst_editors
        '
        Me.lst_editors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_editors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_editorName})
        Me.lst_editors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_editors.FullRowSelect = True
        Me.lst_editors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lst_editors.HideSelection = False
        Me.lst_editors.Location = New System.Drawing.Point(0, 0)
        Me.lst_editors.MultiSelect = False
        Me.lst_editors.Name = "lst_editors"
        Me.lst_editors.Size = New System.Drawing.Size(268, 658)
        Me.lst_editors.TabIndex = 1
        Me.lst_editors.UseCompatibleStateImageBehavior = False
        Me.lst_editors.View = System.Windows.Forms.View.Details
        '
        'col_editorName
        '
        Me.col_editorName.Width = 180
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btn_show)
        Me.Panel1.Controls.Add(Me.btn_edit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(1231, 56)
        Me.Panel1.TabIndex = 13
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
        'UC_NewEditions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.lst_newItemsList)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_NewEditions"
        Me.Size = New System.Drawing.Size(1231, 776)
        Me.Title = "Nouveautés"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.lst_newItemsList, 0)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lst_newItemsList As FrameworkPN.GridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lst_editors As System.Windows.Forms.ListView
    Friend WithEvents col_editorName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_show As Button
    Friend WithEvents btn_edit As Button
End Class

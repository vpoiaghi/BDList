Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Editors
    Inherits UC_Page

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
        Me.lst_editors = New FrameworkPN.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_editEditor = New System.Windows.Forms.Button()
        Me.btn_addEditor = New System.Windows.Forms.Button()
        Me.btn_removeEditor = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_editors
        '
        Me.lst_editors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lst_editors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_editors.FullRowSelect = True
        Me.lst_editors.GridLines = True
        Me.lst_editors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lst_editors.HideSelection = False
        Me.lst_editors.Location = New System.Drawing.Point(0, 124)
        Me.lst_editors.MultiSelect = False
        Me.lst_editors.Name = "lst_editors"
        Me.lst_editors.Size = New System.Drawing.Size(1100, 462)
        Me.lst_editors.TabIndex = 2
        Me.lst_editors.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom"
        Me.ColumnHeader1.Width = 200
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_editEditor)
        Me.Panel2.Controls.Add(Me.btn_addEditor)
        Me.Panel2.Controls.Add(Me.btn_removeEditor)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(1100, 62)
        Me.Panel2.TabIndex = 1
        '
        'btn_editEditor
        '
        Me.btn_editEditor.BackColor = System.Drawing.SystemColors.Control
        Me.btn_editEditor.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_editEditor.Image = Global.BDList.My.Resources.Resources.edit
        Me.btn_editEditor.Location = New System.Drawing.Point(940, 10)
        Me.btn_editEditor.Name = "btn_editEditor"
        Me.btn_editEditor.Size = New System.Drawing.Size(50, 42)
        Me.btn_editEditor.TabIndex = 3
        Me.btn_editEditor.UseVisualStyleBackColor = False
        '
        'btn_addEditor
        '
        Me.btn_addEditor.BackColor = System.Drawing.SystemColors.Control
        Me.btn_addEditor.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_addEditor.Image = Global.BDList.My.Resources.Resources.add
        Me.btn_addEditor.Location = New System.Drawing.Point(990, 10)
        Me.btn_addEditor.Name = "btn_addEditor"
        Me.btn_addEditor.Size = New System.Drawing.Size(50, 42)
        Me.btn_addEditor.TabIndex = 2
        Me.btn_addEditor.UseVisualStyleBackColor = False
        '
        'btn_removeEditor
        '
        Me.btn_removeEditor.BackColor = System.Drawing.SystemColors.Control
        Me.btn_removeEditor.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_removeEditor.Image = Global.BDList.My.Resources.Resources.remove
        Me.btn_removeEditor.Location = New System.Drawing.Point(1040, 10)
        Me.btn_removeEditor.Name = "btn_removeEditor"
        Me.btn_removeEditor.Size = New System.Drawing.Size(50, 42)
        Me.btn_removeEditor.TabIndex = 4
        Me.btn_removeEditor.UseVisualStyleBackColor = False
        '
        'UC_Editors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.lst_editors)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "UC_Editors"
        Me.Size = New System.Drawing.Size(1100, 586)
        Me.Title = "Editeurs"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.lst_editors, 0)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lst_editors As FrameworkPN.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_editEditor As System.Windows.Forms.Button
    Friend WithEvents btn_addEditor As System.Windows.Forms.Button
    Friend WithEvents btn_removeEditor As System.Windows.Forms.Button

End Class

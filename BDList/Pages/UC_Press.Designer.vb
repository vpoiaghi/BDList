Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Press
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
        Me.lst_itemsList = New FrameworkPN.GridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lst_series = New System.Windows.Forms.ListView()
        Me.col_editorName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_itemsList
        '
        Me.lst_itemsList.BackColor = System.Drawing.Color.White
        Me.lst_itemsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_itemsList.ColumnsCount = 3
        Me.lst_itemsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_itemsList.ItemsMargin = 3
        Me.lst_itemsList.Location = New System.Drawing.Point(278, 62)
        Me.lst_itemsList.Name = "lst_itemsList"
        Me.lst_itemsList.RowsCount = 4
        Me.lst_itemsList.Size = New System.Drawing.Size(953, 714)
        Me.lst_itemsList.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lst_series)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Panel1.Size = New System.Drawing.Size(278, 714)
        Me.Panel1.TabIndex = 1
        '
        'lst_series
        '
        Me.lst_series.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_series.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_editorName})
        Me.lst_series.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_series.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_series.FullRowSelect = True
        Me.lst_series.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lst_series.HideSelection = False
        Me.lst_series.Location = New System.Drawing.Point(0, 0)
        Me.lst_series.MultiSelect = False
        Me.lst_series.Name = "lst_series"
        Me.lst_series.Size = New System.Drawing.Size(268, 714)
        Me.lst_series.TabIndex = 0
        Me.lst_series.UseCompatibleStateImageBehavior = False
        Me.lst_series.View = System.Windows.Forms.View.Details
        '
        'col_editorName
        '
        Me.col_editorName.Width = 180
        '
        'UC_Press
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.lst_itemsList)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_Press"
        Me.Size = New System.Drawing.Size(1231, 776)
        Me.Title = "En presse"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.lst_itemsList, 0)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lst_itemsList As FrameworkPN.GridView
    Friend WithEvents lst_series As System.Windows.Forms.ListView
    Friend WithEvents col_editorName As System.Windows.Forms.ColumnHeader

End Class

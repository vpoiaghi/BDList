Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Home
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
        Me.GVw_RecentlyModifiedItems = New FrameworkPN.GridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVw_RecentlyModifiedItems
        '
        Me.GVw_RecentlyModifiedItems.BackColor = System.Drawing.Color.White
        Me.GVw_RecentlyModifiedItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GVw_RecentlyModifiedItems.ColumnsCount = 5
        Me.GVw_RecentlyModifiedItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GVw_RecentlyModifiedItems.ItemsMargin = 3
        Me.GVw_RecentlyModifiedItems.Location = New System.Drawing.Point(20, 44)
        Me.GVw_RecentlyModifiedItems.Name = "GVw_RecentlyModifiedItems"
        Me.GVw_RecentlyModifiedItems.RowsCount = 6
        Me.GVw_RecentlyModifiedItems.Size = New System.Drawing.Size(548, 650)
        Me.GVw_RecentlyModifiedItems.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GVw_RecentlyModifiedItems)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(643, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel1.Size = New System.Drawing.Size(588, 714)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(548, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dernières modifications"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UC_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_Home"
        Me.Size = New System.Drawing.Size(1231, 776)
        Me.Title = "Accueil"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GVw_RecentlyModifiedItems As GridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class

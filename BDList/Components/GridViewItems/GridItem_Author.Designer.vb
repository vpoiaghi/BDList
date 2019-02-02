Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GridItem_Author
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
        Me.lbl_authorName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pct_firstImage = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.pct_firstImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_authorName
        '
        Me.lbl_authorName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_authorName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_authorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_authorName.Location = New System.Drawing.Point(10, 0)
        Me.lbl_authorName.Name = "lbl_authorName"
        Me.lbl_authorName.Size = New System.Drawing.Size(614, 59)
        Me.lbl_authorName.TabIndex = 0
        Me.lbl_authorName.Text = "Auteur"
        Me.lbl_authorName.UseMnemonic = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_id)
        Me.Panel2.Controls.Add(Me.lbl_authorName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(150, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(624, 347)
        Me.Panel2.TabIndex = 8
        '
        'lbl_id
        '
        Me.lbl_id.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(10, 59)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(614, 19)
        Me.lbl_id.TabIndex = 10
        Me.lbl_id.Text = "Id"
        Me.lbl_id.UseMnemonic = False
        '
        'pct_firstImage
        '
        Me.pct_firstImage.BackColor = System.Drawing.Color.Black
        Me.pct_firstImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_firstImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.pct_firstImage.Location = New System.Drawing.Point(3, 3)
        Me.pct_firstImage.Name = "pct_firstImage"
        Me.pct_firstImage.Size = New System.Drawing.Size(147, 347)
        Me.pct_firstImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_firstImage.TabIndex = 4
        Me.pct_firstImage.TabStop = False
        '
        'GridItem_Author
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pct_firstImage)
        Me.Name = "GridItem_Author"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(777, 353)
        Me.Panel2.ResumeLayout(False)
        CType(Me.pct_firstImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_authorName As System.Windows.Forms.Label
    Friend WithEvents pct_firstImage As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_id As Label
End Class

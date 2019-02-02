<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuItem
    Inherits System.Windows.Forms.UserControl

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
        Me.Pct_Icon = New System.Windows.Forms.PictureBox()
        Me.Lbl_Text = New System.Windows.Forms.Label()
        Me.Lbl_DropDown = New System.Windows.Forms.Label()
        CType(Me.Pct_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pct_Icon
        '
        Me.Pct_Icon.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pct_Icon.Location = New System.Drawing.Point(20, 0)
        Me.Pct_Icon.Name = "Pct_Icon"
        Me.Pct_Icon.Size = New System.Drawing.Size(16, 35)
        Me.Pct_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Pct_Icon.TabIndex = 4
        Me.Pct_Icon.TabStop = False
        '
        'Lbl_Text
        '
        Me.Lbl_Text.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_Text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl_Text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Text.ForeColor = System.Drawing.Color.White
        Me.Lbl_Text.Location = New System.Drawing.Point(36, 0)
        Me.Lbl_Text.Name = "Lbl_Text"
        Me.Lbl_Text.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Lbl_Text.Size = New System.Drawing.Size(214, 35)
        Me.Lbl_Text.TabIndex = 5
        Me.Lbl_Text.Text = "MenuItem1"
        Me.Lbl_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_DropDown
        '
        Me.Lbl_DropDown.Dock = System.Windows.Forms.DockStyle.Right
        Me.Lbl_DropDown.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DropDown.ForeColor = System.Drawing.Color.White
        Me.Lbl_DropDown.Location = New System.Drawing.Point(250, 0)
        Me.Lbl_DropDown.Name = "Lbl_DropDown"
        Me.Lbl_DropDown.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Lbl_DropDown.Size = New System.Drawing.Size(26, 35)
        Me.Lbl_DropDown.TabIndex = 6
        Me.Lbl_DropDown.Text = "<"
        Me.Lbl_DropDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Controls.Add(Me.Lbl_Text)
        Me.Controls.Add(Me.Lbl_DropDown)
        Me.Controls.Add(Me.Pct_Icon)
        Me.Name = "MenuItem"
        Me.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.Size = New System.Drawing.Size(296, 35)
        CType(Me.Pct_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pct_Icon As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_Text As System.Windows.Forms.Label
    Friend WithEvents Lbl_DropDown As System.Windows.Forms.Label

End Class

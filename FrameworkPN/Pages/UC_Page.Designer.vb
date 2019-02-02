<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Page
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
        Me.PnlUCHeader1 = New FrameworkPN.PnlUCHeader()
        Me.SuspendLayout()
        '
        'PnlUCHeader1
        '
        Me.PnlUCHeader1.BackColor = System.Drawing.Color.Black
        Me.PnlUCHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlUCHeader1.Location = New System.Drawing.Point(0, 0)
        Me.PnlUCHeader1.Name = "PnlUCHeader1"
        Me.PnlUCHeader1.Padding = New System.Windows.Forms.Padding(10)
        Me.PnlUCHeader1.Size = New System.Drawing.Size(574, 62)
        Me.PnlUCHeader1.TabIndex = 0
        Me.PnlUCHeader1.Title = ""
        '
        'UC_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PnlUCHeader1)
        Me.Name = "UC_Page"
        Me.Size = New System.Drawing.Size(574, 284)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlUCHeader1 As FrameworkPN.PnlUCHeader

End Class

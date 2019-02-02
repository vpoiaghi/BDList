Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Statistics
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
        Me.Lbl_SeriesStartedCount = New System.Windows.Forms.Label()
        Me.Lbl_SeriesFullCount = New System.Windows.Forms.Label()
        Me.Lbl_SeriesNotFullCount = New System.Windows.Forms.Label()
        Me.Lbl_EditionsInCount = New System.Windows.Forms.Label()
        Me.Lbl_TitlesInCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_SeriesStartedCount
        '
        Me.Lbl_SeriesStartedCount.AutoSize = True
        Me.Lbl_SeriesStartedCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SeriesStartedCount.Location = New System.Drawing.Point(26, 84)
        Me.Lbl_SeriesStartedCount.Name = "Lbl_SeriesStartedCount"
        Me.Lbl_SeriesStartedCount.Size = New System.Drawing.Size(160, 16)
        Me.Lbl_SeriesStartedCount.TabIndex = 1
        Me.Lbl_SeriesStartedCount.Text = "Nb séries commencées : "
        '
        'Lbl_SeriesFullCount
        '
        Me.Lbl_SeriesFullCount.AutoSize = True
        Me.Lbl_SeriesFullCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SeriesFullCount.Location = New System.Drawing.Point(26, 110)
        Me.Lbl_SeriesFullCount.Name = "Lbl_SeriesFullCount"
        Me.Lbl_SeriesFullCount.Size = New System.Drawing.Size(141, 16)
        Me.Lbl_SeriesFullCount.TabIndex = 2
        Me.Lbl_SeriesFullCount.Text = "Nb séries complètes : "
        '
        'Lbl_SeriesNotFullCount
        '
        Me.Lbl_SeriesNotFullCount.AutoSize = True
        Me.Lbl_SeriesNotFullCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SeriesNotFullCount.Location = New System.Drawing.Point(26, 135)
        Me.Lbl_SeriesNotFullCount.Name = "Lbl_SeriesNotFullCount"
        Me.Lbl_SeriesNotFullCount.Size = New System.Drawing.Size(268, 16)
        Me.Lbl_SeriesNotFullCount.TabIndex = 3
        Me.Lbl_SeriesNotFullCount.Text = "Nb séries commencées mais incomplètes : "
        '
        'Lbl_EditionsInCount
        '
        Me.Lbl_EditionsInCount.AutoSize = True
        Me.Lbl_EditionsInCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EditionsInCount.Location = New System.Drawing.Point(26, 192)
        Me.Lbl_EditionsInCount.Name = "Lbl_EditionsInCount"
        Me.Lbl_EditionsInCount.Size = New System.Drawing.Size(187, 16)
        Me.Lbl_EditionsInCount.TabIndex = 4
        Me.Lbl_EditionsInCount.Text = "Nb d'éditions en possession : "
        '
        'Lbl_TitlesInCount
        '
        Me.Lbl_TitlesInCount.AutoSize = True
        Me.Lbl_TitlesInCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TitlesInCount.Location = New System.Drawing.Point(26, 252)
        Me.Lbl_TitlesInCount.Name = "Lbl_TitlesInCount"
        Me.Lbl_TitlesInCount.Size = New System.Drawing.Size(176, 16)
        Me.Lbl_TitlesInCount.TabIndex = 5
        Me.Lbl_TitlesInCount.Text = "Nb de titres en possession : "
        '
        'UC_Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.Controls.Add(Me.Lbl_TitlesInCount)
        Me.Controls.Add(Me.Lbl_EditionsInCount)
        Me.Controls.Add(Me.Lbl_SeriesNotFullCount)
        Me.Controls.Add(Me.Lbl_SeriesFullCount)
        Me.Controls.Add(Me.Lbl_SeriesStartedCount)
        Me.Name = "UC_Statistics"
        Me.Size = New System.Drawing.Size(1231, 776)
        Me.Title = "Statistiques"
        Me.Controls.SetChildIndex(Me.Lbl_SeriesStartedCount, 0)
        Me.Controls.SetChildIndex(Me.Lbl_SeriesFullCount, 0)
        Me.Controls.SetChildIndex(Me.Lbl_SeriesNotFullCount, 0)
        Me.Controls.SetChildIndex(Me.Lbl_EditionsInCount, 0)
        Me.Controls.SetChildIndex(Me.Lbl_TitlesInCount, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_SeriesStartedCount As Label
    Friend WithEvents Lbl_SeriesFullCount As Label
    Friend WithEvents Lbl_SeriesNotFullCount As Label
    Friend WithEvents Lbl_EditionsInCount As Label
    Friend WithEvents Lbl_TitlesInCount As Label
End Class

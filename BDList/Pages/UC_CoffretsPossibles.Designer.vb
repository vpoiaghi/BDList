Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_CoffretsPossibles
    Inherits UC_Page

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lst_seriesList = New FrameworkPN.GridView()
        Me.SuspendLayout()
        '
        'lst_seriesList
        '
        Me.lst_seriesList.BackColor = System.Drawing.Color.White
        Me.lst_seriesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_seriesList.ColumnsCount = 1
        Me.lst_seriesList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_seriesList.ItemsMargin = 3
        Me.lst_seriesList.Location = New System.Drawing.Point(0, 62)
        Me.lst_seriesList.Name = "lst_seriesList"
        Me.lst_seriesList.RowsCount = 11
        Me.lst_seriesList.Size = New System.Drawing.Size(574, 222)
        Me.lst_seriesList.TabIndex = 3
        '
        'UC_CoffretsPossibles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lst_seriesList)
        Me.Name = "UC_CoffretsPossibles"
        Me.Title = "Coffrets possibles"
        Me.Controls.SetChildIndex(Me.lst_seriesList, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lst_seriesList As GridView
End Class

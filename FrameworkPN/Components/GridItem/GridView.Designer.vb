<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridView
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
        Me.pnl_buttons = New System.Windows.Forms.Panel()
        Me.lbl_pageIndex = New System.Windows.Forms.Label()
        Me.pnl_main = New System.Windows.Forms.Panel()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.btn_first = New System.Windows.Forms.Button()
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_last = New System.Windows.Forms.Button()
        Me.pnl_buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_buttons
        '
        Me.pnl_buttons.Controls.Add(Me.btn_filter)
        Me.pnl_buttons.Controls.Add(Me.btn_first)
        Me.pnl_buttons.Controls.Add(Me.btn_prev)
        Me.pnl_buttons.Controls.Add(Me.lbl_pageIndex)
        Me.pnl_buttons.Controls.Add(Me.btn_next)
        Me.pnl_buttons.Controls.Add(Me.btn_last)
        Me.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_buttons.Location = New System.Drawing.Point(0, 0)
        Me.pnl_buttons.Name = "pnl_buttons"
        Me.pnl_buttons.Size = New System.Drawing.Size(508, 36)
        Me.pnl_buttons.TabIndex = 0
        '
        'lbl_pageIndex
        '
        Me.lbl_pageIndex.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_pageIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pageIndex.Location = New System.Drawing.Point(0, 0)
        Me.lbl_pageIndex.Name = "lbl_pageIndex"
        Me.lbl_pageIndex.Size = New System.Drawing.Size(246, 36)
        Me.lbl_pageIndex.TabIndex = 2
        Me.lbl_pageIndex.Text = "1 / 2"
        Me.lbl_pageIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl_main
        '
        Me.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_main.Location = New System.Drawing.Point(0, 36)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.Size = New System.Drawing.Size(508, 346)
        Me.pnl_main.TabIndex = 1
        '
        'btn_filter
        '
        Me.btn_filter.BackColor = System.Drawing.Color.Transparent
        Me.btn_filter.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filter.Image = Global.FrameworkPN.My.Resources.Resources.filter
        Me.btn_filter.Location = New System.Drawing.Point(258, 0)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(50, 36)
        Me.btn_filter.TabIndex = 5
        Me.btn_filter.TabStop = False
        Me.btn_filter.UseVisualStyleBackColor = False
        '
        'btn_first
        '
        Me.btn_first.BackColor = System.Drawing.Color.Transparent
        Me.btn_first.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_first.Image = Global.FrameworkPN.My.Resources.Resources.first
        Me.btn_first.Location = New System.Drawing.Point(308, 0)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(50, 36)
        Me.btn_first.TabIndex = 3
        Me.btn_first.TabStop = False
        Me.btn_first.UseVisualStyleBackColor = False
        '
        'btn_prev
        '
        Me.btn_prev.BackColor = System.Drawing.Color.Transparent
        Me.btn_prev.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prev.Image = Global.FrameworkPN.My.Resources.Resources.go_prev
        Me.btn_prev.Location = New System.Drawing.Point(358, 0)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(50, 36)
        Me.btn_prev.TabIndex = 1
        Me.btn_prev.TabStop = False
        Me.btn_prev.UseVisualStyleBackColor = False
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.Color.Transparent
        Me.btn_next.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Image = Global.FrameworkPN.My.Resources.Resources.go_next
        Me.btn_next.Location = New System.Drawing.Point(408, 0)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(50, 36)
        Me.btn_next.TabIndex = 0
        Me.btn_next.TabStop = False
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'btn_last
        '
        Me.btn_last.BackColor = System.Drawing.Color.Transparent
        Me.btn_last.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_last.Image = Global.FrameworkPN.My.Resources.Resources.last
        Me.btn_last.Location = New System.Drawing.Point(458, 0)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(50, 36)
        Me.btn_last.TabIndex = 4
        Me.btn_last.TabStop = False
        Me.btn_last.UseVisualStyleBackColor = False
        '
        'GridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.pnl_main)
        Me.Controls.Add(Me.pnl_buttons)
        Me.Name = "GridView"
        Me.Size = New System.Drawing.Size(508, 382)
        Me.pnl_buttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_buttons As System.Windows.Forms.Panel
    Friend WithEvents pnl_main As System.Windows.Forms.Panel
    Friend WithEvents btn_prev As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents lbl_pageIndex As System.Windows.Forms.Label
    Friend WithEvents btn_last As System.Windows.Forms.Button
    Friend WithEvents btn_first As System.Windows.Forms.Button
    Friend WithEvents btn_filter As Button
End Class


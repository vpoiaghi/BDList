<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPossessionState
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.flp_buttonsGrid = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flp_buttonsGrid
        '
        Me.flp_buttonsGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flp_buttonsGrid.Location = New System.Drawing.Point(0, 0)
        Me.flp_buttonsGrid.Name = "flp_buttonsGrid"
        Me.flp_buttonsGrid.Size = New System.Drawing.Size(354, 201)
        Me.flp_buttonsGrid.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_ok)
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(6)
        Me.Panel1.Size = New System.Drawing.Size(354, 43)
        Me.Panel1.TabIndex = 1
        '
        'btn_ok
        '
        Me.btn_ok.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_ok.Location = New System.Drawing.Point(174, 6)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(87, 31)
        Me.btn_ok.TabIndex = 1
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_cancel.Location = New System.Drawing.Point(261, 6)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(87, 31)
        Me.btn_cancel.TabIndex = 0
        Me.btn_cancel.Text = "Annuler"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'FrmPossessionState
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 244)
        Me.Controls.Add(Me.flp_buttonsGrid)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPossessionState"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Etat de la possession..."
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flp_buttonsGrid As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_cancel As Button
End Class

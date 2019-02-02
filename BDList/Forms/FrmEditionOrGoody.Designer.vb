<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditionOrGoody
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
        Me.Btn_NewEdition = New System.Windows.Forms.Button()
        Me.Btn_NewGoody = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Goody = New System.Windows.Forms.Button()
        Me.Btn_Edition = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_NewEdition
        '
        Me.Btn_NewEdition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_NewEdition.Location = New System.Drawing.Point(3, 3)
        Me.Btn_NewEdition.Name = "Btn_NewEdition"
        Me.Btn_NewEdition.Size = New System.Drawing.Size(162, 87)
        Me.Btn_NewEdition.TabIndex = 0
        Me.Btn_NewEdition.Text = "Nouvelle édition"
        Me.Btn_NewEdition.UseVisualStyleBackColor = True
        '
        'Btn_NewGoody
        '
        Me.Btn_NewGoody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_NewGoody.Location = New System.Drawing.Point(171, 3)
        Me.Btn_NewGoody.Name = "Btn_NewGoody"
        Me.Btn_NewGoody.Size = New System.Drawing.Size(163, 87)
        Me.Btn_NewGoody.TabIndex = 1
        Me.Btn_NewGoody.Text = "Nouveau para-BD"
        Me.Btn_NewGoody.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Goody, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Edition, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_NewEdition, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_NewGoody, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(337, 187)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Btn_Goody
        '
        Me.Btn_Goody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Goody.Location = New System.Drawing.Point(171, 96)
        Me.Btn_Goody.Name = "Btn_Goody"
        Me.Btn_Goody.Size = New System.Drawing.Size(163, 88)
        Me.Btn_Goody.TabIndex = 3
        Me.Btn_Goody.Text = "Para-BD existant"
        Me.Btn_Goody.UseVisualStyleBackColor = True
        '
        'Btn_Edition
        '
        Me.Btn_Edition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Edition.Location = New System.Drawing.Point(3, 96)
        Me.Btn_Edition.Name = "Btn_Edition"
        Me.Btn_Edition.Size = New System.Drawing.Size(162, 88)
        Me.Btn_Edition.TabIndex = 2
        Me.Btn_Edition.Text = "Edition existante"
        Me.Btn_Edition.UseVisualStyleBackColor = True
        '
        'FrmEditionOrGoody
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 187)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEditionOrGoody"
        Me.Text = "Edition ou Para-BD ?"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_NewEdition As Button
    Friend WithEvents Btn_NewGoody As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Btn_Goody As Button
    Friend WithEvents Btn_Edition As Button
End Class

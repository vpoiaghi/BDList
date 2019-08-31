<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectItems
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
        Me.pnlList1 = New System.Windows.Forms.Panel()
        Me.Lst_InitList = New System.Windows.Forms.ListBox()
        Me.Txt_Filter = New System.Windows.Forms.TextBox()
        Me.Lst_SelectionList = New System.Windows.Forms.ListBox()
        Me.Pnl_Buttons = New System.Windows.Forms.Panel()
        Me.Btn_OK = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_Remove = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.pnlList1.SuspendLayout()
        Me.Pnl_Buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlList1
        '
        Me.pnlList1.Controls.Add(Me.Lst_InitList)
        Me.pnlList1.Controls.Add(Me.Txt_Filter)
        Me.pnlList1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlList1.Location = New System.Drawing.Point(0, 0)
        Me.pnlList1.Name = "pnlList1"
        Me.pnlList1.Size = New System.Drawing.Size(225, 262)
        Me.pnlList1.TabIndex = 0
        '
        'Lst_InitList
        '
        Me.Lst_InitList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lst_InitList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lst_InitList.FormattingEnabled = True
        Me.Lst_InitList.IntegralHeight = False
        Me.Lst_InitList.Location = New System.Drawing.Point(0, 20)
        Me.Lst_InitList.Name = "Lst_InitList"
        Me.Lst_InitList.Size = New System.Drawing.Size(225, 242)
        Me.Lst_InitList.TabIndex = 0
        '
        'Txt_Filter
        '
        Me.Txt_Filter.Dock = System.Windows.Forms.DockStyle.Top
        Me.Txt_Filter.Location = New System.Drawing.Point(0, 0)
        Me.Txt_Filter.Name = "Txt_Filter"
        Me.Txt_Filter.Size = New System.Drawing.Size(225, 20)
        Me.Txt_Filter.TabIndex = 1
        '
        'Lst_SelectionList
        '
        Me.Lst_SelectionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lst_SelectionList.Dock = System.Windows.Forms.DockStyle.Right
        Me.Lst_SelectionList.FormattingEnabled = True
        Me.Lst_SelectionList.IntegralHeight = False
        Me.Lst_SelectionList.Location = New System.Drawing.Point(309, 0)
        Me.Lst_SelectionList.Name = "Lst_SelectionList"
        Me.Lst_SelectionList.Size = New System.Drawing.Size(225, 262)
        Me.Lst_SelectionList.TabIndex = 1
        '
        'Pnl_Buttons
        '
        Me.Pnl_Buttons.Controls.Add(Me.Btn_OK)
        Me.Pnl_Buttons.Controls.Add(Me.Btn_Cancel)
        Me.Pnl_Buttons.Controls.Add(Me.Btn_Remove)
        Me.Pnl_Buttons.Controls.Add(Me.Btn_Add)
        Me.Pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Buttons.Location = New System.Drawing.Point(225, 0)
        Me.Pnl_Buttons.Name = "Pnl_Buttons"
        Me.Pnl_Buttons.Size = New System.Drawing.Size(84, 262)
        Me.Pnl_Buttons.TabIndex = 2
        '
        'Btn_OK
        '
        Me.Btn_OK.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_OK.Location = New System.Drawing.Point(0, 162)
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Size = New System.Drawing.Size(84, 50)
        Me.Btn_OK.TabIndex = 2
        Me.Btn_OK.Text = "OK"
        Me.Btn_OK.UseVisualStyleBackColor = True
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.Location = New System.Drawing.Point(0, 212)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(84, 50)
        Me.Btn_Cancel.TabIndex = 3
        Me.Btn_Cancel.Text = "Annuler"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'Btn_Remove
        '
        Me.Btn_Remove.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Remove.Location = New System.Drawing.Point(0, 50)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Size = New System.Drawing.Size(84, 50)
        Me.Btn_Remove.TabIndex = 1
        Me.Btn_Remove.Text = "<< Retirer"
        Me.Btn_Remove.UseVisualStyleBackColor = True
        '
        'Btn_Add
        '
        Me.Btn_Add.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Add.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(84, 50)
        Me.Btn_Add.TabIndex = 0
        Me.Btn_Add.Text = "Ajouter >>"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'frmSelectItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 262)
        Me.Controls.Add(Me.Pnl_Buttons)
        Me.Controls.Add(Me.Lst_SelectionList)
        Me.Controls.Add(Me.pnlList1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Selection..."
        Me.pnlList1.ResumeLayout(False)
        Me.pnlList1.PerformLayout()
        Me.Pnl_Buttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlList1 As Panel
    Friend WithEvents Lst_InitList As ListBox
    Friend WithEvents Txt_Filter As TextBox
    Friend WithEvents Lst_SelectionList As ListBox
    Friend WithEvents Pnl_Buttons As Panel
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Remove As Button
    Friend WithEvents Btn_OK As Button
    Friend WithEvents Btn_Cancel As Button
End Class

﻿Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Festivals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Festivals))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lst_festivals = New System.Windows.Forms.ListBox()
        Me.Lbl_festivalDates = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LVw_InSigning = New System.Windows.Forms.ListView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Btn_AddInSigning = New System.Windows.Forms.Button()
        Me.Btn_editFestival = New System.Windows.Forms.Button()
        Me.Btn_addFestival = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Btn_editFestival)
        Me.Panel1.Controls.Add(Me.Btn_addFestival)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.Panel1.Size = New System.Drawing.Size(1230, 56)
        Me.Panel1.TabIndex = 6
        '
        'Lst_festivals
        '
        Me.Lst_festivals.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Lst_festivals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lst_festivals.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lst_festivals.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_festivals.FormattingEnabled = True
        Me.Lst_festivals.ItemHeight = 18
        Me.Lst_festivals.Location = New System.Drawing.Point(0, 118)
        Me.Lst_festivals.Name = "Lst_festivals"
        Me.Lst_festivals.Size = New System.Drawing.Size(267, 541)
        Me.Lst_festivals.TabIndex = 7
        '
        'Lbl_festivalDates
        '
        Me.Lbl_festivalDates.AutoSize = True
        Me.Lbl_festivalDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_festivalDates.Location = New System.Drawing.Point(6, 14)
        Me.Lbl_festivalDates.Name = "Lbl_festivalDates"
        Me.Lbl_festivalDates.Size = New System.Drawing.Size(67, 16)
        Me.Lbl_festivalDates.TabIndex = 8
        Me.Lbl_festivalDates.Text = "Du ... au ..."
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lbl_festivalDates)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(267, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(963, 100)
        Me.Panel2.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(267, 218)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(963, 441)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LVw_InSigning)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(955, 415)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Auteurs en dédicace"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(955, 415)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pense-bête"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LVw_InSigning
        '
        Me.LVw_InSigning.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.LVw_InSigning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LVw_InSigning.FullRowSelect = True
        Me.LVw_InSigning.GridLines = True
        Me.LVw_InSigning.HideSelection = False
        Me.LVw_InSigning.Location = New System.Drawing.Point(3, 33)
        Me.LVw_InSigning.MultiSelect = False
        Me.LVw_InSigning.Name = "LVw_InSigning"
        Me.LVw_InSigning.ShowGroups = False
        Me.LVw_InSigning.Size = New System.Drawing.Size(949, 379)
        Me.LVw_InSigning.TabIndex = 0
        Me.LVw_InSigning.UseCompatibleStateImageBehavior = False
        Me.LVw_InSigning.View = System.Windows.Forms.View.Details
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Btn_AddInSigning)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(949, 30)
        Me.Panel3.TabIndex = 1
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Auteur"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Editeur"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Début"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Fin"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Edition(s)"
        Me.ColumnHeader6.Width = 200
        '
        'Btn_AddInSigning
        '
        Me.Btn_AddInSigning.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_AddInSigning.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_AddInSigning.Image = CType(resources.GetObject("Btn_AddInSigning.Image"), System.Drawing.Image)
        Me.Btn_AddInSigning.Location = New System.Drawing.Point(917, 0)
        Me.Btn_AddInSigning.Name = "Btn_AddInSigning"
        Me.Btn_AddInSigning.Size = New System.Drawing.Size(32, 30)
        Me.Btn_AddInSigning.TabIndex = 2
        Me.Btn_AddInSigning.UseVisualStyleBackColor = False
        '
        'Btn_editFestival
        '
        Me.Btn_editFestival.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_editFestival.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_editFestival.Image = Global.BDList.My.Resources.Resources.edit
        Me.Btn_editFestival.Location = New System.Drawing.Point(1127, 3)
        Me.Btn_editFestival.Name = "Btn_editFestival"
        Me.Btn_editFestival.Size = New System.Drawing.Size(50, 50)
        Me.Btn_editFestival.TabIndex = 4
        Me.Btn_editFestival.UseVisualStyleBackColor = False
        '
        'Btn_addFestival
        '
        Me.Btn_addFestival.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_addFestival.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_addFestival.Image = CType(resources.GetObject("Btn_addFestival.Image"), System.Drawing.Image)
        Me.Btn_addFestival.Location = New System.Drawing.Point(1177, 3)
        Me.Btn_addFestival.Name = "Btn_addFestival"
        Me.Btn_addFestival.Size = New System.Drawing.Size(50, 50)
        Me.Btn_addFestival.TabIndex = 1
        Me.Btn_addFestival.UseVisualStyleBackColor = False
        '
        'UC_Festivals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Lst_festivals)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_Festivals"
        Me.Size = New System.Drawing.Size(1230, 659)
        Me.Title = "Festivals, séances de dédicace"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Lst_festivals, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_editFestival As Button
    Friend WithEvents Btn_addFestival As Button
    Friend WithEvents Lst_festivals As ListBox
    Friend WithEvents Lbl_festivalDates As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LVw_InSigning As Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_AddInSigning As Button
End Class
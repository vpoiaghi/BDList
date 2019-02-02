Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Events
    Inherits UC_Page

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
        Me.lst_events = New FrameworkPN.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_editEvent = New System.Windows.Forms.Button()
        Me.btn_addEvent = New System.Windows.Forms.Button()
        Me.btn_removeEvent = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_events
        '
        Me.lst_events.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lst_events.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_events.FullRowSelect = True
        Me.lst_events.GridLines = True
        Me.lst_events.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lst_events.HideSelection = False
        Me.lst_events.Location = New System.Drawing.Point(0, 124)
        Me.lst_events.MultiSelect = False
        Me.lst_events.Name = "lst_events"
        Me.lst_events.Size = New System.Drawing.Size(1100, 462)
        Me.lst_events.TabIndex = 2
        Me.lst_events.UseCompatibleStateImageBehavior = False
        Me.lst_events.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Du"
        Me.ColumnHeader1.Width = 59
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Au"
        Me.ColumnHeader2.Width = 59
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nom"
        Me.ColumnHeader3.Width = 197
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Lieu"
        Me.ColumnHeader4.Width = 148
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Commentaires"
        Me.ColumnHeader5.Width = 207
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Etat"
        Me.ColumnHeader6.Width = 59
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nb jours de rappel"
        Me.ColumnHeader7.Width = 148
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Nb jours de persistance"
        Me.ColumnHeader8.Width = 148
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Alerte"
        Me.ColumnHeader9.Width = 50
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_editEvent)
        Me.Panel2.Controls.Add(Me.btn_addEvent)
        Me.Panel2.Controls.Add(Me.btn_removeEvent)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(1100, 62)
        Me.Panel2.TabIndex = 1
        '
        'btn_editEvent
        '
        Me.btn_editEvent.BackColor = System.Drawing.SystemColors.Control
        Me.btn_editEvent.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_editEvent.Image = Global.BDList.My.Resources.Resources.edit
        Me.btn_editEvent.Location = New System.Drawing.Point(940, 10)
        Me.btn_editEvent.Name = "btn_editEvent"
        Me.btn_editEvent.Size = New System.Drawing.Size(50, 42)
        Me.btn_editEvent.TabIndex = 3
        Me.btn_editEvent.UseVisualStyleBackColor = False
        '
        'btn_addEvent
        '
        Me.btn_addEvent.BackColor = System.Drawing.SystemColors.Control
        Me.btn_addEvent.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_addEvent.Image = Global.BDList.My.Resources.Resources.add
        Me.btn_addEvent.Location = New System.Drawing.Point(990, 10)
        Me.btn_addEvent.Name = "btn_addEvent"
        Me.btn_addEvent.Size = New System.Drawing.Size(50, 42)
        Me.btn_addEvent.TabIndex = 2
        Me.btn_addEvent.UseVisualStyleBackColor = False
        '
        'btn_removeEvent
        '
        Me.btn_removeEvent.BackColor = System.Drawing.SystemColors.Control
        Me.btn_removeEvent.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_removeEvent.Image = Global.BDList.My.Resources.Resources.remove
        Me.btn_removeEvent.Location = New System.Drawing.Point(1040, 10)
        Me.btn_removeEvent.Name = "btn_removeEvent"
        Me.btn_removeEvent.Size = New System.Drawing.Size(50, 42)
        Me.btn_removeEvent.TabIndex = 4
        Me.btn_removeEvent.UseVisualStyleBackColor = False
        '
        'UC_Events
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Controls.Add(Me.lst_events)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "UC_Events"
        Me.Size = New System.Drawing.Size(1100, 586)
        Me.Title = "Evènements"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.lst_events, 0)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lst_events As FrameworkPN.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_editEvent As System.Windows.Forms.Button
    Friend WithEvents btn_addEvent As System.Windows.Forms.Button
    Friend WithEvents btn_removeEvent As System.Windows.Forms.Button

End Class

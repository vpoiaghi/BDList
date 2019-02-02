<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWriteEvent
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_place = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_comments = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_state = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_reminderDays = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_persistenceDays = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.txt_endDate = New FrameworkPN.DateTextBox()
        Me.pct_event = New FrameworkPN.PicturesList()
        Me.txt_startDate = New FrameworkPN.DateTextBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Date de début :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Date de fin :"
        '
        'txt_name
        '
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name.Location = New System.Drawing.Point(98, 64)
        Me.txt_name.MaxLength = 100
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(342, 62)
        Me.txt_name.TabIndex = 3
        Me.txt_name.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Nom :"
        '
        'txt_place
        '
        Me.txt_place.Location = New System.Drawing.Point(98, 132)
        Me.txt_place.MaxLength = 100
        Me.txt_place.Name = "txt_place"
        Me.txt_place.Size = New System.Drawing.Size(214, 20)
        Me.txt_place.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Lieu :"
        '
        'txt_comments
        '
        Me.txt_comments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comments.Location = New System.Drawing.Point(98, 158)
        Me.txt_comments.MaxLength = 255
        Me.txt_comments.Name = "txt_comments"
        Me.txt_comments.Size = New System.Drawing.Size(342, 117)
        Me.txt_comments.TabIndex = 5
        Me.txt_comments.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Commentaires :"
        '
        'cmb_state
        '
        Me.cmb_state.FormattingEnabled = True
        Me.cmb_state.Location = New System.Drawing.Point(98, 281)
        Me.cmb_state.Name = "cmb_state"
        Me.cmb_state.Size = New System.Drawing.Size(120, 21)
        Me.cmb_state.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Etat :"
        '
        'txt_reminderDays
        '
        Me.txt_reminderDays.Location = New System.Drawing.Point(98, 308)
        Me.txt_reminderDays.Name = "txt_reminderDays"
        Me.txt_reminderDays.Size = New System.Drawing.Size(89, 20)
        Me.txt_reminderDays.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Rappel :"
        '
        'txt_persistenceDays
        '
        Me.txt_persistenceDays.Location = New System.Drawing.Point(98, 334)
        Me.txt_persistenceDays.Name = "txt_persistenceDays"
        Me.txt_persistenceDays.Size = New System.Drawing.Size(89, 20)
        Me.txt_persistenceDays.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Persistance :"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(873, 438)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 22)
        Me.btn_save.TabIndex = 9
        Me.btn_save.Text = "Enregistrer"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.Location = New System.Drawing.Point(974, 438)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(100, 22)
        Me.btn_cancel.TabIndex = 10
        Me.btn_cancel.Text = "Annuler"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'txt_endDate
        '
        Me.txt_endDate.DateFormat = "dd/MM/yyyy"
        Me.txt_endDate.Location = New System.Drawing.Point(98, 38)
        Me.txt_endDate.Name = "txt_endDate"
        Me.txt_endDate.Size = New System.Drawing.Size(89, 20)
        Me.txt_endDate.TabIndex = 2
        '
        'pct_event
        '
        Me.pct_event.BackColor = System.Drawing.Color.DarkGray
        Me.pct_event.Location = New System.Drawing.Point(446, 12)
        Me.pct_event.Name = "pct_event"
        Me.pct_event.Size = New System.Drawing.Size(628, 420)
        Me.pct_event.TabIndex = 33
        '
        'txt_startDate
        '
        Me.txt_startDate.DateFormat = "dd/MM/yyyy"
        Me.txt_startDate.Location = New System.Drawing.Point(98, 12)
        Me.txt_startDate.Name = "txt_startDate"
        Me.txt_startDate.Size = New System.Drawing.Size(89, 20)
        Me.txt_startDate.TabIndex = 1
        '
        'FrmWriteEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 467)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.txt_persistenceDays)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_reminderDays)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_state)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_comments)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_place)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_endDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pct_event)
        Me.Controls.Add(Me.txt_startDate)
        Me.Controls.Add(Me.Label5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWriteEvent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Evènement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pct_event As FrameworkPN.PicturesList
    Friend WithEvents txt_startDate As FrameworkPN.DateTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_endDate As FrameworkPN.DateTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_place As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_comments As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_state As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_reminderDays As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_persistenceDays As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
End Class

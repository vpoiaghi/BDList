<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWritePurchase
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Postage = New FrameworkPN.MoneyTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dtb_StartDate = New FrameworkPN.DateTextBox()
        Me.Cmb_State = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RTB_Comments = New System.Windows.Forms.RichTextBox()
        Me.Btn_OK = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.slst_websites = New FrameworkPN.SelectList()
        Me.slst_sellers = New FrameworkPN.SelectList()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Frais de port :"
        '
        'Txt_Postage
        '
        Me.Txt_Postage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Postage.Location = New System.Drawing.Point(89, 136)
        Me.Txt_Postage.Name = "Txt_Postage"
        Me.Txt_Postage.Size = New System.Drawing.Size(87, 20)
        Me.Txt_Postage.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Date initiale :"
        '
        'Dtb_StartDate
        '
        Me.Dtb_StartDate.DateFormat = "dd/MM/yyyy"
        Me.Dtb_StartDate.Location = New System.Drawing.Point(89, 162)
        Me.Dtb_StartDate.Name = "Dtb_StartDate"
        Me.Dtb_StartDate.Size = New System.Drawing.Size(87, 19)
        Me.Dtb_StartDate.TabIndex = 45
        '
        'Cmb_State
        '
        Me.Cmb_State.FormattingEnabled = True
        Me.Cmb_State.Location = New System.Drawing.Point(89, 187)
        Me.Cmb_State.Name = "Cmb_State"
        Me.Cmb_State.Size = New System.Drawing.Size(141, 21)
        Me.Cmb_State.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Suivi :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Commentaires :"
        '
        'RTB_Comments
        '
        Me.RTB_Comments.Location = New System.Drawing.Point(89, 214)
        Me.RTB_Comments.Name = "RTB_Comments"
        Me.RTB_Comments.Size = New System.Drawing.Size(393, 149)
        Me.RTB_Comments.TabIndex = 49
        Me.RTB_Comments.Text = ""
        '
        'Btn_OK
        '
        Me.Btn_OK.Location = New System.Drawing.Point(281, 390)
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Size = New System.Drawing.Size(100, 22)
        Me.Btn_OK.TabIndex = 50
        Me.Btn_OK.Text = "Enregistrer"
        Me.Btn_OK.UseVisualStyleBackColor = True
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cancel.Location = New System.Drawing.Point(382, 390)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(100, 22)
        Me.Btn_Cancel.TabIndex = 51
        Me.Btn_Cancel.Text = "Annuler"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'slst_websites
        '
        Me.slst_websites.Location = New System.Drawing.Point(15, 12)
        Me.slst_websites.Name = "slst_websites"
        Me.slst_websites.Size = New System.Drawing.Size(467, 47)
        Me.slst_websites.TabIndex = 52
        Me.slst_websites.Title = "Site Web :"
        '
        'slst_sellers
        '
        Me.slst_sellers.Location = New System.Drawing.Point(15, 70)
        Me.slst_sellers.Name = "slst_sellers"
        Me.slst_sellers.Size = New System.Drawing.Size(467, 47)
        Me.slst_sellers.TabIndex = 53
        Me.slst_sellers.Title = "Vendeur :"
        '
        'FrmWritePurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 428)
        Me.Controls.Add(Me.slst_sellers)
        Me.Controls.Add(Me.slst_websites)
        Me.Controls.Add(Me.Btn_OK)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.RTB_Comments)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cmb_State)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Dtb_StartDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_Postage)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWritePurchase"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajouter ou modifier une vente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Postage As FrameworkPN.MoneyTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Dtb_StartDate As FrameworkPN.DateTextBox
    Friend WithEvents Cmb_State As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RTB_Comments As RichTextBox
    Friend WithEvents Btn_OK As Button
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents slst_websites As FrameworkPN.SelectList
    Friend WithEvents slst_sellers As FrameworkPN.SelectList
End Class

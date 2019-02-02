Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Purchases
    Inherits UC_Page

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGV_Purchases = New System.Windows.Forms.DataGridView()
        Me.COl_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_WebSite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Seller = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_comments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_showPurchase = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        CType(Me.DGV_Purchases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Purchases
        '
        Me.DGV_Purchases.AllowUserToAddRows = False
        Me.DGV_Purchases.AllowUserToDeleteRows = False
        Me.DGV_Purchases.AllowUserToOrderColumns = True
        Me.DGV_Purchases.AllowUserToResizeRows = False
        Me.DGV_Purchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Purchases.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COl_Id, Me.Col_WebSite, Me.Col_Seller, Me.Col_StartDate, Me.Col_State, Me.Col_comments})
        Me.DGV_Purchases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Purchases.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Purchases.Location = New System.Drawing.Point(0, 166)
        Me.DGV_Purchases.MultiSelect = False
        Me.DGV_Purchases.Name = "DGV_Purchases"
        Me.DGV_Purchases.RowHeadersVisible = False
        Me.DGV_Purchases.RowHeadersWidth = 20
        Me.DGV_Purchases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_Purchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Purchases.Size = New System.Drawing.Size(1261, 459)
        Me.DGV_Purchases.TabIndex = 1
        '
        'COl_Id
        '
        Me.COl_Id.HeaderText = "Id"
        Me.COl_Id.Name = "COl_Id"
        Me.COl_Id.Visible = False
        '
        'Col_WebSite
        '
        Me.Col_WebSite.HeaderText = "Site"
        Me.Col_WebSite.Name = "Col_WebSite"
        Me.Col_WebSite.Width = 150
        '
        'Col_Seller
        '
        Me.Col_Seller.HeaderText = "Vendeur"
        Me.Col_Seller.Name = "Col_Seller"
        Me.Col_Seller.Width = 150
        '
        'Col_StartDate
        '
        Me.Col_StartDate.HeaderText = "Date de début"
        Me.Col_StartDate.Name = "Col_StartDate"
        '
        'Col_State
        '
        Me.Col_State.HeaderText = "Suivi"
        Me.Col_State.Name = "Col_State"
        '
        'Col_comments
        '
        Me.Col_comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Col_comments.HeaderText = "Commentaires"
        Me.Col_comments.MinimumWidth = 100
        Me.Col_comments.Name = "Col_comments"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_edit)
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Controls.Add(Me.btn_showPurchase)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1261, 104)
        Me.Panel1.TabIndex = 2
        '
        'btn_showPurchase
        '
        Me.btn_showPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_showPurchase.Image = Global.BDList.My.Resources.Resources.loupe
        Me.btn_showPurchase.Location = New System.Drawing.Point(13, 15)
        Me.btn_showPurchase.Name = "btn_showPurchase"
        Me.btn_showPurchase.Size = New System.Drawing.Size(50, 50)
        Me.btn_showPurchase.TabIndex = 0
        Me.btn_showPurchase.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.Control
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Image = Global.BDList.My.Resources.Resources.add
        Me.btn_add.Location = New System.Drawing.Point(69, 15)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(50, 50)
        Me.btn_add.TabIndex = 9
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.Control
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Image = Global.BDList.My.Resources.Resources.edit
        Me.btn_edit.Location = New System.Drawing.Point(125, 15)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(50, 50)
        Me.btn_edit.TabIndex = 10
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'UC_Purchases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DGV_Purchases)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_Purchases"
        Me.Size = New System.Drawing.Size(1261, 625)
        Me.Title = "Suivi des achats - Synthèse"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.DGV_Purchases, 0)
        CType(Me.DGV_Purchases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_Purchases As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_showPurchase As Button
    Friend WithEvents COl_Id As DataGridViewTextBoxColumn
    Friend WithEvents Col_WebSite As DataGridViewTextBoxColumn
    Friend WithEvents Col_Seller As DataGridViewTextBoxColumn
    Friend WithEvents Col_StartDate As DataGridViewTextBoxColumn
    Friend WithEvents Col_State As DataGridViewTextBoxColumn
    Friend WithEvents Col_comments As DataGridViewTextBoxColumn
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_edit As Button
End Class

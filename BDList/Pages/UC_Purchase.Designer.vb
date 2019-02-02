Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Purchase
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RTB_Comments = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV_PricesMedium = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Prices = New System.Windows.Forms.DataGridView()
        Me.Col_PriceCaption = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_PriceValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lbl_PurchaseState = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.GVw_Ads = New FrameworkPN.GridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lnk_Seller = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_PricesMedium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Prices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.Lbl_PurchaseState)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 554)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RTB_Comments)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 316)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 191)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Commentaires "
        '
        'RTB_Comments
        '
        Me.RTB_Comments.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RTB_Comments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB_Comments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTB_Comments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB_Comments.Location = New System.Drawing.Point(3, 20)
        Me.RTB_Comments.Name = "RTB_Comments"
        Me.RTB_Comments.ReadOnly = True
        Me.RTB_Comments.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RTB_Comments.Size = New System.Drawing.Size(210, 168)
        Me.RTB_Comments.TabIndex = 4
        Me.RTB_Comments.TabStop = False
        Me.RTB_Comments.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV_PricesMedium)
        Me.GroupBox1.Controls.Add(Me.DGV_Prices)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 180)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Prix "
        '
        'DGV_PricesMedium
        '
        Me.DGV_PricesMedium.AllowUserToAddRows = False
        Me.DGV_PricesMedium.AllowUserToDeleteRows = False
        Me.DGV_PricesMedium.AllowUserToResizeColumns = False
        Me.DGV_PricesMedium.AllowUserToResizeRows = False
        Me.DGV_PricesMedium.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_PricesMedium.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGV_PricesMedium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PricesMedium.ColumnHeadersVisible = False
        Me.DGV_PricesMedium.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DGV_PricesMedium.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_PricesMedium.Enabled = False
        Me.DGV_PricesMedium.Location = New System.Drawing.Point(3, 120)
        Me.DGV_PricesMedium.MultiSelect = False
        Me.DGV_PricesMedium.Name = "DGV_PricesMedium"
        Me.DGV_PricesMedium.ReadOnly = True
        Me.DGV_PricesMedium.RowHeadersVisible = False
        Me.DGV_PricesMedium.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_PricesMedium.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_PricesMedium.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_PricesMedium.ShowCellErrors = False
        Me.DGV_PricesMedium.ShowEditingIcon = False
        Me.DGV_PricesMedium.ShowRowErrors = False
        Me.DGV_PricesMedium.Size = New System.Drawing.Size(210, 57)
        Me.DGV_PricesMedium.TabIndex = 2
        Me.DGV_PricesMedium.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Col_PriceCaption"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Col_PriceValue"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DGV_Prices
        '
        Me.DGV_Prices.AllowUserToAddRows = False
        Me.DGV_Prices.AllowUserToDeleteRows = False
        Me.DGV_Prices.AllowUserToResizeColumns = False
        Me.DGV_Prices.AllowUserToResizeRows = False
        Me.DGV_Prices.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Prices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGV_Prices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Prices.ColumnHeadersVisible = False
        Me.DGV_Prices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_PriceCaption, Me.Col_PriceValue})
        Me.DGV_Prices.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGV_Prices.Enabled = False
        Me.DGV_Prices.Location = New System.Drawing.Point(3, 20)
        Me.DGV_Prices.MultiSelect = False
        Me.DGV_Prices.Name = "DGV_Prices"
        Me.DGV_Prices.ReadOnly = True
        Me.DGV_Prices.RowHeadersVisible = False
        Me.DGV_Prices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_Prices.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_Prices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Prices.ShowCellErrors = False
        Me.DGV_Prices.ShowEditingIcon = False
        Me.DGV_Prices.ShowRowErrors = False
        Me.DGV_Prices.Size = New System.Drawing.Size(210, 87)
        Me.DGV_Prices.TabIndex = 1
        Me.DGV_Prices.TabStop = False
        '
        'Col_PriceCaption
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Col_PriceCaption.DefaultCellStyle = DataGridViewCellStyle3
        Me.Col_PriceCaption.HeaderText = "Col_PriceCaption"
        Me.Col_PriceCaption.Name = "Col_PriceCaption"
        Me.Col_PriceCaption.ReadOnly = True
        Me.Col_PriceCaption.Width = 150
        '
        'Col_PriceValue
        '
        Me.Col_PriceValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col_PriceValue.DefaultCellStyle = DataGridViewCellStyle4
        Me.Col_PriceValue.HeaderText = "Col_PriceValue"
        Me.Col_PriceValue.Name = "Col_PriceValue"
        Me.Col_PriceValue.ReadOnly = True
        '
        'Lbl_PurchaseState
        '
        Me.Lbl_PurchaseState.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_PurchaseState.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PurchaseState.Location = New System.Drawing.Point(0, 48)
        Me.Lbl_PurchaseState.Name = "Lbl_PurchaseState"
        Me.Lbl_PurchaseState.Size = New System.Drawing.Size(216, 38)
        Me.Lbl_PurchaseState.TabIndex = 2
        Me.Lbl_PurchaseState.Text = "Achat en cours"
        Me.Lbl_PurchaseState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Controls.Add(Me.btn_show)
        Me.Panel2.Controls.Add(Me.btn_edit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(216, 48)
        Me.Panel2.TabIndex = 4
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.Control
        Me.btn_add.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_add.Image = Global.BDList.My.Resources.Resources.add
        Me.btn_add.Location = New System.Drawing.Point(66, 0)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(50, 48)
        Me.btn_add.TabIndex = 8
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_show
        '
        Me.btn_show.BackColor = System.Drawing.SystemColors.Control
        Me.btn_show.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_show.Image = Global.BDList.My.Resources.Resources.loupe
        Me.btn_show.Location = New System.Drawing.Point(116, 0)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(50, 48)
        Me.btn_show.TabIndex = 7
        Me.btn_show.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.Control
        Me.btn_edit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_edit.Image = Global.BDList.My.Resources.Resources.edit
        Me.btn_edit.Location = New System.Drawing.Point(166, 0)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(50, 48)
        Me.btn_edit.TabIndex = 6
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'GVw_Ads
        '
        Me.GVw_Ads.BackColor = System.Drawing.Color.White
        Me.GVw_Ads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GVw_Ads.ColumnsCount = 8
        Me.GVw_Ads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GVw_Ads.ItemsMargin = 3
        Me.GVw_Ads.Location = New System.Drawing.Point(216, 62)
        Me.GVw_Ads.Name = "GVw_Ads"
        Me.GVw_Ads.RowsCount = 3
        Me.GVw_Ads.Size = New System.Drawing.Size(1029, 554)
        Me.GVw_Ads.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lnk_Seller)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(216, 50)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " Vendeur "
        '
        'Lnk_Seller
        '
        Me.Lnk_Seller.AutoSize = True
        Me.Lnk_Seller.Location = New System.Drawing.Point(6, 22)
        Me.Lnk_Seller.Name = "Lnk_Seller"
        Me.Lnk_Seller.Size = New System.Drawing.Size(78, 18)
        Me.Lnk_Seller.TabIndex = 0
        Me.Lnk_Seller.TabStop = True
        Me.Lnk_Seller.Text = "LinkLabel1"
        '
        'UC_Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GVw_Ads)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_Purchase"
        Me.Size = New System.Drawing.Size(1245, 616)
        Me.Title = "Vente de ... du ..."
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.GVw_Ads, 0)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV_PricesMedium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Prices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GVw_Ads As GridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV_Prices As DataGridView
    Friend WithEvents Col_PriceCaption As DataGridViewTextBoxColumn
    Friend WithEvents Col_PriceValue As DataGridViewTextBoxColumn
    Friend WithEvents DGV_PricesMedium As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Lbl_PurchaseState As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RTB_Comments As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_show As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Lnk_Seller As LinkLabel
End Class

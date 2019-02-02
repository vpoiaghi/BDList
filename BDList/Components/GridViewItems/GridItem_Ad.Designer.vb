Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GridItem_Ad
    Inherits GridItem

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
        Me.Pnl_Back = New System.Windows.Forms.Panel()
        Me.Lbl_WithAutograph = New System.Windows.Forms.Label()
        Me.Lbl_WithNumber = New System.Windows.Forms.Label()
        Me.Lbl_Comments = New System.Windows.Forms.Label()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.Pct_Image = New System.Windows.Forms.PictureBox()
        Me.Lbl_State = New System.Windows.Forms.Label()
        Me.Lbl_EndOfValidity = New System.Windows.Forms.Label()
        Me.Pnl_Price = New System.Windows.Forms.Panel()
        Me.Lbl_CostSeparation = New System.Windows.Forms.Label()
        Me.Lbl_CurrentCost = New System.Windows.Forms.Label()
        Me.Lbl_BestPrice = New System.Windows.Forms.Label()
        Me.Lbl_ArticlesCount = New System.Windows.Forms.Label()
        Me.pnl_colorLeft = New System.Windows.Forms.Panel()
        Me.Pnl_Back.SuspendLayout()
        CType(Me.Pct_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Price.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_Back
        '
        Me.Pnl_Back.Controls.Add(Me.Lbl_WithAutograph)
        Me.Pnl_Back.Controls.Add(Me.Lbl_WithNumber)
        Me.Pnl_Back.Controls.Add(Me.Lbl_Comments)
        Me.Pnl_Back.Controls.Add(Me.Lbl_Title)
        Me.Pnl_Back.Controls.Add(Me.Pct_Image)
        Me.Pnl_Back.Controls.Add(Me.Lbl_State)
        Me.Pnl_Back.Controls.Add(Me.Lbl_EndOfValidity)
        Me.Pnl_Back.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Back.Location = New System.Drawing.Point(8, 0)
        Me.Pnl_Back.Name = "Pnl_Back"
        Me.Pnl_Back.Size = New System.Drawing.Size(183, 304)
        Me.Pnl_Back.TabIndex = 7
        '
        'Lbl_WithAutograph
        '
        Me.Lbl_WithAutograph.BackColor = System.Drawing.Color.Red
        Me.Lbl_WithAutograph.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_WithAutograph.ForeColor = System.Drawing.Color.White
        Me.Lbl_WithAutograph.Location = New System.Drawing.Point(165, 56)
        Me.Lbl_WithAutograph.Name = "Lbl_WithAutograph"
        Me.Lbl_WithAutograph.Size = New System.Drawing.Size(18, 18)
        Me.Lbl_WithAutograph.TabIndex = 11
        Me.Lbl_WithAutograph.Text = "S"
        Me.Lbl_WithAutograph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_WithNumber
        '
        Me.Lbl_WithNumber.BackColor = System.Drawing.Color.Red
        Me.Lbl_WithNumber.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_WithNumber.ForeColor = System.Drawing.Color.White
        Me.Lbl_WithNumber.Location = New System.Drawing.Point(165, 36)
        Me.Lbl_WithNumber.Name = "Lbl_WithNumber"
        Me.Lbl_WithNumber.Size = New System.Drawing.Size(18, 18)
        Me.Lbl_WithNumber.TabIndex = 10
        Me.Lbl_WithNumber.Text = "N"
        Me.Lbl_WithNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Comments
        '
        Me.Lbl_Comments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl_Comments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_Comments.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Comments.Location = New System.Drawing.Point(0, 213)
        Me.Lbl_Comments.Name = "Lbl_Comments"
        Me.Lbl_Comments.Size = New System.Drawing.Size(183, 91)
        Me.Lbl_Comments.TabIndex = 5
        Me.Lbl_Comments.Text = "Commentaires"
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_Title.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.Location = New System.Drawing.Point(0, 198)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(27, 15)
        Me.Lbl_Title.TabIndex = 9
        Me.Lbl_Title.Text = "Titre"
        Me.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Pct_Image
        '
        Me.Pct_Image.BackColor = System.Drawing.Color.Black
        Me.Pct_Image.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pct_Image.Location = New System.Drawing.Point(0, 36)
        Me.Pct_Image.Name = "Pct_Image"
        Me.Pct_Image.Size = New System.Drawing.Size(183, 162)
        Me.Pct_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pct_Image.TabIndex = 8
        Me.Pct_Image.TabStop = False
        '
        'Lbl_State
        '
        Me.Lbl_State.BackColor = System.Drawing.Color.Black
        Me.Lbl_State.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_State.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_State.ForeColor = System.Drawing.Color.White
        Me.Lbl_State.Location = New System.Drawing.Point(0, 18)
        Me.Lbl_State.Name = "Lbl_State"
        Me.Lbl_State.Size = New System.Drawing.Size(183, 18)
        Me.Lbl_State.TabIndex = 7
        Me.Lbl_State.Text = "Enchère en cours"
        Me.Lbl_State.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_EndOfValidity
        '
        Me.Lbl_EndOfValidity.BackColor = System.Drawing.Color.Black
        Me.Lbl_EndOfValidity.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_EndOfValidity.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EndOfValidity.ForeColor = System.Drawing.Color.White
        Me.Lbl_EndOfValidity.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_EndOfValidity.Name = "Lbl_EndOfValidity"
        Me.Lbl_EndOfValidity.Size = New System.Drawing.Size(183, 18)
        Me.Lbl_EndOfValidity.TabIndex = 6
        Me.Lbl_EndOfValidity.Text = "12/03/2018 12:45:16"
        Me.Lbl_EndOfValidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pnl_Price
        '
        Me.Pnl_Price.Controls.Add(Me.Lbl_CostSeparation)
        Me.Pnl_Price.Controls.Add(Me.Lbl_CurrentCost)
        Me.Pnl_Price.Controls.Add(Me.Lbl_BestPrice)
        Me.Pnl_Price.Controls.Add(Me.Lbl_ArticlesCount)
        Me.Pnl_Price.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pnl_Price.Location = New System.Drawing.Point(0, 304)
        Me.Pnl_Price.Name = "Pnl_Price"
        Me.Pnl_Price.Size = New System.Drawing.Size(191, 18)
        Me.Pnl_Price.TabIndex = 3
        '
        'Lbl_CostSeparation
        '
        Me.Lbl_CostSeparation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CostSeparation.Location = New System.Drawing.Point(69, 1)
        Me.Lbl_CostSeparation.Name = "Lbl_CostSeparation"
        Me.Lbl_CostSeparation.Size = New System.Drawing.Size(19, 18)
        Me.Lbl_CostSeparation.TabIndex = 3
        Me.Lbl_CostSeparation.Text = "/"
        Me.Lbl_CostSeparation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_CurrentCost
        '
        Me.Lbl_CurrentCost.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lbl_CurrentCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CurrentCost.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_CurrentCost.Name = "Lbl_CurrentCost"
        Me.Lbl_CurrentCost.Size = New System.Drawing.Size(71, 18)
        Me.Lbl_CurrentCost.TabIndex = 1
        Me.Lbl_CurrentCost.Text = "Label1"
        Me.Lbl_CurrentCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_BestPrice
        '
        Me.Lbl_BestPrice.Dock = System.Windows.Forms.DockStyle.Right
        Me.Lbl_BestPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BestPrice.Location = New System.Drawing.Point(104, 0)
        Me.Lbl_BestPrice.Name = "Lbl_BestPrice"
        Me.Lbl_BestPrice.Size = New System.Drawing.Size(60, 18)
        Me.Lbl_BestPrice.TabIndex = 2
        Me.Lbl_BestPrice.Text = "Label1"
        Me.Lbl_BestPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_ArticlesCount
        '
        Me.Lbl_ArticlesCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lbl_ArticlesCount.Dock = System.Windows.Forms.DockStyle.Right
        Me.Lbl_ArticlesCount.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ArticlesCount.ForeColor = System.Drawing.Color.White
        Me.Lbl_ArticlesCount.Location = New System.Drawing.Point(164, 0)
        Me.Lbl_ArticlesCount.Name = "Lbl_ArticlesCount"
        Me.Lbl_ArticlesCount.Size = New System.Drawing.Size(27, 18)
        Me.Lbl_ArticlesCount.TabIndex = 4
        Me.Lbl_ArticlesCount.Text = "1"
        Me.Lbl_ArticlesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_colorLeft
        '
        Me.pnl_colorLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_colorLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnl_colorLeft.Name = "pnl_colorLeft"
        Me.pnl_colorLeft.Size = New System.Drawing.Size(8, 304)
        Me.pnl_colorLeft.TabIndex = 8
        '
        'GridItem_Ad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Pnl_Back)
        Me.Controls.Add(Me.pnl_colorLeft)
        Me.Controls.Add(Me.Pnl_Price)
        Me.Name = "GridItem_Ad"
        Me.Size = New System.Drawing.Size(191, 322)
        Me.Pnl_Back.ResumeLayout(False)
        Me.Pnl_Back.PerformLayout()
        CType(Me.Pct_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Price.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_Back As Panel
    Friend WithEvents Lbl_Comments As Label
    Friend WithEvents Lbl_Title As Label
    Friend WithEvents Pct_Image As PictureBox
    Friend WithEvents Lbl_State As Label
    Friend WithEvents Lbl_EndOfValidity As Label
    Friend WithEvents Pnl_Price As Panel
    Friend WithEvents Lbl_CostSeparation As Label
    Friend WithEvents Lbl_CurrentCost As Label
    Friend WithEvents Lbl_BestPrice As Label
    Friend WithEvents Lbl_ArticlesCount As Label
    Friend WithEvents pnl_colorLeft As Panel
    Friend WithEvents Lbl_WithAutograph As Label
    Friend WithEvents Lbl_WithNumber As Label
End Class

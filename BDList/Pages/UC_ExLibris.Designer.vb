Imports FrameworkPN

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ExLibris
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Btn_Letter = New System.Windows.Forms.Button()
        Me.ChkVeryLargeSize = New System.Windows.Forms.CheckBox()
        Me.ChkLargeSize = New System.Windows.Forms.CheckBox()
        Me.ChkMiddleSize = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Pnl_XL1 = New System.Windows.Forms.Panel()
        Me.Pct_XL1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_XLSerie1 = New System.Windows.Forms.Label()
        Me.Lbl_XLDescription1 = New System.Windows.Forms.Label()
        Me.Lbl_XLAuthor1 = New System.Windows.Forms.Label()
        Me.Pnl_XL5 = New System.Windows.Forms.Panel()
        Me.Pct_XL5 = New System.Windows.Forms.PictureBox()
        Me.Lbl_XLSerie5 = New System.Windows.Forms.Label()
        Me.Lbl_XLDescription5 = New System.Windows.Forms.Label()
        Me.Lbl_XLAuthor5 = New System.Windows.Forms.Label()
        Me.Pnl_XL2 = New System.Windows.Forms.Panel()
        Me.Pct_XL2 = New System.Windows.Forms.PictureBox()
        Me.Lbl_XLSerie2 = New System.Windows.Forms.Label()
        Me.Lbl_XLDescription2 = New System.Windows.Forms.Label()
        Me.Lbl_XLAuthor2 = New System.Windows.Forms.Label()
        Me.Pnl_XL4 = New System.Windows.Forms.Panel()
        Me.Pct_XL4 = New System.Windows.Forms.PictureBox()
        Me.Lbl_XLSerie4 = New System.Windows.Forms.Label()
        Me.Lbl_XLDescription4 = New System.Windows.Forms.Label()
        Me.Lbl_XLAuthor4 = New System.Windows.Forms.Label()
        Me.Pnl_XL3 = New System.Windows.Forms.Panel()
        Me.Pct_XL3 = New System.Windows.Forms.PictureBox()
        Me.Lbl_XLSerie3 = New System.Windows.Forms.Label()
        Me.Lbl_XLDescription3 = New System.Windows.Forms.Label()
        Me.Lbl_XLAuthor3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Pnl_XL1.SuspendLayout()
        CType(Me.Pct_XL1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_XL5.SuspendLayout()
        CType(Me.Pct_XL5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_XL2.SuspendLayout()
        CType(Me.Pct_XL2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_XL4.SuspendLayout()
        CType(Me.Pct_XL4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_XL3.SuspendLayout()
        CType(Me.Pct_XL3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.ChkVeryLargeSize)
        Me.Panel1.Controls.Add(Me.ChkLargeSize)
        Me.Panel1.Controls.Add(Me.ChkMiddleSize)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1231, 133)
        Me.Panel1.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Btn_Letter)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(745, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(486, 133)
        Me.Panel5.TabIndex = 3
        '
        'Btn_Letter
        '
        Me.Btn_Letter.Location = New System.Drawing.Point(100, 30)
        Me.Btn_Letter.Name = "Btn_Letter"
        Me.Btn_Letter.Size = New System.Drawing.Size(32, 32)
        Me.Btn_Letter.TabIndex = 0
        Me.Btn_Letter.Text = "A"
        Me.Btn_Letter.UseVisualStyleBackColor = True
        '
        'ChkVeryLargeSize
        '
        Me.ChkVeryLargeSize.AutoSize = True
        Me.ChkVeryLargeSize.Checked = True
        Me.ChkVeryLargeSize.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkVeryLargeSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkVeryLargeSize.Location = New System.Drawing.Point(39, 61)
        Me.ChkVeryLargeSize.Name = "ChkVeryLargeSize"
        Me.ChkVeryLargeSize.Size = New System.Drawing.Size(204, 22)
        Me.ChkVeryLargeSize.TabIndex = 2
        Me.ChkVeryLargeSize.Text = "Très grands (sup. à A3)"
        Me.ChkVeryLargeSize.UseVisualStyleBackColor = True
        '
        'ChkLargeSize
        '
        Me.ChkLargeSize.AutoSize = True
        Me.ChkLargeSize.Checked = True
        Me.ChkLargeSize.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkLargeSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkLargeSize.Location = New System.Drawing.Point(39, 38)
        Me.ChkLargeSize.Name = "ChkLargeSize"
        Me.ChkLargeSize.Size = New System.Drawing.Size(118, 22)
        Me.ChkLargeSize.TabIndex = 1
        Me.ChkLargeSize.Text = "Grands (A3)"
        Me.ChkLargeSize.UseVisualStyleBackColor = True
        '
        'ChkMiddleSize
        '
        Me.ChkMiddleSize.AutoSize = True
        Me.ChkMiddleSize.Checked = True
        Me.ChkMiddleSize.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMiddleSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMiddleSize.Location = New System.Drawing.Point(39, 15)
        Me.ChkMiddleSize.Name = "ChkMiddleSize"
        Me.ChkMiddleSize.Size = New System.Drawing.Size(169, 22)
        Me.ChkMiddleSize.TabIndex = 0
        Me.ChkMiddleSize.Text = "Moyens (A4 et inf.)"
        Me.ChkMiddleSize.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 643)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1231, 133)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 195)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1231, 448)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Pnl_XL1)
        Me.Panel4.Controls.Add(Me.Pnl_XL5)
        Me.Panel4.Controls.Add(Me.Pnl_XL2)
        Me.Panel4.Controls.Add(Me.Pnl_XL4)
        Me.Panel4.Controls.Add(Me.Pnl_XL3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(32, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1167, 448)
        Me.Panel4.TabIndex = 7
        '
        'Pnl_XL1
        '
        Me.Pnl_XL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_XL1.Controls.Add(Me.Pct_XL1)
        Me.Pnl_XL1.Controls.Add(Me.Lbl_XLSerie1)
        Me.Pnl_XL1.Controls.Add(Me.Lbl_XLDescription1)
        Me.Pnl_XL1.Controls.Add(Me.Lbl_XLAuthor1)
        Me.Pnl_XL1.Location = New System.Drawing.Point(3, 6)
        Me.Pnl_XL1.Name = "Pnl_XL1"
        Me.Pnl_XL1.Size = New System.Drawing.Size(203, 182)
        Me.Pnl_XL1.TabIndex = 2
        '
        'Pct_XL1
        '
        Me.Pct_XL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pct_XL1.Location = New System.Drawing.Point(0, 0)
        Me.Pct_XL1.Name = "Pct_XL1"
        Me.Pct_XL1.Size = New System.Drawing.Size(201, 141)
        Me.Pct_XL1.TabIndex = 0
        Me.Pct_XL1.TabStop = False
        '
        'Lbl_XLSerie1
        '
        Me.Lbl_XLSerie1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLSerie1.Location = New System.Drawing.Point(0, 141)
        Me.Lbl_XLSerie1.Name = "Lbl_XLSerie1"
        Me.Lbl_XLSerie1.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLSerie1.TabIndex = 1
        Me.Lbl_XLSerie1.Text = "Label1"
        '
        'Lbl_XLDescription1
        '
        Me.Lbl_XLDescription1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLDescription1.Location = New System.Drawing.Point(0, 154)
        Me.Lbl_XLDescription1.Name = "Lbl_XLDescription1"
        Me.Lbl_XLDescription1.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLDescription1.TabIndex = 2
        Me.Lbl_XLDescription1.Text = "Label2"
        '
        'Lbl_XLAuthor1
        '
        Me.Lbl_XLAuthor1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLAuthor1.Location = New System.Drawing.Point(0, 167)
        Me.Lbl_XLAuthor1.Name = "Lbl_XLAuthor1"
        Me.Lbl_XLAuthor1.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLAuthor1.TabIndex = 3
        Me.Lbl_XLAuthor1.Text = "Label1"
        '
        'Pnl_XL5
        '
        Me.Pnl_XL5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_XL5.Controls.Add(Me.Pct_XL5)
        Me.Pnl_XL5.Controls.Add(Me.Lbl_XLSerie5)
        Me.Pnl_XL5.Controls.Add(Me.Lbl_XLDescription5)
        Me.Pnl_XL5.Controls.Add(Me.Lbl_XLAuthor5)
        Me.Pnl_XL5.Location = New System.Drawing.Point(838, 10)
        Me.Pnl_XL5.Name = "Pnl_XL5"
        Me.Pnl_XL5.Size = New System.Drawing.Size(203, 182)
        Me.Pnl_XL5.TabIndex = 6
        '
        'Pct_XL5
        '
        Me.Pct_XL5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pct_XL5.Location = New System.Drawing.Point(0, 0)
        Me.Pct_XL5.Name = "Pct_XL5"
        Me.Pct_XL5.Size = New System.Drawing.Size(201, 141)
        Me.Pct_XL5.TabIndex = 0
        Me.Pct_XL5.TabStop = False
        '
        'Lbl_XLSerie5
        '
        Me.Lbl_XLSerie5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLSerie5.Location = New System.Drawing.Point(0, 141)
        Me.Lbl_XLSerie5.Name = "Lbl_XLSerie5"
        Me.Lbl_XLSerie5.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLSerie5.TabIndex = 1
        Me.Lbl_XLSerie5.Text = "Label9"
        '
        'Lbl_XLDescription5
        '
        Me.Lbl_XLDescription5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLDescription5.Location = New System.Drawing.Point(0, 154)
        Me.Lbl_XLDescription5.Name = "Lbl_XLDescription5"
        Me.Lbl_XLDescription5.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLDescription5.TabIndex = 2
        Me.Lbl_XLDescription5.Text = "Label10"
        '
        'Lbl_XLAuthor5
        '
        Me.Lbl_XLAuthor5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLAuthor5.Location = New System.Drawing.Point(0, 167)
        Me.Lbl_XLAuthor5.Name = "Lbl_XLAuthor5"
        Me.Lbl_XLAuthor5.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLAuthor5.TabIndex = 4
        Me.Lbl_XLAuthor5.Text = "Label1"
        '
        'Pnl_XL2
        '
        Me.Pnl_XL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_XL2.Controls.Add(Me.Pct_XL2)
        Me.Pnl_XL2.Controls.Add(Me.Lbl_XLSerie2)
        Me.Pnl_XL2.Controls.Add(Me.Lbl_XLDescription2)
        Me.Pnl_XL2.Controls.Add(Me.Lbl_XLAuthor2)
        Me.Pnl_XL2.Location = New System.Drawing.Point(212, 7)
        Me.Pnl_XL2.Name = "Pnl_XL2"
        Me.Pnl_XL2.Size = New System.Drawing.Size(203, 182)
        Me.Pnl_XL2.TabIndex = 3
        '
        'Pct_XL2
        '
        Me.Pct_XL2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pct_XL2.Location = New System.Drawing.Point(0, 0)
        Me.Pct_XL2.Name = "Pct_XL2"
        Me.Pct_XL2.Size = New System.Drawing.Size(201, 141)
        Me.Pct_XL2.TabIndex = 0
        Me.Pct_XL2.TabStop = False
        '
        'Lbl_XLSerie2
        '
        Me.Lbl_XLSerie2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLSerie2.Location = New System.Drawing.Point(0, 141)
        Me.Lbl_XLSerie2.Name = "Lbl_XLSerie2"
        Me.Lbl_XLSerie2.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLSerie2.TabIndex = 1
        Me.Lbl_XLSerie2.Text = "Label3"
        '
        'Lbl_XLDescription2
        '
        Me.Lbl_XLDescription2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLDescription2.Location = New System.Drawing.Point(0, 154)
        Me.Lbl_XLDescription2.Name = "Lbl_XLDescription2"
        Me.Lbl_XLDescription2.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLDescription2.TabIndex = 2
        Me.Lbl_XLDescription2.Text = "Label4"
        '
        'Lbl_XLAuthor2
        '
        Me.Lbl_XLAuthor2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLAuthor2.Location = New System.Drawing.Point(0, 167)
        Me.Lbl_XLAuthor2.Name = "Lbl_XLAuthor2"
        Me.Lbl_XLAuthor2.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLAuthor2.TabIndex = 4
        Me.Lbl_XLAuthor2.Text = "Label1"
        '
        'Pnl_XL4
        '
        Me.Pnl_XL4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_XL4.Controls.Add(Me.Pct_XL4)
        Me.Pnl_XL4.Controls.Add(Me.Lbl_XLSerie4)
        Me.Pnl_XL4.Controls.Add(Me.Lbl_XLDescription4)
        Me.Pnl_XL4.Controls.Add(Me.Lbl_XLAuthor4)
        Me.Pnl_XL4.Location = New System.Drawing.Point(629, 9)
        Me.Pnl_XL4.Name = "Pnl_XL4"
        Me.Pnl_XL4.Size = New System.Drawing.Size(203, 182)
        Me.Pnl_XL4.TabIndex = 5
        '
        'Pct_XL4
        '
        Me.Pct_XL4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pct_XL4.Location = New System.Drawing.Point(0, 0)
        Me.Pct_XL4.Name = "Pct_XL4"
        Me.Pct_XL4.Size = New System.Drawing.Size(201, 141)
        Me.Pct_XL4.TabIndex = 0
        Me.Pct_XL4.TabStop = False
        '
        'Lbl_XLSerie4
        '
        Me.Lbl_XLSerie4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLSerie4.Location = New System.Drawing.Point(0, 141)
        Me.Lbl_XLSerie4.Name = "Lbl_XLSerie4"
        Me.Lbl_XLSerie4.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLSerie4.TabIndex = 1
        Me.Lbl_XLSerie4.Text = "Label7"
        '
        'Lbl_XLDescription4
        '
        Me.Lbl_XLDescription4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLDescription4.Location = New System.Drawing.Point(0, 154)
        Me.Lbl_XLDescription4.Name = "Lbl_XLDescription4"
        Me.Lbl_XLDescription4.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLDescription4.TabIndex = 2
        Me.Lbl_XLDescription4.Text = "Label8"
        '
        'Lbl_XLAuthor4
        '
        Me.Lbl_XLAuthor4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLAuthor4.Location = New System.Drawing.Point(0, 167)
        Me.Lbl_XLAuthor4.Name = "Lbl_XLAuthor4"
        Me.Lbl_XLAuthor4.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLAuthor4.TabIndex = 4
        Me.Lbl_XLAuthor4.Text = "Label1"
        '
        'Pnl_XL3
        '
        Me.Pnl_XL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_XL3.Controls.Add(Me.Pct_XL3)
        Me.Pnl_XL3.Controls.Add(Me.Lbl_XLSerie3)
        Me.Pnl_XL3.Controls.Add(Me.Lbl_XLDescription3)
        Me.Pnl_XL3.Controls.Add(Me.Lbl_XLAuthor3)
        Me.Pnl_XL3.Location = New System.Drawing.Point(421, 8)
        Me.Pnl_XL3.Name = "Pnl_XL3"
        Me.Pnl_XL3.Size = New System.Drawing.Size(203, 182)
        Me.Pnl_XL3.TabIndex = 4
        '
        'Pct_XL3
        '
        Me.Pct_XL3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pct_XL3.Location = New System.Drawing.Point(0, 0)
        Me.Pct_XL3.Name = "Pct_XL3"
        Me.Pct_XL3.Size = New System.Drawing.Size(201, 141)
        Me.Pct_XL3.TabIndex = 0
        Me.Pct_XL3.TabStop = False
        '
        'Lbl_XLSerie3
        '
        Me.Lbl_XLSerie3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLSerie3.Location = New System.Drawing.Point(0, 141)
        Me.Lbl_XLSerie3.Name = "Lbl_XLSerie3"
        Me.Lbl_XLSerie3.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLSerie3.TabIndex = 1
        Me.Lbl_XLSerie3.Text = "Label5"
        '
        'Lbl_XLDescription3
        '
        Me.Lbl_XLDescription3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLDescription3.Location = New System.Drawing.Point(0, 154)
        Me.Lbl_XLDescription3.Name = "Lbl_XLDescription3"
        Me.Lbl_XLDescription3.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLDescription3.TabIndex = 2
        Me.Lbl_XLDescription3.Text = "Label6"
        '
        'Lbl_XLAuthor3
        '
        Me.Lbl_XLAuthor3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lbl_XLAuthor3.Location = New System.Drawing.Point(0, 167)
        Me.Lbl_XLAuthor3.Name = "Lbl_XLAuthor3"
        Me.Lbl_XLAuthor3.Size = New System.Drawing.Size(201, 13)
        Me.Lbl_XLAuthor3.TabIndex = 4
        Me.Lbl_XLAuthor3.Text = "Label1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = Global.BDList.My.Resources.Resources.btn_arrow_slide_right
        Me.PictureBox2.Location = New System.Drawing.Point(1199, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 448)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.BDList.My.Resources.Resources.btn_arrow_slide_left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 448)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UC_ExLibris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_ExLibris"
        Me.Size = New System.Drawing.Size(1231, 776)
        Me.Title = "Ex-Libris"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Pnl_XL1.ResumeLayout(False)
        CType(Me.Pct_XL1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_XL5.ResumeLayout(False)
        CType(Me.Pct_XL5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_XL2.ResumeLayout(False)
        CType(Me.Pct_XL2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_XL4.ResumeLayout(False)
        CType(Me.Pct_XL4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_XL3.ResumeLayout(False)
        CType(Me.Pct_XL3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Pnl_XL1 As System.Windows.Forms.Panel
    Friend WithEvents Pct_XL1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_XLSerie1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_XLDescription1 As System.Windows.Forms.Label
    Friend WithEvents Pnl_XL5 As System.Windows.Forms.Panel
    Friend WithEvents Pct_XL5 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_XLSerie5 As System.Windows.Forms.Label
    Friend WithEvents Lbl_XLDescription5 As System.Windows.Forms.Label
    Friend WithEvents Pnl_XL4 As System.Windows.Forms.Panel
    Friend WithEvents Pct_XL4 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_XLSerie4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_XLDescription4 As System.Windows.Forms.Label
    Friend WithEvents Pnl_XL3 As System.Windows.Forms.Panel
    Friend WithEvents Pct_XL3 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_XLSerie3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_XLDescription3 As System.Windows.Forms.Label
    Friend WithEvents Pnl_XL2 As System.Windows.Forms.Panel
    Friend WithEvents Pct_XL2 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_XLSerie2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_XLDescription2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ChkLargeSize As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMiddleSize As System.Windows.Forms.CheckBox
    Friend WithEvents ChkVeryLargeSize As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_XLAuthor1 As Label
    Friend WithEvents Lbl_XLAuthor5 As Label
    Friend WithEvents Lbl_XLAuthor2 As Label
    Friend WithEvents Lbl_XLAuthor4 As Label
    Friend WithEvents Lbl_XLAuthor3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Btn_Letter As Button
End Class

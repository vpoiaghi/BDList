Imports FrameworkPN
Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS
Imports BDList_TOOLS.IO

Public Class UC_ExLibris

    Private m_xlList As New List(Of Goody)
    Private m_currentIndex As Integer = -1
    Private m_currentId As Long = -1

    Private m_showMddleSizeXL As Boolean = True
    Private m_showLargeSizeXL As Boolean = True
    Private m_showVeryLargeSizeXL As Boolean = True

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()
        InitializeLetterButtons()
    End Sub

    Protected Overrides Sub Activate()
        LoadExLibris()
    End Sub

    Private Sub InitializeLetterButtons()

        Dim i As Integer = 0

        AddLetterButton(i, "HS")
        i += 1

        AddLetterButton(i, "0")
        i += 1

        While i < 28
            AddLetterButton(i, Chr(65 + (i - 2)))
            i += 1
        End While


    End Sub

    Private Function AddLetterButton(index As Integer, text As String) As Button

        Dim cols As Integer = 7

        Dim btn As Button

        If index = 0 Then
            btn = Btn_Letter
        Else
            btn = New Button

            With btn
                .Parent = Btn_Letter.Parent
                .Visible = Btn_Letter.Visible
                .Size = Btn_Letter.Size
            End With

        End If

        With btn
            .Text = text
            .Top = Math.Floor(index / cols) * .Height
            .Left = .Parent.Width - (.Width * (cols - (index Mod cols)))
        End With

        AddHandler btn.Click, AddressOf Btn_Letter_Click

        Return btn

    End Function

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

        Dim w As Integer = (Panel4.Width - 60) / 5
        Dim h As Integer = Panel4.Height
        Dim l As Integer

        l = 10
        Pnl_XL1.Location = New Point(l, 0)
        Pnl_XL1.Size = New Size(w, h)

        l += w + 10
        Pnl_XL2.Location = New Point(l, 0)
        Pnl_XL2.Size = New Size(w, h)

        l += w + 10
        Pnl_XL3.Location = New Point(l, 0)
        Pnl_XL3.Size = New Size(w, h)

        l += w + 10
        Pnl_XL4.Location = New Point(l, 0)
        Pnl_XL4.Size = New Size(w, h)

        l += w + 10
        Pnl_XL5.Location = New Point(l, 0)
        Pnl_XL5.Size = New Size(w, h)

    End Sub

    Private Sub LoadExLibris()

        LoadExLibris(GetParameter(NavParameters.PRM_GOODY_ID))
        SetParameter(NavParameters.PRM_GOODY_ID, Nothing)

    End Sub

    Private Sub LoadExLibris(xlId As Long)

        If Me.Controls.Find("Pct_XL1", True).Length > 0 Then

            m_currentId = xlId

            Dim svcGoodies As New ServiceGoody
            Dim xlList As List(Of IdBObject) = svcGoodies.GetExLibrisLike()

            Dim canShow As Boolean = False
            Dim xlIndex As Integer = -1

            m_xlList.Clear()

            If xlList.Count > 0 Then

                Dim xl As Goody

                For Each obj As IdBObject In xlList

                    xl = CType(obj, Goody)

                    If xl.GetId = 1142 Then
                        canShow = canShow
                    End If

                    If (xl.GetPossessionState.GetId <> PossessionStates.InPossession) _
                        AndAlso (xl.GetPossessionState.GetId <> PossessionStates.Reserved) _
                        AndAlso (xl.GetPossessionState.GetId <> PossessionStates.InDelivery) _
                        Then
                        canShow = False
                    ElseIf m_showMddleSizeXL AndAlso m_showLargeSizeXL And m_showVeryLargeSizeXL Then
                        canShow = True
                    ElseIf Not (m_showMddleSizeXL OrElse m_showLargeSizeXL OrElse m_showVeryLargeSizeXL) Then
                        canShow = False
                    Else
                        canShow = (m_showMddleSizeXL AndAlso EnterIn(xl, 211, 301)) _
                            OrElse (m_showLargeSizeXL AndAlso (Not EnterIn(xl, 211, 301) AndAlso EnterIn(xl, 301, 422))) _
                            OrElse (m_showVeryLargeSizeXL AndAlso (Not EnterIn(xl, 302, 422)))
                    End If

                    If canShow Then
                        m_xlList.Add(xl)

                        If (xl.GetId = m_currentId) Then
                            xlIndex = m_xlList.Count
                        End If
                    End If

                Next
            End If

            If m_xlList.Count > 0 Then
                ShowExLibris(IIf(xlIndex = -1, 0, xlIndex - 1))
            Else
                CleanExLibris()
            End If

        End If

    End Sub

    Private Sub ShowExLibris(xlIndex As Integer)

        m_currentIndex = xlIndex
        m_currentId = m_xlList(m_currentIndex).GetId

        Dim firstIndex As Integer = 0
        If m_currentIndex > 2 Then
            firstIndex = m_currentIndex - 2
        End If

        Dim lastIndex As Integer = firstIndex + 4
        If lastIndex >= m_xlList.Count Then
            lastIndex = m_xlList.Count - 1
        End If

        Dim pnlIndex As Integer = 0

        For i As Integer = firstIndex To lastIndex
            pnlIndex += 1
            ShowXL(pnlIndex, m_xlList(i))
        Next

    End Sub

    Private Sub CleanExLibris()

        For i As Integer = 1 To 5
            CleanXL(i)
        Next

    End Sub

    Private Sub ShowXL(pnlIndex As Integer, xl As Goody)

        Dim pnl As Panel = CType(Me.Controls.Find("Pnl_XL" & pnlIndex, True)(0), Panel)
        pnl.Tag = xl

        Dim pct As PictureBox = CType(Me.Controls.Find("Pct_XL" & pnlIndex, True)(0), PictureBox)
        pct.SizeMode = PictureBoxSizeMode.Zoom

        Dim svcGoody As New ServiceGoody
        Dim files As List(Of IFile) = svcGoody.GetFiles(xl)

        If files.Count > 0 Then
            pct.Image = ImageUtils.LoadImage(files(0))
        Else
            pct.Image = Nothing
        End If

        Dim lblSerie As Label = CType(Me.Controls.Find("Lbl_XLSerie" & pnlIndex, True)(0), Label)
        lblSerie.Text = CType(xl.GetSeries(0), Serie).GetName

        Dim lblDescription As Label = CType(Me.Controls.Find("Lbl_XLDescription" & pnlIndex, True)(0), Label)
        lblDescription.Text = xl.ToString

        Dim lblAuthor As Label = CType(Me.Controls.Find("Lbl_XLAuthor" & pnlIndex, True)(0), Label)
        Dim authors As List(Of IdBObject) = xl.GetAuthors
        If authors.Count > 0 Then
            lblAuthor.Text = authors(0).ToString
        Else
            lblAuthor.Text = ""
        End If

    End Sub

    Private Sub CleanXL(pnlIndex As Integer)

        Dim pnl As Panel = CType(Me.Controls.Find("Pnl_XL" & pnlIndex, True)(0), Panel)
        pnl.Tag = Nothing

        Dim pct As PictureBox = CType(Me.Controls.Find("Pct_XL" & pnlIndex, True)(0), PictureBox)
        pct.Image = Nothing

        Dim lblSerie As Label = CType(Me.Controls.Find("Lbl_XLSerie" & pnlIndex, True)(0), Label)
        lblSerie.Text = ""

        Dim lblDescription As Label = CType(Me.Controls.Find("Lbl_XLDescription" & pnlIndex, True)(0), Label)
        lblDescription.Text = ""

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If m_currentIndex > 2 Then
            ShowExLibris(m_currentIndex - 1)
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If m_currentIndex < 2 Then
            ShowExLibris(3)
        ElseIf m_currentIndex < (m_xlList.Count - 2) Then
            ShowExLibris(m_currentIndex + 1)
        End If

    End Sub

    Private Sub ChkMiddleSize_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMiddleSize.CheckedChanged
        m_showMddleSizeXL = ChkMiddleSize.Checked
        LoadExLibris(m_currentId)
    End Sub

    Private Sub ChkLargeSize_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLargeSize.CheckedChanged
        m_showLargeSizeXL = ChkLargeSize.Checked
        LoadExLibris(m_currentId)
    End Sub

    Private Sub ChkVeryLargeSize_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVeryLargeSize.CheckedChanged
        m_showVeryLargeSizeXL = ChkVeryLargeSize.Checked
        LoadExLibris(m_currentId)
    End Sub

    Private Function EnterIn(xl As Goody, size1 As Long, size2 As Long)

        Return _
            (xl.GetWidth <= size1 AndAlso xl.GetHeight <= size2) _
            OrElse (xl.GetHeight <= size1 AndAlso xl.GetWidth <= size2)

    End Function

    Private Sub Pct_XL_MouseDown(sender As Object, e As MouseEventArgs) Handles Pct_XL1.MouseDown, Pct_XL2.MouseDown, Pct_XL3.MouseDown, Pct_XL4.MouseDown, Pct_XL5.MouseDown

        If e.Button = MouseButtons.Left Then
            Dim pnlIndex As Integer = Integer.Parse(CType(sender, PictureBox).Name.Substring(6, 1))
            Dim pnl As Panel = CType(Me.Controls.Find("Pnl_XL" & pnlIndex, True)(0), Panel)
            Dim xl As Goody = pnl.Tag

            SetParameter(NavParameters.PRM_GOODY_ID, xl.GetId)
            SetParameter(NavParameters.PRM_SERIE_ID, xl.GetSeries(0).GetId)
            ShowPage(GetType(UC_Serie).FullName)

        ElseIf e.Button = MouseButtons.Right Then
            FrmShowImage.ShowImage(CType(sender, PictureBox).Image)

        End If

    End Sub

    Private Function GetFirstGoodyIndexBySerieLetter(letter As String) As Integer

        Dim serie As Serie = Nothing
        Dim serieName As String
        Dim i As Integer = 0
        Dim index As Integer = -1
        Dim isNum As Boolean = False

        Dim start As String = letter.ToLower
        If start = "hs" Then
            start = "hors série"
        ElseIf start = "0" Then
            isNum = True
        End If


        While (i < m_xlList.Count) AndAlso (index = -1)

            serie = CType(m_xlList(i).GetSeries(0), Serie)
            serieName = serie.GetSortName.ToLower

            If isNum Then
                If IsNumeric(serieName.Substring(0, 1)) Then
                    index = i
                End If
            Else
                If serieName.StartsWith(start) Then
                    index = i
                End If
            End If

            i += 1

        End While

        Return IIf(index = -1, 0, index)

    End Function

    Private Sub Btn_Letter_Click(sender As Object, e As EventArgs) Handles Btn_Letter.Click

        ShowExLibris(GetFirstGoodyIndexBySerieLetter(CType(sender, Button).Text))

    End Sub
End Class

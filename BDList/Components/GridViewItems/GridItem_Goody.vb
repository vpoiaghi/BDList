Imports FrameworkPN
Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO

Public Class GridItem_Goody

    Private m_series As List(Of Serie) = Nothing
    Private m_firstImage As Image
    Private m_goody As Goody

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Overrides Sub Redraw()

        Dim svcGoody As New ServiceGoody
        m_goody = CType(m_value, Goody)

        With m_goody

            lbl_goodyName.Text = .ToString
            ToolTip1.SetToolTip(lbl_goodyName, .ToString)

            lbl_serieName.Text = GetSeriesNames(m_goody)
            ToolTip1.SetToolTip(lbl_serieName, lbl_serieName.Text)

            pct_inPossession.Image = PossessionStatesUtils.GetImage(.GetPossessionState().GetId)
            pct_withAutograph.Visible = ((.GetAutographs.Count > 0) OrElse (Not String.IsNullOrEmpty(.GetAutograph)))
            lbl_scanned.Visible = .IsScanned

            RedrawComments()
            RedrawCollectionInfo()
            RedrawEditors()
            RedrawParutionDate()
            RedrawNumber()
            RedrawAuthors()
            RedrawPictures(svcGoody.GetFiles(m_goody))

            Nb_Number.SendToBack()
            pct_withAutograph.SendToBack()
            pct_inPossession.SendToBack()

        End With

    End Sub

    Private Sub RedrawEditors()

        Dim editors As List(Of IdBObject) = m_goody.GetEditors
        If (editors Is Nothing) OrElse (editors.Count = 0) Then
            lbl_editor.Text = ""
        Else
            Dim s As String = editors(0).ToString()
            For i As Integer = 1 To editors.Count - 1
                s &= ", " & editors(i).ToString()
            Next
            lbl_editor.Text = s
        End If

    End Sub

    Private Sub RedrawParutionDate()

        Dim parutionDate As Date? = m_goody.GetParutionDate
        If parutionDate Is Nothing Then
            lbl_parutionDate.Text = ""
            lbl_parutionDate.BackColor = Color.Transparent
        Else
            lbl_parutionDate.Text = Format(parutionDate, "dd/MM/yyyy")

            If parutionDate >= Today Then
                lbl_parutionDate.BackColor = Color.Yellow
            Else
                lbl_parutionDate.BackColor = Color.Transparent
            End If

        End If

    End Sub

    Private Sub RedrawNumber()

        Nb_Number.Number = m_goody.GetNumber
        Nb_Number.NumberType = m_goody.GetNumberType
        Nb_Number.MaxNumber = m_goody.GetNumberMax

        Nb_Number.Visible = Not String.IsNullOrEmpty(Nb_Number.Text.Trim)

    End Sub

    Private Sub RedrawCollectionInfo()

        Dim collectionInfo As String = Nothing

        With m_goody
            If .GetCollection IsNot Nothing Then

                collectionInfo = .GetCollection.ToString
                Dim numCollection As Integer? = .GetNumberInCollection

                If numCollection IsNot Nothing Then
                    collectionInfo &= " n°" & numCollection.Value
                End If

            End If
        End With

        If String.IsNullOrEmpty(collectionInfo) Then
            lbl_collection.Text = ""
            lbl_collection.Visible = False
        Else
            lbl_collection.Text = collectionInfo
            lbl_collection.Visible = True
        End If

    End Sub

    Private Sub RedrawComments()

        Dim comments As String = Nothing

        With m_goody
            comments = "(" & .GetId.ToString & ") " & Trim(.GetComments)
        End With

        If String.IsNullOrEmpty(comments) Then
            lbl_comments.Text = ""
            lbl_comments.Visible = False
            ToolTip1.SetToolTip(lbl_comments, Nothing)
        Else
            lbl_comments.Text = comments
            lbl_comments.Visible = True
            ToolTip1.SetToolTip(lbl_comments, comments)
        End If

    End Sub

    Private Sub RedrawAuthors()

        Dim authorsList As List(Of IdBObject) = m_goody.GetAuthors
        Dim authors As String = ""

        If authorsList.Count > 0 Then
            For Each a As Author In authorsList
                authors &= "; " & a.ToString
            Next
            lbl_authors.Text = authors.Substring(2)
            lbl_authors.Visible = True
        Else
            lbl_authors.Text = ""
            lbl_authors.Visible = False
        End If

    End Sub

    Private Sub RedrawPictures(files As List(Of IFile))

        If files.Count > 0 Then
            m_firstImage = ImageUtils.LoadImage(files(0))
            pct_firstImage.Image = m_firstImage
        Else
            pct_firstImage.Image = Nothing
        End If

        If files.Count > 1 Then
            pct_minSecondImage.Image = ImageUtils.LoadImage(files(1).GetFullName)
            pct_minSecondImage.Visible = True
        Else
            pct_minSecondImage.Image = Nothing
            pct_minSecondImage.Visible = False
        End If

        If files.Count > 2 Then
            pct_minThirdImage.Image = ImageUtils.LoadImage(files(2).GetFullName)
            pct_minThirdImage.Visible = True
        Else
            pct_minThirdImage.Image = Nothing
            pct_minThirdImage.Visible = False
        End If

        If files.Count > 3 Then
            pct_minFourthImage.Image = ImageUtils.LoadImage(files(3).GetFullName)
            pct_minFourthImage.Visible = True
        Else
            pct_minFourthImage.Image = Nothing
            pct_minFourthImage.Visible = False
        End If

    End Sub

    Private Sub btn_show_Click(sender As Object, e As EventArgs)

        Dim eventArgs As New GridItemActionEventArgs(GridItemActionEventArgs.listItemActions.Show)
        eventArgs.AddParameter(NavParameters.PRM_GOODY_ID, CType(m_value, Goody).GetId)

        SendActionEvent(eventArgs)

    End Sub

    Private Sub pct_minSecondImage_MouseEnter(sender As Object, e As EventArgs) Handles pct_minSecondImage.MouseEnter
        If pct_minSecondImage.Image IsNot Nothing Then
            pct_firstImage.Image = pct_minSecondImage.Image
        End If
    End Sub

    Private Sub pct_minSecondImage_MouseLeave(sender As Object, e As EventArgs) Handles pct_minSecondImage.MouseLeave
        If pct_minSecondImage.Image IsNot Nothing Then
            pct_firstImage.Image = m_firstImage
        End If
    End Sub

    Private Sub pct_minThirdImage_MouseEnter(sender As Object, e As EventArgs) Handles pct_minThirdImage.MouseEnter
        If pct_minThirdImage.Image IsNot Nothing Then
            pct_firstImage.Image = pct_minThirdImage.Image
        End If
    End Sub

    Private Sub pct_minThirdImage_MouseLeave(sender As Object, e As EventArgs) Handles pct_minThirdImage.MouseLeave
        If pct_minThirdImage.Image IsNot Nothing Then
            pct_firstImage.Image = m_firstImage
        End If
    End Sub

    Private Sub pct_minFourth_MouseEnter(sender As Object, e As EventArgs) Handles pct_minFourthImage.MouseEnter
        If pct_minFourthImage.Image IsNot Nothing Then
            pct_firstImage.Image = pct_minFourthImage.Image
        End If
    End Sub

    Private Sub pct_minFourth_MouseLeave(sender As Object, e As EventArgs) Handles pct_minFourthImage.MouseLeave
        If pct_minFourthImage.Image IsNot Nothing Then
            pct_firstImage.Image = m_firstImage
        End If
    End Sub

    Public Overrides Sub ModifyItem()

        Dim goody As Goody = CType(m_value, Goody)
        Dim serie As Serie = CType(goody.GetSeries(0), Serie)

        Dim modifiedGoody As ModifiedItem = FrmWriteGoody.CreateOrEdit(Me.ParentForm, goody, serie)

        If modifiedGoody IsNot Nothing Then

            m_value = modifiedGoody.GetItem
            Redraw()

            Dim eventArgs As New GridItemActionEventArgs(GridItemActionEventArgs.listItemActions.Modify)
            eventArgs.AddParameter(NavParameters.PRM_GOODY_ID, CType(m_value, Goody).GetId)

            SendActionEvent(eventArgs)

        End If

    End Sub

    Public Overrides Sub ShowItem()

        Dim goody As Goody = CType(m_value, Goody)

        FrmPagesManager.SetParameter(NavParameters.PRM_GOODY_ID, m_goody.GetId)
        FrmPagesManager.ShowPage(GetType(UC_ExLibris).FullName)

    End Sub

    Private Sub pct_firstImage_MouseDown(sender As Object, e As MouseEventArgs) Handles pct_firstImage.MouseDown
        If e.Button = MouseButtons.Right Then
            FrmShowImage.ShowImage(CType(sender, PictureBox).Image)
        End If
    End Sub

    Private Sub pct_minSecondImage_MouseDown(sender As Object, e As MouseEventArgs) Handles pct_minSecondImage.MouseDown
        If e.Button = MouseButtons.Right Then
            FrmShowImage.ShowImage(CType(sender, PictureBox).Image)
        End If
    End Sub

    Private Sub pct_minThirdImage_MouseDown(sender As Object, e As MouseEventArgs) Handles pct_minThirdImage.MouseDown
        If e.Button = MouseButtons.Right Then
            FrmShowImage.ShowImage(CType(sender, PictureBox).Image)
        End If
    End Sub

    Private Sub pct_minFourthImage_MouseDown(sender As Object, e As MouseEventArgs) Handles pct_minFourthImage.MouseDown
        If e.Button = MouseButtons.Right Then
            FrmShowImage.ShowImage(CType(sender, PictureBox).Image)
        End If
    End Sub


    Private Sub lbl_serieName_MouseUp(sender As Object, e As MouseEventArgs) Handles lbl_serieName.MouseUp

        If (Me.IsSelected) AndAlso (e.Button = MouseButtons.Left) Then

            Dim serie As Serie = Nothing

            If m_series.Count = 1 Then
                serie = m_series(0)
            Else
                Dim str As String = ""
                Dim g As Graphics = lbl_serieName.CreateGraphics
                Dim measure As SizeF

                For Each s As Serie In m_series

                    str &= s.ToString
                    measure = g.MeasureString(str, lbl_serieName.Font)

                    If (e.X <= measure.Width) Then
                        serie = s
                        Exit For
                    Else
                        str &= " / "
                    End If
                Next
            End If

            FrmPagesManager.SetParameter(NavParameters.PRM_SERIE_ID, serie.GetId)
            FrmPagesManager.ShowPage(GetType(UC_Serie).FullName)

        End If

    End Sub

    Private Function GetSeriesNames(goody As Goody) As String

        Dim series As List(Of IdBObject) = goody.GetSeries
        Dim seriesNames As String = ""

        m_series = New List(Of Serie)

        For Each s As Serie In series
            seriesNames &= " / " & s.ToString
            m_series.Add(s)
        Next

        If series.Count > 0 Then
            seriesNames = seriesNames.Substring(3)
        End If

        Return seriesNames

    End Function

End Class

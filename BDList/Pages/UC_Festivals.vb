Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports FrameworkPN

Public Class UC_Festivals

    Private m_svcInSigning As New ServiceInSigning
    Private m_svcAuthors As New ServiceAuthor()
    Private m_svcFestivals As New ServiceFestival()
    Private m_festival As Festival


    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()
    End Sub

    Protected Overrides Sub Activate()
        RefreshData()
    End Sub

    Private Sub RefreshData(Optional festival As Festival = Nothing)

        m_festival = festival

        Lst_festivals.Items.Clear()
        For Each f As Festival In m_svcFestivals.GetAll()
            Lst_festivals.Items.Add(f)
        Next

        If Lst_festivals.Items.Count > 0 Then
            If (m_festival Is Nothing) Then
                Lst_festivals.SelectedIndex = 0
            Else
                Lst_festivals.SelectedItem = festival
            End If
        End If

    End Sub

    Private Sub RefreshFestival(festival As Festival)

        Btn_editFestival.Enabled = True
        Lbl_festivalDates.Text = festival.GetDatesString()
        InitAuthorsList(festival)

    End Sub

    Private Sub CleanFestival()

        Btn_editFestival.Enabled = False

        Lbl_festivalDates.Text = ""
        LVw_InSigning.Clear()

    End Sub


    Private Sub btn_addFestival_Click(sender As Object, e As EventArgs) Handles Btn_addFestival.Click

        Dim newFestival As ModifiedItem = FrmWriteFestival.CreateOrEdit(Me.ParentForm, Nothing)

        If newFestival IsNot Nothing Then
            RefreshData(newFestival.GetItem)
        End If

    End Sub

    Private Sub btn_editFestival_Click(sender As Object, e As EventArgs) Handles Btn_editFestival.Click

        Dim modifiedFestival As ModifiedItem = FrmWriteFestival.CreateOrEdit(Me.ParentForm, m_festival)

        If modifiedFestival IsNot Nothing Then
            RefreshData(modifiedFestival.GetItem)
        End If


    End Sub

    Private Sub lst_festivals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_festivals.SelectedIndexChanged

        m_festival = CType(sender, ListBox).SelectedItem

        If m_festival Is Nothing Then
            CleanFestival()
        Else
            RefreshFestival(m_festival)
        End If

    End Sub

    Private Sub Btn_AddInSigning_Click(sender As Object, e As EventArgs) Handles Btn_AddInSigning.Click

        Dim result As FrmSelectItems.FrmSelectItemsResult = FrmSelectItems.GetSelectedItems(m_svcAuthors.GetAll, Nothing, Me.ParentForm)

        If (result.DlgResult = DialogResult.OK) AndAlso (result.SelectedItems IsNot Nothing) Then
            For Each author As Author In result.SelectedItems

                Dim inSingning As New InSigning
                inSingning.SetAuthor(author)
                inSingning.SetFestival(m_festival)

                AddAuthorInSigningToList(inSingning)

            Next
        End If

    End Sub

    Private Sub InitAuthorsList(festival As Festival)

        LVw_InSigning.Items.Clear()

        For Each i As InSigning In m_svcInSigning.GetByFestival(festival)
            AddAuthorInSigningToList(i)
        Next

    End Sub

    Private Sub AddAuthorInSigningToList(authorInSigning As InSigning)

        With LVw_InSigning.Items.Add(authorInSigning.GetAuthor().ToString)

            If authorInSigning.GetEditor Is Nothing Then
                .SubItems.Add("")
            Else
                .SubItems.Add(authorInSigning.GetEditor.ToString)
            End If

            .SubItems.Add(Format(authorInSigning.GetDay, "dd/MM/yyyy"))
            .SubItems.Add(Format(authorInSigning.GetStartTime, "hh:mm"))
            .SubItems.Add(Format(authorInSigning.GetEndTime, "hh:mm"))
            .Tag = authorInSigning

        End With

    End Sub

    Private Sub LVw_InSigning_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVw_InSigning.SelectedIndexChanged

        Btn_SetDefaultTime.Enabled = (LVw_InSigning.SelectedItems.Count = 1)

    End Sub

    Private Sub Btn_SetDefaultTime_Click(sender As Object, e As EventArgs) Handles Btn_SetDefaultTime.Click

        Dim author As Author

        If LVw_InSigning.SelectedItems.Count = 1 Then

            author = CType(LVw_InSigning.SelectedItems.Item(0).Tag, InSigning).GetAuthor

            Dim dte1 As Date? = m_festival.GetBeginDate()
            Dim dte2 As Date? = m_festival.GetEndDate()

            If (dte1 IsNot Nothing) AndAlso (dte2 IsNot Nothing) Then

                Dim i As Integer = 0
                While i < LVw_InSigning.Items.Count

                    If CType(LVw_InSigning.Items(i).Tag, InSigning).GetAuthor.GetId = author.GetId Then
                        LVw_InSigning.Items.RemoveAt(i)
                    Else
                        i += 1
                    End If

                End While

                While dte1 <= dte2

                    Dim inSingning As New InSigning
                    inSingning.SetAuthor(author)
                    inSingning.SetDay(dte1)
                    inSingning.SetFestival(m_festival)

                    AddAuthorInSigningToList(inSingning)

                    dte1 = dte1.Value.AddDays(1)

                End While

            End If

        End If

    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click


    End Sub
End Class

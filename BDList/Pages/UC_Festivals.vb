Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports FrameworkPN

Public Class UC_Festivals

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

        Dim svcInSigning As New ServiceInSigning

        For Each i As InSigning In svcInSigning.GetByFestival(festival)
            With LVw_InSigning.Items.Add(i.GetAuthor().ToString)

                If i.GetEditor Is Nothing Then
                    .SubItems.Add("")
                Else
                    .SubItems.Add(i.GetEditor.ToString)
                End If

                .SubItems.Add(Format(i.GetDay, "dd/MM/yyyy"))
                .SubItems.Add(Format(i.GetStartTime, "hh:mm"))
                .SubItems.Add(Format(i.GetEndTime, "hh:mm"))

            End With
        Next

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

    End Sub

End Class

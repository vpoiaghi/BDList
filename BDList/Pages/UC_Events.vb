Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports FrameworkPN

Public Class UC_Events

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()
    End Sub

    Protected Overrides Sub Activate()

        RefreshEventsList()

    End Sub

    Private Sub RefreshEventsList()

        lst_events.Items.Clear()

        Dim svcEvents = New ServiceRecallEvent
        Dim eventsList As List(Of IdBObject) = svcEvents.GetAll

        For Each evt As RecallEvent In eventsList
            RefreshEvent(Nothing, evt)
        Next

        btn_editEvent.Enabled = False
        btn_removeEvent.Enabled = False

    End Sub

    Private Sub RefreshEvent(item As ListViewItem, evt As RecallEvent)

        If item Is Nothing Then
            item = lst_events.Items.Add("")
            For c As Integer = 2 To lst_events.Columns.Count
                item.SubItems.Add("")
            Next
        End If

        With item
            .Text = Format(evt.GetStartDate, "dd/MM/yyyy")

            If evt.GetEndDate Is Nothing Then
                .SubItems(1).Text = ""
            Else
                .SubItems(1).Text = Format(evt.GetEndDate, "dd/MM/yyyy")
            End If

            .SubItems(2).Text = evt.GetName
            .SubItems(3).Text = evt.GetPlace
            .SubItems(4).Text = evt.GetComments
            .SubItems(5).Text = evt.GetState
            .SubItems(6).Text = evt.GetReminderDays
            .SubItems(7).Text = evt.GetPersistenceDays
            .Tag = evt
        End With

    End Sub

    Private Sub btn_addEvent_Click(sender As Object, e As EventArgs) Handles btn_addEvent.Click

        Dim newEvent As ModifiedItem = FrmWriteEvent.CreateOrEdit(Me.ParentForm, Nothing)

        If (newEvent IsNot Nothing) AndAlso (newEvent.GetItem IsNot Nothing) Then
            RefreshEvent(Nothing, newEvent.GetItem)
        End If

    End Sub

    Private Sub btn_editEvent_Click(sender As Object, e As EventArgs) Handles btn_editEvent.Click

        Dim evt As RecallEvent = lst_events.SelectedItems(0).Tag

        Dim newEvent As ModifiedItem = FrmWriteEvent.CreateOrEdit(Me.ParentForm, evt)

        If newEvent IsNot Nothing Then
            RefreshEvent(lst_events.SelectedItems(0), newEvent.GetItem)
        End If

    End Sub

    Private Sub btn_removeEvent_Click(sender As Object, e As EventArgs) Handles btn_removeEvent.Click

        Dim evt As RecallEvent = lst_events.SelectedItems(0).Tag

        If evt IsNot Nothing Then

            If MsgBox("Etes-vous sure de vouloir supprimer l'évènement """ & evt.GetName & """ ?", MsgBoxStyle.YesNo, "Supprimer un évènement...") = MsgBoxResult.Yes Then
                Dim svcEvents As New ServiceRecallEvent
                svcEvents.Delete(evt)
                RefreshEventsList()
            End If

        End If

    End Sub

    Private Sub lst_events_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_events.SelectedIndexChanged

        If lst_events.SelectedItems.Count = 1 Then
            btn_editEvent.Enabled = True
            btn_removeEvent.Enabled = True
        Else
            btn_editEvent.Enabled = False
            btn_removeEvent.Enabled = False
        End If

    End Sub

End Class

Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class FrmWriteEvent

    Private Shared m_svcEvent As New ServiceRecallEvent

    Private m_recallEvent As RecallEvent
    Private m_modifiedEvent As ModifiedItem

    Private Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub New(ByRef eventToEdit As ModifiedItem)
        Me.New()

        If (eventToEdit Is Nothing) OrElse (eventToEdit.GetItem Is Nothing) Then
            Throw New ArgumentNullException()
        End If

        m_recallEvent = eventToEdit.GetItem
        m_modifiedEvent = eventToEdit

    End Sub

    Private Function GetModifiedEvent() As ModifiedItem
        Return m_modifiedEvent
    End Function

    Public Shared Function CreateOrEdit(owner As Form, recallEvent As RecallEvent) As ModifiedItem

        If recallEvent Is Nothing Then
            recallEvent = CType(m_svcEvent.GetNew, RecallEvent)
        End If

        Dim frm As New FrmWriteEvent(New ModifiedItem(recallEvent))
        frm.ShowDialog(owner)
        frm.Dispose()

        Dim modifiedEvent As ModifiedItem = frm.GetModifiedEvent()

        If (modifiedEvent IsNot Nothing) Then
            m_svcEvent.InsertOrUpdate(modifiedEvent.GetItem)
        End If

        Return modifiedEvent

    End Function

    Private Sub FrmWriteEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If m_recallEvent.GetId IsNot Nothing Then
            Me.Text = "Evènement ref. n°" & m_recallEvent.GetId
        Else
            Me.Text = "Nouvel évènement"
        End If

        pct_event.Clear()
        pct_event.SetFileNameBuilder(New EventFileNameBuilder(m_recallEvent))

        If m_recallEvent.GetId Is Nothing Then
            pct_event.Enabled = False
        Else
            pct_event.Enabled = True
            pct_event.AddRange(m_svcEvent.GetFiles(m_recallEvent))
        End If

        txt_startDate.SetDate(m_recallEvent.GetStartDate)
        txt_endDate.SetDate(m_recallEvent.GetEndDate)
        txt_name.Text = m_recallEvent.GetName
        txt_place.Text = m_recallEvent.GetPlace
        txt_comments.Text = m_recallEvent.GetComments

        If m_recallEvent.GetReminderDays IsNot Nothing Then
            txt_reminderDays.Text = m_recallEvent.GetReminderDays
        End If

        If m_recallEvent.GetPersistenceDays IsNot Nothing Then
            txt_persistenceDays.Text = m_recallEvent.GetPersistenceDays
        End If

        cmb_state.Items.Clear()
        cmb_state.Items.Add("Non traité")
        cmb_state.Items.Add("Traité")
        cmb_state.SelectedIndex = m_recallEvent.GetState

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If ValidateBeforeSave() Then

            With m_recallEvent

                .SetStartDate(txt_startDate().GetDate)
                .SetEndDate(txt_endDate().GetDate)
                .SetName(GetStringValue(txt_name))
                .SetPlace(GetStringValue(txt_place))
                .SetComments(GetStringValue(txt_comments))
                .SetState(cmb_state.SelectedIndex)
                .SetReminderDays(GetIntegerValue(txt_reminderDays))
                .SetPersistenceDays(GetIntegerValue(txt_persistenceDays))

                pct_event.SavePictures()

            End With

            m_modifiedEvent.AddChangedFieldName("bidon")

            Me.Close()

        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

        m_modifiedEvent = Nothing
        Me.Close()

    End Sub

    Private Function ValidateBeforeSave() As Boolean

        Dim allowSave As Boolean = False
        Dim errMsg As String = Nothing

        Dim startDate As String = txt_startDate.Text.Trim
        Dim endDate As String = txt_endDate.Text.Trim
        Dim name As String = txt_name.Text.Trim
        Dim reminderDays As String = txt_reminderDays.Text.Trim
        Dim persistenceDays As String = txt_persistenceDays.Text.Trim


        If (String.IsNullOrEmpty(startDate)) Then
            errMsg = "La date de début doit être renseignée."
        ElseIf Not IsDate(startDate) Then
            errMsg = "Le format de la date de début est invalide."
        End If

        If (Not String.IsNullOrEmpty(endDate)) AndAlso (Not IsDate(endDate)) Then
            errMsg = "Le format de la date de fin est invalide."
        End If

        If (String.IsNullOrEmpty(name)) Then
            errMsg = "Le nom doit être renseigné."
        End If

        If (String.IsNullOrEmpty(reminderDays)) Then
            errMsg = "Le champs Rappel doit être renseigné."
        Else
            Dim fieldError As Boolean = False

            If (Not IsNumeric(reminderDays)) Then
                fieldError = True
            Else
                Dim n As Integer
                fieldError = (Not Integer.TryParse(reminderDays, n)) OrElse (n < 0)
            End If

            If fieldError Then
                errMsg = "Le champs Rappel doit être un nombre entier supérieur ou égal à zéro."
            End If

        End If

        If (String.IsNullOrEmpty(persistenceDays)) Then
            errMsg = "Le champs Persistance doit être renseigné."
        Else
            Dim fieldError As Boolean = False

            If (Not IsNumeric(persistenceDays)) Then
                fieldError = True
            Else
                Dim n As Integer
                fieldError = (Not Integer.TryParse(persistenceDays, n)) OrElse (n < 0)
            End If

            If fieldError Then
                errMsg = "Le champs Persistance doit être un nombre entier supérieur ou égal à zéro."
            End If

        End If

        If errMsg IsNot Nothing Then
            Call MsgBox(errMsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Informations incomplètes ou erronées...")
        Else
            If m_recallEvent Is Nothing Then
                m_recallEvent = m_svcEvent.GetNew
            End If
            allowSave = True
        End If

        Return allowSave

    End Function

    Private Function GetStringValue(ctrl As Control) As String

        Dim value As String = ctrl.Text.Trim

        If String.IsNullOrEmpty(value) Then
            value = Nothing
        End If

        Return value

    End Function

    Private Function GetIntegerValue(ctrl As Control) As Nullable(Of Integer)

        Dim value As String = ctrl.Text.Trim
        Dim result As Nullable(Of Integer) = Nothing

        If Not String.IsNullOrEmpty(value) Then
            result = Integer.Parse(value)
        End If

        Return result

    End Function

End Class
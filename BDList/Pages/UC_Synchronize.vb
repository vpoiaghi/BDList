Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports FrameworkPN

Public Class UC_Synchronize

    Private WithEvents m_synchroniseWithSQLiteBase As SynchroniseWithSQLiteBase
    Private m_syncCtrlResults As List(Of SyncCtrlResult)

    Private WithEvents m_syncControler As SyncControler

    Private m_canSyncToPhone As Boolean = False
    Private m_canSyncTolocal As Boolean = False

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()

        SetCanSyncToPhone(False)
        SetCanSyncTolocal(False)
        EnabledSyncToPhone(False)
        EnabledSyncToLocal(False)

    End Sub

    Protected Overrides Sub Activate()
        RefreshLabels()
    End Sub

    Private Sub btn_synchronize_Click(sender As Object, e As EventArgs) Handles btn_synchronize.Click
        StartSync(False)
    End Sub

    Private Sub btn_synchronizeAll_Click(sender As Object, e As EventArgs) Handles btn_synchronizeAll.Click

        If MsgBox("Etes-vous sure de vouloir réinitialiser le téléphone ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Tout synchroniser...") = MsgBoxResult.Yes Then
            StartSync(True)
        End If

    End Sub

    Private Sub StartSync(synchroniseAll As Boolean)

        ListBox1.Items.Clear()
        ListBox1.Refresh()
        ListBox2.Items.Clear()
        ListBox2.Refresh()
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
        DataGridView2.Rows.Clear()
        DataGridView2.Refresh()

        ProgressBar1.Visible = True
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        ProgressBar1.Refresh()

        lbl_messages.Text = "Synchronisation en cours.."
        lbl_messages.Refresh()

        SetCanSyncToPhone(False)
        SetCanSyncTolocal(False)
        EnabledSyncToPhone(False)
        EnabledSyncToLocal(False)

        m_synchroniseWithSQLiteBase = New SynchroniseWithSQLiteBase
        Dim result As SynchroniseResults = m_synchroniseWithSQLiteBase.Synchronise(synchroniseAll)

        For Each info As String In result.GetPhoneInfos
            ListBox1.Items.Add(info)
        Next

        ListBox1.Items.Add("")

        For Each info As String In result.GetLocalInfos
            ListBox1.Items.Add(info)
        Next

        ListBox1.Items.Add("")

        For Each action As SynchroniseAction In result.GetActions
            ListBox1.Items.Add(action)
        Next

        RefreshLabels()

        m_synchroniseWithSQLiteBase = Nothing

    End Sub

    Private Sub RefreshLabels()

        lbl_messages.Text = ""

        ShowLastSyncDate()

    End Sub

    Private Sub ShowLastSyncDate()

        Dim svcPhoneParameters As New ServicePhoneParameters
        Dim d As DateTime? = svcPhoneParameters.GetAll(0).GetModifiedDateTime

        If d Is Nothing Then
            lbl_lastSync.Text = "Dernière synchronisation : inconnue"
        Else
            lbl_lastSync.Text = "Dernière synchronisation : " & Format(d, "dd/MM/yyyy HH:mm:ss")
        End If

    End Sub

    Private Sub btn_control_Click(sender As Object, e As EventArgs) Handles btn_control.Click

        ListBox2.Items.Clear()
        ListBox2.Refresh()
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
        DataGridView2.Rows.Clear()
        DataGridView2.Refresh()

        ProgressBar1.Visible = True
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        ProgressBar1.Refresh()

        lbl_messages.Text = "Contrôle en cours.."
        lbl_messages.Refresh()

        m_syncControler = New SyncControler
        m_syncCtrlResults = m_syncControler.StartControl()

        SetCanSyncToPhone(False)
        SetCanSyncTolocal(False)
        EnabledSyncToPhone(False)
        EnabledSyncToLocal(False)

        For Each result As SyncCtrlResult In m_syncCtrlResults

            Dim values() As Object = {result.Name, result.GetSamesCount, result.GetDifferentsCount, result.GetMissingsOnLocalCount, result.GetMissingsOnPhoneCount}
            DataGridView1.Rows.Add(values)

        Next

        m_syncControler = Nothing

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim ctrlResult As SyncCtrlResult = m_syncCtrlResults(e.RowIndex)

        Dim items As List(Of SyncCtrlItem) = Nothing

        SetCanSyncToPhone(False)
        SetCanSyncTolocal(False)

        Select Case e.ColumnIndex
            Case 1
                items = ctrlResult.GetSames
            Case 2
                items = ctrlResult.GetDifferents
                SetCanSyncToPhone(True)
                SetCanSyncTolocal(True)
            Case 3
                items = ctrlResult.GetMissingsOnLocal
                SetCanSyncTolocal(True)
            Case 4
                items = ctrlResult.GetMissingsOnPhone
                SetCanSyncToPhone(True)
        End Select

        ListBox2.Items.Clear()
        DataGridView2.Rows.Clear()

        If items IsNot Nothing Then
            For Each item As SyncCtrlItem In items
                ListBox2.Items.Add(item)
            Next
        End If

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

        DataGridView2.Rows.Clear()

        If ListBox2.SelectedItem IsNot Nothing Then

            Dim item As SyncCtrlItem = CType(ListBox2.SelectedItem, SyncCtrlItem)

            Dim phoneValue As String = ""
            Dim localValue As String = ""

            For Each a As SyncCtrlItem.Attribute In item.Attributes

                If a.PhoneValue Is Nothing Then
                    phoneValue = "NULL"
                Else
                    phoneValue = a.PhoneValue.ToString
                End If

                If a.LocalValue Is Nothing Then
                    localValue = "NULL"
                Else
                    localValue = a.LocalValue.ToString
                End If

                Dim rowValues() As Object = {a.Name, phoneValue, localValue}
                DataGridView2.Rows.Add(rowValues)

                If Not a.IsEqual Then
                    DataGridView2.Rows.Item(DataGridView2.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Beige
                End If

            Next

            EnabledSyncToPhone(True)
            EnabledSyncToLocal(True)

        Else
            EnabledSyncToPhone(False)
            EnabledSyncToLocal(False)
        End If

    End Sub

    Private Sub SetCanSyncToPhone(allowed As Boolean)

        m_canSyncToPhone = allowed

        If Not allowed Then
            btn_syncToPhone.Enabled = False
            btn_syncToPhone.Refresh()
        End If

    End Sub

    Private Sub SetCanSyncTolocal(allowed As Boolean)

        m_canSyncTolocal = allowed

        If Not allowed Then
            btn_syncToLocal.Enabled = False
            btn_syncToLocal.Refresh()
        End If

    End Sub

    Private Sub EnabledSyncToPhone(enabled As Boolean)

        btn_syncToPhone.Enabled = m_canSyncToPhone AndAlso enabled
        btn_syncToPhone.Refresh()

    End Sub

    Private Sub EnabledSyncToLocal(enabled As Boolean)

        btn_syncToLocal.Enabled = m_canSyncTolocal AndAlso enabled
        btn_syncToLocal.Refresh()

    End Sub

    Private Sub m_synchroniseWithSQLiteBase_SyncProgressEvent(stepIndex As Integer, stepsCount As Integer, text As String) Handles m_synchroniseWithSQLiteBase.SyncProgressEvent

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = stepsCount
        ProgressBar1.Value = stepIndex
        ProgressBar1.Refresh()

        If String.IsNullOrEmpty(text) Then
            lbl_messages.Text = "Synchronisation en cours..."
        Else
            lbl_messages.Text = "Synchronisation en cours : " & text
        End If

        lbl_messages.Refresh

    End Sub

    Private Sub m_synchroniseWithSQLiteBase_SyncEndedEvent(syncDuration As TimeSpan) Handles m_synchroniseWithSQLiteBase.SyncEndedEvent

        ProgressBar1.Value = ProgressBar1.Maximum
        ProgressBar1.Refresh()

        lbl_messages.Text = "Synchronisation terminée..."
        lbl_messages.Refresh()

        MessageBox.Show("Mise à jour terminée en " & Format(syncDuration.Hours, "00") & ":" & Format(syncDuration.Minutes, "00") & ":" & Format(syncDuration.Seconds, "00"))

        ProgressBar1.Visible = False
        lbl_messages.Text = ""

    End Sub

    Private Sub m_syncControler_CtrlProgressEvent(stepIndex As Integer, stepsCount As Integer, text As String) Handles m_syncControler.CtrlProgressEvent

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = stepsCount
        ProgressBar1.Value = stepIndex
        ProgressBar1.Refresh()

        If String.IsNullOrEmpty(text) Then
            lbl_messages.Text = "Contrôle en cours..."
        Else
            lbl_messages.Text = "Contrôle en cours : " & text
        End If

        lbl_messages.Refresh()

    End Sub

    Private Sub m_syncControler_CtrlEndedEvent(ctrlDuration As TimeSpan) Handles m_syncControler.CtrlEndedEvent

        ProgressBar1.Value = ProgressBar1.Maximum
        ProgressBar1.Refresh()

        lbl_messages.Text = "Contrôle terminé..."
        lbl_messages.Refresh()

        MessageBox.Show("Contrôle terminé en " & Format(ctrlDuration.Hours, "00") & ":" & Format(ctrlDuration.Minutes, "00") & ":" & Format(ctrlDuration.Seconds, "00"))

        ProgressBar1.Visible = False
        lbl_messages.Text = ""

    End Sub

End Class

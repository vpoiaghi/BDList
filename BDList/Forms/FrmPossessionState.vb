Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.Constantes

Public Class FrmPossessionState

    Private m_possessionState As PossessionStates = PossessionStates.Wanted

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub FrmPossessionState_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        AddStates()
    End Sub

    Public Property State As PossessionStates
        Get
            Return m_possessionState
        End Get
        Set(value As PossessionStates)
            If m_possessionState <> value Then
                m_possessionState = value
                RefreshStates()
            End If
        End Set
    End Property

    Private Sub AddStates()

        flp_buttonsGrid.Controls.Clear()

        For Each ps As PossessionStates In [Enum].GetValues(GetType(PossessionStates))

            Dim btn As New Button
            btn.Image = PossessionStatesUtils.GetImage(ps)
            btn.Size = New Size(60, 60)
            btn.Visible = True
            btn.Tag = ps

            AddHandler btn.MouseUp, AddressOf btn_possessionState_MouseUp

            flp_buttonsGrid.Controls.Add(btn)

        Next

        RefreshStates()

    End Sub

    Private Sub RefreshStates()

        For Each btn As Button In flp_buttonsGrid.Controls

            If btn.Tag = m_possessionState Then
                btn.BackColor = Color.CornflowerBlue
            Else
                btn.BackColor = SystemColors.Control
            End If

        Next

    End Sub

    Private Sub btn_ok_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_ok.MouseUp
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_cancel_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_cancel.MouseUp
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_possessionState_MouseUp(sender As Object, e As MouseEventArgs)

        m_possessionState = CType(sender, Button).Tag
        RefreshStates()

    End Sub

    Public Shared Function GetPossessionState(defaultState As BoPossessionState, Optional owner As IWin32Window = Nothing) As BoPossessionState

        Dim result As BoPossessionState = Nothing
        Dim selectedState As PossessionStates = PossessionStates.Wanted

        If defaultState IsNot Nothing Then
            selectedState = GetPossessionState(defaultState.GetId)
        Else
            selectedState = GetPossessionState(PossessionStates.Wanted)
        End If

        If (defaultState IsNot Nothing) AndAlso (selectedState = defaultState.GetId) Then
            result = defaultState
        Else
            Dim svcPossessionState As New ServicePossessionState
            result = CType(svcPossessionState.GetById(CType(selectedState, Long?)), BoPossessionState)
        End If

        Return result

    End Function

    Public Shared Function GetPossessionState(defaultState As PossessionStates, Optional owner As IWin32Window = Nothing) As PossessionStates

        Dim result As PossessionStates = defaultState

        Dim frm As New FrmPossessionState
        frm.State = defaultState
        frm.ShowDialog(owner)

        If frm.DialogResult = DialogResult.OK Then
            result = frm.State
        End If

        Return result

    End Function


End Class
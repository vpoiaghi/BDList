Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class FrmEditionOrGoody

    Public Enum ItemType
        NewEdition
        KnownEdition
        NewGoody
        KnownGoody
        None
    End Enum


    Private result As ItemType = ItemType.None

    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterParent
        Me.DialogResult = DialogResult.Cancel

    End Sub

    Private Sub Btn_NewEdition_Click(sender As Object, e As EventArgs) Handles Btn_NewEdition.Click
        Me.DialogResult = DialogResult.OK
        Me.result = ItemType.NewEdition
        Me.Hide()
    End Sub

    Private Sub Btn_Edition_Click(sender As Object, e As EventArgs) Handles Btn_Edition.Click
        Me.DialogResult = DialogResult.OK
        Me.result = ItemType.KnownEdition
        Me.Hide()
    End Sub

    Private Sub Btn_NewGoody_Click(sender As Object, e As EventArgs) Handles Btn_NewGoody.Click
        Me.DialogResult = DialogResult.OK
        Me.result = ItemType.NewGoody
        Me.Hide()
    End Sub

    Private Sub Btn_Goody_Click(sender As Object, e As EventArgs) Handles Btn_Goody.Click
        Me.DialogResult = DialogResult.OK
        Me.result = ItemType.KnownGoody
        Me.Hide()
    End Sub

    Public Shared Function GetEditionOrGoody(owner As IWin32Window) As ItemType

        Dim result As ItemType = ItemType.None

        Dim frm As New FrmEditionOrGoody
        If frm.ShowDialog(owner) = DialogResult.OK Then
            result = frm.result
        End If

        Return result

    End Function

End Class
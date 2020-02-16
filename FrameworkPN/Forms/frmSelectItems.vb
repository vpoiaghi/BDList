Public Class FrmSelectItems

    Public Structure FrmSelectItemsResult
        Public SelectedItems As Collections.IList
        Public DlgResult As DialogResult
    End Structure


    Private m_fullItemsList As Collections.IList

    Private Sub New()

        InitializeComponent()

    End Sub

    Protected Overrides Sub Finalize()

        m_fullItemsList = Nothing
        MyBase.Finalize()

    End Sub

    Public Shared Function GetSelectedItems(itemsList As Collections.IList, selectedItemsList As Collections.IList, owner As IWin32Window) As FrmSelectItemsResult

        Dim result As FrmSelectItemsResult
        result.SelectedItems = Nothing


        Dim frm As New FrmSelectItems
        frm.SetItems(itemsList)
        frm.setSelectedItems(selectedItemsList)

        result.DlgResult = frm.ShowDialog(owner)

        If result.DlgResult = DialogResult.OK Then
            result.SelectedItems = frm.Lst_SelectionList.Items
        End If

        Return result

    End Function

    Private Sub SetItems(itemsList As Collections.IList)
        m_fullItemsList = itemsList

        Lst_InitList.Items.Clear()

        If itemsList IsNot Nothing Then
            For Each item As Object In itemsList
                Lst_InitList.Items.Add(item)
            Next
        End If

    End Sub

    Private Sub setSelectedItems(selectedItemsList As Collections.IList)
        Lst_SelectionList.Items.Clear()

        If selectedItemsList IsNot Nothing Then
            For Each item As Object In selectedItemsList
                Lst_SelectionList.Items.Add(item)
            Next
        End If

    End Sub


    Private Sub Btn_Add_MouseUp(sender As Object, e As MouseEventArgs) Handles Btn_Add.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then
            AddSelectedItem()
        End If

    End Sub

    Private Sub Btn_Remove_MouseUp(sender As Object, e As MouseEventArgs) Handles Btn_Remove.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then
            RemoveSelectedItem()
        End If

    End Sub

    Private Sub Btn_OK_MouseUp(sender As Object, e As MouseEventArgs) Handles Btn_OK.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub Btn_Cancel_MouseUp(sender As Object, e As MouseEventArgs) Handles Btn_Cancel.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.DialogResult = DialogResult.Cancel
        End If

    End Sub

    Private Sub Txt_Filter_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Filter.KeyUp

        'If e.KeyCode = Keys.Enter Then

        Dim filteredList As New List(Of Object)
        Dim filter As String = "*" & Txt_Filter.Text.Trim.ToLower & "*"

        For Each o As Object In m_fullItemsList

            If o.ToString.ToLower Like filter Then
                filteredList.Add(o)
            End If

        Next

        Lst_InitList.Items.Clear()
        Lst_InitList.Items.AddRange(filteredList.ToArray)

        'End If

    End Sub

    Private Sub frmSelectItems_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        With Txt_Filter
            .TabIndex = 0
            .Focus()
        End With

    End Sub

    Private Sub AddSelectedItem()

        If Lst_InitList.SelectedItem IsNot Nothing Then

            If Not Lst_SelectionList.Items.Contains(Lst_InitList.SelectedItem) Then
                Lst_SelectionList.Items.Add(Lst_InitList.SelectedItem)
            Else
                MsgBox(Lst_InitList.SelectedItem.ToString & " est déjà dans la liste.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Doublons...")
            End If

        End If

    End Sub

    Private Sub RemoveSelectedItem()

        If Lst_SelectionList.SelectedItem IsNot Nothing Then
            Lst_SelectionList.Items.Remove(Lst_SelectionList.SelectedItem)
        End If

    End Sub

    Private Sub Lst_InitList_DoubleClick(sender As Object, e As EventArgs) Handles Lst_InitList.DoubleClick
        AddSelectedItem()
    End Sub

    Private Sub Lst_SelectionList_DoubleClick(sender As Object, e As EventArgs) Handles Lst_SelectionList.DoubleClick
        RemoveSelectedItem()
    End Sub

End Class
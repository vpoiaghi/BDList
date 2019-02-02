Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class UC_Editors

    Private ImgList As New ImageList
    Private svcEditor As New ServiceEditor

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)

        InitializeComponent()
        ImgList.ImageSize = New Size(255, 110)

    End Sub

    Protected Overrides Sub Activate()

        RefreshEditorsList()

    End Sub

    Private Sub RefreshEditorsList()

        lst_editors.Items.Clear()
        ImgList.Images.Clear()
        lst_editors.LargeImageList = ImgList

        Dim editorsList As List(Of IdBObject) = svcEditor.GetAll

        For Each editor As Editor In editorsList
            RefreshEditor(Nothing, editor)
        Next

        btn_editEditor.Enabled = False
        btn_removeEditor.Enabled = False

    End Sub

    Private Sub RefreshEditor(item As ListViewItem, editor As Editor)

        If item Is Nothing Then
            item = lst_editors.Items.Add("")
            For c As Integer = 2 To lst_editors.Columns.Count
                item.SubItems.Add("")
            Next
        End If

        ImgList.Images.Add(GetImage(editor))

        With item
            .Text = editor.ToString
            .ImageIndex = ImgList.Images.Count - 1
            .Tag = editor
        End With

    End Sub

    Private Function GetImage(editor As Editor) As Image

        Dim img As Image = Nothing
        Dim file As IFile = svcEditor.GetFile(editor)

        If file IsNot Nothing Then
            img = ImageUtils.LoadImage(file.GetFullName)
        End If

        If img Is Nothing Then
            img = My.Resources.editor_no_picture
        End If

        Dim g As Graphics = Graphics.FromImage(img)
        g.DrawRectangle(Pens.Black, 0, 0, img.Width - 1, img.Height - 1)
        g.Dispose()

        Return img

    End Function

    Private Sub btn_addEditor_Click(sender As Object, e As EventArgs) Handles btn_addEditor.Click

        Dim newEditor As ModifiedItem = FrmWriteEditor.CreateOrEdit(Me.ParentForm, Nothing)

        If (newEditor IsNot Nothing) AndAlso (newEditor.GetItem IsNot Nothing) Then
            RefreshEditor(Nothing, newEditor.GetItem)
        End If

    End Sub

    Private Sub btn_editEditor_Click(sender As Object, e As EventArgs) Handles btn_editEditor.Click

        Dim editor As Editor = lst_editors.SelectedItems(0).Tag

        Dim newEditor As ModifiedItem = FrmWriteEditor.CreateOrEdit(Me.ParentForm, editor)

        If newEditor IsNot Nothing Then
            RefreshEditor(lst_editors.SelectedItems(0), newEditor.GetItem)
        End If

    End Sub

    Private Sub btn_removeEditor_Click(sender As Object, e As EventArgs) Handles btn_removeEditor.Click

        Dim editor As Editor = lst_editors.SelectedItems(0).Tag

        If editor IsNot Nothing Then

            If MsgBox("Etes-vous sure de vouloir supprimer l'éditeur """ & editor.ToString & """ ?", MsgBoxStyle.YesNo, "Supprimer un éditeur...") = MsgBoxResult.Yes Then
                Dim svcEditor As New ServiceEditor
                svcEditor.Delete(editor)
                RefreshEditorsList()
            End If

        End If

    End Sub

    Private Sub lst_editors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_editors.SelectedIndexChanged

        If lst_editors.SelectedItems.Count = 1 Then
            btn_editEditor.Enabled = True
            btn_removeEditor.Enabled = True
        Else
            btn_editEditor.Enabled = False
            btn_removeEditor.Enabled = False
        End If

    End Sub

End Class

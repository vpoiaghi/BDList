Public Class SelectList
    Inherits Panel

    Private WithEvents m_list As ListBox
    Private WithEvents m_txtFilter As New TextBox
    Private m_tmpList1 As New ListBox
    Private m_tmpList2 As ListBox
    Private m_footPanel As Panel
    Private m_titleLabel As Label
    Private WithEvents m_editButton As Label
    Private WithEvents m_frm As Form

    Private fullItemsList As Collections.IList

    Public Event ItemsListChanged(sender As SelectList)

    Public Sub New()
        MyBase.New()

        With Me
            .BorderStyle = Windows.Forms.BorderStyle.None
        End With

        m_list = New ListBox
        With m_list
            .Parent = Me
            .Visible = True
            .IntegralHeight = False
            .Dock = DockStyle.Fill
            .BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        End With

        m_footPanel = New Panel
        With m_footPanel
            .Parent = Me
            .Visible = True
            .Dock = DockStyle.Top
            .Height = 19
            .BorderStyle = Windows.Forms.BorderStyle.None
        End With

        m_editButton = New Label
        With m_editButton
            .Parent = m_footPanel
            .Visible = True
            .Dock = DockStyle.Right
            .BackColor = Color.LightGray
            .Width = 50
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = "Mdifier"
        End With

        m_titleLabel = New Label
        With m_titleLabel
            .AutoSize = False
            .Parent = m_footPanel
            .Dock = DockStyle.Fill
            .Visible = True
            .TextAlign = ContentAlignment.MiddleLeft
        End With

    End Sub

    Public Property Title As String
        Get
            Return m_titleLabel.Text
        End Get
        Set(value As String)
            m_titleLabel.Text = value
        End Set
    End Property

    Public Sub SetValues(items As Collections.IList)

        m_tmpList1.Items.Clear()
        AddValues(items)

    End Sub

    Public Sub AddValues(items As Collections.IList)

        Dim array(items.Count - 1) As Object

        items.CopyTo(array, 0)
        fullItemsList = items

        m_tmpList1.Items.AddRange(array)

        m_txtFilter.Text = ""

    End Sub

    Public Sub Clear()
        m_list.Items.Clear()
        RaiseEvent ItemsListChanged(Me)
    End Sub

    Public Sub ClearValues()

        If Not fullItemsList Is Nothing Then
            fullItemsList.Clear()
        End If

        m_tmpList1.Items.Clear()

    End Sub

    Private Sub m_editButton_MouseUp(sender As Object, e As MouseEventArgs) Handles m_editButton.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then

            If IsNothing(m_frm) Then
                m_frm = BuildSelectForm()
            Else
                m_tmpList2.Items.Clear()
            End If

            For Each item As Object In m_list.Items
                m_tmpList2.Items.Add(item)
            Next

            m_frm.ShowDialog(Me.FindForm)

        End If

    End Sub

    Private Function BuildSelectForm() As Form

        Dim frm As New Form
        With frm
            .Width = 550
            .Height = 300
            .FormBorderStyle = FormBorderStyle.FixedDialog
            .StartPosition = FormStartPosition.CenterParent
        End With

        Dim pnlList1 As New Panel
        With pnlList1
            .Parent = frm
            .Visible = True
            .Dock = DockStyle.Left
            .BorderStyle = Windows.Forms.BorderStyle.None
            .Width = 225
        End With

        With m_tmpList1
            .Parent = pnlList1
            .Visible = True
            .Dock = DockStyle.Fill
            .IntegralHeight = False
            .BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        End With

        With m_txtFilter
            .Parent = pnlList1
            .Visible = True
            .Dock = DockStyle.Top
            .TabIndex = 0
            .Focus()
        End With

        m_tmpList2 = New ListBox
        With m_tmpList2
            .Parent = frm
            .Visible = True
            .Dock = DockStyle.Right
            .IntegralHeight = False
            .BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            .Width = 225
        End With

        Dim pnl As New Panel
        With pnl
            .Parent = frm
            .Visible = True
            .Dock = DockStyle.Fill
            .BorderStyle = Windows.Forms.BorderStyle.None
        End With

        Dim btnAdd As New Button
        With btnAdd
            .Parent = pnl
            .Dock = DockStyle.Top
            .FlatStyle = FlatStyle.Flat
            .Height = 50
            .Text = "Ajouter"
        End With
        AddHandler btnAdd.MouseUp, AddressOf btnAdd_MouseUp

        Dim btnRemove As New Button
        With btnRemove
            .Parent = pnl
            .Dock = DockStyle.Top
            .FlatStyle = FlatStyle.Flat
            .Height = 50
            .Text = "Suppr."
        End With
        AddHandler btnRemove.MouseUp, AddressOf btnremove_MouseUp

        Dim btnOk As New Button
        With btnOk
            .Parent = pnl
            .Dock = DockStyle.Bottom
            .FlatStyle = FlatStyle.Flat
            .Height = 50
            .Text = "Valider"
        End With
        AddHandler btnOk.MouseUp, AddressOf btnOk_MouseUp

        Dim btnCancel As New Button
        With btnCancel
            .Parent = pnl
            .Dock = DockStyle.Bottom
            .FlatStyle = FlatStyle.Flat
            .Height = 50
            .Text = "Annuler"
        End With
        AddHandler btnCancel.MouseUp, AddressOf btnCancel_MouseUp

        With m_txtFilter
            .TabIndex = 0
            .Focus()
        End With

        Return frm

    End Function

    Private Sub btnOk_MouseUp(sender As Object, e As MouseEventArgs)

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Clear()

            For Each item As Object In m_tmpList2.Items
                AddItem(item)
            Next

            CType(sender, Control).FindForm.Close()
        End If

    End Sub

    Private Sub btnCancel_MouseUp(sender As Object, e As MouseEventArgs)

        If e.Button = Windows.Forms.MouseButtons.Left Then
            CType(sender, Control).FindForm.Close()
        End If

    End Sub

    Private Sub btnAdd_MouseUp(sender As Object, e As MouseEventArgs)

        If e.Button = Windows.Forms.MouseButtons.Left AndAlso m_tmpList1.SelectedItem IsNot Nothing Then
            If Not m_tmpList2.Items.Contains(m_tmpList1.SelectedItem) Then
                m_tmpList2.Items.Add(m_tmpList1.SelectedItem)
            Else
                MsgBox(m_tmpList1.SelectedItem.ToString & " est déjà dans la liste.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Doublons...")
            End If
        End If

    End Sub

    Private Sub btnremove_MouseUp(sender As Object, e As MouseEventArgs)

        If e.Button = Windows.Forms.MouseButtons.Left AndAlso m_tmpList2.SelectedItem IsNot Nothing Then
            m_tmpList2.Items.Remove(m_tmpList2.SelectedItem)
        End If

    End Sub

    Public ReadOnly Property Items As Object()
        Get
            Dim itemsArray(m_list.Items.Count - 1) As Object
            m_list.Items.CopyTo(itemsArray, 0)
            Return itemsArray
        End Get
    End Property

    Public Sub AddItem(item As Object)
        m_list.Items.Add(item)
        RaiseEvent ItemsListChanged(Me)
    End Sub

    Public Sub AddRange(items As ListBox.ObjectCollection)
        m_list.Items.AddRange(items)
        RaiseEvent ItemsListChanged(Me)
    End Sub

    Public Sub AddRange(items As Object())
        m_list.Items.AddRange(items)
        RaiseEvent ItemsListChanged(Me)
    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return m_list.Items.Count
        End Get
    End Property

    Private Sub m_txtFilter_KeyUp(sender As Object, e As KeyEventArgs) Handles m_txtFilter.KeyUp

        If e.KeyCode = Keys.Enter Then

            Dim filteredList As New List(Of Object)
            Dim filter As String = "*" & m_txtFilter.Text.Trim.ToLower & "*"

            For Each o As Object In fullItemsList

                If o.ToString.ToLower Like filter Then
                    filteredList.Add(o)
                End If

            Next

            m_tmpList1.Items.Clear()
            m_tmpList1.Items.AddRange(filteredList.ToArray)

        End If

    End Sub

    Private Sub m_frm_Activated(sender As Object, e As EventArgs) Handles m_frm.Activated

        With m_txtFilter
            .TabIndex = 0
            .Focus()
        End With

    End Sub

End Class

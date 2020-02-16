Public Class SelectList
    Inherits Panel

    Private WithEvents m_list As ListBox
    Private m_footPanel As Panel
    Private m_titleLabel As Label
    Private WithEvents m_editButton As Label
    Private WithEvents m_addButton As Label

    Private fullItemsList As Collections.IList
    Private m_allowAdd As Boolean

    Public Event ItemsListChanged(sender As SelectList)
    Public Event AddItemClick(sender As SelectList)

    Public Sub New()
        MyBase.New()

        m_allowAdd = False
        InitComponents()

    End Sub

    Private Sub InitComponents()

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

        m_addButton = New Label
        With m_addButton
            .Parent = m_footPanel
            .Visible = True
            .Dock = DockStyle.Right
            .BackColor = Color.LightGray
            .Width = 50
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = "Ajouter"
            .Visible = m_allowAdd
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

    Public Property AllowAdd As Boolean
        Get
            Return m_allowAdd
        End Get
        Set(value As Boolean)
            m_allowAdd = value
            m_addButton.Visible = m_allowAdd
        End Set
    End Property

    Public Sub SetValues(items As Collections.IList)
        ClearValues()
        AddValues(items)
    End Sub

    Public Sub AddValues(items As Collections.IList)

        If fullItemsList Is Nothing Then
            fullItemsList = items
        Else
            For Each item In items
                fullItemsList.Add(item)
            Next
        End If

    End Sub

    Public Sub Clear()
        m_list.Items.Clear()
        RaiseEvent ItemsListChanged(Me)
    End Sub

    Public Sub ClearValues()

        If Not fullItemsList Is Nothing Then
            fullItemsList.Clear()
        End If

    End Sub

    Private Sub m_addButton_MouseUp(sender As Object, e As MouseEventArgs) Handles m_addButton.MouseUp

        If AllowAdd Then
            RaiseEvent AddItemClick(Me)
        End If

    End Sub

    Private Sub m_editButton_MouseUp(sender As Object, e As MouseEventArgs) Handles m_editButton.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then

            Dim result As FrmSelectItems.FrmSelectItemsResult = FrmSelectItems.GetSelectedItems(fullItemsList, m_list.Items, Me)

            If result.DlgResult = DialogResult.OK Then

                m_list.Items.Clear()

                If result.SelectedItems IsNot Nothing Then
                    For Each item As Object In result.SelectedItems
                        m_list.Items.Add(item)
                    Next

                End If

                RaiseEvent ItemsListChanged(Me)

            End If

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

End Class

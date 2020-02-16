Public Class GridView

    Public Event ListItemAction(Sender As Object, e As GridItemActionEventArgs)
    Public Event ItemSelectionChanged(Sender As Object, e As GridItemSelectedEventArgs)
    Public Event SerieClicked(Sender As Object, item As GridItem)
    Public Event ShowFilterClick(sender As Object, e As MouseEventArgs)

    Private m_adapter As IAdapter

    Private m_columnsCount As Integer = 1
    Private m_rowsCount As Integer = 1

    Private m_pageIndex As Integer = 1
    Private m_pageCount As Integer

    Private m_itemWidth As Integer = 0
    Private m_itemHeight As Integer = 0
    Private m_itemsMargin As Integer = 3

    Private m_itemsCount As Integer = 0
    Private m_itemsByPageCount As Integer = m_columnsCount * m_rowsCount

    Private m_selectedIem As Object = Nothing

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        btn_filter.Visible = False

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

        pnl_main.Controls.Clear()

    End Sub

    Public Property ColumnsCount As Integer
        Get
            Return m_columnsCount
        End Get
        Set(value As Integer)

            If m_columnsCount <> value Then
                m_columnsCount = value
                UpdateItemsOrganization()
            End If

        End Set
    End Property

    Public Property RowsCount As Integer
        Get
            Return m_rowsCount
        End Get
        Set(value As Integer)

            If m_rowsCount <> value Then
                m_rowsCount = value
                UpdateItemsOrganization()
            End If

        End Set
    End Property

    Public Property ItemsMargin As Integer
        Get
            Return m_itemsMargin
        End Get
        Set(value As Integer)

            If m_itemsMargin <> value Then
                m_itemsMargin = value
                UpdateItemsOrganization()
            End If

        End Set
    End Property

    Public ReadOnly Property SelectedItem As GridItem
        Get

            Dim result As GridItem = Nothing

            If m_selectedIem IsNot Nothing Then

                For Each gi As GridItem In pnl_main.Controls
                    If gi.GetValue Is m_selectedIem Then
                        result = gi
                        Exit For
                    End If
                Next

            End If

            Return result

        End Get
    End Property

    Public Property ShowFilter As Boolean
        Get
            Return Me.btn_filter.Visible
        End Get
        Set(value As Boolean)
            Me.btn_filter.Visible = value
        End Set
    End Property

    Private Sub pnl_main_SizeChanged(sender As Object, e As EventArgs) Handles pnl_main.SizeChanged
        UpdateItemsOrganization()
    End Sub

    Private Sub UpdateItemsOrganization()

        If m_adapter IsNot Nothing Then

            m_itemsCount = m_adapter.GetItemsCount

            Dim panelUsableHeight = pnl_main.Height - ((m_rowsCount + 1) * m_itemsMargin)
            Dim panelUsableWidth = pnl_main.Width - ((m_columnsCount + 1) * m_itemsMargin)

            m_itemHeight = Math.Floor(panelUsableHeight / m_rowsCount)
            m_itemWidth = Math.Floor(panelUsableWidth / m_columnsCount)

            m_itemsByPageCount = m_columnsCount * m_rowsCount
            m_pageCount = Math.Ceiling(m_itemsCount / m_itemsByPageCount)

            showPage(1)

        Else
            m_itemsCount = 0
            m_itemHeight = 0
            m_itemWidth = 0
            m_itemsByPageCount = 0
            m_pageCount = 0

        End If

    End Sub

    Public Sub SetAdapter(adapter As IAdapter)

        m_adapter = adapter

        'If (m_adapter Is Nothing) _
        'OrElse ((Me.Controls.Count > 0) AndAlso (Not Me.Controls(0).GetType Is adapter.GetListViewItemType)) _
        'Then
        '    pnl_main.Controls.Clear()
        'End If
        pnl_main.Controls.Clear()

        UpdateItemsOrganization()

    End Sub

    Public Sub ShowPage(pageIndex As Integer)

        If (m_adapter IsNot Nothing) AndAlso (pageIndex > 0) AndAlso (pageIndex <= m_pageCount) Then

            UnSelectAllItems()
            m_pageIndex = pageIndex

            Dim firstItemIndex As Integer = (m_pageIndex - 1) * m_itemsByPageCount
            Dim lastItemIndex As Integer = (m_pageIndex * m_itemsByPageCount) - 1

            If lastItemIndex >= m_itemsCount Then
                lastItemIndex = m_itemsCount - 1
            End If

            Me.SuspendLayout()

            ShowItems(firstItemIndex, lastItemIndex)

            'If m_s

            Me.ResumeLayout(False)

        End If

        If m_pageCount > 0 Then
            lbl_pageIndex.Text = m_pageIndex & " / " & m_pageCount & " (" & m_itemsCount & " résultats)"
        Else
            lbl_pageIndex.Text = ""
        End If

        btn_first.Enabled = m_pageIndex > 1
        btn_next.Enabled = m_pageIndex < m_pageCount
        btn_prev.Enabled = m_pageIndex > 1
        btn_last.Enabled = m_pageIndex < m_pageCount

    End Sub

    Private Sub ShowItems(firstItemIndex As Integer, lastItemIndex As Integer)

        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0
        Dim itemIndex As Integer = firstItemIndex
        Dim ctrlIndex As Integer = 0
        Dim ctrlReUsed As Boolean


        While (rowIndex < m_rowsCount) AndAlso (itemIndex <= lastItemIndex)

            While (colIndex < m_columnsCount) AndAlso (itemIndex <= lastItemIndex)

                ctrlReUsed = ShowItem(rowIndex, colIndex, itemIndex, ctrlIndex)

                colIndex += 1
                itemIndex += 1

                'If ctrlReUsed Then
                ctrlIndex += 1
                'End If

            End While

            rowIndex += 1
            colIndex = 0

        End While

        Dim n As Integer = pnl_main.Controls.Count - 1
        While ctrlIndex <= n
            pnl_main.Controls(n).Visible = False
            n -= 1
        End While

    End Sub

    ' Retourne true si le un control existe à la position controlIndex et qu'il a été réutilisé.
    ' Retourne false si aucun control n'existe à la position controlIndex ou qu'il n'a pas été réutilisé.
    Private Function ShowItem(rowIndex As Integer, colIndex As Integer, itemIndex As Integer, controlIndex As Integer) As Boolean

        Dim result As Boolean
        Dim ctrl As GridItem

        If pnl_main.Controls.Count > controlIndex Then
            Dim ctrl1 As GridItem = pnl_main.Controls(controlIndex)
            ctrl = m_adapter.InitListViewItem(ctrl1, itemIndex)

            If (ctrl IsNot ctrl1) Then
                ctrl.Parent = pnl_main
                pnl_main.Controls.SetChildIndex(ctrl, controlIndex)
            End If

        Else
            ctrl = m_adapter.BuildNewListViewItem(itemIndex)
            ctrl.Parent = pnl_main

            result = False
        End If

        AddHandler ctrl.ListItemAction, AddressOf ListItem_ActionSent
        AddHandler ctrl.Selected, AddressOf GridItem_Selected

        ctrl.SetSelected(ctrl.GetValue Is m_selectedIem)

        Dim x As Integer = colIndex * (m_itemWidth + m_itemsMargin) + m_itemsMargin
        Dim y As Integer = rowIndex * (m_itemHeight + m_itemsMargin) + m_itemsMargin

        ctrl.Size = New Size(m_itemWidth, m_itemHeight)
        ctrl.Location = New Point(x, y)
        ctrl.Visible = True

        Return result

    End Function

    Private Sub ListItem_ActionSent(Sender As Object, e As GridItemActionEventArgs)
        RaiseEvent ListItemAction(Sender, e)
    End Sub

    Private Sub GridItem_Selected(sender As Object, e As GridItemSelectedEventArgs)

        m_selectedIem = CType(sender, GridItem).GetValue

        For Each c As GridItem In pnl_main.Controls

            If Not c Is sender Then
                c.SetSelected(False)
            End If

        Next

        RaiseEvent ItemSelectionChanged(Me, e)

    End Sub

    ' Optimise le temps d'affichage, et le rendu visuel pendant la construction
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle + 33554432
            Return cp
        End Get
    End Property

    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click

        If m_pageIndex > 1 Then
            showPage(m_pageIndex - 1)
        End If

    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

        If m_pageIndex < m_pageCount Then
            showPage(m_pageIndex + 1)
        End If

    End Sub

    Private Sub btn_first_Click(sender As Object, e As EventArgs) Handles btn_first.Click
        showPage(1)
    End Sub

    Private Sub btn_last_Click(sender As Object, e As EventArgs) Handles btn_last.Click
        showPage(m_pageCount)
    End Sub

    Private Sub pnl_main_MouseDown(sender As Object, e As MouseEventArgs) Handles pnl_main.MouseDown
        UnSelectAllItems()
    End Sub

    Private Sub UnSelectAllItems()

        m_selectedIem = Nothing

        For Each gi As GridItem In pnl_main.Controls
            gi.SetSelected(False)
        Next

        RaiseEvent ItemSelectionChanged(Me, New GridItemSelectedEventArgs(Nothing))

    End Sub

    Private Sub btn_filter_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_filter.MouseUp
        RaiseEvent ShowFilterClick(Me, e)
    End Sub

End Class

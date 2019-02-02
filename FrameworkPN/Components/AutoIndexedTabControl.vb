Public Class AutoIndexedTabControl
    Inherits TabControl

    Private WithEvents parentForm As Form
    Private m_tabPagesPositions1 As Hashtable
    Private m_tabPagesPositions2 As Hashtable
    Private m_tabPagesVisibleStates As Hashtable

    Private onHideTabPage As Boolean = False
    Private onShowTabPage As Boolean = False

    Public Sub New()
        MyBase.New()

        m_tabPagesPositions1 = New Hashtable
        m_tabPagesPositions2 = New Hashtable
        m_tabPagesVisibleStates = New Hashtable

    End Sub

    Public Sub HideTabPage(position As Integer)

        Dim index As Nullable(Of Integer) = PositionToVisibledTabIndex(position)

        If index IsNot Nothing Then
            onHideTabPage = True
            Me.TabPages.RemoveAt(index)
            onHideTabPage = False
        End If

    End Sub

    Public Sub ShowTabPage(position As Integer)

        Dim index As Nullable(Of Integer) = PositionToUnvisibledTabIndex(position)

        If index IsNot Nothing Then
            onShowTabPage = True
            Me.TabPages.Insert(index.Value, m_tabPagesPositions1.Item(position))
            onShowTabPage = False
        End If

    End Sub

    Private Sub AutoIndexedTabControl_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded

        If Not onShowTabPage Then

            Dim tp As TabPage = e.Control
            Dim position = m_tabPagesPositions1.Count

            m_tabPagesPositions1.Add(position, tp)
            m_tabPagesPositions2.Add(tp, position)
            m_tabPagesVisibleStates.Add(position, True)

            OrderControlsTabIndex(tp)

        End If

    End Sub

    Private Sub AutoIndexedTabControl_ControlRemoved(sender As Object, e As ControlEventArgs) Handles Me.ControlRemoved

        If Not onHideTabPage Then

            Dim tp As TabPage = e.Control
            Dim position As Integer = m_tabPagesPositions2.Item(tp)

            m_tabPagesPositions1.Remove(position)
            m_tabPagesPositions2.Remove(tp)
            m_tabPagesVisibleStates.Remove(position)

        End If

    End Sub

    Private Function PositionTovisibledTabIndex(position As Integer) As Nullable(Of Integer)

        Dim index As Nullable(Of Integer) = Nothing
        Dim tp As TabPage = m_tabPagesPositions1.Item(position)

        If tp IsNot Nothing Then
            index = Me.TabPages.IndexOf(tp)
        End If

        Return index

    End Function

    Private Function PositionToUnVisibledTabIndex(position As Integer) As Nullable(Of Integer)

        Dim index As Nullable(Of Integer) = Nothing

        Dim p As Integer = -1
        Dim previousPosition As Integer = -1
        Dim previousTp As TabPage = Nothing

        For Each tp As TabPage In m_tabPagesPositions2.Keys

            p = m_tabPagesPositions2.Item(tp)

            If (p < position) AndAlso (p > previousPosition) Then

                If Not TabPages.Contains(tp) Then
                    previousPosition = p
                    previousTp = tp
                End If

            End If
        Next

        If previousTp IsNot Nothing Then
            index = Me.TabPages.IndexOf(previousTp) + 1
        End If

        Return index

    End Function

    Private Sub OrderControlsTabIndex(tab As TabPage)

        Dim lst As New List(Of TabIndexedControl)

        OrderControls(tab.Controls, lst, 0, 0)

        lst.Sort()

        Dim i As Integer = 1
        For Each tic In lst
            tic.SettabIndex(i)
            i = i + 1
        Next

    End Sub

    Private Sub OrderControls(ctrls As System.Windows.Forms.Control.ControlCollection, lst As List(Of TabIndexedControl), parentX As Integer, parentY As Integer)

        Dim tic As TabIndexedControl

        For Each c As Control In ctrls

            If TypeOf c Is TextBox _
            Or TypeOf c Is ComboBox _
            Or TypeOf c Is RadioButton _
            Or TypeOf c Is Button _
            Then
                tic = New TabIndexedControl(c, parentX, parentY)
                lst.Add(tic)

            ElseIf TypeOf c Is Panel Then
                OrderControls(c.Controls, lst, c.Location.X + parentX, c.Location.Y + parentY)
            End If

        Next

    End Sub

    Private Class TabIndexedControl
        Implements IComparable

        Private ctrl As Control
        Private x As Integer
        Private y As Integer

        Public Sub New(ctrl As Control, parentX As Integer, parentY As Integer)
            Me.ctrl = ctrl
            x = ctrl.Location.X + parentX
            y = ctrl.Location.Y + parentY
        End Sub

        Public Sub SettabIndex(index As Integer)
            Me.ctrl.TabIndex = index
        End Sub

        Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo

            With CType(obj, TabIndexedControl)

                If .y = y AndAlso .x = x Then
                    Return 0
                ElseIf .y < y Then
                    Return 1
                ElseIf .y > y Then
                    Return -1
                ElseIf .x < x Then
                    Return 1
                Else
                    Return -1
                End If

            End With

        End Function
    End Class

End Class

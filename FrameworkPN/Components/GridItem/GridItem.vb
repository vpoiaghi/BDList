Public Class GridItem
    Inherits System.Windows.Forms.UserControl


    Public Event ListItemAction(Sender As Object, e As GridItemActionEventArgs)
    Public Event Selected(Sender As Object, e As GridItemSelectedEventArgs)

    Protected m_value As Object
    Protected m_selected As Boolean = False

    Protected Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Function GetValue() As Object
        Return m_value
    End Function

    Public Sub SetValue(value As Object)
        m_value = value
        Redraw()
    End Sub

    Public Overridable Sub ModifyItem()
    End Sub

    Public Overridable Sub ShowItem()
    End Sub

    Public Overridable Sub Redraw()
        ' A surcharger
    End Sub

    Protected Sub SendActionEvent(EventArgs As GridItemActionEventArgs)
        RaiseEvent ListItemAction(Me, EventArgs)
    End Sub


    Private Sub GridItem_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddEventsToControls(Me)
    End Sub

    Private Sub AddEventsToControls(ctrl As Control)

        RemoveHandler ctrl.MouseUp, AddressOf GridItem_MouseUp
        AddHandler ctrl.MouseUp, AddressOf GridItem_MouseUp

        RemoveHandler ctrl.MouseEnter, AddressOf GridItem_MouseEnter
        AddHandler ctrl.MouseEnter, AddressOf GridItem_MouseEnter

        RemoveHandler ctrl.MouseLeave, AddressOf GridItem_MouseLeave
        AddHandler ctrl.MouseLeave, AddressOf GridItem_MouseLeave


        For Each c As Control In ctrl.Controls
            AddEventsToControls(c)
        Next

    End Sub

    Private Sub GridItem_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left Then
            RaiseEvent Selected(Me, New GridItemSelectedEventArgs(m_value))
            SetSelected(True)
        End If
    End Sub

    Private Sub GridItem_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        ApplyMouseEnterStyle(m_selected)
    End Sub

    Private Sub GridItem_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        ApplyMouseLeaveStyle(m_selected)
    End Sub

    Public Function IsSelected() As Boolean
        Return m_selected
    End Function

    Public Sub SetSelected(selected As Boolean)

        If m_selected <> selected Then
            m_selected = selected
            ApplySelectedStyle(m_selected)
        End If

    End Sub

    Protected Overridable Sub ApplySelectedStyle(Selected As Boolean)

        If m_selected Then
            Me.BackColor = Color.Aquamarine
        Else
            Me.BackColor = Color.White
        End If

    End Sub

    Protected Overridable Sub ApplyMouseEnterStyle(Selected As Boolean)

    End Sub

    Protected Overridable Sub ApplyMouseLeaveStyle(Selected As Boolean)

    End Sub

End Class

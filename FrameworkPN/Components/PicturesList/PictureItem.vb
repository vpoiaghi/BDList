Imports BDList_TOOLS.IO

Friend Class PictureItem
    Inherits Panel

    Private m_item As PctItem
    Private WithEvents m_picture As New PictureBox
    Private WithEvents m_label As New Label

    Private m_isSelected As Boolean

    Public Event ItemSelected(ByVal sender As Object)
    Public Event ItemUnSelected(ByVal sender As Object)

    Public Sub New()
        MyBase.New()

        Me.SuspendLayout()

        With Me
            Width = 113
            Height = 203
            Visible = True
        End With

        With m_picture
            .Parent = Me
            .Dock = DockStyle.Top
            .Visible = True
            .Height = 163
            .SizeMode = PictureBoxSizeMode.Zoom
        End With

        With m_label
            .Parent = Me
            .Dock = DockStyle.Bottom
            .Visible = True
            .Height = 40
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = ""
        End With

        Me.ResumeLayout(False)

        SetSelectState(False)

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Label_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles m_label.MouseDown

        If e.Button = MouseButtons.Left Then
            Me.Selected = True
        End If

    End Sub

    Private Sub m_picture_MouseDown(sender As Object, e As MouseEventArgs) Handles m_picture.MouseDown

        If e.Button = MouseButtons.Left Then
            Me.Selected = True

        ElseIf e.Button = MouseButtons.Right Then
            FrmShowImage.ShowImage(CType(sender, PictureBox).Image)

        End If


    End Sub


    Public Property Selected As Boolean
        Get
            Return m_isSelected
        End Get
        Set(value As Boolean)

            If m_isSelected <> value Then
                SetSelectState(value)
            End If

        End Set
    End Property

    Private Sub SetSelectState(isSelected As Boolean)

        m_isSelected = isSelected

        If m_isSelected Then
            Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            Me.BackColor = Color.Blue
            RaiseEvent ItemSelected(Me)
        Else
            Me.BorderStyle = Windows.Forms.BorderStyle.None
            Me.BackColor = Color.Transparent
            RaiseEvent ItemUnSelected(Me)
        End If

    End Sub

    Public Function GetItem() As PctItem
        Return m_item
    End Function

    Public Sub SetItem(p_item As PctItem)

        m_item = p_item

        Dim file As iFile = m_item.GetFile

        If file IsNot Nothing Then
            m_label.Text = file.GetName
        Else
            m_label.Text = ""
        End If

        m_picture.Image = m_item.GetImage

        Me.Refresh()

    End Sub

End Class
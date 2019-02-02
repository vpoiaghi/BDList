Public Class MenuItem

    Private m_parent As Menu
    Private m_target As String = Nothing

    Public Sub New(parent As Menu)
        MyBase.New()
        InitializeComponent()

        m_parent = parent

        Lbl_DropDown.Visible = False

    End Sub

    Public Overrides Property Text As String
        Get
            Return Lbl_Text.Text
        End Get
        Set(value As String)
            Lbl_Text.Text = value
        End Set
    End Property

    Public Property Target As String
        Get
            Return m_target
        End Get
        Set(value As String)
            m_target = value
        End Set
    End Property

    Public Property Image As Image
        Get
            Return Pct_Icon.Image
        End Get
        Set(value As Image)
            Pct_Icon.Image = value
        End Set
    End Property

    Private Sub Lbl_Text_Click(sender As Object, e As EventArgs) Handles Lbl_Text.Click

        If m_target IsNot Nothing Then
            m_parent.GoToTarget(Me, m_target)
        End If

    End Sub

    Private Sub Lbl_Text_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_Text.MouseEnter
        Lbl_Text.ForeColor = Color.Gold
    End Sub

    Private Sub Lbl_Text_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_Text.MouseLeave
        Lbl_Text.ForeColor = Color.White
    End Sub

End Class

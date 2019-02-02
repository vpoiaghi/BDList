Public Class Menu

    Public Event OnGoToTarget(Sender As MenuItem, Target As String)

    Private m_menuItems As MenuItemsList

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        m_menuItems = New MenuItemsList(Me)

    End Sub

    Public ReadOnly Property Items As MenuItemsList
        Get
            Return m_menuItems
        End Get
    End Property

    Friend Sub GoToTarget(Sender As MenuItem, Target As String)
        RaiseEvent OnGoToTarget(Sender, Target)
    End Sub

    Public Class MenuItemsList

        Private m_menu As Menu
        Private m_menuItems As List(Of MenuItem)

        Friend Sub New(menuControl As Menu)

            m_menu = menuControl
            m_menuItems = New List(Of MenuItem)

        End Sub

        Public Sub Add(text As String, target As String)
            Add(Text, Target, Nothing)
        End Sub

        Public Sub Add(text As String, image As Image)
            Add(Text, Nothing, Image)
        End Sub

        Public Sub Add(text As String, target As String, image As Image)

            Dim mItem As New MenuItem(m_menu)
            With mItem
                .Text = Text
                .Dock = DockStyle.Top
                .Parent = m_menu
                .Image = Image
                .BringToFront()
                .Target = Target
            End With

        End Sub

    End Class

End Class

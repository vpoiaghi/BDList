Public Class UC_Page
    Inherits UserControl

    Private m_frm As FrmPagesManager

    Public Sub New()
        InitializeComponent()
        PnlUCHeader1.SendToBack()

        Me.Padding = New Padding(0)

    End Sub

    Public Sub New(frm As FrmPagesManager)
        Me.New()
        m_frm = frm
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Protected Sub ShowPage(pageName As String)
        FrmPagesManager.ShowPage(pageName)
    End Sub

    Protected Sub SetParameter(key As String, value As Object)
        FrmPagesManager.SetParameter(key, value)
    End Sub

    Protected Function GetParameter(key As String) As Object
        Dim value As Object = m_frm.GetParameter(key)
        SetParameter(key, nothing)
        Return value
    End Function

    Protected Friend Overridable Sub Activate()
        ' Rien à faire par défaut
    End Sub

    Public Property Title As String
        Get
            Return PnlUCHeader1.Title
        End Get
        Set(value As String)
            PnlUCHeader1.Title = value
        End Set
    End Property

    Public Shadows Property Padding As Padding
        Get
            Return MyBase.Padding
        End Get
        Set(value As Padding)
        End Set
    End Property

    Public Property ShowHeader As Boolean
        Get
            Return PnlUCHeader1.Visible
        End Get
        Set(value As Boolean)
            PnlUCHeader1.Visible = value
        End Set
    End Property

End Class
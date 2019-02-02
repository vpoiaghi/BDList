Public Class LabelView
    Inherits Panel

    Private m_lbl1 As Label
    Private m_lbl2 As Label

    Public Sub New()

        m_lbl1 = New Label
        With m_lbl1
            .Parent = Me
            .AutoSize = False
            .Dock = DockStyle.Left
            .Font = New Font("Arial", 8)
            .Width = 85
        End With

        m_lbl2 = New Label
        With m_lbl2
            .Parent = Me
            .BringToFront()
            .AutoSize = False
            .Dock = DockStyle.Fill
        End With

    End Sub

    Public Property Caption() As String
        Get
            Return m_lbl1.Text
        End Get
        Set(value As String)
            m_lbl1.Text = value
        End Set
    End Property

    Public Overrides Property Text() As String
        Get
            Return m_lbl2.Text
        End Get
        Set(value As String)
            m_lbl2.Text = value
        End Set
    End Property

End Class

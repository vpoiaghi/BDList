Public Class PnlUCHeader
    Inherits Panel

    Private lbl_title As Label

    Public Sub New()
        MyBase.New()

        MyBase.Padding = New Padding(10)
        Me.BackColor = Color.Black
        Me.Dock = DockStyle.Top

        lbl_title = New Label
        With lbl_title
            .BackColor = Color.Transparent
            .Font = New Font("Arial", 20, FontStyle.Regular)
            .ForeColor = Color.White
            .AutoSize = False
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Fill
            .Parent = Me
        End With

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Property Title As String
        Get
            Return lbl_title.Text
        End Get
        Set(value As String)
            lbl_title.Text = value
        End Set
    End Property

    Public Overloads Property Padding As Padding
        Get
            Return MyBase.Padding
        End Get
        Set(value As Padding)
        End Set
    End Property

End Class

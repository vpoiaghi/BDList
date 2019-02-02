Public Class FrmShowImage

    Private Shared m_frm As FrmShowImage = Nothing

    Protected Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub SetImage(img As Image)
        PictureBox1.Image = img
    End Sub

    Private Sub FrmShowImage_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.Hide()
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Me.Hide()
    End Sub


    Public Shared Sub ShowImage(img As Image)

        If img IsNot Nothing Then

            If m_frm Is Nothing Then
                m_frm = New FrmShowImage()
            End If

            m_frm.SetImage(img)
            m_frm.ShowDialog()

        End If

    End Sub

End Class
Imports FrameworkPN
Imports BDList_DAO_BO.BO
Imports BDList_TOOLS.IO
Imports BDList_SERVICE
Imports System.Drawing.Drawing2D

Public Class GridItem_Serie

    Private Shared m_font1 As New Font("Microsoft Sans Serif", 16, FontStyle.Regular)
    Private Shared m_font2 As New Font("Microsoft Sans Serif", 16, FontStyle.Bold)

    Private m_imgWithMouse As Image = Nothing
    Private m_imgWithoutMouse As Image = Nothing

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub GridItem_Serie_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        m_imgWithoutMouse = Nothing
        m_imgWithMouse = Nothing
        Me.BackgroundImage = GetImageWithoutMouse()
    End Sub

    Public Overrides Sub Redraw()
        m_imgWithoutMouse = Nothing
        m_imgWithMouse = Nothing
        Me.BackgroundImage = GetImageWithoutMouse()
    End Sub

    Protected Overrides Sub ApplySelectedStyle(selected As Boolean)
    End Sub

    Protected Overrides Sub ApplyMouseEnterStyle(selected As Boolean)
        Me.BackgroundImage = GetImageWithMouse()
    End Sub

    Protected Overrides Sub ApplyMouseLeaveStyle(selected As Boolean)
        Me.BackgroundImage = GetImageWithoutMouse()
    End Sub

    Private Function GetImageWithoutMouse() As Image

        If (m_value IsNot Nothing) AndAlso (m_imgWithMouse Is Nothing) AndAlso (Me.Width > 0) AndAlso (Me.Height > 0) Then

            Dim serie As Serie = CType(m_value, Serie)
            Dim bandeauFile As IFile = DirNameGenerator.GetBandeauDir(serie)

            Dim img As New Bitmap(Me.Width, Me.Height)
            Dim g As Graphics = Graphics.FromImage(img)

            g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
            g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit

            If bandeauFile IsNot Nothing Then
                Dim imgBandeau As Image = ImageUtils.LoadImage(bandeauFile.GetFullName())
                Dim bandeauHeight As Integer = img.Height
                Dim bandeauWidth As Integer = (img.Height * imgBandeau.Width) \ imgBandeau.Height
                g.FillRectangle(Brushes.Black, New RectangleF(0, 0, bandeauWidth, Me.Height))
                g.DrawImage(imgBandeau, img.Width - bandeauWidth, 0, bandeauWidth, bandeauHeight)
            Else
                g.FillRectangle(Brushes.Black, New RectangleF(0, 0, Me.Width, Me.Height))
            End If

            g.DrawString(serie.ToString, m_font1, Brushes.Black, New PointF(9, 9))
            g.DrawString(serie.ToString, m_font1, Brushes.Black, New PointF(9, 11))
            g.DrawString(serie.ToString, m_font1, Brushes.Black, New PointF(11, 11))
            g.DrawString(serie.ToString, m_font1, Brushes.Black, New PointF(11, 9))
            g.DrawString(serie.ToString, m_font1, Brushes.White, New PointF(10, 10))

            g.Dispose()

            m_imgWithoutMouse = img

        End If

        Return m_imgWithoutMouse

    End Function

    Private Function GetImageWithMouse() As Image

        If (m_value IsNot Nothing) AndAlso (m_imgWithMouse Is Nothing) Then

            Dim serie As Serie = CType(m_value, Serie)
            Dim bandeauFile As IFile = DirNameGenerator.GetBandeauDir(serie)

            Dim img As New Bitmap(Me.Width, Me.Height)
            Dim g As Graphics = Graphics.FromImage(img)

            Dim selColor As Color = Color.FromArgb(60, 60, 60)

            g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
            g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit

            Dim backBrush As Brush

            If bandeauFile IsNot Nothing Then
                Dim imgBandeau As Image = ImageUtils.LoadImage(bandeauFile.GetFullName())
                Dim bandeauHeight As Integer = img.Height
                Dim bandeauWidth As Integer = (img.Height * imgBandeau.Width) \ imgBandeau.Height
                backBrush = New LinearGradientBrush(New Point(0, 0), New Point(img.Width - bandeauWidth, 0), selColor, Color.Black)
                g.FillRectangle(backBrush, New RectangleF(0, 0, bandeauWidth, Me.Height))
                g.DrawImage(imgBandeau, img.Width - bandeauWidth, 0, bandeauWidth, bandeauHeight)
            Else
                backBrush = New LinearGradientBrush(New Point(0, 0), New Point(Me.Width \ 2, 0), selColor, Color.Black)
                g.FillRectangle(backBrush, New RectangleF(0, 0, Me.Width \ 2, Me.Height))
                g.FillRectangle(Brushes.Black, New RectangleF(Me.Width \ 2, 0, Me.Width \ 2, Me.Height))
            End If

            g.DrawString(serie.ToString, m_font2, Brushes.Black, New PointF(14, 9))
            g.DrawString(serie.ToString, m_font2, Brushes.Black, New PointF(16, 9))
            g.DrawString(serie.ToString, m_font2, Brushes.Black, New PointF(16, 11))
            g.DrawString(serie.ToString, m_font2, Brushes.Black, New PointF(14, 11))
            g.DrawString(serie.ToString, m_font2, Brushes.Yellow, New PointF(15, 10))

            g.Dispose()

            m_imgWithMouse = img

        End If

        Return m_imgWithMouse

    End Function

End Class

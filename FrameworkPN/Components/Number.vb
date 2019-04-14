Imports System.Drawing.Drawing2D
Imports System.Drawing.Text

Public Class Number
    Inherits Control

    Private m_number As String = Nothing
    Private m_maxNumber As Integer? = Nothing
    Private m_numberType As String = Nothing

    Private m_tooltip As ToolTip = New ToolTip()

    Private m_text As String = ""


    Public Sub New()
        MyBase.New()
        Me.Font = New Font("Segoe UI Semibold", 8, FontStyle.Bold, GraphicsUnit.Point, 1, False)
    End Sub

    Public Property Number As String
        Get
            Return m_number
        End Get
        Set(value As String)
            If value <> m_number Then

                If value Is Nothing Then
                    m_number = value
                Else
                    m_number = value.Trim()
                End If

                RefreshText()
            End If
        End Set
    End Property

    Public Property MaxNumber As Integer?
        Get
            Return m_maxNumber
        End Get
        Set(value As Integer?)
            If Not value.Equals(m_maxNumber) Then
                m_maxNumber = value
                RefreshText()
            End If
        End Set
    End Property

    Public Property NumberType As String
        Get
            Return m_numberType
        End Get
        Set(value As String)
            If value <> m_numberType Then

                If value Is Nothing Then
                    m_numberType = value
                Else
                    m_numberType = value.Trim()
                End If

                RefreshText()
            End If
        End Set
    End Property

    Public Shadows ReadOnly Property Text As String
        Get
            Return m_text
        End Get
    End Property

    Private Sub RefreshText()

        m_text = BuildText()

        UpdateToolTipText()
        Me.Invalidate()

    End Sub

    Private Sub UpdateToolTipText()

        m_tooltip.RemoveAll()

        If Not String.IsNullOrEmpty(m_text) Then
            m_tooltip.SetToolTip(Me, m_text)
        End If

    End Sub

    Private Sub Number_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        With e.Graphics

            Dim str1 As String = ""
            Dim str2 As String = ""

            With m_text.Split("/")
                If .Count > 0 Then
                    str1 = .GetValue(0).trim
                    If .Count > 1 Then
                        str2 = .GetValue(1).trim
                    End If
                End If
            End With

            If (str1.Length > 0) OrElse (str2.Length > 0) Then

                Dim stringSize1 As SizeF? = Nothing
                Dim stringSize2 As SizeF? = Nothing

                If str1.Length > 0 Then
                    stringSize1 = .MeasureString(str1, Me.Font, Me.Width)
                End If

                If str2.Length > 0 Then
                    stringSize2 = .MeasureString(str2, Me.Font, Me.Width)
                End If

                If stringSize1 Is Nothing Then
                    stringSize1 = stringSize2
                End If

                If stringSize2 Is Nothing Then
                    stringSize2 = stringSize1
                End If

                Dim t As Integer = 0

                If str2.Length > 0 Then
                    t = (Me.Height - (stringSize1.Value.Height + stringSize2.Value.Height - 8)) / 2
                Else
                    t = (Me.Height - (stringSize1.Value.Height - 4)) / 2
                End If

                .CompositingQuality = CompositingQuality.HighQuality
                    .SmoothingMode = SmoothingMode.HighQuality
                    .InterpolationMode = InterpolationMode.HighQualityBicubic
                    .TextRenderingHint = TextRenderingHint.AntiAlias

                    Dim colors As Color()

                    If m_number = "1" Then
                        colors = {Color.FromArgb(255, 218, 185, 44)}
                    Else
                        colors = {Color.FromArgb(255, 28, 116, 22)}
                    End If


                    Dim path As New GraphicsPath()
                    path.AddEllipse(5, 5, Me.Width - 10, Me.Height - 10)

                    Dim pthGrBrush As New PathGradientBrush(path)
                    pthGrBrush.CenterPoint = New PointF(Me.Width / 3, Me.Height / 3)
                    pthGrBrush.CenterColor = Color.FromArgb(255, 255, 255, 255)
                    pthGrBrush.SurroundColors = colors

                    .FillEllipse(pthGrBrush, New Rectangle(5, 5, Me.Width - 10, Me.Height - 10))

                    If str1.Length > 0 Then
                        .DrawString(str1, Me.Font, Brushes.LightGray, New PointF((Me.Width - stringSize1.Value.Width) / 2 + 1, t + 1))
                        .DrawString(str1, Me.Font, Brushes.Black, New PointF((Me.Width - stringSize1.Value.Width) / 2, t))
                    End If

                    If str2.Length > 0 Then
                        .DrawString(str2, Me.Font, Brushes.LightGray, New PointF((Me.Width - stringSize2.Value.Width) / 2 + 1, t + stringSize1.Value.Height - 4 + 1))
                        .DrawString(str2, Me.Font, Brushes.Black, New PointF((Me.Width - stringSize2.Value.Width) / 2, t + stringSize1.Value.Height - 4))
                    End If

                End If

        End With

    End Sub

    Private Function BuildText() As String

        Dim s As String = ""

        Dim numSet As Boolean = Not String.IsNullOrEmpty(m_number)
        Dim maxSet As Boolean = Not m_maxNumber Is Nothing
        Dim typSet As Boolean = Not String.IsNullOrEmpty(m_numberType)

        If Not (numSet OrElse maxSet OrElse typSet) Then
            s = ""
        ElseIf (Not (typSet OrElse maxSet)) AndAlso numSet Then
            s = ""
        ElseIf (Not (numSet OrElse maxSet)) AndAlso typSet Then
            s = m_numberType
        ElseIf (Not (numSet OrElse typSet)) AndAlso maxSet Then
            s = "x " & m_maxNumber
        ElseIf numSet AndAlso maxSet AndAlso typSet Then
            s = m_numberType & " " & m_number & " / " & m_maxNumber
        ElseIf maxSet AndAlso typSet Then
            s = m_numberType & " / " & m_maxNumber
        ElseIf numSet AndAlso typSet Then
            s = m_numberType & " " & m_number
        ElseIf numSet AndAlso maxSet Then
            s = m_number & " / " & m_maxNumber
        End If

        Return s

    End Function

End Class

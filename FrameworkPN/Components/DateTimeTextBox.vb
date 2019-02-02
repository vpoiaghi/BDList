Public Class DateTimeTextBox
    Inherits Panel

    Public Shadows Event TextChanged(sender As Object, e As EventArgs)

    Private WithEvents m_textboxDate As TextBox
    Private WithEvents m_textboxTime As TextBox
    Private Shared m_dateSelector As New DateSelector

    Private m_dateFormat As String = "dd/MM/yyyy"
    Private m_timeFormat As String = "HH:mm:ss"
    Private m_date As Nullable(Of DateTime) = Nothing
    Private m_time As Nullable(Of DateTime) = Nothing

    Private m_width As Integer = 0

    Public Sub New()

        m_textboxDate = New TextBox
        With m_textboxDate
            .Parent = Me
            .Dock = DockStyle.Left
        End With

        m_textboxTime = New TextBox
        With m_textboxTime
            .Parent = Me
            .Dock = DockStyle.Right
        End With

    End Sub

    Public Property DateFormat() As String
        Get
            Return m_dateFormat
        End Get
        Set(value As String)
            m_dateFormat = value
        End Set
    End Property

    Public Property TimeFormat() As String
        Get
            Return m_timeFormat
        End Get
        Set(value As String)
            m_timeFormat = value
        End Set
    End Property

    Public Overrides Property Text As String
        Get
            Return m_textboxDate.Text & " " & m_textboxTime.Text
        End Get
        Set(value As String)
            m_textboxDate.Text = value
        End Set
    End Property

    Public Function GetDate() As Nullable(Of DateTime)
        Return m_date
    End Function

    Public Sub SetDate(value As Nullable(Of DateTime))
        m_date = value

        If m_date Is Nothing Then
            m_textboxDate.Text = ""
        Else
            m_date = CDate(m_date.Value.ToString("dd/MM/yyyy") & " 00:00:00")
            m_textboxDate.Text = Format(m_date, m_dateFormat)
        End If

        RaiseEvent TextChanged(Me, New EventArgs())

    End Sub

    Public Function GetTime() As Nullable(Of DateTime)
        Return m_time
    End Function

    Public Sub SetTime(value As Nullable(Of DateTime))
        m_time = value

        If m_time Is Nothing Then
            m_textboxTime.Text = ""
        Else
            m_time = CDate("01/01/1900 " & m_time.Value.ToString("HH:mm:ss"))
            m_textboxTime.Text = Format(m_date, m_timeFormat)
        End If

        RaiseEvent TextChanged(Me, New EventArgs())

    End Sub

    Public Function GetDateTime() As Nullable(Of DateTime)

        If m_date Is Nothing Then
            Return Nothing
        ElseIf m_time Is Nothing Then
            Return CDate(m_date.Value.ToString("dd/MM/yyyy") & " 00:00:00")
        Else
            Return CDate(m_date.Value.ToString("dd/MM/yyyy") & " " & m_time.Value.ToString("HH:mm:ss"))
        End If

    End Function

    Public Sub SetDateTime(value As Nullable(Of DateTime))

        If value Is Nothing Then
            m_date = Nothing
            m_time = Nothing
            m_textboxDate.Text = ""
            m_textboxTime.Text = ""
        Else
            m_date = CDate(value.Value.ToString("dd/MM/yyyy") & " 00:00:00")
            m_time = CDate("01/01/1900 " & value.Value.ToString("HH:mm:ss"))
            m_textboxDate.Text = Format(m_date, m_dateFormat)
            m_textboxTime.Text = Format(m_time, m_timeFormat)
        End If

        RaiseEvent TextChanged(Me, New EventArgs())

    End Sub

    Private Sub DateTextBox_LostFocus(sender As Object, e As EventArgs) Handles m_textboxDate.LostFocus, m_textboxTime.LostFocus

        m_textboxDate.Text = m_textboxDate.Text.Trim
        m_textboxTime.Text = m_textboxTime.Text.Trim

        If Not String.IsNullOrEmpty(m_textboxDate.Text) Then

            If IsDate(m_textboxDate.Text) Then
                m_date = CDate(m_textboxDate.Text)
                m_date = CDate(m_date.Value.ToString("dd/MM/yyyy") & " 00:00:00")
                m_textboxDate.Text = Format(m_date.Value, m_dateFormat)
            Else
                m_date = Nothing
                MsgBox("Le format de la date saisie n'est pas reconnu.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Date invalide...")
                m_textboxDate.Focus()
            End If

        Else
            m_date = Nothing
        End If

        If Not String.IsNullOrEmpty(m_textboxTime.Text) Then

            If IsDate(m_textboxTime.Text) Then
                m_time = CDate(m_textboxTime.Text)
                m_time = CDate("01/01/1900 " & m_time.Value.ToString("HH:mm:ss"))
                m_textboxTime.Text = Format(m_time.Value, m_timeFormat)
            Else
                m_time = Nothing
                MsgBox("Le format de l'heure saisie n'est pas reconnu.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Heure invalide...")
                m_textboxTime.Focus()
            End If

        Else
            m_time = Nothing
        End If

        RaiseEvent TextChanged(Me, New EventArgs())

    End Sub

    Private Sub DateTimeTextBox_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        If m_width <> Me.Width Then
            m_width = Me.Width

            Dim w = Me.Width / 2
            m_textboxDate.Width = w
            m_textboxTime.Width = w
            m_textboxTime.Left = w

        End If

    End Sub

    Private Sub m_textboxDate_MouseUp(sender As Object, e As MouseEventArgs) Handles m_textboxDate.MouseUp

        If e.Button = MouseButtons.Right Then

            m_dateSelector.Location = CType(sender, TextBox).ClientRectangle.Location
            m_dateSelector.CalendarDate = m_date

            With m_textboxDate.Location
                m_dateSelector.Location = m_textboxDate.PointToScreen(New Point(.X - 2 * m_textboxDate.Left, .Y))
            End With

            If m_dateSelector.ShowDialog(Me.FindForm) = DialogResult.OK Then
                SetDate(m_dateSelector.CalendarDate)
            End If

        End If

    End Sub

    Private Class DateSelector
        Inherits Form

        Private m_date As Nullable(Of DateTime)

        Private WithEvents m_monthCalendar As MonthCalendar
        Private WithEvents m_cancelButton As Button
        Private WithEvents m_okButton As Button
        Private m_backPanel As Panel

        Friend Sub New()
            MyBase.New
            m_date = Today

            m_backPanel = New Panel
            With m_backPanel
                .Parent = Me
                .Dock = DockStyle.Fill
                .BorderStyle = BorderStyle.FixedSingle
            End With

            m_monthCalendar = New MonthCalendar
            With m_monthCalendar
                .Parent = m_backPanel
                .Dock = DockStyle.Top
                .CalendarDimensions = New Size(1, 1)
                .MaxSelectionCount = 1
                .ShowTodayCircle = False
                .ShowToday = False
                .SetDate(m_date)
            End With

            m_okButton = New Button
            With m_okButton
                .Parent = m_backPanel
                .Top = m_monthCalendar.Height - 20
                .Height = 20
                .Width = (m_monthCalendar.Width - 2) / 2
                .Left = 1
                .Text = "OK"
            End With

            m_cancelButton = New Button
            With m_cancelButton
                .Parent = m_backPanel
                .Top = m_monthCalendar.Height - 20
                .Height = 20
                .Width = (m_monthCalendar.Width - 2) / 2
                .Left = .Width + 1
                .Text = "Annuler"
            End With

            With Me
                .FormBorderStyle = FormBorderStyle.None
                .Width = m_monthCalendar.Width
                .Height = m_okButton.Top + m_okButton.Height + 1
                .StartPosition = FormStartPosition.Manual
            End With

        End Sub

        Friend Property CalendarDate As Nullable(Of DateTime)
            Get
                Return m_date
            End Get
            Set(value As Nullable(Of DateTime))
                m_date = value

                If (m_date IsNot Nothing) AndAlso (IsDate(m_date.Value)) Then
                    m_monthCalendar.SetDate(m_date)
                End If

            End Set
        End Property

        Private Sub m_okButton_MouseUp(sender As Object, e As MouseEventArgs) Handles m_okButton.MouseUp

            If e.Button = MouseButtons.Left Then
                Me.Hide()
                Me.DialogResult = DialogResult.OK
                m_date = m_monthCalendar.SelectionStart
            End If

        End Sub

        Private Sub m_cancel_MouseUp(sender As Object, e As MouseEventArgs) Handles m_cancelButton.MouseUp

            If e.Button = MouseButtons.Left Then
                Me.Hide()
                Me.DialogResult = DialogResult.Cancel
            End If

        End Sub

    End Class

End Class

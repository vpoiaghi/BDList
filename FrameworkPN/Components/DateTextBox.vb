Public Class DateTextBox
    Inherits Panel

    Public Shadows Event DateChanged(sender As Object, e As EventArgs)

    Private WithEvents m_textbox As TextBox
    Private Shared m_dateSelector As New DateSelector

    Private m_dateFormat As String = "dd/MM/yyyy"
    Private m_date As Nullable(Of DateTime) = Nothing

    Public Sub New()

        m_textbox = New TextBox
        With m_textbox
            .Parent = Me
            .Dock = DockStyle.Fill
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

    Public Overrides Property Text As String
        Get
            Return m_textbox.Text
        End Get
        Set(value As String)
            m_textbox.Text = value
        End Set
    End Property

    Public Function GetDate() As Nullable(Of DateTime)
        Return m_date
    End Function

    Public Sub SetDate(value As Nullable(Of DateTime))
        m_date = value

        If m_date Is Nothing Then
            m_textbox.Text = ""
        Else
            m_date = CDate(m_date.Value.ToString("dd/MM/yyyy") & " 00:00:00")
            m_textbox.Text = Format(m_date, m_dateFormat)
        End If

        RaiseEvent DateChanged(Me, New EventArgs())

    End Sub

    Private Sub DateTextBox_LostFocus(sender As Object, e As EventArgs) Handles m_textbox.LostFocus

        m_textbox.Text = m_textbox.Text.Trim

        If Not String.IsNullOrEmpty(m_textbox.Text) Then

            If IsDate(m_textbox.Text) Then
                m_date = CDate(m_textbox.Text)
                m_date = CDate(m_date.Value.ToString("dd/MM/yyyy") & " 00:00:00")
                m_textbox.Text = Format(m_date.Value, m_dateFormat)
            Else
                m_date = Nothing
                MsgBox("Le format de la date saisie n'est pas reconnu.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Date invalide...")
                m_textbox.Focus()
            End If

        Else
            m_date = Nothing
        End If

        RaiseEvent DateChanged(Me, e)

    End Sub

    Private Sub m_textbox_MouseUp(sender As Object, e As MouseEventArgs) Handles m_textbox.MouseUp

        If e.Button = MouseButtons.Right Then
            m_dateSelector.Location = CType(sender, TextBox).ClientRectangle.Location
            m_dateSelector.CalendarDate = m_date

            With m_textbox.Location
                m_dateSelector.Location = m_textbox.PointToScreen(New Point(.X - 2 * m_textbox.Left, .Y))
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

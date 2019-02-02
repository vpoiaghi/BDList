Public Class MoneyTextBox
    Inherits TextBox

    Private m_onChange As Boolean = False
    Private m_backColor = Me.BackColor

    Public Sub New()
        MyBase.New
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub MoneyTextBox_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged

        If Not m_onChange Then
            m_onChange = True

            Dim txt As String = Me.Text.Replace(".", ",")

            If IsNumeric(txt) Then
                Dim selStart As Integer = Me.SelectionStart
                Dim selLength As Integer = Me.SelectionLength

                Me.Text = txt
                Me.SelectionStart = selStart
                Me.SelectionLength = selLength
                Me.BackColor = m_backColor

            Else
                Me.BackColor = Color.Red
            End If

            m_onChange = False
        End If

    End Sub

End Class

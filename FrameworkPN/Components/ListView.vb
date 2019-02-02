Public Class ListView
    Inherits System.Windows.Forms.ListView

    Private Sub AdaptListViewColumnsWidth()

        If Me.Columns.Count > 0 Then

            Dim listviewWidth As Integer = Me.Width - 25

            Dim colIndex As Integer
            Dim initSumWidths As Integer = 0
            Dim adaptedSumWidths As Integer = 0

            For colIndex = 0 To Me.Columns.Count - 1
                initSumWidths += Me.Columns(colIndex).Width
            Next

            Dim r As Single = listviewWidth / initSumWidths

            For colIndex = 0 To Me.Columns.Count - 2
                Me.Columns(colIndex).Width *= r
                adaptedSumWidths += Me.Columns(colIndex).Width
            Next

            Me.Columns(Me.Columns.Count - 1).Width = listviewWidth - adaptedSumWidths

        End If

    End Sub

    Private Sub ListView_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged
        AdaptListViewColumnsWidth()
    End Sub

    Private Sub ListView_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        AdaptListViewColumnsWidth()
    End Sub

    Private Sub ListView_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        AdaptListViewColumnsWidth()
    End Sub

End Class

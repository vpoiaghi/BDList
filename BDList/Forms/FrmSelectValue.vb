Public Class FrmSelectValue

    Public Delegate Function AddNewItem() As Object

    Private m_result As Object = Nothing
    Private Shared m_newFunction As AddNewItem

    Public Shared Function SelectValue(objects As IEnumerable(Of Object), text As String) As Object
        Return SelectValue(objects, text, Nothing)
    End Function

    Public Shared Function SelectValue(objects As IEnumerable(Of Object), text As String, newFunction As AddNewItem) As Object

        Dim frm As New FrmSelectValue
        frm.Label1.Text = text

        For Each o As Object In objects
            frm.cmbValues.Items.Add(o)
        Next

        frm.Btn_Add.Visible = (newFunction IsNot Nothing)
        m_newFunction = newFunction

        frm.ShowDialog()
        Dim result As Object = frm.GetResult

        frm.Dispose()

        Return result

    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        m_result = cmbValues.SelectedItem
        Me.Close()
    End Sub

    Private Function GetResult() As Object
        Return m_result
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Btn_Add_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn_Add.MouseDown

        Dim newObject As Object = m_newFunction.Invoke()
        cmbValues.Items.Add(newObject)
        cmbValues.SelectedItem = newObject

    End Sub
End Class
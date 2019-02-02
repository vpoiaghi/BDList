Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FrmStat

    Protected Sub RefreshStats()

        Dim serviceSerie As New ServiceSerie
        Dim serviceEdition As New ServiceEdition
        Dim serviceEditor As New ServiceEditor
        Dim serviceGoody As New ServiceGoody

        Dim editors As List(Of IdBObject) = serviceEditor.GetAll()

        Label1.Text = "Nombre de séries : " & serviceSerie.GetAllWithEditionsCount()
        Label2.Text = "Nombre d'éditions en possession : " & serviceEdition.GetInPossessionCount()
        Label3.Text = "Nombre d'intégrales en possession : " & serviceEdition.GetIntegralsInPossessionCount()
        Label4.Text = "Nombre de coffrets en possession : " & serviceGoody.GetBoxesInPossessionCount()
        Label6.Text = "Nombre de fourreaux en possession : " & serviceGoody.GetSheathsInPossessionCount()
        Label5.Text = "Nombre de receuils en possession : " & serviceEdition.GetMiscellaniesInPossessionCount()

        Dim n As Integer

        ListBox1.Items.Clear()
        For Each editor As Editor In editors
            n = serviceEdition.GetInPossessionByEditorCount(editor)
            If n > 0 Then
                ListBox1.Items.Add(editor.GetName & " : " & n)
            End If
        Next

        Dim editionsByMonth As List(Of CountByMonth) = serviceEdition.GetInPossessionByMonths()

        Chart1.Series(0).Points.Clear()
        Chart1.Series(0).XValueType = ChartValueType.String
        Chart1.Series(0).IsXValueIndexed = False

        For Each editionCount As CountByMonth In editionsByMonth
            Chart1.Series(0).Points.AddXY(editionCount.GetDate.ToString("yyyy"), editionCount.GetCount)
        Next

        If editionsByMonth.Count > 0 Then
            Chart1.ChartAreas(0).AxisX.Interval = 12
        End If

    End Sub

End Class
Imports BDList_SERVICE
Imports FrameworkPN

Public Class UC_Statistics

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()
    End Sub

    Protected Overrides Sub Activate()

        Dim serviceSerie As New ServiceSerie
        Lbl_SeriesStartedCount.Text = "Nb séries commencées : " & serviceSerie.GetAllWithEditionsCount()
        Lbl_SeriesFullCount.Text = "Nb séries complètes : " & serviceSerie.GetAllWithEditionsFullCount()
        Lbl_SeriesNotFullCount.Text = "Nb séries commencées mais incomplètes : " & serviceSerie.GetAllWithEditionsNotFullCount()

        Dim serviceEdition As New ServiceEdition
        Lbl_EditionsInCount.Text = "Nb d'éditions en possession : " & serviceEdition.GetInPossessionCount()

        Dim serviceTitle As New ServiceTitle
        Lbl_TitlesInCount.Text = "Nb de titres en possession : " & serviceTitle.GetInPossessionCount()

    End Sub

End Class

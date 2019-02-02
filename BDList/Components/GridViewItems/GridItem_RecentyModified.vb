Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports FrameworkPN

Public Class GridItem_RecentyModified

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Overrides Sub Redraw()

        If TypeOf m_value Is Edition Then
            RedrawEdition(CType(m_value, Edition))
        ElseIf TypeOf m_value Is Goody Then
            RedrawGoody(CType(m_value, Goody))
        End If

    End Sub

    Private Sub RedrawEdition(edition As Edition)

        Dim svcEdition As New ServiceEdition
        Dim firstCoverFile As IFile = svcEdition.GetFirstCoverFile(edition, True)

        If firstCoverFile Is Nothing Then
            PictureBox1.Image = Nothing
        Else
            PictureBox1.Image = ImageUtils.LoadImage(firstCoverFile)
        End If

    End Sub

    Private Sub RedrawGoody(goody As Goody)

        Dim svcGoody As New ServiceGoody
        Dim files As List(Of IFile) = svcGoody.GetFiles(goody)

        If files.Count > 0 Then
            PictureBox1.Image = ImageUtils.LoadImage(files(0))
        Else
            PictureBox1.Image = Nothing
        End If

    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        ModifyItem()
    End Sub

    Public Overrides Sub ModifyItem()

        If TypeOf m_value Is Edition Then
            ModifyEditionItem()
        ElseIf TypeOf m_value Is Goody Then
            ModifyGoodyItem
        End If

    End Sub

    Private Sub ModifyEditionItem()

        Dim edition As Edition = CType(m_value, Edition)
        Dim serie As Serie = CType(edition.GetSeries(0), Serie)

        Dim modifiedEdition As ModifiedItem = FrmWriteEdition.CreateOrEdit(Me.ParentForm, edition, serie)

        If modifiedEdition IsNot Nothing Then

            m_value = modifiedEdition.GetItem
            Redraw()

            Dim eventArgs As New GridItemActionEventArgs(GridItemActionEventArgs.listItemActions.Modify)
            eventArgs.AddParameter(NavParameters.PRM_EDITION_ID, CType(m_value, Edition).GetId)

            SendActionEvent(eventArgs)

        End If

    End Sub

    Private Sub ModifyGoodyItem()

        Dim goody As Goody = CType(m_value, Goody)
        Dim serie As Serie = CType(goody.GetSeries(0), Serie)

        Dim modifiedGoody As ModifiedItem = FrmWriteGoody.CreateOrEdit(Me.ParentForm, goody, serie)

        If modifiedGoody IsNot Nothing Then

            m_value = modifiedGoody.GetItem
            Redraw()

            Dim eventArgs As New GridItemActionEventArgs(GridItemActionEventArgs.listItemActions.Modify)
            eventArgs.AddParameter(NavParameters.PRM_GOODY_ID, CType(m_value, Goody).GetId)

            SendActionEvent(eventArgs)

        End If

    End Sub

End Class

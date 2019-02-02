Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS

Public Class FrmWriteSerie

    Private m_serie As Serie
    Private m_serieResult As Serie

    Private m_manager As Author

    Private m_lstKinds As List(Of IdBObject)
    Private m_lstOrigins As List(Of IdBObject)
    Private m_lstAuthors As List(Of IdBObject)

    Private Sub New()
        MyBase.New()

        InitializeComponent()

        m_serie = Nothing
        m_serieResult = Nothing

    End Sub

    Private Sub New(ByRef serie As Serie)
        Me.New()
        m_serie = serie
    End Sub

    Public Shared Function CreateOrEdit(owner As Form, serie As Serie) As Serie

        If serie Is Nothing Then
            serie = (New ServiceSerie).GetNew()
        End If

        Dim frm As New FrmWriteSerie(serie)
        frm.ShowDialog(owner)
        serie = frm.GetSerie
        frm.Dispose()

        If serie IsNot Nothing Then
            Dim serviceSerie As New ServiceSerie()
            serviceSerie.InsertOrUpdate(serie)
        End If

        Return serie

    End Function

    Public Function GetSerie() As Serie
        Return m_serieResult
    End Function

    Private Sub FrmWriteSerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitialiseKindList()
        InitialiseOriginList()

        radFinished.Checked = True

        If m_serie IsNot Nothing Then

            txtName.Text = m_serie.GetName
            txtWebSite.Text = m_serie.GetWebSite
            rtbStory.Text = m_serie.GetStory

            Select Case m_serie.IsEnded
                Case BoSerie.STATE_FINISHED : radFinished.Checked = True
                Case BoSerie.STATE_ABORTED : radAborted.Checked = True
                Case BoSerie.STATE_ONGOING : radOngoing.Checked = True
            End Select

            If m_serie.GetKind IsNot Nothing Then
                cmbKind.SelectedItem = m_serie.GetKind
            End If

            If m_serie.GetOrigin IsNot Nothing Then
                cmbOrigin.SelectedItem = m_serie.GetOrigin
            End If

            If m_serie.GetManager IsNot Nothing Then
                m_manager = m_serie.GetManager
                TxtManager.Text = m_serie.GetManager.ToString
            End If

        End If

    End Sub

    Private Sub InitialiseKindList()

        Dim svcKind As New ServiceKind
        m_lstKinds = svcKind.GetAll()

        For Each k As Kind In m_lstKinds
            cmbKind.Items.Add(k)
        Next

    End Sub

    Private Sub InitialiseOriginList()

        Dim svcOrigin As New ServiceOrigin
        m_lstOrigins = svcOrigin.GetAll()

        For Each o As Origin In m_lstOrigins
            cmbOrigin.Items.Add(o)
        Next

    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        Dim serviceSerie As New ServiceSerie
        Dim allowSave As Boolean = ValidateBeforeSave()

        Dim kind As Kind = Nothing
        Dim origin As Origin = Nothing

        If allowSave Then
            kind = GetKind()
            allowSave = (kind IsNot Nothing)
        End If

        If allowSave Then
            origin = GetOrigin()
            allowSave = (origin IsNot Nothing)
        End If

        If allowSave Then
            m_serie.SetName(txtName.Text)
            m_serie.SetKind(kind)
            m_serie.SetOrigin(origin)

            If radOngoing.Checked Then
                m_serie.SetEnded(BoSerie.STATE_ONGOING)
            ElseIf radFinished.Checked Then
                m_serie.SetEnded(BoSerie.STATE_FINISHED)
            ElseIf radAborted.Checked Then
                m_serie.SetEnded(BoSerie.STATE_ABORTED)
            End If

            m_serie.SetWebSite(txtWebSite.Text.Trim)
            m_serie.SetStory(rtbStory.Text.Trim)
            m_serie.SetManager(m_manager)

            m_serieResult = m_serie
            Me.Close()
        End If

    End Sub

    Private Function ValidateBeforeSave() As Boolean

        Dim serviceSerie As New ServiceSerie

        Dim allowSave As Boolean = False
        Dim errMsg As String = Nothing

        If String.IsNullOrEmpty(txtName.Text.Trim) Then
            errMsg = "Indiquez un nom pour la série."
        ElseIf String.IsNullOrEmpty(cmbKind.Text.Trim) Then
            errMsg = "Indiquez un genre pour la série."
        ElseIf String.IsNullOrEmpty(cmbOrigin.Text.Trim) Then
            errMsg = "Indiquez une origine pour la série."
        ElseIf Not (radOngoing.Checked Or radFinished.Checked Or radAborted.Checked) Then
            errMsg = "Indiquez si la série est terminée ou non."
        End If

        If errMsg IsNot Nothing Then
            Call MsgBox(errMsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Informations incomplètes...")
        Else

            Dim name As String = txtName.Text.Trim
            If Not String.IsNullOrEmpty(name) Then
                name = name.Substring(0, 1).ToUpper & name.Substring(1)
            End If

            If m_serie Is Nothing Then
                m_serie = serviceSerie.GetNew
                allowSave = True

            ElseIf name <> m_serie.GetName Then

                ' Vérifier que le nouveau nom ne correspond pas à une série existante.
                Dim lstSeries As List(Of IdBObject) = serviceSerie.GetSeriesByName(name)

                If (lstSeries.Count > 0) Then
                    ' Si une série portant ce nom existe déjà.

                    ' Demander confirmation pour modifier la série existante.
                    ' Si non, l'enregistrement est annulé.
                    Dim msg As String = "Une série du même nom existe déjà. Voulez-vous modifier la série existante ?" & vbCrLf _
                                      & "Note : La série initialement sélectionnée pour être modifiée (" & m_serie.GetName() & ") ne sera pas modifiée."

                    If MsgBox(msg, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Série existante...") = MsgBoxResult.Yes Then
                        m_serie = lstSeries(0)
                        allowSave = True
                    End If
                Else
                    ' Si aucune série portant ce nom n'existe.
                    allowSave = True
                End If
            Else
                allowSave = True
            End If
        End If

        Return allowSave

    End Function

    Private Function GetKind() As Kind

        Dim kind As Kind = Nothing
        Dim name As String = cmbKind.Text.Trim

        If (Not String.IsNullOrEmpty(name)) Then

            Dim index As Integer = cmbKind.FindStringExact(name)

            If (index = -1) Then

                name = name.Trim
                name = name.Substring(0, 1).ToUpper & name.Substring(1)

                If MsgBox("Le genre """ & name & """ n'existe pas. Voulez-vous le créer ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Genre inconnu...") = MsgBoxResult.Yes Then

                    Dim serviceKind As New ServiceKind

                    kind = serviceKind.GetNew
                    kind.SetName(name)

                    serviceKind.InsertOrUpdate(kind)

                End If
            Else
                kind = m_lstKinds(index)
            End If
        End If

        Return kind

    End Function

    Private Function GetOrigin() As Origin

        Dim origin As Origin = Nothing
        Dim name As String = cmbOrigin.Text.Trim

        If (Not String.IsNullOrEmpty(name)) Then

            Dim index As Integer = cmbOrigin.FindStringExact(name)

            If (index = -1) Then

                name = name.Trim
                name = name.Substring(0, 1).ToUpper & name.Substring(1)

                If MsgBox("L'origine """ & name & """ n'existe pas. Voulez-vous la créer ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Origine inconnue...") = MsgBoxResult.Yes Then

                    Dim serviceOrigin As New ServiceOrigin

                    origin = serviceOrigin.GetNew
                    origin.SetName(name)

                    serviceOrigin.InsertOrUpdate(origin)

                End If

            Else
                origin = m_lstOrigins(index)
            End If
        End If

        Return origin

    End Function

    Private Sub BtnSelectManager_Click(sender As Object, e As EventArgs) Handles BtnSelectManager.Click

        Dim modifiedItem As ModifiedItem = FrmWriteAuthor.CreateOrEdit(Me, m_manager)

        If modifiedItem IsNot Nothing Then
            m_manager = modifiedItem.GetItem

            If m_manager Is Nothing Then
                TxtManager.Text = ""
            Else
                TxtManager.Text = m_manager.ToString
            End If

        End If

    End Sub

    Private Sub BtnHeader_Click(sender As Object, e As EventArgs) Handles BtnHeader.Click

        Dim cmd As String = "F:\collections\BDs\Projet Net\EN COURS\Bandeaux\Bandeaux\bin\Release\Bandeaux.exe"
        Dim args As String = """" & m_serie.GetSortName() & """"

        Dim psInfo As New System.Diagnostics.ProcessStartInfo(cmd, args)
        psInfo.WindowStyle = ProcessWindowStyle.Hidden
        Dim prc As System.Diagnostics.Process = System.Diagnostics.Process.Start(psInfo)

        prc.WaitForExit()

        Dim f As FrmMain = CType(Me.Owner, FrmMain)
        Dim pageName As String = f.GetCurrentPageName()
        If pageName = GetType(UC_Serie).FullName Then
            Dim page As Object = f.GetCurrentPage()
            CType(page, UC_Serie).DrawHeader()
        End If

    End Sub
End Class
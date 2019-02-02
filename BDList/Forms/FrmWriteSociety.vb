Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class FrmWriteSociety

    Private m_society As Society
    Private m_societyResult As Society

    Private Sub New()
        MyBase.New()

        InitializeComponent()

        m_society = Nothing
        m_societyResult = Nothing

    End Sub

    Private Sub New(ByRef society As Society)
        Me.New()
        m_society = society
    End Sub

    Public Shared Function CreateOrEdit(owner As Form, society As Society) As Society

        Dim frm As New FrmWriteSociety(society)
        frm.ShowDialog(owner)
        society = frm.GetSociety
        frm.Dispose()

        If society IsNot Nothing Then
            Dim serviceSociety As New ServiceSociety()
            serviceSociety.InsertOrUpdate(society)
        End If

        Return society

    End Function

    Public Function GetSociety() As Society
        Return m_societyResult
    End Function

    Private Sub FrmWriteSociety_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If m_society IsNot Nothing Then

            txtName.Text = m_society.GetName
            txtWebSite.Text = m_society.GetWebSite
        End If

    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        Dim serviceSociety As New ServiceSociety

        Dim allowSave As Boolean = False
        Dim errMsg As String = Nothing

        Dim name As String = txtName.Text.Trim

        If String.IsNullOrEmpty(name) Then
            errMsg = "Indiquez un nom pour la société."
        Else
            name = name.Substring(0, 1).ToUpper & name.Substring(1)
        End If

        If errMsg IsNot Nothing Then
            Call MsgBox(errMsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Informations incomplètes...")
        Else

            If m_society Is Nothing Then
                m_society = serviceSociety.GetNew
                allowSave = True

            ElseIf name.ToLower <> m_society.GetName.ToLower Then

                ' Vérifier que le nouveau nom ne correspond pas à une société existante.
                Dim lstSocieties As List(Of IdBObject) = serviceSociety.GetByName(name)

                If (lstSocieties.Count > 0) Then
                    ' Si une société portant ce nom existe déjà.

                    ' Demander confirmation pour modifier la société existante.
                    ' Si non, l'enregistrement est annulé.
                    Dim msg As String = "Une société du même nom existe déjà. Voulez-vous modifier la société existante ?" & vbCrLf _
                                      & "Note : La société initialement sélectionnée pour être modifiée (" & m_society.ToString & ") ne sera pas modifiée."

                    If MsgBox(msg, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Société existante...") = MsgBoxResult.Yes Then
                        m_society = lstSocieties(0)
                        allowSave = True
                    End If
                Else
                    ' Si aucune société portant ce nom n'existe.
                    allowSave = True
                End If
            Else
                allowSave = True
            End If
        End If

        If allowSave Then
            m_society.SetName(name)
            m_society.SetWebSite(txtWebSite.Text.Trim)

            m_societyResult = m_society
            Me.Close()
        End If

    End Sub
End Class
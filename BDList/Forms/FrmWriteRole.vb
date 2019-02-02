Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class FrmWriteRole

    Private m_role As Role
    Private m_roleResult As Role

    Private Sub New()
        MyBase.New()

        InitializeComponent()

        m_role = Nothing
        m_roleResult = Nothing

    End Sub

    Private Sub New(ByRef role As Role)
        Me.New()
        m_role = role
    End Sub

    Public Shared Function CreateOrEdit(owner As Form, role As Role) As Role

        Dim frm As New FrmWriteRole(role)
        frm.ShowDialog(owner)
        role = frm.GetRole
        frm.Dispose()

        If role IsNot Nothing Then
            Dim serviceRole As New ServiceRole()
            serviceRole.InsertOrUpdate(role)
        End If

        Return role

    End Function

    Public Function GetRole() As Role
        Return m_roleResult
    End Function

    Private Sub FrmWriteRole_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If m_role IsNot Nothing Then
            txtName.Text = m_role.GetName
        End If

    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        Dim serviceRole As New ServiceRole

        Dim allowSave As Boolean = False
        Dim errMsg As String = Nothing

        If String.IsNullOrEmpty(txtName.Text) Then
            errMsg = "Indiquez un nom pour le rôle."
        End If

        Dim name As String = txtName.Text.Trim
        If Not String.IsNullOrEmpty(name) Then
            name = name.Substring(0, 1).ToUpper & name.Substring(1)
        End If

        If errMsg IsNot Nothing Then
            Call MsgBox(errMsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Informations incomplètes...")
        Else

            If m_role Is Nothing Then
                m_role = serviceRole.GetNew
                allowSave = True

            ElseIf name.ToLower <> m_role.GetName.ToLower Then

                ' Vérifier que le nouveau nom ne correspond pas à un rôle existant.
                Dim lstRoles As List(Of IdBObject) = serviceRole.GetByName(name)

                If (lstRoles.Count > 0) Then
                    ' Si un rôle portant ce nom existe déjà.

                    ' Demander confirmation pour modifier le rôle existant.
                    ' Si non, l'enregistrement est annulé.
                    Dim msg As String = "Un rôle du même nom existe déjà. Voulez-vous modifier le rôle existant ?" & vbCrLf _
                                      & "Note : Le rôle initialement sélectionné pour être modifié (" & m_role.ToString & ") ne sera pas modifié."

                    If MsgBox(msg, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Rôle existant...") = MsgBoxResult.Yes Then
                        m_role = lstRoles(0)
                        allowSave = True
                    End If
                Else
                    ' Si aucun rôle portant ce nom n'existe.
                    allowSave = True
                End If
            Else
                allowSave = True
            End If
        End If

        If allowSave Then
            m_role.SetName(name)

            m_roleResult = m_role
            Me.Close()
        End If

    End Sub
End Class
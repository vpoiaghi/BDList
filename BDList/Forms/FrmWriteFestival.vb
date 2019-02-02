Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class FrmWriteFestival

    Private Shared m_serviceFestival As New ServiceFestival

    Private m_festival As Festival
    Private m_modifiedItem As ModifiedItem

    Private Sub New()
        MyBase.New()

        InitializeComponent()

    End Sub

    Private Sub New(ByRef festivalToEdit As ModifiedItem)
        Me.New()

        If (festivalToEdit Is Nothing) OrElse (festivalToEdit.GetItem Is Nothing) Then
            Throw New ArgumentNullException()
        End If

        m_festival = festivalToEdit.GetItem
        m_modifiedItem = festivalToEdit

    End Sub

    Public Shared Function CreateOrEdit(owner As Form) As ModifiedItem
        Return CreateOrEdit(owner, Nothing)
    End Function

    Public Shared Function CreateOrEdit(owner As Form, festival As Festival) As ModifiedItem

        Dim isNewFestival As Boolean = False
        Dim modifiedFestival As ModifiedItem = Nothing

        If festival Is Nothing Then
            festival = m_serviceFestival.GetNew
            isNewFestival = True
        End If

        If festival Is Nothing Then
            Throw New NullReferenceException()

        Else
            modifiedFestival = New ModifiedItem(festival)

            Dim frm As New FrmWriteFestival(modifiedFestival)
            frm.ShowDialog(owner)

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                m_serviceFestival.InsertOrUpdate(festival)
            Else
                If isNewFestival Then
                    m_serviceFestival.Delete(festival)
                End If
                modifiedFestival = Nothing
            End If

            frm.Close()
            frm.Dispose()

        End If

        Return modifiedFestival

    End Function

    Private Sub FrmWriteFestival_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm(m_festival)
    End Sub

    Private Sub InitForm(oldFestival As Festival)

        InitFestivalInfos(oldFestival)
        InitInSigningAuthors(oldFestival)
        InitReminders(oldFestival)

    End Sub

    Private Sub InitFestivalInfos(oldFestival As Festival)

        If oldFestival IsNot Nothing Then
            txt_Name.Text = oldFestival.GetName
            dtb_FromDate.SetDate(oldFestival.GetBeginDate)
            dtb_ToDate.SetDate(oldFestival.GetEndDate)
        End If

    End Sub

    Private Sub InitInSigningAuthors(oldFestival As Festival)

    End Sub

    Private Sub InitReminders(oldFestival As Festival)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Save()
        Me.Hide()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Save()

        Dim allowSave As Boolean = ValidateBeforeSave()

        m_festival.SetName(ToNullableString(txt_Name.Text.Trim))
        m_festival.SetBeginDate(dtb_FromDate.GetDate)
        m_festival.SetEndDate(dtb_ToDate.GetDate)

    End Sub

    Private Function ValidateBeforeSave() As Boolean

        Dim allowSave As Boolean = False
        Dim errMsg As String = Nothing

        If String.IsNullOrEmpty(txt_Name.Text.Trim) Then
            errMsg = "Le festival doit avoir un nom."
        End If

        Dim d As String = dtb_FromDate.Text.Trim
        If (String.IsNullOrEmpty(d)) Then
            errMsg = "Indiquez la date de début du festival."
        ElseIf (Not String.IsNullOrEmpty(d)) AndAlso (Not IsDate(d)) Then
            errMsg = "Le format de la date de début du festival n'est pas valide."
        End If

        d = dtb_ToDate.Text.Trim
        If (String.IsNullOrEmpty(d)) Then
            errMsg = "Indiquez la date de fin du festival."
        ElseIf (Not String.IsNullOrEmpty(d)) AndAlso (Not IsDate(d)) Then
            errMsg = "Le format de la date de fin du festival n'est pas valide."
        End If

        If errMsg IsNot Nothing Then
            Call MsgBox(errMsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Informations incomplètes ou erronées...")
        Else
            allowSave = True
        End If

        Return allowSave

    End Function


End Class
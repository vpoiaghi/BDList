Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Class FrmWriteAuthorAlias

    Private m_authorAlias As Author
    Private m_person As Person

    Private Sub New(person As Person)

        InitializeComponent()

        m_authorAlias = Nothing
        m_person = person

        RadNewAlias.Checked = True

        If (person IsNot Nothing) AndAlso (Not person.IsUnknown) Then
            RadAddAliasFromPerson.Text = "Définir " & person.ToString & " comme auteur."
            RadAddAliasFromPerson.Visible = True
        Else
            RadAddAliasFromPerson.Visible = False
        End If

    End Sub

    Public Shared Function Create(owner As IWin32Window, person As Person) As Author

        Dim frm As New FrmWriteAuthorAlias(person)
        frm.ShowDialog(owner)
        Dim authorAlias As Author = frm.m_authorAlias
        frm.Dispose()

        If authorAlias IsNot Nothing Then
            Dim serviceAuthor As New ServiceAuthor()
            serviceAuthor.InsertOrUpdate(authorAlias)
        End If

        Return authorAlias

    End Function

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        Dim serviceAuthor As New ServiceAuthor

        m_authorAlias = serviceAuthor.GetNew()
        m_authorAlias.GetPersons.Add(m_person)

        If RadNewAlias.Checked Then

            Dim newAlias As String = TxtNewAlias.Text.Trim
            newAlias = newAlias.Substring(0, 1).ToUpper & newAlias.Substring(1)

            m_authorAlias.SetAlias(newAlias)

        End If

        Me.Hide()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
    End Sub

End Class
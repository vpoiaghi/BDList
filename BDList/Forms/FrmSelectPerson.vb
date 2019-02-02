Imports BDList_DAO_BO.BO
Imports BDList_TOOLS
Imports BDList_SERVICE

Public Class FrmSelectPerson

    Private m_person As Person

    Private Sub FrmNewPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim servicePerson As New ServicePerson
        Dim persons As List(Of IdBObject) = servicePerson.GetAll()

        For Each p As Person In persons
            LvwPersons.Items.Add(p.ToString).Tag = p
        Next

    End Sub

    Private Sub LvwPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvwPersons.SelectedIndexChanged

        If LvwPersons.SelectedItems.Count > 0 Then
            m_person = LvwPersons.SelectedItems(0).Tag
        Else
            m_person = Nothing
        End If


    End Sub

    Private Sub TxtLastname_TextChanged(sender As Object, e As EventArgs) Handles TxtLastname.TextChanged
        UpdateList()
    End Sub

    Private Sub TxtFirstname_TextChanged(sender As Object, e As EventArgs) Handles TxtFirstname.TextChanged
        UpdateList()
    End Sub

    Private Function GetPerson() As Person
        Return m_person
    End Function

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Me.Hide()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        m_person = Nothing
        Me.Hide()
    End Sub

    Public Shared Function SelectPerson(owner As System.Windows.Forms.IWin32Window) As Person

        Dim frm As New FrmSelectPerson
        frm.ShowDialog(owner)

        Dim selectedPerson As Person = frm.GetPerson

        frm.Close()
        frm = Nothing

        Return selectedPerson

    End Function

    Private Sub UpdateList()

        Dim firstname As String = TxtFirstname.Text.Trim
        If Not String.IsNullOrEmpty(firstname) Then firstname = "%" & firstname & "%"

        Dim lastname As String = TxtLastname.Text.Trim
        If Not String.IsNullOrEmpty(lastname) Then lastname = "%" & lastname & "%"


        Dim servicePerson As New ServicePerson
        Dim persons As List(Of IdBObject) = servicePerson.GetByNames(lastname, firstname)

        LvwPersons.Items.Clear()

        For Each p As Person In persons
            LvwPersons.Items.Add(p.ToString).Tag = p
        Next

    End Sub

End Class
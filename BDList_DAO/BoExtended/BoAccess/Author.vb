Imports BDList_DAO_BO.DAO

Namespace BO

    Public Class Author
        Inherits BoAuthor

        Private Shared ReadOnly m_dao As DaoAuthor = DaoManager.GetDao(Of DaoAuthor)()
        Private m_persons As List(Of IdBObject)

        Public Function GetPersons() As List(Of IdBObject)

            If m_persons Is Nothing Then

                Dim id As Long? = Me.GetId

                If id IsNot Nothing Then
                    m_persons = m_dao.GetLinkedPersons(Me)
                Else
                    m_persons = New List(Of IdBObject)
                End If

            End If

            Return m_persons

        End Function

        Public Sub SetPersons(persons As List(Of IdBObject))
            m_persons = persons
        End Sub

        Public Function IsAlias() As Boolean
            Return Not String.IsNullOrEmpty(GetAlias())
        End Function

        Public Function IsPerson() As Boolean
            Return Not IsAlias()
        End Function

        Public Overrides Function ToString() As String

            Dim result As String = GetAlias()

            If String.IsNullOrEmpty(result) Then
                ' Si l'auteur n'a pas d'alias, il peut n'y avoir qu'une seule personne derrière l'auteur.
                With GetPersons()
                    result = .Item(0).ToString
                End With

            End If

            Return result

        End Function

    End Class

End Namespace
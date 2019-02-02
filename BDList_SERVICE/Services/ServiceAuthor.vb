Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS.IO

Public Class ServiceAuthor
    Inherits Service(Of DaoAuthor)

    Public Overrides Function GetAll() As List(Of IdBObject)

        ' Un appel au getAll du service ServicePerson est fait
        ' pour être sure que les personnes sont déjà en caches
        ' avant d'appeler le getAll du service ServiceAuthor.
        ' Il s'agit d'une optimisation en temps de traitement.
        With New ServicePerson
            .GetAll()
        End With

        Return MyBase.GetAll

    End Function

    Public Function Search(searchCriteria As SearchCriteria) As List(Of IdBObject)
        Return GetDao().Search(searchCriteria)
    End Function


    Public Function GetByAlias(allias As String) As List(Of IdBObject)

        Return GetDao().GetByAlias(allias)

    End Function

    Public Function GetByPerson(p_person As Person) As List(Of IdBObject)

        Return GetDao().GetByPerson(p_person.GetId)

    End Function

    Public Function GetDirectory(author As Author) As IDirectory

        Dim dInfo As IDirectory = Nothing

        With author.GetPersons

            If .Count = 1 Then
                ' L'auteur est une personne

                Dim p As Person = .Item(0)

                If (p.IsUnknown()) Then
                    ' Si la personne est inconnu (on ne connait que l'alias)
                    ' --> le nom du dossier photo doit être l'alias de l'auteur
                    dInfo = DirNameGenerator.GetPersonsDir(author.GetAlias)

                Else
                    ' Si la personne est inconnu (on ne connait que l'alias)
                    ' --> le nom du dossier photo doit être le nom et le prénom de l'auteur
                    ' --> récupération du dossier via le service Person
                    dInfo = Factory.GetDirectory((New ServicePerson).GetFileParentDirPath(p))
                End If
            Else
                ' L'auteur est plus d'une personne
                ' --> le nom du dossier photo doit être l'alias de l'auteur
                dInfo = DirNameGenerator.GetPersonsDir(author.GetAlias)
            End If

        End With


        If (dInfo IsNot Nothing) AndAlso (Not dInfo.IsExists) Then
            dInfo.Create()
        End If

        Return dInfo

    End Function

    Public Overrides Function GetFile(bo As IdBObject, Optional fileIndex As Integer? = 1) As IFile

        Dim fInfo As IFile = Nothing
        Dim author As Author = CType(bo, Author)

        With author.GetPersons

            If .Count = 1 Then
                ' Une personne --> récupération du chemin du fichier par le ServicePerson
                fInfo = (New ServicePerson).GetFile(.Item(0))
            End If

            If fInfo Is Nothing Then
                ' Personne inconnue ou plus d'une personne --> le dossier photo doit porter l'alias de l'auteur
                Dim dInfo As IDirectory = GetDirectory(author)

                If dInfo IsNot Nothing Then
                    With dInfo.GetFiles("*.jpg")
                        If .Count > 0 Then
                            fInfo = Factory.GetFile(.ElementAt(0).GetFullName)
                        End If
                    End With
                End If

            End If

        End With

        Return fInfo

    End Function

    Public Overrides Sub InsertOrUpdate(author As IdBObject)

        Dim servicePerson As New ServicePerson

        For Each person As Person In CType(author, Author).GetPersons
            servicePerson.InsertOrUpdate(person)
        Next

        MyBase.InsertOrUpdate(author)

    End Sub

End Class

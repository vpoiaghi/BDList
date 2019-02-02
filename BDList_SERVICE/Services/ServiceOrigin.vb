Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO

Public Class ServiceOrigin
    Inherits Service(Of DaoOrigin)

    Public Function GetByName(name As String) As IdBObject

        With GetDao.GetByName(name)

            Select .Count
                Case 0 : Return Nothing
                Case 1 : Return .Item(0)
                Case Else : Throw New Exception(.Count & " origines trouvées avec le nom " & name & ".")
            End Select

        End With

    End Function

End Class

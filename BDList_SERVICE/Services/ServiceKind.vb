Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO

Public Class ServiceKind
    Inherits Service(Of DaoKind)

    Public Function GetByName(name As String) As IdBObject

        With GetDao.GetByName(name)

            Select Case .Count
                Case 0 : Return Nothing
                Case 1 : Return .Item(0)
                Case Else : Throw New Exception(.Count & " genres trouvés avec le nom " & name & ".")
            End Select

        End With

    End Function

End Class

Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO

Public Class ServiceTitle
    Inherits Service(Of DaoTitle)

    Public Function GetBySerie(serie As Serie) As List(Of IdBObject)

        Dim result As List(Of IdBobject) = Nothing

        Try

            If serie Is Nothing Then
                result = New List(Of IdBobject)
            Else
                result = GetBySerie(serie.GetId)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Public Function GetBySerie(idSerie As Long?) As List(Of IdBObject)

        Return GetDao().GetBySerie(idSerie)

    End Function

    Public Function GetCountBySerie(idSerie As Long?) As Integer
        Return GetDao().GetCountBySerie(idSerie)
    End Function

    Public Function GetInPossessionCount() As Integer
        Return GetDao().GetInPossessionCount()
    End Function

    Public Function GetCountInPosssessionBySerie(idSerie As Long?) As Integer
        Return GetDao().GetCountInPosssessionBySerie(idSerie)
    End Function

End Class

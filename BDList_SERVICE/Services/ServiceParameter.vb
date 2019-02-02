Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS

Public Class ServiceParameter
    Inherits Service(Of DaoParameter)

    Private Const PRM_LAST_PHONE_SYNC_DATE As String = "LastPhoneSyncDate"

    Public Shared Function GetLastPhoneSyncDate() As Date

        Dim value As String = GetValueByName(ServiceParameter.PRM_LAST_PHONE_SYNC_DATE, Format(Now, "dd/MM/yyyy HH:mm:ss"))

        Return Date.Parse(value)

    End Function

    Public Shared Sub SetLastPhoneSyncDate(value As Date)
        SetValueByName(ServiceParameter.PRM_LAST_PHONE_SYNC_DATE, Format(value, "dd/MM/yyyy HH:mm:ss"))
    End Sub

    Private Function GetByName(name As String) As List(Of IdBObject)
        Return GetDao().GetByName(name)
    End Function

    Private Shared Function GetValueByName(parameterName As String, defaultValue As String) As String

        Dim prm As Parameter = Nothing

        Dim serviceParameter As New ServiceParameter
        Dim parameters As List(Of IdBObject) = serviceParameter.GetByName(parameterName)

        If parameters.Count = 0 Then
            prm = serviceParameter.GetNew
            prm.SetName(serviceParameter.PRM_LAST_PHONE_SYNC_DATE)
            prm.SetValue(defaultValue)

            serviceParameter.InsertOrUpdate(prm)
        Else
            prm = parameters(0)
        End If

        Return prm.GetValue

    End Function

    Private Shared Sub SetValueByName(parameterName As String, value As String)

        Dim prm As Parameter = Nothing

        Dim serviceParameter As New ServiceParameter
        Dim parameters As List(Of IdBObject) = serviceParameter.GetByName(parameterName)

        If parameters.Count = 0 Then
            prm = serviceParameter.GetNew
            prm.SetName(serviceParameter.PRM_LAST_PHONE_SYNC_DATE)
        Else
            prm = parameters(0)
        End If

        prm.SetValue(value)
        serviceParameter.InsertOrUpdate(prm)

    End Sub

End Class

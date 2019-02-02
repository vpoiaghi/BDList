Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_TOOLS

Public Class ServicePhoneParameters
    Inherits Service(Of DaoPhoneParameters)

    Public Function GetParameters() As PhoneParameters
        Return GetAll()(0)
    End Function

End Class

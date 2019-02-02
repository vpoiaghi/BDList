Option Explicit On

Imports BDList_TOOLS.Types.Sql

Namespace BO

    Public MustInherit Class BoPhoneFestival
        Inherits IdBObject

        Private name As String
        Private beginDate As SqlDate
        Private endDate As SqlDate


        Public Function GetName() As String
            Return name
        End Function

        Public Sub SetName(value As String)
            name = value
        End Sub

        Public Function GetBeginDate() As SqlDate
            Return beginDate
        End Function

        Public Sub SetBeginDate(value As SqlDate)
            beginDate = value
        End Sub

        Public Function GetEndDate() As SqlDate
            Return endDate
        End Function

        Public Sub SetEndDate(value As SqlDate)
            endDate = value
        End Sub

    End Class

End Namespace
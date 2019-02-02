Option Explicit On

Imports BDList_TOOLS.Types.Sql

Namespace BO

    Public MustInherit Class BoPhoneParameters
        Inherits IdBObject

        Private newsDaysCount As Integer
        Private dataUpdateDate As SqlDate
        Private firstComingDate As SqlDate
        Private useDefaultFirstComingDate As Boolean
        Private eventPastDaysCount As Integer

        Public Function GetNewsDaysCount() As Integer
            Return newsDaysCount
        End Function

        Public Sub SetNewsDaysCount(value As Integer)
            newsDaysCount = value
        End Sub

        Public Function GetDataUpdateDate() As SqlDate
            Return dataUpdateDate
        End Function

        Public Sub SetDataUpdateDate(value As SqlDate)
            dataUpdateDate = value
        End Sub

        Public Function GetFirstComingDate() As SqlDate
            Return firstComingDate
        End Function

        Public Sub SetFirstComingDate(value As SqlDate)
            firstComingDate = value
        End Sub

        Public Function IsUseDefaultFirstComingDate() As Boolean
            Return useDefaultFirstComingDate
        End Function

        Public Sub SetUseDefaultFirstComingDate(value As Boolean)
            useDefaultFirstComingDate = value
        End Sub

        Public Function GetEventPastDaysCount() As Integer
            Return eventPastDaysCount
        End Function

        Public Sub SetEventPastDaysCount(value As Integer)
            eventPastDaysCount = value
        End Sub


    End Class

End Namespace
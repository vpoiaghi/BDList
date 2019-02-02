Option Explicit On

Namespace BO

    Public MustInherit Class BoPhoneTitle
        Inherits IdBObject

        Private idSerie As Integer
        Private name As String
        Private orderNumber As Integer
        Private story As String
        Private outSerie As Boolean
        Private inPossession As Boolean

        Public Function GetIdSerie() As Integer
            Return idSerie
        End Function

        Public Sub SetIdSerie(value As Integer)
            idSerie = value
        End Sub

        Public Function GetName() As String
            Return name
        End Function

        Public Sub SetName(value As String)
            name = value
        End Sub

        Public Function GetOrderNumber() As Integer
            Return orderNumber
        End Function

        Public Sub SetOrderNumber(value As Integer)
            orderNumber = value
        End Sub

        Public Function GetStory() As String
            Return story
        End Function

        Public Sub SetStory(value As String)
            story = value
        End Sub

        Public Function IsOutSerie() As Boolean
            Return outSerie
        End Function

        Public Sub SetOutSerie(value As Boolean)
            outSerie = value
        End Sub

        Public Function IsInPossession() As Boolean
            Return inPossession
        End Function

        Public Sub SetInPossession(value As Boolean)
            inPossession = value
        End Sub

    End Class

End Namespace
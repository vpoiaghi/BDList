Option Explicit On

Namespace BO

    Public MustInherit Class BoRecallEvent
        Inherits IdBObject

        Private startDate As Date?
        Private endDate As Date?
        Private name As String
        Private place As String
        Private comments As String
        Private state As Integer = 0
        Private reminderDays As Integer?
        Private persistenceDays As Integer?

        Public Function GetStartDate() As Date?
            Return startDate
        End Function
        Public Sub SetStartDate(value As Date)
            startDate = value
        End Sub

        Public Function GetEndDate() As Date?
            Return endDate
        End Function
        Public Sub SetEndDate(value As Date?)
            endDate = value
        End Sub

        Public Function GetName() As String
            Return name
        End Function
        Public Sub SetName(value As String)
            name = value
        End Sub

        Public Function GetPlace() As String
            Return place
        End Function
        Public Sub SetPlace(value As String)
            place = value
        End Sub

        Public Function GetComments() As String
            Return comments
        End Function
        Public Sub SetComments(value As String)
            comments = value
        End Sub

        Public Function GetState() As Integer
            Return state
        End Function
        Public Sub SetState(value As Integer)
            state = value
        End Sub

        Public Function GetReminderDays() As Integer?
            Return reminderDays
        End Function
        Public Sub SetReminderDays(value As Integer)
            reminderDays = value
        End Sub

        Public Function GetPersistenceDays() As Integer?
            Return persistenceDays
        End Function
        Public Sub SetPersistenceDays(value As Integer)
            persistenceDays = value
        End Sub

    End Class

End Namespace
Option Explicit On
Imports BDList_TOOLS.Types.Sql

Namespace BO

    Public MustInherit Class BoPhoneInSigning
        Inherits IdBObject

        Private idFestival As Integer
        Private idAuthor As Integer
        Private idEditor As Nullable(Of Integer)
        Private startHour As SqlDate
        Private endHour As SqlDate
        Private comments As String

        Public Function GetIdFestival() As Integer
            Return idFestival
        End Function

        Public Sub SetIdFestival(value As Integer)
            idFestival = value
        End Sub

        Public Function GetIdAuthor() As Integer
            Return idAuthor
        End Function

        Public Sub SetIdAuthor(value As Integer)
            idAuthor = value
        End Sub

        Public Function GetIdEditor() As Nullable(Of Integer)
            Return idEditor
        End Function

        Public Sub SetIdEditor(value As Nullable(Of Integer))
            idEditor = value
        End Sub

        Public Function GetStartHour() As SqlDate
            Return startHour
        End Function

        Public Sub SetStartHour(value As SqlDate)
            startHour = value
        End Sub

        Public Function GetEndHour() As SqlDate
            Return endHour
        End Function

        Public Sub SetEndHour(value As SqlDate)
            endHour = value
        End Sub

        Public Function GetComments() As String
            Return comments
        End Function

        Public Sub SetComments(value As String)
            comments = value
        End Sub


    End Class

End Namespace
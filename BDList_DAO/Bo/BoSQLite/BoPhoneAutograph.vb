Option Explicit On

Imports BDList_TOOLS.Types.Sql

Namespace BO

    Public MustInherit Class BoPhoneAutograph
        Inherits IdBObject

        Private idEdition As Integer
        Private idGoody As Integer
        Private idAuthor As Integer
        Private idAuthors As String
        Private [date] As SqlDate
        Private place As String
        Private [event] As String
        Private comments As String

        Public Function GetIdEdition() As Integer
            Return IdEdition
        End Function

        Public Sub SetIdEdition(value As Integer)
            IdEdition = value
        End Sub

        Public Function GetIdGoody() As Integer
            Return IdGoody
        End Function

        Public Sub SetIdGoody(value As Integer)
            IdGoody = value
        End Sub

        Public Function GetIdAuthor() As Integer
            Return IdAuthor
        End Function

        Public Sub SetIdAuthor(value As Integer)
            IdAuthor = value
        End Sub

        Public Function GetIdAuthors() As String
            Return IdAuthors
        End Function

        Public Sub SetIdAuthors(value As String)
            IdAuthors = value
        End Sub

        Public Function GetDate() As SqlDate
            Return [Date]
        End Function

        Public Sub SetDate(value As SqlDate)
            [Date] = value
        End Sub

        Public Function GetPlace() As String
            Return Place
        End Function

        Public Sub SetPlace(value As String)
            Place = value
        End Sub

        Public Function GetEvent() As String
            Return [Event]
        End Function

        Public Sub SetEvent(value As String)
            [Event] = value
        End Sub

        Public Function GetComments() As String
            Return comments
        End Function

        Public Sub SetComments(value As String)
            comments = value
        End Sub


    End Class
End Namespace

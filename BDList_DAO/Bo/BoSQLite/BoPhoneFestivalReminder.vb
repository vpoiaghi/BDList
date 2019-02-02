Option Explicit On

Namespace BO

    Public MustInherit Class BoPhoneFestivalReminder
        Inherits IdBObject

        Private idFestival As Integer
        Private idEditor As Nullable(Of Integer)
        Private name As String
        Private kind As Integer
        Private comments As String

        Public Function GetIdFestival() As Integer
            Return idFestival
        End Function

        Public Sub SetIdFestival(value As Integer)
            idFestival = value
        End Sub

        Public Function GetIdEditor() As Nullable(Of Integer)
            Return idEditor
        End Function

        Public Sub SetIdEditor(value As Nullable(Of Integer))
            idEditor = value
        End Sub

        Public Function GetName() As String
            Return name
        End Function

        Public Sub SetName(value As String)
            name = value
        End Sub

        Public Function GetKind() As Integer
            Return kind
        End Function

        Public Sub SetKind(value As Integer)
            kind = value
        End Sub

        Public Function GetComments() As String
            Return comments
        End Function

        Public Sub SetComments(value As String)
            comments = value
        End Sub


    End Class

End Namespace
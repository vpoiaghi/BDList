Option Explicit On

Namespace BO

    Public MustInherit Class BoPhoneSerie
        Inherits IdBObject

        Private kind As String
        Private origin As String
        Private name As String
        Private searchName As String
        Private ended As Boolean
        Private story As String

        Public Function GetKind() As String
            Return kind
        End Function

        Public Sub SetKind(value As String)
            kind = value
        End Sub

        Public Function GetOrigin() As String
            Return origin
        End Function

        Public Sub SetOrigin(value As String)
            origin = value
        End Sub

        Public Function GetName() As String
            Return name
        End Function

        Public Sub SetName(value As String)
            name = value
        End Sub

        Public Function GetSearchName() As String
            Return searchName
        End Function

        Public Sub SetSearchName(value As String)
            searchName = value
        End Sub

        Public Function IsEnded() As Boolean
            Return ended
        End Function

        Public Sub SetEnded(value As Boolean)
            ended = value
        End Sub

        Public Function GetStory() As String
            Return story
        End Function

        Public Sub SetStory(value As String)
            story = value
        End Sub



    End Class

End Namespace
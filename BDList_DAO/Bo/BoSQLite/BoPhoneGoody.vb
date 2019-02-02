Option Explicit On

Imports BDList_TOOLS.Types.Sql

Namespace BO

    Public MustInherit Class BoPhoneGoody
        Inherits IdBObject

        Private idEditor As Integer?
        Private idSerie As Integer?
        Private idSeries As String
        Private idAuthor As Integer?
        Private idAuthors As String
        Private name As String
        Private searchName As String
        Private serieName As String
        Private serieSearchName As String
        Private possessionState As Integer
        Private parutionDate As SqlDate
        Private withAutograph As Boolean
        Private editorName As String
        Private kindName As String
        Private sizeX As Integer?
        Private sizeY As Integer?
        Private sizeZ As Integer?
        Private orderNumber As Integer?
        Private copyNumber As String
        Private copyCount As Integer?
        Private state As Integer?

        Public Function GetIdEditor() As Integer?
            Return idEditor
        End Function

        Public Sub SetIdEditor(value As Integer?)
            idEditor = value
        End Sub

        Public Function GetIdSerie() As Nullable(Of Integer)
            Return idSerie
        End Function

        Public Sub SetIdSerie(value As Nullable(Of Integer))
            idSerie = value
        End Sub

        Public Function GetIdSeries() As String
            Return idSeries
        End Function

        Public Sub SetIdSeries(value As String)
            idSeries = value
        End Sub

        Public Function GetIdAuthor() As Nullable(Of Integer)
            Return idAuthor
        End Function

        Public Sub SetIdAuthor(value As Nullable(Of Integer))
            idAuthor = value
        End Sub

        Public Function GetIdAuthors() As String
            Return idAuthors
        End Function

        Public Sub SetIdAuthors(value As String)
            idAuthors = value
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

        Public Function GetSerieName() As String
            Return serieName
        End Function

        Public Sub SetSerieName(value As String)
            serieName = value
        End Sub

        Public Function GetSerieSearchName() As String
            Return serieSearchName
        End Function

        Public Sub SetSerieSearchName(value As String)
            serieSearchName = value
        End Sub

        Public Function GetPossessionState() As Integer
            Return possessionState
        End Function

        Public Sub SetPossessionState(value As Integer)
            possessionState = value
        End Sub

        Public Function GetParutionDate() As SqlDate
            Return parutionDate
        End Function

        Public Sub SetParutionDate(value As SqlDate)
            parutionDate = value
        End Sub

        Public Function IsWithAutograph() As Boolean
            Return withAutograph
        End Function

        Public Sub SetWithAutograph(value As Boolean)
            withAutograph = value
        End Sub

        Public Function GetEditorName() As String
            Return editorName
        End Function

        Public Sub SetEditorName(value As String)
            editorName = value
        End Sub

        Public Function GetKindName() As String
            Return kindName
        End Function

        Public Sub SetKindName(value As String)
            kindName = value
        End Sub

        Public Function GetSizeX() As Integer?
            Return sizeX
        End Function

        Public Sub SetSizeX(value As Integer?)
            sizeX = value
        End Sub

        Public Function GetSizeY() As Integer?
            Return sizeY
        End Function

        Public Sub SetSizeY(value As Integer?)
            sizeY = value
        End Sub

        Public Function GetSizeZ() As Integer?
            Return sizeZ
        End Function

        Public Sub SetSizeZ(value As Integer?)
            sizeZ = value
        End Sub

        Public Function GetOrderNumber() As Integer?
            Return orderNumber
        End Function

        Public Sub SetOrderNumber(value As Integer?)
            orderNumber = value
        End Sub

        Public Function GetCopyNumber() As String
            Return copyNumber
        End Function

        Public Sub SetCopyNumber(value As String)
            copyNumber = value
        End Sub

        Public Function GetCopyCount() As Integer?
            Return copyCount
        End Function

        Public Sub SetCopyCount(value As Integer?)
            copyCount = value
        End Sub

        Public Function GetState() As Integer?
            Return state
        End Function

        Public Sub SetState(value As Integer?)
            state = value
        End Sub

    End Class

End Namespace
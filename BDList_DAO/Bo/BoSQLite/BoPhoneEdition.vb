Option Explicit On

Imports BDList_TOOLS.Types.Sql

Namespace BO

    Public MustInherit Class BoPhoneEdition
        Inherits IdBObject

        Private idEditor As Integer
        Private idSerie As Nullable(Of Integer)
        Private idSeries As String
        Private idTitle As Nullable(Of Integer)
        Private idTitles As String
        Private serieName As String
        Private serieSearchName As String
        Private orderNumber As Integer
        Private collection As String
        Private state As Nullable(Of Integer)
        Private possessionState As Integer
        Private editionNumber As String
        Private isbn As String
        Private integral As Boolean
        Private miscellany As Boolean
        Private name As String
        Private searchName As String
        Private parutionDate As SqlDate
        Private versionNumber As Nullable(Of Integer)
        Private specialEdition As String
        Private boardsCount As Nullable(Of Integer)
        Private printingMax As Nullable(Of Integer)
        Private boardsColor As String
        Private textAuthorName As String
        Private drawAuthorName As String
        Private colorAuthorName As String
        Private withAutograph As Boolean
        Private anotherEditions As Boolean
        Private editorName As String

        Public Function GetIdEditor() As Integer
            Return idEditor
        End Function

        Public Sub SetIdEditor(value As Integer)
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

        Public Function GetIdTitle() As Nullable(Of Integer)
            Return idTitle
        End Function

        Public Sub SetIdTitle(value As Nullable(Of Integer))
            idTitle = value
        End Sub

        Public Function GetIdTitles() As String
            Return idTitles
        End Function

        Public Sub SetIdTitles(value As String)
            idTitles = value
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

        Public Function GetOrderNumber() As Integer
            Return orderNumber
        End Function

        Public Sub SetOrderNumber(value As Integer)
            orderNumber = value
        End Sub

        Public Function GetCollection() As String
            Return collection
        End Function

        Public Sub SetCollection(value As String)
            collection = value
        End Sub

        Public Function GetState() As Nullable(Of Integer)
            Return state
        End Function

        Public Sub SetState(value As Nullable(Of Integer))
            state = value
        End Sub

        Public Function GetEditionNumber() As String
            Return editionNumber
        End Function

        Public Sub SetEditionNumber(value As String)
            editionNumber = value
        End Sub

        Public Function GetIsbn() As String
            Return isbn
        End Function

        Public Sub SetIsbn(value As String)
            isbn = value
        End Sub

        Public Function GetPossessionState() As Integer
            Return possessionState
        End Function

        Public Sub SetPossessionState(value As Integer)
            possessionState = value
        End Sub

        Public Function IsIntegral() As Boolean
            Return integral
        End Function

        Public Sub SetIntegral(value As Boolean)
            integral = value
        End Sub

        Public Function IsMiscellany() As Boolean
            Return miscellany
        End Function

        Public Sub SetMiscellany(value As Boolean)
            miscellany = value
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

        Public Function GetParutionDate() As SqlDate
            Return parutionDate
        End Function

        Public Sub SetParutionDate(value As SqlDate)
            parutionDate = value
        End Sub

        Public Function GetVersionNumber() As Nullable(Of Integer)
            Return versionNumber
        End Function

        Public Sub SetVersionNumber(value As Nullable(Of Integer))
            versionNumber = value
        End Sub

        Public Function GetSpecialEdition() As String
            Return specialEdition
        End Function

        Public Sub SetSpecialEdition(value As String)
            specialEdition = value
        End Sub

        Public Function GetBoardsCount() As Nullable(Of Integer)
            Return boardsCount
        End Function

        Public Sub SetBoardsCount(value As Nullable(Of Integer))
            boardsCount = value
        End Sub

        Public Function GetPrintingMax() As Nullable(Of Integer)
            Return printingMax
        End Function

        Public Sub SetPrintingMax(value As Nullable(Of Integer))
            printingMax = value
        End Sub

        Public Function GetBoardsColor() As String
            Return boardsColor
        End Function

        Public Sub SetBoardsColor(value As String)
            boardsColor = value
        End Sub

        Public Function GetTextAuthorName() As String
            Return textAuthorName
        End Function

        Public Sub SetTextAuthorName(value As String)
            textAuthorName = value
        End Sub

        Public Function GetDrawAuthorName() As String
            Return drawAuthorName
        End Function

        Public Sub SetDrawAuthorName(value As String)
            drawAuthorName = value
        End Sub

        Public Function GetColorAuthorName() As String
            Return colorAuthorName
        End Function

        Public Sub SetColorAuthorName(value As String)
            colorAuthorName = value
        End Sub

        Public Function IsWithAutograph() As Boolean
            Return withAutograph
        End Function

        Public Sub SetWithAutograph(value As Boolean)
            withAutograph = value
        End Sub

        Public Function GetHasAnotherEditions() As Boolean
            Return anotherEditions
        End Function

        Public Sub SetHasAnotherEditions(value As Boolean)
            anotherEditions = value
        End Sub

        Public Function GetEditorName() As String
            Return editorName
        End Function

        Public Sub SetEditorName(value As String)
            editorName = value
        End Sub


    End Class

End Namespace
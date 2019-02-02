Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.Types.Sql

Public Class SynchroniseEditions
    Inherits SynchroniseIdBobject

    Private svcEditor As New ServiceEditor

    Protected Overrides Function GetItemsName() As String
        Return "édition"
    End Function

    Protected Overrides Function AllowSynchronisePictures() As Boolean
        Return True
    End Function

    Protected Overrides Function GetLocalService() As IService
        Return New ServiceEdition
    End Function

    Protected Overrides Function GetPhoneService() As IService
        Return New ServicePhoneEdition
    End Function

    Protected Overrides Function GetLocalPhoneParentDirPath() As String
        Return LOCAL_PHONE_COVERS_FOLDER
    End Function

    Protected Overrides Function GetPhoneParentDirPath() As String
        Return PHONE_COVERS_FOLDER
    End Function

    Public Overrides Sub LocalItemToPhoneItem(localItem As IdBObject, phoneItem As IdBObject)

        Dim localEdition As Edition = CType(localItem, Edition)
        Dim phoneEdition As PhoneEdition = CType(phoneItem, PhoneEdition)

        Dim serieName As String
        Dim serieSearchName As String

        With localEdition.GetSeries
            If .Count > 1 Then
                serieName = "Séries multiples"
            Else
                serieName = CType(.Item(0), Serie).GetSortName
            End If
            serieSearchName = ToSearchString(serieName)
        End With

        Dim isbn As String = localEdition.GetEAN_ISBN
        If String.IsNullOrEmpty(isbn) Then
            isbn = localEdition.GetISBN
        End If

        Dim colors As String = ""
        For Each c As EditionColor In localEdition.GetColors
            colors &= c.ToString & ", "
        Next
        If Not String.IsNullOrEmpty(colors) Then
            colors = colors.Substring(0, colors.Length - 2)
        End If

        Dim textAuthorName As String = ""
        For Each ar As AuthorRole In localEdition.GetAuthorRoles
            If ar.GetRole.GetName = "Scénario" Then
                textAuthorName &= ar.GetAuthor.GetId & "," & ar.GetAuthor.ToString & "; "
            End If
        Next
        If Not String.IsNullOrEmpty(textAuthorName) Then
            textAuthorName = textAuthorName.Substring(0, textAuthorName.Length - 2)
        End If

        Dim drawAuthorName As String = ""
        For Each ar As AuthorRole In localEdition.GetAuthorRoles
            If ar.GetRole.GetName = "Dessins" Then
                drawAuthorName &= ar.GetAuthor.GetId & "," & ar.GetAuthor.ToString & "; "
            End If
        Next
        If Not String.IsNullOrEmpty(drawAuthorName) Then
            drawAuthorName = drawAuthorName.Substring(0, drawAuthorName.Length - 2)
        End If

        Dim colorAuthorName As String = ""
        For Each ar As AuthorRole In localEdition.GetAuthorRoles
            If ar.GetRole.GetName = "Couleurs" Then
                colorAuthorName &= ar.GetAuthor.GetId & "," & ar.GetAuthor.ToString & "; "
            End If
        Next
        If Not String.IsNullOrEmpty(colorAuthorName) Then
            colorAuthorName = colorAuthorName.Substring(0, colorAuthorName.Length - 2)
        End If

        Dim collection As String = ""
        If localEdition.GetCollection IsNot Nothing Then
            collection = localEdition.GetCollection.GetName
        End If

        Dim state As Nullable(Of Integer) = Nothing
        If localEdition.GetState IsNot Nothing Then
            state = localEdition.GetState.GetId
        End If

        Dim editionName As String = localEdition.GetName

        If String.IsNullOrEmpty(editionName) Then

            If localEdition.IsIntegral Then
                With localEdition.GetTitles
                    editionName = CType(.Item(0), Title).GetName & " à " & CType(.Last(), Title).GetName
                End With
            ElseIf localEdition.IsMiscellany Then
                editionName = ""
            Else
                editionName = CType(localEdition.GetTitles(0), Title).GetName
            End If
        End If

        editionName = editionName.Replace("""", "''")

        Dim editionSearchName As String
        editionSearchName = ToSearchString(editionName)


        Dim editor As Editor = localEdition.GetEditor
        Dim svcEdition As New ServiceEdition

        phoneEdition.SetIdEditor(editor.GetId)
        phoneEdition.SetEditorName(editor.GetName)
        phoneEdition.SetSerieName(serieName)
        phoneEdition.SetSerieSearchName(serieSearchName)
        phoneEdition.SetCollection(collection)
        phoneEdition.SetState(state)
        phoneEdition.SetPossessionState(localEdition.GetPossessionState.GetId)
        phoneEdition.SetEditionNumber(localEdition.GetEditionNumber)
        phoneEdition.SetIsbn(isbn)
        phoneEdition.SetIntegral(localEdition.IsIntegral)
        phoneEdition.SetMiscellany(localEdition.IsMiscellany)
        phoneEdition.SetName(editionName)
        phoneEdition.SetSearchName(editionSearchName)

        If localEdition.GetParutionDate Is Nothing Then
            phoneEdition.SetParutionDate(Nothing)
        Else
            phoneEdition.SetParutionDate(New SqlDate(localEdition.GetParutionDate))
        End If

        phoneEdition.SetVersionNumber(localEdition.GetVersionNumber)
        phoneEdition.SetSpecialEdition(localEdition.GetSpecialEdition)
        phoneEdition.SetBoardsCount(localEdition.GetBoardCount)
        phoneEdition.SetPrintingMax(localEdition.GetPrintingMaxNumber)
        phoneEdition.SetBoardsColor(colors)
        phoneEdition.SetTextAuthorName(textAuthorName)
        phoneEdition.SetDrawAuthorName(drawAuthorName)
        phoneEdition.SetColorAuthorName(colorAuthorName)
        phoneEdition.SetWithAutograph(localEdition.GetAutographs.Count > 0)
        phoneEdition.SetHasAnotherEditions(svcEdition.HasAnotherEditions(localEdition) > 0)

        If localEdition.GetSeries.Count > 0 Then
            If localEdition.IsMiscellany Then
                phoneEdition.SetIdSerie(Nothing)

                Dim s As String = ";"
                For Each serie As Serie In localEdition.GetSeries
                    s = s & serie.GetId & ";"
                Next

                phoneEdition.SetIdSeries(s)
            Else
                phoneEdition.SetIdSerie(CType(localEdition.GetSeries(0), Serie).GetId)
                phoneEdition.SetIdSeries(Nothing)
            End If
        End If

        Dim orderNumber As Integer = 1

        If localEdition.GetTitles.Count > 1 Then

            phoneEdition.SetIdTitle(Nothing)
            Dim t As String = ";"

            If localEdition.IsIntegral Then
                orderNumber = 10000

                For Each title As Title In localEdition.GetTitles

                    With title
                        t = t & .GetId & ";"

                        If .GetOrderNumber < orderNumber Then
                            orderNumber = .GetOrderNumber
                        End If
                    End With
                Next

            Else
                For Each title As Title In localEdition.GetTitles
                    t = t & title.GetId & ";"
                Next

            End If

            phoneEdition.SetIdTitles(t)
        Else
            With CType(localEdition.GetTitles(0), Title)
                phoneEdition.SetIdTitle(.GetId)
                phoneEdition.SetIdTitles(Nothing)
                orderNumber = .GetOrderNumber
            End With
        End If

        phoneEdition.SetOrderNumber(orderNumber)

    End Sub

    Protected Overrides Sub PhoneItemToLocalItem(phoneItem As IdBObject, localItem As IdBObject)

        Dim phoneEdition As PhoneEdition = CType(phoneItem, PhoneEdition)
        Dim localEdition As Edition = CType(localItem, Edition)

        'localEdition.SetSeries()
        'localEdition.SetCollection()
        'localEdition.SetState()
        'localEdition.SetColors()
        'localEdition.SetAuthorRoles()
        'localEdition.SetSocietyRoles()
        'localEdition.SetAutographs()
        'localEdition.SetFormats()
        'localEdition.SetSizeCategory()
        'localEdition.SetTitles()

        'localEdition.SetEditor(svcEditor.getbyid(phoneEdition.GetIdEditor))
        'localEdition.SetEditionNumber(phoneEdition.GetEditionNumber)
        'localEdition.SetEAN_ISBN(phoneEdition.GetIsbn)

        Dim svcPossessionState = New ServicePossessionState
        Dim possessionState As PossessionState = svcPossessionState.GetById(phoneEdition.GetPossessionState)
        localEdition.SetPossessionState(possessionState)

        'localEdition.SetIntegral(phoneEdition.IsIntegral)
        'localEdition.SetMiscellany(phoneEdition.IsMiscellany)
        'localEdition.SetParutionDate(phoneEdition.GetParutionDate)
        'localEdition.SetVersionNumber(phoneEdition.GetVersionNumber)
        'localEdition.SetSpecialEdition(phoneEdition.GetSpecialEdition)
        'localEdition.SetBoardCount(phoneEdition.GetBoardsCount)
        'localEdition.SetPrintingMaxNumber(phoneEdition.GetPrintingMax)


        'If (Not localItem.IsInBase) AndAlso (phoneEdition.IsIntegral) Then
        '    localEdition.SetName(phoneEdition.GetName)
        'End If

        ' ---------------------------------------------------------------
        ' Données non présentes sur le téléphone ou non récupérable
        'localEdition.SetBoughtDate()
        'localEdition.SetComments()
        'localEdition.SetDDL()
        'localEdition.SetISBN()
        'localEdition.SetEditionInformations()
        'localEdition.SetGraphicPagesCount()
        'localEdition.SetHeight()
        'localEdition.SetISSN()
        'localEdition.SetLegalDepositDate()
        'localEdition.SetPageCount()
        'localEdition.SetPrintDate()
        'localEdition.SetPrintingNumber()
        'localEdition.SetRead()
        'localEdition.SetReedition()
        'localEdition.SetWidth()
        ' ---------------------------------------------------------------

    End Sub

End Class


Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.Types.Sql


Public Class SynchroniseGoodies
    Inherits SynchroniseIdBobject

    Private svcSerie As New ServiceSerie
    Private svcEditor As New ServiceEditor
    Private svcKindOfGoody = New ServiceKindOfGoody

    Protected Overrides Function GetItemsName() As String
        Return "para-bd"
    End Function

    Protected Overrides Function AllowSynchronisePictures() As Boolean
        Return True
    End Function

    Protected Overrides Function GetLocalService() As IService
        Return New ServiceGoody
    End Function

    Protected Overrides Function GetPhoneService() As IService
        Return New ServicePhoneGoody
    End Function

    Protected Overrides Function GetLocalPhoneParentDirPath() As String
        Return LOCAL_PHONE_GOODIES_FOLDER
    End Function

    Protected Overrides Function GetPhoneParentDirPath() As String
        Return PHONE_GOODIES_FOLDER
    End Function

    Public Overrides Sub LocalItemToPhoneItem(localItem As IdBObject, phoneItem As IdBObject)

        Dim localGoody As Goody = CType(localItem, Goody)
        Dim phoneGoody As PhoneGoody = CType(phoneItem, PhoneGoody)


        Dim serieName As String = Nothing
        Dim serieSearchName As String = Nothing
        Dim idEditor As Integer? = Nothing
        Dim editorName As String = Nothing
        Dim name As String
        Dim searchName As String

        With localGoody

            With .GetSeries
                If .Count > 1 Then
                    serieName = "Séries multiples"
                ElseIf .Count = 1 Then
                    serieName = CType(.First, Serie).GetSortName
                End If

                serieSearchName = ToSearchString(serieName)

            End With

            If (Not .GetEditors Is Nothing) AndAlso (.GetEditors.Count > 0) Then
                With CType(.GetEditors(0), Editor)
                    idEditor = .GetId
                    editorName = .GetName
                End With
            End If

            name = .ToString.Replace("""", "''")
            searchName = ToSearchString(name)

        End With

            With phoneGoody

            .SetName(name)
            .SetSearchName(searchName)
            .SetSerieName(serieName)
            .SetSerieSearchName(serieSearchName)
            .SetKindName(localGoody.GetKindOfGoody.GetName)
            .SetIdEditor(idEditor)
            .SetEditorName(editorName)
            .SetState(Nothing)
            .SetWithAutograph(localGoody.GetAutograph IsNot Nothing)

            If localGoody.GetParutionDate Is Nothing Then
                .SetParutionDate(Nothing)
            Else
                .SetParutionDate(New SqlDate(localGoody.GetParutionDate))
            End If

            .SetPossessionState(localGoody.GetPossessionState.GetId)

            If ((localGoody.GetNumberType Is Nothing) AndAlso (localGoody.GetNumber Is Nothing)) Then
                .SetCopyNumber(Nothing)
            Else
                .SetCopyNumber(Trim(localGoody.GetNumberType & " " & localGoody.GetNumber))
            End If

            .SetCopyCount(localGoody.GetNumberMax)
            .SetSizeX(localGoody.GetWidth)
            .SetSizeY(localGoody.GetHeight)
            .SetSizeZ(Nothing)
            .SetOrderNumber(localGoody.GetOrderNumber)

            .SetIdSerie(Nothing)
            .SetIdSeries(Nothing)

            If localGoody.GetSeries.Count > 1 Then

                Dim s As String = ";"
                For Each serie As Serie In localGoody.GetSeries
                    s &= serie.GetId & ";"
                Next

                .SetIdSeries(s)

            ElseIf localGoody.GetSeries.Count = 1 Then
                .SetIdSerie(CType(localGoody.GetSeries(0), Serie).GetId)
            End If

            Dim authorsList As List(Of IdBObject) = localGoody.GetAuthors
            .SetIdAuthor(Nothing)
            .SetIdAuthors(Nothing)

            If authorsList.Count > 1 Then

                Dim a As String = ";"
                For Each author As Author In authorsList
                    a &= author.GetId & ";"
                Next

                .SetIdAuthors(a)

            ElseIf localGoody.GetAuthors.Count = 1 Then
                .SetIdAuthor(CType(localGoody.GetAuthors(0), Author).GetId)

            End If


        End With

    End Sub

    Protected Overrides Sub PhoneItemToLocalItem(phoneItem As IdBObject, localItem As IdBObject)

        Dim phoneGoody As PhoneGoody = CType(phoneItem, PhoneGoody)
        Dim localGoody As Goody = CType(localItem, Goody)


        With localGoody

            Dim svcPossessionState = New ServicePossessionState
            Dim possessionState As PossessionState = svcPossessionState.GetById(phoneGoody.GetPossessionState)
            .SetPossessionState(possessionState)

        End With

    End Sub

End Class


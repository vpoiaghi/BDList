Imports BDList_DAO_BO.BO

Public Class SyncIdBoResults
    Inherits SynchroniseResults

    Public Sub New()
        MyBase.New()
    End Sub

    Public Overrides Function ItemToString(item As Object) As String

        Dim t As Type = item.GetType
        Dim result As String

        With CType(item, IdBObject)
            result = "(" & .GetId & ", " & Format(.GetModifiedDateTime, "dd/MM/yyyy hh:mm:ss") & ") "
        End With


        Select Case t.Name
            Case "Author"
                With CType(item, Author)
                    result &= .ToString
                End With

            Case "Autograph"
                With CType(item, Autograph)
                    result &= Format(.GetAutographDate, "dd/MM/yyyy") & " " & .GetAuthor.ToString
                End With

            Case "Edition"
            Case "Editor"
            Case "Goody"
            Case "Event"
            Case "Title"
            Case "Serie"
                With CType(item, Serie)
                    result &= .GetName
                End With

            Case "PhoneAuthor"
            Case "PhoneAutograph"
                With CType(item, PhoneAutograph)
                    'result &= .GetDate.ToString & " " & .GetIdAuthor

                    result = ""

                    If .GetDate IsNot Nothing Then
                        result &= .GetDate.ToString
                    End If

                    result &= " " & .GetIdAuthor
                    result = result.Trim

                End With

            Case "PhoneEdition"
            Case "PhoneEditor"
            Case "PhoneGoody"
            Case "PhoneEvent"
            Case "PhoneTitle"
            Case "PhoneSerie"
                With CType(item, PhoneSerie)
                    result &= .GetName
                End With

            Case Else
                result &= item.ToString

        End Select

        Return result

    End Function

End Class

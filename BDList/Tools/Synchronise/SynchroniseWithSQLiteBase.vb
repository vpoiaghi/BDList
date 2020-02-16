Imports BDList_DAO_BO.BO
Imports BDList_SERVICE
Imports BDList_TOOLS.IO
Imports BDList_TOOLS.Types.Sql

Imports System.Text
Imports System.IO

Public Class SynchroniseWithSQLiteBase

    Public Event SyncProgressEvent(stepIndex As Integer, stepsCount As Integer, text As String)
    Public Event SyncEndedEvent(syncDuration As TimeSpan)


    Private syncDate As Date? = Nothing

    Private m_phoneExplorer As PhoneExplorer

    Private Delegate Sub AddBoValuesToSqlQuery(ByRef bo As IdBObject, ByRef query As StringBuilder, ByVal isFirstRow As Boolean)

    Public Function Synchronise(forceCleanPhone As Boolean) As SynchroniseResults

        Dim result As SynchroniseResults = Nothing

        If beforeSynchronise() Then
            result = doSynchronise(forceCleanPhone)
            afterSynchronise(result)
        End If

        Return result

    End Function

    Private Function beforeSynchronise() As Boolean

        Dim result As Boolean = False

        syncDate = Now

        Try

            m_phoneExplorer = PhoneExplorer.GetInstance

            'If m_phoneExplorer.Connect Then

            '    Dim dbPhoneFile As IFile = Factory.GetFile(SQLITE_DATABASE_PHONE_FILE_PATH)
            '    Dim dbLocalFile As IFile = Factory.GetFile(SQLITE_DATABASE_LOCAL_FILE_PATH)

            '    ' Copie la base de données du téléphone en local
            '    m_phoneExplorer.PullFile(dbPhoneFile, dbLocalFile)

            result = True

            'Else
            '    MsgBox("Aucun téléphone n'est actuellement connecté.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Connection à un téléphone...")
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return result

    End Function

    Private Function doSynchronise(forceCleanPhone As Boolean) As SynchroniseResults

        Dim syncResults As New SyncIdBoResults

        Try

            Dim synchronisersList As New List(Of SynchroniseIdBobject)
            synchronisersList.Add(New SynchroniseEvents())
            synchronisersList.Add(New SynchroniseEditors())
            synchronisersList.Add(New SynchroniseSeries())
            synchronisersList.Add(New SynchroniseTitles())
            synchronisersList.Add(New SynchroniseEditions())
            synchronisersList.Add(New SynchroniseGoodies())
            synchronisersList.Add(New SynchroniseAuthors())
            synchronisersList.Add(New SynchroniseAutographs())
            synchronisersList.Add(New SynchroniseFestivals())
            synchronisersList.Add(New SynchroniseFestivalReminders())
            synchronisersList.Add(New SynchroniseInSigning())


            Dim stepIndex As Integer = 0
            Dim stepCount As Integer = synchronisersList.Count - 1

            For Each s As SynchroniseIdBobject In synchronisersList

                If forceCleanPhone Then
                    s.DeleteAll(m_phoneExplorer)
                End If

                syncResults.AddResults(s.Synchronise(m_phoneExplorer, forceCleanPhone))

                RaiseEvent SyncProgressEvent(stepIndex, stepCount, s.GetType.Name)
                stepIndex += 1

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return syncResults

    End Function

    Private Sub afterSynchronise(syncResults As SynchroniseResults)

        Try
            ' Enregistrement de la date et heure de la synchronisation sur le téléphone.
            Dim svcPhoneParameters As New ServicePhoneParameters()
            Dim phoneParameters As PhoneParameters = svcPhoneParameters.GetParameters
            phoneParameters.SetDataUpdateDate(New SqlDate(Now))
            svcPhoneParameters.InsertOrUpdate(phoneParameters)

            ' La table mise à jour n'est renvoyée sur le téléphone que si elle
            ' a eue des mise à jours.
            'If (syncResults.GetPhoneDataUpdatesCount > 0) OrElse (syncResults.GetPhoneDataRemovedCount > 0) Then

            '    Dim dbPhoneFile As IFile = Factory.GetFile(SQLITE_DATABASE_PHONE_FILE_PATH)
            '    Dim dbLocalFile As IFile = Factory.GetFile(SQLITE_DATABASE_LOCAL_FILE_PATH)

            '    m_phoneExplorer.RemoveFile(dbPhoneFile)
            '    m_phoneExplorer.SendFile(dbLocalFile, dbPhoneFile)

            'End If

            Dim endSyncDate As Date = Now
            Dim syncDuration As TimeSpan = (endSyncDate - syncDate)

            RaiseEvent SyncEndedEvent(syncDuration)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

End Class

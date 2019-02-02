Imports System.Data.SQLite

Friend Class SQLiteDataBase
    Inherits Connection

    'Connexion à la base
    Private m_cnx As SQLiteConnection = Nothing

    Friend Sub New(index As Integer)
        MyBase.New(index)
    End Sub

    Friend Overrides Sub OpenConnection()

        Dim connectionSuccess As Boolean = False

        Try

            m_cnx = New SQLiteConnection
            m_cnx.ConnectionString = "Data Source=" & "F:\Programmation\android\SD\sdcard\bdlist\donnees\bdlist.db"
            m_cnx.Open()

        Catch ex As Exception
        End Try

    End Sub

    Friend Overrides Sub CloseConnection()

        Try
            m_cnx.Close()
            m_cnx.Dispose()
        Catch ex As Exception
        End Try

    End Sub

    Friend Overrides Function DoExecuteQuery(query As String) As ISqlResult

        Dim dr As SQLiteDataReader = Nothing
        Dim cmd As SQLiteCommand = Nothing

        Try

            cmd = New SQLiteCommand(query, m_cnx)
            dr = cmd.ExecuteReader()

        Catch e As Exception
            System.Console.WriteLine("UNE ERREUR EST SURVENUE LORS DE L'EXECUTION DE LA REQUETE")
            System.Console.WriteLine(query)
            System.Console.WriteLine(e.Message)
            System.Console.WriteLine(e.StackTrace)

        Finally
            If cmd IsNot Nothing Then
                cmd.Dispose()
                cmd = Nothing
            End If
        End Try

        Return New SQLiteResult(dr)

    End Function

    Friend Overrides Sub DoExecuteNonQuery(query As String)

        Dim cmd As SQLiteCommand = Nothing

        Try
            cmd = New SQLiteCommand(query, m_cnx)
            cmd.ExecuteNonQuery()

        Catch e As Exception
            System.Console.WriteLine("UNE ERREUR EST SURVENUE LORS DE L'EXECUTION DE LA REQUETE")
            System.Console.WriteLine(query)
            System.Console.WriteLine(e.Message)
            System.Console.WriteLine(e.StackTrace)

        Finally
            If cmd IsNot Nothing Then
                cmd.Dispose()
                cmd = Nothing
            End If
        End Try

    End Sub


End Class

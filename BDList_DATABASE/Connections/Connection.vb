Friend MustInherit Class Connection
    Implements IConnection

    Private m_lock As New Object
    Private m_status As ConnectionStatus
    Private m_index As Integer

    Friend MustOverride Sub OpenConnection()
    Friend MustOverride Sub CloseConnection()
    Friend MustOverride Function DoExecuteQuery(query As String) As ISqlResult
    Friend MustOverride Sub DoExecuteNonQuery(query As String)


    Protected Sub New(p_index As Integer)
        SetStatus(ConnectionStatus.Closed)
        m_index = p_index
    End Sub

    Public Function GetStatus() As ConnectionStatus Implements IConnection.GetStatus
        Return m_status
    End Function

    Private Sub SetStatus(status As ConnectionStatus)
        m_status = status
    End Sub

    Friend Sub Open() Implements IConnection.Open

        OpenConnection()
        SetStatus(ConnectionStatus.Free)

        'Console.WriteLine(Format(Now, "hh:mm:ss,fff") + " ## Connection " & m_index & " ouverte")

    End Sub

    Friend Sub Close() Implements IConnection.Close

        SetStatus(ConnectionStatus.Closed)
        CloseConnection()

        'Console.WriteLine(Format(Now, "hh:mm:ss,fff") + " ## Connection " & m_index & " fermée")

    End Sub

    Friend Function ExecuteQuery(query As String) As ISqlResult Implements IConnection.ExecuteQuery

        SyncLock (m_lock)

            'Console.WriteLine(Format(Now, "hh:mm:ss,fff") + " ## Debut requête sur connection " & m_index)

            SetStatus(ConnectionStatus.Used)

            Dim result As ISqlResult = DoExecuteQuery(query)

            SetStatus(ConnectionStatus.Free)

            'Console.WriteLine(Format(Now, "hh:mm:ss,fff") + " ## Fin requête sur connection " & m_index)

            Return result

        End SyncLock

    End Function

    Friend Sub ExecuteNonQuery(query As String) Implements IConnection.ExecuteNonQuery

        SyncLock (m_lock)

            SetStatus(ConnectionStatus.Used)

            DoExecuteNonQuery(query)

            SetStatus(ConnectionStatus.Free)

        End SyncLock

    End Sub

End Class

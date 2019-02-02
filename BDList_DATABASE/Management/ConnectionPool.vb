Public Class ConnectionPool

    Private Shared _lock As New Object
    Private Shared m_instance As ConnectionPool
    Private Shared m_connectionsLists As New Hashtable

    Private Sub New()
    End Sub

    Public Shared Function ExecuteQuery(p_connectionType As ConnectionTypes, p_query As String) As ISqlResult
        Return GetConnection(p_connectionType).ExecuteQuery(p_query)
    End Function

    Public Shared Sub ExecuteNonQuery(p_connectionType As ConnectionTypes, p_query As String)
        GetConnection(p_connectionType).ExecuteNonQuery(p_query)
    End Sub

    Public Shared Sub CloseAll()

        For Each connections As List(Of IConnection) In m_connectionsLists.Values
            For Each connection As IConnection In connections
                connection.Close()
            Next
        Next

    End Sub

    Private Shared Function GetConnection(connectionType As ConnectionTypes) As IConnection

        SyncLock (_lock)

            Dim connection As IConnection = Nothing
            Dim lst As List(Of IConnection) = m_connectionsLists.Item(connectionType)

            If lst Is Nothing Then
                lst = New List(Of IConnection)
                m_connectionsLists.Add(connectionType, lst)

                connection = CreateConnection(connectionType, 0)
                lst.Add(connection)

            Else
                Dim connectionIndex As Integer = 0
                Dim freeConnectionFound As Boolean = False

                While (connectionIndex < lst.Count) AndAlso (Not freeConnectionFound)

                    connection = lst(connectionIndex)

                    If (connection.GetStatus = ConnectionStatus.Free) Then
                        freeConnectionFound = True
                    Else
                        connectionIndex += 1
                    End If

                End While

                If Not freeConnectionFound Then
                    connection = CreateConnection(connectionType, connectionIndex)
                    lst.Add(connection)
                End If

            End If

            Return connection

        End SyncLock

    End Function

    Private Shared Function CreateConnection(connectionType As ConnectionTypes, connectionIndex As Integer)

        Dim connection As IConnection = Nothing

        Select Case connectionType
            Case ConnectionTypes.Access : connection = New AccessDatabase(connectionIndex)
            Case ConnectionTypes.SQLite : connection = New SQLiteDataBase(connectionIndex)
        End Select

        connection.Open()

        Return connection

    End Function

End Class

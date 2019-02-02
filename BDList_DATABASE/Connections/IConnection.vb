Friend Interface IConnection

    Function GetStatus() As ConnectionStatus

    Sub Open()
    Sub Close()

    Function ExecuteQuery(query As String) As ISqlResult
    Sub ExecuteNonQuery(query As String)

End Interface

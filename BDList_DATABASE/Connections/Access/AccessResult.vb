Imports BDList_TOOLS.Types.Sql

Public Class AccessResult
    Implements ISqlResult

    Private m_dataTable As DataTable = Nothing
    Private m_currentIndex As Integer = -1
    Private m_resultsCount As Integer = -1
    Private m_curentRow As DataRow = Nothing

    Public Sub New(result As DataTable)

        If (result IsNot Nothing) AndAlso (result.Rows IsNot Nothing) Then

            m_dataTable = result
            m_currentIndex = -1
            m_resultsCount = result.Rows.Count

        End If

    End Sub

    Public Function GetCount() As Integer Implements ISqlResult.GetCount
        Return m_dataTable.Rows.Count
    End Function

    Public Function GetValue(columnName As String) As Object Implements ISqlResult.GetValue

        Dim value As Object = Nothing

        Try
            value = m_curentRow.Item(columnName)
        Catch e As System.ArgumentException
            MsgBox("La colonne " & columnName & " est inconnue dans la table " & m_dataTable.TableName & vbCrLf & vbCrLf & e.Message, vbCritical + MsgBoxStyle.OkOnly, "Erreur...")
        End Try

        If value IsNot Nothing Then
            If TypeOf value Is DBNull Then
                value = Nothing
            End If
        End If

        Return value

    End Function

    Public Function GetValue(colIndex As Integer) As IComparable Implements ISqlResult.GetValue

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            Return m_curentRow.Item(colIndex)
        End If

    End Function

    Public Function GetBoolean(colName As String) As Boolean? Implements ISqlResult.GetBoolean
        Return GetValue(colName)
    End Function

    Public Function GetBoolean(colIndex As Integer) As Boolean? Implements ISqlResult.GetBoolean

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            Return m_curentRow.Item(colIndex)
        End If

    End Function

    Public Function GetSqlDate(colName As String) As SqlDate Implements ISqlResult.GetSqlDate
        Return Nothing
    End Function

    Public Function GetDate(colName As String) As DateTime? Implements ISqlResult.GetDate
        Return GetValue(colName)
    End Function

    Public Function GetSqlDate(colIndex As Integer) As SqlDate Implements ISqlResult.GetSqlDate
        Return Nothing
    End Function

    Public Function GetDate(colIndex As Integer) As DateTime? Implements ISqlResult.GetDate

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            Return m_curentRow.Item(colIndex)
        End If

    End Function

    Public Function GetInteger(colName As String) As Integer? Implements ISqlResult.GetInteger
        Return GetValue(colName)
    End Function

    Public Function GetInteger(colIndex As Integer) As Integer? Implements ISqlResult.GetInteger

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            Return m_curentRow.Item(colIndex)
        End If

    End Function

    Public Function GetLong(colName As String) As Long? Implements ISqlResult.GetLong

        Dim result As Long? = Nothing
        Dim o As Object = GetValue(colName)

        If o IsNot Nothing Then
            result = CType(o, Long)
        End If

        Return result

    End Function

    Public Function GetLong(colIndex As Integer) As Long? Implements ISqlResult.GetLong

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            Dim result As Long? = Nothing

            If Not IsDbNull(colIndex) Then
                Dim o As Object = m_curentRow.Item(colIndex)

                If o IsNot Nothing Then
                    result = CType(o, Long)
                End If
            End If

            Return result
        End If

    End Function

    Public Function GetSingle(colName As String) As Single? Implements ISqlResult.GetSingle

        Dim result As Single? = Nothing
        Dim o As Object = GetValue(colName)

        If o IsNot Nothing Then
            result = CType(o, Single)
        End If

        Return result

    End Function

    Public Function GetSingle(colIndex As Integer) As Single? Implements ISqlResult.GetSingle

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            Dim result As Single? = Nothing

            If Not IsDbNull(colIndex) Then
                Dim o As Object = m_curentRow.Item(colIndex)

                If o IsNot Nothing Then
                    result = CType(o, Single)
                End If
            End If

            Return result
        End If

    End Function

    Public Function GetString(colName As String) As String Implements ISqlResult.GetString
        Return GetValue(colName)
    End Function

    Public Function GetString(colIndex As Integer) As String Implements ISqlResult.GetString

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            Return m_curentRow.Item(colIndex)
        End If

    End Function

    Public Function MoveNext() As Boolean Implements ISqlResult.MoveNext

        Dim result As Boolean

        If (m_currentIndex < (m_resultsCount - 1)) Then
            m_currentIndex += 1
            m_curentRow = m_dataTable.Rows(m_currentIndex)
            result = True
        Else
            result = False
        End If

        Return result

    End Function

    Public Function IsDbNull(colIndex As Integer) As Boolean Implements ISqlResult.IsDbNull

        Return m_curentRow.IsNull(colIndex)

    End Function

End Class

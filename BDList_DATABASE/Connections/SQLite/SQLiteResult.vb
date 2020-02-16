Imports BDList_TOOLS.Types.Sql
Imports System.Data.SQLite

Public Class SQLiteResult
    Implements ISqlResult

    Private m_datatable As New DataTable()
    Private m_currentRowIndex As Integer = -1
    Private m_rowsCount As Integer = -1

    Public Sub New(result As SQLiteDataReader)

        If result IsNot Nothing Then
            m_datatable.Load(result)
            m_rowsCount = m_datatable.Rows.Count
        End If

        result = Nothing

    End Sub

    Public Function GetCount() As Integer Implements ISqlResult.GetCount
        Return m_rowsCount
    End Function

    Public Function GetValue(colName As String) As Object Implements ISqlResult.GetValue
        Return GetValue(m_datatable.Columns(colName).Ordinal)
    End Function

    Public Function GetValue(colIndex As Integer) As IComparable Implements ISqlResult.GetValue

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            Try
                Return m_datatable.Rows(m_currentRowIndex).Field(Of IComparable)(colIndex)
            Catch ex As Exception
                ShowCastException(ex, colIndex, "IComparable")
                Return Nothing
            End Try

        End If

    End Function

    Public Function GetBoolean(colName As String) As Boolean? Implements ISqlResult.GetBoolean
        Return GetBoolean(m_datatable.Columns(colName).Ordinal)
    End Function

    Public Function GetBoolean(colIndex As Integer) As Boolean? Implements ISqlResult.GetBoolean

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            Try
                Return m_datatable.Rows(m_currentRowIndex).Field(Of Boolean)(colIndex)
            Catch ex As Exception
                ShowCastException(ex, colIndex, "Boolean")
                Return Nothing
            End Try
        End If

    End Function

    Public Function GetDate(colName As String) As DateTime? Implements ISqlResult.GetDate

        Dim sqlDate As SqlDate = GetSqlDate(colName)

        If sqlDate Is Nothing Then
            Return Nothing
        Else
            Return sqlDate.GetDate
        End If

    End Function

    Public Function GetSqlDate(colName As String) As SqlDate Implements ISqlResult.GetSqlDate
        Return GetSqlDate(m_datatable.Columns(colName).Ordinal)
    End Function

    ' Base SQL vers BO java
    Public Function GetDate(colIndex As Integer) As DateTime? Implements ISqlResult.GetDate

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            ' Nombre de milliseconds depuis le 01/01/1970 00:00:00
            Dim milliseconds As Long

            Try
                milliseconds = m_datatable.Rows(m_currentRowIndex).Field(Of Long)(colIndex)
            Catch ex As Exception
                ShowCastException(ex, colIndex, "Long (date)")
            End Try

            ' Nombre de paquets de 100 nanosecondes dans la valeurs lue en base exprimée en ms
            Dim ns100 As Long = milliseconds * TimeSpan.TicksPerMillisecond

            ' Nombre de paquets de 100 nanosecondes por la date 01/01/1970
            Dim ns1970 As Long = New DateTime(1970, 1, 1, 0, 0, 0).Ticks

            ' On ajoute des heures pour être synchro avec le dateTime java androïd.
            Return (New DateTime(ns100 + ns1970)).AddHours(2)

        End If

    End Function

    Public Function GetSqlDate(colIndex As Integer) As SqlDate Implements ISqlResult.GetSqlDate

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            ' Nombre de milliseconds depuis le 01/01/1970 00:00:00
            Dim dte As String
            dte = ""

            Try
                dte = m_datatable.Rows(m_currentRowIndex).Field(Of String)(colIndex)
            Catch ex As Exception
                ShowCastException(ex, colIndex, "String (date)")
            End Try

            ' On ajoute des heures pour être synchro avec le dateTime java androïd.
            If String.IsNullOrEmpty(dte) Then
                Return Nothing
            Else
                Return New SqlDate(dte)
            End If

        End If

    End Function


    Public Function GetInteger(colName As String) As Integer? Implements ISqlResult.GetInteger
        Return GetInteger(m_datatable.Columns(colName).Ordinal)
    End Function

    Public Function GetInteger(colIndex As Integer) As Integer? Implements ISqlResult.GetInteger

        If IsDbNull(colIndex) Then
            Return Nothing
        Else

            Try
                Return m_datatable.Rows(m_currentRowIndex).Field(Of Int32)(colIndex)
            Catch ex As Exception
                ShowCastException(ex, colIndex, "Int32")
                Return Nothing
            End Try

        End If

    End Function

    Public Function GetLong(colName As String) As Long? Implements ISqlResult.GetLong
        Return GetLong(m_datatable.Columns(colName).Ordinal)
    End Function

    Public Function GetLong(colIndex As Integer) As Long? Implements ISqlResult.GetLong

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            Try
                Return m_datatable.Rows(m_currentRowIndex).Field(Of Long)(colIndex)
            Catch ex As Exception
                ShowCastException(ex, colIndex, "Long")
                Return Nothing
            End Try

        End If

    End Function

    Public Function GetSingle(colName As String) As Single? Implements ISqlResult.GetSingle
        Return GetSingle(m_datatable.Columns(colName).Ordinal)
    End Function

    Public Function GetSingle(colIndex As Integer) As Single? Implements ISqlResult.GetSingle

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            Try
                Return m_datatable.Rows(m_currentRowIndex).Field(Of Single)(colIndex)
            Catch ex As Exception
                ShowCastException(ex, colIndex, "Single")
                Return Nothing
            End Try

        End If

    End Function

    Public Function GetString(colName As String) As String Implements ISqlResult.GetString
        Return GetString(m_datatable.Columns(colName).Ordinal)
    End Function

    Public Function GetString(colIndex As Integer) As String Implements ISqlResult.GetString

        If IsDbNull(colIndex) Then
            Return Nothing
        Else
            Try
                Return m_datatable.Rows(m_currentRowIndex).Field(Of String)(colIndex)
            Catch ex As Exception
                ShowCastException(ex, colIndex, "String")
                Return Nothing
            End Try

        End If

    End Function

    Public Function IsDbNull(colIndex As Integer) As Boolean Implements ISqlResult.IsDbNull
        Return m_datatable.Rows(m_currentRowIndex).IsNull(colIndex)
    End Function

    Public Function MoveNext() As Boolean Implements ISqlResult.MoveNext

        m_currentRowIndex += 1

        Return m_currentRowIndex < m_rowsCount

    End Function

    Private Sub ShowCastException(innerException As Exception, colIndex As Integer, typeName As String)

        Dim v As Object = m_datatable.Rows(m_currentRowIndex).Field(Of Object)(colIndex)

        Dim msg As String = m_datatable.TableName & " (" & m_currentRowIndex & ", " & colIndex & ") : Impossible de convertir la valeur " & vbAbort & " en " & typeName

        Throw New InvalidCastException(msg, innerException)

    End Sub

End Class

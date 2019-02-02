Imports BDList_TOOLS.Types.Sql

Public Interface ISqlResult

    Function MoveNext() As Boolean

    Function GetCount() As Integer

    Function IsDbNull(colIndex As Integer) As Boolean

    Function GetValue(colName As String) As Object
    Function GetString(colName As String) As String
    Function GetInteger(colName As String) As Nullable(Of Integer)
    Function GetLong(colName As String) As Nullable(Of Long)
    Function GetSingle(colName As String) As Nullable(Of Single)
    Function GetBoolean(colName As String) As Nullable(Of Boolean)
    Function GetDate(colName As String) As Nullable(Of DateTime)
    Function GetSqlDate(colName As String) As SqlDate

    Function GetValue(colIndex As Integer) As IComparable
    Function GetString(colIndex As Integer) As String
    Function GetInteger(colIndex As Integer) As Nullable(Of Integer)
    Function GetLong(colIndex As Integer) As Nullable(Of Long)
    Function GetSingle(colIndex As Integer) As Nullable(Of Single)
    Function GetBoolean(colIndex As Integer) As Nullable(Of Boolean)
    Function GetDate(colIndex As Integer) As Nullable(Of DateTime)
    Function GetSqlDate(colIndex As Integer) As SqlDate

End Interface

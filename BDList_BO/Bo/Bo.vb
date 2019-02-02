Option Explicit On

Namespace BO

    Public MustInherit Class Bo

        Public MustOverride Overrides Function ToString() As String
        Public MustOverride Function GetTableName() As String
        Public MustOverride Function GetFieldName(index As Integer) As String
        Public MustOverride Function GetFieldsCount() As Integer

    End Class

End Namespace
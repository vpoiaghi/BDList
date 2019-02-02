Option Explicit On

Namespace BO

    Public MustInherit Class BoParameter
        Inherits BoWithId

        Private m_fieldsNames As String() = {"Id", "Name", "Value"}

        Dim m_Name As String
        Dim m_Value As String


        Public Overrides Function GetTableName() As String
            Return "Parameter"
        End Function


        Public Overrides Function GetFieldName(index As Integer) As String
            Return m_fieldsNames(index)
        End Function

        Public Overrides Function GetFieldsCount() As Integer
            Return m_fieldsNames.Length()
        End Function


        Public Function GetName() As String
            Return m_Name
        End Function
        Public Sub SetName(p_Name As String)
            m_Name = p_Name
        End Sub

        Public Function GetValue() As String
            Return m_Value
        End Function
        Public Sub SetValue(p_Value As String)
            m_Value = p_Value
        End Sub

    End Class
End Namespace
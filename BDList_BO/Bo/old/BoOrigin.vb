Option Explicit On

Namespace BO

    Public MustInherit Class BoOrigin
        Inherits BoWithId

        Private m_fieldsNames As String() = {"Id", "Name"}

        Dim m_Name As String


        Public Overrides Function GetTableName() As String
            Return "Origin"
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

    End Class
End Namespace
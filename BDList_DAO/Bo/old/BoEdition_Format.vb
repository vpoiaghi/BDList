Option Explicit On

Namespace BO

    Public MustInherit Class BoEdition_Format
        Inherits Bo

        Private m_fieldsNames As String() = {"IdEdition", "IdFormat"}

        Dim m_Edition As BoEdition
        Dim m_Format As BoFormat


        Public Overrides Function GetTableName() As String
            Return "Edition_Format"
        End Function


        Public Overrides Function GetFieldName(index As Integer) As String
            Return m_fieldsNames(index)
        End Function

        Public Overrides Function GetFieldsCount() As Integer
            Return m_fieldsNames.Length()
        End Function


        Public Function GetEdition() As BoEdition
            Return m_Edition
        End Function
        Public Sub SetEdition(p_Edition As BoEdition)
            m_Edition = p_Edition
        End Sub

        Public Function GetFormat() As BoFormat
            Return m_Format
        End Function
        Public Sub SetFormat(p_Format As BoFormat)
            m_Format = p_Format
        End Sub

    End Class
End Namespace
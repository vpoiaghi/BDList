Option Explicit On

Namespace BO

    Public MustInherit Class BoEdition_SizeCategory
        Inherits Bo

        Private m_fieldsNames As String() = {"IdEdition", "IdSizeCategory"}

        Dim m_Edition As BoEdition
        Dim m_SizeCategory As BoSizeCategory


        Public Overrides Function GetTableName() As String
            Return "Edition_SizeCategory"
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

        Public Function GetSizeCategory() As BoSizeCategory
            Return m_SizeCategory
        End Function
        Public Sub SetSizeCategory(p_SizeCategory As BoSizeCategory)
            m_SizeCategory = p_SizeCategory
        End Sub

    End Class
End Namespace
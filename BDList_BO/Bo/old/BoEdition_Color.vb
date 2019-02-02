Option Explicit On

Namespace BO

    Public MustInherit Class BoEdition_Color
        Inherits Bo

        Private m_fieldsNames As String() = {"IdEdition", "IdColor"}

        Dim m_Edition As BoEdition
        Dim m_Color As BoColor


        Public Overrides Function GetTableName() As String
            Return "Edition_Color"
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

        Public Function GetColor() As BoColor
            Return m_Color
        End Function
        Public Sub SetColor(p_Color As BoColor)
            m_Color = p_Color
        End Sub

    End Class
End Namespace
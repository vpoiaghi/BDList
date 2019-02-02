Option Explicit On

Namespace BO

    Public MustInherit Class BoEdition_Serie
        Inherits Bo

        Private m_fieldsNames As String() = {"IdEdition", "IdSerie"}

        Dim m_Edition As BoEdition
        Dim m_Serie As BoSerie


        Public Overrides Function GetTableName() As String
            Return "Edition_Serie"
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

        Public Function GetSerie() As BoSerie
            Return m_Serie
        End Function
        Public Sub SetSerie(p_Serie As BoSerie)
            m_Serie = p_Serie
        End Sub

    End Class
End Namespace
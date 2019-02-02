Option Explicit On

Namespace BO

    Public MustInherit Class BoEdition_OutSerie
        Inherits Bo

        Private m_fieldsNames As String() = {"IdEdition", "IdOutSerie"}

        Dim m_Edition As BoEdition
        Dim m_OutSerie As BoOutSerie


        Public Overrides Function GetTableName() As String
            Return "Edition_OutSerie"
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

        Public Function GetOutSerie() As BoOutSerie
            Return m_OutSerie
        End Function
        Public Sub SetOutSerie(p_OutSerie As BoOutSerie)
            m_OutSerie = p_OutSerie
        End Sub

    End Class
End Namespace
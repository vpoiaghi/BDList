Option Explicit On

Namespace BO

    Public MustInherit Class BoEdition_Society_Role
        Inherits Bo

        Private m_fieldsNames As String() = {"IdEdition", "IdSociety", "IdRole"}

        Dim m_Edition As BoEdition
        Dim m_Society As BoSociety
        Dim m_Role As BoRole


        Public Overrides Function GetTableName() As String
            Return "Edition_Society_Role"
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

        Public Function GetSociety() As BoSociety
            Return m_Society
        End Function
        Public Sub SetSociety(p_Society As BoSociety)
            m_Society = p_Society
        End Sub

        Public Function GetRole() As BoRole
            Return m_Role
        End Function
        Public Sub SetRole(p_Role As BoRole)
            m_Role = p_Role
        End Sub

    End Class
End Namespace
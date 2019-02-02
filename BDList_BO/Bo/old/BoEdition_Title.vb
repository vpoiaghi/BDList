Option Explicit On

Namespace BO

    Public MustInherit Class BoEdition_Title
        Inherits Bo

        Private m_fieldsNames As String() = {"IdEdition", "IdTitle"}

        Dim m_Edition As BoEdition
        Dim m_Title As BoTitle


        Public Overrides Function GetTableName() As String
            Return "Edition_Title"
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

        Public Function GetTitle() As BoTitle
            Return m_Title
        End Function
        Public Sub SetTitle(p_Title As BoTitle)
            m_Title = p_Title
        End Sub

    End Class
End Namespace
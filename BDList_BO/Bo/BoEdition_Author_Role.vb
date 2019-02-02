Imports BDList_TOOLS

Namespace BO

	Public MustInherit Class BoEdition_Author_Role
		Inherits Bo

		Private m_fieldsNames As String() = {"IdEdition", "IdAuthor", "IdRole"}

        Dim m_Edition As New IdList(Of BoEdition)(1)
        Dim m_Author As New IdList(Of BoPerson)(1)
        Dim m_Role As New IdList(Of BoRole)(1)


		Public Overrides Function GetTableName() As String
			Return "Edition_Author_Role"
		End Function


		Public Overrides Function GetFieldName(index as Integer) As String
			Return m_fieldsNames(index)
		End Function

		Public Overrides Function GetFieldsCount() as Integer
			Return m_fieldsNames.Length()
		End Function


		Public Function GetEdition() As BoEdition
            If m_Edition.Count = 1 Then
                Return m_Edition(0)
            Else
                Return Nothing
            End If
		End Function
		Public Sub SetEdition(p_Edition As BoEdition)
            m_Edition(0) = p_Edition
		End Sub

        Public Function GetAuthor() As BoPerson
            If m_Author.Count = 1 Then
                Return m_Author(0)
            Else
                Return Nothing
            End If
        End Function
        Public Sub SetAuthor(p_Author As BoPerson)
            m_Author(0) = p_Author
        End Sub

		Public Function GetRole() As BoRole
            If m_Role.Count = 1 Then
                Return m_Role(0)
            Else
                Return Nothing
            End If
        End Function
		Public Sub SetRole(p_Role As BoRole)
            m_Role(0) = p_Role
		End Sub

	End Class
End Namespace
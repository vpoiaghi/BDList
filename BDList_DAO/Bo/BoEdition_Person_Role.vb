Option Explicit On

Namespace BO

	Public MustInherit Class BoEdition_Person_Role
		Inherits Bo

		Private m_fieldsNames As String() = {"IdEdition", "IdPerson", "IdRole"}

		Dim m_Edition As BoEdition
		Dim m_Person As BoPerson
		Dim m_Role As BoRole


		Public Overrides Function GetTableName() As String
			Return "Edition_Person_Role"
		End Function


		Public Overrides Function GetFieldName(index as Integer) As String
			Return m_fieldsNames(index)
		End Function

		Public Overrides Function GetFieldsCount() as Integer
			Return m_fieldsNames.Length()
		End Function


		Public Function GetEdition() As BoEdition
			Return m_Edition
		End Function
		Public Sub SetEdition(p_Edition As BoEdition)
			m_Edition = p_Edition
		End Sub

		Public Function GetPerson() As BoPerson
			Return m_Person
		End Function
		Public Sub SetPerson(p_Person As BoPerson)
			m_Person = p_Person
		End Sub

		Public Function GetRole() As BoRole
			Return m_Role
		End Function
		Public Sub SetRole(p_Role As BoRole)
			m_Role = p_Role
		End Sub

	End Class
End Namespace
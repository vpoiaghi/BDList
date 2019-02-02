Option Explicit On

Namespace BO

	Public MustInherit Class BoSociety
		Inherits BoWithId

		Private m_fieldsNames As String() = {"Id", "Name", "WebSite"}

		Dim m_Name As String
		Dim m_WebSite As String


		Public Overrides Function GetTableName() As String
			Return "Society"
		End Function


		Public Overrides Function GetFieldName(index as Integer) As String
			Return m_fieldsNames(index)
		End Function

		Public Overrides Function GetFieldsCount() as Integer
			Return m_fieldsNames.Length()
		End Function


		Public Function GetName() As String
			Return m_Name
		End Function
		Public Sub SetName(p_Name As String)
			m_Name = p_Name
		End Sub

		Public Function GetWebSite() As String
			Return m_WebSite
		End Function
		Public Sub SetWebSite(p_WebSite As String)
			m_WebSite = p_WebSite
		End Sub

	End Class
End Namespace
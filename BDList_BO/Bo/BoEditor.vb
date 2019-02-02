Option Explicit On

Namespace BO

	Public MustInherit Class BoEditor
		Inherits BoWithId

        Private m_fieldsNames As String() = {"Id", "Name", "WebSite", "Nationality", "FoundationYear", "CessationYear", "CessationCause", "LegalForm", "Status", "HeadOffice"}

		Dim m_Name As String
		Dim m_WebSite As String
		Dim m_Nationality As String
        Dim m_FoundationYear As Nullable(Of Integer)
        Dim m_CessationYear As Nullable(Of Integer)
        Dim m_CessationCause As String
        Dim m_LegalForm As String
        Dim m_Status As String
        Dim m_HeadOffice As String


        Public Overrides Function GetTableName() As String
            Return "Editor"
        End Function


        Public Overrides Function GetFieldName(index As Integer) As String
            Return m_fieldsNames(index)
        End Function

        Public Overrides Function GetFieldsCount() As Integer
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

        Public Function GetNationality() As String
            Return m_Nationality
        End Function
        Public Sub SetNationality(p_Nationality As String)
            m_Nationality = p_Nationality
        End Sub

        Public Function GetFoundationYear() As Nullable(Of Integer)
            Return m_FoundationYear
        End Function
        Public Sub SetFoundationYear(p_FoundationDate As Nullable(Of Integer))
            m_FoundationYear = p_FoundationDate
        End Sub

        Public Function GetCessationYear() As Nullable(Of Integer)
            Return m_CessationYear
        End Function
        Public Sub SetCessationYear(p_CessationYear As Nullable(Of Integer))
            m_CessationYear = p_CessationYear
        End Sub

		Public Function GetCessationCause() As String
			Return m_CessationCause
		End Function
		Public Sub SetCessationCause(p_CessationCause As String)
			m_CessationCause = p_CessationCause
		End Sub

		Public Function GetLegalForm() As String
			Return m_LegalForm
		End Function
		Public Sub SetLegalForm(p_LegalForm As String)
			m_LegalForm = p_LegalForm
		End Sub

		Public Function GetStatus() As String
			Return m_Status
		End Function
		Public Sub SetStatus(p_Status As String)
			m_Status = p_Status
		End Sub

		Public Function GetHeadOffice() As String
			Return m_HeadOffice
		End Function
		Public Sub SetHeadOffice(p_HeadOffice As String)
			m_HeadOffice = p_HeadOffice
		End Sub

        Public Overrides Function CompareTo(other As BoWithId) As Integer

            If other Is Nothing Then
                Return -1
            Else
                Return GetName.CompareTo(CType(other, BoEditor).GetName)
            End If

        End Function

	End Class
End Namespace
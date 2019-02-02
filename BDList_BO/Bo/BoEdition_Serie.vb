Imports BDList_TOOLS

Namespace BO

	Public MustInherit Class BoEdition_Serie
		Inherits Bo

		Private m_fieldsNames As String() = {"IdEdition", "IdSerie"}

        Dim m_Edition As New IdList(Of BoEdition)(1)
        Dim m_Serie As New IdList(Of BoSerie)(1)


		Public Overrides Function GetTableName() As String
			Return "Edition_Serie"
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

		Public Function GetSerie() As BoSerie
            If m_Serie.Count = 1 Then
                Return m_Serie(0)
            Else
                Return Nothing
            End If
		End Function
		Public Sub SetSerie(p_Serie As BoSerie)
            m_Serie(0) = p_Serie
		End Sub

	End Class
End Namespace
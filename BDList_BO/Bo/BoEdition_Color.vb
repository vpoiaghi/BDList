Imports BDList_TOOLS

Namespace BO

	Public MustInherit Class BoEdition_Color
		Inherits Bo

		Private m_fieldsNames As String() = {"IdEdition", "IdColor"}

        Dim m_Edition As New IdList(Of BoEdition)(1)
        Dim m_Color As New IdList(Of BoColor)(1)


		Public Overrides Function GetTableName() As String
			Return "Edition_Color"
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

		Public Function GetColor() As BoColor
            If m_Color.Count = 1 Then
                Return m_Color(0)
            Else
                Return Nothing
            End If
        End Function
		Public Sub SetColor(p_Color As BoColor)
            m_Color(0) = p_Color
		End Sub

	End Class
End Namespace
Imports BDList_TOOLS

Namespace BO

	Public MustInherit Class BoEdition_Format
		Inherits Bo

		Private m_fieldsNames As String() = {"IdEdition", "IdFormat"}

        Dim m_Edition As New IdList(Of BoEdition)(1)
        Dim m_Format As New IdList(Of BoFormat)(1)


		Public Overrides Function GetTableName() As String
			Return "Edition_Format"
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

		Public Function GetFormat() As BoFormat
            If m_Format.Count = 1 Then
                Return m_Format(0)
            Else
                Return Nothing
            End If
        End Function
		Public Sub SetFormat(p_Format As BoFormat)
            m_Format(0) = p_Format
		End Sub

	End Class
End Namespace
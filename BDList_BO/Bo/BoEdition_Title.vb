Imports BDList_TOOLS

Namespace BO

	Public MustInherit Class BoEdition_Title
		Inherits Bo

		Private m_fieldsNames As String() = {"IdEdition", "IdTitle"}

        Dim m_Edition As New IdList(Of BoEdition)(1)
        Dim m_Title As New IdList(Of BoTitle)(1)


		Public Overrides Function GetTableName() As String
			Return "Edition_Title"
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

		Public Function GetTitle() As BoTitle
            If m_Title.Count = 1 Then
                Return m_Title(0)
            Else
                Return Nothing
            End If
        End Function
		Public Sub SetTitle(p_Title As BoTitle)
            m_Title(0) = p_Title
		End Sub

	End Class
End Namespace
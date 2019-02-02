Imports BDList_TOOLS

Namespace BO

	Public MustInherit Class BoTitle
		Inherits BoWithId

        Private m_fieldsNames As String() = {"Id", "IdSerie", "Name", "OrderNumber", "Story", "OutSerie"}

        Dim m_Serie As New IdList(Of BoSerie)(1)
		Dim m_Name As String
		Dim m_OrderNumber As Nullable(Of Int32)
        Dim m_Story As String
        Dim m_OutSerie As Boolean


		Public Overrides Function GetTableName() As String
			Return "Title"
		End Function


		Public Overrides Function GetFieldName(index as Integer) As String
			Return m_fieldsNames(index)
		End Function

		Public Overrides Function GetFieldsCount() as Integer
			Return m_fieldsNames.Length()
		End Function


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

		Public Function GetName() As String
			Return m_Name
		End Function
		Public Sub SetName(p_Name As String)
			m_Name = p_Name
		End Sub

		Public Function GetOrderNumber() As Nullable(Of Int32)
			Return m_OrderNumber
		End Function
		Public Sub SetOrderNumber(p_OrderNumber As Nullable(Of Int32))
			m_OrderNumber = p_OrderNumber
		End Sub

		Public Function GetStory() As String
			Return m_Story
		End Function
		Public Sub SetStory(p_Story As String)
			m_Story = p_Story
		End Sub

        Public Function IsOutSerie() As Boolean
            Return m_OutSerie
        End Function
        Public Sub SetOutSerie(p_OutSerie As Boolean)
            m_OutSerie = p_OutSerie
        End Sub

	End Class
End Namespace
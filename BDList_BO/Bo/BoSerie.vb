Imports BDList_TOOLS

Namespace BO

	Public MustInherit Class BoSerie
		Inherits BoWithId

		Private m_fieldsNames As String() = {"Id", "IdKind", "IdOrigin", "IdManager", "Name", "SortName", "Ended", "WebSite", "Story"}

        Dim m_Kind As New IdList(Of BoKind)(1)
        Dim m_Origin As New IdList(Of BoOrigin)(1)
        Dim m_Manager As New IdList(Of BoPerson)(1)
		Dim m_Name As String
		Dim m_SortName As String
		Dim m_Ended As Boolean
		Dim m_WebSite As String
		Dim m_Story As String


		Public Overrides Function GetTableName() As String
			Return "Serie"
		End Function


		Public Overrides Function GetFieldName(index as Integer) As String
			Return m_fieldsNames(index)
		End Function

		Public Overrides Function GetFieldsCount() as Integer
			Return m_fieldsNames.Length()
		End Function


		Public Function GetKind() As BoKind
            If m_Kind.Count = 1 Then
                Return m_Kind(0)
            Else
                Return Nothing
            End If
        End Function
		Public Sub SetKind(p_Kind As BoKind)
            If p_Kind Is Nothing Then
                m_Kind.Clear()
            Else
                m_Kind(0) = p_Kind
            End If
        End Sub

		Public Function GetOrigin() As BoOrigin
            If m_Origin.Count = 1 Then
                Return m_Origin(0)
            Else
                Return Nothing
            End If
        End Function
		Public Sub SetOrigin(p_Origin As BoOrigin)
            If p_Origin Is Nothing Then
                m_Origin.Clear()
            Else
                m_Origin(0) = p_Origin
            End If
        End Sub

        Public Function GetManager() As BoPerson
            If m_Manager.Count = 1 Then
                Return m_Manager(0)
            Else
                Return Nothing
            End If
        End Function
        Public Sub SetManager(p_Manager As BoPerson)
            If p_Manager Is Nothing Then
                m_Manager.Clear()
            Else
                m_Manager(0) = p_Manager
            End If
        End Sub

		Public Function GetName() As String
			Return m_Name
		End Function
		Public Sub SetName(p_Name As String)
			m_Name = p_Name
		End Sub

		Public Function GetSortName() As String
			Return m_SortName
		End Function
		Public Sub SetSortName(p_SortName As String)
			m_SortName = p_SortName
		End Sub

		Public Function IsEnded() As Boolean
			Return m_Ended
		End Function
		Public Sub SetEnded(p_Ended As Boolean)
			m_Ended = p_Ended
		End Sub

		Public Function GetWebSite() As String
			Return m_WebSite
		End Function
		Public Sub SetWebSite(p_WebSite As String)
			m_WebSite = p_WebSite
		End Sub

		Public Function GetStory() As String
			Return m_Story
		End Function
		Public Sub SetStory(p_Story As String)
			m_Story = p_Story
		End Sub

	End Class
End Namespace
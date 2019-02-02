Option Explicit On

Namespace BO

    Public MustInherit Class BoSerie
        Inherits BoWithId

        Private m_fieldsNames As String() = {"Id", "IdKind", "IdOrigin", "IdManager", "Name", "SortName", "Ended", "WebSite", "Story"}

        Dim m_Kind As BoKind
        Dim m_Origin As BoOrigin
        Dim m_Manager As BoPerson
        Dim m_Name As String
        Dim m_SortName As String
        Dim m_Ended As Boolean
        Dim m_WebSite As String
        Dim m_Story As String


        Public Overrides Function GetTableName() As String
            Return "Serie"
        End Function


        Public Overrides Function GetFieldName(index As Integer) As String
            Return m_fieldsNames(index)
        End Function

        Public Overrides Function GetFieldsCount() As Integer
            Return m_fieldsNames.Length()
        End Function


        Public Function GetKind() As BoKind
            Return m_Kind
        End Function
        Public Sub SetKind(p_Kind As BoKind)
            m_Kind = p_Kind
        End Sub

        Public Function GetOrigin() As BoOrigin
            Return m_Origin
        End Function
        Public Sub SetOrigin(p_Origin As BoOrigin)
            m_Origin = p_Origin
        End Sub

        Public Function GetManager() As BoPerson
            Return m_Manager
        End Function
        Public Sub SetManager(p_Manager As BoPerson)
            m_Manager = p_Manager
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
Option Explicit On

Namespace BO

    Public MustInherit Class BoCollection
        Inherits BoWithId

        Private m_fieldsNames As String() = {"Id", "IdEditor", "Name", "WebSite", "Management"}

        Dim m_Editor As BoEditor
        Dim m_Name As String
        Dim m_WebSite As String
        Dim m_Management As String


        Public Overrides Function GetTableName() As String
            Return "Collection"
        End Function


        Public Overrides Function GetFieldName(index As Integer) As String
            Return m_fieldsNames(index)
        End Function

        Public Overrides Function GetFieldsCount() As Integer
            Return m_fieldsNames.Length()
        End Function


        Public Function GetEditor() As BoEditor
            Return m_Editor
        End Function
        Public Sub SetEditor(p_Editor As BoEditor)
            m_Editor = p_Editor
        End Sub

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

        Public Function GetManagement() As String
            Return m_Management
        End Function
        Public Sub SetManagement(p_Management As String)
            m_Management = p_Management
        End Sub

    End Class
End Namespace
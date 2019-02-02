Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoCollection
        Inherits NamedBObject

        Dim m_editor As BoEditor
        Dim m_WebSite As String
        Dim m_Management As String
        Dim m_CreationYear As Nullable(Of Integer)

        Public Function GetEditor() As BoEditor
            Return m_editor
        End Function
        Public Sub SetEditor(p_Editor As BoEditor)
            m_editor = p_Editor
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

        Public Function GetCreationYear() As Nullable(Of Integer)
            Return m_CreationYear
        End Function
        Public Sub SetCreationYear(p_CreationYear As Nullable(Of Integer))
            m_CreationYear = p_CreationYear
        End Sub

    End Class
End Namespace
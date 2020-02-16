Option Explicit On

Namespace BO

    Public MustInherit Class BoEditor
        Inherits NamedBObject

        Dim m_manager As BoPerson

        Dim m_WebSite As String
        Dim m_comingWebSite As String
        Dim m_Nationality As String
        Dim m_FoundationYear As Nullable(Of Integer)
        Dim m_CessationYear As Nullable(Of Integer)
        Dim m_CessationCause As String
        Dim m_LegalForm As String
        Dim m_Status As String
        Dim m_HeadOffice As String
        Dim m_HeadQuarters As String
        Dim m_Broadcasting As String

        Public Function GetWebSite() As String
            Return m_WebSite
        End Function
        Public Sub SetWebSite(p_WebSite As String)
            m_WebSite = p_WebSite
        End Sub

        Public Function GetComingWebSite() As String
            Return m_comingWebSite
        End Function
        Public Sub SetComingWebSite(p_ComingWebSite As String)
            m_comingWebSite = p_ComingWebSite
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

        Public Function GetHeadQuarters() As String
            Return m_HeadQuarters
        End Function
        Public Sub SetHeadQuarters(p_HeadQuarters As String)
            m_HeadQuarters = p_HeadQuarters
        End Sub

        Public Function GetBroadcasting() As String
            Return m_Broadcasting
        End Function
        Public Sub SetBroadcasting(p_Broadcasting As String)
            m_Broadcasting = p_Broadcasting
        End Sub

        Public Function GetManager() As BoPerson
            Return m_manager
        End Function
        Public Sub SetManager(p_manager As BoPerson)
            m_manager = p_manager
        End Sub

    End Class
End Namespace
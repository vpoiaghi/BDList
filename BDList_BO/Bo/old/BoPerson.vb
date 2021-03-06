Option Explicit On

Namespace BO

    Public MustInherit Class BoPerson
        Inherits BoWithId

        Private m_fieldsNames As String() = {"Id", "Firstname", "Lastname", "Alias", "WebSite", "BirthDay", "BirthPlace", "DeathDay", "DeathPlace", "Biography"}

        Dim m_Firstname As String
        Dim m_Lastname As String
        Dim m_Alias As String
        Dim m_WebSite As String
        Dim m_BirthDay As Nullable(Of DateTime)
        Dim m_BirthPlace As String
        Dim m_DeathDay As Nullable(Of DateTime)
        Dim m_DeathPlace As String
        Dim m_Biography As String


        Public Overrides Function GetTableName() As String
            Return "Person"
        End Function


        Public Overrides Function GetFieldName(index As Integer) As String
            Return m_fieldsNames(index)
        End Function

        Public Overrides Function GetFieldsCount() As Integer
            Return m_fieldsNames.Length()
        End Function


        Public Function GetFirstname() As String
            Return m_Firstname
        End Function
        Public Sub SetFirstname(p_Firstname As String)
            m_Firstname = p_Firstname
        End Sub

        Public Function GetLastname() As String
            Return m_Lastname
        End Function
        Public Sub SetLastname(p_Lastname As String)
            m_Lastname = p_Lastname
        End Sub

        Public Function GetAlias() As String
            Return m_Alias
        End Function
        Public Sub SetAlias(p_Alias As String)
            m_Alias = p_Alias
        End Sub

        Public Function GetWebSite() As String
            Return m_WebSite
        End Function
        Public Sub SetWebSite(p_WebSite As String)
            m_WebSite = p_WebSite
        End Sub

        Public Function GetBirthDay() As Nullable(Of DateTime)
            Return m_BirthDay
        End Function
        Public Sub SetBirthDay(p_BirthDay As Nullable(Of DateTime))
            m_BirthDay = p_BirthDay
        End Sub

        Public Function GetBirthPlace() As String
            Return m_BirthPlace
        End Function
        Public Sub SetBirthPlace(p_BirthPlace As String)
            m_BirthPlace = p_BirthPlace
        End Sub

        Public Function GetDeathDay() As Nullable(Of DateTime)
            Return m_DeathDay
        End Function
        Public Sub SetDeathDay(p_DeathDay As Nullable(Of DateTime))
            m_DeathDay = p_DeathDay
        End Sub

        Public Function GetDeathPlace() As String
            Return m_DeathPlace
        End Function
        Public Sub SetDeathPlace(p_DeathPlace As String)
            m_DeathPlace = p_DeathPlace
        End Sub

        Public Function GetBiography() As String
            Return m_Biography
        End Function
        Public Sub SetBiography(p_Biography As String)
            m_Biography = p_Biography
        End Sub

    End Class
End Namespace
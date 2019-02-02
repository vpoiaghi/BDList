Namespace IO

    Friend MustInherit Class PhoneElement
        Implements IEquatable(Of PhoneElement)

        Protected m_phoneExplorer As PhoneExplorer = PhoneExplorer.GetInstance
        Private m_infos As PhoneElementInfos

        Private m_fullname As String
        Private m_name As String
        Private m_exists As Boolean

        Protected Sub New(fullname As String)

            m_fullname = fullname.Trim.Replace("\", "/")

            If m_fullname.EndsWith("/") Then
                m_fullname = m_fullname.Substring(0, m_fullname.Length - 1)
            End If

            Dim p As Integer = m_fullname.LastIndexOf("/")
            If p = -1 Then
                m_name = m_fullname
            Else
                m_name = m_fullname.Substring(p + 1)
            End If

            m_infos = Nothing

        End Sub

        Public Function GetCreationDate() As Nullable(Of Date)
            RefreshInfos()
            Return m_infos.GetCreationDate
        End Function

        Public Function GetSize() As Integer
            RefreshInfos()
            Return m_infos.GetSize
        End Function

        Public Overridable Function GetName() As String
            Return m_name
        End Function

        Public Overridable Function GetFullname() As String
            Return m_fullname
        End Function

        Protected Sub RefreshInfos()
            If m_infos Is Nothing Then
                SetInfos(PhoneElementInfos.GetInfos(m_phoneExplorer, Me))
            End If
        End Sub

        Friend Sub SetInfos(infos As PhoneElementInfos)
            m_infos = infos
            m_exists = (m_infos IsNot Nothing)
        End Sub

        Public Function GetParent() As PhoneDirectory
            Return New PhoneDirectory(m_fullname.Substring(0, m_fullname.LastIndexOf("/")))
        End Function

        Public Overridable Function IsExists() As Boolean
            RefreshInfos()
            Return m_exists
        End Function

        Public Overrides Function ToString() As String
            Return m_fullname
        End Function

        Public Overridable Sub Remove()
            m_exists = False
            m_infos = Nothing
        End Sub

        Public Overloads Function Equals(other As PhoneElement) As Boolean Implements IEquatable(Of PhoneElement).Equals

            Return (m_fullname = other.GetFullname)

        End Function
    End Class

End Namespace
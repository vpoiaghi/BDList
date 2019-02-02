Imports BDList_TOOLS

Namespace BO

    Friend NotInheritable Class LinkBObject
        Inherits BObject
        Implements ILinkBObject

        Private m_id1 As Long?
        Private m_id2 As Long?

        Friend Sub New(id1 As Long, id2 As Long)
            m_id1 = id1
            m_id2 = id2
        End Sub

        Friend Function GetId1() As Long?
            Return m_id1
        End Function
        Public Sub SetId1(value As Long?)
            m_id1 = value
        End Sub

        Friend Function GetId2() As Long?
            Return m_id2
        End Function
        Public Sub SetId2(value As Long?)
            m_id2 = value
        End Sub

        Public Overrides Function ToString() As String
            Return "(" & m_id1 & "," & m_id2 & ")"
        End Function

    End Class

End Namespace
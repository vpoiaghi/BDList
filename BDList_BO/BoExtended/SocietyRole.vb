Imports BDList_TOOLS

Namespace BO

    Public Class SocietyRole
        Inherits BoContainer

        Public Sub New(society As Society, role As Role)
            MyBase.New()

            m_boList.Add(society)
            m_boList.Add(role)

            SetId(New Id(society.GetId, role.GetId))

        End Sub

        Public Function GetSociety() As Society
            Return m_boList.Item(0)
        End Function

        Public Sub SetSociety(society As Society)
            m_boList.Item(0) = society
        End Sub

        Public Function GetRole() As Role
            Return m_boList.Item(1)
        End Function

        Public Sub SetRole(role As Role)
            m_boList.Item(1) = role
        End Sub

    End Class

End Namespace
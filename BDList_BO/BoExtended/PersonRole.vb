Imports BDList_TOOLS

Namespace BO

    Public Class PersonRole
        Inherits BoContainer

        Public Sub New(person As Person, role As Role)
            MyBase.New()

            m_boList.Add(person)
            m_boList.Add(role)

            SetId(New Id(person.GetId, role.GetId))

        End Sub

        Public Function GetPerson() As Person
            Return m_boList.Item(0)
        End Function

        Public Sub SetPerson(Person As Person)
            m_boList.Item(0) = Person
        End Sub

        Public Function GetRole() As Role
            Return m_boList.Item(1)
        End Function

        Public Sub SetRole(role As Role)
            m_boList.Item(1) = role
        End Sub

    End Class

End Namespace
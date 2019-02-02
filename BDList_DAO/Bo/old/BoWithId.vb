Option Explicit On

Namespace BO

    Public MustInherit Class BoWithId
        Inherits Bo

        Protected m_Id As Int32

        Public Function GetId() As Int32
            Return m_Id
        End Function

        Public Sub SetId(p_Id As Int32)
            m_Id = p_Id
        End Sub

        Public Overrides Function Equals(obj As Object) As Boolean

            Dim result As Boolean = False

            If obj IsNot Nothing Then
                If TypeOf obj Is BoWithId Then
                    result = (Me.GetId = CType(obj, BoWithId).GetId)
                End If
            End If

            Return result

        End Function

    End Class

End Namespace
Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoWithId
        Inherits Bo
        Implements IdObject, IComparable(Of BoWithId)

        Protected m_Id As Id

        Public Function GetId() As Id Implements IdObject.GetId
            Return m_Id
        End Function

        Public Sub SetId(p_Id As Id) Implements IdObject.SetId
            m_Id = p_Id
        End Sub

        Public Overrides Function Equals(other As Object) As Boolean

            Dim result As Boolean = False

            If other IsNot Nothing Then
                If TypeOf other Is BoWithId Then
                    result = (Me.GetId = CType(other, BoWithId).GetId)
                End If
            End If

            Return result

        End Function

        Public Overridable Function CompareTo(other As BoWithId) As Integer Implements IComparable(Of BoWithId).CompareTo

            If other Is Nothing Then
                Return -1
            Else
                If GetId() < other.GetId Then
                    Return -1
                ElseIf GetId() > other.GetId Then
                    Return 1
                Else
                    Return 0
                End If
            End If

        End Function

    End Class

End Namespace
Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class IdBObject
        Inherits BObject
        Implements IIdBObject

        Private m_id As Long?
        Private m_modifiedDateTime As DateTime

        Public Function GetId() As Long?
            Return m_id
        End Function

        Friend Sub SetId(p_id As Long?)
            m_id = p_id
        End Sub

        Public Function GetModifiedDateTime() As DateTime Implements IIdBObject.GetModifiedDateTime
            Return m_modifiedDateTime
        End Function

        Friend Sub SetModifiedDateTime(value As DateTime) Implements IIdBObject.SetModifiedDateTime
            m_modifiedDateTime = value
        End Sub

        Public Overrides Function ToString() As String
            Return "[ID:" & m_id & "]"
        End Function

        Public Overridable Function CompareWith(other As IdBObject) As Integer

            Dim myId As Long? = Me.GetId()
            Dim otherId As Long? = other.GetId

            If Not (myId.HasValue Or otherId.HasValue) Then
                Return 0

            ElseIf (myId.HasValue And otherId.HasValue) Then
                Return myId.Value.CompareTo(otherId.Value)

            ElseIf myId.HasValue Then
                Return 1

            Else
                Return -1

            End If

        End Function

        Public Function CompareTo(other As Object) As Integer Implements IComparable.CompareTo

            Dim result As Integer = -1

            If other Is Nothing Then
                result = -1

            ElseIf IsDBNull(other) Then
                result = -1

            Else
                Dim myType As Type = Me.GetType
                Dim otherType As Type = other.GetType

                If myType Is otherType Then
                    result = CompareWith(CType(other, IdBObject))
                Else
                    Throw New FormatException("Le type " & myType.FullName & " ne peut être comparé au type " & otherType.FullName & ".")
                End If

            End If

            Return result

        End Function

        Public Overrides Function Equals(other As Object) As Boolean
            Return CompareTo(other) = 0
        End Function

    End Class

End Namespace
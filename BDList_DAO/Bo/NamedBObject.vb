Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class NamedBObject
        Inherits IdBObject

        Protected m_name As String

        Public Overridable Function GetName() As String
            Return m_name
        End Function

        Public Overridable Sub SetName(p_name As String)
            m_name = p_name
        End Sub

        Public Overrides Function ToString() As String
            Return GetName()
        End Function

        Public Overrides Function CompareWith(other As IdBObject) As Integer

            If other Is Nothing Then
                Return -1
            ElseIf Not other.GetType Is Me.GetType Then
                Throw New FormatException
            Else
                Return GetName.CompareTo(CType(other, NamedBObject).GetName)
            End If

        End Function

    End Class

End Namespace
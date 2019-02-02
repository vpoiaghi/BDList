Option Explicit On

Namespace BO

    Public MustInherit Class BoParameter
        Inherits NamedBObject

        Dim m_Value As String

        Public Function GetValue() As String
            Return m_Value
        End Function
        Public Sub SetValue(p_Value As String)
            m_Value = p_Value
        End Sub

    End Class
End Namespace
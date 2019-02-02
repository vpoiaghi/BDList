Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoGoody_Autograph
        Inherits BObject

        Dim m_Goody As BoGoody
        Dim m_Autograph As BoAutograph

        Public Function GetGoody() As BoGoody
            Return m_Goody
        End Function
        Public Sub SetGoody(p_Goody As BoGoody)
            m_Goody = p_Goody
        End Sub

        Public Function GetAutograph() As BoAutograph
            Return m_Autograph
        End Function
        Public Sub SetAutograph(p_Autograph As BoAutograph)
            m_Autograph = p_Autograph
        End Sub

    End Class

End Namespace
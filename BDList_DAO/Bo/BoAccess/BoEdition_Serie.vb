Imports BDList_TOOLS

Namespace BO

	Public MustInherit Class BoEdition_Serie
        Inherits BObject

        Dim m_edition As BoEdition
        Dim m_serie As BoSerie

        Public Function GetEdition() As BoEdition
            Return m_edition
        End Function

        Public Sub SetEdition(p_Edition As BoEdition)
            m_edition = p_Edition
        End Sub

        Public Function GetSerie() As BoSerie
            Return m_serie
        End Function

        Public Sub SetSerie(p_serie As BoSerie)
            m_serie = p_serie
        End Sub

    End Class

End Namespace
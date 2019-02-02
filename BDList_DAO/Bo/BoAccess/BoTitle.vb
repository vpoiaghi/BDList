Imports BDList_TOOLS

Namespace BO

	Public MustInherit Class BoTitle
        Inherits NamedBObject

        Dim m_Serie As BoSerie
        Dim m_OrderNumber As Nullable(Of Int32)
        Dim m_Story As String
        Dim m_OutSerie As Boolean

        Public Function GetSerie() As BoSerie
            Return m_Serie
        End Function
        Public Sub SetSerie(p_serie As BoSerie)
            m_Serie = p_serie
        End Sub

        Public Function GetOrderNumber() As Nullable(Of Int32)
            Return m_OrderNumber
        End Function
        Public Sub SetOrderNumber(p_OrderNumber As Nullable(Of Int32))
            m_OrderNumber = p_OrderNumber
        End Sub

        Public Function GetStory() As String
            Return m_Story
        End Function
        Public Sub SetStory(p_Story As String)
            m_Story = p_Story
        End Sub

        Public Function IsOutSerie() As Boolean
            Return m_OutSerie
        End Function
        Public Sub SetOutSerie(p_OutSerie As Boolean)
            m_OutSerie = p_OutSerie
        End Sub

    End Class
End Namespace
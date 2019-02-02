Option Explicit On

Namespace BO

    Public MustInherit Class BoOutSerie
        Inherits BoWithId

        Private m_fieldsNames As String() = {"Id", "IdSerie", "Name", "OrderNumber", "Story"}

        Dim m_Serie As BoSerie
        Dim m_Name As String
        Dim m_OrderNumber As String
        Dim m_Story As String


        Public Overrides Function GetTableName() As String
            Return "OutSerie"
        End Function


        Public Overrides Function GetFieldName(index As Integer) As String
            Return m_fieldsNames(index)
        End Function

        Public Overrides Function GetFieldsCount() As Integer
            Return m_fieldsNames.Length()
        End Function


        Public Function GetSerie() As BoSerie
            Return m_Serie
        End Function
        Public Sub SetSerie(p_Serie As BoSerie)
            m_Serie = p_Serie
        End Sub

        Public Function GetName() As String
            Return m_Name
        End Function
        Public Sub SetName(p_Name As String)
            m_Name = p_Name
        End Sub

        Public Function GetOrderNumber() As String
            Return m_OrderNumber
        End Function
        Public Sub SetOrderNumber(p_OrderNumber As String)
            m_OrderNumber = p_OrderNumber
        End Sub

        Public Function GetStory() As String
            Return m_Story
        End Function
        Public Sub SetStory(p_Story As String)
            m_Story = p_Story
        End Sub

    End Class
End Namespace
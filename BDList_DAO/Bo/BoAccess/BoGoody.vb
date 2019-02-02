Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoGoody
        Inherits IdBObject

        Dim m_KindOfGoody As BoKindOfGoody
        Dim m_Collection As BoCollection
        Dim m_PossessionState As PossessionState

        Dim m_OrderNumber As Integer
        Dim m_Description As String
        Dim m_Number As String
        Dim m_NumberType As String
        Dim m_NumberMax As Nullable(Of Integer)
        Dim m_Autograph As String
        Dim m_ParutionDate As Nullable(Of Date)
        Dim m_BoughtDate As Nullable(Of Date)
        Dim m_Format As String
        Dim m_Width As Nullable(Of Integer)
        Dim m_Height As Nullable(Of Integer)
        Dim m_Comments As String
        Dim m_BoxNumber As Nullable(Of Integer)
        Dim m_numberInCollection As Nullable(Of Integer)
        Dim m_scanned As Boolean

        Public Function GetCollection() As BoCollection
            Return m_Collection
        End Function
        Public Sub SetCollection(p_Collection As BoCollection)
            m_Collection = p_Collection
        End Sub

        Public Function GetPossessionState() As BoPossessionState
            Return m_PossessionState
        End Function
        Public Sub SetPossessionState(p_PossessionState As BoPossessionState)
            m_PossessionState = p_PossessionState
        End Sub

        Public Function GetOrderNumber() As Integer
            Return m_OrderNumber
        End Function
        Public Sub SetOrderNumber(p_OrderNumber As Integer)
            m_OrderNumber = p_OrderNumber
        End Sub

        Public Function GetKindOfGoody() As BoKindOfGoody
            Return m_KindOfGoody
        End Function
        Public Sub SetKindOfGoody(p_KindOfGoody As BoKindOfGoody)
            m_KindOfGoody = p_KindOfGoody
        End Sub

        Public Function GetDescription() As String
            Return m_Description
        End Function
        Public Sub SetDescription(p_Description As String)
            m_Description = p_Description
        End Sub

        Public Function GetNumber() As String
            Return m_Number
        End Function
        Public Sub SetNumber(p_Number As String)
            m_Number = p_Number
        End Sub

        Public Function GetNumberType() As String
            Return m_NumberType
        End Function
        Public Sub SetNumberType(p_NumberType As String)
            m_NumberType = p_NumberType
        End Sub

        Public Function GetNumberMax() As Nullable(Of Integer)
            Return m_NumberMax
        End Function
        Public Sub SetNumberMax(p_NumberMax As Nullable(Of Integer))
            m_NumberMax = p_NumberMax
        End Sub

        Public Function GetAutograph() As String
            Return m_Autograph
        End Function
        Public Sub SetAutograph(p_Autograph As String)
            m_Autograph = p_Autograph
        End Sub

        Public Function GetParutionDate() As Nullable(Of Date)
            Return m_ParutionDate
        End Function
        Public Sub SetParutionDate(p_ParutionDate As Nullable(Of Date))
            m_ParutionDate = p_ParutionDate
        End Sub

        Public Function GetBoughtDate() As Nullable(Of Date)
            Return m_BoughtDate
        End Function
        Public Sub SetBoughtDate(p_BoughtDate As Nullable(Of Date))
            m_BoughtDate = p_BoughtDate
        End Sub

        Public Function GetFormat() As String
            Return m_Format
        End Function
        Public Sub SetFormat(p_Format As String)
            m_Format = p_Format
        End Sub

        Public Function GetWidth() As Nullable(Of Integer)
            Return m_Width
        End Function
        Public Sub SetWidth(p_Width As Nullable(Of Integer))
            m_Width = p_Width
        End Sub

        Public Function GetHeight() As Nullable(Of Integer)
            Return m_Height
        End Function
        Public Sub SetHeight(p_Height As Nullable(Of Integer))
            m_Height = p_Height
        End Sub

        Public Function GetComments() As String
            Return m_Comments
        End Function
        Public Sub SetComments(p_Comments As String)
            m_Comments = p_Comments
        End Sub

        Public Function GetBoxNumber() As Nullable(Of Integer)
            Return m_BoxNumber
        End Function
        Public Sub SetBoxNumber(p_BoxNumber As Nullable(Of Integer))
            m_BoxNumber = p_BoxNumber
        End Sub

        Public Function GetNumberInCollection() As Nullable(Of Integer)
            Return m_numberInCollection
        End Function
        Public Sub SetNumberInCollection(p_NumberInCollection As Nullable(Of Integer))
            m_numberInCollection = p_NumberInCollection
        End Sub

        Public Function IsScanned() As Boolean
            Return m_scanned
        End Function
        Public Sub SetScanned(p_Scanned As Boolean)
            m_scanned = p_Scanned
        End Sub


    End Class
End Namespace
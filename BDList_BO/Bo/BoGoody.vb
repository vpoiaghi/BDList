Imports BDList_TOOLS

Namespace BO

    Public MustInherit Class BoGoody
        Inherits BoWithId

        Private m_fieldsNames As String() = {"Id", "OrderNumber", "IdEditor", "IdKindOfGoody", "Description", "Number", _
                                             "NumberMax", "Autograph", "ParutionDate", "InPossession", _
                                             "BoughtDate", "Format", "Width", "Height", "Comments", "BoxNumber"}

        Dim m_Editor As New idlist(Of BoEditor)(1)
        Dim m_KindOfGoody As New IdList(Of BoKindOfGoody)(1)

        Dim m_OrderNumber As Integer
        Dim m_Description As String
        Dim m_Number As String
        Dim m_NumberMax As Nullable(Of Integer)
        Dim m_Autograph As String
        Dim m_ParutionDate As Nullable(Of Date)
        Dim m_InPossession As Boolean
        Dim m_BoughtDate As Nullable(Of Date)
        Dim m_Format As String
        Dim m_Width As Nullable(Of Integer)
        Dim m_Height As Nullable(Of Integer)
        Dim m_Comments As String
        Dim m_BoxNumber As Nullable(Of Integer)

        Public Overrides Function GetTableName() As String
            Return "Goody"
        End Function


        Public Overrides Function GetFieldName(index As Integer) As String
            Return m_fieldsNames(index)
        End Function

        Public Overrides Function GetFieldsCount() As Integer
            Return m_fieldsNames.Length()
        End Function


        Public Function GetOrderNumber() As Integer
            Return m_OrderNumber
        End Function
        Public Sub SetOrderNumber(p_OrderNumber As Integer)
            m_OrderNumber = p_OrderNumber
        End Sub

        Public Function GetEditor() As BoEditor
            If m_Editor.Count = 1 Then
                Return m_Editor(0)
            Else
                Return Nothing
            End If
        End Function
        Public Sub SetEditor(p_Editor As BoEditor)
            m_Editor(0) = p_Editor
        End Sub

        Public Function GetKindOfGoody() As BoKindOfGoody
            If m_KindOfGoody.Count = 1 Then
                Return m_KindOfGoody(0)
            Else
                Return Nothing
            End If
        End Function
        Public Sub SetKindOfGoody(p_KindOfGoody As BoKindOfGoody)
            m_KindOfGoody(0) = p_KindOfGoody
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

        Public Function IsInPossession() As Boolean
            Return m_InPossession
        End Function
        Public Sub SetInPossession(p_InPossession As Boolean)
            m_InPossession = p_InPossession
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

    End Class
End Namespace
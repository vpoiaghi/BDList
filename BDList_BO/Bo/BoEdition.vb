Imports BDList_TOOLS

Namespace BO

	Public MustInherit Class BoEdition
		Inherits BoWithId

        Private m_fieldsNames As String() = {"Id", "IdEditor", "IdState", "IdCollection", "EditionNumber", "Read", _
                                             "ISBN", "EAN_ISBN", "ISSN", "DDL", "Reedition", "InPossession", "Integral", _
                                             "Miscellany", "Name", "PageCount", "BoardCount", "GraphicPagesCount", _
                                             "BoughtPrice", "LegalDepositDate", "LegalDepositMonth", "LegalDepositYear", _
                                             "ParutionDate", "ParutionMonth", "ParutionYear", "BoughtDate", "BoughtMonth", _
                                             "BoughtYear", "PrintDate", "PrintMonth", "PrintYear", "Wanted", "VersionNumber", _
                                             "EditionInformations", "Autograph", "SpecialEdition", "Width", "Height", _
                                             "IdSizeCategory", "PrintingNumber", "PrintingMaxNumber"}

        Dim m_Editor As New IdList(Of BoEditor)(1)
        Dim m_State As New IdList(Of BoState)(1)
        Dim m_Collection As New IdList(Of BoCollection)(1)
        Dim m_SizeCategory As New IdList(Of BoSizeCategory)(1)

		Dim m_EditionNumber As String
		Dim m_Read As Boolean
		Dim m_ISBN As String
		Dim m_EAN_ISBN As String
		Dim m_ISSN As String
		Dim m_DDL As String
		Dim m_Reedition As String
		Dim m_InPossession As Boolean
        Dim m_Integral As Boolean
        Dim m_Miscellany As Boolean
        Dim m_Name As String
        Dim m_PageCount As Nullable(Of Int32)
        Dim m_BoardCount As Nullable(Of Int32)
        Dim m_GraphicPagesCount As Nullable(Of Int32)
        Dim m_BoughtPrice As Nullable(Of Int32)
        Dim m_LegalDepositDate As Nullable(Of DateTime)
        Dim m_LegalDepositMonth As Nullable(Of Int32)
        Dim m_LegalDepositYear As Nullable(Of Int32)
        Dim m_ParutionDate As Nullable(Of DateTime)
        Dim m_ParutionMonth As Nullable(Of Int32)
        Dim m_ParutionYear As Nullable(Of Int32)
        Dim m_BoughtDate As Nullable(Of DateTime)
        Dim m_BoughtMonth As Nullable(Of Int32)
        Dim m_BoughtYear As Nullable(Of Int32)
        Dim m_PrintDate As Nullable(Of DateTime)
        Dim m_PrintMonth As Nullable(Of Int32)
        Dim m_PrintYear As Nullable(Of Int32)
        Dim m_Wanted As Boolean
        Dim m_VersionNumber As Nullable(Of Int32)
        Dim m_EditionInformations As String
        Dim m_Autograph As String
        Dim m_SpecialEdition As String
        Dim m_Width As Nullable(Of Int32)
        Dim m_Height As Nullable(Of Int32)
        Dim m_PrintingNumber As Nullable(Of Int32)
        Dim m_PrintingMaxNumber As Nullable(Of Int32)


        Public Overrides Function GetTableName() As String
            Return "Edition"
        End Function


        Public Overrides Function GetFieldName(index As Integer) As String
            Return m_fieldsNames(index)
        End Function

        Public Overrides Function GetFieldsCount() As Integer
            Return m_fieldsNames.Length()
        End Function


        Public Function GetEditor() As BoEditor
            If m_Editor.Count = 1 Then
                Return m_Editor(0)
            Else
                Return Nothing
            End If
        End Function
        Public Sub SetEditor(p_Editor As BoEditor)
            If p_Editor Is Nothing Then
                m_Editor.Clear()
            Else
                m_Editor(0) = p_Editor
            End If
        End Sub

        Public Function GetState() As BoState
            If m_State.Count = 1 Then
                Return m_State(0)
            Else
                Return Nothing
            End If
        End Function
        Public Sub SetState(p_State As BoState)
            If p_State Is Nothing Then
                m_State.Clear()
            Else
                m_State(0) = p_State
            End If
        End Sub

        Public Function GetCollection() As BoCollection
            If m_Collection.Count = 1 Then
                Return m_Collection(0)
            Else
                Return Nothing
            End If
        End Function
        Public Sub SetCollection(p_Collection As BoCollection)
            If p_Collection Is Nothing Then
                m_Collection.Clear()
            Else
                m_Collection(0) = p_Collection
            End If
        End Sub

        Public Function GetSizeCategory() As BoSizeCategory
            If m_SizeCategory.Count = 1 Then
                Return m_SizeCategory(0)
            Else
                Return Nothing
            End If
        End Function
        Public Sub SetSizeCategory(p_SizeCategory As BoSizeCategory)
            If p_SizeCategory Is Nothing Then
                m_SizeCategory.Clear()
            Else
                m_SizeCategory(0) = p_SizeCategory
            End If
        End Sub


        Public Function GetEditionNumber() As String
            Return m_EditionNumber
        End Function
        Public Sub SetEditionNumber(p_EditionNumber As String)
            m_EditionNumber = p_EditionNumber
        End Sub

        Public Function IsRead() As Boolean
            Return m_Read
        End Function
        Public Sub SetRead(p_Read As Boolean)
            m_Read = p_Read
        End Sub

        Public Function GetISBN() As String
            Return m_ISBN
        End Function
        Public Sub SetISBN(p_ISBN As String)
            m_ISBN = p_ISBN
        End Sub

        Public Function GetEAN_ISBN() As String
            Return m_EAN_ISBN
        End Function
        Public Sub SetEAN_ISBN(p_EAN_ISBN As String)
            m_EAN_ISBN = p_EAN_ISBN
        End Sub

        Public Function GetISSN() As String
            Return m_ISSN
        End Function
        Public Sub SetISSN(p_ISSN As String)
            m_ISSN = p_ISSN
        End Sub

        Public Function GetDDL() As String
            Return m_DDL
        End Function
        Public Sub SetDDL(p_DDL As String)
            m_DDL = p_DDL
        End Sub

        Public Function GetReedition() As String
            Return m_Reedition
        End Function
        Public Sub SetReedition(p_Reedition As String)
            m_Reedition = p_Reedition
        End Sub

        Public Function IsInPossession() As Boolean
            Return m_InPossession
        End Function
        Public Sub SetInPossession(p_InPossession As Boolean)
            m_InPossession = p_InPossession
        End Sub

        Public Function IsIntegral() As Boolean
            Return m_Integral
        End Function
        Public Sub SetIntegral(p_Integral As Boolean)
            m_Integral = p_Integral
        End Sub

        Public Function IsMiscellany() As Boolean
            Return m_Miscellany
        End Function
        Public Sub SetMiscellany(p_Miscellany As Boolean)
            m_Miscellany = p_Miscellany
        End Sub

		Public Function GetName() As String
			Return m_Name
		End Function
		Public Sub SetName(p_Name As String)
			m_Name = p_Name
		End Sub

		Public Function GetPageCount() As Nullable(Of Int32)
			Return m_PageCount
		End Function
		Public Sub SetPageCount(p_PageCount As Nullable(Of Int32))
			m_PageCount = p_PageCount
		End Sub

		Public Function GetBoardCount() As Nullable(Of Int32)
			Return m_BoardCount
		End Function
		Public Sub SetBoardCount(p_BoardCount As Nullable(Of Int32))
			m_BoardCount = p_BoardCount
		End Sub

		Public Function GetGraphicPagesCount() As Nullable(Of Int32)
			Return m_GraphicPagesCount
		End Function
		Public Sub SetGraphicPagesCount(p_GraphicPagesCount As Nullable(Of Int32))
			m_GraphicPagesCount = p_GraphicPagesCount
		End Sub

		Public Function GetBoughtPrice() As Nullable(Of Int32)
			Return m_BoughtPrice
		End Function
		Public Sub SetBoughtPrice(p_BoughtPrice As Nullable(Of Int32))
			m_BoughtPrice = p_BoughtPrice
		End Sub

		Public Function GetLegalDepositDate() As Nullable(Of DateTime)
			Return m_LegalDepositDate
		End Function
		Public Sub SetLegalDepositDate(p_LegalDepositDate As Nullable(Of DateTime))
			m_LegalDepositDate = p_LegalDepositDate
		End Sub

		Public Function GetLegalDepositMonth() As Nullable(Of Int32)
			Return m_LegalDepositMonth
		End Function
		Public Sub SetLegalDepositMonth(p_LegalDepositMonth As Nullable(Of Int32))
			m_LegalDepositMonth = p_LegalDepositMonth
		End Sub

		Public Function GetLegalDepositYear() As Nullable(Of Int32)
			Return m_LegalDepositYear
		End Function
		Public Sub SetLegalDepositYear(p_LegalDepositYear As Nullable(Of Int32))
			m_LegalDepositYear = p_LegalDepositYear
		End Sub

		Public Function GetParutionDate() As Nullable(Of DateTime)
			Return m_ParutionDate
		End Function
		Public Sub SetParutionDate(p_ParutionDate As Nullable(Of DateTime))
			m_ParutionDate = p_ParutionDate
		End Sub

		Public Function GetParutionMonth() As Nullable(Of Int32)
			Return m_ParutionMonth
		End Function
		Public Sub SetParutionMonth(p_ParutionMonth As Nullable(Of Int32))
			m_ParutionMonth = p_ParutionMonth
		End Sub

		Public Function GetParutionYear() As Nullable(Of Int32)
			Return m_ParutionYear
		End Function
		Public Sub SetParutionYear(p_ParutionYear As Nullable(Of Int32))
			m_ParutionYear = p_ParutionYear
		End Sub

		Public Function GetBoughtDate() As Nullable(Of DateTime)
			Return m_BoughtDate
		End Function
		Public Sub SetBoughtDate(p_BoughtDate As Nullable(Of DateTime))
			m_BoughtDate = p_BoughtDate
		End Sub

		Public Function GetBoughtMonth() As Nullable(Of Int32)
			Return m_BoughtMonth
		End Function
		Public Sub SetBoughtMonth(p_BoughtMonth As Nullable(Of Int32))
			m_BoughtMonth = p_BoughtMonth
		End Sub

		Public Function GetBoughtYear() As Nullable(Of Int32)
			Return m_BoughtYear
		End Function
		Public Sub SetBoughtYear(p_BoughtYear As Nullable(Of Int32))
			m_BoughtYear = p_BoughtYear
		End Sub

		Public Function GetPrintDate() As Nullable(Of DateTime)
			Return m_PrintDate
		End Function
		Public Sub SetPrintDate(p_PrintDate As Nullable(Of DateTime))
			m_PrintDate = p_PrintDate
		End Sub

		Public Function GetPrintMonth() As Nullable(Of Int32)
			Return m_PrintMonth
		End Function
		Public Sub SetPrintMonth(p_PrintMonth As Nullable(Of Int32))
			m_PrintMonth = p_PrintMonth
		End Sub

		Public Function GetPrintYear() As Nullable(Of Int32)
			Return m_PrintYear
		End Function
		Public Sub SetPrintYear(p_PrintYear As Nullable(Of Int32))
			m_PrintYear = p_PrintYear
		End Sub

		Public Function IsWanted() As Boolean
			Return m_Wanted
		End Function
		Public Sub SetWanted(p_Wanted As Boolean)
			m_Wanted = p_Wanted
		End Sub

		Public Function GetVersionNumber() As Nullable(Of Int32)
			Return m_VersionNumber
		End Function
		Public Sub SetVersionNumber(p_VersionNumber As Nullable(Of Int32))
			m_VersionNumber = p_VersionNumber
		End Sub

		Public Function GetEditionInformations() As String
			Return m_EditionInformations
		End Function
		Public Sub SetEditionInformations(p_EditionInformations As String)
			m_EditionInformations = p_EditionInformations
		End Sub

		Public Function GetAutograph() As String
			Return m_Autograph
		End Function
		Public Sub SetAutograph(p_Autograph As String)
			m_Autograph = p_Autograph
		End Sub

		Public Function GetSpecialEdition() As String
			Return m_SpecialEdition
		End Function
		Public Sub SetSpecialEdition(p_SpecialEdition As String)
			m_SpecialEdition = p_SpecialEdition
		End Sub

		Public Function GetWidth() As Nullable(Of Int32)
			Return m_Width
		End Function
		Public Sub SetWidth(p_Width As Nullable(Of Int32))
			m_Width = p_Width
		End Sub

		Public Function GetHeight() As Nullable(Of Int32)
			Return m_Height
		End Function
		Public Sub SetHeight(p_Height As Nullable(Of Int32))
			m_Height = p_Height
		End Sub

        Public Function GetPrintingNumber() As Nullable(Of Int32)
            Return m_PrintingNumber
        End Function
        Public Sub SetPrintingNumber(p_PrintingNumber As Nullable(Of Int32))
            m_PrintingNumber = p_PrintingNumber
        End Sub

        Public Function GetPrintingMaxNumber() As Nullable(Of Int32)
            Return m_PrintingMaxNumber
        End Function
        Public Sub SetPrintingMaxNumber(p_PrintingMaxNumber As Nullable(Of Int32))
            m_PrintingMaxNumber = p_PrintingMaxNumber
        End Sub

	End Class
End Namespace
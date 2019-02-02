Option Explicit On

Namespace BO

    Public MustInherit Class BoEdition
        Inherits BoWithId

        Private m_fieldsNames As String() = {"Id", "IdEditor", "IdState", "IdCollection", "EditionNumber", "Read", "ISBN", "EAN_ISBN", "ISSN", "DDL", "Reedition", "InPossession", "IsIntegral", "IsMiscellany", "Name", "PageCount", "BoardCount", "GraphicPagesCount", "BoughtPrice", "LegalDepositDate", "LegalDepositMonth", "LegalDepositYear", "ParutionDate", "ParutionMonth", "ParutionYear", "BoughtDate", "BoughtMonth", "BoughtYear", "PrintDate", "PrintMonth", "PrintYear", "Wanted", "VersionNumber", "EditionInformations", "Autograph", "SpecialEdition", "Width", "Height"}

        Dim m_Editor As BoEditor
        Dim m_State As BoState
        Dim m_Collection As BoCollection
        Dim m_EditionNumber As String
        Dim m_Read As Boolean
        Dim m_ISBN As String
        Dim m_EAN_ISBN As String
        Dim m_ISSN As String
        Dim m_DDL As String
        Dim m_Reedition As String
        Dim m_InPossession As Boolean
        Dim m_IsIntegral As Boolean
        Dim m_IsMiscellany As Boolean
        Dim m_Name As String
        Dim m_PageCount As Int32
        Dim m_BoardCount As Int32
        Dim m_GraphicPagesCount As Int32
        Dim m_BoughtPrice As Int32
        Dim m_LegalDepositDate As DateTime
        Dim m_LegalDepositMonth As Int32
        Dim m_LegalDepositYear As Int32
        Dim m_ParutionDate As DateTime
        Dim m_ParutionMonth As Int32
        Dim m_ParutionYear As Int32
        Dim m_BoughtDate As DateTime
        Dim m_BoughtMonth As Int32
        Dim m_BoughtYear As Int32
        Dim m_PrintDate As DateTime
        Dim m_PrintMonth As Int32
        Dim m_PrintYear As Int32
        Dim m_Wanted As Boolean
        Dim m_VersionNumber As Int32
        Dim m_EditionInformations As String
        Dim m_Autograph As String
        Dim m_SpecialEdition As String
        Dim m_Width As Int32
        Dim m_Height As Int32


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
            Return m_Editor
        End Function
        Public Sub SetEditor(p_Editor As BoEditor)
            m_Editor = p_Editor
        End Sub

        Public Function GetState() As BoState
            Return m_State
        End Function
        Public Sub SetState(p_State As BoState)
            m_State = p_State
        End Sub

        Public Function GetCollection() As BoCollection
            Return m_Collection
        End Function
        Public Sub SetCollection(p_Collection As BoCollection)
            m_Collection = p_Collection
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

        Public Function IsIsIntegral() As Boolean
            Return m_IsIntegral
        End Function
        Public Sub SetIsIntegral(p_IsIntegral As Boolean)
            m_IsIntegral = p_IsIntegral
        End Sub

        Public Function IsIsMiscellany() As Boolean
            Return m_IsMiscellany
        End Function
        Public Sub SetIsMiscellany(p_IsMiscellany As Boolean)
            m_IsMiscellany = p_IsMiscellany
        End Sub

        Public Function GetName() As String
            Return m_Name
        End Function
        Public Sub SetName(p_Name As String)
            m_Name = p_Name
        End Sub

        Public Function GetPageCount() As Int32
            Return m_PageCount
        End Function
        Public Sub SetPageCount(p_PageCount As Int32)
            m_PageCount = p_PageCount
        End Sub

        Public Function GetBoardCount() As Int32
            Return m_BoardCount
        End Function
        Public Sub SetBoardCount(p_BoardCount As Int32)
            m_BoardCount = p_BoardCount
        End Sub

        Public Function GetGraphicPagesCount() As Int32
            Return m_GraphicPagesCount
        End Function
        Public Sub SetGraphicPagesCount(p_GraphicPagesCount As Int32)
            m_GraphicPagesCount = p_GraphicPagesCount
        End Sub

        Public Function GetBoughtPrice() As Int32
            Return m_BoughtPrice
        End Function
        Public Sub SetBoughtPrice(p_BoughtPrice As Int32)
            m_BoughtPrice = p_BoughtPrice
        End Sub

        Public Function GetLegalDepositDate() As DateTime
            Return m_LegalDepositDate
        End Function
        Public Sub SetLegalDepositDate(p_LegalDepositDate As DateTime)
            m_LegalDepositDate = p_LegalDepositDate
        End Sub

        Public Function GetLegalDepositMonth() As Int32
            Return m_LegalDepositMonth
        End Function
        Public Sub SetLegalDepositMonth(p_LegalDepositMonth As Int32)
            m_LegalDepositMonth = p_LegalDepositMonth
        End Sub

        Public Function GetLegalDepositYear() As Int32
            Return m_LegalDepositYear
        End Function
        Public Sub SetLegalDepositYear(p_LegalDepositYear As Int32)
            m_LegalDepositYear = p_LegalDepositYear
        End Sub

        Public Function GetParutionDate() As DateTime
            Return m_ParutionDate
        End Function
        Public Sub SetParutionDate(p_ParutionDate As DateTime)
            m_ParutionDate = p_ParutionDate
        End Sub

        Public Function GetParutionMonth() As Int32
            Return m_ParutionMonth
        End Function
        Public Sub SetParutionMonth(p_ParutionMonth As Int32)
            m_ParutionMonth = p_ParutionMonth
        End Sub

        Public Function GetParutionYear() As Int32
            Return m_ParutionYear
        End Function
        Public Sub SetParutionYear(p_ParutionYear As Int32)
            m_ParutionYear = p_ParutionYear
        End Sub

        Public Function GetBoughtDate() As DateTime
            Return m_BoughtDate
        End Function
        Public Sub SetBoughtDate(p_BoughtDate As DateTime)
            m_BoughtDate = p_BoughtDate
        End Sub

        Public Function GetBoughtMonth() As Int32
            Return m_BoughtMonth
        End Function
        Public Sub SetBoughtMonth(p_BoughtMonth As Int32)
            m_BoughtMonth = p_BoughtMonth
        End Sub

        Public Function GetBoughtYear() As Int32
            Return m_BoughtYear
        End Function
        Public Sub SetBoughtYear(p_BoughtYear As Int32)
            m_BoughtYear = p_BoughtYear
        End Sub

        Public Function GetPrintDate() As DateTime
            Return m_PrintDate
        End Function
        Public Sub SetPrintDate(p_PrintDate As DateTime)
            m_PrintDate = p_PrintDate
        End Sub

        Public Function GetPrintMonth() As Int32
            Return m_PrintMonth
        End Function
        Public Sub SetPrintMonth(p_PrintMonth As Int32)
            m_PrintMonth = p_PrintMonth
        End Sub

        Public Function GetPrintYear() As Int32
            Return m_PrintYear
        End Function
        Public Sub SetPrintYear(p_PrintYear As Int32)
            m_PrintYear = p_PrintYear
        End Sub

        Public Function IsWanted() As Boolean
            Return m_Wanted
        End Function
        Public Sub SetWanted(p_Wanted As Boolean)
            m_Wanted = p_Wanted
        End Sub

        Public Function GetVersionNumber() As Int32
            Return m_VersionNumber
        End Function
        Public Sub SetVersionNumber(p_VersionNumber As Int32)
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

        Public Function GetWidth() As Int32
            Return m_Width
        End Function
        Public Sub SetWidth(p_Width As Int32)
            m_Width = p_Width
        End Sub

        Public Function GetHeight() As Int32
            Return m_Height
        End Function
        Public Sub SetHeight(p_Height As Int32)
            m_Height = p_Height
        End Sub

    End Class
End Namespace
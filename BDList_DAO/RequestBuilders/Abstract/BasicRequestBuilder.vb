Imports BDList_DAO_BO.BO
Imports BDList_DAO_BO.DAO
Imports BDList_DATABASE

Namespace RequestBuilder

    Friend MustInherit Class BasicRequestBuilder
        Implements IBasicRequestBuilder

        Protected m_tableName As String
        Protected m_rows As List(Of Hashtable)
        Protected m_fields As Hashtable
        Protected m_fieldNames As DAO.DaoBObject.FieldList
        Protected m_criterias As String

        Public MustOverride Function GetInsertRequest() As String Implements IBasicRequestBuilder.GetInsertRequest
        Public MustOverride Function GetInsertRangeRequests() As List(Of String) Implements IBasicRequestBuilder.GetInsertRangeRequests
        Public MustOverride Function GetUpdateRequest() As String Implements IBasicRequestBuilder.GetUpdateRequest
        Public MustOverride Function GetUpdateRangeRequests() As List(Of String) Implements IBasicRequestBuilder.GetUpdateRangeRequests

        Public Shared Function GetInstance(connectionType As ConnectionTypes, tableName As String, fieldNames As DAO.DaoBObject.FieldList) As IBasicRequestBuilder

            Select Case connectionType
                Case ConnectionTypes.Access
                    Return New BasicAccessRequestBuilder(tableName, fieldNames)
                Case ConnectionTypes.SQLite
                    Return New BasicSQLiteRequestBuilder(tableName, fieldNames)
                Case Else
                    MsgBox("Aucune instance de BasicRequestBuilder n'a pu être fournie.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Type de connection inconnu...")
                    Return Nothing
            End Select

        End Function

        Protected Sub New(p_dao As DAO.DaoBObject)
            m_rows = New List(Of Hashtable)
            m_fields = Nothing
            m_tableName = p_dao.GetTableName
            m_fieldNames = p_dao.GetFields
        End Sub

        Protected Sub New(tableName As String, fieldNames As DAO.DaoBObject.FieldList)
            m_rows = New List(Of Hashtable)
            m_fields = Nothing
            m_tableName = tableName
            m_fieldNames = fieldNames
        End Sub

        Public Sub AddRow() Implements IBasicRequestBuilder.AddRow
            m_fields = New Hashtable
            m_rows.Add(m_fields)
        End Sub

        Public Sub AddValue(ByVal fieldName As String, ByVal fieldValue As String) Implements IBasicRequestBuilder.AddValue

            If m_fields Is Nothing Then
                AddRow()
            End If

            m_fields.Add(fieldName, fieldValue)
        End Sub

        Public Sub AddCriterias(ByVal criterias As String) Implements IBasicRequestBuilder.AddCriterias
            m_criterias = criterias.Trim
        End Sub


    End Class

End Namespace
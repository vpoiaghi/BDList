Imports System
Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.VisualBasic

Friend Class AccessDatabase
    Inherits Connection

    'Connexion à la base
    Private m_cnx As OleDbConnection = Nothing

    Friend Sub New(index As Integer)
        MyBase.New(index)
    End Sub

    Friend Overrides Sub OpenConnection()

        Dim connectionSuccess As Boolean = False

        Try
            ' Chaîne de connexion
            Dim cnxstr As String = "provider = microsoft.ace.oledb.12.0 ; data source = " & Constantes.ACCESS_DATABASE_FILE_PATH & ";"

            m_cnx = New OleDbConnection
            With m_cnx
                .ConnectionString = cnxstr
                .Open()
            End With

        Catch ex As Exception
        End Try

    End Sub

    Friend Overrides Sub CloseConnection()

        If m_cnx IsNot Nothing Then
            m_cnx.Close()
            m_cnx.Dispose()
        End If

    End Sub

    'Friend Overrides Function ExecuteQuery(query As String) As List(Of DataRow)

    '    Dim lst As New List(Of DataRow)
    '    Dim dtt As DataTable = GetDataTable(query)

    '    If dtt IsNot Nothing Then
    '        If dtt.Rows IsNot Nothing Then

    '            For Each row As DataRow In dtt.Rows
    '                lst.Add(row)
    '            Next

    '        End If
    '    End If

    '    Return lst

    'End Function

    Friend Overrides Function DoExecuteQuery(query As String) As ISqlResult
        Return New AccessResult(GetDataTable(query))
    End Function

    Friend Overrides Sub DoExecuteNonQuery(query As String)
        GetDataTable(query)
    End Sub

    Private Function GetDataTable(query As String) As DataTable

        Dim dtt As DataTable = Nothing

        If m_cnx IsNot Nothing Then

            'Création de la commande et on l'instancie (sql)       
            Dim cmd As New OleDbCommand(query)

            'Création du dataadapter (dta) et on l'instancie (cmd)      
            Dim dta As New OleDbDataAdapter(cmd)

            'Création du dataset
            Dim dts As New DataSet

            'On instancie la commande (cmd) à la connection (cnx)       
            cmd.Connection() = m_cnx

            Try
                'On charge le dataset (dts) grâce à la propriété fill du dataadapter (dta)      
                dta.Fill(dts, "table")

                'On charge la datatable (dtt) grâce à la propriété tables du dataset (dts)
                dtt = dts.Tables("table")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        Return dtt

    End Function

End Class

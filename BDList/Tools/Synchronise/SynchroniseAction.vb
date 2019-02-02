Public Class SynchroniseAction

    Enum ActionTypes
        CreateOrUpdateFile
        CreateDirectory
        RemoveFile
        RemoveDirectory
    End Enum

    Private m_actionType As ActionTypes
    Private m_fromPath As String
    Private m_toPath As String

    Public Sub New(actionType As ActionTypes, itemPath As String)
        m_actionType = actionType
        m_toPath = itemPath
    End Sub

    Public Sub New(actionType As ActionTypes, fromPath As String, toPath As String)
        Me.New(actionType, toPath)
        m_fromPath = fromPath
    End Sub

    Public Function GetAction() As ActionTypes
        Return m_actionType
    End Function

    Public Function GetFromPath() As String
        Return m_fromPath
    End Function

    Public Function GetToPath() As String
        Return m_toPath
    End Function

    Public Overrides Function ToString() As String

        Dim s As String = ""

        Select Case m_actionType
            Case ActionTypes.RemoveDirectory : s = "SUPPR. DOSSIER"
            Case ActionTypes.RemoveFile : s = "SUPPR. FICHIER"
            Case ActionTypes.CreateDirectory : s = "CREER DOSSIER"
            Case ActionTypes.CreateOrUpdateFile : s = "CREER OU MAJ FICHIER"
        End Select

        s &= " : " & vbTab

        If Not String.IsNullOrEmpty(m_fromPath) Then
            s &= m_fromPath & " --> "
        End If

        s &= m_toPath

        Return s

    End Function

End Class

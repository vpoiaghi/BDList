Imports BDList_DAO_BO.BO

Public Class SyncCtrlResult

    Public ReadOnly Name As String
    Private m_listSames As New List(Of SyncCtrlItem)
    Private m_listDifferents As New List(Of SyncCtrlItem)
    Private m_listMissingsOnLocal As New List(Of SyncCtrlItem)
    Private m_listMissingsOnPhone As New List(Of SyncCtrlItem)

    Public Sub New(name As String)
        Me.Name = name
    End Sub

    Public Sub AddSame(item As SyncCtrlItem)
        m_listSames.Add(item)
    End Sub

    Public Sub AddDifferent(item As SyncCtrlItem)
        m_listDifferents.Add(item)
    End Sub

    Public Sub AddMissingOnLocal(item As SyncCtrlItem)
        m_listMissingsOnLocal.Add(item)
    End Sub

    Public Sub AddMissingOnPhone(item As SyncCtrlItem)
        m_listMissingsOnPhone.Add(item)
    End Sub

    Public Function GetSamesCount() As Integer
        Return m_listSames.Count
    End Function

    Public Function GetDifferentsCount() As Integer
        Return m_listDifferents.Count
    End Function

    Public Function GetMissingsOnLocalCount() As Integer
        Return m_listMissingsOnLocal.Count
    End Function

    Public Function GetMissingsOnPhoneCount() As Integer
        Return m_listMissingsOnPhone.Count
    End Function

    Public Function GetSames() As List(Of SyncCtrlItem)
        Return m_listSames
    End Function

    Public Function GetDifferents() As List(Of SyncCtrlItem)
        Return m_listDifferents
    End Function

    Public Function GetMissingsOnLocal() As List(Of SyncCtrlItem)
        Return m_listMissingsOnLocal
    End Function

    Public Function GetMissingsOnPhone() As List(Of SyncCtrlItem)
        Return m_listMissingsOnPhone
    End Function

End Class

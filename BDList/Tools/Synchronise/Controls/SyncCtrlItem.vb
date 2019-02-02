Imports BDList_DAO_BO.BO

Public Class SyncCtrlItem

    Public ReadOnly phoneItem As IdBObject
    Public ReadOnly localPhoneItem As IdBObject
    Public ReadOnly localItem As IdBObject
    Public ReadOnly Attributes As List(Of Attribute)

    Public Structure Attribute
        Public Name As String
        Public PhoneValue As Object
        Public LocalValue As Object
        Public IsEqual As Boolean
    End Structure


    Public Sub New(phoneItem As IdBObject, localPhoneItem As IdBObject, localItem As IdBObject)
        Me.phoneItem = phoneItem
        Me.localPhoneItem = localPhoneItem
        Me.localItem = localItem
        Me.Attributes = New List(Of Attribute)
    End Sub

    Public Overrides Function ToString() As String

        If localPhoneItem Is Nothing Then
            Return phoneItem.GetId.Value & " - " & phoneItem.ToString
        Else
            Return localPhoneItem.GetId.Value & " - " & localPhoneItem.ToString
        End If

    End Function

End Class
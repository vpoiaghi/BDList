Imports BDList_DAO_BO.BO
Imports BDList_TOOLS.Types.Sql

Public MustInherit Class SyncCtrl

    Private Function GetAttribute(localValue As Object, phoneValue As Object, name As String, testResult As Boolean) As SyncCtrlItem.Attribute

        Dim a As SyncCtrlItem.Attribute

        a.LocalValue = localValue
        a.PhoneValue = phoneValue
        a.IsEqual = testResult
        a.Name = name

        Return a

    End Function

    Protected Function CompareIdBObjects(item As SyncCtrlItem, localValue As IdBObject, phoneValue As IdBObject, name As String)

        Dim result As Boolean = ((localValue Is Nothing) AndAlso (phoneValue Is Nothing)) OrElse (((localValue IsNot Nothing) AndAlso (phoneValue IsNot Nothing)) AndAlso (localValue.GetId.Equals(phoneValue.GetId)))

        item.Attributes.Add(GetAttribute(localValue, phoneValue, name, result))

        Return result

    End Function

    Protected Function CompareStrings(item As SyncCtrlItem, localValue As String, phoneValue As String, name As String)

        Dim lclValue As String = localValue

        If localValue IsNot Nothing Then
            lclValue = localValue.Replace("""", "''")
        End If

        Dim result As Boolean = (lclValue = phoneValue)

        item.Attributes.Add(GetAttribute(localValue, phoneValue, name, result))

        Return result

    End Function

    Protected Function CompareIntegers(item As SyncCtrlItem, localValue As Integer?, phoneValue As Integer?, name As String)

        Dim result As Boolean = ((localValue Is Nothing) AndAlso (phoneValue Is Nothing)) OrElse (((localValue IsNot Nothing) AndAlso (phoneValue IsNot Nothing)) AndAlso (localValue.Value = phoneValue.Value))

        item.Attributes.Add(GetAttribute(localValue, phoneValue, name, result))

        Return result

    End Function

    Protected Function CompareBooleans(item As SyncCtrlItem, localValue As Boolean, phoneValue As Boolean, name As String)

        Dim result As Boolean = (localValue = phoneValue)

        item.Attributes.Add(GetAttribute(localValue, phoneValue, name, result))

        Return result

    End Function

    Protected Function CompareDates(item As SyncCtrlItem, localValue As Date?, phoneValue As Date?, name As String)

        Dim result As Boolean = ((localValue Is Nothing) AndAlso (phoneValue Is Nothing)) OrElse (((localValue IsNot Nothing) AndAlso (phoneValue IsNot Nothing)) AndAlso (localValue.Value = phoneValue.Value))

        item.Attributes.Add(GetAttribute(localValue, phoneValue, name, result))

        Return result

    End Function

    Protected Function CompareDates(item As SyncCtrlItem, localValue As SqlDate, phoneValue As SqlDate, name As String)

        Dim result As Boolean = ((localValue Is Nothing) AndAlso (phoneValue Is Nothing)) OrElse (((localValue IsNot Nothing) AndAlso (phoneValue IsNot Nothing)) AndAlso (localValue.GetDate = phoneValue.GetDate))

        item.Attributes.Add(GetAttribute(localValue, phoneValue, name, result))

        Return result

    End Function

End Class

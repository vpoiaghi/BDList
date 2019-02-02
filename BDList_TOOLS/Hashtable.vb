Public Class Hashtable(Of KeyType, ValueType)
    Inherits Hashtable

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(capacity As Integer)
        MyBase.New(capacity)
    End Sub

    Public Shadows Sub Add(key As KeyType, value As ValueType)
        MyBase.Item(key) = value
    End Sub

    Public Shadows Function Contains(key As KeyType) As Boolean
        Return MyBase.Contains(key)
    End Function

    Public Shadows Function ContainsKey(key As KeyType) As Boolean
        Return MyBase.ContainsKey(key)
    End Function

    Public Shadows Function ContainsValue(value As ValueType) As Boolean
        Return MyBase.ContainsValue(value)
    End Function

    Public Shadows Function Item(key As KeyType) As ValueType
        Return MyBase.Item(key)
    End Function

    Public Shadows Sub Remove(key As KeyType)
        MyBase.Remove(key)
    End Sub

    Public Shadows Function Clone() As Hashtable(Of KeyType, ValueType)

        Dim htClone As New Hashtable(Of KeyType, ValueType)

        For Each k As KeyType In Keys
            htClone.Add(k, Item(k))
        Next

        Return htClone

    End Function

End Class

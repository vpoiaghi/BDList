Imports BDList_TOOLS

Namespace BO

    Public Interface IIdBObject
        Inherits IBObject, IComparable

        Function GetModifiedDateTime() As DateTime
        Sub SetModifiedDateTime(value As DateTime)

    End Interface

End Namespace
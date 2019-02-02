Namespace BO

    Public MustInherit Class BoContainer
        Inherits BoWithId
        Implements IComparable(Of BoContainer)

        Protected m_boList As List(Of BoWithId)

        Protected Sub New()
            m_boList = New List(Of BoWithId)
        End Sub

        Public Function GetBo(index As Integer) As BoWithId
            Return m_boList.Item(index)
        End Function

        Public Sub SetBo(index As Integer, bo As BoWithId)
            m_boList.Item(index) = bo
        End Sub

        Public Overrides Function GetFieldName(index As Integer) As String
            Return Nothing
        End Function

        Public Overrides Function GetFieldsCount() As Integer
            Return 0
        End Function

        Public Overrides Function GetTableName() As String
            Return Nothing
        End Function

        Public Overrides Function ToString() As String

            Dim result As String = ""

            For Each Bo As BoWithId In m_boList
                result &= Bo.ToString & " - "
            Next

            Return result.Substring(0, result.Length - 3)

        End Function

        Public Overrides Function Equals(obj As Object) As Boolean

            Dim result As Boolean = False

            If obj IsNot Nothing Then
                If TypeOf obj Is BoContainer Then
                    With CType(obj, BoContainer)

                        result = True

                        Dim i As Integer = 0
                        While result AndAlso (i < m_boList.Count)
                            result = result And (Me.m_boList.Item(i).Equals(.m_boList.Item(i)))
                            i += 1
                        End While

                    End With
                End If
            End If

            Return result

        End Function

        Public Overridable Shadows Function CompareTo(other As BoContainer) As Integer Implements IComparable(Of BoContainer).CompareTo
            Return 0
        End Function

    End Class

End Namespace

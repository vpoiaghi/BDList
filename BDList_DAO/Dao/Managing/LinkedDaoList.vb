Namespace DAO

    Friend Class LinkedDaoList

        Public Enum LinkedModes
            MultiNotVeryLinked
            MultiVeryLinked
        End Enum

        Private m_daos As New List(Of LinkedDao)

        Public Sub Add(linkedMode As LinkedModes, dao As DaoBObject)

            m_daos.Add(New LinkedDao(dao, linkedMode))

        End Sub

        Public Function Items() As List(Of LinkedDao)
            Return m_daos
        End Function

        Public Function Items(index As Integer) As LinkedDao
            Return m_daos(index)
        End Function

        Public Function Count() As Integer
            Return m_daos.Count
        End Function

    End Class

End Namespace
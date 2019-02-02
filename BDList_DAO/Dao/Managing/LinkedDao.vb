Namespace DAO

    Friend Class LinkedDao

        Private m_dao As DaoBObject
        Private m_linkedMode As LinkedDaoList.LinkedModes

        Friend Sub New(dao As DaoBObject, linkedMode As LinkedDaoList.LinkedModes)
            m_dao = dao
            m_linkedMode = linkedMode
        End Sub

        Friend Function GetLinkedMode() As LinkedDaoList.LinkedModes
            Return m_linkedMode
        End Function

        Friend Function GetDao() As DaoBObject
            Return m_dao
        End Function

    End Class
End Namespace
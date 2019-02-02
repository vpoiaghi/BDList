Imports BDList_DAO_BO.DAO

Namespace BO

    Public Class InSigning
        Inherits BoInSigning

        Private m_editions As List(Of IdBObject)

        Public Function GetEditions() As List(Of IdBObject)

            If m_editions Is Nothing Then

                m_editions = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoEdition As DaoEdition = DaoManager.GetDao(Of DaoEdition)()
                    m_editions = daoEdition.GetByGoody(Me.GetId)
                End If

            End If

            Return m_editions

        End Function

        Public Sub SetEditions(editions As List(Of IdBObject))
            m_editions = editions
        End Sub

    End Class

End Namespace
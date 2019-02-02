Imports BDList_DAO_BO.DAO

Namespace BO

    Public Class PhoneEdition
        Inherits BoPhoneEdition

        Private m_series As List(Of IdBObject)

        Public Function GetSeries() As List(Of IdBObject)

            If m_series Is Nothing Then

                m_series = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoPhoneSerie As DaoPhoneSerie = DaoManager.GetDao(Of DaoPhoneSerie)()
                    m_series = daoPhoneSerie.GetByEdition(Me.GetId)
                End If

            End If

            Return m_series

        End Function

        Public Sub SetSeries(series As List(Of IdBObject))
            m_series = series
        End Sub

        Public Overrides Function ToString() As String
            Return GetName()
        End Function

    End Class

End Namespace
﻿Imports BDList_DAO_BO.DAO

Namespace BO

    Public Class Ad
        Inherits BoAd

        Private m_adArticles As List(Of IdBObject)

        Public Overrides Function ToString() As String
            Return GetTitle()
        End Function

        Public Function GetAdArticles() As List(Of IdBObject)

            If m_adArticles Is Nothing Then

                m_adArticles = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoAdArticle As DaoAdArticle = DaoManager.GetDao(Of DaoAdArticle)()
                    m_adArticles = daoAdArticle.GetByAd(Me.GetId)
                End If

            End If

            Return m_adArticles

        End Function

        Public Sub SetAdArticles(adArticles As List(Of IdBObject))
            m_adArticles = adArticles
        End Sub

        Public Overloads Function GetArticlesCount() As Integer

            Dim result As Integer

            If (m_adArticles Is Nothing) OrElse (m_adArticles.Count = 0) Then
                result = MyBase.GetArticlesCount
            Else
                result = m_adArticles.Count
            End If

            Return result

        End Function


        Public Overloads Function GetState() As AdState
            Return MyBase.GetState
        End Function

    End Class

End Namespace
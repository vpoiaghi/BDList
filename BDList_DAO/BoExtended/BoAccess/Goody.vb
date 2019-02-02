Imports BDList_DAO_BO.DAO

Namespace BO

    Public Class Goody
        Inherits BoGoody

        Private m_series As List(Of IdBObject)
        Private m_editions As List(Of IdBObject)
        Private m_autographs As List(Of IdBObject)
        Private m_authors As List(Of IdBObject)
        Private m_editors As List(Of IdBObject)

        Public Function GetSeries() As List(Of IdBObject)

            If m_series Is Nothing Then

                m_series = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoSerie As DaoSerie = DaoManager.GetDao(Of DaoSerie)()
                    m_series = daoSerie.GetByGoody(Me.GetId)
                End If

            End If

            Return m_series

        End Function

        Public Sub SetSeries(series As List(Of IdBObject))
            m_series = series
        End Sub

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

        Public Function GetAuthors() As List(Of IdBObject)

            If m_authors Is Nothing Then

                m_authors = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoAuthor As DaoAuthor = DaoManager.GetDao(Of DaoAuthor)()
                    m_authors = daoAuthor.GetByGoody(Me.GetId)
                End If

            End If

            Return m_authors

        End Function

        Public Sub SetAuthors(authors As List(Of IdBObject))
            m_authors = authors
        End Sub

        Public Function GetAutographs() As List(Of IdBObject)

            If m_autographs Is Nothing Then

                m_autographs = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoAutograph As DaoAutograph = DaoManager.GetDao(Of DaoAutograph)()
                    m_autographs = daoAutograph.GetByGoody(Me)
                End If

            End If

            Return m_autographs

        End Function

        Public Sub SetAutographs(autographs As List(Of IdBObject))
            m_autographs = autographs
        End Sub

        Public Function GetEditors() As List(Of IdBObject)

            If m_editors Is Nothing Then

                m_editors = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoEditor As DaoEditor = DaoManager.GetDao(Of DaoEditor)()
                    m_editors = daoEditor.GetByGoody(Me)
                End If

            End If

            Return m_editors

        End Function

        Public Sub SetEditors(editors As List(Of IdBObject))
            m_editors = editors
        End Sub

        Public Overrides Function ToString() As String

            Dim s As String = GetKindOfGoody().ToString
            Dim d As String = GetDescription()

            If s.ToLower = "coffret" Or s.ToLower = "fourreau" Then

                s &= " : "

                For Each e As Edition In GetEditions()
                    s &= e.GetEditionNumber & ", "
                Next

                s = s.Substring(0, s.Length - 2)

            Else
                If Not String.IsNullOrEmpty(d) Then
                    s &= " - " & d
                End If

            End If

            Return s

        End Function

    End Class

End Namespace
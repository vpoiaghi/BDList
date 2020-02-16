Imports BDList_DAO_BO.DAO

Namespace BO

    Public Class Edition
        Inherits BoEdition

        Private m_titles As List(Of IdBObject)
        Private m_series As List(Of IdBObject)
        Private m_formats As List(Of IdBObject)
        Private m_colors As List(Of IdBObject)
        Private m_authorRoles As List(Of IdBObject)
        Private m_societyRoles As List(Of IdBObject)
        Private m_autographs As List(Of IdBObject)

        Public Function GetTitles() As List(Of IdBObject)

            If m_titles Is Nothing Then

                m_titles = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoTitle As DaoTitle = DaoManager.GetDao(Of DaoTitle)()
                    m_titles = daoTitle.GetByEdition(Me.GetId)
                End If

            End If

            Return m_titles

        End Function

        Public Sub SetTitles(titles As List(Of IdBObject))
            m_titles = titles
        End Sub

        Public Function GetSeries() As List(Of IdBObject)

            If m_series Is Nothing Then

                m_series = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoSerie As DaoSerie = DaoManager.GetDao(Of DaoSerie)()
                    m_series = daoSerie.GetByEdition(Me.GetId)
                End If

            End If

            Return m_series

        End Function

        Public Sub SetSeries(series As List(Of IdBObject))
            m_series = series
        End Sub

        Public Function GetFormats() As List(Of IdBObject)

            If m_formats Is Nothing Then

                m_formats = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoFormat As DaoFormat = DaoManager.GetDao(Of DaoFormat)()
                    m_formats = daoFormat.GetByEdition(Me.GetId)
                End If

            End If

            Return m_formats

        End Function

        Public Sub SetFormats(formats As List(Of IdBObject))
            m_formats = formats
        End Sub

        Public Function GetColors() As List(Of IdBObject)

            If m_colors Is Nothing Then

                m_colors = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoColor As DaoColor = DaoManager.GetDao(Of DaoColor)()
                    m_colors = daoColor.GetByEdition(Me.GetId)
                End If

            End If

            Return m_colors

        End Function

        Public Sub SetColors(colors As List(Of IdBObject))
            m_colors = colors
        End Sub

        Public Function GetAuthorRoles() As List(Of IdBObject)

            If m_authorRoles Is Nothing Then

                m_authorRoles = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoAuthorRole As DaoAuthorRole = DaoManager.GetDao(Of DaoAuthorRole)()
                    m_authorRoles = daoAuthorRole.GetByEdition(Me.GetId)
                End If

            End If

            Return m_authorRoles

        End Function

        Public Sub SetAuthorRoles(authorRoles As List(Of IdBObject))
            m_authorRoles = authorRoles
        End Sub

        Public Function GetSocietyRoles() As List(Of IdBObject)

            If m_societyRoles Is Nothing Then

                m_societyRoles = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoSocietyRole As DaoSocietyRole = DaoManager.GetDao(Of DaoSocietyRole)()
                    m_societyRoles = daoSocietyRole.GetByEdition(Me.GetId)
                End If

            End If

            Return m_societyRoles

        End Function

        Public Sub SetSocietyRoles(societyRoles As List(Of IdBObject))
            m_societyRoles = societyRoles
        End Sub

        Public Function GetAutographs() As List(Of IdBObject)

            If m_autographs Is Nothing Then

                m_autographs = New List(Of IdBObject)

                If Me.GetId IsNot Nothing Then
                    Dim daoAutograph As DaoAutograph = DaoManager.GetDao(Of DaoAutograph)()
                    m_autographs = daoAutograph.GetByEdition(Me)
                End If

            End If

            Return m_autographs

        End Function

        Public Sub SetAutographs(autographs As List(Of IdBObject))
            m_autographs = autographs
        End Sub

        Public Overrides Function ToString() As String

            Dim result As String
            Dim es As String = ""

            If GetSpecialEdition() IsNot Nothing Then
                es = " (" & GetSpecialEdition() & ")"
            End If


            If IsIntegral() Then

                result = ("[INT] " & GetEditionNumber()).Trim & es & " - " _
                       & "Titres " & CType(GetTitles(0), Title).GetOrderNumber & " à " & CType(GetTitles.Last, Title).GetOrderNumber

                Dim n As String = GetName()
                If Not String.IsNullOrEmpty(n) Then
                    result &= " " & vbCrLf & n
                End If

                'If GetParutionDate() > Now Then
                '    result = CType(GetSeries(0), Serie).GetName & " : " & result
                'End If

            ElseIf IsMiscellany() Then
                result = ("[REC] " & GetEditionNumber()).Trim & es & " - " & GetName()
            Else

                With CType(GetTitles(0), Title)

                    If .IsOutSerie Then
                        result = ("[HS] " & .GetOrderNumber).Trim & es & " - " & .ToString
                    Else
                        result = .GetOrderNumber & " - " & .GetName & es
                    End If

                End With

                'If GetParutionDate() > Now Then
                '    result = CType(GetSeries(0), Serie).GetName & " : " & result
                'End If

            End If

            Return result

        End Function

    End Class

End Namespace
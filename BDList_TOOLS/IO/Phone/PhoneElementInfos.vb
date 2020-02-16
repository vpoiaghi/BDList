Namespace IO

    Friend Class PhoneElementInfos

        Private Const NO_SUCH_FILE_OR_DIRECTORY As String = "no such file or directory"

        Private m_isDirectory As Boolean
        Private m_size As Nullable(Of Integer)
        Private m_creationDate As Nullable(Of Date)
        Private m_name As String
        Private m_exists

        Public Sub New(lsLineResult As String)

            m_name = Nothing
            m_isDirectory = False
            m_creationDate = Nothing
            m_size = Nothing
            m_exists = False

            If lsLineResult <> "" Then

                With lsLineResult

                    If .ToLower.EndsWith(NO_SUCH_FILE_OR_DIRECTORY) Then

                        m_name = .Substring(0, .Length - NO_SUCH_FILE_OR_DIRECTORY.Length - 2)

                    Else

                        Dim lineElements() As String = lsLineResult.Split({" "}, StringSplitOptions.RemoveEmptyEntries)

                        m_name = lineElements.Last
                        m_isDirectory = (.Substring(0, 1) = "d")
                        m_exists = True

                        Dim dte As String = lineElements(5)
                        Dim hr As String = lineElements(6)
                        'm_creationDate = New Date(.Substring(38, 4), .Substring(43, 2), .Substring(46, 2), .Substring(49, 2), .Substring(52, 2), 0)
                        m_creationDate = New Date(dte.Substring(0, 4), dte.Substring(5, 2), dte.Substring(8, 2), hr.Substring(0, 2), hr.Substring(3, 2), 0)

                        If m_isDirectory Then
                            m_size = Nothing
                        Else
                            m_size = Integer.Parse(lineElements(4))
                        End If

                    End If

                End With

            End If

        End Sub

        Public Shared Function GetInfos(phoneExplorer As PhoneExplorer, phoneElement As PhoneElement) As PhoneElementInfos

            Dim result As PhoneElementInfos = Nothing

            If TypeOf phoneElement Is PhoneDirectory Then

                Dim parentDirFullname As String = phoneElement.GetParent().GetFullName
                Dim resultRowsList As List(Of String) = phoneExplorer.SendRequest("shell ls -l '" & parentDirFullname & "'")
                Dim infos As PhoneElementInfos

                For Each resultRow As String In resultRowsList

                    infos = New PhoneElementInfos(resultRow)

                    If infos.GetName = phoneElement.GetName Then
                        result = infos
                        Exit For
                    End If

                Next

            Else

                Dim resultRowsList As List(Of String) = phoneExplorer.SendRequest("shell ls -l '" & phoneElement.GetFullname & "'")

                If resultRowsList.Count = 1 Then
                    result = New PhoneElementInfos(resultRowsList(0))
                End If

            End If

            Return result

        End Function

        Public Function IsDirectory() As Boolean
            Return m_isDirectory
        End Function

        Public Function GetName() As String
            Return m_name
        End Function

        Public Function GetSize() As Nullable(Of Integer)
            Return m_size
        End Function

        Public Function GetCreationDate() As Date
            Return m_creationDate
        End Function

        Public Function IsExists() As Boolean
            Return m_exists
        End Function

    End Class

End Namespace
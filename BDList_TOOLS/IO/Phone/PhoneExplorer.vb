Imports System.IO
Imports System.Threading

Namespace IO

    Public Class PhoneExplorer

        Private Shared fileCounter As Integer

        Private Shared ReadOnly app As New ApplicationServices.ApplicationBase
        Private Shared ReadOnly PHONE_REQUEST_FILE_FOLDER As String = app.Info.DirectoryPath & "\"
        Private Const ADB_DIRECTORY As String = "E:\Program Files (x86)\Android\sdk\platform-tools\"

        Private m_trasactionActionsList As New List(Of String)
        Private m_inTransaction As Boolean = False

        Private Shared lockObject As New Object
        Private Shared m_instance As PhoneExplorer = Nothing
        Private isConnected As Boolean = False

        Private Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()

            Disconnect()
        End Sub

        Public Shared Function GetInstance() As PhoneExplorer

            If m_instance Is Nothing Then
                SyncLock lockObject
                    If m_instance Is Nothing Then
                        m_instance = New PhoneExplorer
                    End If
                End SyncLock
            End If

            Return m_instance

        End Function

        Public Function Connect() As Boolean
            isConnected = IsPhoneReady()
            Return isConnected
        End Function

        Public Function Disconnect() As Boolean

            If IsPhoneReady() Then

                Try
                    Dim myProcesses As Process() = Process.GetProcessesByName("adb")
                    Dim myProcess As Process

                    For Each myProcess In myProcesses
                        myProcess.Kill()
                    Next myProcess

                    isConnected = False

                Catch e As Exception

                End Try

            End If

            Return isConnected

        End Function

        Private Function IsPhoneReady() As Boolean

            Dim resultLines As List(Of String) = SendRequest("devices")

            Dim found As Boolean = False

            If resultLines.Count > 0 Then

                Dim line As String
                Dim lineIndex As Integer = 0

                While (lineIndex < resultLines.Count) AndAlso (Not found)

                    line = resultLines(lineIndex)

                    If line = "List of devices attached" Then
                        found = True
                    End If

                    lineIndex += 1

                End While

                If found Then
                    found = False

                    While (lineIndex < resultLines.Count) AndAlso (Not found)

                        line = resultLines(lineIndex)

                        If line.StartsWith("*") Then
                            lineIndex += 1
                        Else
                            found = True
                        End If

                    End While

                End If
            End If

            Return found

        End Function

        'Public Function GetInfos(phoneElement As PhoneElement) As PhoneElementInfos

        '    Dim result As PhoneElementInfos = Nothing

        '    If TypeOf phoneElement Is PhoneDirectory Then

        '        Dim parentDirFullname As String = phoneElement.GetParent().GetFullname
        '        Dim resultRowsList As List(Of String) = SendRequest("shell ls -l '" & parentDirFullname & "'")
        '        Dim infos As PhoneElementInfos

        '        For Each resultRow As String In resultRowsList

        '            infos = New PhoneElementInfos(resultRow)

        '            If infos.GetName = phoneElement.GetName Then
        '                result = infos
        '                Exit For
        '            End If

        '        Next

        '    Else

        '        Dim resultRowsList As List(Of String) = SendRequest("shell ls -l '" & phoneElement.GetFullname & "'")

        '        If resultRowsList.Count = 1 Then
        '            result = New PhoneElementInfos(resultRowsList(0))
        '        End If

        '    End If

        '    Return result

        'End Function

        Private Function IsExists(phoneElement As PhoneElement) As Boolean

            Dim infos As PhoneElementInfos = PhoneElementInfos.GetInfos(Me, phoneElement)

            Return (infos IsNot Nothing) AndAlso (infos.IsExists)

        End Function

        Friend Function CreateDirectory(directory As IDirectory) As IDirectory

            Dim request As String = "shell mkdir '" & directory.GetFullName & "'"

            If m_inTransaction Then
                m_trasactionActionsList.Add(request)
            Else
                Try
                    SendRequest(request)
                Catch ex As Exception
                    Return Nothing
                End Try
            End If

            Return directory

        End Function

        Public Function RemoveDirectory(phoneDirectory As IDirectory) As Boolean

            Dim request As String = "shell rm -R '" & phoneDirectory.GetFullName & "'"

            If m_inTransaction Then
                m_trasactionActionsList.Add(request)
            Else
                Try
                    SendRequest(request)
                Catch ex As Exception
                    Return False
                End Try
            End If

            Return True

        End Function

        Public Function RemoveFile(phoneFile As IFile) As Boolean

            Dim request As String = "shell rm '" & phoneFile.GetFullName & "'"

            If m_inTransaction Then
                m_trasactionActionsList.Add(request)
            Else
                Try
                    SendRequest(request)
                Catch ex As Exception
                    Return False
                End Try
            End If

            Return True

        End Function

        Public Function RemoveFile(filePath As String) As Boolean

            Dim request As String = "shell rm '" & filePath & "'"

            If m_inTransaction Then
                m_trasactionActionsList.Add(request)
                Return True
            Else
                Try
                    Return (SendRequest(request).Count > 0)
                Catch ex As Exception
                    Return False
                End Try
            End If

        End Function

        Public Function SendDirectory(localDirectory As IDirectory, phoneDirectory As IDirectory) As Boolean

            Dim localDirectoryFullname As String = localDirectory.GetFullName
            If localDirectoryFullname.EndsWith("\") Then
                localDirectoryFullname = localDirectoryFullname.Substring(0, localDirectoryFullname.Length - 1)
            End If

            Dim request As String = "push """ & localDirectoryFullname & """ """ & phoneDirectory.GetFullName & """"

            If m_inTransaction Then
                m_trasactionActionsList.Add(request)
                Return True
            Else
                Try
                    Return (SendRequest(request).Count > 0)
                Catch ex As Exception
                    Return False
                End Try
            End If


        End Function

        Public Function SendFile(localFile As IFile, phoneFile As IFile) As Boolean

            Dim request As String = "push """ & localFile.GetFullName & """ """ & phoneFile.GetFullName & """"

            If m_inTransaction Then
                m_trasactionActionsList.Add(request)
                Return True
            Else
                Try
                    Return (SendRequest(request).Count > 0)
                Catch ex As Exception
                    Return False
                End Try
            End If


        End Function

        ' Copie un fichier depuis le téléphone vers le PC
        Public Function PullFile(phoneFile As IFile, localFile As IFile) As Boolean

            Dim request As String = "pull """ & phoneFile.GetFullName & """ """ & localFile.GetFullName & """"

            If m_inTransaction Then
                m_trasactionActionsList.Add(request)
                Return True
            Else
                Try
                    Return (SendRequest(request).Count > 0)
                Catch ex As Exception
                    Return False
                End Try
            End If

        End Function

        Public Function GetDirectoriesChilds(phoneDirectory As IDirectory) As List(Of IDirectory)

            Dim result As New List(Of IDirectory)

            Dim resultLinesList As List(Of String) = SendRequest("shell ls -l '" & phoneDirectory.GetFullName & "'")
            Dim element As PhoneElement

            For Each line As String In resultLinesList

                element = GetPhoneElement(phoneDirectory, line)

                If TypeOf element Is IDirectory Then
                    result.Add(CType(element, IDirectory))
                End If
            Next

            Return result


        End Function

        Public Function GetFilesChilds(phoneDirectory As IDirectory) As List(Of IFile)

            Dim result As New List(Of IFile)

            Dim resultLinesList As List(Of String) = SendRequest("shell ls -l '" & phoneDirectory.GetFullName & "'")
            Dim element As PhoneElement

            For Each line As String In resultLinesList

                element = GetPhoneElement(phoneDirectory, line)

                If TypeOf element Is IFile Then
                    result.Add(CType(element, IFile))
                End If
            Next

            Return result


        End Function

        Private Function GetPhoneElement(parentDirectory As PhoneDirectory, lsResultLine As String) As PhoneElement

            Dim result As PhoneElement

            Dim infos As New PhoneElementInfos(lsResultLine)

            If infos.IsDirectory Then
                result = New PhoneDirectory(parentDirectory.GetFullname & "/" & infos.GetName)
            Else
                result = New PhoneFile(parentDirectory.GetFullname & "/" & infos.GetName)
            End If

            result.SetInfos(infos)

            Return result

        End Function

        Public Function GetFoldersTree(rootPath As String) As IDirectory

            Dim root As IDirectory = New PhoneDirectory(rootPath)
            Dim parentDir As IDirectory = root
            Dim parentSubDierctories As List(Of IDirectory).Enumerator = Nothing

            Dim directoriesStack As New Stack(Of IDirectory)
            Dim subDirectoriesStack As New Stack(Of List(Of IDirectory).Enumerator)

            Dim resultLinesList As List(Of String) = SendRequest("shell cd '" & rootPath & "'; ls -R -l")
            Dim resultLinesIndex As Integer = 1
            Dim resultLine As String
            Dim firstChar As String

            Dim s As Integer

            directoriesStack.Push(root)

            While (resultLinesIndex < resultLinesList.Count)

                resultLine = resultLinesList(resultLinesIndex)
                firstChar = resultLine.Substring(0, 1)

                If firstChar = "." Then

                    s = resultLine.Split("/").Length

                    If s > directoriesStack.Count Then
                        parentSubDierctories = parentDir.GetDirectories.GetEnumerator
                        parentSubDierctories.MoveNext()
                        subDirectoriesStack.Push(parentSubDierctories)

                    ElseIf s = directoriesStack.Count Then
                        directoriesStack.Pop()

                        parentSubDierctories = subDirectoriesStack.Pop()
                        parentSubDierctories.MoveNext()
                        subDirectoriesStack.Push(parentSubDierctories)

                    ElseIf s < directoriesStack.Count Then
                        directoriesStack.Pop()

                        While directoriesStack.Count >= s
                            directoriesStack.Pop()
                            subDirectoriesStack.Pop()
                        End While

                        parentSubDierctories = subDirectoriesStack.Pop()
                        parentSubDierctories.MoveNext()
                        subDirectoriesStack.Push(parentSubDierctories)

                    End If

                    parentDir = parentSubDierctories.Current
                    directoriesStack.Push(parentDir)

                ElseIf firstChar = "d" Then
                    CType(parentDir, PhoneDirectory).AddDirectory(CType(GetPhoneElement(parentDir, resultLine), IDirectory))

                ElseIf firstChar = "-" Then
                    CType(parentDir, PhoneDirectory).AddFile(GetPhoneElement(parentDir, resultLine))
                End If

                resultLinesIndex += 1

            End While

            Return root

        End Function

        Public Sub BeginTransaction()

            m_trasactionActionsList.Clear()
            m_inTransaction = True

        End Sub

        Public Function PlayTransaction() As List(Of String)

            Dim result As New List(Of String)

            m_inTransaction = False

            If m_trasactionActionsList.Count > 0 Then

                Dim sr As StreamReader = Nothing

                Dim counter As Integer = GetFreeFileCounter()
                Dim requestFilePath As String = GetRequestFilePath(counter)
                Dim resultFilePath As String = GetResultFilePath(counter)

                BuildRequestBatFile(m_trasactionActionsList, requestFilePath, resultFilePath)

                Dim processId As Integer = Shell("""" & requestFilePath & """", AppWinStyle.Hide, True, 10000)

                While Not IsFreeFileToRead(resultFilePath)
                    Thread.Sleep(500)
                End While

                Try
                    sr = New StreamReader(resultFilePath)
                Catch ex As Exception
                    Throw New Exception("C'est bien là (transaction)", ex)
                End Try


                If sr IsNot Nothing Then
                    Dim line As String = sr.ReadLine()

                    While line IsNot Nothing
                        If line <> "" Then
                            result.Add(line.Trim)
                        End If
                        line = sr.ReadLine()
                    End While

                    sr.Close()
                    sr.Dispose()

                End If

                Try
                    My.Computer.FileSystem.DeleteFile(requestFilePath)
                Catch ex As Exception
                End Try

                Try
                    My.Computer.FileSystem.DeleteFile(resultFilePath)
                Catch ex As Exception
                End Try

            End If

            Return result

        End Function


        Friend Function SendRequest(request As String) As List(Of String)

            Dim sr As StreamReader = Nothing
            Dim result As New List(Of String)

            Dim counter As Integer = GetFreeFileCounter()
            Dim requestFilePath As String = GetRequestFilePath(counter)
            Dim resultFilePath As String = GetResultFilePath(counter)

            BuildRequestBatFile(request, requestFilePath, resultFilePath)

            Dim processId As Integer = Shell("""" & requestFilePath & """", AppWinStyle.Hide, True, 10000)

            While Not IsFreeFileToRead(resultFilePath)
                Thread.Sleep(500)
            End While

            Try
                sr = New StreamReader(resultFilePath)
            Catch ex As Exception
                Throw New Exception("C'est bien là", ex)
            End Try


            If sr IsNot Nothing Then
                Dim line As String = sr.ReadLine()

                While line IsNot Nothing
                    If (line <> "") _
                    AndAlso (Not line.StartsWith("* daemon")) _
                    Then
                        result.Add(line.Trim)
                    End If
                    line = sr.ReadLine()
                End While

                sr.Close()
                sr.Dispose()

            End If

            Try
                My.Computer.FileSystem.DeleteFile(requestFilePath)
            Catch ex As Exception
            End Try

            Try
                My.Computer.FileSystem.DeleteFile(resultFilePath)
            Catch ex As Exception
            End Try

            Return result

        End Function

        Private Function GetFreeFileCounter() As Integer

            fileCounter += 1
            Return fileCounter

            'Dim filesFree As Boolean = False
            'Dim stream As StreamWriter = Nothing

            'While Not filesFree

            '    If (IsFreeFileToWrite(GetRequestFilePath(fileCounter)) _
            '        AndAlso IsFreeFileToWrite(GetResultFilePath(fileCounter))) _
            '    Then
            '        filesFree = True
            '        fileCounter += 1
            '    End If

            'End While

            'Return fileCounter

        End Function

        Private Function IsFreeFileToRead(fullname As String) As Boolean

            Dim stream As StreamReader = Nothing

            Try
                stream = New StreamReader(fullname)
                stream.Close()
                stream.Dispose()
                stream = Nothing

                Return True

            Catch ex As Exception
                Return False
            End Try

        End Function

        Private Function IsFreeFileToWrite(fullname As String) As Boolean

            Dim stream As StreamWriter = Nothing

            Try
                stream = New StreamWriter(fullname)
                stream.Close()
                stream.Dispose()
                stream = Nothing

                Return True

            Catch ex As Exception
                Return False
            End Try

        End Function

        Private Sub BuildRequestBatFile(request As String, requestFilePath As String, resultFilePath As String)

            Dim requestsList As New List(Of String)
            requestsList.Add(request)
            BuildRequestBatFile(requestsList, requestFilePath, resultFilePath)

            'Dim sw As StreamWriter = Nothing
            'Dim readOk As Boolean = False

            'My.Computer.FileSystem.DeleteFile(requestFilePath)
            'My.Computer.FileSystem.DeleteFile(resultFilePath)

            'sw = New StreamWriter(requestFilePath, False, System.Text.Encoding.Default)

            'If sw IsNot Nothing Then
            '    sw.WriteLine("CHCP")
            '    sw.WriteLine("CHCP 1252")
            '    sw.WriteLine("MODE CON")
            '    sw.WriteLine("cd """ & ADB_DIRECTORY & """")
            '    sw.WriteLine("E:")
            '    sw.WriteLine("adb " & request & " > """ & resultFilePath & """")
            '    sw.WriteLine("CHCP 850")
            '    sw.Close()
            '    sw.Dispose()
            'End If

        End Sub

        Private Sub BuildRequestBatFile(requestsList As List(Of String), requestFilePath As String, resultFilePath As String)

            Dim sw As StreamWriter = Nothing
            Dim readOk As Boolean = False

            sw = New StreamWriter(requestFilePath, False, System.Text.Encoding.Default)

            If sw IsNot Nothing AndAlso requestsList.Count > 0 Then
                sw.WriteLine("CHCP")
                sw.WriteLine("CHCP 1252")
                sw.WriteLine("MODE CON")
                sw.WriteLine("cd """ & ADB_DIRECTORY & """")
                sw.WriteLine("E:")
                sw.WriteLine("adb " & requestsList(0) & " > """ & resultFilePath & """")

                For i = 1 To requestsList.Count - 1
                    sw.WriteLine("adb " & requestsList(i) & " >> """ & resultFilePath & """")
                Next

                sw.WriteLine("CHCP 850")
                sw.Close()
                sw.Dispose()
            End If

        End Sub

        Private Function GetRequestFilePath(counter As Integer) As String
            Return PHONE_REQUEST_FILE_FOLDER & "request" & Format(counter, "00000") & ".bat"
        End Function

        Private Function GetResultFilePath(counter As Integer) As String
            Return PHONE_REQUEST_FILE_FOLDER & "result" & Format(counter, "00000") & ".txt"
        End Function

    End Class

End Namespace
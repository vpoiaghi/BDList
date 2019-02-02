Public Module Accents

    Public Const ACCENTS_LIST As String = "ÀÁÂÃÄÅàáâãäåÒÓÔÕÖØòóôõöøÈÉÊËèéêë€ÌÍÎÏìíîïÙÚÛÜùúûüÿÑñÇç"
    Public Const NO_ACCENTS_LIST As String = "AAAAAAaaaaaaOOOOOOooooooEEEEEeeeeIIIIiiiiUUUUuuuuyNnCc"

    Private ReadOnly lettersConverter As New Hashtable


    Public Function GetLettersWithAccent(letterWithoutAccent) As String()

        Dim p As Integer
        Dim lettersWithAccent As String = ""

        For p = 0 To NO_ACCENTS_LIST.Length - 1
            If NO_ACCENTS_LIST.Substring(p, 1) = letterWithoutAccent Then
                lettersWithAccent &= ACCENTS_LIST.Substring(p, 1)
            End If
        Next

        Dim result(lettersWithAccent.Length) As String

        For p = 0 To lettersWithAccent.Length - 1
            result(p) = lettersWithAccent.Substring(p, 1)
        Next
        result(p) = letterWithoutAccent

        Return result

    End Function

    Public Function GetSqlAccentsFormat(words As String) As String

        Dim result As String = ""

        Dim chars() As Char = words.ToArray
        Dim convertedChars(chars.Length - 1) As String

        Dim letter As String = ""
        Dim letters As String = ""

        Dim accentLetters As Hashtable = GetAccentsForLetters()

        For i As Integer = 0 To chars.Length - 1

            letter = chars(i)

            If String.IsNullOrEmpty(convertedChars(i)) Then

                letters = accentLetters.Item(letter)

                If letters IsNot Nothing Then
                    letters = "[" & letter & letters & "]"
                Else
                    letters = letter
                End If

                convertedChars(i) = letters

                For j As Integer = i + 1 To chars.Length - 1

                    If chars(j) = letter Then
                        convertedChars(j) = letters
                    End If

                Next

            End If

        Next

        For i As Integer = 0 To chars.Length - 1
            result &= convertedChars(i)
        Next

        Return result

    End Function

    Public Function GetAccentsForLetters() As Hashtable

        If lettersConverter.Count = 0 Then
            GetAccentsForLetters(ACCENTS_LIST, NO_ACCENTS_LIST)
            GetAccentsForLetters(NO_ACCENTS_LIST, ACCENTS_LIST)
        End If

        Return lettersConverter

    End Function

    Private Sub GetAccentsForLetters(lettersList1 As String, lettersList2 As String)

        Dim letter As String = ""
        Dim oldLetter As String = ""
        Dim letters As String = ""

        For i As Integer = 0 To lettersList1.Length - 1

            oldLetter = letter
            letter = lettersList1.Substring(i, 1)

            If (letter = oldLetter) OrElse (oldLetter = "") Then
                letters &= lettersList2.Substring(i, 1)
            Else
                lettersConverter.Add(oldLetter, letters)
                letters = lettersList2.Substring(i, 1)
            End If

        Next

        If Not String.IsNullOrEmpty(letters) Then
            lettersConverter.Add(letter, letters)
        End If


    End Sub

End Module

Namespace BO

    Public Class AdArticle
        Inherits BoAdArticle

        Public Enum AutographStates
            Unknown = 0
            WithoutAutograph = 1
            WithAutograph = 2
        End Enum

        Public Enum NumberStates
            Unknown = 0
            WithoutNumber = 1
            WithNumber = 2
            WithNumberOne = 3
        End Enum

        Public Overrides Function IsWithNumber() As Integer

            Dim result As Integer = NumberStates.Unknown
            Dim number As String = Nothing
            Dim itemFound As Boolean = False

            Dim goody As Goody = GetGoody()
            If goody IsNot Nothing Then
                number = goody.GetNumber
                itemFound = True
            End If

            Dim edition As Edition = GetEdition()
            If (edition IsNot Nothing) AndAlso (edition.GetPrintingNumber IsNot Nothing) Then
                number = edition.GetPrintingNumber.ToString
                itemFound = True
            End If

            If itemFound Then

                If String.IsNullOrEmpty(number) Then
                    result = AdArticle.NumberStates.WithoutNumber
                Else
                    number = Trim(number)

                    If (IsNumeric(number) AndAlso (Val(number) = 1)) Then
                        result = AdArticle.NumberStates.WithNumberOne
                    ElseIf number = "I" Then
                        result = AdArticle.NumberStates.WithNumberOne
                    Else
                        result = AdArticle.NumberStates.WithNumber
                    End If

                End If
            Else
                result = AdArticle.NumberStates.Unknown
            End If

            Return result

        End Function

        Public Overrides Function IsWithAutograph() As Integer

            Dim result As Integer = AutographStates.Unknown
            Dim autographs As List(Of IdBObject) = Nothing
            Dim autograph As String = Nothing
            Dim itemFound As Boolean = False

            Dim goody As Goody = GetGoody()
            If goody IsNot Nothing Then
                autographs = goody.GetAutographs
                autograph = goody.GetAutograph
                itemFound = True
            End If

            Dim edition As Edition = GetEdition()
            If edition IsNot Nothing Then
                autographs = edition.GetAutographs
                itemFound = True
            End If

            If itemFound Then

                If (Not String.IsNullOrEmpty(autograph)) OrElse ((autographs IsNot Nothing) AndAlso (autographs.Count > 0)) Then
                    result = AdArticle.AutographStates.WithAutograph
                Else
                    result = AdArticle.AutographStates.WithoutAutograph
                End If

            Else
                result = AdArticle.AutographStates.Unknown
            End If


            Return result

        End Function


        Public Overrides Function ToString() As String

            Dim result As String = "(" & GetId & ")"

            Dim edition As BoEdition = GetEdition()
            If edition IsNot Nothing Then
                result = edition.ToString
            Else
                result = GetGoody.ToString
            End If

            Return result

        End Function

    End Class

End Namespace
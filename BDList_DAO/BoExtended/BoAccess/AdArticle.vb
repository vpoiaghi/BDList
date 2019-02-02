Namespace BO

    Public Class AdArticle
        Inherits BoAdArticle

        Public Enum AutographStates
            WithoutAutograph = 0
            WithAutograph = 1
            Unknown = 2
        End Enum

        Public Enum NumberStates
            WithoutNumber = 0
            WithNumber = 1
            Unknown = 2
        End Enum

        Public Overrides Function IsWithNumber() As Integer

            Dim result As Integer = NumberStates.Unknown
            Dim number As String = Nothing

            Dim goody As Goody = GetGoody()
            If goody IsNot Nothing Then
                number = goody.GetNumber
            End If

            Dim edition As Edition = GetEdition()
            If (edition IsNot Nothing) AndAlso (edition.GetPrintingNumber IsNot Nothing) Then
                number = edition.GetPrintingNumber.ToString
            End If

            If String.IsNullOrEmpty(number) Then
                result = AdArticle.AutographStates.WithoutAutograph
            Else
                result = AdArticle.AutographStates.WithAutograph
            End If

            Return result

        End Function

        Public Overrides Function IsWithAutograph() As Integer

            Dim result As Integer = AutographStates.Unknown
            Dim autographs As List(Of IdBObject) = Nothing
            Dim autograph As String = Nothing

            Dim goody As Goody = GetGoody()
            If goody IsNot Nothing Then
                autographs = goody.GetAutographs
                autograph = goody.GetAutograph
            End If

            Dim edition As Edition = GetEdition()
            If edition IsNot Nothing Then
                autographs = edition.GetAutographs
            End If

            If (Not String.IsNullOrEmpty(autograph)) OrElse ((autographs IsNot Nothing) AndAlso (autographs.Count > 0)) Then
                result = AdArticle.AutographStates.WithAutograph
            Else
                result = AdArticle.AutographStates.WithoutAutograph
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
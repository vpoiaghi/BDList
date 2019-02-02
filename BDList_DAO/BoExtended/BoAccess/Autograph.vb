Namespace BO

    Public Class Autograph
        Inherits BoAutograph

        Public Overrides Function ToString() As String

            Dim dte As String = ""
            If GetAutographDate() IsNot Nothing Then
                dte = ", " & Format(GetAutographDate, "dd/mm/yyyy")
            End If

            Dim autographEvent As String = ""
            If GetEvent() IsNot Nothing Then
                autographEvent = ", " & GetEvent()
            End If

            Return GetAuthor().ToString & dte & autographEvent

        End Function

    End Class

End Namespace
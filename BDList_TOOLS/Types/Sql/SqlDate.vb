Option Explicit On

Namespace Types.Sql

    Public Class SqlDate

        Private value As String
        Private valueChanged As Boolean
        Private valueDate As Date?

        Public Sub New(value As Date?)
            SetValue(value)
        End Sub

        Public Sub New(value As String)
            SetValue(value)
        End Sub

        Public Function GetValue() As String
            Return value
        End Function

        Public Sub SetValue(value As String)
            Me.value = value
            Me.valueDate = Nothing
            Me.valueChanged = True
        End Sub

        Public Sub SetValue(value As Date?)

            Dim newValue As String

            If value Is Nothing Then
                newValue = Nothing
            Else
                newValue = Format(value.Value, "yyyyMMdd_HHmmss")
            End If

            SetValue(newValue)

        End Sub

        Public Function GetDate() As Date?

            If valueChanged Then

                Me.valueDate = Nothing

                If Not ((value Is Nothing) OrElse (value = "")) Then

                    Dim year As Integer = Integer.Parse(Left(value, 4))
                    Dim month As Integer = Integer.Parse(value.Substring(4, 2))
                    Dim day As Integer = Integer.Parse(value.Substring(6, 2))
                    Dim hour As Integer = Integer.Parse(value.Substring(9, 2))
                    Dim minute As Integer = Integer.Parse(value.Substring(11, 2))
                    Dim second As Integer = Integer.Parse(value.Substring(13, 2))

                    Me.valueDate = New Date(year, month, day, hour, minute, second)

                End If

                Me.valueChanged = False

            End If

            Return Me.valueDate

        End Function

        Public Overrides Function ToString() As String
            Return GetValue()
        End Function

    End Class

End Namespace

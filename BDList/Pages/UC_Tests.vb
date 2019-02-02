Imports BDList.BDList_API.EBay
Imports FrameworkPN

Public Class UC_Tests

    Public Sub New(frm As FrmPagesManager)
        MyBase.New(frm)
        InitializeComponent()
    End Sub

    Protected Overrides Sub Activate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(GoogleBookAPI.GetBookInfos("9782505064152").ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim api As New EBayAPI
        'api.SearchByKeywords("ex libris")
        api.GetItemById(2)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.LoadAsync("C:\Users\VINCENT\Desktop\image tordue.jpg")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' 4 points qui definissent un carré/rectangle dans l'image 
        Dim P1 As New Point(422, 72)
        Dim P2 As New Point(1117, 49)
        Dim P3 As New Point(1244, 1101)
        Dim P4 As New Point(332, 1120)

        ' resolution du systeme
        Dim system As Double() = getSystem(P1, P2, P3, P4)

        ' image source
        Dim source As Bitmap = PictureBox1.Image

        ' creation de l'image corrigée (ici avec un ratio 1/8)
        Dim W As Integer = 840
        Dim H As Integer = 1188
        Dim target As New Bitmap(W, H)

        ' pour chaque pixel (x,y) de l'image corrigée
        For y = 0 To H - 1
            For x = 0 To W - 1

                ' conversion dans le repère orthonormé (u,v) [0,1]x[0,1]
                Dim u As Double = x / W
                Dim v As Double = y / H

                ' passage dans le repère perspective
                Dim P As Double() = invert(u, v, system)

                ' copie du pixel (px,py) correspondant de l'image source 
                ' TODO: faire une interpolation
                Dim px As Integer = Math.Round(P(0))
                Dim py As Integer = Math.Round(P(1))

                target.SetPixel(x, y, source.GetPixel(px, py))

            Next
        Next

        PictureBox2.Image = target

    End Sub


    Public Function getSystem(ParamArray P()) As Double()

        Dim system(8) As Double

        Dim sx As Double = (P(0).x - P(1).x) + (P(2).x - P(3).x)
        Dim sy As Double = (P(0).y - P(1).y) + (P(2).y - P(3).y)

        Dim dx1 As Double = P(1).x - P(2).x
        Dim dx2 As Double = P(3).x - P(2).x
        Dim dy1 As Double = P(1).y - P(2).y
        Dim dy2 As Double = P(3).y - P(2).y

        Dim z As Double = (dx1 * dy2) - (dy1 * dx2)
        Dim g As Double = ((sx * dy2) - (sy * dx2)) / z
        Dim h As Double = ((sy * dx1) - (sx * dy1)) / z

        system(0) = P(1).x - P(0).x + g * P(1).x
        system(1) = P(3).x - P(0).x + h * P(3).x
        system(2) = P(0).x
        system(3) = P(1).y - P(0).y + g * P(1).y
        system(4) = P(3).y - P(0).y + h * P(3).y
        system(5) = P(0).y
        system(6) = g
        system(7) = h

        Return system

    End Function

    Private Function invert(u As Double, v As Double, system As Double()) As Double()

        Dim x As Double = (system(0) * u + system(1) * v + system(2)) / (system(6) * u + system(7) * v + 1)
        Dim y As Double = (system(3) * u + system(4) * v + system(5)) / (system(6) * u + system(7) * v + 1)

        Return New Double() {x, y}

    End Function

End Class

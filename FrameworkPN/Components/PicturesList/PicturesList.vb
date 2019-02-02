Imports BDList_TOOLS.IO

Public Class PicturesList
    Inherits Panel

    Private m_pictureFileNameBuilder As PictureFileNameBuilder
    Private m_pctItemsList As List(Of PctItem)
    Private m_selectedItem As PictureItem = Nothing

    Private m_picturesPanel As Panel
    Private m_commandsPanel As Panel
    Private m_btnPastePicture As Button
    Private m_btnWindowsExplorer As Button
    Private m_btnShowPicture As Button
    Private m_pctZoom As New PictureBox

    Public Sub New()

        MyBase.New()
        InitializeComponent()

        m_pictureFileNameBuilder = PictureFileNameBuilder.GetInstance
        m_pctItemsList = New List(Of PctItem)

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub Add(ByVal p_file As IFile)

        m_picturesPanel.SuspendLayout()

        Add(New PctItem(p_file))

        m_picturesPanel.ResumeLayout(False)

    End Sub

    public Sub Add(ByVal p_file As IFile, p_image As Image)

        m_picturesPanel.SuspendLayout()

        Add(New PctItem(p_file, p_image))

        m_picturesPanel.ResumeLayout(False)

    End Sub

    Public Sub AddRange(ByVal p_files As List(Of IFile))

        m_picturesPanel.SuspendLayout()

        For Each file As IFile In p_files
            Add(New PctItem(file))
        Next

        m_picturesPanel.ResumeLayout(False)

    End Sub

    Private Sub Add(pctItem As PctItem)

        If (pctItem IsNot Nothing) _
        AndAlso (pctItem.GetFile IsNot Nothing) _
        AndAlso (pctItem.GetImage IsNot Nothing) _
        Then

            Dim samePctItem As PctItem = Nothing

            For Each p As PctItem In m_pctItemsList
                If p.GetFile.GetFullName = pctItem.GetFile.GetFullName Then
                    samePctItem = p
                    Exit For
                End If
            Next

            If samePctItem IsNot Nothing Then

                If MsgBox("Le fichier existe déjà. Voulez-vous le remplacer ?", vbYesNo + vbCritical, "Fichier existant...") = vbYes Then
                    samePctItem.setImage(pctItem.GetImage)

                    For Each p As PictureItem In m_picturesPanel.Controls

                        ' Réapplique le PctItem pour forcer le PictureItem à se redessiner.
                        If p.GetItem Is samePctItem Then
                            p.SetItem(samePctItem)
                        End If

                    Next

                End If

            Else
                m_pctItemsList.Add(pctItem)
                AddPictureItemOnPanel(pctItem)

            End If

        End If

    End Sub

    Public Sub Clear()

        ClearView()
        m_pctItemsList.Clear()

    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return m_pctItemsList.Count
        End Get
    End Property

    Public Sub SetFileNameBuilder(fileNameBuilder As PictureFileNameBuilder)

        If fileNameBuilder IsNot Nothing Then
            m_pictureFileNameBuilder = fileNameBuilder
        Else
            Throw New FormatException("Un PicturesList ne peut avoir de FileNameBuilder à Null.")
        End If

    End Sub

    Private Sub PictureItem_ItemSelected(ByVal sender As Object)

        If m_selectedItem IsNot Nothing Then
            m_selectedItem.Selected = False
        End If

        m_selectedItem = CType(sender, PictureItem)

        m_btnWindowsExplorer.Enabled = True
        m_btnShowPicture.Enabled = True

    End Sub

    Private Sub PictureItem_ItemUnSelected(ByVal sender As Object)

        m_selectedItem = Nothing

        m_btnWindowsExplorer.Enabled = False
        m_btnShowPicture.Enabled = False

    End Sub

    Public Sub SelectItem(ByVal index As Integer)

        If (index >= 0) AndAlso (index < m_pctItemsList.Count) Then
            CType(m_picturesPanel.Controls(index), PictureItem).Selected = True
        End If

    End Sub

    Private Sub CleanSelection()

        If m_selectedItem IsNot Nothing Then

            m_picturesPanel.SuspendLayout()

            m_selectedItem.Selected = False

            m_picturesPanel.ResumeLayout(False)

        End If

    End Sub

    Private Sub ClearView()

        CloseZoom()
        CleanSelection()

        Me.SuspendLayout()

        m_picturesPanel.Controls.Clear()

        Me.ResumeLayout(False)

    End Sub

    Private Sub AddPictureItemOnPanel(item As PctItem)

        Dim pictureItem As New PictureItem
        pictureItem.SetItem(item)

        Dim itemsCount As Integer = m_pctItemsList.Count

        Dim itemsCountByRow As Integer = (m_picturesPanel.Width - 25) \ (pictureItem.Width + 5)
        Dim rowIndex As Integer = ((itemsCount - 1) \ itemsCountByRow)
        Dim prevItemRowIndex As Integer = 0
        Dim colIndex As Integer = itemsCount - (rowIndex * itemsCountByRow) - 1

        m_picturesPanel.Controls.Add(pictureItem)

        If itemsCount = 1 Then
            pictureItem.Top = 5
        Else
            prevItemRowIndex = ((itemsCount - 2) \ itemsCountByRow)
            If rowIndex = prevItemRowIndex Then
                pictureItem.Top = m_picturesPanel.Controls(itemsCount - 2).Top
            Else
                pictureItem.Top = m_picturesPanel.Controls(itemsCount - 2).Top + (pictureItem.Height + 5)
            End If
        End If

        pictureItem.Left = 5 + colIndex * (pictureItem.Width + 5)

        AddHandler pictureItem.ItemSelected, AddressOf PictureItem_ItemSelected
        AddHandler pictureItem.ItemUnSelected, AddressOf PictureItem_ItemUnSelected

    End Sub

    Default Public Property File(ByVal index As Integer) As IFile
        Get

            If (index >= 0) AndAlso (index < m_pctItemsList.Count) Then
                Return m_pctItemsList(index).GetFile
            Else
                Throw New IndexOutOfRangeException()
            End If

        End Get
        Set(ByVal value As IFile)
            Add(value)
        End Set
    End Property

    Public Sub RemoveAt(ByVal index As Integer)

        If (index >= 0) AndAlso (index < m_pctItemsList.Count) Then

            m_picturesPanel.SuspendLayout()

            With m_picturesPanel.Controls

                Dim item1 As PictureItem
                Dim item2 As PictureItem

                For i As Integer = index To .Count - 2

                    item1 = .Item(i)
                    item2 = .Item(i + 1)

                    item1.SetItem(item2.GetItem)

                    If item2.Selected Then
                        item2.Selected = False
                        item1.Selected = True
                    End If

                Next

            End With

            m_picturesPanel.ResumeLayout(False)

        Else
            Throw New IndexOutOfRangeException()
        End If

    End Sub

    Private Sub PicturesPanel_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)

        Try
            ' recupere la donnée
            'Variable qui contiendra un tableau contenant les fichiers
            Dim strData As Object

            Dim newPicture As Image = Nothing

            'on recupere le drop dans le tableau
            strData = e.Data.GetData(DataFormats.FileDrop)

            If strData IsNot Nothing Then

                Try
                    If IO.File.Exists(strData(0)) Then
                        newPicture = ImageUtils.LoadImage(strData(0))
                    End If
                Catch ex As Exception
                End Try

            End If

            If newPicture Is Nothing Then

                strData = e.Data.GetData(DataFormats.Html)

                If strData IsNot Nothing Then

                    ' on recupere le début de l'adresse de l'image
                    Dim addressStart() As String = Split(strData.ToString, "src=")

                    ' ensuite on ne prend que la source
                    ' prend le guillemet 
                    Dim guillemet = Chr(34)
                    Dim adresse = Split(addressStart(1), guillemet)

                    ' extraction de l'image
                    newPicture = ImageUtils.LoadWebImage(adresse(1))

                End If
            End If

            ' enregistrement de l'image
            If newPicture IsNot Nothing Then

                Dim newFile As iFile = m_pictureFileNameBuilder.GetFile

                If newFile IsNot Nothing Then
                    Add(newFile, newPicture)
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PicturesPanel_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub PicturesPanel_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        CleanSelection()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()

        m_picturesPanel = New Panel
        m_commandsPanel = New Panel

        m_btnPastePicture = New Button
        m_btnWindowsExplorer = New Button
        m_btnShowPicture = New Button

        With Me
            .BackColor = Color.DarkGray
            .Controls.Add(m_picturesPanel)
            .Controls.Add(m_commandsPanel)
        End With

        With m_picturesPanel
            .Dock = DockStyle.Fill
            .BorderStyle = Windows.Forms.BorderStyle.None
            .AllowDrop = True
            .Visible = True
            .AutoScroll = True
        End With
        AddHandler m_picturesPanel.DragDrop, AddressOf PicturesPanel_DragDrop
        AddHandler m_picturesPanel.DragEnter, AddressOf PicturesPanel_DragEnter
        AddHandler m_picturesPanel.MouseUp, AddressOf PicturesPanel_MouseUp

        With m_commandsPanel
            .BackColor = Color.Gray
            .Dock = DockStyle.Bottom
            .Height = 30
            .BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            .Visible = True

            .Controls.Add(m_btnShowPicture)
            .Controls.Add(m_btnWindowsExplorer)
            .Controls.Add(m_btnPastePicture)
        End With

        With m_btnPastePicture
            .Width = 100
            .Dock = DockStyle.Left
            .Text = "Coller"
        End With
        AddHandler m_btnPastePicture.Click, AddressOf m_btnPastePicture_Click

        With m_btnWindowsExplorer
            .Width = 100
            .Dock = DockStyle.Left
            .Text = "Ouvrir dossier"
            .Enabled = False
        End With
        AddHandler m_btnWindowsExplorer.Click, AddressOf m_btnWindowsExplorer_Click

        With m_btnShowPicture
            .Width = 100
            .Dock = DockStyle.Left
            .Text = "Zoom"
            .Enabled = False
        End With
        AddHandler m_btnShowPicture.Click, AddressOf m_btnShowPicture_Click


        Me.ResumeLayout(False)

    End Sub

    Private Sub m_btnPastePicture_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If Clipboard.ContainsImage Then

            Dim newImage As Image = Clipboard.GetImage()
            Dim newFile As IFile = m_pictureFileNameBuilder.GetFile

            If (newFile IsNot Nothing) AndAlso (newImage IsNot Nothing) Then
                Add(newFile, newImage)
            End If

        Else
            MsgBox("Aucune image à coller.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Collage impossible...")
        End If

    End Sub

    Private Sub m_btnWindowsExplorer_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If m_selectedItem IsNot Nothing Then
            System.Diagnostics.Process.Start("explorer.exe", "/select, """ & m_selectedItem.GetItem.GetFile.GetFullName & """")
        End If

    End Sub

    Private Sub m_btnShowPicture_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If m_selectedItem IsNot Nothing Then

            Dim img As Image = m_selectedItem.GetItem.GetImage

            If img IsNot Nothing Then

                m_btnPastePicture.Enabled = False
                m_btnShowPicture.Enabled = False
                m_btnWindowsExplorer.Enabled = False

                m_pctZoom = New PictureBox

                Me.Controls.Add(m_pctZoom)
                With m_pctZoom
                    .BackColor = Color.Black
                    .Dock = DockStyle.Fill
                    .BringToFront()
                    .Image = img
                    .SizeMode = PictureBoxSizeMode.Zoom
                    .Visible = True
                End With

                AddHandler m_pctZoom.Click, AddressOf ZoomPct_Click

            End If

        End If

    End Sub

    Private Sub ZoomPct_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        CloseZoom()
    End Sub

    Private Sub CloseZoom()

        If m_pctZoom IsNot Nothing Then

            m_pctZoom.Hide()
            m_pctZoom.Controls.Clear()
            Me.Controls.Remove(m_pctZoom)
            m_pctZoom = Nothing

            m_btnPastePicture.Enabled = True
            m_btnShowPicture.Enabled = True
            m_btnWindowsExplorer.Enabled = True

        End If

    End Sub

    Public Sub SavePictures()

        For Each p As PctItem In m_pctItemsList
            p.Save()
        Next

    End Sub

End Class

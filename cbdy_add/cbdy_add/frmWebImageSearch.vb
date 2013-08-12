Imports System.IO

Public Class frmWebImageSearch
    Dim extensions As String = ".jpg.gif.png.bmp.jpeg"
    Dim oPictureBrowser As frmImageStore = Nothing
    Private myCurrentName As String
    Public Property CurrentName() As String
        Get
            Return myCurrentName
        End Get
        Set(ByVal value As String)
            myCurrentName = value
        End Set
    End Property

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click, BackToolStripMenuItem.Click
        WebBrowse.GoBack()
    End Sub

    Private Sub btnFwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFwd.Click, ForwardToolStripMenuItem.Click
        WebBrowse.GoForward()
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        If txtURL.Text.StartsWith("http") = False Then
            txtURL.Text = "http://" & txtURL.Text
        End If
        WebBrowse.Navigate(txtURL.Text)
    End Sub

    Private Sub btnImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImages.Click
        Dim PageElements As HtmlElementCollection = WebBrowse.Document.GetElementsByTagName("img")
        If oPictureBrowser Is Nothing Then
            oPictureBrowser = New frmImageStore
        End If
        oPictureBrowser.picArray.Clear()
        For Each CurElement As HtmlElement In PageElements
            Dim source As String = CurElement.GetAttribute("src")
            Dim parts() As String = Split(source, "?")
            source = parts(0)
            Dim ext As String = Path.GetExtension(source).ToLower
            If ext.Length > 0 AndAlso source.ToLower.EndsWith(ext) AndAlso extensions.IndexOf(ext) >= 0 Then
                oPictureBrowser.picArray.Add(source)
            End If
        Next
        oPictureBrowser.CurrentName = CurrentName
        oPictureBrowser.Show()
        oPictureBrowser.BringToFront()
        oPictureBrowser.PicNo = 0
        oPictureBrowser.showPicture(0)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.imgbrowsepos = setFormPos(Me)
        My.Settings.Save()
        Me.Hide()
    End Sub

    Private Sub WebBrowser1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub

    Private Sub WebBrowser1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getFormPos(Me, My.Settings.imgbrowsepos)

    End Sub

    Private Sub frmWebImageSearch_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        My.Settings.imgbrowsepos = setFormPos(Me)
        My.Settings.Save()
    End Sub
End Class
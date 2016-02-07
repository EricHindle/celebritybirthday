Public Class frmOptions

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveOptions()
        Me.Close()
    End Sub

    Private Sub SaveOptions()
        My.Settings.newimagepath = txtNewImagePath.Text
        My.Settings.ImgFolder = txtImagePath.Text
        My.Settings.Save()
    End Sub

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadOptions()
    End Sub

    Private Sub LoadOptions()
        txtNewImagePath.Text = My.Settings.newimagepath
        txtImagePath.Text = My.Settings.ImgFolder

    End Sub
End Class
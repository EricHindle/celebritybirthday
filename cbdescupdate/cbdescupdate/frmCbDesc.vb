Imports System.Text
Imports System.IO

Public Class frmCbDesc

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sUrl As New StringBuilder("http://celebritybirthday.wordpress.com/")
        sUrl.Append(Format(NumericUpDown3.Value, "0000"))
        sUrl.Append("/")
        sUrl.Append(Format(NumericUpDown2.Value, "00"))
        sUrl.Append("/")
        sUrl.Append(Format(NumericUpDown1.Value, "00"))
        sUrl.Append("/")
        sUrl.Append(ComboBox1.Text)
        sUrl.Append("-")
        sUrl.Append(ComboBox2.Text)
        sUrl.Append("/")
        txtUrl.Text = sUrl.ToString
        WebBrowser1.Navigate(sUrl.ToString)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Dim sDtElements As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("dt")
        ComboBox3.Items.Clear()
        RichTextBox1.Text = ""
        For Each sDtElement As HtmlElement In sDtElements
            Dim sElements As HtmlElementCollection = sDtElement.GetElementsByTagName("a")
            For Each sElement As HtmlElement In sElements
                Dim sTitle As String = sElement.GetAttribute("title")
                Dim sHref As String = sElement.GetAttribute("href")
                ComboBox3.Items.Add(sTitle)


                Dim Client As New System.Net.WebClient
                Dim strm As String = Client.DownloadString(sHref)
                Dim srch As String = "<div class=""entry-caption"">"
                If strm.Contains(srch) Then
                    Dim start As Int16 = strm.IndexOf(srch) + srch.Length + 3

                    Dim newstart As Integer = strm.IndexOf("<p>", start) + 3
                    Dim newend As Int16 = strm.IndexOf("</p>", newstart)

                    Dim desc As String = strm.Substring(newstart, newend - newstart)
                    RichTextBox1.Text = RichTextBox1.Text & desc & vbCrLf
                End If



            Next
        Next
    End Sub

End Class

Imports System.Text
Imports System.IO
Imports System.Net

Public Class frmCbDesc
    Private hrefarray As ArrayList

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

        Dim wb As New WebBrowser
        wb.ScriptErrorsSuppressed = True
        wb.Navigate("about:blank")
        Dim cbdoc As HtmlDocument = wb.Document
        Dim Client As New System.Net.WebClient
        Client.Encoding = System.Text.Encoding.UTF8
        Try
            Dim strm As String = Client.DownloadString(sUrl.ToString)
            cbdoc.Write(strm)
            Label1.Text = "Document Complete. Loading names."
            Me.Refresh()
            Dim sDtElements As HtmlElementCollection = cbdoc.GetElementsByTagName("dt")
            ComboBox3.Items.Clear()
            hrefarray = New ArrayList
            For Each sDtElement As HtmlElement In sDtElements
                Dim sElements As HtmlElementCollection = sDtElement.GetElementsByTagName("a")
                For Each sElement As HtmlElement In sElements
                    Dim sTitle As String = sElement.GetAttribute("title")
                    Dim sHref As String = sElement.GetAttribute("href")
                    ComboBox3.Items.Add(sTitle)
                    hrefarray.Add(sHref)
                Next
            Next
            Label1.Text = "Name list complete"
        Catch ex As WebException
            Label1.Text = ex.Message
        Catch ex2 As Exception
            Label1.Text = "Unexpected exception : " & ex2.Message
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim wb As New WebBrowser
        wb.ScriptErrorsSuppressed = True
        wb.Navigate("about:blank")
        Dim cbdoc As HtmlDocument = wb.Document
        RichTextBox1.Text = ""
        Label1.Text = "Seeking text for " & ComboBox3.Text
        Me.Refresh()
        Dim Client As New System.Net.WebClient
        Client.Encoding = System.Text.Encoding.UTF8
        Dim i As Integer = ComboBox3.SelectedIndex
        Dim strm As String = Client.DownloadString(hrefarray(i))
        cbdoc.Write(strm)
        Dim spElements As HtmlElementCollection = cbdoc.GetElementsByTagName("p")
        Dim spElement As HtmlElement = spElements(3)
        If spElement.InnerText.StartsWith("Please log in") Then
            RichTextBox1.Text = "<empty>"
        Else
            RichTextBox1.Text = RichTextBox1.Text & spElement.InnerText & vbCrLf
        End If
        Label1.Text = "Found text for " & ComboBox3.Text
        Client.Dispose()
        cbdoc = Nothing
        wb.Dispose()
    End Sub
End Class

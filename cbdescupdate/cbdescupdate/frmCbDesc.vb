Imports System.Text
Imports System.IO
Imports System.Net

Public Class frmCbDesc
    Private hrefarray As ArrayList

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        getNames()

    End Sub
    Private Sub getNames()
        ShowProgress("Seeking document")
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
            ShowProgress("Document Complete. Loading names.")
            Dim sDtElements As HtmlElementCollection = cbdoc.GetElementsByTagName("dt")
            If sDtElements.Count > 0 Then
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
                ShowProgress("Name list complete")
            Else
                ' no pictures
                ShowProgress("No pictures - no details")
            End If
        Catch ex As WebException
            Label1.Text = ex.Message
        Catch ex2 As Exception
            ShowProgress("Unexpected exception : " & ex2.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        txtPersonId.Text = ""
        btnUpdateDesc.Enabled = False
        getDescriptions()
    End Sub
    Private Sub getDescriptions()
        Dim wb As New WebBrowser
        wb.ScriptErrorsSuppressed = True
        wb.Navigate("about:blank")
        Dim cbdoc As HtmlDocument = wb.Document
        RichTextBox1.Text = ""
        ShowProgress("Seeking text for " & ComboBox3.Text)
        Dim aParts As String() = ComboBox3.Text.Split("(")
        Dim aNames As String() = aParts(0).Trim.Replace(",", " ").Split(" ")
        Me.Refresh()
        Dim Client As New System.Net.WebClient
        Client.Encoding = System.Text.Encoding.UTF8
        Dim i As Integer = ComboBox3.SelectedIndex
        Try
            Dim strm As String = Client.DownloadString(hrefarray(i))
            cbdoc.Write(strm)
            Dim spElements As HtmlElementCollection = cbdoc.GetElementsByTagName("p")
            Dim spElement As HtmlElement = spElements(3)
            If spElement.InnerText.ToLower.Contains("log in") Or spElement.InnerText.ToLower.Contains("log out") Then
                RichTextBox1.Text = "<empty>"
                ShowProgress("No text for " & ComboBox3.Text)
            Else
                RichTextBox1.Text = RichTextBox1.Text & spElement.InnerText & vbCrLf
                Dim oTa As New CelebrityBirthdayDataSetTableAdapters.PersonTableAdapter
                Dim oTable As New CelebrityBirthdayDataSet.PersonDataTable
                Dim sFname As String = "%"
                Dim sSname As String = "%"
                If cbForename.Checked Then
                    sFname += aNames(0) & "%"
                Else
                    If cbSurname.Checked And aNames.Count = 1 Then
                        sSname += aNames(0) & "%"
                    End If
                End If
                If cbSurname.Checked And aNames.Count > 1 Then
                    sSname += aNames(UBound(aNames)) & "%"
                End If
                Me.Refresh()
                Dim iCt As Integer = oTa.FillByNameDate(oTable, sFname, sSname, ComboBox2.SelectedIndex + 1, ComboBox1.SelectedIndex + 1)
                If iCt = 1 Then
                    Dim pRow As CelebrityBirthdayDataSet.PersonRow = oTable.Rows(0)
                    RichTextBox2.Text = pRow.longdesc
                    txtPersonId.Text = CStr(pRow.id)
                    btnUpdateDesc.Enabled = True
                    Me.Refresh()
                    If cbAutoUpdate.Checked And txtPersonId.TextLength > 0 And IsNumeric(txtPersonId.Text) Then
                        Dim opTa As New CelebrityBirthdayDataSetTableAdapters.PersonTableAdapter
                        opTa.UpdateLongDesc(RichTextBox1.Text, CInt(txtPersonId.Text))
                    End If
                    ShowProgress("Found text for " & ComboBox3.Text)
                Else
                    If iCt > 1 Then
                        ShowProgress("Too many records found")
                    Else
                        ShowProgress("No records found")
                    End If
                End If
                oTable.Dispose()
                oTa.Dispose()
            End If
        Catch we As WebException
        End Try

        Client.Dispose()
        cbdoc = Nothing
        wb.Dispose()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged, ComboBox2.SelectedIndexChanged
        ClearFields()
        txtUrl.Text = ""
        ComboBox3.Items.Clear()
        If ComboBox1.SelectedIndex >= 0 And ComboBox2.SelectedIndex >= 0 Then
            Dim oTa As New CelebrityBirthdayDataSetTableAdapters.DatesTableAdapter
            Dim oTable As New CelebrityBirthdayDataSet.DatesDataTable
            Dim ict As Integer = oTa.FillByDate(oTable, ComboBox1.SelectedIndex + 1, ComboBox2.SelectedIndex + 1)
            If ict = 1 Then
                Dim oRow As CelebrityBirthdayDataSet.DatesRow = oTable.Rows(0)
                If oRow.IsuploadmonthNull = False Then
                    NumericUpDown2.Value = CInt(oRow.uploadmonth)
                End If
                If oRow.IsuploadyearNull = False Then
                    NumericUpDown3.Value = CInt(oRow.uploadyear)
                End If
                If oRow.IsuploaddayNull = False Then
                    NumericUpDown1.Value = CInt(oRow.uploadday)
                End If
            End If
            getNames()
            If ComboBox3.Items.Count > 0 Then
                ComboBox3.SelectedIndex = 0
            Else
                ShowProgress("No names found")
            End If
        End If


    End Sub
    Private Sub ClearFields()
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        txtTitle.Text = ""
        txtCaption.Text = ""
        txtPersonId.Text = ""


    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ClearFields()
        btnUpdateDesc.Enabled = False
        If ComboBox3.SelectedIndex >= 0 Then
            getDescriptions()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateDesc.Click
        If txtPersonId.TextLength > 0 And IsNumeric(txtPersonId.Text) Then
            Dim oTa As New CelebrityBirthdayDataSetTableAdapters.PersonTableAdapter
            oTa.UpdateLongDesc(RichTextBox1.Text, CInt(txtPersonId.Text))
            getDescriptions()
        End If
    End Sub

    Private Sub frmCbDesc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnUpdateDesc.Enabled = False
    End Sub

    Private Sub cbForename_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbForename.CheckedChanged, cbSurname.CheckedChanged
        If ComboBox3.Text.Length > 0 Then
            ClearFields()
            btnUpdateDesc.Enabled = False
            getDescriptions()
        End If
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cbAutoUpdate.Checked = True
        Dim inx As Integer
        For inx = 0 To ComboBox3.Items.Count - 1
            ClearFields()
            ComboBox3.SelectedIndex = inx
        Next
    End Sub

    Private Sub ShowProgress(ByVal pText As String)
        Label1.Text = pText
        Me.Refresh()
    End Sub

End Class

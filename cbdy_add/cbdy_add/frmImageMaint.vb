Imports System.IO
Imports System.Net

Public Class frmImageMaint
    Dim bRecordExists As Boolean = False

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim oPersonTa As New CelebrityBirthdayDataSetTableAdapters.PersonTableAdapter
    '    Dim oPersonTable As New CelebrityBirthdayDataSet.PersonDataTable
    '    Dim oDatesTa As New CelebrityBirthdayDataSetTableAdapters.DatesTableAdapter
    '    Dim oDatesTable As New CelebrityBirthdayDataSet.DatesDataTable
    '    Dim oImageTa As New CelebrityBirthdayDataSetTableAdapters.ImageTableAdapter
    '    Dim oImageTable As New CelebrityBirthdayDataSet.ImageDataTable

    '    oPersonTa.Fill(oPersonTable)
    '    For Each pRow As CelebrityBirthdayDataSet.PersonRow In oPersonTable.Rows
    '        Dim id As Int16 = pRow.id
    '        Dim filename As String = pRow.imgfilename
    '        Dim filetype As String = pRow.imgfiletype

    '        Dim birthDay As Integer = pRow.birthday
    '        Dim birthMonth As Integer = pRow.birthmonth

    '        Dim loadMonth As String = ""
    '        Dim loadYear As String = ""

    '        Dim dCt As Integer = oDatesTa.FillByDate(oDatesTable, birthDay, birthMonth)
    '        If dCt = 1 Then
    '            Dim dRow As CelebrityBirthdayDataSet.DatesRow = oDatesTable.Rows(0)
    '            If dRow.IsuploadmonthNull = False Then
    '                loadMonth = dRow.uploadmonth

    '            End If
    '            If dRow.IsuploadyearNull = False Then
    '                loadYear = dRow.uploadyear
    '            End If
    '        End If

    '        oImageTa.InsertImage(id, filename, filetype, loadYear, loadMonth, "")

    '    Next
    '    oPersonTa = Nothing
    '    oPersonTable = Nothing
    '    oDatesTa = Nothing
    '    oDatesTable = Nothing
    '    oImageTa = Nothing
    '    oImageTable = Nothing

    'End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        bRecordExists = False
        Dim oPersonTa As New CelebrityBirthdayDataSetTableAdapters.PersonTableAdapter
        Dim oPersonTable As New CelebrityBirthdayDataSet.PersonDataTable
        Dim oImageTa As New CelebrityBirthdayDataSetTableAdapters.ImageTableAdapter
        Dim oImageTable As New CelebrityBirthdayDataSet.ImageDataTable
        txtImgName.Text = ""
        txtImgType.Text = ""
        txtLoadDay.Text = ""
        txtLoadMth.Text = ""
        txtLoadYr.Text = ""
        dgvPeople.Visible = False
        If txtId.TextLength > 0 Then
            txtForename.Text = ""
            txtSurname.Text = ""
            ' search by Id
            Try
                Dim iCt As Integer = oImageTa.FillById(oImageTable, CInt(txtId.Text))
                Dim pCt As Integer = oPersonTa.FillById(oPersonTable, CInt(txtId.Text))
                If pCt = 1 Then
                    Dim pRow As CelebrityBirthdayDataSet.PersonRow = oPersonTable.Rows(0)
                    txtForename.Text = pRow.forename
                    txtSurname.Text = pRow.surname
                End If
                If iCt = 1 Then
                    FillById(oImageTable)
                    bRecordExists = True
                Else
                    lblStatus.Text = "No image with this Id"
                    btnUpdate.Text = "Insert"
                    btnDelete.Visible = False
                End If
            Catch ex As Exception
                MsgBox("Image " & txtId.Text & " cannot be found", MsgBoxStyle.Exclamation, "Error")
            End Try
        Else
            ' Search by name
            Dim pCt As Integer = oPersonTa.FillByName(oPersonTable, txtForename.Text.Trim.ToLower & "%", txtSurname.Text.Trim.ToLower & "%")
            If pCt = 1 Then
                Dim pRow As CelebrityBirthdayDataSet.PersonRow = oPersonTable.Rows(0)
                txtForename.Text = pRow.forename
                txtSurname.Text = pRow.surname
                txtId.Text = pRow.id
                Dim iCt As Integer = oImageTa.FillById(oImageTable, CInt(txtId.Text))

                If iCt = 1 Then
                    FillById(oImageTable)
                    bRecordExists = True
                Else
                    lblStatus.Text = "No image with this Id"
                    btnUpdate.Text = "Insert"
                    btnDelete.Visible = False
                End If
            ElseIf pCt > 1 Then
                For Each pRow As CelebrityBirthdayDataSet.PersonRow In oPersonTable.Rows
                    Dim tCt As Integer = dgvPeople.Rows.Add
                    Dim tRow As DataGridViewRow = dgvPeople.Rows(tCt)
                    tRow.Cells("Id").Value = pRow.id
                    tRow.Cells("PersonName").Value = pRow.forename & " " & pRow.surname
                    tRow.Cells("Year").Value = pRow.birthyear
                Next
                dgvPeople.Visible = True
            End If
        End If

        oImageTa = Nothing
        oImageTable = Nothing
        oPersonTa = Nothing
        oPersonTable = Nothing

    End Sub

    Private Sub FillById(ByRef oImageTable As CelebrityBirthdayDataSet.ImageDataTable)

        Dim iRow As CelebrityBirthdayDataSet.ImageRow = oImageTable.Rows(0)
        txtImgName.Text = iRow.imgfilename
        If iRow.IsimgfiletypeNull = False Then
            txtImgType.Text = iRow.imgfiletype

        End If
        If iRow.IsimgloadmonthNull = False Then
            txtLoadMth.Text = iRow.imgloadmonth
        End If
        If iRow.IsimgloadyrNull = False Then
            txtLoadYr.Text = iRow.imgloadyr
        End If
        If iRow.IsimgloaddayNull = False Then
            txtLoadDay.Text = iRow.imgloadday
        End If

        PictureBox1.ImageLocation = ""
        PictureBox2.ImageLocation = ""
        Dim fName1 As String = Path.Combine(My.Settings.ImgFolder, txtImgName.Text & txtImgType.Text)

        If My.Computer.FileSystem.FileExists(fName1) Then
            PictureBox2.ImageLocation = fName1
        End If
        PictureBox1.ImageLocation = "http://celebritybirthday.files.wordpress.com/" & txtLoadYr.Text & "/" & txtLoadMth.Text & "/" & txtImgName.Text & txtImgType.Text

        lblFilename.Text = fName1
        lblWordPress.Text = PictureBox1.ImageLocation

        btnUpdate.Text = "Update"
        btnDelete.Visible = True
    End Sub

    Private Sub btnGetImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetImages.Click
        PictureBox1.ImageLocation = ""
        PictureBox2.ImageLocation = ""
        Dim fName1 As String = Path.Combine(My.Settings.ImgFolder, txtImgName.Text & txtImgType.Text)

        If My.Computer.FileSystem.FileExists(fName1) Then
            PictureBox2.ImageLocation = fName1
        End If
        PictureBox1.ImageLocation = "http://celebritybirthday.files.wordpress.com/" & txtLoadYr.Text & "/" & txtLoadMth.Text & "/" & txtImgName.Text & txtImgType.Text

        lblFilename.Text = fName1
        lblWordPress.Text = PictureBox1.ImageLocation

    End Sub

    Private Sub frmImageMaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvPeople.Visible = False
        btnDelete.Visible = False
    End Sub

    Private Sub dgvPeople_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPeople.SelectionChanged
        If dgvPeople.SelectedRows.Count = 1 Then
            Dim tRow As DataGridViewRow = dgvPeople.SelectedRows(0)
            txtId.Text = tRow.Cells("Id").Value

        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtImgName.Text = ""
        txtImgType.Text = ""
        txtLoadMth.Text = ""
        txtLoadYr.Text = ""
        dgvPeople.Visible = False
        PictureBox1.ImageLocation = ""
        PictureBox2.ImageLocation = ""
        lblFilename.Text = ""
        lblWordPress.Text = ""
        txtId.Text = ""
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MsgBox("Removing " & txtId.Text & ": " & txtForename.Text.Trim & " " & txtSurname.Text, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
            Try
                Dim oImageTa As New CelebrityBirthdayDataSetTableAdapters.ImageTableAdapter
                oImageTa.DeleteImage(CInt(txtId.Text.Trim))
                oImageTa = Nothing
            Catch ex As Exception
                lblStatus.Text = "Error: failed to delete " & txtId.Text
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            Dim oImageTa As New CelebrityBirthdayDataSetTableAdapters.ImageTableAdapter
            If bRecordExists Then
                oImageTa.UpdateImage(txtImgName.Text, txtImgType.Text, txtLoadYr.Text, txtLoadMth.Text, txtLoadDay.Text, CInt(txtId.Text.Trim))
            Else
                oImageTa.InsertImage(CInt(txtId.Text.Trim), txtImgName.Text, txtImgType.Text, txtLoadYr.Text, txtLoadMth.Text, txtLoadDay.Text)
            End If
            oImageTa = Nothing
        Catch ex As Exception
            lblStatus.Text = "Error: failed to " & btnUpdate.Text & " " & txtId.Text
        End Try
    End Sub

    Private Sub btnPicSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPicSave.Click
        Dim filename As String = Path.Combine(My.Settings.ImgFolder, txtImgName.Text & txtImgType.Text)
        Dim url As String = "http://celebritybirthday.files.wordpress.com/" & txtLoadYr.Text & "/" & txtLoadMth.Text & "/" & txtImgName.Text & txtImgType.Text

        SaveImage(url, filename)

    End Sub
    Private Function SaveImage(ByVal url As String, ByVal strFName As String) As Boolean
        Dim rtnval As Boolean = True
        Dim b() As Byte '   Store picture bytes
        lblStatus.Text = "Saving picture"
        ' Create a request for the URL. 
        Dim request As WebRequest = WebRequest.Create(url)
        ' If required by the server, set the credentials.
        request.Credentials = CredentialCache.DefaultCredentials
        ' Get the response.
        Dim response As WebResponse = Nothing
        Try
            response = request.GetResponse()

            ' Display the status.
            lblStatus.Text = CType(response, HttpWebResponse).StatusDescription
            Me.Refresh()
            ' Get the stream containing content returned by the server.
            Dim dataStream As Stream = response.GetResponseStream()

            ' Read the content.
            Dim buffer(4096) As Byte
            Dim memorystream As New MemoryStream
            Dim bct As Integer = -1
            lblStatus.Text = "Writing memory stream"
            Me.Refresh()
            Do While (bct <> 0)
                bct = dataStream.Read(buffer, 0, buffer.Length)
                memorystream.Write(buffer, 0, bct)
            Loop

            b = memorystream.ToArray()
            lblStatus.Text = "Writing file"
            Me.Refresh()
            If b.Length > 0 Then
                Dim bw As BinaryWriter = Nothing
                Try
                    bw = New BinaryWriter(File.Open(strFName, FileMode.Create))
                    bw.Write(b)
                Catch ex As Exception
                    MsgBox("Error writing file")
                    rtnval = False
                Finally
                    If bw IsNot Nothing Then
                        bw.Close()
                    End If
                    bw = Nothing
                End Try
            End If
            ' Clean up the streams and the response.
            memorystream.Close()
            response.Close()

            memorystream.Dispose()

            response = Nothing
            lblStatus.Text = "Picture saved"
        Catch ex As Exception
            lblStatus.Text = ex.Message
            rtnval = False
        End Try
        Return rtnval
    End Function

End Class
Imports System.Text
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Configuration

Public Class frmMain
    Dim aTagStart As String = "<a href=""http://celebritybirthday.files.wordpress.com/"
    Dim aTagEnd As String = """>"
    Dim imgTagStart As String = "<img title="""
    Dim imgTagMiddle As String = """ src=""http://celebritybirthday.files.wordpress.com/"
    Dim imgTagEnd As String = """ alt="""" width=""60"" height=""60"" />"
    Dim strongTagStart As String = "</a> <strong>"
    Dim strongTagEnd As String = "</strong>"
    Dim excerptStart As String = "Today's Birthdays:<br />"
    Dim excerptDiv As String = "<div style=""width:200px;float:left;font-family:arial;font-size:12px;"">"
    Dim excerptDivEnd As String = "</div>"
    Dim urlYear As String = "2013"
    Dim urlMonth As String = "03"
    Dim galleryText As String = ""
    Dim personTable As ArrayList
    Dim mDialog1 As frmSearchDb = Nothing
    Dim oWebBrowser As frmWebImageSearch = Nothing
    Dim bLoadingPerson As Boolean = False
    Dim _search As frmSearchDb
    Dim MouseIsDown As Boolean = False

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim resp As MsgBoxResult = MsgBoxResult.No
        If checkForChanges() Then
            resp = MsgBox("Save changes now?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel, "Unsaved Changes")
        End If
        Select Case resp
            Case MsgBoxResult.Yes
                btnUpdateAll_Click(sender, e)
                Me.Close()
            Case MsgBoxResult.No
                Me.Close()
            Case MsgBoxResult.Cancel
            Case Else
        End Select
    End Sub

    Private Sub getUrlDate(ByRef Id As Integer)

        If txtCurrentText.TextLength > 0 Then
            Dim currParts1 As String() = Split(txtCurrentText.Text, "<h3>")
            If currParts1.Length > 1 Then
                Dim entry1 As String = currParts1(1)
                Dim url1 As String() = Split(entry1, ".com")
                Dim entry11 As String = url1(1)
                Dim url11 As String() = Split(entry11, ".")
                Dim date1 As String() = Split(url11(0), "/")
                urlYear = date1(1)
                urlMonth = date1(2)
            End If
        Else

            urlYear = txtLoadYr.Text
            urlMonth = txtLoadMth.Text

            getAlternateImageDate(urlYear, urlMonth, Id)
        End If

    End Sub

    Private Sub TextBox_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtCurrentExcerpt.DragDrop, _
                                                                                                                           txtCurrentText.DragDrop, _
                                                                                                                           txtDesc.DragDrop, _
                                                                                                                           txtDied.DragDrop, _
                                                                                                                           txtName.DragDrop, _
                                                                                                                           txtYear.DragDrop, _
                                                                                                                           txtForename.DragDrop, _
                                                                                                                           txtSurname.DragDrop, _
                                                                                                                           txtBirthName.DragDrop, _
                                                                                                                           txtBirthPlace.DragDrop
        If e.Data.GetDataPresent(DataFormats.StringFormat) Then
            Dim oBox As TextBox = CType(sender, TextBox)
            Dim item As String = e.Data.GetData(DataFormats.StringFormat)
            oBox.SelectedText = item

        End If
        getGalleryText()
    End Sub

    Private Sub TextBox_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtCurrentExcerpt.DragOver, _
                                                                                                                           txtCurrentText.DragOver, _
                                                                                                                           txtDesc.DragOver, _
                                                                                                                           txtDied.DragOver, _
                                                                                                                           txtName.DragOver, _
                                                                                                                           txtYear.DragOver, _
                                                                                                                           txtForename.DragOver, _
                                                                                                                           txtSurname.DragOver, _
                                                                                                                           txtBirthName.DragOver, _
                                                                                                                           txtBirthPlace.DragOver
        If e.Data.GetDataPresent(DataFormats.StringFormat) Then
            Dim oBox As TextBox = CType(sender, TextBox)
            oBox.Select(TextBoxCursorPos(oBox, e.X, e.Y), 0)
        End If
    End Sub

    Private Sub TextBox_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtCurrentExcerpt.DragEnter, _
                                                                                                                           txtCurrentText.DragEnter, _
                                                                                                                           txtDesc.DragEnter, _
                                                                                                                           txtDied.DragEnter, _
                                                                                                                           txtName.DragEnter, _
                                                                                                                           txtYear.DragEnter, _
                                                                                                                           txtForename.DragEnter, _
                                                                                                                           txtSurname.DragEnter, _
                                                                                                                           txtBirthName.DragEnter, _
                                                                                                                           txtBirthPlace.DragEnter
        If e.Data.GetDataPresent(DataFormats.StringFormat) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub btnCopyFull_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyFull.Click
        My.Computer.Clipboard.SetText(txtCurrentText.Text)

    End Sub

    Private Sub btnCopyExcerpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyExcerpt.Click
        My.Computer.Clipboard.SetText(txtCurrentExcerpt.Text)

    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        personTable = New ArrayList
        If txtCurrentText.TextLength = 0 Or cboDay.SelectedIndex < 0 Or cboMonth.SelectedIndex < 0 Then
        Else
            getGalleryText()
            Dim sText As String = txtCurrentText.Text.Trim.Replace(vbCr, "").Replace(vbLf, "")
            Dim currParts As String() = Split(sText, "<h3>")
            For Each currPart As String In currParts
                Dim entries As String() = Split(currPart, "<img")

                Dim sYr As String = entries(0).Split("<")(0)
                If sYr.ToLower.Contains("bc") Then
                    sYr = "-" & sYr.ToLower.Replace("bc", "").Trim
                End If

                For en As Integer = 1 To entries.Length - 1
                    Dim entry As String = entries(en)
                    entry = entry.Replace("<strong>", "|").Replace("</strong>", "|")
                    Dim lines As String() = Split(entry, "|")
                    Dim imgTag As String = lines(0).Trim
                    Dim imgTagParts As String() = Split(imgTag, "/")
                    Dim sImg As String = imgTagParts(imgTagParts.Count - 3)
                    sImg = sImg.Split("?")(0)
                    sImg = sImg.Split("""")(0)
                    Dim sImgType As String = Path.GetExtension(sImg)
                    Dim simgName As String = Path.GetFileNameWithoutExtension(sImg)
                    Dim sName As String = lines(1).Trim
                    Dim sDesc As String = RemoveTags(lines(2).Trim)
                    Dim sDdStart As Int16 = sDesc.IndexOf("(d.")

                    Dim sDd As String = ""
                    If sDdStart >= 0 Then
                        sDd = Split(Split(sDesc, "(d.")(1), ")")(0).Trim
                    End If
                    sDesc = Split(sDesc, "(d.")(0).Trim

                    Dim sForename As String = ""
                    Dim sSurname As String = ""
                    splitname(sName, sForename, sSurname)
                    Dim sDeathYear As Integer
                    Try
                        sDeathYear = Integer.Parse(sDd)
                    Catch ex As Exception
                        sDeathYear = 0
                    End Try
                    Dim sShortDesc As String = Split(sDesc, ".")(0) & "."
                    Dim oPerson As Person = New Person(sForename, sSurname, sDesc, sShortDesc, cboDay.SelectedIndex + 1, cboMonth.SelectedIndex + 1, sYr, sDeathYear, 0, 0, "", "", simgName, sImgType)

                    personTable.Add(oPerson)
                Next
            Next
        End If
        DisplayPersonlList()
        btnLoad.Font = New Font(btnLoad.Font, FontStyle.Regular)

    End Sub
    Private Sub splitname(ByVal sName As String, ByRef sForename As String, ByRef sSurname As String)
        Dim sWords As String() = Split(sName, " ")
        If sWords.Length > 0 Then
            If sWords.Length = 1 Then
                sSurname = sWords(0)
                sForename = ""
            Else
                sSurname = sWords(sWords.Length - 1)
                ReDim Preserve sWords(sWords.Length - 2)
                sForename = Join(sWords, " ")
            End If
        End If
    End Sub
    Private Sub getGalleryText()
        Dim sText As String = txtCurrentText.Text.Trim
        Dim currParts As String() = Split(sText, "<h3>")
        If currParts(0).StartsWith("[gallery") Then
            galleryText = currParts(0)
        End If
    End Sub
    Private Sub btnClrExcerpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClrExcerpt.Click
        txtCurrentExcerpt.Text = ""
    End Sub

    Private Sub btnClrCurr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClrCurr.Click
        txtCurrentText.Text = ""
    End Sub

    Private Sub btnClrNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClrNew.Click
        ClearDetails()
    End Sub
    Private Sub ClearDetails()
        lblID.Text = ""
        txtDesc.Text = ""
        txtShortDesc.Text = ""
        txtDied.Text = ""
        txtName.Text = ""
        txtForename.Text = ""
        txtSurname.Text = ""
        txtYear.Text = ""
        txtImgName.Text = ""
        cbImgType.SelectedIndex = 0
        PictureBox1.ImageLocation = ""
        PictureBox2.ImageLocation = ""
        txtBirthName.Text = ""
        txtBirthPlace.Text = ""
        txtDthDay.Text = ""
        txtDthMth.Text = ""
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        tidyText()
        If cboDay.SelectedIndex >= 0 And cboMonth.SelectedIndex >= 0 Then
            Try
                Dim newPerson As New Person(txtForename.Text.Trim, _
                                            txtSurname.Text.Trim, _
                                            txtDesc.Text.Trim, _
                                            txtShortDesc.Text.Trim, _
                                            cboDay.SelectedIndex + 1, _
                                            cboMonth.SelectedIndex + 1, _
                                            txtYear.Text.Trim, _
                                            CInt("0" & txtDied.Text.Trim), _
                                            CInt("0" & txtDthMth.Text.Trim), _
                                            CInt("0" & txtDthDay.Text.Trim), _
                                            txtBirthName.Text.Trim, _
                                            txtBirthPlace.Text.Trim, _
                                            txtImgName.Text, cbImgType.Text)
                newPerson.unsavedChanges = True
                Dim bInserted As Boolean = False
                For ix As Integer = 0 To personTable.Count - 1
                    Dim aPerson As Person = personTable(ix)
                    If aPerson.BirthYear > newPerson.BirthYear Then
                        personTable.Insert(ix, newPerson)
                        bInserted = True
                        Exit For
                    End If
                Next
                Dim p As Integer = -1
                If Not bInserted Then
                    p = personTable.Add(newPerson)
                End If
                DisplayPersonlList()
                lbPeople.SelectedIndex = p
            Catch ex As Exception
                MsgBox("Error on insert", MsgBoxStyle.Exclamation, "Insert error")
                lblStatus.Text = ex.Message
            End Try

        Else
            MsgBox("No date selected", MsgBoxStyle.Exclamation, "Insert error")
        End If
    End Sub
    Private Sub DisplayPersonlList()
        lbPeople.Items.Clear()
        For Each oPerson As Person In personTable
            lbPeople.Items.Add(oPerson.BirthYear & " " & oPerson.Name)
        Next
    End Sub

    Private Sub txtCurrentText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurrentText.TextChanged
        btnLoad.Font = New Font(btnLoad.Font, FontStyle.Bold)
        galleryText = ""
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim oPerson As Person = Nothing
        If lbPeople.SelectedIndex >= 0 Then
            oPerson = personTable(lbPeople.SelectedIndex)
            If oPerson.Id > 0 Then
                Dim oTa As New CelebrityBirthdayDataSetTableAdapters.PersonTableAdapter
                Dim oTable As New CelebrityBirthdayDataSet.PersonDataTable
                Dim iCt As Integer = oTa.DeletePerson(oPerson.Id)
                oTable.Dispose()
                oTa.Dispose()
                oTable = Nothing
                oTa = Nothing
            End If

            personTable.RemoveAt(lbPeople.SelectedIndex)
        End If
        DisplayPersonlList()
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Dim ix As Integer = -1
        If lbPeople.SelectedIndex > 0 Then
            ix = lbPeople.SelectedIndex
            Dim prevPerson As New Person(personTable(ix - 1))
            Dim thisperson As New Person(personTable(ix))
            Dim isseq As Integer = prevPerson.Sortseq
            If prevPerson.iBirthYear >= thisperson.iBirthYear Then
                prevPerson.Sortseq = thisperson.Sortseq
                thisperson.Sortseq = isseq
                prevPerson.unsavedChanges = True
                thisperson.unsavedChanges = True
                personTable(ix - 1) = thisperson
                personTable(ix) = prevPerson
                DisplayPersonlList()
                lbPeople.SelectedIndex = ix - 1
            End If

        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim ix As Integer = -1
        If lbPeople.SelectedIndex >= 0 And lbPeople.SelectedIndex < lbPeople.Items.Count - 1 Then
            ix = lbPeople.SelectedIndex
            Dim nextPerson As New Person(personTable(ix + 1))
            Dim thisperson As New Person(personTable(ix))
            Dim isseq As Integer = nextPerson.Sortseq
            If nextPerson.iBirthYear <= thisperson.iBirthYear Then
                nextPerson.Sortseq = thisperson.Sortseq
                thisperson.Sortseq = isseq
                nextPerson.unsavedChanges = True
                thisperson.unsavedChanges = True
                personTable(ix + 1) = thisperson
                personTable(ix) = nextPerson
                DisplayPersonlList()
                lbPeople.SelectedIndex = ix + 1
            End If

        End If
    End Sub

    Private Sub btnGenFullText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenFullText.Click
        Dim bOK As Boolean = True
        'If galleryText.Length = 0 Then
        '    If MsgBox("No gallery text available." & vbCrLf & "OK to continue?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Generator Error") = MsgBoxResult.Yes Then
        '        galleryText = "[gallery columns=""6"" size=""thumbnails"" ids=""""]" & vbCrLf & "<!--more-->" & vbCrLf
        '    Else
        '        bOK = False
        '    End If

        'End If
        If lbPeople.Items.Count = 0 Then
            bOK = False
        End If
        If bOK Then


            Dim lastYear As String = ""
            Dim newText As New StringBuilder(galleryText)
            For Each oPerson As Person In personTable
                getUrlDate(oPerson.Id)
                If oPerson.BirthYear <> lastYear Then
                    newText.Append("<h3>").Append(oPerson.BirthYear).Append("</h3>").Append(vbCrLf)
                    lastYear = oPerson.BirthYear
                End If
                Dim lowername As String = oPerson.ImageName
                If lowername.Length = 0 Then
                    lowername = oPerson.Name.ToLower.Replace(" ", "-").Replace(".", "")
                End If
                Dim sBorn As String = ""
                If oPerson.BirthName.Length > 0 Or oPerson.BirthPlace.Length > 0 Then
                    sBorn = " Born" & If(oPerson.BirthName.Length > 0, " " & oPerson.BirthName, "") & If(oPerson.BirthPlace.Length > 0, " in " & oPerson.BirthPlace, "") & "."
                End If
                Dim sDied As String = " (d. " & CStr(oPerson.DeathYear) & ")"
                With newText
                    .Append(aTagStart)
                    .Append(urlYear)
                    .Append("/")
                    .Append(urlMonth)
                    .Append("/")
                    .Append(lowername)
                    .Append(oPerson.ImageType)
                    .Append(aTagEnd)
                    .Append(imgTagStart)
                    .Append(oPerson.Name)
                    .Append(imgTagMiddle)
                    .Append(urlYear)
                    .Append("/")
                    .Append(urlMonth)
                    .Append("/")
                    .Append(lowername)
                    .Append(oPerson.ImageType)
                    .Append(imgTagEnd)
                    .Append(strongTagStart)
                    .Append(oPerson.Name)
                    .Append(strongTagEnd)
                    .Append(vbCrLf)
                    .Append(oPerson.Description)
                    .Append(sborn)
                    .Append(If(oPerson.DeathYear = 0, "", sDied))
                    .Append(vbCrLf)
                End With
            Next
            txtCurrentText.Text = newText.ToString
            getGalleryText()
        End If
    End Sub

    Private Sub btnGenExcerpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenExcerpt.Click
        Dim bOK As Boolean = True
        Dim listRem As Integer
        Dim listSize As Integer
        Dim pList As ArrayList = personTable.Clone
        If lbPeople.Items.Count = 0 Then
            bOK = False
        Else
            listRem = lbPeople.Items.Count Mod 3
            listSize = Int(lbPeople.Items.Count / 3)
            If listRem > 0 Then
                If listRem = 1 Then
                    pList.Insert((listSize * 2) + 1, New Person)
                End If
                pList.Add(New Person)
                listSize += 1
            End If
        End If
        If bOK Then
            Dim newText As New StringBuilder(excerptStart)
            newText.Append(vbCrLf)
            Dim iCt As Integer = 0
            For Each oPerson As Person In pList
                If iCt = 0 Then
                    newText.Append(excerptDiv).Append(vbCrLf)
                End If
                With newText
                    .Append(oPerson.Name)
                    .Append("<br />")
                    .Append(vbCrLf)
                End With
                iCt += 1
                If iCt = listSize Then
                    newText.Append(excerptDivEnd).Append(vbCrLf)
                    iCt = 0
                End If
            Next
            txtCurrentExcerpt.Text = newText.ToString
        End If
    End Sub
    Private Function MakeImageName(ByVal sName As String) As String
        Dim sImgName As String = ToSimpleCharacters(sName.Trim).Replace(" ", "-").Replace("'", "").Replace(".", "-")
        Return sImgName.Replace("--", "-").ToLower
    End Function
    Public Sub btnMakeImgName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeImgName.Click
        txtImgName.Text = MakeImageName(txtName.Text)

    End Sub



    Private Sub btnUpdateAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateAll.Click
        lblStatus.Text = "Updating Database"
        Me.Refresh()
        Dim oTa As New CelebrityBirthdayDataSetTableAdapters.PersonTableAdapter
        Dim oTable As New CelebrityBirthdayDataSet.PersonDataTable
        Dim lastYear As String = ""
        Dim iSeq As Integer = 0
        For Each oPerson As Person In personTable
            If oPerson.BirthYear = lastYear Then
                iSeq += 1
            Else
                iSeq = 0
                lastYear = oPerson.BirthYear
            End If
            If oPerson.Id < 0 Then
                Dim newId As Integer = oTa.InsertPerson(oPerson.ForeName, oPerson.Surname, CInt(oPerson.BirthYear), oPerson.BirthMonth, oPerson.BirthDay, oPerson.DeathYear, _
                oPerson.ShortDesc, oPerson.Description, iSeq, Today.Date, oPerson.BirthPlace, oPerson.BirthName, oPerson.DeathMonth, oPerson.DeathDay, oPerson.ImageName, oPerson.ImageType)
                oPerson.Id = newId
            Else
                oTa.UpdatePerson(oPerson.ForeName, oPerson.Surname, CInt(oPerson.BirthYear), oPerson.BirthMonth, oPerson.BirthDay, oPerson.DeathYear, _
                 oPerson.ShortDesc, oPerson.Description, iSeq, oPerson.BirthPlace, oPerson.BirthName, oPerson.DeathMonth, oPerson.DeathDay, oPerson.ImageName, oPerson.ImageType, oPerson.Id)
            End If
            oPerson.unsavedChanges = False
        Next
        If cbDateAmend.Checked Then
            updateDate()
        End If
        oTable.Dispose()
        oTa.Dispose()
        oTable = Nothing
        oTa = Nothing
        lblStatus.Text += " - Complete"

    End Sub

    Private Sub btnLoadTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadTable.Click, cboDay.SelectedIndexChanged, cboMonth.SelectedIndexChanged
        lblStatus.Text = ""
        Dim resp As MsgBoxResult = MsgBoxResult.No
        If checkForChanges() Then
            If MsgBox("Save unsaved changes now?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Unsaved Changes") = MsgBoxResult.Yes Then
                btnUpdateAll_Click(sender, e)
            End If
        End If

        If cboDay.SelectedIndex >= 0 And cboMonth.SelectedIndex >= 0 Then
            lblStatus.Text = "Loading Table From Database"
            Me.Refresh()
            personTable = New ArrayList
            lbPeople.Items.Clear()
            Dim sYear As String = ""
            Dim sMonth As String = ""
            Dim sDay As String = ""

            Dim oDta As New CelebrityBirthdayDataSetTableAdapters.DatesTableAdapter
            Dim oDtable As New CelebrityBirthdayDataSet.DatesDataTable
            Dim iCt As Integer = oDta.FillByDate(oDtable, cboDay.SelectedIndex + 1, cboMonth.SelectedIndex + 1)
            Dim bAmended As Boolean = False
            If iCt = 1 Then
                Dim oDrow As CelebrityBirthdayDataSet.DatesRow = oDtable.Rows(0)
                If oDrow.IsuploadyearNull = False Then
                    sYear = oDrow.uploadyear
                End If
                If oDrow.IsuploadmonthNull = False Then
                    sMonth = oDrow.uploadmonth
                End If
                If oDrow.IsuploaddayNull = False Then
                    sDay = oDrow.uploadday
                End If
                bAmended = oDrow.amended
            End If
            oDta.Dispose()
            oDtable.Dispose()
            oDta = Nothing
            oDtable = Nothing
            txtLoadMth.Text = sMonth
            txtLoadYr.Text = sYear
            txtLoadDay.Text = sDay
            cbDateAmend.Checked = bAmended
            Dim oTa As New CelebrityBirthdayDataSetTableAdapters.PersonTableAdapter
            Dim oTable As New CelebrityBirthdayDataSet.PersonDataTable
            oTa.FillByMonthDay(oTable, cboMonth.SelectedIndex + 1, cboDay.SelectedIndex + 1)
            For Each oRow As CelebrityBirthdayDataSet.PersonRow In oTable.Rows
                Dim oPerson As Person = MakePerson(oRow)
                personTable.Add(oPerson)
                lbPeople.Items.Add(oPerson.BirthYear & " " & oPerson.ForeName & " " & oPerson.Surname)
            Next
            oTable.Dispose()
            oTa.Dispose()
            oTable = Nothing
            oTa = Nothing
            lblStatus.Text += " - Complete"
        End If
    End Sub

    Private Sub btnReloadSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReloadSel.Click
        lblStatus.Text = "Loading Item From Database"
        Me.Refresh()
        If lbPeople.SelectedIndex >= 0 And lbPeople.SelectedIndex < lbPeople.Items.Count Then
            If personTable(lbPeople.SelectedIndex) IsNot Nothing Then
                Dim oPerson As Person = personTable(lbPeople.SelectedIndex)
                If oPerson.Id > 0 Then
                    Dim oTa As New CelebrityBirthdayDataSetTableAdapters.PersonTableAdapter
                    Dim oTable As New CelebrityBirthdayDataSet.PersonDataTable
                    Dim iCt As Integer = oTa.FillById(oTable, oPerson.Id)
                    If iCt = 1 Then
                        Dim newPerson As Person = MakePerson(oTable.Rows(0))
                        personTable(lbPeople.SelectedIndex) = newPerson
                        lbPeople.Items(lbPeople.SelectedIndex) = newPerson.BirthYear & " " & newPerson.ForeName & " " & newPerson.Surname
                    End If
                    oTable.Dispose()
                    oTa.Dispose()
                    oTable = Nothing
                    oTa = Nothing
                End If
            End If
        End If
        lblStatus.Text += " - Complete"
    End Sub

    Private Function MakePerson(ByRef oRow As CelebrityBirthdayDataSet.PersonRow) As Person
        Dim oPerson As New Person
        oPerson.Id = oRow.id
        oPerson.ForeName = oRow.forename
        oPerson.Surname = oRow.surname
        oPerson.Description = oRow.longdesc
        oPerson.ShortDesc = oRow.shortdesc
        oPerson.BirthDay = oRow.birthday
        oPerson.BirthMonth = oRow.birthmonth
        oPerson.BirthYear = oRow.birthyear
        oPerson.DeathYear = oRow.deathyear
        oPerson.DeathMonth = oRow.deathmonth
        oPerson.DeathDay = oRow.deathday
        oPerson.BirthPlace = oRow.birthplace
        oPerson.BirthName = oRow.birthname
        If Not oRow.IsimgfilenameNull Then
            oPerson.ImageName = oRow.imgfilename
        End If
        If Not oRow.IsimgfiletypeNull Then
            oPerson.ImageType = oRow.imgfiletype
        End If
        oPerson.Sortseq = oRow.sortseq
        Return oPerson
    End Function

    Private Sub lbPeople_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbPeople.SelectedIndexChanged
        lblStatus.Text = ""
        bLoadingPerson = True
        If lbPeople.SelectedIndex >= 0 Then
            Dim oPerson As Person = personTable(lbPeople.SelectedIndex)
            lblID.Text = oPerson.Id
            txtForename.Text = oPerson.ForeName
            txtSurname.Text = oPerson.Surname
            txtDesc.Text = oPerson.Description
            txtShortDesc.Text = oPerson.ShortDesc
            txtYear.Text = CStr(oPerson.BirthYear)
            txtDied.Text = CStr(oPerson.DeathYear)
            txtDthDay.Text = oPerson.DeathDay
            txtDthMth.Text = oPerson.DeathMonth
            txtImgName.Text = oPerson.ImageName
            cbImgType.SelectedIndex = cbImgType.FindString(oPerson.ImageType)
            txtBirthName.Text = oPerson.BirthName
            txtBirthPlace.Text = oPerson.BirthPlace

            txtName.Text = Trim(oPerson.ForeName & " " & oPerson.Surname)
            Dim sYear As String = txtLoadYr.Text
            Dim sMth As String = txtLoadMth.Text
            getAlternateImageDate(sYear, sMth, oPerson.Id)
            Try
                Dim sSimplename As String = ToSimpleCharacters(Trim(oPerson.ForeName & " " & oPerson.Surname))
                Dim fName1 As String = Path.Combine(My.Settings.ImgFolder, sSimplename & oPerson.ImageType)
                Dim fName2 As String = Path.Combine(My.Settings.ImgFolder, oPerson.ImageName.Trim & oPerson.ImageType)
                PictureBox1.ImageLocation = ""
                PictureBox2.ImageLocation = ""
                If fName1.ToLower <> fName2.ToLower Then
                    If My.Computer.FileSystem.FileExists(fName1) Then
                        If My.Computer.FileSystem.FileExists(fName2) = False Then
                            lblStatus.Text = "Renaming image file"
                            My.Computer.FileSystem.RenameFile(fName1, oPerson.ImageName & oPerson.ImageType)
                        Else
                            lblStatus.Text = "Deleting image file"
                            My.Computer.FileSystem.DeleteFile(fName1)
                        End If
                    End If
                End If
                PictureBox1.ImageLocation = "http://celebritybirthday.files.wordpress.com/" & sYear & "/" & sMth & "/" & oPerson.ImageName & oPerson.ImageType
                If Not My.Computer.FileSystem.FileExists(fName2) Then
                    SavePic()
                End If
                PictureBox2.ImageLocation = fName2
            Catch ex As Exception
                lblStatus.Text = ex.Message
            End Try
        Else
            ClearDetails()
        End If
        bLoadingPerson = False
    End Sub

    Private Sub getAlternateImageDate(ByRef sYear As String, ByRef sMonth As String, ByVal Id As Integer)

        Dim oIta As New CelebrityBirthdayDataSetTableAdapters.ImageTableAdapter
        Dim oITable As New CelebrityBirthdayDataSet.ImageDataTable

        Dim ict As Integer = oIta.FillById(oITable, Id)
        If ict = 1 Then
            Dim oIRow As CelebrityBirthdayDataSet.ImageRow = oITable.Rows(0)

            If oIRow.IsimgloadyrNull = False Then
                sYear = oIRow.imgloadyr
            End If
            If oIRow.IsimgloadmonthNull = False Then
                sMonth = oIRow.imgloadmonth
            End If

        End If

        oITable.Dispose()
        oIta.Dispose()
    End Sub

    Private Sub btnUpdateSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateSel.Click
        lblStatus.Text = ""
        If lbPeople.SelectedIndex >= 0 Then
            lblStatus.Text = "Updating Database"
            Me.Refresh()
            Dim oTa As New CelebrityBirthdayDataSetTableAdapters.PersonTableAdapter
            Dim oTable As New CelebrityBirthdayDataSet.PersonDataTable
            Dim iSeq As Integer = 0
            Dim oPerson As Person = personTable(lbPeople.SelectedIndex)
            If oPerson.Id < 0 Then
                Dim newId As Integer = oTa.InsertPerson(oPerson.ForeName, oPerson.Surname, CInt(oPerson.BirthYear), oPerson.BirthMonth, oPerson.BirthDay, oPerson.DeathYear, _
                oPerson.ShortDesc, oPerson.Description, iSeq, Today.Date, oPerson.BirthPlace, oPerson.BirthName, oPerson.DeathMonth, oPerson.DeathDay, oPerson.ImageName, oPerson.ImageType)
                oPerson.Id = newId
            Else
                oTa.UpdatePerson(oPerson.ForeName, oPerson.Surname, CInt(oPerson.BirthYear), oPerson.BirthMonth, oPerson.BirthDay, oPerson.DeathYear, _
                 oPerson.ShortDesc, oPerson.Description, iSeq, oPerson.BirthPlace, oPerson.BirthName, oPerson.DeathMonth, oPerson.DeathDay, oPerson.ImageName, oPerson.ImageType, oPerson.Id)
            End If
            If cbDateAmend.Checked Then
                updateDate()
            End If
            oPerson.unsavedChanges = False
            oTable.Dispose()
            oTa.Dispose()
            oTable = Nothing
            oTa = Nothing
            lblStatus.Text += " - Complete"
        End If
    End Sub

    Public Function RemoveTags(ByVal sText As String) As String
        Dim outText As New StringBuilder
        Dim inTag As Boolean = False
        For Each c As Char In sText
            If c = "<" Then inTag = True
            If Not inTag Then
                outText.Append(c)
            End If
            If c = ">" Then inTag = False
        Next

        Return outText.ToString

    End Function

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        lblStatus.Text = ""
        tidyText()
        If lblID.Text.Length > 0 Then
            Dim id As Integer = CInt(lblID.Text)
            For Each oPerson As Person In personTable
                If oPerson.Id = id Then
                    oPerson.BirthYear = txtYear.Text
                    oPerson.DeathYear = CInt("0" & txtDied.Text)
                    oPerson.Description = txtDesc.Text.Trim
                    oPerson.ForeName = txtForename.Text.Trim
                    oPerson.ImageName = txtImgName.Text.Trim
                    oPerson.ImageType = cbImgType.Text
                    oPerson.Surname = txtSurname.Text.Trim
                    oPerson.ShortDesc = txtShortDesc.Text.Trim
                    oPerson.DeathDay = CInt("0" & txtDthDay.Text.Trim)
                    oPerson.DeathMonth = CInt("0" & txtDthMth.Text.Trim)
                    oPerson.BirthPlace = txtBirthPlace.Text.Trim
                    oPerson.BirthName = txtBirthName.Text.Trim
                    oPerson.unsavedChanges = True
                    Dim p As Integer = lbPeople.SelectedIndex
                    DisplayPersonlList()
                    lbPeople.SelectedIndex = p
                    lblStatus.Text = "Updated list"

                    Exit For
                End If
            Next

        End If
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

    Private Sub btnPicSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPicSave.Click
        SavePic()
    End Sub

    Private Sub SavePic()
        If lbPeople.SelectedIndex >= 0 Then
            Dim oPerson As Person = personTable(lbPeople.SelectedIndex)
            Dim sYear As String = txtLoadYr.Text
            Dim sMth As String = txtLoadMth.Text
            Dim url As String = "http://celebritybirthday.files.wordpress.com/" & sYear & "/" & sMth & "/" & oPerson.ImageName & oPerson.ImageType
            Try
                Dim sFname As String = Path.Combine(My.Settings.ImgFolder, oPerson.ImageName & oPerson.ImageType)
                If SaveImage(url, sFname) Then
                    PictureBox2.ImageLocation = sFname
                End If
            Catch ex As Exception
                lblStatus.Text = ex.Message
            End Try
        End If
    End Sub

    Private Sub frmAddCbdy_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _search IsNot Nothing Then
            _search.Close()
        End If
        My.Settings.mainformpos = setFormPos(Me)
        My.Settings.Save()
    End Sub

    Private Sub frmAddCbdy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.callUpgrade = 0 Then
            My.Settings.Upgrade()
            My.Settings.callUpgrade = 1
            My.Settings.Save()
        End If
        Label11.Text = "Version: " & My.Application.Info.Version.ToString
        getFormPos(Me, My.Settings.mainformpos)
        txtLoadYr.Text = ""
        txtLoadMth.Text = ""
        cbImgType.SelectedIndex = 0
        cbDateAmend.Checked = False
        bLoadingPerson = False
    End Sub

    Private Sub btnCreateShortDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateShortDesc.Click
        txtShortDesc.Text = txtDesc.SelectedText
    End Sub

    Public Sub btnSplitName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSplitName.Click
        txtName.Text = txtName.Text.Trim
        Dim names As String() = Split(txtName.Text, " ")
        txtSurname.Text = names(UBound(names))
        txtForename.Text = txtName.Text.Replace(txtSurname.Text, "").Trim
    End Sub

    Private Sub btnCreateFullName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateFullName.Click
        txtName.Text = (txtForename.Text & " " & txtSurname.Text).Trim(" ")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FindPeopleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindPeopleToolStripMenuItem.Click
        If mDialog1 Is Nothing Then
            mDialog1 = New frmSearchDb
        End If
        mDialog1.Show()

    End Sub

    Private Sub btnLoadUpd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadUpd.Click
        updateDate()
    End Sub
    Private Sub updateDate()

        Dim oTa As New CelebrityBirthdayDataSetTableAdapters.DatesTableAdapter
        oTa.UpdateDate(txtLoadYr.Text, txtLoadMth.Text, cbDateAmend.Checked, txtLoadDay.Text, cboDay.SelectedIndex + 1, cboMonth.SelectedIndex + 1)
        oTa.Dispose()
    End Sub

    Private Sub btnClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearList.Click
        Dim resp As MsgBoxResult = MsgBoxResult.No
        If checkForChanges() Then
            If MsgBox("Save unsaved changes now?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Unsaved Changes") = MsgBoxResult.Yes Then
                btnUpdateAll_Click(sender, e)
            End If
        End If

        personTable = New ArrayList
        lbPeople.Items.Clear()
        cboDay.SelectedIndex = -1
        cboMonth.SelectedIndex = -1
    End Sub

    Private Sub btnFindImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindImage.Click
        My.Computer.Clipboard.SetText(txtName.Text)
        If oWebBrowser Is Nothing Then
            oWebBrowser = New frmWebImageSearch
        End If
        Dim sUrl As String = "http://images.google.co.uk/images?q=" & txtName.Text.Replace(" ", "+")
        oWebBrowser.txtURL.Text = sUrl
        oWebBrowser.CurrentName = txtName.Text
        oWebBrowser.WebBrowse.Navigate(sUrl)
        oWebBrowser.Show()
        oWebBrowser.BringToFront()
    End Sub

    Private Function checkForChanges() As Boolean
        Dim isUnsavedChanges As Boolean = False
        If personTable IsNot Nothing Then
            For Each oPerson As Person In personTable
                If oPerson.unsavedChanges Then
                    isUnsavedChanges = True
                End If
            Next
        End If
        Return isUnsavedChanges
    End Function

    Private Sub frmMain_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        My.Settings.mainformpos = setFormPos(Me)
        My.Settings.Save()
    End Sub

    Private Sub ImagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImagesToolStripMenuItem.Click
        Dim imgForm As New frmImageMaint
        imgForm.ShowDialog()
        imgForm.Dispose()
    End Sub


    Private Sub txtYear_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYear.TextChanged, txtDied.TextChanged, _
                                                                                                txtImgName.TextChanged, _
                                                                                                txtForename.TextChanged, txtSurname.TextChanged, _
                                                                                                txtName.TextChanged, txtDesc.TextChanged, _
                                                                                                txtShortDesc.TextChanged, txtBirthName.TextChanged, _
                                                                                                txtBirthPlace.TextChanged, txtDthDay.TextChanged, _
                                                                                                txtDthMth.TextChanged
        If Not bLoadingPerson Then
            cbDateAmend.Checked = True
        End If
    End Sub

    Private Const EM_CHARFROMPOS As Int32 = &HD7
    Private Structure POINTAPI
        Public X As Integer
        Public Y As Integer
    End Structure

    Private Declare Function SendMessageLong Lib "user32" Alias _
        "SendMessageA" (ByVal hWnd As IntPtr, ByVal wMsg As  _
        Int32, ByVal wParam As Int32, ByVal lParam As Int32) As _
        Long

    ' Return the character position under the mouse.
    Public Function TextBoxCursorPos(ByRef oBox As TextBox, _
        ByVal X As Single, ByVal Y As Single) As Long
        ' Convert screen coordinates into control coordinates.
        Dim pt As Point = oBox.PointToClient(New Point(X, _
            Y))

        ' Get the character number
        TextBoxCursorPos = SendMessageLong(oBox.Handle, _
            EM_CHARFROMPOS, 0&, CLng(pt.X + pt.Y * &H10000)) _
            And &HFFFF&
    End Function

    Private Sub btnSaveImgInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveImgInfo.Click
        If txtCurrentText.TextLength > 0 Then

            Dim oIta As New CelebrityBirthdayDataSetTableAdapters.ImageTableAdapter
            Dim oITable As New CelebrityBirthdayDataSet.ImageDataTable
            Dim sText As String = txtCurrentText.Text.Trim.Replace(vbCr, "").Replace(vbLf, "")
            Dim currParts As String() = Split(sText, "<h3>")
            For Each currPart As String In currParts
                Dim entries As String() = Split(currPart, "<img")

                For x = 1 To entries.Count - 1
                    Dim imgsrcstart As Int16 = entries(x).IndexOf("src=") + 5
                    Dim imgsrcend As Int16 = entries(x).IndexOf(" alt") - 1
                    Dim url = entries(x).Substring(imgsrcstart, imgsrcend - imgsrcstart)
                    Dim urlparts As String() = Split(url, "/")

                    Dim filename As String() = Split(urlparts(urlparts.Count - 1), ".")
                    Dim ldmth As String = urlparts(urlparts.Count - 2)
                    Dim ldyr As String = urlparts(urlparts.Count - 3)
                    Debug.Print(filename(0) & " " & filename(1) & " " & ldmth & " " & ldyr)

                    Dim ict As Integer = oIta.FillByFilename(oITable, filename(0), "." & filename(1))
                    If ict = 1 Then
                        Dim oIRow As CelebrityBirthdayDataSet.ImageRow = oITable.Rows(0)
                        oIta.UpdateImage(filename(0), "." & filename(1), ldyr, ldmth, Nothing, oIRow.id)
                    End If
                Next
            Next
            oITable.Dispose()
            oIta.Dispose()
        End If

    End Sub

    Private Sub btnWiki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWiki.Click
        Dim item As String() = {""}
        If lblID.Text.Length > 0 And lbPeople.SelectedIndex >= 0 Then
            item = Split(lbPeople.SelectedItem, " ")
            item(0) = ""
        Else
            If txtName.TextLength > 0 Then
                item = Split(txtName.Text, " ")
            End If
        End If
        If _search Is Nothing Then
            _search = New frmSearchDb
        End If
        _search.Show()
        _search.searchName = Join(item, " ").Trim
        _search.FindinWiki()

    End Sub

    Private Sub txtDthDay_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDthDay.Click, txtDthMth.Click, txtDied.Click
        Dim fld As TextBox = CType(sender, TextBox)
        fld.SelectAll()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal menuItem As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        getSourceControl(menuItem).Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal menuItem As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        getSourceControl(menuItem).Cut()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        Dim _textBox As TextBox = getSourceControl(sender)
        If _textBox IsNot Nothing Then
            _textBox.SelectAll()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal menuItem As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Dim _textBox As TextBox = getSourceControl(menuItem)
        _textBox.SelectionStart = _textBox.SelectionStart + _textBox.SelectionLength
        _textBox.Paste()
    End Sub

    Private Sub LowercaseToolStripMenuItem_Click(ByVal menuItem As System.Object, ByVal e As System.EventArgs) Handles LowercaseToolStripMenuItem.Click
        Dim _textBox As TextBox = getSourceControl(menuItem)
        _textBox.SelectedText = _textBox.SelectedText.ToLower
    End Sub

    Private Sub UpperCaseToolStripMenuItem_Click(ByVal menuItem As System.Object, ByVal e As System.EventArgs) Handles UpperCaseToolStripMenuItem.Click
        Dim _textBox As TextBox = getSourceControl(menuItem)
        _textBox.SelectedText = _textBox.SelectedText.ToUpper
    End Sub

    Private Function getSourceControl(ByRef menuItem As Object) As TextBox
        Dim _menuItem As ToolStripMenuItem = CType(menuItem, ToolStripMenuItem)
        Dim menuStrip As ContextMenuStrip = CType(_menuItem.Owner, ContextMenuStrip)
        Return menuStrip.SourceControl
    End Function

    Private Sub TitleCaseToolStripMenuItem_Click(ByVal menuItem As System.Object, ByVal e As System.EventArgs) Handles TitleCaseToolStripMenuItem.Click
        Dim _textBox As TextBox = getSourceControl(menuItem)
        _textBox.SelectedText = StrConv(_textBox.SelectedText, VbStrConv.ProperCase)
    End Sub


    Private Sub ClearToolStripMenuItem_Click(ByVal menuItem As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Dim _textBox As TextBox = getSourceControl(menuItem)
        _textBox.Text = ""
    End Sub

    Private Sub btnCopyBirthName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyBirthName.Click

        If txtDesc.SelectionLength > 0 Then
            Dim name As String = txtDesc.SelectedText
            Dim names As String() = Split(name, """")
            If names.Length = 3 Then
                name = names(0).Trim & " " & names(2).Trim
            End If
            txtBirthName.Text = name
        End If
    End Sub

    Private Sub btnCopyBirthPlace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyBirthPlace.Click
        If txtDesc.SelectionLength > 0 Then
            txtBirthPlace.Text = txtDesc.SelectedText.Trim.TrimEnd(".").TrimEnd(",")
        End If
    End Sub

    Private Sub btnClearDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearDesc.Click
        txtDesc.Text = ""
    End Sub

    Private Sub UseNicknameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UseNicknameToolStripMenuItem.Click
        If txtDesc.SelectionLength > 0 Then
            txtDesc.SelectedText = getNickname(txtDesc.SelectedText)
        End If
    End Sub

    Private Function getNickname(ByRef sName As String) As String
        Dim names As String() = Split(sName, """")
        Dim sNickName As String = ""
        If names.Length > 2 Then
            sNickName = names(1).Trim & " " & names(2).Trim
            sName = names(0).Trim & " " & names(2).Trim
        End If
        Return sNickName & " "
    End Function

    Private Sub btnTidy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTidy.Click
        tidyText()
    End Sub

    Private Sub tidyText()
        Dim charsToTrim() As Char = {" "c, ","c, ";"c, "."c}
        Dim newText As String = txtDesc.Text.Trim(charsToTrim).Replace("–", "-").Replace(Chr(147), """").Replace(Chr(148), """")
        Do While newText.Contains("[") And newText.Contains("]")
            Dim parts1 As String() = Split(newText, "[", 2)
            Dim parts2 As String() = Split(parts1(1), "]", 2)
            newText = parts1(0) & parts2(1)
        Loop

        Dim s1 As String() = Split(newText, " - ")

        If s1.Count > 1 Then
            Dim s2 As String() = Split(s1(1), ")")
            If s2.Count > 1 Then
                If IsDate(s2(0)) Then
                    Dim d1 As Date = CDate(s2(0))
                    txtDthDay.Text = Format(d1, "dd")
                    txtDthMth.Text = Format(d1, "MM")
                End If
            End If
        End If

        Dim s3 As String() = Split(newText, "(")
        If s3.Count > 1 Then
            If s3(0).IndexOf("""") > 0 Then
                Dim birthName As String = s3(0)
                s3(0) = getNickname(birthName)
                txtBirthName.Text = birthName
                newText = Join(s3, "(")
            End If
        End If

        txtDesc.Text = newText & If(newText.Length > 0, ".", "")
        txtName.Text = txtName.Text.Trim(charsToTrim)
        txtForename.Text = txtForename.Text.Trim(charsToTrim)
        txtSurname.Text = txtSurname.Text.Trim(charsToTrim)
        Dim newShortText = txtShortDesc.Text.Trim(charsToTrim)
        txtShortDesc.Text = newShortText & If(newShortText.Length > 0, ".", "")
        txtBirthName.Text = txtBirthName.Text.Replace(",", "").Replace(".", "").Replace(";", "").Trim(charsToTrim)
        txtBirthPlace.Text = txtBirthPlace.Text.Replace(".", "").Replace(";", "").Trim(charsToTrim)
        txtImgName.Text = txtImgName.Text.Replace("'", "").Trim(charsToTrim)
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Using _options As New frmOptions
            _options.ShowDialog()
        End Using
    End Sub
End Class

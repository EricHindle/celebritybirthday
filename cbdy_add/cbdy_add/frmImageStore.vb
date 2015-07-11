Imports System.IO

Imports System.Net

Public Class frmImageStore
    Dim iProtocol As Short
    Dim b() As Byte '   Store picture bytes
    Dim sImagePath As String
    Dim sApplicationPath As String
    Private myPicArray As New ArrayList
    Private mypicno As Integer
    '   Dim inet1 As Inet

    Dim bLoadingPicture As Boolean = False

    Private myCurrentName As String
    Public Property CurrentName() As String
        Get
            Return myCurrentName
        End Get
        Set(ByVal value As String)
            myCurrentName = value
        End Set
    End Property

    Public Property PicNo() As Integer
        Get
            Return mypicno
        End Get
        Set(ByVal value As Integer)
            mypicno = value
        End Set
    End Property


    Public Property picArray() As ArrayList
        Get
            Return myPicArray
        End Get
        Set(ByVal value As ArrayList)
            myPicArray = value
        End Set
    End Property
    Public Sub showPicture(ByRef pic As Integer)
        If myPicArray.Count > pic Then
            bLoadingPicture = True
            Label2.Text = myPicArray.Item(pic)
            PicBrowser.Navigate(New System.Uri(myPicArray.Item(pic)))
        Else
            Label2.Text = "None"
        End If
    End Sub
    Private Sub getPicture(ByRef URL As String)
        If URL.Length > 0 Then
            PicBrowser.Navigate(New System.Uri(URL))
        End If
    End Sub
    Private Function getUniqueFname(ByVal filename As String) As String
        Dim newfilename As String = filename
        For subs As Integer = 0 To 999
            newfilename = Path.Combine(sImagePath, Path.GetFileNameWithoutExtension(filename) & "_" & CStr(subs) & Path.GetExtension(filename))
            If My.Computer.FileSystem.FileExists(newfilename) = False Then
                Exit For
            End If

        Next
        Return newfilename
    End Function

    Private Sub WebBrowser2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If

    End Sub


    Private Sub WebBrowser2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getFormPos(Me, My.Settings.imgselectpos)
        sApplicationPath = My.Application.Info.DirectoryPath
        sImagePath = My.Settings.newimagepath.Replace("<applicationpath>", sApplicationPath)
        Label1.Text = sImagePath
        If My.Computer.FileSystem.DirectoryExists(sImagePath) = False Then
            My.Computer.FileSystem.CreateDirectory(sImagePath)
        End If

    End Sub


    Private Sub btnSavepic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavepic.Click
        sImagePath = My.Settings.newimagepath.Replace("<applicationpath>", sApplicationPath)
        If bLoadingPicture Then
            MsgBox("Picture still loading", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim url As String = ""
        If picArray.Count > 0 AndAlso mypicno < picArray.Count Then
            url = picArray.Item(mypicno)
        Else
            MsgBox("No picture", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim ext As String = Path.GetExtension(url)
        Dim picname As String = Path.GetFileNameWithoutExtension(url)
        Dim strFName As String
        If cbOrig.Checked Then
            strFName = Path.Combine(sImagePath, myCurrentName & "_" & picname & ext)
        Else
            strFName = Path.Combine(sImagePath, myCurrentName & ext)
        End If

        picStatus.Text = "Saving " & picname
        Me.Refresh()
        If My.Computer.FileSystem.FileExists(strFName) Then
            strFName = getUniqueFname(strFName)
        End If
        Me.Refresh()

        ' Create a request for the URL. 
        Dim request As WebRequest = WebRequest.Create(url)
        ' If required by the server, set the credentials.
        request.Credentials = CredentialCache.DefaultCredentials
        ' Get the response.
        Dim response As WebResponse = Nothing
        Try
            response = request.GetResponse()

            ' Display the status.
            picStatus.Text = CType(response, HttpWebResponse).StatusDescription
            Me.Refresh()
            ' Get the stream containing content returned by the server.
            Dim dataStream As Stream = response.GetResponseStream()

            ' Read the content.
            Dim buffer(4096) As Byte
            Dim memorystream As New MemoryStream
            Dim bct As Integer = -1
            picStatus.Text = "Writing memory stream"
            Me.Refresh()
            Do While (bct <> 0)
                bct = dataStream.Read(buffer, 0, buffer.Length)
                memorystream.Write(buffer, 0, bct)
            Loop

            b = memorystream.ToArray()
            picStatus.Text = "Writing file"
            Me.Refresh()
            If b.Length > 0 Then
                Dim bw As BinaryWriter = Nothing
                Try
                    bw = New BinaryWriter(File.Open(strFName, FileMode.Create))
                    bw.Write(b)
                Catch ex As Exception
                    MsgBox("Error writing file")
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
            picStatus.Text = "Saved"
        Catch ex As Exception
            picStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub btnNextpic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextpic.Click
        If mypicno < picArray.Count - 1 Then
            mypicno = mypicno + 1
            picStatus.Text = "Finding Next"
            getPicture(picArray.Item(mypicno))
        Else
            picStatus.Text = "No Next"
        End If
    End Sub

    Private Sub btnPrevpic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevpic.Click

        If mypicno > 0 Then
            mypicno = mypicno - 1
            picStatus.Text = "Finding Prev"
            getPicture(picArray.Item(mypicno))
        Else
            picStatus.Text = "No Prev"
        End If
    End Sub

    Private Sub PicBrowser_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles PicBrowser.DocumentCompleted
        picStatus.Text = "picture complete"
        bLoadingPicture = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.imgselectpos = setFormPos(Me)
        My.Settings.Save()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        FolderBrowserDialog1.SelectedPath = My.Settings.newimagepath

        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFolder = FolderBrowserDialog1.SelectedPath
            If MsgBox("Set default image folder to " & sFolder & " ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Image Folder") = MsgBoxResult.Yes Then
                My.Settings.newimagepath = sFolder
                My.Settings.Save()
            End If
            Label1.Text = sFolder
        End If

    End Sub

    Private Sub frmImageStore_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        My.Settings.imgselectpos = setFormPos(Me)
        My.Settings.Save()
    End Sub
End Class
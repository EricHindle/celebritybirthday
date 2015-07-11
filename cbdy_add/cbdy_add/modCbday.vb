Imports System.Text
Imports System.Globalization

Module modCbday
    Dim _lookup As Dictionary(Of Char, String) = Nothing

    Public Function ToSimpleCharacters(ByVal original As String) As String
        Dim rtnvalue As String = original
        If original <> String.Empty Then
            Dim stFormD As String = original.Normalize(NormalizationForm.FormD)
            Dim sb As New StringBuilder

            For ich As Integer = 0 To stFormD.Length - 1
                Dim uc As UnicodeCategory = CharUnicodeInfo.GetUnicodeCategory(stFormD(ich))
                If uc <> UnicodeCategory.NonSpacingMark And uc <> UnicodeCategory.OtherPunctuation Then
                    If Lookup.ContainsKey(stFormD(ich)) Then
                        sb.Append(Lookup(stFormD(ich)))
                    Else
                        sb.Append(stFormD(ich))
                    End If
                End If
            Next
            rtnvalue = sb.ToString().Normalize(NormalizationForm.FormC)
        End If
        Return rtnvalue
    End Function


    Private Function Lookup() As Dictionary(Of Char, String)
        If _lookup Is Nothing Then
            _lookup = New Dictionary(Of Char, String)()
            _lookup(Char.ConvertFromUtf32(230)(0)) = "ae"
            _lookup(Char.ConvertFromUtf32(198)(0)) = "AE"
            _lookup(Char.ConvertFromUtf32(208)(0)) = "D"
            _lookup(Char.ConvertFromUtf32(240)(0)) = "d"
            _lookup(Char.ConvertFromUtf32(222)(0)) = "th"
            _lookup(Char.ConvertFromUtf32(254)(0)) = "TH"
            _lookup(Char.ConvertFromUtf32(223)(0)) = "ss"
        End If

        Return _lookup
    End Function

    Public Function setFormPos(ByRef oForm As Form) As String
        Dim sPos As String
        If oForm.WindowState = FormWindowState.Maximized Then
            sPos = "max"
        ElseIf oForm.WindowState = FormWindowState.Minimized Then
            sPos = "min"
        Else
            sPos = oForm.Top & "~" & oForm.Left & "~" & oForm.Height & "~" & oForm.Width
        End If
        Return sPos
    End Function

    Public Sub getFormPos(ByRef oForm As Form, ByVal sPos As String)
        If sPos = "max" Then
            oForm.WindowState = FormWindowState.Maximized
        ElseIf sPos = "min" Then
            oForm.WindowState = FormWindowState.Minimized
        Else
            Dim pos As String() = sPos.Split("~")
            If pos.Count = 4 Then
                oForm.Top = CInt(pos(0))
                oForm.Left = CInt(pos(1))
                oForm.Height = CInt(pos(2))
                oForm.Width = CInt(pos(3))
            End If
        End If
    End Sub



End Module

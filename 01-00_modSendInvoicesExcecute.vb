Imports System.Net.Mail
Imports System.Text
Module mod01SendFacturenExcecute
    Public Sub predictIndicators(ByVal myFirstPfdLink As String)
        'check whether one or more items are found in pdf
        Dim tempValue As String
        Dim tempCounter As Integer = 0
        Dim content = GetAllTextFromPDF(myFirstPfdLink)
        For i = 0 To frmSEIN.cmb00_AdresIndicator.Items.Count - 1
            tempValue = frmSEIN.cmb00_AdresIndicator.Items(i)    'To: (A.B. Smith)
            tempValue = Left(tempValue, InStr(tempValue, ":"))
            If InStr(content, tempValue) > 0 Then
                tempCounter = tempCounter + 1
                frmSEIN.cmb00_AdresIndicator.Text = frmSEIN.cmb00_AdresIndicator.Items(i)
                gstrAdresIndicator = tempValue
            End If
        Next i
        If tempCounter <> 1 Then
            frmSEIN.cmb00_AdresIndicator.Text = "type or select"
            gstrAdresIndicator = ""
        End If
        tempValue = ""
        tempCounter = 0

        For i = 0 To frmSEIN.cmb00_Salutation.Items.Count - 1
            tempValue = frmSEIN.cmb00_Salutation.Items(i)  'Dear (A.B. Smith),
            tempValue = Left(tempValue, InStr(tempValue, "(") - 1)
            If InStr(content, tempValue) > 0 Then
                tempCounter = tempCounter + 1
                frmSEIN.cmb00_Salutation.Text = frmSEIN.cmb00_Salutation.Items(i)
                gstrSalutation = tempValue
            End If
        Next i
        If tempCounter <> 1 Then
            frmSEIN.cmb00_Salutation.Text = "type or select"
            gstrSalutation = ""
        End If
        tempValue = ""
        tempCounter = 0

        For i = 0 To frmSEIN.cmb00_Formulation.Items.Count - 1
            tempValue = frmSEIN.cmb00_Formulation.Items(i)  'stating invoice number (100037/2020)
            tempValue = Left(tempValue, InStr(tempValue, "(") - 1)
            If InStr(content, tempValue) > 0 Then
                tempCounter = tempCounter + 1
                frmSEIN.cmb00_Formulation.Text = frmSEIN.cmb00_Formulation.Items(i)
                gstrFormulation = tempValue
            End If
        Next i
        If tempCounter <> 1 Then
            frmSEIN.cmb00_Formulation.Text = "type or select"
            gstrFormulation = ""
        End If
        tempValue = ""
        tempCounter = 0

        For i = 0 To frmSEIN.cmb00_Currency.Items.Count - 1
            tempValue = frmSEIN.cmb00_Currency.Items(i)  '€
            If InStr(content, tempValue) > 0 Then
                tempCounter = tempCounter + 1
                frmSEIN.cmb00_Currency.Text = frmSEIN.cmb00_Currency.Items(i)
                gstrCurrency = tempValue
            End If
        Next i
        If tempCounter <> 1 Then
            frmSEIN.cmb00_Currency.Text = "type or select"
            gstrCurrency = ""
        End If
        tempValue = ""
        tempCounter = 0
    End Sub
    Public Sub setColorNewline(ByVal thisTextColor As System.Drawing.Color, ByVal thisHiddenColor As System.Drawing.Color)
        frmSEIN.rtb00_Message.Text = ""

        frmSEIN.rtb00_Message.SelectionColor = thisHiddenColor
        frmSEIN.rtb00_Message.SelectionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        frmSEIN.rtb00_Message.SelectedText = "write text of email; be aware: the invoice goes as attachment pdf" & vbCrLf & vbCrLf

        frmSEIN.rtb00_Message.SelectionColor = thisTextColor
        frmSEIN.rtb00_Message.SelectionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        frmSEIN.rtb00_Message.SelectedText = "Dear «MemberName»," & vbCrLf & _
        vbCrLf & _
        "Hereby you receive the invoice for your garden nr «MemberNumber»." & vbCrLf & _
         vbCrLf & _
        "Kind regards," & vbCrLf & _
        "Our Paradise" & vbCrLf & _
         vbCrLf & _
        "H.K. van de Ven," & vbCrLf & _
        "treasurer"
    End Sub
    Public Sub controlAllValuesArray()
        '0.2 controlAllValuesArray() 
        '0.21 if errors: fill listview with errors and send mail with errors to myFrom
        '0.22 if errors: fill listview with values
        Dim thisDate As Date = Format(Now, "yyyy-MM-dd")
        Dim thisError As String
        Dim isPdfReady As Boolean = True
        Dim thisValuesArray(4) As String
        Dim numbersArray(gintPageCount - 1) As String

        frmSEIN.lvw03_ShowMembers.Items.Clear()
        For i = 0 To (gintPageCount - 1)
            For j = 0 To UBound(thisValuesArray)
                thisValuesArray(j) = gAllValuesArray(i, j)
                If thisValuesArray(j) = "" Then
                    Select Case j
                        Case 0
                            thisError = thisError & " no#"
                        Case 1
                            thisError = thisError & " noName"
                        Case 2
                            thisError = thisError & " no@"
                        Case 3
                            thisError = thisError & " no€$£"
                        Case 4
                            thisError = thisError & " noyear"
                    End Select
                Else
                    Select Case j
                        Case 0
                            'If thisValuesArray(0) <> (i + 1) Then
                            'thisError = thisError & " " & thisValuesArray(0) & "<>" & (i + 1)
                            'End If
                            numbersArray(i) = thisValuesArray(0)
                        Case 4
                            If thisValuesArray(4) <> CStr(thisDate.Year) Then
                                thisError = thisError & " " & thisValuesArray(4)
                            End If
                    End Select
                End If
            Next j
            fillListview(thisValuesArray)
            If thisError = "" Then
                If InStr(thisValuesArray(2), "@") > 0 Then
                    Dim thisProvider As String
                    thisProvider = (Split(thisValuesArray(2), "@")(1))
                    If checkURL(thisProvider) = False Then
                        frmSEIN.lvw03_ShowMembers.Items(i).SubItems(5).Text = "no" & thisProvider
                    End If
                End If
            Else
                isPdfReady = False
                frmSEIN.rtb00_bigPdf.ForeColor = Color.Red
                frmSEIN.lvw03_ShowMembers.Items(i).SubItems(5).Text = thisError
            End If
            ReDim thisValuesArray(4)
            thisError = ""
        Next (i)
        frmSEIN.cmb02_SendOne.Items.AddRange(numbersArray)
    End Sub
    Public Sub sendPdfs(ByVal myTest As String, ByVal myFrom As String, ByVal myNumbersArray() As Integer)
        '0.3 if noerrors: sendPdfs(myNumbersArray)
        '0.31 prepare sending
        '0.32 for i = 0 to n-1: send
        '0.33 close sending
        frmSEIN.lbl01_SentCounter.Text = 0
        frmSEIN.lbl01_NotsentCounter.Text = 0
        frmSEIN.ProgressBar1.Value = 5
        Dim thisValuesArray(4) As String
        Dim thisRemark As String
        '0.31 prepare sending
        If myTest = "TEST" Then
            'this check is probably redundant, just to be sure...
            For i = 0 To UBound(myNumbersArray)
                For j = 0 To 4
                    thisValuesArray(j) = gAllValuesArray(myNumbersArray(i) - 1, j)
                Next j
                If thisValuesArray(0) <> CStr(frmSEIN.txt01_NumberICT.Text) And thisValuesArray(0) <> CStr(frmSEIN.txt01_NumberTREA.Text) Then 'to prevent all mistakes
                    thisRemark = "testmails cannot be send to members, except to ict-assistent or treasurer"
                    thisValuesArray(2) = ""   'testmails cannot be send, except to ict-assistent or treasurer
                    Exit Sub
                End If
            Next i
        End If

        Dim thisFromAddress As String = ""
        Dim thisPassword As String = ""
        Dim thisMessageTemplate As String = ""

        Dim thisAttachment As String = ""
        Dim thisSubject As String = ""
        Dim thisMessage As String = ""

        Dim thisNumber As String = ""           '0
        Dim thisName As String = ""             '1     
        Dim thisEmailAddress As String = ""     '2
        Dim thisTotaalBedrag As String = ""     '3
        Dim thisYear As String = ""             '4

        Dim thisNotSentCounter As Integer = 0
        Dim thisSentCounter As Integer = 0
        If myFrom = "ICT" Then
            thisFromAddress = frmSEIN.txt01_EmailICT.Text
            thisPassword = Replace(frmSEIN.txt01_PasswordICT.Text, " ", "")
            frmSEIN.txt01_PasswordICT.Text = thisPassword
            frmSEIN.txt01_PasswordICT.Refresh()
        ElseIf myFrom = "TREA" Then
            thisFromAddress = frmSEIN.txt01_EmailTREA.Text
            thisPassword = Replace(frmSEIN.txt01_PasswordTREA.Text, " ", "")
            frmSEIN.txt01_PasswordTREA.Text = thisPassword
            frmSEIN.txt01_PasswordTREA.Refresh()
        Else
            thisRemark = "no ICT/TREA data"
            Exit Sub
        End If
        Dim isFirstRow As Boolean
        For Each line In frmSEIN.rtb00_Message.Lines
            If line = "write text of email; be aware: the invoice goes as attachment pdf" Then
                isFirstRow = True
            ElseIf isFirstRow = True And line = "" Then
                isFirstRow = False
            Else
                line = line & "<br />"
                thisMessageTemplate = thisMessageTemplate & line
                isFirstRow = False
            End If
        Next line
        thisMessageTemplate = Replace(thisMessageTemplate, "write text of email; be aware: the invoice goes as attachment pdf", "")
        thisMessageTemplate = Replace(thisMessageTemplate, "  ", " ")
        Try
            'i'm aware SmtpClient is obsolete, but no time to figure out MailKit 
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Dim attachment As System.Net.Mail.Attachment
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(thisFromAddress, thisPassword)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            '0.32 for i = 0 to n-1: send
            For i = 0 To UBound(myNumbersArray)
                For j = 0 To 4
                    thisValuesArray(j) = gAllValuesArray(myNumbersArray(i) - 1, j)
                Next j
                thisNumber = thisValuesArray(0)
                thisName = thisValuesArray(1)
                thisEmailAddress = thisValuesArray(2)
                thisTotaalBedrag = thisValuesArray(3)
                thisYear = thisValuesArray(4)
                thisAttachment = My.Computer.FileSystem.GetParentPath(gstrBigPfdLink) & "\" & myTest & "invoice_" & thisNumber & ".pdf" 'invoice_37.pdf
                If InStr(thisEmailAddress, "@") > 0 Then
                    If File.Exists(thisAttachment) = True Then
                        thisSubject = myTest & "invoice 100" & thisNumber & "/" & thisYear 'invoice 100037/2020
                        thisMessage = Replace(thisMessageTemplate, "«MemberName»", thisName)
                        thisMessage = Replace(thisMessage, "«MemberNumber»", thisNumber)
                    Else
                        thisRemark = "noPdf"
                    End If
                Else
                    thisRemark = "no@"
                End If
                If thisRemark <> "" Then
                    thisEmailAddress = thisFromAddress
                    thisSubject = "NOT SEND: " & My.Computer.FileSystem.GetName(thisAttachment) 'factuur ATV Kweeklust 100037/2020"
                    thisMessage = _
                               "be aware:" & Environment.NewLine & Environment.NewLine & _
                               "not send:" & thisAttachment & Environment.NewLine & _
                               "error message:" & thisRemark & Environment.NewLine & Environment.NewLine & _
                               "this e-mail is automatically send from the app SEIN."
                    thisMessage = thisMessage.Replace(Environment.NewLine, "<br />")
                    thisNotSentCounter = thisNotSentCounter + 1
                Else
                    thisSentCounter = thisSentCounter + 1
                End If
                e_mail = New MailMessage()
                e_mail.From = New MailAddress(thisFromAddress)
                attachment = New System.Net.Mail.Attachment(thisAttachment) 'file path
                e_mail.To.Add(thisEmailAddress)
                e_mail.Attachments.Add(attachment) 'attachment
                e_mail.Subject = thisSubject
                e_mail.IsBodyHtml = True
                e_mail.Body = thisMessage
                Smtp_Server.Send(e_mail)
                attachment.Dispose()
                e_mail.Dispose()
                If thisRemark = "" Then
                    thisRemark = "send"
                End If
                Dim foundItem As ListViewItem = frmSEIN.lvw03_ShowMembers.FindItemWithText(thisNumber)
                Dim tempIndex As Integer = frmSEIN.lvw03_ShowMembers.Items.IndexOf(foundItem)
                frmSEIN.lvw03_ShowMembers.Items(tempIndex).SubItems(5).Text = thisRemark
                frmSEIN.lvw03_ShowMembers.TopItem = foundItem
                frmSEIN.lbl01_SentCounter.Text = thisSentCounter
                frmSEIN.lbl01_SentCounter.Refresh()
                frmSEIN.lbl01_NotsentCounter.Text = thisNotSentCounter
                frmSEIN.lbl01_NotsentCounter.Refresh()
                frmSEIN.ProgressBar1.Value = 5 + 95 * (i + 1) / (UBound(myNumbersArray) + 1)
                frmSEIN.ProgressBar1.Refresh()

                ReDim thisValuesArray(4)
                thisNumber = ""           '0
                thisName = ""             '1     
                thisEmailAddress = ""     '2
                thisTotaalBedrag = ""     '3
                thisYear = ""             '4
                thisRemark = ""
                thisAttachment = ""
                thisSubject = ""
                thisMessage = ""
            Next i
            '0.33 close sending
        Catch error_t As Exception
            If thisNumber = "" Then
                thisRemark = error_t.ToString
                MsgBox("failure, problably Google app password not correct or no connection" & Chr(13) & thisRemark, , "not send")
            Else
                thisRemark = "notsend"
                Dim foundItem As ListViewItem = frmSEIN.lvw03_ShowMembers.FindItemWithText(thisNumber)
                Dim tempIndex As Integer = frmSEIN.lvw03_ShowMembers.Items.IndexOf(foundItem)
                frmSEIN.lvw03_ShowMembers.Items(tempIndex).SubItems(5).Text = thisRemark
            End If
        End Try
        '0.33 close sending
    End Sub
    Public Sub fillListview(ByVal myValuesArray() As String)
        Dim item = New ListViewItem(myValuesArray(0)) 'thisNumber
        item.SubItems.Add(myValuesArray(1))           'thisName
        item.SubItems.Add(myValuesArray(2))           'thisEmailAddress
        item.SubItems.Add(myValuesArray(3))           'thisTotaalBedrag
        item.SubItems.Add(myValuesArray(4))           'thisYear
        item.SubItems.Add("")
        frmSEIN.lvw03_ShowMembers.Items.Add(item)
        item.Selected = True
        item.EnsureVisible()
    End Sub
    Public Sub deleteTESTpfds()
        Dim tempArray() As String
        If gstrBigPfdLink <> "" Then
            If Directory.Exists(My.Computer.FileSystem.GetParentPath(gstrBigPfdLink)) = True Then
                tempArray = Directory.GetFiles(My.Computer.FileSystem.GetParentPath(gstrBigPfdLink), "TESTinvoice_*", SearchOption.TopDirectoryOnly)
                If tempArray IsNot Nothing Then
                    For Each link In tempArray
                        On Error Resume Next
                        File.Delete(link)
                    Next link
                End If
            End If
        End If
    End Sub
    Public Sub controleerPdfs()
        Dim tempArray() As String
        Dim thisBigPfdDate As Date
        Dim thisSmallPfdDate As Date
        Dim thisAnswer As MsgBoxResult = Nothing

        If gstrBigPfdLink <> "" Then
            If Directory.Exists(My.Computer.FileSystem.GetParentPath(gstrBigPfdLink)) = True Then
                tempArray = Directory.GetFiles(My.Computer.FileSystem.GetParentPath(gstrBigPfdLink), "invoice_*.pdf", SearchOption.TopDirectoryOnly)
                thisBigPfdDate = getFileDate(gstrBigPfdLink)
                If tempArray IsNot Nothing Then
                    For Each link In tempArray
                        If getFileDate(link) < thisBigPfdDate Then
                            If thisAnswer = Nothing Then thisAnswer = QuestionDeleteOldInvoices(link)
                            If thisAnswer = MsgBoxResult.Yes Then
                                On Error Resume Next
                                File.Delete(link)
                            End If
                        Else
                            'MsgBox((getFileDate(link) - thisBigPfdDate).ToString)
                        End If
                    Next link
                End If
            End If
        End If
    End Sub
End Module

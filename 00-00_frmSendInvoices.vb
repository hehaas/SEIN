Imports System.Runtime.InteropServices
Imports System.IO
Public Class frmSEIN
    '*****************************************************************************
    'Purpose   send email to garden club members with invoice as pdf attachment
    'Inputs    1 pdf with n invoices: invoice_(n).pdf (made in Office Word)
    'Assumes   iText software: itextpdf.com  [itextsharp.dll] 
    'Assumes   invoice_(n).pdf should contain certain elements, see below
    'Results   n separate pdf's, invoice_(i).pdf in same folder as invoice_(n).pdf	 
    'Results   send mails in Sendbox treasurer + Inbox garden club members
    'Results   if notsend: in Inbox treasurer: NOT SEND: invoice_(i).pdf
    '***************************************************************************** 
   
    Private Sub frmSEIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.cmd02_SendOne.Enabled = True Then
            If QuestionAppOntwikkeling() = MsgBoxResult.No Then
                MsgBox("Jammer dan", , "we gaan sluiten")
                Me.Close()
            End If
        End If
        cmd00_SplitPdf.PerformClick()
        If gstrBigPfdLink = "" Then
            MsgBox("select the pdf-file with all invoices" & Chr(13) & _
                 "you might create it with Microsoft Word: invoice_2020_110invoicespdf.docx", , "again")

            gstrBigPfdLink = selectBigPdfLink()
        End If
        If gstrBigPfdLink = "" Then
            MsgBox("... what you want ...", , "we are closing")
            Me.Close()
        Else
            deleteTESTpfds()
            controleerPdfs()
            setColorNewline(System.Drawing.Color.Black, System.Drawing.Color.Black)
        End If
    End Sub
    Private Sub cmd00_SplitPdf_Click(sender As System.Object, e As System.EventArgs) Handles cmd00_SplitPdf.Click
        Me.Enabled = False
        subCmd00_SplitPdf()
        Me.Enabled = True
    End Sub
    Private Sub cmd00_Help_Click(sender As System.Object, e As System.EventArgs) Handles cmd00_Help.Click
        If rtb00_Help.Visible = False Then
            rtb00_Help.Visible = True
            Me.rtb00_Help.Size = New System.Drawing.Size(700, 770)

            Me.rtb00_Help.BringToFront()
            Me.cmd00_Help.BringToFront()
        Else
            rtb00_Help.Visible = False
            Me.rtb00_Help.Size = New System.Drawing.Size(0, 0)
        End If
    End Sub
    Private Sub cmb01_TestVerbindingICT_TextChanged(sender As System.Object, e As System.EventArgs) Handles cmb01_TestVerbindingICT.TextChanged
        If cmb01_TestVerbindingICT.Text <> "" Then
            If txt01_NumberICT.ForeColor = Color.Red Or txt01_NumberTREA.ForeColor = Color.Red Then
                MsgBox("please type membernumber of ict-assistent and membernumber of treasurer", , "needed for testing")
            Else
                cmd01_TestVerbindingOKICT.Enabled = True
            End If
        End If
    End Sub
    Private Sub cmb01_TestVerbindingICT_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb01_TestVerbindingICT.SelectedIndexChanged
        MsgBox(cmb01_TestVerbindingICT.SelectedIndex)
    End Sub
    Private Sub cmb01_TestVerbindingTREA_TextChanged(sender As System.Object, e As System.EventArgs) Handles cmb01_TestVerbindingTREA.TextChanged
        If cmb01_TestVerbindingTREA.Text <> "" Then
            If txt01_NumberICT.ForeColor <> Color.Red And txt01_NumberTREA.ForeColor <> Color.Red Then
                cmd01_TestVerbindingOKTREA.Enabled = True
            End If
        End If
    End Sub
    Private Sub cmb01_TestVerbindingTREA_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) 'Handles cmb01_TestVerbindingTREA.SelectedIndexChanged
        If cmb01_TestVerbindingTREA.Text <> "" Then
            If txt01_NumberICT.ForeColor <> Color.Red And txt01_NumberTREA.ForeColor <> Color.Red Then
                cmd01_TestVerbindingOKTREA.Enabled = True
            End If
        End If
    End Sub
    Private Sub cmb02_SendOne_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb02_SendOne.SelectedIndexChanged
        If cmb02_SendOne.SelectedItem <> Nothing And IsNumeric(cmb02_SendOne.SelectedItem) Then
            If CInt(cmb02_SendOne.SelectedItem) > 0 And CInt(cmb02_SendOne.SelectedItem) <= 110 Then
                cmd02_SendOneOK.Enabled = True
            Else
                cmd02_SendOneOK.Enabled = False
            End If
        Else
            cmd02_SendOneOK.Enabled = False
        End If
    End Sub
    Private Sub cmb02_SendOne_TextChanged(sender As System.Object, e As System.EventArgs) Handles cmb02_SendOne.TextChanged
        If cmb02_SendOne.Text <> Nothing And IsNumeric(cmb02_SendOne.Text) Then
            If CInt(cmb02_SendOne.Text) > 0 And CInt(cmb02_SendOne.Text) <= 110 Then
                cmd02_SendOneOK.Enabled = True
            Else
                cmd02_SendOneOK.Enabled = False
                cmd02_SendOne.Text = Nothing
            End If
        Else
            cmd02_SendOneOK.Enabled = False
            cmb02_SendOne.Text = Nothing
            cmb02_SendOne.SelectedIndex = -1
        End If
    End Sub
    Private Sub cmd01_TestVerbindingICT_Click(sender As System.Object, e As System.EventArgs) Handles cmd01_TestVerbindingICT.Click
        Me.Enabled = False
        rtb00_Message.Visible = False
        lvw03_ShowMembers.Items.Clear()
        lvw03_ShowMembers.Refresh()
        lvw03_ShowMembers.Visible = True
        txt01_PasswordTREA.Enabled = False
        cmb01_TestVerbindingTREA.Text = ""
        cmb01_TestVerbindingTREA.Enabled = False
        txt01_EmailICT.Enabled = True
        txt01_PasswordICT.Enabled = True
        cmb01_TestVerbindingICT.Enabled = True
        Dim thisTest As String = "TEST"
        subCmd01_TestVerbindingICT(thisTest)
        Me.Enabled = True
    End Sub
    Private Sub cmd01_TestVerbindingTREA_Click(sender As System.Object, e As System.EventArgs) Handles cmd01_TestVerbindingTREA.Click
        txt01_PasswordICT.Enabled = False
        cmb01_TestVerbindingICT.Text = ""
        cmb01_TestVerbindingICT.Enabled = False
        txt01_EmailTREA.Enabled = True
        txt01_PasswordTREA.Enabled = True
        cmb01_TestVerbindingTREA.Enabled = True
    End Sub
    Private Sub txt01_NumberICT_DoubleClick(sender As System.Object, e As System.EventArgs) Handles txt01_NumberICT.DoubleClick
        txt01_NumberICT.Text = ""
    End Sub
    Private Sub txt01_NumberICT_KeyPress(sender As System.Object, e As KeyPressEventArgs) Handles txt01_NumberICT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If CStr(txt01_NumberICT.Text) <> "" And IsNumeric(txt01_NumberICT.Text) = True And IsNumeric(txt01_NumberTREA.Text) = False Then
                cmb01_TestVerbindingICT.Items(0) = CStr(txt01_NumberICT.Text)
                cmb01_TestVerbindingICT.Items(1) = CStr(txt01_NumberICT.Text) & " + " & CStr(txt01_NumberTREA.Text)
                cmb01_TestVerbindingTREA.Items(1) = CStr(txt01_NumberTREA.Text) & " + " & CStr(txt01_NumberICT.Text)
                txt01_NumberTREA.Enabled = True
                txt01_NumberTREA.ForeColor = Color.Red
            Else
                cmb01_TestVerbindingICT.Items(0) = ""
                cmb01_TestVerbindingICT.Items(1) = ""
                cmb01_TestVerbindingTREA.Items(1) = ""
                txt01_NumberTREA.Enabled = False
                txt01_NumberTREA.ForeColor = Color.Black
            End If
        End If
    End Sub
    Private Sub txt01_NumberTREA_DoubleClick(sender As System.Object, e As System.EventArgs) Handles txt01_NumberTREA.DoubleClick
        txt01_NumberTREA.Text = ""
    End Sub
    Private Sub txt01_NumberTREA_KeyPress(sender As System.Object, e As KeyPressEventArgs) Handles txt01_NumberTREA.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If CStr(txt01_NumberTREA.Text) <> "" And IsNumeric(txt01_NumberTREA.Text) = True Then
                cmb01_TestVerbindingICT.Items(1) = CStr(txt01_NumberICT.Text) & " + " & CStr(txt01_NumberTREA.Text)
                cmb01_TestVerbindingTREA.Items(0) = CStr(txt01_NumberTREA.Text)
                cmb01_TestVerbindingTREA.Items(1) = CStr(txt01_NumberTREA.Text) & " + " & CStr(txt01_NumberICT.Text)
                txt01_NumberTREA.ForeColor = Color.Black
                cmb01_TestVerbindingICT.Text = cmb01_TestVerbindingICT.Items(0)
                cmb01_TestVerbindingTREA.Text = cmb01_TestVerbindingTREA.Items(0)
            Else
                cmb01_TestVerbindingICT.Items(1) = ""
                cmb01_TestVerbindingTREA.Items(0) = ""
                cmb01_TestVerbindingTREA.Items(1) = ""
                txt01_NumberTREA.ForeColor = Color.Red
            End If
        End If
    End Sub
    Private Sub txt01_EmailICT_DoubleClick(sender As System.Object, e As System.EventArgs) Handles txt01_EmailICT.DoubleClick
        txt01_EmailICT.Text = ""
    End Sub
    Private Sub txt01_EmailTREA_DoubleClick(sender As System.Object, e As System.EventArgs) Handles txt01_EmailTREA.DoubleClick
        txt01_EmailTREA.Text = ""
    End Sub
    Private Sub txt01_PasswordICT_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt01_PasswordICT.TextChanged
        If txt01_PasswordICT.Text <> "" Then
            txt01_PasswordICT.Text = Replace(txt01_PasswordICT.Text, " ", "")
        End If
    End Sub
    Private Sub txt01_Passwordtrea_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt01_PasswordTREA.TextChanged
        If txt01_PasswordTREA.Text <> "" Then
            txt01_PasswordTREA.Text = Replace(txt01_PasswordTREA.Text, " ", "")
        End If
    End Sub
    Private Sub cmb00_AdresIndicator_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb00_AdresIndicator.SelectedIndexChanged
        If cmb00_AdresIndicator.SelectedItem <> "" Then
            gstrAdresIndicator = cmb00_AdresIndicator.SelectedItem
        End If
    End Sub
    Private Sub cmb00_Salutation_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb00_Salutation.SelectedIndexChanged
        If cmb00_Salutation.SelectedItem <> "" Then
            gstrSalutation = cmb00_Salutation.SelectedItem
        End If
    End Sub
    Private Sub cmb00_Formulation_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb00_Formulation.SelectedIndexChanged
        If cmb00_Formulation.SelectedItem <> "" Then
            gstrFormulation = cmb00_Formulation.SelectedItem
        End If
    End Sub
    Private Sub cmb00_Currency_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb00_Currency.SelectedIndexChanged
        If cmb00_Currency.SelectedItem <> "" Then
            gstrCurrency = cmb00_Currency.SelectedItem
        End If
    End Sub
    Private Sub cmd00_MessageOK_Click(sender As System.Object, e As System.EventArgs) Handles cmd00_MessageOK.Click
        rtb00_Message.Enabled = False
        cmd00_MessageOK.Visible = False
        cmd00_MessageEdit.Visible = True
        rtb00_Message.Visible = True
        setColorNewline(System.Drawing.Color.Black, rtb00_Message.BackColor)
    End Sub
    Private Sub cmd00_MessageEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmd00_MessageEdit.Click
        lvw03_ShowMembers.Visible = False
        rtb00_Message.Enabled = True
        cmd00_MessageEdit.Visible = False
        cmd00_MessageOK.Visible = True
        rtb00_Message.Visible = True
        setColorNewline(System.Drawing.Color.Black, System.Drawing.Color.Black)
    End Sub
    Private Sub txt01_EmailICT_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txt01_EmailICT.MouseLeave
        If InStr(txt01_EmailICT.Text, "@") > 0 And InStr(txt01_EmailICT.Text, "@gmail.") = 0 Then
            MsgBox("Sorry, this app is made to tackle issues with sending mails+attachment from gmail accounts; from other accounts try Word + MAPILAB's mailmerge instead" & Chr(13) & _
                   "https://www.mapilab.com/outlook/mail_merge/", , "SEIN only for gmail-accounts")
        ElseIf InStr(txt01_EmailICT.Text, "[") > 0 Or InStr(txt01_EmailICT.Text, "]") > 0 Then
            MsgBox("type your own gmail address", , "no [ or ] in address")
        End If
    End Sub
    Private Sub txt01_EmailTREA_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txt01_EmailTREA.MouseLeave
        If InStr(txt01_EmailTREA.Text, "@") > 0 And InStr(txt01_EmailTREA.Text, "@gmail.") = 0 Then
            MsgBox("Sorry, this app is made to tackle issues with sending mails+attachment from gmail accounts; from other accounts try Word + MAPILAB's mailmerge instead" & Chr(13) & _
                  "https://www.mapilab.com/outlook/mail_merge/", , "SEIN only for gmail-accounts")
        ElseIf InStr(txt01_EmailTREA.Text, "[") > 0 Or InStr(txt01_EmailTREA.Text, "]") > 0 Then
            MsgBox("type your own gmail address", , "no [ or ] in address")
        End If
    End Sub
    Private Sub cmd01_TestVerbindingOKICT_Click(sender As System.Object, e As System.EventArgs) Handles cmd01_TestVerbindingOKICT.Click
        Dim strNumbersArray(cmb02_SendOne.Items.Count - 1) As String
        cmb02_SendOne.Items.CopyTo(strNumbersArray, 0)
        If Array.IndexOf(strNumbersArray, txt01_NumberICT.Text) = -1 Then
            MsgBox("Membernumber " & txt01_NumberICT.Text & " is not mentioned in " & gstrBigPfdLink, , "type valid membernumber")
            txt01_NumberICT.Text = ""
            cmb01_TestVerbindingICT.Items(0) = ""
            cmb01_TestVerbindingICT.Items(1) = ""
            cmb01_TestVerbindingTREA.Items(1) = ""
            txt01_NumberTREA.Enabled = False
            txt01_NumberTREA.ForeColor = Color.Black
        ElseIf InStr(txt01_EmailICT.Text, "[") > 0 Or InStr(txt01_EmailICT.Text, "]") > 0 Then
            MsgBox("type your own gmail address", , "no [ or ] in address")
        Else
            Dim thisTest As String = "TEST"
            Dim thisFrom As String = "ICT"
            Dim thisTosArray() As String

            cmd01_TestVerbindingOKICT.Enabled = False

            lbl01_SentCounter.Text = 0
            lbl01_SentCounter.Refresh()
            lbl01_NotsentCounter.Text = 0
            lbl01_NotsentCounter.Refresh()

            If Me.rtb00_bigPdf.ForeColor <> Color.Red Then
                If InStr(cmb01_TestVerbindingICT.Text, " + ") = 0 Then
                    sendPdfs(thisTest, thisFrom, {CInt(cmb01_TestVerbindingICT.Text)})
                Else
                    Dim tempArray() As String = Split(cmb01_TestVerbindingICT.Text, " + ")
                    sendPdfs(thisTest, thisFrom, {CInt(tempArray(0)), CInt(tempArray(1))})
                End If
            Else
                MsgBox("selected pdf is not correct: year and/or membernumber not right" & Chr(13) & _
                      "make new pdf in Word", , "mail with errors is send to " & txt01_EmailICT.Text)
            End If
            cmb01_TestVerbindingICT.Text = ""
        End If
    End Sub
    Private Sub cmd01_TestVerbindingOKTREA_Click(sender As System.Object, e As System.EventArgs) Handles cmd01_TestVerbindingOKTREA.Click
        Dim strNumbersArray(cmb02_SendOne.Items.Count - 1) As String
        cmb02_SendOne.Items.CopyTo(strNumbersArray, 0)
        If Array.IndexOf(strNumbersArray, txt01_NumberTREA.Text) = -1 Then
            MsgBox("Membernumber " & txt01_NumberTREA.Text & " is not mentioned in " & gstrBigPfdLink, , "type valid membernumber")
            txt01_NumberTREA.Text = ""
            cmb01_TestVerbindingICT.Items(0) = ""
            cmb01_TestVerbindingICT.Items(1) = ""
            cmb01_TestVerbindingTREA.Items(1) = ""
            txt01_NumberTREA.Enabled = False
            txt01_NumberTREA.ForeColor = Color.Black
        ElseIf InStr(txt01_EmailTREA.Text, "[") > 0 Or InStr(txt01_EmailTREA.Text, "]") > 0 Then
            MsgBox("type your own gmail address", , "no [ or ] in address")
        Else
            Dim thisTest As String = "TEST"
            Dim thisFrom As String = "TREA"
            rtb00_Message.Visible = False
            cmd01_TestVerbindingOKTREA.Enabled = False

            lvw03_ShowMembers.Items.Clear()
            lvw03_ShowMembers.Refresh()
            lvw03_ShowMembers.Visible = True
            lbl01_SentCounter.Text = 0
            lbl01_SentCounter.Refresh()
            lbl01_NotsentCounter.Text = 0
            lbl01_NotsentCounter.Refresh()
            If Me.rtb00_bigPdf.ForeColor <> Color.Red Then
                If InStr(cmb01_TestVerbindingTREA.Text, " + ") = 0 Then
                    sendPdfs(thisTest, thisFrom, {CInt(cmb01_TestVerbindingTREA.Text)})
                Else
                    Dim tempArray() As String = Split(cmb01_TestVerbindingTREA.Text, " + ")
                    sendPdfs(thisTest, thisFrom, {CInt(tempArray(0)), CInt(tempArray(1))})
                End If
                If QuestionTestOK("your personal mailbox") = MsgBoxResult.Yes Then
                    cmd03_SendAll.Enabled = True
                    cmd02_SendOne.Enabled = True
                    cmb02_SendOne.Enabled = True
                    deleteTESTpfds()
                End If
            Else
                MsgBox("selected pdf is not correct: year and/or membernumber not right" & Chr(13) & _
                      "make new pdf in Word", , "mail with errors is send to " & txt01_EmailTREA.Text)
            End If
            cmb01_TestVerbindingTREA.Text = ""
        End If
    End Sub
    Private Sub cmd02_SendOneOK_Click(sender As System.Object, e As System.EventArgs) Handles cmd02_SendOneOK.Click
        Dim thisTest As String = ""
        Dim thisFrom As String = "TREA"
        rtb00_Message.Visible = False
        cmd02_SendOneOK.Enabled = False
        lvw03_ShowMembers.Items.Clear()
        lvw03_ShowMembers.Refresh()
        lvw03_ShowMembers.Visible = True
        lbl01_SentCounter.Text = 0
        lbl01_SentCounter.Refresh()
        lbl01_NotsentCounter.Text = 0
        lbl01_NotsentCounter.Refresh()
        If Me.rtb00_bigPdf.ForeColor <> Color.Red Then
            sendPdfs(thisTest, thisFrom, {CInt(cmb02_SendOne.SelectedItem)})
        Else
            MsgBox("selected pdf is not correct: year and/or membernumber not right" & Chr(13) & _
                  "make new pdf in Word", , "mail with errors is send to " & txt01_EmailTREA.Text)
        End If
    End Sub
    Private Sub cmd03_SendAll_Click(sender As System.Object, e As System.EventArgs) Handles cmd03_SendAll.Click
        Dim thisTest As String = ""
        Dim thisFrom As String = "TREA"
        rtb00_Message.Visible = False
        cmd03_SendAll.Enabled = False
        lvw03_ShowMembers.Items.Clear()
        lvw03_ShowMembers.Refresh()
        lvw03_ShowMembers.Visible = True
        lbl01_SentCounter.Text = 0
        lbl01_SentCounter.Refresh()
        lbl01_NotsentCounter.Text = 0
        lbl01_NotsentCounter.Refresh()
        If Me.rtb00_bigPdf.ForeColor <> Color.Red Then
            Dim strNumbersArray(cmb02_SendOne.Items.Count - 1) As String
            cmb02_SendOne.Items.CopyTo(strNumbersArray, 0)
            Dim intNumbersArray(cmb02_SendOne.Items.Count - 1) As Integer
            For i = 0 To UBound(strNumbersArray)
                intNumbersArray(i) = CInt(strNumbersArray(i))
            Next
            sendPdfs(thisTest, thisFrom, intNumbersArray)
        Else
            MsgBox("selected pdf is not correct: year and/or membernumber not right" & Chr(13) & _
                  "make new pdf in Word", , "mail with errors is send to " & txt01_EmailTREA.Text)
        End If
    End Sub

    Private Sub txt01_NumberICT_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt01_NumberICT.TextChanged

    End Sub
End Class

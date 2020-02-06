Imports System.Text
Module mod01SendFacturenEvents
    Public gstrBigPfdLink As String = ""
    Public gstrAdresIndicator As String = ""
    Public gstrSalutation As String = ""
    Public gstrFormulation As String = ""
    Public gstrCurrency As String = ""
    Public gAllValuesArray(,) As String = Nothing
    Public gintPageCount As Integer = 0
    Public Sub subCmd00_SplitPdf()
        gstrBigPfdLink = selectBigPdfLink()
        If gstrBigPfdLink = "" Then
            MsgBox("select pdf met n invoices" & Chr(13) & _
                    "if necessary create it in Office Word:", , "again")
            gstrBigPfdLink = selectBigPdfLink()
        End If
        If gstrBigPfdLink = "" Then
            MsgBox("... I assume you don't want to select a pdf ...", , "we are closing")
            frmSEIN.Close()
        End If
        If File.Exists(gstrBigPfdLink) = True Then
            predictIndicators(gstrBigPfdLink)
        End If
    End Sub
    Public Function makeAllValuesArray(ByVal myTest As String) As Array
        Dim tempTwoArray(gintPageCount - 1, 4) As String
        Dim thisSinglePdfContent As String
        Dim thisValuesArray(4)
        Dim thisSinglePfd As String
        tempTwoArray = Nothing
        For i = 0 To gintPageCount - 1
            thisSinglePfd = myTest & "invoice_" & (i + 1) & ".pdf"
            thisSinglePfd = My.Computer.FileSystem.GetParentPath(gstrBigPfdLink) & "\" & thisSinglePfd
            thisSinglePdfContent = GetAllTextFromPDF(thisSinglePfd)
            ReDim thisValuesArray(4)
            ReDim Preserve tempTwoArray(gintPageCount, 4)
            thisValuesArray = makeValuesArray(thisSinglePdfContent)
            For j = 0 To 4
                tempTwoArray(i, j) = CStr(thisValuesArray(j))
            Next j
        Next i
        Return tempTwoArray
    End Function
    Public Sub subCmd01_TestVerbindingICT(ByVal myTest As String)
        '0.1 makeAllValuesArray(n-1, 4)
        '0.2 controlAllValuesArray() 
        '0.21 if errors: fill listview with errors and send mail with errors to myFrom
        '0.22 if errors: fill listview with values
        Dim content As String
        Dim thisValuesArray(4) As String
        'Dim thisError As String
        'Dim thisPdfReady As Boolean = False
        Dim thisSentCounter As Integer
        Dim thisNotSentCounter As Integer
        ReDim gAllValuesArray(110, 4)

        Dim myNumber As String = ""           '0
        Dim myName As String = ""             '1     
        Dim myEmailAddress As String = ""     '2
        Dim myTotaalBedrag As String = ""     '3
        Dim myYear As String = ""             '4
        '1. search/make thisSinglePfd
        '===============
        '0.1 makeAllValuesArray(n-1, 4)
        Dim thisSinglePfd As String
        thisSinglePfd = myTest & "invoice_" & myNumber & ".pdf"
        thisSinglePfd = My.Computer.FileSystem.GetParentPath(gstrBigPfdLink) & "\" & thisSinglePfd

        If File.Exists(gstrBigPfdLink) = True Then
            SplitPdfByPages(gstrBigPfdLink, Replace(thisSinglePfd, myNumber, ""))   'in SplitPdfByPages: invoice_73.pdf 
        End If
        gAllValuesArray = makeAllValuesArray(myTest)

        '0.2 controlAllValuesArray() 
        controlAllValuesArray()

    End Sub
  
End Module
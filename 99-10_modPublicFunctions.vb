Module mod99PublicFunctions
    Public Function getFileDate(ByVal myFileLink As String) As Date
        getFileDate = Nothing
        Dim thisFileDate As Date
        thisFileDate = Nothing
        If System.IO.File.Exists(myFileLink) = True Then
            Dim fileInfo As System.IO.FileInfo
            fileInfo = My.Computer.FileSystem.GetFileInfo(myFileLink)
            thisFileDate = fileInfo.LastWriteTime
            Return thisFileDate
        End If
    End Function
   
    Public Function makeValuesArray(ByVal myText As String) As Array
        Dim tempArray() As String = Nothing
        Dim tempValue As String = ""
        Dim thisEndText As String = ""

        Dim thisNumber As String = ""           '0
        Dim thisName As String = ""             '1     
        Dim thisEmailAddress As String = ""     '2
        Dim thisTotaalBedrag As String = ""     '3
        Dim thisYear As String = ""             '4

        tempArray = Split(myText, "Aan:")
        If UBound(tempArray) = 1 Then
            tempValue = Trim(tempArray(1))
            tempArray = Nothing
            '
            tempArray = Split(tempValue, "Geachte")
            tempValue = Nothing
            If UBound(tempArray) = 1 Then
                thisEndText = tempArray(1)  'tijdelijk
                tempValue = Trim(tempArray(0))
                tempArray = Nothing
                tempArray = Split(tempValue, vbLf)
                thisName = Trim(tempArray(0))
                For i = 0 To UBound(tempArray)
                    If InStr(tempArray(i), "@") > 0 Or InStr(tempArray(i), "no email") > 0 Then
                        thisEmailAddress = Trim(tempArray(i))
                        Exit For
                    End If
                Next
                tempArray = Nothing
                tempValue = ""
                tempArray = Split(thisEndText, "factuur nummer")
                thisEndText = ""
                If UBound(tempArray) = 1 Then
                    tempValue = tempArray(1)
                    tempArray = Nothing
                    tempArray = Split(tempValue, vbLf)
                    tempValue = ""
                    If UBound(tempArray) > 4 Then
                        tempValue = Trim(tempArray(0))
                        For i = 0 To UBound(tempArray)
                            If IsNumeric(Trim(tempArray(i))) = True Then
                                thisTotaalBedrag = "€ " & Trim(tempArray(i))
                                Exit For
                            End If
                        Next
                        tempArray = Nothing
                        tempArray = Split(tempValue, "/")
                        If UBound(tempArray) = 1 Then
                            thisYear = Trim(tempArray(1))
                            thisNumber = Trim(tempArray(0))
                            thisNumber = Right(thisNumber, 3)
                            thisNumber = CStr(CInt(thisNumber))
                        End If
                    End If
                    tempArray = Nothing
                End If
            End If
        End If
        ReDim tempArray(4)
        tempArray(0) = thisNumber
        tempArray(1) = thisName
        tempArray(2) = thisEmailAddress
        tempArray(3) = thisTotaalBedrag
        tempArray(4) = thisYear
        Return tempArray
    End Function
    Public Function selectBigPdfLink() As String
        Dim tempValue As String
        tempValue = ""
        Using openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Title = "select pdf with n invoices"
            openFileDialog1.Filter = "pdfs (*.pdf)|*.pdf"
            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                tempValue = openFileDialog1.FileName
                frmSEIN.rtb00_bigPdf.Text = My.Computer.FileSystem.GetName(tempValue) & " in: " & vbLf & _
                My.Computer.FileSystem.GetParentPath(tempValue)
            End If
        End Using
        Return tempValue
    End Function
    Public Function checkURL(ByVal urltocheck As String)
        Dim url As New System.Uri("http://www." & urltocheck)
        Dim req As System.Net.WebRequest
        req = System.Net.WebRequest.Create(url)
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return True
        Catch ex As Exception
            req = Nothing
            Return False
        End Try
    End Function
End Module

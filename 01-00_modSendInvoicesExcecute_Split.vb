Module mod01SendFacturenExcecute_Split
    'download itextsharp.dll https://github.com/Eugenec139/VbAccessProject/blob/master/itextsharp.dll

    ''' <summary>
    ''' Split source pdf into multiple pdfs with specifc number of pages: here: 1
    ''' </summary>
    ''' <param name="sourcePdf">the full path to source pdf</param>
    ''' <param name="numOfPages">the number of pages each splitted pdf should contain</param>
    ''' <param name="baseNameOutPdf">the base file name (full path) for splitted pdfs.
    ''' The actual output pdf file names will be serialized. </param>
    ''' <remarks>The last splitted pdf may not have
    ''' the same number of pages as the rest, depending on the combination of number of pages in the source pdf 
    ''' and the number of target pages in each splitted pdf. For example, if the original pdf has 9 pages and it is to be 
    ''' splitted with 2 pages for each pdf, the last splitted pdf will have only 1 page while all others have 2 pages.</remarks>

    Public Sub SplitPdfByPages(ByVal sourcePdf As String, ByVal baseNameOutPdf As String)
        Dim doc As iTextSharp.text.Document = Nothing
        Dim pdfCpy As iTextSharp.text.pdf.PdfCopy = Nothing
        Dim page As iTextSharp.text.pdf.PdfImportedPage = Nothing

        Dim pages As Integer = 0  'overbodig, maar om gelijkenis met oorspr code te behouden
        If File.Exists(sourcePdf) = True Then
            Using oReader As New iTextSharp.text.pdf.PdfReader(sourcePdf)
                gintPageCount = oReader.NumberOfPages
                frmSEIN.rtb00_bigPdf.Text = gintPageCount & " pages in " & frmSEIN.rtb00_bigPdf.Text
                pages = gintPageCount
                If gintPageCount < pages Then   'redundant, but to maintain similarity with orig code
                    Throw New ArgumentException("Not enough pages in source pdf to split")   'redundant, but to maintain similarity with orig code
                Else
                    Dim n As Integer = gintPageCount \ pages 'number of pages of splitted pdfs: here: 1
                    Dim currentPage As Integer = 1
                    Dim ext As String = IO.Path.GetExtension(baseNameOutPdf)
                    Dim outfile As String = String.Empty
                    For i As Integer = 1 To pages
                        outfile = baseNameOutPdf.Replace(ext, i & ext)
                        doc = New iTextSharp.text.Document(oReader.GetPageSizeWithRotation(currentPage))
                        pdfCpy = New iTextSharp.text.pdf.PdfCopy(doc, New IO.FileStream(outfile, IO.FileMode.Create))
                        doc.Open()
                        If i < pages Then
                            For j As Integer = 1 To n
                                page = pdfCpy.GetImportedPage(oReader, currentPage)
                                pdfCpy.AddPage(page)
                                currentPage += 1
                            Next j
                        Else
                            For j As Integer = currentPage To gintPageCount
                                page = pdfCpy.GetImportedPage(oReader, j)
                                pdfCpy.AddPage(page)
                            Next j
                        End If
                        doc.Close()
                    Next
                End If
            End Using
        Else
            MsgBox("Can't find " & sourcePdf, , "not found")
        End If
    End Sub
    Public Function GetAllTextFromPDF(ByVal PdfFileName As String) As String
        Using oReader As New iTextSharp.text.pdf.PdfReader(PdfFileName)
            Dim sOut = ""
            For i = 1 To oReader.NumberOfPages
                Dim its As New iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy
                sOut &= iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(oReader, i, its)
            Next
            Return sOut
        End Using
    End Function 'download itextsharp.dll https://github.com/Eugenec139/VbAccessProject/blob/master/itextsharp.dll

End Module

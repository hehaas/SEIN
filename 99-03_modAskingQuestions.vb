Module mod99AskingQuestions
    '**************************************************************************   
    'alfabetische volgorde
    Function QuestionAppOntwikkeling() As MsgBoxResult
        QuestionAppOntwikkeling = _
        MsgBox("are you testing the app? " & Chr(13) & _
               "IF NOT: ""send 1 invoice"" and ""send all invoices OK"" should be disabled!!", _
               vbYesNo + vbExclamation, "testing app? ")
    End Function
    Function QuestionDeleteOldInvoices(ByVal myLink As String) As MsgBoxResult
        QuestionDeleteOldInvoices = _
        MsgBox("at least one of the invoices is older the the bif pdf-file you just selected " & Chr(13) & _
               myLink & Chr(13) & _
               "SEIN will delete the old split invoices" & Chr(13) & "do you agree?", _
               vbYesNo + vbExclamation, "delete old split invoices? ")
    End Function
    Function QuestionTestOK(ByVal myTestMail As String) As MsgBoxResult
        QuestionTestOK = _
        MsgBox("Has the test mail arrived correctly in " & myTestMail, _
                vbYesNo + vbExclamation, "satisfied ? ")
    End Function
  
End Module

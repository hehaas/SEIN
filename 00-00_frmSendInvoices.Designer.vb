<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSEIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSEIN))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmd00_Help = New System.Windows.Forms.Button()
        Me.cmd00_SplitPdf = New System.Windows.Forms.Button()
        Me.cmb01_TestVerbindingTREA = New System.Windows.Forms.ComboBox()
        Me.cmb01_TestVerbindingICT = New System.Windows.Forms.ComboBox()
        Me.txt01_PasswordTREA = New System.Windows.Forms.TextBox()
        Me.txt01_PasswordICT = New System.Windows.Forms.TextBox()
        Me.cmb00_AdresIndicator = New System.Windows.Forms.ComboBox()
        Me.cmb00_Salutation = New System.Windows.Forms.ComboBox()
        Me.cmb00_Currency = New System.Windows.Forms.ComboBox()
        Me.cmb00_Formulation = New System.Windows.Forms.ComboBox()
        Me.lbl00_Currency = New System.Windows.Forms.Label()
        Me.txt01_NumberICT = New System.Windows.Forms.TextBox()
        Me.txt01_NumberTREA = New System.Windows.Forms.TextBox()
        Me.rtb00_bigPdf = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.rtb00_Help = New System.Windows.Forms.RichTextBox()
        Me.lbl01_NotsentCounter = New System.Windows.Forms.Label()
        Me.lbl01_SentCounter = New System.Windows.Forms.Label()
        Me.cmd01_TestVerbindingOKTREA = New System.Windows.Forms.Button()
        Me.cmd01_TestVerbindingTREA = New System.Windows.Forms.Button()
        Me.cmb02_SendOne = New System.Windows.Forms.ComboBox()
        Me.cmd03_SendAll = New System.Windows.Forms.Button()
        Me.cmd02_SendOneOK = New System.Windows.Forms.Button()
        Me.cmd01_TestVerbindingOKICT = New System.Windows.Forms.Button()
        Me.cmd02_SendOne = New System.Windows.Forms.Button()
        Me.cmd01_TestVerbindingICT = New System.Windows.Forms.Button()
        Me.lvw03_ShowMembers = New System.Windows.Forms.ListView()
        Me.nr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.membername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.year = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.result = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt01_EmailICT = New System.Windows.Forms.TextBox()
        Me.txt01_EmailTREA = New System.Windows.Forms.TextBox()
        Me.lbl00_AdresIndicator = New System.Windows.Forms.Label()
        Me.lbl00_Salutation = New System.Windows.Forms.Label()
        Me.lbl00_Formulation = New System.Windows.Forms.Label()
        Me.rtb00_Message = New System.Windows.Forms.RichTextBox()
        Me.cmd00_MessageOK = New System.Windows.Forms.Button()
        Me.cmd00_MessageEdit = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'cmd00_Help
        '
        Me.cmd00_Help.AutoSize = True
        Me.cmd00_Help.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmd00_Help.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd00_Help.Location = New System.Drawing.Point(649, 9)
        Me.cmd00_Help.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd00_Help.Name = "cmd00_Help"
        Me.cmd00_Help.Size = New System.Drawing.Size(59, 49)
        Me.cmd00_Help.TabIndex = 27
        Me.cmd00_Help.Text = "?"
        Me.ToolTip1.SetToolTip(Me.cmd00_Help, "Help Aan/Uit")
        Me.cmd00_Help.UseVisualStyleBackColor = False
        '
        'cmd00_SplitPdf
        '
        Me.cmd00_SplitPdf.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmd00_SplitPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd00_SplitPdf.Location = New System.Drawing.Point(9, 9)
        Me.cmd00_SplitPdf.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd00_SplitPdf.Name = "cmd00_SplitPdf"
        Me.cmd00_SplitPdf.Size = New System.Drawing.Size(635, 49)
        Me.cmd00_SplitPdf.TabIndex = 26
        Me.cmd00_SplitPdf.Text = "test split pdf in pages"
        Me.ToolTip1.SetToolTip(Me.cmd00_SplitPdf, "test connection treasurer first")
        Me.cmd00_SplitPdf.UseVisualStyleBackColor = False
        '
        'cmb01_TestVerbindingTREA
        '
        Me.cmb01_TestVerbindingTREA.BackColor = System.Drawing.Color.White
        Me.cmb01_TestVerbindingTREA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb01_TestVerbindingTREA.Enabled = False
        Me.cmb01_TestVerbindingTREA.FormattingEnabled = True
        Me.cmb01_TestVerbindingTREA.Items.AddRange(New Object() {"number treasurer", "number ictassistent + number treasurer"})
        Me.cmb01_TestVerbindingTREA.Location = New System.Drawing.Point(421, 565)
        Me.cmb01_TestVerbindingTREA.Name = "cmb01_TestVerbindingTREA"
        Me.cmb01_TestVerbindingTREA.Size = New System.Drawing.Size(161, 28)
        Me.cmb01_TestVerbindingTREA.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.cmb01_TestVerbindingTREA, "send test to treasurer ( + ict-assistent)")
        '
        'cmb01_TestVerbindingICT
        '
        Me.cmb01_TestVerbindingICT.BackColor = System.Drawing.Color.White
        Me.cmb01_TestVerbindingICT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb01_TestVerbindingICT.Enabled = False
        Me.cmb01_TestVerbindingICT.FormattingEnabled = True
        Me.cmb01_TestVerbindingICT.Items.AddRange(New Object() {"number ictassistent", "number ictassistent + number treasurer"})
        Me.cmb01_TestVerbindingICT.Location = New System.Drawing.Point(420, 500)
        Me.cmb01_TestVerbindingICT.Name = "cmb01_TestVerbindingICT"
        Me.cmb01_TestVerbindingICT.Size = New System.Drawing.Size(161, 28)
        Me.cmb01_TestVerbindingICT.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.cmb01_TestVerbindingICT, "send test to ict-assistent ( + treasurer)")
        Me.cmb01_TestVerbindingICT.UseWaitCursor = True
        '
        'txt01_PasswordTREA
        '
        Me.txt01_PasswordTREA.Enabled = False
        Me.txt01_PasswordTREA.Location = New System.Drawing.Point(229, 567)
        Me.txt01_PasswordTREA.Name = "txt01_PasswordTREA"
        Me.txt01_PasswordTREA.Size = New System.Drawing.Size(186, 26)
        Me.txt01_PasswordTREA.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.txt01_PasswordTREA, "here Email App Password for gmail account" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://support.google.com/accounts/an" & _
        "swer/185833?hl=en" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "format: abcd efgh ijkl mnop")
        '
        'txt01_PasswordICT
        '
        Me.txt01_PasswordICT.Enabled = False
        Me.txt01_PasswordICT.Location = New System.Drawing.Point(230, 502)
        Me.txt01_PasswordICT.Name = "txt01_PasswordICT"
        Me.txt01_PasswordICT.Size = New System.Drawing.Size(185, 26)
        Me.txt01_PasswordICT.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.txt01_PasswordICT, "here Email App Password for gmail account" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "https://support.google.com/accounts/an" & _
        "swer/185833?hl=en" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "format: abcd efgh ijkl mnop")
        '
        'cmb00_AdresIndicator
        '
        Me.cmb00_AdresIndicator.FormattingEnabled = True
        Me.cmb00_AdresIndicator.Items.AddRange(New Object() {"To: (A.B. Smith)", "Aan: (C.D. Jansen)", "Zu: (E.F. Schmidt)", "Á: (G.H. Legrand)"})
        Me.cmb00_AdresIndicator.Location = New System.Drawing.Point(141, 122)
        Me.cmb00_AdresIndicator.Name = "cmb00_AdresIndicator"
        Me.cmb00_AdresIndicator.Size = New System.Drawing.Size(196, 28)
        Me.cmb00_AdresIndicator.TabIndex = 47
        Me.cmb00_AdresIndicator.Text = "type or select"
        Me.ToolTip1.SetToolTip(Me.cmb00_AdresIndicator, "select or type the indicator of your adresshead in the pdf")
        '
        'cmb00_Salutation
        '
        Me.cmb00_Salutation.FormattingEnabled = True
        Me.cmb00_Salutation.Items.AddRange(New Object() {"Dear (A.B. Smith),", "Geachte (heer C.D. Jansen),", "Beste (heer C.D. Jansen),", "Sehr geehrte (Frau E.F. Schmidt),", "Geehrte (Frau E.F. Schmidt),", "Liebe (Frau E.F. Schmidt),", "Cher (M. G.H. Legrand),"})
        Me.cmb00_Salutation.Location = New System.Drawing.Point(141, 154)
        Me.cmb00_Salutation.Name = "cmb00_Salutation"
        Me.cmb00_Salutation.Size = New System.Drawing.Size(196, 28)
        Me.cmb00_Salutation.TabIndex = 49
        Me.cmb00_Salutation.Text = "type or select"
        Me.ToolTip1.SetToolTip(Me.cmb00_Salutation, "select or type the salutation in the pdf")
        '
        'cmb00_Currency
        '
        Me.cmb00_Currency.FormattingEnabled = True
        Me.cmb00_Currency.Items.AddRange(New Object() {"€", "$", "£"})
        Me.cmb00_Currency.Location = New System.Drawing.Point(497, 154)
        Me.cmb00_Currency.Name = "cmb00_Currency"
        Me.cmb00_Currency.Size = New System.Drawing.Size(209, 28)
        Me.cmb00_Currency.TabIndex = 53
        Me.cmb00_Currency.Text = "type or select"
        Me.ToolTip1.SetToolTip(Me.cmb00_Currency, "fill in membernumbers of ICT-assistent (+ treasurer)")
        '
        'cmb00_Formulation
        '
        Me.cmb00_Formulation.FormattingEnabled = True
        Me.cmb00_Formulation.Items.AddRange(New Object() {"stating invoice number (100037/2020)", "onder vermelding van factuur nummer (100073/2020)", "indiquant le numéro de facture (100037/2020)", "unter Angabe der Rechnungsnummer (100037/2020)"})
        Me.cmb00_Formulation.Location = New System.Drawing.Point(497, 122)
        Me.cmb00_Formulation.Name = "cmb00_Formulation"
        Me.cmb00_Formulation.Size = New System.Drawing.Size(209, 28)
        Me.cmb00_Formulation.TabIndex = 51
        Me.cmb00_Formulation.Text = "type or select"
        Me.ToolTip1.SetToolTip(Me.cmb00_Formulation, "select or type the formulation used in the pdf")
        '
        'lbl00_Currency
        '
        Me.lbl00_Currency.AutoSize = True
        Me.lbl00_Currency.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbl00_Currency.Location = New System.Drawing.Point(366, 154)
        Me.lbl00_Currency.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl00_Currency.MinimumSize = New System.Drawing.Size(128, 28)
        Me.lbl00_Currency.Name = "lbl00_Currency"
        Me.lbl00_Currency.Padding = New System.Windows.Forms.Padding(3)
        Me.lbl00_Currency.Size = New System.Drawing.Size(128, 28)
        Me.lbl00_Currency.TabIndex = 52
        Me.lbl00_Currency.Text = "currency:"
        Me.ToolTip1.SetToolTip(Me.lbl00_Currency, "select or type currency just before total-amount of invoice in your adresshead in" & _
        " the pdf")
        '
        'txt01_NumberICT
        '
        Me.txt01_NumberICT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt01_NumberICT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt01_NumberICT.Location = New System.Drawing.Point(421, 473)
        Me.txt01_NumberICT.Name = "txt01_NumberICT"
        Me.txt01_NumberICT.Size = New System.Drawing.Size(160, 26)
        Me.txt01_NumberICT.TabIndex = 55
        Me.txt01_NumberICT.Text = "number ict-assistent"
        Me.ToolTip1.SetToolTip(Me.txt01_NumberICT, "fill in membernumber of ICT-assistent: testmail will be send to personal email of" & _
        " ictassistent")
        '
        'txt01_NumberTREA
        '
        Me.txt01_NumberTREA.Enabled = False
        Me.txt01_NumberTREA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt01_NumberTREA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt01_NumberTREA.Location = New System.Drawing.Point(420, 537)
        Me.txt01_NumberTREA.Name = "txt01_NumberTREA"
        Me.txt01_NumberTREA.Size = New System.Drawing.Size(162, 26)
        Me.txt01_NumberTREA.TabIndex = 56
        Me.txt01_NumberTREA.Text = "number treasurer"
        Me.ToolTip1.SetToolTip(Me.txt01_NumberTREA, "fill in membernumber of treasurer: testmail can also be send to personal email of" & _
        " treasurer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'rtb00_bigPdf
        '
        Me.rtb00_bigPdf.BackColor = System.Drawing.Color.CornflowerBlue
        Me.rtb00_bigPdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtb00_bigPdf.Enabled = False
        Me.rtb00_bigPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb00_bigPdf.Location = New System.Drawing.Point(9, 63)
        Me.rtb00_bigPdf.Margin = New System.Windows.Forms.Padding(0)
        Me.rtb00_bigPdf.Name = "rtb00_bigPdf"
        Me.rtb00_bigPdf.ReadOnly = True
        Me.rtb00_bigPdf.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtb00_bigPdf.Size = New System.Drawing.Size(697, 55)
        Me.rtb00_bigPdf.TabIndex = 25
        Me.rtb00_bigPdf.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'rtb00_Help
        '
        Me.rtb00_Help.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rtb00_Help.Location = New System.Drawing.Point(9, 9)
        Me.rtb00_Help.Margin = New System.Windows.Forms.Padding(0)
        Me.rtb00_Help.Name = "rtb00_Help"
        Me.rtb00_Help.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtb00_Help.Size = New System.Drawing.Size(0, 0)
        Me.rtb00_Help.TabIndex = 24
        Me.rtb00_Help.Text = resources.GetString("rtb00_Help.Text")
        Me.rtb00_Help.Visible = False
        Me.rtb00_Help.WordWrap = False
        '
        'lbl01_NotsentCounter
        '
        Me.lbl01_NotsentCounter.AutoSize = True
        Me.lbl01_NotsentCounter.BackColor = System.Drawing.SystemColors.Control
        Me.lbl01_NotsentCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl01_NotsentCounter.Location = New System.Drawing.Point(420, 723)
        Me.lbl01_NotsentCounter.MinimumSize = New System.Drawing.Size(40, 2)
        Me.lbl01_NotsentCounter.Name = "lbl01_NotsentCounter"
        Me.lbl01_NotsentCounter.Size = New System.Drawing.Size(40, 22)
        Me.lbl01_NotsentCounter.TabIndex = 42
        Me.lbl01_NotsentCounter.Text = "0"
        '
        'lbl01_SentCounter
        '
        Me.lbl01_SentCounter.AutoSize = True
        Me.lbl01_SentCounter.BackColor = System.Drawing.SystemColors.Control
        Me.lbl01_SentCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl01_SentCounter.Location = New System.Drawing.Point(239, 723)
        Me.lbl01_SentCounter.MinimumSize = New System.Drawing.Size(40, 2)
        Me.lbl01_SentCounter.Name = "lbl01_SentCounter"
        Me.lbl01_SentCounter.Size = New System.Drawing.Size(40, 22)
        Me.lbl01_SentCounter.TabIndex = 41
        Me.lbl01_SentCounter.Text = "0"
        '
        'cmd01_TestVerbindingOKTREA
        '
        Me.cmd01_TestVerbindingOKTREA.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmd01_TestVerbindingOKTREA.Enabled = False
        Me.cmd01_TestVerbindingOKTREA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd01_TestVerbindingOKTREA.Location = New System.Drawing.Point(588, 536)
        Me.cmd01_TestVerbindingOKTREA.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd01_TestVerbindingOKTREA.Name = "cmd01_TestVerbindingOKTREA"
        Me.cmd01_TestVerbindingOKTREA.Size = New System.Drawing.Size(122, 60)
        Me.cmd01_TestVerbindingOKTREA.TabIndex = 37
        Me.cmd01_TestVerbindingOKTREA.Text = "test now from treasurer"
        Me.cmd01_TestVerbindingOKTREA.UseVisualStyleBackColor = False
        '
        'cmd01_TestVerbindingTREA
        '
        Me.cmd01_TestVerbindingTREA.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmd01_TestVerbindingTREA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd01_TestVerbindingTREA.Location = New System.Drawing.Point(9, 535)
        Me.cmd01_TestVerbindingTREA.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd01_TestVerbindingTREA.Name = "cmd01_TestVerbindingTREA"
        Me.cmd01_TestVerbindingTREA.Size = New System.Drawing.Size(215, 60)
        Me.cmd01_TestVerbindingTREA.TabIndex = 36
        Me.cmd01_TestVerbindingTREA.Text = "test connection treasurer"
        Me.cmd01_TestVerbindingTREA.UseVisualStyleBackColor = False
        '
        'cmb02_SendOne
        '
        Me.cmb02_SendOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb02_SendOne.FormatString = "N0"
        Me.cmb02_SendOne.Location = New System.Drawing.Point(421, 611)
        Me.cmb02_SendOne.Name = "cmb02_SendOne"
        Me.cmb02_SendOne.Size = New System.Drawing.Size(161, 28)
        Me.cmb02_SendOne.TabIndex = 35
        '
        'cmd03_SendAll
        '
        Me.cmd03_SendAll.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmd03_SendAll.Enabled = False
        Me.cmd03_SendAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd03_SendAll.Location = New System.Drawing.Point(10, 661)
        Me.cmd03_SendAll.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd03_SendAll.Name = "cmd03_SendAll"
        Me.cmd03_SendAll.Size = New System.Drawing.Size(700, 60)
        Me.cmd03_SendAll.TabIndex = 31
        Me.cmd03_SendAll.Text = "send all invoices OK "
        Me.cmd03_SendAll.UseVisualStyleBackColor = False
        '
        'cmd02_SendOneOK
        '
        Me.cmd02_SendOneOK.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmd02_SendOneOK.Enabled = False
        Me.cmd02_SendOneOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd02_SendOneOK.Location = New System.Drawing.Point(588, 598)
        Me.cmd02_SendOneOK.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd02_SendOneOK.Name = "cmd02_SendOneOK"
        Me.cmd02_SendOneOK.Size = New System.Drawing.Size(122, 60)
        Me.cmd02_SendOneOK.TabIndex = 33
        Me.cmd02_SendOneOK.Text = "send 1 invoice OK"
        Me.cmd02_SendOneOK.UseVisualStyleBackColor = False
        '
        'cmd01_TestVerbindingOKICT
        '
        Me.cmd01_TestVerbindingOKICT.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmd01_TestVerbindingOKICT.Enabled = False
        Me.cmd01_TestVerbindingOKICT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd01_TestVerbindingOKICT.Location = New System.Drawing.Point(588, 472)
        Me.cmd01_TestVerbindingOKICT.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd01_TestVerbindingOKICT.Name = "cmd01_TestVerbindingOKICT"
        Me.cmd01_TestVerbindingOKICT.Size = New System.Drawing.Size(122, 60)
        Me.cmd01_TestVerbindingOKICT.TabIndex = 32
        Me.cmd01_TestVerbindingOKICT.Text = "test now from ict-assistent"
        Me.cmd01_TestVerbindingOKICT.UseVisualStyleBackColor = False
        '
        'cmd02_SendOne
        '
        Me.cmd02_SendOne.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmd02_SendOne.Enabled = False
        Me.cmd02_SendOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd02_SendOne.Location = New System.Drawing.Point(9, 598)
        Me.cmd02_SendOne.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd02_SendOne.Name = "cmd02_SendOne"
        Me.cmd02_SendOne.Size = New System.Drawing.Size(405, 60)
        Me.cmd02_SendOne.TabIndex = 30
        Me.cmd02_SendOne.Text = "only 1 invoice"
        Me.cmd02_SendOne.UseVisualStyleBackColor = False
        '
        'cmd01_TestVerbindingICT
        '
        Me.cmd01_TestVerbindingICT.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmd01_TestVerbindingICT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd01_TestVerbindingICT.Location = New System.Drawing.Point(9, 471)
        Me.cmd01_TestVerbindingICT.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd01_TestVerbindingICT.Name = "cmd01_TestVerbindingICT"
        Me.cmd01_TestVerbindingICT.Size = New System.Drawing.Size(215, 60)
        Me.cmd01_TestVerbindingICT.TabIndex = 28
        Me.cmd01_TestVerbindingICT.Text = "test connection ict-assistent"
        Me.cmd01_TestVerbindingICT.UseVisualStyleBackColor = False
        '
        'lvw03_ShowMembers
        '
        Me.lvw03_ShowMembers.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lvw03_ShowMembers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nr, Me.membername, Me.email, Me.total, Me.year, Me.result})
        Me.lvw03_ShowMembers.GridLines = True
        Me.lvw03_ShowMembers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvw03_ShowMembers.HideSelection = False
        Me.lvw03_ShowMembers.HoverSelection = True
        Me.lvw03_ShowMembers.Location = New System.Drawing.Point(8, 188)
        Me.lvw03_ShowMembers.MultiSelect = False
        Me.lvw03_ShowMembers.Name = "lvw03_ShowMembers"
        Me.lvw03_ShowMembers.Size = New System.Drawing.Size(699, 274)
        Me.lvw03_ShowMembers.TabIndex = 43
        Me.lvw03_ShowMembers.UseCompatibleStateImageBehavior = False
        Me.lvw03_ShowMembers.View = System.Windows.Forms.View.Details
        '
        'nr
        '
        Me.nr.Text = "nr"
        Me.nr.Width = 42
        '
        'membername
        '
        Me.membername.Text = "membername"
        Me.membername.Width = 173
        '
        'email
        '
        Me.email.Text = "email"
        Me.email.Width = 167
        '
        'total
        '
        Me.total.Text = "total"
        Me.total.Width = 91
        '
        'year
        '
        Me.year.Text = "year"
        Me.year.Width = 88
        '
        'result
        '
        Me.result.Text = "result"
        Me.result.Width = 85
        '
        'txt01_EmailICT
        '
        Me.txt01_EmailICT.Enabled = False
        Me.txt01_EmailICT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt01_EmailICT.Location = New System.Drawing.Point(230, 473)
        Me.txt01_EmailICT.Name = "txt01_EmailICT"
        Me.txt01_EmailICT.Size = New System.Drawing.Size(185, 26)
        Me.txt01_EmailICT.TabIndex = 44
        Me.txt01_EmailICT.Text = "[ictassistent]@gmail.com"
        '
        'txt01_EmailTREA
        '
        Me.txt01_EmailTREA.Enabled = False
        Me.txt01_EmailTREA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt01_EmailTREA.Location = New System.Drawing.Point(229, 537)
        Me.txt01_EmailTREA.Name = "txt01_EmailTREA"
        Me.txt01_EmailTREA.Size = New System.Drawing.Size(185, 26)
        Me.txt01_EmailTREA.TabIndex = 45
        Me.txt01_EmailTREA.Text = "[treasurer]@gmail.com"
        '
        'lbl00_AdresIndicator
        '
        Me.lbl00_AdresIndicator.AutoSize = True
        Me.lbl00_AdresIndicator.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbl00_AdresIndicator.Location = New System.Drawing.Point(10, 122)
        Me.lbl00_AdresIndicator.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl00_AdresIndicator.MinimumSize = New System.Drawing.Size(128, 28)
        Me.lbl00_AdresIndicator.Name = "lbl00_AdresIndicator"
        Me.lbl00_AdresIndicator.Padding = New System.Windows.Forms.Padding(3)
        Me.lbl00_AdresIndicator.Size = New System.Drawing.Size(128, 28)
        Me.lbl00_AdresIndicator.TabIndex = 46
        Me.lbl00_AdresIndicator.Text = "adres-indicator: "
        '
        'lbl00_Salutation
        '
        Me.lbl00_Salutation.AutoSize = True
        Me.lbl00_Salutation.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbl00_Salutation.Location = New System.Drawing.Point(10, 154)
        Me.lbl00_Salutation.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl00_Salutation.MinimumSize = New System.Drawing.Size(128, 28)
        Me.lbl00_Salutation.Name = "lbl00_Salutation"
        Me.lbl00_Salutation.Padding = New System.Windows.Forms.Padding(3)
        Me.lbl00_Salutation.Size = New System.Drawing.Size(128, 28)
        Me.lbl00_Salutation.TabIndex = 48
        Me.lbl00_Salutation.Text = "salutation:"
        '
        'lbl00_Formulation
        '
        Me.lbl00_Formulation.AutoSize = True
        Me.lbl00_Formulation.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbl00_Formulation.Location = New System.Drawing.Point(366, 122)
        Me.lbl00_Formulation.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl00_Formulation.MinimumSize = New System.Drawing.Size(128, 28)
        Me.lbl00_Formulation.Name = "lbl00_Formulation"
        Me.lbl00_Formulation.Padding = New System.Windows.Forms.Padding(3)
        Me.lbl00_Formulation.Size = New System.Drawing.Size(128, 28)
        Me.lbl00_Formulation.TabIndex = 50
        Me.lbl00_Formulation.Text = "in invoice: "
        '
        'rtb00_Message
        '
        Me.rtb00_Message.BackColor = System.Drawing.Color.White
        Me.rtb00_Message.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb00_Message.ForeColor = System.Drawing.Color.Black
        Me.rtb00_Message.HideSelection = False
        Me.rtb00_Message.Location = New System.Drawing.Point(9, 190)
        Me.rtb00_Message.Name = "rtb00_Message"
        Me.rtb00_Message.Size = New System.Drawing.Size(699, 274)
        Me.rtb00_Message.TabIndex = 54
        Me.rtb00_Message.Text = ""
        '
        'cmd00_MessageOK
        '
        Me.cmd00_MessageOK.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmd00_MessageOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd00_MessageOK.Location = New System.Drawing.Point(586, 406)
        Me.cmd00_MessageOK.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd00_MessageOK.Name = "cmd00_MessageOK"
        Me.cmd00_MessageOK.Size = New System.Drawing.Size(122, 58)
        Me.cmd00_MessageOK.TabIndex = 57
        Me.cmd00_MessageOK.Text = "text of email OK"
        Me.cmd00_MessageOK.UseVisualStyleBackColor = False
        '
        'cmd00_MessageEdit
        '
        Me.cmd00_MessageEdit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmd00_MessageEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd00_MessageEdit.Location = New System.Drawing.Point(583, 406)
        Me.cmd00_MessageEdit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmd00_MessageEdit.Name = "cmd00_MessageEdit"
        Me.cmd00_MessageEdit.Size = New System.Drawing.Size(122, 58)
        Me.cmd00_MessageEdit.TabIndex = 58
        Me.cmd00_MessageEdit.Text = "edit text of email"
        Me.cmd00_MessageEdit.UseVisualStyleBackColor = False
        Me.cmd00_MessageEdit.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 747)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(697, 29)
        Me.ProgressBar1.TabIndex = 29
        '
        'frmSEIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(718, 787)
        Me.Controls.Add(Me.cmd00_MessageOK)
        Me.Controls.Add(Me.cmd00_MessageEdit)
        Me.Controls.Add(Me.txt01_NumberTREA)
        Me.Controls.Add(Me.txt01_NumberICT)
        Me.Controls.Add(Me.rtb00_Message)
        Me.Controls.Add(Me.cmb00_Currency)
        Me.Controls.Add(Me.lbl00_Currency)
        Me.Controls.Add(Me.cmb00_Formulation)
        Me.Controls.Add(Me.lbl00_Formulation)
        Me.Controls.Add(Me.cmb00_Salutation)
        Me.Controls.Add(Me.lbl00_Salutation)
        Me.Controls.Add(Me.cmb00_AdresIndicator)
        Me.Controls.Add(Me.lbl00_AdresIndicator)
        Me.Controls.Add(Me.txt01_EmailTREA)
        Me.Controls.Add(Me.txt01_EmailICT)
        Me.Controls.Add(Me.lvw03_ShowMembers)
        Me.Controls.Add(Me.lbl01_NotsentCounter)
        Me.Controls.Add(Me.lbl01_SentCounter)
        Me.Controls.Add(Me.txt01_PasswordTREA)
        Me.Controls.Add(Me.txt01_PasswordICT)
        Me.Controls.Add(Me.cmb01_TestVerbindingTREA)
        Me.Controls.Add(Me.cmd01_TestVerbindingOKTREA)
        Me.Controls.Add(Me.cmd01_TestVerbindingTREA)
        Me.Controls.Add(Me.cmb02_SendOne)
        Me.Controls.Add(Me.cmb01_TestVerbindingICT)
        Me.Controls.Add(Me.cmd02_SendOneOK)
        Me.Controls.Add(Me.cmd01_TestVerbindingOKICT)
        Me.Controls.Add(Me.cmd03_SendAll)
        Me.Controls.Add(Me.cmd02_SendOne)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cmd01_TestVerbindingICT)
        Me.Controls.Add(Me.rtb00_Help)
        Me.Controls.Add(Me.cmd00_SplitPdf)
        Me.Controls.Add(Me.cmd00_Help)
        Me.Controls.Add(Me.rtb00_bigPdf)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmSEIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEin INvoices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents rtb00_bigPdf As System.Windows.Forms.RichTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmd00_Help As System.Windows.Forms.Button
    Friend WithEvents rtb00_Help As System.Windows.Forms.RichTextBox
    Friend WithEvents cmd00_SplitPdf As System.Windows.Forms.Button
    Friend WithEvents lbl01_NotsentCounter As System.Windows.Forms.Label
    Friend WithEvents lbl01_SentCounter As System.Windows.Forms.Label
    Friend WithEvents txt01_PasswordTREA As System.Windows.Forms.TextBox
    Friend WithEvents txt01_PasswordICT As System.Windows.Forms.TextBox
    Friend WithEvents cmb01_TestVerbindingTREA As System.Windows.Forms.ComboBox
    Friend WithEvents cmd01_TestVerbindingOKTREA As System.Windows.Forms.Button
    Friend WithEvents cmd01_TestVerbindingTREA As System.Windows.Forms.Button
    Friend WithEvents cmb02_SendOne As System.Windows.Forms.ComboBox
    Friend WithEvents cmb01_TestVerbindingICT As System.Windows.Forms.ComboBox
    Friend WithEvents cmd03_SendAll As System.Windows.Forms.Button
    Friend WithEvents cmd02_SendOneOK As System.Windows.Forms.Button
    Friend WithEvents cmd01_TestVerbindingOKICT As System.Windows.Forms.Button
    Friend WithEvents cmd02_SendOne As System.Windows.Forms.Button
    Friend WithEvents cmd01_TestVerbindingICT As System.Windows.Forms.Button
    Friend WithEvents lvw03_ShowMembers As System.Windows.Forms.ListView
    Friend WithEvents nr As System.Windows.Forms.ColumnHeader
    Friend WithEvents membername As System.Windows.Forms.ColumnHeader
    Friend WithEvents email As System.Windows.Forms.ColumnHeader
    Friend WithEvents total As System.Windows.Forms.ColumnHeader
    Friend WithEvents year As System.Windows.Forms.ColumnHeader
    Friend WithEvents result As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt01_EmailICT As System.Windows.Forms.TextBox
    Friend WithEvents txt01_EmailTREA As System.Windows.Forms.TextBox
    Friend WithEvents lbl00_AdresIndicator As System.Windows.Forms.Label
    Friend WithEvents cmb00_AdresIndicator As System.Windows.Forms.ComboBox
    Friend WithEvents cmb00_Salutation As System.Windows.Forms.ComboBox
    Friend WithEvents lbl00_Salutation As System.Windows.Forms.Label
    Friend WithEvents cmb00_Currency As System.Windows.Forms.ComboBox
    Friend WithEvents lbl00_Currency As System.Windows.Forms.Label
    Friend WithEvents cmb00_Formulation As System.Windows.Forms.ComboBox
    Friend WithEvents lbl00_Formulation As System.Windows.Forms.Label
    Friend WithEvents rtb00_Message As System.Windows.Forms.RichTextBox
    Friend WithEvents txt01_NumberICT As System.Windows.Forms.TextBox
    Friend WithEvents txt01_NumberTREA As System.Windows.Forms.TextBox
    Friend WithEvents cmd00_MessageOK As System.Windows.Forms.Button
    Friend WithEvents cmd00_MessageEdit As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class

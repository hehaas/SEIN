# SEIN
SEnd INvoices: email to allotment members with invoice as pdf attachment

  '*****************************************************************************

  'Purpose   send email to allotment members with invoice as pdf attachment
  
  'Inputs    1 pdf with n invoices: invoice_(n).pdf (made in Office Word)
  
  'Assumes   iText software: itextpdf.com  [itextsharp.dll] 
  
  'Assumes   invoice_(n).pdf should contain certain elements, see below
  
  'Results   n separate pdf's, invoice_(i).pdf in same folder as invoice_(n).pdf	
  
  'Results   send mails in Sendbox treasurer + Inbox garden club members
  
  'Results   if notsend: in Inbox treasurer: NOT SEND: invoice_(i).pdf
  
  '***************************************************************************** 

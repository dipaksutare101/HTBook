Module Module1

    Public ServerName As String = String.Empty
    Public UseWindowsAuthentication As Boolean = False
    Public DataBase As String = String.Empty
    Public DbUser As String = String.Empty
    Public dbPass As String = String.Empty
    Public ReportPath As String = String.Empty
    Public IsQuotationNew As Boolean = False
    Public IsStateValidationRequired As Boolean = False

    Public ConnString As String

    Public SupplierId As Long
    Public FindId As Integer
    Public ViewType As String
    Public TermsConditions As String

    Public PartyId As Integer
    Public IsLabour As Boolean = False
    Public InwardId As Integer

    Public SalesID As Integer
    Public SelectedCustomerID As Int64
    Public SelectedRowIndex As Integer
    Public SelectedProductID As Int64
    Public IsAgencySales As Boolean = False
    Public SaleBillPrefix As String

    Public RequestModel As String
    Public SelectedValue As Integer
    Public SelectedText As String

End Module

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmSalesBillReport
    Dim Kailash As New DataAccessLayer
    Dim MyDataSet As New DataSet

    Private Sub FrmSalesBillReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kailash.FillComboDataSource("Select CustomerID, CustomerName From dbo.Customers Where CompanyID = 1", cmbCustomer, String.Empty)
        chkIsParekhAgency.Checked = False
        GetSalesList()
    End Sub

    Public Sub GetSalesList()
        Dim dtSales As DataTable
        dgvSalesbill.DataSource = dtSales
        Dim _fromDate As String = "", _toDate As String = ""
        If dtpFromDate.Checked Then
            _fromDate = dtpFromDate.Value.ToString("dd-MMM-yyyy")
        End If
        If dtpToDate.Checked Then
            _toDate = dtpToDate.Value.ToString("dd-MMM-yyyy")
        End If

        Dim salesString As String = "spSales_GetList 0,'" & _fromDate & "','" & _toDate & "'," & cmbCustomer.SelectedValue & ",'" & txtSearchText.Text & "',1," & chkIsParekhAgency.Checked & ""
        dtSales = Kailash.ExecuteDatatable(salesString)
        dgvSalesbill.DataSource = dtSales
        If Not dtSales Is Nothing And dtSales.Rows.Count > 0 Then
            dgvSalesbill.DataSource = dtSales

            Me.dgvSalesbill.Columns("SalesID").Visible = False
            Me.dgvSalesbill.Columns("CompanyID").Visible = False

            Me.dgvSalesbill.Columns("SalesNo").HeaderText = "Bill No"
            Me.dgvSalesbill.Columns("SalesNo").Width = 100
            Me.dgvSalesbill.Columns("SaleDate").Width = 100
            Me.dgvSalesbill.Columns("CustomerName").Width = 300
            Me.dgvSalesbill.Columns("NetAmount").Width = 200
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        FrmSalesBillReport_Load(Nothing, Nothing)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        GetSalesList()
    End Sub

    Private Sub txtSearchText_TextChanged(sender As Object, e As EventArgs) Handles txtSearchText.TextChanged
        GetSalesList()
    End Sub

    Private Sub dgvSalesbill_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSalesbill.CellMouseDoubleClick
        FindId = dgvSalesbill.Rows(e.RowIndex).Cells("SalesID").Value
        Dim frmRetailSell As New frmRetailSell
        frmRetailSell.MdiParent = Frmmain
        frmRetailSell.StartPosition = FormStartPosition.CenterScreen
        frmRetailSell.Show()
    End Sub

    Private Sub dtpFromDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpFromDate.ValueChanged
        dtpToDate.MinDate = dtpFromDate.Value
    End Sub

    Private Sub dgvSalesbill_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSalesbill.KeyDown
        Dim iRow = dgvSalesbill.CurrentCell.RowIndex
        FindId = dgvSalesbill.Rows(iRow).Cells("SalesID").Value

        If e.KeyCode = Keys.F11 Then
            Print(FindId)
        ElseIf e.KeyCode = Keys.F2 Then
            Dim frmRetailSell As New frmRetailSell
            frmRetailSell.MdiParent = Frmmain
            frmRetailSell.StartPosition = FormStartPosition.CenterScreen
            frmRetailSell.Show()
        ElseIf e.KeyCode = Keys.F4 Then
            AddSalesLog(FindId, 2)
        ElseIf e.KeyCode = Keys.F6 Then
            AddSalesLog(FindId, 1)
        End If

        'FindId = dgvSalesbill.Rows(e.KeyCode).Cells("SalesID").Value

    End Sub

    Public Sub AddSalesLog(ByVal salesId As Integer, ByVal action As Integer)
        Dim salesLogString As String = "spSalesLog_Create " & salesId & "," & action & ",1"
        Dim result As String = Kailash.ExecuteScalar(salesLogString)
        MessageBox.Show(result, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        GetSalesList()
    End Sub

    Private Sub Print(EntryId)
        Dim RD As New ReportDocument
        Dim path As String = Application.StartupPath & "\SalesInvoice_PE.rpt"

        If chkIsParekhAgency.Checked Then
            path = Application.StartupPath & "\SalesInvoice_PA.rpt"
        End If
        RD.Load(path)

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues()
        Dim crParameterDiscreteValue As New ParameterDiscreteValue()

        crParameterDiscreteValue.Value = EntryId
        crParameterFieldDefinitions = RD.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions("@SalesID")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        Dim crParameterFieldDefinitionTerms As ParameterFieldDefinition
        Dim crParameterValuesTerms As New ParameterValues()
        Dim crParameterDiscreteValueTerms As New ParameterDiscreteValue()

        crParameterDiscreteValueTerms.Value = 1
        crParameterFieldDefinitionTerms = crParameterFieldDefinitions("@CompanyID")
        crParameterValuesTerms = crParameterFieldDefinitionTerms.CurrentValues
        crParameterValuesTerms.Clear()
        crParameterValuesTerms.Add(crParameterDiscreteValueTerms)
        crParameterFieldDefinitionTerms.ApplyCurrentValues(crParameterValuesTerms)

        Kailash.SetDBLogonForReport(RD, True)

        FrmReportViewer.CrystalReportViewer1.ReportSource = RD

        FrmReportViewer.CrystalReportViewer1.ShowRefreshButton = True
        FrmReportViewer.Show()

    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim iRow = dgvSalesbill.CurrentCell.RowIndex
        FindId = dgvSalesbill.Rows(iRow).Cells("SalesID").Value

        Dim frmRetailSell As New frmRetailSell
        frmRetailSell.MdiParent = Frmmain
        frmRetailSell.StartPosition = FormStartPosition.CenterScreen
        frmRetailSell.Show()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim iRow = dgvSalesbill.CurrentCell.RowIndex
        FindId = dgvSalesbill.Rows(iRow).Cells("SalesID").Value
        Print(FindId)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim iRow = dgvSalesbill.CurrentCell.RowIndex
        FindId = dgvSalesbill.Rows(iRow).Cells("SalesID").Value
        AddSalesLog(FindId, 1)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim iRow = dgvSalesbill.CurrentCell.RowIndex
        FindId = dgvSalesbill.Rows(iRow).Cells("SalesID").Value
        AddSalesLog(FindId, 2)
    End Sub
End Class
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmInvoiceGST
    Public isQuatation As Boolean
    Dim Kailash As New DataAccessLayer
    Dim EntryId As Integer = 0
    Dim IsEdit As Boolean = False
    Dim MyDataSet As New DataSet

    Private Sub FrmInvoiceGST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtAddress.Width = 90
        txtParticular.Width = 350
        cmbInvType.Items.Clear()
        If isQuatation.Equals(False) Then
            lblQNo.Text = "Invoice No. :"
            cmbInvType.Items.Add(String.Empty)
            cmbInvType.Items.Add("INVOICE")
            'cmbInvType.Items.Add("RETAIL INVOICE")
            cmbInvType.Items.Add("LABOUR INVOICE")
            btnTerms.Visible = False
        Else
            lblQNo.Text = "Q No. :"
            cmbInvType.Items.Add(String.Empty)
            cmbInvType.Items.Add("SUPPLY QUATATION")
            cmbInvType.Items.Add("LABOUR QUATATION")
            chkPerformaInvoice.Visible = False
            btnTerms.Visible = True
        End If
        txtLabourDisPer.Text = "#0.00"
        lblLabourDisPer.Visible = False
        lbllabourDisAmt.Visible = False
        txtLabourDisPer.Visible = False
        txtlabourDisAmt.Visible = False
        btnNew_Click(Nothing, Nothing)
    End Sub

    Public Sub ClearField()
        txtQNo.Text = ""
        txtLHSNCode.Text = ""
        txtSupplyPrintPer.Text = ""
        txtLabPrintPer.Text = ""
        txtOrderNo.Text = ""
        txtChallanNo.Text = ""
        txtLrRrNo.Text = ""
        txtRemark.Text = ""
        txtAddress.Text = ""
        txtQNoCopy.Text = ""
        dtpQDate.Text = ""
        dtpOrderDate.Text = ""
        dtpChallanDate.Text = ""
        dtpLrRrDate.Text = ""
        cmbPartyName.SelectedIndex = cmbInvType.SelectedIndex = cmbPartyName.SelectedIndex = 0
        chkPerformaInvoice.Checked = False
        txtRemark.Text = ""
        txtGAmt.Text = ""

        txtGSTNo.Text = ""
        txtSGST5.Text = ""
        txtSGST12.Text = ""
        txtSGST18.Text = ""
        txtSGST28.Text = ""
        txtCGST5.Text = ""
        txtCGST12.Text = ""
        txtCGST18.Text = ""
        txtCGST28.Text = ""
        txtIGST5.Text = ""
        txtIGST12.Text = ""
        txtIGST18.Text = ""
        txtIGST28.Text = ""

        txtTotalAmt.Text = ""
        txtNetAmt.Text = ""
        txtLabourDisPer.Text = ""
        txtlabourDisAmt.Text = ""

        txtQNo.Focus()
    End Sub


    Private Sub MyDataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles MyDataGridView1.CurrentCellDirtyStateChanged
        'If MyDataGridView1.IsCurrentCellDirty Then
        '    MyDataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        '    'MyDataSet.Tables(1).AcceptChanges()
        'End If
        MyDataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
    End Sub

    Private Sub MyDataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView1.CellEndEdit
        MyDataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue

        If e.RowIndex = -1 Then Exit Sub

        If MyDataGridView1.Columns(e.ColumnIndex).Name = COlCapitalA.Name Then
            With MyDataGridView1.Rows(e.RowIndex)
                .Cells(CapitalAHidden.Name).Value = .Cells(COlCapitalA.Name).Value.ToString()
            End With
        End If

        If MyDataGridView1.Columns(e.ColumnIndex).Name = ColQty.Name Or MyDataGridView1.Columns(e.ColumnIndex).Name = ColRate.Name Or MyDataGridView1.Columns(e.ColumnIndex).Name = ColDis.Name Or MyDataGridView1.Columns(e.ColumnIndex).Name = ColVatper.Name Or MyDataGridView1.Columns(e.ColumnIndex).Name = iRate.Name Or MyDataGridView1.Columns(e.ColumnIndex).Name = iVatper.Name Or MyDataGridView1.Columns(e.ColumnIndex).Name = iDis.Name Then
            With MyDataGridView1.Rows(e.RowIndex)
                .Cells(ColAmount.Name).Value = Math.Round(Val(.Cells(ColQty.Name).Value.ToString()) * Val(.Cells(ColRate.Name).Value.ToString()), 2)
                .Cells(ColDisAmount.Name).Value = Math.Round((((Val(.Cells(ColQty.Name).Value.ToString()) * Val(.Cells(ColRate.Name).Value.ToString())) * Val(.Cells(ColDis.Name).Value.ToString())) / 100), 2)
                .Cells(ColVatAmount.Name).Value = Math.Round(((((Val(.Cells(ColQty.Name).Value.ToString()) * Val(.Cells(ColRate.Name).Value.ToString())) - Val(.Cells(ColDisAmount.Name).Value.ToString())) * Val(.Cells(ColVatper.Name).Value.ToString())) / 100), 2)
                .Cells(iAmount.Name).Value = Math.Round(Val(.Cells(ColQty.Name).Value.ToString()) * Val(.Cells(iRate.Name).Value.ToString()), 2)
                .Cells(iDisAmount.Name).Value = Math.Round((((Val(.Cells(ColQty.Name).Value.ToString()) * Val(.Cells(iRate.Name).Value.ToString())) * Val(.Cells(iDis.Name).Value.ToString())) / 100), 2)
                .Cells(iVatAmount.Name).Value = Math.Round(((((Val(.Cells(ColQty.Name).Value.ToString()) * Val(.Cells(iRate.Name).Value.ToString())) - Val(.Cells(iDisAmount.Name).Value.ToString())) * Val(.Cells(iVatper.Name).Value.ToString())) / 100), 2)

            End With
        End If

        If MyDataSet.Tables(1).Columns("CapitalAHidden") Is Nothing Then
            MyDataSet.Tables(1).Columns.Add("CapitalAHidden")
            MyDataSet.Tables(1).AcceptChanges()
        End If
        ReCalculate()
    End Sub

    Public Sub ReCalculate()
        If MyDataSet Is Nothing Then
            Exit Sub
        End If
        If MyDataSet IsNot Nothing And MyDataSet.Tables Is Nothing Then
            Exit Sub
        End If
        If MyDataSet IsNot Nothing And MyDataSet.Tables.Count = 0 Then
            Exit Sub
        End If

        Dim dtGrid As DataTable = MyDataSet.Tables(1) 'MyDataGridView1.DataSource
        Dim Vat2 As Double = 0, Vat5 As Double = 0, Vat15 As Double = 0, GAmount As Double = 0, Discont As Double = 0

        Dim GST5 As Double = 0, GST12 As Double = 0, GST18 As Double = 0, GST28 As Double = 0

        For Each dr As DataRow In dtGrid.Rows
            If dr("Vatper").ToString() IsNot Nothing And Not dr("Vatper").ToString().Equals("") Then
                If Convert.ToDecimal(dr("Vatper").ToString()) = 5 Then
                    GST5 = GST5 + Val(dr("VatAmount").ToString())
                ElseIf Convert.ToDecimal(dr("Vatper").ToString()) = 12 Then
                    GST12 = GST12 + Val(dr("VatAmount").ToString())
                ElseIf Convert.ToDecimal(dr("Vatper").ToString()) = 18 Then
                    GST18 = GST18 + Val(dr("VatAmount").ToString())
                ElseIf Convert.ToDecimal(dr("Vatper").ToString()) = 28 Then
                    GST28 = GST28 + Val(dr("VatAmount").ToString())
                End If
            ElseIf dr("ItemRemark").ToString() IsNot Nothing Then
                dr("ItemRemark") = dr("ItemRemark").ToString.Trim()
            End If

            If dr("iVatper").ToString() IsNot Nothing And Not dr("iVatper").ToString().Equals("") Then
                If Convert.ToDecimal(dr("iVatper").ToString()) = 5 Then
                    GST5 = GST5 + Val(dr("iVatAmount").ToString())
                ElseIf Convert.ToDecimal(dr("iVatper").ToString()) = 12 Then
                    GST12 = GST12 + Val(dr("iVatAmount").ToString())
                ElseIf Convert.ToDecimal(dr("iVatper").ToString()) = 18 Then
                    GST18 = GST18 + Val(dr("iVatAmount").ToString())
                ElseIf Convert.ToDecimal(dr("iVatper").ToString()) = 28 Then
                    GST28 = GST28 + Val(dr("iVatAmount").ToString())
                End If
            End If

            If dr("Dis").ToString() IsNot Nothing Then
                Discont = Discont + Val(dr("DisAmount").ToString())
            End If
            If dr("iDis").ToString() IsNot Nothing Then
                Discont = Discont + Val(dr("iDisAmount").ToString())
            End If
            GAmount = GAmount + Val(dr("Amount").ToString()) + Val(dr("iAmount").ToString())
        Next
        txtGAmt.Text = GAmount.ToString("#0.00")

        If cmbStateName.SelectedValue = 24 Then
            txtSGST5.Text = (GST5 / 2).ToString("#0.00")
            txtCGST5.Text = (GST5 / 2).ToString("#0.00")

            txtSGST12.Text = (GST12 / 2).ToString("#0.00")
            txtCGST12.Text = (GST12 / 2).ToString("#0.00")

            txtSGST18.Text = (GST18 / 2).ToString("#0.00")
            txtCGST18.Text = (GST18 / 2).ToString("#0.00")

            txtSGST28.Text = (GST28 / 2).ToString("#0.00")
            txtCGST28.Text = (GST28 / 2).ToString("#0.00")

            txtIGST5.Text = (0).ToString("#0.00")
            txtIGST12.Text = (0).ToString("#0.00")
            txtIGST18.Text = (0).ToString("#0.00")
            txtIGST28.Text = (0).ToString("#0.00")
        Else
            txtSGST5.Text = (0).ToString("#0.00")
            txtCGST5.Text = (0).ToString("#0.00")
            txtSGST12.Text = (0).ToString("#0.00")
            txtCGST12.Text = (0).ToString("#0.00")
            txtSGST18.Text = (0).ToString("#0.00")
            txtCGST18.Text = (0).ToString("#0.00")
            txtSGST28.Text = (0).ToString("#0.00")
            txtCGST28.Text = (0).ToString("#0.00")

            txtIGST5.Text = GST5.ToString("#0.00")
            txtIGST12.Text = GST12.ToString("#0.00")
            txtIGST18.Text = GST18.ToString("#0.00")
            txtIGST28.Text = GST28.ToString("#0.00")
        End If

        txtDiscountAmt.Text = Discont.ToString("#0.00")

        txtTotalAmt.Text = ((GAmount - Discont) + (GST5 + GST12 + GST18 + GST28)).ToString("#0.00")

        Dim roudedVal As Decimal = Math.Round(Val(txtTotalAmt.Text), MidpointRounding.AwayFromZero) '// rounded value
        Dim Roff As Decimal = 0
        Roff -= Val(txtTotalAmt.Text) - roudedVal

        txtRoundOff.Text = Roff.ToString("#0.00")
        txtNetAmt.Text = roudedVal.ToString("#0.00")

        Dim NetAmt As Decimal = 0
        If txtLabourDisPer.Visible = True Then
            Dim DisPer As Decimal = 0, DisAmt As Decimal = 0, TotalAmt As Decimal = 0
            TotalAmt = Val(txtTotalAmt.Text)
            DisPer = Val(txtLabourDisPer.Text)
            DisAmt = Math.Round((TotalAmt * DisPer) / 100, 2)
            txtlabourDisAmt.Text = Val(DisAmt).ToString("#0.00")
            NetAmt = TotalAmt - DisAmt

            roudedVal = Math.Round(Val(NetAmt), MidpointRounding.AwayFromZero) '// rounded value
            Roff = 0
            Roff -= Val(NetAmt) - roudedVal
            txtRoundOff.Text = Roff.ToString("#0.00")
            txtNetAmt.Text = roudedVal.ToString("#0.00")
        End If
        'Roundoff = Roff
        'NetAmont = roudedVal
        'txtRounfOff.Text = (Math.Round(Val(txtGAmount.Text)) - Val(txtGAmount.Text)).ToString("#0.00")
        'txtNetAmount.Text = Val(Math.Round(Val(txtGAmount.Text))).ToString("#0.00")
    End Sub


    Private Sub MyDataGridView1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView1.CellLeave
        If MyDataGridView1.Columns(e.ColumnIndex).Name = Colsmalla.Name Then
            txtParticular.Focus()
            MyDataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
            'ElseIf MyDataGridView1.Columns(e.ColumnIndex).Name = ColVatper.Name Then
            '    Dim allRow As DataRow = MyDataSet.Tables(1).NewRow
            '    MyDataSet.Tables(1).Rows.InsertAt(allRow, MyDataGridView1.CurrentRow.Index + 1)
            '    MyDataGridView1.Focus()
            '    MyDataGridView1.CurrentCell = MyDataGridView1(MyDataGridView1.SelectedRows(0).Cells(COlCapitalA.Name).ColumnIndex, MyDataGridView1.CurrentRow.Index + 1)
            '    MyDataSet.Tables(1).AcceptChanges()
            '    'btnAddRow_Click(Nothing, Nothing)
        End If
    End Sub


    Function sfuncEndVBCRLFremoved(strSource As String, Optional bTrimSource As Boolean = True) As String
        If strSource = "" Then
            Return strSource
        End If
        On Error GoTo err_h
        Dim s As String
        Dim iLen As Integer

        If bTrimSource Then strSource = Trim$(strSource)

testPoint:

        If strSource = "" Then
            Return strSource
        End If
        'get last two characters of string
        s = Mid$(strSource, Len(strSource) - 1, 2)

        'len of [strSource]
        iLen = Len(strSource)

        'if last two characters are carriage return and 
        'line feed then trim off the last 2 characters
        If s = vbCrLf Then
            If strSource = "" Then
                Return strSource
            End If
            strSource = Mid$(strSource, 1, (iLen - 2))
            If strSource = "" Then
                Return strSource
            End If
            GoTo testPoint 'test last two characters
        End If

        'return with trailing carriage returns removed
        sfuncEndVBCRLFremoved = strSource

        Exit Function
err_h:
        With Err()

            If .Number <> 0 Then
                If strSource = "" Then
                    Return strSource
                End If
                'ErrHandler.ReportError Date & ": Str.sfuncEndVBCRLFremoved." & Err.Number & "." & Err.Description
                Resume Next
            End If
        End With
    End Function


    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        'Dim SqlString As String = "SELECT " + IIf(IsLabour.Equals(False), "IsNull(Terms,'')", "IsNull(LabourTerms,'')") + " FROM dbo.PartyMaster Where PartyId = " & Val(cmbPartyName.SelectedValue)
        'TermsConditions = Kailash.ExecuteScalar(SqlString)
        If cmbInvType.Text.Contains("LABOUR") Then
            IsLabour = True
        Else
            IsLabour = False
        End If
        Dim SqlString As String = "SELECT Top 1 " + IIf(IsLabour.Equals(False), "Terms", "LabourTerms") + " FROM dbo.PartyTermsCondition Where PartyId = " & Val(cmbPartyName.SelectedValue) & " Order By ModifiedDate Desc"
        If InwardId > 0 Then
            SqlString = "SELECT Top 1 " + IIf(IsLabour.Equals(False), "Terms", "LabourTerms") + " FROM dbo.PartyTermsCondition Where PartyId = " & Val(cmbPartyName.SelectedValue) & " And InwardId = " & InwardId
        End If
        TermsConditions = Kailash.ExecuteScalar(SqlString)
        If cmbInvType.Text <> "" Then

            If cmbInvType.Text = "LABOUR INVOICE" Or cmbInvType.Text = "LABOUR QUATATION" Then

                Dim RD As New ReportDocument
                Dim path As String = Application.StartupPath & "\InvLabourNew.rpt"

                If cmbInvType.Text = "LABOUR QUATATION" Then
                    path = Application.StartupPath & "\QuotationLabour.rpt"
                    If IsQuotationNew = True Then
                        ' path = Application.StartupPath & "\QuotationLabourNew.rpt"
                        path = Application.StartupPath & "\QuatationWithLabourNew.rpt"
                    End If
                End If

                RD.Load(path)

                Dim crParameterFieldDefinitions As ParameterFieldDefinitions
                Dim crParameterFieldDefinition As ParameterFieldDefinition
                Dim crParameterValues As New ParameterValues()
                Dim crParameterDiscreteValue As New ParameterDiscreteValue()

                crParameterDiscreteValue.Value = EntryId
                crParameterFieldDefinitions = RD.DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions("inwardid")
                crParameterValues = crParameterFieldDefinition.CurrentValues

                crParameterValues.Clear()
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)


                Dim crParameterFieldDefinition1 As ParameterFieldDefinition
                Dim crParameterValues1 As New ParameterValues()
                Dim crParameterDiscreteValue1 As New ParameterDiscreteValue()

                If (isQuatation = False) Then
                    If (chkPerformaInvoice.Checked = True) Then
                        crParameterDiscreteValue1.Value = "PERFORMA INVOICE"
                    Else
                        crParameterDiscreteValue1.Value = "LABOUR / CONSULTING INVOICE"
                    End If
                Else
                    crParameterDiscreteValue1.Value = "LABOUR WORK ESTIMATE"
                End If
                crParameterFieldDefinition1 = crParameterFieldDefinitions("invType")
                crParameterValues1 = crParameterFieldDefinition1.CurrentValues

                crParameterValues1.Clear()
                crParameterValues1.Add(crParameterDiscreteValue1)
                crParameterFieldDefinition1.ApplyCurrentValues(crParameterValues1)

                If cmbInvType.Text = "LABOUR QUATATION" And IsQuotationNew = True Then
                    Dim crParameterFieldDefinitionTerms As ParameterFieldDefinition
                    Dim crParameterValuesTerms As New ParameterValues()
                    Dim crParameterDiscreteValueTerms As New ParameterDiscreteValue()

                    Dim strTerms As String
                    strTerms = "Terms & Conditions Apply"
                    strTerms = TermsConditions
                    crParameterDiscreteValueTerms.Value = strTerms
                    crParameterFieldDefinitionTerms = crParameterFieldDefinitions("Terms")
                    crParameterValuesTerms = crParameterFieldDefinitionTerms.CurrentValues
                    crParameterValuesTerms.Clear()
                    crParameterValuesTerms.Add(crParameterDiscreteValueTerms)
                    crParameterFieldDefinitionTerms.ApplyCurrentValues(crParameterValuesTerms)
                End If

                Kailash.SetDBLogonForReport(RD)

                FrmReportViewer.CrystalReportViewer1.ReportSource = RD

                FrmReportViewer.CrystalReportViewer1.ShowRefreshButton = True
                FrmReportViewer.Show()
            Else
                Dim RD As New ReportDocument()
                ' Dim path As String = Application.StartupPath & "\InvNew.rpt"
                Dim path As String = Application.StartupPath & "\InvWithLabourNew.rpt"

                If cmbInvType.Text.Contains("QUATATION") Then
                    'path = Application.StartupPath & "\QuotationNew.rpt"
                    path = Application.StartupPath & "\QuatationWithLabourNew.rpt"
                End If

                RD.Load(path)
                Kailash.SetDBLogonForReport(RD)
                Dim crParameterFieldDefinitions As ParameterFieldDefinitions
                Dim crParameterFieldDefinition As ParameterFieldDefinition
                Dim crParameterValues As New ParameterValues()
                Dim crParameterDiscreteValue As New ParameterDiscreteValue()

                crParameterDiscreteValue.Value = EntryId
                crParameterFieldDefinitions = RD.DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions("inwardid")
                crParameterValues = crParameterFieldDefinition.CurrentValues

                crParameterValues.Clear()
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)


                Dim crParameterFieldDefinition1 As ParameterFieldDefinition
                Dim crParameterValues1 As New ParameterValues()
                Dim crParameterDiscreteValue1 As New ParameterDiscreteValue()

                If (isQuatation = False) Then
                    If (chkRevised.Checked = True) Then
                        If (chkPerformaInvoice.Checked = True) Then
                            crParameterDiscreteValue1.Value = "REVISED PERFORMA INVOICE"
                        Else
                            crParameterDiscreteValue1.Value = "REVISED " + cmbInvType.Text
                        End If
                    Else
                        If (chkPerformaInvoice.Checked = True) Then
                            crParameterDiscreteValue1.Value = "PERFORMA INVOICE"
                        Else
                            crParameterDiscreteValue1.Value = cmbInvType.Text
                        End If

                    End If

                Else
                    If (chkRevised.Checked = True) Then
                        crParameterDiscreteValue1.Value = "REVISED QUOTATION / ESTIMATE"
                    Else
                        crParameterDiscreteValue1.Value = "QUOTATION / ESTIMATE"
                    End If

                End If

                crParameterFieldDefinition1 = crParameterFieldDefinitions("invType")
                crParameterValues1 = crParameterFieldDefinition1.CurrentValues
                crParameterValues1.Clear()
                crParameterValues1.Add(crParameterDiscreteValue1)
                crParameterFieldDefinition1.ApplyCurrentValues(crParameterValues1)

                If cmbInvType.Text.Contains("QUATATION") Then
                    Dim crParameterFieldDefinitionTerms As ParameterFieldDefinition
                    Dim crParameterValuesTerms As New ParameterValues()
                    Dim crParameterDiscreteValueTerms As New ParameterDiscreteValue()

                    Dim strTerms As String
                    strTerms = "Terms & Conditions Apply"
                    strTerms = TermsConditions
                    crParameterDiscreteValueTerms.Value = strTerms
                    crParameterFieldDefinitionTerms = crParameterFieldDefinitions("Terms")
                    crParameterValuesTerms = crParameterFieldDefinitionTerms.CurrentValues
                    crParameterValuesTerms.Clear()
                    crParameterValuesTerms.Add(crParameterDiscreteValueTerms)
                    crParameterFieldDefinitionTerms.ApplyCurrentValues(crParameterValuesTerms)
                End If


                FrmReportViewer.CrystalReportViewer1.ReportSource = RD
                FrmReportViewer.CrystalReportViewer1.ShowRefreshButton = True

                FrmReportViewer.Show()

            End If
        Else
            MessageBox.Show("Please Select InvoiceType")
        End If
    End Sub

    Private Sub cmbPartyName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPartyName.SelectionChangeCommitted
        txtAddress.Text = Kailash.GetValue("Select Address From PartyMaster Where PartyId= " & Val(cmbPartyName.SelectedValue))
        'cmbStateName.Focus()
    End Sub


    Private Sub FillData()
        Try
            Dim SqlString As String = "View_Inward 2," & FindId & "," & isQuatation & ",null,null,null"
            MyDataSet = New DataSet
            MyDataSet = Kailash.ExecuteDataSet(SqlString)

            If MyDataSet.Tables(0).Rows.Count > 0 Then
                cmbInvType.Items.Clear()
                If isQuatation.Equals(False) Then
                    lblQNo.Text = "Invoice No. :"
                    cmbInvType.Items.Add(String.Empty)
                    cmbInvType.Items.Add("INVOICE")
                    'cmbInvType.Items.Add("RETAIL INVOICE")
                    cmbInvType.Items.Add("LABOUR INVOICE")
                Else
                    lblQNo.Text = "Q No. :"
                    cmbInvType.Items.Add(String.Empty)
                    cmbInvType.Items.Add("SUPPLY QUATATION")
                    cmbInvType.Items.Add("LABOUR QUATATION")
                    chkPerformaInvoice.Visible = False
                End If

                With MyDataSet.Tables(0).Rows(0)

                    txtLabourDisPer.Text = "#0.00"

                    EntryId = Val(.Item("InwardId"))
                    InwardId = EntryId
                    txtQNo.Text = .Item("BillNo").ToString()
                    txtLHSNCode.Text = .Item("LHSNCode").ToString()
                    If Not IsDBNull(.Item("LabourPrintPer")) Then
                        txtLabPrintPer.Text = .Item("LabourPrintPer").ToString()
                    End If
                    If Not IsDBNull(.Item("SupplyPrintPer")) Then
                        txtSupplyPrintPer.Text = .Item("SupplyPrintPer").ToString()
                    End If

                    If .Item("InwardDate").ToString() <> String.Empty Then dtpQDate.Text = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(.Item("InwardDate").ToString()))
                    txtOrderNo.Text = .Item("OrderNo").ToString()
                    cmbPartyName.SelectedValue = .Item("PartyId").ToString()
                    cmbPartyName_SelectionChangeCommitted(Nothing, Nothing)

                    If .Item("StateCode").ToString() <> String.Empty Then
                        cmbStateName.SelectedValue = .Item("StateCode").ToString()
                        cmbStateName_SelectedValueChanged(Nothing, Nothing)
                    Else
                        cmbStateName.SelectedIndex = 0
                    End If

                    If .Item("OrderDate").ToString() <> String.Empty Then dtpOrderDate.Text = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(.Item("OrderDate").ToString()))
                    txtChallanNo.Text = .Item("ChallanNo").ToString()
                    If .Item("ChallanDate").ToString() <> String.Empty Then dtpChallanDate.Text = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(.Item("ChallanDate").ToString()))
                    txtLrRrNo.Text = .Item("LRNo").ToString()
                    If .Item("LRDate").ToString() <> String.Empty Then dtpLrRrDate.Text = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(.Item("LRDate").ToString()))

                    txtGSTNo.Text = .Item("GSTNo").ToString()

                    txtTotalAmt.Text = .Item("TotalAmont").ToString()
                    txtDiscountAmt.Text = .Item("DetailDiscount").ToString()

                    txtSGST5.Text = .Item("SGST5").ToString()
                    txtSGST12.Text = .Item("SGST12").ToString()
                    txtSGST18.Text = .Item("SGST18").ToString()
                    txtSGST28.Text = .Item("SGST28").ToString()
                    txtCGST5.Text = .Item("CGST5").ToString()
                    txtCGST12.Text = .Item("CGST12").ToString()
                    txtCGST18.Text = .Item("CGST18").ToString()
                    txtCGST28.Text = .Item("CGST28").ToString()
                    txtIGST5.Text = .Item("IGST5").ToString()
                    txtIGST12.Text = .Item("IGST12").ToString()
                    txtIGST18.Text = .Item("IGST18").ToString()
                    txtIGST28.Text = .Item("IGST28").ToString()

                    txtRoundOff.Text = .Item("Roundoff").ToString()
                    txtNetAmt.Text = .Item("NetAmont").ToString()

                    cmbInvType.SelectedItem = .Item("InvoiceType").ToString()
                    txtRemark.Text = .Item("Remark").ToString()
                End With
                MyDataGridView1.DataSource = MyDataSet.Tables(1)

                txtLabourDisPer.Text = MyDataSet.Tables(0).Rows(0).Item("DisFive").ToString()
                txtlabourDisAmt.Text = MyDataSet.Tables(0).Rows(0).Item("DisFiveAmount").ToString()
                'Dim SPP As Decimal = txtSupplyPrintPer.Text
                'txtSupplyPrintPer.Text = SPP.ToString("#0.00")

                'Dim LPP As Decimal = txtLabPrintPer.Text
                'txtLabPrintPer.Text = LPP.ToString("#0.00")

                IsEdit = True
                txtQNo.Focus()
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message.ToString())
        End Try
    End Sub



    Private Sub MyDataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView1.KeyDown
        MyDataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Dim iCol = MyDataGridView1.CurrentCell.ColumnIndex
            Dim iRow = MyDataGridView1.CurrentCell.RowIndex
            If iCol = MyDataGridView1.Columns.Count - 1 Then
                If iRow < MyDataGridView1.Rows.Count - 1 Then
                    'btnAddRow_Click(Nothing, Nothing)
                    'MyDataGridView1.CurrentCell = MyDataGridView1(3, iRow + 1)
                End If
            Else
                If iCol < 12 Then
                    MyDataGridView1.CurrentCell = MyDataGridView1(iCol + 1, iRow)
                Else
                    If MyDataGridView1.Rows.Count > iRow Then

                    End If
                    btnAddNewRow_Click(Nothing, Nothing)
                    MyDataGridView1.CurrentCell = MyDataGridView1(3, iRow + 1)
                    'MyDataGridView1.CurrentCell.Style = DefaultBackColor
                End If
            End If

        ElseIf e.KeyCode = Keys.Delete Then
            If MyDataGridView1.Rows.Count = 1 Then Exit Sub
            For Each row As DataGridViewRow In MyDataGridView1.SelectedRows
                If (MyDataGridView1.Rows.Count > 1) Then
                    If MsgBox("Are You Sure Want to Sure Delete this Entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
                        MyDataSet.Tables(1).Rows.RemoveAt(row.Index)
                        MyDataSet.Tables(1).AcceptChanges()
                        ReCalculate()
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub MyDataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyDataGridView1.KeyPress
        MyDataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Tab) Then
            'e.SuppressKeyPress = True
            Dim iCol = MyDataGridView1.CurrentCell.ColumnIndex
            Dim iRow = MyDataGridView1.CurrentCell.RowIndex

            If MyDataGridView1.CurrentCell.OwningColumn.Name = iAmount.Name Then
                If MyDataGridView1.Rows.Count - 1 = iRow Then
                    btnAddNewRow_Click(Nothing, Nothing)
                    MyDataGridView1.CurrentCell = MyDataGridView1(3, iRow + 1)
                End If
            End If

            'If iCol = MyDataGridView1.Columns.Count - 1 Then
            '    If iRow < MyDataGridView1.Rows.Count - 1 Then
            '        'btnAddRow_Click(Nothing, Nothing)
            '        'MyDataGridView1.CurrentCell = MyDataGridView1(3, iRow + 1)
            '    End If
            'Else
            '    If iCol < 12 Then
            '        MyDataGridView1.CurrentCell = MyDataGridView1(iCol + 1, iRow)
            '    Else
            '        btnAddNewRow_Click(Nothing, Nothing)
            '        MyDataGridView1.CurrentCell = MyDataGridView1(3, iRow + 1)
            '    End If
            'End If


        End If
    End Sub

    Private Sub cmbInvType_TextChanged(sender As Object, e As EventArgs) Handles cmbInvType.TextChanged
        If isQuatation.Equals(False) Then
            lblLabourDisPer.Visible = (cmbInvType.Text = "LABOUR INVOICE")
            lbllabourDisAmt.Visible = (cmbInvType.Text = "LABOUR INVOICE")
            txtLabourDisPer.Visible = (cmbInvType.Text = "LABOUR INVOICE")
            txtlabourDisAmt.Visible = (cmbInvType.Text = "LABOUR INVOICE")

            txtLabourDisPer.Text = Val("0").ToString("#0.00")
            txtlabourDisAmt.Text = Val("0").ToString("#0.00")
        Else
            lblLabourDisPer.Visible = (cmbInvType.Text = "LABOUR QUATATION")
            lbllabourDisAmt.Visible = (cmbInvType.Text = "LABOUR QUATATION")
            txtLabourDisPer.Visible = (cmbInvType.Text = "LABOUR QUATATION")
            txtlabourDisAmt.Visible = (cmbInvType.Text = "LABOUR QUATATION")

            txtLabourDisPer.Text = Val("0").ToString("#0.00")
            txtlabourDisAmt.Text = Val("0").ToString("#0.00")
        End If
    End Sub

    Private Sub txtLabourDisPer_TextChanged(sender As Object, e As EventArgs) Handles txtLabourDisPer.TextChanged
        ReCalculate()
    End Sub

    Private Sub txtLabourDisPer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLabourDisPer.KeyPress
        'If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
        '    Beep()
        '    e.Handled = True
        'End If
        If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub txtLabourDisPer_Enter(sender As Object, e As EventArgs) Handles txtLabourDisPer.Enter
        If (Not String.IsNullOrEmpty(txtLabourDisPer.Text)) Then
            txtLabourDisPer.SelectionStart = 0
            txtLabourDisPer.SelectionLength = txtLabourDisPer.Text.Length
        End If
    End Sub

    Private Sub MyDataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles MyDataGridView1.EditingControlShowing
        'If MyDataGridView1.CurrentCell.OwningColumn.Name = "ColVatper" Or MyDataGridView1.CurrentCell.OwningColumn.Name = "ColDis" Or MyDataGridView1.CurrentCell.OwningColumn.Name = "ColRate" Or MyDataGridView1.CurrentCell.OwningColumn.Name = "ColQty" Or MyDataGridView1.CurrentCell.OwningColumn.Name = "ColDigital1" Then
        '    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf txtLabourDisPer_KeyPress
        'End If
    End Sub

    Private Sub MyDataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles MyDataGridView1.SelectionChanged
        MyDataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        If MyDataGridView1.RowCount = 0 Then Exit Sub
        If MyDataGridView1.SelectedRows.Count = 0 Then Exit Sub
        If MyDataGridView1.SelectedRows(0).Cells(ColItemRemark.Name).Value IsNot Nothing And Not IsDBNull(MyDataGridView1.SelectedRows(0).Cells(ColItemRemark.Name).Value) Then
            txtParticular.Text = MyDataGridView1.SelectedRows(0).Cells(ColItemRemark.Name).Value.ToString()
        Else
            txtParticular.Text = ""
        End If
    End Sub

    Private Sub MyDataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MyDataGridView1.CellFormatting
        MyDataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        If MyDataGridView1.CurrentCell IsNot Nothing Then
            If e.RowIndex = MyDataGridView1.CurrentCell.RowIndex And e.ColumnIndex = MyDataGridView1.CurrentCell.ColumnIndex Then
                e.CellStyle.SelectionBackColor = Color.Wheat
            Else
                e.CellStyle.SelectionBackColor = MyDataGridView1.DefaultCellStyle.SelectionBackColor
            End If
        End If
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Kailash.ResetTextBox(Me)
        cmbPartyName.SelectedIndex = -1
        cmbInvType.SelectedIndex = -1
        chkCopyEntry.Checked = False
        chkPerformaInvoice.Checked = False
        Kailash.FillComboDataSource("select PartyId, PartyName from dbo.PartyMaster", cmbPartyName, String.Empty)

        Kailash.FillComboDataSource("Select StateCode, StateName From StateMaster", cmbStateName, String.Empty)

        IsEdit = False
        EntryId = 0
        InwardId = 0
        MyDataSet = New DataSet
        MyDataSet = Kailash.ExecuteDataSet("LIst_InwardDetails 0")
        MyDataGridView1.DataSource = MyDataSet.Tables(1)
        btnAddNewRow_Click(Nothing, Nothing)
        ClearField()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not EntryId.Equals(0) And chkCopyEntry.Checked Then
            Try
                Dim SqlString As String = "CopyRecords"
                Kailash.AddParameter("@Id", EntryId)
                Kailash.AddParameter("@Copytype", "")
                Kailash.ExecuteNonQuery(SqlString, Kailash.ParameterList)
                MessageBox.Show("Record Copied Successfully", "Record Copy", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnNew_Click(Nothing, Nothing)
                ClearField()

            Catch ex As Exception
                MessageBox.Show("An exception Of type " & ex.GetType().ToString() &
                            "was encountered While inserting the data." &
                            vbNewLine & ex.Message.ToString(), "Record Copy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try

        Else

            If txtQNo.Text.Equals(String.Empty) Then
                MessageBox.Show("Please Enter " & IIf(isQuatation.Equals(False), "Invoice", "Quatation ") & "No.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtQNo.Focus()
                Exit Sub
            End If

            If cmbPartyName.SelectedIndex = 0 Or cmbPartyName.Text = "" Then
                MessageBox.Show("Please Select Party", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbPartyName.Focus()
                Exit Sub
            End If

            If cmbInvType.SelectedIndex = 0 Or cmbInvType.Text = "" Then
                MessageBox.Show("Please Select Invoice Type", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbInvType.Focus()
                Exit Sub
            End If

            If IsStateValidationRequired.Equals(True) Then
                If cmbStateName.SelectedIndex = 0 Or cmbStateName.Text = "" Then
                    MessageBox.Show("Please Select State", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cmbStateName.Focus()
                    Exit Sub
                End If
            End If

            Dim strCapitalAHidden As String = String.Empty
            Dim index As Integer = 0
            For Each dr As DataRow In MyDataSet.Tables(1).Rows
                If index = 0 Then
                    strCapitalAHidden = dr("CapitalA").ToString()
                End If

                If dr("CapitalA").ToString() Is Nothing Or dr("CapitalA").ToString() = "" Then
                    dr("CapitalAHidden") = strCapitalAHidden
                Else
                    strCapitalAHidden = dr("CapitalA").ToString()
                    dr("CapitalAHidden") = strCapitalAHidden
                End If

                index = index + 1
            Next

            MyDataSet.Tables(1).AcceptChanges()
            Dim SqlString As String = "Ins_Inward"
            Kailash.AddParameter("@InwardID", EntryId)
            Kailash.AddParameter("@PartyId", Val(cmbPartyName.SelectedValue))

            If Not dtpQDate.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals("") Then
                Kailash.AddParameter("@InwardDate", Convert.ToDateTime(dtpQDate.Text).ToString("yyyy/MM/dd"))
            Else
                Kailash.AddParameter("@InwardDate", DBNull.Value)
            End If

            Kailash.AddParameter("@CenterId", Val(0))
            Kailash.AddParameter("@BillNo", txtQNo.Text)
            Kailash.AddParameter("@LHSNCode", txtLHSNCode.Text)
            Kailash.AddParameter("@LabourPrintPer", Val(txtLabPrintPer.Text))
            Kailash.AddParameter("@SupplyPrintPer", Val(txtSupplyPrintPer.Text))
            'Kailash.AddParameter("@LabourPrintPer", Val(0))
            'Kailash.AddParameter("@SupplyPrintPer", Val(0))
            Kailash.AddParameter("@Remark", txtRemark.Text)
            Kailash.AddParameter("@AmountAdd", Val(0))
            Kailash.AddParameter("@AmountLess", Val(0))
            Kailash.AddParameter("@Total", Val(txtGAmt.Text))
            Kailash.AddParameter("@Paid", 0)
            Kailash.AddParameter("@PaidRemark", String.Empty)
            Kailash.AddParameter("@OrderNo", txtOrderNo.Text)

            If Not dtpOrderDate.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals("") Then
                Kailash.AddParameter("@OrderDate", Convert.ToDateTime(dtpOrderDate.Text).ToString("yyyy/MM/dd"))
            Else
                Kailash.AddParameter("@OrderDate", DBNull.Value)
            End If

            Kailash.AddParameter("@ChallanNo", txtChallanNo.Text)
            If Not dtpChallanDate.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals("") Then
                Kailash.AddParameter("@ChallanDate", Convert.ToDateTime(dtpChallanDate.Text).ToString("yyyy/MM/dd"))
            Else
                Kailash.AddParameter("@ChallanDate", DBNull.Value)
            End If

            Kailash.AddParameter("@LRNo", txtLrRrNo.Text)
            If Not dtpLrRrDate.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals("") Then
                Kailash.AddParameter("@LRDate", Convert.ToDateTime(dtpLrRrDate.Text).ToString("yyyy/MM/dd"))
            Else
                Kailash.AddParameter("@LRDate", DBNull.Value)
            End If

            Kailash.AddParameter("@VatPerFour", 0)
            Kailash.AddParameter("@VatFourAmont", 0)
            Kailash.AddParameter("@ATaxOne", 0)
            Kailash.AddParameter("@ATaxOneAmount", 0)
            Kailash.AddParameter("@VatPerTwelveFive", 0)
            Kailash.AddParameter("@VatPerTwelveFiveAmount", 0)
            Kailash.AddParameter("@ATaxTwoFive", 0)
            Kailash.AddParameter("@ATaxTwoFiveAmount", 0)
            Kailash.AddParameter("@TotalAmont", Val(txtTotalAmt.Text))
            Kailash.AddParameter("@DisFive", Val(txtLabourDisPer.Text))
            Kailash.AddParameter("@DisFiveAmount", Val(txtlabourDisAmt.Text))
            Kailash.AddParameter("@NetAmont", Val(txtNetAmt.Text))
            Kailash.AddParameter("@CstTwoPer", 0)
            Kailash.AddParameter("@CstTwoPerAmount", 0)
            Kailash.AddParameter("@Roundoff", Val(txtRoundOff.Text))
            Kailash.AddParameter("@DetailDiscount", Val(txtDiscountAmt.Text))
            Kailash.AddParameter("@isQuatation", isQuatation)
            Kailash.AddParameter("@InvoiceType", cmbInvType.Text)
            Kailash.AddParameter("@Action", IIf(IsEdit.Equals(True), 2, 1))

            Kailash.AddParameter("@GSTNo", txtGSTNo.Text)

            Kailash.AddParameter("@SGST5", Val(txtSGST5.Text))
            Kailash.AddParameter("@SGST12", Val(txtSGST12.Text))
            Kailash.AddParameter("@SGST18", Val(txtSGST18.Text))
            Kailash.AddParameter("@SGST28", Val(txtSGST28.Text))

            Kailash.AddParameter("@CGST5", Val(txtCGST5.Text))
            Kailash.AddParameter("@CGST12", Val(txtCGST12.Text))
            Kailash.AddParameter("@CGST18", Val(txtCGST18.Text))
            Kailash.AddParameter("@CGST28", Val(txtCGST28.Text))

            Kailash.AddParameter("@IGST5", Val(txtIGST5.Text))
            Kailash.AddParameter("@IGST12", Val(txtIGST12.Text))
            Kailash.AddParameter("@IGST18", Val(txtIGST18.Text))
            Kailash.AddParameter("@IGST28", Val(txtIGST28.Text))

            Kailash.AddParameter("@StateCode", Val(cmbStateName.SelectedValue))
            Kailash.AddParameter("@IwdDetails", MyDataSet.Tables(1))

            Try
                'Kailash.ExecuteNonQuery(SqlString, Kailash.ParameterList)
                EntryId = Convert.ToInt16(Kailash.ExecuteScalar(SqlString, Kailash.ParameterList))
                InwardId = EntryId
                If Not EntryId.Equals(0) Then
                    MessageBox.Show("Save Successfully.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FindId = EntryId
                    FillData()
                Else
                    MessageBox.Show("Something went wrong.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'Button5_Click(Nothing, Nothing)
                    'ClearField()
                End If

            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub btnAddNewRow_Click(sender As Object, e As EventArgs) Handles btnAddNewRow.Click, btnAddNewRow.Enter
        If MyDataSet.Tables(1).Rows.Count > 0 Then
            Dim allRow As DataRow = MyDataSet.Tables(1).NewRow
            MyDataSet.Tables(1).Rows.InsertAt(allRow, MyDataGridView1.CurrentRow.Index + 1)
            MyDataGridView1.Focus()
            MyDataGridView1.CurrentCell = MyDataGridView1(MyDataGridView1.SelectedRows(0).Cells(COlCapitalA.Name).ColumnIndex, MyDataGridView1.CurrentRow.Index + 1)
        Else
            MyDataSet.Tables(1).Rows.Add()
        End If
        MyDataSet.Tables(1).AcceptChanges()
    End Sub

    Private Sub txtParticular_TextChanged(sender As Object, e As EventArgs) Handles txtParticular.TextChanged
        If MyDataGridView1.Rows.Count > 0 Then
            MyDataGridView1.SelectedRows(0).Cells(ColItemRemark.Name).Value = txtParticular.Text
        End If
    End Sub

    Private Sub txtParticular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtParticular.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Tab) Then
            If MyDataGridView1.RowCount = 0 Then Exit Sub
            txtParticular.Text = sfuncEndVBCRLFremoved(txtParticular.Text)
            MyDataGridView1.SelectedRows(0).Cells(ColItemRemark.Name).Value = txtParticular.Text
            MyDataGridView1.Focus()
            MyDataGridView1.CurrentCell = MyDataGridView1(MyDataGridView1.SelectedRows(0).Cells(ColHSNCode.Name).ColumnIndex - 1, MyDataGridView1.SelectedRows(0).Cells(ColHSNCode.Name).RowIndex)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If EntryId = 0 Then
            Exit Sub
        Else
            If MsgBox("Are You Sure Want to Sure Delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
                Dim SqlString As String = "Delete From Inward WHere InwardId = " & EntryId & vbNewLine & "Delete From InwardDetail WHere InwardId = " & EntryId
                Kailash.ExecuteNonQuery(SqlString)
                MessageBox.Show("Entry Successfully Deleted")
                btnNew_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If isQuatation.Equals(False) Then
            ViewType = "Invoice"
        Else
            ViewType = "Quatation"
        End If

        Dim SqlString As String = "View_Inward 1,0," & isQuatation & ",null,null,null"
        Dim MyDataTable As DataTable
        MyDataTable = Kailash.ExecuteDatatable(SqlString)
        FrmView.Label1.Text = "List of Party Name"
        FrmView.MyDataGridView1.DataSource = MyDataTable

        FrmView.MyDataGridView1.Columns("PartyName").Width = 200
        FrmView.MyDataGridView1.Columns("InvoiceType").Width = 150
        FrmView.MyDataGridView1.Columns("InvoiceDate").Width = 150

        FrmView.MyDataGridView1.Columns("Vat4").Visible = False
        FrmView.MyDataGridView1.Columns("ATax1").Visible = False
        FrmView.MyDataGridView1.Columns("Vat125").Visible = False
        FrmView.MyDataGridView1.Columns("ATax25").Visible = False
        FrmView.MyDataGridView1.Columns("TaxDisCount").Visible = False
        FrmView.MyDataGridView1.Columns("LaboutPer").Visible = False
        FrmView.MyDataGridView1.Columns("LabourDiscount").Visible = False
        FrmView.MyDataGridView1.Columns("Remark").Visible = False
        FrmView.MyDataGridView1.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        FrmView.ShowDialog(Frmmain)

        If FindId.Equals(0) Then
            btnNew_Click(Nothing, Nothing)
        Else
            FillData()
        End If
    End Sub

    Private Sub FrmInvoiceGST_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Try

            Dim Id As Integer

            Try
                Id = Convert.ToInt32(Kailash.ExecuteScalar("Select * From Inward Where BillNo = '" & txtQNoCopy.Text & "' And isQuatation = 1", Nothing))
            Catch ex As Exception
                MessageBox.Show("An exception Of type " & ex.GetType().ToString() &
                        "was encountered While inserting the data." &
                        vbNewLine & ex.Message.ToString(), "Quatattion Copy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End Try

            If Id >= 0 Then
                Dim SqlString As String = "CopyRecords"
                Kailash.AddParameter("@Id", Id)
                Kailash.AddParameter("@Copytype", "Q2I")
                Kailash.ExecuteNonQuery(SqlString, Kailash.ParameterList)
                MessageBox.Show("Record Copied Successfully", "Quatattion Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnNew_Click(Nothing, Nothing)
                ClearField()
            Else

                MessageBox.Show("No Quatattion found for this No.", "Quatattion Copy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show("An exception Of type " & ex.GetType().ToString() &
                        "was encountered While inserting the data." &
                        vbNewLine & ex.Message.ToString(), "Quatattion Copy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub txtParticular_Enter(sender As Object, e As EventArgs) Handles txtParticular.Enter
        Dim position As Integer = txtParticular.Text.Length
        txtParticular.Select(position, position)
    End Sub

    Private Sub chkPerformaInvoice_Leave(sender As Object, e As EventArgs) Handles chkPerformaInvoice.Leave
        MyDataGridView1.Focus()
        MyDataGridView1.CurrentCell = MyDataGridView1(3, 0)
    End Sub

    Private Sub cmbStateName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbStateName.SelectedValueChanged
        ReCalculate()
        'cmbInvType.Focus()
    End Sub

    Private Sub cmbPartyName_Leave(sender As Object, e As EventArgs) Handles cmbPartyName.Leave
        cmbStateName.Focus()
    End Sub

    Private Sub btnTerms_Click(sender As Object, e As EventArgs) Handles btnTerms.Click
        Dim Frm As New FrmTerms
        Frm.Text = "Terms & Conditions"
        If cmbInvType.Text.Contains("LABOUR") Then
            IsLabour = True
        Else
            IsLabour = False
        End If
        PartyId = cmbPartyName.SelectedValue
        InwardId = EntryId
        Frm.StartPosition = FormStartPosition.CenterScreen
        Frm.ShowDialog()
    End Sub

    Private Sub MyDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView1.CellContentClick

    End Sub
End Class
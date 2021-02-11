Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmInvoice

    Public isQuatation As Boolean
    Dim Kailash As New DataAccessLayer
    Dim EntryId As Integer = 0
    Dim IsEdit As Boolean = False
    Dim MyDataSet As New DataSet

    Private Sub FrmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.StartPosition = FormStartPosition.CenterScreen
        txtParticular.Width = 325

        cmbInvType.Items.Clear()
        If isQuatation.Equals(False) Then
            lblQNo.Text = "Invoice No. :"
            cmbInvType.Items.Add(String.Empty)
            cmbInvType.Items.Add("TAX INVOICE")
            cmbInvType.Items.Add("RETAIL INVOICE")
            cmbInvType.Items.Add("LABOUR INVOICE")
        Else
            lblQNo.Text = "Q No. :"
            cmbInvType.Items.Add(String.Empty)
            cmbInvType.Items.Add("SUPPLY QUATATION")
            cmbInvType.Items.Add("LABOUR QUATATION")
            chkPerformaInvoice.Visible = False
        End If
        txtLabourDisPer.Text = "#0.00"
        lblLabourDisPer.Visible = False
        lbllabourDisAmt.Visible = False
        txtLabourDisPer.Visible = False
        txtlabourDisAmt.Visible = False
        btnNew_Click(Nothing, Nothing)

        txtQNo.Focus()
    End Sub

    Private Sub FrmInvoice_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbPartyName_Leave(sender As Object, e As EventArgs) Handles cmbPartyName.Leave
        cmbInvType.Focus()
    End Sub


    Public Sub ClearField()
        txtQNo.Text = ""
        txtOrderNo.Text = ""
        txtChallanNo.Text = ""
        txtLrRrNo.Text = ""
        txtParticular.Text = ""
        txtAddress.Text = ""
        txtQNoCopy.Text = ""
        dtpQDate.Value = DateTime.Now
        dtpOrderDate.Text = "" 'DateTime.Now
        dtpChallanDate.Text = "" 'DateTime.Now
        dtpLrRrDate.Text = "" 'DateTime.Now
        cmbPartyName.SelectedIndex = cmbInvType.SelectedIndex = 0
        chkPerformaInvoice.Checked = False
        txtRemark.Text = ""
        txtParticular.Text = ""
        txtGAmt.Text = ""
        txtVat4Amt.Text = ""
        txtvat125Amt.Text = ""
        txtCst2Amt.Text = ""
        txtRoundOff.Text = ""
        txtDiscountAmt.Text = ""
        txtATax1Amt.Text = ""
        txtVat25Amt.Text = ""
        txtTotalAmt.Text = ""
        txtNetAmt.Text = ""
        txtLabourDisPer.Text = ""
        txtlabourDisAmt.Text = ""
    End Sub


    Private Sub FillData()
        Try
            Dim SqlString As String = "View_Inward 2," & FindId & "," & isQuatation & ",null,null,null"
            MyDataSet = New DataSet
            MyDataSet = Kailash.ExecuteDataSet(SqlString)

            If MyDataSet.Tables(0).Rows.Count > 0 Then
                With MyDataSet.Tables(0).Rows(0)

                    txtLabourDisPer.Text = "#0.00"

                    EntryId = Val(.Item("InwardId"))
                    txtQNo.Text = .Item("BillNo").ToString()
                    dtpQDate.Value = .Item("InwardDate").ToString()
                    txtOrderNo.Text = .Item("OrderNo").ToString()
                    cmbPartyName.SelectedValue = .Item("PartyId").ToString()
                    cmbPartyName_SelectionChangeCommitted(Nothing, Nothing)

                    If .Item("OrderDate").ToString() <> String.Empty Then dtpOrderDate.Text = .Item("OrderDate").ToString()
                    txtChallanNo.Text = .Item("ChallanNo").ToString()
                    If .Item("ChallanDate").ToString() <> String.Empty Then dtpChallanDate.Text = .Item("ChallanDate").ToString()
                    txtLrRrNo.Text = .Item("LRNo").ToString()
                    If .Item("LRDate").ToString() <> String.Empty Then dtpLrRrDate.Text = .Item("LRDate").ToString()

                    txtVat4Amt.Text = .Item("VatFourAmont").ToString()
                    txtATax1Amt.Text = .Item("ATaxOneAmount").ToString()

                    txtvat125Amt.Text = .Item("VatPerTwelveFiveAmount").ToString()
                    txtVat25Amt.Text = .Item("ATaxTwoFiveAmount").ToString()

                    txtTotalAmt.Text = .Item("TotalAmont").ToString()
                    txtDiscountAmt.Text = .Item("DetailDiscount").ToString()

                    txtLabourDisPer.Text = .Item("DisFive").ToString()
                    txtlabourDisAmt.Text = .Item("DisFiveAmount").ToString()

                    txtCst2Amt.Text = .Item("CstTwoPer").ToString()
                    txtRoundOff.Text = .Item("Roundoff").ToString()
                    txtNetAmt.Text = .Item("NetAmont").ToString()
                    cmbInvType.Text = .Item("InvoiceType").ToString()
                End With
            End If
            MyDataGridView1.DataSource = MyDataSet.Tables(1)
            IsEdit = True
            txtQNo.Focus()
        Catch Ex As Exception
            MessageBox.Show(Ex.Message.ToString())
        End Try
    End Sub

    Private Sub cmbPartyName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPartyName.SelectionChangeCommitted
        txtAddress.Text = Kailash.GetValue("Select Address From PartyMaster Where PartyId= " & Val(cmbPartyName.SelectedValue))
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Kailash.ResetTextBox(Me)
        cmbPartyName.SelectedIndex = -1
        cmbInvType.SelectedIndex = -1
        chkCopyEntry.Checked = False
        chkPerformaInvoice.Checked = False
        Kailash.FillComboDataSource("select PartyId, PartyName from dbo.PartyMaster", cmbPartyName, String.Empty)
        IsEdit = False
        EntryId = 0
        MyDataGridView1.AutoGenerateColumns = False
        MyDataSet = New DataSet
        MyDataSet = Kailash.ExecuteDataSet("LIst_InwardDetails 0")
        MyDataGridView1.DataSource = MyDataSet.Tables(1)
        btnAddNewRow_Click(Nothing, Nothing)
        txtQNo.Focus()
        ClearField()
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
        FrmView.ShowDialog(Frmmain)

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

        If FindId.Equals(0) Then
            btnNew_Click(Nothing, Nothing)
        Else
            FillData()
        End If
    End Sub

    Private Sub btnAddNewRow_Click(sender As Object, e As EventArgs) Handles btnAddNewRow.Click
        If MyDataSet.Tables(1).Rows.Count > 0 Then
            Dim allRow As DataRow = MyDataSet.Tables(1).NewRow
            MyDataSet.Tables(1).Rows.InsertAt(allRow, MyDataGridView1.CurrentRow.Index + 1)
        Else
            MyDataSet.Tables(1).Rows.Add()
        End If
        MyDataSet.Tables(1).AcceptChanges()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Not EntryId.Equals(0) And chkCopyEntry.Checked Then
            Try
                Dim SqlString As String = "CopyRecords"
                Kailash.AddParameter("@Id", EntryId)
                Kailash.AddParameter("@Copytype", "")
                Kailash.ExecuteNonQuery(SqlString, Kailash.ParameterList)
                MessageBox.Show("Record Copied Successfully", "Record Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnNew_Click(Nothing, Nothing)
                ClearField()
            Catch ex As Exception
                MessageBox.Show("An exception Of type " & ex.GetType().ToString() &
                            "was encountered While inserting the data." &
                            vbNewLine & ex.Message.ToString(), "Record Copy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try

        Else

            If txtQNo.Text.Equals(String.Empty) Then
                MessageBox.Show("Please Enter " & IIf(isQuatation.Equals(False), "Invoice", "Quatation ") & "No.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtQNo.Focus()
                Exit Sub
            End If

            If cmbPartyName.SelectedIndex = 0 Or cmbPartyName.Text = "" Then
                MessageBox.Show("Please Select Party", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbPartyName.Focus()
                Exit Sub
            End If

            If cmbInvType.SelectedIndex = 0 Or cmbInvType.Text = "" Then
                MessageBox.Show("Please Select Invoice Type", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbInvType.Focus()
                Exit Sub
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
            Kailash.AddParameter("@InwardDate", dtpQDate.Value.ToString("yyyy/MM/dd"))
            Kailash.AddParameter("@CenterId", Val(0))
            Kailash.AddParameter("@BillNo", txtQNo.Text)
            Kailash.AddParameter("@Remark", txtRemark.Text)
            Kailash.AddParameter("@AmountAdd", Val(0))
            Kailash.AddParameter("@AmountLess", Val(0))
            Kailash.AddParameter("@Total", Val(txtTotalAmt.Text))
            Kailash.AddParameter("@Paid", 0)
            Kailash.AddParameter("@PaidRemark", String.Empty)
            Kailash.AddParameter("@OrderNo", txtOrderNo.Text)
            Kailash.AddParameter("@OrderDate", dtpOrderDate.Text.ToString("yyyy/MM/dd"))
            Kailash.AddParameter("@ChallanNo", txtChallanNo.Text)
            Kailash.AddParameter("@ChallanDate", dtpChallanDate.Text.ToString("yyyy/MM/dd"))
            Kailash.AddParameter("@LRNo", txtLrRrNo.Text)
            Kailash.AddParameter("@LRDate", dtpLrRrDate.Text.ToString("yyyy/MM/dd"))
            Kailash.AddParameter("@VatPerFour", 4)
            Kailash.AddParameter("@VatFourAmont", Val(txtVat4Amt.Text))
            Kailash.AddParameter("@ATaxOne", 1)
            Kailash.AddParameter("@ATaxOneAmount", Val(txtATax1Amt.Text))
            Kailash.AddParameter("@VatPerTwelveFive", Val(12.5))
            Kailash.AddParameter("@VatPerTwelveFiveAmount", Val(txtvat125Amt.Text))
            Kailash.AddParameter("@ATaxTwoFive", Val(2.5))
            Kailash.AddParameter("@ATaxTwoFiveAmount", Val(txtVat25Amt.Text))
            Kailash.AddParameter("@TotalAmont", Val(txtTotalAmt.Text))
            Kailash.AddParameter("@DisFive", Val(txtLabourDisPer.Text))
            Kailash.AddParameter("@DisFiveAmount", Val(txtlabourDisAmt.Text))
            Kailash.AddParameter("@NetAmont", Val(txtNetAmt.Text))
            Kailash.AddParameter("@CstTwoPer", Val(2))
            Kailash.AddParameter("@Roundoff", Val(txtRoundOff.Text))
            Kailash.AddParameter("@DetailDiscount", Val(txtDiscountAmt.Text))
            Kailash.AddParameter("@isQuatation", isQuatation)
            Kailash.AddParameter("@InvoiceType", cmbInvType.Text)
            Kailash.AddParameter("@Action", IIf(IsEdit.Equals(True), 2, 1))
            Kailash.AddParameter("@IwdDetails", MyDataSet.Tables(1))

            Try
                Kailash.ExecuteNonQuery(SqlString, Kailash.ParameterList)
                btnNew_Click(Nothing, Nothing)
                ClearField()
            Catch ex As Exception
                Exit Sub
            End Try

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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Val(cmbInvType.SelectedValue) <> 0 Then

            If cmbInvType.Text = "LABOUR INVOICE" Or cmbInvType.Text = "LABOUR QUATATION" Then

                Dim RD As New ReportDocument
                Dim path As String = Application.StartupPath & "\InvLabour.rpt"

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
                    crParameterDiscreteValue1.Value = "QUATATION / ESTIMATE"
                End If
                crParameterFieldDefinition1 = crParameterFieldDefinitions("invType")
                crParameterValues1 = crParameterFieldDefinition1.CurrentValues

                crParameterValues1.Clear()
                crParameterValues1.Add(crParameterDiscreteValue1)
                crParameterFieldDefinition1.ApplyCurrentValues(crParameterValues1)

                Kailash.SetDBLogonForReport(RD)

                FrmReportViewer.CrystalReportViewer1.ReportSource = RD

                FrmReportViewer.CrystalReportViewer1.ShowRefreshButton = True
                FrmReportViewer.Show()
            Else
                Dim RD As New ReportDocument()
                Dim path As String = Application.StartupPath & "\Inv.rpt"

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

                    If (chkPerformaInvoice.Checked = True) Then
                        crParameterDiscreteValue1.Value = "PERFORMA INVOICE"
                    Else
                        crParameterDiscreteValue1.Value = cmbInvType.Text
                    End If
                Else
                    crParameterDiscreteValue1.Value = "QUATATION / ESTIMATE"
                End If

                crParameterFieldDefinition1 = crParameterFieldDefinitions("invType")
                crParameterValues1 = crParameterFieldDefinition1.CurrentValues
                crParameterValues1.Clear()
                crParameterValues1.Add(crParameterDiscreteValue1)
                crParameterFieldDefinition1.ApplyCurrentValues(crParameterValues1)

                FrmReportViewer.CrystalReportViewer1.ReportSource = RD
                FrmReportViewer.CrystalReportViewer1.ShowRefreshButton = True

                FrmReportViewer.Show()

            End If
        Else
            MessageBox.Show("Please Select InvoiceType")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
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

        'Dim dtGrid As DataTable = MyDataSet.Tables(1)
        Dim dtGrid As DataTable = MyDataGridView1.DataSource
        Dim Vat2 As Double = 0, Vat5 As Double = 0, Vat15 As Double = 0, GAmount As Double = 0, Discont As Double = 0
        For Each dr As DataRow In dtGrid.Rows
            If dr("Vatper").ToString() IsNot Nothing And Not dr("Vatper").ToString().Equals("") Then
                If Convert.ToDecimal(dr("Vatper").ToString()) = 2 Then
                    Vat2 = Vat2 + Val(dr("VatAmount").ToString())
                ElseIf Convert.ToDecimal(dr("Vatper").ToString()) = 5 Then
                    Vat5 = Vat5 + Val(dr("VatAmount").ToString())
                ElseIf Convert.ToDecimal(dr("Vatper").ToString()) = 15 Then
                    Vat15 = Vat15 + Val(dr("VatAmount").ToString())
                End If
            End If

            If dr("Dis").ToString() IsNot Nothing Then
                Discont = Discont + Val(dr("DisAmount").ToString())
            End If
            GAmount = GAmount + Val(dr("Amount").ToString())
        Next
        txtGAmt.Text = GAmount.ToString("#0.00")
        txtVat4Amt.Text = ((4 * Vat5) / 5).ToString("#0.00")
        txtATax1Amt.Text = ((1 * Vat5) / 5).ToString("#0.00")
        txtvat125Amt.Text = ((12.5 * Vat15) / 15).ToString("#0.00")
        txtVat25Amt.Text = ((2.5 * Vat15) / 15).ToString("#0.00")
        txtCst2Amt.Text = Vat2.ToString("#0.00")

        txtDiscountAmt.Text = Discont.ToString("#0.00")
        txtTotalAmt.Text = (GAmount - (Vat2 + Vat5 + Vat15)).ToString("#0.00")

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
            Roff -= Val(NetAmt) - roudedVal
            txtRoundOff.Text = Roff.ToString("#0.00")
            txtNetAmt.Text = roudedVal.ToString("#0.00")
        End If
        'Roundoff = Roff
        'NetAmont = roudedVal
        'txtRounfOff.Text = (Math.Round(Val(txtGAmount.Text)) - Val(txtGAmount.Text)).ToString("#0.00")
        'txtNetAmount.Text = Val(Math.Round(Val(txtGAmount.Text))).ToString("#0.00")
    End Sub


    Private Sub txtLabourDisPer_TextChanged(sender As Object, e As EventArgs) Handles txtLabourDisPer.TextChanged
        ReCalculate()
    End Sub

    Private Sub txtLabourDisPer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLabourDisPer.KeyPress
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


    Private Sub cmbInvType_TextChanged(sender As Object, e As EventArgs) Handles cmbInvType.TextChanged
        If isQuatation.Equals(False) Then
            If cmbInvType.Text = "LABOUR INVOICE" Then
                lblLabourDisPer.Visible = True
                lbllabourDisAmt.Visible = True
                txtLabourDisPer.Visible = True
                txtlabourDisAmt.Visible = True
            Else
                lblLabourDisPer.Visible = False
                lbllabourDisAmt.Visible = False
                txtLabourDisPer.Visible = False
                txtlabourDisAmt.Visible = False
                txtLabourDisPer.Text = txtlabourDisAmt.Text = Val("0").ToString("#0.00")
            End If
        Else
            If cmbInvType.Text = "LABOUR QUATATION" Then
                lblLabourDisPer.Visible = True
                lbllabourDisAmt.Visible = True
                txtLabourDisPer.Visible = True
                txtlabourDisAmt.Visible = True
            Else
                lblLabourDisPer.Visible = False
                lbllabourDisAmt.Visible = False
                txtLabourDisPer.Visible = False
                txtlabourDisAmt.Visible = False
                txtLabourDisPer.Text = txtlabourDisAmt.Text = Val("0").ToString("#0.00")
            End If
        End If
    End Sub

    Private Sub MyDataGridView1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView1.CellLeave
        If MyDataGridView1.Columns(e.ColumnIndex).Name = smalla.Name Then
            txtParticular.Focus()
        End If
    End Sub

    Private Sub MyDataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles MyDataGridView1.CurrentCellDirtyStateChanged
        'If MyDataGridView1.IsCurrentCellDirty Then
        '    MyDataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        '    'MyDataSet.Tables(1).AcceptChanges()
        'End If
    End Sub

    Private Sub txtParticular_TextChanged(sender As Object, e As EventArgs) Handles txtParticular.TextChanged
        MyDataGridView1.SelectedRows(0).Cells(ItemRemark.Name).Value = txtParticular.Text
    End Sub

    Private Sub txtParticular_Leave(sender As Object, e As EventArgs) Handles txtParticular.Leave
        If MyDataGridView1.RowCount = 0 Then Exit Sub
        'MyDataGridView1.SelectedRows(0).Cells(ColUnit.Name).Selected = True
        MyDataGridView1.Focus()
        MyDataGridView1.CurrentCell = MyDataGridView1(MyDataGridView1.SelectedRows(0).Cells(Unit.Name).ColumnIndex, MyDataGridView1.SelectedRows(0).Cells(Unit.Name).RowIndex)
    End Sub

    Private Sub MyDataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView1.CellEndEdit
        If e.RowIndex = -1 Then Exit Sub

        If MyDataGridView1.Columns(e.ColumnIndex).Name = CapitalA.Name Then
            With MyDataGridView1.Rows(e.RowIndex)
                .Cells(CapitalAHidden.Name).Value = .Cells(CapitalA.Name).Value.ToString()
            End With
        End If

        With MyDataGridView1.Rows(e.RowIndex)
            If .Cells(Rate.Name).Value Is Nothing Then
                .Cells(Rate.Name).Value = "0"
            End If
            If .Cells(Dis.Name).Value Is Nothing Then
                .Cells(Dis.Name).Value = "0"
            End If
            If .Cells(Vatper.Name).Value Is Nothing Then
                .Cells(Vatper.Name).Value = "0"
            End If
            If .Cells(DisAmount.Name).Value Is Nothing Then
                .Cells(DisAmount.Name).Value = "0"
            End If
            If .Cells(VatAmount.Name).Value Is Nothing Then
                .Cells(VatAmount.Name).Value = "0"
            End If
        End With

        If MyDataGridView1.Columns(e.ColumnIndex).Name = Qty.Name Then
            With MyDataGridView1.Rows(e.RowIndex)
                .Cells(Amount.Name).Value = Math.Round(Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString()), 2)

                .Cells(DisAmount.Name).Value = Math.Round((((Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString())) * Val(.Cells(Dis.Name).Value.ToString())) / 100), 2)
                .Cells(Amount.Name).Value = Math.Round((((Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString())) - Val(.Cells(DisAmount.Name).Value.ToString())) - Val(.Cells(VatAmount.Name).Value.ToString())), 2)

                .Cells(VatAmount.Name).Value = Math.Round(((((Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString())) - Val(.Cells(DisAmount.Name).Value.ToString())) * Val(.Cells(Vatper.Name).Value.ToString())) / 100), 2)
                .Cells(Amount.Name).Value = Math.Round(((((Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString())) - Val(.Cells(DisAmount.Name).Value.ToString())) - Val(.Cells(VatAmount.Name).Value.ToString()))), 2)
            End With
        End If

        If MyDataGridView1.Columns(e.ColumnIndex).Name = Rate.Name Then
            With MyDataGridView1.Rows(e.RowIndex)
                .Cells(Amount.Name).Value = Math.Round(Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString()), 2)

                .Cells(DisAmount.Name).Value = Math.Round((((Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString())) * Val(.Cells(Dis.Name).Value.ToString())) / 100), 2)
                '.Cells(ColAmount.Name).Value = Math.Round((((Val(.Cells(ColQty.Name).Value.ToString()) * Val(.Cells(ColRate.Name).Value.ToString())) - Val(.Cells(ColDisAmount.Name).Value.ToString())) - Val(.Cells(ColVatAmount.Name).Value.ToString())), 2)

                .Cells(VatAmount.Name).Value = Math.Round(((((Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString())) - Val(.Cells(DisAmount.Name).Value.ToString())) * Val(.Cells(Vatper.Name).Value.ToString())) / 100), 2)
                .Cells(Amount.Name).Value = Math.Round(((((Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString())) - Val(.Cells(DisAmount.Name).Value.ToString())) - Val(.Cells(VatAmount.Name).Value.ToString()))), 2)
            End With

        End If

        If MyDataGridView1.Columns(e.ColumnIndex).Name = Dis.Name Then
            With MyDataGridView1.Rows(e.RowIndex)
                .Cells(DisAmount.Name).Value = Math.Round((((Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString())) * Val(.Cells(Dis.Name).Value.ToString())) / 100), 2)
                '.Cells(ColAmount.Name).Value = Math.Round((((Val(.Cells(ColQty.Name).Value.ToString()) * Val(.Cells(ColRate.Name).Value.ToString())) - Val(.Cells(ColDisAmount.Name).Value.ToString())) - Val(.Cells(ColVatAmount.Name).Value.ToString())), 2)

                .Cells(VatAmount.Name).Value = Math.Round(((((Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString())) - Val(.Cells(DisAmount.Name).Value.ToString())) * Val(.Cells(Vatper.Name).Value.ToString())) / 100), 2)
                .Cells(Amount.Name).Value = Math.Round(((((Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString())) - Val(.Cells(DisAmount.Name).Value.ToString())) - Val(.Cells(VatAmount.Name).Value.ToString()))), 2)
            End With

        End If

        If MyDataGridView1.Columns(e.ColumnIndex).Name = Vatper.Name Then
            With MyDataGridView1.Rows(e.RowIndex)
                .Cells(VatAmount.Name).Value = Math.Round(((((Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString())) - Val(.Cells(DisAmount.Name).Value.ToString())) * Val(.Cells(Vatper.Name).Value.ToString())) / 100), 2)
                .Cells(Amount.Name).Value = Math.Round(((((Val(.Cells(Qty.Name).Value.ToString()) * Val(.Cells(Rate.Name).Value.ToString())) - Val(.Cells(DisAmount.Name).Value.ToString())) - Val(.Cells(VatAmount.Name).Value.ToString()))), 2)
            End With
        End If
        'MyDataSet.Tables(1).AcceptChanges()
        'MyDataGridView1.DataSource = MyDataSet.Tables(1)

        'If MyDataSet.Tables(1).Columns("CapitalAHidden") Is Nothing Then
        '    MyDataSet.Tables(1).Columns.Add("CapitalAHidden")
        '    MyDataSet.Tables(1).AcceptChanges()
        'End If

        ReCalculate()

        ''Dim Total5Prct As Decimal = Val(MyDataSet.Tables(1).Compute("SUM(VatAmount)", "Vatper=5").ToString()).ToString("#0.00")
        ''Dim Total15Prct As Decimal = Val(MyDataSet.Tables(1).Compute("SUM(VatAmount)", "Vatper=15").ToString()).ToString("#0.00")
        ''txtGAmount.Text = Val(MyDataSet.Tables(1).Compute("SUM(Amount)", String.Empty).ToString()).ToString("#0.00")
        ''TxtVat4Prct.Text = ((4 * Total5Prct) / 5).ToString("#0.00")
        ''txtATex1PRct.Text = ((1 * Total5Prct) / 5).ToString("#0.00")
        ''txtVAT125Prct.Text = ((12.5 * Total15Prct) / 15).ToString("#0.00")
        ''txtAVat25Prct.Text = ((2.5 * Total15Prct) / 15).ToString("#0.00")
        ''txtCST.Text = Val(MyDataSet.Tables(1).Compute("SUM(VatAmount)", "Vatper=2").ToString()).ToString("#0.00")

        'Dim dtGrid As DataTable = MyDataSet.Tables(1) 'MyDataGridView1.DataSource
        'Dim Vat2 As Double = 0, Vat5 As Double = 0, Vat15 As Double = 0, GAmount As Double = 0
        'For Each dr As DataRow In dtGrid.Rows
        '    If dr("Vatper").ToString() = "2" Then
        '        Vat2 = Vat2 + Val(dr("VatAmount").ToString())
        '    ElseIf dr("Vatper").ToString() = "5" Then
        '        Vat5 = Vat5 + Val(dr("VatAmount").ToString())
        '    ElseIf dr("Vatper").ToString() = "15" Then
        '        Vat15 = Vat15 + Val(dr("VatAmount").ToString())
        '    End If
        '    GAmount = GAmount + Val(dr("Amount").ToString())
        'Next
        'txtGAmount.Text = GAmount
        'TxtVat4Prct.Text = ((4 * Vat5) / 5).ToString("#0.00")
        'txtATex1PRct.Text = ((1 * Vat5) / 5).ToString("#0.00")
        'txtVAT125Prct.Text = ((12.5 * Vat15) / 15).ToString("#0.00")
        'txtAVat25Prct.Text = ((2.5 * Vat15) / 15).ToString("#0.00")
        'txtCST.Text = Vat2.ToString("#0.00")

        'txtRounfOff.Text = (Math.Round(Val(txtGAmount.Text)) - Val(txtGAmount.Text)).ToString("#0.00")
        'txtNetAmount.Text = Val(Math.Round(Val(txtGAmount.Text))).ToString("#0.00")


    End Sub

    Private Sub MyDataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView1.KeyDown
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
                    btnAddNewRow_Click(Nothing, Nothing)
                    MyDataGridView1.CurrentCell = MyDataGridView1(CapitalA.Name, iRow + 1)
                End If
            End If

        ElseIf e.KeyCode = Keys.Delete Then
            If MyDataGridView1.Rows.Count = 1 Then Exit Sub
            For Each row As DataGridViewRow In MyDataGridView1.SelectedRows
                If (MyDataGridView1.Rows.Count > 1) Then
                    MyDataSet.Tables(1).Rows.RemoveAt(row.Index)
                    MyDataSet.Tables(1).AcceptChanges()
                    'MyDataGridView1.Rows.Remove(row)
                    ReCalculate()
                End If
            Next
        End If
    End Sub

    Private Sub chkPerformaInvoice_Leave(sender As Object, e As EventArgs) Handles chkPerformaInvoice.Leave
        If MyDataGridView1.RowCount = 0 Then Exit Sub
        MyDataGridView1.Focus()
        MyDataGridView1.CurrentCell = MyDataGridView1(MyDataGridView1.SelectedRows(0).Cells(CapitalA.Name).ColumnIndex, MyDataGridView1.SelectedRows(0).Cells(CapitalA.Name).RowIndex)
    End Sub

    Private Sub MyDataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles MyDataGridView1.SelectionChanged
        If MyDataGridView1.RowCount = 0 Then Exit Sub
        If MyDataGridView1.SelectedRows.Count = 0 Then Exit Sub
        If MyDataGridView1.SelectedRows(0).Cells(ItemRemark.Name).Value IsNot Nothing And Not IsDBNull(MyDataGridView1.SelectedRows(0).Cells(ItemRemark.Name).Value) Then
            txtParticular.Text = MyDataGridView1.SelectedRows(0).Cells(ItemRemark.Name).Value.ToString()
        Else
            txtParticular.Text = ""
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
End Class
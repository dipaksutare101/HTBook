Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmInvop
    Public isQuatation As Boolean
    Dim Kailash As New DataAccessLayer
    Dim EntryId As Integer = 0
    Dim IsEdit As Boolean = False
    Dim MyDataSet As New DataSet

    Private Sub FrmQuatation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyTextBox6.Width = 38
        MyTextBox5.Width = 400
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
            chkPerfomaInvoice.Visible = False
        End If
        txtLabourDisPer.Text = "#0.00"
        lblLabourDisPer.Visible = False
        lblLabourDisAmt.Visible = False
        txtLabourDisPer.Visible = False
        txtLabourDisAmt.Visible = False
        Button5_Click(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Kailash.ResetTextBox(Me)
        cmbPartyName.SelectedIndex = -1
        cmbInvType.SelectedIndex = -1
        ChkCopyEntry.Checked = False
        chkPerfomaInvoice.Checked = False
        Kailash.FillComboDataSource("select PartyId, PartyName from dbo.PartyMaster", cmbPartyName, String.Empty)
        IsEdit = False
        EntryId = 0
        MyDataSet = New DataSet
        MyDataSet = Kailash.ExecuteDataSet("LIst_InwardDetails 0")
        MyDataGridView1.DataSource = MyDataSet.Tables(1)
        btnAddRow_Click(Nothing, Nothing)
        txtQNo.Focus()
        ClearField()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If Not EntryId.Equals(0) And ChkCopyEntry.Checked Then
            Try
                Dim SqlString As String = "CopyRecords"
                Kailash.AddParameter("@Id", EntryId)
                Kailash.AddParameter("@Copytype", "")
                Kailash.ExecuteNonQuery(SqlString, Kailash.ParameterList)
                MessageBox.Show("Record Copied Successfully", "Record Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Button5_Click(Nothing, Nothing)
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

            If Not DtpQdate.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals("") Then
                Kailash.AddParameter("@InwardDate", Convert.ToDateTime(DtpQdate.Text).ToString("yyyy/MM/dd"))
            Else
                Kailash.AddParameter("@InwardDate", DBNull.Value)
            End If
            'Kailash.AddParameter("@InwardDate", IIf(Not DtpQdate.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals(""), Convert.ToDateTime(DtpQdate.Text).ToString("yyyy/MM/dd"), DBNull.Value))

            Kailash.AddParameter("@CenterId", Val(0))
            Kailash.AddParameter("@BillNo", txtQNo.Text)
            Kailash.AddParameter("@Remark", txtRemark.Text)
            Kailash.AddParameter("@AmountAdd", Val(0))
            Kailash.AddParameter("@AmountLess", Val(0))
            Kailash.AddParameter("@Total", Val(txtGAmount.Text))
            Kailash.AddParameter("@Paid", 0)
            Kailash.AddParameter("@PaidRemark", String.Empty)
            Kailash.AddParameter("@OrderNo", txtOrderNo.Text)

            If Not DtpOrderDate.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals("") Then
                Kailash.AddParameter("@OrderDate", Convert.ToDateTime(DtpOrderDate.Text).ToString("yyyy/MM/dd"))
            Else
                Kailash.AddParameter("@OrderDate", DBNull.Value)
            End If
            'Kailash.AddParameter("@OrderDate", IIf(Not DtpOrderDate.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals(""), Convert.ToDateTime(DtpOrderDate.Text).ToString("yyyy/MM/dd"), DBNull.Value))

            Kailash.AddParameter("@ChallanNo", txtChallanNo.Text)
            If Not dtpChallanDate.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals("") Then
                Kailash.AddParameter("@ChallanDate", Convert.ToDateTime(dtpChallanDate.Text).ToString("yyyy/MM/dd"))
            Else
                Kailash.AddParameter("@ChallanDate", DBNull.Value)
            End If
            'Kailash.AddParameter("@ChallanDate", IIf(Not dtpChallanDate.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals(""), Convert.ToDateTime(dtpChallanDate.Text).ToString("yyyy/MM/dd"), DBNull.Value))

            Kailash.AddParameter("@LRNo", txtLrRrNo.Text)
            If Not dtpLrRrDate.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals("") Then
                Kailash.AddParameter("@LRDate", Convert.ToDateTime(dtpLrRrDate.Text).ToString("yyyy/MM/dd"))
            Else
                Kailash.AddParameter("@LRDate", DBNull.Value)
            End If
            'Kailash.AddParameter("@LRDate", IIf(Not dtpLrRrDate.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals(""), Convert.ToDateTime(dtpLrRrDate.Text).ToString("yyyy/MM/dd"), DBNull.Value))

            Kailash.AddParameter("@VatPerFour", IIf(Val(TxtVat4Prct.Text) = 0, Val(0), Val(4)))
            Kailash.AddParameter("@VatFourAmont", Val(TxtVat4Prct.Text))

            Kailash.AddParameter("@ATaxOne", IIf(Val(txtATex1PRct.Text) = 0, Val(0), Val(1)))
            Kailash.AddParameter("@ATaxOneAmount", Val(txtATex1PRct.Text))

            Kailash.AddParameter("@VatPerTwelveFive", IIf(Val(txtVAT125Prct.Text) = 0, Val(0), Val(12.5)))
            Kailash.AddParameter("@VatPerTwelveFiveAmount", Val(txtVAT125Prct.Text))

            Kailash.AddParameter("@ATaxTwoFive", IIf(Val(txtAVat25Prct.Text) = 0, Val(0), Val(2.5)))
            Kailash.AddParameter("@ATaxTwoFiveAmount", Val(txtAVat25Prct.Text))

            Kailash.AddParameter("@TotalAmont", Val(txtTotalAmount.Text))
            Kailash.AddParameter("@DisFive", Val(txtLabourDisPer.Text))
            Kailash.AddParameter("@DisFiveAmount", Val(txtLabourDisAmt.Text))
            Kailash.AddParameter("@NetAmont", Val(txtNetAmount.Text))

            Kailash.AddParameter("@CstTwoPer", IIf(Val(txtCST.Text) = 0, 0, Val(2)))
            Kailash.AddParameter("@CstTwoPerAmount", Val(txtCST.Text))

            Kailash.AddParameter("@Roundoff", Val(txtRounfOff.Text))
            Kailash.AddParameter("@DetailDiscount", Val(txtDiscount.Text))
            Kailash.AddParameter("@isQuatation", isQuatation)
            Kailash.AddParameter("@InvoiceType", cmbInvType.Text)
            Kailash.AddParameter("@Action", IIf(IsEdit.Equals(True), 2, 1))

            Kailash.AddParameter("@GSTNo", "")

            Kailash.AddParameter("@SGST5", Val(0))
            Kailash.AddParameter("@SGST12", Val(0))
            Kailash.AddParameter("@SGST18", Val(0))
            Kailash.AddParameter("@SGST28", Val(0))

            Kailash.AddParameter("@CGST5", Val(0))
            Kailash.AddParameter("@CGST12", Val(0))
            Kailash.AddParameter("@CGST18", Val(0))
            Kailash.AddParameter("@CGST28", Val(0))

            Kailash.AddParameter("@IGST5", Val(0))
            Kailash.AddParameter("@IGST12", Val(0))
            Kailash.AddParameter("@IGST18", Val(0))
            Kailash.AddParameter("@IGST28", Val(0))

            Kailash.AddParameter("@StateCode", Val(0))

            Kailash.AddParameter("@IwdDetails", MyDataSet.Tables(1))

            Try
                'Kailash.ExecuteNonQuery(SqlString, Kailash.ParameterList)
                EntryId = Convert.ToInt16(Kailash.ExecuteScalar(SqlString, Kailash.ParameterList))
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

    Public Sub ClearField()
        txtQNo.Text = ""
        txtOrderNo.Text = ""
        txtChallanNo.Text = ""
        txtLrRrNo.Text = ""
        MyTextBox5.Text = ""
        MyTextBox6.Text = ""
        txtCopyQ.Text = ""
        DtpQdate.Text = "" 'String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        DtpOrderDate.Text = "" 'DateTime.Now
        dtpChallanDate.Text = "" 'DateTime.Now
        dtpLrRrDate.Text = "" 'DateTime.Now
        cmbPartyName.SelectedIndex = cmbInvType.SelectedIndex = 0
        chkPerfomaInvoice.Checked = False
        txtRemark.Text = ""
        txtGAmount.Text = ""
        TxtVat4Prct.Text = ""
        txtVAT125Prct.Text = ""
        txtCST.Text = ""
        txtRounfOff.Text = ""
        txtDiscount.Text = ""
        txtATex1PRct.Text = ""
        txtAVat25Prct.Text = ""
        txtTotalAmount.Text = ""
        txtNetAmount.Text = ""
        txtLabourDisPer.Text = ""
        txtLabourDisAmt.Text = ""
    End Sub

    Private Sub btnAddRow_Click(sender As Object, e As EventArgs) Handles btnAddRow.Click, btnAddRow.Enter
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

    Private Sub MyDataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles MyDataGridView1.CurrentCellDirtyStateChanged
        'If MyDataGridView1.IsCurrentCellDirty Then
        '    MyDataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        '    'MyDataSet.Tables(1).AcceptChanges()
        'End If
    End Sub
    Private Sub MyDataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView1.CellEndEdit

        If e.RowIndex = -1 Then Exit Sub

        If MyDataGridView1.Columns(e.ColumnIndex).Name = COlCapitalA.Name Then
            With MyDataGridView1.Rows(e.RowIndex)
                .Cells(CapitalAHidden.Name).Value = .Cells(COlCapitalA.Name).Value.ToString()
            End With
        End If

        If MyDataGridView1.Columns(e.ColumnIndex).Name = ColQty.Name Or MyDataGridView1.Columns(e.ColumnIndex).Name = ColRate.Name Or MyDataGridView1.Columns(e.ColumnIndex).Name = ColDis.Name Or MyDataGridView1.Columns(e.ColumnIndex).Name = ColVatper.Name Then
            With MyDataGridView1.Rows(e.RowIndex)
                .Cells(ColAmount.Name).Value = Math.Round(Val(.Cells(ColQty.Name).Value.ToString()) * Val(.Cells(ColRate.Name).Value.ToString()), 2)
                .Cells(ColDisAmount.Name).Value = Math.Round((((Val(.Cells(ColQty.Name).Value.ToString()) * Val(.Cells(ColRate.Name).Value.ToString())) * Val(.Cells(ColDis.Name).Value.ToString())) / 100), 2)
                .Cells(ColVatAmount.Name).Value = Math.Round(((((Val(.Cells(ColQty.Name).Value.ToString()) * Val(.Cells(ColRate.Name).Value.ToString())) - Val(.Cells(ColDisAmount.Name).Value.ToString())) * Val(.Cells(ColVatper.Name).Value.ToString())) / 100), 2)
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
        For Each dr As DataRow In dtGrid.Rows
            If dr("Vatper").ToString() IsNot Nothing And Not dr("Vatper").ToString().Equals("") Then
                If Convert.ToDecimal(dr("Vatper").ToString()) = 2 Then
                    Vat2 = Vat2 + Val(dr("VatAmount").ToString())
                ElseIf Convert.ToDecimal(dr("Vatper").ToString()) = 5 Then
                    Vat5 = Vat5 + Val(dr("VatAmount").ToString())
                ElseIf Convert.ToDecimal(dr("Vatper").ToString()) = 15 Then
                    Vat15 = Vat15 + Val(dr("VatAmount").ToString())
                End If
            ElseIf dr("ItemRemark").ToString() IsNot Nothing Then
                dr("ItemRemark") = dr("ItemRemark").ToString.Trim()
            End If

            If dr("Dis").ToString() IsNot Nothing Then
                Discont = Discont + Val(dr("DisAmount").ToString())
            End If
            GAmount = GAmount + Val(dr("Amount").ToString())
        Next
        txtGAmount.Text = GAmount.ToString("#0.00")
        TxtVat4Prct.Text = ((4 * Vat5) / 5).ToString("#0.00")
        txtATex1PRct.Text = ((1 * Vat5) / 5).ToString("#0.00")
        txtVAT125Prct.Text = ((12.5 * Vat15) / 15).ToString("#0.00")
        txtAVat25Prct.Text = ((2.5 * Vat15) / 15).ToString("#0.00")
        txtCST.Text = Vat2.ToString("#0.00")

        txtDiscount.Text = Discont.ToString("#0.00")

        txtTotalAmount.Text = ((GAmount - Discont) + (Vat2 + Vat5 + Vat15)).ToString("#0.00")

        Dim roudedVal As Decimal = Math.Round(Val(txtTotalAmount.Text), MidpointRounding.AwayFromZero) '// rounded value
        Dim Roff As Decimal = 0
        Roff -= Val(txtTotalAmount.Text) - roudedVal

        txtRounfOff.Text = Roff.ToString("#0.00")
        txtNetAmount.Text = roudedVal.ToString("#0.00")

        Dim NetAmt As Decimal = 0
        If txtLabourDisPer.Visible = True Then
            Dim DisPer As Decimal = 0, DisAmt As Decimal = 0, TotalAmt As Decimal = 0
            TotalAmt = Val(txtTotalAmount.Text)
            DisPer = Val(txtLabourDisPer.Text)
            DisAmt = Math.Round((TotalAmt * DisPer) / 100, 2)
            txtLabourDisAmt.Text = Val(DisAmt).ToString("#0.00")
            NetAmt = TotalAmt - DisAmt

            roudedVal = Math.Round(Val(NetAmt), MidpointRounding.AwayFromZero) '// rounded value
            Roff -= Val(NetAmt) - roudedVal
            txtRounfOff.Text = Roff.ToString("#0.00")
            txtNetAmount.Text = roudedVal.ToString("#0.00")
        End If
        'Roundoff = Roff
        'NetAmont = roudedVal
        'txtRounfOff.Text = (Math.Round(Val(txtGAmount.Text)) - Val(txtGAmount.Text)).ToString("#0.00")
        'txtNetAmount.Text = Val(Math.Round(Val(txtGAmount.Text))).ToString("#0.00")
    End Sub

    Private Sub MyDataGridView1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView1.CellLeave
        If MyDataGridView1.Columns(e.ColumnIndex).Name = Colsmalla.Name Then
            MyTextBox5.Focus()
            'ElseIf MyDataGridView1.Columns(e.ColumnIndex).Name = ColVatper.Name Then
            '    Dim allRow As DataRow = MyDataSet.Tables(1).NewRow
            '    MyDataSet.Tables(1).Rows.InsertAt(allRow, MyDataGridView1.CurrentRow.Index + 1)
            '    MyDataGridView1.Focus()
            '    MyDataGridView1.CurrentCell = MyDataGridView1(MyDataGridView1.SelectedRows(0).Cells(COlCapitalA.Name).ColumnIndex, MyDataGridView1.CurrentRow.Index + 1)
            '    MyDataSet.Tables(1).AcceptChanges()
            '    'btnAddRow_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub MyTextBox5_TextChanged(sender As Object, e As EventArgs) Handles MyTextBox5.TextChanged
        MyDataGridView1.SelectedRows(0).Cells(ColItemRemark.Name).Value = MyTextBox5.Text
    End Sub

    'Private Sub MyTextBox5_Leave(sender As Object, e As EventArgs) Handles MyTextBox5.Leave
    '    'If MyDataGridView1.RowCount = 0 Then Exit Sub
    '    'MyDataGridView1.Focus()
    '    'MyDataGridView1.CurrentCell = MyDataGridView1(MyDataGridView1.SelectedRows(0).Cells(ColUnit.Name).ColumnIndex, MyDataGridView1.SelectedRows(0).Cells(ColUnit.Name).RowIndex)
    'End Sub

    'Private Sub MyTextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles MyTextBox5.KeyDown
    '    If MyDataGridView1.RowCount = 0 Then Exit Sub
    '    If e.KeyCode = Keys.Enter Then
    '        MyDataGridView1.Focus()
    '        MyDataGridView1.CurrentCell = MyDataGridView1(MyDataGridView1.SelectedRows(0).Cells(ColUnit.Name).ColumnIndex, MyDataGridView1.SelectedRows(0).Cells(ColUnit.Name).RowIndex)
    '    ElseIf e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
    '        MyTextBox5.Focus()
    '        'MessageBox.Show("test")
    '    End If
    'End Sub

    Private Sub MyTextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyTextBox5.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            If MyDataGridView1.RowCount = 0 Then Exit Sub
            MyTextBox5.Text = sfuncEndVBCRLFremoved(MyTextBox5.Text)
            MyDataGridView1.SelectedRows(0).Cells(ColItemRemark.Name).Value = MyTextBox5.Text
            MyDataGridView1.Focus()
            MyDataGridView1.CurrentCell = MyDataGridView1(MyDataGridView1.SelectedRows(0).Cells(ColUnit.Name).ColumnIndex, MyDataGridView1.SelectedRows(0).Cells(7).RowIndex)
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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If EntryId = 0 Then
            Exit Sub
        Else
            If MsgBox("Are You Sure Want to Sure Delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
                Dim SqlString As String = "Delete From Inward WHere InwardId = " & EntryId & vbNewLine & "Delete From InwardDetail WHere InwardId = " & EntryId
                Kailash.ExecuteNonQuery(SqlString)
                MessageBox.Show("Entry Successfully Deleted")
                Button5_Click(Nothing, Nothing)
            End If
        End If


    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

        If cmbInvType.Text <> "" Then

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
                    If (chkPerfomaInvoice.Checked = True) Then
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

                    If (chkPerfomaInvoice.Checked = True) Then
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

    Private Sub cmbPartyName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPartyName.SelectionChangeCommitted
        MyTextBox6.Text = Kailash.GetValue("Select Address From PartyMaster Where PartyId= " & Val(cmbPartyName.SelectedValue))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

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
            Button5_Click(Nothing, Nothing)
        Else
            FillData()
        End If
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
                    cmbInvType.Items.Add("TAX INVOICE")
                    cmbInvType.Items.Add("RETAIL INVOICE")
                    cmbInvType.Items.Add("LABOUR INVOICE")
                Else
                    lblQNo.Text = "Q No. :"
                    cmbInvType.Items.Add(String.Empty)
                    cmbInvType.Items.Add("SUPPLY QUATATION")
                    cmbInvType.Items.Add("LABOUR QUATATION")
                    chkPerfomaInvoice.Visible = False
                End If

                With MyDataSet.Tables(0).Rows(0)

                    txtLabourDisPer.Text = "#0.00"

                    EntryId = Val(.Item("InwardId"))
                    txtQNo.Text = .Item("BillNo").ToString()
                    If .Item("InwardDate").ToString() <> String.Empty Then DtpQdate.Text = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(.Item("InwardDate").ToString()))
                    txtOrderNo.Text = .Item("OrderNo").ToString()
                    cmbPartyName.SelectedValue = .Item("PartyId").ToString()
                    cmbPartyName_SelectionChangeCommitted(Nothing, Nothing)

                    If .Item("OrderDate").ToString() <> String.Empty Then DtpOrderDate.Text = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(.Item("OrderDate").ToString()))
                    txtChallanNo.Text = .Item("ChallanNo").ToString()
                    If .Item("ChallanDate").ToString() <> String.Empty Then dtpChallanDate.Text = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(.Item("ChallanDate").ToString()))
                    txtLrRrNo.Text = .Item("LRNo").ToString()
                    If .Item("LRDate").ToString() <> String.Empty Then dtpLrRrDate.Text = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(.Item("LRDate").ToString()))

                    TxtVat4Prct.Text = .Item("VatFourAmont").ToString()
                    txtATex1PRct.Text = .Item("ATaxOneAmount").ToString()

                    txtVAT125Prct.Text = .Item("VatPerTwelveFiveAmount").ToString()
                    txtAVat25Prct.Text = .Item("ATaxTwoFiveAmount").ToString()

                    txtTotalAmount.Text = .Item("TotalAmont").ToString()
                    txtDiscount.Text = .Item("DetailDiscount").ToString()

                    'txtCST.Text = .Item("CstTwoPer").ToString("#0.00")
                    txtCST.Text = .Item("CstTwoPerAmount").ToString()

                    txtRounfOff.Text = .Item("Roundoff").ToString()
                    txtNetAmount.Text = .Item("NetAmont").ToString()
                    cmbInvType.SelectedItem = .Item("InvoiceType").ToString()
                    txtRemark.Text = .Item("Remark").ToString()
                End With
                MyDataGridView1.DataSource = MyDataSet.Tables(1)

                txtLabourDisPer.Text = MyDataSet.Tables(0).Rows(0).Item("DisFive").ToString()
                txtLabourDisAmt.Text = MyDataSet.Tables(0).Rows(0).Item("DisFiveAmount").ToString()

                IsEdit = True
                txtQNo.Focus()
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message.ToString())
        End Try
    End Sub

    Private Sub FrmInvop_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
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
                    btnAddRow_Click(Nothing, Nothing)
                    MyDataGridView1.CurrentCell = MyDataGridView1(3, iRow + 1)
                    'MyDataGridView1.CurrentCell.Style = DefaultBackColor
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

    Private Sub MyDataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyDataGridView1.KeyPress
        'If MyDataGridView1.CurrentCell.OwningColumn.Name = "ColVatper" Or MyDataGridView1.CurrentCell.OwningColumn.Name = "ColDis" Or MyDataGridView1.CurrentCell.OwningColumn.Name = "ColRate" Or MyDataGridView1.CurrentCell.OwningColumn.Name = "ColQty" Or MyDataGridView1.CurrentCell.OwningColumn.Name = "ColDigital1" Then
        '    txtLabourDisPer_KeyPress(Nothing, Nothing)
        '    'AddHandler CType(e.Handled, TextBox).KeyPress, AddressOf txtLabourDisPer_KeyPress
        '    'ElseIf MyDataGridView1.CurrentCell.ColumnIndex = 1 Then
        '    '    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf txtLabourDisPer_KeyPress
        'End If
    End Sub

    Private Sub cmbInvType_TextChanged(sender As Object, e As EventArgs) Handles cmbInvType.TextChanged
        If isQuatation.Equals(False) Then
            lblLabourDisPer.Visible = (cmbInvType.Text = "LABOUR INVOICE")
            lblLabourDisAmt.Visible = (cmbInvType.Text = "LABOUR INVOICE")
            txtLabourDisPer.Visible = (cmbInvType.Text = "LABOUR INVOICE")
            txtLabourDisAmt.Visible = (cmbInvType.Text = "LABOUR INVOICE")

            'If cmbInvType.Text = "LABOUR INVOICE" Then
            '    lblLabourDisPer.Visible = True
            '    lblLabourDisAmt.Visible = True
            '    'txtLabourDisPer.Visible = True
            '    txtLabourDisPer.Visible = (cmbInvType.Text = "LABOUR INVOICE")
            '    txtLabourDisAmt.Visible = True
            'Else
            '    lblLabourDisPer.Visible = False
            '    lblLabourDisAmt.Visible = False
            '    'txtLabourDisPer.Visible = False
            '    txtLabourDisPer.Visible = (cmbInvType.Text = "LABOUR INVOICE")
            '    txtLabourDisAmt.Visible = False
            'End If
            txtLabourDisPer.Text = Val("0").ToString("#0.00")
            txtLabourDisAmt.Text = Val("0").ToString("#0.00")
        Else
            lblLabourDisPer.Visible = (cmbInvType.Text = "LABOUR QUATATION")
            lblLabourDisAmt.Visible = (cmbInvType.Text = "LABOUR QUATATION")
            txtLabourDisPer.Visible = (cmbInvType.Text = "LABOUR QUATATION")
            txtLabourDisAmt.Visible = (cmbInvType.Text = "LABOUR QUATATION")
            'If cmbInvType.Text = "LABOUR QUATATION" Then
            '    lblLabourDisPer.Visible = True
            '    lblLabourDisAmt.Visible = True
            '    txtLabourDisPer.Visible = True
            '    txtLabourDisAmt.Visible = True
            'Else
            '    lblLabourDisPer.Visible = False
            '    lblLabourDisAmt.Visible = False
            '    txtLabourDisPer.Visible = False
            '    txtLabourDisAmt.Visible = False
            'End If
            txtLabourDisPer.Text = Val("0").ToString("#0.00")
            txtLabourDisAmt.Text = Val("0").ToString("#0.00")
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
        If MyDataGridView1.RowCount = 0 Then Exit Sub
        If MyDataGridView1.SelectedRows.Count = 0 Then Exit Sub
        If MyDataGridView1.SelectedRows(0).Cells(ColItemRemark.Name).Value IsNot Nothing And Not IsDBNull(MyDataGridView1.SelectedRows(0).Cells(ColItemRemark.Name).Value) Then
            MyTextBox5.Text = MyDataGridView1.SelectedRows(0).Cells(ColItemRemark.Name).Value.ToString()
        Else
            MyTextBox5.Text = ""
        End If
    End Sub

    Private Sub MyDataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MyDataGridView1.CellFormatting
        If MyDataGridView1.CurrentCell IsNot Nothing Then
            If e.RowIndex = MyDataGridView1.CurrentCell.RowIndex And e.ColumnIndex = MyDataGridView1.CurrentCell.ColumnIndex Then
                e.CellStyle.SelectionBackColor = Color.Pink
            Else
                e.CellStyle.SelectionBackColor = MyDataGridView1.DefaultCellStyle.SelectionBackColor
            End If
        End If
    End Sub

    Private Sub BtnCopyQuatattion_Click(sender As Object, e As EventArgs) Handles BtnCopyQuatattion.Click
        Try

            Dim Id As Integer

            Try
                Id = Convert.ToInt32(Kailash.ExecuteScalar("Select * From Inward Where BillNo = '" & txtCopyQ.Text & "' And isQuatation = 1", Nothing))
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
                Button5_Click(Nothing, Nothing)
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

    Private Sub MyTextBox5_Enter(sender As Object, e As EventArgs) Handles MyTextBox5.Enter
        Dim position As Integer = MyTextBox5.Text.Length
        MyTextBox5.Select(position, position)
    End Sub

    Private Sub chkPerfomaInvoice_Leave(sender As Object, e As EventArgs) Handles chkPerfomaInvoice.Leave
        MyDataGridView1.Focus()
        MyDataGridView1.CurrentCell = MyDataGridView1(3, 0)
    End Sub
End Class
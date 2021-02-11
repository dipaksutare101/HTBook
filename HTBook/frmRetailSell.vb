Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmRetailSell

    Dim Kailash As New DataAccessLayer
    Dim EntryId As Integer = 0
    Dim IsEdit As Boolean = False
    Dim MyDataSet As New DataSet
    Dim FreightSGST As Double = 0
    Dim FreightCGST As Double = 0
    Dim FreightIGST As Double = 0
    Dim FreightTotalAmount As Double = 0
    Dim FreightAmount As Double = 0, FreightGSTPer As Double = 18, FreightGSTAmount As Double = 0

    Private Sub frmRetailSell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbBillType.Items.Add("TAX INVOICE")
        cmbBillType.SelectedText = "TAX INVOICE"
        btnNew_Click(Nothing, Nothing)
        'chkIsParekhAgency.Checked = True
        If FindId > 0 Then
            FillData(FindId)
        End If
    End Sub

    Public Sub ClearField()
        txtPartyName.Text = ""
        txtCustomerAddress1.Text = ""
        cmbStateName.Text = ""
        txtCustomerPostalCode.Text = ""
        txtGSTNo.Text = ""

        txtBillNo.Text = ""
        'dtpBillDate.Text = DateTime.Now.ToLongDateString()
        txtChallanNo.Text = ""
        dtpChallanDate.Text = ""
        txtLrRrNo.Text = ""
        dtpLrRrDate.Text = ""

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

        cmbCustomer.Focus()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Kailash.ResetTextBox(Me)

        cmbBillType.SelectedIndex = 0
        cmbCustomer.SelectedIndex = -1

        Kailash.FillComboDataSource("Select StateCode, StateName From StateMaster", cmbStateName, String.Empty)
        cmbStateName.SelectedValue = 24
        cmbStateName_SelectedValueChanged(Nothing, Nothing)
        'cmbStateName.SelectedText = "GUJARAT"

        Kailash.FillComboDataSource("Select CustomerID, CustomerName From dbo.Customers Where CompanyID = 1", cmbCustomer, String.Empty)

        'IsEdit = False
        'EntryId = 0
        'FindId = 0

        SalesID = 0
        MyDataSet = New DataSet
        MyDataSet = Kailash.ExecuteDataSet("spSales_Get 0, 1, 0")
        MyDataGridView1.DataSource = MyDataSet.Tables(1)
        btnAddNewRow_Click(Nothing, Nothing)
        ClearField()

        Dim NextSalesNoString As String = "spSales_GetNextSalesNo"
        Kailash.AddParameter("@CompanyID", Val(1))
        Dim NextSalesNo As String = Convert.ToString(Kailash.ExecuteScalar(NextSalesNoString, Kailash.ParameterList))
        'spSales_GetNextSalesNo

        txtBillPrefix.Text = SaleBillPrefix
        txtBillNo.Text = SaleBillPrefix + NextSalesNo
    End Sub

    Private Sub btnAddNewRow_Click(sender As Object, e As EventArgs) Handles btnAddNewRow.Click
        If MyDataSet.Tables(1).Rows.Count > 0 Then
            Dim allRow As DataRow = MyDataSet.Tables(1).NewRow
            MyDataSet.Tables(1).Rows.InsertAt(allRow, MyDataGridView1.CurrentRow.Index + 1)
            MyDataGridView1.Focus()
            'MyDataGridView1.CurrentCell = MyDataGridView1(MyDataGridView1.SelectedRows(0).Cells(ColProductName.Name).ColumnIndex, MyDataGridView1.CurrentRow.Index + 1)
            MyDataGridView1.CurrentCell = MyDataGridView1(4, MyDataGridView1.CurrentRow.Index + 1)
        Else
            MyDataSet.Tables(1).Rows.Add()
        End If
        MyDataSet.Tables(1).AcceptChanges()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub MyDataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView1.CellEndEdit
        If e.RowIndex = -1 Then Exit Sub

        If MyDataGridView1.Columns(e.ColumnIndex).Name = ColAmountWithGST.Name Then
            With MyDataGridView1.Rows(e.RowIndex)
                .Cells(ColRate.Name).Value = Math.Round((Val(Val(.Cells(ColAmountWithGST.Name).Value) * 100) / (100 + .Cells(ColGSTPer.Name).Value)), 2)
                If Val(.Cells(ColQuantity.Name).Value.ToString()) <= 0 Then
                    MessageBox.Show("Please enter valid quantity.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End With
        End If

        If MyDataGridView1.Columns(e.ColumnIndex).Name = ColQuantity.Name Or MyDataGridView1.Columns(e.ColumnIndex).Name = ColAmountWithGST.Name Or MyDataGridView1.Columns(e.ColumnIndex).Name = ColRate.Name Or MyDataGridView1.Columns(e.ColumnIndex).Name = ColDiscountPer.Name Or MyDataGridView1.Columns(e.ColumnIndex).Name = ColGSTPer.Name Then
            With MyDataGridView1.Rows(e.RowIndex)
                If Val(.Cells(ColQuantity.Name).Value.ToString()) <= 0 Then
                    Exit Sub
                End If
                If Val(.Cells(ColRate.Name).Value.ToString()) <= 0 Then
                    Exit Sub
                End If

                Dim _qty As Double = 0
                Dim _rate As Double = 0
                Dim _disPer As Double = 0
                Dim _GstPer As Double = 0

                If Val(.Cells(ColQuantity.Name).Value.ToString()) > 0 Then
                    _qty = .Cells(ColQuantity.Name).Value
                End If
                If Val(.Cells(ColRate.Name).Value.ToString()) > 0 Then
                    _rate = .Cells(ColRate.Name).Value
                End If
                If Val(.Cells(ColDiscountPer.Name).Value.ToString()) > 0 Then
                    _disPer = .Cells(ColDiscountPer.Name).Value
                End If
                If Val(.Cells(ColGSTPer.Name).Value.ToString()) > 0 Then
                    _GstPer = .Cells(ColGSTPer.Name).Value
                End If

                Dim _disAmt As Double = Math.Round((_rate * _disPer) / 100, 2) * _qty
                Dim _GstAmt As Double = Math.Round(((_rate - _disAmt) * _GstPer) / 100, 2) * _qty

                .Cells(ColAmount.Name).Value = Math.Round(Convert.ToDecimal(.Cells(ColQuantity.Name).Value.ToString()) * Val(.Cells(ColRate.Name).Value.ToString()), 2)
                .Cells(ColDiscountAmount.Name).Value = _disAmt
                .Cells(ColGSTAmount.Name).Value = _GstAmt
                .Cells(ColFinalAmount.Name).Value = .Cells(ColAmount.Name).Value - _disAmt + _GstAmt
            End With
        End If

        ReCalculate()

        Dim iRow = e.RowIndex
        Dim iCol = e.ColumnIndex
        If iCol = 4 Then
            SelectedRowIndex = iRow
            btnProductView_Click(Nothing, Nothing)
        ElseIf iCol = 6 Then
            MyDataGridView1.CurrentCell = MyDataGridView1(7, iRow)
        ElseIf iCol = 7 Then
            MyDataGridView1.CurrentCell = MyDataGridView1(12, iRow)
        ElseIf iCol = 12 Then
            MyDataGridView1.CurrentCell = MyDataGridView1(14, iRow)
        ElseIf iCol = 14 Then
            btnAddNewRow_Click(Nothing, Nothing)
            MyDataGridView1.CurrentCell = MyDataGridView1(4, iRow + 1)
        End If

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
            If dr("GSTPer").ToString() IsNot Nothing And Not dr("GSTPer").ToString().Equals("") Then
                If Convert.ToDecimal(dr("GSTPer").ToString()) = 5 Then
                    GST5 = GST5 + Val(dr("GSTAmount").ToString())
                ElseIf Convert.ToDecimal(dr("GSTPer").ToString()) = 12 Then
                    GST12 = GST12 + Val(dr("GSTAmount").ToString())
                ElseIf Convert.ToDecimal(dr("GSTPer").ToString()) = 18 Then
                    GST18 = GST18 + Val(dr("GSTAmount").ToString())
                ElseIf Convert.ToDecimal(dr("GSTPer").ToString()) = 28 Then
                    GST28 = GST28 + Val(dr("GSTAmount").ToString())
                End If
            ElseIf dr("ProductName").ToString() IsNot Nothing Then
                dr("ProductName") = dr("ProductName").ToString.Trim()
            End If

            If dr("DiscountPer").ToString() IsNot Nothing Then
                Discont = Discont + Val(dr("DiscountAmount").ToString())
            End If
            GAmount = GAmount + Val(dr("Amount").ToString())
        Next
        txtGAmt.Text = GAmount.ToString("#0.00")


        FreightAmount = Val(txtFreightAmt.Text)
        FreightGSTAmount = Math.Round(((FreightAmount * FreightGSTPer) / 100), 2)

        If cmbStateName.SelectedValue = 24 Then
            txtSGST5.Text = (GST5 / 2).ToString("#0.00")
            txtCGST5.Text = (GST5 / 2).ToString("#0.00")

            txtSGST12.Text = (GST12 / 2).ToString("#0.00")
            txtCGST12.Text = (GST12 / 2).ToString("#0.00")

            txtSGST18.Text = (GST18 / 2).ToString("#0.00")
            txtCGST18.Text = (GST18 / 2).ToString("#0.00")

            txtSGST28.Text = (GST28 / 2).ToString("#0.00")
            txtCGST28.Text = (GST28 / 2).ToString("#0.00")

            FreightSGST = (FreightGSTAmount / 2).ToString("0.00")
            FreightCGST = (FreightGSTAmount / 2).ToString("0.00")

            txtIGST5.Text = (0).ToString("#0.00")
            txtIGST12.Text = (0).ToString("#0.00")
            txtIGST18.Text = (0).ToString("#0.00")
            txtIGST28.Text = (0).ToString("#0.00")
            FreightIGST = (0).ToString("#0.00")
        Else
            txtSGST5.Text = (0).ToString("#0.00")
            txtCGST5.Text = (0).ToString("#0.00")
            txtSGST12.Text = (0).ToString("#0.00")
            txtCGST12.Text = (0).ToString("#0.00")
            txtSGST18.Text = (0).ToString("#0.00")
            txtCGST18.Text = (0).ToString("#0.00")
            txtSGST28.Text = (0).ToString("#0.00")
            txtCGST28.Text = (0).ToString("#0.00")

            FreightSGST = (0).ToString("#0.00")
            FreightCGST = (0).ToString("#0.00")

            txtIGST5.Text = GST5.ToString("#0.00")
            txtIGST12.Text = GST12.ToString("#0.00")
            txtIGST18.Text = GST18.ToString("#0.00")
            txtIGST28.Text = GST28.ToString("#0.00")

            FreightIGST = (FreightGSTAmount).ToString("#0.00")
        End If

        FreightTotalAmount = FreightAmount + FreightGSTAmount

        txtDiscountAmt.Text = Discont.ToString("#0.00")

        txtFreight.Text = FreightTotalAmount.ToString("#0.00")

        txtTotalAmt.Text = ((GAmount - Discont) + (GST5 + GST12 + GST18 + GST28)).ToString("#0.00")

        Dim roudedVal As Decimal = Math.Round(Val(Val(txtTotalAmt.Text) + FreightTotalAmount), MidpointRounding.AwayFromZero) '// rounded value
        Dim Roff As Decimal = 0
        Roff -= (Val(txtTotalAmt.Text) + FreightTotalAmount) - roudedVal

        txtRoundOff.Text = Roff.ToString("#0.00")
        txtNetAmt.Text = roudedVal.ToString("#0.00")

        Dim NetAmt As Decimal = 0
        'If txtLabourDisPer.Visible = True Then
        '    Dim DisPer As Decimal = 0, DisAmt As Decimal = 0, TotalAmt As Decimal = 0
        '    TotalAmt = Val(txtTotalAmt.Text)
        '    DisPer = Val(txtLabourDisPer.Text)
        '    DisAmt = Math.Round((TotalAmt * DisPer) / 100, 2)
        '    txtlabourDisAmt.Text = Val(DisAmt).ToString("#0.00")
        '    NetAmt = TotalAmt - DisAmt

        '    roudedVal = Math.Round(Val(NetAmt), MidpointRounding.AwayFromZero) '// rounded value
        '    Roff = 0
        '    Roff -= Val(NetAmt) - roudedVal
        '    txtRoundOff.Text = Roff.ToString("#0.00")
        '    txtNetAmt.Text = roudedVal.ToString("#0.00")
        'End If
        'Roundoff = Roff
        'NetAmont = roudedVal
        'txtRounfOff.Text = (Math.Round(Val(txtGAmount.Text)) - Val(txtGAmount.Text)).ToString("#0.00")
        'txtNetAmount.Text = Val(Math.Round(Val(txtGAmount.Text))).ToString("#0.00")
    End Sub

    Private Sub MyDataGridView1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView1.CellLeave

    End Sub

    Private Sub MyDataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            'If e.KeyCode = Keys.Enter Then

            'e.SuppressKeyPress = True
            'Dim iRow = MyDataGridView1.CurrentCell.RowIndex
            'Dim iCol = MyDataGridView1.CurrentCell.ColumnIndex
            'If iCol = 4 Then
            '    SelectedRowIndex = iRow
            '    btnProductView_Click(Nothing, Nothing)
            'ElseIf iCol = 6 Then
            '    MyDataGridView1.CurrentCell = MyDataGridView1(7, iRow)
            'ElseIf iCol = 7 Then
            '    MyDataGridView1.CurrentCell = MyDataGridView1(12, iRow)
            'ElseIf iCol = 12 Then
            '    MyDataGridView1.CurrentCell = MyDataGridView1(14, iRow)
            'ElseIf iCol = 14 Then
            '    btnAddNewRow_Click(Nothing, Nothing)
            '    MyDataGridView1.CurrentCell = MyDataGridView1(4, iRow + 1)
            'End If


            'If iCol = MyDataGridView1.Columns.Count - 1 Then
            '    If iRow < MyDataGridView1.Rows.Count - 1 Then
            '        'btnAddRow_Click(Nothing, Nothing)
            '        'MyDataGridView1.CurrentCell = MyDataGridView1(3, iRow + 1)
            '    End If
            'Else
            '    If iCol < 6 Then
            '        MyDataGridView1.CurrentCell = MyDataGridView1(iCol + 1, iRow)
            '    Else
            '        If MyDataGridView1.Rows.Count > iRow Then

            '        End If
            '        btnAddNewRow_Click(Nothing, Nothing)
            '        MyDataGridView1.CurrentCell = MyDataGridView1(4, iRow + 1)
            '        'MyDataGridView1.CurrentCell.Style = DefaultBackColor
            '    End If
            'End If

        ElseIf e.KeyCode = Keys.F2 Then
            Dim iRow = MyDataGridView1.CurrentCell.RowIndex
            Dim iCol = MyDataGridView1.CurrentCell.ColumnIndex
            If iCol = 4 Then
                SelectedRowIndex = iRow
                btnProductView_Click(Nothing, Nothing)
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            If MyDataGridView1.Rows.Count = 1 Then Exit Sub
            For Each row As DataGridViewRow In MyDataGridView1.SelectedRows
                If (MyDataGridView1.Rows.Count > 1) Then
                    If MsgBox("Are You Sure Want to Sure remove this product?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
                        MyDataSet.Tables(1).Rows.RemoveAt(row.Index)
                        MyDataSet.Tables(1).AcceptChanges()
                        ReCalculate()
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub MyDataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyDataGridView1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Tab) Then
            'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Tab) Then
            'e.SuppressKeyPress = True
            Dim iRow = MyDataGridView1.CurrentCell.RowIndex
            Dim iCol = MyDataGridView1.CurrentCell.ColumnIndex
            If iCol = 4 Then
                SelectedRowIndex = iRow
                btnProductView_Click(Nothing, Nothing)
            ElseIf iCol = 6 Then
                MyDataGridView1.CurrentCell = MyDataGridView1(7, iRow)
            ElseIf iCol = 7 Then
                MyDataGridView1.CurrentCell = MyDataGridView1(12, iRow)
            ElseIf iCol = 12 Then
                MyDataGridView1.CurrentCell = MyDataGridView1(14, iRow)
            ElseIf iCol = 14 Then
                btnAddNewRow_Click(Nothing, Nothing)
                'MyDataGridView1.CurrentCell = MyDataGridView1(4, iRow + 1)
            End If

            ''''Old
            'Dim iCol = MyDataGridView1.CurrentCell.ColumnIndex
            'Dim iRow = MyDataGridView1.CurrentCell.RowIndex

            'If MyDataGridView1.CurrentCell.OwningColumn.Name = ColFinalAmount.Name Then
            '    If MyDataGridView1.Rows.Count - 1 = iRow Then
            '        btnAddNewRow_Click(Nothing, Nothing)
            '        MyDataGridView1.CurrentCell = MyDataGridView1(4, iRow + 1)
            '    End If
            'End If

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

        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.F2) Then
            Dim iRow = MyDataGridView1.CurrentCell.RowIndex
            Dim iCol = MyDataGridView1.CurrentCell.ColumnIndex
            If iCol = 4 Then
                SelectedRowIndex = iRow
                btnProductView_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub MyDataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles MyDataGridView1.SelectionChanged
        If MyDataGridView1.RowCount = 0 Then Exit Sub
        If MyDataGridView1.SelectedRows.Count = 0 Then Exit Sub
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

    Private Sub cmbStateName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbStateName.SelectedValueChanged
        ReCalculate()
    End Sub

    Private Sub frmRetailSell_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        ElseIf e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.P Then
        ElseIf e.KeyCode = Keys.F5 Then
            btnView_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            Dim result As Integer = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                IsEdit = False
                FindId = 0
                EntryId = 0
                SalesID = 0
                btnNew_Click(Nothing, Nothing)
                Close()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If EntryId = 0 Then
            Exit Sub
        Else
            If MsgBox("Are You Sure Want to Sure Delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
                Dim SqlString As String = "DELETE FROM dbo.Sales WHERE SalesID = " & EntryId & vbNewLine & " DELETE FROM dbo.SalesDetail WHERE SalesID = " & EntryId
                Kailash.ExecuteNonQuery(SqlString)
                MessageBox.Show("Entry Successfully Deleted")
                btnNew_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'If cmbBillType.SelectedIndex = 0 Or cmbBillType.Text = "" Then
        If cmbBillType.Text = "" Then
            MessageBox.Show("Please Select Bill Type", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbBillType.Focus()
            Exit Sub
        End If

        If txtBillNo.Text = "" Then
            MessageBox.Show("Please Enter Bill No", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBillNo.Focus()
            Exit Sub
        End If

        If cmbCustomer.SelectedIndex = 0 Or cmbCustomer.Text = "" Then
            MessageBox.Show("Please Select Customer", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCustomer.Focus()
            Exit Sub
        End If

        'If Val(txtCustomerMobileNo.Text) = 0 Or txtCustomerMobileNo.Text = "" Then
        '    MessageBox.Show("Please Enter Mobile No.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtCustomerMobileNo.Focus()
        '    Exit Sub
        'End If

        If IsStateValidationRequired.Equals(True) Then
            If cmbStateName.SelectedIndex = 0 Or cmbStateName.Text = "" Then
                MessageBox.Show("Please Select State", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbStateName.Focus()
                Exit Sub
            End If
        End If

        'MyDataSet.Tables(1)

        For Each dr As DataRow In MyDataSet.Tables(1).Rows
            If Val(dr("ProductID").ToString()) <= 0 Then
                MessageBox.Show("Please enter product name", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf Val(dr("Quantity").ToString()) <= 0 Then
                MessageBox.Show("Please enter quantity for product " & dr("ProductDescription").ToString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf Convert.ToDecimal(dr("AmountWithGST").ToString()) <= 0 Or Convert.ToDecimal(dr("Rate").ToString()) <= 0 Then
                MessageBox.Show("Please enter amont for product " & dr("ProductDescription").ToString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'strSalesDetail = strSalesDetail & vbCrLf & "( " & EntryId.ToString() & ", " & dr("ProductID").ToString() & ", " & Convert.ToDecimal(dr("Quantity").ToString()) & ", " & Convert.ToDecimal(dr("AmountWithGST").ToString()) & ", " & Convert.ToDecimal(dr("Rate").ToString()) & ", " & Convert.ToDecimal(dr("Amount").ToString()) & ", " & Convert.ToDecimal(dr("GSTPer").ToString()) & ", " & Convert.ToDecimal(dr("GSTAmount").ToString()) & ", " & Convert.ToDecimal(dr("DiscountPer").ToString()) & ", " & Convert.ToDecimal(dr("DiscountAmount").ToString()) & ", " & Convert.ToDecimal(dr("FinalAmount").ToString()) & ", 1 ) ,"
        Next

        Dim customerName As String = txtPartyName.Text
        Dim customerId As Int64 = cmbCustomer.SelectedValue
        If customerId <= 0 Then
            Dim customerString As String = "spCustomer_Exists"
            Kailash.AddParameter("@CustomerName", txtPartyName.Text.ToString())
            Kailash.AddParameter("@CompanyID", Val(1))
            customerId = Convert.ToInt64(Kailash.ExecuteScalar(customerString, Kailash.ParameterList))
            If customerId = 0 Then
                customerString = "spCustomer_Create"
                Kailash.AddParameter("@CustomerID", 0)
                Kailash.AddParameter("@CustomerName", txtPartyName.Text.ToString())
                Kailash.AddParameter("@Address1", txtCustomerAddress1.Text.ToString())
                Kailash.AddParameter("@Address2", "")
                Kailash.AddParameter("@CityName", "")
                Kailash.AddParameter("@StateCode", cmbStateName.SelectedValue)
                Kailash.AddParameter("@PostalCode", Val(txtCustomerPostalCode.Text.ToString().Replace("-", "")))
                Kailash.AddParameter("@EmailAddress", txtCustomerEmailID.Text.ToString())
                Kailash.AddParameter("@GSTNo", txtGSTNo.Text.ToString())
                Kailash.AddParameter("@MobileNo1", txtCustomerMobileNo.Text.ToString())
                Kailash.AddParameter("@MobileNo2", "")
                Kailash.AddParameter("@LandlineNo1", "")
                Kailash.AddParameter("@LandlineNo2", "")
                Kailash.AddParameter("@CompanyID", Val(1))
                customerId = Convert.ToInt16(Kailash.ExecuteScalar(customerString, Kailash.ParameterList))

                If customerId = 0 Then
                    MessageBox.Show("Something went wrong, please try again.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
        End If

        Dim SqlString As String = "spSales_Create"
        Kailash.AddParameter("@SalesID", EntryId)
        Kailash.AddParameter("@CustomerID", Val(customerId))

        If Not dtpBillDate.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals("") Then
            Kailash.AddParameter("@SaleDate", Convert.ToDateTime(dtpBillDate.Text).ToString("yyyy/MM/dd"))
        Else
            Kailash.AddParameter("@SaleDate", DBNull.Value)
        End If
        Kailash.AddParameter("@SalesNo", txtBillNo.Text)

        'If Not dtp.Text.Trim().Replace(" ", "").Replace("-", "").Replace("/", "").Trim().Equals("") Then
        '    Kailash.AddParameter("@OrderDate", Convert.ToDateTime(dtpOrderDate.Text).ToString("yyyy/MM/dd"))
        'Else
        '    Kailash.AddParameter("@OrderDate", DBNull.Value)
        'End If
        'Kailash.AddParameter("@OrderNo", txtOrderNo.Text)

        Kailash.AddParameter("@OrderDate", DBNull.Value)
        Kailash.AddParameter("@OrderNo", "")

        If Not String.IsNullOrEmpty(txtChallanNo.Text.ToString()) Then
            Kailash.AddParameter("@ChallanNo", txtChallanNo.Text)
        Else
            Kailash.AddParameter("@ChallanNo", txtMultiChallanNo.Text)
        End If
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

        Kailash.AddParameter("@SalesType", cmbBillType.Text)
        Kailash.AddParameter("@StateCode", Val(cmbStateName.SelectedValue))
        Kailash.AddParameter("@IsParekhAgency", Convert.ToBoolean(chkIsParekhAgency.Checked))
        Kailash.AddParameter("@TotalAmont", Val(txtTotalAmt.Text))
        Kailash.AddParameter("@DiscountAmount", Val(txtDiscountAmt.Text))

        Kailash.AddParameter("@FinalAmount", Val(txtTotalAmt.Text))

        Kailash.AddParameter("@Roundoff", Val(txtRoundOff.Text))
        Kailash.AddParameter("@NetAmount", Val(txtNetAmt.Text))

        Kailash.AddParameter("@SGST5", Val(txtSGST5.Text))
        Kailash.AddParameter("@CGST5", Val(txtCGST5.Text))
        Kailash.AddParameter("@IGST5", Val(txtIGST5.Text))

        Kailash.AddParameter("@SGST12", Val(txtSGST12.Text))
        Kailash.AddParameter("@CGST12", Val(txtCGST12.Text))
        Kailash.AddParameter("@IGST12", Val(txtIGST12.Text))

        Kailash.AddParameter("@SGST18", Val(txtSGST18.Text))
        Kailash.AddParameter("@CGST18", Val(txtCGST18.Text))
        Kailash.AddParameter("@IGST18", Val(txtIGST18.Text))

        Kailash.AddParameter("@SGST28", Val(txtSGST28.Text))
        Kailash.AddParameter("@CGST28", Val(txtCGST28.Text))
        Kailash.AddParameter("@IGST28", Val(txtIGST28.Text))

        Kailash.AddParameter("@FreightAmount", Val(txtFreightAmt.Text))
        Kailash.AddParameter("@FreightSGST", Val(FreightSGST))
        Kailash.AddParameter("@FreightCGST", Val(FreightCGST))
        Kailash.AddParameter("@FreightIGST", Val(FreightIGST))
        Kailash.AddParameter("@FreightTotalAmount", Val(FreightTotalAmount))

        Kailash.AddParameter("@CompanyID", Val(1))
        Kailash.AddParameter("@Action", IIf(IsEdit.Equals(True), 2, 1))

        'Kailash.AddParameter("@Ins_SalesDetail", MyDataSet.Tables(1))

        Try
            'Kailash.ExecuteNonQuery(SqlString, Kailash.ParameterList)
            EntryId = Convert.ToInt16(Kailash.ExecuteScalar(SqlString, Kailash.ParameterList))
            InwardId = EntryId
            If Not EntryId.Equals(0) And Not EntryId.ToString().Equals("") Then

                Dim strSalesDetail As String = "DELETE FROM dbo.SalesDetail WHERE SalesID = " & EntryId.ToString() & " AND CompanyID = 1 " & vbCrLf
                'strSalesDetail = strSalesDetail & vbCrLf & " INSERT INTO dbo.SalesDetail ( SalesID, ProductID, Quantity, AmountWithGST, Rate, Amount, GSTPer, GSTAmount, DiscountPer, DiscountAmount, FinalAmount, CompanyID )  Values "

                Dim dtGrid As DataTable = MyDataSet.Tables(1)
                For Each dr As DataRow In dtGrid.Rows
                    If Not String.IsNullOrEmpty(dr("ProductID").ToString()) Then
                        strSalesDetail = strSalesDetail & vbCrLf & " INSERT INTO dbo.SalesDetail ( SalesID, ProductID, Quantity, AmountWithGST, Rate, Amount, GSTPer, GSTAmount, DiscountPer, DiscountAmount, FinalAmount, CompanyID )  Values "
                        strSalesDetail = strSalesDetail & vbCrLf & "( " & EntryId.ToString() & ", " & dr("ProductID").ToString() & ", " & IIf(Not String.IsNullOrEmpty(dr("Quantity").ToString()), dr("Quantity").ToString(), 0) & ", " & IIf(Not String.IsNullOrEmpty(dr("AmountWithGST").ToString()), dr("AmountWithGST").ToString(), 0) & ", " & IIf(Not String.IsNullOrEmpty(dr("Rate").ToString()), dr("Rate").ToString(), 0) & ", " & IIf(Not String.IsNullOrEmpty(dr("Amount").ToString()), dr("Amount").ToString(), 0) & ", " & IIf(Not String.IsNullOrEmpty(dr("GSTPer").ToString()), dr("GSTPer").ToString(), 0) & ", " & IIf(Not String.IsNullOrEmpty(dr("GSTAmount").ToString()), dr("GSTAmount").ToString(), 0) & ", " & IIf(Not String.IsNullOrEmpty(dr("DiscountPer").ToString()), dr("DiscountPer").ToString(), 0) & ", " & IIf(Not String.IsNullOrEmpty(dr("DiscountAmount").ToString()), dr("DiscountAmount").ToString(), 0) & ", " & IIf(Not String.IsNullOrEmpty(dr("FinalAmount").ToString()), dr("FinalAmount").ToString(), 0) & ", 1 ) "
                    End If
                Next
                strSalesDetail = strSalesDetail.TrimEnd(",", " ")
                Try
                    Kailash.ExecuteNonQuery(strSalesDetail)
                    MessageBox.Show("Save Successfully.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Print(EntryId)
                    'Print(FindId)
                    'FindId = EntryId
                    'FillData(FindId)
                    'btnPrint_Click(Nothing, Nothing)
                    FindId = 0
                    EntryId = 0
                    txtSalesID.Text = EntryId
                    txtSalesID_Leave(Nothing, Nothing)
                    Close()
                Catch ex As Exception
                    Kailash.ExecuteNonQuery("Delete From Sales Where SalesID = " & EntryId & " And CompanyID = 1")
                    InwardId = 0
                    EntryId = 0
                    MessageBox.Show(ex.Message.ToString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End Try

            Else
                MessageBox.Show("Something went wrong.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'Button5_Click(Nothing, Nothing)
                'ClearField()
            End If

        Catch ex As Exception
            Kailash.ExecuteNonQuery("Delete From Sales Where SalesID = " & EntryId & " And CompanyID = 1")
            InwardId = 0
            EntryId = 0
            Exit Sub
        End Try

    End Sub


    Private Sub FillData(ByVal FindId As Integer)
        Try
            Dim SqlString As String = "spSales_Get " & FindId & ", 1 ," & chkIsParekhAgency.Checked
            MyDataSet = New DataSet
            MyDataSet = Kailash.ExecuteDataSet(SqlString)

            If MyDataSet.Tables(0).Rows.Count > 0 Then

                With MyDataSet.Tables(0).Rows(0)

                    EntryId = Val(.Item("SalesID"))
                    InwardId = EntryId
                    txtBillNo.Text = .Item("SalesNo").ToString()

                    If .Item("SaleDate").ToString() <> String.Empty Then dtpBillDate.Text = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(.Item("SaleDate").ToString()))

                    cmbCustomer.SelectedValue = .Item("CustomerID").ToString()
                    cmbCustomer_SelectedValueChanged(Nothing, Nothing)

                    txtChallanNo.Text = .Item("ChallanNo").ToString()
                    If .Item("ChallanDate").ToString() <> String.Empty Then dtpChallanDate.Text = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(.Item("ChallanDate").ToString()))
                    txtLrRrNo.Text = .Item("LRNo").ToString()
                    If .Item("LRDate").ToString() <> String.Empty Then dtpLrRrDate.Text = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(.Item("LRDate").ToString()))

                    txtGSTNo.Text = .Item("GSTNo").ToString()

                    txtTotalAmt.Text = .Item("TotalAmont").ToString()
                    txtDiscountAmt.Text = .Item("DiscountAmount").ToString()

                    chkIsParekhAgency.Checked = Convert.ToBoolean(.Item("IsParekhAgency"))

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

                    txtFreightAmt.Text = .Item("FreightAmount").ToString()
                    txtFreight.Text = .Item("FreightTotalAmount").ToString()

                    txtNetAmt.Text = .Item("NetAmount").ToString()

                    cmbBillType.SelectedItem = .Item("SalesType").ToString()

                End With
                MyDataGridView1.DataSource = MyDataSet.Tables(1)

                IsEdit = True
                txtBillNo.Focus()
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Print(EntryId)

        'Dim RD As New ReportDocument
        'Dim path As String = Application.StartupPath & "\SalesInvoice_PE.rpt"

        'If chkIsParekhAgency.Checked Then
        '    path = Application.StartupPath & "\SalesInvoice_PA.rpt"
        'End If
        'RD.Load(path)

        'Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        'Dim crParameterFieldDefinition As ParameterFieldDefinition
        'Dim crParameterValues As New ParameterValues()
        'Dim crParameterDiscreteValue As New ParameterDiscreteValue()

        'crParameterDiscreteValue.Value = EntryId
        'crParameterFieldDefinitions = RD.DataDefinition.ParameterFields
        'crParameterFieldDefinition = crParameterFieldDefinitions("@SalesID")
        'crParameterValues = crParameterFieldDefinition.CurrentValues

        'crParameterValues.Clear()
        'crParameterValues.Add(crParameterDiscreteValue)
        'crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        'Dim crParameterFieldDefinitionTerms As ParameterFieldDefinition
        'Dim crParameterValuesTerms As New ParameterValues()
        'Dim crParameterDiscreteValueTerms As New ParameterDiscreteValue()

        'crParameterDiscreteValueTerms.Value = 1
        'crParameterFieldDefinitionTerms = crParameterFieldDefinitions("@CompanyID")
        'crParameterValuesTerms = crParameterFieldDefinitionTerms.CurrentValues
        'crParameterValuesTerms.Clear()
        'crParameterValuesTerms.Add(crParameterDiscreteValueTerms)
        'crParameterFieldDefinitionTerms.ApplyCurrentValues(crParameterValuesTerms)

        'Kailash.SetDBLogonForReport(RD, True)

        'FrmReportViewer.CrystalReportViewer1.ReportSource = RD

        'FrmReportViewer.CrystalReportViewer1.ShowRefreshButton = True
        'FrmReportViewer.Show()

        'FindId = 0
        'EntryId = 0
        'txtSalesID.Text = EntryId
        'txtSalesID_Leave(Nothing, Nothing)

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

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim FrmSalesBillReport As New FrmSalesBillReport
        FrmSalesBillReport.MdiParent = Frmmain
        FrmSalesBillReport.StartPosition = FormStartPosition.CenterScreen
        FrmSalesBillReport.WindowState = FormWindowState.Maximized
        FrmSalesBillReport.Show()
    End Sub

    Private Sub cmbCustomer_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCustomer.SelectedValueChanged
        If Val(cmbCustomer.SelectedIndex) <= 0 Then
            Exit Sub
        End If

        Dim strCustomer As String = "Select * From Customers Where CompanyID = 1 And CustomerID = " & cmbCustomer.SelectedValue.ToString()
        Dim dtCustomer As DataTable = Kailash.ExecuteDatatable(strCustomer)

        If Not dtCustomer Is Nothing And dtCustomer.Rows.Count > 0 Then
            SelectedCustomerID = cmbCustomer.SelectedValue
            txtCustomerAddress1.Text = Convert.ToString(dtCustomer.Rows(0).Item("Address1"))
            txtCustomerPostalCode.Text = Convert.ToString(dtCustomer.Rows(0).Item("PostalCode"))
            txtGSTNo.Text = Convert.ToString(dtCustomer.Rows(0).Item("GSTNo"))
            txtCustomerMobileNo.Text = Convert.ToString(dtCustomer.Rows(0).Item("MobileNo1"))
            txtCustomerEmailID.Text = Convert.ToString(dtCustomer.Rows(0).Item("EmailAddress"))
            cmbStateName.SelectedValue = Val(dtCustomer.Rows(0).Item("StateCode"))
        End If
    End Sub

    Private Sub btnViewCustomerList_KeyDown(sender As Object, e As KeyEventArgs) Handles btnViewCustomerList.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnViewCustomerList_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnViewCustomerList_Click(sender As Object, e As EventArgs) Handles btnViewCustomerList.Click
        FrmCustomerView.ShowDialog(Frmmain)

        If Not SelectedCustomerID.Equals(0) Then
            cmbCustomer.SelectedValue = SelectedCustomerID
            cmbCustomer_SelectedValueChanged(Nothing, Nothing)
            txtCustomerAddress1.Focus()
        End If
    End Sub

    Private Sub btnProductView_Click(sender As Object, e As EventArgs) Handles btnProductView.Click

        FrmProductView.Close()
        FrmProductView.ShowDialog(Frmmain)
        FrmProductView.txtSearchText.Focus()
        If Not SelectedProductID.Equals(0) Then
            Dim strProduct As String = "Select P.*, T.TaxName , T.TaxPer From Products P INNER JOIN dbo.Taxes T ON T.TaxID = P.TaxID Where P.CompanyID = 1 And ProductID = " & SelectedProductID.ToString()
            Dim dtProduct As DataTable = Kailash.ExecuteDatatable(strProduct)

            If Not dtProduct Is Nothing And dtProduct.Rows.Count > 0 Then
                Dim itemNameDetail As String
                itemNameDetail = dtProduct.Rows(0).Item("ProductName") & vbCrLf & dtProduct.Rows(0).Item("ProductDescription")
                With MyDataGridView1.Rows(SelectedRowIndex)
                    .Cells(ColProductID.Name).Value = dtProduct.Rows(0).Item("ProductID")
                    '.Cells(ColProductDescription.Name).Value = itemNameDetail
                    .Cells(ColProductName.Name).Value = dtProduct.Rows(0).Item("ProductDescription")
                    '.Cells(ColProductName.Name).Value = dtProduct.Rows(0).Item("ProductName") '& vbCrLf & dtProduct.Rows(0).Item("ProductDescription")
                    .Cells(ColProductDescription.Name).Value = dtProduct.Rows(0).Item("ProductDescription")
                    .Cells(ColGSTPer.Name).Value = dtProduct.Rows(0).Item("TaxPer")
                    .Cells(ColHSNCode.Name).Value = dtProduct.Rows(0).Item("HSNCode")
                    .Cells(ColDiscountPer.Name).Value = 0
                    .Cells(ColDiscountAmount.Name).Value = 0
                End With

                MyDataGridView1.CurrentCell = MyDataGridView1(6, SelectedRowIndex)
            Else
                MessageBox.Show("Something went wrong, please try again later.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub txtSalesID_Leave(sender As Object, e As EventArgs) Handles txtSalesID.Leave
        FillData(Val(txtSalesID.Text))
    End Sub

    Private Sub txtMultiChallanNo_TextChanged(sender As Object, e As EventArgs) Handles txtMultiChallanNo.TextChanged

    End Sub

    Private Sub cmbCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCustomer.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.F2) Then
            btnViewCustomerList_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtFreightAmt_TextChanged(sender As Object, e As EventArgs) Handles txtFreightAmt.TextChanged
        ReCalculate()
    End Sub

    Private Sub dtpLrRrDate_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpLrRrDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            MyDataGridView1.Focus()
        End If
    End Sub

    Private Sub cmbCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCustomer.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F2 Then
            btnViewCustomerList_Click(Nothing, Nothing)
        End If
    End Sub
End Class
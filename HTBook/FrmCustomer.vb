Public Class FrmCustomer

    Dim Kailash As New DataAccessLayer

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub FrmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCustomerId.Text = "0"
        txtSearchText.Text = ""

        Kailash.FillComboDataSource("Select StateCode, StateName From StateMaster Order by StateName", cmbStateName, String.Empty)
        cmbStateName.SelectedValue = 24

        BindCustomers(txtSearchText.Text)
    End Sub

    Private Sub txtSearchText_TextChanged(sender As Object, e As EventArgs) Handles txtSearchText.TextChanged
        BindCustomers(txtSearchText.Text)
    End Sub

    Private Sub FrmCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        ElseIf e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.S Then
            txtSearchText.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim customerString As String = "spCustomer_Create"

        If txtCustomerName.Text = "" Then
            MessageBox.Show("Please Enter Customer Name.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerName.Focus()
            Exit Sub
        End If

        'If Val(txtMobileNo1.Text) = 0 Or txtMobileNo1.Text = "" Then
        '    MessageBox.Show("Please Enter Mobile No.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtMobileNo1.Focus()
        '    Exit Sub
        'End If

        Kailash.AddParameter("@CustomerID", Val(lblCustomerId.Text))
        Kailash.AddParameter("@CustomerName", txtCustomerName.Text.ToString())
        Kailash.AddParameter("@Address1", txtAddress1.Text.ToString())
        Kailash.AddParameter("@Address2", "")
        Kailash.AddParameter("@CityName", "")
        Kailash.AddParameter("@StateCode", cmbStateName.SelectedValue)
        Kailash.AddParameter("@PostalCode", Val(txtPostalCode.Text.ToString().Replace("-", "")))
        Kailash.AddParameter("@EmailAddress", "")
        Kailash.AddParameter("@GSTNo", txtGSTNo.Text.ToString())
        Kailash.AddParameter("@MobileNo1", txtMobileNo1.Text.ToString())
        Kailash.AddParameter("@MobileNo2", txtMobileNo2.Text.ToString())
        Kailash.AddParameter("@LandlineNo1", "")
        Kailash.AddParameter("@LandlineNo2", "")
        Kailash.AddParameter("@CompanyID", Val(1))
        Dim customerId As Int64 = Convert.ToInt64(Kailash.ExecuteScalar(customerString, Kailash.ParameterList))

        If customerId = 0 Then
            MessageBox.Show("Something went wrong, please try again.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ClearFields()
    End Sub

    Public Sub ClearFields()
        lblCustomerId.Text = "0"
        txtCustomerName.Text = ""
        txtAddress1.Text = ""
        cmbStateName.SelectedValue = 24
        txtPostalCode.Text = ""
        txtGSTNo.Text = ""
        txtMobileNo1.Text = ""
        txtMobileNo2.Text = ""
        txtSearchText.Text = ""

        BindCustomers("")
    End Sub

    Public Sub BindCustomers(ByVal searchText As String)
        Dim customerString As String = "spCustomers_Get 0,'" & txtSearchText.Text & "',1"
        Dim dtCustomers As DataTable = Kailash.ExecuteDatatable(customerString)
        If Not dtCustomers Is Nothing And dtCustomers.Rows.Count > 0 Then
            dgvCustomers.DataSource = dtCustomers

            Me.dgvCustomers.Columns("CustomerID").Visible = False
            Me.dgvCustomers.Columns("Address2").Visible = False
            Me.dgvCustomers.Columns("CityName").Visible = False
            Me.dgvCustomers.Columns("StateCode").Visible = False
            Me.dgvCustomers.Columns("PostalCode").Visible = False
            Me.dgvCustomers.Columns("EmailAddress").Visible = False
            Me.dgvCustomers.Columns("MobileNo2").Visible = False
            Me.dgvCustomers.Columns("LandlineNo1").Visible = False
            Me.dgvCustomers.Columns("LandlineNo2").Visible = False
            Me.dgvCustomers.Columns("CompanyID").Visible = False
        End If
    End Sub

    Private Sub dgvCustomers_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCustomers.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub dgvCustomers_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCustomers.CellMouseDoubleClick
        Dim iRow = e.RowIndex
        Dim iCol = e.ColumnIndex

        lblCustomerId.Text = dgvCustomers.Rows(e.RowIndex).Cells("CustomerID").Value
        txtCustomerName.Text = dgvCustomers.Rows(e.RowIndex).Cells("CustomerName").Value.ToString()
        txtAddress1.Text = dgvCustomers.Rows(e.RowIndex).Cells("Address1").Value.ToString()
        txtPostalCode.Text = dgvCustomers.Rows(e.RowIndex).Cells("PostalCode").Value.ToString()
        txtGSTNo.Text = dgvCustomers.Rows(e.RowIndex).Cells("GSTNo").Value.ToString()
        cmbStateName.SelectedValue = dgvCustomers.Rows(e.RowIndex).Cells("StateCode").Value
        txtMobileNo1.Text = dgvCustomers.Rows(e.RowIndex).Cells("MobileNo1").Value.ToString()
        txtMobileNo2.Text = dgvCustomers.Rows(e.RowIndex).Cells("MobileNo2").Value.ToString()
        txtCustomerName.Focus()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
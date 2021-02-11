Public Class FrmCustomerView
    Dim Kailash As New DataAccessLayer

    Private Sub txtSearchText_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchText.KeyDown
        If e.KeyCode = Keys.Down Then
            If Not dgvCustomers.DataSource Is Nothing Then
                dgvCustomers.Focus()
            End If
        End If
    End Sub

    Private Sub FrmCustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearchText.Text = ""
        BindCustomers(txtSearchText.Text)
        txtSearchText.Focus()
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

    Private Sub txtSearchText_TextChanged(sender As Object, e As EventArgs) Handles txtSearchText.TextChanged
        BindCustomers(txtSearchText.Text)
    End Sub

    Private Sub dgvCustomers_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCustomers.KeyDown
        If e.KeyCode = Keys.Enter Then
            'SelectedCustomerID = Val(dgvCustomers.SelectedRows.Item.Rows(e.RowIndex).Cells("CustomerID").Value)
            Dim iRowIndex As Integer

            For i As Integer = 0 To Me.dgvCustomers.SelectedCells.Count - 1
                If i = 0 Then
                    iRowIndex = Me.dgvCustomers.SelectedCells.Item(i).RowIndex
                    SelectedCustomerID = Val(dgvCustomers.Rows(iRowIndex).Cells("CustomerID").Value)
                Else
                    Exit For
                End If
            Next
            Dim frmRetail As New frmRetailSell
            frmRetail.cmbCustomer.SelectedValue = SelectedCustomerID
            Me.Close()
        ElseIf e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.I Then
            btnAddCustomer_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub FrmCustomerView_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.I Then
            btnAddCustomer_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        FrmCustomer.ShowDialog(Frmmain)
    End Sub
End Class
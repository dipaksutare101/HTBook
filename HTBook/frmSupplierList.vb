Public Class frmSupplierList

    Dim Kailash As New DataAccessLayer
    Dim MyDataSet As New DataSet

    Private Sub frmSupplierList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearchText.Left = 5
        txtSearchText.Width = pnlHeader.Width - 10

        GetSupplierList()
    End Sub

    Private Sub txtSearchText_TextChanged(sender As Object, e As EventArgs) Handles txtSearchText.TextChanged
        GetSupplierList()
    End Sub

    Private Sub GetSupplierList()
        dgvSuppliers.DataSource = Nothing
        Try
            Dim SqlString As String = "spSuppliers_Get 0, '" & txtSearchText.Text & "', 1"
            Dim dtSuppliers = Kailash.ExecuteDatatable(SqlString)

            If dtSuppliers.Rows.Count > 0 Then
                dgvSuppliers.DataSource = dtSuppliers

                Me.dgvSuppliers.Columns("SupplierID").Visible = False
                Me.dgvSuppliers.Columns("StateCode").Visible = False
                Me.dgvSuppliers.Columns("CompanyID").Visible = False

                Me.dgvSuppliers.Columns("StateName").HeaderText = "State"
                Me.dgvSuppliers.Columns("SupplierName").Width = 150
                Me.dgvSuppliers.Columns("Address").Width = 300
                Me.dgvSuppliers.Columns("StateName").Width = 80
                Me.dgvSuppliers.Columns("GSTNo").Width = 100
                Me.dgvSuppliers.Columns("CSTNo").Width = 100
                Me.dgvSuppliers.Columns("MobileNo").Width = 100
            End If
        Catch ex As Exception
            dgvSuppliers.DataSource = Nothing
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSearchText.Focus()
        End Try
    End Sub

    Private Sub dgvSuppliers_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSuppliers.CellMouseDoubleClick
        Dim iRow = dgvSuppliers.CurrentCell.RowIndex
        SupplierId = dgvSuppliers.Rows(iRow).Cells("SupplierID").Value

        Dim objFrm As New frmSupplier
        objFrm.MdiParent = Frmmain
        objFrm.StartPosition = FormStartPosition.CenterScreen
        objFrm.Show()
        Close()
    End Sub

    Private Sub dgvSuppliers_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSuppliers.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim iRow = dgvSuppliers.CurrentCell.RowIndex
            SupplierId = dgvSuppliers.Rows(iRow).Cells("SupplierID").Value

            Dim objFrm As New frmSupplier
            objFrm.MdiParent = Frmmain
            objFrm.StartPosition = FormStartPosition.CenterScreen
            objFrm.Show()
            Close()
        End If
    End Sub

    Private Sub frmSupplierList_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim result As Integer = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                SupplierId = 0
                Close()
            End If
        End If
    End Sub
End Class
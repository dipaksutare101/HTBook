Public Class FrmProductView
    Dim Kailash As New DataAccessLayer

    Private Sub dgvProducts_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProducts.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim iRowIndex As Integer
            For i As Integer = 0 To Me.dgvProducts.SelectedCells.Count - 1
                If i = 0 Then
                    iRowIndex = Me.dgvProducts.SelectedCells.Item(i).RowIndex
                    SelectedProductID = Val(dgvProducts.Rows(iRowIndex).Cells("ProductID").Value)
                Else
                    Exit For
                End If
            Next
            Me.Close()
        End If
    End Sub

    Private Sub FrmProductView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearchText.Text = ""
        BindPrducts(txtSearchText.Text)
        txtSearchText.Focus()
    End Sub

    Public Sub BindPrducts(ByVal searchText As String)
        Dim productString As String = "spProducts_Get 0,'" & txtSearchText.Text & "',1"
        Dim dtProducts As DataTable = Kailash.ExecuteDatatable(productString)
        If Not dtProducts Is Nothing And dtProducts.Rows.Count > 0 Then
            dgvProducts.DataSource = dtProducts

            Me.dgvProducts.Columns("ProductID").Visible = False
            Me.dgvProducts.Columns("HSNCode").Visible = False
            Me.dgvProducts.Columns("CompanyID").Visible = False

            Me.dgvProducts.Columns("ManufID").Visible = False
            Me.dgvProducts.Columns("TaxID").Visible = False
            Me.dgvProducts.Columns("BrandID").Visible = False
            Me.dgvProducts.Columns("ProductTypeID").Visible = False
            Me.dgvProducts.Columns("ProductSubTypeID").Visible = False
            Me.dgvProducts.Columns("ColorTypeID").Visible = False

            Me.dgvProducts.Columns("ProductName").Width = 300
            Me.dgvProducts.Columns("ProductDescription").Width = 300
        End If
    End Sub

    Private Sub txtSearchText_TextChanged(sender As Object, e As EventArgs) Handles txtSearchText.TextChanged
        BindPrducts(txtSearchText.Text)
    End Sub

    Private Sub txtSearchText_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchText.KeyDown
        If e.KeyCode = Keys.Down Then
            If Not dgvProducts.DataSource Is Nothing Then
                dgvProducts.Focus()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            'Dim result As Integer = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If result = DialogResult.Yes Then
            '    SalesID = 0
            '    Close()
            'End If
            Close()
        End If
    End Sub

    Private Sub FrmProductView_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Control And e.KeyCode = Keys.Shift And e.KeyCode = Keys.I Then
            btnAddProduct_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            Dim result As Integer = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                SalesID = 0
                Close()
            End If
        End If
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        FrmProductAdd.ShowDialog(Frmmain)
    End Sub
End Class
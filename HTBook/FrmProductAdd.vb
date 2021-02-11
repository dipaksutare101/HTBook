Public Class FrmProductAdd
    Dim Kailash As New DataAccessLayer
    Dim MyDataSet As New DataSet

    Dim frmType As String

    Dim frm As New Form()
    Dim txtSearch As New TextBox
    Dim dgvProductSubType As New MyDataGridView()

    Private ProductID As Int64

    Private TaxID As Integer
    Private BrandID As Integer
    Private ManufID As Integer
    Private ProductTypeID As Integer
    Private ProductSubTypeID As Integer
    Private ColorTypeID As Integer

    Private TaxName As String
    Private BrandName As String
    Private ManufName As String
    Private ProductTypeName As String
    Private ProductSubTypeName As String
    Private ColorTypeName As String


    Private Sub FrmProductAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler dgvProductSubType.KeyDown, AddressOf dgvProductSubType_KeyDown
        AddHandler txtSearch.KeyDown, AddressOf txtSearch_KeyDown

        lblProductID.Text = "0"
        txtProductName.Text = ""
        txtProductDescription.Text = ""
        txtHSNCode.Text = ""
        txtSearchText.Text = ""
        ClearFields()
        BindPrducts(txtSearchText.Text)
        txtSearchText.Focus()
    End Sub

    Public Sub ClearFields()
        RefreshTaxes()
        RefreshManufacturers()
        RefreshBrands()
        RefreshProductTypes()
        RefreshProductSubTypes()
        RefreshColorTypes()
    End Sub

    Public Sub RefreshTaxes()
        Kailash.FillComboDataSource("SELECT TaxID , TaxName FROM dbo.Taxes", cmbGST, String.Empty)
        cmbGST.SelectedValue = 2
        TaxID = cmbGST.SelectedValue
        txtTax.Text = cmbGST.Text
    End Sub

    Public Sub RefreshManufacturers()
        Kailash.FillComboDataSource("SELECT ManufID , ManufName FROM dbo.Manufacturers", cmbmfg, String.Empty)
        cmbmfg.SelectedValue = 1
        ManufID = cmbmfg.SelectedValue
        txtMfg.Text = cmbmfg.Text
    End Sub

    Public Sub RefreshBrands()
        Kailash.FillComboDataSource("SELECT BrandID , BrandName FROM dbo.Brands", cmbBrand, String.Empty)
        cmbBrand.SelectedValue = 1
        BrandID = cmbBrand.SelectedValue
        txtBrand.Text = cmbBrand.Text
    End Sub

    Public Sub RefreshProductTypes()
        Kailash.FillComboDataSource("SELECT ProductTypeID , ProductTypeName FROM dbo.ProductTypes", cmbProductType, String.Empty)
        cmbProductType.SelectedValue = 1
        ProductTypeID = cmbProductType.SelectedValue
        txtProductType.Text = cmbProductType.Text
    End Sub

    Public Sub RefreshProductSubTypes()
        Kailash.FillComboDataSource("SELECT ProductSubTypeID , ProductSubTypeName FROM dbo.ProductSubTypes Order By ProductSubTypeName", cmbProductSubType, String.Empty)
        cmbProductSubType.SelectedValue = 1
        ProductSubTypeID = cmbProductSubType.SelectedValue
        txtProductSubType.Text = cmbProductSubType.Text
    End Sub

    Public Sub RefreshColorTypes()
        Kailash.FillComboDataSource("SELECT ColorTypeID , ColorTypeName FROM dbo.ColorTypes", cmbColorType, String.Empty)
        cmbColorType.SelectedValue = 1
        ColorTypeID = cmbColorType.SelectedValue
        txtColor.Text = cmbColorType.Text
    End Sub


    Public Sub BindPrducts(ByVal searchText As String)
        Dim productString As String = "spProducts_Get 0,'" & txtSearchText.Text & "',1"
        Dim dtProducts As DataTable = Kailash.ExecuteDatatable(productString)
        dgvProducts.DataSource = dtProducts

        If Not dtProducts Is Nothing And dtProducts.Rows.Count > 0 Then
            dgvProducts.DataSource = dtProducts

            Me.dgvProducts.Columns("ProductID").Visible = False
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
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim productString As String = "spProducts_Create"

        If txtProductName.Text = "" Then
            MessageBox.Show("Please Enter Product Name.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductName.Focus()
            Exit Sub
        End If
        If txtProductDescription.Text = "" Then
            MessageBox.Show("Please Enter Product Short Code.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductDescription.Focus()
            Exit Sub
        End If
        If txtHSNCode.Text = "" Then
            MessageBox.Show("Please Enter Product HSN Code.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHSNCode.Focus()
            Exit Sub
        End If

        Kailash.AddParameter("@ProductID", Val(lblProductID.Text))
        Kailash.AddParameter("@ProductName", txtProductName.Text.ToString())
        Kailash.AddParameter("@ProductDescription", txtProductDescription.Text.ToString())
        Kailash.AddParameter("@HSNCode", txtHSNCode.Text.ToString())
        'Kailash.AddParameter("@ManufID", Val(cmbmfg.SelectedValue))
        'Kailash.AddParameter("@TaxID", Val(cmbGST.SelectedValue))
        'Kailash.AddParameter("@BrandID", Val(cmbBrand.SelectedValue))
        'Kailash.AddParameter("@ProductTypeID", Val(cmbProductType.SelectedValue))
        'Kailash.AddParameter("@ProductSubTypeID", Val(cmbProductSubType.SelectedValue))
        'Kailash.AddParameter("@ColorTypeID", Val(cmbColorType.SelectedValue))
        Kailash.AddParameter("@ManufID", Val(ManufID))
        Kailash.AddParameter("@TaxID", Val(TaxID))
        Kailash.AddParameter("@BrandID", Val(BrandID))
        Kailash.AddParameter("@ProductTypeID", Val(ProductTypeID))
        Kailash.AddParameter("@ProductSubTypeID", Val(ProductSubTypeID))
        Kailash.AddParameter("@ColorTypeID", Val(ColorTypeID))
        Kailash.AddParameter("@CompanyID", Val(1))
        Dim productId As Int64 = Convert.ToInt64(Kailash.ExecuteScalar(productString, Kailash.ParameterList))

        If productId = 0 Then
            MessageBox.Show("Something went wrong, please try again.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        lblProductID.Text = "0"
        txtProductName.Text = ""
        txtProductDescription.Text = ""
        txtProductDescription.Text = ""
        txtSearchText.Text = ""

        cmbGST.SelectedValue = 2
        cmbmfg.SelectedValue = 1
        cmbBrand.SelectedValue = 1
        cmbProductType.SelectedValue = 1
        cmbProductSubType.SelectedValue = 1
        cmbColorType.SelectedValue = 1

        BindPrducts("")

        txtProductName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub FrmProductAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        ElseIf e.KeyCode = Keys.Escape Then
            Dim result As Integer = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                SalesID = 0
                Close()
            End If
        End If
    End Sub

    Private Sub dgvProducts_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProducts.CellMouseDoubleClick
        lblProductID.Text = dgvProducts.Rows(e.RowIndex).Cells("ProductID").Value
        txtProductName.Text = dgvProducts.Rows(e.RowIndex).Cells("ProductName").Value.ToString()
        txtProductDescription.Text = dgvProducts.Rows(e.RowIndex).Cells("ProductDescription").Value.ToString()
        txtHSNCode.Text = dgvProducts.Rows(e.RowIndex).Cells("HSNCode").Value.ToString()

        cmbGST.SelectedValue = dgvProducts.Rows(e.RowIndex).Cells("TaxID").Value
        cmbmfg.SelectedValue = dgvProducts.Rows(e.RowIndex).Cells("ManufID").Value
        cmbBrand.SelectedValue = dgvProducts.Rows(e.RowIndex).Cells("BrandID").Value
        cmbProductType.SelectedValue = dgvProducts.Rows(e.RowIndex).Cells("ProductTypeID").Value
        cmbProductSubType.SelectedValue = dgvProducts.Rows(e.RowIndex).Cells("ProductSubTypeID").Value
        cmbColorType.SelectedValue = dgvProducts.Rows(e.RowIndex).Cells("ColorTypeID").Value

        txtProductName.Focus()
    End Sub

    Private Sub cmbProductSubType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbProductSubType.KeyPress
        'If e.KeyChar = ChrW(Keys.F2) Then
        'End If

        'frm.Name = "frmProductSubType"
        'frm.Size = New Size(300, 300)
        'frm.StartPosition = FormStartPosition.CenterScreen

        'Dim pnlHead = New Panel()
        'pnlHead.Dock = DockStyle.Top
        'txtSearch.Dock = DockStyle.Fill
        'txtSearch.Width = pnlHead.Width
        'pnlHead.Controls.Add(txtSearch)

        'Dim pnlContent = New Panel()
        'pnlContent.Dock = DockStyle.Fill

        'dgvProductSubType.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'dgvProductSubType.MultiSelect = False
        'dgvProductSubType.AllowUserToAddRows = False
        'dgvProductSubType.AllowUserToOrderColumns = True
        'dgvProductSubType.AllowUserToResizeColumns = False
        'dgvProductSubType.AllowUserToResizeRows = False
        'dgvProductSubType.Dock = DockStyle.Fill
        'dgvProductSubType.EditMode = DataGridViewEditMode.EditProgrammatically

        'Dim SqlString As String = "SELECT ProductSubTypeID , ProductSubTypeName FROM dbo.ProductSubTypes Order By ProductSubTypeName "
        'Dim dt = New DataTable
        'dt = Kailash.ExecuteDatatable(SqlString)
        'dgvProductSubType.DataSource = Nothing

        'If Not dt Is Nothing And dt.Rows.Count > 0 Then
        '    dgvProductSubType.DataSource = dt

        '    'dgvProductSubType.Columns("ProductSubTypeID").Visible = False
        '    dgvProductSubType.Columns("ProductSubTypeID").HeaderText = "Id"
        '    dgvProductSubType.Columns("ProductSubTypeName").Width = dgvProductSubType.Width - 10
        'End If
        'pnlContent.Controls.Add(dgvProductSubType)

        'frm.Controls.Add(pnlHead)
        'frm.Controls.Add(pnlContent)
        'frm.ShowDialog(Me)
        'txtSearch.Focus()
    End Sub

    Private Sub cmbProductSubType_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbProductSubType.KeyDown
        If e.KeyCode = Keys.F2 Then
            SelectedValue = 0
            SelectedText = ""
            RequestModel = "ProductSubTypes"
            frmManufSelectionModel.ShowDialog(Frmmain)
            frmManufSelectionModel.txtSearchText.Focus()
            If Not SelectedValue.Equals(0) Then
                cmbProductSubType.SelectedValue = SelectedValue
                cmbProductSubType.SelectedText = SelectedText
                SelectedValue = 0
                SelectedText = ""
                RequestModel = ""
                cmbColorType.Focus()
            Else
                MessageBox.Show("Something went wrong, please try again later.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            Exit Sub
        End If
        'If e.KeyCode = Keys.F2 Then
        '    frm.Name = "frmProductSubType"
        '    frm.Size = New Size(300, 300)
        '    frm.StartPosition = FormStartPosition.CenterScreen

        '    Dim pnlHead = New Panel()
        '    pnlHead.Dock = DockStyle.Top
        '    txtSearch.Dock = DockStyle.Fill
        '    txtSearch.Width = pnlHead.Width
        '    pnlHead.Controls.Add(txtSearch)

        '    Dim pnlContent = New Panel()
        '    pnlContent.Dock = DockStyle.Fill

        '    dgvProductSubType.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '    dgvProductSubType.MultiSelect = False
        '    dgvProductSubType.AllowUserToAddRows = False
        '    dgvProductSubType.Dock = DockStyle.Fill
        '    dgvProductSubType.EditMode = DataGridViewEditMode.EditProgrammatically

        '    Dim SqlString As String = "SELECT ProductSubTypeID , ProductSubTypeName FROM dbo.ProductSubTypes Order By ProductSubTypeName "
        '    Dim dt = New DataTable
        '    dt = Kailash.ExecuteDatatable(SqlString)
        '    'dgvProductSubType.DataSource = Nothing
        '    dgvProductSubType.DataSource = dt
        '    If Not dt Is Nothing And dt.Rows.Count > 0 Then
        '        'dgvProductSubType.DataSource = dt

        '        'dgvProductSubType.Columns("ProductSubTypeID").Visible = False
        '        dgvProductSubType.Columns("ProductSubTypeID").HeaderText = "Id"
        '        dgvProductSubType.Columns("ProductSubTypeName").Width = dgvProductSubType.Width - 10
        '    End If
        '    pnlContent.Controls.Add(dgvProductSubType)

        '    frm.Controls.Add(pnlHead)
        '    frm.Controls.Add(pnlContent)
        '    frm.ShowDialog(Me)
        '    txtSearch.Focus()
        'End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Down Then
            If frm.Name = "frmProductSubType" Then
                If Not dgvProductSubType.DataSource Is Nothing Then
                    dgvProductSubType.Focus()
                End If
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            frm.Close()
        End If
    End Sub

    Private Sub dgvProductSubType_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Dim iRowIndex As Integer
            For i As Integer = 0 To Me.dgvProductSubType.SelectedCells.Count - 1
                If i = 0 Then
                    iRowIndex = Me.dgvProductSubType.SelectedCells.Item(i).RowIndex
                    Dim SelectedProductSubTypeID = Val(dgvProductSubType.Rows(iRowIndex).Cells("ProductSubTypeID").Value)
                    cmbProductSubType.SelectedValue = SelectedProductSubTypeID
                Else
                    Exit For
                End If
            Next
            frm.Close()
        End If
    End Sub

    Private Sub btnAddMfg_Click(sender As Object, e As EventArgs) Handles btnAddMfg.Click
        SelectedValue = 0
        SelectedText = ""
        Dim frm As New frmManufaturers
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog(Frmmain)
        'If Not SelectedValue.Equals(0) Then
        '    cmbmfg.SelectedValue = SelectedValue
        'End If
        RefreshManufacturers()
        cmbmfg.Focus()
    End Sub

    Private Sub btnRefreshMfg_Click(sender As Object, e As EventArgs) Handles btnRefreshMfg.Click
        RefreshManufacturers()
        cmbmfg.Focus()
    End Sub

    Private Sub btnAddProductType_Click(sender As Object, e As EventArgs) Handles btnAddProductType.Click
        Dim frm As New frmProducts
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog(Frmmain)
        RefreshProductTypes()
        cmbProductType.Focus()
    End Sub

    Private Sub btnRefreshProductType_Click(sender As Object, e As EventArgs) Handles btnRefreshProductType.Click
        RefreshProductTypes()
        cmbProductType.Focus()
    End Sub

    Private Sub btnAddColor_Click(sender As Object, e As EventArgs) Handles btnAddColor.Click
        Dim frm As New frmColors
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog(Frmmain)
        RefreshColorTypes()
        cmbColorType.Focus()
    End Sub

    Private Sub btnRefreshColor_Click(sender As Object, e As EventArgs) Handles btnRefreshColor.Click
        RefreshColorTypes()
        cmbColorType.Focus()
    End Sub

    Private Sub btnAddBrand_Click(sender As Object, e As EventArgs) Handles btnAddBrand.Click
        Dim frm As New frmBrands
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog(Frmmain)
        RefreshBrands()
        cmbBrand.Focus()
    End Sub

    Private Sub btnRefreshBrand_Click(sender As Object, e As EventArgs) Handles btnRefreshBrand.Click
        RefreshBrands()
        cmbBrand.Focus()
    End Sub

    Private Sub btnAddProductSubType_Click(sender As Object, e As EventArgs) Handles btnAddProductSubType.Click
        Dim frm As New frmProductTypes
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog(Frmmain)
        RefreshProductSubTypes()
        cmbProductSubType.Focus()
    End Sub

    Private Sub btnRefreshProductSubType_Click(sender As Object, e As EventArgs) Handles btnRefreshProductSubType.Click
        RefreshProductSubTypes()
        cmbProductSubType.Focus()
    End Sub

    Private Sub cmbmfg_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbmfg.KeyDown
        If e.KeyCode = Keys.F2 Then
            SelectedValue = 0
            SelectedText = ""
            RequestModel = "Manufacturers"
            frmManufSelectionModel.ShowDialog(Frmmain)
            frmManufSelectionModel.txtSearchText.Focus()
            If Not SelectedValue.Equals(0) Then
                cmbmfg.SelectedValue = SelectedValue
                cmbmfg.SelectedText = SelectedText
                SelectedValue = 0
                SelectedText = ""
                RequestModel = ""
                cmbBrand.Focus()
            Else
                MessageBox.Show("Something went wrong, please try again later.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else

        End If
    End Sub

    Private Sub cmbmfg_Leave(sender As Object, e As EventArgs) Handles cmbmfg.Leave
        If cmbmfg.SelectedIndex < 0 Then
            cmbmfg.SelectedValue = 0
            cmbmfg.SelectedText = ""
        End If
    End Sub

    Private Sub cmbBrand_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbBrand.KeyDown
        If e.KeyCode = Keys.F2 Then
            SelectedValue = 0
            SelectedText = ""
            RequestModel = "Brands"
            frmManufSelectionModel.ShowDialog(Frmmain)
            frmManufSelectionModel.txtSearchText.Focus()
            If Not SelectedValue.Equals(0) Then
                cmbBrand.SelectedValue = SelectedValue
                cmbBrand.SelectedText = SelectedText
                SelectedValue = 0
                SelectedText = ""
                RequestModel = ""
                cmbProductType.Focus()
            Else
                MessageBox.Show("Something went wrong, please try again later.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else

        End If
    End Sub

    Private Sub cmbProductType_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbProductType.KeyDown
        If e.KeyCode = Keys.F2 Then
            SelectedValue = 0
            SelectedText = ""
            RequestModel = "ProductTypes"
            frmManufSelectionModel.ShowDialog(Frmmain)
            frmManufSelectionModel.txtSearchText.Focus()
            If Not SelectedValue.Equals(0) Then
                cmbProductType.SelectedValue = SelectedValue
                cmbProductType.SelectedText = SelectedText
                SelectedValue = 0
                SelectedText = ""
                RequestModel = ""
                cmbProductSubType.Focus()
            Else
                MessageBox.Show("Something went wrong, please try again later.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else

        End If
    End Sub

    Private Sub cmbColorType_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbColorType.KeyDown
        If e.KeyCode = Keys.F2 Then
            SelectedValue = 0
            SelectedText = ""
            RequestModel = "ColorTypes"
            frmManufSelectionModel.ShowDialog(Frmmain)
            frmManufSelectionModel.txtSearchText.Focus()
            If Not SelectedValue.Equals(0) Then
                cmbColorType.SelectedValue = SelectedValue
                cmbColorType.SelectedText = SelectedText
                SelectedValue = 0
                SelectedText = ""
                RequestModel = ""
                btnSave.Focus()
            Else
                MessageBox.Show("Something went wrong, please try again later.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else

        End If
    End Sub

    Private Sub txtMfg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMfg.KeyDown
        If e.KeyCode = Keys.F2 Then
            SelectedValue = 0
            SelectedText = ""
            RequestModel = "Manufacturers"
            frmManufSelectionModel.ShowDialog(Frmmain)
            frmManufSelectionModel.txtSearchText.Focus()
            If Not SelectedValue.Equals(0) Then
                ManufID = SelectedValue
                txtMfg.Text = SelectedText
                'cmbmfg.SelectedValue = SelectedValue
                'cmbmfg.SelectedText = SelectedText
                SelectedValue = 0
                SelectedText = ""
                RequestModel = ""
                txtBrand.Focus()
                'cmbBrand.Focus()
            Else
                MessageBox.Show("Something went wrong, please try again later.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else

        End If
    End Sub

    Private Sub txtBrand_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBrand.KeyDown
        If e.KeyCode = Keys.F2 Then
            SelectedValue = 0
            SelectedText = ""
            RequestModel = "Brands"
            frmManufSelectionModel.ShowDialog(Frmmain)
            frmManufSelectionModel.txtSearchText.Focus()
            If Not SelectedValue.Equals(0) Then
                BrandID = SelectedValue
                txtBrand.Text = SelectedText
                'cmbmfg.SelectedValue = SelectedValue
                'cmbmfg.SelectedText = SelectedText
                SelectedValue = 0
                SelectedText = ""
                RequestModel = ""
                txtProductType.Focus()
                'cmbBrand.Focus()
            Else
                MessageBox.Show("Something went wrong, please try again later.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else

        End If
    End Sub

    Private Sub txtProductType_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductType.KeyDown
        If e.KeyCode = Keys.F2 Then
            SelectedValue = 0
            SelectedText = ""
            RequestModel = "ProductTypes"
            frmManufSelectionModel.ShowDialog(Frmmain)
            frmManufSelectionModel.txtSearchText.Focus()
            If Not SelectedValue.Equals(0) Then
                ProductTypeID = SelectedValue
                txtProductType.Text = SelectedText
                'cmbmfg.SelectedValue = SelectedValue
                'cmbmfg.SelectedText = SelectedText
                SelectedValue = 0
                SelectedText = ""
                RequestModel = ""
                txtProductSubType.Focus()
                'cmbBrand.Focus()
            Else
                MessageBox.Show("Something went wrong, please try again later.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else

        End If
    End Sub

    Private Sub txtProductSubType_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductSubType.KeyDown
        If e.KeyCode = Keys.F2 Then
            SelectedValue = 0
            SelectedText = ""
            RequestModel = "ProductSubTypes"
            frmManufSelectionModel.ShowDialog(Frmmain)
            frmManufSelectionModel.txtSearchText.Focus()
            If Not SelectedValue.Equals(0) Then
                ProductSubTypeID = SelectedValue
                txtProductSubType.Text = SelectedText
                'cmbmfg.SelectedValue = SelectedValue
                'cmbmfg.SelectedText = SelectedText
                SelectedValue = 0
                SelectedText = ""
                RequestModel = ""
                txtColor.Focus()
                'cmbBrand.Focus()
            Else
                MessageBox.Show("Something went wrong, please try again later.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else

        End If
    End Sub

    Private Sub txtColor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtColor.KeyDown
        If e.KeyCode = Keys.F2 Then
            SelectedValue = 0
            SelectedText = ""
            RequestModel = "ColorTypes"
            frmManufSelectionModel.ShowDialog(Frmmain)
            frmManufSelectionModel.txtSearchText.Focus()
            If Not SelectedValue.Equals(0) Then
                ColorTypeID = SelectedValue
                txtColor.Text = SelectedText
                'cmbmfg.SelectedValue = SelectedValue
                'cmbmfg.SelectedText = SelectedText
                SelectedValue = 0
                SelectedText = ""
                RequestModel = ""
                btnSave.Focus()
                'cmbBrand.Focus()
            Else
                MessageBox.Show("Something went wrong, please try again later.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else

        End If
    End Sub

    Private Sub txtTax_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTax.KeyDown
        If e.KeyCode = Keys.F2 Then
            SelectedValue = 0
            SelectedText = ""
            RequestModel = "Taxes"
            frmManufSelectionModel.ShowDialog(Frmmain)
            frmManufSelectionModel.txtSearchText.Focus()
            If Not SelectedValue.Equals(0) Then
                TaxID = SelectedValue
                txtTax.Text = SelectedText
                'cmbmfg.SelectedValue = SelectedValue
                'cmbmfg.SelectedText = SelectedText
                SelectedValue = 0
                SelectedText = ""
                RequestModel = ""
                txtMfg.Focus()
                'cmbBrand.Focus()
            Else
                MessageBox.Show("Something went wrong, please try again later.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else

        End If
    End Sub

    Private Sub dgvProducts_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProducts.KeyDown
        Dim iRow = dgvProducts.CurrentCell.RowIndex
        ProductID = dgvProducts.Rows(iRow).Cells("ProductID").Value

        If e.KeyCode = Keys.Delete Then
            If dgvProducts.Rows.Count = 0 Then Exit Sub
            For Each row As DataGridViewRow In dgvProducts.SelectedRows
                If (dgvProducts.Rows.Count > 0) Then
                    If MsgBox("Are You Sure Want to Sure remove this Item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
                        Dim brandString As String = "spProducts_Delete"
                        Kailash.AddParameter("@ProductID", Val(ProductID))
                        Try
                            Dim dtResult = Kailash.ExecuteDatatable(brandString, Kailash.ParameterList)
                            If dtResult.Rows.Count > 0 Then
                                Dim IsSuccessful As Boolean = Convert.ToBoolean(dtResult.Rows(0).Item("IsSuccessful"))
                                Dim responseMessage As String = Convert.ToString(dtResult.Rows(0).Item("Message").ToString())
                                If IsSuccessful = False Then
                                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                Else
                                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    BindPrducts("")
                                    txtSearchText.Focus()
                                End If
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message.ToString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End Try
                    End If
                End If
            Next
        End If
    End Sub
End Class
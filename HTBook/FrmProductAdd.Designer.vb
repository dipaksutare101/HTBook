<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRefreshProductSubType = New System.Windows.Forms.Button()
        Me.btnAddProductSubType = New System.Windows.Forms.Button()
        Me.btnRefreshBrand = New System.Windows.Forms.Button()
        Me.btnAddBrand = New System.Windows.Forms.Button()
        Me.btnRefreshColor = New System.Windows.Forms.Button()
        Me.btnAddColor = New System.Windows.Forms.Button()
        Me.btnRefreshProductType = New System.Windows.Forms.Button()
        Me.btnAddProductType = New System.Windows.Forms.Button()
        Me.btnRefreshMfg = New System.Windows.Forms.Button()
        Me.btnAddMfg = New System.Windows.Forms.Button()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbProductSubType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbColorType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbProductType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbGST = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbmfg = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProducts = New HTBook.MyDataGridView(Me.components)
        Me.txtSearchText = New HTBook.WatermarkTextbox(Me.components)
        Me.txtTax = New HTBook.MyTextBox(Me.components)
        Me.txtColor = New HTBook.MyTextBox(Me.components)
        Me.txtProductSubType = New HTBook.MyTextBox(Me.components)
        Me.txtProductType = New HTBook.MyTextBox(Me.components)
        Me.txtBrand = New HTBook.MyTextBox(Me.components)
        Me.txtMfg = New HTBook.MyTextBox(Me.components)
        Me.txtHSNCode = New HTBook.MyTextBox(Me.components)
        Me.txtProductDescription = New HTBook.MyTextBox(Me.components)
        Me.txtProductName = New HTBook.MyTextBox(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(821, 461)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 196)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(821, 265)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgvProducts)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 20)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(821, 245)
        Me.Panel5.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtSearchText)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(821, 20)
        Me.Panel4.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtTax)
        Me.Panel2.Controls.Add(Me.txtColor)
        Me.Panel2.Controls.Add(Me.txtProductSubType)
        Me.Panel2.Controls.Add(Me.txtProductType)
        Me.Panel2.Controls.Add(Me.txtBrand)
        Me.Panel2.Controls.Add(Me.txtMfg)
        Me.Panel2.Controls.Add(Me.btnRefreshProductSubType)
        Me.Panel2.Controls.Add(Me.btnAddProductSubType)
        Me.Panel2.Controls.Add(Me.btnRefreshBrand)
        Me.Panel2.Controls.Add(Me.btnAddBrand)
        Me.Panel2.Controls.Add(Me.btnRefreshColor)
        Me.Panel2.Controls.Add(Me.btnAddColor)
        Me.Panel2.Controls.Add(Me.btnRefreshProductType)
        Me.Panel2.Controls.Add(Me.btnAddProductType)
        Me.Panel2.Controls.Add(Me.btnRefreshMfg)
        Me.Panel2.Controls.Add(Me.btnAddMfg)
        Me.Panel2.Controls.Add(Me.cmbBrand)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.cmbProductSubType)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.cmbColorType)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cmbProductType)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cmbGST)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cmbmfg)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtHSNCode)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblProductID)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.txtProductDescription)
        Me.Panel2.Controls.Add(Me.txtProductName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(821, 196)
        Me.Panel2.TabIndex = 0
        '
        'btnRefreshProductSubType
        '
        Me.btnRefreshProductSubType.Location = New System.Drawing.Point(791, 120)
        Me.btnRefreshProductSubType.Name = "btnRefreshProductSubType"
        Me.btnRefreshProductSubType.Size = New System.Drawing.Size(18, 21)
        Me.btnRefreshProductSubType.TabIndex = 27
        Me.btnRefreshProductSubType.Text = "↻"
        Me.btnRefreshProductSubType.UseVisualStyleBackColor = True
        '
        'btnAddProductSubType
        '
        Me.btnAddProductSubType.Location = New System.Drawing.Point(772, 120)
        Me.btnAddProductSubType.Name = "btnAddProductSubType"
        Me.btnAddProductSubType.Size = New System.Drawing.Size(18, 21)
        Me.btnAddProductSubType.TabIndex = 26
        Me.btnAddProductSubType.Text = "+"
        Me.btnAddProductSubType.UseVisualStyleBackColor = True
        '
        'btnRefreshBrand
        '
        Me.btnRefreshBrand.Location = New System.Drawing.Point(791, 93)
        Me.btnRefreshBrand.Name = "btnRefreshBrand"
        Me.btnRefreshBrand.Size = New System.Drawing.Size(18, 21)
        Me.btnRefreshBrand.TabIndex = 25
        Me.btnRefreshBrand.Text = "↻"
        Me.btnRefreshBrand.UseVisualStyleBackColor = True
        '
        'btnAddBrand
        '
        Me.btnAddBrand.Location = New System.Drawing.Point(772, 93)
        Me.btnAddBrand.Name = "btnAddBrand"
        Me.btnAddBrand.Size = New System.Drawing.Size(18, 21)
        Me.btnAddBrand.TabIndex = 24
        Me.btnAddBrand.Text = "+"
        Me.btnAddBrand.UseVisualStyleBackColor = True
        '
        'btnRefreshColor
        '
        Me.btnRefreshColor.Location = New System.Drawing.Point(375, 147)
        Me.btnRefreshColor.Name = "btnRefreshColor"
        Me.btnRefreshColor.Size = New System.Drawing.Size(18, 21)
        Me.btnRefreshColor.TabIndex = 23
        Me.btnRefreshColor.Text = "↻"
        Me.btnRefreshColor.UseVisualStyleBackColor = True
        '
        'btnAddColor
        '
        Me.btnAddColor.Location = New System.Drawing.Point(356, 147)
        Me.btnAddColor.Name = "btnAddColor"
        Me.btnAddColor.Size = New System.Drawing.Size(18, 21)
        Me.btnAddColor.TabIndex = 22
        Me.btnAddColor.Text = "+"
        Me.btnAddColor.UseVisualStyleBackColor = True
        '
        'btnRefreshProductType
        '
        Me.btnRefreshProductType.Location = New System.Drawing.Point(375, 120)
        Me.btnRefreshProductType.Name = "btnRefreshProductType"
        Me.btnRefreshProductType.Size = New System.Drawing.Size(18, 21)
        Me.btnRefreshProductType.TabIndex = 21
        Me.btnRefreshProductType.Text = "↻"
        Me.btnRefreshProductType.UseVisualStyleBackColor = True
        '
        'btnAddProductType
        '
        Me.btnAddProductType.Location = New System.Drawing.Point(356, 120)
        Me.btnAddProductType.Name = "btnAddProductType"
        Me.btnAddProductType.Size = New System.Drawing.Size(18, 21)
        Me.btnAddProductType.TabIndex = 20
        Me.btnAddProductType.Text = "+"
        Me.btnAddProductType.UseVisualStyleBackColor = True
        '
        'btnRefreshMfg
        '
        Me.btnRefreshMfg.Location = New System.Drawing.Point(375, 93)
        Me.btnRefreshMfg.Name = "btnRefreshMfg"
        Me.btnRefreshMfg.Size = New System.Drawing.Size(18, 21)
        Me.btnRefreshMfg.TabIndex = 19
        Me.btnRefreshMfg.Text = "↻"
        Me.btnRefreshMfg.UseVisualStyleBackColor = True
        '
        'btnAddMfg
        '
        Me.btnAddMfg.Location = New System.Drawing.Point(356, 93)
        Me.btnAddMfg.Name = "btnAddMfg"
        Me.btnAddMfg.Size = New System.Drawing.Size(18, 21)
        Me.btnAddMfg.TabIndex = 18
        Me.btnAddMfg.Text = "+"
        Me.btnAddMfg.UseVisualStyleBackColor = True
        '
        'cmbBrand
        '
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.Location = New System.Drawing.Point(512, 93)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(260, 21)
        Me.cmbBrand.TabIndex = 5
        Me.cmbBrand.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(429, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Brand"
        '
        'cmbProductSubType
        '
        Me.cmbProductSubType.FormattingEnabled = True
        Me.cmbProductSubType.Location = New System.Drawing.Point(512, 120)
        Me.cmbProductSubType.Name = "cmbProductSubType"
        Me.cmbProductSubType.Size = New System.Drawing.Size(260, 21)
        Me.cmbProductSubType.TabIndex = 7
        Me.cmbProductSubType.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(429, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Product Type"
        '
        'cmbColorType
        '
        Me.cmbColorType.FormattingEnabled = True
        Me.cmbColorType.Location = New System.Drawing.Point(95, 147)
        Me.cmbColorType.Name = "cmbColorType"
        Me.cmbColorType.Size = New System.Drawing.Size(260, 21)
        Me.cmbColorType.TabIndex = 8
        Me.cmbColorType.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Color"
        '
        'cmbProductType
        '
        Me.cmbProductType.FormattingEnabled = True
        Me.cmbProductType.Location = New System.Drawing.Point(95, 120)
        Me.cmbProductType.Name = "cmbProductType"
        Me.cmbProductType.Size = New System.Drawing.Size(260, 21)
        Me.cmbProductType.TabIndex = 6
        Me.cmbProductType.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Product"
        '
        'cmbGST
        '
        Me.cmbGST.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGST.FormattingEnabled = True
        Me.cmbGST.Location = New System.Drawing.Point(512, 63)
        Me.cmbGST.Name = "cmbGST"
        Me.cmbGST.Size = New System.Drawing.Size(260, 21)
        Me.cmbGST.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(429, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "TAX (GST)"
        '
        'cmbmfg
        '
        Me.cmbmfg.FormattingEnabled = True
        Me.cmbmfg.Location = New System.Drawing.Point(95, 93)
        Me.cmbmfg.Name = "cmbmfg"
        Me.cmbmfg.Size = New System.Drawing.Size(260, 21)
        Me.cmbmfg.TabIndex = 4
        Me.cmbmfg.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MFG. Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "HSN Code"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(685, 18)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(55, 13)
        Me.lblProductID.TabIndex = 4
        Me.lblProductID.Text = "ProductID"
        Me.lblProductID.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(699, 150)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(618, 150)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Short Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name"
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToOrderColumns = True
        Me.dgvProducts.AllowUserToResizeColumns = False
        Me.dgvProducts.AllowUserToResizeRows = False
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducts.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProducts.Location = New System.Drawing.Point(0, 0)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersWidth = 20
        Me.dgvProducts.RowTemplate.Height = 28
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(821, 245)
        Me.dgvProducts.TabIndex = 12
        '
        'txtSearchText
        '
        Me.txtSearchText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchText.Location = New System.Drawing.Point(0, 0)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(821, 20)
        Me.txtSearchText.TabIndex = 10
        Me.txtSearchText.WatermarkText = "Enter your search text here..."
        '
        'txtTax
        '
        Me.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTax.Location = New System.Drawing.Point(512, 64)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(260, 20)
        Me.txtTax.TabIndex = 3
        '
        'txtColor
        '
        Me.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColor.Location = New System.Drawing.Point(95, 148)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.ReadOnly = True
        Me.txtColor.Size = New System.Drawing.Size(260, 20)
        Me.txtColor.TabIndex = 8
        '
        'txtProductSubType
        '
        Me.txtProductSubType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductSubType.Location = New System.Drawing.Point(512, 121)
        Me.txtProductSubType.Name = "txtProductSubType"
        Me.txtProductSubType.ReadOnly = True
        Me.txtProductSubType.Size = New System.Drawing.Size(260, 20)
        Me.txtProductSubType.TabIndex = 7
        '
        'txtProductType
        '
        Me.txtProductType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductType.Location = New System.Drawing.Point(95, 121)
        Me.txtProductType.Name = "txtProductType"
        Me.txtProductType.ReadOnly = True
        Me.txtProductType.Size = New System.Drawing.Size(260, 20)
        Me.txtProductType.TabIndex = 6
        '
        'txtBrand
        '
        Me.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrand.Location = New System.Drawing.Point(512, 94)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.ReadOnly = True
        Me.txtBrand.Size = New System.Drawing.Size(260, 20)
        Me.txtBrand.TabIndex = 5
        '
        'txtMfg
        '
        Me.txtMfg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMfg.Location = New System.Drawing.Point(95, 94)
        Me.txtMfg.Name = "txtMfg"
        Me.txtMfg.ReadOnly = True
        Me.txtMfg.Size = New System.Drawing.Size(260, 20)
        Me.txtMfg.TabIndex = 4
        '
        'txtHSNCode
        '
        Me.txtHSNCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHSNCode.Location = New System.Drawing.Point(95, 64)
        Me.txtHSNCode.Name = "txtHSNCode"
        Me.txtHSNCode.Size = New System.Drawing.Size(260, 20)
        Me.txtHSNCode.TabIndex = 2
        '
        'txtProductDescription
        '
        Me.txtProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductDescription.Location = New System.Drawing.Point(95, 37)
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.Size = New System.Drawing.Size(347, 20)
        Me.txtProductDescription.TabIndex = 1
        '
        'txtProductName
        '
        Me.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductName.Location = New System.Drawing.Point(95, 11)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(347, 20)
        Me.txtProductName.TabIndex = 0
        '
        'FrmProductAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 461)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProductAdd"
        Me.ShowIcon = False
        Me.Text = "New Product"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As HTBook.MyTextBox
    Friend WithEvents txtProductDescription As HTBook.MyTextBox
    Friend WithEvents txtSearchText As HTBook.WatermarkTextbox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgvProducts As HTBook.MyDataGridView
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents txtHSNCode As HTBook.MyTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbmfg As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGST As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbProductType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbProductSubType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbColorType As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbBrand As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAddMfg As Button
    Friend WithEvents btnRefreshMfg As Button
    Friend WithEvents btnRefreshProductType As Button
    Friend WithEvents btnAddProductType As Button
    Friend WithEvents btnRefreshColor As Button
    Friend WithEvents btnAddColor As Button
    Friend WithEvents btnRefreshBrand As Button
    Friend WithEvents btnAddBrand As Button
    Friend WithEvents btnRefreshProductSubType As Button
    Friend WithEvents btnAddProductSubType As Button
    Friend WithEvents txtMfg As MyTextBox
    Friend WithEvents txtProductType As MyTextBox
    Friend WithEvents txtBrand As MyTextBox
    Friend WithEvents txtProductSubType As MyTextBox
    Friend WithEvents txtColor As MyTextBox
    Friend WithEvents txtTax As MyTextBox
End Class

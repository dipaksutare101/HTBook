<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvoiceGST
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlFooterButton = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkCopyEntry = New System.Windows.Forms.CheckBox()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.MyDataGridView1 = New HTBook.MyDataGridView(Me.components)
        Me.ColInwardDetailId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColInwardId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COlCapitalA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDigital1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colsmalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColItemRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHSNCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDisAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVatper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVatAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitalAHidden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpLrRrDate = New System.Windows.Forms.MaskedTextBox()
        Me.dtpChallanDate = New System.Windows.Forms.MaskedTextBox()
        Me.dtpOrderDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbPartyName = New System.Windows.Forms.ComboBox()
        Me.chkPerformaInvoice = New System.Windows.Forms.CheckBox()
        Me.cmbInvType = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.dtpQDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtParticular = New HTBook.MyTextBox(Me.components)
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbStateName = New System.Windows.Forms.ComboBox()
        Me.txtGSTNo = New HTBook.MyTextBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblQNoCopy = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.RichTextBox()
        Me.lblQNo = New System.Windows.Forms.Label()
        Me.txtQNoCopy = New HTBook.MyTextBox(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddNewRow = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLrRrNo = New HTBook.MyTextBox(Me.components)
        Me.txtQNo = New HTBook.MyTextBox(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOrderNo = New HTBook.MyTextBox(Me.components)
        Me.txtChallanNo = New HTBook.MyTextBox(Me.components)
        Me.pnlBottomLeft = New System.Windows.Forms.Panel()
        Me.btnTerms = New System.Windows.Forms.Button()
        Me.txtRemark = New HTBook.MyTextBox(Me.components)
        Me.pnlBottomRight = New System.Windows.Forms.Panel()
        Me.txtLabourDisPer = New HTBook.MyTextBox(Me.components)
        Me.txtlabourDisAmt = New HTBook.MyTextBox(Me.components)
        Me.lblLabourDisPer = New System.Windows.Forms.Label()
        Me.lbllabourDisAmt = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtIGST5 = New HTBook.MyTextBox(Me.components)
        Me.txtIGST12 = New HTBook.MyTextBox(Me.components)
        Me.txtCGST5 = New HTBook.MyTextBox(Me.components)
        Me.txtCGST12 = New HTBook.MyTextBox(Me.components)
        Me.txtIGST18 = New HTBook.MyTextBox(Me.components)
        Me.txtIGST28 = New HTBook.MyTextBox(Me.components)
        Me.txtCGST18 = New HTBook.MyTextBox(Me.components)
        Me.txtCGST28 = New HTBook.MyTextBox(Me.components)
        Me.txtSGST18 = New HTBook.MyTextBox(Me.components)
        Me.txtSGST28 = New HTBook.MyTextBox(Me.components)
        Me.txtNetAmt = New HTBook.MyTextBox(Me.components)
        Me.txtDiscountAmt = New HTBook.MyTextBox(Me.components)
        Me.txtTotalAmt = New HTBook.MyTextBox(Me.components)
        Me.txtRoundOff = New HTBook.MyTextBox(Me.components)
        Me.txtGAmt = New HTBook.MyTextBox(Me.components)
        Me.txtSGST5 = New HTBook.MyTextBox(Me.components)
        Me.txtSGST12 = New HTBook.MyTextBox(Me.components)
        Me.pnlFooterButton.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        CType(Me.MyDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlBottomLeft.SuspendLayout()
        Me.pnlBottomRight.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFooterButton
        '
        Me.pnlFooterButton.Controls.Add(Me.btnNew)
        Me.pnlFooterButton.Controls.Add(Me.btnExit)
        Me.pnlFooterButton.Controls.Add(Me.btnPrint)
        Me.pnlFooterButton.Controls.Add(Me.btnDelete)
        Me.pnlFooterButton.Controls.Add(Me.btnSave)
        Me.pnlFooterButton.Controls.Add(Me.btnView)
        Me.pnlFooterButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooterButton.Location = New System.Drawing.Point(0, 164)
        Me.pnlFooterButton.Name = "pnlFooterButton"
        Me.pnlFooterButton.Size = New System.Drawing.Size(1362, 48)
        Me.pnlFooterButton.TabIndex = 7
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(628, 7)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(100, 35)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1158, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 35)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(1052, 7)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 35)
        Me.btnPrint.TabIndex = 21
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(946, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 35)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(840, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 35)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(734, 7)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(100, 35)
        Me.btnView.TabIndex = 18
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(860, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 16)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = "Discount : "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(830, 70)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 16)
        Me.Label21.TabIndex = 72
        Me.Label21.Text = "Total Amount : "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(840, 129)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 16)
        Me.Label22.TabIndex = 73
        Me.Label22.Text = "Net Amount : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(872, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "G Amt. :"
        '
        'chkCopyEntry
        '
        Me.chkCopyEntry.AutoSize = True
        Me.chkCopyEntry.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCopyEntry.Location = New System.Drawing.Point(105, 130)
        Me.chkCopyEntry.Name = "chkCopyEntry"
        Me.chkCopyEntry.Size = New System.Drawing.Size(100, 20)
        Me.chkCopyEntry.TabIndex = 11
        Me.chkCopyEntry.Text = "Copy Entry"
        Me.chkCopyEntry.UseVisualStyleBackColor = True
        '
        'pnlDetails
        '
        Me.pnlDetails.Controls.Add(Me.MyDataGridView1)
        Me.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetails.Location = New System.Drawing.Point(0, 188)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(1362, 243)
        Me.pnlDetails.TabIndex = 4
        '
        'MyDataGridView1
        '
        Me.MyDataGridView1.AllowUserToAddRows = False
        Me.MyDataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black
        Me.MyDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.MyDataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MyDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.MyDataGridView1.ColumnHeadersHeight = 30
        Me.MyDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColInwardDetailId, Me.ColInwardId, Me.ColItemId, Me.COlCapitalA, Me.ColDigital1, Me.Colsmalla, Me.ColItemRemark, Me.ColHSNCode, Me.ColUnit, Me.ColQty, Me.ColRate, Me.ColDis, Me.ColDisAmount, Me.ColVatper, Me.ColVatAmount, Me.ColAmount, Me.CapitalAHidden})
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MyDataGridView1.DefaultCellStyle = DataGridViewCellStyle24
        Me.MyDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.MyDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView1.Name = "MyDataGridView1"
        Me.MyDataGridView1.RowHeadersWidth = 20
        Me.MyDataGridView1.RowTemplate.Height = 28
        Me.MyDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView1.Size = New System.Drawing.Size(1362, 243)
        Me.MyDataGridView1.TabIndex = 0
        '
        'ColInwardDetailId
        '
        Me.ColInwardDetailId.DataPropertyName = "InwardDetailId"
        Me.ColInwardDetailId.HeaderText = "InwardDetailId"
        Me.ColInwardDetailId.Name = "ColInwardDetailId"
        Me.ColInwardDetailId.Visible = False
        '
        'ColInwardId
        '
        Me.ColInwardId.DataPropertyName = "InwardId"
        Me.ColInwardId.HeaderText = "InwardId"
        Me.ColInwardId.Name = "ColInwardId"
        Me.ColInwardId.Visible = False
        '
        'ColItemId
        '
        Me.ColItemId.DataPropertyName = "ItemId"
        Me.ColItemId.HeaderText = "ItemId"
        Me.ColItemId.Name = "ColItemId"
        Me.ColItemId.Visible = False
        '
        'COlCapitalA
        '
        Me.COlCapitalA.DataPropertyName = "CapitalA"
        Me.COlCapitalA.HeaderText = "Capital A"
        Me.COlCapitalA.Name = "COlCapitalA"
        Me.COlCapitalA.Width = 90
        '
        'ColDigital1
        '
        Me.ColDigital1.DataPropertyName = "Digital1"
        Me.ColDigital1.HeaderText = "1"
        Me.ColDigital1.Name = "ColDigital1"
        Me.ColDigital1.Width = 80
        '
        'Colsmalla
        '
        Me.Colsmalla.DataPropertyName = "smalla"
        Me.Colsmalla.HeaderText = "a"
        Me.Colsmalla.Name = "Colsmalla"
        Me.Colsmalla.Width = 80
        '
        'ColItemRemark
        '
        Me.ColItemRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColItemRemark.DataPropertyName = "ItemRemark"
        Me.ColItemRemark.HeaderText = "Particulars"
        Me.ColItemRemark.Name = "ColItemRemark"
        Me.ColItemRemark.Width = 300
        '
        'ColHSNCode
        '
        Me.ColHSNCode.DataPropertyName = "HSNCode"
        Me.ColHSNCode.HeaderText = "HSNCode"
        Me.ColHSNCode.Name = "ColHSNCode"
        Me.ColHSNCode.Width = 80
        '
        'ColUnit
        '
        Me.ColUnit.DataPropertyName = "Unit"
        Me.ColUnit.HeaderText = "Unit"
        Me.ColUnit.Name = "ColUnit"
        Me.ColUnit.Width = 90
        '
        'ColQty
        '
        Me.ColQty.DataPropertyName = "Qty"
        DataGridViewCellStyle19.Format = "N2"
        Me.ColQty.DefaultCellStyle = DataGridViewCellStyle19
        Me.ColQty.HeaderText = "Qty"
        Me.ColQty.Name = "ColQty"
        '
        'ColRate
        '
        Me.ColRate.DataPropertyName = "Rate"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "N2"
        DataGridViewCellStyle20.NullValue = Nothing
        Me.ColRate.DefaultCellStyle = DataGridViewCellStyle20
        Me.ColRate.HeaderText = "Rate"
        Me.ColRate.Name = "ColRate"
        '
        'ColDis
        '
        Me.ColDis.DataPropertyName = "Dis"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "N2"
        Me.ColDis.DefaultCellStyle = DataGridViewCellStyle21
        Me.ColDis.HeaderText = "Dis"
        Me.ColDis.Name = "ColDis"
        Me.ColDis.Width = 75
        '
        'ColDisAmount
        '
        Me.ColDisAmount.DataPropertyName = "DisAmount"
        Me.ColDisAmount.HeaderText = "DisAmount"
        Me.ColDisAmount.Name = "ColDisAmount"
        Me.ColDisAmount.Visible = False
        Me.ColDisAmount.Width = 80
        '
        'ColVatper
        '
        Me.ColVatper.DataPropertyName = "Vatper"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "N2"
        Me.ColVatper.DefaultCellStyle = DataGridViewCellStyle22
        Me.ColVatper.HeaderText = "GST %"
        Me.ColVatper.Name = "ColVatper"
        Me.ColVatper.Width = 75
        '
        'ColVatAmount
        '
        Me.ColVatAmount.DataPropertyName = "VatAmount"
        Me.ColVatAmount.HeaderText = "GSTAmount"
        Me.ColVatAmount.Name = "ColVatAmount"
        Me.ColVatAmount.Visible = False
        '
        'ColAmount
        '
        Me.ColAmount.DataPropertyName = "Amount"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "N2"
        Me.ColAmount.DefaultCellStyle = DataGridViewCellStyle23
        Me.ColAmount.HeaderText = "Amount"
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.ReadOnly = True
        '
        'CapitalAHidden
        '
        Me.CapitalAHidden.DataPropertyName = "CapitalAHidden"
        Me.CapitalAHidden.HeaderText = "CapitalAHidden"
        Me.CapitalAHidden.Name = "CapitalAHidden"
        Me.CapitalAHidden.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(853, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 16)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "Round Off : "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 15)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 16)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "Remark : "
        '
        'dtpLrRrDate
        '
        Me.dtpLrRrDate.Location = New System.Drawing.Point(413, 98)
        Me.dtpLrRrDate.Mask = "00/00/0000"
        Me.dtpLrRrDate.Name = "dtpLrRrDate"
        Me.dtpLrRrDate.Size = New System.Drawing.Size(122, 22)
        Me.dtpLrRrDate.TabIndex = 7
        Me.dtpLrRrDate.ValidatingType = GetType(Date)
        '
        'dtpChallanDate
        '
        Me.dtpChallanDate.Location = New System.Drawing.Point(413, 67)
        Me.dtpChallanDate.Mask = "00/00/0000"
        Me.dtpChallanDate.Name = "dtpChallanDate"
        Me.dtpChallanDate.Size = New System.Drawing.Size(122, 22)
        Me.dtpChallanDate.TabIndex = 5
        Me.dtpChallanDate.ValidatingType = GetType(Date)
        '
        'dtpOrderDate
        '
        Me.dtpOrderDate.Location = New System.Drawing.Point(413, 38)
        Me.dtpOrderDate.Mask = "00/00/0000"
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(122, 22)
        Me.dtpOrderDate.TabIndex = 3
        Me.dtpOrderDate.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1030, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "ID : "
        '
        'cmbPartyName
        '
        Me.cmbPartyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPartyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartyName.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbPartyName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyName.FormattingEnabled = True
        Me.cmbPartyName.Location = New System.Drawing.Point(134, 158)
        Me.cmbPartyName.Name = "cmbPartyName"
        Me.cmbPartyName.Size = New System.Drawing.Size(266, 24)
        Me.cmbPartyName.TabIndex = 9
        '
        'chkPerformaInvoice
        '
        Me.chkPerformaInvoice.AutoSize = True
        Me.chkPerformaInvoice.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPerformaInvoice.Location = New System.Drawing.Point(1123, 161)
        Me.chkPerformaInvoice.Name = "chkPerformaInvoice"
        Me.chkPerformaInvoice.Size = New System.Drawing.Size(138, 20)
        Me.chkPerformaInvoice.TabIndex = 12
        Me.chkPerformaInvoice.Text = "Performa Invoice"
        Me.chkPerformaInvoice.UseVisualStyleBackColor = True
        '
        'cmbInvType
        '
        Me.cmbInvType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbInvType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbInvType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInvType.FormattingEnabled = True
        Me.cmbInvType.Location = New System.Drawing.Point(1125, 129)
        Me.cmbInvType.Name = "cmbInvType"
        Me.cmbInvType.Size = New System.Drawing.Size(133, 24)
        Me.cmbInvType.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1030, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Inv. Type : "
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.chkPerformaInvoice)
        Me.pnlHeader.Controls.Add(Me.cmbInvType)
        Me.pnlHeader.Controls.Add(Me.dtpQDate)
        Me.pnlHeader.Controls.Add(Me.Label10)
        Me.pnlHeader.Controls.Add(Me.txtParticular)
        Me.pnlHeader.Controls.Add(Me.Label11)
        Me.pnlHeader.Controls.Add(Me.Label23)
        Me.pnlHeader.Controls.Add(Me.cmbStateName)
        Me.pnlHeader.Controls.Add(Me.txtGSTNo)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Controls.Add(Me.dtpLrRrDate)
        Me.pnlHeader.Controls.Add(Me.dtpChallanDate)
        Me.pnlHeader.Controls.Add(Me.dtpOrderDate)
        Me.pnlHeader.Controls.Add(Me.lblQNoCopy)
        Me.pnlHeader.Controls.Add(Me.cmbPartyName)
        Me.pnlHeader.Controls.Add(Me.txtAddress)
        Me.pnlHeader.Controls.Add(Me.lblQNo)
        Me.pnlHeader.Controls.Add(Me.txtQNoCopy)
        Me.pnlHeader.Controls.Add(Me.Label2)
        Me.pnlHeader.Controls.Add(Me.btnCopy)
        Me.pnlHeader.Controls.Add(Me.Label3)
        Me.pnlHeader.Controls.Add(Me.btnAddNewRow)
        Me.pnlHeader.Controls.Add(Me.Label4)
        Me.pnlHeader.Controls.Add(Me.Label7)
        Me.pnlHeader.Controls.Add(Me.Label5)
        Me.pnlHeader.Controls.Add(Me.Label6)
        Me.pnlHeader.Controls.Add(Me.Label9)
        Me.pnlHeader.Controls.Add(Me.txtLrRrNo)
        Me.pnlHeader.Controls.Add(Me.txtQNo)
        Me.pnlHeader.Controls.Add(Me.Label8)
        Me.pnlHeader.Controls.Add(Me.txtOrderNo)
        Me.pnlHeader.Controls.Add(Me.txtChallanNo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1362, 188)
        Me.pnlHeader.TabIndex = 1
        '
        'dtpQDate
        '
        Me.dtpQDate.Location = New System.Drawing.Point(413, 5)
        Me.dtpQDate.Mask = "00/00/0000"
        Me.dtpQDate.Name = "dtpQDate"
        Me.dtpQDate.Size = New System.Drawing.Size(122, 22)
        Me.dtpQDate.TabIndex = 1
        Me.dtpQDate.ValidatingType = GetType(Date)
        '
        'txtParticular
        '
        Me.txtParticular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtParticular.Location = New System.Drawing.Point(564, 6)
        Me.txtParticular.Multiline = True
        Me.txtParticular.Name = "txtParticular"
        Me.txtParticular.Size = New System.Drawing.Size(380, 85)
        Me.txtParticular.TabIndex = 13
        Me.txtParticular.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAA"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(9, 130)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 16)
        Me.Label23.TabIndex = 69
        Me.Label23.Text = "GST No."
        '
        'cmbStateName
        '
        Me.cmbStateName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStateName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStateName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStateName.FormattingEnabled = True
        Me.cmbStateName.Location = New System.Drawing.Point(676, 158)
        Me.cmbStateName.Name = "cmbStateName"
        Me.cmbStateName.Size = New System.Drawing.Size(266, 24)
        Me.cmbStateName.TabIndex = 10
        '
        'txtGSTNo
        '
        Me.txtGSTNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGSTNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGSTNo.Location = New System.Drawing.Point(134, 125)
        Me.txtGSTNo.Name = "txtGSTNo"
        Me.txtGSTNo.Size = New System.Drawing.Size(167, 23)
        Me.txtGSTNo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(567, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "State Name"
        '
        'lblQNoCopy
        '
        Me.lblQNoCopy.AutoSize = True
        Me.lblQNoCopy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQNoCopy.Location = New System.Drawing.Point(567, 130)
        Me.lblQNoCopy.Name = "lblQNoCopy"
        Me.lblQNoCopy.Size = New System.Drawing.Size(45, 16)
        Me.lblQNoCopy.TabIndex = 59
        Me.lblQNoCopy.Text = "Q No."
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Location = New System.Drawing.Point(1033, 5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(225, 90)
        Me.txtAddress.TabIndex = 65
        Me.txtAddress.Text = ""
        '
        'lblQNo
        '
        Me.lblQNo.AutoSize = True
        Me.lblQNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQNo.Location = New System.Drawing.Point(9, 8)
        Me.lblQNo.Name = "lblQNo"
        Me.lblQNo.Size = New System.Drawing.Size(45, 16)
        Me.lblQNo.TabIndex = 54
        Me.lblQNo.Text = "Q No."
        '
        'txtQNoCopy
        '
        Me.txtQNoCopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQNoCopy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQNoCopy.Location = New System.Drawing.Point(676, 127)
        Me.txtQNoCopy.Name = "txtQNoCopy"
        Me.txtQNoCopy.Size = New System.Drawing.Size(172, 23)
        Me.txtQNoCopy.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Milage"
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(861, 125)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(83, 27)
        Me.btnCopy.TabIndex = 64
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Reg No."
        '
        'btnAddNewRow
        '
        Me.btnAddNewRow.Location = New System.Drawing.Point(413, 155)
        Me.btnAddNewRow.Name = "btnAddNewRow"
        Me.btnAddNewRow.Size = New System.Drawing.Size(122, 29)
        Me.btnAddNewRow.TabIndex = 80
        Me.btnAddNewRow.Text = "Add Row"
        Me.btnAddNewRow.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Model No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(344, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Date : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Party Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(344, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Date : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(344, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Date : "
        '
        'txtLrRrNo
        '
        Me.txtLrRrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLrRrNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLrRrNo.Location = New System.Drawing.Point(134, 96)
        Me.txtLrRrNo.Name = "txtLrRrNo"
        Me.txtLrRrNo.Size = New System.Drawing.Size(167, 23)
        Me.txtLrRrNo.TabIndex = 6
        '
        'txtQNo
        '
        Me.txtQNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtQNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQNo.Location = New System.Drawing.Point(134, 5)
        Me.txtQNo.Name = "txtQNo"
        Me.txtQNo.Size = New System.Drawing.Size(167, 23)
        Me.txtQNo.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(344, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Date : "
        '
        'txtOrderNo
        '
        Me.txtOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrderNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderNo.Location = New System.Drawing.Point(134, 36)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(167, 23)
        Me.txtOrderNo.TabIndex = 2
        '
        'txtChallanNo
        '
        Me.txtChallanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChallanNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChallanNo.Location = New System.Drawing.Point(134, 65)
        Me.txtChallanNo.Name = "txtChallanNo"
        Me.txtChallanNo.Size = New System.Drawing.Size(167, 23)
        Me.txtChallanNo.TabIndex = 4
        '
        'pnlBottomLeft
        '
        Me.pnlBottomLeft.Controls.Add(Me.btnTerms)
        Me.pnlBottomLeft.Controls.Add(Me.txtRemark)
        Me.pnlBottomLeft.Controls.Add(Me.Label25)
        Me.pnlBottomLeft.Controls.Add(Me.chkCopyEntry)
        Me.pnlBottomLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBottomLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlBottomLeft.Name = "pnlBottomLeft"
        Me.pnlBottomLeft.Size = New System.Drawing.Size(336, 164)
        Me.pnlBottomLeft.TabIndex = 5
        '
        'btnTerms
        '
        Me.btnTerms.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerms.Location = New System.Drawing.Point(3, 132)
        Me.btnTerms.Name = "btnTerms"
        Me.btnTerms.Size = New System.Drawing.Size(68, 26)
        Me.btnTerms.TabIndex = 61
        Me.btnTerms.Text = "Terms"
        Me.btnTerms.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        Me.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemark.Location = New System.Drawing.Point(105, 8)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(193, 109)
        Me.txtRemark.TabIndex = 15
        '
        'pnlBottomRight
        '
        Me.pnlBottomRight.Controls.Add(Me.txtLabourDisPer)
        Me.pnlBottomRight.Controls.Add(Me.txtlabourDisAmt)
        Me.pnlBottomRight.Controls.Add(Me.lblLabourDisPer)
        Me.pnlBottomRight.Controls.Add(Me.lbllabourDisAmt)
        Me.pnlBottomRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBottomRight.Location = New System.Drawing.Point(1099, 0)
        Me.pnlBottomRight.Name = "pnlBottomRight"
        Me.pnlBottomRight.Size = New System.Drawing.Size(263, 164)
        Me.pnlBottomRight.TabIndex = 6
        '
        'txtLabourDisPer
        '
        Me.txtLabourDisPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLabourDisPer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabourDisPer.Location = New System.Drawing.Point(149, 8)
        Me.txtLabourDisPer.Name = "txtLabourDisPer"
        Me.txtLabourDisPer.Size = New System.Drawing.Size(108, 23)
        Me.txtLabourDisPer.TabIndex = 16
        Me.txtLabourDisPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtlabourDisAmt
        '
        Me.txtlabourDisAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlabourDisAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlabourDisAmt.Location = New System.Drawing.Point(149, 39)
        Me.txtlabourDisAmt.Name = "txtlabourDisAmt"
        Me.txtlabourDisAmt.ReadOnly = True
        Me.txtlabourDisAmt.Size = New System.Drawing.Size(109, 23)
        Me.txtlabourDisAmt.TabIndex = 79
        Me.txtlabourDisAmt.TabStop = False
        Me.txtlabourDisAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLabourDisPer
        '
        Me.lblLabourDisPer.AutoSize = True
        Me.lblLabourDisPer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabourDisPer.Location = New System.Drawing.Point(7, 11)
        Me.lblLabourDisPer.Name = "lblLabourDisPer"
        Me.lblLabourDisPer.Size = New System.Drawing.Size(97, 16)
        Me.lblLabourDisPer.TabIndex = 76
        Me.lblLabourDisPer.Text = "Labour Dis. : "
        '
        'lbllabourDisAmt
        '
        Me.lbllabourDisAmt.AutoSize = True
        Me.lbllabourDisAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllabourDisAmt.Location = New System.Drawing.Point(7, 42)
        Me.lbllabourDisAmt.Name = "lbllabourDisAmt"
        Me.lbllabourDisAmt.Size = New System.Drawing.Size(128, 16)
        Me.lbllabourDisAmt.TabIndex = 77
        Me.lbllabourDisAmt.Text = "Labour Dis Amt. : "
        '
        'pnlFooter
        '
        Me.pnlFooter.Controls.Add(Me.Label27)
        Me.pnlFooter.Controls.Add(Me.Label26)
        Me.pnlFooter.Controls.Add(Me.Label16)
        Me.pnlFooter.Controls.Add(Me.Label20)
        Me.pnlFooter.Controls.Add(Me.Label24)
        Me.pnlFooter.Controls.Add(Me.Label15)
        Me.pnlFooter.Controls.Add(Me.Label14)
        Me.pnlFooter.Controls.Add(Me.Label19)
        Me.pnlFooter.Controls.Add(Me.txtIGST5)
        Me.pnlFooter.Controls.Add(Me.txtIGST12)
        Me.pnlFooter.Controls.Add(Me.txtCGST5)
        Me.pnlFooter.Controls.Add(Me.txtCGST12)
        Me.pnlFooter.Controls.Add(Me.txtIGST18)
        Me.pnlFooter.Controls.Add(Me.txtIGST28)
        Me.pnlFooter.Controls.Add(Me.txtCGST18)
        Me.pnlFooter.Controls.Add(Me.txtCGST28)
        Me.pnlFooter.Controls.Add(Me.txtSGST18)
        Me.pnlFooter.Controls.Add(Me.txtSGST28)
        Me.pnlFooter.Controls.Add(Me.pnlBottomRight)
        Me.pnlFooter.Controls.Add(Me.pnlBottomLeft)
        Me.pnlFooter.Controls.Add(Me.pnlFooterButton)
        Me.pnlFooter.Controls.Add(Me.txtNetAmt)
        Me.pnlFooter.Controls.Add(Me.txtDiscountAmt)
        Me.pnlFooter.Controls.Add(Me.txtTotalAmt)
        Me.pnlFooter.Controls.Add(Me.Label18)
        Me.pnlFooter.Controls.Add(Me.Label21)
        Me.pnlFooter.Controls.Add(Me.Label22)
        Me.pnlFooter.Controls.Add(Me.txtRoundOff)
        Me.pnlFooter.Controls.Add(Me.txtGAmt)
        Me.pnlFooter.Controls.Add(Me.txtSGST5)
        Me.pnlFooter.Controls.Add(Me.txtSGST12)
        Me.pnlFooter.Controls.Add(Me.Label13)
        Me.pnlFooter.Controls.Add(Me.Label17)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 431)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1362, 212)
        Me.pnlFooter.TabIndex = 71
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(708, 11)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(40, 16)
        Me.Label27.TabIndex = 102
        Me.Label27.Text = "IGST"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(569, 11)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(44, 16)
        Me.Label26.TabIndex = 101
        Me.Label26.Text = "CGST"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(429, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 16)
        Me.Label16.TabIndex = 100
        Me.Label16.Text = "SGST"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(342, 133)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 16)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "28%"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(342, 104)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 16)
        Me.Label24.TabIndex = 98
        Me.Label24.Text = "18%"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(342, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 16)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "12%"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(350, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 16)
        Me.Label14.TabIndex = 93
        Me.Label14.Text = "5%"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(344, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 16)
        Me.Label19.TabIndex = 92
        Me.Label19.Text = "GST"
        '
        'txtIGST5
        '
        Me.txtIGST5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIGST5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGST5.Location = New System.Drawing.Point(666, 38)
        Me.txtIGST5.Name = "txtIGST5"
        Me.txtIGST5.ReadOnly = True
        Me.txtIGST5.Size = New System.Drawing.Size(122, 23)
        Me.txtIGST5.TabIndex = 90
        Me.txtIGST5.TabStop = False
        Me.txtIGST5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIGST12
        '
        Me.txtIGST12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIGST12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGST12.Location = New System.Drawing.Point(666, 67)
        Me.txtIGST12.Name = "txtIGST12"
        Me.txtIGST12.ReadOnly = True
        Me.txtIGST12.Size = New System.Drawing.Size(122, 23)
        Me.txtIGST12.TabIndex = 91
        Me.txtIGST12.TabStop = False
        Me.txtIGST12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCGST5
        '
        Me.txtCGST5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCGST5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCGST5.Location = New System.Drawing.Point(529, 39)
        Me.txtCGST5.Name = "txtCGST5"
        Me.txtCGST5.ReadOnly = True
        Me.txtCGST5.Size = New System.Drawing.Size(122, 23)
        Me.txtCGST5.TabIndex = 88
        Me.txtCGST5.TabStop = False
        Me.txtCGST5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCGST12
        '
        Me.txtCGST12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCGST12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCGST12.Location = New System.Drawing.Point(529, 68)
        Me.txtCGST12.Name = "txtCGST12"
        Me.txtCGST12.ReadOnly = True
        Me.txtCGST12.Size = New System.Drawing.Size(122, 23)
        Me.txtCGST12.TabIndex = 89
        Me.txtCGST12.TabStop = False
        Me.txtCGST12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIGST18
        '
        Me.txtIGST18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIGST18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGST18.Location = New System.Drawing.Point(666, 98)
        Me.txtIGST18.Name = "txtIGST18"
        Me.txtIGST18.ReadOnly = True
        Me.txtIGST18.Size = New System.Drawing.Size(122, 23)
        Me.txtIGST18.TabIndex = 86
        Me.txtIGST18.TabStop = False
        Me.txtIGST18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIGST28
        '
        Me.txtIGST28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIGST28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIGST28.Location = New System.Drawing.Point(666, 127)
        Me.txtIGST28.Name = "txtIGST28"
        Me.txtIGST28.ReadOnly = True
        Me.txtIGST28.Size = New System.Drawing.Size(122, 23)
        Me.txtIGST28.TabIndex = 87
        Me.txtIGST28.TabStop = False
        Me.txtIGST28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCGST18
        '
        Me.txtCGST18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCGST18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCGST18.Location = New System.Drawing.Point(529, 98)
        Me.txtCGST18.Name = "txtCGST18"
        Me.txtCGST18.ReadOnly = True
        Me.txtCGST18.Size = New System.Drawing.Size(122, 23)
        Me.txtCGST18.TabIndex = 84
        Me.txtCGST18.TabStop = False
        Me.txtCGST18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCGST28
        '
        Me.txtCGST28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCGST28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCGST28.Location = New System.Drawing.Point(529, 127)
        Me.txtCGST28.Name = "txtCGST28"
        Me.txtCGST28.ReadOnly = True
        Me.txtCGST28.Size = New System.Drawing.Size(122, 23)
        Me.txtCGST28.TabIndex = 85
        Me.txtCGST28.TabStop = False
        Me.txtCGST28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSGST18
        '
        Me.txtSGST18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSGST18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSGST18.Location = New System.Drawing.Point(393, 98)
        Me.txtSGST18.Name = "txtSGST18"
        Me.txtSGST18.ReadOnly = True
        Me.txtSGST18.Size = New System.Drawing.Size(122, 23)
        Me.txtSGST18.TabIndex = 82
        Me.txtSGST18.TabStop = False
        Me.txtSGST18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSGST28
        '
        Me.txtSGST28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSGST28.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSGST28.Location = New System.Drawing.Point(393, 127)
        Me.txtSGST28.Name = "txtSGST28"
        Me.txtSGST28.ReadOnly = True
        Me.txtSGST28.Size = New System.Drawing.Size(122, 23)
        Me.txtSGST28.TabIndex = 83
        Me.txtSGST28.TabStop = False
        Me.txtSGST28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetAmt
        '
        Me.txtNetAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetAmt.Location = New System.Drawing.Point(962, 127)
        Me.txtNetAmt.Name = "txtNetAmt"
        Me.txtNetAmt.ReadOnly = True
        Me.txtNetAmt.Size = New System.Drawing.Size(122, 23)
        Me.txtNetAmt.TabIndex = 78
        Me.txtNetAmt.TabStop = False
        Me.txtNetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscountAmt
        '
        Me.txtDiscountAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscountAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountAmt.Location = New System.Drawing.Point(962, 39)
        Me.txtDiscountAmt.Name = "txtDiscountAmt"
        Me.txtDiscountAmt.ReadOnly = True
        Me.txtDiscountAmt.Size = New System.Drawing.Size(122, 23)
        Me.txtDiscountAmt.TabIndex = 74
        Me.txtDiscountAmt.TabStop = False
        Me.txtDiscountAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmt.Location = New System.Drawing.Point(962, 69)
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.ReadOnly = True
        Me.txtTotalAmt.Size = New System.Drawing.Size(122, 23)
        Me.txtTotalAmt.TabIndex = 77
        Me.txtTotalAmt.TabStop = False
        Me.txtTotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRoundOff
        '
        Me.txtRoundOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoundOff.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoundOff.Location = New System.Drawing.Point(962, 98)
        Me.txtRoundOff.Name = "txtRoundOff"
        Me.txtRoundOff.ReadOnly = True
        Me.txtRoundOff.Size = New System.Drawing.Size(122, 23)
        Me.txtRoundOff.TabIndex = 68
        Me.txtRoundOff.TabStop = False
        Me.txtRoundOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGAmt
        '
        Me.txtGAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGAmt.Location = New System.Drawing.Point(962, 8)
        Me.txtGAmt.Name = "txtGAmt"
        Me.txtGAmt.ReadOnly = True
        Me.txtGAmt.Size = New System.Drawing.Size(122, 23)
        Me.txtGAmt.TabIndex = 64
        Me.txtGAmt.TabStop = False
        Me.txtGAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSGST5
        '
        Me.txtSGST5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSGST5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSGST5.Location = New System.Drawing.Point(393, 40)
        Me.txtSGST5.Name = "txtSGST5"
        Me.txtSGST5.ReadOnly = True
        Me.txtSGST5.Size = New System.Drawing.Size(122, 23)
        Me.txtSGST5.TabIndex = 65
        Me.txtSGST5.TabStop = False
        Me.txtSGST5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSGST12
        '
        Me.txtSGST12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSGST12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSGST12.Location = New System.Drawing.Point(393, 69)
        Me.txtSGST12.Name = "txtSGST12"
        Me.txtSGST12.ReadOnly = True
        Me.txtSGST12.Size = New System.Drawing.Size(122, 23)
        Me.txtSGST12.TabIndex = 66
        Me.txtSGST12.TabStop = False
        Me.txtSGST12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmInvoiceGST
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1362, 643)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlFooter)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "FrmInvoiceGST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quatation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlFooterButton.ResumeLayout(False)
        Me.pnlDetails.ResumeLayout(False)
        CType(Me.MyDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlBottomLeft.ResumeLayout(False)
        Me.pnlBottomLeft.PerformLayout()
        Me.pnlBottomRight.ResumeLayout(False)
        Me.pnlBottomRight.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFooterButton As Panel
    Friend WithEvents btnNew As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnView As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents chkCopyEntry As CheckBox
    Friend WithEvents pnlDetails As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents dtpLrRrDate As MaskedTextBox
    Friend WithEvents dtpChallanDate As MaskedTextBox
    Friend WithEvents dtpOrderDate As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbPartyName As ComboBox
    Friend WithEvents chkPerformaInvoice As CheckBox
    Friend WithEvents cmbInvType As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblQNo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAddNewRow As Button
    Friend WithEvents lblQNoCopy As Label
    Friend WithEvents txtAddress As RichTextBox
    Friend WithEvents btnCopy As Button
    Friend WithEvents pnlBottomLeft As Panel
    Friend WithEvents pnlBottomRight As Panel
    Friend WithEvents lblLabourDisPer As Label
    Friend WithEvents lbllabourDisAmt As Label
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents cmbStateName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents MyDataGridView1 As MyDataGridView
    Friend WithEvents dtpQDate As MaskedTextBox
    Private WithEvents txtParticular As MyTextBox
    Friend WithEvents txtQNo As MyTextBox
    Friend WithEvents txtNetAmt As MyTextBox
    Friend WithEvents txtDiscountAmt As MyTextBox
    Friend WithEvents txtTotalAmt As MyTextBox
    Friend WithEvents txtRoundOff As MyTextBox
    Friend WithEvents txtGAmt As MyTextBox
    Friend WithEvents txtSGST5 As MyTextBox
    Friend WithEvents txtSGST12 As MyTextBox
    Friend WithEvents txtOrderNo As MyTextBox
    Friend WithEvents txtChallanNo As MyTextBox
    Friend WithEvents txtLrRrNo As MyTextBox
    Friend WithEvents txtQNoCopy As MyTextBox
    Friend WithEvents txtLabourDisPer As MyTextBox
    Friend WithEvents txtlabourDisAmt As MyTextBox
    Friend WithEvents txtGSTNo As MyTextBox
    Friend WithEvents txtIGST18 As MyTextBox
    Friend WithEvents txtIGST28 As MyTextBox
    Friend WithEvents txtCGST18 As MyTextBox
    Friend WithEvents txtCGST28 As MyTextBox
    Friend WithEvents txtSGST18 As MyTextBox
    Friend WithEvents txtSGST28 As MyTextBox
    Friend WithEvents txtIGST5 As MyTextBox
    Friend WithEvents txtIGST12 As MyTextBox
    Friend WithEvents txtCGST5 As MyTextBox
    Friend WithEvents txtCGST12 As MyTextBox
    Friend WithEvents txtRemark As MyTextBox
    Friend WithEvents ColInwardDetailId As DataGridViewTextBoxColumn
    Friend WithEvents ColInwardId As DataGridViewTextBoxColumn
    Friend WithEvents ColItemId As DataGridViewTextBoxColumn
    Friend WithEvents COlCapitalA As DataGridViewTextBoxColumn
    Friend WithEvents ColDigital1 As DataGridViewTextBoxColumn
    Friend WithEvents Colsmalla As DataGridViewTextBoxColumn
    Friend WithEvents ColItemRemark As DataGridViewTextBoxColumn
    Friend WithEvents ColHSNCode As DataGridViewTextBoxColumn
    Friend WithEvents ColUnit As DataGridViewTextBoxColumn
    Friend WithEvents ColQty As DataGridViewTextBoxColumn
    Friend WithEvents ColRate As DataGridViewTextBoxColumn
    Friend WithEvents ColDis As DataGridViewTextBoxColumn
    Friend WithEvents ColDisAmount As DataGridViewTextBoxColumn
    Friend WithEvents ColVatper As DataGridViewTextBoxColumn
    Friend WithEvents ColVatAmount As DataGridViewTextBoxColumn
    Friend WithEvents ColAmount As DataGridViewTextBoxColumn
    Friend WithEvents CapitalAHidden As DataGridViewTextBoxColumn
    Friend WithEvents btnTerms As Button
End Class

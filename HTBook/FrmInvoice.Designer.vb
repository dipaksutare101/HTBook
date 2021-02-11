<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvoice
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkPerformaInvoice = New System.Windows.Forms.CheckBox()
        Me.cmbInvType = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbPartyName = New System.Windows.Forms.ComboBox()
        Me.lblQNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtQNo = New System.Windows.Forms.TextBox()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.txtChallanNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLrRrNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpQDate = New System.Windows.Forms.DateTimePicker()
        Me.btnAddNewRow = New System.Windows.Forms.Button()
        Me.txtParticular = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.RichTextBox()
        Me.txtQNoCopy = New System.Windows.Forms.TextBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtLabourDisPer = New System.Windows.Forms.TextBox()
        Me.txtlabourDisAmt = New System.Windows.Forms.TextBox()
        Me.lblLabourDisPer = New System.Windows.Forms.Label()
        Me.lbllabourDisAmt = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtRemark = New System.Windows.Forms.RichTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.chkCopyEntry = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtNetAmt = New System.Windows.Forms.TextBox()
        Me.txtDiscountAmt = New System.Windows.Forms.TextBox()
        Me.txtATax1Amt = New System.Windows.Forms.TextBox()
        Me.txtVat25Amt = New System.Windows.Forms.TextBox()
        Me.txtTotalAmt = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtRoundOff = New System.Windows.Forms.TextBox()
        Me.txtGAmt = New System.Windows.Forms.TextBox()
        Me.txtVat4Amt = New System.Windows.Forms.TextBox()
        Me.txtvat125Amt = New System.Windows.Forms.TextBox()
        Me.txtCst2Amt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.MyDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dtpOrderDate = New System.Windows.Forms.MaskedTextBox()
        Me.dtpChallanDate = New System.Windows.Forms.MaskedTextBox()
        Me.dtpLrRrDate = New System.Windows.Forms.MaskedTextBox()
        Me.InwardDetailId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InwardId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitalA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Digital1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.smalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vatper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VatAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitalAHidden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        CType(Me.MyDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.Panel3)
        Me.pnlHeader.Controls.Add(Me.Panel2)
        Me.pnlHeader.Controls.Add(Me.txtParticular)
        Me.pnlHeader.Controls.Add(Me.Label12)
        Me.pnlHeader.Controls.Add(Me.txtAddress)
        Me.pnlHeader.Controls.Add(Me.txtQNoCopy)
        Me.pnlHeader.Controls.Add(Me.btnCopy)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1225, 167)
        Me.pnlHeader.TabIndex = 70
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.chkPerformaInvoice)
        Me.Panel3.Controls.Add(Me.cmbInvType)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(992, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(233, 167)
        Me.Panel3.TabIndex = 72
        '
        'chkPerformaInvoice
        '
        Me.chkPerformaInvoice.AutoSize = True
        Me.chkPerformaInvoice.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPerformaInvoice.Location = New System.Drawing.Point(90, 100)
        Me.chkPerformaInvoice.Name = "chkPerformaInvoice"
        Me.chkPerformaInvoice.Size = New System.Drawing.Size(138, 20)
        Me.chkPerformaInvoice.TabIndex = 10
        Me.chkPerformaInvoice.Text = "Performa Invoice"
        Me.chkPerformaInvoice.UseVisualStyleBackColor = True
        '
        'cmbInvType
        '
        Me.cmbInvType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbInvType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbInvType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInvType.FormattingEnabled = True
        Me.cmbInvType.Location = New System.Drawing.Point(90, 70)
        Me.cmbInvType.Name = "cmbInvType"
        Me.cmbInvType.Size = New System.Drawing.Size(133, 24)
        Me.cmbInvType.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Inv. Type : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "ID : "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtpLrRrDate)
        Me.Panel2.Controls.Add(Me.dtpChallanDate)
        Me.Panel2.Controls.Add(Me.dtpOrderDate)
        Me.Panel2.Controls.Add(Me.cmbPartyName)
        Me.Panel2.Controls.Add(Me.lblQNo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtQNo)
        Me.Panel2.Controls.Add(Me.txtOrderNo)
        Me.Panel2.Controls.Add(Me.txtChallanNo)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtLrRrNo)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.dtpQDate)
        Me.Panel2.Controls.Add(Me.btnAddNewRow)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(541, 167)
        Me.Panel2.TabIndex = 71
        '
        'cmbPartyName
        '
        Me.cmbPartyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPartyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartyName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyName.FormattingEnabled = True
        Me.cmbPartyName.Location = New System.Drawing.Point(109, 132)
        Me.cmbPartyName.Name = "cmbPartyName"
        Me.cmbPartyName.Size = New System.Drawing.Size(266, 24)
        Me.cmbPartyName.TabIndex = 8
        '
        'lblQNo
        '
        Me.lblQNo.AutoSize = True
        Me.lblQNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQNo.Location = New System.Drawing.Point(7, 13)
        Me.lblQNo.Name = "lblQNo"
        Me.lblQNo.Size = New System.Drawing.Size(45, 16)
        Me.lblQNo.TabIndex = 54
        Me.lblQNo.Text = "Q No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Order No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Challan No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "LR / RR No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Party Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(320, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Date : "
        '
        'txtQNo
        '
        Me.txtQNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQNo.Location = New System.Drawing.Point(109, 10)
        Me.txtQNo.Name = "txtQNo"
        Me.txtQNo.Size = New System.Drawing.Size(167, 23)
        Me.txtQNo.TabIndex = 0
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderNo.Location = New System.Drawing.Point(109, 41)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(167, 23)
        Me.txtOrderNo.TabIndex = 2
        '
        'txtChallanNo
        '
        Me.txtChallanNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChallanNo.Location = New System.Drawing.Point(109, 70)
        Me.txtChallanNo.Name = "txtChallanNo"
        Me.txtChallanNo.Size = New System.Drawing.Size(167, 23)
        Me.txtChallanNo.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(320, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Date : "
        '
        'txtLrRrNo
        '
        Me.txtLrRrNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLrRrNo.Location = New System.Drawing.Point(109, 101)
        Me.txtLrRrNo.Name = "txtLrRrNo"
        Me.txtLrRrNo.Size = New System.Drawing.Size(167, 23)
        Me.txtLrRrNo.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(320, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Date : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(320, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Date : "
        '
        'dtpQDate
        '
        Me.dtpQDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpQDate.Location = New System.Drawing.Point(409, 9)
        Me.dtpQDate.Name = "dtpQDate"
        Me.dtpQDate.Size = New System.Drawing.Size(122, 21)
        Me.dtpQDate.TabIndex = 1
        '
        'btnAddNewRow
        '
        Me.btnAddNewRow.Location = New System.Drawing.Point(409, 132)
        Me.btnAddNewRow.Name = "btnAddNewRow"
        Me.btnAddNewRow.Size = New System.Drawing.Size(122, 23)
        Me.btnAddNewRow.TabIndex = 62
        Me.btnAddNewRow.Text = "Add Row"
        Me.btnAddNewRow.UseVisualStyleBackColor = True
        '
        'txtParticular
        '
        Me.txtParticular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtParticular.Location = New System.Drawing.Point(547, 6)
        Me.txtParticular.Name = "txtParticular"
        Me.txtParticular.Size = New System.Drawing.Size(350, 84)
        Me.txtParticular.TabIndex = 68
        Me.txtParticular.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(550, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 16)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Q No."
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Location = New System.Drawing.Point(891, 6)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 84)
        Me.txtAddress.TabIndex = 65
        Me.txtAddress.Text = ""
        '
        'txtQNoCopy
        '
        Me.txtQNoCopy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQNoCopy.Location = New System.Drawing.Point(599, 132)
        Me.txtQNoCopy.Name = "txtQNoCopy"
        Me.txtQNoCopy.Size = New System.Drawing.Size(148, 23)
        Me.txtQNoCopy.TabIndex = 60
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(753, 132)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(64, 23)
        Me.btnCopy.TabIndex = 64
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'pnlFooter
        '
        Me.pnlFooter.Controls.Add(Me.Panel5)
        Me.pnlFooter.Controls.Add(Me.Panel4)
        Me.pnlFooter.Controls.Add(Me.Panel1)
        Me.pnlFooter.Controls.Add(Me.txtNetAmt)
        Me.pnlFooter.Controls.Add(Me.txtDiscountAmt)
        Me.pnlFooter.Controls.Add(Me.txtATax1Amt)
        Me.pnlFooter.Controls.Add(Me.txtVat25Amt)
        Me.pnlFooter.Controls.Add(Me.txtTotalAmt)
        Me.pnlFooter.Controls.Add(Me.Label18)
        Me.pnlFooter.Controls.Add(Me.Label19)
        Me.pnlFooter.Controls.Add(Me.Label20)
        Me.pnlFooter.Controls.Add(Me.Label21)
        Me.pnlFooter.Controls.Add(Me.Label22)
        Me.pnlFooter.Controls.Add(Me.txtRoundOff)
        Me.pnlFooter.Controls.Add(Me.txtGAmt)
        Me.pnlFooter.Controls.Add(Me.txtVat4Amt)
        Me.pnlFooter.Controls.Add(Me.txtvat125Amt)
        Me.pnlFooter.Controls.Add(Me.txtCst2Amt)
        Me.pnlFooter.Controls.Add(Me.Label13)
        Me.pnlFooter.Controls.Add(Me.Label14)
        Me.pnlFooter.Controls.Add(Me.Label15)
        Me.pnlFooter.Controls.Add(Me.Label16)
        Me.pnlFooter.Controls.Add(Me.Label17)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 264)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1225, 211)
        Me.pnlFooter.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtLabourDisPer)
        Me.Panel5.Controls.Add(Me.txtlabourDisAmt)
        Me.Panel5.Controls.Add(Me.lblLabourDisPer)
        Me.Panel5.Controls.Add(Me.lbllabourDisAmt)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(950, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(275, 163)
        Me.Panel5.TabIndex = 81
        '
        'txtLabourDisPer
        '
        Me.txtLabourDisPer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabourDisPer.Location = New System.Drawing.Point(163, 8)
        Me.txtLabourDisPer.Name = "txtLabourDisPer"
        Me.txtLabourDisPer.Size = New System.Drawing.Size(108, 23)
        Me.txtLabourDisPer.TabIndex = 78
        '
        'txtlabourDisAmt
        '
        Me.txtlabourDisAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlabourDisAmt.Location = New System.Drawing.Point(163, 39)
        Me.txtlabourDisAmt.Name = "txtlabourDisAmt"
        Me.txtlabourDisAmt.ReadOnly = True
        Me.txtlabourDisAmt.Size = New System.Drawing.Size(109, 23)
        Me.txtlabourDisAmt.TabIndex = 79
        '
        'lblLabourDisPer
        '
        Me.lblLabourDisPer.AutoSize = True
        Me.lblLabourDisPer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabourDisPer.Location = New System.Drawing.Point(39, 11)
        Me.lblLabourDisPer.Name = "lblLabourDisPer"
        Me.lblLabourDisPer.Size = New System.Drawing.Size(97, 16)
        Me.lblLabourDisPer.TabIndex = 76
        Me.lblLabourDisPer.Text = "Labour Dis. : "
        '
        'lbllabourDisAmt
        '
        Me.lbllabourDisAmt.AutoSize = True
        Me.lbllabourDisAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllabourDisAmt.Location = New System.Drawing.Point(39, 42)
        Me.lbllabourDisAmt.Name = "lbllabourDisAmt"
        Me.lbllabourDisAmt.Size = New System.Drawing.Size(128, 16)
        Me.lbllabourDisAmt.TabIndex = 77
        Me.lbllabourDisAmt.Text = "Labour Dis Amt. : "
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtRemark)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.chkCopyEntry)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(314, 163)
        Me.Panel4.TabIndex = 80
        '
        'txtRemark
        '
        Me.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemark.Location = New System.Drawing.Point(109, 8)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(200, 83)
        Me.txtRemark.TabIndex = 69
        Me.txtRemark.Text = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(7, 15)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 16)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "Remark : "
        '
        'chkCopyEntry
        '
        Me.chkCopyEntry.AutoSize = True
        Me.chkCopyEntry.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCopyEntry.Location = New System.Drawing.Point(209, 133)
        Me.chkCopyEntry.Name = "chkCopyEntry"
        Me.chkCopyEntry.Size = New System.Drawing.Size(100, 20)
        Me.chkCopyEntry.TabIndex = 11
        Me.chkCopyEntry.Text = "Copy Entry"
        Me.chkCopyEntry.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 163)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1225, 48)
        Me.Panel1.TabIndex = 79
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(505, 7)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(100, 35)
        Me.btnNew.TabIndex = 68
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1035, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 35)
        Me.btnExit.TabIndex = 67
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(929, 7)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 35)
        Me.btnPrint.TabIndex = 66
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(823, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 35)
        Me.btnDelete.TabIndex = 65
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(717, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 35)
        Me.btnSave.TabIndex = 64
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(611, 7)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(100, 35)
        Me.btnView.TabIndex = 63
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'txtNetAmt
        '
        Me.txtNetAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetAmt.Location = New System.Drawing.Point(680, 134)
        Me.txtNetAmt.Name = "txtNetAmt"
        Me.txtNetAmt.ReadOnly = True
        Me.txtNetAmt.Size = New System.Drawing.Size(122, 23)
        Me.txtNetAmt.TabIndex = 78
        '
        'txtDiscountAmt
        '
        Me.txtDiscountAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountAmt.Location = New System.Drawing.Point(680, 8)
        Me.txtDiscountAmt.Name = "txtDiscountAmt"
        Me.txtDiscountAmt.ReadOnly = True
        Me.txtDiscountAmt.Size = New System.Drawing.Size(122, 23)
        Me.txtDiscountAmt.TabIndex = 74
        '
        'txtATax1Amt
        '
        Me.txtATax1Amt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtATax1Amt.Location = New System.Drawing.Point(680, 39)
        Me.txtATax1Amt.Name = "txtATax1Amt"
        Me.txtATax1Amt.ReadOnly = True
        Me.txtATax1Amt.Size = New System.Drawing.Size(122, 23)
        Me.txtATax1Amt.TabIndex = 75
        '
        'txtVat25Amt
        '
        Me.txtVat25Amt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVat25Amt.Location = New System.Drawing.Point(680, 68)
        Me.txtVat25Amt.Name = "txtVat25Amt"
        Me.txtVat25Amt.ReadOnly = True
        Me.txtVat25Amt.Size = New System.Drawing.Size(122, 23)
        Me.txtVat25Amt.TabIndex = 76
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmt.Location = New System.Drawing.Point(680, 99)
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.ReadOnly = True
        Me.txtTotalAmt.Size = New System.Drawing.Size(122, 23)
        Me.txtTotalAmt.TabIndex = 77
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(569, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 16)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = "Discount : "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(569, 46)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(108, 16)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "A. Tax (1 %) : "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(569, 75)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 16)
        Me.Label20.TabIndex = 71
        Me.Label20.Text = "VAT (2.5 %) : "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(569, 106)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 16)
        Me.Label21.TabIndex = 72
        Me.Label21.Text = "Total Amount : "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(569, 137)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 16)
        Me.Label22.TabIndex = 73
        Me.Label22.Text = "Net Amount : "
        '
        'txtRoundOff
        '
        Me.txtRoundOff.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoundOff.Location = New System.Drawing.Point(428, 134)
        Me.txtRoundOff.Name = "txtRoundOff"
        Me.txtRoundOff.ReadOnly = True
        Me.txtRoundOff.Size = New System.Drawing.Size(122, 23)
        Me.txtRoundOff.TabIndex = 68
        '
        'txtGAmt
        '
        Me.txtGAmt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGAmt.Location = New System.Drawing.Point(428, 8)
        Me.txtGAmt.Name = "txtGAmt"
        Me.txtGAmt.ReadOnly = True
        Me.txtGAmt.Size = New System.Drawing.Size(122, 23)
        Me.txtGAmt.TabIndex = 64
        '
        'txtVat4Amt
        '
        Me.txtVat4Amt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVat4Amt.Location = New System.Drawing.Point(428, 39)
        Me.txtVat4Amt.Name = "txtVat4Amt"
        Me.txtVat4Amt.ReadOnly = True
        Me.txtVat4Amt.Size = New System.Drawing.Size(122, 23)
        Me.txtVat4Amt.TabIndex = 65
        '
        'txtvat125Amt
        '
        Me.txtvat125Amt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvat125Amt.Location = New System.Drawing.Point(428, 68)
        Me.txtvat125Amt.Name = "txtvat125Amt"
        Me.txtvat125Amt.ReadOnly = True
        Me.txtvat125Amt.Size = New System.Drawing.Size(122, 23)
        Me.txtvat125Amt.TabIndex = 66
        '
        'txtCst2Amt
        '
        Me.txtCst2Amt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCst2Amt.Location = New System.Drawing.Point(428, 99)
        Me.txtCst2Amt.Name = "txtCst2Amt"
        Me.txtCst2Amt.ReadOnly = True
        Me.txtCst2Amt.Size = New System.Drawing.Size(122, 23)
        Me.txtCst2Amt.TabIndex = 67
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(320, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "G Amt. :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(320, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 16)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "VAT (4 %) : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(320, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 16)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "VAT (12.5 %) : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(320, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 16)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "CST (2%) : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(320, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 16)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "Round Off : "
        '
        'pnlDetails
        '
        Me.pnlDetails.Controls.Add(Me.MyDataGridView1)
        Me.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetails.Location = New System.Drawing.Point(0, 167)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(1225, 97)
        Me.pnlDetails.TabIndex = 2
        '
        'MyDataGridView1
        '
        Me.MyDataGridView1.AllowUserToAddRows = False
        Me.MyDataGridView1.AllowUserToDeleteRows = False
        Me.MyDataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MyDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.MyDataGridView1.ColumnHeadersHeight = 28
        Me.MyDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InwardDetailId, Me.InwardId, Me.ItemId, Me.CapitalA, Me.Digital1, Me.smalla, Me.ItemRemark, Me.Unit, Me.Qty, Me.Rate, Me.Dis, Me.DisAmount, Me.Vatper, Me.VatAmount, Me.Amount, Me.CapitalAHidden})
        Me.MyDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView1.Name = "MyDataGridView1"
        Me.MyDataGridView1.RowHeadersWidth = 20
        Me.MyDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView1.Size = New System.Drawing.Size(1225, 97)
        Me.MyDataGridView1.TabIndex = 11
        '
        'dtpOrderDate
        '
        Me.dtpOrderDate.Location = New System.Drawing.Point(409, 43)
        Me.dtpOrderDate.Mask = "00/00/0000"
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(122, 21)
        Me.dtpOrderDate.TabIndex = 3
        Me.dtpOrderDate.ValidatingType = GetType(Date)
        '
        'dtpChallanDate
        '
        Me.dtpChallanDate.Location = New System.Drawing.Point(409, 72)
        Me.dtpChallanDate.Mask = "00/00/0000"
        Me.dtpChallanDate.Name = "dtpChallanDate"
        Me.dtpChallanDate.Size = New System.Drawing.Size(122, 21)
        Me.dtpChallanDate.TabIndex = 5
        Me.dtpChallanDate.ValidatingType = GetType(Date)
        '
        'dtpLrRrDate
        '
        Me.dtpLrRrDate.Location = New System.Drawing.Point(409, 103)
        Me.dtpLrRrDate.Mask = "00/00/0000"
        Me.dtpLrRrDate.Name = "dtpLrRrDate"
        Me.dtpLrRrDate.Size = New System.Drawing.Size(122, 21)
        Me.dtpLrRrDate.TabIndex = 7
        Me.dtpLrRrDate.ValidatingType = GetType(Date)
        '
        'InwardDetailId
        '
        Me.InwardDetailId.HeaderText = "InwardDetailId"
        Me.InwardDetailId.Name = "InwardDetailId"
        Me.InwardDetailId.Visible = False
        '
        'InwardId
        '
        Me.InwardId.HeaderText = "InwardId"
        Me.InwardId.Name = "InwardId"
        Me.InwardId.Visible = False
        '
        'ItemId
        '
        Me.ItemId.HeaderText = "ItemId"
        Me.ItemId.Name = "ItemId"
        Me.ItemId.Visible = False
        '
        'CapitalA
        '
        Me.CapitalA.HeaderText = "CapitalA"
        Me.CapitalA.Name = "CapitalA"
        Me.CapitalA.Width = 80
        '
        'Digital1
        '
        Me.Digital1.HeaderText = "1"
        Me.Digital1.Name = "Digital1"
        Me.Digital1.Width = 80
        '
        'smalla
        '
        Me.smalla.HeaderText = "a"
        Me.smalla.Name = "smalla"
        Me.smalla.Width = 80
        '
        'ItemRemark
        '
        Me.ItemRemark.HeaderText = "Particulars"
        Me.ItemRemark.Name = "ItemRemark"
        Me.ItemRemark.Width = 330
        '
        'Unit
        '
        Me.Unit.HeaderText = "Unit"
        Me.Unit.Name = "Unit"
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 80
        '
        'Rate
        '
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 80
        '
        'Dis
        '
        Me.Dis.HeaderText = "Dis"
        Me.Dis.Name = "Dis"
        Me.Dis.Width = 80
        '
        'DisAmount
        '
        Me.DisAmount.HeaderText = "DisAmount"
        Me.DisAmount.Name = "DisAmount"
        Me.DisAmount.Visible = False
        '
        'Vatper
        '
        Me.Vatper.HeaderText = "Vat %"
        Me.Vatper.Name = "Vatper"
        Me.Vatper.Width = 80
        '
        'VatAmount
        '
        Me.VatAmount.HeaderText = "VatAmount"
        Me.VatAmount.Name = "VatAmount"
        Me.VatAmount.Visible = False
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'CapitalAHidden
        '
        Me.CapitalAHidden.HeaderText = "CapitalAHidden"
        Me.CapitalAHidden.Name = "CapitalAHidden"
        Me.CapitalAHidden.Visible = False
        '
        'FrmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1225, 475)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "FrmInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInvoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnlDetails.ResumeLayout(False)
        CType(Me.MyDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents chkPerformaInvoice As CheckBox
    Friend WithEvents cmbInvType As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbPartyName As ComboBox
    Friend WithEvents lblQNo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtQNo As TextBox
    Friend WithEvents txtOrderNo As TextBox
    Friend WithEvents txtChallanNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLrRrNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpQDate As DateTimePicker
    Friend WithEvents btnAddNewRow As Button
    Friend WithEvents txtParticular As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAddress As RichTextBox
    Friend WithEvents txtQNoCopy As TextBox
    Friend WithEvents btnCopy As Button
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents pnlDetails As Panel
    Friend WithEvents MyDataGridView1 As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtGAmt As TextBox
    Friend WithEvents txtVat4Amt As TextBox
    Friend WithEvents txtvat125Amt As TextBox
    Friend WithEvents txtCst2Amt As TextBox
    Friend WithEvents txtRoundOff As TextBox
    Friend WithEvents txtNetAmt As TextBox
    Friend WithEvents txtDiscountAmt As TextBox
    Friend WithEvents txtATax1Amt As TextBox
    Friend WithEvents txtVat25Amt As TextBox
    Friend WithEvents txtTotalAmt As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnView As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtLabourDisPer As TextBox
    Friend WithEvents txtlabourDisAmt As TextBox
    Friend WithEvents lblLabourDisPer As Label
    Friend WithEvents lbllabourDisAmt As Label
    Friend WithEvents chkCopyEntry As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtRemark As RichTextBox
    Friend WithEvents dtpLrRrDate As MaskedTextBox
    Friend WithEvents dtpChallanDate As MaskedTextBox
    Friend WithEvents dtpOrderDate As MaskedTextBox
    Friend WithEvents InwardDetailId As DataGridViewTextBoxColumn
    Friend WithEvents InwardId As DataGridViewTextBoxColumn
    Friend WithEvents ItemId As DataGridViewTextBoxColumn
    Friend WithEvents CapitalA As DataGridViewTextBoxColumn
    Friend WithEvents Digital1 As DataGridViewTextBoxColumn
    Friend WithEvents smalla As DataGridViewTextBoxColumn
    Friend WithEvents ItemRemark As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Dis As DataGridViewTextBoxColumn
    Friend WithEvents DisAmount As DataGridViewTextBoxColumn
    Friend WithEvents Vatper As DataGridViewTextBoxColumn
    Friend WithEvents VatAmount As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents CapitalAHidden As DataGridViewTextBoxColumn
End Class

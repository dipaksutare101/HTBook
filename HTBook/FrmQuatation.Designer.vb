<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvop
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblQNo = New System.Windows.Forms.Label()
        Me.lblOrderNo = New System.Windows.Forms.Label()
        Me.lblChallanNo = New System.Windows.Forms.Label()
        Me.lblLRRRNo = New System.Windows.Forms.Label()
        Me.lblPartyName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQNo = New HTBook.MyTextBox(Me.components)
        Me.txtOrderNo = New HTBook.MyTextBox(Me.components)
        Me.txtChallanNo = New HTBook.MyTextBox(Me.components)
        Me.txtLrRrNo = New HTBook.MyTextBox(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblInvTYpe = New System.Windows.Forms.Label()
        Me.cmbPartyName = New System.Windows.Forms.ComboBox()
        Me.cmbInvType = New System.Windows.Forms.ComboBox()
        Me.btnAddRow = New System.Windows.Forms.Button()
        Me.MyTextBox5 = New HTBook.MyTextBox(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MyDataGridView1 = New HTBook.MyDataGridView(Me.components)
        Me.ColInwardDetailId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColInwardId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COlCapitalA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDigital1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colsmalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColItemRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDisAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVatper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVatAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitalAHidden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRemark = New HTBook.MyTextBox(Me.components)
        Me.lblGAmount = New System.Windows.Forms.Label()
        Me.txtGAmount = New HTBook.MyTextBox(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiscount = New HTBook.MyTextBox(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtVat4Prct = New HTBook.MyTextBox(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVAT125Prct = New HTBook.MyTextBox(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAVat25Prct = New HTBook.MyTextBox(Me.components)
        Me.txtATex1PRct = New HTBook.MyTextBox(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCST = New HTBook.MyTextBox(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRounfOff = New HTBook.MyTextBox(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New HTBook.MyTextBox(Me.components)
        Me.txtNetAmount = New HTBook.MyTextBox(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MyTextBox6 = New HTBook.MyTextBox(Me.components)
        Me.chkPerfomaInvoice = New System.Windows.Forms.CheckBox()
        Me.lblCpoyQNo = New System.Windows.Forms.Label()
        Me.txtCopyQ = New HTBook.MyTextBox(Me.components)
        Me.BtnCopyQuatattion = New System.Windows.Forms.Button()
        Me.ChkCopyEntry = New System.Windows.Forms.CheckBox()
        Me.lblLabourDisPer = New System.Windows.Forms.Label()
        Me.lblLabourDisAmt = New System.Windows.Forms.Label()
        Me.txtLabourDisPer = New HTBook.MyTextBox(Me.components)
        Me.txtLabourDisAmt = New HTBook.MyTextBox(Me.components)
        Me.DtpOrderDate = New System.Windows.Forms.MaskedTextBox()
        Me.dtpChallanDate = New System.Windows.Forms.MaskedTextBox()
        Me.dtpLrRrDate = New System.Windows.Forms.MaskedTextBox()
        Me.DtpQdate = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.MyDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.35294!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.666667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblQNo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOrderNo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblChallanNo, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLRRRNo, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPartyName, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDate, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtQNo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtOrderNo, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtChallanNo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLrRrNo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 8, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblInvTYpe, 8, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPartyName, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbInvType, 9, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddRow, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.MyTextBox5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.MyDataGridView1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRemark, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblGAmount, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtGAmount, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDiscount, 5, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtVat4Prct, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 4, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtVAT125Prct, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 4, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAVat25Prct, 5, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtATex1PRct, 5, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCST, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 4, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRounfOff, 3, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 4, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTotalAmount, 5, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNetAmount, 5, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.MyTextBox6, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkPerfomaInvoice, 9, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCpoyQNo, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCopyQ, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCopyQuatattion, 6, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ChkCopyEntry, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLabourDisPer, 8, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLabourDisAmt, 8, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLabourDisPer, 9, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLabourDisAmt, 9, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.DtpOrderDate, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpChallanDate, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpLrRrDate, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DtpQdate, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 12
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1212, 626)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblQNo
        '
        Me.lblQNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblQNo.AutoSize = True
        Me.lblQNo.Location = New System.Drawing.Point(3, 5)
        Me.lblQNo.Name = "lblQNo"
        Me.lblQNo.Size = New System.Drawing.Size(54, 20)
        Me.lblQNo.TabIndex = 0
        Me.lblQNo.Text = "Q. No :"
        '
        'lblOrderNo
        '
        Me.lblOrderNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Location = New System.Drawing.Point(3, 36)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(81, 20)
        Me.lblOrderNo.TabIndex = 0
        Me.lblOrderNo.Text = "Order No. :"
        '
        'lblChallanNo
        '
        Me.lblChallanNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblChallanNo.AutoSize = True
        Me.lblChallanNo.Location = New System.Drawing.Point(3, 67)
        Me.lblChallanNo.Name = "lblChallanNo"
        Me.lblChallanNo.Size = New System.Drawing.Size(92, 20)
        Me.lblChallanNo.TabIndex = 0
        Me.lblChallanNo.Text = "Challan No. :"
        '
        'lblLRRRNo
        '
        Me.lblLRRRNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLRRRNo.AutoSize = True
        Me.lblLRRRNo.Location = New System.Drawing.Point(3, 98)
        Me.lblLRRRNo.Name = "lblLRRRNo"
        Me.lblLRRRNo.Size = New System.Drawing.Size(91, 20)
        Me.lblLRRRNo.TabIndex = 0
        Me.lblLRRRNo.Text = "LR / RR No. :"
        '
        'lblPartyName
        '
        Me.lblPartyName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPartyName.AutoSize = True
        Me.lblPartyName.Location = New System.Drawing.Point(3, 132)
        Me.lblPartyName.Name = "lblPartyName"
        Me.lblPartyName.Size = New System.Drawing.Size(92, 20)
        Me.lblPartyName.TabIndex = 0
        Me.lblPartyName.Text = "Party Name :"
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(299, 5)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(299, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Date :"
        '
        'txtQNo
        '
        Me.txtQNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQNo.Location = New System.Drawing.Point(101, 3)
        Me.txtQNo.Name = "txtQNo"
        Me.txtQNo.Size = New System.Drawing.Size(192, 27)
        Me.txtQNo.TabIndex = 0
        '
        'txtOrderNo
        '
        Me.txtOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrderNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOrderNo.Location = New System.Drawing.Point(101, 34)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(192, 27)
        Me.txtOrderNo.TabIndex = 2
        '
        'txtChallanNo
        '
        Me.txtChallanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChallanNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtChallanNo.Location = New System.Drawing.Point(101, 65)
        Me.txtChallanNo.Name = "txtChallanNo"
        Me.txtChallanNo.Size = New System.Drawing.Size(192, 27)
        Me.txtChallanNo.TabIndex = 4
        '
        'txtLrRrNo
        '
        Me.txtLrRrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLrRrNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLrRrNo.Location = New System.Drawing.Point(101, 96)
        Me.txtLrRrNo.Name = "txtLrRrNo"
        Me.txtLrRrNo.Size = New System.Drawing.Size(192, 27)
        Me.txtLrRrNo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(989, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ID :"
        '
        'lblInvTYpe
        '
        Me.lblInvTYpe.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblInvTYpe.AutoSize = True
        Me.lblInvTYpe.Location = New System.Drawing.Point(989, 67)
        Me.lblInvTYpe.Name = "lblInvTYpe"
        Me.lblInvTYpe.Size = New System.Drawing.Size(73, 20)
        Me.lblInvTYpe.TabIndex = 0
        Me.lblInvTYpe.Text = "Inv. Type :"
        '
        'cmbPartyName
        '
        Me.cmbPartyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPartyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmbPartyName, 2)
        Me.cmbPartyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPartyName.FormattingEnabled = True
        Me.cmbPartyName.Location = New System.Drawing.Point(101, 127)
        Me.cmbPartyName.Name = "cmbPartyName"
        Me.cmbPartyName.Size = New System.Drawing.Size(298, 28)
        Me.cmbPartyName.TabIndex = 8
        '
        'cmbInvType
        '
        Me.cmbInvType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbInvType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInvType.FormattingEnabled = True
        Me.cmbInvType.Location = New System.Drawing.Point(1085, 65)
        Me.cmbInvType.Name = "cmbInvType"
        Me.cmbInvType.Size = New System.Drawing.Size(124, 28)
        Me.cmbInvType.TabIndex = 9
        '
        'btnAddRow
        '
        Me.btnAddRow.AutoSize = True
        Me.btnAddRow.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnAddRow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRow.Location = New System.Drawing.Point(405, 127)
        Me.btnAddRow.Name = "btnAddRow"
        Me.btnAddRow.Size = New System.Drawing.Size(124, 30)
        Me.btnAddRow.TabIndex = 13
        Me.btnAddRow.Text = "Add Row"
        Me.btnAddRow.UseVisualStyleBackColor = False
        '
        'MyTextBox5
        '
        Me.MyTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.MyTextBox5, 2)
        Me.MyTextBox5.Location = New System.Drawing.Point(535, 3)
        Me.MyTextBox5.Multiline = True
        Me.MyTextBox5.Name = "MyTextBox5"
        Me.TableLayoutPanel1.SetRowSpan(Me.MyTextBox5, 3)
        Me.MyTextBox5.Size = New System.Drawing.Size(279, 87)
        Me.MyTextBox5.TabIndex = 11
        '
        'FlowLayoutPanel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.FlowLayoutPanel1, 10)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnPrint)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button5)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 585)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1206, 38)
        Me.FlowLayoutPanel1.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1128, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.AutoSize = True
        Me.BtnPrint.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Location = New System.Drawing.Point(1047, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 32)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(966, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(885, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.LemonChiffon
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(804, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 32)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "View"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.Color.LemonChiffon
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(723, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 32)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "New"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'MyDataGridView1
        '
        Me.MyDataGridView1.AllowUserToAddRows = False
        Me.MyDataGridView1.AllowUserToDeleteRows = False
        Me.MyDataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MyDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MyDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColInwardDetailId, Me.ColInwardId, Me.ColItemId, Me.COlCapitalA, Me.ColDigital1, Me.Colsmalla, Me.ColItemRemark, Me.ColUnit, Me.ColQty, Me.ColRate, Me.ColDis, Me.ColDisAmount, Me.ColVatper, Me.ColVatAmount, Me.ColAmount, Me.CapitalAHidden})
        Me.TableLayoutPanel1.SetColumnSpan(Me.MyDataGridView1, 10)
        Me.MyDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.MyDataGridView1.Location = New System.Drawing.Point(3, 163)
        Me.MyDataGridView1.Name = "MyDataGridView1"
        Me.MyDataGridView1.RowHeadersWidth = 20
        Me.MyDataGridView1.RowTemplate.Height = 28
        Me.MyDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView1.Size = New System.Drawing.Size(1206, 261)
        Me.MyDataGridView1.TabIndex = 12
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
        '
        'ColDigital1
        '
        Me.ColDigital1.DataPropertyName = "Digital1"
        Me.ColDigital1.HeaderText = "1"
        Me.ColDigital1.Name = "ColDigital1"
        '
        'Colsmalla
        '
        Me.Colsmalla.DataPropertyName = "smalla"
        Me.Colsmalla.HeaderText = "a"
        Me.Colsmalla.Name = "Colsmalla"
        '
        'ColItemRemark
        '
        Me.ColItemRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColItemRemark.DataPropertyName = "ItemRemark"
        Me.ColItemRemark.HeaderText = "Particulars"
        Me.ColItemRemark.Name = "ColItemRemark"
        Me.ColItemRemark.Width = 400
        '
        'ColUnit
        '
        Me.ColUnit.DataPropertyName = "Unit"
        Me.ColUnit.HeaderText = "Unit"
        Me.ColUnit.Name = "ColUnit"
        '
        'ColQty
        '
        Me.ColQty.DataPropertyName = "Qty"
        DataGridViewCellStyle2.Format = "N2"
        Me.ColQty.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColQty.HeaderText = "Qty"
        Me.ColQty.Name = "ColQty"
        '
        'ColRate
        '
        Me.ColRate.DataPropertyName = "Rate"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ColRate.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColRate.HeaderText = "Rate"
        Me.ColRate.Name = "ColRate"
        '
        'ColDis
        '
        Me.ColDis.DataPropertyName = "Dis"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.ColDis.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColDis.HeaderText = "Dis"
        Me.ColDis.Name = "ColDis"
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.ColVatper.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColVatper.HeaderText = "Vat %"
        Me.ColVatper.Name = "ColVatper"
        '
        'ColVatAmount
        '
        Me.ColVatAmount.DataPropertyName = "VatAmount"
        Me.ColVatAmount.HeaderText = "VatAmount"
        Me.ColVatAmount.Name = "ColVatAmount"
        Me.ColVatAmount.Visible = False
        '
        'ColAmount
        '
        Me.ColAmount.DataPropertyName = "Amount"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.ColAmount.DefaultCellStyle = DataGridViewCellStyle6
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
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Remark :"
        '
        'txtRemark
        '
        Me.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRemark.Location = New System.Drawing.Point(101, 430)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.TableLayoutPanel1.SetRowSpan(Me.txtRemark, 3)
        Me.txtRemark.Size = New System.Drawing.Size(192, 87)
        Me.txtRemark.TabIndex = 25
        '
        'lblGAmount
        '
        Me.lblGAmount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblGAmount.AutoSize = True
        Me.lblGAmount.Location = New System.Drawing.Point(299, 432)
        Me.lblGAmount.Name = "lblGAmount"
        Me.lblGAmount.Size = New System.Drawing.Size(64, 20)
        Me.lblGAmount.TabIndex = 0
        Me.lblGAmount.Text = "G. Amt. :"
        '
        'txtGAmount
        '
        Me.txtGAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGAmount.Location = New System.Drawing.Point(405, 430)
        Me.txtGAmount.Name = "txtGAmount"
        Me.txtGAmount.ReadOnly = True
        Me.txtGAmount.Size = New System.Drawing.Size(124, 27)
        Me.txtGAmount.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(535, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Discount :"
        '
        'txtDiscount
        '
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtDiscount, 2)
        Me.txtDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDiscount.Location = New System.Drawing.Point(647, 430)
        Me.txtDiscount.MaximumSize = New System.Drawing.Size(130, 27)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(130, 27)
        Me.txtDiscount.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(299, 463)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "VAT (4 %) :"
        '
        'TxtVat4Prct
        '
        Me.TxtVat4Prct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVat4Prct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtVat4Prct.Location = New System.Drawing.Point(405, 461)
        Me.TxtVat4Prct.Name = "TxtVat4Prct"
        Me.TxtVat4Prct.ReadOnly = True
        Me.TxtVat4Prct.Size = New System.Drawing.Size(124, 27)
        Me.TxtVat4Prct.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(535, 463)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "A.Tax (1 %) :"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(299, 494)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "VAT (12.5 %) :"
        '
        'txtVAT125Prct
        '
        Me.txtVAT125Prct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVAT125Prct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtVAT125Prct.Location = New System.Drawing.Point(405, 492)
        Me.txtVAT125Prct.Name = "txtVAT125Prct"
        Me.txtVAT125Prct.ReadOnly = True
        Me.txtVAT125Prct.Size = New System.Drawing.Size(124, 27)
        Me.txtVAT125Prct.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(535, 494)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "VAT (2.5 %) :"
        '
        'txtAVat25Prct
        '
        Me.txtAVat25Prct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtAVat25Prct, 2)
        Me.txtAVat25Prct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAVat25Prct.Location = New System.Drawing.Point(647, 492)
        Me.txtAVat25Prct.MaximumSize = New System.Drawing.Size(130, 27)
        Me.txtAVat25Prct.Name = "txtAVat25Prct"
        Me.txtAVat25Prct.ReadOnly = True
        Me.txtAVat25Prct.Size = New System.Drawing.Size(130, 27)
        Me.txtAVat25Prct.TabIndex = 20
        '
        'txtATex1PRct
        '
        Me.txtATex1PRct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtATex1PRct, 2)
        Me.txtATex1PRct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtATex1PRct.Location = New System.Drawing.Point(647, 461)
        Me.txtATex1PRct.MaximumSize = New System.Drawing.Size(130, 27)
        Me.txtATex1PRct.Name = "txtATex1PRct"
        Me.txtATex1PRct.ReadOnly = True
        Me.txtATex1PRct.Size = New System.Drawing.Size(130, 27)
        Me.txtATex1PRct.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(299, 525)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "CST (2 %) :"
        '
        'txtCST
        '
        Me.txtCST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCST.Location = New System.Drawing.Point(405, 523)
        Me.txtCST.Name = "txtCST"
        Me.txtCST.ReadOnly = True
        Me.txtCST.Size = New System.Drawing.Size(124, 27)
        Me.txtCST.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(535, 525)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Total Amount :"
        '
        'txtRounfOff
        '
        Me.txtRounfOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRounfOff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRounfOff.Location = New System.Drawing.Point(405, 554)
        Me.txtRounfOff.Name = "txtRounfOff"
        Me.txtRounfOff.ReadOnly = True
        Me.txtRounfOff.Size = New System.Drawing.Size(124, 27)
        Me.txtRounfOff.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(535, 556)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Net Amopunt :"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtTotalAmount, 2)
        Me.txtTotalAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTotalAmount.Location = New System.Drawing.Point(647, 523)
        Me.txtTotalAmount.MaximumSize = New System.Drawing.Size(130, 27)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(130, 27)
        Me.txtTotalAmount.TabIndex = 22
        '
        'txtNetAmount
        '
        Me.txtNetAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtNetAmount, 2)
        Me.txtNetAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNetAmount.Location = New System.Drawing.Point(647, 554)
        Me.txtNetAmount.MaximumSize = New System.Drawing.Size(130, 27)
        Me.txtNetAmount.Name = "txtNetAmount"
        Me.txtNetAmount.ReadOnly = True
        Me.txtNetAmount.Size = New System.Drawing.Size(130, 27)
        Me.txtNetAmount.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(299, 556)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Round off :"
        '
        'MyTextBox6
        '
        Me.MyTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyTextBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyTextBox6.Location = New System.Drawing.Point(860, 3)
        Me.MyTextBox6.Multiline = True
        Me.MyTextBox6.Name = "MyTextBox6"
        Me.TableLayoutPanel1.SetRowSpan(Me.MyTextBox6, 3)
        Me.MyTextBox6.Size = New System.Drawing.Size(114, 87)
        Me.MyTextBox6.TabIndex = 101
        Me.MyTextBox6.TabStop = False
        '
        'chkPerfomaInvoice
        '
        Me.chkPerfomaInvoice.AutoSize = True
        Me.chkPerfomaInvoice.Location = New System.Drawing.Point(1085, 96)
        Me.chkPerfomaInvoice.Name = "chkPerfomaInvoice"
        Me.chkPerfomaInvoice.Size = New System.Drawing.Size(124, 24)
        Me.chkPerfomaInvoice.TabIndex = 10
        Me.chkPerfomaInvoice.Text = "Perfoma Invoice"
        Me.chkPerfomaInvoice.UseVisualStyleBackColor = True
        '
        'lblCpoyQNo
        '
        Me.lblCpoyQNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCpoyQNo.AutoSize = True
        Me.lblCpoyQNo.Location = New System.Drawing.Point(535, 132)
        Me.lblCpoyQNo.Name = "lblCpoyQNo"
        Me.lblCpoyQNo.Size = New System.Drawing.Size(54, 20)
        Me.lblCpoyQNo.TabIndex = 11
        Me.lblCpoyQNo.Text = "Q. No :"
        '
        'txtCopyQ
        '
        Me.txtCopyQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCopyQ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCopyQ.Location = New System.Drawing.Point(647, 127)
        Me.txtCopyQ.Name = "txtCopyQ"
        Me.txtCopyQ.Size = New System.Drawing.Size(207, 27)
        Me.txtCopyQ.TabIndex = 14
        '
        'BtnCopyQuatattion
        '
        Me.BtnCopyQuatattion.AutoSize = True
        Me.BtnCopyQuatattion.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnCopyQuatattion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopyQuatattion.Location = New System.Drawing.Point(860, 127)
        Me.BtnCopyQuatattion.Name = "BtnCopyQuatattion"
        Me.BtnCopyQuatattion.Size = New System.Drawing.Size(114, 30)
        Me.BtnCopyQuatattion.TabIndex = 15
        Me.BtnCopyQuatattion.Text = "Copy Quatation"
        Me.BtnCopyQuatattion.UseVisualStyleBackColor = False
        '
        'ChkCopyEntry
        '
        Me.ChkCopyEntry.AutoSize = True
        Me.ChkCopyEntry.Location = New System.Drawing.Point(101, 554)
        Me.ChkCopyEntry.Name = "ChkCopyEntry"
        Me.ChkCopyEntry.Size = New System.Drawing.Size(99, 24)
        Me.ChkCopyEntry.TabIndex = 26
        Me.ChkCopyEntry.Text = "Copy Entry"
        Me.ChkCopyEntry.UseVisualStyleBackColor = True
        '
        'lblLabourDisPer
        '
        Me.lblLabourDisPer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLabourDisPer.AutoSize = True
        Me.lblLabourDisPer.Location = New System.Drawing.Point(997, 432)
        Me.lblLabourDisPer.Name = "lblLabourDisPer"
        Me.lblLabourDisPer.Size = New System.Drawing.Size(74, 20)
        Me.lblLabourDisPer.TabIndex = 28
        Me.lblLabourDisPer.Text = "Lab Dis %"
        '
        'lblLabourDisAmt
        '
        Me.lblLabourDisAmt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLabourDisAmt.AutoSize = True
        Me.lblLabourDisAmt.Location = New System.Drawing.Point(989, 463)
        Me.lblLabourDisAmt.Name = "lblLabourDisAmt"
        Me.lblLabourDisAmt.Size = New System.Drawing.Size(90, 20)
        Me.lblLabourDisAmt.TabIndex = 29
        Me.lblLabourDisAmt.Text = "Lab Dis Amt"
        '
        'txtLabourDisPer
        '
        Me.txtLabourDisPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLabourDisPer.Location = New System.Drawing.Point(1085, 430)
        Me.txtLabourDisPer.Name = "txtLabourDisPer"
        Me.txtLabourDisPer.Size = New System.Drawing.Size(82, 27)
        Me.txtLabourDisPer.TabIndex = 30
        '
        'txtLabourDisAmt
        '
        Me.txtLabourDisAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLabourDisAmt.Location = New System.Drawing.Point(1085, 461)
        Me.txtLabourDisAmt.Name = "txtLabourDisAmt"
        Me.txtLabourDisAmt.ReadOnly = True
        Me.txtLabourDisAmt.Size = New System.Drawing.Size(122, 27)
        Me.txtLabourDisAmt.TabIndex = 31
        '
        'DtpOrderDate
        '
        Me.DtpOrderDate.Location = New System.Drawing.Point(405, 34)
        Me.DtpOrderDate.Mask = "00/00/0000"
        Me.DtpOrderDate.Name = "DtpOrderDate"
        Me.DtpOrderDate.Size = New System.Drawing.Size(124, 27)
        Me.DtpOrderDate.TabIndex = 3
        Me.DtpOrderDate.ValidatingType = GetType(Date)
        '
        'dtpChallanDate
        '
        Me.dtpChallanDate.Location = New System.Drawing.Point(405, 65)
        Me.dtpChallanDate.Mask = "00/00/0000"
        Me.dtpChallanDate.Name = "dtpChallanDate"
        Me.dtpChallanDate.Size = New System.Drawing.Size(124, 27)
        Me.dtpChallanDate.TabIndex = 5
        Me.dtpChallanDate.ValidatingType = GetType(Date)
        '
        'dtpLrRrDate
        '
        Me.dtpLrRrDate.Location = New System.Drawing.Point(405, 96)
        Me.dtpLrRrDate.Mask = "00/00/0000"
        Me.dtpLrRrDate.Name = "dtpLrRrDate"
        Me.dtpLrRrDate.Size = New System.Drawing.Size(124, 27)
        Me.dtpLrRrDate.TabIndex = 7
        Me.dtpLrRrDate.ValidatingType = GetType(Date)
        '
        'DtpQdate
        '
        Me.DtpQdate.Location = New System.Drawing.Point(405, 3)
        Me.DtpQdate.Mask = "00/00/0000"
        Me.DtpQdate.Name = "DtpQdate"
        Me.DtpQdate.Size = New System.Drawing.Size(124, 27)
        Me.DtpQdate.TabIndex = 1
        Me.DtpQdate.ValidatingType = GetType(Date)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1212, 3)
        Me.Panel1.TabIndex = 1
        '
        'FrmInvop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1212, 629)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "FrmInvop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quatation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.MyDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblQNo As Label
    Friend WithEvents lblOrderNo As Label
    Friend WithEvents lblChallanNo As Label
    Friend WithEvents lblLRRRNo As Label
    Friend WithEvents lblPartyName As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQNo As MyTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtOrderNo As MyTextBox
    Friend WithEvents txtChallanNo As MyTextBox
    Friend WithEvents txtLrRrNo As MyTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblInvTYpe As Label
    Friend WithEvents cmbPartyName As ComboBox
    Friend WithEvents cmbInvType As ComboBox
    Friend WithEvents btnAddRow As Button
    Friend WithEvents MyTextBox6 As MyTextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents MyDataGridView1 As MyDataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRemark As MyTextBox
    Friend WithEvents lblGAmount As Label
    Friend WithEvents txtGAmount As MyTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDiscount As MyTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnPrint As Button
    Friend WithEvents TxtVat4Prct As MyTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtVAT125Prct As MyTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAVat25Prct As MyTextBox
    Friend WithEvents txtATex1PRct As MyTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCST As MyTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtRounfOff As MyTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotalAmount As MyTextBox
    Friend WithEvents txtNetAmount As MyTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents chkPerfomaInvoice As System.Windows.Forms.CheckBox
    Friend WithEvents lblCpoyQNo As System.Windows.Forms.Label
    Friend WithEvents txtCopyQ As HTBook.MyTextBox
    Friend WithEvents BtnCopyQuatattion As System.Windows.Forms.Button
    Friend WithEvents ChkCopyEntry As System.Windows.Forms.CheckBox
    Friend WithEvents lblLabourDisPer As Label
    Friend WithEvents lblLabourDisAmt As Label
    Friend WithEvents txtLabourDisPer As MyTextBox
    Friend WithEvents txtLabourDisAmt As MyTextBox
    Friend WithEvents DtpOrderDate As MaskedTextBox
    Friend WithEvents dtpChallanDate As MaskedTextBox
    Friend WithEvents dtpLrRrDate As MaskedTextBox
    Friend WithEvents DtpQdate As MaskedTextBox
    Private WithEvents MyTextBox5 As MyTextBox
    Friend WithEvents ColInwardDetailId As DataGridViewTextBoxColumn
    Friend WithEvents ColInwardId As DataGridViewTextBoxColumn
    Friend WithEvents ColItemId As DataGridViewTextBoxColumn
    Friend WithEvents COlCapitalA As DataGridViewTextBoxColumn
    Friend WithEvents ColDigital1 As DataGridViewTextBoxColumn
    Friend WithEvents Colsmalla As DataGridViewTextBoxColumn
    Friend WithEvents ColItemRemark As DataGridViewTextBoxColumn
    Friend WithEvents ColUnit As DataGridViewTextBoxColumn
    Friend WithEvents ColQty As DataGridViewTextBoxColumn
    Friend WithEvents ColRate As DataGridViewTextBoxColumn
    Friend WithEvents ColDis As DataGridViewTextBoxColumn
    Friend WithEvents ColDisAmount As DataGridViewTextBoxColumn
    Friend WithEvents ColVatper As DataGridViewTextBoxColumn
    Friend WithEvents ColVatAmount As DataGridViewTextBoxColumn
    Friend WithEvents ColAmount As DataGridViewTextBoxColumn
    Friend WithEvents CapitalAHidden As DataGridViewTextBoxColumn
End Class

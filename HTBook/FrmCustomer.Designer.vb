<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomer
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlCustomerAdd = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGSTNo = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMobileNo2 = New HTBook.MyTextBox(Me.components)
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtMobileNo1 = New HTBook.MyTextBox(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPostalCode = New HTBook.MyTextBox(Me.components)
        Me.cmbStateName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblCustomerId = New System.Windows.Forms.Label()
        Me.txtSearchText = New HTBook.WatermarkTextbox(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlCustomerAdd.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(998, 321)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.pnlCustomerAdd)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(998, 321)
        Me.Panel3.TabIndex = 1
        '
        'pnlCustomerAdd
        '
        Me.pnlCustomerAdd.Controls.Add(Me.Button2)
        Me.pnlCustomerAdd.Controls.Add(Me.Button1)
        Me.pnlCustomerAdd.Controls.Add(Me.Label8)
        Me.pnlCustomerAdd.Controls.Add(Me.Label1)
        Me.pnlCustomerAdd.Controls.Add(Me.txtGSTNo)
        Me.pnlCustomerAdd.Controls.Add(Me.txtCustomerName)
        Me.pnlCustomerAdd.Controls.Add(Me.Label7)
        Me.pnlCustomerAdd.Controls.Add(Me.Label2)
        Me.pnlCustomerAdd.Controls.Add(Me.txtMobileNo2)
        Me.pnlCustomerAdd.Controls.Add(Me.txtAddress1)
        Me.pnlCustomerAdd.Controls.Add(Me.txtMobileNo1)
        Me.pnlCustomerAdd.Controls.Add(Me.Label3)
        Me.pnlCustomerAdd.Controls.Add(Me.Label5)
        Me.pnlCustomerAdd.Controls.Add(Me.txtPostalCode)
        Me.pnlCustomerAdd.Controls.Add(Me.cmbStateName)
        Me.pnlCustomerAdd.Controls.Add(Me.Label4)
        Me.pnlCustomerAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlCustomerAdd.Location = New System.Drawing.Point(0, 0)
        Me.pnlCustomerAdd.Name = "pnlCustomerAdd"
        Me.pnlCustomerAdd.Size = New System.Drawing.Size(455, 321)
        Me.pnlCustomerAdd.TabIndex = 33
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(348, 292)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "E&xit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(240, 292)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(275, 190)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "/"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Customer Name"
        '
        'txtGSTNo
        '
        Me.txtGSTNo.Location = New System.Drawing.Point(129, 155)
        Me.txtGSTNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtGSTNo.Name = "txtGSTNo"
        Me.txtGSTNo.Size = New System.Drawing.Size(319, 21)
        Me.txtGSTNo.TabIndex = 4
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(129, 12)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(319, 21)
        Me.txtCustomerName.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 158)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "GST No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Address"
        '
        'txtMobileNo2
        '
        Me.txtMobileNo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileNo2.InputType = HTBook.TextInputType.Number
        Me.txtMobileNo2.Location = New System.Drawing.Point(303, 187)
        Me.txtMobileNo2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMobileNo2.Name = "txtMobileNo2"
        Me.txtMobileNo2.Size = New System.Drawing.Size(145, 21)
        Me.txtMobileNo2.TabIndex = 6
        Me.txtMobileNo2.Text = "0"
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(129, 43)
        Me.txtAddress1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddress1.Multiline = True
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(319, 69)
        Me.txtAddress1.TabIndex = 1
        '
        'txtMobileNo1
        '
        Me.txtMobileNo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileNo1.InputType = HTBook.TextInputType.Number
        Me.txtMobileNo1.Location = New System.Drawing.Point(129, 187)
        Me.txtMobileNo1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMobileNo1.Name = "txtMobileNo1"
        Me.txtMobileNo1.Size = New System.Drawing.Size(145, 21)
        Me.txtMobileNo1.TabIndex = 5
        Me.txtMobileNo1.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(293, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "PIN Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 189)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Mobile No."
        '
        'txtPostalCode
        '
        Me.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPostalCode.InputType = HTBook.TextInputType.Number
        Me.txtPostalCode.Location = New System.Drawing.Point(366, 124)
        Me.txtPostalCode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(82, 21)
        Me.txtPostalCode.TabIndex = 3
        Me.txtPostalCode.Text = "0"
        '
        'cmbStateName
        '
        Me.cmbStateName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStateName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStateName.FormattingEnabled = True
        Me.cmbStateName.Location = New System.Drawing.Point(129, 123)
        Me.cmbStateName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbStateName.Name = "cmbStateName"
        Me.cmbStateName.Size = New System.Drawing.Size(145, 21)
        Me.cmbStateName.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "State"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(455, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(543, 321)
        Me.Panel6.TabIndex = 32
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.dgvCustomers)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 39)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(543, 282)
        Me.Panel9.TabIndex = 1
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToOrderColumns = True
        Me.dgvCustomers.AllowUserToResizeColumns = False
        Me.dgvCustomers.AllowUserToResizeRows = False
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCustomers.Location = New System.Drawing.Point(0, 0)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(543, 282)
        Me.dgvCustomers.TabIndex = 10
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.lblCustomerId)
        Me.Panel8.Controls.Add(Me.txtSearchText)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(543, 39)
        Me.Panel8.TabIndex = 0
        '
        'lblCustomerId
        '
        Me.lblCustomerId.AutoSize = True
        Me.lblCustomerId.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerId.Location = New System.Drawing.Point(447, 15)
        Me.lblCustomerId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerId.Name = "lblCustomerId"
        Me.lblCustomerId.Size = New System.Drawing.Size(83, 13)
        Me.lblCustomerId.TabIndex = 32
        Me.lblCustomerId.Text = "CustomerId"
        Me.lblCustomerId.Visible = False
        '
        'txtSearchText
        '
        Me.txtSearchText.Location = New System.Drawing.Point(6, 12)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(284, 21)
        Me.txtSearchText.TabIndex = 9
        Me.txtSearchText.WatermarkText = "Enter search text here..."
        '
        'FrmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 321)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCustomer"
        Me.ShowIcon = False
        Me.Text = "Customer"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.pnlCustomerAdd.ResumeLayout(False)
        Me.pnlCustomerAdd.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtGSTNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo2 As HTBook.MyTextBox
    Friend WithEvents txtMobileNo1 As HTBook.MyTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbStateName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPostalCode As HTBook.MyTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pnlCustomerAdd As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents dgvCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearchText As HTBook.WatermarkTextbox
    Friend WithEvents lblCustomerId As System.Windows.Forms.Label
End Class

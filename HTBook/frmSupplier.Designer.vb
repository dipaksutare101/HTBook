<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSupplierId = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.txtCSTNo = New System.Windows.Forms.TextBox()
        Me.txtGSTNo = New System.Windows.Forms.TextBox()
        Me.txtPinCode = New System.Windows.Forms.TextBox()
        Me.cmbStateName = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(686, 432)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblSupplierId)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(111, 426)
        Me.Panel1.TabIndex = 0
        '
        'lblSupplierId
        '
        Me.lblSupplierId.AutoSize = True
        Me.lblSupplierId.Location = New System.Drawing.Point(61, 74)
        Me.lblSupplierId.Name = "lblSupplierId"
        Me.lblSupplierId.Size = New System.Drawing.Size(18, 13)
        Me.lblSupplierId.TabIndex = 8
        Me.lblSupplierId.Text = "ID"
        Me.lblSupplierId.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "MobileNo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CST No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "GST No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pin Code"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "State"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "City"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier Name"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnNew)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnView)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.txtMobileNo)
        Me.Panel2.Controls.Add(Me.txtCSTNo)
        Me.Panel2.Controls.Add(Me.txtGSTNo)
        Me.Panel2.Controls.Add(Me.txtPinCode)
        Me.Panel2.Controls.Add(Me.cmbStateName)
        Me.Panel2.Controls.Add(Me.txtCity)
        Me.Panel2.Controls.Add(Me.txtAddress)
        Me.Panel2.Controls.Add(Me.txtSupplierName)
        Me.Panel2.Location = New System.Drawing.Point(120, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(465, 426)
        Me.Panel2.TabIndex = 1
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(35, 286)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(102, 37)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "New (Ctrl+N)"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(143, 286)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 37)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(251, 286)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(102, 37)
        Me.btnView.TabIndex = 10
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(359, 286)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 37)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit (Esc)"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(3, 243)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(458, 20)
        Me.txtMobileNo.TabIndex = 7
        '
        'txtCSTNo
        '
        Me.txtCSTNo.Location = New System.Drawing.Point(3, 217)
        Me.txtCSTNo.Name = "txtCSTNo"
        Me.txtCSTNo.Size = New System.Drawing.Size(458, 20)
        Me.txtCSTNo.TabIndex = 6
        '
        'txtGSTNo
        '
        Me.txtGSTNo.Location = New System.Drawing.Point(3, 191)
        Me.txtGSTNo.Name = "txtGSTNo"
        Me.txtGSTNo.Size = New System.Drawing.Size(458, 20)
        Me.txtGSTNo.TabIndex = 5
        '
        'txtPinCode
        '
        Me.txtPinCode.Location = New System.Drawing.Point(3, 162)
        Me.txtPinCode.Name = "txtPinCode"
        Me.txtPinCode.Size = New System.Drawing.Size(458, 20)
        Me.txtPinCode.TabIndex = 4
        Me.txtPinCode.Visible = False
        '
        'cmbStateName
        '
        Me.cmbStateName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbStateName.FormattingEnabled = True
        Me.cmbStateName.Location = New System.Drawing.Point(4, 132)
        Me.cmbStateName.Name = "cmbStateName"
        Me.cmbStateName.Size = New System.Drawing.Size(457, 21)
        Me.cmbStateName.TabIndex = 3
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(3, 105)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(458, 20)
        Me.txtCity.TabIndex = 2
        Me.txtCity.Visible = False
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(4, 38)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(458, 61)
        Me.txtAddress.TabIndex = 1
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(4, 12)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(458, 20)
        Me.txtSupplierName.TabIndex = 0
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 432)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSupplier"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Supplier"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbStateName As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPinCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCSTNo As System.Windows.Forms.TextBox
    Friend WithEvents txtGSTNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents lblSupplierId As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class

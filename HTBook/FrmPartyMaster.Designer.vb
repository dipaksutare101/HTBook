<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPartyMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPartyName = New System.Windows.Forms.Label()
        Me.lblPartyType = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.lblTelephoneNo = New System.Windows.Forms.Label()
        Me.txtPartyName = New HTBook.MyTextBox(Me.components)
        Me.txtAddress = New HTBook.MyTextBox(Me.components)
        Me.txtCity = New HTBook.MyTextBox(Me.components)
        Me.txtMobileNo = New HTBook.MyTextBox(Me.components)
        Me.txtTelepnoneNo = New HTBook.MyTextBox(Me.components)
        Me.lblCSTNo = New System.Windows.Forms.Label()
        Me.lblGstNo = New System.Windows.Forms.Label()
        Me.txtCTS = New HTBook.MyTextBox(Me.components)
        Me.txtGST = New HTBook.MyTextBox(Me.components)
        Me.cboPartyType = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 3)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(458, 383)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblPartyName, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPartyType, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAddress, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCity, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblMobileNo, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTelephoneNo, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPartyName, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAddress, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCity, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMobileNo, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.txtTelepnoneNo, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCSTNo, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.lblGstNo, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCTS, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.txtGST, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.cboPartyType, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 11
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(452, 332)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lblPartyName
        '
        Me.lblPartyName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPartyName.AutoSize = True
        Me.lblPartyName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartyName.Location = New System.Drawing.Point(3, 7)
        Me.lblPartyName.Name = "lblPartyName"
        Me.lblPartyName.Size = New System.Drawing.Size(95, 16)
        Me.lblPartyName.TabIndex = 0
        Me.lblPartyName.Text = "Party Name :"
        '
        'lblPartyType
        '
        Me.lblPartyType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPartyType.AutoSize = True
        Me.lblPartyType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartyType.Location = New System.Drawing.Point(3, 38)
        Me.lblPartyType.Name = "lblPartyType"
        Me.lblPartyType.Size = New System.Drawing.Size(91, 16)
        Me.lblPartyType.TabIndex = 0
        Me.lblPartyType.Text = "Party Type :"
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(3, 69)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(71, 16)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Address :"
        '
        'lblCity
        '
        Me.lblCity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(3, 162)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(45, 16)
        Me.lblCity.TabIndex = 0
        Me.lblCity.Text = "City :"
        '
        'lblMobileNo
        '
        Me.lblMobileNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMobileNo.AutoSize = True
        Me.lblMobileNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileNo.Location = New System.Drawing.Point(3, 193)
        Me.lblMobileNo.Name = "lblMobileNo"
        Me.lblMobileNo.Size = New System.Drawing.Size(87, 16)
        Me.lblMobileNo.TabIndex = 0
        Me.lblMobileNo.Text = "Mobile No. :"
        '
        'lblTelephoneNo
        '
        Me.lblTelephoneNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTelephoneNo.AutoSize = True
        Me.lblTelephoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephoneNo.Location = New System.Drawing.Point(3, 224)
        Me.lblTelephoneNo.Name = "lblTelephoneNo"
        Me.lblTelephoneNo.Size = New System.Drawing.Size(113, 16)
        Me.lblTelephoneNo.TabIndex = 0
        Me.lblTelephoneNo.Text = "Telephone No. :"
        '
        'txtPartyName
        '
        Me.txtPartyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPartyName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartyName.Location = New System.Drawing.Point(122, 3)
        Me.txtPartyName.Name = "txtPartyName"
        Me.txtPartyName.Size = New System.Drawing.Size(317, 23)
        Me.txtPartyName.TabIndex = 0
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(122, 65)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.TableLayoutPanel2.SetRowSpan(Me.txtAddress, 3)
        Me.txtAddress.Size = New System.Drawing.Size(317, 87)
        Me.txtAddress.TabIndex = 2
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCity.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(122, 158)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(317, 23)
        Me.txtCity.TabIndex = 3
        '
        'txtMobileNo
        '
        Me.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMobileNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.Location = New System.Drawing.Point(122, 189)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(317, 23)
        Me.txtMobileNo.TabIndex = 4
        '
        'txtTelepnoneNo
        '
        Me.txtTelepnoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelepnoneNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTelepnoneNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelepnoneNo.Location = New System.Drawing.Point(122, 220)
        Me.txtTelepnoneNo.Name = "txtTelepnoneNo"
        Me.txtTelepnoneNo.Size = New System.Drawing.Size(317, 23)
        Me.txtTelepnoneNo.TabIndex = 5
        '
        'lblCSTNo
        '
        Me.lblCSTNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCSTNo.AutoSize = True
        Me.lblCSTNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCSTNo.Location = New System.Drawing.Point(3, 255)
        Me.lblCSTNo.Name = "lblCSTNo"
        Me.lblCSTNo.Size = New System.Drawing.Size(73, 16)
        Me.lblCSTNo.TabIndex = 0
        Me.lblCSTNo.Text = "CST No. :"
        '
        'lblGstNo
        '
        Me.lblGstNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblGstNo.AutoSize = True
        Me.lblGstNo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGstNo.Location = New System.Drawing.Point(3, 286)
        Me.lblGstNo.Name = "lblGstNo"
        Me.lblGstNo.Size = New System.Drawing.Size(73, 16)
        Me.lblGstNo.TabIndex = 0
        Me.lblGstNo.Text = "GST No. :"
        '
        'txtCTS
        '
        Me.txtCTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCTS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCTS.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTS.Location = New System.Drawing.Point(122, 251)
        Me.txtCTS.Name = "txtCTS"
        Me.txtCTS.Size = New System.Drawing.Size(317, 23)
        Me.txtCTS.TabIndex = 6
        '
        'txtGST
        '
        Me.txtGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGST.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGST.Location = New System.Drawing.Point(122, 282)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(317, 23)
        Me.txtGST.TabIndex = 7
        '
        'cboPartyType
        '
        Me.cboPartyType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboPartyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartyType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPartyType.FormattingEnabled = True
        Me.cboPartyType.Items.AddRange(New Object() {"Customer", "Supplier"})
        Me.cboPartyType.Location = New System.Drawing.Point(122, 34)
        Me.cboPartyType.Name = "cboPartyType"
        Me.cboPartyType.Size = New System.Drawing.Size(317, 24)
        Me.cboPartyType.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnExit)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnView)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnNew)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 341)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(452, 39)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'BtnExit
        '
        Me.BtnExit.AutoSize = True
        Me.BtnExit.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(374, 3)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 32)
        Me.BtnExit.TabIndex = 11
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(293, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 32)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.AutoSize = True
        Me.BtnSave.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(212, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 32)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnView
        '
        Me.BtnView.AutoSize = True
        Me.BtnView.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnView.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.Location = New System.Drawing.Point(131, 3)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 32)
        Me.BtnView.TabIndex = 9
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.AutoSize = True
        Me.BtnNew.BackColor = System.Drawing.Color.LemonChiffon
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.Location = New System.Drawing.Point(50, 3)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(75, 32)
        Me.BtnNew.TabIndex = 10
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'FrmPartyMaster
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(458, 383)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "FrmPartyMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Party Master"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnView As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblPartyName As Label
    Friend WithEvents lblPartyType As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblMobileNo As Label
    Friend WithEvents lblTelephoneNo As Label
    Friend WithEvents lblCSTNo As Label
    Friend WithEvents lblGstNo As Label
    Friend WithEvents txtPartyName As MyTextBox
    Friend WithEvents txtAddress As MyTextBox
    Friend WithEvents txtCity As MyTextBox
    Friend WithEvents txtMobileNo As MyTextBox
    Friend WithEvents txtTelepnoneNo As MyTextBox
    Friend WithEvents txtCTS As MyTextBox
    Friend WithEvents txtGST As MyTextBox
    Friend WithEvents cboPartyType As System.Windows.Forms.ComboBox
End Class

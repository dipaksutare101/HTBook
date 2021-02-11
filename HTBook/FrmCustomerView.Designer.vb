<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerView
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSearchText = New HTBook.WatermarkTextbox(Me.components)
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 351)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvCustomers)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(729, 309)
        Me.Panel3.TabIndex = 1
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
        Me.dgvCustomers.Size = New System.Drawing.Size(729, 309)
        Me.dgvCustomers.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAddCustomer)
        Me.Panel2.Controls.Add(Me.txtSearchText)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(729, 42)
        Me.Panel2.TabIndex = 0
        '
        'txtSearchText
        '
        Me.txtSearchText.Location = New System.Drawing.Point(7, 11)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(312, 20)
        Me.txtSearchText.TabIndex = 0
        Me.txtSearchText.WatermarkText = "Enter search text here..."
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(611, 9)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(106, 23)
        Me.btnAddCustomer.TabIndex = 2
        Me.btnAddCustomer.Text = "Add New Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'FrmCustomerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 351)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCustomerView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer Selection"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtSearchText As HTBook.WatermarkTextbox
    Friend WithEvents dgvCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddCustomer As System.Windows.Forms.Button
End Class

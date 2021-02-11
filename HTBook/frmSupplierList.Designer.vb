<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSupplierList
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvSuppliers = New System.Windows.Forms.DataGridView()
        Me.txtSearchText = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.pnlHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(985, 450)
        Me.Panel1.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.txtSearchText)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(985, 45)
        Me.pnlHeader.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvSuppliers)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(985, 405)
        Me.Panel3.TabIndex = 1
        '
        'dgvSuppliers
        '
        Me.dgvSuppliers.AllowUserToAddRows = False
        Me.dgvSuppliers.AllowUserToDeleteRows = False
        Me.dgvSuppliers.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSuppliers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSuppliers.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvSuppliers.Location = New System.Drawing.Point(0, 0)
        Me.dgvSuppliers.Name = "dgvSuppliers"
        Me.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSuppliers.Size = New System.Drawing.Size(985, 405)
        Me.dgvSuppliers.TabIndex = 1
        '
        'txtSearchText
        '
        Me.txtSearchText.Location = New System.Drawing.Point(3, 10)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(979, 20)
        Me.txtSearchText.TabIndex = 0
        '
        'frmSupplierList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSupplierList"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Supplier List"
        Me.Panel1.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvSuppliers As DataGridView
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents txtSearchText As TextBox
End Class

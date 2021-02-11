<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManufaturers
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgvMfgs = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtSearchText = New HTBook.WatermarkTextbox(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtMfgName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMfgId = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvMfgs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(659, 451)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(659, 384)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgvMfgs)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 20)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(659, 364)
        Me.Panel5.TabIndex = 1
        '
        'dgvMfgs
        '
        Me.dgvMfgs.AllowUserToAddRows = False
        Me.dgvMfgs.AllowUserToDeleteRows = False
        Me.dgvMfgs.AllowUserToOrderColumns = True
        Me.dgvMfgs.AllowUserToResizeColumns = False
        Me.dgvMfgs.AllowUserToResizeRows = False
        Me.dgvMfgs.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvMfgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMfgs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMfgs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMfgs.Location = New System.Drawing.Point(0, 0)
        Me.dgvMfgs.Name = "dgvMfgs"
        Me.dgvMfgs.RowHeadersWidth = 20
        Me.dgvMfgs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMfgs.Size = New System.Drawing.Size(659, 364)
        Me.dgvMfgs.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtSearchText)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(659, 20)
        Me.Panel4.TabIndex = 0
        '
        'txtSearchText
        '
        Me.txtSearchText.Location = New System.Drawing.Point(1, 0)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(656, 20)
        Me.txtSearchText.TabIndex = 2
        Me.txtSearchText.WatermarkText = "Enter Search text here"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.txtMfgName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblMfgId)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(659, 67)
        Me.Panel2.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(521, 17)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(440, 17)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtMfgName
        '
        Me.txtMfgName.Location = New System.Drawing.Point(100, 19)
        Me.txtMfgName.Name = "txtMfgName"
        Me.txtMfgName.Size = New System.Drawing.Size(315, 20)
        Me.txtMfgName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manufacturer :"
        '
        'lblMfgId
        '
        Me.lblMfgId.AutoSize = True
        Me.lblMfgId.Location = New System.Drawing.Point(3, 9)
        Me.lblMfgId.Name = "lblMfgId"
        Me.lblMfgId.Size = New System.Drawing.Size(16, 13)
        Me.lblMfgId.TabIndex = 0
        Me.lblMfgId.Text = "Id"
        Me.lblMfgId.Visible = False
        '
        'frmManufaturers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 451)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "frmManufaturers"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manufaturers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvMfgs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgvMfgs As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtSearchText As WatermarkTextbox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtMfgName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMfgId As Label
End Class

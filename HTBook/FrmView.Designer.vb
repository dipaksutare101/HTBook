<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmView
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmdPartyName = New System.Windows.Forms.ComboBox()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.MyDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pnlHead.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        CType(Me.MyDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Party :"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(766, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(142, 45)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cmdPartyName
        '
        Me.cmdPartyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmdPartyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmdPartyName.FormattingEnabled = True
        Me.cmdPartyName.Location = New System.Drawing.Point(105, 12)
        Me.cmdPartyName.Name = "cmdPartyName"
        Me.cmdPartyName.Size = New System.Drawing.Size(193, 21)
        Me.cmdPartyName.TabIndex = 5
        '
        'dtpToDate
        '
        Me.dtpToDate.Checked = False
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(325, 39)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.ShowCheckBox = True
        Me.dtpToDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpToDate.TabIndex = 4
        Me.dtpToDate.Value = New Date(2017, 5, 23, 0, 0, 0, 0)
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Checked = False
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(105, 39)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.ShowCheckBox = True
        Me.dtpFromDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpFromDate.TabIndex = 3
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToDate.Location = New System.Drawing.Point(250, 45)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(69, 13)
        Me.lblToDate.TabIndex = 2
        Me.lblToDate.Text = "To Date : "
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromDate.Location = New System.Drawing.Point(12, 45)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(87, 13)
        Me.lblFromDate.TabIndex = 1
        Me.lblFromDate.Text = "From Date : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(531, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'pnlHead
        '
        Me.pnlHead.Controls.Add(Me.Label4)
        Me.pnlHead.Controls.Add(Me.lblToDate)
        Me.pnlHead.Controls.Add(Me.lblFromDate)
        Me.pnlHead.Controls.Add(Me.btnSearch)
        Me.pnlHead.Controls.Add(Me.dtpFromDate)
        Me.pnlHead.Controls.Add(Me.Label1)
        Me.pnlHead.Controls.Add(Me.cmdPartyName)
        Me.pnlHead.Controls.Add(Me.dtpToDate)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.Location = New System.Drawing.Point(0, 0)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(920, 89)
        Me.pnlHead.TabIndex = 1
        '
        'pnlDetails
        '
        Me.pnlDetails.Controls.Add(Me.MyDataGridView1)
        Me.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetails.Location = New System.Drawing.Point(0, 89)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(920, 393)
        Me.pnlDetails.TabIndex = 2
        '
        'MyDataGridView1
        '
        Me.MyDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MyDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MyDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView1.Name = "MyDataGridView1"
        Me.MyDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView1.Size = New System.Drawing.Size(920, 393)
        Me.MyDataGridView1.TabIndex = 1
        '
        'FrmView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(920, 482)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.pnlHead)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHead.ResumeLayout(False)
        Me.pnlHead.PerformLayout()
        Me.pnlDetails.ResumeLayout(False)
        CType(Me.MyDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFromDate As Label
    Friend WithEvents dtpToDate As DateTimePicker
    Friend WithEvents dtpFromDate As DateTimePicker
    Friend WithEvents lblToDate As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmdPartyName As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlHead As Panel
    Friend WithEvents pnlDetails As Panel
    Friend WithEvents MyDataGridView1 As DataGridView
End Class

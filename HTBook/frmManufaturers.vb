Public Class frmManufaturers
    Dim Kailash As New DataAccessLayer
    Private ManufID As Integer

    Private Sub frmManufaturers_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        ElseIf e.KeyCode = Keys.Escape Then
            Dim result As Integer = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Close()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmManufaturers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMfgId.Text = ""
        BindMfgs("")
        txtSearchText.Focus()
    End Sub

    Private Sub txtMfgName_Enter(sender As Object, e As EventArgs) Handles txtMfgName.Enter
        Dim position As Integer = txtMfgName.Text.Length
        txtMfgName.Select(position, position)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtMfgName.Text = "" Then
            MessageBox.Show("Please Enter Manufacturer Name.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMfgName.Focus()
            Exit Sub
        End If
        Dim mfgString As String = "spManufacturers_Create"
        Kailash.AddParameter("@ManufID", Val(lblMfgId.Text.ToString()))
        Kailash.AddParameter("@ManufName", txtMfgName.Text.ToString())

        Try
            Dim dtResult = Kailash.ExecuteDatatable(mfgString, Kailash.ParameterList)
            If dtResult.Rows.Count > 0 Then
                Dim IsSuccessful As Boolean = Convert.ToBoolean(dtResult.Rows(0).Item("IsSuccessful"))
                Dim responseMessage As String = Convert.ToString(dtResult.Rows(0).Item("Message").ToString())
                If IsSuccessful = False Then
                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtMfgName.Focus()
                    Exit Sub
                Else
                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblMfgId.Text = ""
                    txtMfgName.Text = ""
                    BindMfgs("")
                    txtSearchText.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try
    End Sub

    Private Sub BindMfgs(ByVal searchText As String)
        Dim productString As String = "Select SrNo = ROW_NUMBER() OVER (ORDER BY ManufID), ManufID, ManufName From Manufacturers Where ManufName Like '%" & searchText & "%'"
        Dim dtMfgs As DataTable = Kailash.ExecuteDatatable(productString)
        dgvMfgs.DataSource = dtMfgs
        If Not dtMfgs Is Nothing And dtMfgs.Rows.Count > 0 Then
            dgvMfgs.DataSource = dtMfgs

            dgvMfgs.Columns("ManufID").Visible = False
            dgvMfgs.Columns("SrNo").HeaderText = "No"
            dgvMfgs.Columns("SrNo").Width = 60
            dgvMfgs.Columns("ManufName").Width = dgvMfgs.Width - dgvMfgs.Columns("ManufID").Width - 40
        End If
    End Sub

    Private Sub txtSearchText_TextChanged(sender As Object, e As EventArgs) Handles txtSearchText.TextChanged
        BindMfgs(txtSearchText.Text)
    End Sub

    Private Sub txtSearchText_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchText.KeyDown
        If e.KeyCode = Keys.Down Then
            If Not dgvMfgs.DataSource Is Nothing Then
                dgvMfgs.Focus()
            End If
        End If
    End Sub

    Private Sub dgvMfgs_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMfgs.CellMouseDoubleClick
        lblMfgId.Text = dgvMfgs.Rows(e.RowIndex).Cells("ManufID").Value
        txtMfgName.Text = dgvMfgs.Rows(e.RowIndex).Cells("ManufName").Value.ToString()
        txtMfgName.Focus()
    End Sub

    Private Sub dgvMfgs_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvMfgs.KeyDown
        Dim iRow = dgvMfgs.CurrentCell.RowIndex
        ManufID = dgvMfgs.Rows(iRow).Cells("ManufID").Value

        If e.KeyCode = Keys.F2 Then
            lblMfgId.Text = ManufID
            txtMfgName.Text = dgvMfgs.Rows(iRow).Cells("ManufName").Value
            txtMfgName.Focus()
        ElseIf e.KeyCode = Keys.Down Then
            If Not dgvMfgs.DataSource Is Nothing Then
                dgvMfgs.Focus()
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            If dgvMfgs.Rows.Count = 0 Then Exit Sub
            For Each row As DataGridViewRow In dgvMfgs.SelectedRows
                If (dgvMfgs.Rows.Count > 0) Then
                    If MsgBox("Are You Sure Want to Sure remove this Manufacturers?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
                        Dim brandString As String = "spManufacturers_Delete"
                        Kailash.AddParameter("@ManufID", Val(ManufID))
                        Try
                            Dim dtResult = Kailash.ExecuteDatatable(brandString, Kailash.ParameterList)
                            If dtResult.Rows.Count > 0 Then
                                Dim IsSuccessful As Boolean = Convert.ToBoolean(dtResult.Rows(0).Item("IsSuccessful"))
                                Dim responseMessage As String = Convert.ToString(dtResult.Rows(0).Item("Message").ToString())
                                If IsSuccessful = False Then
                                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                Else
                                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    BindMfgs("")
                                    txtSearchText.Focus()
                                End If
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message.ToString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End Try
                    End If
                End If
            Next
        End If
    End Sub
End Class
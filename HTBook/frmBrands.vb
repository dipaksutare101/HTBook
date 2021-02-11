Public Class frmBrands
    Dim Kailash As New DataAccessLayer
    Private BrandID As Integer

    Private Sub frmBrands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBrandId.Text = ""
        BindBrands("")
        txtSearchText.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtBrandName.Text = "" Then
            MessageBox.Show("Please Enter Brand Name.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBrandName.Focus()
            Exit Sub
        End If
        Dim brandString As String = "spBrands_Create"
        Kailash.AddParameter("@BrandID", Val(lblBrandId.Text.ToString()))
        Kailash.AddParameter("@BrandName", txtBrandName.Text.ToString())

        Try
            Dim dtResult = Kailash.ExecuteDatatable(brandString, Kailash.ParameterList)
            If dtResult.Rows.Count > 0 Then
                Dim IsSuccessful As Boolean = Convert.ToBoolean(dtResult.Rows(0).Item("IsSuccessful"))
                Dim responseMessage As String = Convert.ToString(dtResult.Rows(0).Item("Message").ToString())
                If IsSuccessful = False Then
                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtBrandName.Focus()
                    Exit Sub
                Else
                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblBrandId.Text = ""
                    txtBrandName.Text = ""
                    BindBrands("")
                    txtSearchText.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try
    End Sub

    Private Sub frmBrands_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub txtSearchText_TextChanged(sender As Object, e As EventArgs) Handles txtSearchText.TextChanged
        BindBrands(txtSearchText.Text)
    End Sub

    Private Sub BindBrands(ByVal searchText As String)
        Dim productString As String = "SELECT SrNo = ROW_NUMBER() OVER (ORDER BY BrandID), BrandID, BrandName FROM dbo.Brands Where BrandName Like '%" & searchText & "%'"
        Dim dtBrands As DataTable = Kailash.ExecuteDatatable(productString)
        dgvBrands.DataSource = dtBrands
        If Not dtBrands Is Nothing And dtBrands.Rows.Count > 0 Then
            dgvBrands.DataSource = dtBrands

            dgvBrands.Columns("BrandID").Visible = False
            dgvBrands.Columns("SrNo").HeaderText = "No"
            dgvBrands.Columns("SrNo").Width = 60
            dgvBrands.Columns("BrandName").Width = dgvBrands.Width - dgvBrands.Columns("BrandID").Width - 40
        End If
    End Sub

    Private Sub dgvBrands_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvBrands.KeyDown
        Dim iRow = dgvBrands.CurrentCell.RowIndex
        BrandID = dgvBrands.Rows(iRow).Cells("BrandID").Value

        If e.KeyCode = Keys.F2 Then
            lblBrandId.Text = BrandID
            txtBrandName.Text = dgvBrands.Rows(iRow).Cells("BrandName").Value
            txtBrandName.Focus()
        ElseIf e.KeyCode = Keys.Down Then
            If Not dgvBrands.DataSource Is Nothing Then
                dgvBrands.Focus()
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            If dgvBrands.Rows.Count = 0 Then Exit Sub
            For Each row As DataGridViewRow In dgvBrands.SelectedRows
                If (dgvBrands.Rows.Count > 0) Then
                    If MsgBox("Are You Sure Want to Sure remove this Brand?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
                        Dim brandString As String = "spBrands_Delete"
                        Kailash.AddParameter("@BrandID", Val(BrandID))
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
                                    BindBrands("")
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

    Private Sub txtBrandName_Enter(sender As Object, e As EventArgs) Handles txtBrandName.Enter
        Dim position As Integer = txtBrandName.Text.Length
        txtBrandName.Select(position, position)
    End Sub

    Private Sub txtSearchText_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchText.KeyDown
        If e.KeyCode = Keys.Down Then
            If Not dgvBrands.DataSource Is Nothing Then
                dgvBrands.Focus()
            End If
        End If
    End Sub

    Private Sub dgvBrands_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBrands.CellMouseDoubleClick
        lblBrandId.Text = dgvBrands.Rows(e.RowIndex).Cells("BrandID").Value
        txtBrandName.Text = dgvBrands.Rows(e.RowIndex).Cells("BrandName").Value.ToString()
        txtBrandName.Focus()
    End Sub
End Class
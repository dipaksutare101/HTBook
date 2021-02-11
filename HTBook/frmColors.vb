Public Class frmColors

    Dim Kailash As New DataAccessLayer
    Private ColorTypeID As Integer

    Private Sub frmColors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblColorId.Text = ""
        BindColors("")
        txtSearchText.Focus()
    End Sub

    Private Sub BindColors(ByVal searchText As String)
        Dim productString As String = "Select SrNo = ROW_NUMBER() OVER (ORDER BY ColorTypeID), ColorTypeID, ColorTypeName From ColorTypes Where ColorTypeName Like '%" & searchText & "%'"
        Dim dtProducts As DataTable = Kailash.ExecuteDatatable(productString)
        dgvColors.DataSource = dtProducts
        If Not dtProducts Is Nothing And dtProducts.Rows.Count > 0 Then
            dgvColors.DataSource = dtProducts

            dgvColors.Columns("ColorTypeID").Visible = False
            dgvColors.Columns("SrNo").HeaderText = "No"
            dgvColors.Columns("SrNo").Width = 60
            dgvColors.Columns("ColorTypeName").HeaderText = "Color Type"
            dgvColors.Columns("ColorTypeName").Width = dgvColors.Width - dgvColors.Columns("ColorTypeID").Width - 40
        End If
    End Sub

    Private Sub frmColors_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub txtColorName_Enter(sender As Object, e As EventArgs) Handles txtColorName.Enter
        Dim position As Integer = txtColorName.Text.Length
        txtColorName.Select(position, position)
    End Sub

    Private Sub txtSearchText_TextChanged(sender As Object, e As EventArgs) Handles txtSearchText.TextChanged
        BindColors(txtSearchText.Text)
    End Sub

    Private Sub txtSearchText_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchText.KeyDown
        If e.KeyCode = Keys.Down Then
            If Not dgvColors.DataSource Is Nothing Then
                dgvColors.Focus()
            End If
        End If
    End Sub

    Private Sub dgvColors_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvColors.KeyDown
        Dim iRow = dgvColors.CurrentCell.RowIndex
        ColorTypeID = dgvColors.Rows(iRow).Cells("ColorTypeID").Value

        If e.KeyCode = Keys.F2 Then
            lblColorId.Text = ColorTypeID
            txtColorName.Text = dgvColors.Rows(iRow).Cells("ColorTypeName").Value
            txtColorName.Focus()
        ElseIf e.KeyCode = Keys.Down Then
            If Not dgvColors.DataSource Is Nothing Then
                dgvColors.Focus()
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            If dgvColors.Rows.Count = 0 Then Exit Sub
            For Each row As DataGridViewRow In dgvColors.SelectedRows
                If (dgvColors.Rows.Count > 0) Then
                    If MsgBox("Are You Sure Want to Sure remove this Color type?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
                        Dim brandString As String = "spColorTypes_Delete"
                        Kailash.AddParameter("@ColorTypeID", Val(ColorTypeID))
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
                                    BindColors("")
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

    Private Sub dgvColors_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvColors.CellMouseDoubleClick
        lblColorId.Text = dgvColors.Rows(e.RowIndex).Cells("ColorTypeID").Value
        txtColorName.Text = dgvColors.Rows(e.RowIndex).Cells("ColorTypeName").Value.ToString()
        txtColorName.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtColorName.Text = "" Then
            MessageBox.Show("Please Enter Color Type Name.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtColorName.Focus()
            Exit Sub
        End If
        Dim brandString As String = "spColorTypes_Create"
        Kailash.AddParameter("@ColorTypeID", Val(lblColorId.Text.ToString()))
        Kailash.AddParameter("@ColorTypeName", txtColorName.Text.ToString())

        Try
            Dim dtResult = Kailash.ExecuteDatatable(brandString, Kailash.ParameterList)
            If dtResult.Rows.Count > 0 Then
                Dim IsSuccessful As Boolean = Convert.ToBoolean(dtResult.Rows(0).Item("IsSuccessful"))
                Dim responseMessage As String = Convert.ToString(dtResult.Rows(0).Item("Message").ToString())
                If IsSuccessful = False Then
                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtColorName.Focus()
                    Exit Sub
                Else
                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblColorId.Text = ""
                    txtColorName.Text = ""
                    BindColors("")
                    txtSearchText.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try
    End Sub
End Class
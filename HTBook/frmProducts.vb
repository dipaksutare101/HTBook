Public Class frmProducts

    Dim Kailash As New DataAccessLayer
    Private ProductTypeID As Integer

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblProductId.Text = ""
        BindProducts("")
        txtSearchText.Focus()
    End Sub

    Private Sub BindProducts(ByVal searchText As String)
        Dim productString As String = "Select SrNo = ROW_NUMBER() OVER (ORDER BY ProductTypeID), ProductTypeID, ProductTypeName From ProductTypes Where ProductTypeName Like '%" & searchText & "%'"
        Dim dtProducts As DataTable = Kailash.ExecuteDatatable(productString)
        dgvProducts.DataSource = dtProducts
        If Not dtProducts Is Nothing And dtProducts.Rows.Count > 0 Then
            dgvProducts.DataSource = dtProducts

            dgvProducts.Columns("ProductTypeID").Visible = False
            dgvProducts.Columns("SrNo").HeaderText = "No"
            dgvProducts.Columns("SrNo").Width = 60
            dgvProducts.Columns("ProductTypeName").Width = dgvProducts.Width - dgvProducts.Columns("ProductTypeID").Width - 40
        End If
    End Sub

    Private Sub frmProducts_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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
        BindProducts(txtSearchText.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtProductName.Text = "" Then
            MessageBox.Show("Please Enter Product Name.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductName.Focus()
            Exit Sub
        End If
        Dim brandString As String = "spProductTypes_Create"
        Kailash.AddParameter("@ProductTypeID", Val(lblProductId.Text.ToString()))
        Kailash.AddParameter("@ProductTypeName", txtProductName.Text.ToString())

        Try
            Dim dtResult = Kailash.ExecuteDatatable(brandString, Kailash.ParameterList)
            If dtResult.Rows.Count > 0 Then
                Dim IsSuccessful As Boolean = Convert.ToBoolean(dtResult.Rows(0).Item("IsSuccessful"))
                Dim responseMessage As String = Convert.ToString(dtResult.Rows(0).Item("Message").ToString())
                If IsSuccessful = False Then
                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtProductName.Focus()
                    Exit Sub
                Else
                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblProductId.Text = ""
                    txtProductName.Text = ""
                    BindProducts("")
                    txtSearchText.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try
    End Sub

    Private Sub dgvProducts_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProducts.KeyDown
        Dim iRow = dgvProducts.CurrentCell.RowIndex
        ProductTypeID = dgvProducts.Rows(iRow).Cells("ProductTypeID").Value

        If e.KeyCode = Keys.F2 Then
            lblProductId.Text = ProductTypeID
            txtProductName.Text = dgvProducts.Rows(iRow).Cells("ProductTypeName").Value
            txtProductName.Focus()
        ElseIf e.KeyCode = Keys.Down Then
            If Not dgvProducts.DataSource Is Nothing Then
                dgvProducts.Focus()
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            If dgvProducts.Rows.Count = 0 Then Exit Sub
            For Each row As DataGridViewRow In dgvProducts.SelectedRows
                If (dgvProducts.Rows.Count > 0) Then
                    If MsgBox("Are You Sure Want to Sure remove this Product?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
                        Dim brandString As String = "spProductTypes_Delete"
                        Kailash.AddParameter("@ProductTypeID", Val(ProductTypeID))
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
                                    BindProducts("")
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

    Private Sub dgvProducts_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProducts.CellMouseDoubleClick
        lblProductId.Text = dgvProducts.Rows(e.RowIndex).Cells("ProductTypeID").Value
        txtProductName.Text = dgvProducts.Rows(e.RowIndex).Cells("ProductTypeName").Value.ToString()
        txtProductName.Focus()
    End Sub

    Private Sub txtProductName_Enter(sender As Object, e As EventArgs) Handles txtProductName.Enter
        Dim position As Integer = txtProductName.Text.Length
        txtProductName.Select(position, position)
    End Sub

    Private Sub txtSearchText_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchText.KeyDown
        If e.KeyCode = Keys.Down Then
            If Not dgvProducts.DataSource Is Nothing Then
                dgvProducts.Focus()
            End If
        End If
    End Sub
End Class
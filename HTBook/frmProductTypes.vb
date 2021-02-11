Public Class frmProductTypes

    Dim Kailash As New DataAccessLayer
    Private ProductTypeID As Integer

    Private Sub frmProductTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblProductTypeId.Text = ""
        BindProducts("")
        txtSearchText.Focus()
    End Sub

    Private Sub BindProducts(ByVal searchText As String)
        Dim productString As String = "Select SrNo = ROW_NUMBER() OVER (ORDER BY ProductSubTypeID), ProductSubTypeID, ProductSubTypeName From ProductSubTypes Where ProductSubTypeName Like '%" & searchText & "%'"
        Dim dtProducts As DataTable = Kailash.ExecuteDatatable(productString)
        dgvProducts.DataSource = dtProducts
        If Not dtProducts Is Nothing And dtProducts.Rows.Count > 0 Then
            dgvProducts.DataSource = dtProducts

            dgvProducts.Columns("ProductSubTypeID").Visible = False
            dgvProducts.Columns("SrNo").HeaderText = "No"
            dgvProducts.Columns("SrNo").Width = 60
            dgvProducts.Columns("ProductSubTypeName").Width = dgvProducts.Width - dgvProducts.Columns("ProductSubTypeID").Width - 40
        End If
    End Sub

    Private Sub frmProductTypes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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
        If txtProductTypeName.Text = "" Then
            MessageBox.Show("Please Enter Product Type Name.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductTypeName.Focus()
            Exit Sub
        End If
        Dim brandString As String = "spProductSubTypes_Create"
        Kailash.AddParameter("@ProductSubTypeID", Val(lblProductTypeId.Text.ToString()))
        Kailash.AddParameter("@ProductSubTypeName", txtProductTypeName.Text.ToString())

        Try
            Dim dtResult = Kailash.ExecuteDatatable(brandString, Kailash.ParameterList)
            If dtResult.Rows.Count > 0 Then
                Dim IsSuccessful As Boolean = Convert.ToBoolean(dtResult.Rows(0).Item("IsSuccessful"))
                Dim responseMessage As String = Convert.ToString(dtResult.Rows(0).Item("Message").ToString())
                If IsSuccessful = False Then
                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtProductTypeName.Focus()
                    Exit Sub
                Else
                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblProductTypeId.Text = ""
                    txtProductTypeName.Text = ""
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
        ProductTypeID = dgvProducts.Rows(iRow).Cells("ProductSubTypeID").Value

        If e.KeyCode = Keys.F2 Then
            lblProductTypeId.Text = ProductTypeID
            txtProductTypeName.Text = dgvProducts.Rows(iRow).Cells("ProductSubTypeName").Value
            txtProductTypeName.Focus()
        ElseIf e.KeyCode = Keys.Down Then
            If Not dgvProducts.DataSource Is Nothing Then
                dgvProducts.Focus()
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            If dgvProducts.Rows.Count = 0 Then Exit Sub
            For Each row As DataGridViewRow In dgvProducts.SelectedRows
                If (dgvProducts.Rows.Count > 0) Then
                    If MsgBox("Are You Sure Want to Sure remove this Product Type?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
                        Dim brandString As String = "spProductSubTypes_Delete"
                        Kailash.AddParameter("@ProductSubTypeID", Val(ProductTypeID))
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
        lblProductTypeId.Text = dgvProducts.Rows(e.RowIndex).Cells("ProductSubTypeID").Value
        txtProductTypeName.Text = dgvProducts.Rows(e.RowIndex).Cells("ProductSubTypeName").Value.ToString()
        txtProductTypeName.Focus()
    End Sub

    Private Sub txtProductTypeName_Enter(sender As Object, e As EventArgs) Handles txtProductTypeName.Enter
        Dim position As Integer = txtProductTypeName.Text.Length
        txtProductTypeName.Select(position, position)
    End Sub

    Private Sub txtSearchText_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchText.KeyDown
        If e.KeyCode = Keys.Down Then
            If Not dgvProducts.DataSource Is Nothing Then
                dgvProducts.Focus()
            End If
        End If
    End Sub
End Class
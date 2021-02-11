Public Class frmManufSelectionModel

    Dim Kailash As New DataAccessLayer

    Private Sub frmManufSelectionModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearchText.Text = ""
        BindData("")
        txtSearchText.Focus()
    End Sub

    Public Sub BindData(ByVal searchText As String)
        Dim dataString As String = ""
        If RequestModel = "Manufacturers" Then
            dataString = "Select SrNo = ROW_NUMBER() OVER (ORDER BY ManufID), ManufID As colID, ManufName As colName From Manufacturers Where ManufName Like '%" & searchText & "%'"
        ElseIf RequestModel = "Brands" Then
            dataString = "Select SrNo = ROW_NUMBER() OVER (ORDER BY BrandID), BrandID As colID, BrandName As colName From Brands Where BrandName Like '%" & searchText & "%'"
        ElseIf RequestModel = "ProductTypes" Then
            dataString = "Select SrNo = ROW_NUMBER() OVER (ORDER BY ProductTypeID), ProductTypeID As colID, ProductTypeName As colName From ProductTypes Where ProductTypeName Like '%" & searchText & "%'"
        ElseIf RequestModel = "ProductSubTypes" Then
            dataString = "Select SrNo = ROW_NUMBER() OVER (ORDER BY ProductSubTypeID), ProductSubTypeID As colID, ProductSubTypeName As colName From ProductSubTypes Where ProductSubTypeName Like '%" & searchText & "%'"
        ElseIf RequestModel = "ColorTypes" Then
            dataString = "Select SrNo = ROW_NUMBER() OVER (ORDER BY ColorTypeID), ColorTypeID As colID, ColorTypeName As colName From ColorTypes Where ColorTypeName Like '%" & searchText & "%'"
        ElseIf RequestModel = "Taxes" Then
            dataString = "Select SrNo = ROW_NUMBER() OVER (ORDER BY TaxID), TaxID As colID, TaxName As colName From Taxes Where TaxName Like '%" & searchText & "%'"
        End If

        Dim dtResult As DataTable = Kailash.ExecuteDatatable(dataString)
        dgvData.DataSource = dtResult
        If Not dtResult Is Nothing And dtResult.Rows.Count > 0 Then
            dgvData.DataSource = dtResult

            dgvData.Columns("colID").Visible = False
            dgvData.Columns("SrNo").HeaderText = "No"
            dgvData.Columns("SrNo").Width = 60
            dgvData.Columns("colName").HeaderText = RequestModel.Replace("s", "")
            If RequestModel = "Taxes" Then
                dgvData.Columns("colName").HeaderText = RequestModel.Replace("es", "")
            End If
            dgvData.Columns("colName").Width = dgvData.Width - dgvData.Columns("colID").Width - 40
        End If
    End Sub

    Private Sub frmManufSelectionModel_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim result As Integer = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                SelectedValue = 0
                SelectedText = ""
                Close()
            End If
        End If
    End Sub

    Private Sub txtSearchText_TextChanged(sender As Object, e As EventArgs) Handles txtSearchText.TextChanged
        BindData(txtSearchText.Text)
    End Sub

    Private Sub txtSearchText_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchText.KeyDown
        If e.KeyCode = Keys.Down Then
            If Not dgvData.DataSource Is Nothing Then
                dgvData.Focus()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            SelectedValue = 0
            SelectedText = ""
            Close()
        End If
    End Sub

    Private Sub dgvData_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvData.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim iRowIndex As Integer
            For i As Integer = 0 To Me.dgvData.SelectedCells.Count - 1
                If i = 0 Then
                    iRowIndex = Me.dgvData.SelectedCells.Item(i).RowIndex
                    SelectedValue = Val(dgvData.Rows(iRowIndex).Cells("colID").Value)
                    SelectedText = dgvData.Rows(iRowIndex).Cells("colName").Value
                Else
                    Exit For
                End If
            Next
            Me.Close()
        End If
    End Sub
End Class
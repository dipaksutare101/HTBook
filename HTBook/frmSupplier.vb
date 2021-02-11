Public Class frmSupplier

    Dim Kailash As New DataAccessLayer

    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kailash.FillComboDataSource("Select StateCode, StateName From StateMaster", cmbStateName, String.Empty)
        cmbStateName.SelectedValue = 24
        If SupplierId > 0 Then
            Dim SqlString As String = "spSuppliers_Get " & Convert.ToString(SupplierId) & ", '', 1"
            Dim dtSupplier = Kailash.ExecuteDatatable(SqlString)
            If dtSupplier.Rows.Count > 0 Then

                lblSupplierId.Text = Convert.ToString(dtSupplier.Rows(0).Item("SupplierID").ToString())
                txtSupplierName.Text = Convert.ToString(dtSupplier.Rows(0).Item("SupplierName").ToString())
                txtAddress.Text = Convert.ToString(dtSupplier.Rows(0).Item("Address").ToString())
                cmbStateName.SelectedValue = Val(dtSupplier.Rows(0).Item("StateCode").ToString())
                txtGSTNo.Text = Convert.ToString(dtSupplier.Rows(0).Item("GSTNo").ToString())
                txtCSTNo.Text = Convert.ToString(dtSupplier.Rows(0).Item("CSTNo").ToString())
                txtMobileNo.Text = Convert.ToString(dtSupplier.Rows(0).Item("MobileNo").ToString())

            End If
        End If
        SupplierId = 0
        txtSupplierName.Focus()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        lblSupplierId.Text = "0"
        txtSupplierName.Text = ""
        txtAddress.Text = ""
        cmbStateName.SelectedValue = 24
        txtGSTNo.Text = ""
        txtCSTNo.Text = ""
        txtMobileNo.Text = ""
        txtSupplierName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtSupplierName.Text = "" Then
            MessageBox.Show("Supplier Name required.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSupplierName.Focus()
            Exit Sub
        End If
        If txtAddress.Text = "" Then
            MessageBox.Show("Supplier address required.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddress.Focus()
            Exit Sub
        End If
        If cmbStateName.SelectedIndex = 0 Or cmbStateName.Text = "" Then
            MessageBox.Show("Please Select State", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStateName.Focus()
            Exit Sub
        End If
        If txtGSTNo.Text = "" Then
            MessageBox.Show("Supplier GST No required.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtGSTNo.Focus()
            Exit Sub
        End If

        Dim supplierString As String = "spSuppliers_Create"
        Kailash.AddParameter("@SupplierID", Val(lblSupplierId.Text.ToString()))
        Kailash.AddParameter("@SupplierName", txtSupplierName.Text.ToString())
        Kailash.AddParameter("@Address", txtAddress.Text.ToString())
        Kailash.AddParameter("@StateCode", Val(cmbStateName.SelectedValue))
        Kailash.AddParameter("@GSTNo", txtGSTNo.Text.ToString())
        Kailash.AddParameter("@CSTNo", txtCSTNo.Text.ToString())
        Kailash.AddParameter("@MobileNo", txtMobileNo.Text.ToString())
        Kailash.AddParameter("@CompanyID", Val(1))

        Try
            Dim dtSupplier = Kailash.ExecuteDatatable(supplierString, Kailash.ParameterList)
            If dtSupplier.Rows.Count > 0 Then
                Dim IsSuccessful As Boolean = Convert.ToBoolean(dtSupplier.Rows(0).Item("IsSuccessful"))
                Dim responseMessage As String = Convert.ToString(dtSupplier.Rows(0).Item("Message").ToString())
                If IsSuccessful = False Then
                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    MessageBox.Show(responseMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnNew_Click(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim objFrm As New frmSupplierList
        objFrm.MdiParent = Frmmain
        objFrm.StartPosition = FormStartPosition.CenterScreen
        objFrm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmSupplier_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        ElseIf e.KeyCode = Keys.F2 Then
            Dim objFrm As New frmSupplierList
            objFrm.MdiParent = Frmmain
            objFrm.StartPosition = FormStartPosition.CenterScreen
            objFrm.Show()
        ElseIf e.KeyCode = Keys.Escape Then
            Dim result As Integer = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                SupplierId = 0
                Me.Close()
            End If
        End If
    End Sub
End Class
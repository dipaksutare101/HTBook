Public Class FrmView
    Public isQuatation As Boolean
    Dim Kailash As New DataAccessLayer


    Private Sub FrmView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SplitContainer1.SplitterDistance = 100
        MyDataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        dtpToDate.MaxDate = DateTime.Now
        If ViewType Is Nothing Then
            Me.Text = "View"
            pnlHead.Visible = False
            lblFromDate.Visible = False
            lblToDate.Visible = False
            dtpFromDate.Visible = False
            dtpToDate.Visible = False
        ElseIf ViewType.Equals("Party") Then
            Me.Text = "Party View"
            lblFromDate.Visible = False
            lblToDate.Visible = False
            dtpFromDate.Visible = False
            dtpToDate.Visible = False
            pnlHead.Visible = False
        ElseIf ViewType.Equals("Invoice") Then
            Me.Text = "Invoice View"
            pnlHead.Visible = True
            lblFromDate.Visible = True
            lblToDate.Visible = True
            dtpFromDate.Visible = True
            dtpToDate.Visible = True
        ElseIf ViewType.Equals("Quatation") Then
            Me.Text = "Quatation View"
            pnlHead.Visible = True
            lblFromDate.Visible = True
            lblToDate.Visible = True
            dtpFromDate.Visible = True
            dtpToDate.Visible = True
        End If
        Kailash.FillComboDataSource("select PartyId, PartyName from dbo.PartyMaster", cmdPartyName, String.Empty)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim _fromDate As String = "", _toDate As String = "", _partyId As Integer = 0
        If dtpFromDate.Checked Then
            _fromDate = dtpFromDate.Value.ToString("dd-MMM-yyyy")
        End If
        If dtpToDate.Checked Then
            _toDate = dtpToDate.Value.ToString("dd-MMM-yyyy")
        End If

        If cmdPartyName.Text IsNot Nothing Or cmdPartyName.Text <> "" Then
            _partyId = Val(cmdPartyName.SelectedValue)
        End If

        Dim SqlString As String = "View_Inward 1,0," & isQuatation & ",'" & _fromDate & "','" & _toDate & "'," & _partyId
        Dim MyDataTable As DataTable
        MyDataTable = Kailash.ExecuteDatatable(SqlString)
        Label1.Text = "List of Party Name"
        MyDataGridView1.DataSource = MyDataTable

        'Me.MyDataGridView1.Columns("Vat4").Visible = False
        'Me.MyDataGridView1.Columns("ATax1").Visible = False
        'Me.MyDataGridView1.Columns("Vat125").Visible = False
        'Me.MyDataGridView1.Columns("ATax25").Visible = False

        'Me.MyDataGridView1.Columns("TaxDisCount").Visible = False
        'Me.MyDataGridView1.Columns("LaboutPer").Visible = False
        'Me.MyDataGridView1.Columns("LabourDiscount").Visible = False
        'Me.MyDataGridView1.Columns("Remark").Visible = False

    End Sub

    Private Sub MyDataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MyDataGridView1.CellMouseDoubleClick
        MyDataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        FindId = Val(MyDataGridView1.Rows(e.RowIndex).Cells(0).Value)
        Me.Close()
    End Sub

    Private Sub dtpFromDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpFromDate.ValueChanged
        MyDataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        dtpToDate.MinDate = dtpFromDate.Value
    End Sub
End Class
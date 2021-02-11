Public Class FrmPartyMaster

    Dim Kailash As New DataAccessLayer
    Dim EntryId As Integer = 0
    Dim IsEdit As Boolean

    Private Sub FrmPartyMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BtnNew_Click(Nothing, Nothing)

    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click

        Kailash.ResetTextBox(Me)
        IsEdit = False
        EntryId = 0
        cboPartyType.SelectedIndex = -1
        txtPartyName.Focus()

    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        ViewType = "Party"
        Dim SqlString As String = "SELECT PartyId, PartyName, PartyType, [Address], City, MobileNo, TelephoneNo, CSTNo, GSTNo FROM dbo.PartyMaster"
        Dim MyDataTable As DataTable
        MyDataTable = Kailash.ExecuteDatatable(SqlString)
        FrmView.Label1.Text = "List of Party Name"
        FrmView.MyDataGridView1.DataSource = MyDataTable
        FrmView.ShowDialog(Frmmain)

        If FindId.Equals(0) Then
            BtnNew_Click(Nothing, Nothing)
        Else
            FillData()
        End If
    End Sub

    Private Sub FillData()
        Try
            Dim SqlString As String = "SELECT PartyId, PartyName, PartyType, [Address], City, MobileNo, TelephoneNo, CSTNo, GSTNo FROM dbo.PartyMaster WHERE PartyId = " & FindId
            Dim SqlConn = New SqlClient.SqlConnection(ConnString)
            SqlConn.Open()
            Dim SqlCmd As New SqlClient.SqlCommand(SqlString, SqlConn)
            Dim MyReader As SqlClient.SqlDataReader = SqlCmd.ExecuteReader()

            While MyReader.Read()

                EntryId = Val(MyReader("PartyId"))
                txtPartyName.Text = MyReader("PartyName").ToString()
                cboPartyType.Text = MyReader("PartyType").ToString()
                txtAddress.Text = MyReader("Address").ToString()
                txtCity.Text = MyReader("City").ToString()
                txtMobileNo.Text = MyReader("MobileNo").ToString()
                txtTelepnoneNo.Text = MyReader("TelephoneNo").ToString()
                txtCTS.Text = MyReader("CSTNo").ToString()
                txtGST.Text = MyReader("GSTNo").ToString()

            End While
            MyReader.Close()
            SqlConn.Close()
            IsEdit = True
            txtPartyName.Focus()
        Catch Ex As Exception
            MessageBox.Show(Ex.Message.ToString())
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If txtPartyName.Text.Equals(String.Empty) Then
            MessageBox.Show("Please Enter Party Name.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPartyName.Focus()
            Exit Sub
        End If

        Dim MySql As String = String.Empty

        If IsEdit = False Then
            MySql = "INSERT INTO dbo.PartyMaster (PartyName, PartyType, [Address], City, MobileNo, TelephoneNo, CSTNo, GSTNo) Values ('" & _
                txtPartyName.Text & "','" & _
                cboPartyType.Text & "','" & _
                txtAddress.Text & "','" & _
                txtCity.Text & "','" & _
                txtMobileNo.Text & "','" & _
                txtTelepnoneNo.Text & "','" & _
                txtCTS.Text & "','" & _
                txtGST.Text & "')"
        ElseIf IsEdit = True Then

            MySql = "UPDATE dbo.PartyMaster SET " &
                    "PartyName = '" & txtPartyName.Text & "'," &
                    "PartyType = '" & cboPartyType.Text & "'," &
                    "[Address] = '" & txtAddress.Text.Replace(ControlChars.Quote, String.Empty) & "'," &
                    "City = '" & txtCity.Text & "'," &
                    "MobileNo = '" & txtMobileNo.Text & "'," &
                    "TelephoneNo = '" & txtTelepnoneNo.Text & "'," &
                    "CSTNo = '" & txtCTS.Text & "'," &
                    "GSTNo = '" & txtGST.Text & "' Where PartyId = " & EntryId
        End If

        Kailash.ExecuteNonQuery(MySql)
        BtnNew_Click(Nothing, Nothing)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If EntryId = 0 Then
            Exit Sub
        Else
            If MsgBox("Are you Sure To Delete This Entry?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Party Master") = MsgBoxResult.Yes Then
                Dim MySql As String = String.Empty

                MySql = "Delete From dbo.PartyMaster Where  Partyid = " & EntryId
                Kailash.ExecuteNonQuery(MySql)
                MessageBox.Show("Entry Successfully Deleted")
                BtnNew_Click(Nothing, Nothing)
            End If
        End If

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub FrmPartyMaster_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
End Class
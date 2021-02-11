Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmTerms

    Dim Kailash As New DataAccessLayer
    Dim MAX_LINES As Integer = 7

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim MySql As String = String.Empty

        'MySql = "UPDATE dbo.PartyTermsCondition SET " &
        '        " " + IIf(IsLabour.Equals(False), "Terms", "LabourTerms") + " = '" & txtTermsCondition.Text & "'" &
        '        " Where PartyId = " & PartyId & " InwardId = " & InwardId

        'MySql = "If Exists ( Select * From PartyTermsCondition Where PartyId = " & PartyId & " And InwardId = " & InwardId & " )
        '         Begin
        '          UPDATE dbo.PartyTermsCondition SET " + IIf(IsLabour.Equals(False), "Terms", "LabourTerms") + " = '" & txtTermsCondition.Text & "' Where PartyId = " & PartyId & " And InwardId = " & InwardId & "
        '         End
        '        Else
        '         Begin
        '          Insert InTo dbo.PartyTermsCondition (PartyId, InwardId, " + IIf(IsLabour.Equals(False), "Terms", "LabourTerms") + ") Values (" & PartyId & ", " & InwardId & ", '" & txtTermsCondition.Text & "')
        '         End"
        Try
            MySql = "usp_InsertUpdate_PartyTermsCondition " & PartyId & "," & InwardId & "," & IIf(IsLabour.Equals(False), 0, 1) & ",'" & txtTermsCondition.Text & "' "
            Kailash.ExecuteNonQuery(MySql)
        Catch ex As Exception

        End Try

        TermsConditions = txtTermsCondition.Text
        'TermsConditions = TextBox1.Text & Environment.NewLine & TextBox2.Text & Environment.NewLine & TextBox3.Text & Environment.NewLine & TextBox4.Text & Environment.NewLine & TextBox5.Text & Environment.NewLine & TextBox6.Text & Environment.NewLine & TextBox7.Text & Environment.NewLine & TextBox8.Text
        'Me.Close()

        Dim RD As New ReportDocument
        Dim path As String = Application.StartupPath & "\TermsConditionPreview.rpt"
        RD.Load(path)

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinitionTerms As ParameterFieldDefinition
        Dim crParameterValuesTerms As New ParameterValues()
        Dim crParameterDiscreteValueTerms As New ParameterDiscreteValue()

        crParameterDiscreteValueTerms.Value = TermsConditions
        crParameterFieldDefinitions = RD.DataDefinition.ParameterFields
        crParameterFieldDefinitionTerms = crParameterFieldDefinitions("Terms")
        crParameterValuesTerms = crParameterFieldDefinitionTerms.CurrentValues
        crParameterValuesTerms.Clear()
        crParameterValuesTerms.Add(crParameterDiscreteValueTerms)
        crParameterFieldDefinitionTerms.ApplyCurrentValues(crParameterValuesTerms)

        Kailash.SetDBLogonForReport(RD)
        CrystalReportViewer1.ReportSource = RD
        CrystalReportViewer1.ShowRefreshButton = True
    End Sub

    Private Sub FrmTerms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildTermsConditionString()
    End Sub

    Public Sub BuildTermsConditionString()
        Try
            Dim path As String = IO.Path.Combine(Application.StartupPath, "TermsConditionConfig.ini")

            'Dim SqlString As String = "SELECT " + IIf(IsLabour.Equals(False), "Terms", "LabourTerms") + " FROM dbo.PartyTermsCondition Where PartyId = " & PartyId
            Dim SqlString As String = "SELECT Top 1 " + IIf(IsLabour.Equals(False), "Terms", "LabourTerms") + " FROM dbo.PartyTermsCondition Where PartyId = " & PartyId & " Order By ModifiedDate Desc"
            If InwardId > 0 Then
                SqlString = "SELECT Top 1 " + IIf(IsLabour.Equals(False), "Terms", "LabourTerms") + " FROM dbo.PartyTermsCondition Where PartyId = " & PartyId & " And InwardId = " & InwardId
            End If
            TermsConditions = Kailash.ExecuteScalar(SqlString)
            If TermsConditions = "" Or TermsConditions Is Nothing Then
                SqlString = "SELECT Top 1 " + IIf(IsLabour.Equals(False), "Terms", "LabourTerms") + " FROM dbo.PartyTermsCondition Where PartyId = " & PartyId & " Order By ModifiedDate Desc"
                TermsConditions = Kailash.ExecuteScalar(SqlString)
            End If

            txtTermsCondition.Text = TermsConditions
        Catch ex As Exception
            LogError(ex, "Build TermsConditionConfig String")
        End Try

    End Sub

    Public Sub LogError(ex As Exception, Optional CmdText As String = Nothing)
        Dim message As String = String.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
        message += Environment.NewLine
        message += "-----------------------------------------------------------"
        If Not CmdText Is Nothing Then
            message += Environment.NewLine
            message += String.Format("Command Text: {0}", CmdText.ToString())
        End If
        message += Environment.NewLine
        message += String.Format("Message: {0}", ex.Message)
        message += Environment.NewLine
        message += String.Format("StackTrace: {0}", ex.StackTrace)
        message += Environment.NewLine
        message += String.Format("Source: {0}", ex.Source)
        message += Environment.NewLine
        message += String.Format("TargetSite: {0}", ex.TargetSite.ToString())
        message += Environment.NewLine
        message += "-----------------------------------------------------------"
        message += Environment.NewLine

        Dim Path As String = Application.StartupPath & "\ErrorLog.txt"
        If IO.File.Exists(Path).Equals(False) Then
            IO.File.Create(Path).Close()

        End If

        Using writer As New IO.StreamWriter(Path, True)
            writer.WriteLine(message)
            writer.Close()
        End Using

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTermsCondition.TextChanged
        TextBox9.Text = txtTermsCondition.Text
    End Sub

    Private Sub txtTermsCondition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTermsCondition.KeyPress
        If txtTermsCondition.Lines.Length >= MAX_LINES And e.KeyChar = "\r" Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        InwardId = 0
        Me.Close()
    End Sub
End Class
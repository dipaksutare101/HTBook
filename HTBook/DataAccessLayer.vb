Imports System.Configuration
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class DataAccessLayer

    Public ParameterList As New List(Of SqlParameter)
    Public Sub BuildConnString()
        Try
            Dim path As String = IO.Path.Combine(Application.StartupPath, "ConnectionConfig.ini")
            Dim TermsConditionConfigPath As String = IO.Path.Combine(Application.StartupPath, "TermsConditionConfig.ini")
            'CS.Clear()
            '"ConnConfig.dat"
            '"ConnectionConfig.ini"

            Dim DBConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("dbConnection").ConnectionString)
            SaleBillPrefix = ConfigurationManager.AppSettings("SaleBillPrefix")

            Dim IsQuotationNewSetting As String = ConfigurationManager.AppSettings("IsQuotationNew")
            IsQuotationNew = Convert.ToBoolean(IsQuotationNewSetting)

            ConnString = DBConnection.ConnectionString.ToString()

            ServerName = DBConnection.DataSource.ToString()
            DataBase = DBConnection.Database.ToString()
            DbUser = "sa"
            dbPass = "smart@123"

            If IO.File.Exists(path) = False Then
                IO.File.Create(path)
            Else
                'Using sr As IO.StreamReader = New IO.StreamReader(path)
                '    ServerName = sr.ReadLine()
                '    DataBase = sr.ReadLine()
                '    DbUser = sr.ReadLine()
                '    dbPass = sr.ReadLine
                '    'ReportPath = sr.ReadLine()
                '    IsQuotationNew = Convert.ToBoolean(sr.ReadLine())
                '    IsStateValidationRequired = Convert.ToBoolean(sr.ReadLine())
                'End Using

                'Dim objReader As New StreamReader(path)
                'Do While objReader.Peek() <> -1
                ' ServerName = objReader.ReadLine()
                'DataBase = objReader.ReadLine()
                'DbUser = objReader.ReadLine()
                'dbPass = objReader.ReadLine()
                'Loop
                'objReader.Close()
            End If


            If IO.File.Exists(TermsConditionConfigPath) = False Then
                IO.File.Create(TermsConditionConfigPath)
            Else
                Using sr As IO.StreamReader = New IO.StreamReader(TermsConditionConfigPath)
                    TermsConditions += sr.ReadLine()
                    TermsConditions += Environment.NewLine + sr.ReadLine()
                    TermsConditions += Environment.NewLine + sr.ReadLine()
                    TermsConditions += Environment.NewLine + sr.ReadLine()
                    TermsConditions += Environment.NewLine + sr.ReadLine()
                    TermsConditions += Environment.NewLine + sr.ReadLine()
                    TermsConditions += Environment.NewLine + sr.ReadLine()
                    TermsConditions += Environment.NewLine + sr.ReadLine()
                End Using
            End If


            'If ServerName.Equals(String.Empty) Or DataBase.Equals(String.Empty) Or DbUser.Equals(String.Empty) Or dbPass.Equals(String.Empty) Then
            '    MessageBox.Show("Database Connection Not Established.", "Data Access Layer", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            'Else
            '    'ConnString = "Server=" & ServerName & ";Database=" & DataBase & ";User Id=" & DbUser & ";password=" & dbPass & ";"
            '    'ConnString = "Data Source=JAYESH-PC; Initial Catalog=ParekhDbNew; Integrated Security=True;"
            '    ConnString = DBConnection.ConnectionString.ToString()

            '    ServerName = DBConnection.DataSource.ToString()
            '    DataBase = DBConnection.Database.ToString()
            '    DbUser = DBConnection.Credential.UserId.ToString()
            '    dbPass = DBConnection.Credential.Password.ToString()

            'End If

        Catch ex As Exception
            LogError(ex, "Build Connection String")
        End Try

    End Sub

    Public Sub ResetTextBox(Root As Control)
        Try
            For Each MyCtl As Control In Root.Controls

                If TypeOf MyCtl Is MyTextBox Then
                    With CType(MyCtl, MyTextBox)
                        .Text = String.Empty
                        .Tag = String.Empty
                    End With
                End If

                If TypeOf MyCtl Is MyDateTime Then
                    With CType(MyCtl, MyDateTime)
                        .Value = CurrentDate()
                        .Tag = String.Empty
                    End With
                End If

                If TypeOf MyCtl Is CheckBox Then
                    With CType(MyCtl, CheckBox)
                        .Checked = False
                        .Tag = String.Empty
                    End With
                End If

                If TypeOf MyCtl Is Button Then
                    With CType(MyCtl, Button)
                        If .Name.Equals("BtnDelete") = True Then
                            .Text = "Delete"
                        End If
                    End With
                End If

                If TypeOf MyCtl Is MyLabel Then
                    With CType(MyCtl, MyLabel)
                        .Tag = String.Empty
                        If .TextBox.Equals(True) And .InputType = MyTextInputType.None Then
                            .Text = String.Empty
                        ElseIf .TextBox.Equals(True) And .InputType = MyTextInputType.Currency Then
                            .Text = "0.00"
                        ElseIf .TextBox.Equals(True) And .InputType = MyTextInputType.Number Then
                            .Text = "0"
                        End If
                    End With
                End If

                If MyCtl.HasChildren Then
                    ResetTextBox(MyCtl)
                End If
            Next
        Catch Ex As Exception
            MessageBox.Show(Ex.Message.ToString, "Reset Text", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    Public Function CurrentDate() As DateTime
        Return GetValue("Select GETDATE()")
    End Function

    Private Function MyValue(ByVal SqlString As String, Optional SqlPara As List(Of SqlParameter) = Nothing) As Object
        'BuildConnString()
        Dim MyStatus As Object = Nothing
        Using SqlConn As New SqlConnection(ConnString)
            Using SqlCmd As New SqlCommand()
                Try
                    With SqlCmd
                        .Parameters.Clear()
                        .Connection = SqlConn
                        If SqlString.StartsWith("Select", StringComparison.CurrentCultureIgnoreCase).Equals(True) Then
                            .CommandType = CommandType.Text
                            .CommandText = SqlString

                        ElseIf SqlString.StartsWith("Insert", StringComparison.CurrentCultureIgnoreCase).Equals(True) Then
                            .CommandType = CommandType.Text
                            .CommandText = SqlString

                        ElseIf SqlString.StartsWith("Update", StringComparison.CurrentCultureIgnoreCase).Equals(True) Then
                            .CommandType = CommandType.Text
                            .CommandText = SqlString

                        ElseIf SqlString.StartsWith("Delete", StringComparison.CurrentCultureIgnoreCase).Equals(True) Then
                            .CommandType = CommandType.Text
                            .CommandText = SqlString

                        ElseIf SqlPara Is Nothing Then
                            .CommandType = CommandType.Text
                            .CommandText = "Exec dbo." & SqlString

                        ElseIf SqlPara IsNot Nothing Then
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "dbo." & SqlString
                            .Parameters.AddRange(SqlPara.ToArray())

                        End If
                    End With

                    SqlConn.Open()
                    Dim MyValueReader As SqlDataReader = SqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
                    While MyValueReader.Read()
                        If IsDBNull(MyValueReader(0)) = True Then
                            MyStatus = Nothing
                        Else
                            MyStatus = MyValueReader(0)
                        End If
                    End While
                    MyValueReader.Close() : MyValueReader = Nothing
                Catch ex As Exception
                    LogError(ex, SqlString)
                    MessageBox.Show(("An exception Of type " & ex.GetType().ToString() & " was encountered While Filling Auto Complate Text." &
                                     vbNewLine & ex.Message.ToString()), "Get Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ParameterList.Clear() : SqlConn.Close()
                End Try
            End Using
        End Using
        Return MyStatus
    End Function

    Public Function GetValue(ByVal SqlString As String) As Object
        Return MyValue(SqlString, Nothing)
    End Function

    Public Function GetValue(ByVal SqlString As String, ListofSqlParameter As List(Of SqlParameter)) As Object
        Return MyValue(SqlString, ListofSqlParameter)
    End Function

    Public Sub AddParameter(ParameterName As String, value As Object)
        Try
            ParameterList.Add(New SqlParameter(ParameterName, value))
        Catch Ex As Exception
            LogError(Ex, "Build Parameter")
            MessageBox.Show(Ex.Message.ToString, "Base Form AddParameter", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ClearParameter()
        Try
            ParameterList.Clear()
        Catch Ex As Exception
            LogError(Ex, "Clear Parameter")
        End Try
    End Sub

    Private Function MyScalar(ByVal SqlString As String, Optional SqlPara As List(Of SqlParameter) = Nothing) As Object

        Dim res As New Object

        'If BuildConnString.Equals(True) Then
        Using Sqlconn As New SqlConnection(ConnString)
            Dim Transaction As SqlTransaction = Nothing
            Dim Sqlcmd As New SqlCommand()
            Try
                With Sqlcmd
                    .Connection = Sqlconn
                    .Parameters.Clear()
                    If SqlString.StartsWith("Select", StringComparison.CurrentCultureIgnoreCase) Then
                        .CommandType = CommandType.Text
                        .CommandText = SqlString

                    ElseIf SqlString.StartsWith("Insert", StringComparison.CurrentCultureIgnoreCase) Then
                        .CommandType = CommandType.Text
                        .CommandText = SqlString

                    ElseIf SqlString.StartsWith("Update", StringComparison.CurrentCultureIgnoreCase) Then
                        .CommandType = CommandType.Text
                        .CommandText = SqlString

                    ElseIf SqlString.StartsWith("Delete", StringComparison.CurrentCultureIgnoreCase) Then
                        .CommandType = CommandType.Text
                        .CommandText = SqlString

                    ElseIf SqlPara Is Nothing Then
                        .CommandType = CommandType.Text
                        .CommandText = "Exec dbo." & SqlString

                    ElseIf Not SqlPara Is Nothing Then
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddRange(SqlPara.ToArray())
                        .CommandText = "dbo." & SqlString
                    End If
                End With

                Sqlconn.Open()
                Transaction = Sqlconn.BeginTransaction()
                Sqlcmd.Transaction = Transaction
                res = Sqlcmd.ExecuteScalar()
                Transaction.Commit()
            Catch ex As Exception
                Try
                    LogError(ex, SqlString)
                    res = Nothing
                    Transaction.Rollback()
                Catch ex1 As SqlException
                    LogError(ex1, SqlString)
                    If Not Transaction.Connection Is Nothing Then
                        MessageBox.Show("An exception Of type " & ex1.GetType().ToString() &
                                        " was encountered While attempting To roll back the transaction." &
                                        vbNewLine & ex1.Message.ToString(), "Execute Scalar", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If
                End Try

                MessageBox.Show("An exception Of type " & ex.GetType().ToString() &
                                "was encountered While inserting the data." &
                                vbNewLine & ex.Message.ToString(), "Execute Scalar", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                Sqlconn.Close() : Sqlcmd.Dispose() : Transaction.Dispose() : ClearParameter()
            End Try
        End Using
        '      Else
        '     MessageBox.Show(ErrMsg.ToString(), "Execure Scalar", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    End If

        Return res

    End Function

    Public Function ExecuteScalar(ByVal SqlString As String) As Object
        Return MyScalar(SqlString)
    End Function

    Public Function ExecuteScalar(ByVal SqlString As String, ListofParameter As List(Of SqlParameter)) As Object
        Return MyScalar(SqlString, ListofParameter)
    End Function

    Private Sub MyNonQuery(ByVal SqlString As String, Optional SqlPara As List(Of SqlParameter) = Nothing)

        'If BuildConnString.Equals(True) Then
        Using SQLConn As New SqlConnection(ConnString)
            Dim SqlCmd As SqlCommand = SQLConn.CreateCommand()
            Dim Transaction As SqlTransaction = Nothing
            Try
                SQLConn.Open()
                ' Start a local transaction
                Transaction = SQLConn.BeginTransaction("SampleTransaction")
                ' Must assign both transaction object and connection
                ' to Command object for a pending local transaction
                SqlCmd.Connection = SQLConn
                SqlCmd.Transaction = Transaction

                With SqlCmd
                    .Parameters.Clear()
                    If SqlString.StartsWith("Select", StringComparison.CurrentCultureIgnoreCase) Then
                        .CommandType = CommandType.Text
                        .CommandText = SqlString

                    ElseIf SqlString.StartsWith("Insert", StringComparison.CurrentCultureIgnoreCase) Then
                        .CommandType = CommandType.Text
                        .CommandText = SqlString

                    ElseIf SqlString.StartsWith("Update", StringComparison.CurrentCultureIgnoreCase) Then
                        .CommandType = CommandType.Text
                        .CommandText = SqlString

                    ElseIf SqlString.StartsWith("Delete", StringComparison.CurrentCultureIgnoreCase) Then
                        .CommandType = CommandType.Text
                        .CommandText = SqlString

                    ElseIf SqlPara Is Nothing Then
                        .CommandType = CommandType.Text
                        .CommandText = "Exec dbo." & SqlString

                    ElseIf Not SqlPara Is Nothing Then
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "dbo." & SqlString
                        .Parameters.AddRange(SqlPara.ToArray())
                    End If
                End With

                SqlCmd.ExecuteNonQuery()
                Transaction.Commit()

            Catch Ex As Exception
                Try
                    LogError(Ex, SqlString)
                    Transaction.Rollback()
                Catch Exr As SqlException
                    LogError(Exr, SqlString)
                    If Not Transaction.Connection Is Nothing Then
                        MessageBox.Show("An exception Of type " & Exr.GetType().ToString() &
                                    " was encountered While attempting To roll back the transaction." &
                                    vbNewLine & Exr.Message.ToString(), "Execute Non Query", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If
                End Try

                MessageBox.Show("An exception Of type " & Ex.GetType().ToString() &
                            "was encountered While inserting the data." &
                            vbNewLine & Ex.Message.ToString(), "Execute Non Query", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Throw Ex
            Finally
                SQLConn.Close() : SqlCmd.Dispose() : Transaction.Dispose() : ClearParameter()
            End Try

        End Using
        'Else
        'MessageBox.Show(ErrMsg.ToString, "Execure Non Query", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'End If
    End Sub

    Public Sub ExecuteNonQuery(ByVal SqlString As String)
        Try
            MyNonQuery(SqlString)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ExecuteNonQuery(ByVal SqlString As String, ListOfParameter As List(Of SqlParameter))
        Try
            MyNonQuery(SqlString, ListOfParameter)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function NewDataTable(ByVal SqlString As String, Optional Sqlpara As List(Of SqlParameter) = Nothing) As DataTable

        Dim DT As New DataTable

        'If BuildConnString.Equals(True) Then
        Using SqlConn As New SqlConnection(ConnString)
            Try
                If SqlString.StartsWith("Select", StringComparison.CurrentCultureIgnoreCase) Then
                    SqlString = SqlString

                ElseIf SqlString.StartsWith("Insert", StringComparison.CurrentCultureIgnoreCase) Then
                    SqlString = SqlString

                ElseIf SqlString.StartsWith("Update", StringComparison.CurrentCultureIgnoreCase) Then
                    SqlString = SqlString

                ElseIf SqlString.StartsWith("Delete", StringComparison.CurrentCultureIgnoreCase) Then
                    SqlString = SqlString

                ElseIf Sqlpara Is Nothing Then
                    SqlString = "Exec dbo." & SqlString

                ElseIf Not Sqlpara Is Nothing Then
                    SqlString = "dbo." & SqlString

                End If

                Using SqlDA As New SqlDataAdapter(SqlString, SqlConn)
                    SqlDA.SelectCommand.Parameters.Clear()

                    If Sqlpara Is Nothing Then
                        SqlDA.SelectCommand.CommandType = CommandType.Text
                    Else
                        SqlDA.SelectCommand.CommandType = CommandType.StoredProcedure
                        Sqlpara.ForEach(Sub(p) SqlDA.SelectCommand.Parameters.Add(p))
                    End If

                    SqlDA.Fill(DT)
                End Using
            Catch ex As Exception
                LogError(ex, SqlString)
                MessageBox.Show(("An exception Of type " & ex.GetType().ToString() & " was encountered While Getting DataTable." &
                             vbNewLine & ex.Message.ToString()), "Data Table", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                SqlConn.Close() : ClearParameter()
            End Try
        End Using
        'Else
        'MessageBox.Show(ErrMsg.ToString, "Data Table", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'End If
        Return DT
    End Function

    Public Function ExecuteDatatable(ByVal SqlString As String) As DataTable
        Return NewDataTable(SqlString)
    End Function

    Public Function ExecuteDatatable(ByVal SqlString As String, ListofParameter As List(Of SqlParameter)) As DataTable
        Return NewDataTable(SqlString, ListofParameter)
    End Function


    Private Function NewDataSet(ByVal SqlString As String, Optional SqlPara As List(Of SqlParameter) = Nothing) As DataSet
        Dim Ds As New DataSet
        'If BuildConnString.Equals(True) Then
        Using SqlConn As New SqlConnection(ConnString)
            Try
                If SqlString.StartsWith("Select", StringComparison.CurrentCultureIgnoreCase) Then
                    SqlString = SqlString

                ElseIf SqlString.StartsWith("Insert", StringComparison.CurrentCultureIgnoreCase) Then
                    SqlString = SqlString

                ElseIf SqlString.StartsWith("Update", StringComparison.CurrentCultureIgnoreCase) Then
                    SqlString = SqlString

                ElseIf SqlString.StartsWith("Delete", StringComparison.CurrentCultureIgnoreCase) Then
                    SqlString = SqlString

                ElseIf SqlPara Is Nothing Then
                    SqlString = "Exec dbo." & SqlString

                ElseIf Not SqlPara Is Nothing Then
                    SqlString = "dbo." & SqlString

                End If

                Using SqlDA As New SqlDataAdapter(SqlString, SqlConn)
                    SqlDA.SelectCommand.Parameters.Clear()

                    If SqlPara Is Nothing Then
                        SqlDA.SelectCommand.CommandType = CommandType.Text
                    Else
                        SqlDA.SelectCommand.CommandType = CommandType.StoredProcedure
                        SqlPara.ForEach(Sub(p) SqlDA.SelectCommand.Parameters.Add(p))
                    End If
                    SqlDA.Fill(Ds)
                End Using
            Catch ex As Exception
                LogError(ex, SqlString)
                MessageBox.Show(("An exception Of type " & ex.GetType().ToString() & " was encountered While Getting DataTable." &
                             vbNewLine & ex.Message.ToString()), "Data Set", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Finally
                SqlConn.Close() : ClearParameter()
            End Try
        End Using
        'Else
        'MessageBox.Show(ErrMsg.ToString(), "Get DataSet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If
        Return Ds
    End Function

    Public Function ExecuteDataSet(ByVal SqlString As String, ListofParameter As List(Of SqlParameter)) As DataSet
        Return NewDataSet(SqlString, ListofParameter)
    End Function

    Public Function ExecuteDataSet(ByVal SqlString As String) As DataSet
        Return NewDataSet(SqlString)
    End Function

    Private Sub MyComboDataSource(ByVal Sqlstring As String, ByVal MyCombobox As ComboBox, Optional MyDefaultValue As String = Nothing, Optional SqlPara As List(Of SqlParameter) = Nothing)

        'If BuildConnString.Equals(True) Then
        Dim DT As New DataTable
        Try
            Using SqlConn As New SqlConnection(ConnString)
                Using SqlCmd As New SqlCommand()
                    With SqlCmd
                        .Parameters.Clear()
                        .Connection = SqlConn
                        If Sqlstring.StartsWith("Select", StringComparison.CurrentCultureIgnoreCase).Equals(True) Then
                            .CommandType = CommandType.Text
                            .CommandText = Sqlstring

                        ElseIf Sqlstring.StartsWith("Insert", StringComparison.CurrentCultureIgnoreCase).Equals(True) Then
                            .CommandType = CommandType.Text
                            .CommandText = Sqlstring

                        ElseIf Sqlstring.StartsWith("Update", StringComparison.CurrentCultureIgnoreCase).Equals(True) Then
                            .CommandType = CommandType.Text
                            .CommandText = Sqlstring

                        ElseIf Sqlstring.StartsWith("Delete", StringComparison.CurrentCultureIgnoreCase).Equals(True) Then
                            .CommandType = CommandType.Text
                            .CommandText = Sqlstring

                        ElseIf SqlPara Is Nothing Then
                            .CommandType = CommandType.Text
                            .CommandText = "Exec dbo." & Sqlstring

                        ElseIf Not SqlPara Is Nothing Then
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "dbo." & Sqlstring
                            SqlPara.ForEach(Sub(p) .Parameters.Add(p))
                        End If

                    End With
                    Using SqlDA As New SqlDataAdapter(SqlCmd)
                        SqlDA.Fill(DT)

                        If DT.Rows.Count > 0 AndAlso Not MyDefaultValue Is Nothing Then

                            Dim Dr As DataRow
                            Dr = DT.NewRow()
                            Dr.Item(0) = Val(0)
                            Dr.Item(1) = MyDefaultValue.ToString()
                            DT.Rows.InsertAt(Dr, 0)
                        End If
                        MyCombobox.DataSource = DT
                        MyCombobox.ValueMember = DT.Columns(0).ColumnName
                        MyCombobox.DisplayMember = DT.Columns(1).ColumnName
                    End Using
                End Using
            End Using
        Catch ex As Exception
            LogError(ex, Sqlstring)
            MessageBox.Show(("An exception Of type " & ex.GetType().ToString() & " was encountered While Filling Combobx Data Source." &
                                 vbNewLine & ex.Message.ToString()), "Data Table", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Finally
            ClearParameter()
        End Try
        'End If

    End Sub

    Public Sub FillComboDataSource(ByVal Sqlstring As String, ByVal MyCombobox As ComboBox)
        MyComboDataSource(Sqlstring, MyCombobox)
    End Sub

    Public Sub FillComboDataSource(ByVal Sqlstring As String, ByVal MyCombobox As ComboBox, ByVal DefaultValue As String)
        MyComboDataSource(Sqlstring, MyCombobox, DefaultValue)
    End Sub

    Public Sub FillComboDataSource(ByVal Sqlstring As String, ByVal MyCombobox As ComboBox, SqlPara As List(Of SqlParameter))
        MyComboDataSource(Sqlstring, MyCombobox, Nothing, SqlPara)
    End Sub

    Public Sub FillComboDataSource(ByVal Sqlstring As String, ByVal MyCombobox As ComboBox, ByVal DefaultValue As String, ByVal SqlPara As List(Of SqlParameter))
        MyComboDataSource(Sqlstring, MyCombobox, DefaultValue, SqlPara)
    End Sub

    Public Sub SetDBLogonForReport(ByVal myReportDocument As ReportDocument, Optional ByVal isProcReport As Boolean = False)

        Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()

        If isProcReport = False Then
            myConnectionInfo.ServerName = ServerName
            myConnectionInfo.DatabaseName = DataBase
            If Trim(DbUser) <> "" Then
                myConnectionInfo.UserID = DbUser
            End If
            If Trim(dbPass) <> "" Then
                myConnectionInfo.Password = dbPass
            End If

            If Trim(DbUser) = "" Or Trim(dbPass) = "" Then
                myConnectionInfo.IntegratedSecurity = True
            Else
                myConnectionInfo.IntegratedSecurity = False
            End If

            Dim myTables As Tables = myReportDocument.Database.Tables
            For Each myTable As Table In myTables

                Dim myTableLogonInfo As New TableLogOnInfo
                myTableLogonInfo.ConnectionInfo = myConnectionInfo
                myTable.ApplyLogOnInfo(myTableLogonInfo)

                myTable.Location = DataBase + ".dbo." + myTable.Location.Substring(myTable.Location.LastIndexOf(".") + 1)

                If myTable.TestConnectivity.ToString = "False" Then
                    MsgBox("Connection not Found")
                End If
            Next
        Else

            myConnectionInfo.ServerName = ServerName
            myConnectionInfo.DatabaseName = DataBase
            If Trim(DbUser) <> "" Then
                myConnectionInfo.UserID = DbUser
            End If
            If Trim(dbPass) <> "" Then
                myConnectionInfo.Password = dbPass
            End If

            If Trim(DbUser) = "" Or Trim(dbPass) = "" Then
                myConnectionInfo.IntegratedSecurity = True
            Else
                myConnectionInfo.IntegratedSecurity = False
            End If

            Dim myTables As Tables = myReportDocument.Database.Tables
            For Each myTable As Table In myTables

                Dim myTableLogonInfo As New TableLogOnInfo
                myTableLogonInfo.ConnectionInfo = myConnectionInfo
                myTable.ApplyLogOnInfo(myTableLogonInfo)

                myTable.Location = DataBase + ".dbo." + myTable.Location.Substring(myTable.Location.LastIndexOf(".") + 1)

                If myTable.TestConnectivity.ToString = "False" Then
                    MsgBox("Connection not Found")
                End If
            Next
        End If

    End Sub



End Class

Imports System.ComponentModel
Public Enum TextInputType
    None
    Number
    MobileNo
    Currency
    Email
    Parcentage
End Enum
Public Class MyTextBox


    Inherits TextBox

    Private Sub MyTextBox_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        BackColor = Color.LemonChiffon
    End Sub

    Private Sub MyTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then SendKeys.Send("{TAB}")
        'If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then SendKeys.Send("{TAB}")
        'If e.KeyCode = Keys.Up Then SendKeys.Send("+{TAB}")
    End Sub

    Private Sub MyTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case _MyInputType
            Case TextInputType.None
            Case TextInputType.MobileNo And e.KeyChar <> ControlChars.Back
                If e.KeyChar = "+"c Then
                    e.Handled = (CType(sender, MyTextBox).Text.IndexOf("+"c) <> -1)
                Else
                    e.Handled = ("0123456789".IndexOf(e.KeyChar) = -1)
                End If
            Case TextInputType.Number And e.KeyChar <> ControlChars.Back
                e.Handled = ("0123456789".IndexOf(e.KeyChar) = -1)

            Case TextInputType.Currency And e.KeyChar <> ControlChars.Back
                If e.KeyChar = "."c Then
                    e.Handled = (CType(sender, MyTextBox).Text.IndexOf("."c) <> -1)
                Else
                    e.Handled = ("0123456789".IndexOf(e.KeyChar) = -1)
                End If

            Case TextInputType.Parcentage And e.KeyChar <> ControlChars.Back
                If e.KeyChar = "."c Then
                    e.Handled = (CType(sender, MyTextBox).Text.IndexOf("."c) <> -1)
                Else
                    e.Handled = ("0123456789".IndexOf(e.KeyChar) = -1)
                End If
        End Select

    End Sub

    Private Sub MyTextBox_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        BackColor = SystemColors.Window
        SetVal ()
    End Sub
    Private Sub SetVal()
        Select Case _MyInputType
            Case TextInputType.Currency
                TextAlign = HorizontalAlignment.Right
                Text = Val(Text).ToString("#0.00")
            Case TextInputType.Parcentage
                TextAlign = HorizontalAlignment.Right
                Text = Val(Text).ToString("#0.00")
        End Select
    End Sub

    Dim _MyInputType As TextInputType
    <DefaultValue(TextInputType.None), Category("Project Property"), Description("Set or Get Input Type Text.")> _
    Public Property InputType() As TextInputType
        Get
            Return _MyInputType
        End Get
        Set(value As TextInputType)
            _MyInputType = value
            SetText()
        End Set
    End Property

    Dim _Decimal As Integer = 0
    <DefaultValue(0), Category("Project Property"), Description("Set or Get Decimal Value.")> _
    Public Property DecimalPoint As Integer
        Get
            Return _Decimal
        End Get
        Set(value As Integer)
            _Decimal = Val(value)
            SetText()
        End Set
    End Property

    Private Sub SetText()
        Select Case _MyInputType
            Case TextInputType.None, TextInputType.Email
                TextAlign = HorizontalAlignment.Left
                Text = String.Empty
            Case TextInputType.Number
                TextAlign = HorizontalAlignment.Left
                Text = Val(0)
            Case TextInputType.Currency
                TextAlign = HorizontalAlignment.Right
                Text = FormatNumber(Val(Text), _Decimal)
            Case TextInputType.Parcentage
                TextAlign = HorizontalAlignment.Right
                Text = FormatNumber(Val(Text), _Decimal)
        End Select
    End Sub

    Private Sub MyTextBox_Validated(sender As Object, e As EventArgs) Handles Me.Validated

        If Text.Equals(String.Empty) = True Then Exit Sub

        If _MyInputType = TextInputType.MobileNo Then
            If Text.StartsWith("0") = True And Val(Text.Length <> 11) Then
                MessageBox.Show("Invalid Mobile No." & vbNewLine & "Please Enter Valid Mobile No.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Focus()
                Exit Sub
            ElseIf Text.StartsWith("91") = True And Val(Text.Length <> 12) Then
                MessageBox.Show("Invalid Mobile No." & vbNewLine & "Please Enter Valid Mobile No.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Focus()
                Exit Sub
            ElseIf Text.StartsWith("+91") = True And Val(Text.Length <> 13) Then
                MessageBox.Show("Invalid Mobile No." & vbNewLine & "Please Enter Valid Mobile No.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Focus()
                Exit Sub
            End If
        ElseIf _MyInputType = TextInputType.Parcentage Then
            If Val(Text) < 0 And Val(Text) > 100 Then
                MessageBox.Show("Invalid Parcenatage." & vbNewLine & "Please Parcentage Between 1 to 100.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Focus()
                Exit Sub
            End If
        End If
    End Sub

End Class

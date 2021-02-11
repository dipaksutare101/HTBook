Imports System.ComponentModel

Public Enum MyTextInputType
    None
    Number
    Currency
End Enum

Public Class MyLabel
    Inherits System.Windows.Forms.Label

    Dim _IsTextBox As Boolean = False
    <DefaultValue(False)>
    Public Property TextBox() As Boolean
        Get
            Return _IsTextBox
        End Get
        Set(value As Boolean)
            _IsTextBox = value
        End Set
    End Property


    Dim _MyInputType As MyTextInputType
    <DefaultValue(MyTextInputType.None), Category("Project Property"), Description("Set or Get Input Type Text.")>
    Public Property InputType() As MyTextInputType
        Get
            Return _MyInputType
        End Get
        Set(value As MyTextInputType)
            _MyInputType = value

            If _IsTextBox.Equals(True) Then SetText()
        End Set
    End Property

    Private Sub SetText()
        Select Case _MyInputType
            Case MyTextInputType.None
                Me.TextAlign = ContentAlignment.MiddleRight
                Me.Text = Me.Name
                Me.BorderStyle = BorderStyle.None
            Case MyTextInputType.Number
                Me.TextAlign = ContentAlignment.MiddleLeft
                Me.Text = Val(0)
                Me.BorderStyle = BorderStyle.FixedSingle
            Case MyTextInputType.Currency
                Me.TextAlign = ContentAlignment.MiddleRight
                Me.Text = FormatNumber(Val(Me.Text), _Decimal)
                Me.BorderStyle = BorderStyle.FixedSingle
        End Select
    End Sub

    Dim _Decimal As Integer = 0
    <DefaultValue(0), Category("Project Property"), Description("Set or Get Decimal Value.")>
    Public Property DecimalPoint As Integer
        Get
            Return _Decimal
        End Get
        Set(value As Integer)
            _Decimal = Val(value)
            Me.Text = FormatNumber(Val(Me.Text), _Decimal)
        End Set
    End Property


    Dim _FormatedText As String = "0.00"
    Public ReadOnly Property FormatedText() As String
        Get
            Dim MyText As String = String.Empty
            If TextBox.Equals(True) Then
                MyText = FormatNumber(Val(Me.Text), _Decimal)
            End If
            Return MyText
        End Get
    End Property

End Class

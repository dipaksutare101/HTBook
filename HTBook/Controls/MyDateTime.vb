Public Class MyDateTime
    Inherits System.Windows.Forms.DateTimePicker

    Public ReadOnly Property SqlDate() As DateTime
        Get
            Return Value.ToString("yyyy/MM/dd")
        End Get
    End Property

End Class

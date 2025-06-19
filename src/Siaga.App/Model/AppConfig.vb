Namespace Model
    Public Class AppConfig
        Public Property DBConfig As DBConfig
        Public Property Theme As String
    End Class

    Public Class DBConfig
        Public Property Server As String
        Public Property UserID As String
        Public Property Password As String
        Public Property Timeout As Integer
    End Class
End Namespace

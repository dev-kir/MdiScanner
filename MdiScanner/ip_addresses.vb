Public Class ip_addresses
    Public Property ip_address As String
    Public Property name As String
    Public Property status As String

    Public Sub New(ip_address As String, name As String)
        Me.ip_address = ip_address
        Me.name = name
        Me.status = "Down"
    End Sub
End Class

Imports System.Data.SqlClient
Module Module1
    Public Conn As New SqlConnection
    Public Da As SqlDataAdapter
    Public Ds As DataSet
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public MyDB As String
    Public Sub Connect()
        MyDB = "Data Source=MSI;initial catalog=kimdomi;integrated security=true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

End Module

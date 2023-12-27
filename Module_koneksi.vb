Imports System.Data.SqlClient


Module Module_koneksi
    Public CONN As SqlConnection
    Public DA As SqlDataAdapter
    Public DS As DataSet
    Public CMD As SqlCommand
    Public DR As SqlDataReader
    Public DT As DataTable

    Public Sub koneksi()
        CONN = New SqlConnection("data source=ARDHANA\SQLEXPRESS01;initial catalog=DATATIKET;integrated security=true")
        CONN.Open()
    End Sub


End Module

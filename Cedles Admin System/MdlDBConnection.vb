Imports System.Data.SqlClient

Module MDLDBConnection
    Public con As New SqlConnection("Data Source=TAN-PC\MSSQLSERVER1;Initial Catalog=SchoolDatabase;Integrated Security=True")
    Public cmd As SqlCommand
    Public dr As SqlClient.SqlDataReader
End Module

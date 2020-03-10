Module MdlSqlQueries
    Public TableName As String
    Public orderby As String
    Public display As String
    Public Sub LoadData(TableName As String, orderby As String, FormName As Form, display As String)
        Dim table As ListView = GetControlByName(FormName, display)
        Dim columncount As Integer
        table.Items.Clear()
        Dim cmd As New SqlClient.SqlCommand("select * from " + TableName + " order by " + orderby, con)
        con.Open()
        dr = cmd.ExecuteReader
        columncount = dr.FieldCount - 1
        Dim x As Integer = 0
        Dim y As Integer = 0
        While dr.Read
            table.Items.Add(dr.GetValue(0).ToString())
            For y = 1 To columncount
                table.Items(x).SubItems.Add(dr.GetValue(y).ToString())
            Next y
            x = x + 1
        End While
        con.Close()


    End Sub

    Private Function GetControlByName(container As Control, name As String) As Control
        Dim retVal As Control = Nothing
        If Not TryGetControlByName(container, name, retVal) Then Throw New ApplicationException("control not found")
        Return retVal
    End Function

    Private Function TryGetControlByName(container As Control, name As String, ByRef ctl As Control) As Boolean
        For Each item As Control In container.Controls
            If item.Name = name Then
                ctl = item
                Return True
            End If

            'If item is a Container (like GroupBox, Panel) check its children
            If TryGetControlByName(item, name, ctl) Then Return True
        Next
        Return False
    End Function
End Module
Imports MySql.Data.MySqlClient

Module BasicModule
    Public strConn, testConn As String

    Public Function getStrConn() As String
        Try
            strConn = "server=127.0.0.1;uid=root;pwd=;database=sekolah"
        Catch ex As Exception
            MsgBox(ex)
        End Try

        Return strConn
    End Function
    Public Function getDS(ByVal sql As String, ByVal conStr As String) As DataSet
        Dim connection As New MySqlConnection(conStr)
        Dim command As New MySqlCommand("", connection)
        Dim adapter As New MySqlDataAdapter
        Dim ds As New DataSet
        If (connection.State = ConnectionState.Open) Then
            connection.Close()
        End If
        connection.Open()
        'MessageBox.Show(sql)
        command.CommandText = sql
        adapter.SelectCommand = command
        adapter.Fill(ds, "data")
        connection.Close()
        Return ds
    End Function

    Public Function execScalar(ByVal sql As String, ByVal conStr As String) As String
        Dim connection As New MySqlConnection(conStr)
        Dim cmd As New MySqlCommand("", connection)
        Dim adapter As New MySqlDataAdapter
        Dim ds As New DataSet
        If (connection.State = ConnectionState.Open) Then
            connection.Close()
        End If
        connection.Open()
        cmd.CommandText = sql
        Return cmd.ExecuteScalar()
        connection.Close()
    End Function

    Public Function execQuery(ByVal sql As String, ByVal conStr As String) As Boolean
        Dim connection As New MySqlConnection(conStr)
        Dim cmd As New MySqlCommand("", connection)
        Dim adapter As New MySqlDataAdapter
        Dim ds As New DataSet
        If (connection.State = ConnectionState.Open) Then
            connection.Close()
        End If
        connection.Open()
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        connection.Close()
        Return True
    End Function

End Module

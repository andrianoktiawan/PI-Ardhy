Imports MySql.Data.MySqlClient
Public Class frmStock
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_dgv()
    End Sub

    Private Sub refresh_dgv()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM stock", strConn)

        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAdditem.Show()
        Me.Close()

    End Sub
End Class
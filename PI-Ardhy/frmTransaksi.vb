Imports MySql.Data.MySqlClient

Public Class frmTransaksi
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Close()
    End Sub
    Private Sub frmTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT kd_barang, nama_barang FROM stock", strConn)
        Dim ds As New DataSet

        adapter.Fill(ds)

        Dim test = ds.Tables(0).Rows.Count
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

            ComboBox1.Items.Add(ds.Tables(0).Rows(i).Item("nama_barang"))

        Next

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtDate_TextChanged(sender As Object, e As EventArgs) Handles txtDate.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles txtTunai.Click

    End Sub
End Class
Imports MySql.Data.MySqlClient
Imports System.Globalization

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

            Dim a = ds.Tables(0).Rows(i).Item("nama_barang")
            Dim b = ds.Tables(0).Rows(i).Item("kd_barang")
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.ValueMember = "kd_barang"
            ComboBox1.DisplayMember = "nama_barang"

        Next

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim test = ComboBox1.SelectedValue
        Dim qty As Integer = NumericUpDown1.Value

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter($"SELECT kd_barang as 'Kode Barang', nama_barang as 'Nama Barang', harga_jual as Harga, {qty} as qty, (harga_jual * {qty}) as Total FROM stock where kd_barang = {test}", strConn)

        If DataGridView1.DataSource IsNot Nothing Then
            Dim table2 As New DataTable()
            adapter.Fill(table2)
            Dim total = 0
            Dim table3 As DataTable = DataGridView1.DataSource

            ' Loop through each row in the source DataTable
            For Each sourceRow As DataRow In table2.Rows
                ' Import the row from the source DataTable to the destination DataTable
                Dim newRow As DataRow = table3.NewRow()

                ' Copy the values from sourceRow to newRow
                For Each column As DataColumn In table3.Columns
                    newRow(column.ColumnName) = sourceRow(column.ColumnName)
                Next

                ' Add the new row to the destination DataTable
                table3.Rows.Add(newRow)
            Next

            DataGridView1.DataSource = table3

            For i As Integer = 0 To table3.Rows.Count - 1

                Dim totalrow As Integer = table3.Rows(i).Item("Total")

                total += totalrow

            Next

            Dim formattedValue As String = String.Format("{0:C2}", total)
            TextBox1.Text = formattedValue

            MsgBox("sukses tambah kue...")
        Else
            adapter.Fill(table)

            DataGridView1.DataSource = table

            Dim total = table.Rows(0).Item("Total")
            Dim formattedValue As String = String.Format("{0:C2}", total)

            TextBox1.Text = formattedValue

            MsgBox("sukses tambah kue...")
        End If

    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        Dim bayar = TextBox5.Text
        Dim total = TextBox1.Text

        Dim kembalian = bayar - total

        Dim formattedValue As String = String.Format("{0:C2}", kembalian)

        TextBox4.Text = formattedValue





    End Sub
End Class
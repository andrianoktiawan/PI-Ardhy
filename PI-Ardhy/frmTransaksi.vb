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

        If qty = 0 Then
            MsgBox("Qty harus lebih dari 0!")
            Exit Sub
        End If

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
            txtTotal.Text = formattedValue

            MsgBox("sukses tambah kue...")
        Else
            adapter.Fill(table)

            DataGridView1.DataSource = table

            Dim total = table.Rows(0).Item("Total")
            Dim formattedValue As String = String.Format("{0:C2}", total)

            txtTotal.Text = formattedValue

            MsgBox("sukses tambah kue...")
        End If

        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(4).ReadOnly = True
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        'Dim bayar = TextBox5.Text
        Dim total = txtTotal.Text
        Dim bayar = txtTunai.Text
        Dim kembalian = bayar - total

        Dim formattedValue As String = String.Format("{0:C2}", kembalian)

        txtKembalian.Text = formattedValue


    End Sub
    'Private Sub txtTunai_TextChanged(sender As Object, e As EventArgs) Handles txtTunai.TextChanged
    '    TextBox5.Text = String.Format("{0:#,0}", Convert.ToDouble(TextBox5.Text))
    '    TextBox5.SelectionStart = TextBox5.Text.Length
    '    TextBox5.SelectionLength = 0
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if any row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected row (since MultiSelect is set to False, only one row will be selected)
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Remove the selected row from the DataGridView
            DataGridView1.Rows.Remove(selectedRow)
        Else
            MsgBox("Silahkan pilih item yg ingin dihapus")
            DataGridView1.Focus()
        End If
    End Sub
    Private Sub dataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.ColumnIndex = 3 Then

            Dim value = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            Dim harga = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            Dim total_baru = value * harga

            DataGridView1.Rows(e.RowIndex).Cells(4).Value = total_baru


            Dim total = DataGridView1.DataSource.Rows(0).Item("Total")
            Dim formattedValue As String = String.Format("{0:C2}", total)

            txtTotal.Text = formattedValue
        End If

    End Sub

End Class
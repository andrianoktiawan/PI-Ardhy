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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        ' Check if any row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected row (since MultiSelect is set to False, only one row will be selected)
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim kd_barang = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value

            Dim result As DialogResult = MessageBox.Show($"apakah anda yakin untuk menghapus kode barang {kd_barang}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim hasil = execQuery($"DELETE FROM STOCK WHERE kd_barang = {kd_barang} ", strConn)

                If hasil = True Then
                    ' Remove the selected row from the DataGridView
                    DataGridView1.Rows.Remove(selectedRow)
                Else
                    MsgBox("Gagal Hapus Kue...")
                End If
            Else
                Exit Sub
            End If
        Else
            MsgBox("Silahkan pilih item yg ingin dihapus")
            DataGridView1.Focus()
        End If
    End Sub
End Class
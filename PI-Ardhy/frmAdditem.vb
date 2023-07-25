Public Class frmAdditem
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmStock.Show()
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim kd_barang, nama_barang, harga_jual, Stock As String

        kd_barang = TextBox1.Text
        nama_barang = TextBox2.Text
        harga_jual = TextBox3.Text
        Stock = TextBox4.Text

        If isEmpty(kd_barang, nama_barang, harga_jual, Stock) = True Then
            MsgBox("Ada data yang masih kosong!")
        Else
            Dim hasil = execQuery($"INSERT INTO stock(kd_barang, nama_barang, harga_jual, Stock) VALUES ('{kd_barang}', '{nama_barang}', '{harga_jual}', '{Stock}');", strConn)
            If hasil = True Then
                MsgBox("Berhasil menginput stock")
            Else
                MsgBox("Nama barang sudah tersedia")
                MsgBox("Gagal menginput Stock!")
            End If

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
        End If
    End Sub

    Private Function isEmpty(kd_barang As String, nama_barang As String, harga_jual As String, stock As String) As Boolean
        If kd_barang = "" Or nama_barang = "" Or harga_jual = "" Or stock = "" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
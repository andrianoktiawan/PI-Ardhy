Imports MySql.Data.MySqlClient
Public Class frmDelete
    Private txtUser As Object

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        frmCreateAccount.Show()
        Me.Close()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim username As String

        username = txtUsernameD.Text

        Dim result As DialogResult = MessageBox.Show($"Apakah anda yakin untuk menghapus {username}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim hasil = execQuery($"DELETE FROM user WHERE username =  ('{username}');", strConn)
            If hasil = True Then
                MsgBox("Berhasil menghapus account!")
                refresh_dgv()
                DataGridView1.Refresh()
            Else
                MsgBox("Gagal menghapus account!")
            End If

            txtUsernameD.Text = ""
        Else
            Exit Sub
        End If



    End Sub

    Private Sub frmDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_dgv()
    End Sub

    Private Sub refresh_dgv()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM user", strConn)

        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub txtUsernameD_TextChanged(sender As Object, e As EventArgs) Handles txtUsernameD.TextChanged

    End Sub
End Class

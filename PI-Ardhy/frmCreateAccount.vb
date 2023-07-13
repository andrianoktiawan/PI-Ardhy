Public Class frmCreateAccount
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim user, password, role As String

        user = txtUser.Text
        password = txtPassword.Text
        role = cmbRole.Text

        If isEmpty(user, password, role) = True Then
            MsgBox("Ada data yang masih kosong!")
        Else
            Dim hasil = execQuery($"INSERT INTO user(username, password, role) VALUES ('{user}', '{password}', '{role}');", strConn)
            If hasil = True Then
                MsgBox("Berhasil membuat account!")
            Else
                MsgBox("Username sudah tersedia")
                MsgBox("Gagal membuat account!")
            End If

            txtUser.Text = ""
            txtPassword.Text = ""
            cmbRole.Text = ""
        End If

    End Sub

    Function isEmpty(user As String, password As String, role As String) As Boolean
        If user = "" Or password = "" Or role = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub btnDeleteA_Click(sender As Object, e As EventArgs) Handles btnDeleteA.Click
        frmDelete.Show()
        Me.Close()

    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged

    End Sub
End Class
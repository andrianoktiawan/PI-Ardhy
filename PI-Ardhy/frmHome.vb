Public Class frmHome
    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Welocome Back " & username)

        lblUser.Text = username

        Dim regDate As Date = Date.Now()
        Dim strDate As String = regDate.ToString("dd-MM-yyyy")

        txtDate.Text = strDate
        txtRole.Text = getUserRole

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub txtDate_TextChanged(sender As Object, e As EventArgs) Handles txtDate.TextChanged

    End Sub
    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        Dim frm As New frmStock
        frm.Show()
    End Sub

    Private Sub btnCreateaccount_Click(sender As Object, e As EventArgs) Handles btnCreateaccount.Click
        Dim frm As New frmCreateAccount
        frm.Show()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Dim frm As New frmLaporan
        frm.Show()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click

    End Sub
End Class

Public Class frmHome
    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Welocome Back " & username)

        lblUser.Text = username

        Dim regDate As Date = Date.Now()
        Dim strDate As String = regDate.ToString("dd-MM-yyyy")

        txtDate.Text = strDate
        txtRole.Text = getUserRole

    End Sub

End Class
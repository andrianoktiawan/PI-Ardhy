Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strConn = getStrConn()

        testConn = execScalar($"SELECT username FROM user", strConn)

        If testConn <> "" Then
            MsgBox("Connection Success")
        Else
            MsgBox("Connection Failed")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim isUserValid As Boolean
        Dim password As String

        username = txtUsername.Text
        password = txtPassword.Text

        If username <> "" Or password <> "" Then
            getUserRole = execScalar($"SELECT role FROM user WHERE username = '{username}' and password = '{password}'", strConn)

            If getUserRole <> "" Then
                frmHome.Show()
                Me.Close()
                MsgBox("Welocome Back " & username)
            Else
                MsgBox("Username atau Password Salah!")
            End If
        Else
            MsgBox("Username & Password tidak boleh kosong!")
        End If


    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.PasswordChar = ""

        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
End Class

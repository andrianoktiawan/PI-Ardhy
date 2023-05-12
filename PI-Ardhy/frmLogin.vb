Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strConn = getStrConn()

        testConn = execScalar($"SELECT nama FROM SISWA WHERE ID = 3", strConn)

        If testConn <> "" Then
            MsgBox("Connection Success")
        Else
            MsgBox("Connection Failed")
        End If
    End Sub

End Class

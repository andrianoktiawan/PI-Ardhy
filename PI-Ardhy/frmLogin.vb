﻿Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strConn = getStrConn()

        testConn = execScalar($"SELECT username FROM user WHERE ID = 1", strConn)

        If testConn <> "" Then
            MsgBox("Connection Success")
        Else
            MsgBox("Connection Failed")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim isUserValid As Boolean
        Dim username, password, getUser As String

        username = txtUsername.Text
        password = txtPassword.Text

        If username <> "" Or password <> "" Then
            getUser = execScalar($"SELECT * FROM user WHERE username = '{username}' and password = '{password}'", strConn)

            If getUser <> "" Then
                frmHome.Show()
            Else
                MsgBox("Username atau Password Salah!")
            End If
        Else

            MsgBox("Username & Password tidak boleh kosong!")
        End If


    End Sub
End Class
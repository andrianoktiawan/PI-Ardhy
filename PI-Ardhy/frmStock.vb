﻿Public Class frmStock
    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim regDate As Date = Date.Now()
        Dim strDate As String = regDate.ToString("dd-MM-yyyy")

        txtbTanggal.Text = strDate
    End Sub

    Private Sub txtbTanggal_TextChanged(sender As Object, e As EventArgs) Handles txtbTanggal.TextChanged

    End Sub
End Class
Public Class frmLaporan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'query inner join untuk print laporan 

        'SELECT transaksi.transaksi_date, orders.id_transaksi, orders.nama_barang
        'From transaksi
        'INNER Join orders
        'On transaksi.id = orders.id_transaksi;
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        frmHome.Show()
        Me.Close()

    End Sub
End Class
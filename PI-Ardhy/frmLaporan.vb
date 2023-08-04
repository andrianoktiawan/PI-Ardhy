Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class frmLaporan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim getTglAwal = DateTimePicker1.Value
            Dim getTglAkhir = DateTimePicker2.Value

            Dim tglAwal = getTglAwal.ToString("yyyy-MM-dd")
            Dim tglAkhir = getTglAkhir.ToString("yyyy-MM-dd")

            If getTglAwal > getTglAkhir Then
                MsgBox("Tanggal Dari harus lebih kecil dari tanggal sampai!")
                Exit Sub
            End If

            Dim query_laporan = $"SELECT transaksi.transaksi_date, orders.id_transaksi, orders.nama_barang, orders.qty, orders.total_harga, transaksi.tunai, transaksi.kembalian, transaksi.kasir
                                From transaksi
                                INNER Join orders
                                On transaksi.id = orders.id_transaksi       
                            where transaksi.transaksi_date BETWEEN '{tglAwal}' AND '{tglAkhir} 23:59:59';"

            Dim total = execScalar($"SELECT SUM(laporan.total_harga) as Total 
                                    FROM
                                        (SELECT transaksi.transaksi_date, orders.id_transaksi, orders.nama_barang, orders.qty, orders.total_harga, transaksi.tunai, transaksi.kembalian, transaksi.kasir
                                            From transaksi
                                        INNER Join orders
                                        On transaksi.id = orders.id_transaksi       
                                        where transaksi.transaksi_date BETWEEN '{tglAwal}' AND '{tglAkhir} 23:59:59') as laporan;", strConn)

            '<------- start Tampilin Report Viewer
            Dim tbl As New DataTable
            Dim da As New MySqlDataAdapter(query_laporan, strConn)

            da.Fill(tbl)

            If tbl.Rows.Count > 0 And tbl IsNot DBNull.Value Then
                frmReportViewer.ReportViewer1.LocalReport.ReportPath = "../../Laporan.rdlc"
                frmReportViewer.ReportViewer1.LocalReport.DataSources.Clear()
                frmReportViewer.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("laporan_dataset", tbl))

                'Dim formattedTotal = String.Format("{0:C2}", replaceCurrencyTotal)
                'Dim formattedTunai As String = String.Format("{0:C2}", Double.Parse(txtTunai.Text))
                'Dim formattedKembalian As String = txtKembalian.Text

                Dim parameter(2) As ReportParameter
                parameter(0) = New ReportParameter("TGL_AWAL", getTglAwal.ToString("dd-MMM-yyyy"))
                parameter(1) = New ReportParameter("TGL_AKHIR", getTglAkhir.ToString("dd-MMM-yyyy"))
                parameter(2) = New ReportParameter("TOTAL", total)

                frmReportViewer.ReportViewer1.LocalReport.SetParameters(parameter)
                frmReportViewer.ReportViewer1.LocalReport.Refresh()
                frmReportViewer.ShowDialog()
            Else
                frmReportViewer.ReportViewer1.Reset()
                frmReportViewer.ReportViewer1.LocalReport.Refresh()
            End If
            'end Tampilin Report Viewer ------->


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


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
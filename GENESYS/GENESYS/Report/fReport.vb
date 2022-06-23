Public Class fReport

    Private Sub fReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.koneksi()
        reportJadwal()
    End Sub
    Sub reportJadwal()
        Try
            Dim da As New SqlClient.SqlDataAdapter("tampil_all", cnn)
            Dim dt As New DataTable
            da.Fill(dt)
            cnn.Close()

            Dim report As New crJadwal
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cnn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error cetak laporan")
        End Try
    End Sub
End Class
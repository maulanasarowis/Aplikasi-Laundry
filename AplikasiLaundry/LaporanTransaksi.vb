Public Class LaporanTransaksi
    Sub LAPORAN()
        Dim cryRpt As New Lap_Transaksi
        cryRpt.Load("D:\PROJECT VB 2008\AplikasiLaundry\AplikasiLaundry\Lap_Transaksi.rpt")
        CrystalReportViewer1.ReportSource = cryRpt


    End Sub
    Private Sub LaporanTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LAPORAN()
    End Sub
End Class
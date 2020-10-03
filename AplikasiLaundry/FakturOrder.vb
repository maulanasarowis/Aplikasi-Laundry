Public Class FakturOrder
    Sub LAPORAN()
        Dim cryRpt As New Fak_Order
        cryRpt.Load("D:\PROJECT VB 2008\AplikasiLaundry\AplikasiLaundry\Fak_Order.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
    End Sub
    Private Sub FakturOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LAPORAN()

    End Sub
End Class
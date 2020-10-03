Public Class Menu_Utama

    Private Sub ORDERPESANANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ORDERPESANANToolStripMenuItem.Click
        Order_Pesanan.Show()
    End Sub

    Private Sub TRANSAKSIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRANSAKSIToolStripMenuItem.Click
        Transaksi.Show()
    End Sub

    Private Sub PENGATURANPAKETToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENGATURANPAKETToolStripMenuItem.Click
        Paket.Show()
    End Sub
   
    Private Sub KELUARToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELUARToolStripMenuItem1.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub LAPORANTRANSAKSIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAPORANTRANSAKSIToolStripMenuItem.Click
        LaporanTransaksi.Show()
    End Sub
End Class
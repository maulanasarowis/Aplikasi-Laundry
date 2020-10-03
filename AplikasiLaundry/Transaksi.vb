Imports System.Data.Odbc
Public Class Transaksi
    Sub NOOTOMATIS()
        Dim notrans As String = "select count(*) as No_Transaksi from transaksi"
        Dim cmd = New OdbcCommand(notrans, conn)
        r = cmd.ExecuteReader

        While r.Read
            notrans = Val(r.Item("No_Transaksi").ToString) + 1
        End While

        Select Case Len(Trim(notrans))
            Case 1 : notransaksi.Text = "T0" & Trim(Str(notrans)) & Format(Now, "/ddMMyy/hhmm")
            Case 2 : notransaksi.Text = "T" & Trim(Str(notrans)) & Format(Now, "/ddMMyy/hhmm")
        End Select
        r.Close()
    End Sub
    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Dim hasil As Integer
        Try
            Dim simpan As String = "Insert into transaksi(No_Order,No_Transaksi,Bayar,Kembalian) values " & _
                                "('" & noorder.Text & "','" & notransaksi.Text & "','" & bayar.Text & "','" & kembali.Text & "')"
            Dim cmd = New OdbcCommand(simpan, conn)
            hasil = cmd.ExecuteNonQuery()
            If (hasil > 0) Then
                MessageBox.Show("Data berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TAMPIL()
                NOOTOMATIS()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        noorder.Text = ""
        tanggalorder.Text = ""
        nama.Text = ""
        totalharga.Text = ""
        bayar.Text = ""
        kembali.Text = ""
    End Sub

    Sub TAMPIL()
        Dim da As OdbcDataAdapter
        Dim ds As DataSet
        da = New OdbcDataAdapter("SELECT order_pesanan.No_Order,order_pesanan.Tanggal_Order,order_pesanan.Nama_Order," & _
                                 "order_pesanan.Total_Harga,transaksi.No_Transaksi,transaksi.Bayar,transaksi.Kembalian " & _
                                 "FROM order_pesanan INNER JOIN transaksi ON (order_pesanan.No_Order = transaksi.No_Order)", conn)
        ds = New DataSet
        da.Fill(ds, "transaksi")
        DataGridViewTransaksi.DataSource = ds.Tables("transaksi")
    End Sub

    Private Sub Transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ODBC_KONEK()
        TAMPIL()
        NOOTOMATIS()

    End Sub

    Private Sub DataGridViewTransaksi_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewTransaksi.CellContentClick
        Try
            Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridViewTransaksi.DataSource, DataGridViewTransaksi.DataMember), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)
            Dim dr As DataRow
            dr = dv.Item(cm.Position).Row
            noorder.Text = dr(0).ToString
            notransaksi.Text = dr(1).ToString
            bayar.Text = dr(2).ToString
            kembali.Text = dr(3).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub noorder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noorder.TextChanged
        CARI_ORDER()
    End Sub
    Sub CARI_ORDER()
        sql = "SELECT * FROM order_pesanan WHERE No_Order = '" & noorder.Text & "'"
        cmd = New OdbcCommand(sql, conn)
        r = cmd.ExecuteReader
        Try
            While r.Read
                tanggalorder.Text = r(1).ToString
                nama.Text = r(2).ToString
                totalharga.Text = r(9).ToString

            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub notransaksi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles notransaksi.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub ButtonBayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBayar.Click
        kembali.Text = bayar.Text - totalharga.Text
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        Menu_Utama.Show()
        Me.Hide()
    End Sub

    Private Sub tanggalorder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tanggalorder.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub nama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nama.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub totalharga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles totalharga.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub kembali_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles kembali.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub bayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles bayar.KeyPress
        If Strings.InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
            MsgBox("Masukkan Angka")
        End If
    End Sub
End Class
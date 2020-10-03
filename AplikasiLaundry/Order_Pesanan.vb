Imports System.Data.Odbc
Public Class Order_Pesanan
    Sub NOOTOMATIS()
        Dim orderurut As String = "select count(*) as No_Order from order_pesanan"
        Dim cmd = New OdbcCommand(orderurut, conn)
        r = cmd.ExecuteReader

        While r.Read
            orderurut = Val(r.Item("No_Order").ToString) + 1
        End While

        Select Case Len(Trim(orderurut))
            Case 1 : noorder.Text = "P0" & Trim(Str(orderurut)) & Format(Now, "/ddMMyyyy/hhmm")
            Case 2 : noorder.Text = "P" & Trim(Str(orderurut)) & Format(Now, "/ddMMyyyy/hhmm")
        End Select
        r.Close()
    End Sub

    Sub CNAMAPAKET()
        Dim paket As String = "select Nama_Paket from paket order by Nama_Paket"
        Dim cmd = New OdbcCommand(paket, conn)
        r = cmd.ExecuteReader

        While r.Read
            ComboNamaPaket.Items.Add(r("Nama_Paket"))
        End While
    End Sub
    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Dim hasil As Integer
        Try
            Dim simpan As String = "Insert into order_pesanan(No_Order,Tanggal_Order,Nama_Order,No_Telpon,Alamat_Order,Berat_Pakaian,Jumlah_Pakaian,Nama_Paket,Harga_Perkilo,Total_Harga) values " & _
                                "('" & noorder.Text & "','" & tanggalorder.Text & "','" & nama.Text & "','" & notelpon.Text & _
                                "','" & alamat.Text & "','" & beratpakaian.Text & "','" & jumlahpakaian.Text & _
                                "','" & ComboNamaPaket.Text & "','" & hargaperkilo.Text & "','" & totalharga.Text & "')"
            Dim cmd = New OdbcCommand(simpan, conn)
            hasil = cmd.ExecuteNonQuery()
            If (hasil > 0) Then
                MessageBox.Show("Data berhasil disimpan dan akan dicetak", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TAMPIL()
                NOOTOMATIS()
            End If
            nama.Text = ""
            notelpon.Text = ""
            alamat.Text = ""
            beratpakaian.Text = ""
            jumlahpakaian.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        FakturOrder.Show()
    End Sub

    Sub TAMPIL()
        Dim da As OdbcDataAdapter
        Dim ds As DataSet
        da = New OdbcDataAdapter("SELECT * from order_pesanan", conn)
        ds = New DataSet
        da.Fill(ds, "order_pesanan")
        DataGridViewOrderPesanan.DataSource = ds.Tables("order_pesanan")
    End Sub

    Private Sub DataGridViewOrderPesanan_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewOrderPesanan.CellContentClick
        Try
            Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridViewOrderPesanan.DataSource, DataGridViewOrderPesanan.DataMember), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)
            Dim dr As DataRow
            dr = dv.Item(cm.Position).Row
            noorder.Text = dr(0).ToString
            tanggalorder.Text = dr(1).ToString
            nama.Text = dr(2).ToString
            notelpon.Text = dr(3).ToString
            alamat.Text = dr(4).ToString
            beratpakaian.Text = dr(5).ToString
            jumlahpakaian.Text = dr(6).ToString
            totalharga.Text = dr(7).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Order_Pesanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ODBC_KONEK()
        TAMPIL()
        CNAMAPAKET()
        NOOTOMATIS()
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        Dim result = MessageBox.Show("Apakah anda yakin ingin menghapus data ini ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                Dim hapus As String = " delete from order_pesanan where No_Order = '" & noorder.Text & "'"
                Dim cmd = New OdbcCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("data berhasil dihapus", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TAMPIL()
                NOOTOMATIS()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        nama.Text = ""
        notelpon.Text = ""
        alamat.Text = ""
        beratpakaian.Text = ""
        jumlahpakaian.Text = ""
    End Sub

    Private Sub ComboNamaPaket_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboNamaPaket.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub ComboNamaPaket_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboNamaPaket.SelectedIndexChanged
        HARGAPAKET()
    End Sub
    Sub HARGAPAKET()
        sql = "SELECT * FROM paket WHERE Nama_Paket = '" & ComboNamaPaket.Text & "'"
        cmd = New OdbcCommand(sql, conn)
        r = cmd.ExecuteReader
        Try
            While r.Read
                hargaperkilo.Text = r(1).ToString

            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub noorder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles noorder.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        Menu_Utama.Show()
        Me.Hide()
    End Sub

    Private Sub hargaperkilo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles hargaperkilo.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub hargaperkilo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hargaperkilo.TextChanged
        totalharga.Text = hargaperkilo.Text * beratpakaian.Text
    End Sub

    Private Sub notelpon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles notelpon.KeyPress
        If Strings.InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
            MsgBox("Masukkan Angka")
        End If
    End Sub

    Private Sub beratpakaian_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles beratpakaian.KeyPress
        If Strings.InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
            MsgBox("Masukkan Angka")
        End If
    End Sub

    Private Sub jumlahpakaian_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles jumlahpakaian.KeyPress
        If Strings.InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
            MsgBox("Masukkan Angka")
        End If
    End Sub

    Private Sub totalharga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles totalharga.KeyPress
        e.KeyChar = Chr(0)
    End Sub
End Class
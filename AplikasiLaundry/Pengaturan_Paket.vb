Imports System.Data.Odbc
Public Class Paket

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Dim hasil As Integer
        Try
            Dim simpan As String = "Insert into paket(Nama_Paket,Harga_Perkilo) values " & _
                                "('" & namapaket.Text & "','" & hargaperkilo.Text & "')"
            Dim cmd = New OdbcCommand(simpan, conn)
            hasil = cmd.ExecuteNonQuery()
            If (hasil > 0) Then
                MessageBox.Show("data berhasil disimpan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TAMPIL()
            End If
            namapaket.Text = ""
            hargaperkilo.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub TAMPIL()
        Dim da As OdbcDataAdapter
        Dim ds As DataSet
        da = New OdbcDataAdapter("SELECT * from paket", conn)
        ds = New DataSet
        da.Fill(ds, "paket")
        DataGridViewPaket.DataSource = ds.Tables("paket")
    End Sub

    Private Sub DataGridViewPaket_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewPaket.CellContentClick
        Try
            Dim cm As CurrencyManager = CType(Me.BindingContext(DataGridViewPaket.DataSource, DataGridViewPaket.DataMember), CurrencyManager)
            Dim dv As DataView = CType(cm.List, DataView)
            Dim dr As DataRow
            dr = dv.Item(cm.Position).Row
            namapaket.Text = dr(0).ToString
            hargaperkilo.Text = dr(1).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Paket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ODBC_KONEK()
        TAMPIL()
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        Dim result = MessageBox.Show("Apakah anda yakin ingin menghapus data ini ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                Dim hapus As String = " delete from paket where Nama_Paket = '" & namapaket.Text & "'"
                Dim cmd = New OdbcCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("data berhasil dihapus", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TAMPIL()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        namapaket.Text = ""
        hargaperkilo.Text = ""
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        Dim result = MessageBox.Show("Apakah anda yakin ingin merubah data ini ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                sql = " update paket set Nama_Paket='" & namapaket.Text & "',Harga_Perkilo='" & hargaperkilo.Text & "'"
                cmd = New OdbcCommand(sql, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("data berhasil diubah", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TAMPIL()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        namapaket.Text = ""
        hargaperkilo.Text = ""
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        Menu_Utama.Show()
        Me.Hide()
    End Sub

    Private Sub hargaperkilo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles hargaperkilo.KeyPress
        If Strings.InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
            MsgBox("Masukkan Angka")
        End If
    End Sub
End Class

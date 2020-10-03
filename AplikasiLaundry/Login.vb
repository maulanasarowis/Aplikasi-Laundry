Public Class Login

   
    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        If username.Text = "kasir" And password.Text = "kasir" Then
            Menu_Utama.Show()
            Me.Hide()
            Menu_Utama.LaporanToolStripMenuItem.Enabled = True
        Else
            MsgBox("Username atau Password anda salah")
            username.Clear()
            password.Clear()
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        End
    End Sub
End Class
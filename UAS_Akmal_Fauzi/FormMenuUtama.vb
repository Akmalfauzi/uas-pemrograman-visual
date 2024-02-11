Public Class FormMenuUtama

    'Prosedur untuk menampilkan atau menyembunyikan menu
    Sub LockMenu()
        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False
        MasterToolStripMenuItem.Visible = False
    End Sub

    'Jika Form menu utama di load maka akan memanggil lockMenu
    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LockMenu()
    End Sub

    'Jika Menu Exit diklik maka akan muncul pilihan untuk keluar atau tidak
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Apakah Anda Yakin Ingin Keluar?", "Info", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    'Jika Menu Login diklik maka akan memunculkan form login
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.Show()
    End Sub

    'Jika Menu Master - Dokter diklik maka akan memunculkan form master dokter
    Private Sub DokterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DokterToolStripMenuItem.Click
        FormMasterDokter.Show()
    End Sub

    'Jika Menu Logout diklik maka akan memunculkan pilihan jika ya maka akan menampilkan form login
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Apakah Anda Yakin Ingin Logout?", "Info", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            LogoutToolStripMenuItem.Visible = False
            MasterToolStripMenuItem.Visible = False
            LoginToolStripMenuItem.Visible = True
            FormLogin.Show()
        End If
    End Sub
End Class

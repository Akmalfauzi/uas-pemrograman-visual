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

    'Jika Menu Exit diklik maka akan mengakhiri program
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    'Jika Menu Login diklik maka akan memunculkan form login
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.Show()
    End Sub
End Class

Imports System.Data.Odbc
Public Class FormLogin

    'Prosedure untuk menampilkan atau menyembunyikan menu di form menu utama
    Sub OpenMenu()
        FormMenuUtama.LoginToolStripMenuItem.Visible = False
        FormMenuUtama.LogoutToolStripMenuItem.Visible = True
        FormMenuUtama.MasterToolStripMenuItem.Visible = True
    End Sub

    'Fungsi untuk mengecek textbox username dan password apakah kosong atau tidak
    'Jika textbox username dan password kosong atau belum diisi maka akan mengembalikan nilai False
    'Jika textbox username dan password tidak kosong atau sudah diisi maka akan mengembalikan nilai True
    Function ValidateLogin()
        If TxtUsername_Akmal.Text = "" Or TxtPassword_Akmal.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    'Prosedure untuk melakukan proses login
    Sub ProcessLogin()
        'Validasi jika username atau password tidak diisi maka akan muncul messageBox dengan text "Silahkan isi Username dan Password"
        If ValidateLogin() = False Then
            MessageBox.Show("Silahkan isi Username dan Password!")
        Else
            'Jika Validasi sudah sesuai, maka akan melakukan proses memanggil koneksi ke database
            'Kemudian Jika sudah berhasil terkoneksi dengan database, 
            'maka akan melakukan proses mengambil data dari database dengan nama table tbl_user berdasarkan username dan password yang telah diinput dan divalidasi
            Call Koneksi()
            Dim Login As String = "SELECT * FROM tbl_user WHERE username='" & TxtUsername_Akmal.Text & "' AND password='" & TxtPassword_Akmal.Text & "'"
            Cmd = New OdbcCommand(Login, Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            'Jika data tidak ditemukan maka akan memunculkan messageBox dengan text "Username atau Password Salah"
            If Not Rd.HasRows Then
                MessageBox.Show("Username atau Password Salah!")
            Else
                'Jika data berhasil ditemukan dari database maka akan memunculkan messageBox dengan text "Login Berhasil"
                'Kemudian akan menutup form login
                'dan juga akan memanggil fungsi OpenMenu
                MessageBox.Show("Login Berhasil!")
                Me.Close()
                Call OpenMenu()
            End If
        End If
    End Sub

    'Prosedur untuk menampilkan atau menyembunyikan value dari textbox password
    Private Sub CheckBoxShowPassword_Akmal_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword_Akmal.CheckedChanged
        If CheckBoxShowPassword_Akmal.Checked = True Then
            TxtPassword_Akmal.UseSystemPasswordChar = False
        Else
            TxtPassword_Akmal.UseSystemPasswordChar = True
        End If
    End Sub

    'Jika button login di klik maka akan memanggil proccessLogin
    Private Sub ButtonLogin_Akmal_Click(sender As Object, e As EventArgs) Handles ButtonLogin_Akmal.Click
        Call ProcessLogin()
    End Sub
End Class
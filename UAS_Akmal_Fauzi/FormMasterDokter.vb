Imports System.Data.Odbc
Public Class FormMasterDokter

    Sub FirstCondition()
        Call GetDataDokter()
        Call SetAutoNumberIDDokter()
    End Sub

    'Mendapatkan Semua data dokter dari tbl_dokter
    Sub GetDataDokter()
        'Memanggil koneksi ke database
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tbl_dokter", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Dokter")
        DataGridView_Akmal.DataSource = (Ds.Tables("Dokter"))
        'Menambahkan Alias Header Text di GridView
        DataGridView_Akmal.Columns(0).HeaderText = "ID"
        DataGridView_Akmal.Columns(1).HeaderText = "Nama"
        DataGridView_Akmal.Columns(2).HeaderText = "Tanggal Lahir"
        DataGridView_Akmal.Columns(3).HeaderText = "Alamat"
        DataGridView_Akmal.Columns(4).HeaderText = "Nomor Telepon"
        DataGridView_Akmal.Columns(5).HeaderText = "Jenis Kelamin"

    End Sub

    Sub GetDataDokterByID()
        Call Koneksi()
        Cmd = New OdbcCommand("SELECT * FROM tbl_dokter WHERE id = '" & TxtIDDokter_Akmal.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then

            If Rd.Item("jenis_kelamin") = "Laki-Laki" Then
                RadioButtonLakiLaki_Akmal.Checked = True
            Else
                RadioButtonPerempuan_Akmal.Checked = True
            End If

            TxtIDDokter_Akmal.Text = Rd.Item("id")
            TxtNama_Akmal.Text = Rd.Item("nama")
            TxtAlamat_Akmal.Text = Rd.Item("alamat")
            MaskedTxtNoTelepon_Akmal.Text = Rd.Item("no_telepon")
            DateTimePicker_Akmal.Text = Rd.Item("tanggal_lahir")
        Else
            MessageBox.Show("Data Tidak Ada")
        End If
    End Sub

    Sub SearchDokter()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tbl_dokter WHERE id = '" & TxtCari_Akmal.Text & "' OR nama = '" & TxtCari_Akmal.Text & "' OR no_telepon = '" & TxtCari_Akmal.Text & "' OR alamat = '" & TxtCari_Akmal.Text & "' ", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Dokter")
        DataGridView_Akmal.DataSource = (Ds.Tables("Dokter"))
        'Menambahkan Alias Header Text di GridView
        DataGridView_Akmal.Columns(0).HeaderText = "ID"
        DataGridView_Akmal.Columns(1).HeaderText = "Nama"
        DataGridView_Akmal.Columns(2).HeaderText = "Tanggal Lahir"
        DataGridView_Akmal.Columns(3).HeaderText = "Alamat"
        DataGridView_Akmal.Columns(4).HeaderText = "Nomor Telepon"
        DataGridView_Akmal.Columns(5).HeaderText = "Jenis Kelamin"
    End Sub

    Private Sub ButtonShowForm_Akmal_Click(sender As Object, e As EventArgs) Handles ButtonShowForm_Akmal.Click
        ButtonShowForm_Akmal.Visible = False
        PanelFormDokter_Akmal.Visible = True
        DataGridView_Akmal.Width = 418
    End Sub

    Private Sub ButtonHideForm_Akmal_Click(sender As Object, e As EventArgs) Handles ButtonHideForm_Akmal.Click
        ButtonShowForm_Akmal.Visible = True
        PanelFormDokter_Akmal.Visible = False
        DataGridView_Akmal.Width = 863
    End Sub

    Sub SetAutoNumberIDDokter()

        Call Koneksi()

        Dim tahun As String
        tahun = Format(Now, "yyyy")

        Cmd = New OdbcCommand("SELECT * FROM tbl_dokter where id in(select max(id) from tbl_dokter) order by id desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Rd.HasRows = 0 Then
            TxtIDDokter_Akmal.Text = "DR-" & tahun & "000001"
        End If

        If Not Rd.HasRows Then
            TxtIDDokter_Akmal.Text = "DR-" & tahun & "000001"
            Rd.Close()
        Else

            TxtIDDokter_Akmal.Text = Val(Microsoft.VisualBasic.Mid(Rd.Item("ID").ToString, 9, 6)) + 1

            If Len(TxtIDDokter_Akmal.Text) = 1 Then
                TxtIDDokter_Akmal.Text = "DR-" & tahun & "00000" & TxtIDDokter_Akmal.Text
            ElseIf Len(TxtIDDokter_Akmal.Text) = 2 Then
                TxtIDDokter_Akmal.Text = "DR-" & tahun & "0000" & TxtIDDokter_Akmal.Text
            ElseIf Len(TxtIDDokter_Akmal.Text) = 3 Then
                TxtIDDokter_Akmal.Text = "DR-" & tahun & "000" & TxtIDDokter_Akmal.Text
            ElseIf Len(TxtIDDokter_Akmal.Text) = 4 Then
                TxtIDDokter_Akmal.Text = "DR-" & tahun & "00" & TxtIDDokter_Akmal.Text
            ElseIf Len(TxtIDDokter_Akmal.Text) = 5 Then
                TxtIDDokter_Akmal.Text = "DR-" & tahun & "0" & TxtIDDokter_Akmal.Text
            End If
            Rd.Close()

        End If

    End Sub

    Private Sub FormMasterDokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView_Akmal.Width = 863

        Call FirstCondition()
    End Sub

    Sub ClearForm()
        TxtNama_Akmal.Text = ""
        DateTimePicker_Akmal.Text = ""
        RadioButtonLakiLaki_Akmal.Checked = False
        RadioButtonPerempuan_Akmal.Checked = False
        TxtAlamat_Akmal.Text = ""
        MaskedTxtNoTelepon_Akmal.Text = ""
        DateTimePicker_Akmal.Value = Now
        DateTimePicker_Akmal.Format = DateTimePickerFormat.Custom
        DateTimePicker_Akmal.CustomFormat = "yyyy-MM-dd"
    End Sub

    Function ValidateForm()
        If TxtIDDokter_Akmal.Text = "" Or TxtNama_Akmal.Text = "" Or DateTimePicker_Akmal.Text = "" Or (MaskedTxtNoTelepon_Akmal.Text = "" Or MaskedTxtNoTelepon_Akmal.Text = "62") Or (RadioButtonLakiLaki_Akmal.Checked = False And RadioButtonPerempuan_Akmal.Checked = False) Or TxtAlamat_Akmal.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ButtonSave_Akmal_Click(sender As Object, e As EventArgs) Handles ButtonSave_Akmal.Click
        If ValidateForm() = False Then
            MessageBox.Show("Pastikan Semua Field diisi! ")
        Else
            Try
                Call Koneksi()

                Dim JenisKelamin As String
                If RadioButtonLakiLaki_Akmal.Checked Then
                    JenisKelamin = "Laki-Laki"
                Else
                    JenisKelamin = "Perempuan"
                End If

                Dim TanggalLahir
                DateTimePicker_Akmal.Format = DateTimePickerFormat.Custom
                DateTimePicker_Akmal.CustomFormat = "yyyy-MM-dd"
                TanggalLahir = DateTimePicker_Akmal.Text

                Dim InputData As String = "INSERT INTO tbl_dokter VALUES ('" & TxtIDDokter_Akmal.Text & "', '" & TxtNama_Akmal.Text & "', '" & TanggalLahir & "', '" & TxtAlamat_Akmal.Text & "', '" & MaskedTxtNoTelepon_Akmal.Text & "', '" & JenisKelamin & "' )"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()

                MessageBox.Show("Input Data Berhasil")

                Call ClearForm()
                Call FirstCondition()

            Catch ex As Exception
                MessageBox.Show("Input Data Gagal!")
            End Try
        End If
    End Sub

    Private Sub TxtIDDokter_Akmal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIDDokter_Akmal.KeyPress
        If e.KeyChar = Chr(13) Then
            Call GetDataDokterByID()
        End If
    End Sub

    Private Sub ButtonEdit_Akmal_Click(sender As Object, e As EventArgs) Handles ButtonEdit_Akmal.Click
        If ValidateForm() = False Then
            MessageBox.Show("Pastikan Semua Field diisi! ")
        Else

            If MessageBox.Show("Apakah Anda Yakin ingin mengupdate data ?", "Peringatan", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    Dim JenisKelamin As String
                    If RadioButtonLakiLaki_Akmal.Checked Then
                        JenisKelamin = "Laki-Laki"
                    Else
                        JenisKelamin = "Perempuan"
                    End If

                    Dim TanggalLahir
                    DateTimePicker_Akmal.Format = DateTimePickerFormat.Custom
                    DateTimePicker_Akmal.CustomFormat = "yyyy-MM-dd"
                    TanggalLahir = DateTimePicker_Akmal.Text

                    Dim EditData As String = "UPDATE tbl_dokter SET id='" & TxtIDDokter_Akmal.Text & "', nama='" & TxtNama_Akmal.Text & "', jenis_kelamin='" & JenisKelamin & "', alamat='" & TxtAlamat_Akmal.Text & "', no_telepon='" & MaskedTxtNoTelepon_Akmal.Text & "', tanggal_lahir='" & TanggalLahir & "' WHERE id='" & TxtIDDokter_Akmal.Text & "' "
                    Cmd = New OdbcCommand(EditData, Conn)
                    Cmd.ExecuteNonQuery()
                    MessageBox.Show("Edit Data Berhasil")

                    Call ClearForm()
                    Call FirstCondition()

                Catch ex As Exception
                    MessageBox.Show("Edit Data Gagal!")
                End Try
            End If

        End If
    End Sub

    Private Sub ButtonDeleteAkmal_Click(sender As Object, e As EventArgs) Handles ButtonDelete_Akmal.Click
        If ValidateForm() = False Then
            MessageBox.Show("Pastikan Semua Field diisi! ")
        Else
            If MessageBox.Show("Apakah Anda Yakin ingin menghapus data ?", "Peringatan", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    Call Koneksi()

                    Dim HapusData As String = "DELETE FROM tbl_dokter WHERE id='" & TxtIDDokter_Akmal.Text & "' "
                    Cmd = New OdbcCommand(HapusData, Conn)
                    Cmd.ExecuteNonQuery()
                    MessageBox.Show("Hapus Data Berhasil")

                    Call ClearForm()
                    Call FirstCondition()

                Catch ex As Exception
                    MessageBox.Show("Delete Data Gagal!")
                End Try
            End If
        End If
    End Sub

    Private Sub ButtonCari_Akmal_Click(sender As Object, e As EventArgs) Handles ButtonCari_Akmal.Click
        If TxtCari_Akmal.Text = "" Then
            MessageBox.Show("Field Cari Harus diisi!")
        Else
            Call SearchDokter()
        End If
    End Sub

    Private Sub ButtonResetCari_Akmal_Click(sender As Object, e As EventArgs) Handles ButtonResetCari_Akmal.Click
        TxtCari_Akmal.Text = ""
        Call GetDataDokter()
    End Sub
End Class
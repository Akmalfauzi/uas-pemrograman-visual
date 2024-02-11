Imports System.Data.Odbc
Module ModuleKoneksiDatabase
    'Deklarasi Variable secara publik agar bisa dipanggil di manapun
    Public Conn As OdbcConnection
    Public Cmd As OdbcCommand
    Public Rd As OdbcDataReader
    Public Da As OdbcDataAdapter
    Public Ds As New DataSet
    Public str As String

    'Prosedur untuk koneksi ke database dengan menggunakan metode dsn dan juga try catch
    'Jika berhasil terkoneksi dengan database, maka program akan terus dilanjutkan
    'Jika gagal terkoneksi dengan database, maka akan memunculkan messageBox dengan text "Database tidak terkoneksi"
    Public Sub Koneksi()
        Try
            str = "DSN=dsn_dokter"
            Conn = New OdbcConnection(str)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Database tidak terkoneksi", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module

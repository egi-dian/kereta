Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class beli
    Sub kosongkan()
        Textnama.Clear()
        Textalamat.Clear()
        Textnohp.Clear()
        Textnik.Clear()
        ComboBoxkrt.Text = ""
        ComboBoxrute.Text = ""
        ComboBoxkls.Text = ""

    End Sub
    Sub kereta()
        Call koneksi()
        Dim DA As New SqlDataAdapter("select * from kereta", CONN)
        Dim DS As New DataSet()
        DA.Fill(DS, "kereta")
        Dim dt As DataTable = DS.Tables("kereta")

        ComboBoxkrt.Items.Clear()
        For Each row As DataRow In dt.Rows
            ComboBoxkrt.Items.Add(row("nama_kereta").ToString())
        Next

        CONN.Close()
    End Sub

    Sub rute()
        Call koneksi()
        Dim DA As New SqlDataAdapter("select * from tujuan1", CONN)
        Dim DS As New DataSet()
        DA.Fill(DS, "tujuan1")
        Dim dt As DataTable = DS.Tables("tujuan1")

        ComboBoxrute.Items.Clear()
        For Each row As DataRow In dt.Rows
            ComboBoxrute.Items.Add(row("rute").ToString())
        Next

        CONN.Close()
    End Sub

    Sub datagrid()
        Call koneksi()
        DA = New SqlDataAdapter("SELECT *
        FROM pembeli1
        INNER JOIN kereta1 ON kereta1.id_kereta = pembeli1.id_pembeli
        INNER JOIN tujuan1 ON tujuan1.id_rute = pembeli1.id_pembeli", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Sub kondisiawal()
        Call datagrid()
        Call kosongkan()

    End Sub

    Sub kondisi2()
        Call datagrid()

    End Sub

    Sub cari_kode()
        Call koneksi()
        CMD = New SqlCommand("Select * from pembeli1 where nama ='" & Textnama.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()

    End Sub

    Sub cari_kode3()
        Call koneksi()
        CMD = New SqlCommand("Select harga2 from kereta ='" & Textnama.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()

    End Sub


    Private Sub beli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()




    End Sub

    Private Sub Buttonsimpan_Click(sender As Object, e As EventArgs) Handles Buttonsimpan.Click

        Try
            ' Membuat koneksi ke database
            Call koneksi()

            ' Perintah SQL pertama
            Dim simpan As String = "INSERT INTO pembeli1 (nama, alamat, no_hp, nik) VALUES (@nama, @alamat, @nohp, @nik)"
            Dim CMD1 As New SqlCommand(simpan, CONN)

            CMD1.Parameters.AddWithValue("@nama", Textnama.Text)
            CMD1.Parameters.AddWithValue("@alamat", Textalamat.Text)
            CMD1.Parameters.AddWithValue("@nohp", Textnohp.Text)
            CMD1.Parameters.AddWithValue("@nik", Textnik.Text)

            CMD1.ExecuteNonQuery()

            Dim simpanpilihan As String = "INSERT INTO kereta1 (nama_kereta, kelas) VALUES (@nama_kereta, @kelas)"
            Dim CMD3 As New SqlCommand(simpanpilihan, CONN)

            CMD3.Parameters.AddWithValue("@nama_kereta", ComboBoxkrt.Text)
            CMD3.Parameters.AddWithValue("@kelas", ComboBoxkls.Text)

            CMD3.ExecuteNonQuery()


            Dim simpanpilihan1 As String = "INSERT INTO tujuan1 (rute) VALUES (@rute)"
            Dim CMD2 As New SqlCommand(simpanpilihan1, CONN)

            CMD2.Parameters.AddWithValue("@rute", ComboBoxrute.Text)

            CMD2.ExecuteNonQuery()



            ' Perintah SQL kedua




            MessageBox.Show("Data berhasil disimpan ke database.")
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try


    End Sub
    Private Sub Btnbaru_Click(sender As Object, e As EventArgs) Handles Btnbaru.Click
        Call kondisiawal()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call kondisiawal()


    End Sub

    Private Sub ComboBoxkrt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxkrt.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxrute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxrute.SelectedIndexChanged

    End Sub

    Private Sub Buttonhps_Click(sender As Object, e As EventArgs) Handles Buttonhps.Click
        ' Pastikan ada koneksi terbuka ke database sebelum melakukan penghapusan data
        Call koneksi()

        ' Query SQL untuk menghapus data pembeli berdasarkan nama
        Dim query As String = "DELETE FROM pembeli1 WHERE nama = @nama"
        CMD = New SqlCommand(query, CONN)

        ' Menambahkan parameter nama
        CMD.Parameters.AddWithValue("@nama", Textnama.Text)

        ' Menjalankan perintah DELETE
        CMD.ExecuteNonQuery()

        ' Lakukan sesuatu setelah data dihapus, misalnya memberikan notifikasi atau melakukan refresh tampilan data
        ' Contoh memberikan notifikasi bahwa data telah dihapus
        MessageBox.Show("Data telah dihapus.")

        ' Setelah penghapusan data, mungkin kamu ingin membersihkan teks di Textnama
        Textnama.Text = ""

    End Sub

    Private Sub Buttonli_Click(sender As Object, e As EventArgs) Handles Buttonli.Click
        Me.Hide()

        ' Tampilkan Form2
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub Buttonljt_Click(sender As Object, e As EventArgs) Handles Buttonljt.Click
        Me.Hide()

        ' Tampilkan Form2
        Dim pesanan As New pesanan()
        pesanan.Show()
    End Sub


End Class
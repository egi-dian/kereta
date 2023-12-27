Imports System.Data.SqlClient






Public Class pesanan

    Sub data5()
        Call koneksi()
        DA = New SqlDataAdapter("SELECT nama,alamat,no_hp,nik FROM pembeli1 ", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView5.DataSource = DS.Tables(0)
        DataGridView5.ReadOnly = True

    End Sub

    Sub kondisiawal1()

        Call data5()
    End Sub
    Private Sub data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal1()


    End Sub
    Private Sub Buttoncek_Click(sender As Object, e As EventArgs) Handles Buttoncek.Click

        Try
            Call koneksi()

            ' Ganti 'NamaYangDicari' dengan nama yang ingin Anda cari
            Dim namaYangDicari As String = TextBoxnm.Text.Trim()

            Dim query As String = "SELECT nama, alamat, no_hp, nik FROM pembeli1 WHERE nama LIKE @nama"
            Dim DA As New SqlDataAdapter(query, CONN)
            DA.SelectCommand.Parameters.AddWithValue("@nama", "%" & namaYangDicari & "%")

            Dim DS As New DataSet
            DA.Fill(DS)

            DataGridView5.DataSource = DS.Tables(0)
            DataGridView5.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxnm.TextChanged

    End Sub

    Private Sub Buttonhpus_Click(sender As Object, e As EventArgs) Handles Buttonhpus.Click
        ' Pastikan ada koneksi terbuka ke database sebelum melakukan penghapusan data
        Call koneksi()

        ' Query SQL untuk menghapus data pembeli berdasarkan nama
        Dim query As String = "DELETE FROM pembeli1 WHERE nama = @nama"
        CMD = New SqlCommand(query, CONN)

        ' Menambahkan parameter nama
        CMD.Parameters.AddWithValue("@nama", TextBoxnm.Text)

        ' Menjalankan perintah DELETE
        CMD.ExecuteNonQuery()

        ' Lakukan sesuatu setelah data dihapus, misalnya memberikan notifikasi atau melakukan refresh tampilan data
        ' Contoh memberikan notifikasi bahwa data telah dihapus
        MessageBox.Show("Data telah dihapus.")

        ' Setelah penghapusan data, mungkin kamu ingin membersihkan teks di Textnama
        TextBoxnm.Text = ""


    End Sub

    Private Sub Buttonkmba_Click(sender As Object, e As EventArgs) Handles Buttonkmba.Click
        ' Tampilkan Form2
        Me.Hide()
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        Call data5()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim pembayaran As New pembayaran()
        pembayaran.Show()
    End Sub
End Class
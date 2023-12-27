Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient


Public Class pembayaran

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttonqr.Click


        Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        Try
            PictureBox1.Image = qrcode.Encode(ComboBoxgn.Text)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Try
            Call koneksi()

            ' Ganti 'NamaYangDicari' dengan nama yang ingin Anda cari
            Dim namaYangDicari As String = ComboBoxgn.Text.Trim()

            Dim query As String = "SELECT nama, alamat, no_hp, nik FROM pembeli1 WHERE nama LIKE @nama"
            Dim DA As New SqlDataAdapter(query, CONN)
            DA.SelectCommand.Parameters.AddWithValue("@nama", "%" & namaYangDicari & "%")

            Dim DS As New DataSet
            DA.Fill(DS)

            If DS.Tables(0).Rows.Count > 0 Then
                ' Menampilkan data dari database di PictureBox1
                Dim nama As String = DS.Tables(0).Rows(0)("nama").ToString()
                Dim alamat As String = DS.Tables(0).Rows(0)("alamat").ToString()
                Dim no_hp As String = DS.Tables(0).Rows(0)("no_hp").ToString()
                Dim nik As String = DS.Tables(0).Rows(0)("nik").ToString()

                ' Menggabungkan data menjadi satu teks untuk ditampilkan
                Dim Pembeli1 As String = $"Nama: {nama}{Environment.NewLine}Alamat: {alamat}{Environment.NewLine}No HP: {no_hp}{Environment.NewLine}NIK: {nik}"

                ' Menghasilkan QR Code dari data pembeli
                Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
                PictureBox1.Image = qrcode.Encode(Pembeli1)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                MsgBox("Data tidak ditemukan")
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub
    Sub data9()
        Call koneksi()
        Dim DA As New SqlDataAdapter("select * from pembeli1", CONN)
        Dim DS As New DataSet()
        DA.Fill(DS, "pembeli1")
        Dim dt As DataTable = DS.Tables("pembeli1")

        For Each row As DataRow In dt.Rows
            Dim dataPembeli As String = $"{row("nama")}, {row("alamat")}, {row("no_hp")}, {row("nik")}"

            ComboBoxgn.Items.Add(dataPembeli)
        Next

        CONN.Close()
    End Sub
    Private Sub pembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call data9()

    End Sub

    Private Sub Button1sls_Click(sender As Object, e As EventArgs) Handles Button1sls.Click
        Me.Hide()
        Dim form1 As New Form1()
        form1.Show()

    End Sub
End Class

Imports Microsoft.VisualBasic.Logging

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnadmin_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        Me.Hide()

        ' Tampilkan Form2
        Dim admin As New admin()
        admin.Show()
    End Sub

    Private Sub btnbeli_Click(sender As Object, e As EventArgs) Handles btnbeli.Click
        Me.Hide()

        ' Tampilkan Form2
        Dim beli As New beli()
        beli.Show()
    End Sub

    Private Sub btnpsn_Click(sender As Object, e As EventArgs) Handles btnpsn.Click
        Me.Hide()

        ' Tampilkan Form2
        Dim pesanan As New pesanan()
        pesanan.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Dim result As DialogResult = MessageBox.Show("Apakah kamu yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Memeriksa pilihan pengguna
        If result = DialogResult.Yes Then
            ' Menutup aplikasi jika pengguna memilih 'Yes'
            Me.Close()
        Else
            ' Lakukan sesuatu jika pengguna memilih 'No'
            ' Misalnya, tidak melakukan apa-apa atau mengatur kembali fokus ke aplikasi
        End If
    End Sub
End Class

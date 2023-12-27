Public Class admin
    Private Sub Buttonlogin_Click(sender As Object, e As EventArgs) Handles Buttonlogin.Click
        Dim username As String = TextBoxusn.Text
        Dim password As String = TextBoxpass.Text

        ' Cek kredensial (Contoh sederhana, sebaiknya gunakan database atau cara penyimpanan yang aman)
        If username = "admin" AndAlso password = "sandi" Then
            MessageBox.Show("Login berhasil!")
            ' Jika login berhasil, buka Form lain atau lakukan tindakan lainnya
            Dim data As New data() ' Ganti dengan nama Form utama setelah login
            data.Show()
            Me.Hide() ' Sembunyikan Form login
        Else
            MessageBox.Show("Login gagal. Coba lagi.")
            ' Kosongkan TextBox atau lakukan sesuatu untuk memberi kesempatan mencoba login kembali
            TextBoxusn.Text = ""
            TextBoxpass.Text = ""
            TextBoxusn.Focus() ' Fokuskan kursor ke TextBox username
        End If


    End Sub


    Private Sub Buttonkmb_Click(sender As Object, e As EventArgs) Handles Buttonkmb.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' Jika checkbox "Tampilkan Password" dicentang, tampilkan teks biasa
            TextBoxpass.PasswordChar = ControlChars.NullChar ' Menghilangkan karakter pengganti
        Else
            ' Jika checkbox "Tampilkan Password" tidak dicentang, sembunyikan karakter dengan karakter pengganti seperti '*'
            TextBoxpass.PasswordChar = "*"c ' Karakter pengganti, bisa berupa '*' atau karakter lainnya
        End If
    End Sub
End Class
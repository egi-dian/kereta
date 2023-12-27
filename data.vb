Imports System.Data.SqlClient
Public Class data


    Sub data()
        Call koneksi()
        DA = New SqlDataAdapter("SELECT *
        FROM pembeli1
        INNER JOIN kereta1 ON kereta1.id_kereta = pembeli1.id_pembeli
        INNER JOIN tujuan1 ON tujuan1.id_rute = pembeli1.id_pembeli", CONN)
        DS = New DataSet
        DA.Fill(DS)
        Data3.DataSource = DS.Tables(0)
        Data3.ReadOnly = True
    End Sub

    Sub kondisiawal1()
        Call data()
    End Sub
    Private Sub data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal1()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ' Tampilkan Form2
        Dim form1 As New Form1()
        form1.Show()
    End Sub
End Class
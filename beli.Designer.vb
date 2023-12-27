<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class beli
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(beli))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Textnama = New System.Windows.Forms.TextBox()
        Me.Textnik = New System.Windows.Forms.TextBox()
        Me.Textnohp = New System.Windows.Forms.TextBox()
        Me.Textalamat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxkrt = New System.Windows.Forms.ComboBox()
        Me.ComboBoxrute = New System.Windows.Forms.ComboBox()
        Me.Buttonsimpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btnbaru = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxkls = New System.Windows.Forms.ComboBox()
        Me.Buttonhps = New System.Windows.Forms.Button()
        Me.Buttonli = New System.Windows.Forms.Button()
        Me.Buttonljt = New System.Windows.Forms.Button()
        Me.DATATIKETDataSet = New tiketing3.DATATIKETDataSet()
        Me.Harga1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Harga1TableAdapter = New tiketing3.DATATIKETDataSetTableAdapters.harga1TableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATATIKETDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Harga1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(95, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ALAMAT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NIK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(95, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "NO HP"
        '
        'Textnama
        '
        Me.Textnama.Location = New System.Drawing.Point(180, 46)
        Me.Textnama.Name = "Textnama"
        Me.Textnama.Size = New System.Drawing.Size(147, 22)
        Me.Textnama.TabIndex = 5
        '
        'Textnik
        '
        Me.Textnik.Location = New System.Drawing.Point(180, 174)
        Me.Textnik.Name = "Textnik"
        Me.Textnik.Size = New System.Drawing.Size(147, 22)
        Me.Textnik.TabIndex = 8
        '
        'Textnohp
        '
        Me.Textnohp.Location = New System.Drawing.Point(180, 124)
        Me.Textnohp.Name = "Textnohp"
        Me.Textnohp.Size = New System.Drawing.Size(147, 22)
        Me.Textnohp.TabIndex = 9
        '
        'Textalamat
        '
        Me.Textalamat.Location = New System.Drawing.Point(180, 88)
        Me.Textalamat.Name = "Textalamat"
        Me.Textalamat.Size = New System.Drawing.Size(147, 22)
        Me.Textalamat.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(351, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "KERETA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(351, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "RUTE"
        '
        'ComboBoxkrt
        '
        Me.ComboBoxkrt.FormattingEnabled = True
        Me.ComboBoxkrt.Items.AddRange(New Object() {"KARTASURA EKSPRESS", "ARJUNA EXPRESS", "HOKAIDO", "AIR INDO"})
        Me.ComboBoxkrt.Location = New System.Drawing.Point(491, 47)
        Me.ComboBoxkrt.Name = "ComboBoxkrt"
        Me.ComboBoxkrt.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxkrt.TabIndex = 14
        '
        'ComboBoxrute
        '
        Me.ComboBoxrute.FormattingEnabled = True
        Me.ComboBoxrute.Items.AddRange(New Object() {"YOGYAKARTA-MADIUN", "YOGYAKARTA-SOLO", "YOGYAKARTA-JAKARTA", "YOGYAKARTA-KLATEN", "YOGYAKARTA-MALANG"})
        Me.ComboBoxrute.Location = New System.Drawing.Point(491, 88)
        Me.ComboBoxrute.Name = "ComboBoxrute"
        Me.ComboBoxrute.Size = New System.Drawing.Size(200, 24)
        Me.ComboBoxrute.TabIndex = 15
        '
        'Buttonsimpan
        '
        Me.Buttonsimpan.ForeColor = System.Drawing.Color.Black
        Me.Buttonsimpan.Location = New System.Drawing.Point(491, 238)
        Me.Buttonsimpan.Name = "Buttonsimpan"
        Me.Buttonsimpan.Size = New System.Drawing.Size(103, 26)
        Me.Buttonsimpan.TabIndex = 20
        Me.Buttonsimpan.Text = "SIMPAN"
        Me.Buttonsimpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 238)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(441, 200)
        Me.DataGridView1.TabIndex = 21
        '
        'Btnbaru
        '
        Me.Btnbaru.Location = New System.Drawing.Point(744, 238)
        Me.Btnbaru.Name = "Btnbaru"
        Me.Btnbaru.Size = New System.Drawing.Size(117, 26)
        Me.Btnbaru.TabIndex = 22
        Me.Btnbaru.Text = "DATA BARU"
        Me.Btnbaru.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(351, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "KELAS"
        '
        'ComboBoxkls
        '
        Me.ComboBoxkls.FormattingEnabled = True
        Me.ComboBoxkls.Items.AddRange(New Object() {"BISNIS", "EKONOMI"})
        Me.ComboBoxkls.Location = New System.Drawing.Point(491, 130)
        Me.ComboBoxkls.Name = "ComboBoxkls"
        Me.ComboBoxkls.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxkls.TabIndex = 26
        '
        'Buttonhps
        '
        Me.Buttonhps.ForeColor = System.Drawing.Color.Black
        Me.Buttonhps.Location = New System.Drawing.Point(613, 238)
        Me.Buttonhps.Name = "Buttonhps"
        Me.Buttonhps.Size = New System.Drawing.Size(100, 26)
        Me.Buttonhps.TabIndex = 27
        Me.Buttonhps.Text = "HAPUS"
        Me.Buttonhps.UseVisualStyleBackColor = True
        '
        'Buttonli
        '
        Me.Buttonli.ForeColor = System.Drawing.Color.Black
        Me.Buttonli.Location = New System.Drawing.Point(491, 403)
        Me.Buttonli.Name = "Buttonli"
        Me.Buttonli.Size = New System.Drawing.Size(103, 26)
        Me.Buttonli.TabIndex = 28
        Me.Buttonli.Text = "KEMBALI"
        Me.Buttonli.UseVisualStyleBackColor = True
        '
        'Buttonljt
        '
        Me.Buttonljt.ForeColor = System.Drawing.Color.Black
        Me.Buttonljt.Location = New System.Drawing.Point(758, 403)
        Me.Buttonljt.Name = "Buttonljt"
        Me.Buttonljt.Size = New System.Drawing.Size(103, 26)
        Me.Buttonljt.TabIndex = 29
        Me.Buttonljt.Text = "LANJUT"
        Me.Buttonljt.UseVisualStyleBackColor = True
        '
        'DATATIKETDataSet
        '
        Me.DATATIKETDataSet.DataSetName = "DATATIKETDataSet"
        Me.DATATIKETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Harga1BindingSource
        '
        Me.Harga1BindingSource.DataMember = "harga1"
        Me.Harga1BindingSource.DataSource = Me.DATATIKETDataSet
        '
        'Harga1TableAdapter
        '
        Me.Harga1TableAdapter.ClearBeforeFill = True
        '
        'beli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImage = Global.tiketing3.My.Resources.Resources._854_8541242_1366_x_768_31_background_orange_vector_png
        Me.ClientSize = New System.Drawing.Size(873, 450)
        Me.Controls.Add(Me.Buttonljt)
        Me.Controls.Add(Me.Buttonli)
        Me.Controls.Add(Me.Buttonhps)
        Me.Controls.Add(Me.ComboBoxkls)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btnbaru)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Buttonsimpan)
        Me.Controls.Add(Me.ComboBoxrute)
        Me.Controls.Add(Me.ComboBoxkrt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Textalamat)
        Me.Controls.Add(Me.Textnohp)
        Me.Controls.Add(Me.Textnik)
        Me.Controls.Add(Me.Textnama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "beli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "beli"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATATIKETDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Harga1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Textnama As TextBox
    Friend WithEvents Textnik As TextBox
    Friend WithEvents Textnohp As TextBox
    Friend WithEvents Textalamat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxkrt As ComboBox
    Friend WithEvents ComboBoxrute As ComboBox
    Friend WithEvents Buttonsimpan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btnbaru As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBoxkls As ComboBox
    Friend WithEvents Buttonhps As Button
    Friend WithEvents Buttonli As Button
    Friend WithEvents Buttonljt As Button
    Friend WithEvents DATATIKETDataSet As DATATIKETDataSet
    Friend WithEvents Harga1BindingSource As BindingSource
    Friend WithEvents Harga1TableAdapter As DATATIKETDataSetTableAdapters.harga1TableAdapter
End Class

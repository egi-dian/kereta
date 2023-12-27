<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pesanan))
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Buttoncek = New System.Windows.Forms.Button()
        Me.Buttonkmba = New System.Windows.Forms.Button()
        Me.TextBoxnm = New System.Windows.Forms.TextBox()
        Me.Buttonhpus = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(238, 174)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.RowTemplate.Height = 24
        Me.DataGridView5.Size = New System.Drawing.Size(353, 83)
        Me.DataGridView5.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PESANAN ANDA"
        '
        'Buttoncek
        '
        Me.Buttoncek.Location = New System.Drawing.Point(238, 132)
        Me.Buttoncek.Name = "Buttoncek"
        Me.Buttoncek.Size = New System.Drawing.Size(75, 23)
        Me.Buttoncek.TabIndex = 2
        Me.Buttoncek.Text = "CEK"
        Me.Buttoncek.UseVisualStyleBackColor = True
        '
        'Buttonkmba
        '
        Me.Buttonkmba.Location = New System.Drawing.Point(22, 25)
        Me.Buttonkmba.Name = "Buttonkmba"
        Me.Buttonkmba.Size = New System.Drawing.Size(137, 23)
        Me.Buttonkmba.TabIndex = 4
        Me.Buttonkmba.Text = "KEMBALI"
        Me.Buttonkmba.UseVisualStyleBackColor = True
        '
        'TextBoxnm
        '
        Me.TextBoxnm.Location = New System.Drawing.Point(318, 133)
        Me.TextBoxnm.Name = "TextBoxnm"
        Me.TextBoxnm.Size = New System.Drawing.Size(273, 22)
        Me.TextBoxnm.TabIndex = 5
        '
        'Buttonhpus
        '
        Me.Buttonhpus.Location = New System.Drawing.Point(238, 263)
        Me.Buttonhpus.Name = "Buttonhpus"
        Me.Buttonhpus.Size = New System.Drawing.Size(159, 23)
        Me.Buttonhpus.TabIndex = 6
        Me.Buttonhpus.Text = "HAPUS"
        Me.Buttonhpus.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(414, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "PEMBAYARAN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImage = Global.tiketing3.My.Resources.Resources._854_8541242_1366_x_768_31_background_orange_vector_png
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Buttonhpus)
        Me.Controls.Add(Me.TextBoxnm)
        Me.Controls.Add(Me.Buttonkmba)
        Me.Controls.Add(Me.Buttoncek)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView5)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pesanan"
        Me.Text = "pesanan"
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Buttoncek As Button
    Friend WithEvents Buttonkmba As Button
    Friend WithEvents TextBoxnm As TextBox
    Friend WithEvents Buttonhpus As Button
    Friend WithEvents Button1 As Button
End Class

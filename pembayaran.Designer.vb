<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pembayaran
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Buttonqr = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.ComboBoxgn = New System.Windows.Forms.ComboBox()
        Me.Button1sls = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Buttonqr
        '
        Me.Buttonqr.Location = New System.Drawing.Point(330, 136)
        Me.Buttonqr.Name = "Buttonqr"
        Me.Buttonqr.Size = New System.Drawing.Size(129, 23)
        Me.Buttonqr.TabIndex = 2
        Me.Buttonqr.Text = "GENERATE"
        Me.Buttonqr.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(292, 186)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 191)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(192, 80)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(79, 23)
        Me.btncari.TabIndex = 4
        Me.btncari.Text = "CARI"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'ComboBoxgn
        '
        Me.ComboBoxgn.FormattingEnabled = True
        Me.ComboBoxgn.Location = New System.Drawing.Point(321, 79)
        Me.ComboBoxgn.Name = "ComboBoxgn"
        Me.ComboBoxgn.Size = New System.Drawing.Size(155, 24)
        Me.ComboBoxgn.TabIndex = 5
        '
        'Button1sls
        '
        Me.Button1sls.Location = New System.Drawing.Point(624, 395)
        Me.Button1sls.Name = "Button1sls"
        Me.Button1sls.Size = New System.Drawing.Size(129, 23)
        Me.Button1sls.TabIndex = 6
        Me.Button1sls.Text = "SELESAI"
        Me.Button1sls.UseVisualStyleBackColor = True
        '
        'pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImage = Global.tiketing3.My.Resources.Resources._854_8541242_1366_x_768_31_background_orange_vector_png
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1sls)
        Me.Controls.Add(Me.ComboBoxgn)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Buttonqr)
        Me.DoubleBuffered = True
        Me.Name = "pembayaran"
        Me.Text = "pembayaran"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Buttonqr As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btncari As Button
    Friend WithEvents ComboBoxgn As ComboBox
    Friend WithEvents Button1sls As Button
End Class

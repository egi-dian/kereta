<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnadmin = New System.Windows.Forms.Button()
        Me.btnbeli = New System.Windows.Forms.Button()
        Me.btnpsn = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnadmin
        '
        Me.btnadmin.Location = New System.Drawing.Point(24, 46)
        Me.btnadmin.Name = "btnadmin"
        Me.btnadmin.Size = New System.Drawing.Size(75, 23)
        Me.btnadmin.TabIndex = 0
        Me.btnadmin.Text = "ADMIN"
        Me.btnadmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnadmin.UseVisualStyleBackColor = True
        '
        'btnbeli
        '
        Me.btnbeli.Location = New System.Drawing.Point(471, 46)
        Me.btnbeli.Name = "btnbeli"
        Me.btnbeli.Size = New System.Drawing.Size(75, 23)
        Me.btnbeli.TabIndex = 1
        Me.btnbeli.Text = "BELI"
        Me.btnbeli.UseVisualStyleBackColor = True
        '
        'btnpsn
        '
        Me.btnpsn.Location = New System.Drawing.Point(568, 46)
        Me.btnpsn.Name = "btnpsn"
        Me.btnpsn.Size = New System.Drawing.Size(97, 23)
        Me.btnpsn.TabIndex = 2
        Me.btnpsn.Text = "PESANAN"
        Me.btnpsn.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(687, 46)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 3
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImage = Global.tiketing3.My.Resources.Resources.daftar_nama_pramugari_garuda_indonesia_2013
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnpsn)
        Me.Controls.Add(Me.btnbeli)
        Me.Controls.Add(Me.btnadmin)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnadmin As Button
    Friend WithEvents btnbeli As Button
    Friend WithEvents btnpsn As Button
    Friend WithEvents btnkeluar As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxusn = New System.Windows.Forms.TextBox()
        Me.TextBoxpass = New System.Windows.Forms.TextBox()
        Me.Buttonlogin = New System.Windows.Forms.Button()
        Me.Buttonkmb = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD"
        '
        'TextBoxusn
        '
        Me.TextBoxusn.Location = New System.Drawing.Point(287, 115)
        Me.TextBoxusn.Name = "TextBoxusn"
        Me.TextBoxusn.Size = New System.Drawing.Size(294, 22)
        Me.TextBoxusn.TabIndex = 2
        '
        'TextBoxpass
        '
        Me.TextBoxpass.Location = New System.Drawing.Point(287, 158)
        Me.TextBoxpass.Name = "TextBoxpass"
        Me.TextBoxpass.Size = New System.Drawing.Size(294, 22)
        Me.TextBoxpass.TabIndex = 3
        '
        'Buttonlogin
        '
        Me.Buttonlogin.Location = New System.Drawing.Point(384, 241)
        Me.Buttonlogin.Name = "Buttonlogin"
        Me.Buttonlogin.Size = New System.Drawing.Size(75, 23)
        Me.Buttonlogin.TabIndex = 4
        Me.Buttonlogin.Text = "LOGIN"
        Me.Buttonlogin.UseVisualStyleBackColor = True
        '
        'Buttonkmb
        '
        Me.Buttonkmb.Location = New System.Drawing.Point(12, 12)
        Me.Buttonkmb.Name = "Buttonkmb"
        Me.Buttonkmb.Size = New System.Drawing.Size(75, 23)
        Me.Buttonkmb.TabIndex = 5
        Me.Buttonkmb.Text = "KEMBALI"
        Me.Buttonkmb.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(587, 160)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(87, 20)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "tampilkan"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImage = Global.tiketing3.My.Resources.Resources._854_8541242_1366_x_768_31_background_orange_vector_png
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Buttonkmb)
        Me.Controls.Add(Me.Buttonlogin)
        Me.Controls.Add(Me.TextBoxpass)
        Me.Controls.Add(Me.TextBoxusn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "admin"
        Me.Text = "admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxusn As TextBox
    Friend WithEvents TextBoxpass As TextBox
    Friend WithEvents Buttonlogin As Button
    Friend WithEvents Buttonkmb As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class

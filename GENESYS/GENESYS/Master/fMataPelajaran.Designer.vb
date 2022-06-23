<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMataPelajaran
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
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_Ubah = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgview1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_jam_patpel = New System.Windows.Forms.TextBox()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_idmatpel = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_hapus
        '
        Me.btn_hapus.Enabled = False
        Me.btn_hapus.Location = New System.Drawing.Point(303, 173)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(72, 30)
        Me.btn_hapus.TabIndex = 17
        Me.btn_hapus.Text = "HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_Ubah
        '
        Me.btn_Ubah.Enabled = False
        Me.btn_Ubah.Location = New System.Drawing.Point(208, 173)
        Me.btn_Ubah.Name = "btn_Ubah"
        Me.btn_Ubah.Size = New System.Drawing.Size(72, 30)
        Me.btn_Ubah.TabIndex = 16
        Me.btn_Ubah.Text = "UBAH"
        Me.btn_Ubah.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "JAM MATA PELAJARAN"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "NAMA MATA PELAJARAN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgview1
        '
        Me.dgview1.AllowUserToAddRows = False
        Me.dgview1.AllowUserToDeleteRows = False
        Me.dgview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgview1.Location = New System.Drawing.Point(23, 230)
        Me.dgview1.Name = "dgview1"
        Me.dgview1.ReadOnly = True
        Me.dgview1.Size = New System.Drawing.Size(544, 224)
        Me.dgview1.TabIndex = 24
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID MatPel"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Mata Pelajaran"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jam Mata Pelajaran"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Enabled = False
        Me.btn_simpan.Location = New System.Drawing.Point(114, 173)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(72, 30)
        Me.btn_simpan.TabIndex = 7
        Me.btn_simpan.Text = "SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID MATA PELAJARAN"
        '
        'txt_jam_patpel
        '
        Me.txt_jam_patpel.Location = New System.Drawing.Point(180, 114)
        Me.txt_jam_patpel.MaxLength = 5
        Me.txt_jam_patpel.Name = "txt_jam_patpel"
        Me.txt_jam_patpel.Size = New System.Drawing.Size(48, 20)
        Me.txt_jam_patpel.TabIndex = 12
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(438, 173)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(72, 30)
        Me.btn_Clear.TabIndex = 22
        Me.btn_Clear.Text = "CLEAR"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(180, 76)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(263, 20)
        Me.txt_nama.TabIndex = 1
        '
        'txt_idmatpel
        '
        Me.txt_idmatpel.Location = New System.Drawing.Point(180, 44)
        Me.txt_idmatpel.Name = "txt_idmatpel"
        Me.txt_idmatpel.ReadOnly = True
        Me.txt_idmatpel.Size = New System.Drawing.Size(100, 20)
        Me.txt_idmatpel.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_hapus)
        Me.GroupBox1.Controls.Add(Me.btn_Clear)
        Me.GroupBox1.Controls.Add(Me.btn_Ubah)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_simpan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_jam_patpel)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.txt_idmatpel)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 211)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 30)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "CREATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(234, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Jam"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fMataPelajaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 467)
        Me.Controls.Add(Me.dgview1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "fMataPelajaran"
        Me.Text = "Mata Pelajaran"
        CType(Me.dgview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_Ubah As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgview1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_jam_patpel As System.Windows.Forms.TextBox
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents txt_idmatpel As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

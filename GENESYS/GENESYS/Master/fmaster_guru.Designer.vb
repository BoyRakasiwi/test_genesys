<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmaster_guru
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
        Me.txt_idGuru = New System.Windows.Forms.TextBox()
        Me.txt_Matapelajaran = New System.Windows.Forms.TextBox()
        Me.txt_Alamat = New System.Windows.Forms.TextBox()
        Me.dt_tglLahir = New System.Windows.Forms.DateTimePicker()
        Me.txt_HP = New System.Windows.Forms.TextBox()
        Me.txt_workingTime = New System.Windows.Forms.TextBox()
        Me.txt_NamaGuru = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_matapelajaran = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_Ubah = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_idMatapelajaran = New System.Windows.Forms.TextBox()
        Me.dgview1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_idGuru
        '
        Me.txt_idGuru.Location = New System.Drawing.Point(91, 47)
        Me.txt_idGuru.Name = "txt_idGuru"
        Me.txt_idGuru.ReadOnly = True
        Me.txt_idGuru.Size = New System.Drawing.Size(100, 20)
        Me.txt_idGuru.TabIndex = 0
        '
        'txt_Matapelajaran
        '
        Me.txt_Matapelajaran.Enabled = False
        Me.txt_Matapelajaran.Location = New System.Drawing.Point(91, 79)
        Me.txt_Matapelajaran.Name = "txt_Matapelajaran"
        Me.txt_Matapelajaran.Size = New System.Drawing.Size(148, 20)
        Me.txt_Matapelajaran.TabIndex = 1
        '
        'txt_Alamat
        '
        Me.txt_Alamat.Location = New System.Drawing.Point(91, 151)
        Me.txt_Alamat.Multiline = True
        Me.txt_Alamat.Name = "txt_Alamat"
        Me.txt_Alamat.Size = New System.Drawing.Size(166, 53)
        Me.txt_Alamat.TabIndex = 2
        '
        'dt_tglLahir
        '
        Me.dt_tglLahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_tglLahir.Location = New System.Drawing.Point(405, 47)
        Me.dt_tglLahir.Name = "dt_tglLahir"
        Me.dt_tglLahir.Size = New System.Drawing.Size(100, 20)
        Me.dt_tglLahir.TabIndex = 3
        '
        'txt_HP
        '
        Me.txt_HP.Location = New System.Drawing.Point(405, 78)
        Me.txt_HP.Name = "txt_HP"
        Me.txt_HP.Size = New System.Drawing.Size(100, 20)
        Me.txt_HP.TabIndex = 4
        '
        'txt_workingTime
        '
        Me.txt_workingTime.Location = New System.Drawing.Point(405, 114)
        Me.txt_workingTime.Name = "txt_workingTime"
        Me.txt_workingTime.Size = New System.Drawing.Size(100, 20)
        Me.txt_workingTime.TabIndex = 5
        '
        'txt_NamaGuru
        '
        Me.txt_NamaGuru.Location = New System.Drawing.Point(405, 151)
        Me.txt_NamaGuru.Name = "txt_NamaGuru"
        Me.txt_NamaGuru.Size = New System.Drawing.Size(118, 20)
        Me.txt_NamaGuru.TabIndex = 6
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(91, 213)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(72, 30)
        Me.btn_simpan.TabIndex = 7
        Me.btn_simpan.Text = "SIMPAN"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(475, 225)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(72, 30)
        Me.btn_Clear.TabIndex = 8
        Me.btn_Clear.Text = "CLEAR"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID GURU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "PELAJARAN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ALAMAT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "TGL LAHIR"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(377, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "HP"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(310, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "WORKING TIME"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(326, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "NAMA GURU"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btn_matapelajaran)
        Me.GroupBox1.Controls.Add(Me.btn_hapus)
        Me.GroupBox1.Controls.Add(Me.txt_NamaGuru)
        Me.GroupBox1.Controls.Add(Me.txt_workingTime)
        Me.GroupBox1.Controls.Add(Me.btn_Ubah)
        Me.GroupBox1.Controls.Add(Me.txt_HP)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dt_tglLahir)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_simpan)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_idMatapelajaran)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_Alamat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_Matapelajaran)
        Me.GroupBox1.Controls.Add(Me.txt_idGuru)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 250)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 30)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "CREATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_matapelajaran
        '
        Me.btn_matapelajaran.Location = New System.Drawing.Point(245, 78)
        Me.btn_matapelajaran.Name = "btn_matapelajaran"
        Me.btn_matapelajaran.Size = New System.Drawing.Size(41, 23)
        Me.btn_matapelajaran.TabIndex = 18
        Me.btn_matapelajaran.Text = ". . ."
        Me.btn_matapelajaran.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(280, 213)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(72, 30)
        Me.btn_hapus.TabIndex = 17
        Me.btn_hapus.Text = "HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_Ubah
        '
        Me.btn_Ubah.Location = New System.Drawing.Point(185, 213)
        Me.btn_Ubah.Name = "btn_Ubah"
        Me.btn_Ubah.Size = New System.Drawing.Size(72, 30)
        Me.btn_Ubah.TabIndex = 16
        Me.btn_Ubah.Text = "UBAH"
        Me.btn_Ubah.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 26)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "ID MATA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PELAJARAN"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_idMatapelajaran
        '
        Me.txt_idMatapelajaran.Enabled = False
        Me.txt_idMatapelajaran.Location = New System.Drawing.Point(91, 117)
        Me.txt_idMatapelajaran.Name = "txt_idMatapelajaran"
        Me.txt_idMatapelajaran.Size = New System.Drawing.Size(100, 20)
        Me.txt_idMatapelajaran.TabIndex = 12
        '
        'dgview1
        '
        Me.dgview1.AllowUserToAddRows = False
        Me.dgview1.AllowUserToDeleteRows = False
        Me.dgview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column8, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgview1.Location = New System.Drawing.Point(24, 268)
        Me.dgview1.Name = "dgview1"
        Me.dgview1.ReadOnly = True
        Me.dgview1.Size = New System.Drawing.Size(544, 185)
        Me.dgview1.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Guru"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Guru"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "ID M_Pelajaran"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Mata Pelajaran"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Alamat"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tgl Lahir"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "HP"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Working Time"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'fmaster_guru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 467)
        Me.Controls.Add(Me.dgview1)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "fmaster_guru"
        Me.Text = "Master guru"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_idGuru As System.Windows.Forms.TextBox
    Friend WithEvents txt_Matapelajaran As System.Windows.Forms.TextBox
    Friend WithEvents txt_Alamat As System.Windows.Forms.TextBox
    Friend WithEvents dt_tglLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_HP As System.Windows.Forms.TextBox
    Friend WithEvents txt_workingTime As System.Windows.Forms.TextBox
    Friend WithEvents txt_NamaGuru As System.Windows.Forms.TextBox
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgview1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_idMatapelajaran As System.Windows.Forms.TextBox
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_Ubah As System.Windows.Forms.Button
    Friend WithEvents btn_matapelajaran As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

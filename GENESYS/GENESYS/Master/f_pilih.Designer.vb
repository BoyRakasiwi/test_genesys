<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_pilih
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Matapelajaran = New System.Windows.Forms.TextBox()
        Me.dgview1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "NAMA MATA PELAJARAN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Matapelajaran
        '
        Me.txt_Matapelajaran.Location = New System.Drawing.Point(20, 32)
        Me.txt_Matapelajaran.Name = "txt_Matapelajaran"
        Me.txt_Matapelajaran.Size = New System.Drawing.Size(272, 20)
        Me.txt_Matapelajaran.TabIndex = 11
        '
        'dgview1
        '
        Me.dgview1.AllowUserToAddRows = False
        Me.dgview1.AllowUserToDeleteRows = False
        Me.dgview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgview1.Location = New System.Drawing.Point(20, 58)
        Me.dgview1.Name = "dgview1"
        Me.dgview1.ReadOnly = True
        Me.dgview1.Size = New System.Drawing.Size(418, 164)
        Me.dgview1.TabIndex = 25
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
        'f_pilih
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 229)
        Me.Controls.Add(Me.dgview1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Matapelajaran)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f_pilih"
        Me.Text = "Pilih"
        CType(Me.dgview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Matapelajaran As System.Windows.Forms.TextBox
    Friend WithEvents dgview1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

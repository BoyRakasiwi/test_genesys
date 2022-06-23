<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_MDI
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LogicTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoalTestPraktekDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MataPelajaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogicTestToolStripMenuItem, Me.SoalTestPraktekDesktopToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 367)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'LogicTestToolStripMenuItem
        '
        Me.LogicTestToolStripMenuItem.Name = "LogicTestToolStripMenuItem"
        Me.LogicTestToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.LogicTestToolStripMenuItem.Text = "Logic Test"
        '
        'SoalTestPraktekDesktopToolStripMenuItem
        '
        Me.SoalTestPraktekDesktopToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.JadwalToolStripMenuItem})
        Me.SoalTestPraktekDesktopToolStripMenuItem.Name = "SoalTestPraktekDesktopToolStripMenuItem"
        Me.SoalTestPraktekDesktopToolStripMenuItem.Size = New System.Drawing.Size(152, 20)
        Me.SoalTestPraktekDesktopToolStripMenuItem.Text = "Soal Test Praktek Desktop"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MataPelajaranToolStripMenuItem, Me.GuruToolStripMenuItem, Me.KelasToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'MataPelajaranToolStripMenuItem
        '
        Me.MataPelajaranToolStripMenuItem.Name = "MataPelajaranToolStripMenuItem"
        Me.MataPelajaranToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MataPelajaranToolStripMenuItem.Text = "Mata Pelajaran"
        '
        'GuruToolStripMenuItem
        '
        Me.GuruToolStripMenuItem.Name = "GuruToolStripMenuItem"
        Me.GuruToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GuruToolStripMenuItem.Text = "Guru"
        '
        'KelasToolStripMenuItem
        '
        Me.KelasToolStripMenuItem.Name = "KelasToolStripMenuItem"
        Me.KelasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KelasToolStripMenuItem.Text = "Kelas"
        '
        'JadwalToolStripMenuItem
        '
        Me.JadwalToolStripMenuItem.Name = "JadwalToolStripMenuItem"
        Me.JadwalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JadwalToolStripMenuItem.Text = "Jadwal"
        '
        'f_MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 389)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "f_MDI"
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents LogicTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoalTestPraktekDesktopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MataPelajaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuruToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KelasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JadwalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

Imports System.Windows.Forms

Public Class f_MDI

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

   
    Private Sub LogicTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogicTestToolStripMenuItem.Click
        Form1.ShowDialog()
    End Sub

    Private Sub MataPelajaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MataPelajaranToolStripMenuItem.Click
        fMataPelajaran.ShowDialog()
    End Sub

    Private Sub GuruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuruToolStripMenuItem.Click
        fmaster_guru.ShowDialog()
    End Sub

    Private Sub KelasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KelasToolStripMenuItem.Click
        fKelas.ShowDialog()
    End Sub

    Private Sub JadwalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JadwalToolStripMenuItem.Click
        fJadwal.ShowDialog()
    End Sub

End Class

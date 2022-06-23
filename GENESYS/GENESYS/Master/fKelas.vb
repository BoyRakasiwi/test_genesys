Public Class fKelas

    Private Sub fKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.koneksi()
        tampil_all()
    End Sub

    Sub kode()
        Try
            Dim id As String

            Using da As New SqlClient.SqlDataAdapter("select * from m_kelas order by kelas_id desc", cnn)
                Using dt As New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count = 0 Then
                        id = "K000000001"
                    Else
                        With dt.Rows(0)
                            id = .Item("kelas_id")
                        End With
                        id = Val(Mid(id, 2, 10)) + 1
                        If Len(id) = 1 Then
                            id = "K00000000" & id
                        ElseIf Len(id) = 2 Then
                            id = "K0000000" & id
                        ElseIf Len(id) = 3 Then
                            id = "K000000" & id

                        ElseIf Len(id) = 4 Then
                            id = "K00000" & id
                        ElseIf Len(id) = 5 Then
                            id = "K0000" & id

                        ElseIf Len(id) = 6 Then
                            id = "K000" & id
                        ElseIf Len(id) = 7 Then
                            id = "K00" & id
                        ElseIf Len(id) = 8 Then
                            id = "K0" & id
                        ElseIf Len(id) = 3 Then
                            id = id
                        Else
                            MsgBox("ID SUDAH PENUH, SILAHKAN HUBUNGI STAFF IT PT. AMAN JAYA PERDANA", MsgBoxStyle.Critical, "ERROR")
                        End If
                    End If
                End Using
            End Using
            txt_idKelas.Text = id
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub clear()
        txt_idKelas.Clear()
        txtLocation.Clear()
        txtRemarks.Clear()

    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Try
            ''WITHOUT STORE PROCEDURE
            If txt_idKelas.Text = String.Empty Or txtLocation.Text = String.Empty Or txtRemarks.Text = String.Empty Then
                MsgBox("Silahkan lengkapi data", MsgBoxStyle.Critical, "Gagal simpan")
            Else
                str = "select * from m_kelas where location='" & txtLocation.Text & "'"
                Dim cmd As New SqlClient.SqlCommand(str, cnn)
                Dim a = cmd.ExecuteScalar
                If a = Nothing Then
                    Dim stq = "insert into m_kelas values('" & txt_idKelas.Text & "','" & txtRemarks.Text & "','" & txtLocation.Text & "')"
                    Dim cmn As New SqlClient.SqlCommand(stq, cnn)
                    Dim b = cmn.ExecuteNonQuery
                    If b <> Nothing Then
                        MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Info")
                        clear()
                        ''kode()
                        tampil_all()
                        btn_simpan.Enabled = True
                        btn_Ubah.Enabled = False
                        btn_hapus.Enabled = False
                    End If

                Else
                    MsgBox(txtLocation.Text & " sudah ada", MsgBoxStyle.Critical, "Gagal simpan")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Ubah_Click(sender As Object, e As EventArgs) Handles btn_Ubah.Click
        Try
            ''WITHOUT STORE PROCEDURE
             If txt_idKelas.Text = String.Empty Or txtLocation.Text = String.Empty Or txtRemarks.Text = String.Empty Then
                MsgBox("Silahkan lengkapi data", MsgBoxStyle.Critical, "Gagal ubah")

            Else
                If MsgBox("Yakin ingin ubah data " & dgview1.Item(0, dgview1.CurrentRow.Index).Value & "?", MsgBoxStyle.OkCancel, "Konfirmasi") = vbOK Then
                    Dim stq = "update m_kelas set remarks='" & txtRemarks.Text & "' where kelas_id='" & txt_idKelas.Text & "'"
                    Dim cmn As New SqlClient.SqlCommand(stq, cnn)
                    Dim b = cmn.ExecuteNonQuery
                    If b <> Nothing Then
                        MsgBox("Data berhasil diubah", MsgBoxStyle.Information, "Info")
                        clear()
                        ''kode()
                        tampil_all()
                        btn_simpan.Enabled = True
                        btn_Ubah.Enabled = False
                        btn_hapus.Enabled = False
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Try
            ''WITHOUT STORE PROCEDURE
            If txt_idKelas.Text = String.Empty Or txtLocation.Text = String.Empty Or txtRemarks.Text = String.Empty Then
                MsgBox("Silahkan lengkapi data", MsgBoxStyle.Critical, "Gagal hapus")
            Else
                If MsgBox("Yakin ingin hapus data " & dgview1.Item(0, dgview1.CurrentRow.Index).Value & " ?", MsgBoxStyle.OkCancel, "Konfirmasi") = vbOK Then
                    Dim stq = "delete from m_kelas " _
                              & "where kelas_id='" & txt_idKelas.Text & "'"
                    Dim cmn As New SqlClient.SqlCommand(stq, cnn)
                    Dim b = cmn.ExecuteNonQuery
                    If b <> Nothing Then
                        MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Info")
                        clear()
                        ''kode()
                        tampil_all()
                        btn_simpan.Enabled = True
                        btn_Ubah.Enabled = False
                        btn_hapus.Enabled = False
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub tampil_all()
        Try
            str = "select * from m_kelas order by kelas_id desc"
            Dim cmd As New SqlClient.SqlCommand(str, cnn)
            da.SelectCommand = cmd
            dr = cmd.ExecuteReader
            dgview1.Rows.Clear()
            While dr.Read()
                With dgview1.Rows.Add(dr("kelas_id"), dr("remarks"), dr("location"))

                End With
            End While
            dr.Close()

            For i = 0 To dgview1.Rows.Count - 1

                If i Mod 2 = 0 Then
                    With dgview1.ColumnHeadersDefaultCellStyle
                        .Alignment = DataGridViewContentAlignment.MiddleCenter
                        .BackColor = Color.Orange
                        .ForeColor = Color.White
                        .Font = New Font(.Font.FontFamily, .Font.Size, _
                         .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
                    End With

                    dgview1.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                    dgview1.RowsDefaultCellStyle.SelectionBackColor = Color.BlueViolet

                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgview1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview1.CellClick
        Try
            txt_idKelas.Text = dgview1.Item(0, dgview1.CurrentRow.Index).Value
            txtRemarks.Text = dgview1.Item(1, dgview1.CurrentRow.Index).Value
            txtLocation.Text = dgview1.Item(2, dgview1.CurrentRow.Index).Value

            txtLocation.Enabled = False
            btn_simpan.Enabled = False
            btn_Ubah.Enabled = True
            btn_hapus.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clear()
        kode()

        btn_simpan.Enabled = True
        btn_Ubah.Enabled = False
        btn_hapus.Enabled = False
        txtLocation.Enabled = True
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        clear()
    End Sub
End Class
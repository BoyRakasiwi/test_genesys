Public Class fmaster_guru


    Private Sub fmaster_guru_Load(sender As Object, e As EventArgs) Handles Me.Load
        Module1.koneksi()
        tampil_all()
        ''kode()
    End Sub

    Sub kode()
        Try
            Dim id As String

            Using da As New SqlClient.SqlDataAdapter("select * from m_guru order by guru_id desc", cnn)
                Using dt As New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count = 0 Then
                        id = "G000000001"
                    Else
                        With dt.Rows(0)
                            id = .Item("guru_id")
                        End With
                        id = Val(Mid(id, 2, 10)) + 1
                        If Len(id) = 1 Then
                            id = "G00000000" & id
                        ElseIf Len(id) = 2 Then
                            id = "G0000000" & id
                        ElseIf Len(id) = 3 Then
                            id = "G000000" & id

                        ElseIf Len(id) = 4 Then
                            id = "G00000" & id
                        ElseIf Len(id) = 5 Then
                            id = "G0000" & id

                        ElseIf Len(id) = 6 Then
                            id = "G000" & id
                        ElseIf Len(id) = 7 Then
                            id = "G00" & id
                        ElseIf Len(id) = 8 Then
                            id = "G0" & id
                        ElseIf Len(id) = 3 Then
                            id = id
                        Else
                            MsgBox("ID SUDAH PENUH, SILAHKAN HUBUNGI STAFF IT PT. AMAN JAYA PERDANA", MsgBoxStyle.Critical, "ERROR")
                        End If
                    End If
                End Using
            End Using
            txt_idGuru.Text = id
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub clear()
        txt_Alamat.Clear()
        txt_HP.Clear()
        txt_idGuru.Clear()
        txt_idMatapelajaran.Clear()
        txt_Matapelajaran.Clear()
        txt_NamaGuru.Clear()
        txt_workingTime.Clear()

    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Try
            ''WITHOUT STORE PROCEDURE
            If txt_NamaGuru.Text = String.Empty Or txt_idGuru.Text = String.Empty Or txt_idMatapelajaran.Text = String.Empty _
                Or txt_workingTime.Text = String.Empty Then
                MsgBox("Silahkan lengkapi data", MsgBoxStyle.Critical, "Gagal simpan")
            Else
                str = "select * from m_guru where guru_nama='" & txt_NamaGuru.Text & "'"
                Dim cmd As New SqlClient.SqlCommand(str, cnn)
                Dim a = cmd.ExecuteScalar
                If a = Nothing Then
                    Dim stq = "insert into m_guru values('" & txt_idGuru.Text & "','" & txt_idMatapelajaran.Text & "','" _
                              & txt_Alamat.Text & "','" & dt_tglLahir.Value & "','" & txt_HP.Text & "','" _
                              & txt_workingTime.Text & "','" & txt_NamaGuru.Text & "')"
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
                    MsgBox("Guru " & txt_NamaGuru.Text & " sudah ada", MsgBoxStyle.Critical, "Gagal simpan")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Ubah_Click(sender As Object, e As EventArgs) Handles btn_Ubah.Click
        Try
            ''WITHOUT STORE PROCEDURE
            If txt_NamaGuru.Text = String.Empty Or txt_idGuru.Text = String.Empty Or txt_idMatapelajaran.Text = String.Empty _
               Or txt_workingTime.Text = String.Empty Then
                MsgBox("Silahkan lengkapi data", MsgBoxStyle.Critical, "Gagal simpan")

            Else
                If MsgBox("Yakin ingin ubah data " & dgview1.Item(0, dgview1.CurrentRow.Index).Value & "?", MsgBoxStyle.OkCancel, "Konfirmasi") = vbOK Then
                    Dim stq = "update m_guru set matpel_id='" & txt_idMatapelajaran.Text & "', guru_alamat='" & txt_Alamat.Text & "', " _
                              & "guru_tgllahir='" & dt_tglLahir.Value & "',guru_phone='" & txt_HP.Text & "', guru_workingtime='" & txt_workingTime.Text & "' " _
                              & "where guru_id='" & txt_idGuru.Text & "'"
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
            If txt_NamaGuru.Text = String.Empty Or txt_idGuru.Text = String.Empty Or txt_idMatapelajaran.Text = String.Empty _
               Or txt_workingTime.Text = String.Empty Then
                MsgBox("Silahkan lengkapi data", MsgBoxStyle.Critical, "Gagal hapus")
            Else
                If MsgBox("Yakin ingin hapus data " & dgview1.Item(0, dgview1.CurrentRow.Index).Value & " ?", MsgBoxStyle.OkCancel, "Konfirmasi") = vbOK Then
                    Dim stq = "delete from m_guru " _
                              & "where guru_id='" & txt_idGuru.Text & "'"
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
            str = "select * from m_guru a left join m_pelajaran b on a.matpel_id=b.matpel_id order by guru_id desc"
            Dim cmd As New SqlClient.SqlCommand(str, cnn)
            da.SelectCommand = cmd
            dr = cmd.ExecuteReader
            dgview1.Rows.Clear()
            While dr.Read()
                With dgview1.Rows.Add(dr("guru_id"), dr("guru_nama"), dr("matpel_id"), dr("matpel_nama"), _
                                       dr("guru_alamat"), dr("guru_tgllahir"), _
                                      dr("guru_phone"), dr("guru_workingtime"))

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
    Private Sub btn_matapelajaran_Click(sender As Object, e As EventArgs) Handles btn_matapelajaran.Click
        ' Dim ctl As TextBox 'the textbox which the form will show at its bottom
        Dim ctlpos As Point = txt_Matapelajaran.PointToScreen(New Point(0, 0)) 'Point.Empty is not function so se Point(0, 0)

        f_pilih.StartPosition = FormStartPosition.Manual 'set it to manual
        f_pilih.Location = New Point(ctlpos.X - 2, ctlpos.Y + txt_Matapelajaran.Height - 2) 'then locate its position
        f_pilih.parameter_pilih = "master guru"
        f_pilih.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clear()
        kode()

        btn_simpan.Enabled = True
        btn_Ubah.Enabled = False
        btn_hapus.Enabled = False
        txt_NamaGuru.Enabled = True
    End Sub

    Private Sub txt_workingTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_workingTime.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_HP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_HP.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgview1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview1.CellClick
        Try
            txt_idGuru.Text = dgview1.Item(0, dgview1.CurrentRow.Index).Value
            txt_NamaGuru.Text = dgview1.Item(1, dgview1.CurrentRow.Index).Value
            txt_idMatapelajaran.Text = dgview1.Item(2, dgview1.CurrentRow.Index).Value

            txt_Matapelajaran.Text = dgview1.Item(3, dgview1.CurrentRow.Index).Value
            txt_Alamat.Text = dgview1.Item(4, dgview1.CurrentRow.Index).Value
            dt_tglLahir.Value = dgview1.Item(5, dgview1.CurrentRow.Index).Value

            txt_HP.Text = dgview1.Item(6, dgview1.CurrentRow.Index).Value
            txt_workingTime.Text = dgview1.Item(7, dgview1.CurrentRow.Index).Value
            txt_NamaGuru.Enabled = False
            btn_simpan.Enabled = False
            btn_Ubah.Enabled = True
            btn_hapus.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        clear()
    End Sub
End Class
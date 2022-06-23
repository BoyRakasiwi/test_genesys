Public Class fJadwal
    Public guru_id, kelas_id, hari_id, jadwal_id As String
    Private Sub fJadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.koneksi()
        ComboBoxHari()
        ComboBoxKelas()
        ComboBoxNamGuru()
        ComboBoxKelas()
        tampil_all()
    End Sub
    Sub kode()
        Try
            Dim id As String

            Using da As New SqlClient.SqlDataAdapter("select * from t_jadwal order by id_jadwal desc", cnn)
                Using dt As New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count = 0 Then
                        id = "J000000001"
                    Else
                        With dt.Rows(0)
                            id = .Item("id_jadwal")
                        End With
                        id = Val(Mid(id, 2, 10)) + 1
                        If Len(id) = 1 Then
                            id = "J00000000" & id
                        ElseIf Len(id) = 2 Then
                            id = "J0000000" & id
                        ElseIf Len(id) = 3 Then
                            id = "J000000" & id

                        ElseIf Len(id) = 4 Then
                            id = "J00000" & id
                        ElseIf Len(id) = 5 Then
                            id = "J0000" & id

                        ElseIf Len(id) = 6 Then
                            id = "J000" & id
                        ElseIf Len(id) = 7 Then
                            id = "J00" & id
                        ElseIf Len(id) = 8 Then
                            id = "J0" & id
                        ElseIf Len(id) = 3 Then
                            id = id
                        Else
                            MsgBox("ID SUDAH PENUH, SILAHKAN HUBUNGI STAFF IT PT. AMAN JAYA PERDANA", MsgBoxStyle.Critical, "ERROR")
                        End If
                    End If
                End Using
            End Using
            jadwal_id = id
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ComboBoxHari()
        Try
            Dim da As New SqlClient.SqlDataAdapter("select * from m_hari order by hari_id asc", cnn)
            Dim dt As New DataTable
            da.Fill(dt)
            cmb_hari.DataSource = dt
            cmb_hari.ValueMember = "hari_id"
            cmb_hari.DisplayMember = "hari_nama"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ComboBoxKelas()
        Try
            Dim da As New SqlClient.SqlDataAdapter("select * from m_kelas order by kelas_id asc", cnn)
            Dim dt As New DataTable
            da.Fill(dt)
            cmb_kelas.DataSource = dt
            cmb_kelas.ValueMember = "kelas_id"
            cmb_kelas.DisplayMember = "Remarks"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ComboBoxNamGuru()
        Try
            Dim da As New SqlClient.SqlDataAdapter("select * from m_guru order by guru_id asc", cnn)
            Dim dt As New DataTable
            da.Fill(dt)
            cmbNamaGuru.DataSource = dt
            cmbNamaGuru.ValueMember = "guru_id"
            cmbNamaGuru.DisplayMember = "guru_nama"

            cmbNamaGuru.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cmbNamaGuru.AutoCompleteSource = AutoCompleteSource.ListItems
            guru_id = dt.Rows.Item(0).Item("guru_id")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        fReport.ShowDialog()
    End Sub

    Sub tampil_all()
        Try
            Dim cmd As New SqlClient.SqlCommand("tampil_all", cnn)
            da.SelectCommand = cmd
            cmd.CommandType = CommandType.StoredProcedure
            dr = cmd.ExecuteReader
            dgview1.Rows.Clear()
            While dr.Read()
                With dgview1.Rows.Add(dr("id_jadwal"), dr("hari_nama"), dr("guru_id"), dr("guru_nama"), dr("matpel_id"), _
                                       dr("matpel_nama"), dr("Remarks"), dr("JamPelajaran"))

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

                    dgview1.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
                    dgview1.RowsDefaultCellStyle.SelectionBackColor = Color.BlueViolet

                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Try

            If cmb_hari.Text = String.Empty Or cmb_kelas.Text = String.Empty Or cmbNamaGuru.Text = String.Empty _
                Or txt_jampel.Text = String.Empty Or txt_namaPelajaran.Text = String.Empty Then
                MsgBox("Silahkan lengkapi data", MsgBoxStyle.Critical, "Gagal simpan")
            Else
                kode()
                Dim result As String
                Dim stq = "simpan_jadwal"
                Dim cmn As New SqlClient.SqlCommand(stq, cnn)
                cmn.CommandType = CommandType.StoredProcedure
                cmn.Parameters.AddWithValue("@hari_id", cmb_hari.SelectedValue)
                cmn.Parameters.AddWithValue("@kelas_id", cmb_kelas.SelectedValue)
                cmn.Parameters.AddWithValue("@guru_id", cmbNamaGuru.SelectedValue)
                cmn.Parameters.AddWithValue("@id_jadwal", jadwal_id)
                cmn.Parameters.AddWithValue("@jampelajaran", Convert.ToDecimal(txt_jampel.Text))
                cmn.Parameters.Add("@OUTPUTMESSAGE", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
                Dim b = cmn.ExecuteNonQuery
                result = cmn.Parameters("@OUTPUTMESSAGE").Value.ToString()
                If b <> Nothing Then
                    MsgBox(result, MsgBoxStyle.Information, "Info")
                    ClearTextBox(Me)
                    ''kode()
                    tampil_all()
                    btn_simpan.Enabled = True
                    btn_Ubah.Enabled = False
                    btn_hapus.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Ubah_Click(sender As Object, e As EventArgs) Handles btn_Ubah.Click
        Try
            If cmb_hari.Text = String.Empty Or cmb_kelas.Text = String.Empty Or cmbNamaGuru.Text = String.Empty _
                Or txt_jampel.Text = String.Empty Or txt_namaPelajaran.Text = String.Empty Then
                MsgBox("Silahkan lengkapi data", MsgBoxStyle.Critical, "Gagal ubah")

            Else
                If MsgBox("Yakin ingin ubah data " & dgview1.Item(0, dgview1.CurrentRow.Index).Value & "?", MsgBoxStyle.OkCancel, "Konfirmasi") = vbOK Then
                    Dim cmn As New SqlClient.SqlCommand("ubah_jadwal", cnn)
                    cmn.CommandType = CommandType.StoredProcedure
                    cmn.Parameters.AddWithValue("@hari_id", cmb_hari.SelectedValue)
                    cmn.Parameters.AddWithValue("@kelas_id", cmb_kelas.SelectedValue)
                    cmn.Parameters.AddWithValue("@guru_id", cmbNamaGuru.SelectedValue)
                    cmn.Parameters.AddWithValue("@id_jadwal", jadwal_id)
                    cmn.Parameters.AddWithValue("@jampelajaran", txt_jampel.Text)
                    Dim b = cmn.ExecuteNonQuery
                    If b <> Nothing Then
                        MsgBox("Data berhasil diubah", MsgBoxStyle.Information, "Info")
                        ClearTextBox(Me)
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
            If cmb_hari.Text = String.Empty Or cmb_kelas.Text = String.Empty Or cmbNamaGuru.Text = String.Empty _
                Or txt_jampel.Text = String.Empty Or txt_namaPelajaran.Text = String.Empty Then
                MsgBox("Silahkan lengkapi data", MsgBoxStyle.Critical, "Gagal hapus")

            Else
                If MsgBox("Yakin ingin hapus data " & dgview1.Item(0, dgview1.CurrentRow.Index).Value & "?", MsgBoxStyle.OkCancel, "Konfirmasi") = vbOK Then
                    Dim cmn As New SqlClient.SqlCommand("hapus_jadwal", cnn)
                    cmn.CommandType = CommandType.StoredProcedure
                    cmn.Parameters.AddWithValue("@id_jadwal", jadwal_id)
                    Dim b = cmn.ExecuteNonQuery
                    If b <> Nothing Then
                        MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Info")
                        ClearTextBox(Me)
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
    Private Sub txt_jampel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jampel.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbNamaGuru_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNamaGuru.SelectedIndexChanged
        txt_namaPelajaran.Clear()
        Try
            str = "select matpel_nama from m_pelajaran a inner join m_guru b on a.matpel_id=b.matpel_id where guru_id='" & cmbNamaGuru.SelectedValue.ToString() & "'"
            Dim cmd As New SqlClient.SqlCommand(str, cnn)
            Dim a = cmd.ExecuteScalar
            If a <> Nothing Then
                txt_namaPelajaran.Text = a
            Else
                txt_namaPelajaran.Text = String.Empty
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgview1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview1.CellClick
        Try
            jadwal_id = dgview1.Item(0, dgview1.CurrentRow.Index).Value

            Dim index As Integer
            index = cmb_hari.FindString(dgview1.Item(1, dgview1.CurrentRow.Index).Value)
            cmb_hari.SelectedIndex = index

            Dim index_namaguru As Integer
            index_namaguru = cmbNamaGuru.FindString(dgview1.Item(3, dgview1.CurrentRow.Index).Value)
            cmbNamaGuru.SelectedIndex = index_namaguru

            txt_namaPelajaran.Text = dgview1.Item(5, dgview1.CurrentRow.Index).Value

            Dim index_kelas As Integer
            index_kelas = cmb_kelas.FindString(dgview1.Item(6, dgview1.CurrentRow.Index).Value)
            cmb_kelas.SelectedIndex = index_kelas

            txt_jampel.Text = dgview1.Item(7, dgview1.CurrentRow.Index).Value

            btn_simpan.Enabled = False
            btn_Ubah.Enabled = True
            btn_hapus.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
End Class
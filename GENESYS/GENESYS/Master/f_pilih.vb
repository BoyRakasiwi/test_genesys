Public Class f_pilih
    Public parameter_pilih As String

    Sub tampil_()
        Try
            str = "select * from m_pelajaran where matpel_nama like '%" & txt_Matapelajaran.Text & "%' order by matpel_id desc"
            Dim cmd As New SqlClient.SqlCommand(str, cnn)
            da.SelectCommand = cmd
            dr = cmd.ExecuteReader
            dgview1.Rows.Clear()
            While dr.Read()
                With dgview1.Rows.Add(dr("matpel_id"), dr("matpel_nama"), dr("matpel_hour"))

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

    Private Sub txt_Matapelajaran_TextChanged(sender As Object, e As EventArgs) Handles txt_Matapelajaran.TextChanged
        tampil_()
    End Sub

    Private Sub dgview1_DoubleClick(sender As Object, e As EventArgs) Handles dgview1.DoubleClick
        Try
            fmaster_guru.txt_idMatapelajaran.Text = dgview1.Item(0, dgview1.CurrentRow.Index).Value
            fmaster_guru.txt_Matapelajaran.Text = dgview1.Item(1, dgview1.CurrentRow.Index).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
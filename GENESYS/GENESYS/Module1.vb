Imports System.Data.SqlClient
''Imports System.IO
Module Module1
    Public cmd As New SqlCommand
    Public cnn As New SqlConnection
    Public str As String
    Public dr As SqlDataReader
    Public da As New SqlDataAdapter
    Public parameter As String
    Sub koneksi()

        Try
            If cnn.State = ConnectionState.Open Then cnn.Close()
            cnn.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=DBAkademik; Integrated Security=True"
            cnn.Open()
        Catch ex As Exception
            MsgBox("Gagal konek Database, cek pengaturan Database", MsgBoxStyle.Critical, "Gagal konek")
        End Try
      
    End Sub
End Module

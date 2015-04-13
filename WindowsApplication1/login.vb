
Imports System.Data.SqlClient
Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim chuoiketnoi As String = "workstation id=datvttps02047.mssql.somee.com;packet size=4096;user id=tandat;pwd=Aa@123456;data source=datvttps02047.mssql.somee.com;persist security info=False;initial catalog=datvttps02047"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NHANVIEN where TENNV='" & txtusername.Text & "' and MANV='" & txtpassword.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then

                MessageBox.Show("Đăng nhập thành công")
                Main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai Tai Khoan hoac Mat Khau")
            End If

        Catch ex As Exception

        End Try
    End Sub


End Class

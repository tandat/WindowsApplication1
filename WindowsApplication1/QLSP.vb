
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class QLSP
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=datvttps02047.mssql.somee.com;packet size=4096;user id=tandat;pwd=Aa@123456;data source=datvttps02047.mssql.somee.com;persist security info=False;initial catalog=datvttps02047"


    Public Sub LoadData()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("Select * from SANPHAM", KetNoi)

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try

        DataGridView1.DataSource = tb

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim KetNoi As New SqlConnection(connectstr)

        KetNoi.Open()

        Dim stradd As String = "Insert into SANPHAM values (@MASP,@TENSP,@DONGIA,@SOLUONG,@CHITIETSP)"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            com.Parameters.AddWithValue("@MASP", TextBox1.Text)
            com.Parameters.AddWithValue("@TENSP", TextBox2.Text)
            com.Parameters.AddWithValue("@DONGIA", TextBox3.Text)
            com.Parameters.AddWithValue("@SOLUONG", TextBox4.Text)
            com.Parameters.AddWithValue("@CHITIETSP", TextBox5.Text)

            com.ExecuteNonQuery()

            KetNoi.Close()

        Catch ex As Exception
            MessageBox.Show("kết nối thành công")
        End Try
        Dim res As SqlDataAdapter = New SqlDataAdapter("select * from SANPHAM", KetNoi)
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing

        LoadData()

    End Sub

   

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim stradd As String = "Delete from SANPHAM WHERE MASP = @MASP"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            com.Parameters.AddWithValue("@MASP", TextBox1.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()

        Catch ex As Exception
            MessageBox.Show("Xoá thành công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()

        Dim stradd As String = "UPDATE SANPHAM SET MASP=@MASP,TENSP=@TENSP,DONGIA=@DONGIA,SOLUONG=@SOLUONG,CHITIETSP=@CHITIETSP"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            com.Parameters.AddWithValue("@MASP", TextBox1.Text)
            com.Parameters.AddWithValue("@TENSP", TextBox2.Text)
            com.Parameters.AddWithValue("@DONGIA", TextBox3.Text)
            com.Parameters.AddWithValue("@SOLUONG", TextBox4.Text)
            com.Parameters.AddWithValue("@CHITIETSP", TextBox5.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối thành công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()

    End Sub

   

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        TextBox1.Text = DataGridView1.Item(0, index).Value
        TextBox2.Text = DataGridView1.Item(1, index).Value
        TextBox3.Text = DataGridView1.Item(2, index).Value
    End Sub
End Class

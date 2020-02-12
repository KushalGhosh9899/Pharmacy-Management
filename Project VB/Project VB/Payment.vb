Imports System.Data.SqlClient
Public Class Payment
    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New SqlCommand("insert into payment(cardnum,name,date,cvv) values(" & TextBox1.Text & " ,'" & TextBox2.Text & "'," & TextBox3.Text & "," & TextBox4.Text & " )", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        deliverydetails.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HelpandSupport.Show()
    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=DESKTOP-65VG5F2\KUSHAL123;Initial Catalog=Pharmacy;Integrated Security=True")
        cn.Open()
        cn.Close()
    End Sub
End Class
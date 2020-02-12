Imports System.Data.SqlClient
Public Class deliverydetails
    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New SqlCommand("insert into delivery(fname,lname,mobile,housenum,street,locality,city,state,pin) values('" & TextBox1.Text & "' ,'" & TextBox2.Text & "'," & TextBox3.Text & ",'" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "'," & TextBox9.Text & " )", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        EndPage.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HelpandSupport.Show()
    End Sub

    Private Sub Deliverydetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=DESKTOP-65VG5F2\KUSHAL123;Initial Catalog=Pharmacy;Integrated Security=True")
        cn.Open()
        cn.Close()
    End Sub
End Class
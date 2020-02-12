Imports System.Data.SqlClient
Public Class onetimeuser
    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HelpandSupport.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox5.Text = TextBox6.Text Then
            cmd = New SqlCommand("insert into One_Time_User(Fname,Lname,email,mobileno,password) values('" & TextBox1.Text & "' ,'" & TextBox2.Text & "','" & TextBox3.Text & "'," & TextBox4.Text & " ,'" & TextBox5.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            Shopping.Show()
            Me.Hide()
        Else
            MessageBox.Show("Password Doesnot Match")
        End If

    End Sub

    Private Sub Onetimeuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cn = New SqlConnection("Data Source=DESKTOP-65VG5F2\KUSHAL123;Initial Catalog=Pharmacy;Integrated Security=True")
        cn.Open()
        cn.Close()

    End Sub
End Class
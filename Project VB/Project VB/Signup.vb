Imports System.Data.SqlClient
Public Class signup
    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox6.Text = TextBox7.Text Then
            cmd = New SqlCommand("insert into signup(fname,lname,email,username,mobile,password) values('" & TextBox1.Text & "' ,'" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "'," & TextBox5.Text & " ,'" & TextBox6.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Account Created Succesfully")
            Login.Show()
            MessageBox.Show("Login For Further Use")
            Me.Hide()
        Else
            MessageBox.Show("Password Doesnot Match")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HelpandSupport.Show()

    End Sub

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=DESKTOP-65VG5F2\KUSHAL123;Initial Catalog=Pharmacy;Integrated Security=True")
        cn.Open()
        cn.Close()
    End Sub
End Class
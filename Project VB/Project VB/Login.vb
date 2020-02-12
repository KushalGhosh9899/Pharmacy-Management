Imports System.Data.SqlClient
Imports System.Data
Public Class Login
    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HelpandSupport.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        da = New SqlDataAdapter
        dt = New DataTable
        cmd = New SqlCommand("select * from signup where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "' ", cn)
        cn.Open()
        da.SelectCommand = cmd
        da.Fill(dt)
        cn.Close()

        If dt.Rows.Count > 0 Then
            MessageBox.Show("Login Successful")
            Shopping.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Username and Password, Please try again")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=DESKTOP-65VG5F2\KUSHAL123;Initial Catalog=Pharmacy;Integrated Security=True")
        cn.Open()
        cn.Close()
    End Sub
End Class
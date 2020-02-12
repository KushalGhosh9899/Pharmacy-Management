Public Class Shopping

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HelpandSupport.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Payment.Show()
        Me.Hide()
    End Sub

    Private Sub Shopping_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        TextBox12.Enabled = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Enabled = True
            TextBox1.Enabled = True
            TextBox7.Enabled = True
            TextBox7.Focus()
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox2.Enabled = True
            TextBox2.Enabled = True
            TextBox8.Enabled = True
            TextBox8.Focus()
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox3.Enabled = True
            TextBox3.Enabled = True
            TextBox9.Enabled = True
            TextBox9.Focus()
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox4.Enabled = True
            TextBox4.Enabled = True
            TextBox10.Enabled = True
            TextBox10.Focus()
        End If

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox5.Enabled = True
            TextBox5.Enabled = True
            TextBox11.Enabled = True
            TextBox11.Focus()
        End If

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            CheckBox1.Enabled = True
            TextBox6.Enabled = True
            TextBox12.Enabled = True
            TextBox12.Focus()
        End If

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        TextBox1.Text = 150 * Val(TextBox7.Text)
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        TextBox2.Text = 200 * Val(TextBox8.Text)
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        TextBox3.Text = 250 * Val(TextBox9.Text)
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        TextBox4.Text = 300 * Val(TextBox10.Text)
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        TextBox5.Text = 350 * Val(TextBox11.Text)
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        TextBox6.Text = 400 * Val(TextBox12.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label5.Text = "Rs " & (Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text))
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Payment.Show()
        Me.Hide()
    End Sub
End Class
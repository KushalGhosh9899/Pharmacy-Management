Public Class UserUtility
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        signup.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        onetimeuser.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        HelpandSupport.Show()
    End Sub
End Class
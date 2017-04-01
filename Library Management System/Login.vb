Public Class Login

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtlevel.Text = "Librarian" Then
            Librarian.Show()
            Me.Hide()
        End If

        If txtlevel.Text = "Adminstrator" Then
            Admin.Show()
            Me.Hide()
        End If
    End Sub
End Class

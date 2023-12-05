Public Class Login
    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        If txt_username.Text = "admin" And txt_pwd.Text = "1234" Then
            Me.Hide()
            frm_main.WindowState = FormWindowState.Maximized
            frm_main.Show()
        Else
            txt_pwd.Clear()
            txt_username.Clear()
            MsgBox("verifier vos informations ")
        End If
    End Sub
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        txt_username.Clear()
        txt_pwd.Clear()
    End Sub
End Class
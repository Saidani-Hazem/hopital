Public Class ajout_patient
    Public Sub sup()
        txt_code.Clear()
        txt_nom.Clear()
        txt_prenom.Clear()
    End Sub
    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Close()
        frm_main.WindowState = FormWindowState.Maximized
        frm_main.Show()
    End Sub
    Private Sub txt_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        Dim p As d_patient
        If ((txt_code.Text = "") Or (txt_nom.Text = "") Or (txt_prenom.Text = "")) Then
            MsgBox("tous les champs sont obligatoires ")
        Else
            txt_code.Text = CODE()
            p.code = txt_code.Text
            p.nom = txt_nom.Text
            p.prenom = txt_prenom.Text
            ajoutpatient(p)
            sup()
            txt_code.Text = CODE()

        End If
    End Sub

    Private Sub ajout_patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_code.Text = CODE()
    End Sub
End Class
Public Class frm_main
    Private Sub AjoutPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutPatientToolStripMenuItem.Click
        Me.Close()
        ajout_patient.WindowState = FormWindowState.Maximized
        ajout_patient.Show()
    End Sub
    Private Sub AffichePatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AffichePatientToolStripMenuItem.Click
        Me.Close()
        affichepa.WindowState = FormWindowState.Maximized
        affichepa.Show()
    End Sub
    Private Sub RdvDeJourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RdvDeJourToolStripMenuItem.Click
        Me.Close()
        affiche_rdv.WindowState = FormWindowState.Maximized
        affiche_rdv.Show()
    End Sub

    Private Sub AjoutRdvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutRdvToolStripMenuItem.Click
        Me.Close()
        ajout_rdv.WindowState = FormWindowState.Maximized
        ajout_rdv.Show()
    End Sub
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_rech.Text = "*"
    End Sub
    Private Sub btn_rech_Click(sender As Object, e As EventArgs) Handles btn_rech.Click
        Dim nom As String = txt_rech.Text
        If (nom = Nothing) Then
            MsgBox("Taper un nom de patient. ou ' * ' pour afficher tous")
        ElseIf (nom = "*") Then
            ajoutRT()
            AffTtRT(dgv_resultat)
            majrt()
        Else
            ajoutRT()
            AffRT(dgv_resultat, nom)
            majrt()
        End If
    End Sub
End Class

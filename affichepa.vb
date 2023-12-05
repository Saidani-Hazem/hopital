Public Class affichepa
    Private Sub affichepa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Affpatient(dgv_patient)
    End Sub
    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Close()
        frm_main.WindowState = FormWindowState.Maximized
        frm_main.Show()
    End Sub
    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        If (dgv_patient.SelectedRows.Count <= 0) Then
            MsgBox("selectioner un patient pour le supprimer")
        Else
            Dim pa As Integer = dgv_patient.SelectedRows(0).Cells("Code").Value
            supppatient(pa)
            MsgBox("ce patient a ete supprimer")
            Affpatient(dgv_patient)
        End If
    End Sub
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        dgv_patient.ClearSelection()
    End Sub
End Class
Public Class affiche_rdv
    Private Sub affiche_rdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Affrdv(dgv_rdv)
    End Sub
    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Close()
        frm_main.WindowState = FormWindowState.Maximized
        frm_main.Show()
    End Sub
    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        If (dgv_rdv.SelectedRows.Count <= 0) Then
            MsgBox("selectioner un rdv pour le supprimer ")
        Else
            Dim item As Integer = dgv_rdv.SelectedRows(0).Cells("CODE").Value
            suppprdv(item)
            MsgBox("supprimer avec succes")
            Affrdv(dgv_rdv)
        End If
    End Sub
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        dgv_rdv.ClearSelection()
    End Sub
End Class
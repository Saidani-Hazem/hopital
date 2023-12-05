Public Class ajout_rdv
    Private Sub btn_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        Dim r As d_rdv
        If (txt_code.Text = "") Then
            MsgBox("remplir le code")
        Else
            r.code = txt_code.Text
            r.datee = dt_date.Value
            r.heure = dt_heure.Value
            Affpatient(affichepa.dgv_patient)
            For index As Integer = 1 To affichepa.dgv_patient.Rows.Count
                Dim val As Object = affichepa.dgv_patient.Rows(index - 1).Cells("CODE").Value
                If (r.code = val) Then
                    ajoutRDV(r)
                    MsgBox("ajouter avec succes")
                    Exit For
                Else
                    index = index
                End If
                If (index = affichepa.dgv_patient.Rows.Count - 1 Or r.code = 0) Then
                    MsgBox("ce patient n'existe pas")
                    Exit For
                End If
            Next
            txt_code.Clear()
        End If
    End Sub
    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Close()
        frm_main.WindowState = FormWindowState.Maximized
        frm_main.Show()
    End Sub
    Private Sub ajout_rdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_date.MinDate = DateTime.Now.AddDays(1)
        dt_date.MaxDate = DateTime.Now.AddDays(30)
        dt_heure.Format = DateTimePickerFormat.Custom
        dt_heure.CustomFormat = "HH:mm"
        Affpatient(affichepa.dgv_patient)
    End Sub
End Class
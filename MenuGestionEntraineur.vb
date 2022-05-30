Public Class MenuGestionEntraineur
    Private Sub Cmd_Ajouter_Click(sender As Object, e As EventArgs) Handles Cmd_Ajouter.Click
        Frm_GestionEntraineur_AJ.Show()

    End Sub

    Private Sub Cmd_Modifier_Supprimer_Click(sender As Object, e As EventArgs) Handles Cmd_Modifier_Supprimer.Click
        Frm_GestionEntraineur_MS.Show()

    End Sub

    Private Sub Cmd_Fermer_Click(sender As Object, e As EventArgs) Handles Cmd_Fermer.Click
        Me.Close()
    End Sub

    Private Sub MenuGestionEntraineur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
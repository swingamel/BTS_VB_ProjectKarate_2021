Public Class EspaceEntraineur
    Private Sub EspaceEntraineur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cmd_Ajouter_Click(sender As Object, e As EventArgs) Handles Cmd_Ajouter.Click
        MenuGestionEntraineur.Show()

    End Sub

    Private Sub Cmd_Modifier_Supprimer_Click(sender As Object, e As EventArgs) Handles Cmd_Modifier_Supprimer.Click
        MenuAffectationEntraineur.Show()

    End Sub

    Private Sub Cmd_Fermer_Click(sender As Object, e As EventArgs) Handles Cmd_Fermer.Click
        Frm_Affichage_Global.Show()

    End Sub
End Class
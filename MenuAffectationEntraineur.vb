Public Class MenuAffectationEntraineur
    Private Sub Cmd_Ajouter_Click(sender As Object, e As EventArgs) Handles Cmd_Ajouter.Click
        Frm_AffectationEntraineur_AJ.Show()

    End Sub

    Private Sub Cmd_Modifier_Supprimer_Click(sender As Object, e As EventArgs) Handles Cmd_Modifier_Supprimer.Click
        Frm_AffectationEntraineur_MS.Show()

    End Sub

    Private Sub Cmd_Fermer_Click(sender As Object, e As EventArgs) Handles Cmd_Fermer.Click
        Me.Close()
    End Sub

End Class
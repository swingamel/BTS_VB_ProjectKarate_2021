Imports System.Data.OleDb

Public Class Frm_Affichage_Global
    Dim idMembre As Double
    Private Sub Frm_Affichage_Global_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Grid_Global_Membre.ColumnCount = 4
        Grid_Global_Membre.Columns(0).Width = 100
        Grid_Global_Membre.Columns(1).Width = 190
        Grid_Global_Membre.Columns(2).Width = 190
        Grid_Global_Membre.Columns(3).Width = 100
        Grid_Global_Membre.Columns(0).Name = "Numéro de licence"
        Grid_Global_Membre.Columns(1).Name = "Nom du membre"
        Grid_Global_Membre.Columns(2).Name = "Prénom du membre"
        Grid_Global_Membre.Columns(3).Name = "Numéro du club"

        Grid_Global_Membre.AllowUserToAddRows = False
        Grid_Global_Membre.Columns("Numéro de licence").Visible = False
        Grid_Global_Membre.Columns("Numéro du club").Visible = False

        Dim req As String
        req = "SELECT * from MEMBRE ORDER BY NOM_MEMBRE"
        Dim cmdRech As New OleDbCommand(req, maConnexion)

        Dim rdrRech As OleDbDataReader = cmdRech.ExecuteReader()
        While rdrRech.Read()
            Grid_Global_Membre.Rows.Add()
            Dim numLigne = Grid_Global_Membre.RowCount - 1
            Grid_Global_Membre.Item(0, numLigne).Value = rdrRech.Item("NUM_LICENCE")
            Grid_Global_Membre.Item(1, numLigne).Value = rdrRech.Item("NOM_MEMBRE")
            Grid_Global_Membre.Item(2, numLigne).Value = rdrRech.Item("PRENOM_MEMBRE")
            Grid_Global_Membre.Item(3, numLigne).Value = rdrRech.Item("NUM_CLUB")
        End While
    End Sub

    Public Id_Membre As Double
    Private Sub Grid_Global_Membre_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Global_Membre.CellContentClick
        idMembre = Me.Grid_Global_Membre.Item(0, Me.Grid_Global_Membre.CurrentRow.Index).Value
        Id_Membre = idMembre
    End Sub
    Private Sub Cmd_Afficher_Click(sender As Object, e As EventArgs) Handles Cmd_Afficher.Click
        Frm_Affichage_Global_Resultat.Show()
    End Sub
    Private Sub Cmd_Fermer_Click(sender As Object, e As EventArgs) Handles Cmd_Fermer.Click
        Close()
    End Sub

End Class
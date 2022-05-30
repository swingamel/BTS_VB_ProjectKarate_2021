Imports System.Data.OleDb

Public Class Frm_Affichage_Global_Resultat
    Dim Id_Membre As Double = Frm_Affichage_Global.Id_Membre

    Private Sub Frm_Affichage_Global_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grid_Résultat_Bilan.ColumnCount = 4
        Grid_Résultat_Bilan.Columns(0).Width = 100
        Grid_Résultat_Bilan.Columns(1).Width = 150
        Grid_Résultat_Bilan.Columns(2).Width = 200
        Grid_Résultat_Bilan.Columns(3).Width = 100
        Grid_Résultat_Bilan.Columns(0).Name = "Numéro de la compétition"
        Grid_Résultat_Bilan.Columns(1).Name = "Date de la compétition"
        Grid_Résultat_Bilan.Columns(2).Name = "Adresse, ville et code postal du CLub"
        Grid_Résultat_Bilan.Columns(3).Name = "Note globale"

        Dim req As String
        req = "SELECT DATE_COMPETITION, INSCRIPTION.NUM_COMPETITION, ADR_RUE_CLUB, CODE_POST_CLUB, CLUB.ADR_VILLE_CLUB, INSCRIPTION.NOTE_GLOBALE
               FROM (CLUB INNER JOIN COMPETITION ON CLUB.NUM_CLUB = COMPETITION.NUM_CLUB)INNER JOIN INSCRIPTION ON COMPETITION.NUM_COMPETITION = INSCRIPTION.NUM_COMPETITION
               WHERE (((INSCRIPTION.NUM_LICENCE)=[@id]))
               ORDER BY INSCRIPTION.NUM_COMPETITION"

        Dim cmdRech As New OleDbCommand(req, maConnexion)

        cmdRech.Parameters.AddWithValue("@id", Id_Membre)

        Dim rdrRech As OleDbDataReader = cmdRech.ExecuteReader()
        While rdrRech.Read()
            Grid_Résultat_Bilan.Rows.Add()
            Dim numLigne = Grid_Résultat_Bilan.RowCount - 1
            Grid_Résultat_Bilan.Item(0, numLigne).Value = rdrRech.Item("NUM_COMPETITION")
            Grid_Résultat_Bilan.Item(1, numLigne).Value = rdrRech.Item("DATE_COMPETITION")
            Grid_Résultat_Bilan.Item(2, numLigne).Value = rdrRech.Item("ADR_RUE_CLUB") + " " + rdrRech.Item("CODE_POST_CLUB") + " " + rdrRech.Item("ADR_VILLE_CLUB")
            Grid_Résultat_Bilan.Item(3, numLigne).Value = rdrRech.Item("NOTE_GLOBALE")
        End While

    End Sub
End Class
Imports System.Data.OleDb

Public Class Frm_AffectationEntraineur_MS
    Private Sub Frm_AffectationEntraineur_MS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connexion("bdKarate.accdb")
        Grid_Entraineur.ColumnCount = 3
        Grid_Entraineur.Columns(0).Width = 100
        Grid_Entraineur.Columns(1).Width = 180
        Grid_Entraineur.Columns(2).Width = 180
        Grid_Entraineur.Columns(0).Name = "Numéro"
        Grid_Entraineur.Columns(1).Name = "Nom"
        Grid_Entraineur.Columns(2).Name = "Prénom"
        '** Evite d'avoir une ligne blanche en fin, destinée à la 
        '** saisie d'une nouvelle ligne 
        Grid_Entraineur.AllowUserToAddRows = False
        Dim req As String
        req = "select NUM_ENTRAINEUR, NOM_ENTRAINEUR, PRENOM_ENTRAINEUR from ENTRAINEUR "

        'On déclare une variable de type objet "Command" qui exécute une commande (requête SQL) sur la base de données
        Dim cmdRech As New OleDbCommand(req, maConnexion)

        'On déclare une variable de type objet "DataReader" qui récupère les enregistrements de la requête de type SELECT

        Dim rdrRech As OleDbDataReader = cmdRech.ExecuteReader()
        Dim numLigne As Integer
        While (rdrRech.Read())
            Grid_Entraineur.Rows.Add()
            numLigne = Grid_Entraineur.RowCount - 1
            Grid_Entraineur.Item(0, numLigne).Value = rdrRech.Item("NUM_ENTRAINEUR")
            Grid_Entraineur.Item(1, numLigne).Value = rdrRech.Item("NOM_ENTRAINEUR")
            Grid_Entraineur.Item(2, numLigne).Value = rdrRech.Item("PRENOM_ENTRAINEUR")

        End While

        Grid_Competition.ColumnCount = 3
        Grid_Competition.Columns(0).Width = 200
        Grid_Competition.Columns(1).Width = 200
        Grid_Competition.Columns(2).Width = 200
        Grid_Competition.Columns(0).Name = "Numero de la competition"
        Grid_Competition.Columns(1).Name = "Date de la competition"
        Grid_Competition.Columns(2).Name = "Numero du jury"
        '** Evite d'avoir une ligne blanche en fin, destinée à la 
        '** saisie d'une nouvelle ligne 
        Grid_Competition.AllowUserToAddRows = False
        Grid_Competition.Columns("Numero du jury").Visible = False

    End Sub

    Private Sub Grid_Entraineur_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Entraineur.CellContentClick
        Dim req1 As String
        req1 = "select NUM_COMPETITION, DATE_COMPETITION FROM COMPETITION WHERE NUM_COMPETITION IN(select NUM_COMPETITION from JUGE where NUM_ENTRAINEUR = @numE)"

        'On déclare une variable de type objet "Command" qui exécute une commande (requête SQL) sur la base de données
        Dim cmdRech1 As New OleDbCommand(req1, maConnexion)

        'On déclare une variable de type objet "DataReader" qui récupère les enregistrements de la requête de type SELECT
        cmdRech1.Parameters.AddWithValue("@numE", Me.Grid_Entraineur.Item(0, Grid_Entraineur.CurrentRow.Index).Value)

        Dim rdrRech1 As OleDbDataReader = cmdRech1.ExecuteReader()
        Dim numLigne1 As Integer

        Grid_Competition.Rows.Clear()
        While (rdrRech1.Read())
            Grid_Competition.Rows.Add()
            numLigne1 = Grid_Competition.RowCount - 1
            Grid_Competition.Item(0, numLigne1).Value = rdrRech1.Item("NUM_COMPETITION")
            Grid_Competition.Item(1, numLigne1).Value = rdrRech1.Item("DATE_COMPETITION")
        End While

    End Sub
    Private Sub Txt_Jury_TextChanged(sender As Object, e As EventArgs) Handles Txt_Jury.TextChanged
        Dim req As String
        req = "SELECT MAX (NUM_JURY) FROM JUGE WHERE NUM_COMPETITION = @numC"

        Dim cmdRech As New OleDbCommand(req, maConnexion)

        cmdRech.Parameters.AddWithValue("@numC", Me.Grid_Competition.Item(0, Grid_Competition.CurrentRow.Index).Value)

        Dim rdrRech As OleDbDataReader = cmdRech.ExecuteReader()
    End Sub

    Private Sub Cmd_Modifier_Click(sender As Object, e As EventArgs) Handles Cmd_Modifier.Click
        Dim req As String
        req = "UPDATE JUGE SET NUM_JURY = @numJ WHERE NUM_COMPETITION = @numC and NUM_ENTRAINEUR = @numE"
        'On déclare une variable de type objet "Command" qui exécute une commande (requête SQL) sur la base de données
        Dim cmdUpdate As New OleDbCommand(req, maConnexion)
        'Passage des paramètres
        cmdUpdate.Parameters.AddWithValue("@numJ", Txt_Jury.Text)
        cmdUpdate.Parameters.AddWithValue("@numC", Me.Grid_Competition.Item(0, Grid_Competition.CurrentRow.Index).Value)
        cmdUpdate.Parameters.AddWithValue("@numE", Me.Grid_Entraineur.Item(0, Grid_Entraineur.CurrentRow.Index).Value)
        'On exécute la requête dans la base de données
        cmdUpdate.ExecuteNonQuery()

        MsgBox("L'affectation d'un entraineur à une compétition a bien été modifiée... ")
        Me.Close()

    End Sub

    Private Sub Cmd_Supprimer_Click(sender As Object, e As EventArgs) Handles Cmd_Supprimer.Click
        Dim req As String
        req = "DELETE FROM JUGE WHERE NUM_COMPETITION = @numC and NUM_ENTRAINEUR = @numE"
        'On déclare une variable de type objet "Command" qui exécute une commande (requête SQL) sur la base de données
        Dim cmdDelete As New OleDbCommand(req, maConnexion)
        'Passage des paramètres
        cmdDelete.Parameters.AddWithValue("@numC", Me.Grid_Competition.Item(0, Grid_Competition.CurrentRow.Index).Value)
        cmdDelete.Parameters.AddWithValue("@numE", Me.Grid_Entraineur.Item(0, Grid_Entraineur.CurrentRow.Index).Value)

        'On exécute la requête dans la base de données
        cmdDelete.ExecuteNonQuery()

        MsgBox("L'affectation d'un entraineur à une compétition a bien été suprimée... ")
        Me.Close()

    End Sub

    Private Sub Cmd_Fermer_Click(sender As Object, e As EventArgs) Handles Cmd_Fermer.Click
        Me.Close()

    End Sub
End Class
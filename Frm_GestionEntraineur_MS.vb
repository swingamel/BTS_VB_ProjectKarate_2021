Imports System.Data.OleDb

Public Class Frm_GestionEntraineur_MS
    Private Sub Frm_GestionEntraineur_MS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connexion("bdKarate.accdb")
        Grid_Entraineur.ColumnCount = 3
        Grid_Entraineur.Columns(0).Width = 200
        Grid_Entraineur.Columns(1).Width = 200
        Grid_Entraineur.Columns(2).Width = 200
        Grid_Entraineur.Columns(0).Name = "Nom"
        Grid_Entraineur.Columns(1).Name = "Prénom"
        Grid_Entraineur.Columns(2).Name = "Numero"
        '** Evite d'avoir une ligne blanche en fin, destinée à la 
        '** saisie d'une nouvelle ligne 
        Grid_Entraineur.AllowUserToAddRows = False
        Grid_Entraineur.Columns("Numero").Visible = False
        Dim req As String
        req = "select * from ENTRAINEUR"

        'On déclare une variable de type objet "Command" qui exécute une commande (requête SQL) sur la base de données
        Dim cmdRech As New OleDbCommand(req, maConnexion)

        'On déclare une variable de type objet "DataReader" qui récupère les enregistrements de la requête de type SELECT
        Dim rdrRech As OleDbDataReader = cmdRech.ExecuteReader()
        Dim numLigne As Integer
        While (rdrRech.Read())
            Grid_Entraineur.Rows.Add()
            numLigne = Grid_Entraineur.RowCount - 1
            Grid_Entraineur.Item(0, numLigne).Value = rdrRech.Item("NOM_ENTRAINEUR")
            Grid_Entraineur.Item(1, numLigne).Value = rdrRech.Item("PRENOM_ENTRAINEUR")
            Grid_Entraineur.Item(2, numLigne).Value = rdrRech.Item("NUM_ENTRAINEUR")

        End While
    End Sub

    Private Sub Grid_Entraineur_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Entraineur.CellContentClick
        Dim numLigne As Integer
        numLigne = Grid_Entraineur.CurrentRow.Index
        Txt_Nom.Text = Grid_Entraineur.Item(0, numLigne).Value
        Txt_Prenom.Text = Grid_Entraineur.Item(1, numLigne).Value

    End Sub

    Private Sub Cmd_Modifier_Click(sender As Object, e As EventArgs) Handles Cmd_Modifier.Click
        Dim req As String
        req = "UPDATE ENTRAINEUR SET NOM_ENTRAINEUR = @nom, PRENOM_ENTRAINEUR = @prenom WHERE NUM_ENTRAINEUR = @num"
        'On déclare une variable de type objet "Command" qui exécute une commande (requête SQL) sur la base de données
        Dim cmdUpdate As New OleDbCommand(req, maConnexion)
        'Passage des paramètres
        cmdUpdate.Parameters.AddWithValue("@nom", Txt_Nom.Text)
        cmdUpdate.Parameters.AddWithValue("@prenom", Txt_Prenom.Text)
        cmdUpdate.Parameters.AddWithValue("@num", Me.Grid_Entraineur.Item(2, Grid_Entraineur.CurrentRow.Index).Value)

        'On exécute la requête dans la base de données
        cmdUpdate.ExecuteNonQuery()

        MsgBox("Entraineur modifié...")
        Me.Close()
    End Sub
    Private Sub Cmd_Supprimer_Click(sender As Object, e As EventArgs) Handles Cmd_Supprimer.Click
        Dim req As String
        req = "DELETE FROM ENTRAINEUR WHERE NOM_ENTRAINEUR = @nom and PRENOM_ENTRAINEUR = @prenom"
        'On déclare une variable de type objet "Command" qui exécute une commande (requête SQL) sur la base de données
        Dim cmdDelete As New OleDbCommand(req, maConnexion)
        'Passage des paramètres
        cmdDelete.Parameters.AddWithValue("@nom", Me.Grid_Entraineur.Item(0, Grid_Entraineur.CurrentRow.Index).Value)
        cmdDelete.Parameters.AddWithValue("@prenom", Me.Grid_Entraineur.Item(1, Grid_Entraineur.CurrentRow.Index).Value)

        'On exécute la requête dans la base de données
        cmdDelete.ExecuteNonQuery()

        MsgBox("Entraineur supprimé...")
        Me.Close()
    End Sub
    Private Sub Cmd_Fermer_Click(sender As Object, e As EventArgs) Handles Cmd_Fermer.Click
        Me.Close()
    End Sub

End Class
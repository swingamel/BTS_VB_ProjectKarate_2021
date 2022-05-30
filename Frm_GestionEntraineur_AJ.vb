Imports System.Data.OleDb

Public Class Frm_GestionEntraineur_AJ
    Private Sub Frm_GestionEntraineur_AJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connexion("bdKarate.accdb")
        Grid_Entraineur.ColumnCount = 2
        Grid_Entraineur.Columns(0).Width = 90
        Grid_Entraineur.Columns(1).Width = 200
        Grid_Entraineur.Columns(0).Name = "Numéro du Club"
        Grid_Entraineur.Columns(1).Name = "Nom du Club"
        '** Evite d'avoir une ligne blanche en fin, destinée à la 
        '** saisie d'une nouvelle ligne 
        Grid_Entraineur.AllowUserToAddRows = False
        Dim req As String
        req = "select * from CLUB"

        'On déclare une variable de type objet "Command" qui exécute une commande (requête SQL) sur la base de données
        Dim cmdRech As New OleDbCommand(req, maConnexion)

        'On déclare une variable de type objet "DataReader" qui récupère les enregistrements de la requête de type SELECT
        Dim rdrRech As OleDbDataReader = cmdRech.ExecuteReader()
        Dim numLigne As Integer
        While (rdrRech.Read())
            Grid_Entraineur.Rows.Add()
            numLigne = Grid_Entraineur.RowCount - 1
            Grid_Entraineur.Item(0, numLigne).Value = rdrRech.Item("NUM_CLUB")
            Grid_Entraineur.Item(1, numLigne).Value = rdrRech.Item("NOM_CLUB")
        End While


    End Sub

    Private Sub Cmd_Ajouter_Click(sender As Object, e As EventArgs) Handles Cmd_Ajouter.Click
        Dim req As String
        req = "insert into ENTRAINEUR values (@num, @club, @nom, @prenom)"

        'On déclare une variable de type objet "Command" qui exécute une commande (requête SQL) sur la base de données
        Dim cmdInsert As New OleDbCommand(req, maConnexion)

        'Passage des paramètres
        cmdInsert.Parameters.AddWithValue("@num", Txt_NumEntraineur.Text)
        cmdInsert.Parameters.AddWithValue("@club", Me.Grid_Entraineur.Item(0, Grid_Entraineur.CurrentRow.Index).Value)
        cmdInsert.Parameters.AddWithValue("@nom", Txt_Nom.Text)
        cmdInsert.Parameters.AddWithValue("@prenom", Txt_Prenom.Text)

        'On exécute la requête dans la base de données
        cmdInsert.ExecuteNonQuery()

        MsgBox("Entraineur créé...")
        Me.Close()
    End Sub

    Private Sub Cmd_Fermer_Click(sender As Object, e As EventArgs) Handles Cmd_Fermer.Click
        Me.Close()
    End Sub
End Class
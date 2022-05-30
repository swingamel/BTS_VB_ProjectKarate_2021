Imports System.Data.OleDb
Module ModuleConnexion
    Public maConnexion As New OleDbConnection()

    Public Sub connexion(ByVal nombd As String)
        Try
            maConnexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; data source = " &
                                Application.StartupPath & "\" & nombd
            maConnexion.Open()
        Catch ex As Exception
            MessageBox.Show("Impossible d'établir la connexion à la base." & ex.Message)
        End Try
    End Sub

    Public Sub deconnexion()
        Try
            maConnexion.Close()
        Catch ex As Exception
            MessageBox.Show("Impossible d'établir la connexion à la base." & ex.Message)
        End Try
    End Sub
End Module
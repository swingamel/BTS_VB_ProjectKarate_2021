<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Affichage_Global
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Grid_Global_Membre = New System.Windows.Forms.DataGridView()
        Me.Cmd_Afficher = New System.Windows.Forms.Button()
        Me.Cmd_Fermer = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NomMembre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomMembre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grid_Global_Membre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid_Global_Membre
        '
        Me.Grid_Global_Membre.AllowUserToAddRows = False
        Me.Grid_Global_Membre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Global_Membre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomMembre, Me.PrenomMembre})
        Me.Grid_Global_Membre.Location = New System.Drawing.Point(16, 15)
        Me.Grid_Global_Membre.Name = "Grid_Global_Membre"
        Me.Grid_Global_Membre.Size = New System.Drawing.Size(475, 166)
        Me.Grid_Global_Membre.TabIndex = 0
        '
        'Cmd_Afficher
        '
        Me.Cmd_Afficher.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Cmd_Afficher.Location = New System.Drawing.Point(27, 14)
        Me.Cmd_Afficher.Name = "Cmd_Afficher"
        Me.Cmd_Afficher.Size = New System.Drawing.Size(150, 46)
        Me.Cmd_Afficher.TabIndex = 1
        Me.Cmd_Afficher.Text = "AFFICHER"
        Me.Cmd_Afficher.UseVisualStyleBackColor = True
        '
        'Cmd_Fermer
        '
        Me.Cmd_Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Cmd_Fermer.Location = New System.Drawing.Point(296, 14)
        Me.Cmd_Fermer.Name = "Cmd_Fermer"
        Me.Cmd_Fermer.Size = New System.Drawing.Size(150, 46)
        Me.Cmd_Fermer.TabIndex = 2
        Me.Cmd_Fermer.Text = "FERMER"
        Me.Cmd_Fermer.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(27, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(736, 60)
        Me.Panel4.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label3.Location = New System.Drawing.Point(1, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(732, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "AFFICHAGE D'UN BILAN GLOBAL SUR UNE SAISON POUR UN COMPETITEUR DONNÉ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Grid_Global_Membre)
        Me.Panel1.Location = New System.Drawing.Point(128, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(508, 202)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Cmd_Fermer)
        Me.Panel2.Controls.Add(Me.Cmd_Afficher)
        Me.Panel2.Location = New System.Drawing.Point(145, 309)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(475, 69)
        Me.Panel2.TabIndex = 23
        '
        'NomMembre
        '
        Me.NomMembre.HeaderText = "Nom du Membre"
        Me.NomMembre.Name = "NomMembre"
        Me.NomMembre.Width = 200
        '
        'PrenomMembre
        '
        Me.PrenomMembre.HeaderText = "Prenom du Membre "
        Me.PrenomMembre.Name = "PrenomMembre"
        Me.PrenomMembre.Width = 200
        '
        'Frm_Affichage_Global
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 393)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "Frm_Affichage_Global"
        Me.Text = "Frm_Affichage_Global_1"
        CType(Me.Grid_Global_Membre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grid_Global_Membre As DataGridView
    Friend WithEvents Cmd_Afficher As Button
    Friend WithEvents Cmd_Fermer As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NomMembre As DataGridViewTextBoxColumn
    Friend WithEvents PrenomMembre As DataGridViewTextBoxColumn
End Class

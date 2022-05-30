<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Affichage_Global_Resultat
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Grid_Résultat_Bilan = New System.Windows.Forms.DataGridView()
        Me.NumCompetition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCompetition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresseCompetition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteGlobale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Grid_Résultat_Bilan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid_Résultat_Bilan
        '
        Me.Grid_Résultat_Bilan.AllowUserToAddRows = False
        Me.Grid_Résultat_Bilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Résultat_Bilan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumCompetition, Me.DateCompetition, Me.AdresseCompetition, Me.NoteGlobale})
        Me.Grid_Résultat_Bilan.Location = New System.Drawing.Point(101, 90)
        Me.Grid_Résultat_Bilan.Name = "Grid_Résultat_Bilan"
        Me.Grid_Résultat_Bilan.Size = New System.Drawing.Size(596, 145)
        Me.Grid_Résultat_Bilan.TabIndex = 4
        '
        'NumCompetition
        '
        Me.NumCompetition.HeaderText = "Numéro de la Competition"
        Me.NumCompetition.Name = "NumCompetition"
        '
        'DateCompetition
        '
        Me.DateCompetition.HeaderText = "Date de la Competition"
        Me.DateCompetition.Name = "DateCompetition"
        '
        'AdresseCompetition
        '
        Me.AdresseCompetition.HeaderText = "Adresse de la Competition"
        Me.AdresseCompetition.Name = "AdresseCompetition"
        '
        'NoteGlobale
        '
        Me.NoteGlobale.HeaderText = "Note Globale"
        Me.NoteGlobale.Name = "NoteGlobale"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(31, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(736, 60)
        Me.Panel4.TabIndex = 22
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
        'Frm_Affichage_Global_Resultat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 256)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Grid_Résultat_Bilan)
        Me.Name = "Frm_Affichage_Global_Resultat"
        Me.Text = "Frm_Affichage_Global_2"
        CType(Me.Grid_Résultat_Bilan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grid_Résultat_Bilan As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents NumCompetition As DataGridViewTextBoxColumn
    Friend WithEvents DateCompetition As DataGridViewTextBoxColumn
    Friend WithEvents AdresseCompetition As DataGridViewTextBoxColumn
    Friend WithEvents NoteGlobale As DataGridViewTextBoxColumn
End Class

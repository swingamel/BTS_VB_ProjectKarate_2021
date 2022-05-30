<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AffectationEntraineur_MS
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Grid_Competition = New System.Windows.Forms.DataGridView()
        Me.NumCompétition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCompétition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grid_Entraineur = New System.Windows.Forms.DataGridView()
        Me.NumEntraineur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomEntraineur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrénomEntraineur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Jury = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Cmd_Supprimer = New System.Windows.Forms.Button()
        Me.Cmd_Modifier = New System.Windows.Forms.Button()
        Me.Cmd_Fermer = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Grid_Competition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_Entraineur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(47, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(709, 68)
        Me.Panel1.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(674, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "AFFECTATION DES ENTRAINEURS (MODIFIER / SUPPRIMER)"
        '
        'Grid_Competition
        '
        Me.Grid_Competition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Competition.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumCompétition, Me.DateCompétition})
        Me.Grid_Competition.Location = New System.Drawing.Point(81, 275)
        Me.Grid_Competition.Name = "Grid_Competition"
        Me.Grid_Competition.Size = New System.Drawing.Size(644, 172)
        Me.Grid_Competition.TabIndex = 27
        '
        'NumCompétition
        '
        Me.NumCompétition.HeaderText = "Numéro de la Compétition"
        Me.NumCompétition.Name = "NumCompétition"
        Me.NumCompétition.Width = 200
        '
        'DateCompétition
        '
        Me.DateCompétition.HeaderText = "Date de la compétition"
        Me.DateCompétition.Name = "DateCompétition"
        Me.DateCompétition.Width = 200
        '
        'Grid_Entraineur
        '
        Me.Grid_Entraineur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Entraineur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumEntraineur, Me.NomEntraineur, Me.PrénomEntraineur})
        Me.Grid_Entraineur.Location = New System.Drawing.Point(81, 97)
        Me.Grid_Entraineur.Name = "Grid_Entraineur"
        Me.Grid_Entraineur.Size = New System.Drawing.Size(644, 172)
        Me.Grid_Entraineur.TabIndex = 28
        '
        'NumEntraineur
        '
        Me.NumEntraineur.HeaderText = "Numéro de l'entraineur"
        Me.NumEntraineur.Name = "NumEntraineur"
        '
        'NomEntraineur
        '
        Me.NomEntraineur.HeaderText = "Nom de l'entraineur"
        Me.NomEntraineur.Name = "NomEntraineur"
        '
        'PrénomEntraineur
        '
        Me.PrénomEntraineur.HeaderText = "Prénom de l'entraineur"
        Me.PrénomEntraineur.Name = "PrénomEntraineur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 476)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 24)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "NUMERO DU JURY : "
        '
        'Txt_Jury
        '
        Me.Txt_Jury.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Txt_Jury.Location = New System.Drawing.Point(316, 476)
        Me.Txt_Jury.Name = "Txt_Jury"
        Me.Txt_Jury.Size = New System.Drawing.Size(154, 29)
        Me.Txt_Jury.TabIndex = 29
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Cmd_Supprimer)
        Me.Panel3.Controls.Add(Me.Cmd_Fermer)
        Me.Panel3.Controls.Add(Me.Cmd_Modifier)
        Me.Panel3.Location = New System.Drawing.Point(103, 523)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(584, 72)
        Me.Panel3.TabIndex = 32
        '
        'Cmd_Supprimer
        '
        Me.Cmd_Supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Supprimer.Location = New System.Drawing.Point(221, 19)
        Me.Cmd_Supprimer.Name = "Cmd_Supprimer"
        Me.Cmd_Supprimer.Size = New System.Drawing.Size(145, 36)
        Me.Cmd_Supprimer.TabIndex = 22
        Me.Cmd_Supprimer.Text = "SUPPRIMER"
        Me.Cmd_Supprimer.UseVisualStyleBackColor = True
        '
        'Cmd_Modifier
        '
        Me.Cmd_Modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Modifier.Location = New System.Drawing.Point(36, 19)
        Me.Cmd_Modifier.Name = "Cmd_Modifier"
        Me.Cmd_Modifier.Size = New System.Drawing.Size(145, 36)
        Me.Cmd_Modifier.TabIndex = 21
        Me.Cmd_Modifier.Text = "MODIFIER"
        Me.Cmd_Modifier.UseVisualStyleBackColor = True
        '
        'Cmd_Fermer
        '
        Me.Cmd_Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Fermer.Location = New System.Drawing.Point(402, 19)
        Me.Cmd_Fermer.Name = "Cmd_Fermer"
        Me.Cmd_Fermer.Size = New System.Drawing.Size(145, 36)
        Me.Cmd_Fermer.TabIndex = 20
        Me.Cmd_Fermer.Text = "FERMER"
        Me.Cmd_Fermer.UseVisualStyleBackColor = True
        '
        'Frm_AffectationEntraineur_MS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 607)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Jury)
        Me.Controls.Add(Me.Grid_Competition)
        Me.Controls.Add(Me.Grid_Entraineur)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_AffectationEntraineur_MS"
        Me.Text = "Frm_AffectationEntraineur_MS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Grid_Competition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_Entraineur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Grid_Competition As DataGridView
    Friend WithEvents NumCompétition As DataGridViewTextBoxColumn
    Friend WithEvents DateCompétition As DataGridViewTextBoxColumn
    Friend WithEvents Grid_Entraineur As DataGridView
    Friend WithEvents NumEntraineur As DataGridViewTextBoxColumn
    Friend WithEvents NomEntraineur As DataGridViewTextBoxColumn
    Friend WithEvents PrénomEntraineur As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Jury As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Cmd_Modifier As Button
    Friend WithEvents Cmd_Fermer As Button
    Friend WithEvents Cmd_Supprimer As Button
End Class

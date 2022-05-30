<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_GestionEntraineur_MS
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
        Me.Grid_Entraineur = New System.Windows.Forms.DataGridView()
        Me.Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cmd_Fermer = New System.Windows.Forms.Button()
        Me.Cmd_Supprimer = New System.Windows.Forms.Button()
        Me.Cmd_Modifier = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Prenom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Nom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.Grid_Entraineur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid_Entraineur
        '
        Me.Grid_Entraineur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Entraineur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num, Me.Nom})
        Me.Grid_Entraineur.Location = New System.Drawing.Point(16, 117)
        Me.Grid_Entraineur.Name = "Grid_Entraineur"
        Me.Grid_Entraineur.Size = New System.Drawing.Size(584, 239)
        Me.Grid_Entraineur.TabIndex = 17
        '
        'Num
        '
        Me.Num.HeaderText = "Nom de l'entraineur"
        Me.Num.Name = "Num"
        Me.Num.Width = 150
        '
        'Nom
        '
        Me.Nom.HeaderText = "Prenom de l'entraineur"
        Me.Nom.Name = "Nom"
        Me.Nom.Width = 150
        '
        'Cmd_Fermer
        '
        Me.Cmd_Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Fermer.Location = New System.Drawing.Point(387, 19)
        Me.Cmd_Fermer.Name = "Cmd_Fermer"
        Me.Cmd_Fermer.Size = New System.Drawing.Size(168, 36)
        Me.Cmd_Fermer.TabIndex = 20
        Me.Cmd_Fermer.Text = "FERMER"
        Me.Cmd_Fermer.UseVisualStyleBackColor = True
        '
        'Cmd_Supprimer
        '
        Me.Cmd_Supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Supprimer.Location = New System.Drawing.Point(203, 19)
        Me.Cmd_Supprimer.Name = "Cmd_Supprimer"
        Me.Cmd_Supprimer.Size = New System.Drawing.Size(168, 36)
        Me.Cmd_Supprimer.TabIndex = 21
        Me.Cmd_Supprimer.Text = "SUPPRIMER"
        Me.Cmd_Supprimer.UseVisualStyleBackColor = True
        '
        'Cmd_Modifier
        '
        Me.Cmd_Modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Modifier.Location = New System.Drawing.Point(20, 19)
        Me.Cmd_Modifier.Name = "Cmd_Modifier"
        Me.Cmd_Modifier.Size = New System.Drawing.Size(168, 36)
        Me.Cmd_Modifier.TabIndex = 22
        Me.Cmd_Modifier.Text = "MODIFIER"
        Me.Cmd_Modifier.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(57, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 68)
        Me.Panel1.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(618, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "GESTION DES ENTRAINEURS (MODIFIER / SUPPRIMER)"
        '
        'Txt_Prenom
        '
        Me.Txt_Prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Prenom.Location = New System.Drawing.Point(240, 62)
        Me.Txt_Prenom.Name = "Txt_Prenom"
        Me.Txt_Prenom.Size = New System.Drawing.Size(295, 29)
        Me.Txt_Prenom.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "PRENOM :"
        '
        'Txt_Nom
        '
        Me.Txt_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nom.Location = New System.Drawing.Point(240, 23)
        Me.Txt_Nom.Name = "Txt_Nom"
        Me.Txt_Nom.Size = New System.Drawing.Size(295, 29)
        Me.Txt_Nom.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "NOM : "
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Txt_Prenom)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Txt_Nom)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Grid_Entraineur)
        Me.Panel2.Location = New System.Drawing.Point(65, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(621, 372)
        Me.Panel2.TabIndex = 30
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Cmd_Modifier)
        Me.Panel3.Controls.Add(Me.Cmd_Supprimer)
        Me.Panel3.Controls.Add(Me.Cmd_Fermer)
        Me.Panel3.Location = New System.Drawing.Point(82, 486)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(584, 72)
        Me.Panel3.TabIndex = 31
        '
        'Frm_GestionEntraineur_MS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(741, 570)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_GestionEntraineur_MS"
        Me.Text = "Frm_GestionEntraineur_MS"
        CType(Me.Grid_Entraineur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid_Entraineur As DataGridView
    Friend WithEvents Cmd_Fermer As Button
    Friend WithEvents Cmd_Supprimer As Button
    Friend WithEvents Cmd_Modifier As Button
    Friend WithEvents Num As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Prenom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Nom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class

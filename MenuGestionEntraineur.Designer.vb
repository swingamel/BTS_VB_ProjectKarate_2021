<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGestionEntraineur
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Cmd_Fermer = New System.Windows.Forms.Button()
        Me.Cmd_Modifier_Supprimer = New System.Windows.Forms.Button()
        Me.Cmd_Ajouter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Cmd_Fermer)
        Me.Panel2.Controls.Add(Me.Cmd_Modifier_Supprimer)
        Me.Panel2.Controls.Add(Me.Cmd_Ajouter)
        Me.Panel2.Location = New System.Drawing.Point(32, 107)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(511, 324)
        Me.Panel2.TabIndex = 7
        '
        'Cmd_Fermer
        '
        Me.Cmd_Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Fermer.Location = New System.Drawing.Point(116, 223)
        Me.Cmd_Fermer.Name = "Cmd_Fermer"
        Me.Cmd_Fermer.Size = New System.Drawing.Size(263, 71)
        Me.Cmd_Fermer.TabIndex = 10
        Me.Cmd_Fermer.Text = "FERMER"
        Me.Cmd_Fermer.UseVisualStyleBackColor = True
        '
        'Cmd_Modifier_Supprimer
        '
        Me.Cmd_Modifier_Supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Modifier_Supprimer.Location = New System.Drawing.Point(116, 121)
        Me.Cmd_Modifier_Supprimer.Name = "Cmd_Modifier_Supprimer"
        Me.Cmd_Modifier_Supprimer.Size = New System.Drawing.Size(263, 71)
        Me.Cmd_Modifier_Supprimer.TabIndex = 9
        Me.Cmd_Modifier_Supprimer.Text = "MODIFIER / SUPPRIMER ENTRAINEUR"
        Me.Cmd_Modifier_Supprimer.UseVisualStyleBackColor = True
        '
        'Cmd_Ajouter
        '
        Me.Cmd_Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Ajouter.Location = New System.Drawing.Point(116, 26)
        Me.Cmd_Ajouter.Name = "Cmd_Ajouter"
        Me.Cmd_Ajouter.Size = New System.Drawing.Size(263, 71)
        Me.Cmd_Ajouter.TabIndex = 8
        Me.Cmd_Ajouter.Text = "AJOUTER ENTRAINEUR"
        Me.Cmd_Ajouter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(2, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(539, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "GESTION DES ENTRAINEURS (MENU)"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(12, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(546, 68)
        Me.Panel4.TabIndex = 13
        '
        'MenuGestionEntraineur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(571, 442)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuGestionEntraineur"
        Me.Text = "MenuEntraineur"
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Cmd_Fermer As Button
    Friend WithEvents Cmd_Modifier_Supprimer As Button
    Friend WithEvents Cmd_Ajouter As Button
End Class

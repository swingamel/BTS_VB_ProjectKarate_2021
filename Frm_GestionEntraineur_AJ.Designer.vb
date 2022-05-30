<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_GestionEntraineur_AJ
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Nom = New System.Windows.Forms.TextBox()
        Me.PRENOM = New System.Windows.Forms.Label()
        Me.Txt_Prenom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmd_Ajouter = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txt_NumEntraineur = New System.Windows.Forms.TextBox()
        Me.Grid_Entraineur = New System.Windows.Forms.DataGridView()
        Me.NumClub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomClub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Cmd_Fermer = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        CType(Me.Grid_Entraineur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOM : "
        '
        'Txt_Nom
        '
        Me.Txt_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nom.Location = New System.Drawing.Point(221, 70)
        Me.Txt_Nom.Name = "Txt_Nom"
        Me.Txt_Nom.Size = New System.Drawing.Size(295, 29)
        Me.Txt_Nom.TabIndex = 2
        '
        'PRENOM
        '
        Me.PRENOM.AutoSize = True
        Me.PRENOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRENOM.Location = New System.Drawing.Point(15, 109)
        Me.PRENOM.Name = "PRENOM"
        Me.PRENOM.Size = New System.Drawing.Size(103, 24)
        Me.PRENOM.TabIndex = 3
        Me.PRENOM.Text = "PRENOM :"
        '
        'Txt_Prenom
        '
        Me.Txt_Prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Prenom.Location = New System.Drawing.Point(221, 109)
        Me.Txt_Prenom.Name = "Txt_Prenom"
        Me.Txt_Prenom.Size = New System.Drawing.Size(295, 29)
        Me.Txt_Prenom.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NUM ENTRAINEUR : "
        '
        'Cmd_Ajouter
        '
        Me.Cmd_Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Ajouter.Location = New System.Drawing.Point(77, 12)
        Me.Cmd_Ajouter.Name = "Cmd_Ajouter"
        Me.Cmd_Ajouter.Size = New System.Drawing.Size(143, 42)
        Me.Cmd_Ajouter.TabIndex = 7
        Me.Cmd_Ajouter.Text = "AJOUTER"
        Me.Cmd_Ajouter.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Txt_NumEntraineur)
        Me.Panel1.Controls.Add(Me.Grid_Entraineur)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Txt_Prenom)
        Me.Panel1.Controls.Add(Me.PRENOM)
        Me.Panel1.Controls.Add(Me.Txt_Nom)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(120, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 345)
        Me.Panel1.TabIndex = 9
        '
        'Txt_NumEntraineur
        '
        Me.Txt_NumEntraineur.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NumEntraineur.Location = New System.Drawing.Point(221, 24)
        Me.Txt_NumEntraineur.Name = "Txt_NumEntraineur"
        Me.Txt_NumEntraineur.Size = New System.Drawing.Size(295, 29)
        Me.Txt_NumEntraineur.TabIndex = 15
        '
        'Grid_Entraineur
        '
        Me.Grid_Entraineur.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid_Entraineur.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid_Entraineur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Entraineur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumClub, Me.NomClub})
        Me.Grid_Entraineur.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.Grid_Entraineur.Location = New System.Drawing.Point(77, 172)
        Me.Grid_Entraineur.Name = "Grid_Entraineur"
        Me.Grid_Entraineur.Size = New System.Drawing.Size(389, 148)
        Me.Grid_Entraineur.TabIndex = 14
        '
        'NumClub
        '
        Me.NumClub.HeaderText = "Num Club"
        Me.NumClub.Name = "NumClub"
        '
        'NomClub
        '
        Me.NomClub.HeaderText = "Nom Club"
        Me.NomClub.Name = "NomClub"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Cmd_Fermer)
        Me.Panel2.Controls.Add(Me.Cmd_Ajouter)
        Me.Panel2.Location = New System.Drawing.Point(120, 469)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(539, 68)
        Me.Panel2.TabIndex = 10
        '
        'Cmd_Fermer
        '
        Me.Cmd_Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Fermer.Location = New System.Drawing.Point(323, 12)
        Me.Cmd_Fermer.Name = "Cmd_Fermer"
        Me.Cmd_Fermer.Size = New System.Drawing.Size(143, 42)
        Me.Cmd_Fermer.TabIndex = 8
        Me.Cmd_Fermer.Text = "FERMER"
        Me.Cmd_Fermer.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(83, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(621, 68)
        Me.Panel4.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(590, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "GESTION DES ENTRAINEURS (AJOUTER)"
        '
        'Frm_GestionEntraineur_AJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(788, 569)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_GestionEntraineur_AJ"
        Me.Text = "Frm_GestionEntraineur_AJ"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Grid_Entraineur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Nom As TextBox
    Friend WithEvents PRENOM As Label
    Friend WithEvents Txt_Prenom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmd_Ajouter As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_NumEntraineur As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Cmd_Fermer As Button
    Friend WithEvents Grid_Entraineur As DataGridView
    Friend WithEvents NumClub As DataGridViewTextBoxColumn
    Friend WithEvents NomClub As DataGridViewTextBoxColumn
End Class

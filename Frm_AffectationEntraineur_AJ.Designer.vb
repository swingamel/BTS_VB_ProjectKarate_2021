<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_AffectationEntraineur_AJ
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Cmd_Fermer = New System.Windows.Forms.Button()
        Me.Cmd_Ajouter = New System.Windows.Forms.Button()
        Me.Grid_Competition = New System.Windows.Forms.DataGridView()
        Me.NumCompétition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCompétition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grid_Entraineur = New System.Windows.Forms.DataGridView()
        Me.NumEntraineur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomEntraineur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrénomEntraineur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_Jury = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Grid_Competition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_Entraineur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(12, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(628, 68)
        Me.Panel4.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(607, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "AFFECTATION DES ENTRAINEURS (AJOUTER)"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Cmd_Fermer)
        Me.Panel2.Controls.Add(Me.Cmd_Ajouter)
        Me.Panel2.Location = New System.Drawing.Point(55, 542)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(522, 68)
        Me.Panel2.TabIndex = 22
        '
        'Cmd_Fermer
        '
        Me.Cmd_Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Fermer.Location = New System.Drawing.Point(306, 12)
        Me.Cmd_Fermer.Name = "Cmd_Fermer"
        Me.Cmd_Fermer.Size = New System.Drawing.Size(188, 42)
        Me.Cmd_Fermer.TabIndex = 8
        Me.Cmd_Fermer.Text = "FERMER"
        Me.Cmd_Fermer.UseVisualStyleBackColor = True
        '
        'Cmd_Ajouter
        '
        Me.Cmd_Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Ajouter.Location = New System.Drawing.Point(20, 11)
        Me.Cmd_Ajouter.Name = "Cmd_Ajouter"
        Me.Cmd_Ajouter.Size = New System.Drawing.Size(188, 42)
        Me.Cmd_Ajouter.TabIndex = 7
        Me.Cmd_Ajouter.Text = "AJOUTER"
        Me.Cmd_Ajouter.UseVisualStyleBackColor = True
        '
        'Grid_Competition
        '
        Me.Grid_Competition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Competition.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumCompétition, Me.DateCompétition})
        Me.Grid_Competition.Location = New System.Drawing.Point(71, 207)
        Me.Grid_Competition.Name = "Grid_Competition"
        Me.Grid_Competition.Size = New System.Drawing.Size(459, 163)
        Me.Grid_Competition.TabIndex = 21
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
        Me.Grid_Entraineur.Location = New System.Drawing.Point(23, 12)
        Me.Grid_Entraineur.Name = "Grid_Entraineur"
        Me.Grid_Entraineur.Size = New System.Drawing.Size(558, 180)
        Me.Grid_Entraineur.TabIndex = 22
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
        'Txt_Jury
        '
        Me.Txt_Jury.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Txt_Jury.Location = New System.Drawing.Point(326, 390)
        Me.Txt_Jury.Name = "Txt_Jury"
        Me.Txt_Jury.Size = New System.Drawing.Size(133, 29)
        Me.Txt_Jury.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "NUMERO DU JURY : "
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Txt_Jury)
        Me.Panel1.Controls.Add(Me.Grid_Competition)
        Me.Panel1.Controls.Add(Me.Grid_Entraineur)
        Me.Panel1.Location = New System.Drawing.Point(21, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 434)
        Me.Panel1.TabIndex = 28
        '
        'Frm_AffectationEntraineur_AJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(652, 622)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "Frm_AffectationEntraineur_AJ"
        Me.Text = "Frm_AffectationEntraineur_AJ"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Grid_Competition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_Entraineur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Cmd_Fermer As Button
    Friend WithEvents Cmd_Ajouter As Button
    Friend WithEvents Grid_Competition As DataGridView
    Friend WithEvents Grid_Entraineur As DataGridView
    Friend WithEvents NumEntraineur As DataGridViewTextBoxColumn
    Friend WithEvents NomEntraineur As DataGridViewTextBoxColumn
    Friend WithEvents PrénomEntraineur As DataGridViewTextBoxColumn
    Friend WithEvents NumCompétition As DataGridViewTextBoxColumn
    Friend WithEvents DateCompétition As DataGridViewTextBoxColumn
    Friend WithEvents Txt_Jury As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class

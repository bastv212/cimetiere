<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProlongation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProlongation))
        Me.ProlongDG = New System.Windows.Forms.DataGridView()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prénoms = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.naissance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProlongRBCaveau = New System.Windows.Forms.RadioButton()
        Me.ProlongLabelEndroit = New System.Windows.Forms.Label()
        Me.ProlongRBColumb = New System.Windows.Forms.RadioButton()
        Me.ProlongRBpleineterr = New System.Windows.Forms.RadioButton()
        Me.ProlongLabRemarque = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ProlongTBLien = New System.Windows.Forms.TextBox()
        Me.ProlongTBEndroit = New System.Windows.Forms.TextBox()
        Me.ProlongTBRemarque = New System.Windows.Forms.TextBox()
        Me.ProlongBTerminer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProlongTBPays = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProlongTBCodePostal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProlongTBVille = New System.Windows.Forms.TextBox()
        Me.ProlongTBTelephonne = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProlongTBPrenom = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ProlongTBAdresse = New System.Windows.Forms.TextBox()
        Me.ProlongTBNom = New System.Windows.Forms.TextBox()
        Me.FormProlPanPersDem = New System.Windows.Forms.Panel()
        Me.FormProlGBPersDem = New System.Windows.Forms.GroupBox()
        Me.FormProlPanType = New System.Windows.Forms.Panel()
        Me.FormProlGBType = New System.Windows.Forms.GroupBox()
        Me.FormProlPanFormProlPanPersonne = New System.Windows.Forms.Panel()
        Me.FormProlGBPersonne = New System.Windows.Forms.GroupBox()
        Me.FormProlPanInfoSup = New System.Windows.Forms.Panel()
        Me.FormProlGBInfoSup = New System.Windows.Forms.GroupBox()
        Me.ProlongLabLien = New System.Windows.Forms.Label()
        CType(Me.ProlongDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormProlPanPersDem.SuspendLayout()
        Me.FormProlGBPersDem.SuspendLayout()
        Me.FormProlPanType.SuspendLayout()
        Me.FormProlGBType.SuspendLayout()
        Me.FormProlPanFormProlPanPersonne.SuspendLayout()
        Me.FormProlGBPersonne.SuspendLayout()
        Me.FormProlPanInfoSup.SuspendLayout()
        Me.FormProlGBInfoSup.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProlongDG
        '
        Me.ProlongDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProlongDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nom, Me.Prénoms, Me.naissance, Me.Lien})
        Me.ProlongDG.Location = New System.Drawing.Point(6, 21)
        Me.ProlongDG.Name = "ProlongDG"
        Me.ProlongDG.Size = New System.Drawing.Size(481, 127)
        Me.ProlongDG.TabIndex = 93
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom(s)"
        Me.Nom.Name = "Nom"
        '
        'Prénoms
        '
        Me.Prénoms.HeaderText = "Prénoms"
        Me.Prénoms.Name = "Prénoms"
        '
        'naissance
        '
        Me.naissance.HeaderText = "Date(s) de naissance"
        Me.naissance.Name = "naissance"
        '
        'Lien
        '
        Me.Lien.HeaderText = "Lien(s) de parenté"
        Me.Lien.Name = "Lien"
        '
        'ProlongRBCaveau
        '
        Me.ProlongRBCaveau.AutoSize = True
        Me.ProlongRBCaveau.Location = New System.Drawing.Point(23, 42)
        Me.ProlongRBCaveau.Name = "ProlongRBCaveau"
        Me.ProlongRBCaveau.Size = New System.Drawing.Size(143, 17)
        Me.ProlongRBCaveau.TabIndex = 145
        Me.ProlongRBCaveau.TabStop = True
        Me.ProlongRBCaveau.Text = "Emplacement en caveau"
        Me.ProlongRBCaveau.UseVisualStyleBackColor = True
        '
        'ProlongLabelEndroit
        '
        Me.ProlongLabelEndroit.AutoSize = True
        Me.ProlongLabelEndroit.Location = New System.Drawing.Point(6, 57)
        Me.ProlongLabelEndroit.Name = "ProlongLabelEndroit"
        Me.ProlongLabelEndroit.Size = New System.Drawing.Size(298, 13)
        Me.ProlongLabelEndroit.TabIndex = 126
        Me.ProlongLabelEndroit.Text = "Situation approximative de l'endroit où se trouve la sépulture : "
        '
        'ProlongRBColumb
        '
        Me.ProlongRBColumb.AutoSize = True
        Me.ProlongRBColumb.Location = New System.Drawing.Point(23, 65)
        Me.ProlongRBColumb.Name = "ProlongRBColumb"
        Me.ProlongRBColumb.Size = New System.Drawing.Size(166, 17)
        Me.ProlongRBColumb.TabIndex = 146
        Me.ProlongRBColumb.TabStop = True
        Me.ProlongRBColumb.Text = "Emplacement en columbarium"
        Me.ProlongRBColumb.UseVisualStyleBackColor = True
        '
        'ProlongRBpleineterr
        '
        Me.ProlongRBpleineterr.AutoSize = True
        Me.ProlongRBpleineterr.Location = New System.Drawing.Point(23, 19)
        Me.ProlongRBpleineterr.Name = "ProlongRBpleineterr"
        Me.ProlongRBpleineterr.Size = New System.Drawing.Size(159, 17)
        Me.ProlongRBpleineterr.TabIndex = 154
        Me.ProlongRBpleineterr.TabStop = True
        Me.ProlongRBpleineterr.Text = "Emplacement en pleine terre"
        Me.ProlongRBpleineterr.UseVisualStyleBackColor = True
        '
        'ProlongLabRemarque
        '
        Me.ProlongLabRemarque.AutoSize = True
        Me.ProlongLabRemarque.Location = New System.Drawing.Point(6, 96)
        Me.ProlongLabRemarque.Name = "ProlongLabRemarque"
        Me.ProlongLabRemarque.Size = New System.Drawing.Size(119, 13)
        Me.ProlongLabRemarque.TabIndex = 155
        Me.ProlongLabRemarque.Text = "Remarque éventuelles :"
        '
        'Button3
        '
        Me.Button3.Image = Global.cimetiere.My.Resources.Resources.Table_16x
        Me.Button3.Location = New System.Drawing.Point(305, 54)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 20)
        Me.Button3.TabIndex = 158
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ProlongTBLien
        '
        Me.ProlongTBLien.Location = New System.Drawing.Point(9, 34)
        Me.ProlongTBLien.Name = "ProlongTBLien"
        Me.ProlongTBLien.Size = New System.Drawing.Size(100, 20)
        Me.ProlongTBLien.TabIndex = 159
        '
        'ProlongTBEndroit
        '
        Me.ProlongTBEndroit.Location = New System.Drawing.Point(9, 73)
        Me.ProlongTBEndroit.Name = "ProlongTBEndroit"
        Me.ProlongTBEndroit.Size = New System.Drawing.Size(100, 20)
        Me.ProlongTBEndroit.TabIndex = 160
        '
        'ProlongTBRemarque
        '
        Me.ProlongTBRemarque.Location = New System.Drawing.Point(9, 112)
        Me.ProlongTBRemarque.Name = "ProlongTBRemarque"
        Me.ProlongTBRemarque.Size = New System.Drawing.Size(100, 20)
        Me.ProlongTBRemarque.TabIndex = 161
        '
        'ProlongBTerminer
        '
        Me.ProlongBTerminer.Location = New System.Drawing.Point(448, 607)
        Me.ProlongBTerminer.Name = "ProlongBTerminer"
        Me.ProlongBTerminer.Size = New System.Drawing.Size(75, 23)
        Me.ProlongBTerminer.TabIndex = 162
        Me.ProlongBTerminer.Text = "Terminer"
        Me.ProlongBTerminer.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(242, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 175
        Me.Label4.Text = "Pays :"
        '
        'ProlongTBPays
        '
        Me.ProlongTBPays.Location = New System.Drawing.Point(288, 80)
        Me.ProlongTBPays.Name = "ProlongTBPays"
        Me.ProlongTBPays.Size = New System.Drawing.Size(116, 20)
        Me.ProlongTBPays.TabIndex = 176
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 173
        Me.Label5.Text = "Code postale :"
        '
        'ProlongTBCodePostal
        '
        Me.ProlongTBCodePostal.Location = New System.Drawing.Point(92, 80)
        Me.ProlongTBCodePostal.Name = "ProlongTBCodePostal"
        Me.ProlongTBCodePostal.Size = New System.Drawing.Size(116, 20)
        Me.ProlongTBCodePostal.TabIndex = 174
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(250, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 171
        Me.Label8.Text = "Ville :"
        '
        'ProlongTBVille
        '
        Me.ProlongTBVille.Location = New System.Drawing.Point(288, 51)
        Me.ProlongTBVille.Name = "ProlongTBVille"
        Me.ProlongTBVille.Size = New System.Drawing.Size(116, 20)
        Me.ProlongTBVille.TabIndex = 172
        '
        'ProlongTBTelephonne
        '
        Me.ProlongTBTelephonne.Location = New System.Drawing.Point(76, 104)
        Me.ProlongTBTelephonne.Name = "ProlongTBTelephonne"
        Me.ProlongTBTelephonne.Size = New System.Drawing.Size(150, 20)
        Me.ProlongTBTelephonne.TabIndex = 170
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 169
        Me.Label9.Text = "Téléphone :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 164
        Me.Label10.Text = "Nom :"
        '
        'ProlongTBPrenom
        '
        Me.ProlongTBPrenom.Location = New System.Drawing.Point(288, 19)
        Me.ProlongTBPrenom.Name = "ProlongTBPrenom"
        Me.ProlongTBPrenom.Size = New System.Drawing.Size(193, 20)
        Me.ProlongTBPrenom.TabIndex = 166
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(233, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 165
        Me.Label11.Text = "Prénom :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 167
        Me.Label12.Text = "Adresse :"
        '
        'ProlongTBAdresse
        '
        Me.ProlongTBAdresse.Location = New System.Drawing.Point(64, 50)
        Me.ProlongTBAdresse.Name = "ProlongTBAdresse"
        Me.ProlongTBAdresse.Size = New System.Drawing.Size(162, 20)
        Me.ProlongTBAdresse.TabIndex = 168
        '
        'ProlongTBNom
        '
        Me.ProlongTBNom.Location = New System.Drawing.Point(48, 19)
        Me.ProlongTBNom.Name = "ProlongTBNom"
        Me.ProlongTBNom.Size = New System.Drawing.Size(163, 20)
        Me.ProlongTBNom.TabIndex = 163
        '
        'FormProlPanPersDem
        '
        Me.FormProlPanPersDem.BackColor = System.Drawing.Color.SeaGreen
        Me.FormProlPanPersDem.Controls.Add(Me.FormProlGBPersDem)
        Me.FormProlPanPersDem.Location = New System.Drawing.Point(6, 12)
        Me.FormProlPanPersDem.Name = "FormProlPanPersDem"
        Me.FormProlPanPersDem.Size = New System.Drawing.Size(520, 143)
        Me.FormProlPanPersDem.TabIndex = 178
        '
        'FormProlGBPersDem
        '
        Me.FormProlGBPersDem.BackColor = System.Drawing.Color.GhostWhite
        Me.FormProlGBPersDem.Controls.Add(Me.ProlongTBNom)
        Me.FormProlGBPersDem.Controls.Add(Me.ProlongTBAdresse)
        Me.FormProlGBPersDem.Controls.Add(Me.ProlongTBTelephonne)
        Me.FormProlGBPersDem.Controls.Add(Me.Label9)
        Me.FormProlGBPersDem.Controls.Add(Me.Label4)
        Me.FormProlGBPersDem.Controls.Add(Me.Label12)
        Me.FormProlGBPersDem.Controls.Add(Me.ProlongTBPays)
        Me.FormProlGBPersDem.Controls.Add(Me.Label11)
        Me.FormProlGBPersDem.Controls.Add(Me.Label5)
        Me.FormProlGBPersDem.Controls.Add(Me.ProlongTBPrenom)
        Me.FormProlGBPersDem.Controls.Add(Me.ProlongTBCodePostal)
        Me.FormProlGBPersDem.Controls.Add(Me.Label10)
        Me.FormProlGBPersDem.Controls.Add(Me.Label8)
        Me.FormProlGBPersDem.Controls.Add(Me.ProlongTBVille)
        Me.FormProlGBPersDem.Location = New System.Drawing.Point(9, 7)
        Me.FormProlGBPersDem.Name = "FormProlGBPersDem"
        Me.FormProlGBPersDem.Size = New System.Drawing.Size(503, 129)
        Me.FormProlGBPersDem.TabIndex = 0
        Me.FormProlGBPersDem.TabStop = False
        Me.FormProlGBPersDem.Text = "Personne effectuant la demande"
        '
        'FormProlPanType
        '
        Me.FormProlPanType.BackColor = System.Drawing.Color.SeaGreen
        Me.FormProlPanType.Controls.Add(Me.FormProlGBType)
        Me.FormProlPanType.Location = New System.Drawing.Point(6, 161)
        Me.FormProlPanType.Name = "FormProlPanType"
        Me.FormProlPanType.Size = New System.Drawing.Size(520, 102)
        Me.FormProlPanType.TabIndex = 179
        '
        'FormProlGBType
        '
        Me.FormProlGBType.BackColor = System.Drawing.Color.GhostWhite
        Me.FormProlGBType.Controls.Add(Me.ProlongRBCaveau)
        Me.FormProlGBType.Controls.Add(Me.ProlongRBpleineterr)
        Me.FormProlGBType.Controls.Add(Me.ProlongRBColumb)
        Me.FormProlGBType.Location = New System.Drawing.Point(9, 5)
        Me.FormProlGBType.Name = "FormProlGBType"
        Me.FormProlGBType.Size = New System.Drawing.Size(503, 92)
        Me.FormProlGBType.TabIndex = 0
        Me.FormProlGBType.TabStop = False
        Me.FormProlGBType.Text = "Type de sépulture"
        '
        'FormProlPanFormProlPanPersonne
        '
        Me.FormProlPanFormProlPanPersonne.BackColor = System.Drawing.Color.SeaGreen
        Me.FormProlPanFormProlPanPersonne.Controls.Add(Me.FormProlGBPersonne)
        Me.FormProlPanFormProlPanPersonne.Location = New System.Drawing.Point(6, 269)
        Me.FormProlPanFormProlPanPersonne.Name = "FormProlPanFormProlPanPersonne"
        Me.FormProlPanFormProlPanPersonne.Size = New System.Drawing.Size(520, 172)
        Me.FormProlPanFormProlPanPersonne.TabIndex = 180
        '
        'FormProlGBPersonne
        '
        Me.FormProlGBPersonne.BackColor = System.Drawing.Color.GhostWhite
        Me.FormProlGBPersonne.Controls.Add(Me.ProlongDG)
        Me.FormProlGBPersonne.Location = New System.Drawing.Point(9, 5)
        Me.FormProlGBPersonne.Name = "FormProlGBPersonne"
        Me.FormProlGBPersonne.Size = New System.Drawing.Size(503, 161)
        Me.FormProlGBPersonne.TabIndex = 0
        Me.FormProlGBPersonne.TabStop = False
        Me.FormProlGBPersonne.Text = "Dans cette sépulture les restes mortels de la (des) personne(s) suivante(s) :"
        '
        'FormProlPanInfoSup
        '
        Me.FormProlPanInfoSup.BackColor = System.Drawing.Color.SeaGreen
        Me.FormProlPanInfoSup.Controls.Add(Me.FormProlGBInfoSup)
        Me.FormProlPanInfoSup.Location = New System.Drawing.Point(6, 447)
        Me.FormProlPanInfoSup.Name = "FormProlPanInfoSup"
        Me.FormProlPanInfoSup.Size = New System.Drawing.Size(520, 155)
        Me.FormProlPanInfoSup.TabIndex = 181
        '
        'FormProlGBInfoSup
        '
        Me.FormProlGBInfoSup.BackColor = System.Drawing.Color.GhostWhite
        Me.FormProlGBInfoSup.Controls.Add(Me.ProlongLabLien)
        Me.FormProlGBInfoSup.Controls.Add(Me.ProlongLabelEndroit)
        Me.FormProlGBInfoSup.Controls.Add(Me.ProlongLabRemarque)
        Me.FormProlGBInfoSup.Controls.Add(Me.Button3)
        Me.FormProlGBInfoSup.Controls.Add(Me.ProlongTBLien)
        Me.FormProlGBInfoSup.Controls.Add(Me.ProlongTBRemarque)
        Me.FormProlGBInfoSup.Controls.Add(Me.ProlongTBEndroit)
        Me.FormProlGBInfoSup.Location = New System.Drawing.Point(9, 8)
        Me.FormProlGBInfoSup.Name = "FormProlGBInfoSup"
        Me.FormProlGBInfoSup.Size = New System.Drawing.Size(503, 140)
        Me.FormProlGBInfoSup.TabIndex = 0
        Me.FormProlGBInfoSup.TabStop = False
        Me.FormProlGBInfoSup.Text = "Informations supplémentaires"
        '
        'ProlongLabLien
        '
        Me.ProlongLabLien.AutoSize = True
        Me.ProlongLabLien.Location = New System.Drawing.Point(6, 18)
        Me.ProlongLabLien.Name = "ProlongLabLien"
        Me.ProlongLabLien.Size = New System.Drawing.Size(195, 13)
        Me.ProlongLabLien.TabIndex = 127
        Me.ProlongLabLien.Text = "Lien(s) de parenté avec le demandeur : "
        '
        'FormProlongation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(531, 637)
        Me.Controls.Add(Me.FormProlPanInfoSup)
        Me.Controls.Add(Me.FormProlPanFormProlPanPersonne)
        Me.Controls.Add(Me.FormProlPanType)
        Me.Controls.Add(Me.FormProlPanPersDem)
        Me.Controls.Add(Me.ProlongBTerminer)
        Me.Name = "FormProlongation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProlongation"
        CType(Me.ProlongDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormProlPanPersDem.ResumeLayout(False)
        Me.FormProlGBPersDem.ResumeLayout(False)
        Me.FormProlGBPersDem.PerformLayout()
        Me.FormProlPanType.ResumeLayout(False)
        Me.FormProlGBType.ResumeLayout(False)
        Me.FormProlGBType.PerformLayout()
        Me.FormProlPanFormProlPanPersonne.ResumeLayout(False)
        Me.FormProlGBPersonne.ResumeLayout(False)
        Me.FormProlPanInfoSup.ResumeLayout(False)
        Me.FormProlGBInfoSup.ResumeLayout(False)
        Me.FormProlGBInfoSup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProlongDG As System.Windows.Forms.DataGridView
    Friend WithEvents ProlongRBCaveau As System.Windows.Forms.RadioButton
    Friend WithEvents ProlongLabelEndroit As System.Windows.Forms.Label
    Friend WithEvents ProlongRBColumb As System.Windows.Forms.RadioButton
    Friend WithEvents ProlongRBpleineterr As System.Windows.Forms.RadioButton
    Friend WithEvents ProlongLabRemarque As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ProlongTBLien As System.Windows.Forms.TextBox
    Friend WithEvents ProlongTBEndroit As System.Windows.Forms.TextBox
    Friend WithEvents ProlongTBRemarque As System.Windows.Forms.TextBox
    Friend WithEvents Nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prénoms As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents naissance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProlongBTerminer As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProlongTBPays As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProlongTBCodePostal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ProlongTBVille As System.Windows.Forms.TextBox
    Friend WithEvents ProlongTBTelephonne As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ProlongTBPrenom As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ProlongTBAdresse As System.Windows.Forms.TextBox
    Friend WithEvents ProlongTBNom As System.Windows.Forms.TextBox
    Friend WithEvents FormProlPanPersDem As System.Windows.Forms.Panel
    Friend WithEvents FormProlGBPersDem As System.Windows.Forms.GroupBox
    Friend WithEvents FormProlPanType As System.Windows.Forms.Panel
    Friend WithEvents FormProlGBType As System.Windows.Forms.GroupBox
    Friend WithEvents FormProlPanFormProlPanPersonne As System.Windows.Forms.Panel
    Friend WithEvents FormProlGBPersonne As System.Windows.Forms.GroupBox
    Friend WithEvents FormProlPanInfoSup As System.Windows.Forms.Panel
    Friend WithEvents FormProlGBInfoSup As System.Windows.Forms.GroupBox
    Friend WithEvents ProlongLabLien As System.Windows.Forms.Label
End Class

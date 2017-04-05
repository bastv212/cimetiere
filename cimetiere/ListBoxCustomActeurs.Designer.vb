<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBoxCustomActeurs
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BtNouveau = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbFiltre = New System.Windows.Forms.TextBox()
        Me.BtDetails = New System.Windows.Forms.Button()
        Me.BtModifier = New System.Windows.Forms.Button()
        Me.BtClearFiltr = New System.Windows.Forms.Button()
        Me.LabTel = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LabDateNaiss = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabAdresse = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LabNoNational = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabNom = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LbListe = New cimetiere.ListboxEntites()
        Me.SuspendLayout()
        '
        'BtNouveau
        '
        Me.BtNouveau.Location = New System.Drawing.Point(351, 4)
        Me.BtNouveau.Name = "BtNouveau"
        Me.BtNouveau.Size = New System.Drawing.Size(116, 30)
        Me.BtNouveau.TabIndex = 181
        Me.BtNouveau.Text = "Nouveau..."
        Me.BtNouveau.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(359, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 179
        Me.Label6.Text = "Filtrer"
        '
        'TbFiltre
        '
        Me.TbFiltre.Location = New System.Drawing.Point(351, 64)
        Me.TbFiltre.Name = "TbFiltre"
        Me.TbFiltre.Size = New System.Drawing.Size(86, 22)
        Me.TbFiltre.TabIndex = 178
        '
        'BtDetails
        '
        Me.BtDetails.Location = New System.Drawing.Point(351, 139)
        Me.BtDetails.Name = "BtDetails"
        Me.BtDetails.Size = New System.Drawing.Size(116, 30)
        Me.BtDetails.TabIndex = 176
        Me.BtDetails.Text = "Détails..."
        Me.BtDetails.UseVisualStyleBackColor = True
        '
        'BtModifier
        '
        Me.BtModifier.Location = New System.Drawing.Point(351, 105)
        Me.BtModifier.Name = "BtModifier"
        Me.BtModifier.Size = New System.Drawing.Size(116, 29)
        Me.BtModifier.TabIndex = 175
        Me.BtModifier.Text = "Modifier..."
        Me.BtModifier.UseVisualStyleBackColor = True
        '
        'BtClearFiltr
        '
        Me.BtClearFiltr.Image = Global.cimetiere.My.Resources.Resources.Cancel_16x
        Me.BtClearFiltr.Location = New System.Drawing.Point(437, 63)
        Me.BtClearFiltr.Name = "BtClearFiltr"
        Me.BtClearFiltr.Size = New System.Drawing.Size(30, 27)
        Me.BtClearFiltr.TabIndex = 180
        Me.BtClearFiltr.TabStop = False
        Me.BtClearFiltr.UseVisualStyleBackColor = True
        '
        'LabTel
        '
        Me.LabTel.AutoSize = True
        Me.LabTel.Location = New System.Drawing.Point(91, 49)
        Me.LabTel.Name = "LabTel"
        Me.LabTel.Size = New System.Drawing.Size(98, 17)
        Me.LabTel.TabIndex = 191
        Me.LabTel.Text = "LabP2CsnrTel"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 17)
        Me.Label17.TabIndex = 190
        Me.Label17.Text = "Téléphone :"
        '
        'LabDateNaiss
        '
        Me.LabDateNaiss.AutoSize = True
        Me.LabDateNaiss.Location = New System.Drawing.Point(140, 95)
        Me.LabDateNaiss.Name = "LabDateNaiss"
        Me.LabDateNaiss.Size = New System.Drawing.Size(143, 17)
        Me.LabDateNaiss.TabIndex = 189
        Me.LabDateNaiss.Text = "LabP2CsnrDateNaiss"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 17)
        Me.Label12.TabIndex = 188
        Me.Label12.Text = "Date de naissance :"
        '
        'LabAdresse
        '
        Me.LabAdresse.AutoSize = True
        Me.LabAdresse.Location = New System.Drawing.Point(76, 25)
        Me.LabAdresse.Name = "LabAdresse"
        Me.LabAdresse.Size = New System.Drawing.Size(159, 17)
        Me.LabAdresse.TabIndex = 187
        Me.LabAdresse.Text = "LabP2CsnrAdrComplete"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 17)
        Me.Label15.TabIndex = 186
        Me.Label15.Text = "Adresse :"
        '
        'LabNoNational
        '
        Me.LabNoNational.AutoSize = True
        Me.LabNoNational.Location = New System.Drawing.Point(125, 72)
        Me.LabNoNational.Name = "LabNoNational"
        Me.LabNoNational.Size = New System.Drawing.Size(148, 17)
        Me.LabNoNational.TabIndex = 185
        Me.LabNoNational.Text = "LabP2CsnrNoNational"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 17)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "Numéro national :"
        '
        'LabNom
        '
        Me.LabNom.AutoSize = True
        Me.LabNom.Location = New System.Drawing.Point(48, 3)
        Me.LabNom.Name = "LabNom"
        Me.LabNom.Size = New System.Drawing.Size(107, 17)
        Me.LabNom.TabIndex = 183
        Me.LabNom.Text = "LabP2CsnrNom"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 182
        Me.Label7.Text = "Nom :"
        '
        'LbListe
        '
        Me.LbListe.DataSource = Nothing
        Me.LbListe.DisplayMember = "Nom"
        Me.LbListe.Filtre = ""
        Me.LbListe.FormattingEnabled = True
        Me.LbListe.ItemHeight = 16
        Me.LbListe.Location = New System.Drawing.Point(493, 4)
        Me.LbListe.Name = "LbListe"
        Me.LbListe.Size = New System.Drawing.Size(273, 164)
        Me.LbListe.TabIndex = 192
        Me.LbListe.ValueMember = "Id"
        '
        'ListBoxCustomActeurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.LbListe)
        Me.Controls.Add(Me.LabTel)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LabDateNaiss)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LabAdresse)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LabNoNational)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabNom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtNouveau)
        Me.Controls.Add(Me.BtClearFiltr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbFiltre)
        Me.Controls.Add(Me.BtDetails)
        Me.Controls.Add(Me.BtModifier)
        Me.Name = "ListBoxCustomActeurs"
        Me.Size = New System.Drawing.Size(768, 170)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtNouveau As Button
    Friend WithEvents BtClearFiltr As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TbFiltre As TextBox
    Friend WithEvents BtDetails As Button
    Friend WithEvents BtModifier As Button
    Friend WithEvents LabTel As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents LabDateNaiss As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LabAdresse As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LabNoNational As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabNom As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LbListe As ListboxEntites
End Class

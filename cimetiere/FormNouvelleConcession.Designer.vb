<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNouvelleConcession
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabDemandeCsn = New System.Windows.Forms.TabPage()
        Me.BtSuivantDeForm = New System.Windows.Forms.Button()
        Me.PanCoordsDmdr = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabRecap = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GbPersMand = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabDmdrAdresse = New System.Windows.Forms.Label()
        Me.LabDmdrNom = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LabCsnrNomComplet = New System.Windows.Forms.Label()
        Me.LabCsnrNoNat = New System.Windows.Forms.Label()
        Me.LabCsnrDateNaiss = New System.Windows.Forms.Label()
        Me.LabCsnrAdresseComplete = New System.Windows.Forms.Label()
        Me.LabCsnrTel = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabTypeConcession = New System.Windows.Forms.Label()
        Me.GbRecapBenefs = New System.Windows.Forms.GroupBox()
        Me.FlpLabsBeneficiaires = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CbOuvrirPdf = New System.Windows.Forms.CheckBox()
        Me.CbEnregPdf = New System.Windows.Forms.CheckBox()
        Me.BtTerminer = New System.Windows.Forms.Button()
        Me.BtPrecedentDeRecap = New System.Windows.Forms.Button()
        Me.LbListeConcessionnaires = New cimetiere.ListBoxCustomActeurs()
        Me.ListeBeneficiaires = New cimetiere.ListeBeneficiairesNvCon()
        Me.PanelChoixTypeEmpl1 = New cimetiere.PanelChoixTypeEmpl()
        Me.TextBoxNullable1 = New cimetiere.TextBoxNullable()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabDemandeCsn.SuspendLayout()
        Me.PanCoordsDmdr.SuspendLayout()
        Me.TabRecap.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GbPersMand.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GbRecapBenefs.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabDemandeCsn)
        Me.TabControl1.Controls.Add(Me.TabRecap)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(814, 1021)
        Me.TabControl1.TabIndex = 0
        '
        'TabDemandeCsn
        '
        Me.TabDemandeCsn.Controls.Add(Me.LbListeConcessionnaires)
        Me.TabDemandeCsn.Controls.Add(Me.BtSuivantDeForm)
        Me.TabDemandeCsn.Controls.Add(Me.PanCoordsDmdr)
        Me.TabDemandeCsn.Controls.Add(Me.Label3)
        Me.TabDemandeCsn.Controls.Add(Me.ListeBeneficiaires)
        Me.TabDemandeCsn.Controls.Add(Me.PanelChoixTypeEmpl1)
        Me.TabDemandeCsn.Controls.Add(Me.Label1)
        Me.TabDemandeCsn.Location = New System.Drawing.Point(4, 25)
        Me.TabDemandeCsn.Name = "TabDemandeCsn"
        Me.TabDemandeCsn.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDemandeCsn.Size = New System.Drawing.Size(806, 992)
        Me.TabDemandeCsn.TabIndex = 0
        Me.TabDemandeCsn.Text = "Demande de concession"
        Me.TabDemandeCsn.UseVisualStyleBackColor = True
        '
        'BtSuivantDeForm
        '
        Me.BtSuivantDeForm.Enabled = False
        Me.BtSuivantDeForm.Location = New System.Drawing.Point(564, 882)
        Me.BtSuivantDeForm.Name = "BtSuivantDeForm"
        Me.BtSuivantDeForm.Size = New System.Drawing.Size(105, 36)
        Me.BtSuivantDeForm.TabIndex = 181
        Me.BtSuivantDeForm.Text = "Suivant >>"
        Me.BtSuivantDeForm.UseVisualStyleBackColor = True
        '
        'PanCoordsDmdr
        '
        Me.PanCoordsDmdr.BackColor = System.Drawing.Color.SeaGreen
        Me.PanCoordsDmdr.Controls.Add(Me.GroupBox1)
        Me.PanCoordsDmdr.Location = New System.Drawing.Point(-29, -264)
        Me.PanCoordsDmdr.Margin = New System.Windows.Forms.Padding(4)
        Me.PanCoordsDmdr.Name = "PanCoordsDmdr"
        Me.PanCoordsDmdr.Size = New System.Drawing.Size(912, 258)
        Me.PanCoordsDmdr.TabIndex = 174
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(892, 244)
        Me.GroupBox1.TabIndex = 125
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personne introduisant la demande"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(92, 864)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(393, 75)
        Me.Label3.TabIndex = 180
        Me.Label3.Text = "A faire : mettre la personne mandatée quelque part (si il y en a une)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-13, -305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(551, 32)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Demande de réservation d'une concession"
        '
        'TabRecap
        '
        Me.TabRecap.AutoScroll = True
        Me.TabRecap.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabRecap.Location = New System.Drawing.Point(4, 25)
        Me.TabRecap.Name = "TabRecap"
        Me.TabRecap.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRecap.Size = New System.Drawing.Size(806, 992)
        Me.TabRecap.TabIndex = 1
        Me.TabRecap.Text = "Récapitulatif"
        Me.TabRecap.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.GbPersMand)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox6)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox3)
        Me.FlowLayoutPanel1.Controls.Add(Me.GbRecapBenefs)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(620, 884)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'GbPersMand
        '
        Me.GbPersMand.Controls.Add(Me.Label6)
        Me.GbPersMand.Controls.Add(Me.LabDmdrAdresse)
        Me.GbPersMand.Controls.Add(Me.LabDmdrNom)
        Me.GbPersMand.Location = New System.Drawing.Point(3, 3)
        Me.GbPersMand.Name = "GbPersMand"
        Me.GbPersMand.Size = New System.Drawing.Size(617, 118)
        Me.GbPersMand.TabIndex = 0
        Me.GbPersMand.TabStop = False
        Me.GbPersMand.Text = "Personne introduisant la demande - si n'est pas le concessionnaire"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Téléphone"
        '
        'LabDmdrAdresse
        '
        Me.LabDmdrAdresse.Location = New System.Drawing.Point(6, 37)
        Me.LabDmdrAdresse.Name = "LabDmdrAdresse"
        Me.LabDmdrAdresse.Size = New System.Drawing.Size(592, 44)
        Me.LabDmdrAdresse.TabIndex = 1
        Me.LabDmdrAdresse.Text = "Adresse complète"
        '
        'LabDmdrNom
        '
        Me.LabDmdrNom.AutoSize = True
        Me.LabDmdrNom.Location = New System.Drawing.Point(6, 18)
        Me.LabDmdrNom.Name = "LabDmdrNom"
        Me.LabDmdrNom.Size = New System.Drawing.Size(90, 17)
        Me.LabDmdrNom.TabIndex = 0
        Me.LabDmdrNom.Text = "Nom complet"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LabCsnrNomComplet)
        Me.GroupBox6.Controls.Add(Me.LabCsnrNoNat)
        Me.GroupBox6.Controls.Add(Me.LabCsnrDateNaiss)
        Me.GroupBox6.Controls.Add(Me.LabCsnrAdresseComplete)
        Me.GroupBox6.Controls.Add(Me.LabCsnrTel)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 127)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(605, 170)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Concessionnaire"
        '
        'LabCsnrNomComplet
        '
        Me.LabCsnrNomComplet.AutoEllipsis = True
        Me.LabCsnrNomComplet.AutoSize = True
        Me.LabCsnrNomComplet.Location = New System.Drawing.Point(7, 17)
        Me.LabCsnrNomComplet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabCsnrNomComplet.Name = "LabCsnrNomComplet"
        Me.LabCsnrNomComplet.Padding = New System.Windows.Forms.Padding(6, 6, 3, 2)
        Me.LabCsnrNomComplet.Size = New System.Drawing.Size(46, 25)
        Me.LabCsnrNomComplet.TabIndex = 5
        Me.LabCsnrNomComplet.Text = "Nom"
        '
        'LabCsnrNoNat
        '
        Me.LabCsnrNoNat.AutoEllipsis = True
        Me.LabCsnrNoNat.AutoSize = True
        Me.LabCsnrNoNat.Location = New System.Drawing.Point(7, 137)
        Me.LabCsnrNoNat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabCsnrNoNat.Name = "LabCsnrNoNat"
        Me.LabCsnrNoNat.Padding = New System.Windows.Forms.Padding(6, 6, 3, 2)
        Me.LabCsnrNoNat.Size = New System.Drawing.Size(139, 25)
        Me.LabCsnrNoNat.TabIndex = 6
        Me.LabCsnrNoNat.Text = "N° registre national"
        '
        'LabCsnrDateNaiss
        '
        Me.LabCsnrDateNaiss.AutoEllipsis = True
        Me.LabCsnrDateNaiss.AutoSize = True
        Me.LabCsnrDateNaiss.Location = New System.Drawing.Point(7, 112)
        Me.LabCsnrDateNaiss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabCsnrDateNaiss.Name = "LabCsnrDateNaiss"
        Me.LabCsnrDateNaiss.Padding = New System.Windows.Forms.Padding(6, 6, 3, 2)
        Me.LabCsnrDateNaiss.Size = New System.Drawing.Size(50, 25)
        Me.LabCsnrDateNaiss.TabIndex = 7
        Me.LabCsnrDateNaiss.Text = "Né le"
        '
        'LabCsnrAdresseComplete
        '
        Me.LabCsnrAdresseComplete.AutoEllipsis = True
        Me.LabCsnrAdresseComplete.Location = New System.Drawing.Point(7, 42)
        Me.LabCsnrAdresseComplete.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabCsnrAdresseComplete.Name = "LabCsnrAdresseComplete"
        Me.LabCsnrAdresseComplete.Padding = New System.Windows.Forms.Padding(6, 6, 3, 2)
        Me.LabCsnrAdresseComplete.Size = New System.Drawing.Size(591, 42)
        Me.LabCsnrAdresseComplete.TabIndex = 8
        Me.LabCsnrAdresseComplete.Text = "Adresse"
        '
        'LabCsnrTel
        '
        Me.LabCsnrTel.AutoEllipsis = True
        Me.LabCsnrTel.AutoSize = True
        Me.LabCsnrTel.Location = New System.Drawing.Point(7, 87)
        Me.LabCsnrTel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabCsnrTel.Name = "LabCsnrTel"
        Me.LabCsnrTel.Padding = New System.Windows.Forms.Padding(6, 6, 3, 2)
        Me.LabCsnrTel.Size = New System.Drawing.Size(85, 25)
        Me.LabCsnrTel.TabIndex = 9
        Me.LabCsnrTel.Text = "Téléphone"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabTypeConcession)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 303)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(617, 100)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Emplacement demandé"
        '
        'LabTypeConcession
        '
        Me.LabTypeConcession.AutoSize = True
        Me.LabTypeConcession.Location = New System.Drawing.Point(56, 18)
        Me.LabTypeConcession.Name = "LabTypeConcession"
        Me.LabTypeConcession.Size = New System.Drawing.Size(157, 17)
        Me.LabTypeConcession.TabIndex = 0
        Me.LabTypeConcession.Text = "Type concession et prix"
        '
        'GbRecapBenefs
        '
        Me.GbRecapBenefs.AutoSize = True
        Me.GbRecapBenefs.Controls.Add(Me.Panel2)
        Me.GbRecapBenefs.Location = New System.Drawing.Point(3, 409)
        Me.GbRecapBenefs.Name = "GbRecapBenefs"
        Me.GbRecapBenefs.Size = New System.Drawing.Size(604, 142)
        Me.GbRecapBenefs.TabIndex = 2
        Me.GbRecapBenefs.TabStop = False
        Me.GbRecapBenefs.Text = "Bénéficiaires"
        '
        'FlpLabsBeneficiaires
        '
        Me.FlpLabsBeneficiaires.AutoSize = True
        Me.FlpLabsBeneficiaires.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlpLabsBeneficiaires.Location = New System.Drawing.Point(3, 3)
        Me.FlpLabsBeneficiaires.Name = "FlpLabsBeneficiaires"
        Me.FlpLabsBeneficiaires.Size = New System.Drawing.Size(579, 94)
        Me.FlpLabsBeneficiaires.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.AutoSize = True
        Me.GroupBox5.Controls.Add(Me.TextBoxNullable1)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 557)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(611, 138)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Remarque éventuelle"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CbOuvrirPdf)
        Me.Panel1.Controls.Add(Me.CbEnregPdf)
        Me.Panel1.Controls.Add(Me.BtTerminer)
        Me.Panel1.Controls.Add(Me.BtPrecedentDeRecap)
        Me.Panel1.Location = New System.Drawing.Point(3, 701)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 103)
        Me.Panel1.TabIndex = 10
        '
        'CbOuvrirPdf
        '
        Me.CbOuvrirPdf.AutoSize = True
        Me.CbOuvrirPdf.Checked = True
        Me.CbOuvrirPdf.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbOuvrirPdf.Location = New System.Drawing.Point(9, 47)
        Me.CbOuvrirPdf.Margin = New System.Windows.Forms.Padding(4)
        Me.CbOuvrirPdf.Name = "CbOuvrirPdf"
        Me.CbOuvrirPdf.Size = New System.Drawing.Size(157, 21)
        Me.CbOuvrirPdf.TabIndex = 7
        Me.CbOuvrirPdf.Text = "Ouvrir le fichier PDF"
        Me.CbOuvrirPdf.UseVisualStyleBackColor = True
        '
        'CbEnregPdf
        '
        Me.CbEnregPdf.AutoSize = True
        Me.CbEnregPdf.Checked = True
        Me.CbEnregPdf.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbEnregPdf.Location = New System.Drawing.Point(9, 16)
        Me.CbEnregPdf.Margin = New System.Windows.Forms.Padding(4)
        Me.CbEnregPdf.Name = "CbEnregPdf"
        Me.CbEnregPdf.Size = New System.Drawing.Size(188, 21)
        Me.CbEnregPdf.TabIndex = 6
        Me.CbEnregPdf.Text = "Enregistrer le fichier PDF"
        Me.CbEnregPdf.UseVisualStyleBackColor = True
        '
        'BtTerminer
        '
        Me.BtTerminer.Location = New System.Drawing.Point(440, 24)
        Me.BtTerminer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtTerminer.Name = "BtTerminer"
        Me.BtTerminer.Size = New System.Drawing.Size(134, 48)
        Me.BtTerminer.TabIndex = 9
        Me.BtTerminer.Text = "Terminer"
        Me.BtTerminer.UseVisualStyleBackColor = True
        '
        'BtPrecedentDeRecap
        '
        Me.BtPrecedentDeRecap.Location = New System.Drawing.Point(264, 24)
        Me.BtPrecedentDeRecap.Name = "BtPrecedentDeRecap"
        Me.BtPrecedentDeRecap.Size = New System.Drawing.Size(154, 48)
        Me.BtPrecedentDeRecap.TabIndex = 9
        Me.BtPrecedentDeRecap.Text = "<< Précédent"
        Me.BtPrecedentDeRecap.UseVisualStyleBackColor = True
        '
        'LbListeConcessionnaires
        '
        Me.LbListeConcessionnaires.AspectActif = True
        Me.LbListeConcessionnaires.BackColor = System.Drawing.Color.Transparent
        Me.LbListeConcessionnaires.DataSource = Nothing
        Me.LbListeConcessionnaires.Location = New System.Drawing.Point(6, 3)
        Me.LbListeConcessionnaires.Name = "LbListeConcessionnaires"
        Me.LbListeConcessionnaires.Size = New System.Drawing.Size(794, 213)
        Me.LbListeConcessionnaires.TabIndex = 182
        '
        'ListeBeneficiaires
        '
        Me.ListeBeneficiaires.AutoScroll = True
        Me.ListeBeneficiaires.BackColor = System.Drawing.Color.AliceBlue
        Me.ListeBeneficiaires.Location = New System.Drawing.Point(-2, 638)
        Me.ListeBeneficiaires.Margin = New System.Windows.Forms.Padding(4)
        Me.ListeBeneficiaires.Name = "ListeBeneficiaires"
        Me.ListeBeneficiaires.Size = New System.Drawing.Size(783, 207)
        Me.ListeBeneficiaires.TabIndex = 177
        Me.ListeBeneficiaires.Titre = "Bénéficiaires"
        '
        'PanelChoixTypeEmpl1
        '
        Me.PanelChoixTypeEmpl1.BackColor = System.Drawing.Color.Transparent
        Me.PanelChoixTypeEmpl1.Location = New System.Drawing.Point(0, 189)
        Me.PanelChoixTypeEmpl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelChoixTypeEmpl1.Name = "PanelChoixTypeEmpl1"
        Me.PanelChoixTypeEmpl1.Size = New System.Drawing.Size(669, 441)
        Me.PanelChoixTypeEmpl1.TabIndex = 176
        '
        'TextBoxNullable1
        '
        Me.TextBoxNullable1.CueBanner = Nothing
        Me.TextBoxNullable1.Location = New System.Drawing.Point(9, 21)
        Me.TextBoxNullable1.Multiline = True
        Me.TextBoxNullable1.Name = "TextBoxNullable1"
        Me.TextBoxNullable1.Size = New System.Drawing.Size(596, 96)
        Me.TextBoxNullable1.TabIndex = 0
        Me.TextBoxNullable1.Value = Nothing
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.FlpLabsBeneficiaires)
        Me.Panel2.Location = New System.Drawing.Point(13, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(585, 100)
        Me.Panel2.TabIndex = 1
        '
        'FormNouvelleConcession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(835, 1045)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormNouvelleConcession"
        Me.Tag = ""
        Me.Text = "Demande de réservation d'une concession"
        Me.TabControl1.ResumeLayout(False)
        Me.TabDemandeCsn.ResumeLayout(False)
        Me.TabDemandeCsn.PerformLayout()
        Me.PanCoordsDmdr.ResumeLayout(False)
        Me.TabRecap.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.GbPersMand.ResumeLayout(False)
        Me.GbPersMand.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GbRecapBenefs.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabDemandeCsn As TabPage
    Friend WithEvents BtSuivantDeForm As Button
    Friend WithEvents PanCoordsDmdr As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListeBeneficiaires As ListeBeneficiairesNvCon
    Friend WithEvents PanelChoixTypeEmpl1 As PanelChoixTypeEmpl
    Friend WithEvents Label1 As Label
    Friend WithEvents TabRecap As TabPage
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GbPersMand As GroupBox
    Friend WithEvents LabDmdrNom As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabDmdrAdresse As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabTypeConcession As Label
    Friend WithEvents GbRecapBenefs As GroupBox
    Friend WithEvents FlpLabsBeneficiaires As FlowLayoutPanel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBoxNullable1 As TextBoxNullable
    Friend WithEvents LbListeConcessionnaires As ListBoxCustomActeurs
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LabCsnrNomComplet As Label
    Friend WithEvents LabCsnrNoNat As Label
    Friend WithEvents LabCsnrDateNaiss As Label
    Friend WithEvents LabCsnrAdresseComplete As Label
    Friend WithEvents LabCsnrTel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CbOuvrirPdf As CheckBox
    Friend WithEvents CbEnregPdf As CheckBox
    Friend WithEvents BtTerminer As Button
    Friend WithEvents BtPrecedentDeRecap As Button
    Friend WithEvents Panel2 As Panel
End Class

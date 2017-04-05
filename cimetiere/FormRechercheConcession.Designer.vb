<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRechercheConcession
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
        Me.DgvConcessions = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomCsnr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Benefs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Defunts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbChampRecherche = New System.Windows.Forms.TextBox()
        Me.BtChercher = New System.Windows.Forms.Button()
        Me.LabFiltre = New System.Windows.Forms.Label()
        Me.GbConcessionnaire = New System.Windows.Forms.GroupBox()
        Me.FlpConcessionnaire = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabCsnrNom = New System.Windows.Forms.Label()
        Me.FlpInfosConcessionSelect = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabCsnrDomicile = New System.Windows.Forms.Label()
        Me.LabCsnrTel = New System.Windows.Forms.Label()
        Me.CsnrDateNaiss = New System.Windows.Forms.Label()
        Me.CsnrNoRegistre = New System.Windows.Forms.Label()
        Me.GbInfosCsn = New System.Windows.Forms.GroupBox()
        Me.LabDateFin = New System.Windows.Forms.Label()
        Me.LabDateDebut = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabCommentaireEmpl = New System.Windows.Forms.Label()
        Me.LabEmplacement = New System.Windows.Forms.Label()
        Me.GbBenefs = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabBenefsIndiquesOuPas = New System.Windows.Forms.Label()
        Me.GbOccupants = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabOccupantsOuPas = New System.Windows.Forms.Label()
        Me.GbCommentaire = New System.Windows.Forms.GroupBox()
        Me.LabCommentaireCsn = New System.Windows.Forms.Label()
        Me.LabRefEmplacement = New System.Windows.Forms.Label()
        Me.LabEmplPlaces = New System.Windows.Forms.Label()
        CType(Me.DgvConcessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbConcessionnaire.SuspendLayout()
        Me.FlpConcessionnaire.SuspendLayout()
        Me.FlpInfosConcessionSelect.SuspendLayout()
        Me.GbInfosCsn.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GbBenefs.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GbOccupants.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.GbCommentaire.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvConcessions
        '
        Me.DgvConcessions.AllowUserToAddRows = False
        Me.DgvConcessions.AllowUserToDeleteRows = False
        Me.DgvConcessions.AllowUserToOrderColumns = True
        Me.DgvConcessions.AllowUserToResizeRows = False
        Me.DgvConcessions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgvConcessions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvConcessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConcessions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.NomCsnr, Me.Empl, Me.Benefs, Me.Defunts})
        Me.DgvConcessions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvConcessions.EnableHeadersVisualStyles = False
        Me.DgvConcessions.Location = New System.Drawing.Point(14, 187)
        Me.DgvConcessions.MultiSelect = False
        Me.DgvConcessions.Name = "DgvConcessions"
        Me.DgvConcessions.ReadOnly = True
        Me.DgvConcessions.RowHeadersVisible = False
        Me.DgvConcessions.RowTemplate.Height = 24
        Me.DgvConcessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConcessions.Size = New System.Drawing.Size(709, 476)
        Me.DgvConcessions.TabIndex = 0
        '
        'No
        '
        Me.No.HeaderText = "N°"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 50
        '
        'NomCsnr
        '
        Me.NomCsnr.DataPropertyName = "NomCsnr"
        Me.NomCsnr.HeaderText = "Concessionnaire"
        Me.NomCsnr.Name = "NomCsnr"
        Me.NomCsnr.ReadOnly = True
        Me.NomCsnr.Width = 120
        '
        'Empl
        '
        Me.Empl.DataPropertyName = "RefEmpl"
        Me.Empl.HeaderText = "Empl."
        Me.Empl.Name = "Empl"
        Me.Empl.ReadOnly = True
        Me.Empl.Width = 50
        '
        'Benefs
        '
        Me.Benefs.DataPropertyName = "NomsBenefs"
        Me.Benefs.HeaderText = "Bénéficiaires"
        Me.Benefs.Name = "Benefs"
        Me.Benefs.ReadOnly = True
        Me.Benefs.Width = 120
        '
        'Defunts
        '
        Me.Defunts.DataPropertyName = "NomsDefunts"
        Me.Defunts.HeaderText = "Occupants"
        Me.Defunts.Name = "Defunts"
        Me.Defunts.ReadOnly = True
        Me.Defunts.Width = 120
        '
        'TbChampRecherche
        '
        Me.TbChampRecherche.Location = New System.Drawing.Point(26, 39)
        Me.TbChampRecherche.Name = "TbChampRecherche"
        Me.TbChampRecherche.Size = New System.Drawing.Size(278, 25)
        Me.TbChampRecherche.TabIndex = 1
        '
        'BtChercher
        '
        Me.BtChercher.Location = New System.Drawing.Point(362, 38)
        Me.BtChercher.Name = "BtChercher"
        Me.BtChercher.Size = New System.Drawing.Size(84, 33)
        Me.BtChercher.TabIndex = 3
        Me.BtChercher.Text = "cherch"
        Me.BtChercher.UseVisualStyleBackColor = True
        '
        'LabFiltre
        '
        Me.LabFiltre.AutoSize = True
        Me.LabFiltre.Location = New System.Drawing.Point(13, 156)
        Me.LabFiltre.Name = "LabFiltre"
        Me.LabFiltre.Size = New System.Drawing.Size(81, 20)
        Me.LabFiltre.TabIndex = 4
        Me.LabFiltre.Text = "(LabFiltre)"
        '
        'GbConcessionnaire
        '
        Me.GbConcessionnaire.AutoSize = True
        Me.GbConcessionnaire.Controls.Add(Me.FlpConcessionnaire)
        Me.GbConcessionnaire.Location = New System.Drawing.Point(3, 3)
        Me.GbConcessionnaire.Name = "GbConcessionnaire"
        Me.GbConcessionnaire.Size = New System.Drawing.Size(359, 148)
        Me.GbConcessionnaire.TabIndex = 5
        Me.GbConcessionnaire.TabStop = False
        Me.GbConcessionnaire.Text = "Concessionnaire"
        '
        'FlpConcessionnaire
        '
        Me.FlpConcessionnaire.AutoSize = True
        Me.FlpConcessionnaire.Controls.Add(Me.LabCsnrNom)
        Me.FlpConcessionnaire.Controls.Add(Me.LabCsnrDomicile)
        Me.FlpConcessionnaire.Controls.Add(Me.LabCsnrTel)
        Me.FlpConcessionnaire.Controls.Add(Me.CsnrDateNaiss)
        Me.FlpConcessionnaire.Controls.Add(Me.CsnrNoRegistre)
        Me.FlpConcessionnaire.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlpConcessionnaire.Location = New System.Drawing.Point(6, 24)
        Me.FlpConcessionnaire.Name = "FlpConcessionnaire"
        Me.FlpConcessionnaire.Size = New System.Drawing.Size(347, 100)
        Me.FlpConcessionnaire.TabIndex = 0
        '
        'LabCsnrNom
        '
        Me.LabCsnrNom.AutoSize = True
        Me.LabCsnrNom.Location = New System.Drawing.Point(3, 0)
        Me.LabCsnrNom.Name = "LabCsnrNom"
        Me.LabCsnrNom.Size = New System.Drawing.Size(75, 20)
        Me.LabCsnrNom.TabIndex = 0
        Me.LabCsnrNom.Text = "CsnrNom"
        '
        'FlpInfosConcessionSelect
        '
        Me.FlpInfosConcessionSelect.Controls.Add(Me.GbConcessionnaire)
        Me.FlpInfosConcessionSelect.Controls.Add(Me.GbInfosCsn)
        Me.FlpInfosConcessionSelect.Controls.Add(Me.GbBenefs)
        Me.FlpInfosConcessionSelect.Controls.Add(Me.GbOccupants)
        Me.FlpInfosConcessionSelect.Controls.Add(Me.GbCommentaire)
        Me.FlpInfosConcessionSelect.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlpInfosConcessionSelect.Location = New System.Drawing.Point(746, 38)
        Me.FlpInfosConcessionSelect.Name = "FlpInfosConcessionSelect"
        Me.FlpInfosConcessionSelect.Size = New System.Drawing.Size(362, 624)
        Me.FlpInfosConcessionSelect.TabIndex = 6
        '
        'LabCsnrDomicile
        '
        Me.LabCsnrDomicile.AutoSize = True
        Me.LabCsnrDomicile.Location = New System.Drawing.Point(3, 20)
        Me.LabCsnrDomicile.Name = "LabCsnrDomicile"
        Me.LabCsnrDomicile.Size = New System.Drawing.Size(102, 20)
        Me.LabCsnrDomicile.TabIndex = 1
        Me.LabCsnrDomicile.Text = "CsnrDomicile"
        '
        'LabCsnrTel
        '
        Me.LabCsnrTel.AutoSize = True
        Me.LabCsnrTel.Location = New System.Drawing.Point(3, 40)
        Me.LabCsnrTel.Name = "LabCsnrTel"
        Me.LabCsnrTel.Size = New System.Drawing.Size(63, 20)
        Me.LabCsnrTel.TabIndex = 2
        Me.LabCsnrTel.Text = "CsnrTel"
        '
        'CsnrDateNaiss
        '
        Me.CsnrDateNaiss.AutoSize = True
        Me.CsnrDateNaiss.Location = New System.Drawing.Point(3, 60)
        Me.CsnrDateNaiss.Name = "CsnrDateNaiss"
        Me.CsnrDateNaiss.Size = New System.Drawing.Size(116, 20)
        Me.CsnrDateNaiss.TabIndex = 3
        Me.CsnrDateNaiss.Text = "CsnrDateNaiss"
        '
        'CsnrNoRegistre
        '
        Me.CsnrNoRegistre.AutoSize = True
        Me.CsnrNoRegistre.Location = New System.Drawing.Point(3, 80)
        Me.CsnrNoRegistre.Name = "CsnrNoRegistre"
        Me.CsnrNoRegistre.Size = New System.Drawing.Size(122, 20)
        Me.CsnrNoRegistre.TabIndex = 4
        Me.CsnrNoRegistre.Text = "CsnrNoRegistre"
        '
        'GbInfosCsn
        '
        Me.GbInfosCsn.AutoSize = True
        Me.GbInfosCsn.Controls.Add(Me.FlowLayoutPanel1)
        Me.GbInfosCsn.Location = New System.Drawing.Point(3, 157)
        Me.GbInfosCsn.Name = "GbInfosCsn"
        Me.GbInfosCsn.Size = New System.Drawing.Size(356, 165)
        Me.GbInfosCsn.TabIndex = 6
        Me.GbInfosCsn.TabStop = False
        '
        'LabDateFin
        '
        Me.LabDateFin.AutoSize = True
        Me.LabDateFin.Location = New System.Drawing.Point(3, 60)
        Me.LabDateFin.Name = "LabDateFin"
        Me.LabDateFin.Size = New System.Drawing.Size(66, 20)
        Me.LabDateFin.TabIndex = 6
        Me.LabDateFin.Text = "DateFin"
        '
        'LabDateDebut
        '
        Me.LabDateDebut.AutoSize = True
        Me.LabDateDebut.Location = New System.Drawing.Point(3, 40)
        Me.LabDateDebut.Name = "LabDateDebut"
        Me.LabDateDebut.Size = New System.Drawing.Size(88, 20)
        Me.LabDateDebut.TabIndex = 5
        Me.LabDateDebut.Text = "DateDebut"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.LabEmplacement)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabRefEmplacement)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabDateDebut)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabDateFin)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabEmplPlaces)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabCommentaireEmpl)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 21)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(344, 120)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'LabCommentaireEmpl
        '
        Me.LabCommentaireEmpl.AutoSize = True
        Me.LabCommentaireEmpl.Location = New System.Drawing.Point(3, 100)
        Me.LabCommentaireEmpl.Name = "LabCommentaireEmpl"
        Me.LabCommentaireEmpl.Size = New System.Drawing.Size(202, 20)
        Me.LabCommentaireEmpl.TabIndex = 7
        Me.LabCommentaireEmpl.Text = "CommentaireEmplacement"
        '
        'LabEmplacement
        '
        Me.LabEmplacement.AutoSize = True
        Me.LabEmplacement.Location = New System.Drawing.Point(3, 0)
        Me.LabEmplacement.Name = "LabEmplacement"
        Me.LabEmplacement.Size = New System.Drawing.Size(107, 20)
        Me.LabEmplacement.TabIndex = 8
        Me.LabEmplacement.Text = "Emplacement"
        '
        'GbBenefs
        '
        Me.GbBenefs.AutoSize = True
        Me.GbBenefs.Controls.Add(Me.FlowLayoutPanel2)
        Me.GbBenefs.Location = New System.Drawing.Point(3, 328)
        Me.GbBenefs.Name = "GbBenefs"
        Me.GbBenefs.Size = New System.Drawing.Size(356, 68)
        Me.GbBenefs.TabIndex = 7
        Me.GbBenefs.TabStop = False
        Me.GbBenefs.Text = "Bénéficiaires"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.LabBenefsIndiquesOuPas)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(6, 24)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(344, 20)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'LabBenefsIndiquesOuPas
        '
        Me.LabBenefsIndiquesOuPas.AutoSize = True
        Me.LabBenefsIndiquesOuPas.Location = New System.Drawing.Point(3, 0)
        Me.LabBenefsIndiquesOuPas.Name = "LabBenefsIndiquesOuPas"
        Me.LabBenefsIndiquesOuPas.Size = New System.Drawing.Size(169, 20)
        Me.LabBenefsIndiquesOuPas.TabIndex = 0
        Me.LabBenefsIndiquesOuPas.Text = "BenefsIndiquesOuPas"
        '
        'GbOccupants
        '
        Me.GbOccupants.AutoSize = True
        Me.GbOccupants.Controls.Add(Me.FlowLayoutPanel3)
        Me.GbOccupants.Location = New System.Drawing.Point(3, 402)
        Me.GbOccupants.Name = "GbOccupants"
        Me.GbOccupants.Size = New System.Drawing.Size(355, 68)
        Me.GbOccupants.TabIndex = 8
        Me.GbOccupants.TabStop = False
        Me.GbOccupants.Text = "Occupant(s)"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.Controls.Add(Me.LabOccupantsOuPas)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(6, 24)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(343, 20)
        Me.FlowLayoutPanel3.TabIndex = 0
        '
        'LabOccupantsOuPas
        '
        Me.LabOccupantsOuPas.AutoSize = True
        Me.LabOccupantsOuPas.Location = New System.Drawing.Point(3, 0)
        Me.LabOccupantsOuPas.Name = "LabOccupantsOuPas"
        Me.LabOccupantsOuPas.Size = New System.Drawing.Size(134, 20)
        Me.LabOccupantsOuPas.TabIndex = 0
        Me.LabOccupantsOuPas.Text = "OccupantsOuPas"
        '
        'GbCommentaire
        '
        Me.GbCommentaire.Controls.Add(Me.LabCommentaireCsn)
        Me.GbCommentaire.Location = New System.Drawing.Point(3, 476)
        Me.GbCommentaire.Name = "GbCommentaire"
        Me.GbCommentaire.Size = New System.Drawing.Size(349, 100)
        Me.GbCommentaire.TabIndex = 9
        Me.GbCommentaire.TabStop = False
        Me.GbCommentaire.Text = "Commentaire"
        '
        'LabCommentaireCsn
        '
        Me.LabCommentaireCsn.AutoSize = True
        Me.LabCommentaireCsn.Location = New System.Drawing.Point(9, 21)
        Me.LabCommentaireCsn.Name = "LabCommentaireCsn"
        Me.LabCommentaireCsn.Size = New System.Drawing.Size(187, 20)
        Me.LabCommentaireCsn.TabIndex = 0
        Me.LabCommentaireCsn.Text = "CommentaireConcession"
        '
        'LabRefEmplacement
        '
        Me.LabRefEmplacement.AutoSize = True
        Me.LabRefEmplacement.Location = New System.Drawing.Point(3, 20)
        Me.LabRefEmplacement.Name = "LabRefEmplacement"
        Me.LabRefEmplacement.Size = New System.Drawing.Size(133, 20)
        Me.LabRefEmplacement.TabIndex = 9
        Me.LabRefEmplacement.Text = "RefEmplacement"
        '
        'LabEmplPlaces
        '
        Me.LabEmplPlaces.AutoSize = True
        Me.LabEmplPlaces.Location = New System.Drawing.Point(3, 80)
        Me.LabEmplPlaces.Name = "LabEmplPlaces"
        Me.LabEmplPlaces.Size = New System.Drawing.Size(56, 20)
        Me.LabEmplPlaces.TabIndex = 10
        Me.LabEmplPlaces.Text = "Places"
        '
        'FormRechercheConcession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 676)
        Me.Controls.Add(Me.FlpInfosConcessionSelect)
        Me.Controls.Add(Me.LabFiltre)
        Me.Controls.Add(Me.BtChercher)
        Me.Controls.Add(Me.TbChampRecherche)
        Me.Controls.Add(Me.DgvConcessions)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.3!)
        Me.Name = "FormRechercheConcession"
        Me.Text = "FormRechercheConcession"
        CType(Me.DgvConcessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbConcessionnaire.ResumeLayout(False)
        Me.GbConcessionnaire.PerformLayout()
        Me.FlpConcessionnaire.ResumeLayout(False)
        Me.FlpConcessionnaire.PerformLayout()
        Me.FlpInfosConcessionSelect.ResumeLayout(False)
        Me.FlpInfosConcessionSelect.PerformLayout()
        Me.GbInfosCsn.ResumeLayout(False)
        Me.GbInfosCsn.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.GbBenefs.ResumeLayout(False)
        Me.GbBenefs.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.GbOccupants.ResumeLayout(False)
        Me.GbOccupants.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.GbCommentaire.ResumeLayout(False)
        Me.GbCommentaire.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvConcessions As DataGridView
    Friend WithEvents TbChampRecherche As TextBox
    Friend WithEvents BtChercher As Button
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents NomCsnr As DataGridViewTextBoxColumn
    Friend WithEvents Empl As DataGridViewTextBoxColumn
    Friend WithEvents Benefs As DataGridViewTextBoxColumn
    Friend WithEvents Defunts As DataGridViewTextBoxColumn
    Friend WithEvents LabFiltre As Label
    Friend WithEvents GbConcessionnaire As GroupBox
    Friend WithEvents FlpConcessionnaire As FlowLayoutPanel
    Friend WithEvents LabCsnrNom As Label
    Friend WithEvents FlpInfosConcessionSelect As FlowLayoutPanel
    Friend WithEvents LabCsnrDomicile As Label
    Friend WithEvents LabCsnrTel As Label
    Friend WithEvents CsnrDateNaiss As Label
    Friend WithEvents CsnrNoRegistre As Label
    Friend WithEvents GbInfosCsn As GroupBox
    Friend WithEvents LabDateFin As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LabDateDebut As Label
    Friend WithEvents LabCommentaireEmpl As Label
    Friend WithEvents LabEmplacement As Label
    Friend WithEvents GbBenefs As GroupBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents LabBenefsIndiquesOuPas As Label
    Friend WithEvents GbOccupants As GroupBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents LabOccupantsOuPas As Label
    Friend WithEvents GbCommentaire As GroupBox
    Friend WithEvents LabCommentaireCsn As Label
    Friend WithEvents LabRefEmplacement As Label
    Friend WithEvents LabEmplPlaces As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGestion))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbDefChampRecherche = New System.Windows.Forms.TextBox()
        Me.CbDefChercherNom = New System.Windows.Forms.CheckBox()
        Me.CbDefChercherDateDeces = New System.Windows.Forms.CheckBox()
        Me.CbDefChercherCode = New System.Windows.Forms.CheckBox()
        Me.CbDefChercherEmplacement = New System.Windows.Forms.CheckBox()
        Me.BtDefChercher = New System.Windows.Forms.Button()
        Me.LvListeDefunts = New System.Windows.Forms.ListView()
        Me.Nom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Prenom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Emplacement = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateDeces = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FPBAjouter = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvListeDefunts = New System.Windows.Forms.DataGridView()
        Me.ColDefNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDefEmplacement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDateDeces = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FPBRefresh = New System.Windows.Forms.Button()
        Me.FPTBRechercher = New System.Windows.Forms.TextBox()
        Me.FPCBNom = New System.Windows.Forms.CheckBox()
        Me.FPCBDateD = New System.Windows.Forms.CheckBox()
        Me.FPCBDate = New System.Windows.Forms.CheckBox()
        Me.FPCBEmplacement = New System.Windows.Forms.CheckBox()
        Me.FPBRechercher = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtDefDomicile = New System.Windows.Forms.Label()
        Me.TxtDefEtatCiv = New System.Windows.Forms.Label()
        Me.TxtDefCode = New System.Windows.Forms.Label()
        Me.TxtDefDateDeces = New System.Windows.Forms.Label()
        Me.TxtDefNom = New System.Windows.Forms.Label()
        Me.TxtDefEmplacement = New System.Windows.Forms.LinkLabel()
        Me.LabDefDomicile = New System.Windows.Forms.Label()
        Me.LabDefCode = New System.Windows.Forms.Label()
        Me.LabDefEmplacement = New System.Windows.Forms.Label()
        Me.LabDefDateDeces = New System.Windows.Forms.Label()
        Me.LabDefEtatCivil = New System.Windows.Forms.Label()
        Me.FPBSupprimer = New System.Windows.Forms.Button()
        Me.FPBModifier = New System.Windows.Forms.Button()
        Me.FPBDetails = New System.Windows.Forms.Button()
        Me.FPBLienCons = New System.Windows.Forms.Button()
        Me.FPTBLahulpe = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.FCDGBeneficiare = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.FCDGDefunt = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.FCTBNom = New System.Windows.Forms.TextBox()
        Me.FCLNom = New System.Windows.Forms.Label()
        Me.FCLPrenom = New System.Windows.Forms.Label()
        Me.FCLPays = New System.Windows.Forms.Label()
        Me.FCTBPrenom = New System.Windows.Forms.TextBox()
        Me.FCTBPays = New System.Windows.Forms.TextBox()
        Me.FCLDateNaiss = New System.Windows.Forms.Label()
        Me.FCTBDateNaiss = New System.Windows.Forms.TextBox()
        Me.FCLLienParente = New System.Windows.Forms.Label()
        Me.FCTBCodePostal = New System.Windows.Forms.TextBox()
        Me.FCTBLienParente = New System.Windows.Forms.TextBox()
        Me.FCLCodePostal = New System.Windows.Forms.Label()
        Me.FCLAdresse = New System.Windows.Forms.Label()
        Me.FCTBAdresse = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.FCDGConss = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.FCLDenomination = New System.Windows.Forms.Label()
        Me.FCTBDenomination = New System.Windows.Forms.TextBox()
        Me.FCLEmplacement = New System.Windows.Forms.Label()
        Me.FCTBEmplacement = New System.Windows.Forms.TextBox()
        Me.FCLPlaceLibre = New System.Windows.Forms.Label()
        Me.FCTBPlaceLibre = New System.Windows.Forms.TextBox()
        Me.FCLPlaceOccupe = New System.Windows.Forms.Label()
        Me.FCTBPlaceOccupe = New System.Windows.Forms.TextBox()
        Me.FCTBMonumentClasse = New System.Windows.Forms.TextBox()
        Me.FCLCommentaire = New System.Windows.Forms.Label()
        Me.FCTBCommentaire = New System.Windows.Forms.TextBox()
        Me.FCLMonumentC = New System.Windows.Forms.Label()
        Me.FCLHistoire = New System.Windows.Forms.Label()
        Me.FCTBHistoire = New System.Windows.Forms.TextBox()
        Me.FCLType = New System.Windows.Forms.Label()
        Me.FCTBType = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.FCTBRechercher = New System.Windows.Forms.TextBox()
        Me.FCCBNom = New System.Windows.Forms.CheckBox()
        Me.FCCBDate = New System.Windows.Forms.CheckBox()
        Me.FCCBEmplacement = New System.Windows.Forms.CheckBox()
        Me.FCBRechercher = New System.Windows.Forms.Button()
        Me.FCCBType = New System.Windows.Forms.CheckBox()
        Me.FCBSupp = New System.Windows.Forms.Button()
        Me.FCBModifier = New System.Windows.Forms.Button()
        Me.FCBAjouter = New System.Windows.Forms.Button()
        Me.FCBLienDefunt = New System.Windows.Forms.Button()
        Me.FCBDetails = New System.Windows.Forms.Button()
        Me.FCPBlahulpe = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PRBPersCon = New System.Windows.Forms.RadioButton()
        Me.PRBConcessionnaire = New System.Windows.Forms.RadioButton()
        Me.PRBBenef = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TBPersAdress = New cimetiere.TextBoxNullable()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBPersNumNational = New cimetiere.TextBoxIntNullable()
        Me.TBPersDN = New cimetiere.MaskedTextBoxDate()
        Me.TBPersTel = New cimetiere.TextBoxNullable()
        Me.TBPersPays = New cimetiere.TextBoxNullable()
        Me.TBPersVille = New cimetiere.TextBoxNullable()
        Me.TBPersCodePostal = New cimetiere.TextBoxIntNullable()
        Me.TBPersNom = New cimetiere.TextBoxNullable()
        Me.TBPersPrenom = New cimetiere.TextBoxNullable()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.TBConsAdresse = New cimetiere.TextBoxNullable()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TBConsDateNaiss = New cimetiere.MaskedTextBoxDate()
        Me.TBConsTel = New cimetiere.TextBoxNullable()
        Me.TBConsPays = New cimetiere.TextBoxNullable()
        Me.TBConsVille = New cimetiere.TextBoxNullable()
        Me.TBConsCodePostal = New cimetiere.TextBoxIntNullable()
        Me.TBConsNom = New cimetiere.TextBoxNullable()
        Me.TBConsPrenom = New cimetiere.TextBoxNullable()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TBBenefAdresse = New cimetiere.TextBoxNullable()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TBBenefDN = New cimetiere.MaskedTextBoxDate()
        Me.TBBenefTel = New cimetiere.TextBoxNullable()
        Me.TBBenefPays = New cimetiere.TextBoxNullable()
        Me.TBBenefVille = New cimetiere.TextBoxNullable()
        Me.TBBenefCodePostal = New cimetiere.TextBoxIntNullable()
        Me.TBBenefNom = New cimetiere.TextBoxNullable()
        Me.TBBenefPrenom = New cimetiere.TextBoxNullable()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.DgvListeConcessionnaire = New System.Windows.Forms.DataGridView()
        Me.ColPersNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.TextBoxNullable1 = New cimetiere.TextBoxNullable()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvListeDefunts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FPTBLahulpe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.FCDGBeneficiare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.FCDGDefunt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.FCDGConss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.FCPBlahulpe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.DgvListeConcessionnaire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(64, 32)
        Me.TabControl1.Location = New System.Drawing.Point(-5, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1300, 673)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Panel10)
        Me.TabPage1.Controls.Add(Me.LvListeDefunts)
        Me.TabPage1.Controls.Add(Me.FPBAjouter)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.FPBSupprimer)
        Me.TabPage1.Controls.Add(Me.FPBModifier)
        Me.TabPage1.Controls.Add(Me.FPBDetails)
        Me.TabPage1.Controls.Add(Me.FPBLienCons)
        Me.TabPage1.Controls.Add(Me.FPTBLahulpe)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1292, 633)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Défunt"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel10.Controls.Add(Me.GroupBox10)
        Me.Panel10.Location = New System.Drawing.Point(3, 89)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(261, 241)
        Me.Panel10.TabIndex = 94
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox10.Controls.Add(Me.Button1)
        Me.GroupBox10.Controls.Add(Me.Label3)
        Me.GroupBox10.Controls.Add(Me.Label2)
        Me.GroupBox10.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox10.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox10.Controls.Add(Me.Label1)
        Me.GroupBox10.Controls.Add(Me.TbDefChampRecherche)
        Me.GroupBox10.Controls.Add(Me.CbDefChercherNom)
        Me.GroupBox10.Controls.Add(Me.CbDefChercherDateDeces)
        Me.GroupBox10.Controls.Add(Me.CbDefChercherCode)
        Me.GroupBox10.Controls.Add(Me.CbDefChercherEmplacement)
        Me.GroupBox10.Controls.Add(Me.BtDefChercher)
        Me.GroupBox10.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(242, 221)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Rechercher"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 23)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Annuler la recherche"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 14)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Décédé après :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 14)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Décédé avant :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Checked = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(98, 142)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowCheckBox = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(113, 21)
        Me.DateTimePicker2.TabIndex = 94
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(98, 115)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowCheckBox = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(113, 21)
        Me.DateTimePicker1.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Dans :"
        '
        'TbDefChampRecherche
        '
        Me.TbDefChampRecherche.Location = New System.Drawing.Point(10, 20)
        Me.TbDefChampRecherche.Name = "TbDefChampRecherche"
        Me.TbDefChampRecherche.Size = New System.Drawing.Size(150, 21)
        Me.TbDefChampRecherche.TabIndex = 40
        '
        'CbDefChercherNom
        '
        Me.CbDefChercherNom.AutoSize = True
        Me.CbDefChercherNom.Location = New System.Drawing.Point(10, 69)
        Me.CbDefChercherNom.Name = "CbDefChercherNom"
        Me.CbDefChercherNom.Size = New System.Drawing.Size(50, 18)
        Me.CbDefChercherNom.TabIndex = 45
        Me.CbDefChercherNom.Text = "Nom"
        Me.CbDefChercherNom.UseVisualStyleBackColor = True
        '
        'CbDefChercherDateDeces
        '
        Me.CbDefChercherDateDeces.AutoSize = True
        Me.CbDefChercherDateDeces.Location = New System.Drawing.Point(65, 69)
        Me.CbDefChercherDateDeces.Name = "CbDefChercherDateDeces"
        Me.CbDefChercherDateDeces.Size = New System.Drawing.Size(98, 18)
        Me.CbDefChercherDateDeces.TabIndex = 91
        Me.CbDefChercherDateDeces.Text = "Date de décès"
        Me.CbDefChercherDateDeces.UseVisualStyleBackColor = True
        '
        'CbDefChercherCode
        '
        Me.CbDefChercherCode.AutoSize = True
        Me.CbDefChercherCode.Location = New System.Drawing.Point(107, 88)
        Me.CbDefChercherCode.Name = "CbDefChercherCode"
        Me.CbDefChercherCode.Size = New System.Drawing.Size(53, 18)
        Me.CbDefChercherCode.TabIndex = 46
        Me.CbDefChercherCode.Text = "Code"
        Me.CbDefChercherCode.UseVisualStyleBackColor = True
        '
        'CbDefChercherEmplacement
        '
        Me.CbDefChercherEmplacement.AutoSize = True
        Me.CbDefChercherEmplacement.Location = New System.Drawing.Point(10, 88)
        Me.CbDefChercherEmplacement.Name = "CbDefChercherEmplacement"
        Me.CbDefChercherEmplacement.Size = New System.Drawing.Size(94, 18)
        Me.CbDefChercherEmplacement.TabIndex = 47
        Me.CbDefChercherEmplacement.Text = "Emplacement"
        Me.CbDefChercherEmplacement.UseVisualStyleBackColor = True
        '
        'BtDefChercher
        '
        Me.BtDefChercher.Location = New System.Drawing.Point(156, 192)
        Me.BtDefChercher.Name = "BtDefChercher"
        Me.BtDefChercher.Size = New System.Drawing.Size(75, 23)
        Me.BtDefChercher.TabIndex = 49
        Me.BtDefChercher.Text = "Rechercher"
        Me.BtDefChercher.UseVisualStyleBackColor = True
        '
        'LvListeDefunts
        '
        Me.LvListeDefunts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nom, Me.Prenom, Me.Emplacement, Me.Code, Me.DateDeces})
        Me.LvListeDefunts.FullRowSelect = True
        Me.LvListeDefunts.Location = New System.Drawing.Point(1621, 667)
        Me.LvListeDefunts.MultiSelect = False
        Me.LvListeDefunts.Name = "LvListeDefunts"
        Me.LvListeDefunts.Size = New System.Drawing.Size(224, 134)
        Me.LvListeDefunts.TabIndex = 95
        Me.LvListeDefunts.UseCompatibleStateImageBehavior = False
        Me.LvListeDefunts.View = System.Windows.Forms.View.Details
        '
        'Nom
        '
        Me.Nom.Tag = "nom"
        Me.Nom.Text = "Nom"
        '
        'Prenom
        '
        Me.Prenom.Tag = "prenom"
        Me.Prenom.Text = "Prénom"
        '
        'Emplacement
        '
        Me.Emplacement.Tag = "emplacement"
        Me.Emplacement.Text = "Emplacement"
        '
        'Code
        '
        Me.Code.Tag = "code"
        Me.Code.Text = "Code"
        '
        'DateDeces
        '
        Me.DateDeces.Tag = "datedeces"
        Me.DateDeces.Text = "Date de décès"
        '
        'FPBAjouter
        '
        Me.FPBAjouter.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBAjouter.ForeColor = System.Drawing.Color.Transparent
        Me.FPBAjouter.Location = New System.Drawing.Point(756, 349)
        Me.FPBAjouter.Name = "FPBAjouter"
        Me.FPBAjouter.Size = New System.Drawing.Size(64, 23)
        Me.FPBAjouter.TabIndex = 88
        Me.FPBAjouter.Text = "Ajouter"
        Me.FPBAjouter.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Location = New System.Drawing.Point(305, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(403, 513)
        Me.Panel3.TabIndex = 94
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox3.Controls.Add(Me.DgvListeDefunts)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(381, 496)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'DgvListeDefunts
        '
        Me.DgvListeDefunts.AllowUserToAddRows = False
        Me.DgvListeDefunts.AllowUserToDeleteRows = False
        Me.DgvListeDefunts.AllowUserToOrderColumns = True
        Me.DgvListeDefunts.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvListeDefunts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvListeDefunts.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DgvListeDefunts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvListeDefunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListeDefunts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColDefNom, Me.ColDefEmplacement, Me.ColDateDeces, Me.ColCode})
        Me.DgvListeDefunts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvListeDefunts.EnableHeadersVisualStyles = False
        Me.DgvListeDefunts.GridColor = System.Drawing.Color.DarkGray
        Me.DgvListeDefunts.Location = New System.Drawing.Point(8, 15)
        Me.DgvListeDefunts.MultiSelect = False
        Me.DgvListeDefunts.Name = "DgvListeDefunts"
        Me.DgvListeDefunts.ReadOnly = True
        Me.DgvListeDefunts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvListeDefunts.RowHeadersVisible = False
        Me.DgvListeDefunts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListeDefunts.Size = New System.Drawing.Size(367, 476)
        Me.DgvListeDefunts.TabIndex = 48
        '
        'ColDefNom
        '
        Me.ColDefNom.DataPropertyName = "Nom"
        Me.ColDefNom.HeaderText = "Nom"
        Me.ColDefNom.Name = "ColDefNom"
        Me.ColDefNom.ReadOnly = True
        '
        'ColDefEmplacement
        '
        Me.ColDefEmplacement.DataPropertyName = "RefEmplacement"
        Me.ColDefEmplacement.HeaderText = "Emplacement"
        Me.ColDefEmplacement.Name = "ColDefEmplacement"
        Me.ColDefEmplacement.ReadOnly = True
        '
        'ColDateDeces
        '
        Me.ColDateDeces.DataPropertyName = "DateDeces"
        Me.ColDateDeces.HeaderText = "Date de décès"
        Me.ColDateDeces.Name = "ColDateDeces"
        Me.ColDateDeces.ReadOnly = True
        '
        'ColCode
        '
        Me.ColCode.DataPropertyName = "NumeroLh"
        Me.ColCode.HeaderText = "Code"
        Me.ColCode.Name = "ColCode"
        Me.ColCode.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(961, 313)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(147, 201)
        Me.Panel2.TabIndex = 93
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox2.Controls.Add(Me.FPBRefresh)
        Me.GroupBox2.Controls.Add(Me.FPTBRechercher)
        Me.GroupBox2.Controls.Add(Me.FPCBNom)
        Me.GroupBox2.Controls.Add(Me.FPCBDateD)
        Me.GroupBox2.Controls.Add(Me.FPCBDate)
        Me.GroupBox2.Controls.Add(Me.FPCBEmplacement)
        Me.GroupBox2.Controls.Add(Me.FPBRechercher)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 181)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechercher"
        '
        'FPBRefresh
        '
        Me.FPBRefresh.Location = New System.Drawing.Point(29, 152)
        Me.FPBRefresh.Name = "FPBRefresh"
        Me.FPBRefresh.Size = New System.Drawing.Size(75, 23)
        Me.FPBRefresh.TabIndex = 92
        Me.FPBRefresh.Text = "Actualiser"
        Me.FPBRefresh.UseVisualStyleBackColor = True
        '
        'FPTBRechercher
        '
        Me.FPTBRechercher.Location = New System.Drawing.Point(10, 18)
        Me.FPTBRechercher.Name = "FPTBRechercher"
        Me.FPTBRechercher.Size = New System.Drawing.Size(100, 21)
        Me.FPTBRechercher.TabIndex = 40
        '
        'FPCBNom
        '
        Me.FPCBNom.AutoSize = True
        Me.FPCBNom.Location = New System.Drawing.Point(10, 44)
        Me.FPCBNom.Name = "FPCBNom"
        Me.FPCBNom.Size = New System.Drawing.Size(50, 18)
        Me.FPCBNom.TabIndex = 45
        Me.FPCBNom.Text = "Nom"
        Me.FPCBNom.UseVisualStyleBackColor = True
        '
        'FPCBDateD
        '
        Me.FPCBDateD.AutoSize = True
        Me.FPCBDateD.Location = New System.Drawing.Point(10, 87)
        Me.FPCBDateD.Name = "FPCBDateD"
        Me.FPCBDateD.Size = New System.Drawing.Size(98, 18)
        Me.FPCBDateD.TabIndex = 91
        Me.FPCBDateD.Text = "Date de décès"
        Me.FPCBDateD.UseVisualStyleBackColor = True
        '
        'FPCBDate
        '
        Me.FPCBDate.AutoSize = True
        Me.FPCBDate.Location = New System.Drawing.Point(61, 44)
        Me.FPCBDate.Name = "FPCBDate"
        Me.FPCBDate.Size = New System.Drawing.Size(50, 18)
        Me.FPCBDate.TabIndex = 46
        Me.FPCBDate.Text = "Date"
        Me.FPCBDate.UseVisualStyleBackColor = True
        '
        'FPCBEmplacement
        '
        Me.FPCBEmplacement.AutoSize = True
        Me.FPCBEmplacement.Location = New System.Drawing.Point(10, 67)
        Me.FPCBEmplacement.Name = "FPCBEmplacement"
        Me.FPCBEmplacement.Size = New System.Drawing.Size(94, 18)
        Me.FPCBEmplacement.TabIndex = 47
        Me.FPCBEmplacement.Text = "Emplacement"
        Me.FPCBEmplacement.UseVisualStyleBackColor = True
        '
        'FPBRechercher
        '
        Me.FPBRechercher.Location = New System.Drawing.Point(10, 113)
        Me.FPBRechercher.Name = "FPBRechercher"
        Me.FPBRechercher.Size = New System.Drawing.Size(75, 23)
        Me.FPBRechercher.TabIndex = 49
        Me.FPBRechercher.Text = "Rechercher"
        Me.FPBRechercher.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(718, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 266)
        Me.Panel1.TabIndex = 92
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.TxtDefDomicile)
        Me.GroupBox1.Controls.Add(Me.TxtDefEtatCiv)
        Me.GroupBox1.Controls.Add(Me.TxtDefCode)
        Me.GroupBox1.Controls.Add(Me.TxtDefDateDeces)
        Me.GroupBox1.Controls.Add(Me.TxtDefNom)
        Me.GroupBox1.Controls.Add(Me.TxtDefEmplacement)
        Me.GroupBox1.Controls.Add(Me.LabDefDomicile)
        Me.GroupBox1.Controls.Add(Me.LabDefCode)
        Me.GroupBox1.Controls.Add(Me.LabDefEmplacement)
        Me.GroupBox1.Controls.Add(Me.LabDefDateDeces)
        Me.GroupBox1.Controls.Add(Me.LabDefEtatCivil)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 245)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations du défunt"
        '
        'TxtDefDomicile
        '
        Me.TxtDefDomicile.AutoSize = True
        Me.TxtDefDomicile.Location = New System.Drawing.Point(68, 135)
        Me.TxtDefDomicile.Name = "TxtDefDomicile"
        Me.TxtDefDomicile.Size = New System.Drawing.Size(40, 14)
        Me.TxtDefDomicile.TabIndex = 92
        Me.TxtDefDomicile.Text = "Label7"
        '
        'TxtDefEtatCiv
        '
        Me.TxtDefEtatCiv.AutoSize = True
        Me.TxtDefEtatCiv.Location = New System.Drawing.Point(66, 114)
        Me.TxtDefEtatCiv.Name = "TxtDefEtatCiv"
        Me.TxtDefEtatCiv.Size = New System.Drawing.Size(40, 14)
        Me.TxtDefEtatCiv.TabIndex = 91
        Me.TxtDefEtatCiv.Text = "Label6"
        '
        'TxtDefCode
        '
        Me.TxtDefCode.AutoSize = True
        Me.TxtDefCode.Location = New System.Drawing.Point(370, 67)
        Me.TxtDefCode.Name = "TxtDefCode"
        Me.TxtDefCode.Size = New System.Drawing.Size(40, 14)
        Me.TxtDefCode.TabIndex = 89
        Me.TxtDefCode.Text = "Label4"
        '
        'TxtDefDateDeces
        '
        Me.TxtDefDateDeces.AutoSize = True
        Me.TxtDefDateDeces.Location = New System.Drawing.Point(67, 92)
        Me.TxtDefDateDeces.Name = "TxtDefDateDeces"
        Me.TxtDefDateDeces.Size = New System.Drawing.Size(40, 14)
        Me.TxtDefDateDeces.TabIndex = 88
        Me.TxtDefDateDeces.Text = "Label3"
        '
        'TxtDefNom
        '
        Me.TxtDefNom.AutoSize = True
        Me.TxtDefNom.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDefNom.Location = New System.Drawing.Point(16, 24)
        Me.TxtDefNom.Name = "TxtDefNom"
        Me.TxtDefNom.Size = New System.Drawing.Size(82, 30)
        Me.TxtDefNom.TabIndex = 86
        Me.TxtDefNom.Text = "Label1"
        '
        'TxtDefEmplacement
        '
        Me.TxtDefEmplacement.AutoSize = True
        Me.TxtDefEmplacement.Location = New System.Drawing.Point(84, 67)
        Me.TxtDefEmplacement.Name = "TxtDefEmplacement"
        Me.TxtDefEmplacement.Size = New System.Drawing.Size(61, 14)
        Me.TxtDefEmplacement.TabIndex = 85
        Me.TxtDefEmplacement.TabStop = True
        Me.TxtDefEmplacement.Text = "LinkLabel1"
        '
        'LabDefDomicile
        '
        Me.LabDefDomicile.AutoSize = True
        Me.LabDefDomicile.Location = New System.Drawing.Point(12, 135)
        Me.LabDefDomicile.Name = "LabDefDomicile"
        Me.LabDefDomicile.Size = New System.Drawing.Size(57, 14)
        Me.LabDefDomicile.TabIndex = 76
        Me.LabDefDomicile.Text = "Domicile :"
        '
        'LabDefCode
        '
        Me.LabDefCode.AutoSize = True
        Me.LabDefCode.Location = New System.Drawing.Point(286, 67)
        Me.LabDefCode.Name = "LabDefCode"
        Me.LabDefCode.Size = New System.Drawing.Size(78, 14)
        Me.LabDefCode.TabIndex = 71
        Me.LabDefCode.Text = "Code défunt :"
        '
        'LabDefEmplacement
        '
        Me.LabDefEmplacement.AutoSize = True
        Me.LabDefEmplacement.Location = New System.Drawing.Point(12, 67)
        Me.LabDefEmplacement.Name = "LabDefEmplacement"
        Me.LabDefEmplacement.Size = New System.Drawing.Size(75, 14)
        Me.LabDefEmplacement.TabIndex = 70
        Me.LabDefEmplacement.Text = "Emplacement"
        Me.LabDefEmplacement.Visible = False
        '
        'LabDefDateDeces
        '
        Me.LabDefDateDeces.AutoSize = True
        Me.LabDefDateDeces.Location = New System.Drawing.Point(12, 92)
        Me.LabDefDateDeces.Name = "LabDefDateDeces"
        Me.LabDefDateDeces.Size = New System.Drawing.Size(57, 14)
        Me.LabDefDateDeces.TabIndex = 69
        Me.LabDefDateDeces.Text = "Décédé le"
        '
        'LabDefEtatCivil
        '
        Me.LabDefEtatCivil.AutoSize = True
        Me.LabDefEtatCivil.Location = New System.Drawing.Point(12, 114)
        Me.LabDefEtatCivil.Name = "LabDefEtatCivil"
        Me.LabDefEtatCivil.Size = New System.Drawing.Size(57, 14)
        Me.LabDefEtatCivil.TabIndex = 82
        Me.LabDefEtatCivil.Text = "Etat Civil :"
        '
        'FPBSupprimer
        '
        Me.FPBSupprimer.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBSupprimer.ForeColor = System.Drawing.Color.Transparent
        Me.FPBSupprimer.Location = New System.Drawing.Point(757, 408)
        Me.FPBSupprimer.Name = "FPBSupprimer"
        Me.FPBSupprimer.Size = New System.Drawing.Size(74, 23)
        Me.FPBSupprimer.TabIndex = 90
        Me.FPBSupprimer.Text = "Supprimer"
        Me.FPBSupprimer.UseVisualStyleBackColor = False
        '
        'FPBModifier
        '
        Me.FPBModifier.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBModifier.ForeColor = System.Drawing.Color.Transparent
        Me.FPBModifier.Location = New System.Drawing.Point(757, 379)
        Me.FPBModifier.Name = "FPBModifier"
        Me.FPBModifier.Size = New System.Drawing.Size(64, 23)
        Me.FPBModifier.TabIndex = 89
        Me.FPBModifier.Text = "Modifier"
        Me.FPBModifier.UseVisualStyleBackColor = False
        '
        'FPBDetails
        '
        Me.FPBDetails.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBDetails.ForeColor = System.Drawing.Color.Transparent
        Me.FPBDetails.Location = New System.Drawing.Point(1157, 329)
        Me.FPBDetails.Name = "FPBDetails"
        Me.FPBDetails.Size = New System.Drawing.Size(99, 48)
        Me.FPBDetails.TabIndex = 87
        Me.FPBDetails.Text = "Détails"
        Me.FPBDetails.UseVisualStyleBackColor = False
        '
        'FPBLienCons
        '
        Me.FPBLienCons.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBLienCons.ForeColor = System.Drawing.Color.Transparent
        Me.FPBLienCons.Location = New System.Drawing.Point(1107, 279)
        Me.FPBLienCons.Name = "FPBLienCons"
        Me.FPBLienCons.Size = New System.Drawing.Size(152, 48)
        Me.FPBLienCons.TabIndex = 86
        Me.FPBLienCons.Text = "Lien vers concession"
        Me.FPBLienCons.UseVisualStyleBackColor = False
        '
        'FPTBLahulpe
        '
        Me.FPTBLahulpe.Image = CType(resources.GetObject("FPTBLahulpe.Image"), System.Drawing.Image)
        Me.FPTBLahulpe.Location = New System.Drawing.Point(0, 3)
        Me.FPTBLahulpe.Name = "FPTBLahulpe"
        Me.FPTBLahulpe.Size = New System.Drawing.Size(111, 77)
        Me.FPTBLahulpe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FPTBLahulpe.TabIndex = 50
        Me.FPTBLahulpe.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.GhostWhite
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Panel9)
        Me.TabPage2.Controls.Add(Me.Panel8)
        Me.TabPage2.Controls.Add(Me.Panel7)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.FCBSupp)
        Me.TabPage2.Controls.Add(Me.FCBModifier)
        Me.TabPage2.Controls.Add(Me.FCBAjouter)
        Me.TabPage2.Controls.Add(Me.FCBLienDefunt)
        Me.TabPage2.Controls.Add(Me.FCBDetails)
        Me.TabPage2.Controls.Add(Me.FCPBlahulpe)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1292, 633)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Concession"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel9.Controls.Add(Me.GroupBox9)
        Me.Panel9.Location = New System.Drawing.Point(159, 213)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(349, 200)
        Me.Panel9.TabIndex = 131
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox9.Controls.Add(Me.FCDGBeneficiare)
        Me.GroupBox9.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(312, 166)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Défunt :"
        '
        'FCDGBeneficiare
        '
        Me.FCDGBeneficiare.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.FCDGBeneficiare.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FCDGBeneficiare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FCDGBeneficiare.EnableHeadersVisualStyles = False
        Me.FCDGBeneficiare.Location = New System.Drawing.Point(0, 14)
        Me.FCDGBeneficiare.Name = "FCDGBeneficiare"
        Me.FCDGBeneficiare.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FCDGBeneficiare.RowHeadersVisible = False
        Me.FCDGBeneficiare.Size = New System.Drawing.Size(312, 152)
        Me.FCDGBeneficiare.TabIndex = 92
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel8.Controls.Add(Me.GroupBox8)
        Me.Panel8.Location = New System.Drawing.Point(159, 419)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(349, 200)
        Me.Panel8.TabIndex = 131
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox8.Controls.Add(Me.FCDGDefunt)
        Me.GroupBox8.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(312, 166)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Bénéficiaire :"
        '
        'FCDGDefunt
        '
        Me.FCDGDefunt.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.FCDGDefunt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FCDGDefunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FCDGDefunt.EnableHeadersVisualStyles = False
        Me.FCDGDefunt.Location = New System.Drawing.Point(0, 17)
        Me.FCDGDefunt.Name = "FCDGDefunt"
        Me.FCDGDefunt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FCDGDefunt.RowHeadersVisible = False
        Me.FCDGDefunt.Size = New System.Drawing.Size(312, 149)
        Me.FCDGDefunt.TabIndex = 93
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel7.Controls.Add(Me.GroupBox7)
        Me.Panel7.Location = New System.Drawing.Point(550, 419)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(536, 200)
        Me.Panel7.TabIndex = 130
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox7.Controls.Add(Me.FCTBNom)
        Me.GroupBox7.Controls.Add(Me.FCLNom)
        Me.GroupBox7.Controls.Add(Me.FCLPrenom)
        Me.GroupBox7.Controls.Add(Me.FCLPays)
        Me.GroupBox7.Controls.Add(Me.FCTBPrenom)
        Me.GroupBox7.Controls.Add(Me.FCTBPays)
        Me.GroupBox7.Controls.Add(Me.FCLDateNaiss)
        Me.GroupBox7.Controls.Add(Me.FCTBDateNaiss)
        Me.GroupBox7.Controls.Add(Me.FCLLienParente)
        Me.GroupBox7.Controls.Add(Me.FCTBCodePostal)
        Me.GroupBox7.Controls.Add(Me.FCTBLienParente)
        Me.GroupBox7.Controls.Add(Me.FCLCodePostal)
        Me.GroupBox7.Controls.Add(Me.FCLAdresse)
        Me.GroupBox7.Controls.Add(Me.FCTBAdresse)
        Me.GroupBox7.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(502, 166)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Infos Bénéficiaires"
        '
        'FCTBNom
        '
        Me.FCTBNom.Location = New System.Drawing.Point(128, 28)
        Me.FCTBNom.Name = "FCTBNom"
        Me.FCTBNom.Size = New System.Drawing.Size(128, 21)
        Me.FCTBNom.TabIndex = 103
        '
        'FCLNom
        '
        Me.FCLNom.AutoSize = True
        Me.FCLNom.Location = New System.Drawing.Point(79, 31)
        Me.FCLNom.Name = "FCLNom"
        Me.FCLNom.Size = New System.Drawing.Size(37, 14)
        Me.FCLNom.TabIndex = 102
        Me.FCLNom.Text = "Nom :"
        '
        'FCLPrenom
        '
        Me.FCLPrenom.AutoSize = True
        Me.FCLPrenom.Location = New System.Drawing.Point(309, 25)
        Me.FCLPrenom.Name = "FCLPrenom"
        Me.FCLPrenom.Size = New System.Drawing.Size(52, 14)
        Me.FCLPrenom.TabIndex = 104
        Me.FCLPrenom.Text = "Prenom :"
        '
        'FCLPays
        '
        Me.FCLPays.AutoSize = True
        Me.FCLPays.Location = New System.Drawing.Point(324, 105)
        Me.FCLPays.Name = "FCLPays"
        Me.FCLPays.Size = New System.Drawing.Size(35, 14)
        Me.FCLPays.TabIndex = 105
        Me.FCLPays.Text = "Pays :"
        '
        'FCTBPrenom
        '
        Me.FCTBPrenom.Location = New System.Drawing.Point(365, 22)
        Me.FCTBPrenom.Name = "FCTBPrenom"
        Me.FCTBPrenom.Size = New System.Drawing.Size(127, 21)
        Me.FCTBPrenom.TabIndex = 106
        '
        'FCTBPays
        '
        Me.FCTBPays.Location = New System.Drawing.Point(365, 102)
        Me.FCTBPays.Name = "FCTBPays"
        Me.FCTBPays.Size = New System.Drawing.Size(127, 21)
        Me.FCTBPays.TabIndex = 108
        '
        'FCLDateNaiss
        '
        Me.FCLDateNaiss.AutoSize = True
        Me.FCLDateNaiss.Location = New System.Drawing.Point(10, 58)
        Me.FCLDateNaiss.Name = "FCLDateNaiss"
        Me.FCLDateNaiss.Size = New System.Drawing.Size(106, 14)
        Me.FCLDateNaiss.TabIndex = 109
        Me.FCLDateNaiss.Text = "Date de naissance :"
        '
        'FCTBDateNaiss
        '
        Me.FCTBDateNaiss.Location = New System.Drawing.Point(128, 58)
        Me.FCTBDateNaiss.Name = "FCTBDateNaiss"
        Me.FCTBDateNaiss.Size = New System.Drawing.Size(128, 21)
        Me.FCTBDateNaiss.TabIndex = 110
        '
        'FCLLienParente
        '
        Me.FCLLienParente.AutoSize = True
        Me.FCLLienParente.Location = New System.Drawing.Point(263, 52)
        Me.FCLLienParente.Name = "FCLLienParente"
        Me.FCLLienParente.Size = New System.Drawing.Size(98, 14)
        Me.FCLLienParente.TabIndex = 111
        Me.FCLLienParente.Text = "Liens de parenté :"
        '
        'FCTBCodePostal
        '
        Me.FCTBCodePostal.Location = New System.Drawing.Point(365, 75)
        Me.FCTBCodePostal.Name = "FCTBCodePostal"
        Me.FCTBCodePostal.Size = New System.Drawing.Size(127, 21)
        Me.FCTBCodePostal.TabIndex = 116
        '
        'FCTBLienParente
        '
        Me.FCTBLienParente.Location = New System.Drawing.Point(366, 49)
        Me.FCTBLienParente.Name = "FCTBLienParente"
        Me.FCTBLienParente.Size = New System.Drawing.Size(127, 21)
        Me.FCTBLienParente.TabIndex = 112
        '
        'FCLCodePostal
        '
        Me.FCLCodePostal.AutoSize = True
        Me.FCLCodePostal.Location = New System.Drawing.Point(284, 79)
        Me.FCLCodePostal.Name = "FCLCodePostal"
        Me.FCLCodePostal.Size = New System.Drawing.Size(75, 14)
        Me.FCLCodePostal.TabIndex = 115
        Me.FCLCodePostal.Text = "Code postal :"
        '
        'FCLAdresse
        '
        Me.FCLAdresse.AutoSize = True
        Me.FCLAdresse.Location = New System.Drawing.Point(63, 88)
        Me.FCLAdresse.Name = "FCLAdresse"
        Me.FCLAdresse.Size = New System.Drawing.Size(53, 14)
        Me.FCLAdresse.TabIndex = 113
        Me.FCLAdresse.Text = "Adresse :"
        '
        'FCTBAdresse
        '
        Me.FCTBAdresse.Location = New System.Drawing.Point(127, 88)
        Me.FCTBAdresse.Name = "FCTBAdresse"
        Me.FCTBAdresse.Size = New System.Drawing.Size(128, 21)
        Me.FCTBAdresse.TabIndex = 114
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel5.Controls.Add(Me.GroupBox5)
        Me.Panel5.Location = New System.Drawing.Point(159, 7)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(349, 200)
        Me.Panel5.TabIndex = 130
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox5.Controls.Add(Me.FCDGConss)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(312, 166)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Concession :"
        '
        'FCDGConss
        '
        Me.FCDGConss.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.FCDGConss.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FCDGConss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FCDGConss.EnableHeadersVisualStyles = False
        Me.FCDGConss.Location = New System.Drawing.Point(0, 15)
        Me.FCDGConss.Name = "FCDGConss"
        Me.FCDGConss.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FCDGConss.RowHeadersVisible = False
        Me.FCDGConss.Size = New System.Drawing.Size(312, 151)
        Me.FCDGConss.TabIndex = 43
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel6.Controls.Add(Me.GroupBox6)
        Me.Panel6.Location = New System.Drawing.Point(550, 7)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(536, 200)
        Me.Panel6.TabIndex = 130
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox6.Controls.Add(Me.FCLDenomination)
        Me.GroupBox6.Controls.Add(Me.FCTBDenomination)
        Me.GroupBox6.Controls.Add(Me.FCLEmplacement)
        Me.GroupBox6.Controls.Add(Me.FCTBEmplacement)
        Me.GroupBox6.Controls.Add(Me.FCLPlaceLibre)
        Me.GroupBox6.Controls.Add(Me.FCTBPlaceLibre)
        Me.GroupBox6.Controls.Add(Me.FCLPlaceOccupe)
        Me.GroupBox6.Controls.Add(Me.FCTBPlaceOccupe)
        Me.GroupBox6.Controls.Add(Me.FCTBMonumentClasse)
        Me.GroupBox6.Controls.Add(Me.FCLCommentaire)
        Me.GroupBox6.Controls.Add(Me.FCTBCommentaire)
        Me.GroupBox6.Controls.Add(Me.FCLMonumentC)
        Me.GroupBox6.Controls.Add(Me.FCLHistoire)
        Me.GroupBox6.Controls.Add(Me.FCTBHistoire)
        Me.GroupBox6.Controls.Add(Me.FCLType)
        Me.GroupBox6.Controls.Add(Me.FCTBType)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(502, 166)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Infos Concessions"
        '
        'FCLDenomination
        '
        Me.FCLDenomination.AutoSize = True
        Me.FCLDenomination.Location = New System.Drawing.Point(31, 25)
        Me.FCLDenomination.Name = "FCLDenomination"
        Me.FCLDenomination.Size = New System.Drawing.Size(87, 14)
        Me.FCLDenomination.TabIndex = 64
        Me.FCLDenomination.Text = "Dénomination :"
        '
        'FCTBDenomination
        '
        Me.FCTBDenomination.Location = New System.Drawing.Point(124, 22)
        Me.FCTBDenomination.Name = "FCTBDenomination"
        Me.FCTBDenomination.Size = New System.Drawing.Size(129, 21)
        Me.FCTBDenomination.TabIndex = 65
        '
        'FCLEmplacement
        '
        Me.FCLEmplacement.AutoSize = True
        Me.FCLEmplacement.Location = New System.Drawing.Point(277, 20)
        Me.FCLEmplacement.Name = "FCLEmplacement"
        Me.FCLEmplacement.Size = New System.Drawing.Size(81, 14)
        Me.FCLEmplacement.TabIndex = 66
        Me.FCLEmplacement.Text = "Emplacement :"
        '
        'FCTBEmplacement
        '
        Me.FCTBEmplacement.Location = New System.Drawing.Point(361, 20)
        Me.FCTBEmplacement.Name = "FCTBEmplacement"
        Me.FCTBEmplacement.Size = New System.Drawing.Size(128, 21)
        Me.FCTBEmplacement.TabIndex = 67
        '
        'FCLPlaceLibre
        '
        Me.FCLPlaceLibre.AutoSize = True
        Me.FCLPlaceLibre.Location = New System.Drawing.Point(53, 56)
        Me.FCLPlaceLibre.Name = "FCLPlaceLibre"
        Me.FCLPlaceLibre.Size = New System.Drawing.Size(65, 14)
        Me.FCLPlaceLibre.TabIndex = 68
        Me.FCLPlaceLibre.Text = "Place libre :"
        '
        'FCTBPlaceLibre
        '
        Me.FCTBPlaceLibre.Location = New System.Drawing.Point(125, 53)
        Me.FCTBPlaceLibre.Name = "FCTBPlaceLibre"
        Me.FCTBPlaceLibre.Size = New System.Drawing.Size(128, 21)
        Me.FCTBPlaceLibre.TabIndex = 69
        '
        'FCLPlaceOccupe
        '
        Me.FCLPlaceOccupe.AutoSize = True
        Me.FCLPlaceOccupe.Location = New System.Drawing.Point(279, 54)
        Me.FCLPlaceOccupe.Name = "FCLPlaceOccupe"
        Me.FCLPlaceOccupe.Size = New System.Drawing.Size(79, 14)
        Me.FCLPlaceOccupe.TabIndex = 70
        Me.FCLPlaceOccupe.Text = "Place occupé :"
        '
        'FCTBPlaceOccupe
        '
        Me.FCTBPlaceOccupe.Location = New System.Drawing.Point(361, 51)
        Me.FCTBPlaceOccupe.Name = "FCTBPlaceOccupe"
        Me.FCTBPlaceOccupe.Size = New System.Drawing.Size(128, 21)
        Me.FCTBPlaceOccupe.TabIndex = 71
        '
        'FCTBMonumentClasse
        '
        Me.FCTBMonumentClasse.Location = New System.Drawing.Point(124, 83)
        Me.FCTBMonumentClasse.Name = "FCTBMonumentClasse"
        Me.FCTBMonumentClasse.Size = New System.Drawing.Size(128, 21)
        Me.FCTBMonumentClasse.TabIndex = 95
        '
        'FCLCommentaire
        '
        Me.FCLCommentaire.AutoSize = True
        Me.FCLCommentaire.Location = New System.Drawing.Point(277, 84)
        Me.FCLCommentaire.Name = "FCLCommentaire"
        Me.FCLCommentaire.Size = New System.Drawing.Size(81, 14)
        Me.FCLCommentaire.TabIndex = 124
        Me.FCLCommentaire.Text = "Commentaire :"
        '
        'FCTBCommentaire
        '
        Me.FCTBCommentaire.Location = New System.Drawing.Point(361, 81)
        Me.FCTBCommentaire.Name = "FCTBCommentaire"
        Me.FCTBCommentaire.Size = New System.Drawing.Size(128, 21)
        Me.FCTBCommentaire.TabIndex = 97
        '
        'FCLMonumentC
        '
        Me.FCLMonumentC.AutoSize = True
        Me.FCLMonumentC.Location = New System.Drawing.Point(14, 86)
        Me.FCLMonumentC.Name = "FCLMonumentC"
        Me.FCLMonumentC.Size = New System.Drawing.Size(105, 14)
        Me.FCLMonumentC.TabIndex = 123
        Me.FCLMonumentC.Text = "Monument Classé :"
        '
        'FCLHistoire
        '
        Me.FCLHistoire.AutoSize = True
        Me.FCLHistoire.Location = New System.Drawing.Point(65, 117)
        Me.FCLHistoire.Name = "FCLHistoire"
        Me.FCLHistoire.Size = New System.Drawing.Size(53, 14)
        Me.FCLHistoire.TabIndex = 98
        Me.FCLHistoire.Text = "Histoire :"
        '
        'FCTBHistoire
        '
        Me.FCTBHistoire.Location = New System.Drawing.Point(125, 114)
        Me.FCTBHistoire.Name = "FCTBHistoire"
        Me.FCTBHistoire.Size = New System.Drawing.Size(128, 21)
        Me.FCTBHistoire.TabIndex = 99
        '
        'FCLType
        '
        Me.FCLType.AutoSize = True
        Me.FCLType.Location = New System.Drawing.Point(318, 115)
        Me.FCLType.Name = "FCLType"
        Me.FCLType.Size = New System.Drawing.Size(36, 14)
        Me.FCLType.TabIndex = 100
        Me.FCLType.Text = "Type :"
        '
        'FCTBType
        '
        Me.FCTBType.Location = New System.Drawing.Point(361, 112)
        Me.FCTBType.Name = "FCTBType"
        Me.FCTBType.Size = New System.Drawing.Size(128, 21)
        Me.FCTBType.TabIndex = 101
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Location = New System.Drawing.Point(3, 83)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(150, 195)
        Me.Panel4.TabIndex = 129
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox4.Controls.Add(Me.FCTBRechercher)
        Me.GroupBox4.Controls.Add(Me.FCCBNom)
        Me.GroupBox4.Controls.Add(Me.FCCBDate)
        Me.GroupBox4.Controls.Add(Me.FCCBEmplacement)
        Me.GroupBox4.Controls.Add(Me.FCBRechercher)
        Me.GroupBox4.Controls.Add(Me.FCCBType)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(127, 171)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rechercher :"
        '
        'FCTBRechercher
        '
        Me.FCTBRechercher.Location = New System.Drawing.Point(6, 14)
        Me.FCTBRechercher.Name = "FCTBRechercher"
        Me.FCTBRechercher.Size = New System.Drawing.Size(100, 21)
        Me.FCTBRechercher.TabIndex = 35
        '
        'FCCBNom
        '
        Me.FCCBNom.AutoSize = True
        Me.FCCBNom.Location = New System.Drawing.Point(6, 40)
        Me.FCCBNom.Name = "FCCBNom"
        Me.FCCBNom.Size = New System.Drawing.Size(50, 18)
        Me.FCCBNom.TabIndex = 40
        Me.FCCBNom.Text = "Nom"
        Me.FCCBNom.UseVisualStyleBackColor = True
        '
        'FCCBDate
        '
        Me.FCCBDate.AutoSize = True
        Me.FCCBDate.Location = New System.Drawing.Point(57, 40)
        Me.FCCBDate.Name = "FCCBDate"
        Me.FCCBDate.Size = New System.Drawing.Size(50, 18)
        Me.FCCBDate.TabIndex = 41
        Me.FCCBDate.Text = "Date"
        Me.FCCBDate.UseVisualStyleBackColor = True
        '
        'FCCBEmplacement
        '
        Me.FCCBEmplacement.AutoSize = True
        Me.FCCBEmplacement.Location = New System.Drawing.Point(6, 64)
        Me.FCCBEmplacement.Name = "FCCBEmplacement"
        Me.FCCBEmplacement.Size = New System.Drawing.Size(94, 18)
        Me.FCCBEmplacement.TabIndex = 42
        Me.FCCBEmplacement.Text = "Emplacement"
        Me.FCCBEmplacement.UseVisualStyleBackColor = True
        '
        'FCBRechercher
        '
        Me.FCBRechercher.Location = New System.Drawing.Point(6, 108)
        Me.FCBRechercher.Name = "FCBRechercher"
        Me.FCBRechercher.Size = New System.Drawing.Size(75, 23)
        Me.FCBRechercher.TabIndex = 44
        Me.FCBRechercher.Text = "Rechercher"
        Me.FCBRechercher.UseVisualStyleBackColor = True
        '
        'FCCBType
        '
        Me.FCCBType.AutoSize = True
        Me.FCCBType.Location = New System.Drawing.Point(6, 84)
        Me.FCCBType.Name = "FCCBType"
        Me.FCCBType.Size = New System.Drawing.Size(49, 18)
        Me.FCCBType.TabIndex = 125
        Me.FCCBType.Text = "Type"
        Me.FCCBType.UseVisualStyleBackColor = True
        '
        'FCBSupp
        '
        Me.FCBSupp.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBSupp.ForeColor = System.Drawing.Color.Transparent
        Me.FCBSupp.Location = New System.Drawing.Point(20, 343)
        Me.FCBSupp.Name = "FCBSupp"
        Me.FCBSupp.Size = New System.Drawing.Size(74, 23)
        Me.FCBSupp.TabIndex = 128
        Me.FCBSupp.Text = "Supprimer"
        Me.FCBSupp.UseVisualStyleBackColor = False
        '
        'FCBModifier
        '
        Me.FCBModifier.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBModifier.ForeColor = System.Drawing.Color.Transparent
        Me.FCBModifier.Location = New System.Drawing.Point(20, 314)
        Me.FCBModifier.Name = "FCBModifier"
        Me.FCBModifier.Size = New System.Drawing.Size(64, 23)
        Me.FCBModifier.TabIndex = 127
        Me.FCBModifier.Text = "Modifier"
        Me.FCBModifier.UseVisualStyleBackColor = False
        '
        'FCBAjouter
        '
        Me.FCBAjouter.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBAjouter.ForeColor = System.Drawing.Color.Transparent
        Me.FCBAjouter.Location = New System.Drawing.Point(20, 285)
        Me.FCBAjouter.Name = "FCBAjouter"
        Me.FCBAjouter.Size = New System.Drawing.Size(64, 23)
        Me.FCBAjouter.TabIndex = 126
        Me.FCBAjouter.Text = "Ajouter"
        Me.FCBAjouter.UseVisualStyleBackColor = False
        '
        'FCBLienDefunt
        '
        Me.FCBLienDefunt.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBLienDefunt.ForeColor = System.Drawing.Color.Transparent
        Me.FCBLienDefunt.Location = New System.Drawing.Point(788, 268)
        Me.FCBLienDefunt.Name = "FCBLienDefunt"
        Me.FCBLienDefunt.Size = New System.Drawing.Size(154, 57)
        Me.FCBLienDefunt.TabIndex = 91
        Me.FCBLienDefunt.Text = "Lien vers Défunt"
        Me.FCBLienDefunt.UseVisualStyleBackColor = False
        '
        'FCBDetails
        '
        Me.FCBDetails.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBDetails.ForeColor = System.Drawing.Color.Transparent
        Me.FCBDetails.Location = New System.Drawing.Point(1000, 270)
        Me.FCBDetails.Name = "FCBDetails"
        Me.FCBDetails.Size = New System.Drawing.Size(86, 53)
        Me.FCBDetails.TabIndex = 90
        Me.FCBDetails.Text = "Détails"
        Me.FCBDetails.UseVisualStyleBackColor = False
        '
        'FCPBlahulpe
        '
        Me.FCPBlahulpe.Image = CType(resources.GetObject("FCPBlahulpe.Image"), System.Drawing.Image)
        Me.FCPBlahulpe.Location = New System.Drawing.Point(0, 2)
        Me.FCPBlahulpe.Name = "FCPBlahulpe"
        Me.FCPBlahulpe.Size = New System.Drawing.Size(111, 77)
        Me.FCPBlahulpe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FCPBlahulpe.TabIndex = 45
        Me.FCPBlahulpe.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PRBPersCon)
        Me.TabPage3.Controls.Add(Me.PRBConcessionnaire)
        Me.TabPage3.Controls.Add(Me.PRBBenef)
        Me.TabPage3.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage3.Controls.Add(Me.Panel12)
        Me.TabPage3.Controls.Add(Me.Panel14)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 36)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1292, 633)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Personnes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PRBPersCon
        '
        Me.PRBPersCon.AutoSize = True
        Me.PRBPersCon.Location = New System.Drawing.Point(394, 6)
        Me.PRBPersCon.Name = "PRBPersCon"
        Me.PRBPersCon.Size = New System.Drawing.Size(130, 18)
        Me.PRBPersCon.TabIndex = 142
        Me.PRBPersCon.Text = "Personne de contact"
        Me.PRBPersCon.UseVisualStyleBackColor = True
        '
        'PRBConcessionnaire
        '
        Me.PRBConcessionnaire.AutoSize = True
        Me.PRBConcessionnaire.Location = New System.Drawing.Point(282, 6)
        Me.PRBConcessionnaire.Name = "PRBConcessionnaire"
        Me.PRBConcessionnaire.Size = New System.Drawing.Size(110, 18)
        Me.PRBConcessionnaire.TabIndex = 141
        Me.PRBConcessionnaire.Text = "Concessionnaire"
        Me.PRBConcessionnaire.UseVisualStyleBackColor = True
        '
        'PRBBenef
        '
        Me.PRBBenef.AutoSize = True
        Me.PRBBenef.Checked = True
        Me.PRBBenef.Location = New System.Drawing.Point(192, 6)
        Me.PRBBenef.Name = "PRBBenef"
        Me.PRBBenef.Size = New System.Drawing.Size(85, 18)
        Me.PRBBenef.TabIndex = 140
        Me.PRBBenef.TabStop = True
        Me.PRBBenef.Text = "Bénéficiaire"
        Me.PRBBenef.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel13)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel11)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel15)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(546, 29)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(547, 582)
        Me.FlowLayoutPanel1.TabIndex = 139
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel13.Controls.Add(Me.GroupBox13)
        Me.Panel13.Location = New System.Drawing.Point(3, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(531, 200)
        Me.Panel13.TabIndex = 138
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox13.Controls.Add(Me.Button5)
        Me.GroupBox13.Controls.Add(Me.TBPersAdress)
        Me.GroupBox13.Controls.Add(Me.Button6)
        Me.GroupBox13.Controls.Add(Me.Label4)
        Me.GroupBox13.Controls.Add(Me.TBPersNumNational)
        Me.GroupBox13.Controls.Add(Me.TBPersDN)
        Me.GroupBox13.Controls.Add(Me.TBPersTel)
        Me.GroupBox13.Controls.Add(Me.TBPersPays)
        Me.GroupBox13.Controls.Add(Me.TBPersVille)
        Me.GroupBox13.Controls.Add(Me.TBPersCodePostal)
        Me.GroupBox13.Controls.Add(Me.TBPersNom)
        Me.GroupBox13.Controls.Add(Me.TBPersPrenom)
        Me.GroupBox13.Controls.Add(Me.Label9)
        Me.GroupBox13.Controls.Add(Me.Label8)
        Me.GroupBox13.Controls.Add(Me.Label7)
        Me.GroupBox13.Controls.Add(Me.Label6)
        Me.GroupBox13.Controls.Add(Me.Label5)
        Me.GroupBox13.Controls.Add(Me.Label10)
        Me.GroupBox13.Controls.Add(Me.Label11)
        Me.GroupBox13.Controls.Add(Me.Label28)
        Me.GroupBox13.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(500, 166)
        Me.GroupBox13.TabIndex = 0
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Infos Personnes"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SeaGreen
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(403, 129)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(74, 23)
        Me.Button5.TabIndex = 137
        Me.Button5.Text = "Supprimer"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TBPersAdress
        '
        Me.TBPersAdress.CueBanner = Nothing
        Me.TBPersAdress.Location = New System.Drawing.Point(74, 44)
        Me.TBPersAdress.Margin = New System.Windows.Forms.Padding(2)
        Me.TBPersAdress.Name = "TBPersAdress"
        Me.TBPersAdress.Size = New System.Drawing.Size(121, 21)
        Me.TBPersAdress.TabIndex = 26
        Me.TBPersAdress.Value = Nothing
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.SeaGreen
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(403, 100)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 23)
        Me.Button6.TabIndex = 136
        Me.Button6.Text = "Modifier"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 14)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Adresse"
        '
        'TBPersNumNational
        '
        Me.TBPersNumNational.CueBanner = Nothing
        Me.TBPersNumNational.Location = New System.Drawing.Point(80, 129)
        Me.TBPersNumNational.Margin = New System.Windows.Forms.Padding(2)
        Me.TBPersNumNational.Name = "TBPersNumNational"
        Me.TBPersNumNational.Size = New System.Drawing.Size(109, 21)
        Me.TBPersNumNational.TabIndex = 37
        Me.TBPersNumNational.Value = Nothing
        '
        'TBPersDN
        '
        Me.TBPersDN.DateValue = Nothing
        Me.TBPersDN.IntArrayValue = CType(resources.GetObject("TBPersDN.IntArrayValue"), System.Collections.Generic.List(Of System.Nullable(Of Integer)))
        Me.TBPersDN.Location = New System.Drawing.Point(113, 102)
        Me.TBPersDN.Margin = New System.Windows.Forms.Padding(2)
        Me.TBPersDN.Mask = "00/00/0000"
        Me.TBPersDN.Name = "TBPersDN"
        Me.TBPersDN.Size = New System.Drawing.Size(76, 21)
        Me.TBPersDN.TabIndex = 34
        Me.TBPersDN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBPersTel
        '
        Me.TBPersTel.CueBanner = Nothing
        Me.TBPersTel.Location = New System.Drawing.Point(74, 73)
        Me.TBPersTel.Margin = New System.Windows.Forms.Padding(2)
        Me.TBPersTel.Name = "TBPersTel"
        Me.TBPersTel.Size = New System.Drawing.Size(121, 21)
        Me.TBPersTel.TabIndex = 29
        Me.TBPersTel.Value = Nothing
        '
        'TBPersPays
        '
        Me.TBPersPays.CueBanner = Nothing
        Me.TBPersPays.Location = New System.Drawing.Point(265, 100)
        Me.TBPersPays.Margin = New System.Windows.Forms.Padding(2)
        Me.TBPersPays.Name = "TBPersPays"
        Me.TBPersPays.Size = New System.Drawing.Size(105, 21)
        Me.TBPersPays.TabIndex = 35
        Me.TBPersPays.Value = Nothing
        '
        'TBPersVille
        '
        Me.TBPersVille.CueBanner = Nothing
        Me.TBPersVille.Location = New System.Drawing.Point(265, 71)
        Me.TBPersVille.Margin = New System.Windows.Forms.Padding(2)
        Me.TBPersVille.Name = "TBPersVille"
        Me.TBPersVille.Size = New System.Drawing.Size(105, 21)
        Me.TBPersVille.TabIndex = 31
        Me.TBPersVille.Value = Nothing
        '
        'TBPersCodePostal
        '
        Me.TBPersCodePostal.CueBanner = Nothing
        Me.TBPersCodePostal.Location = New System.Drawing.Point(291, 42)
        Me.TBPersCodePostal.Margin = New System.Windows.Forms.Padding(2)
        Me.TBPersCodePostal.Name = "TBPersCodePostal"
        Me.TBPersCodePostal.Size = New System.Drawing.Size(79, 21)
        Me.TBPersCodePostal.TabIndex = 27
        Me.TBPersCodePostal.Value = Nothing
        '
        'TBPersNom
        '
        Me.TBPersNom.CueBanner = Nothing
        Me.TBPersNom.Location = New System.Drawing.Point(265, 15)
        Me.TBPersNom.Margin = New System.Windows.Forms.Padding(2)
        Me.TBPersNom.Name = "TBPersNom"
        Me.TBPersNom.Size = New System.Drawing.Size(105, 21)
        Me.TBPersNom.TabIndex = 24
        Me.TBPersNom.Value = Nothing
        '
        'TBPersPrenom
        '
        Me.TBPersPrenom.CueBanner = Nothing
        Me.TBPersPrenom.Location = New System.Drawing.Point(74, 15)
        Me.TBPersPrenom.Margin = New System.Windows.Forms.Padding(2)
        Me.TBPersPrenom.Name = "TBPersPrenom"
        Me.TBPersPrenom.Size = New System.Drawing.Size(121, 21)
        Me.TBPersPrenom.TabIndex = 22
        Me.TBPersPrenom.Value = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 131)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 14)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "N° national"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 104)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 14)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Date de naissance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 76)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 14)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Téléphone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(226, 102)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 14)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Pays"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 74)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 14)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Ville"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(223, 45)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 14)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Code postal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(222, 15)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 14)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Nom"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(14, 17)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(46, 14)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "Prénom"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel11.Controls.Add(Me.GroupBox11)
        Me.Panel11.Location = New System.Drawing.Point(3, 209)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(531, 200)
        Me.Panel11.TabIndex = 139
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox11.Controls.Add(Me.TBConsAdresse)
        Me.GroupBox11.Controls.Add(Me.Label12)
        Me.GroupBox11.Controls.Add(Me.Button3)
        Me.GroupBox11.Controls.Add(Me.Button4)
        Me.GroupBox11.Controls.Add(Me.TBConsDateNaiss)
        Me.GroupBox11.Controls.Add(Me.TBConsTel)
        Me.GroupBox11.Controls.Add(Me.TBConsPays)
        Me.GroupBox11.Controls.Add(Me.TBConsVille)
        Me.GroupBox11.Controls.Add(Me.TBConsCodePostal)
        Me.GroupBox11.Controls.Add(Me.TBConsNom)
        Me.GroupBox11.Controls.Add(Me.TBConsPrenom)
        Me.GroupBox11.Controls.Add(Me.Label14)
        Me.GroupBox11.Controls.Add(Me.Label15)
        Me.GroupBox11.Controls.Add(Me.Label16)
        Me.GroupBox11.Controls.Add(Me.Label17)
        Me.GroupBox11.Controls.Add(Me.Label18)
        Me.GroupBox11.Controls.Add(Me.Label19)
        Me.GroupBox11.Controls.Add(Me.Label29)
        Me.GroupBox11.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(500, 166)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Infos concessionnaire"
        '
        'TBConsAdresse
        '
        Me.TBConsAdresse.CueBanner = Nothing
        Me.TBConsAdresse.Location = New System.Drawing.Point(65, 44)
        Me.TBConsAdresse.Margin = New System.Windows.Forms.Padding(2)
        Me.TBConsAdresse.Name = "TBConsAdresse"
        Me.TBConsAdresse.Size = New System.Drawing.Size(121, 21)
        Me.TBConsAdresse.TabIndex = 26
        Me.TBConsAdresse.Value = Nothing
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 47)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 14)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Adresse"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SeaGreen
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(403, 129)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 23)
        Me.Button3.TabIndex = 135
        Me.Button3.Text = "Supprimer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SeaGreen
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(403, 100)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 23)
        Me.Button4.TabIndex = 134
        Me.Button4.Text = "Modifier"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TBConsDateNaiss
        '
        Me.TBConsDateNaiss.DateValue = Nothing
        Me.TBConsDateNaiss.IntArrayValue = CType(resources.GetObject("TBConsDateNaiss.IntArrayValue"), System.Collections.Generic.List(Of System.Nullable(Of Integer)))
        Me.TBConsDateNaiss.Location = New System.Drawing.Point(104, 102)
        Me.TBConsDateNaiss.Margin = New System.Windows.Forms.Padding(2)
        Me.TBConsDateNaiss.Mask = "00/00/0000"
        Me.TBConsDateNaiss.Name = "TBConsDateNaiss"
        Me.TBConsDateNaiss.Size = New System.Drawing.Size(76, 21)
        Me.TBConsDateNaiss.TabIndex = 34
        Me.TBConsDateNaiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBConsTel
        '
        Me.TBConsTel.CueBanner = Nothing
        Me.TBConsTel.Location = New System.Drawing.Point(65, 73)
        Me.TBConsTel.Margin = New System.Windows.Forms.Padding(2)
        Me.TBConsTel.Name = "TBConsTel"
        Me.TBConsTel.Size = New System.Drawing.Size(121, 21)
        Me.TBConsTel.TabIndex = 29
        Me.TBConsTel.Value = Nothing
        '
        'TBConsPays
        '
        Me.TBConsPays.CueBanner = Nothing
        Me.TBConsPays.Location = New System.Drawing.Point(234, 102)
        Me.TBConsPays.Margin = New System.Windows.Forms.Padding(2)
        Me.TBConsPays.Name = "TBConsPays"
        Me.TBConsPays.Size = New System.Drawing.Size(105, 21)
        Me.TBConsPays.TabIndex = 35
        Me.TBConsPays.Value = Nothing
        '
        'TBConsVille
        '
        Me.TBConsVille.CueBanner = Nothing
        Me.TBConsVille.Location = New System.Drawing.Point(234, 73)
        Me.TBConsVille.Margin = New System.Windows.Forms.Padding(2)
        Me.TBConsVille.Name = "TBConsVille"
        Me.TBConsVille.Size = New System.Drawing.Size(105, 21)
        Me.TBConsVille.TabIndex = 31
        Me.TBConsVille.Value = Nothing
        '
        'TBConsCodePostal
        '
        Me.TBConsCodePostal.CueBanner = Nothing
        Me.TBConsCodePostal.Location = New System.Drawing.Point(260, 44)
        Me.TBConsCodePostal.Margin = New System.Windows.Forms.Padding(2)
        Me.TBConsCodePostal.Name = "TBConsCodePostal"
        Me.TBConsCodePostal.Size = New System.Drawing.Size(79, 21)
        Me.TBConsCodePostal.TabIndex = 27
        Me.TBConsCodePostal.Value = Nothing
        '
        'TBConsNom
        '
        Me.TBConsNom.CueBanner = Nothing
        Me.TBConsNom.Location = New System.Drawing.Point(234, 17)
        Me.TBConsNom.Margin = New System.Windows.Forms.Padding(2)
        Me.TBConsNom.Name = "TBConsNom"
        Me.TBConsNom.Size = New System.Drawing.Size(105, 21)
        Me.TBConsNom.TabIndex = 24
        Me.TBConsNom.Value = Nothing
        '
        'TBConsPrenom
        '
        Me.TBConsPrenom.CueBanner = Nothing
        Me.TBConsPrenom.Location = New System.Drawing.Point(65, 15)
        Me.TBConsPrenom.Margin = New System.Windows.Forms.Padding(2)
        Me.TBConsPrenom.Name = "TBConsPrenom"
        Me.TBConsPrenom.Size = New System.Drawing.Size(121, 21)
        Me.TBConsPrenom.TabIndex = 22
        Me.TBConsPrenom.Value = Nothing
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 104)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 14)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Date de naissance"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 76)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 14)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Téléphone"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(195, 104)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 14)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Pays"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(195, 76)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 14)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Ville"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(192, 47)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 14)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Code postal"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(191, 17)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 14)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Nom"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(5, 17)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(46, 14)
        Me.Label29.TabIndex = 21
        Me.Label29.Text = "Prénom"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel15.Controls.Add(Me.GroupBox15)
        Me.Panel15.Location = New System.Drawing.Point(3, 415)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(531, 200)
        Me.Panel15.TabIndex = 140
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox15.Controls.Add(Me.Button7)
        Me.GroupBox15.Controls.Add(Me.TBBenefAdresse)
        Me.GroupBox15.Controls.Add(Me.Button8)
        Me.GroupBox15.Controls.Add(Me.Label20)
        Me.GroupBox15.Controls.Add(Me.TBBenefDN)
        Me.GroupBox15.Controls.Add(Me.TBBenefTel)
        Me.GroupBox15.Controls.Add(Me.TBBenefPays)
        Me.GroupBox15.Controls.Add(Me.TBBenefVille)
        Me.GroupBox15.Controls.Add(Me.TBBenefCodePostal)
        Me.GroupBox15.Controls.Add(Me.TBBenefNom)
        Me.GroupBox15.Controls.Add(Me.TBBenefPrenom)
        Me.GroupBox15.Controls.Add(Me.Label22)
        Me.GroupBox15.Controls.Add(Me.Label23)
        Me.GroupBox15.Controls.Add(Me.Label24)
        Me.GroupBox15.Controls.Add(Me.Label25)
        Me.GroupBox15.Controls.Add(Me.Label26)
        Me.GroupBox15.Controls.Add(Me.Label27)
        Me.GroupBox15.Controls.Add(Me.Label30)
        Me.GroupBox15.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(500, 166)
        Me.GroupBox15.TabIndex = 0
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Infos bénéficiaires"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.SeaGreen
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(393, 76)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(74, 23)
        Me.Button7.TabIndex = 137
        Me.Button7.Text = "Supprimer"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'TBBenefAdresse
        '
        Me.TBBenefAdresse.CueBanner = Nothing
        Me.TBBenefAdresse.Location = New System.Drawing.Point(68, 44)
        Me.TBBenefAdresse.Margin = New System.Windows.Forms.Padding(2)
        Me.TBBenefAdresse.Name = "TBBenefAdresse"
        Me.TBBenefAdresse.Size = New System.Drawing.Size(121, 21)
        Me.TBBenefAdresse.TabIndex = 26
        Me.TBBenefAdresse.Value = Nothing
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.SeaGreen
        Me.Button8.ForeColor = System.Drawing.Color.Transparent
        Me.Button8.Location = New System.Drawing.Point(403, 47)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(64, 23)
        Me.Button8.TabIndex = 136
        Me.Button8.Text = "Modifier"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 47)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 14)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Adresse"
        '
        'TBBenefDN
        '
        Me.TBBenefDN.DateValue = Nothing
        Me.TBBenefDN.IntArrayValue = CType(resources.GetObject("TBBenefDN.IntArrayValue"), System.Collections.Generic.List(Of System.Nullable(Of Integer)))
        Me.TBBenefDN.Location = New System.Drawing.Point(107, 102)
        Me.TBBenefDN.Margin = New System.Windows.Forms.Padding(2)
        Me.TBBenefDN.Mask = "00/00/0000"
        Me.TBBenefDN.Name = "TBBenefDN"
        Me.TBBenefDN.Size = New System.Drawing.Size(76, 21)
        Me.TBBenefDN.TabIndex = 34
        Me.TBBenefDN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBBenefTel
        '
        Me.TBBenefTel.CueBanner = Nothing
        Me.TBBenefTel.Location = New System.Drawing.Point(68, 73)
        Me.TBBenefTel.Margin = New System.Windows.Forms.Padding(2)
        Me.TBBenefTel.Name = "TBBenefTel"
        Me.TBBenefTel.Size = New System.Drawing.Size(121, 21)
        Me.TBBenefTel.TabIndex = 29
        Me.TBBenefTel.Value = Nothing
        '
        'TBBenefPays
        '
        Me.TBBenefPays.CueBanner = Nothing
        Me.TBBenefPays.Location = New System.Drawing.Point(237, 102)
        Me.TBBenefPays.Margin = New System.Windows.Forms.Padding(2)
        Me.TBBenefPays.Name = "TBBenefPays"
        Me.TBBenefPays.Size = New System.Drawing.Size(105, 21)
        Me.TBBenefPays.TabIndex = 35
        Me.TBBenefPays.Value = Nothing
        '
        'TBBenefVille
        '
        Me.TBBenefVille.CueBanner = Nothing
        Me.TBBenefVille.Location = New System.Drawing.Point(237, 73)
        Me.TBBenefVille.Margin = New System.Windows.Forms.Padding(2)
        Me.TBBenefVille.Name = "TBBenefVille"
        Me.TBBenefVille.Size = New System.Drawing.Size(105, 21)
        Me.TBBenefVille.TabIndex = 31
        Me.TBBenefVille.Value = Nothing
        '
        'TBBenefCodePostal
        '
        Me.TBBenefCodePostal.CueBanner = Nothing
        Me.TBBenefCodePostal.Location = New System.Drawing.Point(263, 44)
        Me.TBBenefCodePostal.Margin = New System.Windows.Forms.Padding(2)
        Me.TBBenefCodePostal.Name = "TBBenefCodePostal"
        Me.TBBenefCodePostal.Size = New System.Drawing.Size(79, 21)
        Me.TBBenefCodePostal.TabIndex = 27
        Me.TBBenefCodePostal.Value = Nothing
        '
        'TBBenefNom
        '
        Me.TBBenefNom.CueBanner = Nothing
        Me.TBBenefNom.Location = New System.Drawing.Point(237, 17)
        Me.TBBenefNom.Margin = New System.Windows.Forms.Padding(2)
        Me.TBBenefNom.Name = "TBBenefNom"
        Me.TBBenefNom.Size = New System.Drawing.Size(105, 21)
        Me.TBBenefNom.TabIndex = 24
        Me.TBBenefNom.Value = Nothing
        '
        'TBBenefPrenom
        '
        Me.TBBenefPrenom.CueBanner = Nothing
        Me.TBBenefPrenom.Location = New System.Drawing.Point(68, 15)
        Me.TBBenefPrenom.Margin = New System.Windows.Forms.Padding(2)
        Me.TBBenefPrenom.Name = "TBBenefPrenom"
        Me.TBBenefPrenom.Size = New System.Drawing.Size(121, 21)
        Me.TBBenefPrenom.TabIndex = 22
        Me.TBBenefPrenom.Value = Nothing
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 104)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 14)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Date de naissance"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 76)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 14)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "Téléphone"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(198, 104)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(29, 14)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Pays"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(198, 76)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(29, 14)
        Me.Label25.TabIndex = 28
        Me.Label25.Text = "Ville"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(195, 47)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 14)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "Code postal"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(194, 17)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 14)
        Me.Label27.TabIndex = 23
        Me.Label27.Text = "Nom"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(8, 17)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(46, 14)
        Me.Label30.TabIndex = 21
        Me.Label30.Text = "Prénom"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel12.Controls.Add(Me.GroupBox12)
        Me.Panel12.Location = New System.Drawing.Point(175, 29)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(349, 527)
        Me.Panel12.TabIndex = 137
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox12.Controls.Add(Me.DgvListeConcessionnaire)
        Me.GroupBox12.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(312, 483)
        Me.GroupBox12.TabIndex = 0
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Acteurs"
        '
        'DgvListeConcessionnaire
        '
        Me.DgvListeConcessionnaire.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DgvListeConcessionnaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvListeConcessionnaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListeConcessionnaire.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColPersNom})
        Me.DgvListeConcessionnaire.EnableHeadersVisualStyles = False
        Me.DgvListeConcessionnaire.Location = New System.Drawing.Point(0, 15)
        Me.DgvListeConcessionnaire.Name = "DgvListeConcessionnaire"
        Me.DgvListeConcessionnaire.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvListeConcessionnaire.RowHeadersVisible = False
        Me.DgvListeConcessionnaire.Size = New System.Drawing.Size(312, 470)
        Me.DgvListeConcessionnaire.TabIndex = 43
        '
        'ColPersNom
        '
        Me.ColPersNom.DataPropertyName = "Nom"
        Me.ColPersNom.HeaderText = "Nom"
        Me.ColPersNom.Name = "ColPersNom"
        Me.ColPersNom.Width = 300
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel14.Controls.Add(Me.GroupBox14)
        Me.Panel14.Location = New System.Drawing.Point(9, 87)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(150, 125)
        Me.Panel14.TabIndex = 136
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox14.Controls.Add(Me.TextBoxNullable1)
        Me.GroupBox14.Controls.Add(Me.Button2)
        Me.GroupBox14.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(127, 93)
        Me.GroupBox14.TabIndex = 0
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Rechercher :"
        '
        'TextBoxNullable1
        '
        Me.TextBoxNullable1.CueBanner = Nothing
        Me.TextBoxNullable1.Location = New System.Drawing.Point(6, 20)
        Me.TextBoxNullable1.Name = "TextBoxNullable1"
        Me.TextBoxNullable1.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxNullable1.TabIndex = 136
        Me.TextBoxNullable1.Value = Nothing
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Rechercher"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 132
        Me.PictureBox1.TabStop = False
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, -1)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, -1)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, -1)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, -1)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 150)
        '
        'FormGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1104, 707)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormGestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvListeDefunts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FPTBLahulpe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.FCDGBeneficiare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.FCDGDefunt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.FCDGConss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.FCPBlahulpe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.DgvListeConcessionnaire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents FPBSupprimer As System.Windows.Forms.Button
    Friend WithEvents FPBModifier As System.Windows.Forms.Button
    Friend WithEvents FPBAjouter As System.Windows.Forms.Button
    Friend WithEvents FPBDetails As System.Windows.Forms.Button
    Friend WithEvents FPBLienCons As System.Windows.Forms.Button
    Friend WithEvents LabDefEtatCivil As System.Windows.Forms.Label
    Friend WithEvents LabDefDomicile As System.Windows.Forms.Label
    Friend WithEvents LabDefCode As System.Windows.Forms.Label
    Friend WithEvents LabDefEmplacement As System.Windows.Forms.Label
    Friend WithEvents LabDefDateDeces As System.Windows.Forms.Label
    Friend WithEvents FPBRechercher As System.Windows.Forms.Button
    Friend WithEvents DgvListeDefunts As System.Windows.Forms.DataGridView
    Friend WithEvents FPCBEmplacement As System.Windows.Forms.CheckBox
    Friend WithEvents FPCBDate As System.Windows.Forms.CheckBox
    Friend WithEvents FPCBNom As System.Windows.Forms.CheckBox
    Friend WithEvents FPTBRechercher As System.Windows.Forms.TextBox
    Friend WithEvents FPTBLahulpe As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents FCTBCodePostal As System.Windows.Forms.TextBox
    Friend WithEvents FCLCodePostal As System.Windows.Forms.Label
    Friend WithEvents FCLAdresse As System.Windows.Forms.Label
    Friend WithEvents FCTBLienParente As System.Windows.Forms.TextBox
    Friend WithEvents FCLLienParente As System.Windows.Forms.Label
    Friend WithEvents FCTBDateNaiss As System.Windows.Forms.TextBox
    Friend WithEvents FCLDateNaiss As System.Windows.Forms.Label
    Friend WithEvents FCTBPays As System.Windows.Forms.TextBox
    Friend WithEvents FCTBPrenom As System.Windows.Forms.TextBox
    Friend WithEvents FCLPays As System.Windows.Forms.Label
    Friend WithEvents FCLPrenom As System.Windows.Forms.Label
    Friend WithEvents FCTBNom As System.Windows.Forms.TextBox
    Friend WithEvents FCLNom As System.Windows.Forms.Label
    Friend WithEvents FCTBType As System.Windows.Forms.TextBox
    Friend WithEvents FCLType As System.Windows.Forms.Label
    Friend WithEvents FCTBHistoire As System.Windows.Forms.TextBox
    Friend WithEvents FCLHistoire As System.Windows.Forms.Label
    Friend WithEvents FCTBCommentaire As System.Windows.Forms.TextBox
    Friend WithEvents FCTBMonumentClasse As System.Windows.Forms.TextBox
    Friend WithEvents FCDGDefunt As System.Windows.Forms.DataGridView
    Friend WithEvents FCDGBeneficiare As System.Windows.Forms.DataGridView
    Friend WithEvents FCBLienDefunt As System.Windows.Forms.Button
    Friend WithEvents FCBDetails As System.Windows.Forms.Button
    Friend WithEvents FCTBPlaceOccupe As System.Windows.Forms.TextBox
    Friend WithEvents FCLPlaceOccupe As System.Windows.Forms.Label
    Friend WithEvents FCTBPlaceLibre As System.Windows.Forms.TextBox
    Friend WithEvents FCLPlaceLibre As System.Windows.Forms.Label
    Friend WithEvents FCTBEmplacement As System.Windows.Forms.TextBox
    Friend WithEvents FCLEmplacement As System.Windows.Forms.Label
    Friend WithEvents FCTBDenomination As System.Windows.Forms.TextBox
    Friend WithEvents FCLDenomination As System.Windows.Forms.Label
    Friend WithEvents FCBRechercher As System.Windows.Forms.Button
    Friend WithEvents FCDGConss As System.Windows.Forms.DataGridView
    Friend WithEvents FCCBEmplacement As System.Windows.Forms.CheckBox
    Friend WithEvents FCCBDate As System.Windows.Forms.CheckBox
    Friend WithEvents FCCBNom As System.Windows.Forms.CheckBox
    Friend WithEvents FCTBRechercher As System.Windows.Forms.TextBox
    Friend WithEvents FCPBlahulpe As System.Windows.Forms.PictureBox
    Friend WithEvents FPCBDateD As System.Windows.Forms.CheckBox
    Friend WithEvents FCLCommentaire As System.Windows.Forms.Label
    Friend WithEvents FCLMonumentC As System.Windows.Forms.Label
    Friend WithEvents FCCBType As System.Windows.Forms.CheckBox
    Friend WithEvents FCTBAdresse As System.Windows.Forms.TextBox
    Friend WithEvents FCBSupp As System.Windows.Forms.Button
    Friend WithEvents FCBModifier As System.Windows.Forms.Button
    Friend WithEvents FCBAjouter As System.Windows.Forms.Button
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents FPBRefresh As System.Windows.Forms.Button
    Friend WithEvents LvListeDefunts As ListView
    Friend WithEvents Nom As ColumnHeader
    Friend WithEvents Prenom As ColumnHeader
    Friend WithEvents Emplacement As ColumnHeader
    Friend WithEvents Code As ColumnHeader
    Friend WithEvents DateDeces As ColumnHeader
    Friend WithEvents TxtDefDateDeces As Label
    Friend WithEvents TxtDefNom As Label
    Friend WithEvents TxtDefEmplacement As LinkLabel
    Friend WithEvents TxtDefDomicile As Label
    Friend WithEvents TxtDefEtatCiv As Label
    Friend WithEvents TxtDefCode As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbDefChampRecherche As TextBox
    Friend WithEvents CbDefChercherNom As CheckBox
    Friend WithEvents CbDefChercherDateDeces As CheckBox
    Friend WithEvents CbDefChercherCode As CheckBox
    Friend WithEvents CbDefChercherEmplacement As CheckBox
    Friend WithEvents BtDefChercher As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ColDefNom As DataGridViewTextBoxColumn
    Friend WithEvents ColDefEmplacement As DataGridViewTextBoxColumn
    Friend WithEvents ColDateDeces As DataGridViewTextBoxColumn
    Friend WithEvents ColCode As DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvListeConcessionnaire As System.Windows.Forms.DataGridView
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents ColPersNom As DataGridViewTextBoxColumn
    Friend WithEvents PRBPersCon As RadioButton
    Friend WithEvents PRBConcessionnaire As RadioButton
    Friend WithEvents PRBBenef As RadioButton
    Friend WithEvents TextBoxNullable1 As TextBoxNullable
    Friend WithEvents Button5 As Button
    Friend WithEvents TBPersAdress As TextBoxNullable
    Friend WithEvents Button6 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TBPersNumNational As TextBoxIntNullable
    Friend WithEvents TBPersDN As MaskedTextBoxDate
    Friend WithEvents TBPersTel As TextBoxNullable
    Friend WithEvents TBPersPays As TextBoxNullable
    Friend WithEvents TBPersVille As TextBoxNullable
    Friend WithEvents TBPersCodePostal As TextBoxIntNullable
    Friend WithEvents TBPersNom As TextBoxNullable
    Friend WithEvents TBPersPrenom As TextBoxNullable
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents TBConsAdresse As TextBoxNullable
    Friend WithEvents Label12 As Label
    Friend WithEvents TBConsDateNaiss As MaskedTextBoxDate
    Friend WithEvents TBConsTel As TextBoxNullable
    Friend WithEvents TBConsPays As TextBoxNullable
    Friend WithEvents TBConsVille As TextBoxNullable
    Friend WithEvents TBConsCodePostal As TextBoxIntNullable
    Friend WithEvents TBConsNom As TextBoxNullable
    Friend WithEvents TBConsPrenom As TextBoxNullable
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents TBBenefAdresse As TextBoxNullable
    Friend WithEvents Button8 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents TBBenefDN As MaskedTextBoxDate
    Friend WithEvents TBBenefTel As TextBoxNullable
    Friend WithEvents TBBenefPays As TextBoxNullable
    Friend WithEvents TBBenefVille As TextBoxNullable
    Friend WithEvents TBBenefCodePostal As TextBoxIntNullable
    Friend WithEvents TBBenefNom As TextBoxNullable
    Friend WithEvents TBBenefPrenom As TextBoxNullable
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label30 As Label
End Class

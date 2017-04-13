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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.ColPersNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel12.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
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
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
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
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvListeDefunts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
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
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage3.Controls.Add(Me.Panel12)
        Me.TabPage3.Controls.Add(Me.Panel14)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 36)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1292, 633)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Personnes"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        Me.GroupBox12.Controls.Add(Me.DataGridView2)
        Me.GroupBox12.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(312, 483)
        Me.GroupBox12.TabIndex = 0
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Acteurs"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColPersNom})
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(0, 15)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(312, 470)
        Me.DataGridView2.TabIndex = 43
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
        Me.GroupBox13.Controls.Add(Me.Label4)
        Me.GroupBox13.Controls.Add(Me.TextBox1)
        Me.GroupBox13.Controls.Add(Me.Label5)
        Me.GroupBox13.Controls.Add(Me.TextBox2)
        Me.GroupBox13.Controls.Add(Me.Label6)
        Me.GroupBox13.Controls.Add(Me.TextBox3)
        Me.GroupBox13.Controls.Add(Me.Label7)
        Me.GroupBox13.Controls.Add(Me.TextBox4)
        Me.GroupBox13.Controls.Add(Me.TextBox5)
        Me.GroupBox13.Controls.Add(Me.Label8)
        Me.GroupBox13.Controls.Add(Me.TextBox6)
        Me.GroupBox13.Controls.Add(Me.Label9)
        Me.GroupBox13.Controls.Add(Me.Label10)
        Me.GroupBox13.Controls.Add(Me.TextBox7)
        Me.GroupBox13.Controls.Add(Me.Label11)
        Me.GroupBox13.Controls.Add(Me.TextBox8)
        Me.GroupBox13.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(500, 166)
        Me.GroupBox13.TabIndex = 0
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Infos Personnes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 14)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Dénomination :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(124, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(129, 21)
        Me.TextBox1.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(277, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 14)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Emplacement :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(361, 20)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 21)
        Me.TextBox2.TabIndex = 67
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 14)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Place libre :"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(125, 53)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(128, 21)
        Me.TextBox3.TabIndex = 69
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(279, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 14)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Place occupé :"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(361, 51)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(128, 21)
        Me.TextBox4.TabIndex = 71
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(124, 83)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(128, 21)
        Me.TextBox5.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(277, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 14)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "Commentaire :"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(361, 81)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(128, 21)
        Me.TextBox6.TabIndex = 97
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 14)
        Me.Label9.TabIndex = 123
        Me.Label9.Text = "Monument Classé :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(65, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 14)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Histoire :"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(125, 114)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(128, 21)
        Me.TextBox7.TabIndex = 99
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(318, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 14)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "Type :"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(361, 112)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(128, 21)
        Me.TextBox8.TabIndex = 101
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel14.Controls.Add(Me.GroupBox14)
        Me.Panel14.Location = New System.Drawing.Point(9, 87)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(150, 195)
        Me.Panel14.TabIndex = 136
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox14.Controls.Add(Me.TextBox9)
        Me.GroupBox14.Controls.Add(Me.CheckBox1)
        Me.GroupBox14.Controls.Add(Me.CheckBox2)
        Me.GroupBox14.Controls.Add(Me.CheckBox3)
        Me.GroupBox14.Controls.Add(Me.Button2)
        Me.GroupBox14.Controls.Add(Me.CheckBox4)
        Me.GroupBox14.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(127, 171)
        Me.GroupBox14.TabIndex = 0
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Rechercher :"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(6, 14)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 21)
        Me.TextBox9.TabIndex = 35
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 40)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(50, 18)
        Me.CheckBox1.TabIndex = 40
        Me.CheckBox1.Text = "Nom"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(57, 40)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(50, 18)
        Me.CheckBox2.TabIndex = 41
        Me.CheckBox2.Text = "Date"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(6, 64)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(94, 18)
        Me.CheckBox3.TabIndex = 42
        Me.CheckBox3.Text = "Emplacement"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Rechercher"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(6, 84)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(49, 18)
        Me.CheckBox4.TabIndex = 125
        Me.CheckBox4.Text = "Type"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SeaGreen
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(26, 347)
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
        Me.Button4.Location = New System.Drawing.Point(26, 318)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 23)
        Me.Button4.TabIndex = 134
        Me.Button4.Text = "Modifier"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SeaGreen
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(13, 288)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 23)
        Me.Button5.TabIndex = 133
        Me.Button5.Text = "Ajouter"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 132
        Me.PictureBox1.TabStop = False
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
        Me.GroupBox11.Controls.Add(Me.Label12)
        Me.GroupBox11.Controls.Add(Me.TextBox10)
        Me.GroupBox11.Controls.Add(Me.Label13)
        Me.GroupBox11.Controls.Add(Me.TextBox11)
        Me.GroupBox11.Controls.Add(Me.Label14)
        Me.GroupBox11.Controls.Add(Me.TextBox12)
        Me.GroupBox11.Controls.Add(Me.Label15)
        Me.GroupBox11.Controls.Add(Me.TextBox13)
        Me.GroupBox11.Controls.Add(Me.TextBox14)
        Me.GroupBox11.Controls.Add(Me.Label16)
        Me.GroupBox11.Controls.Add(Me.TextBox15)
        Me.GroupBox11.Controls.Add(Me.Label17)
        Me.GroupBox11.Controls.Add(Me.Label18)
        Me.GroupBox11.Controls.Add(Me.TextBox16)
        Me.GroupBox11.Controls.Add(Me.Label19)
        Me.GroupBox11.Controls.Add(Me.TextBox17)
        Me.GroupBox11.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(500, 166)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Infos concessionnaire"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 14)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Dénomination :"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(124, 22)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(129, 21)
        Me.TextBox10.TabIndex = 65
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(277, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 14)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Emplacement :"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(361, 20)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(128, 21)
        Me.TextBox11.TabIndex = 67
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(53, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 14)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "Place libre :"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(125, 53)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(128, 21)
        Me.TextBox12.TabIndex = 69
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(279, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 14)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Place occupé :"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(361, 51)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(128, 21)
        Me.TextBox13.TabIndex = 71
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(124, 83)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(128, 21)
        Me.TextBox14.TabIndex = 95
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(277, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 14)
        Me.Label16.TabIndex = 124
        Me.Label16.Text = "Commentaire :"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(361, 81)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(128, 21)
        Me.TextBox15.TabIndex = 97
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 86)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 14)
        Me.Label17.TabIndex = 123
        Me.Label17.Text = "Monument Classé :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(65, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 14)
        Me.Label18.TabIndex = 98
        Me.Label18.Text = "Histoire :"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(125, 114)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(128, 21)
        Me.TextBox16.TabIndex = 99
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(318, 115)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 14)
        Me.Label19.TabIndex = 100
        Me.Label19.Text = "Type :"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(361, 112)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(128, 21)
        Me.TextBox17.TabIndex = 101
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
        Me.GroupBox15.Controls.Add(Me.Label20)
        Me.GroupBox15.Controls.Add(Me.TextBox18)
        Me.GroupBox15.Controls.Add(Me.Label21)
        Me.GroupBox15.Controls.Add(Me.TextBox19)
        Me.GroupBox15.Controls.Add(Me.Label22)
        Me.GroupBox15.Controls.Add(Me.TextBox20)
        Me.GroupBox15.Controls.Add(Me.Label23)
        Me.GroupBox15.Controls.Add(Me.TextBox21)
        Me.GroupBox15.Controls.Add(Me.TextBox22)
        Me.GroupBox15.Controls.Add(Me.Label24)
        Me.GroupBox15.Controls.Add(Me.TextBox23)
        Me.GroupBox15.Controls.Add(Me.Label25)
        Me.GroupBox15.Controls.Add(Me.Label26)
        Me.GroupBox15.Controls.Add(Me.TextBox24)
        Me.GroupBox15.Controls.Add(Me.Label27)
        Me.GroupBox15.Controls.Add(Me.TextBox25)
        Me.GroupBox15.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(500, 166)
        Me.GroupBox15.TabIndex = 0
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Infos bénéficiaires"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(31, 25)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 14)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "Dénomination :"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(124, 22)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(129, 21)
        Me.TextBox18.TabIndex = 65
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(277, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 14)
        Me.Label21.TabIndex = 66
        Me.Label21.Text = "Emplacement :"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(361, 20)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(128, 21)
        Me.TextBox19.TabIndex = 67
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(53, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 14)
        Me.Label22.TabIndex = 68
        Me.Label22.Text = "Place libre :"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(125, 53)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(128, 21)
        Me.TextBox20.TabIndex = 69
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(279, 54)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(79, 14)
        Me.Label23.TabIndex = 70
        Me.Label23.Text = "Place occupé :"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(361, 51)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(128, 21)
        Me.TextBox21.TabIndex = 71
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(124, 83)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(128, 21)
        Me.TextBox22.TabIndex = 95
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(277, 84)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 14)
        Me.Label24.TabIndex = 124
        Me.Label24.Text = "Commentaire :"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(361, 81)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(128, 21)
        Me.TextBox23.TabIndex = 97
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(14, 86)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(105, 14)
        Me.Label25.TabIndex = 123
        Me.Label25.Text = "Monument Classé :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(65, 117)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 14)
        Me.Label26.TabIndex = 98
        Me.Label26.Text = "Histoire :"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(125, 114)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(128, 21)
        Me.TextBox24.TabIndex = 99
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(318, 115)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(36, 14)
        Me.Label27.TabIndex = 100
        Me.Label27.Text = "Type :"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(361, 112)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(128, 21)
        Me.TextBox25.TabIndex = 101
        '
        'ColPersNom
        '
        Me.ColPersNom.HeaderText = "Nom"
        Me.ColPersNom.Name = "ColPersNom"
        Me.ColPersNom.Width = 300
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
        Me.Panel12.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents ColPersNom As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

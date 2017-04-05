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
        Me.ColDefNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDefEmplacement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDateDeces = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(64, 32)
        Me.TabControl1.Location = New System.Drawing.Point(-7, -1)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1733, 828)
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
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1725, 788)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Défunt"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel10.Controls.Add(Me.GroupBox10)
        Me.Panel10.Location = New System.Drawing.Point(4, 110)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(348, 297)
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
        Me.GroupBox10.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox10.Size = New System.Drawing.Size(323, 272)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Rechercher"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 236)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 28)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Annuler la recherche"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 177)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Décédé après :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Décédé avant :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Checked = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(131, 175)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowCheckBox = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(149, 25)
        Me.DateTimePicker2.TabIndex = 94
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(131, 142)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowCheckBox = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(149, 25)
        Me.DateTimePicker1.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Dans :"
        '
        'TbDefChampRecherche
        '
        Me.TbDefChampRecherche.Location = New System.Drawing.Point(13, 25)
        Me.TbDefChampRecherche.Margin = New System.Windows.Forms.Padding(4)
        Me.TbDefChampRecherche.Name = "TbDefChampRecherche"
        Me.TbDefChampRecherche.Size = New System.Drawing.Size(199, 25)
        Me.TbDefChampRecherche.TabIndex = 40
        '
        'CbDefChercherNom
        '
        Me.CbDefChercherNom.AutoSize = True
        Me.CbDefChercherNom.Location = New System.Drawing.Point(13, 85)
        Me.CbDefChercherNom.Margin = New System.Windows.Forms.Padding(4)
        Me.CbDefChercherNom.Name = "CbDefChercherNom"
        Me.CbDefChercherNom.Size = New System.Drawing.Size(60, 22)
        Me.CbDefChercherNom.TabIndex = 45
        Me.CbDefChercherNom.Text = "Nom"
        Me.CbDefChercherNom.UseVisualStyleBackColor = True
        '
        'CbDefChercherDateDeces
        '
        Me.CbDefChercherDateDeces.AutoSize = True
        Me.CbDefChercherDateDeces.Location = New System.Drawing.Point(87, 85)
        Me.CbDefChercherDateDeces.Margin = New System.Windows.Forms.Padding(4)
        Me.CbDefChercherDateDeces.Name = "CbDefChercherDateDeces"
        Me.CbDefChercherDateDeces.Size = New System.Drawing.Size(116, 22)
        Me.CbDefChercherDateDeces.TabIndex = 91
        Me.CbDefChercherDateDeces.Text = "Date de décès"
        Me.CbDefChercherDateDeces.UseVisualStyleBackColor = True
        '
        'CbDefChercherCode
        '
        Me.CbDefChercherCode.AutoSize = True
        Me.CbDefChercherCode.Location = New System.Drawing.Point(143, 108)
        Me.CbDefChercherCode.Margin = New System.Windows.Forms.Padding(4)
        Me.CbDefChercherCode.Name = "CbDefChercherCode"
        Me.CbDefChercherCode.Size = New System.Drawing.Size(62, 22)
        Me.CbDefChercherCode.TabIndex = 46
        Me.CbDefChercherCode.Text = "Code"
        Me.CbDefChercherCode.UseVisualStyleBackColor = True
        '
        'CbDefChercherEmplacement
        '
        Me.CbDefChercherEmplacement.AutoSize = True
        Me.CbDefChercherEmplacement.Location = New System.Drawing.Point(13, 108)
        Me.CbDefChercherEmplacement.Margin = New System.Windows.Forms.Padding(4)
        Me.CbDefChercherEmplacement.Name = "CbDefChercherEmplacement"
        Me.CbDefChercherEmplacement.Size = New System.Drawing.Size(112, 22)
        Me.CbDefChercherEmplacement.TabIndex = 47
        Me.CbDefChercherEmplacement.Text = "Emplacement"
        Me.CbDefChercherEmplacement.UseVisualStyleBackColor = True
        '
        'BtDefChercher
        '
        Me.BtDefChercher.Location = New System.Drawing.Point(208, 236)
        Me.BtDefChercher.Margin = New System.Windows.Forms.Padding(4)
        Me.BtDefChercher.Name = "BtDefChercher"
        Me.BtDefChercher.Size = New System.Drawing.Size(100, 28)
        Me.BtDefChercher.TabIndex = 49
        Me.BtDefChercher.Text = "Rechercher"
        Me.BtDefChercher.UseVisualStyleBackColor = True
        '
        'LvListeDefunts
        '
        Me.LvListeDefunts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nom, Me.Prenom, Me.Emplacement, Me.Code, Me.DateDeces})
        Me.LvListeDefunts.FullRowSelect = True
        Me.LvListeDefunts.Location = New System.Drawing.Point(2161, 821)
        Me.LvListeDefunts.Margin = New System.Windows.Forms.Padding(4)
        Me.LvListeDefunts.MultiSelect = False
        Me.LvListeDefunts.Name = "LvListeDefunts"
        Me.LvListeDefunts.Size = New System.Drawing.Size(297, 164)
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
        Me.FPBAjouter.Location = New System.Drawing.Point(1008, 430)
        Me.FPBAjouter.Margin = New System.Windows.Forms.Padding(4)
        Me.FPBAjouter.Name = "FPBAjouter"
        Me.FPBAjouter.Size = New System.Drawing.Size(85, 28)
        Me.FPBAjouter.TabIndex = 88
        Me.FPBAjouter.Text = "Ajouter"
        Me.FPBAjouter.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Location = New System.Drawing.Point(407, 6)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(537, 631)
        Me.Panel3.TabIndex = 94
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox3.Controls.Add(Me.DgvListeDefunts)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 10)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(508, 610)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'DgvListeDefunts
        '
        Me.DgvListeDefunts.AllowUserToAddRows = False
        Me.DgvListeDefunts.AllowUserToDeleteRows = False
        Me.DgvListeDefunts.AllowUserToOrderColumns = True
        Me.DgvListeDefunts.AllowUserToResizeRows = False
        Me.DgvListeDefunts.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DgvListeDefunts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvListeDefunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListeDefunts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColDefNom, Me.ColDefEmplacement, Me.ColDateDeces, Me.ColCode})
        Me.DgvListeDefunts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvListeDefunts.EnableHeadersVisualStyles = False
        Me.DgvListeDefunts.GridColor = System.Drawing.Color.DarkGray
        Me.DgvListeDefunts.Location = New System.Drawing.Point(11, 18)
        Me.DgvListeDefunts.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvListeDefunts.MultiSelect = False
        Me.DgvListeDefunts.Name = "DgvListeDefunts"
        Me.DgvListeDefunts.ReadOnly = True
        Me.DgvListeDefunts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvListeDefunts.RowHeadersVisible = False
        Me.DgvListeDefunts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListeDefunts.Size = New System.Drawing.Size(489, 586)
        Me.DgvListeDefunts.TabIndex = 48
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(1281, 385)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(196, 247)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(169, 223)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechercher"
        '
        'FPBRefresh
        '
        Me.FPBRefresh.Location = New System.Drawing.Point(39, 187)
        Me.FPBRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.FPBRefresh.Name = "FPBRefresh"
        Me.FPBRefresh.Size = New System.Drawing.Size(100, 28)
        Me.FPBRefresh.TabIndex = 92
        Me.FPBRefresh.Text = "Actualiser"
        Me.FPBRefresh.UseVisualStyleBackColor = True
        '
        'FPTBRechercher
        '
        Me.FPTBRechercher.Location = New System.Drawing.Point(13, 22)
        Me.FPTBRechercher.Margin = New System.Windows.Forms.Padding(4)
        Me.FPTBRechercher.Name = "FPTBRechercher"
        Me.FPTBRechercher.Size = New System.Drawing.Size(132, 25)
        Me.FPTBRechercher.TabIndex = 40
        '
        'FPCBNom
        '
        Me.FPCBNom.AutoSize = True
        Me.FPCBNom.Location = New System.Drawing.Point(13, 54)
        Me.FPCBNom.Margin = New System.Windows.Forms.Padding(4)
        Me.FPCBNom.Name = "FPCBNom"
        Me.FPCBNom.Size = New System.Drawing.Size(60, 22)
        Me.FPCBNom.TabIndex = 45
        Me.FPCBNom.Text = "Nom"
        Me.FPCBNom.UseVisualStyleBackColor = True
        '
        'FPCBDateD
        '
        Me.FPCBDateD.AutoSize = True
        Me.FPCBDateD.Location = New System.Drawing.Point(13, 107)
        Me.FPCBDateD.Margin = New System.Windows.Forms.Padding(4)
        Me.FPCBDateD.Name = "FPCBDateD"
        Me.FPCBDateD.Size = New System.Drawing.Size(116, 22)
        Me.FPCBDateD.TabIndex = 91
        Me.FPCBDateD.Text = "Date de décès"
        Me.FPCBDateD.UseVisualStyleBackColor = True
        '
        'FPCBDate
        '
        Me.FPCBDate.AutoSize = True
        Me.FPCBDate.Location = New System.Drawing.Point(81, 54)
        Me.FPCBDate.Margin = New System.Windows.Forms.Padding(4)
        Me.FPCBDate.Name = "FPCBDate"
        Me.FPCBDate.Size = New System.Drawing.Size(59, 22)
        Me.FPCBDate.TabIndex = 46
        Me.FPCBDate.Text = "Date"
        Me.FPCBDate.UseVisualStyleBackColor = True
        '
        'FPCBEmplacement
        '
        Me.FPCBEmplacement.AutoSize = True
        Me.FPCBEmplacement.Location = New System.Drawing.Point(13, 82)
        Me.FPCBEmplacement.Margin = New System.Windows.Forms.Padding(4)
        Me.FPCBEmplacement.Name = "FPCBEmplacement"
        Me.FPCBEmplacement.Size = New System.Drawing.Size(112, 22)
        Me.FPCBEmplacement.TabIndex = 47
        Me.FPCBEmplacement.Text = "Emplacement"
        Me.FPCBEmplacement.UseVisualStyleBackColor = True
        '
        'FPBRechercher
        '
        Me.FPBRechercher.Location = New System.Drawing.Point(13, 139)
        Me.FPBRechercher.Margin = New System.Windows.Forms.Padding(4)
        Me.FPBRechercher.Name = "FPBRechercher"
        Me.FPBRechercher.Size = New System.Drawing.Size(100, 28)
        Me.FPBRechercher.TabIndex = 49
        Me.FPBRechercher.Text = "Rechercher"
        Me.FPBRechercher.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(957, 7)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 327)
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
        Me.GroupBox1.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(712, 302)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations du défunt"
        '
        'TxtDefDomicile
        '
        Me.TxtDefDomicile.AutoSize = True
        Me.TxtDefDomicile.Location = New System.Drawing.Point(91, 166)
        Me.TxtDefDomicile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtDefDomicile.Name = "TxtDefDomicile"
        Me.TxtDefDomicile.Size = New System.Drawing.Size(48, 18)
        Me.TxtDefDomicile.TabIndex = 92
        Me.TxtDefDomicile.Text = "Label7"
        '
        'TxtDefEtatCiv
        '
        Me.TxtDefEtatCiv.AutoSize = True
        Me.TxtDefEtatCiv.Location = New System.Drawing.Point(88, 140)
        Me.TxtDefEtatCiv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtDefEtatCiv.Name = "TxtDefEtatCiv"
        Me.TxtDefEtatCiv.Size = New System.Drawing.Size(48, 18)
        Me.TxtDefEtatCiv.TabIndex = 91
        Me.TxtDefEtatCiv.Text = "Label6"
        '
        'TxtDefCode
        '
        Me.TxtDefCode.AutoSize = True
        Me.TxtDefCode.Location = New System.Drawing.Point(493, 82)
        Me.TxtDefCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtDefCode.Name = "TxtDefCode"
        Me.TxtDefCode.Size = New System.Drawing.Size(48, 18)
        Me.TxtDefCode.TabIndex = 89
        Me.TxtDefCode.Text = "Label4"
        '
        'TxtDefDateDeces
        '
        Me.TxtDefDateDeces.AutoSize = True
        Me.TxtDefDateDeces.Location = New System.Drawing.Point(89, 113)
        Me.TxtDefDateDeces.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtDefDateDeces.Name = "TxtDefDateDeces"
        Me.TxtDefDateDeces.Size = New System.Drawing.Size(48, 18)
        Me.TxtDefDateDeces.TabIndex = 88
        Me.TxtDefDateDeces.Text = "Label3"
        '
        'TxtDefNom
        '
        Me.TxtDefNom.AutoSize = True
        Me.TxtDefNom.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDefNom.Location = New System.Drawing.Point(21, 30)
        Me.TxtDefNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtDefNom.Name = "TxtDefNom"
        Me.TxtDefNom.Size = New System.Drawing.Size(103, 38)
        Me.TxtDefNom.TabIndex = 86
        Me.TxtDefNom.Text = "Label1"
        '
        'TxtDefEmplacement
        '
        Me.TxtDefEmplacement.AutoSize = True
        Me.TxtDefEmplacement.Location = New System.Drawing.Point(112, 82)
        Me.TxtDefEmplacement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtDefEmplacement.Name = "TxtDefEmplacement"
        Me.TxtDefEmplacement.Size = New System.Drawing.Size(73, 18)
        Me.TxtDefEmplacement.TabIndex = 85
        Me.TxtDefEmplacement.TabStop = True
        Me.TxtDefEmplacement.Text = "LinkLabel1"
        '
        'LabDefDomicile
        '
        Me.LabDefDomicile.AutoSize = True
        Me.LabDefDomicile.Location = New System.Drawing.Point(16, 166)
        Me.LabDefDomicile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabDefDomicile.Name = "LabDefDomicile"
        Me.LabDefDomicile.Size = New System.Drawing.Size(67, 18)
        Me.LabDefDomicile.TabIndex = 76
        Me.LabDefDomicile.Text = "Domicile :"
        '
        'LabDefCode
        '
        Me.LabDefCode.AutoSize = True
        Me.LabDefCode.Location = New System.Drawing.Point(381, 82)
        Me.LabDefCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabDefCode.Name = "LabDefCode"
        Me.LabDefCode.Size = New System.Drawing.Size(91, 18)
        Me.LabDefCode.TabIndex = 71
        Me.LabDefCode.Text = "Code défunt :"
        '
        'LabDefEmplacement
        '
        Me.LabDefEmplacement.AutoSize = True
        Me.LabDefEmplacement.Location = New System.Drawing.Point(16, 82)
        Me.LabDefEmplacement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabDefEmplacement.Name = "LabDefEmplacement"
        Me.LabDefEmplacement.Size = New System.Drawing.Size(90, 18)
        Me.LabDefEmplacement.TabIndex = 70
        Me.LabDefEmplacement.Text = "Emplacement"
        Me.LabDefEmplacement.Visible = False
        '
        'LabDefDateDeces
        '
        Me.LabDefDateDeces.AutoSize = True
        Me.LabDefDateDeces.Location = New System.Drawing.Point(16, 113)
        Me.LabDefDateDeces.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabDefDateDeces.Name = "LabDefDateDeces"
        Me.LabDefDateDeces.Size = New System.Drawing.Size(67, 18)
        Me.LabDefDateDeces.TabIndex = 69
        Me.LabDefDateDeces.Text = "Décédé le"
        '
        'LabDefEtatCivil
        '
        Me.LabDefEtatCivil.AutoSize = True
        Me.LabDefEtatCivil.Location = New System.Drawing.Point(16, 140)
        Me.LabDefEtatCivil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabDefEtatCivil.Name = "LabDefEtatCivil"
        Me.LabDefEtatCivil.Size = New System.Drawing.Size(68, 18)
        Me.LabDefEtatCivil.TabIndex = 82
        Me.LabDefEtatCivil.Text = "Etat Civil :"
        '
        'FPBSupprimer
        '
        Me.FPBSupprimer.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBSupprimer.ForeColor = System.Drawing.Color.Transparent
        Me.FPBSupprimer.Location = New System.Drawing.Point(1009, 502)
        Me.FPBSupprimer.Margin = New System.Windows.Forms.Padding(4)
        Me.FPBSupprimer.Name = "FPBSupprimer"
        Me.FPBSupprimer.Size = New System.Drawing.Size(99, 28)
        Me.FPBSupprimer.TabIndex = 90
        Me.FPBSupprimer.Text = "Supprimer"
        Me.FPBSupprimer.UseVisualStyleBackColor = False
        '
        'FPBModifier
        '
        Me.FPBModifier.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBModifier.ForeColor = System.Drawing.Color.Transparent
        Me.FPBModifier.Location = New System.Drawing.Point(1009, 466)
        Me.FPBModifier.Margin = New System.Windows.Forms.Padding(4)
        Me.FPBModifier.Name = "FPBModifier"
        Me.FPBModifier.Size = New System.Drawing.Size(85, 28)
        Me.FPBModifier.TabIndex = 89
        Me.FPBModifier.Text = "Modifier"
        Me.FPBModifier.UseVisualStyleBackColor = False
        '
        'FPBDetails
        '
        Me.FPBDetails.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBDetails.ForeColor = System.Drawing.Color.Transparent
        Me.FPBDetails.Location = New System.Drawing.Point(1543, 405)
        Me.FPBDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.FPBDetails.Name = "FPBDetails"
        Me.FPBDetails.Size = New System.Drawing.Size(132, 59)
        Me.FPBDetails.TabIndex = 87
        Me.FPBDetails.Text = "Détails"
        Me.FPBDetails.UseVisualStyleBackColor = False
        '
        'FPBLienCons
        '
        Me.FPBLienCons.BackColor = System.Drawing.Color.SeaGreen
        Me.FPBLienCons.ForeColor = System.Drawing.Color.Transparent
        Me.FPBLienCons.Location = New System.Drawing.Point(1476, 343)
        Me.FPBLienCons.Margin = New System.Windows.Forms.Padding(4)
        Me.FPBLienCons.Name = "FPBLienCons"
        Me.FPBLienCons.Size = New System.Drawing.Size(203, 59)
        Me.FPBLienCons.TabIndex = 86
        Me.FPBLienCons.Text = "Lien vers concession"
        Me.FPBLienCons.UseVisualStyleBackColor = False
        '
        'FPTBLahulpe
        '
        Me.FPTBLahulpe.Image = CType(resources.GetObject("FPTBLahulpe.Image"), System.Drawing.Image)
        Me.FPTBLahulpe.Location = New System.Drawing.Point(0, 4)
        Me.FPTBLahulpe.Margin = New System.Windows.Forms.Padding(4)
        Me.FPTBLahulpe.Name = "FPTBLahulpe"
        Me.FPTBLahulpe.Size = New System.Drawing.Size(148, 95)
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
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1725, 788)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Concession"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel9.Controls.Add(Me.GroupBox9)
        Me.Panel9.Location = New System.Drawing.Point(212, 262)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(465, 246)
        Me.Panel9.TabIndex = 131
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox9.Controls.Add(Me.FCDGBeneficiare)
        Me.GroupBox9.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Size = New System.Drawing.Size(416, 204)
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
        Me.FCDGBeneficiare.Location = New System.Drawing.Point(0, 17)
        Me.FCDGBeneficiare.Margin = New System.Windows.Forms.Padding(4)
        Me.FCDGBeneficiare.Name = "FCDGBeneficiare"
        Me.FCDGBeneficiare.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FCDGBeneficiare.RowHeadersVisible = False
        Me.FCDGBeneficiare.Size = New System.Drawing.Size(416, 187)
        Me.FCDGBeneficiare.TabIndex = 92
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel8.Controls.Add(Me.GroupBox8)
        Me.Panel8.Location = New System.Drawing.Point(212, 516)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(465, 246)
        Me.Panel8.TabIndex = 131
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox8.Controls.Add(Me.FCDGDefunt)
        Me.GroupBox8.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(416, 204)
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
        Me.FCDGDefunt.Location = New System.Drawing.Point(0, 21)
        Me.FCDGDefunt.Margin = New System.Windows.Forms.Padding(4)
        Me.FCDGDefunt.Name = "FCDGDefunt"
        Me.FCDGDefunt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FCDGDefunt.RowHeadersVisible = False
        Me.FCDGDefunt.Size = New System.Drawing.Size(416, 183)
        Me.FCDGDefunt.TabIndex = 93
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel7.Controls.Add(Me.GroupBox7)
        Me.Panel7.Location = New System.Drawing.Point(733, 516)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(715, 246)
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
        Me.GroupBox7.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(669, 204)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Infos Bénéficiaires"
        '
        'FCTBNom
        '
        Me.FCTBNom.Location = New System.Drawing.Point(171, 34)
        Me.FCTBNom.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBNom.Name = "FCTBNom"
        Me.FCTBNom.Size = New System.Drawing.Size(169, 25)
        Me.FCTBNom.TabIndex = 103
        '
        'FCLNom
        '
        Me.FCLNom.AutoSize = True
        Me.FCLNom.Location = New System.Drawing.Point(105, 38)
        Me.FCLNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLNom.Name = "FCLNom"
        Me.FCLNom.Size = New System.Drawing.Size(45, 18)
        Me.FCLNom.TabIndex = 102
        Me.FCLNom.Text = "Nom :"
        '
        'FCLPrenom
        '
        Me.FCLPrenom.AutoSize = True
        Me.FCLPrenom.Location = New System.Drawing.Point(412, 31)
        Me.FCLPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLPrenom.Name = "FCLPrenom"
        Me.FCLPrenom.Size = New System.Drawing.Size(63, 18)
        Me.FCLPrenom.TabIndex = 104
        Me.FCLPrenom.Text = "Prenom :"
        '
        'FCLPays
        '
        Me.FCLPays.AutoSize = True
        Me.FCLPays.Location = New System.Drawing.Point(432, 129)
        Me.FCLPays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLPays.Name = "FCLPays"
        Me.FCLPays.Size = New System.Drawing.Size(43, 18)
        Me.FCLPays.TabIndex = 105
        Me.FCLPays.Text = "Pays :"
        '
        'FCTBPrenom
        '
        Me.FCTBPrenom.Location = New System.Drawing.Point(487, 27)
        Me.FCTBPrenom.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBPrenom.Name = "FCTBPrenom"
        Me.FCTBPrenom.Size = New System.Drawing.Size(168, 25)
        Me.FCTBPrenom.TabIndex = 106
        '
        'FCTBPays
        '
        Me.FCTBPays.Location = New System.Drawing.Point(487, 126)
        Me.FCTBPays.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBPays.Name = "FCTBPays"
        Me.FCTBPays.Size = New System.Drawing.Size(168, 25)
        Me.FCTBPays.TabIndex = 108
        '
        'FCLDateNaiss
        '
        Me.FCLDateNaiss.AutoSize = True
        Me.FCLDateNaiss.Location = New System.Drawing.Point(13, 71)
        Me.FCLDateNaiss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLDateNaiss.Name = "FCLDateNaiss"
        Me.FCLDateNaiss.Size = New System.Drawing.Size(125, 18)
        Me.FCLDateNaiss.TabIndex = 109
        Me.FCLDateNaiss.Text = "Date de naissance :"
        '
        'FCTBDateNaiss
        '
        Me.FCTBDateNaiss.Location = New System.Drawing.Point(171, 71)
        Me.FCTBDateNaiss.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBDateNaiss.Name = "FCTBDateNaiss"
        Me.FCTBDateNaiss.Size = New System.Drawing.Size(169, 25)
        Me.FCTBDateNaiss.TabIndex = 110
        '
        'FCLLienParente
        '
        Me.FCLLienParente.AutoSize = True
        Me.FCLLienParente.Location = New System.Drawing.Point(351, 64)
        Me.FCLLienParente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLLienParente.Name = "FCLLienParente"
        Me.FCLLienParente.Size = New System.Drawing.Size(116, 18)
        Me.FCLLienParente.TabIndex = 111
        Me.FCLLienParente.Text = "Liens de parenté :"
        '
        'FCTBCodePostal
        '
        Me.FCTBCodePostal.Location = New System.Drawing.Point(487, 92)
        Me.FCTBCodePostal.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBCodePostal.Name = "FCTBCodePostal"
        Me.FCTBCodePostal.Size = New System.Drawing.Size(168, 25)
        Me.FCTBCodePostal.TabIndex = 116
        '
        'FCTBLienParente
        '
        Me.FCTBLienParente.Location = New System.Drawing.Point(488, 60)
        Me.FCTBLienParente.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBLienParente.Name = "FCTBLienParente"
        Me.FCTBLienParente.Size = New System.Drawing.Size(168, 25)
        Me.FCTBLienParente.TabIndex = 112
        '
        'FCLCodePostal
        '
        Me.FCLCodePostal.AutoSize = True
        Me.FCLCodePostal.Location = New System.Drawing.Point(379, 97)
        Me.FCLCodePostal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLCodePostal.Name = "FCLCodePostal"
        Me.FCLCodePostal.Size = New System.Drawing.Size(88, 18)
        Me.FCLCodePostal.TabIndex = 115
        Me.FCLCodePostal.Text = "Code postal :"
        '
        'FCLAdresse
        '
        Me.FCLAdresse.AutoSize = True
        Me.FCLAdresse.Location = New System.Drawing.Point(84, 108)
        Me.FCLAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLAdresse.Name = "FCLAdresse"
        Me.FCLAdresse.Size = New System.Drawing.Size(63, 18)
        Me.FCLAdresse.TabIndex = 113
        Me.FCLAdresse.Text = "Adresse :"
        '
        'FCTBAdresse
        '
        Me.FCTBAdresse.Location = New System.Drawing.Point(169, 108)
        Me.FCTBAdresse.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBAdresse.Name = "FCTBAdresse"
        Me.FCTBAdresse.Size = New System.Drawing.Size(169, 25)
        Me.FCTBAdresse.TabIndex = 114
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel5.Controls.Add(Me.GroupBox5)
        Me.Panel5.Location = New System.Drawing.Point(212, 9)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(465, 246)
        Me.Panel5.TabIndex = 130
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox5.Controls.Add(Me.FCDGConss)
        Me.GroupBox5.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(416, 204)
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
        Me.FCDGConss.Location = New System.Drawing.Point(0, 18)
        Me.FCDGConss.Margin = New System.Windows.Forms.Padding(4)
        Me.FCDGConss.Name = "FCDGConss"
        Me.FCDGConss.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FCDGConss.RowHeadersVisible = False
        Me.FCDGConss.Size = New System.Drawing.Size(416, 186)
        Me.FCDGConss.TabIndex = 43
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel6.Controls.Add(Me.GroupBox6)
        Me.Panel6.Location = New System.Drawing.Point(733, 9)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(715, 246)
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
        Me.GroupBox6.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(669, 204)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Infos Concessions"
        '
        'FCLDenomination
        '
        Me.FCLDenomination.AutoSize = True
        Me.FCLDenomination.Location = New System.Drawing.Point(41, 31)
        Me.FCLDenomination.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLDenomination.Name = "FCLDenomination"
        Me.FCLDenomination.Size = New System.Drawing.Size(102, 18)
        Me.FCLDenomination.TabIndex = 64
        Me.FCLDenomination.Text = "Dénomination :"
        '
        'FCTBDenomination
        '
        Me.FCTBDenomination.Location = New System.Drawing.Point(165, 27)
        Me.FCTBDenomination.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBDenomination.Name = "FCTBDenomination"
        Me.FCTBDenomination.Size = New System.Drawing.Size(171, 25)
        Me.FCTBDenomination.TabIndex = 65
        '
        'FCLEmplacement
        '
        Me.FCLEmplacement.AutoSize = True
        Me.FCLEmplacement.Location = New System.Drawing.Point(369, 25)
        Me.FCLEmplacement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLEmplacement.Name = "FCLEmplacement"
        Me.FCLEmplacement.Size = New System.Drawing.Size(97, 18)
        Me.FCLEmplacement.TabIndex = 66
        Me.FCLEmplacement.Text = "Emplacement :"
        '
        'FCTBEmplacement
        '
        Me.FCTBEmplacement.Location = New System.Drawing.Point(481, 25)
        Me.FCTBEmplacement.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBEmplacement.Name = "FCTBEmplacement"
        Me.FCTBEmplacement.Size = New System.Drawing.Size(169, 25)
        Me.FCTBEmplacement.TabIndex = 67
        '
        'FCLPlaceLibre
        '
        Me.FCLPlaceLibre.AutoSize = True
        Me.FCLPlaceLibre.Location = New System.Drawing.Point(71, 69)
        Me.FCLPlaceLibre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLPlaceLibre.Name = "FCLPlaceLibre"
        Me.FCLPlaceLibre.Size = New System.Drawing.Size(76, 18)
        Me.FCLPlaceLibre.TabIndex = 68
        Me.FCLPlaceLibre.Text = "Place libre :"
        '
        'FCTBPlaceLibre
        '
        Me.FCTBPlaceLibre.Location = New System.Drawing.Point(167, 65)
        Me.FCTBPlaceLibre.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBPlaceLibre.Name = "FCTBPlaceLibre"
        Me.FCTBPlaceLibre.Size = New System.Drawing.Size(169, 25)
        Me.FCTBPlaceLibre.TabIndex = 69
        '
        'FCLPlaceOccupe
        '
        Me.FCLPlaceOccupe.AutoSize = True
        Me.FCLPlaceOccupe.Location = New System.Drawing.Point(372, 66)
        Me.FCLPlaceOccupe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLPlaceOccupe.Name = "FCLPlaceOccupe"
        Me.FCLPlaceOccupe.Size = New System.Drawing.Size(93, 18)
        Me.FCLPlaceOccupe.TabIndex = 70
        Me.FCLPlaceOccupe.Text = "Place occupé :"
        '
        'FCTBPlaceOccupe
        '
        Me.FCTBPlaceOccupe.Location = New System.Drawing.Point(481, 63)
        Me.FCTBPlaceOccupe.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBPlaceOccupe.Name = "FCTBPlaceOccupe"
        Me.FCTBPlaceOccupe.Size = New System.Drawing.Size(169, 25)
        Me.FCTBPlaceOccupe.TabIndex = 71
        '
        'FCTBMonumentClasse
        '
        Me.FCTBMonumentClasse.Location = New System.Drawing.Point(165, 102)
        Me.FCTBMonumentClasse.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBMonumentClasse.Name = "FCTBMonumentClasse"
        Me.FCTBMonumentClasse.Size = New System.Drawing.Size(169, 25)
        Me.FCTBMonumentClasse.TabIndex = 95
        '
        'FCLCommentaire
        '
        Me.FCLCommentaire.AutoSize = True
        Me.FCLCommentaire.Location = New System.Drawing.Point(369, 103)
        Me.FCLCommentaire.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLCommentaire.Name = "FCLCommentaire"
        Me.FCLCommentaire.Size = New System.Drawing.Size(98, 18)
        Me.FCLCommentaire.TabIndex = 124
        Me.FCLCommentaire.Text = "Commentaire :"
        '
        'FCTBCommentaire
        '
        Me.FCTBCommentaire.Location = New System.Drawing.Point(481, 100)
        Me.FCTBCommentaire.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBCommentaire.Name = "FCTBCommentaire"
        Me.FCTBCommentaire.Size = New System.Drawing.Size(169, 25)
        Me.FCTBCommentaire.TabIndex = 97
        '
        'FCLMonumentC
        '
        Me.FCLMonumentC.AutoSize = True
        Me.FCLMonumentC.Location = New System.Drawing.Point(19, 106)
        Me.FCLMonumentC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLMonumentC.Name = "FCLMonumentC"
        Me.FCLMonumentC.Size = New System.Drawing.Size(126, 18)
        Me.FCLMonumentC.TabIndex = 123
        Me.FCLMonumentC.Text = "Monument Classé :"
        '
        'FCLHistoire
        '
        Me.FCLHistoire.AutoSize = True
        Me.FCLHistoire.Location = New System.Drawing.Point(87, 144)
        Me.FCLHistoire.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLHistoire.Name = "FCLHistoire"
        Me.FCLHistoire.Size = New System.Drawing.Size(62, 18)
        Me.FCLHistoire.TabIndex = 98
        Me.FCLHistoire.Text = "Histoire :"
        '
        'FCTBHistoire
        '
        Me.FCTBHistoire.Location = New System.Drawing.Point(167, 140)
        Me.FCTBHistoire.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBHistoire.Name = "FCTBHistoire"
        Me.FCTBHistoire.Size = New System.Drawing.Size(169, 25)
        Me.FCTBHistoire.TabIndex = 99
        '
        'FCLType
        '
        Me.FCLType.AutoSize = True
        Me.FCLType.Location = New System.Drawing.Point(424, 142)
        Me.FCLType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FCLType.Name = "FCLType"
        Me.FCLType.Size = New System.Drawing.Size(44, 18)
        Me.FCLType.TabIndex = 100
        Me.FCLType.Text = "Type :"
        '
        'FCTBType
        '
        Me.FCTBType.Location = New System.Drawing.Point(481, 138)
        Me.FCTBType.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBType.Name = "FCTBType"
        Me.FCTBType.Size = New System.Drawing.Size(169, 25)
        Me.FCTBType.TabIndex = 101
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Location = New System.Drawing.Point(4, 102)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 240)
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
        Me.GroupBox4.Location = New System.Drawing.Point(15, 14)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(169, 210)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rechercher :"
        '
        'FCTBRechercher
        '
        Me.FCTBRechercher.Location = New System.Drawing.Point(8, 17)
        Me.FCTBRechercher.Margin = New System.Windows.Forms.Padding(4)
        Me.FCTBRechercher.Name = "FCTBRechercher"
        Me.FCTBRechercher.Size = New System.Drawing.Size(132, 25)
        Me.FCTBRechercher.TabIndex = 35
        '
        'FCCBNom
        '
        Me.FCCBNom.AutoSize = True
        Me.FCCBNom.Location = New System.Drawing.Point(8, 49)
        Me.FCCBNom.Margin = New System.Windows.Forms.Padding(4)
        Me.FCCBNom.Name = "FCCBNom"
        Me.FCCBNom.Size = New System.Drawing.Size(60, 22)
        Me.FCCBNom.TabIndex = 40
        Me.FCCBNom.Text = "Nom"
        Me.FCCBNom.UseVisualStyleBackColor = True
        '
        'FCCBDate
        '
        Me.FCCBDate.AutoSize = True
        Me.FCCBDate.Location = New System.Drawing.Point(76, 49)
        Me.FCCBDate.Margin = New System.Windows.Forms.Padding(4)
        Me.FCCBDate.Name = "FCCBDate"
        Me.FCCBDate.Size = New System.Drawing.Size(59, 22)
        Me.FCCBDate.TabIndex = 41
        Me.FCCBDate.Text = "Date"
        Me.FCCBDate.UseVisualStyleBackColor = True
        '
        'FCCBEmplacement
        '
        Me.FCCBEmplacement.AutoSize = True
        Me.FCCBEmplacement.Location = New System.Drawing.Point(8, 79)
        Me.FCCBEmplacement.Margin = New System.Windows.Forms.Padding(4)
        Me.FCCBEmplacement.Name = "FCCBEmplacement"
        Me.FCCBEmplacement.Size = New System.Drawing.Size(112, 22)
        Me.FCCBEmplacement.TabIndex = 42
        Me.FCCBEmplacement.Text = "Emplacement"
        Me.FCCBEmplacement.UseVisualStyleBackColor = True
        '
        'FCBRechercher
        '
        Me.FCBRechercher.Location = New System.Drawing.Point(8, 133)
        Me.FCBRechercher.Margin = New System.Windows.Forms.Padding(4)
        Me.FCBRechercher.Name = "FCBRechercher"
        Me.FCBRechercher.Size = New System.Drawing.Size(100, 28)
        Me.FCBRechercher.TabIndex = 44
        Me.FCBRechercher.Text = "Rechercher"
        Me.FCBRechercher.UseVisualStyleBackColor = True
        '
        'FCCBType
        '
        Me.FCCBType.AutoSize = True
        Me.FCCBType.Location = New System.Drawing.Point(8, 103)
        Me.FCCBType.Margin = New System.Windows.Forms.Padding(4)
        Me.FCCBType.Name = "FCCBType"
        Me.FCCBType.Size = New System.Drawing.Size(59, 22)
        Me.FCCBType.TabIndex = 125
        Me.FCCBType.Text = "Type"
        Me.FCCBType.UseVisualStyleBackColor = True
        '
        'FCBSupp
        '
        Me.FCBSupp.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBSupp.ForeColor = System.Drawing.Color.Transparent
        Me.FCBSupp.Location = New System.Drawing.Point(27, 422)
        Me.FCBSupp.Margin = New System.Windows.Forms.Padding(4)
        Me.FCBSupp.Name = "FCBSupp"
        Me.FCBSupp.Size = New System.Drawing.Size(99, 28)
        Me.FCBSupp.TabIndex = 128
        Me.FCBSupp.Text = "Supprimer"
        Me.FCBSupp.UseVisualStyleBackColor = False
        '
        'FCBModifier
        '
        Me.FCBModifier.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBModifier.ForeColor = System.Drawing.Color.Transparent
        Me.FCBModifier.Location = New System.Drawing.Point(27, 386)
        Me.FCBModifier.Margin = New System.Windows.Forms.Padding(4)
        Me.FCBModifier.Name = "FCBModifier"
        Me.FCBModifier.Size = New System.Drawing.Size(85, 28)
        Me.FCBModifier.TabIndex = 127
        Me.FCBModifier.Text = "Modifier"
        Me.FCBModifier.UseVisualStyleBackColor = False
        '
        'FCBAjouter
        '
        Me.FCBAjouter.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBAjouter.ForeColor = System.Drawing.Color.Transparent
        Me.FCBAjouter.Location = New System.Drawing.Point(27, 351)
        Me.FCBAjouter.Margin = New System.Windows.Forms.Padding(4)
        Me.FCBAjouter.Name = "FCBAjouter"
        Me.FCBAjouter.Size = New System.Drawing.Size(85, 28)
        Me.FCBAjouter.TabIndex = 126
        Me.FCBAjouter.Text = "Ajouter"
        Me.FCBAjouter.UseVisualStyleBackColor = False
        '
        'FCBLienDefunt
        '
        Me.FCBLienDefunt.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBLienDefunt.ForeColor = System.Drawing.Color.Transparent
        Me.FCBLienDefunt.Location = New System.Drawing.Point(1051, 330)
        Me.FCBLienDefunt.Margin = New System.Windows.Forms.Padding(4)
        Me.FCBLienDefunt.Name = "FCBLienDefunt"
        Me.FCBLienDefunt.Size = New System.Drawing.Size(205, 70)
        Me.FCBLienDefunt.TabIndex = 91
        Me.FCBLienDefunt.Text = "Lien vers Défunt"
        Me.FCBLienDefunt.UseVisualStyleBackColor = False
        '
        'FCBDetails
        '
        Me.FCBDetails.BackColor = System.Drawing.Color.SeaGreen
        Me.FCBDetails.ForeColor = System.Drawing.Color.Transparent
        Me.FCBDetails.Location = New System.Drawing.Point(1333, 332)
        Me.FCBDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.FCBDetails.Name = "FCBDetails"
        Me.FCBDetails.Size = New System.Drawing.Size(115, 65)
        Me.FCBDetails.TabIndex = 90
        Me.FCBDetails.Text = "Détails"
        Me.FCBDetails.UseVisualStyleBackColor = False
        '
        'FCPBlahulpe
        '
        Me.FCPBlahulpe.Image = CType(resources.GetObject("FCPBlahulpe.Image"), System.Drawing.Image)
        Me.FCPBlahulpe.Location = New System.Drawing.Point(0, 2)
        Me.FCPBlahulpe.Margin = New System.Windows.Forms.Padding(4)
        Me.FCPBlahulpe.Name = "FCPBlahulpe"
        Me.FCPBlahulpe.Size = New System.Drawing.Size(148, 95)
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
        'FormGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1712, 802)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
End Class

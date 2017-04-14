
Public Class FormGestion

    Dim _listeConcessionnairesSortable As SortableBindingList(Of Acteur.InfosPourListe)
    Dim _ListeBeneficiaireSortable As SortableBindingList(Of Acteur.InfosPourListe)
    Dim _ListePersContactSortable As SortableBindingList(Of Acteur.InfosPourListe)
    Private Property ListeConcessionnairesSortable As SortableBindingList(Of Acteur.InfosPourListe)
        Get
            If _listeConcessionnairesSortable Is Nothing Then
                _listeConcessionnairesSortable = New SortableBindingList(Of Acteur.InfosPourListe)(Bdd.GetListeActeurs)
            End If
            Return _listeConcessionnairesSortable
        End Get
        Set(value As SortableBindingList(Of Acteur.InfosPourListe))
            _listeConcessionnairesSortable = value
        End Set
    End Property

    Private Property ListeBeneficiaireSortable As SortableBindingList(Of Acteur.InfosPourListe)
        Get
            If _ListeBeneficiaireSortable Is Nothing Then
                _ListeBeneficiaireSortable = New SortableBindingList(Of Acteur.InfosPourListe)(Bdd.GetListeBeneficiaires)
            End If
            Return _ListeBeneficiaireSortable
        End Get
        Set(value As SortableBindingList(Of Acteur.InfosPourListe))
            _ListeBeneficiaireSortable = value
        End Set
    End Property

    Private Property ListePersContactSortable As SortableBindingList(Of Acteur.InfosPourListe)
        Get
            If _ListePersContactSortable Is Nothing Then
                _ListePersContactSortable = New SortableBindingList(Of Acteur.InfosPourListe)(Bdd.GetListePersContact)
            End If
            Return _ListePersContactSortable
        End Get
        Set(value As SortableBindingList(Of Acteur.InfosPourListe))
            _ListePersContactSortable = value
        End Set
    End Property

    Dim DefuntAffiche As Defunt
    Dim ActeurAffiche As Acteur

    'Public dtLit As DataTable
    'Dim DTTPers As DataTable


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '        BindDataDormeur()
        '        AfficheDonneesDormeur()

        Dim ListeDefunts = Bdd.GetListeDefunts()
        Dim ListeDefuntsSortable As New SortableBindingList(Of Object)(ListeDefunts)
        DgvListeDefunts.AutoGenerateColumns = False
        DgvListeDefunts.DataSource = ListeDefuntsSortable







        '  lacteur.Cp = codepostal.Value



        'Bdd.getliste

    End Sub

    Sub BindDataDormeur()


    End Sub


    Sub BindDataLit()
        '*** DataSet ***'  
        'dtLit = Bdd.GetTable("emplacements")
        'Dim DTGV_Id_Colonne = New DataGridViewTextBoxColumn()
        'Dim ColonnePrenom = New DataGridViewTextBoxColumn()
        'DTGV_Id_Colonne.DataPropertyName = "empl_reference"
        'DTGV_Id_Colonne.HeaderText = "empl_reference"
        'DTGV_Id_Colonne.Name = "empl_reference"
        'DTGV_Id_Colonne.Width = 180
        'FPDatagr.Columns.Add(DTGV_Id_Colonne)

        'ColonnePrenom.DataPropertyName = "empl_type"
        'ColonnePrenom.HeaderText = "empl_type"
        'ColonnePrenom.Name = "empl_type"
        'ColonnePrenom.Width = 180
        'FPDatagr.Columns.Add(ColonnePrenom)
        'FPDatagr.AutoGenerateColumns = False
        'FPDatagr.DataSource = dtLit

    End Sub

    Private Sub AfficheDonneeslit()

    End Sub

    Private Sub AfficheDonneesDormeur()
        'TbDefNom.DataBindings.Add("Text", dtPersonnes, "def_nom")
        'TbDefPrenom.DataBindings.Add("Text", dtPersonnes, "def_prenom")
        'TbDefDateNaiss.DataBindings.Add("Text", dtPersonnes, "def_date_naiss")
        'TbDefDateDeces.DataBindings.Add("Text", dtPersonnes, "def_date_deces")
        'TbDefAdresse.DataBindings.Add("Text", dtPersonnes, "def_adresse")
        'TbDefPays.DataBindings.Add("Text", dtPersonnes, "def_pays")
        'TbDefCp.DataBindings.Add("Text", dtPersonnes, "def_cp")
        'TbDefEtatCiv.DataBindings.Add("Text", dtPersonnes, "def_etat_civil")
        'TbDefLieuNaiss.DataBindings.Add("Text", dtPersonnes, "def_lieu_naiss")

        'FPTBDateE.DataBindings.Add("Text", dtPersonnes, "enterement")
        'FPTBCodeLieu.DataBindings.Add("Text", dtPersonnes, "expiration")
    End Sub

    '  Private Sub Deplacement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ' Inutile de tenter un déplacement si la DataTable ne contient aucune ligne.
    '   If dtPersonnes IsNot Nothing AndAlso dtPersonnes.Rows.Count > 0 Then
    ' Le BindingContext appartient à un conteneur, le formulaire dans ce cas.
    '     With Me.BindingContext(dtPersonnes)
    ' Modification de sa propriété Position en fonction du bouton.
    '       If sender.Equals(FPBPremier) Then
    '           .Position = 0
    '       ElseIf sender.Equals(FPBPrec) Then
    '           If .Position = 0 Then
    '               .Position = .Count - 1            ' Balayage circulaire
    '           Else
    '               .Position -= 1
    '           End If
    '       ElseIf sender.Equals(FPBSuivant) Then
    '          If .Position = .Count - 1 Then
    '             .Position = 0                 ' Balayage circulaire
    '         Else
    '           .Position += 1
    '       End If
    '   ElseIf sender.Equals(FPBDernier) Then
    '       .Position = .Count - 1
    '    End If
    '  End With
    '     End If
    ' End Sub

    Private Sub ConfirmationToolStripMenuItem_Click(sender As Object, e As System.EventArgs)

        ' Bdd.InsertPers()
    End Sub


    Private Sub RbRecherche_Click(sender As Object, e As EventArgs) Handles FPCBNom.Click, FPCBEmplacement.Click, FPCBDateD.Click, FPCBDate.Click
        Select Case sender.Name
            Case "FPCBNom"
                FPCBDate.Checked = False
                FPCBEmplacement.Checked = False
                FPCBDateD.Checked = False
            Case "FPCBEmplacement"
                FPCBNom.Checked = False
                FPCBDate.Checked = False
                FPCBDateD.Checked = False
            Case "FPCBDateD"
                FPCBNom.Checked = False
                FPCBDate.Checked = False
                FPCBEmplacement.Checked = False
            Case "FPCBDate"
                FPCBNom.Checked = False
                FPCBEmplacement.Checked = False
                FPCBDateD.Checked = False
        End Select
    End Sub


    Private Sub FPBDetails_Click(sender As Object, e As EventArgs) Handles FPBDetails.Click
        Dim FDetails As New FDetails
        FDetails.ShowDialog()
    End Sub

    Private Sub FCBDetails_Click(sender As Object, e As EventArgs) Handles FCBDetails.Click
        Dim FDetails As New FDetails
        FDetails.ShowDialog()
    End Sub

    Private Sub FPBAjouter_Click(sender As Object, e As EventArgs) Handles FPBAjouter.Click
    End Sub


    Private Sub FPBRechercher_Click(sender As Object, e As EventArgs) Handles FPBRechercher.Click
        If FPCBNom.Checked = True Then
            Dim Source As New BindingSource()
            Source.DataSource = Me.DgvListeDefunts.DataSource
            Source.Filter = "def_nom Like '%" & FPTBRechercher.Text & "%'"
        ElseIf FPCBEmplacement.Checked = True Then

        ElseIf FPCBDate.Checked = True Then
            ' erreur avec les dates
            ' Dim Source As New BindingSource()
            '  Source.DataSource = Me.FPDatagr.DataSource
            '  Source.Filter = "def_date_naiss like '%" & FPTBRechercher.ToString & "%'"

        ElseIf FPCBDateD.Checked = True Then

        Else
            MessageBox.Show("Veuillez inserer un choix")
        End If

    End Sub

    Private Sub FPBRefresh_Click(sender As Object, e As EventArgs) Handles FPBRefresh.Click
        Dim Source As New BindingSource()
        Source.DataSource = Me.DgvListeDefunts.DataSource

        Source.Filter = "def_nom like '%'"
    End Sub



    ' Affiche les infos d'un défunt quand celui-ci est sélectionné dans la liste
    Private Sub DgvListeDefunts_SelectionChanged(sender As Object, e As EventArgs) Handles DgvListeDefunts.SelectionChanged
        If DgvListeDefunts.SelectedRows.Count > 0 Then
            If DefuntAffiche Is Nothing Then
                LabDefEmplacement.Visible = True
                LabDefCode.Visible = True
                LabDefDateDeces.Visible = True
                LabDefEtatCivil.Visible = True
                LabDefDomicile.Visible = True
            End If
            'DefuntAffiche = Bdd.ChargerDefunt(CType(DgvListeDefunts.SelectedRows(0).Cells("ColId").Value, Int32))
            DefuntAffiche = Bdd.ChargerDefunt(DgvListeDefunts.SelectedRows(0).DataBoundItem.Id)
            With DefuntAffiche
                TxtDefNom.Text = If(.Prenom IsNot Nothing Or .Nom IsNot Nothing, .Prenom & " " & .Nom, "?")
                TxtDefEmplacement.Text = If(.SejourActif IsNot Nothing, .SejourActif.Emplacement.Reference, "/")
                TxtDefDateDeces.Text = If(.DateDeces IsNot Nothing, .DateDeces.Value.ToString("dd/MM/yyyy"), "/")
                TxtDefCode.Text = If(.NumeroLh, "/")
                TxtDefEtatCiv.Text = If(.EtatCivil IsNot Nothing, Defunt.StaticEtatCivilToString(.EtatCivil) & If(.EtatCivil <> "celibataire", " de " & .EtatCivilDe, ""), "/")
                Dim strdomicile As String = If(.Adresse IsNot Nothing, .Adresse & ",", "") _
                    & If(.Cp IsNot Nothing, .Cp & " ", "") & If(.Ville IsNot Nothing, .Ville, "") & If(.Pays <> "" And String.Compare(.Pays, "belgique", True) <> 0, ", " & .Pays, "")
                TxtDefDomicile.Text = If(strdomicile <> "", strdomicile, "/")
            End With

        End If

    End Sub

    Private Sub DgvListeConcessionnaire_SelectionChanged(sender As Object, e As EventArgs) Handles DgvListeConcessionnaire.SelectionChanged

        If DgvListeConcessionnaire.SelectedRows.Count > 0 Then
            If ActeurAffiche Is Nothing Then

            End If

            ActeurAffiche = Bdd.GetActeur(DgvListeConcessionnaire.SelectedRows(0).DataBoundItem.Id)
            With ActeurAffiche
                TBPersPrenom.Text = If(.Prenom IsNot Nothing Or .Nom IsNot Nothing, .Prenom & " " & .Nom, "?")


                ' TxtDefNom.Text = If(.Prenom IsNot Nothing Or .Nom IsNot Nothing, .Prenom & " " & .Nom, "?")
                'TxtDefEmplacement.Text = If(.SejourActif IsNot Nothing, .SejourActif.Emplacement.Reference, "/")
                'TxtDefDateDeces.Text = If(.DateDeces IsNot Nothing, .DateDeces.Value.ToString("dd/MM/yyyy"), "/")
                'TxtDefCode.Text = If(.NumeroLh, "/")
                'TxtDefEtatCiv.Text = If(.EtatCivil IsNot Nothing, Defunt.StaticEtatCivilToString(.EtatCivil) & If(.EtatCivil <> "celibataire", " de " & .EtatCivilDe, ""), "/")
                'Dim strdomicile As String = If(.Adresse IsNot Nothing, .Adresse & ",", "") _
                '   & If(.Cp IsNot Nothing, .Cp & " ", "") & If(.Ville IsNot Nothing, .Ville, "") & If(.Pays <> "" And String.Compare(.Pays, "belgique", True) <> 0, ", " & .Pays, "")
                'TxtDefDomicile.Text = If(strdomicile <> "", strdomicile, "/")
            End With

        End If





    End Sub

    Private Sub BtDefChercher_Click(sender As Object, e As EventArgs) Handles BtDefChercher.Click
        'TbDefChampRecherche
        'CbDefChercherNom
        'CbDefChercherEmplacement
        'CbDefChercherDateDeces
        'CbDefChercherCode
    End Sub

    Private Sub PRBConcessionnaire_CheckedChanged(sender As Object, e As EventArgs) Handles PRBConcessionnaire.CheckedChanged
        DgvListeConcessionnaire.DataSource = ListeConcessionnairesSortable
    End Sub

    Private Sub PRBPersCon_CheckedChanged(sender As Object, e As EventArgs) Handles PRBPersCon.CheckedChanged

        DgvListeConcessionnaire.DataSource = ListePersContactSortable
    End Sub

    Private Sub PRBBenef_CheckedChanged(sender As Object, e As EventArgs) Handles PRBBenef.CheckedChanged
        DgvListeConcessionnaire.DataSource = ListeBeneficiaireSortable
    End Sub
End Class

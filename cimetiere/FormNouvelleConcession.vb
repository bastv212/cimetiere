Public Class FormNouvelleConcession
    Implements QuiModifieBdd

    Dim LeDemandeur As Acteur
    Dim LeConcessionnaire As Acteur
    Dim LeFormNvCon As FormulaireNvConcession
    Dim LesBenefs As List(Of Acteur)
    Dim LesParentes As List(Of String)

#Region "onglets"
    Private TabsBloques As Boolean = True
    Sub ChangerPage(n As Integer)
        TabsBloques = False
        TabControl1.SelectTab(n)
        TabsBloques = True
    End Sub
    Private Sub TabControl1_Click(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        If TabsBloques Then
            e.Cancel = True
        End If
    End Sub
#End Region

    Public Event BddChanged() Implements QuiModifieBdd.BddChanged
    ' À FAIRE : ajouter liste demandeurs (pers mand) quand sera mise
    Public Sub OnBddChanged() Handles ListeBeneficiaires.BddChanged, LbListeConcessionnaires.BddChanged
        RaiseEvent BddChanged()
    End Sub

    Public Sub FormNouvelleConcession_Load() Handles MyBase.Load
        ' masque les onglets
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.TabStop = False
    End Sub

    Private Sub BtSuivantDeForm_Click(sender As Object, e As EventArgs) Handles BtSuivantDeForm.Click
        MajRecapitulatif()
        ChangerPage(1)
    End Sub

    Private Sub BtPrecedentDeRecap_Click(sender As Object, e As EventArgs) Handles BtPrecedentDeRecap.Click
        ChangerPage(0)
    End Sub

    Sub MajRecapitulatif()
        LeFormNvCon = New FormulaireNvConcession

        ' Récupère les infos des champs
        LeFormNvCon.TypeCon = PanelChoixTypeEmpl1.GetChoix

        LeFormNvCon.DateSign = Today.Date

        ' À FAIRE
        ' LeDemandeur = LbListeDemandeurs.ActeurSelectionne
        ' LeFormNvCon.IntegrerInfosPmand(LeDemandeur)

        LeConcessionnaire = LbListeConcessionnaires.ActeurSelectionne
        LeFormNvCon.IntegrerInfosCsnr(LeConcessionnaire)

        ' À FAIRE
        'LeFormNvCon.SigneParPmand = 

        ListeBeneficiaires.GetBeneficiaires(LesBenefs, LesParentes)
        LeFormNvCon.AjouterBeneficiaires(LesBenefs,LesParentes)

        LabDmdrNom.Text = LeConcessionnaire.NomComplet

        ' Affiche le récapitulatif
        ' À FAIRE - masquer la GbPersMand si pas de pmand
        ' ou màj ses infos

        LabCsnrNomComplet.Text = LeConcessionnaire.NomComplet(True)
        Dim adrcsnr = LeConcessionnaire.AdresseComplete
        LabCsnrAdresseComplete.Text = If(adrcsnr <> "", adrcsnr, "Adresse non spécifiée")
        LabCsnrTel.Text = If(LeConcessionnaire.Tel <> "", LeConcessionnaire.Tel, "(pas de numéro de téléphone)")
        LabCsnrDateNaiss.Text = If(LeConcessionnaire.DateNaiss.HasValue, LeConcessionnaire.DateNaiss.Value.ToString("dd/MM/yyyy"), "(date de naissance non précisée)")
        LabCsnrNoNat.Text = If(LeConcessionnaire.NoRegistre, LeConcessionnaire.NoRegistre.Value, "(numéro de registre national non précisé)")

        ' À FAIRE : prix
        LabTypeConcession.Text = LeFormNvCon.TypeConToString

        GbRecapBenefs.Visible = LeFormNvCon.Beneficiaires.Count >= 1
        FlpLabsBeneficiaires.Controls.Clear()
        For n = 0 To LesBenefs.Count - 1
            FlpLabsBeneficiaires.Controls.Add(New Label With {.Text = LesBenefs(n).NomComplet & If(LesParentes(n) <> "", " (" & LesParentes(n) & ")", ""), .AutoSize = True})
        Next

    End Sub

    Public Sub OnTrucsChanged() Handles LbListeConcessionnaires.ActeurChanged, PanelChoixTypeEmpl1.SelectionChanged
        UpdateBtSuivantDeForm()
    End Sub

    'désact btn suiv si emplacement ne demande pas de concession, si csnr non indiqué ou si pmand présente mais pas choisie

    Private Sub UpdateBtSuivantDeForm()
        Dim emplchoisi As String = PanelChoixTypeEmpl1.GetChoix
        BtSuivantDeForm.Enabled = emplchoisi <> Nothing _
                                  AndAlso UzineAGaz.EmplacementImpliqueConcession(emplchoisi) _
                                  AndAlso LbListeConcessionnaires.ActeurSelectionne IsNot Nothing _
        '                         + À FAIRE : pmand (soit pas de personne mandatée impliquée, ou il y en a une choisie)
    End Sub


    Private Sub Finaliser()


    End Sub


End Class
Public Class FormRechercheConcession

    Private ListeConcessions As SortableBindingList(Of Concession.InfosPourListe)
    Private _csnSelect As Concession
    Public ReadOnly Property CsnSelect
        Get
            Return _csnSelect
        End Get
    End Property
    ' Sert à retrouver une concession existante sur base d'infos fournies par le demandeur

    ' à faire :
    ' - charger la liste des concessions

    Private Sub FormRechercheConcession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabFiltre.Text = ""
        ChargerListe()
        ListeConcessions.FilterFunc = AddressOf FiltrerElement
        DgvConcessions.AutoGenerateColumns = False
        DgvConcessions.DataSource = ListeConcessions
    End Sub

    Private Sub TbChampRecherche_KeyDown(sender As Object, e As KeyEventArgs) Handles TbChampRecherche.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtChercher_Click(BtChercher, Nothing)
        End If
    End Sub


    'Private Function FiltrerElem(elem As , filtre As String)

    'End Function


    ' colonnes à reprendre dans la grille :
    ' - nom & prénom du concessionnaire (utiliser NomComplet)
    ' - numéro de la concession (quoi que ça puisse être)
    ' - référence emplacement
    ' - Bénéficiaires
    ' - Défunts (auto ellipsis pourrait servir)
    ' - peut-être date d'expiration ?

    ' critères pertinents :
    ' - nom, prénom du concessionnaire
    ' - nom, prénom de la personne de contact
    ' - noms, prénoms des bénéficiaires désignés si présents
    ' - numéro de la concession (probablement inconnu)
    ' - (commentaire ?)
    ' - réf emplacement
    ' (- parcelle emplacement)
    ' - noms défunts [actuellement] associés à l'emplacement ou si libre/vide

    ' - données à afficher quand sélection :
    ' x - dates de début et de fin (expire)
    ' x - commentaire (?)
    ' x - infos du concessionnaire (nom complet & adresse avec signalement absence, pour le reste si rien a afficher ne rien mettre)
    ' x - liste des bénéficiaires (avec scroll, on ne sait jamais - peut-être dgv)
    ' - référence, type, nombre de places, peut-être commentaire ? de l'emplacement, ainsi que
    ' x - défunt(s) qui sont actuellement dans l'emplacement - peut-être pas sous forme d'une liste, il risque de n'y en avoir qu'un le plus souvent)



    ' :
    ' champ général nom de la personne/des bénefs/des défunts
    ' champ pour l'emplacement

    ' (peut-être des boutons/liens/actions au double clic pour éditer les éléments ? (intégration plus générale dans une interface de gestion/édition))

    ' - montrer (en rouge ?) si la concession est expiré (ou proche de l'expiration, en orange ?)

    Private Sub ChargerListe()
        ListeConcessions = New SortableBindingList(Of Concession.InfosPourListe)(Bdd.GetListeConcessions)
    End Sub

    Private Sub BtChercher_Click(sender As Object, e As EventArgs) Handles BtChercher.Click
        Dim f = TbChampRecherche.Text.Trim
        ListeConcessions.Filter = f
        If f = "" Then
            LabFiltre.Text = ""
        Else
            LabFiltre.Text = "Recherche : " & f
        End If
    End Sub



    Private Function FiltrerElement(elem As Object, f As String)
        Dim celem = CType(elem, Concession.InfosPourListe)
        Return UzineAGaz.ReduireString(String.Concat(celem.NomCsnr, celem.NomsBenefs, celem.NomsDefunts, celem.RefEmpl)).Contains(UzineAGaz.ReduireString(f))
    End Function

    Private Sub DgvConcessions_SelectionChanged(sender As Object, e As EventArgs) Handles DgvConcessions.SelectionChanged
        If DgvConcessions.SelectedRows.Count > 0 Then
            Try
                _csnSelect = DgvConcessions.SelectedRows(0).DataBoundItem.Id
            Catch ex As Exception
                ChargerListe()
                ' (À FAIRE voir si recharger la liste vide/update les infos affichées)
                Exit Sub
            End Try

            ' affiche les infos




        End If
    End Sub

End Class
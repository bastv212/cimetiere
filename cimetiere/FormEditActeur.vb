﻿Public Class FormEditActeur
    ' modal
    Public IdActeur As Integer?     ' peut être utilisé comme valeur de retour pour renvoyer l'id de l'entité créée
    Private LActeur As Acteur
    Public Sub New(Optional idAct As Integer? = Nothing)
        ' This call is required by the designer.
        InitializeComponent()
        IdActeur = idAct
    End Sub

    Private Sub FormEditActeur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' édit ou nouveau ?
        If IdActeur IsNot Nothing Then
            Me.Text = "Modifier une entrée"
            LActeur = Bdd.Load(Of Acteur)(IdActeur)
            With LActeur
                TbPrenom.Value = .Prenom
                TbNom.Value = .Nom
                TbAdresse.Value = .Adresse
                TbVille.Value = .Ville
                TbCp.Value = .Cp
                TbPays.Value = .Pays
                TbTel.Value = .Tel
                MtbDateNaiss.DateValue = .DateNaiss
                TbNumRegistre.Value = .NoRegistre
            End With
        Else
            Me.Text = "Nouvelle entrée"
            LActeur = New Acteur
        End If
    End Sub
    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click
        With LActeur
            .Prenom = TbPrenom.Value
            .Nom = TbNom.Value
            .Adresse = TbAdresse.Value
            .Ville = TbVille.Value
            .Cp = TbCp.Value
            .Pays = TbPays.Value
            .Tel = TbTel.Value
            .DateNaiss = MtbDateNaiss.DateValue
            .NoRegistre = TbNumRegistre.Value
        End With
        Bdd.Save(LActeur)
        IdActeur = LActeur.Id '''''''' màj id sur save ???
    End Sub

End Class
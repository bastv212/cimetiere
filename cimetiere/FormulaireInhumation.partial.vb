Imports cimetiere

Public Class FormulaireInhumation
    Inherits IEntity
    Implements IEntityInterface
    Private Property InternId As Integer Implements IEntityInterface.Id
        Get
            Return Me.Id
        End Get
        Set(value As Integer)
            Me.Id = value
        End Set
    End Property



    Public Property FormNvCon As FormulaireNvConcession
        Get
            If FormsNvCon.Count <> 0 Then
                Return FormsNvCon(0)
            Else
                Return Nothing
            End If
        End Get
        Set(value As FormulaireNvConcession)
            FormsNvCon.Clear()
            FormsNvCon.Add(value)
        End Set
    End Property


    Public Sub IntegrerInfosDefunt(def As Defunt)
        With def
            DefNom = .Nom
            DefPrenom = .Prenom
            DefAdresse = .Adresse
            DefCp = .Cp
            DefVille = .Ville
            DefPays = .Pays
            DefEtatCivil = .EtatCivil
            DefEtatCivilDe = .EtatCivilDe
            DefDateNaiss = .DateNaiss
            DefLieuNaiss = .LieuNaiss
            DefDateDeces = .DateDeces
            DefLieuDeces = .LieuDeces
            If .NumeroAnnee IsNot Nothing Then NumDefAnnee = .NumeroAnnee
            If .NumeroLh IsNot Nothing Then NumDefLh = .NumeroLh
        End With
    End Sub

    Public Sub IntegrerInfosDemandeur(dem As Acteur)
        With dem
            DmdrNom = .Nom
            DmdrPrenom = .Prenom
            DmdrTel = .Tel
            DmdrAdresse = .Adresse
            DmdrVille = .Ville
            DmdrCp = .Cp
            DmdrPays = .Pays
        End With
    End Sub

End Class

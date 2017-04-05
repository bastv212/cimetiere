Public Class PopupRechercheDemandeur
    Inherits PopupRecherche

    Protected Overrides Property ListeValueMember As String = "Id"
    Protected Overrides Property ListeDisplayMember As String = "Nom"

    Public Sub New(Optional ActionSuite As Action(Of Object) = Nothing, Optional RechInit As String = "")
        MyBase.New(ActionSuite, RechInit)
    End Sub

    Protected Overrides Sub UpdateListe(texte As String)
        If texte.Equals("") Then
            Dim l = Bdd.GetCondenseActeurs
            ' cannot convert [automatiquement] List(Of Truc) to List(Of Object)
            Me.ElementsListe = l.ConvertAll(New Converter(Of IEntity.Condense, Object)(Function(x) New With {.Id = x.Id, .Nom = x.Nom}))

        Else
            Dim l = Bdd.ChercherActeurs(texte)
            Me.ElementsListe = l.ConvertAll(New Converter(Of IEntity.Condense, Object)(Function(x) New With {.Id = x.Id, .Nom = x.Nom}))
        End If
    End Sub
End Class
